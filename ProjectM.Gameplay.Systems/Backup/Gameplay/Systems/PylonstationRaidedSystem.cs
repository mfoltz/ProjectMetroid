// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Systems.PylonstationRaidedSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding;
using ProjectM.Network;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Gameplay.Systems
{
  public class PylonstationRaidedSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ModificationSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__RaidedCastleHearts;
    private static readonly System.IntPtr NativeFieldInfoPtr__PersistenceWasLoadedEvent;
    private static readonly System.IntPtr NativeFieldInfoPtr___ClearDestroyedCastleHearts_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ClearDestroyedCastleHearts_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateRaidedCastleHearts_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateRaidedCastleHearts_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateImmaterialWhileRaided_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateImmaterialWhileRaided_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateHealth_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateHealth_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSwapArtWhileRaided_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSwapArtWhileRaided_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSpawnLocationsLocked_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSpawnLocationsLocked_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateRespawnPointsLocked_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateRespawnPointsLocked_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateCastleWaygatesLocked_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateCastleWaygatesLocked_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateCastleWaygatesMapIconsLocked_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateCastleWaygatesMapIconsLocked_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateRaidedStates_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsRaided_Private_Static_Boolean_byref_EntityManager_byref_NativeHashSet_1_Entity_byref_NetworkedEntity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsRaided_Private_Static_Boolean_byref_NativeHashSet_1_Entity_byref_CastleHeartConnection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForClearDestroyedCastleHearts_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateRaidedCastleHearts_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateImmaterialWhileRaided_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateHealth_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateSwapArtWhileRaided_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateSpawnLocationsLocked_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateRespawnPointsLocked_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateCastleWaygatesLocked_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateCastleWaygatesMapIconsLocked_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_3;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_4;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_5;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_6;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_7;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_8;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456933, XrefRangeEnd = 1456953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PylonstationRaidedSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456953, XrefRangeEnd = 1456956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PylonstationRaidedSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456956, XrefRangeEnd = 1456987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PylonstationRaidedSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1457092, RefRangeEnd = 1457093, XrefRangeStart = 1456987, XrefRangeEnd = 1457092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateRaidedStates()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.NativeMethodInfoPtr_UpdateRaidedStates_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1457099, RefRangeEnd = 1457103, XrefRangeStart = 1457093, XrefRangeEnd = 1457099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsRaided(
      ref EntityManager entityManager,
      [In] ref NativeHashSet<Entity> raidedCastleHearts,
      [In] ref NetworkedEntity connectedEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref raidedCastleHearts;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref connectedEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.NativeMethodInfoPtr_IsRaided_Private_Static_Boolean_byref_EntityManager_byref_NativeHashSet_1_Entity_byref_NetworkedEntity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1457106, RefRangeEnd = 1457110, XrefRangeStart = 1457103, XrefRangeEnd = 1457106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsRaided(
      [In] ref NativeHashSet<Entity> raidedCastleHearts,
      [In] ref CastleHeartConnection castleHeartConnection)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref raidedCastleHearts;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeartConnection;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.NativeMethodInfoPtr_IsRaided_Private_Static_Boolean_byref_NativeHashSet_1_Entity_byref_CastleHeartConnection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PylonstationRaidedSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1457110, XrefRangeEnd = 1457373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PylonstationRaidedSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1457373, XrefRangeEnd = 1457392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForClearDestroyedCastleHearts_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.NativeMethodInfoPtr___GetEntityQuery_ForClearDestroyedCastleHearts_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1457392, XrefRangeEnd = 1457408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateRaidedCastleHearts_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateRaidedCastleHearts_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1457436, RefRangeEnd = 1457437, XrefRangeStart = 1457408, XrefRangeEnd = 1457436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateImmaterialWhileRaided_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateImmaterialWhileRaided_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1457465, RefRangeEnd = 1457466, XrefRangeStart = 1457437, XrefRangeEnd = 1457465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateHealth_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateHealth_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1457466, XrefRangeEnd = 1457485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateSwapArtWhileRaided_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSwapArtWhileRaided_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1457485, XrefRangeEnd = 1457504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateSpawnLocationsLocked_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSpawnLocationsLocked_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1457504, XrefRangeEnd = 1457520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateRespawnPointsLocked_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateRespawnPointsLocked_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1457520, XrefRangeEnd = 1457539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateCastleWaygatesLocked_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateCastleWaygatesLocked_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1457539, XrefRangeEnd = 1457555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateCastleWaygatesMapIconsLocked_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateCastleWaygatesMapIconsLocked_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1457559, RefRangeEnd = 1457560, XrefRangeStart = 1457555, XrefRangeEnd = 1457559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1457564, RefRangeEnd = 1457565, XrefRangeStart = 1457560, XrefRangeEnd = 1457564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1457569, RefRangeEnd = 1457570, XrefRangeStart = 1457565, XrefRangeEnd = 1457569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1457574, RefRangeEnd = 1457575, XrefRangeStart = 1457570, XrefRangeEnd = 1457574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1457579, RefRangeEnd = 1457580, XrefRangeStart = 1457575, XrefRangeEnd = 1457579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_4()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.NativeMethodInfoPtr_Method_Public_Static_Void_4, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1457584, RefRangeEnd = 1457585, XrefRangeStart = 1457580, XrefRangeEnd = 1457584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_5()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.NativeMethodInfoPtr_Method_Public_Static_Void_5, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1457589, RefRangeEnd = 1457590, XrefRangeStart = 1457585, XrefRangeEnd = 1457589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_6()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.NativeMethodInfoPtr_Method_Public_Static_Void_6, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1457594, RefRangeEnd = 1457595, XrefRangeStart = 1457590, XrefRangeEnd = 1457594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_7()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.NativeMethodInfoPtr_Method_Public_Static_Void_7, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1457599, RefRangeEnd = 1457600, XrefRangeStart = 1457595, XrefRangeEnd = 1457599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_8()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.NativeMethodInfoPtr_Method_Public_Static_Void_8, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PylonstationRaidedSystem()
    {
      Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay.Systems", nameof (PylonstationRaidedSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr);
      PylonstationRaidedSystem.NativeFieldInfoPtr__ModificationSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, nameof (_ModificationSystem));
      PylonstationRaidedSystem.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, nameof (_NetworkIdSystem));
      PylonstationRaidedSystem.NativeFieldInfoPtr__RaidedCastleHearts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, nameof (_RaidedCastleHearts));
      PylonstationRaidedSystem.NativeFieldInfoPtr__PersistenceWasLoadedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, nameof (_PersistenceWasLoadedEvent));
      PylonstationRaidedSystem.NativeFieldInfoPtr___ClearDestroyedCastleHearts_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>ClearDestroyedCastleHearts_entityQuery");
      PylonstationRaidedSystem.NativeFieldInfoPtr___ClearDestroyedCastleHearts_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>ClearDestroyedCastleHearts_profilerMarker");
      PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateRaidedCastleHearts_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>UpdateRaidedCastleHearts_entityQuery");
      PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateRaidedCastleHearts_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>UpdateRaidedCastleHearts_profilerMarker");
      PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateImmaterialWhileRaided_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>UpdateImmaterialWhileRaided_entityQuery");
      PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateImmaterialWhileRaided_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>UpdateImmaterialWhileRaided_profilerMarker");
      PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateHealth_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>UpdateHealth_entityQuery");
      PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateHealth_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>UpdateHealth_profilerMarker");
      PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateSwapArtWhileRaided_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>UpdateSwapArtWhileRaided_entityQuery");
      PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateSwapArtWhileRaided_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>UpdateSwapArtWhileRaided_profilerMarker");
      PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateSpawnLocationsLocked_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>UpdateSpawnLocationsLocked_entityQuery");
      PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateSpawnLocationsLocked_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>UpdateSpawnLocationsLocked_profilerMarker");
      PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateRespawnPointsLocked_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>UpdateRespawnPointsLocked_entityQuery");
      PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateRespawnPointsLocked_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>UpdateRespawnPointsLocked_profilerMarker");
      PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateCastleWaygatesLocked_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>UpdateCastleWaygatesLocked_entityQuery");
      PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateCastleWaygatesLocked_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>UpdateCastleWaygatesLocked_profilerMarker");
      PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateCastleWaygatesMapIconsLocked_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>UpdateCastleWaygatesMapIconsLocked_entityQuery");
      PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateCastleWaygatesMapIconsLocked_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>UpdateCastleWaygatesMapIconsLocked_profilerMarker");
      PylonstationRaidedSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673158);
      PylonstationRaidedSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673159);
      PylonstationRaidedSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673160);
      PylonstationRaidedSystem.NativeMethodInfoPtr_UpdateRaidedStates_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673161);
      PylonstationRaidedSystem.NativeMethodInfoPtr_IsRaided_Private_Static_Boolean_byref_EntityManager_byref_NativeHashSet_1_Entity_byref_NetworkedEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673162);
      PylonstationRaidedSystem.NativeMethodInfoPtr_IsRaided_Private_Static_Boolean_byref_NativeHashSet_1_Entity_byref_CastleHeartConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673163);
      PylonstationRaidedSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673164);
      PylonstationRaidedSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673165);
      PylonstationRaidedSystem.NativeMethodInfoPtr___GetEntityQuery_ForClearDestroyedCastleHearts_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673166);
      PylonstationRaidedSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateRaidedCastleHearts_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673167);
      PylonstationRaidedSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateImmaterialWhileRaided_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673168);
      PylonstationRaidedSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateHealth_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673169);
      PylonstationRaidedSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSwapArtWhileRaided_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673170);
      PylonstationRaidedSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSpawnLocationsLocked_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673171);
      PylonstationRaidedSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateRespawnPointsLocked_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673172);
      PylonstationRaidedSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateCastleWaygatesLocked_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673173);
      PylonstationRaidedSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateCastleWaygatesMapIconsLocked_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673174);
      PylonstationRaidedSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673175);
      PylonstationRaidedSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673176);
      PylonstationRaidedSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673177);
      PylonstationRaidedSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673178);
      PylonstationRaidedSystem.NativeMethodInfoPtr_Method_Public_Static_Void_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673179);
      PylonstationRaidedSystem.NativeMethodInfoPtr_Method_Public_Static_Void_5 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673180);
      PylonstationRaidedSystem.NativeMethodInfoPtr_Method_Public_Static_Void_6 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673181);
      PylonstationRaidedSystem.NativeMethodInfoPtr_Method_Public_Static_Void_7 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673182);
      PylonstationRaidedSystem.NativeMethodInfoPtr_Method_Public_Static_Void_8 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, 100673183);
    }

    public PylonstationRaidedSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ModificationSystem _ModificationSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr__ModificationSystem));
        return pointer == System.IntPtr.Zero ? (ModificationSystem) null : new ModificationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr__ModificationSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == System.IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeHashSet<Entity> _RaidedCastleHearts
    {
      get
      {
        return *(NativeHashSet<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr__RaidedCastleHearts));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr__RaidedCastleHearts), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashSet<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _PersistenceWasLoadedEvent
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr__PersistenceWasLoadedEvent));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr__PersistenceWasLoadedEvent)) = value;
      }
    }

    public unsafe EntityQuery __ClearDestroyedCastleHearts_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___ClearDestroyedCastleHearts_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___ClearDestroyedCastleHearts_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ClearDestroyedCastleHearts_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___ClearDestroyedCastleHearts_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___ClearDestroyedCastleHearts_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateRaidedCastleHearts_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateRaidedCastleHearts_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateRaidedCastleHearts_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateRaidedCastleHearts_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateRaidedCastleHearts_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateRaidedCastleHearts_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateImmaterialWhileRaided_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateImmaterialWhileRaided_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateImmaterialWhileRaided_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateImmaterialWhileRaided_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateImmaterialWhileRaided_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateImmaterialWhileRaided_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateHealth_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateHealth_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateHealth_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateHealth_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateHealth_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateHealth_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateSwapArtWhileRaided_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateSwapArtWhileRaided_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateSwapArtWhileRaided_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateSwapArtWhileRaided_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateSwapArtWhileRaided_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateSwapArtWhileRaided_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateSpawnLocationsLocked_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateSpawnLocationsLocked_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateSpawnLocationsLocked_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateSpawnLocationsLocked_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateSpawnLocationsLocked_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateSpawnLocationsLocked_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateRespawnPointsLocked_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateRespawnPointsLocked_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateRespawnPointsLocked_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateRespawnPointsLocked_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateRespawnPointsLocked_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateRespawnPointsLocked_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateCastleWaygatesLocked_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateCastleWaygatesLocked_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateCastleWaygatesLocked_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateCastleWaygatesLocked_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateCastleWaygatesLocked_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateCastleWaygatesLocked_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateCastleWaygatesMapIconsLocked_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateCastleWaygatesMapIconsLocked_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateCastleWaygatesMapIconsLocked_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateCastleWaygatesMapIconsLocked_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateCastleWaygatesMapIconsLocked_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationRaidedSystem.NativeFieldInfoPtr___UpdateCastleWaygatesMapIconsLocked_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/<>c__DisplayClass6_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass6_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_raidedCastleHearts;
      private static readonly System.IntPtr NativeFieldInfoPtr_anyRaidStateChanged;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_Pylonstation_0;
      [FieldOffset(0)]
      public NativeHashSet<Entity> raidedCastleHearts;
      [FieldOffset(16)]
      public bool anyRaidStateChanged;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass6_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(Entity entity, [In] ref Pylonstation pylonstation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref pylonstation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_Pylonstation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass6_0()
      {
        Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>c__DisplayClass6_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass6_0>.NativeClassPtr);
        PylonstationRaidedSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_raidedCastleHearts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (raidedCastleHearts));
        PylonstationRaidedSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_anyRaidStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (anyRaidStateChanged));
        PylonstationRaidedSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass6_0>.NativeClassPtr, 100673184);
        PylonstationRaidedSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass6_0>.NativeClassPtr, 100673185);
        PylonstationRaidedSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_Pylonstation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass6_0>.NativeClassPtr, 100673186);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass6_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/<>c__DisplayClass7_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass7_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_raidedCastleHearts;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIds;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateRaidedStates_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_LongModificationBuffer_byref_CastleHeartConnection_byref_BuffableFlagState_byref_TileModel_byref_ImmaterialWhileRaided_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateRaidedStates_b__1_Internal_Void_Entity_byref_Health_byref_CastleHeartConnection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateRaidedStates_b__2_Internal_Void_Entity_byref_SwapArtWhileRaidedRoot_byref_CastleHeartConnection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateRaidedStates_b__3_Internal_Void_Entity_byref_SpawnLocationSelector_byref_MapIconTargetEntity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateRaidedStates_b__4_Internal_Void_Entity_byref_DynamicBuffer_1_RespawnPointOwnerBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateRaidedStates_b__5_Internal_Void_Entity_byref_ChunkWaypoint_byref_CastleHeartConnection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateRaidedStates_b__6_Internal_Void_Entity_byref_WaypointMapIcon_0;
      [FieldOffset(0)]
      public NativeHashSet<Entity> raidedCastleHearts;
      [FieldOffset(16)]
      public ModificationStructure modificationStruct;
      [FieldOffset(48)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(64)]
      public EntityManager entityManager;
      [FieldOffset(72)]
      public NativeHashMap<NetworkId, Entity> networkIds;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateRaidedStates_b__0(
        Entity entity,
        ref DynamicBuffer<LongModificationBuffer> flagModifications,
        [In] ref CastleHeartConnection castleHeartConnection,
        [In] ref BuffableFlagState flagState,
        [In] ref TileModel tileModel,
        [In] ref ImmaterialWhileRaided immaterialWhileRaided)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref flagModifications;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeartConnection;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref flagState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileModel;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref immaterialWhileRaided;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateRaidedStates_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_LongModificationBuffer_byref_CastleHeartConnection_byref_BuffableFlagState_byref_TileModel_byref_ImmaterialWhileRaided_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateRaidedStates_b__1(
        Entity entity,
        [In] ref Health health,
        [In] ref CastleHeartConnection castleHeartConnection)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref health;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeartConnection;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateRaidedStates_b__1_Internal_Void_Entity_byref_Health_byref_CastleHeartConnection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateRaidedStates_b__2(
        Entity entity,
        [In] ref SwapArtWhileRaidedRoot swapArtRoot,
        [In] ref CastleHeartConnection castleHeartConnection)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref swapArtRoot;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeartConnection;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateRaidedStates_b__2_Internal_Void_Entity_byref_SwapArtWhileRaidedRoot_byref_CastleHeartConnection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateRaidedStates_b__3(
        Entity mapIconEntity,
        [In] ref SpawnLocationSelector spawnLocationSelector,
        [In] ref MapIconTargetEntity targetEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &mapIconEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnLocationSelector;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref targetEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateRaidedStates_b__3_Internal_Void_Entity_byref_SpawnLocationSelector_byref_MapIconTargetEntity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateRaidedStates_b__4(
        Entity entity,
        [In] ref DynamicBuffer<RespawnPointOwnerBuffer> respawnPoints)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref respawnPoints;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateRaidedStates_b__4_Internal_Void_Entity_byref_DynamicBuffer_1_RespawnPointOwnerBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateRaidedStates_b__5(
        Entity entity,
        [In] ref ChunkWaypoint waypoint,
        [In] ref CastleHeartConnection castleHeartConnection)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref waypoint;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeartConnection;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateRaidedStates_b__5_Internal_Void_Entity_byref_ChunkWaypoint_byref_CastleHeartConnection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateRaidedStates_b__6(Entity entity, [In] ref WaypointMapIcon waypoint)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref waypoint;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateRaidedStates_b__6_Internal_Void_Entity_byref_WaypointMapIcon_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_0()
      {
        Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>c__DisplayClass7_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass7_0>.NativeClassPtr);
        PylonstationRaidedSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_raidedCastleHearts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (raidedCastleHearts));
        PylonstationRaidedSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (modificationStruct));
        PylonstationRaidedSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (commandBuffer));
        PylonstationRaidedSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (entityManager));
        PylonstationRaidedSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_networkIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (networkIds));
        PylonstationRaidedSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass7_0>.NativeClassPtr, 100673187);
        PylonstationRaidedSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateRaidedStates_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_LongModificationBuffer_byref_CastleHeartConnection_byref_BuffableFlagState_byref_TileModel_byref_ImmaterialWhileRaided_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass7_0>.NativeClassPtr, 100673188);
        PylonstationRaidedSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateRaidedStates_b__1_Internal_Void_Entity_byref_Health_byref_CastleHeartConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass7_0>.NativeClassPtr, 100673189);
        PylonstationRaidedSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateRaidedStates_b__2_Internal_Void_Entity_byref_SwapArtWhileRaidedRoot_byref_CastleHeartConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass7_0>.NativeClassPtr, 100673190);
        PylonstationRaidedSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateRaidedStates_b__3_Internal_Void_Entity_byref_SpawnLocationSelector_byref_MapIconTargetEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass7_0>.NativeClassPtr, 100673191);
        PylonstationRaidedSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateRaidedStates_b__4_Internal_Void_Entity_byref_DynamicBuffer_1_RespawnPointOwnerBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass7_0>.NativeClassPtr, 100673192);
        PylonstationRaidedSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateRaidedStates_b__5_Internal_Void_Entity_byref_ChunkWaypoint_byref_CastleHeartConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass7_0>.NativeClassPtr, 100673193);
        PylonstationRaidedSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateRaidedStates_b__6_Internal_Void_Entity_byref_WaypointMapIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass7_0>.NativeClassPtr, 100673194);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass7_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ClearDestroyedCastleHearts")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ClearDestroyedCastleHearts
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_raidedCastleHearts;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashSet<Entity> raidedCastleHearts;
      [FieldOffset(16)]
      public PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(24)]
      public unsafe PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1455888, XrefRangeEnd = 1455891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PylonstationRaidedSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PylonstationRaidedSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1455891, XrefRangeEnd = 1455893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1455896, RefRangeEnd = 1455897, XrefRangeStart = 1455893, XrefRangeEnd = 1455896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10)]
      [CachedScanResults(RefRangeStart = 1035887, RefRangeEnd = 1035897, XrefRangeStart = 1035887, XrefRangeEnd = 1035897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PylonstationRaidedSystem componentSystem,
        ref PylonstationRaidedSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1455897, XrefRangeEnd = 1455901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1455901, XrefRangeEnd = 1455907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ClearDestroyedCastleHearts()
      {
        Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>c__DisplayClass_ClearDestroyedCastleHearts");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts>.NativeClassPtr);
        PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeFieldInfoPtr_raidedCastleHearts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts>.NativeClassPtr, nameof (raidedCastleHearts));
        PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts>.NativeClassPtr, nameof (_runtimes));
        PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts>.NativeClassPtr, 100673195);
        PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts>.NativeClassPtr, 100673196);
        PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts>.NativeClassPtr, 100673197);
        PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts>.NativeClassPtr, 100673198);
        PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts>.NativeClassPtr, 100673199);
        PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts>.NativeClassPtr, 100673200);
        PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts>.NativeClassPtr, 100673201);
        PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts>.NativeClassPtr, 100673202);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;

        [CallerCount(25)]
        [CachedScanResults(RefRangeStart = 742675, RefRangeEnd = 742700, XrefRangeStart = 742675, XrefRangeEnd = 742700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PylonstationRaidedSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(25)]
        [CachedScanResults(RefRangeStart = 742701, RefRangeEnd = 742726, XrefRangeStart = 742701, XrefRangeEnd = 742726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, 100673203);
          PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, 100673204);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;

          static Runtimes()
          {
            Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ClearDestroyedCastleHearts/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000017BD$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts>.NativeClassPtr, "RunWithoutJobSystem_000017BD$PostfixBurstDelegate");
          PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673205);
          PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673206);
          PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673207);
          PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673208);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ClearDestroyedCastleHearts/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000017BD$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1455813, XrefRangeEnd = 1455827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1455827, XrefRangeEnd = 1455845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1455845, XrefRangeEnd = 1455860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1455887, RefRangeEnd = 1455888, XrefRangeStart = 1455860, XrefRangeEnd = 1455887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts>.NativeClassPtr, "RunWithoutJobSystem_000017BD$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673209);
          PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673210);
          PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673211);
          PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673212);
          PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673214);
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
            IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_ClearDestroyedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateRaidedCastleHearts")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateRaidedCastleHearts
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_anyRaidStateChanged;
      private static readonly System.IntPtr NativeFieldInfoPtr_raidedCastleHearts;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Pylonstation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public bool anyRaidStateChanged;
      [FieldOffset(8)]
      public NativeHashSet<Entity> raidedCastleHearts;
      [FieldOffset(24)]
      public PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(64)]
      public unsafe PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1455992, XrefRangeEnd = 1455999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref Pylonstation pylonstation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref pylonstation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Pylonstation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1455999, RefRangeEnd = 1456000, XrefRangeStart = 1455999, XrefRangeEnd = 1455999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PylonstationRaidedSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1456000, RefRangeEnd = 1456001, XrefRangeStart = 1456000, XrefRangeEnd = 1456000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PylonstationRaidedSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456001, XrefRangeEnd = 1456003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1456009, RefRangeEnd = 1456010, XrefRangeStart = 1456003, XrefRangeEnd = 1456009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1456012, RefRangeEnd = 1456013, XrefRangeStart = 1456010, XrefRangeEnd = 1456012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PylonstationRaidedSystem componentSystem,
        ref PylonstationRaidedSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456013, XrefRangeEnd = 1456017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456017, XrefRangeEnd = 1456023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateRaidedCastleHearts()
      {
        Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateRaidedCastleHearts");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts>.NativeClassPtr);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeFieldInfoPtr_anyRaidStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts>.NativeClassPtr, nameof (anyRaidStateChanged));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeFieldInfoPtr_raidedCastleHearts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts>.NativeClassPtr, nameof (raidedCastleHearts));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts>.NativeClassPtr, nameof (_runtimes));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Pylonstation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts>.NativeClassPtr, 100673215);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts>.NativeClassPtr, 100673216);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts>.NativeClassPtr, 100673217);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts>.NativeClassPtr, 100673218);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts>.NativeClassPtr, 100673219);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts>.NativeClassPtr, 100673220);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts>.NativeClassPtr, 100673221);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts>.NativeClassPtr, 100673222);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_pylonstation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Pylonstation> forParameter_pylonstation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1455911, RefRangeEnd = 1455912, XrefRangeStart = 1455907, XrefRangeEnd = 1455911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PylonstationRaidedSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1455916, RefRangeEnd = 1455917, XrefRangeStart = 1455912, XrefRangeEnd = 1455916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_pylonstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_pylonstation));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, 100673223);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, 100673224);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_pylonstation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Pylonstation>.Runtime runtime_pylonstation;

          static Runtimes()
          {
            Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_pylonstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_pylonstation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateRaidedCastleHearts/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000017C6$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts>.NativeClassPtr, "RunWithoutJobSystem_000017C6$PostfixBurstDelegate");
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673225);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673226);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673227);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673228);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateRaidedCastleHearts/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000017C6$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1455917, XrefRangeEnd = 1455931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1455931, XrefRangeEnd = 1455949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1455949, XrefRangeEnd = 1455964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1455991, RefRangeEnd = 1455992, XrefRangeStart = 1455964, XrefRangeEnd = 1455991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts>.NativeClassPtr, "RunWithoutJobSystem_000017C6$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673229);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673230);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673231);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673232);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673234);
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
            IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateRaidedCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateImmaterialWhileRaided")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateImmaterialWhileRaided
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_raidedCastleHearts;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_LongModificationBuffer_byref_CastleHeartConnection_byref_BuffableFlagState_byref_TileModel_byref_ImmaterialWhileRaided_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashSet<Entity> raidedCastleHearts;
      [FieldOffset(16)]
      public ModificationStructure modificationStruct;
      [FieldOffset(48)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(64)]
      public PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(240)]
      public unsafe PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456132, XrefRangeEnd = 1456150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref DynamicBuffer<LongModificationBuffer> flagModifications,
        [In] ref CastleHeartConnection castleHeartConnection,
        [In] ref BuffableFlagState flagState,
        [In] ref TileModel tileModel,
        [In] ref ImmaterialWhileRaided immaterialWhileRaided)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref flagModifications;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeartConnection;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref flagState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileModel;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref immaterialWhileRaided;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_LongModificationBuffer_byref_CastleHeartConnection_byref_BuffableFlagState_byref_TileModel_byref_ImmaterialWhileRaided_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1121402, RefRangeEnd = 1121405, XrefRangeStart = 1121402, XrefRangeEnd = 1121405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PylonstationRaidedSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1121405, RefRangeEnd = 1121408, XrefRangeStart = 1121405, XrefRangeEnd = 1121408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PylonstationRaidedSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456150, XrefRangeEnd = 1456152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1456170, RefRangeEnd = 1456171, XrefRangeStart = 1456152, XrefRangeEnd = 1456170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1456173, RefRangeEnd = 1456174, XrefRangeStart = 1456171, XrefRangeEnd = 1456173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PylonstationRaidedSystem componentSystem,
        ref PylonstationRaidedSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456174, XrefRangeEnd = 1456178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456178, XrefRangeEnd = 1456184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateImmaterialWhileRaided()
      {
        Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateImmaterialWhileRaided");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided>.NativeClassPtr);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeFieldInfoPtr_raidedCastleHearts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided>.NativeClassPtr, nameof (raidedCastleHearts));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided>.NativeClassPtr, nameof (modificationStruct));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided>.NativeClassPtr, nameof (commandBuffer));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided>.NativeClassPtr, nameof (_runtimes));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_LongModificationBuffer_byref_CastleHeartConnection_byref_BuffableFlagState_byref_TileModel_byref_ImmaterialWhileRaided_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided>.NativeClassPtr, 100673235);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided>.NativeClassPtr, 100673236);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided>.NativeClassPtr, 100673237);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided>.NativeClassPtr, 100673238);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided>.NativeClassPtr, 100673239);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided>.NativeClassPtr, 100673240);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided>.NativeClassPtr, 100673241);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided>.NativeClassPtr, 100673242);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_flagModifications;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castleHeartConnection;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_flagState;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_tileModel;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_immaterialWhileRaided;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<LongModificationBuffer> forParameter_flagModifications;
        [FieldOffset(48)]
        public LambdaParameterValueProvider_IComponentData<CastleHeartConnection> forParameter_castleHeartConnection;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_IComponentData<BuffableFlagState> forParameter_flagState;
        [FieldOffset(112)]
        public LambdaParameterValueProvider_IComponentData<TileModel> forParameter_tileModel;
        [FieldOffset(144)]
        public LambdaParameterValueProvider_IComponentData<ImmaterialWhileRaided> forParameter_immaterialWhileRaided;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1456039, RefRangeEnd = 1456040, XrefRangeStart = 1456023, XrefRangeEnd = 1456039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PylonstationRaidedSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1456056, RefRangeEnd = 1456057, XrefRangeStart = 1456040, XrefRangeEnd = 1456056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_flagModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_flagModifications));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castleHeartConnection));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_flagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_flagState));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_tileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_tileModel));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_immaterialWhileRaided = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_immaterialWhileRaided));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders>.NativeClassPtr, 100673243);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders>.NativeClassPtr, 100673244);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_flagModifications;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castleHeartConnection;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_flagState;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_tileModel;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_immaterialWhileRaided;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<LongModificationBuffer>.Runtime runtime_flagModifications;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<CastleHeartConnection>.Runtime runtime_castleHeartConnection;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_IComponentData<BuffableFlagState>.Runtime runtime_flagState;
          [FieldOffset(48)]
          public LambdaParameterValueProvider_IComponentData<TileModel>.Runtime runtime_tileModel;
          [FieldOffset(56)]
          public LambdaParameterValueProvider_IComponentData<ImmaterialWhileRaided>.Runtime runtime_immaterialWhileRaided;

          static Runtimes()
          {
            Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_flagModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_flagModifications));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castleHeartConnection));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_flagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_flagState));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_tileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_tileModel));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_immaterialWhileRaided = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_immaterialWhileRaided));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateImmaterialWhileRaided/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000017CF$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided>.NativeClassPtr, "RunWithoutJobSystem_000017CF$PostfixBurstDelegate");
          PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673245);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673246);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673247);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673248);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateImmaterialWhileRaided/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000017CF$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456057, XrefRangeEnd = 1456071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456071, XrefRangeEnd = 1456089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456089, XrefRangeEnd = 1456104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1456131, RefRangeEnd = 1456132, XrefRangeStart = 1456104, XrefRangeEnd = 1456131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided>.NativeClassPtr, "RunWithoutJobSystem_000017CF$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673249);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673250);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673251);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673252);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673254);
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
            IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateImmaterialWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateHealth")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateHealth
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_raidedCastleHearts;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Health_byref_CastleHeartConnection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashSet<Entity> raidedCastleHearts;
      [FieldOffset(16)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(32)]
      public PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(104)]
      public unsafe PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456275, XrefRangeEnd = 1456279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref Health health,
        [In] ref CastleHeartConnection castleHeartConnection)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref health;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeartConnection;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Health_byref_CastleHeartConnection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1456279, RefRangeEnd = 1456282, XrefRangeStart = 1456279, XrefRangeEnd = 1456279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PylonstationRaidedSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1456282, RefRangeEnd = 1456285, XrefRangeStart = 1456282, XrefRangeEnd = 1456282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PylonstationRaidedSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456285, XrefRangeEnd = 1456287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1456296, RefRangeEnd = 1456297, XrefRangeStart = 1456287, XrefRangeEnd = 1456296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1456299, RefRangeEnd = 1456300, XrefRangeStart = 1456297, XrefRangeEnd = 1456299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PylonstationRaidedSystem componentSystem,
        ref PylonstationRaidedSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456300, XrefRangeEnd = 1456304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456304, XrefRangeEnd = 1456310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateHealth()
      {
        Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateHealth");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth>.NativeClassPtr);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeFieldInfoPtr_raidedCastleHearts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth>.NativeClassPtr, nameof (raidedCastleHearts));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth>.NativeClassPtr, nameof (commandBuffer));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth>.NativeClassPtr, nameof (_runtimes));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Health_byref_CastleHeartConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth>.NativeClassPtr, 100673255);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth>.NativeClassPtr, 100673256);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth>.NativeClassPtr, 100673257);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth>.NativeClassPtr, 100673258);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth>.NativeClassPtr, 100673259);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth>.NativeClassPtr, 100673260);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth>.NativeClassPtr, 100673261);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth>.NativeClassPtr, 100673262);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_health;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castleHeartConnection;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Health> forParameter_health;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<CastleHeartConnection> forParameter_castleHeartConnection;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1456191, RefRangeEnd = 1456192, XrefRangeStart = 1456184, XrefRangeEnd = 1456191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PylonstationRaidedSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1456199, RefRangeEnd = 1456200, XrefRangeStart = 1456192, XrefRangeEnd = 1456199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_health));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castleHeartConnection));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders>.NativeClassPtr, 100673263);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders>.NativeClassPtr, 100673264);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_health;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castleHeartConnection;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Health>.Runtime runtime_health;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<CastleHeartConnection>.Runtime runtime_castleHeartConnection;

          static Runtimes()
          {
            Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_health));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castleHeartConnection));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateHealth/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000017D8$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth>.NativeClassPtr, "RunWithoutJobSystem_000017D8$PostfixBurstDelegate");
          PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673265);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673266);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673267);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673268);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateHealth/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000017D8$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456200, XrefRangeEnd = 1456214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456214, XrefRangeEnd = 1456232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456232, XrefRangeEnd = 1456247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1456274, RefRangeEnd = 1456275, XrefRangeStart = 1456247, XrefRangeEnd = 1456274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth>.NativeClassPtr, "RunWithoutJobSystem_000017D8$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673269);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673270);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673271);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673272);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673274);
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
            IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateHealth.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateSwapArtWhileRaided")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateSwapArtWhileRaided
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_raidedCastleHearts;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SwapArtWhileRaidedRoot_byref_CastleHeartConnection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashSet<Entity> raidedCastleHearts;
      [FieldOffset(16)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(32)]
      public PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(104)]
      public unsafe PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456401, XrefRangeEnd = 1456405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref SwapArtWhileRaidedRoot swapArtRoot,
        [In] ref CastleHeartConnection castleHeartConnection)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref swapArtRoot;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeartConnection;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SwapArtWhileRaidedRoot_byref_CastleHeartConnection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1456279, RefRangeEnd = 1456282, XrefRangeStart = 1456279, XrefRangeEnd = 1456282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PylonstationRaidedSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1456282, RefRangeEnd = 1456285, XrefRangeStart = 1456282, XrefRangeEnd = 1456285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PylonstationRaidedSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456405, XrefRangeEnd = 1456407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1456416, RefRangeEnd = 1456417, XrefRangeStart = 1456407, XrefRangeEnd = 1456416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1456419, RefRangeEnd = 1456420, XrefRangeStart = 1456417, XrefRangeEnd = 1456419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PylonstationRaidedSystem componentSystem,
        ref PylonstationRaidedSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456420, XrefRangeEnd = 1456424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456424, XrefRangeEnd = 1456430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateSwapArtWhileRaided()
      {
        Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateSwapArtWhileRaided");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided>.NativeClassPtr);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeFieldInfoPtr_raidedCastleHearts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided>.NativeClassPtr, nameof (raidedCastleHearts));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided>.NativeClassPtr, nameof (commandBuffer));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided>.NativeClassPtr, nameof (_runtimes));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SwapArtWhileRaidedRoot_byref_CastleHeartConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided>.NativeClassPtr, 100673275);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided>.NativeClassPtr, 100673276);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided>.NativeClassPtr, 100673277);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided>.NativeClassPtr, 100673278);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided>.NativeClassPtr, 100673279);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided>.NativeClassPtr, 100673280);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided>.NativeClassPtr, 100673281);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided>.NativeClassPtr, 100673282);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_swapArtRoot;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castleHeartConnection;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<SwapArtWhileRaidedRoot> forParameter_swapArtRoot;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<CastleHeartConnection> forParameter_castleHeartConnection;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1456317, RefRangeEnd = 1456318, XrefRangeStart = 1456310, XrefRangeEnd = 1456317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PylonstationRaidedSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1456325, RefRangeEnd = 1456326, XrefRangeStart = 1456318, XrefRangeEnd = 1456325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_swapArtRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_swapArtRoot));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castleHeartConnection));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders>.NativeClassPtr, 100673283);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders>.NativeClassPtr, 100673284);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_swapArtRoot;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castleHeartConnection;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<SwapArtWhileRaidedRoot>.Runtime runtime_swapArtRoot;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<CastleHeartConnection>.Runtime runtime_castleHeartConnection;

          static Runtimes()
          {
            Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_swapArtRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_swapArtRoot));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castleHeartConnection));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateSwapArtWhileRaided/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000017E1$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided>.NativeClassPtr, "RunWithoutJobSystem_000017E1$PostfixBurstDelegate");
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673285);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673286);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673287);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673288);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateSwapArtWhileRaided/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000017E1$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456326, XrefRangeEnd = 1456340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456340, XrefRangeEnd = 1456358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456358, XrefRangeEnd = 1456373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1456400, RefRangeEnd = 1456401, XrefRangeStart = 1456373, XrefRangeEnd = 1456400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided>.NativeClassPtr, "RunWithoutJobSystem_000017E1$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673289);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673290);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673291);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673292);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673294);
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
            IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateSwapArtWhileRaided.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateSpawnLocationsLocked")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateSpawnLocationsLocked
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_raidedCastleHearts;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SpawnLocationSelector_byref_MapIconTargetEntity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeHashSet<Entity> raidedCastleHearts;
      [FieldOffset(24)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(40)]
      public PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(112)]
      public unsafe PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456521, XrefRangeEnd = 1456525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity mapIconEntity,
        [In] ref SpawnLocationSelector spawnLocationSelector,
        [In] ref MapIconTargetEntity targetEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &mapIconEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnLocationSelector;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref targetEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SpawnLocationSelector_byref_MapIconTargetEntity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1456525, RefRangeEnd = 1456527, XrefRangeStart = 1456525, XrefRangeEnd = 1456525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PylonstationRaidedSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1456527, RefRangeEnd = 1456529, XrefRangeStart = 1456527, XrefRangeEnd = 1456527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PylonstationRaidedSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456529, XrefRangeEnd = 1456531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1456540, RefRangeEnd = 1456541, XrefRangeStart = 1456531, XrefRangeEnd = 1456540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1456543, RefRangeEnd = 1456544, XrefRangeStart = 1456541, XrefRangeEnd = 1456543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PylonstationRaidedSystem componentSystem,
        ref PylonstationRaidedSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456544, XrefRangeEnd = 1456548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456548, XrefRangeEnd = 1456554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateSpawnLocationsLocked()
      {
        Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateSpawnLocationsLocked");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked>.NativeClassPtr);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked>.NativeClassPtr, nameof (entityManager));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeFieldInfoPtr_raidedCastleHearts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked>.NativeClassPtr, nameof (raidedCastleHearts));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked>.NativeClassPtr, nameof (commandBuffer));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked>.NativeClassPtr, nameof (_runtimes));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SpawnLocationSelector_byref_MapIconTargetEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked>.NativeClassPtr, 100673295);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked>.NativeClassPtr, 100673296);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked>.NativeClassPtr, 100673297);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked>.NativeClassPtr, 100673298);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked>.NativeClassPtr, 100673299);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked>.NativeClassPtr, 100673300);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked>.NativeClassPtr, 100673301);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked>.NativeClassPtr, 100673302);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_mapIconEntity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_spawnLocationSelector;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_targetEntity;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_mapIconEntity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<SpawnLocationSelector> forParameter_spawnLocationSelector;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<MapIconTargetEntity> forParameter_targetEntity;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1456437, RefRangeEnd = 1456438, XrefRangeStart = 1456430, XrefRangeEnd = 1456437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PylonstationRaidedSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1456445, RefRangeEnd = 1456446, XrefRangeStart = 1456438, XrefRangeEnd = 1456445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_mapIconEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_mapIconEntity));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_spawnLocationSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_spawnLocationSelector));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_targetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_targetEntity));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders>.NativeClassPtr, 100673303);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders>.NativeClassPtr, 100673304);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_mapIconEntity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_spawnLocationSelector;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_targetEntity;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_mapIconEntity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<SpawnLocationSelector>.Runtime runtime_spawnLocationSelector;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<MapIconTargetEntity>.Runtime runtime_targetEntity;

          static Runtimes()
          {
            Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_mapIconEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_mapIconEntity));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_spawnLocationSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_spawnLocationSelector));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_targetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_targetEntity));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateSpawnLocationsLocked/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000017EA$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked>.NativeClassPtr, "RunWithoutJobSystem_000017EA$PostfixBurstDelegate");
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673305);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673306);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673307);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673308);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateSpawnLocationsLocked/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000017EA$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456446, XrefRangeEnd = 1456460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456460, XrefRangeEnd = 1456478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456478, XrefRangeEnd = 1456493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1456520, RefRangeEnd = 1456521, XrefRangeStart = 1456493, XrefRangeEnd = 1456520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked>.NativeClassPtr, "RunWithoutJobSystem_000017EA$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673309);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673310);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673311);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673312);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673314);
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
            IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateSpawnLocationsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateRespawnPointsLocked")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateRespawnPointsLocked
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_raidedCastleHearts;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_RespawnPointOwnerBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeHashSet<Entity> raidedCastleHearts;
      [FieldOffset(24)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(40)]
      public PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456639, XrefRangeEnd = 1456677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref DynamicBuffer<RespawnPointOwnerBuffer> respawnPoints)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref respawnPoints;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_RespawnPointOwnerBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1456525, RefRangeEnd = 1456527, XrefRangeStart = 1456525, XrefRangeEnd = 1456527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PylonstationRaidedSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1456527, RefRangeEnd = 1456529, XrefRangeStart = 1456527, XrefRangeEnd = 1456529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PylonstationRaidedSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456677, XrefRangeEnd = 1456679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1456685, RefRangeEnd = 1456686, XrefRangeStart = 1456679, XrefRangeEnd = 1456685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1456688, RefRangeEnd = 1456689, XrefRangeStart = 1456686, XrefRangeEnd = 1456688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PylonstationRaidedSystem componentSystem,
        ref PylonstationRaidedSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456689, XrefRangeEnd = 1456693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456693, XrefRangeEnd = 1456699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateRespawnPointsLocked()
      {
        Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateRespawnPointsLocked");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked>.NativeClassPtr);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked>.NativeClassPtr, nameof (entityManager));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeFieldInfoPtr_raidedCastleHearts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked>.NativeClassPtr, nameof (raidedCastleHearts));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked>.NativeClassPtr, nameof (commandBuffer));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked>.NativeClassPtr, nameof (_runtimes));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_RespawnPointOwnerBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked>.NativeClassPtr, 100673315);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked>.NativeClassPtr, 100673316);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked>.NativeClassPtr, 100673317);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked>.NativeClassPtr, 100673318);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked>.NativeClassPtr, 100673319);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked>.NativeClassPtr, 100673320);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked>.NativeClassPtr, 100673321);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked>.NativeClassPtr, 100673322);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_respawnPoints;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<RespawnPointOwnerBuffer> forParameter_respawnPoints;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1456558, RefRangeEnd = 1456559, XrefRangeStart = 1456554, XrefRangeEnd = 1456558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PylonstationRaidedSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1456563, RefRangeEnd = 1456564, XrefRangeStart = 1456559, XrefRangeEnd = 1456563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_respawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_respawnPoints));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders>.NativeClassPtr, 100673323);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders>.NativeClassPtr, 100673324);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_respawnPoints;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<RespawnPointOwnerBuffer>.Runtime runtime_respawnPoints;

          static Runtimes()
          {
            Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_respawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_respawnPoints));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateRespawnPointsLocked/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000017F3$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked>.NativeClassPtr, "RunWithoutJobSystem_000017F3$PostfixBurstDelegate");
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673325);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673326);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673327);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673328);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateRespawnPointsLocked/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000017F3$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456564, XrefRangeEnd = 1456578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456578, XrefRangeEnd = 1456596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456596, XrefRangeEnd = 1456611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1456638, RefRangeEnd = 1456639, XrefRangeStart = 1456611, XrefRangeEnd = 1456638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked>.NativeClassPtr, "RunWithoutJobSystem_000017F3$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673329);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673330);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673331);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673332);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673334);
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
            IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateRespawnPointsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateCastleWaygatesLocked")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateCastleWaygatesLocked
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_raidedCastleHearts;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ChunkWaypoint_byref_CastleHeartConnection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashSet<Entity> raidedCastleHearts;
      [FieldOffset(16)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(32)]
      public PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(104)]
      public unsafe PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456790, XrefRangeEnd = 1456794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref ChunkWaypoint waypoint,
        [In] ref CastleHeartConnection castleHeartConnection)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref waypoint;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeartConnection;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ChunkWaypoint_byref_CastleHeartConnection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1456279, RefRangeEnd = 1456282, XrefRangeStart = 1456279, XrefRangeEnd = 1456282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PylonstationRaidedSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1456282, RefRangeEnd = 1456285, XrefRangeStart = 1456282, XrefRangeEnd = 1456285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PylonstationRaidedSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456794, XrefRangeEnd = 1456796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1456805, RefRangeEnd = 1456806, XrefRangeStart = 1456796, XrefRangeEnd = 1456805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1456808, RefRangeEnd = 1456809, XrefRangeStart = 1456806, XrefRangeEnd = 1456808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PylonstationRaidedSystem componentSystem,
        ref PylonstationRaidedSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456809, XrefRangeEnd = 1456813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456813, XrefRangeEnd = 1456819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateCastleWaygatesLocked()
      {
        Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateCastleWaygatesLocked");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked>.NativeClassPtr);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeFieldInfoPtr_raidedCastleHearts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked>.NativeClassPtr, nameof (raidedCastleHearts));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked>.NativeClassPtr, nameof (commandBuffer));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked>.NativeClassPtr, nameof (_runtimes));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ChunkWaypoint_byref_CastleHeartConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked>.NativeClassPtr, 100673335);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked>.NativeClassPtr, 100673336);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked>.NativeClassPtr, 100673337);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked>.NativeClassPtr, 100673338);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked>.NativeClassPtr, 100673339);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked>.NativeClassPtr, 100673340);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked>.NativeClassPtr, 100673341);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked>.NativeClassPtr, 100673342);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_waypoint;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castleHeartConnection;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<ChunkWaypoint> forParameter_waypoint;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<CastleHeartConnection> forParameter_castleHeartConnection;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1456706, RefRangeEnd = 1456707, XrefRangeStart = 1456699, XrefRangeEnd = 1456706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PylonstationRaidedSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1456714, RefRangeEnd = 1456715, XrefRangeStart = 1456707, XrefRangeEnd = 1456714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_waypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_waypoint));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castleHeartConnection));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders>.NativeClassPtr, 100673343);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders>.NativeClassPtr, 100673344);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_waypoint;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castleHeartConnection;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<ChunkWaypoint>.Runtime runtime_waypoint;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<CastleHeartConnection>.Runtime runtime_castleHeartConnection;

          static Runtimes()
          {
            Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_waypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_waypoint));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castleHeartConnection));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateCastleWaygatesLocked/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000017FC$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked>.NativeClassPtr, "RunWithoutJobSystem_000017FC$PostfixBurstDelegate");
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673345);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673346);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673347);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673348);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateCastleWaygatesLocked/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000017FC$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456715, XrefRangeEnd = 1456729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456729, XrefRangeEnd = 1456747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456747, XrefRangeEnd = 1456762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1456789, RefRangeEnd = 1456790, XrefRangeStart = 1456762, XrefRangeEnd = 1456789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked>.NativeClassPtr, "RunWithoutJobSystem_000017FC$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673349);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673350);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673351);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673352);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673354);
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
            IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateCastleWaygatesMapIconsLocked")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateCastleWaygatesMapIconsLocked
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_raidedCastleHearts;
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIds;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_WaypointMapIcon_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeHashSet<Entity> raidedCastleHearts;
      [FieldOffset(24)]
      public NativeHashMap<NetworkId, Entity> networkIds;
      [FieldOffset(40)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(56)]
      public PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(96)]
      public unsafe PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456904, XrefRangeEnd = 1456909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref WaypointMapIcon waypoint)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref waypoint;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_WaypointMapIcon_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1456909, RefRangeEnd = 1456910, XrefRangeStart = 1456909, XrefRangeEnd = 1456909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PylonstationRaidedSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1456910, RefRangeEnd = 1456911, XrefRangeStart = 1456910, XrefRangeEnd = 1456910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PylonstationRaidedSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456911, XrefRangeEnd = 1456913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1456919, RefRangeEnd = 1456920, XrefRangeStart = 1456913, XrefRangeEnd = 1456919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1456922, RefRangeEnd = 1456923, XrefRangeStart = 1456920, XrefRangeEnd = 1456922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PylonstationRaidedSystem componentSystem,
        ref PylonstationRaidedSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456923, XrefRangeEnd = 1456927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456927, XrefRangeEnd = 1456933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateCastleWaygatesMapIconsLocked()
      {
        Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateCastleWaygatesMapIconsLocked");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked>.NativeClassPtr);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked>.NativeClassPtr, nameof (entityManager));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeFieldInfoPtr_raidedCastleHearts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked>.NativeClassPtr, nameof (raidedCastleHearts));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeFieldInfoPtr_networkIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked>.NativeClassPtr, nameof (networkIds));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked>.NativeClassPtr, nameof (commandBuffer));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked>.NativeClassPtr, nameof (_runtimes));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_WaypointMapIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked>.NativeClassPtr, 100673355);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked>.NativeClassPtr, 100673356);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked>.NativeClassPtr, 100673357);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked>.NativeClassPtr, 100673358);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked>.NativeClassPtr, 100673359);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked>.NativeClassPtr, 100673360);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked>.NativeClassPtr, 100673361);
        PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked>.NativeClassPtr, 100673362);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_waypoint;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<WaypointMapIcon> forParameter_waypoint;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1456823, RefRangeEnd = 1456824, XrefRangeStart = 1456819, XrefRangeEnd = 1456823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PylonstationRaidedSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1456828, RefRangeEnd = 1456829, XrefRangeStart = 1456824, XrefRangeEnd = 1456828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_waypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_waypoint));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationRaidedSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders>.NativeClassPtr, 100673363);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders>.NativeClassPtr, 100673364);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_waypoint;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<WaypointMapIcon>.Runtime runtime_waypoint;

          static Runtimes()
          {
            Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_waypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_waypoint));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateCastleWaygatesMapIconsLocked/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001805$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked>.NativeClassPtr, "RunWithoutJobSystem_00001805$PostfixBurstDelegate");
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673365);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673366);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673367);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673368);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationRaidedSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpdateCastleWaygatesMapIconsLocked/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001805$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456829, XrefRangeEnd = 1456843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456843, XrefRangeEnd = 1456861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1456861, XrefRangeEnd = 1456876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1456903, RefRangeEnd = 1456904, XrefRangeStart = 1456876, XrefRangeEnd = 1456903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked>.NativeClassPtr, "RunWithoutJobSystem_00001805$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673369);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673370);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673371);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673372);
          PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673374);
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
            IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PylonstationRaidedSystem.__c__DisplayClass_UpdateCastleWaygatesMapIconsLocked.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
