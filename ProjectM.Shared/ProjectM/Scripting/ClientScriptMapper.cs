// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.ClientScriptMapper
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Physics;

#nullable disable
namespace ProjectM.Scripting
{
  public class ClientScriptMapper : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__EntityComponentsToAdd;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnFuncs;
    private static readonly System.IntPtr NativeFieldInfoPtr__UpdateFuncs;
    private static readonly System.IntPtr NativeFieldInfoPtr__AbilityCastEndedFuncs;
    private static readonly System.IntPtr NativeFieldInfoPtr__DestroyFuncs;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientGameManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__CollisionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__DistanceHits;
    private static readonly System.IntPtr NativeFieldInfoPtr__ColliderCastHits;
    private static readonly System.IntPtr NativeFieldInfoPtr__RayCastHits;
    private static readonly System.IntPtr NativeFieldInfoPtr__HitResults;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__Names;
    private static readonly System.IntPtr NativeFieldInfoPtr__HashedTypeToTypeLookup;
    private static readonly System.IntPtr NativeFieldInfoPtr__ModificationSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__DetectModificationLeaksSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ConditionCheckerFactory;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AssertHasDependencies_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallSpawnFuncs_Public_Void_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallUpdateFuncs_Public_Void_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallAbilityCastEndedFuncs_Public_Void_Entity_PrefabGUID_byref_AbilityCastEndedData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallDestroyFuncs_Public_Void_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetFunctions_Private_Void_String_Type_byref_RequiredScriptComponents_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterBaseClasses_Public_Void_Entity_PrefabGUID_NativeArray_1_HashedTypesBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterBaseClassesFromHotReload_Public_Void_Entity_PrefabGuidComponent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterType_Private_Void_Type_List_1_String_byref_RequiredScriptComponents_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrepareDependencies_Public_Void_EntityCommandBuffer_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeDependencies_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearBatchComponentTracker_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginBatchedAddComponents_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndBatchedAddComponents_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_RequiredScriptComponents_RequiredScriptComponents_NativeList_1_ComponentType_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772917, XrefRangeEnd = 773016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientScriptMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773016, XrefRangeEnd = 773031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientScriptMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 773031, RefRangeEnd = 773035, XrefRangeStart = 773031, XrefRangeEnd = 773031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AssertHasDependencies()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.NativeMethodInfoPtr_AssertHasDependencies_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 773050, RefRangeEnd = 773051, XrefRangeStart = 773035, XrefRangeEnd = 773050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallSpawnFuncs(Entity entity, PrefabGUID prefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.NativeMethodInfoPtr_CallSpawnFuncs_Public_Void_Entity_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 773066, RefRangeEnd = 773067, XrefRangeStart = 773051, XrefRangeEnd = 773066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallUpdateFuncs(Entity entity, PrefabGUID prefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.NativeMethodInfoPtr_CallUpdateFuncs_Public_Void_Entity_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 773082, RefRangeEnd = 773086, XrefRangeStart = 773067, XrefRangeEnd = 773082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallAbilityCastEndedFuncs(
      Entity targetEntity,
      PrefabGUID prefabGuid,
      [In] ref AbilityCastEndedData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &targetEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.NativeMethodInfoPtr_CallAbilityCastEndedFuncs_Public_Void_Entity_PrefabGUID_byref_AbilityCastEndedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 773101, RefRangeEnd = 773102, XrefRangeStart = 773086, XrefRangeEnd = 773101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CallDestroyFuncs(Entity entity, PrefabGUID prefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.NativeMethodInfoPtr_CallDestroyFuncs_Public_Void_Entity_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 773121, RefRangeEnd = 773123, XrefRangeStart = 773102, XrefRangeEnd = 773121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetFunctions(
      string name,
      Il2CppSystem.Type type,
      ref ClientScriptMapper.RequiredScriptComponents componentsToAdd)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref componentsToAdd;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.NativeMethodInfoPtr_SetFunctions_Private_Void_String_Type_byref_RequiredScriptComponents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 773180, RefRangeEnd = 773181, XrefRangeStart = 773123, XrefRangeEnd = 773180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterBaseClasses(
      Entity entity,
      PrefabGUID prefabGuid,
      NativeArray<HashedTypesBuffer> hashedTypes)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hashedTypes;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.NativeMethodInfoPtr_RegisterBaseClasses_Public_Void_Entity_PrefabGUID_NativeArray_1_HashedTypesBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773181, XrefRangeEnd = 773228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterBaseClassesFromHotReload(
      Entity entity,
      PrefabGuidComponent prefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabGuid);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.NativeMethodInfoPtr_RegisterBaseClassesFromHotReload_Public_Void_Entity_PrefabGuidComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 773243, RefRangeEnd = 773244, XrefRangeStart = 773228, XrefRangeEnd = 773243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterType(
      Il2CppSystem.Type parentType,
      List<string> names,
      ref ClientScriptMapper.RequiredScriptComponents componentsToAdd)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parentType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) names);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref componentsToAdd;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.NativeMethodInfoPtr_RegisterType_Private_Void_Type_List_1_String_byref_RequiredScriptComponents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773244, XrefRangeEnd = 773246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientScriptMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 773265, RefRangeEnd = 773269, XrefRangeStart = 773246, XrefRangeEnd = 773265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PrepareDependencies(
      EntityCommandBuffer spawnCommandBuffer,
      EntityCommandBuffer destroyCommandBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spawnCommandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &destroyCommandBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.NativeMethodInfoPtr_PrepareDependencies_Public_Void_EntityCommandBuffer_EntityCommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 773269, RefRangeEnd = 773273, XrefRangeStart = 773269, XrefRangeEnd = 773269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FinalizeDependencies()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.NativeMethodInfoPtr_FinalizeDependencies_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773273, XrefRangeEnd = 773286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Clear()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 773309, RefRangeEnd = 773313, XrefRangeStart = 773286, XrefRangeEnd = 773309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearBatchComponentTracker()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.NativeMethodInfoPtr_ClearBatchComponentTracker_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773313, XrefRangeEnd = 773314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BeginBatchedAddComponents()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.NativeMethodInfoPtr_BeginBatchedAddComponents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 773367, RefRangeEnd = 773368, XrefRangeStart = 773314, XrefRangeEnd = 773367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EndBatchedAddComponents()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.NativeMethodInfoPtr_EndBatchedAddComponents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773368, XrefRangeEnd = 773376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClientScriptMapper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773376, XrefRangeEnd = 773384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Internal_Static_Void_RequiredScriptComponents_RequiredScriptComponents_NativeList_1_ComponentType_PDM_0<T>(
      ClientScriptMapper.RequiredScriptComponents required,
      ClientScriptMapper.RequiredScriptComponents flags,
      NativeList<ComponentType> list)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &required;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &list;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.MethodInfoStoreGeneric_Method_Internal_Static_Void_RequiredScriptComponents_RequiredScriptComponents_NativeList_1_ComponentType_PDM_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientScriptMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClientScriptMapper()
    {
      Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (ClientScriptMapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr);
      ClientScriptMapper.NativeFieldInfoPtr__EntityComponentsToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, nameof (_EntityComponentsToAdd));
      ClientScriptMapper.NativeFieldInfoPtr__SpawnFuncs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, nameof (_SpawnFuncs));
      ClientScriptMapper.NativeFieldInfoPtr__UpdateFuncs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, nameof (_UpdateFuncs));
      ClientScriptMapper.NativeFieldInfoPtr__AbilityCastEndedFuncs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, nameof (_AbilityCastEndedFuncs));
      ClientScriptMapper.NativeFieldInfoPtr__DestroyFuncs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, nameof (_DestroyFuncs));
      ClientScriptMapper.NativeFieldInfoPtr__ClientGameManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, nameof (_ClientGameManager));
      ClientScriptMapper.NativeFieldInfoPtr__CollisionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, nameof (_CollisionSystem));
      ClientScriptMapper.NativeFieldInfoPtr__DistanceHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, nameof (_DistanceHits));
      ClientScriptMapper.NativeFieldInfoPtr__ColliderCastHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, nameof (_ColliderCastHits));
      ClientScriptMapper.NativeFieldInfoPtr__RayCastHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, nameof (_RayCastHits));
      ClientScriptMapper.NativeFieldInfoPtr__HitResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, nameof (_HitResults));
      ClientScriptMapper.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      ClientScriptMapper.NativeFieldInfoPtr__Names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, nameof (_Names));
      ClientScriptMapper.NativeFieldInfoPtr__HashedTypeToTypeLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, nameof (_HashedTypeToTypeLookup));
      ClientScriptMapper.NativeFieldInfoPtr__ModificationSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, nameof (_ModificationSystem));
      ClientScriptMapper.NativeFieldInfoPtr__DetectModificationLeaksSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, nameof (_DetectModificationLeaksSystem));
      ClientScriptMapper.NativeFieldInfoPtr__ConditionCheckerFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, nameof (_ConditionCheckerFactory));
      ClientScriptMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, 100668486);
      ClientScriptMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, 100668487);
      ClientScriptMapper.NativeMethodInfoPtr_AssertHasDependencies_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, 100668488);
      ClientScriptMapper.NativeMethodInfoPtr_CallSpawnFuncs_Public_Void_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, 100668489);
      ClientScriptMapper.NativeMethodInfoPtr_CallUpdateFuncs_Public_Void_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, 100668490);
      ClientScriptMapper.NativeMethodInfoPtr_CallAbilityCastEndedFuncs_Public_Void_Entity_PrefabGUID_byref_AbilityCastEndedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, 100668491);
      ClientScriptMapper.NativeMethodInfoPtr_CallDestroyFuncs_Public_Void_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, 100668492);
      ClientScriptMapper.NativeMethodInfoPtr_SetFunctions_Private_Void_String_Type_byref_RequiredScriptComponents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, 100668493);
      ClientScriptMapper.NativeMethodInfoPtr_RegisterBaseClasses_Public_Void_Entity_PrefabGUID_NativeArray_1_HashedTypesBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, 100668494);
      ClientScriptMapper.NativeMethodInfoPtr_RegisterBaseClassesFromHotReload_Public_Void_Entity_PrefabGuidComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, 100668495);
      ClientScriptMapper.NativeMethodInfoPtr_RegisterType_Private_Void_Type_List_1_String_byref_RequiredScriptComponents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, 100668496);
      ClientScriptMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, 100668497);
      ClientScriptMapper.NativeMethodInfoPtr_PrepareDependencies_Public_Void_EntityCommandBuffer_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, 100668498);
      ClientScriptMapper.NativeMethodInfoPtr_FinalizeDependencies_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, 100668499);
      ClientScriptMapper.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, 100668500);
      ClientScriptMapper.NativeMethodInfoPtr_ClearBatchComponentTracker_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, 100668501);
      ClientScriptMapper.NativeMethodInfoPtr_BeginBatchedAddComponents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, 100668502);
      ClientScriptMapper.NativeMethodInfoPtr_EndBatchedAddComponents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, 100668503);
      ClientScriptMapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, 100668504);
      ClientScriptMapper.NativeMethodInfoPtr_Method_Internal_Static_Void_RequiredScriptComponents_RequiredScriptComponents_NativeList_1_ComponentType_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, 100668505);
      ClientScriptMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, 100668506);
    }

    public ClientScriptMapper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Dictionary<ClientScriptMapper.RequiredScriptComponents, NativeList<Entity>> _EntityComponentsToAdd
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__EntityComponentsToAdd));
        return pointer == System.IntPtr.Zero ? (Dictionary<ClientScriptMapper.RequiredScriptComponents, NativeList<Entity>>) null : new Dictionary<ClientScriptMapper.RequiredScriptComponents, NativeList<Entity>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__EntityComponentsToAdd), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameFunction<ClientScriptMapper.SpawnDelegate> _SpawnFuncs
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__SpawnFuncs));
        return pointer == System.IntPtr.Zero ? (GameFunction<ClientScriptMapper.SpawnDelegate>) null : new GameFunction<ClientScriptMapper.SpawnDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__SpawnFuncs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameFunction<ClientScriptMapper.UpdateDelegate> _UpdateFuncs
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__UpdateFuncs));
        return pointer == System.IntPtr.Zero ? (GameFunction<ClientScriptMapper.UpdateDelegate>) null : new GameFunction<ClientScriptMapper.UpdateDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__UpdateFuncs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameFunction<ClientScriptMapper.AbilityCastEndedCallbackDelegate> _AbilityCastEndedFuncs
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__AbilityCastEndedFuncs));
        return pointer == System.IntPtr.Zero ? (GameFunction<ClientScriptMapper.AbilityCastEndedCallbackDelegate>) null : new GameFunction<ClientScriptMapper.AbilityCastEndedCallbackDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__AbilityCastEndedFuncs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameFunction<ClientScriptMapper.DestroyDelegate> _DestroyFuncs
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__DestroyFuncs));
        return pointer == System.IntPtr.Zero ? (GameFunction<ClientScriptMapper.DestroyDelegate>) null : new GameFunction<ClientScriptMapper.DestroyDelegate>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__DestroyFuncs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClientGameManager _ClientGameManager
    {
      get
      {
        return *(ClientGameManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__ClientGameManager));
      }
      [param: In] set
      {
        *(ClientGameManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__ClientGameManager)) = value;
      }
    }

    public unsafe CollisionSystem _CollisionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__CollisionSystem));
        return pointer == System.IntPtr.Zero ? (CollisionSystem) null : new CollisionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__CollisionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<DistanceHit> _DistanceHits
    {
      get
      {
        return *(NativeList<DistanceHit>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__DistanceHits));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__DistanceHits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<DistanceHit>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<ColliderCastHit> _ColliderCastHits
    {
      get
      {
        return *(NativeList<ColliderCastHit>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__ColliderCastHits));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__ColliderCastHits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ColliderCastHit>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<RaycastHit> _RayCastHits
    {
      get
      {
        return *(NativeList<RaycastHit>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__RayCastHits));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__RayCastHits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<RaycastHit>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<HitResult> _HitResults
    {
      get
      {
        return *(NativeList<HitResult>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__HitResults));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__HitResults), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<HitResult>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<string> _Names
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__Names));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__Names), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<int, Il2CppSystem.Type> _HashedTypeToTypeLookup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__HashedTypeToTypeLookup));
        return pointer == System.IntPtr.Zero ? (Dictionary<int, Il2CppSystem.Type>) null : new Dictionary<int, Il2CppSystem.Type>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__HashedTypeToTypeLookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ModificationSystem _ModificationSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__ModificationSystem));
        return pointer == System.IntPtr.Zero ? (ModificationSystem) null : new ModificationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__ModificationSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DetectModificationLeaksSystem _DetectModificationLeaksSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__DetectModificationLeaksSystem));
        return pointer == System.IntPtr.Zero ? (DetectModificationLeaksSystem) null : new DetectModificationLeaksSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__DetectModificationLeaksSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ConditionCheckerFactory _ConditionCheckerFactory
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__ConditionCheckerFactory));
        return pointer == System.IntPtr.Zero ? (ConditionCheckerFactory) null : new ConditionCheckerFactory(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientScriptMapper.NativeFieldInfoPtr__ConditionCheckerFactory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Flags]
    public enum RequiredScriptComponents
    {
      None = 0,
      ScriptSpawn = 1,
      ScriptDestroy = 2,
      ScriptUpdate = 4,
      RunScriptOnCastEnded = 8,
    }

    public sealed class SpawnDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ClientGameManager_byref_SelfClient_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SpawnDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientScriptMapper.SpawnDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.SpawnDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 691761, RefRangeEnd = 691772, XrefRangeStart = 691761, XrefRangeEnd = 691772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(ref ClientGameManager manager, [In] ref SelfClient self)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref manager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.SpawnDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772886, XrefRangeEnd = 772893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ClientGameManager manager,
        [In] ref SelfClient self,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref manager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.SpawnDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ClientGameManager_byref_SelfClient_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ClientGameManager manager,
        [In] ref SelfClient self,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref manager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.SpawnDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SpawnDelegate()
      {
        Il2CppClassPointerStore<ClientScriptMapper.SpawnDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, nameof (SpawnDelegate));
        ClientScriptMapper.SpawnDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper.SpawnDelegate>.NativeClassPtr, 100668507);
        ClientScriptMapper.SpawnDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper.SpawnDelegate>.NativeClassPtr, 100668508);
        ClientScriptMapper.SpawnDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ClientGameManager_byref_SelfClient_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper.SpawnDelegate>.NativeClassPtr, 100668509);
        ClientScriptMapper.SpawnDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper.SpawnDelegate>.NativeClassPtr, 100668510);
      }

      public SpawnDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class UpdateDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ClientGameManager_byref_SelfClient_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe UpdateDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientScriptMapper.UpdateDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.UpdateDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 691761, RefRangeEnd = 691772, XrefRangeStart = 691761, XrefRangeEnd = 691772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(ref ClientGameManager manager, [In] ref SelfClient self)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref manager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.UpdateDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772893, XrefRangeEnd = 772900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ClientGameManager manager,
        [In] ref SelfClient self,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref manager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.UpdateDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ClientGameManager_byref_SelfClient_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ClientGameManager manager,
        [In] ref SelfClient self,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref manager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.UpdateDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static UpdateDelegate()
      {
        Il2CppClassPointerStore<ClientScriptMapper.UpdateDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, nameof (UpdateDelegate));
        ClientScriptMapper.UpdateDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper.UpdateDelegate>.NativeClassPtr, 100668511);
        ClientScriptMapper.UpdateDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper.UpdateDelegate>.NativeClassPtr, 100668512);
        ClientScriptMapper.UpdateDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ClientGameManager_byref_SelfClient_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper.UpdateDelegate>.NativeClassPtr, 100668513);
        ClientScriptMapper.UpdateDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper.UpdateDelegate>.NativeClassPtr, 100668514);
      }

      public UpdateDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class AbilityCastEndedCallbackDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_byref_AbilityCastEndedData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ClientGameManager_byref_SelfClient_byref_AbilityCastEndedData_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_byref_AbilityCastEndedData_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe AbilityCastEndedCallbackDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientScriptMapper.AbilityCastEndedCallbackDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.AbilityCastEndedCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 383532, RefRangeEnd = 383539, XrefRangeStart = 383532, XrefRangeEnd = 383539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(
        ref ClientGameManager game,
        [In] ref SelfClient self,
        [In] ref AbilityCastEndedData data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.AbilityCastEndedCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_byref_AbilityCastEndedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772900, XrefRangeEnd = 772910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ClientGameManager game,
        [In] ref SelfClient self,
        [In] ref AbilityCastEndedData data,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.AbilityCastEndedCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ClientGameManager_byref_SelfClient_byref_AbilityCastEndedData_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ClientGameManager game,
        [In] ref SelfClient self,
        [In] ref AbilityCastEndedData data,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.AbilityCastEndedCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_byref_AbilityCastEndedData_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static AbilityCastEndedCallbackDelegate()
      {
        Il2CppClassPointerStore<ClientScriptMapper.AbilityCastEndedCallbackDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, nameof (AbilityCastEndedCallbackDelegate));
        ClientScriptMapper.AbilityCastEndedCallbackDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper.AbilityCastEndedCallbackDelegate>.NativeClassPtr, 100668515);
        ClientScriptMapper.AbilityCastEndedCallbackDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_byref_AbilityCastEndedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper.AbilityCastEndedCallbackDelegate>.NativeClassPtr, 100668516);
        ClientScriptMapper.AbilityCastEndedCallbackDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ClientGameManager_byref_SelfClient_byref_AbilityCastEndedData_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper.AbilityCastEndedCallbackDelegate>.NativeClassPtr, 100668517);
        ClientScriptMapper.AbilityCastEndedCallbackDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_byref_AbilityCastEndedData_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper.AbilityCastEndedCallbackDelegate>.NativeClassPtr, 100668518);
      }

      public AbilityCastEndedCallbackDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public sealed class DestroyDelegate : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ClientGameManager_byref_SelfClient_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe DestroyDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientScriptMapper.DestroyDelegate>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.DestroyDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 691761, RefRangeEnd = 691772, XrefRangeStart = 691761, XrefRangeEnd = 691772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Invoke(ref ClientGameManager manager, [In] ref SelfClient self)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref manager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.DestroyDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772910, XrefRangeEnd = 772917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref ClientGameManager manager,
        [In] ref SelfClient self,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref manager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.DestroyDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ClientGameManager_byref_SelfClient_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void EndInvoke(
        ref ClientGameManager manager,
        [In] ref SelfClient self,
        Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref manager;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ClientScriptMapper.DestroyDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static DestroyDelegate()
      {
        Il2CppClassPointerStore<ClientScriptMapper.DestroyDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr, nameof (DestroyDelegate));
        ClientScriptMapper.DestroyDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper.DestroyDelegate>.NativeClassPtr, 100668519);
        ClientScriptMapper.DestroyDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper.DestroyDelegate>.NativeClassPtr, 100668520);
        ClientScriptMapper.DestroyDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_ClientGameManager_byref_SelfClient_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper.DestroyDelegate>.NativeClassPtr, 100668521);
        ClientScriptMapper.DestroyDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_ClientGameManager_byref_SelfClient_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientScriptMapper.DestroyDelegate>.NativeClassPtr, 100668522);
      }

      public DestroyDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    private sealed class MethodInfoStoreGeneric_Method_Internal_Static_Void_RequiredScriptComponents_RequiredScriptComponents_NativeList_1_ComponentType_PDM_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ClientScriptMapper.NativeMethodInfoPtr_Method_Internal_Static_Void_RequiredScriptComponents_RequiredScriptComponents_NativeList_1_ComponentType_PDM_0, Il2CppClassPointerStore<ClientScriptMapper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
