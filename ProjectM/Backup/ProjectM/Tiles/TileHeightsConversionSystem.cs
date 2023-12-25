// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileHeightsConversionSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Network;
using ProjectM.Physics;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;

#nullable disable
namespace ProjectM.Tiles
{
  public class TileHeightsConversionSystem : GameObjectConversionSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SystemsBeforeCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_CalculatedGameplayHeights;
    private static readonly System.IntPtr NativeFieldInfoPtr_CalculatedTerrainHeights;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionAuthoringQuery;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessAabbs_Internal_Static_Boolean_NativeQueue_1_RelevantAABB_Allocator_byref_BoundsMinMax_byref_NativeArray_1_Boolean_byref_NativeArray_1_RelevantAABB_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AabbToHalfTileBounds_Internal_Static_BoundsMinMax_float2_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateHeights_Private_Static_Void_GameObjectLookupConversionSystem_EntityManager_CollisionWorld_NativeArray_1_Boolean_BoundsMinMax_Dictionary_2_PrefabGUID_List_1_DataStruct_TileHeightData_NativeHashSet_1_Entity_CollisionFilterFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupPhysicsWorld_Private_CollisionWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShutdownPhysicsWorld_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildEntityData_Internal_Static_NativeList_1_EntityData_GameObjectLookupConversionSystem_EntityManager_NativeHashSet_1_Entity_NativeArray_1_Entity_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__6_0_Private_Void_Entity_NetworkedComponent_TileModelComponent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086228, XrefRangeEnd = 1086239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileHeightsConversionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086239, XrefRangeEnd = 1086320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileHeightsConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1086334, RefRangeEnd = 1086335, XrefRangeStart = 1086320, XrefRangeEnd = 1086334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ProcessAabbs(
      NativeQueue<TileHeightsConversionSystem.RelevantAABB> relevantAabbs,
      Allocator allocator,
      out BoundsMinMax totalHalfTileBounds,
      out NativeArray<bool> halfTilesToRaycast,
      out NativeArray<TileHeightsConversionSystem.RelevantAABB> aabbs)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &relevantAabbs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref totalHalfTileBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref halfTilesToRaycast;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref aabbs;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileHeightsConversionSystem.NativeMethodInfoPtr_ProcessAabbs_Internal_Static_Boolean_NativeQueue_1_RelevantAABB_Allocator_byref_BoundsMinMax_byref_NativeArray_1_Boolean_byref_NativeArray_1_RelevantAABB_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1086338, RefRangeEnd = 1086339, XrefRangeStart = 1086335, XrefRangeEnd = 1086338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BoundsMinMax AabbToHalfTileBounds(float2 minAabb, float2 maxAabb)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &minAabb;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxAabb;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileHeightsConversionSystem.NativeMethodInfoPtr_AabbToHalfTileBounds_Internal_Static_BoundsMinMax_float2_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1086437, RefRangeEnd = 1086438, XrefRangeStart = 1086339, XrefRangeEnd = 1086437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CalculateHeights(
      GameObjectLookupConversionSystem gameObjectLookup,
      EntityManager dstEntityManager,
      CollisionWorld collisionWorld,
      NativeArray<bool> halfTilesToRaycast,
      BoundsMinMax halfTileBounds,
      Dictionary<PrefabGUID, List<TileDatas<TileHeightData>.DataStruct>> calculatedResultHeights,
      NativeHashSet<Entity> validEntities,
      CollisionFilterFlags collisionFilter)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObjectLookup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstEntityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &halfTilesToRaycast;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &halfTileBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) calculatedResultHeights);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &validEntities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionFilter;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileHeightsConversionSystem.NativeMethodInfoPtr_CalculateHeights_Private_Static_Void_GameObjectLookupConversionSystem_EntityManager_CollisionWorld_NativeArray_1_Boolean_BoundsMinMax_Dictionary_2_PrefabGUID_List_1_DataStruct_TileHeightData_NativeHashSet_1_Entity_CollisionFilterFlags_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1086467, RefRangeEnd = 1086468, XrefRangeStart = 1086438, XrefRangeEnd = 1086467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CollisionWorld SetupPhysicsWorld()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileHeightsConversionSystem.NativeMethodInfoPtr_SetupPhysicsWorld_Private_CollisionWorld_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CollisionWorld*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1086502, RefRangeEnd = 1086503, XrefRangeStart = 1086468, XrefRangeEnd = 1086502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShutdownPhysicsWorld()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileHeightsConversionSystem.NativeMethodInfoPtr_ShutdownPhysicsWorld_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1086541, RefRangeEnd = 1086542, XrefRangeStart = 1086503, XrefRangeEnd = 1086541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeList<TileHeightsConversionSystem.EntityData> BuildEntityData(
      GameObjectLookupConversionSystem gameObjectLookup,
      EntityManager dstEntityManager,
      NativeHashSet<Entity> validEntities,
      NativeArray<Entity> hitEntities,
      Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObjectLookup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstEntityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &validEntities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &hitEntities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileHeightsConversionSystem.NativeMethodInfoPtr_BuildEntityData_Internal_Static_NativeList_1_EntityData_GameObjectLookupConversionSystem_EntityManager_NativeHashSet_1_Entity_NativeArray_1_Entity_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<TileHeightsConversionSystem.EntityData>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086542, XrefRangeEnd = 1086555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileHeightsConversionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileHeightsConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086555, XrefRangeEnd = 1086604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__6_0(
      Entity entity,
      NetworkedComponent networkedComponent,
      TileModelComponent tileModel)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) networkedComponent);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tileModel);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileHeightsConversionSystem.NativeMethodInfoPtr__OnUpdate_b__6_0_Private_Void_Entity_NetworkedComponent_TileModelComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileHeightsConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TileHeightsConversionSystem()
    {
      Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (TileHeightsConversionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr);
      TileHeightsConversionSystem.NativeFieldInfoPtr__SystemsBeforeCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr, nameof (_SystemsBeforeCollision));
      TileHeightsConversionSystem.NativeFieldInfoPtr_CalculatedGameplayHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr, nameof (CalculatedGameplayHeights));
      TileHeightsConversionSystem.NativeFieldInfoPtr_CalculatedTerrainHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr, nameof (CalculatedTerrainHeights));
      TileHeightsConversionSystem.NativeFieldInfoPtr__PrefabCollectionAuthoringQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr, nameof (_PrefabCollectionAuthoringQuery));
      TileHeightsConversionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr, 100685557);
      TileHeightsConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr, 100685558);
      TileHeightsConversionSystem.NativeMethodInfoPtr_ProcessAabbs_Internal_Static_Boolean_NativeQueue_1_RelevantAABB_Allocator_byref_BoundsMinMax_byref_NativeArray_1_Boolean_byref_NativeArray_1_RelevantAABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr, 100685559);
      TileHeightsConversionSystem.NativeMethodInfoPtr_AabbToHalfTileBounds_Internal_Static_BoundsMinMax_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr, 100685560);
      TileHeightsConversionSystem.NativeMethodInfoPtr_CalculateHeights_Private_Static_Void_GameObjectLookupConversionSystem_EntityManager_CollisionWorld_NativeArray_1_Boolean_BoundsMinMax_Dictionary_2_PrefabGUID_List_1_DataStruct_TileHeightData_NativeHashSet_1_Entity_CollisionFilterFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr, 100685561);
      TileHeightsConversionSystem.NativeMethodInfoPtr_SetupPhysicsWorld_Private_CollisionWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr, 100685562);
      TileHeightsConversionSystem.NativeMethodInfoPtr_ShutdownPhysicsWorld_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr, 100685563);
      TileHeightsConversionSystem.NativeMethodInfoPtr_BuildEntityData_Internal_Static_NativeList_1_EntityData_GameObjectLookupConversionSystem_EntityManager_NativeHashSet_1_Entity_NativeArray_1_Entity_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr, 100685564);
      TileHeightsConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr, 100685565);
      TileHeightsConversionSystem.NativeMethodInfoPtr__OnUpdate_b__6_0_Private_Void_Entity_NetworkedComponent_TileModelComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr, 100685566);
      TileHeightsConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr, 100685567);
    }

    public TileHeightsConversionSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe HashSet<ComponentSystemBase> _SystemsBeforeCollision
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileHeightsConversionSystem.NativeFieldInfoPtr__SystemsBeforeCollision));
        return pointer == System.IntPtr.Zero ? (HashSet<ComponentSystemBase>) null : new HashSet<ComponentSystemBase>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TileHeightsConversionSystem.NativeFieldInfoPtr__SystemsBeforeCollision), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<PrefabGUID, List<TileDatas<TileHeightData>.DataStruct>> CalculatedGameplayHeights
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileHeightsConversionSystem.NativeFieldInfoPtr_CalculatedGameplayHeights));
        return pointer == System.IntPtr.Zero ? (Dictionary<PrefabGUID, List<TileDatas<TileHeightData>.DataStruct>>) null : new Dictionary<PrefabGUID, List<TileDatas<TileHeightData>.DataStruct>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TileHeightsConversionSystem.NativeFieldInfoPtr_CalculatedGameplayHeights), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<PrefabGUID, List<TileDatas<TileHeightData>.DataStruct>> CalculatedTerrainHeights
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileHeightsConversionSystem.NativeFieldInfoPtr_CalculatedTerrainHeights));
        return pointer == System.IntPtr.Zero ? (Dictionary<PrefabGUID, List<TileDatas<TileHeightData>.DataStruct>>) null : new Dictionary<PrefabGUID, List<TileDatas<TileHeightData>.DataStruct>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TileHeightsConversionSystem.NativeFieldInfoPtr_CalculatedTerrainHeights), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _PrefabCollectionAuthoringQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileHeightsConversionSystem.NativeFieldInfoPtr__PrefabCollectionAuthoringQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileHeightsConversionSystem.NativeFieldInfoPtr__PrefabCollectionAuthoringQuery)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SampledRaycastHit
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_RaycastPos;
      private static readonly System.IntPtr NativeFieldInfoPtr_Height;
      [FieldOffset(0)]
      public float2 RaycastPos;
      [FieldOffset(8)]
      public float Height;

      static SampledRaycastHit()
      {
        Il2CppClassPointerStore<TileHeightsConversionSystem.SampledRaycastHit>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr, nameof (SampledRaycastHit));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileHeightsConversionSystem.SampledRaycastHit>.NativeClassPtr);
        TileHeightsConversionSystem.SampledRaycastHit.NativeFieldInfoPtr_RaycastPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.SampledRaycastHit>.NativeClassPtr, nameof (RaycastPos));
        TileHeightsConversionSystem.SampledRaycastHit.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.SampledRaycastHit>.NativeClassPtr, nameof (Height));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileHeightsConversionSystem.SampledRaycastHit>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CalculateRelevantAabbs
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ValidEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_StaticBodies;
      private static readonly System.IntPtr NativeFieldInfoPtr_ResultAABBs;
      private static readonly System.IntPtr NativeFieldInfoPtr_ValidFilterFlags;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;
      [FieldOffset(0)]
      public NativeHashSet<Entity> ValidEntities;
      [FieldOffset(16)]
      public NativeArray<RigidBody> StaticBodies;
      [FieldOffset(32)]
      public NativeQueue<TileHeightsConversionSystem.RelevantAABB>.ParallelWriter ResultAABBs;
      [FieldOffset(56)]
      public CollisionFilterFlags ValidFilterFlags;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086102, XrefRangeEnd = 1086116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(int index)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &index;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TileHeightsConversionSystem.CalculateRelevantAabbs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static CalculateRelevantAabbs()
      {
        Il2CppClassPointerStore<TileHeightsConversionSystem.CalculateRelevantAabbs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr, nameof (CalculateRelevantAabbs));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileHeightsConversionSystem.CalculateRelevantAabbs>.NativeClassPtr);
        TileHeightsConversionSystem.CalculateRelevantAabbs.NativeFieldInfoPtr_ValidEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.CalculateRelevantAabbs>.NativeClassPtr, nameof (ValidEntities));
        TileHeightsConversionSystem.CalculateRelevantAabbs.NativeFieldInfoPtr_StaticBodies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.CalculateRelevantAabbs>.NativeClassPtr, nameof (StaticBodies));
        TileHeightsConversionSystem.CalculateRelevantAabbs.NativeFieldInfoPtr_ResultAABBs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.CalculateRelevantAabbs>.NativeClassPtr, nameof (ResultAABBs));
        TileHeightsConversionSystem.CalculateRelevantAabbs.NativeFieldInfoPtr_ValidFilterFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.CalculateRelevantAabbs>.NativeClassPtr, nameof (ValidFilterFlags));
        TileHeightsConversionSystem.CalculateRelevantAabbs.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileHeightsConversionSystem.CalculateRelevantAabbs>.NativeClassPtr, 100685568);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileHeightsConversionSystem.CalculateRelevantAabbs>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RelevantAABB
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Aabb;
      [FieldOffset(0)]
      public Aabb Aabb;

      static RelevantAABB()
      {
        Il2CppClassPointerStore<TileHeightsConversionSystem.RelevantAABB>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr, nameof (RelevantAABB));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileHeightsConversionSystem.RelevantAABB>.NativeClassPtr);
        TileHeightsConversionSystem.RelevantAABB.NativeFieldInfoPtr_Aabb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.RelevantAABB>.NativeClassPtr, nameof (Aabb));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileHeightsConversionSystem.RelevantAABB>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct BuildTargetTilesJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_AABBs;
      private static readonly System.IntPtr NativeFieldInfoPtr_HalfTileResult;
      private static readonly System.IntPtr NativeFieldInfoPtr_TotalHalfTileBoundsMin;
      private static readonly System.IntPtr NativeFieldInfoPtr_TotalHalfTileBoundsWidth;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_Int32_0;
      [FieldOffset(0)]
      public NativeArray<TileHeightsConversionSystem.RelevantAABB> AABBs;
      [FieldOffset(16)]
      public NativeArray<bool> HalfTileResult;
      [FieldOffset(32)]
      public int2 TotalHalfTileBoundsMin;
      [FieldOffset(40)]
      public int TotalHalfTileBoundsWidth;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086116, XrefRangeEnd = 1086117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TileHeightsConversionSystem.BuildTargetTilesJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1086120, RefRangeEnd = 1086121, XrefRangeStart = 1086117, XrefRangeEnd = 1086120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(int index)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &index;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TileHeightsConversionSystem.BuildTargetTilesJob.NativeMethodInfoPtr_Execute_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static BuildTargetTilesJob()
      {
        Il2CppClassPointerStore<TileHeightsConversionSystem.BuildTargetTilesJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr, nameof (BuildTargetTilesJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileHeightsConversionSystem.BuildTargetTilesJob>.NativeClassPtr);
        TileHeightsConversionSystem.BuildTargetTilesJob.NativeFieldInfoPtr_AABBs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.BuildTargetTilesJob>.NativeClassPtr, nameof (AABBs));
        TileHeightsConversionSystem.BuildTargetTilesJob.NativeFieldInfoPtr_HalfTileResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.BuildTargetTilesJob>.NativeClassPtr, nameof (HalfTileResult));
        TileHeightsConversionSystem.BuildTargetTilesJob.NativeFieldInfoPtr_TotalHalfTileBoundsMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.BuildTargetTilesJob>.NativeClassPtr, nameof (TotalHalfTileBoundsMin));
        TileHeightsConversionSystem.BuildTargetTilesJob.NativeFieldInfoPtr_TotalHalfTileBoundsWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.BuildTargetTilesJob>.NativeClassPtr, nameof (TotalHalfTileBoundsWidth));
        TileHeightsConversionSystem.BuildTargetTilesJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileHeightsConversionSystem.BuildTargetTilesJob>.NativeClassPtr, 100685569);
        TileHeightsConversionSystem.BuildTargetTilesJob.NativeMethodInfoPtr_Execute_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileHeightsConversionSystem.BuildTargetTilesJob>.NativeClassPtr, 100685570);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileHeightsConversionSystem.BuildTargetTilesJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HeightPickingJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CollisionFlags;
      private static readonly System.IntPtr NativeFieldInfoPtr_CollisionWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_Result;
      private static readonly System.IntPtr NativeFieldInfoPtr_Entities;
      private static readonly System.IntPtr NativeFieldInfoPtr_HalfTileResult;
      private static readonly System.IntPtr NativeFieldInfoPtr_TotalHalfTileBoundsMin;
      private static readonly System.IntPtr NativeFieldInfoPtr_TotalHalfTileBoundsSize;
      private static readonly System.IntPtr NativeFieldInfoPtr_RAYCAST_OFFSET;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;
      [FieldOffset(0)]
      public CollisionFilterFlags CollisionFlags;
      [FieldOffset(8)]
      public CollisionWorld CollisionWorld;
      [FieldOffset(352)]
      public NativeMultiHashMap<Entity, TileHeightsConversionSystem.SampledRaycastHit>.ParallelWriter Result;
      [FieldOffset(368)]
      public NativeHashSet<Entity>.ParallelWriter Entities;
      [FieldOffset(384)]
      public NativeArray<bool> HalfTileResult;
      [FieldOffset(400)]
      public int2 TotalHalfTileBoundsMin;
      [FieldOffset(408)]
      public int2 TotalHalfTileBoundsSize;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086121, XrefRangeEnd = 1086182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(int index)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &index;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TileHeightsConversionSystem.HeightPickingJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HeightPickingJob()
      {
        Il2CppClassPointerStore<TileHeightsConversionSystem.HeightPickingJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr, nameof (HeightPickingJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileHeightsConversionSystem.HeightPickingJob>.NativeClassPtr);
        TileHeightsConversionSystem.HeightPickingJob.NativeFieldInfoPtr_CollisionFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.HeightPickingJob>.NativeClassPtr, nameof (CollisionFlags));
        TileHeightsConversionSystem.HeightPickingJob.NativeFieldInfoPtr_CollisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.HeightPickingJob>.NativeClassPtr, nameof (CollisionWorld));
        TileHeightsConversionSystem.HeightPickingJob.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.HeightPickingJob>.NativeClassPtr, nameof (Result));
        TileHeightsConversionSystem.HeightPickingJob.NativeFieldInfoPtr_Entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.HeightPickingJob>.NativeClassPtr, nameof (Entities));
        TileHeightsConversionSystem.HeightPickingJob.NativeFieldInfoPtr_HalfTileResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.HeightPickingJob>.NativeClassPtr, nameof (HalfTileResult));
        TileHeightsConversionSystem.HeightPickingJob.NativeFieldInfoPtr_TotalHalfTileBoundsMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.HeightPickingJob>.NativeClassPtr, nameof (TotalHalfTileBoundsMin));
        TileHeightsConversionSystem.HeightPickingJob.NativeFieldInfoPtr_TotalHalfTileBoundsSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.HeightPickingJob>.NativeClassPtr, nameof (TotalHalfTileBoundsSize));
        TileHeightsConversionSystem.HeightPickingJob.NativeFieldInfoPtr_RAYCAST_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.HeightPickingJob>.NativeClassPtr, nameof (RAYCAST_OFFSET));
        TileHeightsConversionSystem.HeightPickingJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileHeightsConversionSystem.HeightPickingJob>.NativeClassPtr, 100685571);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileHeightsConversionSystem.HeightPickingJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe float RAYCAST_OFFSET
      {
        get
        {
          float raycastOffset;
          IL2CPP.il2cpp_field_static_get_value(TileHeightsConversionSystem.HeightPickingJob.NativeFieldInfoPtr_RAYCAST_OFFSET, (void*) &raycastOffset);
          return raycastOffset;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TileHeightsConversionSystem.HeightPickingJob.NativeFieldInfoPtr_RAYCAST_OFFSET, (void*) &value);
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct EntityData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_PivotSettings;
      [FieldOffset(0)]
      public Entity Entity;
      [FieldOffset(8)]
      public PrefabGUID PrefabGUID;
      [FieldOffset(12)]
      public TilePivotSettings PivotSettings;

      static EntityData()
      {
        Il2CppClassPointerStore<TileHeightsConversionSystem.EntityData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr, nameof (EntityData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileHeightsConversionSystem.EntityData>.NativeClassPtr);
        TileHeightsConversionSystem.EntityData.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.EntityData>.NativeClassPtr, nameof (Entity));
        TileHeightsConversionSystem.EntityData.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.EntityData>.NativeClassPtr, nameof (PrefabGUID));
        TileHeightsConversionSystem.EntityData.NativeFieldInfoPtr_PivotSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.EntityData>.NativeClassPtr, nameof (PivotSettings));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileHeightsConversionSystem.EntityData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GroupHeightsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Entities;
      private static readonly System.IntPtr NativeFieldInfoPtr_Hits;
      private static readonly System.IntPtr NativeFieldInfoPtr_TempHeightHashMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_Prefabs;
      private static readonly System.IntPtr NativeFieldInfoPtr_GroupedHits;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;
      [FieldOffset(0)]
      public NativeList<TileHeightsConversionSystem.EntityData> Entities;
      [FieldOffset(16)]
      public NativeMultiHashMap<Entity, TileHeightsConversionSystem.SampledRaycastHit> Hits;
      [FieldOffset(32)]
      public NativeHashMap<int2, float> TempHeightHashMap;
      [FieldOffset(48)]
      public NativeHashSet<PrefabGUID>.ParallelWriter Prefabs;
      [FieldOffset(64)]
      public NativeMultiHashMap<PrefabGUID, TileDatas<TileHeightData>.DataStruct>.ParallelWriter GroupedHits;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086182, XrefRangeEnd = 1086228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(int index)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &index;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TileHeightsConversionSystem.GroupHeightsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static GroupHeightsJob()
      {
        Il2CppClassPointerStore<TileHeightsConversionSystem.GroupHeightsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileHeightsConversionSystem>.NativeClassPtr, nameof (GroupHeightsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileHeightsConversionSystem.GroupHeightsJob>.NativeClassPtr);
        TileHeightsConversionSystem.GroupHeightsJob.NativeFieldInfoPtr_Entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.GroupHeightsJob>.NativeClassPtr, nameof (Entities));
        TileHeightsConversionSystem.GroupHeightsJob.NativeFieldInfoPtr_Hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.GroupHeightsJob>.NativeClassPtr, nameof (Hits));
        TileHeightsConversionSystem.GroupHeightsJob.NativeFieldInfoPtr_TempHeightHashMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.GroupHeightsJob>.NativeClassPtr, nameof (TempHeightHashMap));
        TileHeightsConversionSystem.GroupHeightsJob.NativeFieldInfoPtr_Prefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.GroupHeightsJob>.NativeClassPtr, nameof (Prefabs));
        TileHeightsConversionSystem.GroupHeightsJob.NativeFieldInfoPtr_GroupedHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHeightsConversionSystem.GroupHeightsJob>.NativeClassPtr, nameof (GroupedHits));
        TileHeightsConversionSystem.GroupHeightsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileHeightsConversionSystem.GroupHeightsJob>.NativeClassPtr, 100685572);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileHeightsConversionSystem.GroupHeightsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
