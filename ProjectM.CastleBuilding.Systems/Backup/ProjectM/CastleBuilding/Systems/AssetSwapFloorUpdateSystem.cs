// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Systems.AssetSwapFloorUpdateSystem
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.CastleBuilding.AssetSwapping;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;

#nullable disable
namespace ProjectM.CastleBuilding.Systems
{
  public class AssetSwapFloorUpdateSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CastleBlockSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CastleRailingsSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__FloorEntityEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__WallEntityEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__PillarEntityEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__DirtySwappableWalls;
    private static readonly System.IntPtr NativeFieldInfoPtr__DirtySwappablePillars;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClockwisePillarFloorOffsets;
    private static readonly System.IntPtr NativeFieldInfoPtr_StairNeighborDirections;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsFloor_Private_Static_Boolean_byref_EntityManager_byref_CastleFloorBlockCollection_CastleBlock_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSwapFlags_Private_Static_AssetSwapFlags_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWallSwapState_Private_Static_Void_byref_EntityManager_Entity_byref_CastleBlockCollection_byref_TileWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePillarSwapState_Private_Static_Void_byref_EntityManager_Entity_byref_CastleBlockCollection_byref_TileWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VerifyLedgeIsNotDoubleStairsEntrance_Private_Static_Boolean_byref_EntityManager_byref_CastleFloorBlockCollection_byref_CastleBlock_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202997, XrefRangeEnd = 1203042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AssetSwapFloorUpdateSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203042, XrefRangeEnd = 1203047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AssetSwapFloorUpdateSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203047, XrefRangeEnd = 1203110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AssetSwapFloorUpdateSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1203119, RefRangeEnd = 1203125, XrefRangeStart = 1203110, XrefRangeEnd = 1203119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsFloor(
      [In] ref EntityManager entityManager,
      [In] ref CastleFloorBlockCollection floorCollection,
      CastleBlock block)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref floorCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &block;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.NativeMethodInfoPtr_IsFloor_Private_Static_Boolean_byref_EntityManager_byref_CastleFloorBlockCollection_CastleBlock_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe AssetSwapFlags GetSwapFlags(
      bool hasGround,
      bool hasFloor,
      bool hasCeiling,
      bool hasStructureBelow,
      bool hasStructureAbove,
      bool hasLedgeAbove,
      bool hasFloorLedge)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &hasGround;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hasFloor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hasCeiling;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &hasStructureBelow;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &hasStructureAbove;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &hasLedgeAbove;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &hasFloorLedge;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.NativeMethodInfoPtr_GetSwapFlags_Private_Static_AssetSwapFlags_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AssetSwapFlags*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1203189, RefRangeEnd = 1203190, XrefRangeStart = 1203125, XrefRangeEnd = 1203189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateWallSwapState(
      ref EntityManager entityManager,
      Entity wallEntity,
      [In] ref CastleBlockCollection blockCollection,
      ref TileWorld tileWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &wallEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref blockCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileWorld;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.NativeMethodInfoPtr_UpdateWallSwapState_Private_Static_Void_byref_EntityManager_Entity_byref_CastleBlockCollection_byref_TileWorld_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1203263, RefRangeEnd = 1203264, XrefRangeStart = 1203190, XrefRangeEnd = 1203263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdatePillarSwapState(
      ref EntityManager entityManager,
      Entity pillarEntity,
      [In] ref CastleBlockCollection blockCollection,
      ref TileWorld tileWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pillarEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref blockCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileWorld;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.NativeMethodInfoPtr_UpdatePillarSwapState_Private_Static_Void_byref_EntityManager_Entity_byref_CastleBlockCollection_byref_TileWorld_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1203296, RefRangeEnd = 1203297, XrefRangeStart = 1203264, XrefRangeEnd = 1203296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool VerifyLedgeIsNotDoubleStairsEntrance(
      [In] ref EntityManager entityManager,
      [In] ref CastleFloorBlockCollection floors,
      [In] ref CastleBlock ceilingBlock)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref floors;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ceilingBlock;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.NativeMethodInfoPtr_VerifyLedgeIsNotDoubleStairsEntrance_Private_Static_Boolean_byref_EntityManager_byref_CastleFloorBlockCollection_byref_CastleBlock_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AssetSwapFloorUpdateSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203297, XrefRangeEnd = 1203349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AssetSwapFloorUpdateSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203349, XrefRangeEnd = 1203365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203365, XrefRangeEnd = 1203369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203369, XrefRangeEnd = 1203373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AssetSwapFloorUpdateSystem()
    {
      Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.CastleBuilding.Systems", nameof (AssetSwapFloorUpdateSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr);
      AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__CastleBlockSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, nameof (_CastleBlockSystem));
      AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, nameof (_TileWorldSystem));
      AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__CastleRailingsSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, nameof (_CastleRailingsSystem));
      AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__FloorEntityEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, nameof (_FloorEntityEventQuery));
      AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__WallEntityEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, nameof (_WallEntityEventQuery));
      AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__PillarEntityEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, nameof (_PillarEntityEventQuery));
      AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__DirtySwappableWalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, nameof (_DirtySwappableWalls));
      AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__DirtySwappablePillars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, nameof (_DirtySwappablePillars));
      AssetSwapFloorUpdateSystem.NativeFieldInfoPtr_ClockwisePillarFloorOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, nameof (ClockwisePillarFloorOffsets));
      AssetSwapFloorUpdateSystem.NativeFieldInfoPtr_StairNeighborDirections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, nameof (StairNeighborDirections));
      AssetSwapFloorUpdateSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      AssetSwapFloorUpdateSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      AssetSwapFloorUpdateSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob1_profilerMarker");
      AssetSwapFloorUpdateSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, 100664521);
      AssetSwapFloorUpdateSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, 100664522);
      AssetSwapFloorUpdateSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, 100664523);
      AssetSwapFloorUpdateSystem.NativeMethodInfoPtr_IsFloor_Private_Static_Boolean_byref_EntityManager_byref_CastleFloorBlockCollection_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, 100664524);
      AssetSwapFloorUpdateSystem.NativeMethodInfoPtr_GetSwapFlags_Private_Static_AssetSwapFlags_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, 100664525);
      AssetSwapFloorUpdateSystem.NativeMethodInfoPtr_UpdateWallSwapState_Private_Static_Void_byref_EntityManager_Entity_byref_CastleBlockCollection_byref_TileWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, 100664526);
      AssetSwapFloorUpdateSystem.NativeMethodInfoPtr_UpdatePillarSwapState_Private_Static_Void_byref_EntityManager_Entity_byref_CastleBlockCollection_byref_TileWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, 100664527);
      AssetSwapFloorUpdateSystem.NativeMethodInfoPtr_VerifyLedgeIsNotDoubleStairsEntrance_Private_Static_Boolean_byref_EntityManager_byref_CastleFloorBlockCollection_byref_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, 100664528);
      AssetSwapFloorUpdateSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, 100664529);
      AssetSwapFloorUpdateSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, 100664531);
      AssetSwapFloorUpdateSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, 100664532);
      AssetSwapFloorUpdateSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, 100664533);
      AssetSwapFloorUpdateSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, 100664534);
    }

    public AssetSwapFloorUpdateSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CastleBlockSystem _CastleBlockSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__CastleBlockSystem));
        return pointer == System.IntPtr.Zero ? (CastleBlockSystem) null : new CastleBlockSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__CastleBlockSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CastleRailingsSystem _CastleRailingsSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__CastleRailingsSystem));
        return pointer == System.IntPtr.Zero ? (CastleRailingsSystem) null : new CastleRailingsSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__CastleRailingsSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _FloorEntityEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__FloorEntityEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__FloorEntityEventQuery)) = value;
      }
    }

    public unsafe EntityQuery _WallEntityEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__WallEntityEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__WallEntityEventQuery)) = value;
      }
    }

    public unsafe EntityQuery _PillarEntityEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__PillarEntityEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__PillarEntityEventQuery)) = value;
      }
    }

    public unsafe NativeHashSet<Entity> _DirtySwappableWalls
    {
      get
      {
        return *(NativeHashSet<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__DirtySwappableWalls));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__DirtySwappableWalls), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashSet<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashSet<Entity> _DirtySwappablePillars
    {
      get
      {
        return *(NativeHashSet<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__DirtySwappablePillars));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr__DirtySwappablePillars), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashSet<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public static unsafe Il2CppStructArray<int3> ClockwisePillarFloorOffsets
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr_ClockwisePillarFloorOffsets, (void*) &num);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<int3>) null : new Il2CppStructArray<int3>(nativeObject);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr_ClockwisePillarFloorOffsets, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppStructArray<CardinalDirection> StairNeighborDirections
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr_StairNeighborDirections, (void*) &num);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<CardinalDirection>) null : new Il2CppStructArray<CardinalDirection>(nativeObject);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr_StairNeighborDirections, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwapFloorUpdateSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GetDirtyAssetSwapWallAndPillarsFromFloorsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityEvent;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetAssetSwapState;
      private static readonly System.IntPtr NativeFieldInfoPtr_BlockCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_RailingsCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_OutSwappableWalls;
      private static readonly System.IntPtr NativeFieldInfoPtr_OutSwappablePillars;
      private static readonly System.IntPtr NativeFieldInfoPtr_CheckOffsets;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_AddSwappableWalls_Private_Void_byref_CastleBlock_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_AddSwappablePillars_Private_Void_byref_CastleBlock_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.EntityEvent> EntityEvent;
      [FieldOffset(32)]
      public ComponentDataFromEntity<TilePosition> GetTilePosition;
      [FieldOffset(64)]
      public ComponentDataFromEntity<AssetSwapState> GetAssetSwapState;
      [FieldOffset(96)]
      public CastleBlockCollection BlockCollection;
      [FieldOffset(144)]
      public CastleRailingsCollection RailingsCollection;
      [FieldOffset(176)]
      public NativeHashSet<Entity> OutSwappableWalls;
      [FieldOffset(192)]
      public NativeHashSet<Entity> OutSwappablePillars;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202516, XrefRangeEnd = 1202546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1202562, RefRangeEnd = 1202563, XrefRangeStart = 1202546, XrefRangeEnd = 1202562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void AddSwappableWalls([In] ref CastleBlock block)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref block;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob.NativeMethodInfoPtr_AddSwappableWalls_Private_Void_byref_CastleBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1202579, RefRangeEnd = 1202580, XrefRangeStart = 1202563, XrefRangeEnd = 1202579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void AddSwappablePillars([In] ref CastleBlock block)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref block;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob.NativeMethodInfoPtr_AddSwappablePillars_Private_Void_byref_CastleBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static GetDirtyAssetSwapWallAndPillarsFromFloorsJob()
      {
        Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, nameof (GetDirtyAssetSwapWallAndPillarsFromFloorsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob>.NativeClassPtr);
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob.NativeFieldInfoPtr_EntityEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob>.NativeClassPtr, nameof (EntityEvent));
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob.NativeFieldInfoPtr_GetTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob>.NativeClassPtr, nameof (GetTilePosition));
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob.NativeFieldInfoPtr_GetAssetSwapState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob>.NativeClassPtr, nameof (GetAssetSwapState));
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob.NativeFieldInfoPtr_BlockCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob>.NativeClassPtr, nameof (BlockCollection));
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob.NativeFieldInfoPtr_RailingsCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob>.NativeClassPtr, nameof (RailingsCollection));
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob.NativeFieldInfoPtr_OutSwappableWalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob>.NativeClassPtr, nameof (OutSwappableWalls));
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob.NativeFieldInfoPtr_OutSwappablePillars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob>.NativeClassPtr, nameof (OutSwappablePillars));
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob.NativeFieldInfoPtr_CheckOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob>.NativeClassPtr, nameof (CheckOffsets));
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob>.NativeClassPtr, 100664535);
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob.NativeMethodInfoPtr_AddSwappableWalls_Private_Void_byref_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob>.NativeClassPtr, 100664536);
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob.NativeMethodInfoPtr_AddSwappablePillars_Private_Void_byref_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob>.NativeClassPtr, 100664537);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe Il2CppStructArray<int3> CheckOffsets
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob.NativeFieldInfoPtr_CheckOffsets, (void*) &num);
          System.IntPtr nativeObject = num;
          return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<int3>) null : new Il2CppStructArray<int3>(nativeObject);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallAndPillarsFromFloorsJob.NativeFieldInfoPtr_CheckOffsets, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GetDirtyAssetSwapWallsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityEvent;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTileData;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetAssetSwapState;
      private static readonly System.IntPtr NativeFieldInfoPtr_BlockCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_RailingsCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_OutSwappableWalls;
      private static readonly System.IntPtr NativeFieldInfoPtr_CheckOffsets;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_AddNearbySwappableWalls_Private_Void_Entity_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.EntityEvent> EntityEvent;
      [FieldOffset(32)]
      public ComponentDataFromEntity<TilePosition> GetTilePosition;
      [FieldOffset(64)]
      public ComponentDataFromEntity<TileData> GetTileData;
      [FieldOffset(96)]
      public ComponentDataFromEntity<AssetSwapState> GetAssetSwapState;
      [FieldOffset(128)]
      public CastleWallBlockCollection BlockCollection;
      [FieldOffset(144)]
      public CastleRailingsCollection RailingsCollection;
      [FieldOffset(176)]
      public NativeHashSet<Entity> OutSwappableWalls;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202580, XrefRangeEnd = 1202606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1202636, RefRangeEnd = 1202637, XrefRangeStart = 1202606, XrefRangeEnd = 1202636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void AddNearbySwappableWalls(Entity wallEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &wallEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob.NativeMethodInfoPtr_AddNearbySwappableWalls_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static GetDirtyAssetSwapWallsJob()
      {
        Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, nameof (GetDirtyAssetSwapWallsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob>.NativeClassPtr);
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob.NativeFieldInfoPtr_EntityEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob>.NativeClassPtr, nameof (EntityEvent));
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob.NativeFieldInfoPtr_GetTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob>.NativeClassPtr, nameof (GetTilePosition));
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob.NativeFieldInfoPtr_GetTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob>.NativeClassPtr, nameof (GetTileData));
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob.NativeFieldInfoPtr_GetAssetSwapState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob>.NativeClassPtr, nameof (GetAssetSwapState));
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob.NativeFieldInfoPtr_BlockCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob>.NativeClassPtr, nameof (BlockCollection));
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob.NativeFieldInfoPtr_RailingsCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob>.NativeClassPtr, nameof (RailingsCollection));
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob.NativeFieldInfoPtr_OutSwappableWalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob>.NativeClassPtr, nameof (OutSwappableWalls));
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob.NativeFieldInfoPtr_CheckOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob>.NativeClassPtr, nameof (CheckOffsets));
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob>.NativeClassPtr, 100664539);
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob.NativeMethodInfoPtr_AddNearbySwappableWalls_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob>.NativeClassPtr, 100664540);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe Il2CppStructArray<int3> CheckOffsets
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob.NativeFieldInfoPtr_CheckOffsets, (void*) &num);
          System.IntPtr nativeObject = num;
          return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<int3>) null : new Il2CppStructArray<int3>(nativeObject);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AssetSwapFloorUpdateSystem.GetDirtyAssetSwapWallsJob.NativeFieldInfoPtr_CheckOffsets, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GetDirtyAssetSwapPillarsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityEvent;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetAssetSwapState;
      private static readonly System.IntPtr NativeFieldInfoPtr_BlockCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_RailingsCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_OutSwappablePillars;
      private static readonly System.IntPtr NativeFieldInfoPtr_CheckOffsets;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_AddNearbySwappablePillars_Private_Void_Entity_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleWallPillar, TilePosition>.EntityEvent> EntityEvent;
      [FieldOffset(32)]
      public ComponentDataFromEntity<TilePosition> GetTilePosition;
      [FieldOffset(64)]
      public ComponentDataFromEntity<AssetSwapState> GetAssetSwapState;
      [FieldOffset(96)]
      public CastlePillarBlockCollection BlockCollection;
      [FieldOffset(112)]
      public CastleRailingsCollection RailingsCollection;
      [FieldOffset(144)]
      public NativeHashSet<Entity> OutSwappablePillars;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202637, XrefRangeEnd = 1202663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1202684, RefRangeEnd = 1202685, XrefRangeStart = 1202663, XrefRangeEnd = 1202684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void AddNearbySwappablePillars(Entity pillarEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &pillarEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob.NativeMethodInfoPtr_AddNearbySwappablePillars_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static GetDirtyAssetSwapPillarsJob()
      {
        Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, nameof (GetDirtyAssetSwapPillarsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob>.NativeClassPtr);
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob.NativeFieldInfoPtr_EntityEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob>.NativeClassPtr, nameof (EntityEvent));
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob.NativeFieldInfoPtr_GetTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob>.NativeClassPtr, nameof (GetTilePosition));
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob.NativeFieldInfoPtr_GetAssetSwapState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob>.NativeClassPtr, nameof (GetAssetSwapState));
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob.NativeFieldInfoPtr_BlockCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob>.NativeClassPtr, nameof (BlockCollection));
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob.NativeFieldInfoPtr_RailingsCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob>.NativeClassPtr, nameof (RailingsCollection));
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob.NativeFieldInfoPtr_OutSwappablePillars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob>.NativeClassPtr, nameof (OutSwappablePillars));
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob.NativeFieldInfoPtr_CheckOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob>.NativeClassPtr, nameof (CheckOffsets));
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob>.NativeClassPtr, 100664542);
        AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob.NativeMethodInfoPtr_AddNearbySwappablePillars_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob>.NativeClassPtr, 100664543);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe Il2CppStructArray<int3> CheckOffsets
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob.NativeFieldInfoPtr_CheckOffsets, (void*) &num);
          System.IntPtr nativeObject = num;
          return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<int3>) null : new Il2CppStructArray<int3>(nativeObject);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AssetSwapFloorUpdateSystem.GetDirtyAssetSwapPillarsJob.NativeFieldInfoPtr_CheckOffsets, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.Systems.AssetSwapFloorUpdateSystem/<>c__DisplayClass10_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass10_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_dirtySwappableWalls;
      private static readonly System.IntPtr NativeFieldInfoPtr_dirtySwappablePillars;
      private static readonly System.IntPtr NativeFieldInfoPtr_blockCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_tileWorld;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_WallpaperUpdatedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeHashSet<Entity> dirtySwappableWalls;
      [FieldOffset(24)]
      public NativeHashSet<Entity> dirtySwappablePillars;
      [FieldOffset(40)]
      public CastleBlockCollection blockCollection;
      [FieldOffset(88)]
      public TileWorld tileWorld;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass10_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0([In] ref WallpaperUpdatedEvent updatedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref updatedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_WallpaperUpdatedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass10_0()
      {
        Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, "<>c__DisplayClass10_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass10_0>.NativeClassPtr);
        AssetSwapFloorUpdateSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (entityManager));
        AssetSwapFloorUpdateSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_dirtySwappableWalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (dirtySwappableWalls));
        AssetSwapFloorUpdateSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_dirtySwappablePillars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (dirtySwappablePillars));
        AssetSwapFloorUpdateSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_blockCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (blockCollection));
        AssetSwapFloorUpdateSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_tileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (tileWorld));
        AssetSwapFloorUpdateSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass10_0>.NativeClassPtr, 100664545);
        AssetSwapFloorUpdateSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_WallpaperUpdatedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass10_0>.NativeClassPtr, 100664546);
        AssetSwapFloorUpdateSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass10_0>.NativeClassPtr, 100664547);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass10_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.Systems.AssetSwapFloorUpdateSystem/ProjectM.CastleBuilding.Systems.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_dirtySwappableWalls;
      private static readonly System.IntPtr NativeFieldInfoPtr_dirtySwappablePillars;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_WallpaperUpdatedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSwapFloorUpdateSystem_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeHashSet<Entity> dirtySwappableWalls;
      [FieldOffset(24)]
      public NativeHashSet<Entity> dirtySwappablePillars;
      [FieldOffset(40)]
      public AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(72)]
      public unsafe AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202768, XrefRangeEnd = 1202782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref WallpaperUpdatedEvent updatedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref updatedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_WallpaperUpdatedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 999090, RefRangeEnd = 999093, XrefRangeStart = 999090, XrefRangeEnd = 999093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AssetSwapFloorUpdateSystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 999093, RefRangeEnd = 999096, XrefRangeStart = 999093, XrefRangeEnd = 999096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AssetSwapFloorUpdateSystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202782, XrefRangeEnd = 1202784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1202789, RefRangeEnd = 1202790, XrefRangeStart = 1202784, XrefRangeEnd = 1202789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1202792, RefRangeEnd = 1202793, XrefRangeStart = 1202790, XrefRangeEnd = 1202792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AssetSwapFloorUpdateSystem componentSystem,
        ref AssetSwapFloorUpdateSystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSwapFloorUpdateSystem_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202793, XrefRangeEnd = 1202797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202797, XrefRangeEnd = 1202803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (entityManager));
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_dirtySwappableWalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (dirtySwappableWalls));
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_dirtySwappablePillars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (dirtySwappablePillars));
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_WallpaperUpdatedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664548);
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664549);
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664550);
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664551);
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664552);
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSwapFloorUpdateSystem_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664553);
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664554);
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664555);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_updatedEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSwapFloorUpdateSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<WallpaperUpdatedEvent> forParameter_updatedEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1202688, RefRangeEnd = 1202689, XrefRangeStart = 1202685, XrefRangeEnd = 1202688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AssetSwapFloorUpdateSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSwapFloorUpdateSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1202692, RefRangeEnd = 1202693, XrefRangeStart = 1202689, XrefRangeEnd = 1202692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_updatedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_updatedEvent));
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSwapFloorUpdateSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664556);
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664557);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_updatedEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<WallpaperUpdatedEvent>.Runtime runtime_updatedEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_updatedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_updatedEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.Systems.AssetSwapFloorUpdateSystem/ProjectM.CastleBuilding.Systems.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.CastleBuilding.Systems.RunWithoutJobSystem_0000035C$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000035C$PostfixBurstDelegate");
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664558);
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664559);
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664560);
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664561);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.Systems.AssetSwapFloorUpdateSystem/ProjectM.CastleBuilding.Systems.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.CastleBuilding.Systems.RunWithoutJobSystem_0000035C$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202693, XrefRangeEnd = 1202707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202707, XrefRangeEnd = 1202725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202725, XrefRangeEnd = 1202740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1202767, RefRangeEnd = 1202768, XrefRangeStart = 1202740, XrefRangeEnd = 1202767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000035C$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664562);
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664563);
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664564);
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664565);
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664567);
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
            IL2CPP.il2cpp_field_static_get_value(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.Systems.AssetSwapFloorUpdateSystem/ProjectM.CastleBuilding.Systems.<>c__DisplayClass_OnUpdate_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_dirtySwappableWalls;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_blockCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_tileWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_dirtySwappablePillars;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSwapFloorUpdateSystem_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public NativeHashSet<Entity> dirtySwappableWalls;
      [FieldOffset(16)]
      public EntityManager entityManager;
      [FieldOffset(24)]
      public CastleBlockCollection blockCollection;
      [FieldOffset(72)]
      public TileWorld tileWorld;
      [FieldOffset(96)]
      public NativeHashSet<Entity> dirtySwappablePillars;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202878, XrefRangeEnd = 1202913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1202913, RefRangeEnd = 1202914, XrefRangeStart = 1202913, XrefRangeEnd = 1202913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AssetSwapFloorUpdateSystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1202914, RefRangeEnd = 1202915, XrefRangeStart = 1202914, XrefRangeEnd = 1202914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AssetSwapFloorUpdateSystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1202916, RefRangeEnd = 1202917, XrefRangeStart = 1202915, XrefRangeEnd = 1202916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1202918, RefRangeEnd = 1202919, XrefRangeStart = 1202917, XrefRangeEnd = 1202918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AssetSwapFloorUpdateSystem componentSystem,
        ref AssetSwapFloorUpdateSystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSwapFloorUpdateSystem_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202919, XrefRangeEnd = 1202923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1202996, RefRangeEnd = 1202997, XrefRangeStart = 1202923, XrefRangeEnd = 1202996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob1()
      {
        Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr);
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_dirtySwappableWalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (dirtySwappableWalls));
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (entityManager));
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_blockCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (blockCollection));
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_tileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (tileWorld));
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_dirtySwappablePillars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (dirtySwappablePillars));
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100664568);
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100664569);
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100664570);
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100664571);
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSwapFloorUpdateSystem_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100664572);
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100664573);
        AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100664574);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.Systems.AssetSwapFloorUpdateSystem/ProjectM.CastleBuilding.Systems.<>c__DisplayClass_OnUpdate_LambdaJob1/ProjectM.CastleBuilding.Systems.RunWithoutJobSystem_00000364$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000364$PostfixBurstDelegate");
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100664575);
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100664576);
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100664577);
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100664578);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.Systems.AssetSwapFloorUpdateSystem/ProjectM.CastleBuilding.Systems.<>c__DisplayClass_OnUpdate_LambdaJob1/ProjectM.CastleBuilding.Systems.RunWithoutJobSystem_00000364$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202803, XrefRangeEnd = 1202817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202817, XrefRangeEnd = 1202835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202835, XrefRangeEnd = 1202850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1202877, RefRangeEnd = 1202878, XrefRangeStart = 1202850, XrefRangeEnd = 1202877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000364$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664579);
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664580);
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664581);
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664582);
          AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664584);
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
            IL2CPP.il2cpp_field_static_get_value(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AssetSwapFloorUpdateSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
