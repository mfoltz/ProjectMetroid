// Decompiled with JetBrains decompiler
// Type: ProjectM.PreviewPlacementBuffSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Physics;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class PreviewPlacementBuffSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__CollisionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__MouseWorldPositionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileModelSpatialLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__RequiredPrefabs;
    private static readonly System.IntPtr NativeFieldInfoPtr__ValidComponents;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerDebugSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_HybridCameraData_24;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertPreviewOnDemand_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreatePreview_Private_Boolean_Entity_byref_PreviewPlacementBuff_PrefabLookupMap_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreatePreviewForAttachedChildren_Private_Void_Entity_Entity_PrefabLookupMap_NativeHashSet_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePreviewPosition_Private_Void_byref_CollisionWorld_byref_TileWorld_byref_PreviewPlacementBuff_byref_Entity_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetStartAndEndStairs_Private_Boolean_PrefabGUID_PrefabLookupMap_byref_NetworkedPrefabData_byref_NetworkedPrefabData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePreviewPositionsForAttachedChildren_Private_Void_Entity_Translation_Rotation_Translation_Rotation_NativeHashSet_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPreviewPositionsForAttachedChildrenRecursive_Private_Static_Void_Entity_Translation_Rotation_Translation_Rotation_EntityManager_NativeList_1_TileModelData_NativeHashSet_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateNetworkedChildrenAndStripPreview_Private_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SpawnNetworkedPrefabChildrenRecursive_Private_Void_Entity_NativeList_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StripComponentsRecursive_Private_Void_Entity_byref_NativeList_1_ComponentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyHiddenChildren_Private_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyPreviewBuffPreview_Public_Static_Void_EntityManager_byref_PreviewPlacementBuff_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyCastleBuildingAttachedChildren_Private_Static_Void_EntityManager_Entity_NativeHashMap_2_Entity_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028068, XrefRangeEnd = 1028262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PreviewPlacementBuffSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028262, XrefRangeEnd = 1028268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PreviewPlacementBuffSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028268, XrefRangeEnd = 1028301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PreviewPlacementBuffSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ConvertPreviewOnDemand()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PreviewPlacementBuffSystem.NativeMethodInfoPtr_ConvertPreviewOnDemand_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1028336, RefRangeEnd = 1028337, XrefRangeStart = 1028301, XrefRangeEnd = 1028336, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CreatePreview(
      Entity buffEntity,
      ref PreviewPlacementBuff buff,
      PrefabLookupMap prefabLookupMap)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &buffEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PreviewPlacementBuffSystem.NativeMethodInfoPtr_CreatePreview_Private_Boolean_Entity_byref_PreviewPlacementBuff_PrefabLookupMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1028443, RefRangeEnd = 1028445, XrefRangeStart = 1028337, XrefRangeEnd = 1028443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreatePreviewForAttachedChildren(
      Entity existingEntity,
      Entity previewEntity,
      PrefabLookupMap prefabLookupMap,
      NativeHashSet<Entity> checkedEntities)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &existingEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &previewEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &checkedEntities;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PreviewPlacementBuffSystem.NativeMethodInfoPtr_CreatePreviewForAttachedChildren_Private_Void_Entity_Entity_PrefabLookupMap_NativeHashSet_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1028617, RefRangeEnd = 1028618, XrefRangeStart = 1028445, XrefRangeEnd = 1028617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdatePreviewPosition(
      ref CollisionWorld collisionWorld,
      ref TileWorld tileWorld,
      ref PreviewPlacementBuff buff,
      [In] ref Entity buffEntity,
      byte heightLevel)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PreviewPlacementBuffSystem.NativeMethodInfoPtr_UpdatePreviewPosition_Private_Void_byref_CollisionWorld_byref_TileWorld_byref_PreviewPlacementBuff_byref_Entity_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028618, XrefRangeEnd = 1028639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetStartAndEndStairs(
      PrefabGUID prefabGuid,
      PrefabLookupMap prefabLookupMap,
      out NetworkedPrefabData startStairs,
      out NetworkedPrefabData endStairs)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref startStairs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref endStairs;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PreviewPlacementBuffSystem.NativeMethodInfoPtr_TryGetStartAndEndStairs_Private_Boolean_PrefabGUID_PrefabLookupMap_byref_NetworkedPrefabData_byref_NetworkedPrefabData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028639, XrefRangeEnd = 1028663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdatePreviewPositionsForAttachedChildren(
      Entity entityToMove,
      Translation oldTranslation,
      Rotation oldRotation,
      Translation newTranslation,
      Rotation newRotation,
      NativeHashSet<Entity> checkedEntities)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityToMove;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &oldTranslation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &oldRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &newTranslation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &newRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &checkedEntities;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PreviewPlacementBuffSystem.NativeMethodInfoPtr_UpdatePreviewPositionsForAttachedChildren_Private_Void_Entity_Translation_Rotation_Translation_Rotation_NativeHashSet_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1028714, RefRangeEnd = 1028717, XrefRangeStart = 1028663, XrefRangeEnd = 1028714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetPreviewPositionsForAttachedChildrenRecursive(
      Entity parentEntity,
      Translation oldTranslation,
      Rotation oldRotation,
      Translation newTranslation,
      Rotation newRotation,
      EntityManager entityManager,
      NativeList<PreviewPlacementBuffSystem.TileModelData> tileModelsToMove,
      NativeHashSet<Entity> checkedEntities)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &parentEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &oldTranslation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &oldRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &newTranslation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &newRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModelsToMove;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &checkedEntities;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PreviewPlacementBuffSystem.NativeMethodInfoPtr_GetPreviewPositionsForAttachedChildrenRecursive_Private_Static_Void_Entity_Translation_Rotation_Translation_Rotation_EntityManager_NativeList_1_TileModelData_NativeHashSet_1_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1028749, RefRangeEnd = 1028750, XrefRangeStart = 1028717, XrefRangeEnd = 1028749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InstantiateNetworkedChildrenAndStripPreview(Entity previewEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &previewEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PreviewPlacementBuffSystem.NativeMethodInfoPtr_InstantiateNetworkedChildrenAndStripPreview_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1028825, RefRangeEnd = 1028827, XrefRangeStart = 1028750, XrefRangeEnd = 1028825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SpawnNetworkedPrefabChildrenRecursive(
      Entity parentEntity,
      NativeList<Entity> spawnedNestedEntities)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &parentEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnedNestedEntities;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PreviewPlacementBuffSystem.NativeMethodInfoPtr_SpawnNetworkedPrefabChildrenRecursive_Private_Void_Entity_NativeList_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1028867, RefRangeEnd = 1028870, XrefRangeStart = 1028827, XrefRangeEnd = 1028867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StripComponentsRecursive(
      Entity entity,
      ref NativeList<ComponentType> componentTypesResult)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref componentTypesResult;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PreviewPlacementBuffSystem.NativeMethodInfoPtr_StripComponentsRecursive_Private_Void_Entity_byref_NativeList_1_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1028901, RefRangeEnd = 1028903, XrefRangeStart = 1028870, XrefRangeEnd = 1028901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DestroyHiddenChildren(Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PreviewPlacementBuffSystem.NativeMethodInfoPtr_DestroyHiddenChildren_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1028915, RefRangeEnd = 1028918, XrefRangeStart = 1028903, XrefRangeEnd = 1028915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DestroyPreviewBuffPreview(
      EntityManager entityManager,
      ref PreviewPlacementBuff previewBuff)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref previewBuff;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PreviewPlacementBuffSystem.NativeMethodInfoPtr_DestroyPreviewBuffPreview_Public_Static_Void_EntityManager_byref_PreviewPlacementBuff_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1028945, RefRangeEnd = 1028947, XrefRangeStart = 1028918, XrefRangeEnd = 1028945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DestroyCastleBuildingAttachedChildren(
      EntityManager entityManager,
      Entity parentEntity,
      NativeHashMap<Entity, bool> checkedEntities)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &parentEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &checkedEntities;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PreviewPlacementBuffSystem.NativeMethodInfoPtr_DestroyCastleBuildingAttachedChildren_Private_Static_Void_EntityManager_Entity_NativeHashMap_2_Entity_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PreviewPlacementBuffSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PreviewPlacementBuffSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028947, XrefRangeEnd = 1028955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PreviewPlacementBuffSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PreviewPlacementBuffSystem()
    {
      Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PreviewPlacementBuffSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr);
      PreviewPlacementBuffSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, nameof (_Query));
      PreviewPlacementBuffSystem.NativeFieldInfoPtr__CollisionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, nameof (_CollisionSystem));
      PreviewPlacementBuffSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      PreviewPlacementBuffSystem.NativeFieldInfoPtr__MouseWorldPositionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, nameof (_MouseWorldPositionSystem));
      PreviewPlacementBuffSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, nameof (_TileModelSpatialLookupMap));
      PreviewPlacementBuffSystem.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, nameof (_TileWorldSystem));
      PreviewPlacementBuffSystem.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, nameof (_CommonClientDataSystem));
      PreviewPlacementBuffSystem.NativeFieldInfoPtr__RequiredPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, nameof (_RequiredPrefabs));
      PreviewPlacementBuffSystem.NativeFieldInfoPtr__ValidComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, nameof (_ValidComponents));
      PreviewPlacementBuffSystem.NativeFieldInfoPtr__ServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, nameof (_ServerDebugSettings));
      PreviewPlacementBuffSystem.NativeFieldInfoPtr__SingletonEntityQuery_HybridCameraData_24 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_HybridCameraData_24));
      PreviewPlacementBuffSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, 100680315);
      PreviewPlacementBuffSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, 100680316);
      PreviewPlacementBuffSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, 100680317);
      PreviewPlacementBuffSystem.NativeMethodInfoPtr_ConvertPreviewOnDemand_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, 100680318);
      PreviewPlacementBuffSystem.NativeMethodInfoPtr_CreatePreview_Private_Boolean_Entity_byref_PreviewPlacementBuff_PrefabLookupMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, 100680319);
      PreviewPlacementBuffSystem.NativeMethodInfoPtr_CreatePreviewForAttachedChildren_Private_Void_Entity_Entity_PrefabLookupMap_NativeHashSet_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, 100680320);
      PreviewPlacementBuffSystem.NativeMethodInfoPtr_UpdatePreviewPosition_Private_Void_byref_CollisionWorld_byref_TileWorld_byref_PreviewPlacementBuff_byref_Entity_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, 100680321);
      PreviewPlacementBuffSystem.NativeMethodInfoPtr_TryGetStartAndEndStairs_Private_Boolean_PrefabGUID_PrefabLookupMap_byref_NetworkedPrefabData_byref_NetworkedPrefabData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, 100680322);
      PreviewPlacementBuffSystem.NativeMethodInfoPtr_UpdatePreviewPositionsForAttachedChildren_Private_Void_Entity_Translation_Rotation_Translation_Rotation_NativeHashSet_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, 100680323);
      PreviewPlacementBuffSystem.NativeMethodInfoPtr_GetPreviewPositionsForAttachedChildrenRecursive_Private_Static_Void_Entity_Translation_Rotation_Translation_Rotation_EntityManager_NativeList_1_TileModelData_NativeHashSet_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, 100680324);
      PreviewPlacementBuffSystem.NativeMethodInfoPtr_InstantiateNetworkedChildrenAndStripPreview_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, 100680325);
      PreviewPlacementBuffSystem.NativeMethodInfoPtr_SpawnNetworkedPrefabChildrenRecursive_Private_Void_Entity_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, 100680326);
      PreviewPlacementBuffSystem.NativeMethodInfoPtr_StripComponentsRecursive_Private_Void_Entity_byref_NativeList_1_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, 100680327);
      PreviewPlacementBuffSystem.NativeMethodInfoPtr_DestroyHiddenChildren_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, 100680328);
      PreviewPlacementBuffSystem.NativeMethodInfoPtr_DestroyPreviewBuffPreview_Public_Static_Void_EntityManager_byref_PreviewPlacementBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, 100680329);
      PreviewPlacementBuffSystem.NativeMethodInfoPtr_DestroyCastleBuildingAttachedChildren_Private_Static_Void_EntityManager_Entity_NativeHashMap_2_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, 100680330);
      PreviewPlacementBuffSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, 100680331);
      PreviewPlacementBuffSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, 100680332);
    }

    public PreviewPlacementBuffSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewPlacementBuffSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewPlacementBuffSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe CollisionSystem _CollisionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewPlacementBuffSystem.NativeFieldInfoPtr__CollisionSystem));
        return pointer == System.IntPtr.Zero ? (CollisionSystem) null : new CollisionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PreviewPlacementBuffSystem.NativeFieldInfoPtr__CollisionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewPlacementBuffSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PreviewPlacementBuffSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MouseWorldPositionSystem _MouseWorldPositionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewPlacementBuffSystem.NativeFieldInfoPtr__MouseWorldPositionSystem));
        return pointer == System.IntPtr.Zero ? (MouseWorldPositionSystem) null : new MouseWorldPositionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PreviewPlacementBuffSystem.NativeFieldInfoPtr__MouseWorldPositionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileModelSpatialLookupMap _TileModelSpatialLookupMap
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewPlacementBuffSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap));
        return pointer == System.IntPtr.Zero ? (TileModelSpatialLookupMap) null : new TileModelSpatialLookupMap(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PreviewPlacementBuffSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewPlacementBuffSystem.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PreviewPlacementBuffSystem.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewPlacementBuffSystem.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PreviewPlacementBuffSystem.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<PrefabGUID> _RequiredPrefabs
    {
      get
      {
        return *(NativeList<PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewPlacementBuffSystem.NativeFieldInfoPtr__RequiredPrefabs));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewPlacementBuffSystem.NativeFieldInfoPtr__RequiredPrefabs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe HashSet<ComponentType> _ValidComponents
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewPlacementBuffSystem.NativeFieldInfoPtr__ValidComponents));
        return pointer == System.IntPtr.Zero ? (HashSet<ComponentType>) null : new HashSet<ComponentType>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PreviewPlacementBuffSystem.NativeFieldInfoPtr__ValidComponents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> _ServerDebugSettings
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewPlacementBuffSystem.NativeFieldInfoPtr__ServerDebugSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewPlacementBuffSystem.NativeFieldInfoPtr__ServerDebugSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_HybridCameraData_24
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewPlacementBuffSystem.NativeFieldInfoPtr__SingletonEntityQuery_HybridCameraData_24));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewPlacementBuffSystem.NativeFieldInfoPtr__SingletonEntityQuery_HybridCameraData_24)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TileModelData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ExistingEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_NewTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_NewRotation;
      [FieldOffset(0)]
      public Entity ExistingEntity;
      [FieldOffset(8)]
      public Translation NewTranslation;
      [FieldOffset(20)]
      public Rotation NewRotation;

      static TileModelData()
      {
        Il2CppClassPointerStore<PreviewPlacementBuffSystem.TileModelData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreviewPlacementBuffSystem>.NativeClassPtr, nameof (TileModelData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreviewPlacementBuffSystem.TileModelData>.NativeClassPtr);
        PreviewPlacementBuffSystem.TileModelData.NativeFieldInfoPtr_ExistingEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuffSystem.TileModelData>.NativeClassPtr, nameof (ExistingEntity));
        PreviewPlacementBuffSystem.TileModelData.NativeFieldInfoPtr_NewTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuffSystem.TileModelData>.NativeClassPtr, nameof (NewTranslation));
        PreviewPlacementBuffSystem.TileModelData.NativeFieldInfoPtr_NewRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewPlacementBuffSystem.TileModelData>.NativeClassPtr, nameof (NewRotation));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreviewPlacementBuffSystem.TileModelData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
