// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HybridModelSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Transforms;
using UnityEngine;

#nullable disable
namespace ProjectM.Hybrid
{
  public class HybridModelSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GenderCollectionGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr__RemoveModelQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__UpdateModelQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__InstantiatedModels;
    private static readonly System.IntPtr NativeFieldInfoPtr__EntityToGameObject;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__GenderCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr__EyeColorCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr__HybridModelPool;
    private static readonly System.IntPtr NativeFieldInfoPtr__ModelStreaming;
    private static readonly System.IntPtr NativeFieldInfoPtr__ModelParent;
    private static readonly System.IntPtr NativeFieldInfoPtr__ForceReInstantiateOfAllModels;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowInsideRangeSq;
    private static readonly System.IntPtr NativeFieldInfoPtr_RemoveAfterTimeNotSeen;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastImportedAssetsCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr___CheckHiddenModels_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CheckHiddenModels_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___FindClosestModelToSpawn_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___FindClosestModelToSpawn_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_65;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveModelCount_Public_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntityToGameObjectMap_Public_Dictionary_2_Entity_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearModelPoolAndInstances_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateGenderCollection_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateModels_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddModels_Private_Void_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetUsedAsset_Private_Void_byref_AssetReferenceToken_AssetGuid_GameObject_byref_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessInstanceClothSettings_Public_Static_Void_GameObject_Byte_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateHybridEntity_Private_Entity_Entity_GameObject_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveModels_Private_Void_EntityQuery_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveModel_Private_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpInfo_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCheckHiddenModels_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForFindClosestModelToSpawn_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1159803, RefRangeEnd = 1159806, XrefRangeStart = 1159799, XrefRangeEnd = 1159803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetActiveModelCount()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.NativeMethodInfoPtr_GetActiveModelCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 22805, RefRangeEnd = 22806, XrefRangeStart = 22805, XrefRangeEnd = 22806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Dictionary<Entity, GameObject> GetEntityToGameObjectMap()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.NativeMethodInfoPtr_GetEntityToGameObjectMap_Public_Dictionary_2_Entity_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<Entity, GameObject>) null : new Dictionary<Entity, GameObject>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159806, XrefRangeEnd = 1159971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HybridModelSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159971, XrefRangeEnd = 1159974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearModelPoolAndInstances()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.NativeMethodInfoPtr_ClearModelPoolAndInstances_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159974, XrefRangeEnd = 1159983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HybridModelSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159983, XrefRangeEnd = 1160032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HybridModelSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160032, XrefRangeEnd = 1160045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateGenderCollection()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.NativeMethodInfoPtr_UpdateGenderCollection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1160058, RefRangeEnd = 1160059, XrefRangeStart = 1160045, XrefRangeEnd = 1160058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateModels()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.NativeMethodInfoPtr_UpdateModels_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1160213, RefRangeEnd = 1160214, XrefRangeStart = 1160059, XrefRangeEnd = 1160213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddModels(float3 localUserPosition)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &localUserPosition;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.NativeMethodInfoPtr_AddModels_Private_Void_float3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1160238, RefRangeEnd = 1160240, XrefRangeStart = 1160214, XrefRangeEnd = 1160238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetUsedAsset(
      ref AssetReferenceToken activeToken,
      AssetGuid requestedGuid,
      GameObject hardPrefab,
      out GameObject loadedAsset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      numPtr1[0] = (System.IntPtr) ref activeToken;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &requestedGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hardPrefab);
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.NativeMethodInfoPtr_SetUsedAsset_Private_Void_byref_AssetReferenceToken_AssetGuid_GameObject_byref_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref GameObject local = ref loadedAsset;
      System.IntPtr pointer = zero;
      GameObject gameObject = pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      local = gameObject;
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1160261, RefRangeEnd = 1160263, XrefRangeStart = 1160240, XrefRangeEnd = 1160261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ProcessInstanceClothSettings(
      GameObject instance,
      byte globalClothQualityFlag,
      bool isLocalCharacter)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) instance);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &globalClothQualityFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isLocalCharacter;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.NativeMethodInfoPtr_ProcessInstanceClothSettings_Public_Static_Void_GameObject_Byte_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1160295, RefRangeEnd = 1160296, XrefRangeStart = 1160263, XrefRangeEnd = 1160295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity CreateHybridEntity(Entity forEntity, GameObject go, int modelIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &forEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) go);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &modelIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.NativeMethodInfoPtr_CreateHybridEntity_Private_Entity_Entity_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1160306, RefRangeEnd = 1160311, XrefRangeStart = 1160296, XrefRangeEnd = 1160306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveModels(EntityQuery query)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &query;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.NativeMethodInfoPtr_RemoveModels_Private_Void_EntityQuery_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1160357, RefRangeEnd = 1160359, XrefRangeStart = 1160311, XrefRangeEnd = 1160357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveModel(Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.NativeMethodInfoPtr_RemoveModel_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1160430, RefRangeEnd = 1160431, XrefRangeStart = 1160359, XrefRangeEnd = 1160430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DumpInfo()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.NativeMethodInfoPtr_DumpInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HybridModelSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160431, XrefRangeEnd = 1160472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HybridModelSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1160494, RefRangeEnd = 1160495, XrefRangeStart = 1160472, XrefRangeEnd = 1160494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCheckHiddenModels_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.NativeMethodInfoPtr___GetEntityQuery_ForCheckHiddenModels_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1160520, RefRangeEnd = 1160521, XrefRangeStart = 1160495, XrefRangeEnd = 1160520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForFindClosestModelToSpawn_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.NativeMethodInfoPtr___GetEntityQuery_ForFindClosestModelToSpawn_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1160525, RefRangeEnd = 1160526, XrefRangeStart = 1160521, XrefRangeEnd = 1160525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1160530, RefRangeEnd = 1160531, XrefRangeStart = 1160526, XrefRangeEnd = 1160530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HybridModelSystem()
    {
      Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (HybridModelSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr);
      HybridModelSystem.NativeFieldInfoPtr_GenderCollectionGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, nameof (GenderCollectionGUID));
      HybridModelSystem.NativeFieldInfoPtr__RemoveModelQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, nameof (_RemoveModelQuery));
      HybridModelSystem.NativeFieldInfoPtr__UpdateModelQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, nameof (_UpdateModelQuery));
      HybridModelSystem.NativeFieldInfoPtr__InstantiatedModels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, nameof (_InstantiatedModels));
      HybridModelSystem.NativeFieldInfoPtr__EntityToGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, nameof (_EntityToGameObject));
      HybridModelSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      HybridModelSystem.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, nameof (_CommonClientDataSystem));
      HybridModelSystem.NativeFieldInfoPtr__GenderCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, nameof (_GenderCollection));
      HybridModelSystem.NativeFieldInfoPtr__EyeColorCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, nameof (_EyeColorCollection));
      HybridModelSystem.NativeFieldInfoPtr__HybridModelPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, nameof (_HybridModelPool));
      HybridModelSystem.NativeFieldInfoPtr__ModelStreaming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, nameof (_ModelStreaming));
      HybridModelSystem.NativeFieldInfoPtr__ModelParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, nameof (_ModelParent));
      HybridModelSystem.NativeFieldInfoPtr__ForceReInstantiateOfAllModels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, nameof (_ForceReInstantiateOfAllModels));
      HybridModelSystem.NativeFieldInfoPtr_ShowInsideRangeSq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, nameof (ShowInsideRangeSq));
      HybridModelSystem.NativeFieldInfoPtr_RemoveAfterTimeNotSeen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, nameof (RemoveAfterTimeNotSeen));
      HybridModelSystem.NativeFieldInfoPtr_LastImportedAssetsCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, nameof (LastImportedAssetsCounter));
      HybridModelSystem.NativeFieldInfoPtr___CheckHiddenModels_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, "<>CheckHiddenModels_entityQuery");
      HybridModelSystem.NativeFieldInfoPtr___CheckHiddenModels_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, "<>CheckHiddenModels_profilerMarker");
      HybridModelSystem.NativeFieldInfoPtr___FindClosestModelToSpawn_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, "<>FindClosestModelToSpawn_entityQuery");
      HybridModelSystem.NativeFieldInfoPtr___FindClosestModelToSpawn_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, "<>FindClosestModelToSpawn_profilerMarker");
      HybridModelSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_65 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_LocalCharacter_65));
      HybridModelSystem.NativeMethodInfoPtr_GetActiveModelCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, 100692174);
      HybridModelSystem.NativeMethodInfoPtr_GetEntityToGameObjectMap_Public_Dictionary_2_Entity_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, 100692175);
      HybridModelSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, 100692176);
      HybridModelSystem.NativeMethodInfoPtr_ClearModelPoolAndInstances_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, 100692177);
      HybridModelSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, 100692178);
      HybridModelSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, 100692179);
      HybridModelSystem.NativeMethodInfoPtr_UpdateGenderCollection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, 100692180);
      HybridModelSystem.NativeMethodInfoPtr_UpdateModels_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, 100692181);
      HybridModelSystem.NativeMethodInfoPtr_AddModels_Private_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, 100692182);
      HybridModelSystem.NativeMethodInfoPtr_SetUsedAsset_Private_Void_byref_AssetReferenceToken_AssetGuid_GameObject_byref_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, 100692183);
      HybridModelSystem.NativeMethodInfoPtr_ProcessInstanceClothSettings_Public_Static_Void_GameObject_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, 100692184);
      HybridModelSystem.NativeMethodInfoPtr_CreateHybridEntity_Private_Entity_Entity_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, 100692185);
      HybridModelSystem.NativeMethodInfoPtr_RemoveModels_Private_Void_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, 100692186);
      HybridModelSystem.NativeMethodInfoPtr_RemoveModel_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, 100692187);
      HybridModelSystem.NativeMethodInfoPtr_DumpInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, 100692188);
      HybridModelSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, 100692189);
      HybridModelSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, 100692190);
      HybridModelSystem.NativeMethodInfoPtr___GetEntityQuery_ForCheckHiddenModels_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, 100692191);
      HybridModelSystem.NativeMethodInfoPtr___GetEntityQuery_ForFindClosestModelToSpawn_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, 100692192);
      HybridModelSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, 100692193);
      HybridModelSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, 100692194);
    }

    public HybridModelSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGUID GenderCollectionGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr_GenderCollectionGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr_GenderCollectionGUID)) = value;
      }
    }

    public unsafe EntityQuery _RemoveModelQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__RemoveModelQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__RemoveModelQuery)) = value;
      }
    }

    public unsafe EntityQuery _UpdateModelQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__UpdateModelQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__UpdateModelQuery)) = value;
      }
    }

    public unsafe EntityQuery _InstantiatedModels
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__InstantiatedModels));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__InstantiatedModels)) = value;
      }
    }

    public unsafe Dictionary<Entity, GameObject> _EntityToGameObject
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__EntityToGameObject));
        return pointer == System.IntPtr.Zero ? (Dictionary<Entity, GameObject>) null : new Dictionary<Entity, GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__EntityToGameObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FeaturesCollection _GenderCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__GenderCollection));
        return pointer == System.IntPtr.Zero ? (FeaturesCollection) null : new FeaturesCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__GenderCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ColorCollection _EyeColorCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__EyeColorCollection));
        return pointer == System.IntPtr.Zero ? (ColorCollection) null : new ColorCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__EyeColorCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HybridModelPool _HybridModelPool
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__HybridModelPool));
        return pointer == System.IntPtr.Zero ? (HybridModelPool) null : new HybridModelPool(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__HybridModelPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HybridModelStreamingHandler _ModelStreaming
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__ModelStreaming));
        return pointer == System.IntPtr.Zero ? (HybridModelStreamingHandler) null : new HybridModelStreamingHandler(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__ModelStreaming), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform _ModelParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__ModelParent));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__ModelParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _ForceReInstantiateOfAllModels
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__ForceReInstantiateOfAllModels));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__ForceReInstantiateOfAllModels)) = value;
      }
    }

    public static unsafe float ShowInsideRangeSq
    {
      get
      {
        float showInsideRangeSq;
        IL2CPP.il2cpp_field_static_get_value(HybridModelSystem.NativeFieldInfoPtr_ShowInsideRangeSq, (void*) &showInsideRangeSq);
        return showInsideRangeSq;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HybridModelSystem.NativeFieldInfoPtr_ShowInsideRangeSq, (void*) &value);
      }
    }

    public static unsafe float RemoveAfterTimeNotSeen
    {
      get
      {
        float afterTimeNotSeen;
        IL2CPP.il2cpp_field_static_get_value(HybridModelSystem.NativeFieldInfoPtr_RemoveAfterTimeNotSeen, (void*) &afterTimeNotSeen);
        return afterTimeNotSeen;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HybridModelSystem.NativeFieldInfoPtr_RemoveAfterTimeNotSeen, (void*) &value);
      }
    }

    public unsafe int LastImportedAssetsCounter
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr_LastImportedAssetsCounter));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr_LastImportedAssetsCounter)) = value;
      }
    }

    public unsafe EntityQuery __CheckHiddenModels_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr___CheckHiddenModels_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr___CheckHiddenModels_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CheckHiddenModels_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr___CheckHiddenModels_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr___CheckHiddenModels_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __FindClosestModelToSpawn_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr___FindClosestModelToSpawn_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr___FindClosestModelToSpawn_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __FindClosestModelToSpawn_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr___FindClosestModelToSpawn_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr___FindClosestModelToSpawn_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_LocalCharacter_65
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_65));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_65)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Hybrid.HybridModelSystem/<>c__DisplayClass21_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass21_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_localUserPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_entitiesToRemoveBecauseHidden;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_HybridModelUser_byref_Hideable_byref_Translation_0;
      [FieldOffset(0)]
      public float3 localUserPosition;
      [FieldOffset(12)]
      public float deltaTime;
      [FieldOffset(16)]
      public NativeList<Entity> entitiesToRemoveBecauseHidden;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass21_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref HybridModelUser hybridModelUser,
        [In] ref Hideable hideable,
        [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hybridModelUser;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref hideable;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass21_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_HybridModelUser_byref_Hideable_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass21_0()
      {
        Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, "<>c__DisplayClass21_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass21_0>.NativeClassPtr);
        HybridModelSystem.__c__DisplayClass21_0.NativeFieldInfoPtr_localUserPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass21_0>.NativeClassPtr, nameof (localUserPosition));
        HybridModelSystem.__c__DisplayClass21_0.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass21_0>.NativeClassPtr, nameof (deltaTime));
        HybridModelSystem.__c__DisplayClass21_0.NativeFieldInfoPtr_entitiesToRemoveBecauseHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass21_0>.NativeClassPtr, nameof (entitiesToRemoveBecauseHidden));
        HybridModelSystem.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass21_0>.NativeClassPtr, 100692195);
        HybridModelSystem.__c__DisplayClass21_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_HybridModelUser_byref_Hideable_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass21_0>.NativeClassPtr, 100692196);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass21_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Hybrid.HybridModelSystem/<>c__DisplayClass24_0")]
    public sealed class __c__DisplayClass24_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_localUserPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_closestDistanceSq;
      private static readonly System.IntPtr NativeFieldInfoPtr_hybridModelToInstantiate;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddModels_b__0_Internal_Void_Entity_byref_Translation_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass24_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass24_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AddModels_b__0(Entity entity, [In] ref Translation translation)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__AddModels_b__0_Internal_Void_Entity_byref_Translation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass24_0()
      {
        Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, "<>c__DisplayClass24_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass24_0>.NativeClassPtr);
        HybridModelSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_localUserPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass24_0>.NativeClassPtr, nameof (localUserPosition));
        HybridModelSystem.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass24_0>.NativeClassPtr, "<>4__this");
        HybridModelSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_closestDistanceSq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass24_0>.NativeClassPtr, nameof (closestDistanceSq));
        HybridModelSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_hybridModelToInstantiate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass24_0>.NativeClassPtr, nameof (hybridModelToInstantiate));
        HybridModelSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass24_0>.NativeClassPtr, 100692197);
        HybridModelSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__AddModels_b__0_Internal_Void_Entity_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass24_0>.NativeClassPtr, 100692198);
      }

      public __c__DisplayClass24_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass24_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass24_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass24_0>.NativeClassPtr, data));
      }

      public unsafe float3 localUserPosition
      {
        get
        {
          return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_localUserPosition));
        }
        [param: In] set
        {
          *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_localUserPosition)) = value;
        }
      }

      public unsafe HybridModelSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (HybridModelSystem) null : new HybridModelSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float closestDistanceSq
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_closestDistanceSq));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_closestDistanceSq)) = value;
        }
      }

      public unsafe Entity hybridModelToInstantiate
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_hybridModelToInstantiate));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_hybridModelToInstantiate)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Hybrid.HybridModelSystem/ProjectM.Hybrid.<>c__DisplayClass_CheckHiddenModels")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CheckHiddenModels
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_localUserPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_entitiesToRemoveBecauseHidden;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_HybridModelUser_byref_Hideable_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HybridModelSystem_byref___c__DisplayClass21_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public float3 localUserPosition;
      [FieldOffset(12)]
      public float deltaTime;
      [FieldOffset(16)]
      public NativeList<Entity> entitiesToRemoveBecauseHidden;
      [FieldOffset(32)]
      public HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(136)]
      public unsafe HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157781, XrefRangeEnd = 1157785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref HybridModelUser hybridModelUser,
        [In] ref Hideable hideable,
        [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hybridModelUser;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref hideable;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_HybridModelUser_byref_Hideable_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1157785, RefRangeEnd = 1157786, XrefRangeStart = 1157785, XrefRangeEnd = 1157785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref HybridModelSystem.__c__DisplayClass21_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1157786, RefRangeEnd = 1157787, XrefRangeStart = 1157786, XrefRangeEnd = 1157786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref HybridModelSystem.__c__DisplayClass21_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157787, XrefRangeEnd = 1157789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1157801, RefRangeEnd = 1157802, XrefRangeStart = 1157789, XrefRangeEnd = 1157801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1157804, RefRangeEnd = 1157805, XrefRangeStart = 1157802, XrefRangeEnd = 1157804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        HybridModelSystem componentSystem,
        ref HybridModelSystem.__c__DisplayClass21_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HybridModelSystem_byref___c__DisplayClass21_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157805, XrefRangeEnd = 1157809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157809, XrefRangeEnd = 1157815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CheckHiddenModels()
      {
        Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, "<>c__DisplayClass_CheckHiddenModels");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels>.NativeClassPtr);
        HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeFieldInfoPtr_localUserPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels>.NativeClassPtr, nameof (localUserPosition));
        HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels>.NativeClassPtr, nameof (deltaTime));
        HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeFieldInfoPtr_entitiesToRemoveBecauseHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels>.NativeClassPtr, nameof (entitiesToRemoveBecauseHidden));
        HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels>.NativeClassPtr, nameof (_runtimes));
        HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_HybridModelUser_byref_Hideable_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels>.NativeClassPtr, 100692199);
        HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels>.NativeClassPtr, 100692200);
        HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass21_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels>.NativeClassPtr, 100692201);
        HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels>.NativeClassPtr, 100692202);
        HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels>.NativeClassPtr, 100692203);
        HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HybridModelSystem_byref___c__DisplayClass21_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels>.NativeClassPtr, 100692204);
        HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels>.NativeClassPtr, 100692205);
        HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels>.NativeClassPtr, 100692206);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_hybridModelUser;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_hideable;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HybridModelSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<HybridModelUser> forParameter_hybridModelUser;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Hideable> forParameter_hideable;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1157694, RefRangeEnd = 1157695, XrefRangeStart = 1157684, XrefRangeEnd = 1157694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(HybridModelSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HybridModelSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1157705, RefRangeEnd = 1157706, XrefRangeStart = 1157695, XrefRangeEnd = 1157705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_hybridModelUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_hybridModelUser));
          HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_hideable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_hideable));
          HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HybridModelSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders>.NativeClassPtr, 100692207);
          HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders>.NativeClassPtr, 100692208);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_hybridModelUser;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_hideable;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<HybridModelUser>.Runtime runtime_hybridModelUser;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Hideable>.Runtime runtime_hideable;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;

          static Runtimes()
          {
            Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hybridModelUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_hybridModelUser));
            HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hideable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_hideable));
            HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Hybrid.HybridModelSystem/ProjectM.Hybrid.<>c__DisplayClass_CheckHiddenModels/ProjectM.Hybrid.RunWithoutJobSystem_000063AF$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels>.NativeClassPtr, "RunWithoutJobSystem_000063AF$PostfixBurstDelegate");
          HybridModelSystem.__c__DisplayClass_CheckHiddenModels.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100692209);
          HybridModelSystem.__c__DisplayClass_CheckHiddenModels.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100692210);
          HybridModelSystem.__c__DisplayClass_CheckHiddenModels.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100692211);
          HybridModelSystem.__c__DisplayClass_CheckHiddenModels.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100692212);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Hybrid.HybridModelSystem/ProjectM.Hybrid.<>c__DisplayClass_CheckHiddenModels/ProjectM.Hybrid.RunWithoutJobSystem_000063AF$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157706, XrefRangeEnd = 1157720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157720, XrefRangeEnd = 1157738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157738, XrefRangeEnd = 1157753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1157780, RefRangeEnd = 1157781, XrefRangeStart = 1157753, XrefRangeEnd = 1157780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels>.NativeClassPtr, "RunWithoutJobSystem_000063AF$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100692213);
          HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100692214);
          HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100692215);
          HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100692216);
          HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100692218);
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
            IL2CPP.il2cpp_field_static_get_value(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(HybridModelSystem.__c__DisplayClass_CheckHiddenModels.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Hybrid.HybridModelSystem/ProjectM.Hybrid.<>c__DisplayClass_FindClosestModelToSpawn")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_FindClosestModelToSpawn
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_localUserPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_closestDistanceSq;
      private static readonly System.IntPtr NativeFieldInfoPtr_hybridModelToInstantiate;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Hideable_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HybridModelSystem_byref___c__DisplayClass24_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public float3 localUserPosition;
      [FieldOffset(12)]
      public float closestDistanceSq;
      [FieldOffset(16)]
      public Entity hybridModelToInstantiate;
      [FieldOffset(24)]
      public ComponentDataFromEntity<Hideable> _ComponentDataFromEntity_Hideable_0;
      [FieldOffset(56)]
      public HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(96)]
      public unsafe HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159766, XrefRangeEnd = 1159772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1159772, RefRangeEnd = 1159773, XrefRangeStart = 1159772, XrefRangeEnd = 1159772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref HybridModelSystem.__c__DisplayClass24_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1159773, RefRangeEnd = 1159774, XrefRangeStart = 1159773, XrefRangeEnd = 1159773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref HybridModelSystem.__c__DisplayClass24_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159774, XrefRangeEnd = 1159776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1159782, RefRangeEnd = 1159783, XrefRangeStart = 1159776, XrefRangeEnd = 1159782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1159788, RefRangeEnd = 1159789, XrefRangeStart = 1159783, XrefRangeEnd = 1159788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        HybridModelSystem componentSystem,
        ref HybridModelSystem.__c__DisplayClass24_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HybridModelSystem_byref___c__DisplayClass24_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159789, XrefRangeEnd = 1159793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159793, XrefRangeEnd = 1159799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_FindClosestModelToSpawn()
      {
        Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridModelSystem>.NativeClassPtr, "<>c__DisplayClass_FindClosestModelToSpawn");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn>.NativeClassPtr);
        HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeFieldInfoPtr_localUserPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn>.NativeClassPtr, nameof (localUserPosition));
        HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeFieldInfoPtr_closestDistanceSq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn>.NativeClassPtr, nameof (closestDistanceSq));
        HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeFieldInfoPtr_hybridModelToInstantiate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn>.NativeClassPtr, nameof (hybridModelToInstantiate));
        HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeFieldInfoPtr__ComponentDataFromEntity_Hideable_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn>.NativeClassPtr, nameof (_ComponentDataFromEntity_Hideable_0));
        HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn>.NativeClassPtr, nameof (_runtimes));
        HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn>.NativeClassPtr, 100692219);
        HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn>.NativeClassPtr, 100692220);
        HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn>.NativeClassPtr, 100692221);
        HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn>.NativeClassPtr, 100692222);
        HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn>.NativeClassPtr, 100692223);
        HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HybridModelSystem_byref___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn>.NativeClassPtr, 100692224);
        HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn>.NativeClassPtr, 100692225);
        HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn>.NativeClassPtr, 100692226);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HybridModelSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1157819, RefRangeEnd = 1157820, XrefRangeStart = 1157815, XrefRangeEnd = 1157819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(HybridModelSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HybridModelSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1157824, RefRangeEnd = 1157825, XrefRangeStart = 1157820, XrefRangeEnd = 1157824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HybridModelSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders>.NativeClassPtr, 100692227);
          HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders>.NativeClassPtr, 100692228);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;

          static Runtimes()
          {
            Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Hybrid.HybridModelSystem/ProjectM.Hybrid.<>c__DisplayClass_FindClosestModelToSpawn/ProjectM.Hybrid.RunWithoutJobSystem_000063B8$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn>.NativeClassPtr, "RunWithoutJobSystem_000063B8$PostfixBurstDelegate");
          HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100692229);
          HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100692230);
          HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100692231);
          HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100692232);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Hybrid.HybridModelSystem/ProjectM.Hybrid.<>c__DisplayClass_FindClosestModelToSpawn/ProjectM.Hybrid.RunWithoutJobSystem_000063B8$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157825, XrefRangeEnd = 1157839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157839, XrefRangeEnd = 1157857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157857, XrefRangeEnd = 1157872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1159765, RefRangeEnd = 1159766, XrefRangeStart = 1157872, XrefRangeEnd = 1159765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn>.NativeClassPtr, "RunWithoutJobSystem_000063B8$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100692233);
          HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100692234);
          HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100692235);
          HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100692236);
          HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100692238);
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
            IL2CPP.il2cpp_field_static_get_value(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(HybridModelSystem.__c__DisplayClass_FindClosestModelToSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
