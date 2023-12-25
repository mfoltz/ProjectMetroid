// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Systems.CastleRailingsSystem
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Profiling;

#nullable disable
namespace ProjectM.CastleBuilding.Systems
{
  public class CastleRailingsSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__FloorEntityEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__WallEntityEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__PillarEntityEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__RegisterRailingsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__PotentialRailingBlocks;
    private static readonly System.IntPtr NativeFieldInfoPtr__PotentialCornerBlocks;
    private static readonly System.IntPtr NativeFieldInfoPtr__Railings;
    private static readonly System.IntPtr NativeFieldInfoPtr__Corners;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CastleBlockSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RailingsCollection_Public_get_CastleRailingsCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateRailing_Private_Static_Void_byref_CastleWallBlock_byref_CastleBlockCollection_byref_TileWorld_byref_NativeHashMap_2_CastleWallBlock_Entity_byref_CastleRailingPrefabsCollection_byref_PrefabLookupMap_byref_EntityManager_byref_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckStairRailings_Private_Static_Boolean_CastleWallBlock_EntityManager_Entity_Entity_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateRailingCorner_Private_Static_Void_byref_CastleBlock_byref_CastleBlockCollection_byref_NativeHashMap_2_CastleBlock_Entity_byref_NativeHashMap_2_CastleWallBlock_Entity_Entity_byref_EntityManager_byref_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValidFloor_Private_Static_Boolean_byref_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsRailingGrounded_Private_Static_Boolean_byref_TileWorld_byref_CastleWallBlock_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0;

    public unsafe CastleRailingsCollection RailingsCollection
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.NativeMethodInfoPtr_get_RailingsCollection_Public_get_CastleRailingsCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CastleRailingsCollection*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203983, XrefRangeEnd = 1204050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleRailingsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204050, XrefRangeEnd = 1204062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleRailingsSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204062, XrefRangeEnd = 1204153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleRailingsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1204221, RefRangeEnd = 1204222, XrefRangeStart = 1204153, XrefRangeEnd = 1204221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateRailing(
      [In] ref CastleWallBlock railingBlock,
      [In] ref CastleBlockCollection blockCollection,
      [In] ref TileWorld tileWorld,
      ref NativeHashMap<CastleWallBlock, Entity> currentRailings,
      ref CastleRailingPrefabsCollection railingPrefabsCollection,
      ref PrefabLookupMap lookupMap,
      ref EntityManager entityManager,
      ref EntityCommandBuffer commandBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) ref railingBlock;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref blockCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentRailings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref railingPrefabsCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref lookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref commandBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.NativeMethodInfoPtr_UpdateRailing_Private_Static_Void_byref_CastleWallBlock_byref_CastleBlockCollection_byref_TileWorld_byref_NativeHashMap_2_CastleWallBlock_Entity_byref_CastleRailingPrefabsCollection_byref_PrefabLookupMap_byref_EntityManager_byref_EntityCommandBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1204239, RefRangeEnd = 1204240, XrefRangeStart = 1204222, XrefRangeEnd = 1204239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CheckStairRailings(
      CastleWallBlock railingBlock,
      EntityManager entityManager,
      Entity backFloorEntity,
      Entity frontFloorEntity,
      out bool stairRailingOverride)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &railingBlock;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &backFloorEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &frontFloorEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref stairRailingOverride;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.NativeMethodInfoPtr_CheckStairRailings_Private_Static_Boolean_CastleWallBlock_EntityManager_Entity_Entity_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1204296, RefRangeEnd = 1204297, XrefRangeStart = 1204240, XrefRangeEnd = 1204296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateRailingCorner(
      [In] ref CastleBlock cornerBlock,
      [In] ref CastleBlockCollection blockCollection,
      ref NativeHashMap<CastleBlock, Entity> currentCorners,
      [In] ref NativeHashMap<CastleWallBlock, Entity> currentRailings,
      Entity cornerPrefab,
      ref EntityManager entityManager,
      ref EntityCommandBuffer commandBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) ref cornerBlock;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref blockCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentCorners;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref currentRailings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &cornerPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref commandBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.NativeMethodInfoPtr_UpdateRailingCorner_Private_Static_Void_byref_CastleBlock_byref_CastleBlockCollection_byref_NativeHashMap_2_CastleBlock_Entity_byref_NativeHashMap_2_CastleWallBlock_Entity_Entity_byref_EntityManager_byref_EntityCommandBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1204303, RefRangeEnd = 1204305, XrefRangeStart = 1204297, XrefRangeEnd = 1204303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsValidFloor(ref EntityManager entityManager, Entity floorEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &floorEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.NativeMethodInfoPtr_IsValidFloor_Private_Static_Boolean_byref_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1204324, RefRangeEnd = 1204325, XrefRangeStart = 1204305, XrefRangeEnd = 1204324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsRailingGrounded(
      [In] ref TileWorld tileWorld,
      [In] ref CastleWallBlock railingBlock)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref railingBlock;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.NativeMethodInfoPtr_IsRailingGrounded_Private_Static_Boolean_byref_TileWorld_byref_CastleWallBlock_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleRailingsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204325, XrefRangeEnd = 1204342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleRailingsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204342, XrefRangeEnd = 1204346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleRailingsSystem()
    {
      Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.CastleBuilding.Systems", nameof (CastleRailingsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr);
      CastleRailingsSystem.NativeFieldInfoPtr__FloorEntityEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, nameof (_FloorEntityEventQuery));
      CastleRailingsSystem.NativeFieldInfoPtr__WallEntityEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, nameof (_WallEntityEventQuery));
      CastleRailingsSystem.NativeFieldInfoPtr__PillarEntityEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, nameof (_PillarEntityEventQuery));
      CastleRailingsSystem.NativeFieldInfoPtr__RegisterRailingsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, nameof (_RegisterRailingsQuery));
      CastleRailingsSystem.NativeFieldInfoPtr__PotentialRailingBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, nameof (_PotentialRailingBlocks));
      CastleRailingsSystem.NativeFieldInfoPtr__PotentialCornerBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, nameof (_PotentialCornerBlocks));
      CastleRailingsSystem.NativeFieldInfoPtr__Railings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, nameof (_Railings));
      CastleRailingsSystem.NativeFieldInfoPtr__Corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, nameof (_Corners));
      CastleRailingsSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      CastleRailingsSystem.NativeFieldInfoPtr__CastleBlockSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, nameof (_CastleBlockSystem));
      CastleRailingsSystem.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, nameof (_TileWorldSystem));
      CastleRailingsSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      CastleRailingsSystem.NativeMethodInfoPtr_get_RailingsCollection_Public_get_CastleRailingsCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, 100664615);
      CastleRailingsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, 100664616);
      CastleRailingsSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, 100664617);
      CastleRailingsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, 100664618);
      CastleRailingsSystem.NativeMethodInfoPtr_UpdateRailing_Private_Static_Void_byref_CastleWallBlock_byref_CastleBlockCollection_byref_TileWorld_byref_NativeHashMap_2_CastleWallBlock_Entity_byref_CastleRailingPrefabsCollection_byref_PrefabLookupMap_byref_EntityManager_byref_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, 100664619);
      CastleRailingsSystem.NativeMethodInfoPtr_CheckStairRailings_Private_Static_Boolean_CastleWallBlock_EntityManager_Entity_Entity_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, 100664620);
      CastleRailingsSystem.NativeMethodInfoPtr_UpdateRailingCorner_Private_Static_Void_byref_CastleBlock_byref_CastleBlockCollection_byref_NativeHashMap_2_CastleBlock_Entity_byref_NativeHashMap_2_CastleWallBlock_Entity_Entity_byref_EntityManager_byref_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, 100664621);
      CastleRailingsSystem.NativeMethodInfoPtr_IsValidFloor_Private_Static_Boolean_byref_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, 100664622);
      CastleRailingsSystem.NativeMethodInfoPtr_IsRailingGrounded_Private_Static_Boolean_byref_TileWorld_byref_CastleWallBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, 100664623);
      CastleRailingsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, 100664624);
      CastleRailingsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, 100664625);
      CastleRailingsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, 100664626);
    }

    public CastleRailingsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _FloorEntityEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr__FloorEntityEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr__FloorEntityEventQuery)) = value;
      }
    }

    public unsafe EntityQuery _WallEntityEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr__WallEntityEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr__WallEntityEventQuery)) = value;
      }
    }

    public unsafe EntityQuery _PillarEntityEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr__PillarEntityEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr__PillarEntityEventQuery)) = value;
      }
    }

    public unsafe EntityQuery _RegisterRailingsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr__RegisterRailingsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr__RegisterRailingsQuery)) = value;
      }
    }

    public unsafe NativeHashSet<CastleWallBlock> _PotentialRailingBlocks
    {
      get
      {
        return *(NativeHashSet<CastleWallBlock>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr__PotentialRailingBlocks));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr__PotentialRailingBlocks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashSet<CastleWallBlock>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashSet<CastleBlock> _PotentialCornerBlocks
    {
      get
      {
        return *(NativeHashSet<CastleBlock>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr__PotentialCornerBlocks));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr__PotentialCornerBlocks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashSet<CastleBlock>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<CastleWallBlock, Entity> _Railings
    {
      get
      {
        return *(NativeHashMap<CastleWallBlock, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr__Railings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr__Railings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<CastleWallBlock, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<CastleBlock, Entity> _Corners
    {
      get
      {
        return *(NativeHashMap<CastleBlock, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr__Corners));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr__Corners), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<CastleBlock, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CastleBlockSystem _CastleBlockSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr__CastleBlockSystem));
        return pointer == System.IntPtr.Zero ? (CastleBlockSystem) null : new CastleBlockSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr__CastleBlockSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleRailingsSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct FloorEventsGetCastleBlocksJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_AddedEvent;
      private static readonly System.IntPtr NativeFieldInfoPtr_RemovedEvent;
      private static readonly System.IntPtr NativeFieldInfoPtr_UpdatedEvent;
      private static readonly System.IntPtr NativeFieldInfoPtr_OutRailingBlocks;
      private static readonly System.IntPtr NativeFieldInfoPtr_OutCornerBlocks;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_AddFloorTile_Private_Void_byref_TilePosition_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.AddedEvent> AddedEvent;
      [FieldOffset(32)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.RemovedEvent> RemovedEvent;
      [FieldOffset(64)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.UpdatedEvent> UpdatedEvent;
      [FieldOffset(96)]
      public NativeHashSet<CastleWallBlock> OutRailingBlocks;
      [FieldOffset(112)]
      public NativeHashSet<CastleBlock> OutCornerBlocks;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203641, XrefRangeEnd = 1203702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.FloorEventsGetCastleBlocksJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1203735, RefRangeEnd = 1203739, XrefRangeStart = 1203702, XrefRangeEnd = 1203735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void AddFloorTile([In] ref TilePosition floorTile)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref floorTile;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.FloorEventsGetCastleBlocksJob.NativeMethodInfoPtr_AddFloorTile_Private_Void_byref_TilePosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static FloorEventsGetCastleBlocksJob()
      {
        Il2CppClassPointerStore<CastleRailingsSystem.FloorEventsGetCastleBlocksJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, nameof (FloorEventsGetCastleBlocksJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleRailingsSystem.FloorEventsGetCastleBlocksJob>.NativeClassPtr);
        CastleRailingsSystem.FloorEventsGetCastleBlocksJob.NativeFieldInfoPtr_AddedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.FloorEventsGetCastleBlocksJob>.NativeClassPtr, nameof (AddedEvent));
        CastleRailingsSystem.FloorEventsGetCastleBlocksJob.NativeFieldInfoPtr_RemovedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.FloorEventsGetCastleBlocksJob>.NativeClassPtr, nameof (RemovedEvent));
        CastleRailingsSystem.FloorEventsGetCastleBlocksJob.NativeFieldInfoPtr_UpdatedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.FloorEventsGetCastleBlocksJob>.NativeClassPtr, nameof (UpdatedEvent));
        CastleRailingsSystem.FloorEventsGetCastleBlocksJob.NativeFieldInfoPtr_OutRailingBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.FloorEventsGetCastleBlocksJob>.NativeClassPtr, nameof (OutRailingBlocks));
        CastleRailingsSystem.FloorEventsGetCastleBlocksJob.NativeFieldInfoPtr_OutCornerBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.FloorEventsGetCastleBlocksJob>.NativeClassPtr, nameof (OutCornerBlocks));
        CastleRailingsSystem.FloorEventsGetCastleBlocksJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem.FloorEventsGetCastleBlocksJob>.NativeClassPtr, 100664627);
        CastleRailingsSystem.FloorEventsGetCastleBlocksJob.NativeMethodInfoPtr_AddFloorTile_Private_Void_byref_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem.FloorEventsGetCastleBlocksJob>.NativeClassPtr, 100664628);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleRailingsSystem.FloorEventsGetCastleBlocksJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct WallEventsGetCastleBlocksJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityEvent;
      private static readonly System.IntPtr NativeFieldInfoPtr_AddedEvent;
      private static readonly System.IntPtr NativeFieldInfoPtr_RemovedEvent;
      private static readonly System.IntPtr NativeFieldInfoPtr_UpdatedEvent;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTileData;
      private static readonly System.IntPtr NativeFieldInfoPtr_OutRailingBlocks;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.EntityEvent> EntityEvent;
      [FieldOffset(32)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.AddedEvent> AddedEvent;
      [FieldOffset(64)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.RemovedEvent> RemovedEvent;
      [FieldOffset(96)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.UpdatedEvent> UpdatedEvent;
      [FieldOffset(128)]
      public ComponentDataFromEntity<TileData> GetTileData;
      [FieldOffset(160)]
      public NativeHashSet<CastleWallBlock> OutRailingBlocks;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203739, XrefRangeEnd = 1203780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.WallEventsGetCastleBlocksJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static WallEventsGetCastleBlocksJob()
      {
        Il2CppClassPointerStore<CastleRailingsSystem.WallEventsGetCastleBlocksJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, nameof (WallEventsGetCastleBlocksJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleRailingsSystem.WallEventsGetCastleBlocksJob>.NativeClassPtr);
        CastleRailingsSystem.WallEventsGetCastleBlocksJob.NativeFieldInfoPtr_EntityEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.WallEventsGetCastleBlocksJob>.NativeClassPtr, nameof (EntityEvent));
        CastleRailingsSystem.WallEventsGetCastleBlocksJob.NativeFieldInfoPtr_AddedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.WallEventsGetCastleBlocksJob>.NativeClassPtr, nameof (AddedEvent));
        CastleRailingsSystem.WallEventsGetCastleBlocksJob.NativeFieldInfoPtr_RemovedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.WallEventsGetCastleBlocksJob>.NativeClassPtr, nameof (RemovedEvent));
        CastleRailingsSystem.WallEventsGetCastleBlocksJob.NativeFieldInfoPtr_UpdatedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.WallEventsGetCastleBlocksJob>.NativeClassPtr, nameof (UpdatedEvent));
        CastleRailingsSystem.WallEventsGetCastleBlocksJob.NativeFieldInfoPtr_GetTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.WallEventsGetCastleBlocksJob>.NativeClassPtr, nameof (GetTileData));
        CastleRailingsSystem.WallEventsGetCastleBlocksJob.NativeFieldInfoPtr_OutRailingBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.WallEventsGetCastleBlocksJob>.NativeClassPtr, nameof (OutRailingBlocks));
        CastleRailingsSystem.WallEventsGetCastleBlocksJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem.WallEventsGetCastleBlocksJob>.NativeClassPtr, 100664629);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleRailingsSystem.WallEventsGetCastleBlocksJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct PillarEventsGetCastleBlocksJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_AddedEvent;
      private static readonly System.IntPtr NativeFieldInfoPtr_RemovedEvent;
      private static readonly System.IntPtr NativeFieldInfoPtr_UpdatedEvent;
      private static readonly System.IntPtr NativeFieldInfoPtr_OutCornerBlocks;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleWallPillar, TilePosition>.AddedEvent> AddedEvent;
      [FieldOffset(32)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleWallPillar, TilePosition>.RemovedEvent> RemovedEvent;
      [FieldOffset(64)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleWallPillar, TilePosition>.UpdatedEvent> UpdatedEvent;
      [FieldOffset(96)]
      public NativeHashSet<CastleBlock> OutCornerBlocks;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203780, XrefRangeEnd = 1203850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.PillarEventsGetCastleBlocksJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static PillarEventsGetCastleBlocksJob()
      {
        Il2CppClassPointerStore<CastleRailingsSystem.PillarEventsGetCastleBlocksJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, nameof (PillarEventsGetCastleBlocksJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleRailingsSystem.PillarEventsGetCastleBlocksJob>.NativeClassPtr);
        CastleRailingsSystem.PillarEventsGetCastleBlocksJob.NativeFieldInfoPtr_AddedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.PillarEventsGetCastleBlocksJob>.NativeClassPtr, nameof (AddedEvent));
        CastleRailingsSystem.PillarEventsGetCastleBlocksJob.NativeFieldInfoPtr_RemovedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.PillarEventsGetCastleBlocksJob>.NativeClassPtr, nameof (RemovedEvent));
        CastleRailingsSystem.PillarEventsGetCastleBlocksJob.NativeFieldInfoPtr_UpdatedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.PillarEventsGetCastleBlocksJob>.NativeClassPtr, nameof (UpdatedEvent));
        CastleRailingsSystem.PillarEventsGetCastleBlocksJob.NativeFieldInfoPtr_OutCornerBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.PillarEventsGetCastleBlocksJob>.NativeClassPtr, nameof (OutCornerBlocks));
        CastleRailingsSystem.PillarEventsGetCastleBlocksJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem.PillarEventsGetCastleBlocksJob>.NativeClassPtr, 100664630);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleRailingsSystem.PillarEventsGetCastleBlocksJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.Systems.CastleRailingsSystem/<>c__DisplayClass15_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass15_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_railingBlocks;
      private static readonly System.IntPtr NativeFieldInfoPtr_blockCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_tileWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentRailings;
      private static readonly System.IntPtr NativeFieldInfoPtr_railingsCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_lookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_cornerBlocks;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentCorners;
      private static readonly System.IntPtr NativeFieldInfoPtr_cornerPrefab;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_0;
      [FieldOffset(0)]
      public NativeHashSet<CastleWallBlock> railingBlocks;
      [FieldOffset(16)]
      public CastleBlockCollection blockCollection;
      [FieldOffset(64)]
      public TileWorld tileWorld;
      [FieldOffset(88)]
      public NativeHashMap<CastleWallBlock, Entity> currentRailings;
      [FieldOffset(104)]
      public CastleRailingPrefabsCollection railingsCollection;
      [FieldOffset(144)]
      public PrefabLookupMap lookupMap;
      [FieldOffset(192)]
      public EntityManager entityManager;
      [FieldOffset(200)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(216)]
      public NativeHashSet<CastleBlock> cornerBlocks;
      [FieldOffset(232)]
      public NativeHashMap<CastleBlock, Entity> currentCorners;
      [FieldOffset(248)]
      public Entity cornerPrefab;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass15_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.__c__DisplayClass15_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass15_0()
      {
        Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, "<>c__DisplayClass15_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass15_0>.NativeClassPtr);
        CastleRailingsSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_railingBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (railingBlocks));
        CastleRailingsSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_blockCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (blockCollection));
        CastleRailingsSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_tileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (tileWorld));
        CastleRailingsSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_currentRailings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (currentRailings));
        CastleRailingsSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_railingsCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (railingsCollection));
        CastleRailingsSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_lookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (lookupMap));
        CastleRailingsSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (entityManager));
        CastleRailingsSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (commandBuffer));
        CastleRailingsSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_cornerBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (cornerBlocks));
        CastleRailingsSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_currentCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (currentCorners));
        CastleRailingsSystem.__c__DisplayClass15_0.NativeFieldInfoPtr_cornerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass15_0>.NativeClassPtr, nameof (cornerPrefab));
        CastleRailingsSystem.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass15_0>.NativeClassPtr, 100664631);
        CastleRailingsSystem.__c__DisplayClass15_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass15_0>.NativeClassPtr, 100664632);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass15_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.Systems.CastleRailingsSystem/ProjectM.CastleBuilding.Systems.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_railingBlocks;
      private static readonly System.IntPtr NativeFieldInfoPtr_blockCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_tileWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentRailings;
      private static readonly System.IntPtr NativeFieldInfoPtr_railingsCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_lookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_cornerBlocks;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentCorners;
      private static readonly System.IntPtr NativeFieldInfoPtr_cornerPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass15_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass15_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleRailingsSystem_byref___c__DisplayClass15_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public NativeHashSet<CastleWallBlock> railingBlocks;
      [FieldOffset(16)]
      public CastleBlockCollection blockCollection;
      [FieldOffset(64)]
      public TileWorld tileWorld;
      [FieldOffset(88)]
      public NativeHashMap<CastleWallBlock, Entity> currentRailings;
      [FieldOffset(104)]
      public CastleRailingPrefabsCollection railingsCollection;
      [FieldOffset(144)]
      public PrefabLookupMap lookupMap;
      [FieldOffset(192)]
      public EntityManager entityManager;
      [FieldOffset(200)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(216)]
      public NativeHashSet<CastleBlock> cornerBlocks;
      [FieldOffset(232)]
      public NativeHashMap<CastleBlock, Entity> currentCorners;
      [FieldOffset(248)]
      public Entity cornerPrefab;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203925, XrefRangeEnd = 1203959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1203959, RefRangeEnd = 1203960, XrefRangeStart = 1203959, XrefRangeEnd = 1203959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref CastleRailingsSystem.__c__DisplayClass15_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass15_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1203960, RefRangeEnd = 1203961, XrefRangeStart = 1203960, XrefRangeEnd = 1203960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref CastleRailingsSystem.__c__DisplayClass15_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass15_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1203962, RefRangeEnd = 1203963, XrefRangeStart = 1203961, XrefRangeEnd = 1203962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1203964, RefRangeEnd = 1203965, XrefRangeStart = 1203963, XrefRangeEnd = 1203964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        CastleRailingsSystem componentSystem,
        ref CastleRailingsSystem.__c__DisplayClass15_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleRailingsSystem_byref___c__DisplayClass15_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203965, XrefRangeEnd = 1203969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1203982, RefRangeEnd = 1203983, XrefRangeStart = 1203969, XrefRangeEnd = 1203982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleRailingsSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_railingBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (railingBlocks));
        CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_blockCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (blockCollection));
        CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_tileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (tileWorld));
        CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_currentRailings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (currentRailings));
        CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_railingsCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (railingsCollection));
        CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_lookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (lookupMap));
        CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (entityManager));
        CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (commandBuffer));
        CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_cornerBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (cornerBlocks));
        CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_currentCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (currentCorners));
        CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_cornerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (cornerPrefab));
        CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664633);
        CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass15_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664634);
        CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass15_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664635);
        CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664636);
        CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleRailingsSystem_byref___c__DisplayClass15_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664637);
        CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664638);
        CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664639);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.Systems.CastleRailingsSystem/ProjectM.CastleBuilding.Systems.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.CastleBuilding.Systems.RunWithoutJobSystem_0000038D$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000038D$PostfixBurstDelegate");
          CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100664640);
          CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100664641);
          CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100664642);
          CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100664643);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.Systems.CastleRailingsSystem/ProjectM.CastleBuilding.Systems.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.CastleBuilding.Systems.RunWithoutJobSystem_0000038D$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203850, XrefRangeEnd = 1203864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203864, XrefRangeEnd = 1203882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203882, XrefRangeEnd = 1203897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1203924, RefRangeEnd = 1203925, XrefRangeStart = 1203897, XrefRangeEnd = 1203924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000038D$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664644);
          CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664645);
          CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664646);
          CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664647);
          CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664649);
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
            IL2CPP.il2cpp_field_static_get_value(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CastleRailingsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
