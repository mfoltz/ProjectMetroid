// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnRegionUpdateSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding.Placement;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class SpawnRegionUpdateSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinimumRespawnAttemptDelay;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaximumRespawnAttemptDelay;
    private static readonly System.IntPtr NativeFieldInfoPtr_PenaltySecondsPerFailedSpawn;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxSpawnAttemptsPerFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__EventPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlacementSystemData;
    private static readonly System.IntPtr NativeFieldInfoPtr__QueuedSpawnRequests;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlacementProfilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReplaceAIQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__DetachAIQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTimeAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSpawnRegions_entityQuery;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleUpdateSpawnRegions_Private_Void_EntityCommandBuffer_ServerTime_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateSpawnRegions_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072791, XrefRangeEnd = 1072842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpawnRegionUpdateSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072842, XrefRangeEnd = 1072849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpawnRegionUpdateSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072849, XrefRangeEnd = 1072899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpawnRegionUpdateSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1072947, RefRangeEnd = 1072948, XrefRangeStart = 1072899, XrefRangeEnd = 1072947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ScheduleUpdateSpawnRegions(
      EntityCommandBuffer spawnECB,
      ServerTime serverTime)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spawnECB;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.NativeMethodInfoPtr_ScheduleUpdateSpawnRegions_Private_Void_EntityCommandBuffer_ServerTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpawnRegionUpdateSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072948, XrefRangeEnd = 1072950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpawnRegionUpdateSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1072975, RefRangeEnd = 1072976, XrefRangeStart = 1072950, XrefRangeEnd = 1072975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateSpawnRegions_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSpawnRegions_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SpawnRegionUpdateSystem()
    {
      Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SpawnRegionUpdateSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr);
      SpawnRegionUpdateSystem.NativeFieldInfoPtr_MinimumRespawnAttemptDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, nameof (MinimumRespawnAttemptDelay));
      SpawnRegionUpdateSystem.NativeFieldInfoPtr_MaximumRespawnAttemptDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, nameof (MaximumRespawnAttemptDelay));
      SpawnRegionUpdateSystem.NativeFieldInfoPtr_PenaltySecondsPerFailedSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, nameof (PenaltySecondsPerFailedSpawn));
      SpawnRegionUpdateSystem.NativeFieldInfoPtr_MaxSpawnAttemptsPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, nameof (MaxSpawnAttemptsPerFrame));
      SpawnRegionUpdateSystem.NativeFieldInfoPtr__SpawnBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, nameof (_SpawnBarrier));
      SpawnRegionUpdateSystem.NativeFieldInfoPtr__EventPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, nameof (_EventPrefab));
      SpawnRegionUpdateSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      SpawnRegionUpdateSystem.NativeFieldInfoPtr__PlacementSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, nameof (_PlacementSystemData));
      SpawnRegionUpdateSystem.NativeFieldInfoPtr__QueuedSpawnRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, nameof (_QueuedSpawnRequests));
      SpawnRegionUpdateSystem.NativeFieldInfoPtr__PlacementProfilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, nameof (_PlacementProfilerMarker));
      SpawnRegionUpdateSystem.NativeFieldInfoPtr__ReplaceAIQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, nameof (_ReplaceAIQuery));
      SpawnRegionUpdateSystem.NativeFieldInfoPtr__DetachAIQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, nameof (_DetachAIQuery));
      SpawnRegionUpdateSystem.NativeFieldInfoPtr__ServerTimeAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, nameof (_ServerTimeAccessor));
      SpawnRegionUpdateSystem.NativeFieldInfoPtr___UpdateSpawnRegions_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, "<>UpdateSpawnRegions_entityQuery");
      SpawnRegionUpdateSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, 100684503);
      SpawnRegionUpdateSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, 100684504);
      SpawnRegionUpdateSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, 100684505);
      SpawnRegionUpdateSystem.NativeMethodInfoPtr_ScheduleUpdateSpawnRegions_Private_Void_EntityCommandBuffer_ServerTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, 100684506);
      SpawnRegionUpdateSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, 100684507);
      SpawnRegionUpdateSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, 100684508);
      SpawnRegionUpdateSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSpawnRegions_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, 100684509);
    }

    public SpawnRegionUpdateSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe double MinimumRespawnAttemptDelay
    {
      get
      {
        double respawnAttemptDelay;
        IL2CPP.il2cpp_field_static_get_value(SpawnRegionUpdateSystem.NativeFieldInfoPtr_MinimumRespawnAttemptDelay, (void*) &respawnAttemptDelay);
        return respawnAttemptDelay;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SpawnRegionUpdateSystem.NativeFieldInfoPtr_MinimumRespawnAttemptDelay, (void*) &value);
      }
    }

    public static unsafe double MaximumRespawnAttemptDelay
    {
      get
      {
        double respawnAttemptDelay;
        IL2CPP.il2cpp_field_static_get_value(SpawnRegionUpdateSystem.NativeFieldInfoPtr_MaximumRespawnAttemptDelay, (void*) &respawnAttemptDelay);
        return respawnAttemptDelay;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SpawnRegionUpdateSystem.NativeFieldInfoPtr_MaximumRespawnAttemptDelay, (void*) &value);
      }
    }

    public static unsafe double PenaltySecondsPerFailedSpawn
    {
      get
      {
        double secondsPerFailedSpawn;
        IL2CPP.il2cpp_field_static_get_value(SpawnRegionUpdateSystem.NativeFieldInfoPtr_PenaltySecondsPerFailedSpawn, (void*) &secondsPerFailedSpawn);
        return secondsPerFailedSpawn;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SpawnRegionUpdateSystem.NativeFieldInfoPtr_PenaltySecondsPerFailedSpawn, (void*) &value);
      }
    }

    public static unsafe int MaxSpawnAttemptsPerFrame
    {
      get
      {
        int attemptsPerFrame;
        IL2CPP.il2cpp_field_static_get_value(SpawnRegionUpdateSystem.NativeFieldInfoPtr_MaxSpawnAttemptsPerFrame, (void*) &attemptsPerFrame);
        return attemptsPerFrame;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SpawnRegionUpdateSystem.NativeFieldInfoPtr_MaxSpawnAttemptsPerFrame, (void*) &value);
      }
    }

    public unsafe SpawnBarrier _SpawnBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.NativeFieldInfoPtr__SpawnBarrier));
        return pointer == System.IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.NativeFieldInfoPtr__SpawnBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _EventPrefab
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.NativeFieldInfoPtr__EventPrefab));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.NativeFieldInfoPtr__EventPrefab)) = value;
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public GetPlacementResult.SystemData _PlacementSystemData
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.NativeFieldInfoPtr__PlacementSystemData);
        return new GetPlacementResult.SystemData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.NativeFieldInfoPtr__PlacementSystemData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<SpawnRegionUpdateSystem.QueuedSpawnRequest> _QueuedSpawnRequests
    {
      get
      {
        return *(NativeList<SpawnRegionUpdateSystem.QueuedSpawnRequest>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.NativeFieldInfoPtr__QueuedSpawnRequests));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.NativeFieldInfoPtr__QueuedSpawnRequests), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<SpawnRegionUpdateSystem.QueuedSpawnRequest>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ProfilerMarker _PlacementProfilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.NativeFieldInfoPtr__PlacementProfilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.NativeFieldInfoPtr__PlacementProfilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _ReplaceAIQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.NativeFieldInfoPtr__ReplaceAIQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.NativeFieldInfoPtr__ReplaceAIQuery)) = value;
      }
    }

    public unsafe EntityQuery _DetachAIQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.NativeFieldInfoPtr__DetachAIQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.NativeFieldInfoPtr__DetachAIQuery)) = value;
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTimeAccessor
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.NativeFieldInfoPtr__ServerTimeAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.NativeFieldInfoPtr__ServerTimeAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __UpdateSpawnRegions_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.NativeFieldInfoPtr___UpdateSpawnRegions_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.NativeFieldInfoPtr___UpdateSpawnRegions_entityQuery)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct QueuedSpawnRequest
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_SpawnRegionEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_AttemptsAtFillingRegion;
      private static readonly System.IntPtr NativeFieldInfoPtr_LastRespawnAttempt;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_QueuedSpawnRequest_0;
      [FieldOffset(0)]
      public Entity SpawnRegionEntity;
      [FieldOffset(8)]
      public int AttemptsAtFillingRegion;
      [FieldOffset(16)]
      public double LastRespawnAttempt;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072428, XrefRangeEnd = 1072429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(SpawnRegionUpdateSystem.QueuedSpawnRequest other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.QueuedSpawnRequest.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_QueuedSpawnRequest_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static QueuedSpawnRequest()
      {
        Il2CppClassPointerStore<SpawnRegionUpdateSystem.QueuedSpawnRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, nameof (QueuedSpawnRequest));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnRegionUpdateSystem.QueuedSpawnRequest>.NativeClassPtr);
        SpawnRegionUpdateSystem.QueuedSpawnRequest.NativeFieldInfoPtr_SpawnRegionEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.QueuedSpawnRequest>.NativeClassPtr, nameof (SpawnRegionEntity));
        SpawnRegionUpdateSystem.QueuedSpawnRequest.NativeFieldInfoPtr_AttemptsAtFillingRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.QueuedSpawnRequest>.NativeClassPtr, nameof (AttemptsAtFillingRegion));
        SpawnRegionUpdateSystem.QueuedSpawnRequest.NativeFieldInfoPtr_LastRespawnAttempt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.QueuedSpawnRequest>.NativeClassPtr, nameof (LastRespawnAttempt));
        SpawnRegionUpdateSystem.QueuedSpawnRequest.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_QueuedSpawnRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem.QueuedSpawnRequest>.NativeClassPtr, 100684510);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnRegionUpdateSystem.QueuedSpawnRequest>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct UpdateJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Elapsed;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpawnECB;
      private static readonly System.IntPtr NativeFieldInfoPtr_Random;
      private static readonly System.IntPtr NativeFieldInfoPtr_PlacementProfilerMarker;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetSpawnRegion;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetSpawnPointBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetSpawnGroupBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetSpawnRegionSpawnSlotEntry;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTileModel;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetPrefabGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetSpawnGroupData;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetMapCollision;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetSpawnTableBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_EventPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_QueuedSpawnRequests;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetPlacementJobParams;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryFindValidSpawnPositions_Private_Boolean_Entity_NativeArray_1_float3_float3_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IsValidSpawnPosition_Private_Boolean_float3_Entity_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryGetRandomSpawnTable_Private_Boolean_Int32_NativeArray_1_Int32_byref_DynamicBuffer_1_SpawnGroupBuffer_byref_Int32_byref_SpawnGroup_SpawnTableBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryGetNextSpawnGroupIndex_Private_Boolean_Int32_NativeArray_1_Int32_byref_DynamicBuffer_1_SpawnGroupBuffer_byref_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAvailableSpawnPoint_Private_Void_Int32_NativeList_1_AvailableSpawnPoint_Single_0;
      [FieldOffset(0)]
      public double Elapsed;
      [FieldOffset(8)]
      public EntityCommandBuffer SpawnECB;
      [FieldOffset(24)]
      public Unity.Mathematics.Random Random;
      [FieldOffset(32)]
      public ProfilerMarker PlacementProfilerMarker;
      [FieldOffset(40)]
      public ComponentDataFromEntity<SpawnRegion> GetSpawnRegion;
      [FieldOffset(72)]
      public BufferFromEntity<SpawnPointBuffer> GetSpawnPointBuffer;
      [FieldOffset(112)]
      public BufferFromEntity<SpawnGroupBuffer> GetSpawnGroupBuffer;
      [FieldOffset(152)]
      public BufferFromEntity<SpawnRegionSpawnSlotEntry> GetSpawnRegionSpawnSlotEntry;
      [FieldOffset(192)]
      public ComponentDataFromEntity<TileModel> GetTileModel;
      [FieldOffset(224)]
      public ComponentDataFromEntity<PrefabGUID> GetPrefabGUID;
      [FieldOffset(256)]
      public ComponentDataFromEntity<SpawnGroupData> GetSpawnGroupData;
      [FieldOffset(288)]
      public ComponentDataFromEntity<MapCollision> GetMapCollision;
      [FieldOffset(320)]
      public BufferFromEntity<SpawnGroup_SpawnTableBuffer> GetSpawnTableBuffer;
      [FieldOffset(360)]
      public Entity EventPrefab;
      [FieldOffset(368)]
      public PrefabLookupMap PrefabLookupMap;
      [FieldOffset(416)]
      public NativeList<SpawnRegionUpdateSystem.QueuedSpawnRequest> QueuedSpawnRequests;
      [FieldOffset(432)]
      public GetPlacementResult.JobData GetPlacementJobParams;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072429, XrefRangeEnd = 1072550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.UpdateJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1072558, RefRangeEnd = 1072559, XrefRangeStart = 1072550, XrefRangeEnd = 1072558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool TryFindValidSpawnPositions(
        Entity prefab,
        NativeArray<float3> spawnPositionsToFill,
        float3 spawnPoint)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &prefab;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnPositionsToFill;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnPoint;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.UpdateJob.NativeMethodInfoPtr_TryFindValidSpawnPositions_Private_Boolean_Entity_NativeArray_1_float3_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1072577, RefRangeEnd = 1072578, XrefRangeStart = 1072559, XrefRangeEnd = 1072577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool IsValidSpawnPosition(
        float3 pos,
        Entity prefab,
        float prefabMapCollisionRadius)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &pos;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefab;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabMapCollisionRadius;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.UpdateJob.NativeMethodInfoPtr_IsValidSpawnPosition_Private_Boolean_float3_Entity_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1072606, RefRangeEnd = 1072607, XrefRangeStart = 1072578, XrefRangeEnd = 1072606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool TryGetRandomSpawnTable(
        int currentActiveSpawnPoints,
        NativeArray<int> activePointsByGroup,
        [In] ref DynamicBuffer<SpawnGroupBuffer> spawnGroups,
        out int spawnGroupIndex,
        out SpawnGroup_SpawnTableBuffer spawnTableInstance)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &currentActiveSpawnPoints;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &activePointsByGroup;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnGroups;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnGroupIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnTableInstance;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.UpdateJob.NativeMethodInfoPtr_TryGetRandomSpawnTable_Private_Boolean_Int32_NativeArray_1_Int32_byref_DynamicBuffer_1_SpawnGroupBuffer_byref_Int32_byref_SpawnGroup_SpawnTableBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1072649, RefRangeEnd = 1072650, XrefRangeStart = 1072607, XrefRangeEnd = 1072649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool TryGetNextSpawnGroupIndex(
        int currentActiveSpawnPoints,
        NativeArray<int> activePointsByGroup,
        [In] ref DynamicBuffer<SpawnGroupBuffer> spawnGroups,
        out int targetSpawnGroupIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &currentActiveSpawnPoints;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &activePointsByGroup;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnGroups;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref targetSpawnGroupIndex;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.UpdateJob.NativeMethodInfoPtr_TryGetNextSpawnGroupIndex_Private_Boolean_Int32_NativeArray_1_Int32_byref_DynamicBuffer_1_SpawnGroupBuffer_byref_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1072665, RefRangeEnd = 1072666, XrefRangeStart = 1072650, XrefRangeEnd = 1072665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void RemoveAvailableSpawnPoint(
        int index,
        NativeList<SpawnRegionUpdateSystem.UpdateJob.AvailableSpawnPoint> availableSpawnPoints,
        float squaredBlockingRadius)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &index;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &availableSpawnPoints;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &squaredBlockingRadius;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.UpdateJob.NativeMethodInfoPtr_RemoveAvailableSpawnPoint_Private_Void_Int32_NativeList_1_AvailableSpawnPoint_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static UpdateJob()
      {
        Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, nameof (UpdateJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr);
        SpawnRegionUpdateSystem.UpdateJob.NativeFieldInfoPtr_Elapsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, nameof (Elapsed));
        SpawnRegionUpdateSystem.UpdateJob.NativeFieldInfoPtr_SpawnECB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, nameof (SpawnECB));
        SpawnRegionUpdateSystem.UpdateJob.NativeFieldInfoPtr_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, nameof (Random));
        SpawnRegionUpdateSystem.UpdateJob.NativeFieldInfoPtr_PlacementProfilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, nameof (PlacementProfilerMarker));
        SpawnRegionUpdateSystem.UpdateJob.NativeFieldInfoPtr_GetSpawnRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, nameof (GetSpawnRegion));
        SpawnRegionUpdateSystem.UpdateJob.NativeFieldInfoPtr_GetSpawnPointBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, nameof (GetSpawnPointBuffer));
        SpawnRegionUpdateSystem.UpdateJob.NativeFieldInfoPtr_GetSpawnGroupBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, nameof (GetSpawnGroupBuffer));
        SpawnRegionUpdateSystem.UpdateJob.NativeFieldInfoPtr_GetSpawnRegionSpawnSlotEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, nameof (GetSpawnRegionSpawnSlotEntry));
        SpawnRegionUpdateSystem.UpdateJob.NativeFieldInfoPtr_GetTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, nameof (GetTileModel));
        SpawnRegionUpdateSystem.UpdateJob.NativeFieldInfoPtr_GetPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, nameof (GetPrefabGUID));
        SpawnRegionUpdateSystem.UpdateJob.NativeFieldInfoPtr_GetSpawnGroupData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, nameof (GetSpawnGroupData));
        SpawnRegionUpdateSystem.UpdateJob.NativeFieldInfoPtr_GetMapCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, nameof (GetMapCollision));
        SpawnRegionUpdateSystem.UpdateJob.NativeFieldInfoPtr_GetSpawnTableBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, nameof (GetSpawnTableBuffer));
        SpawnRegionUpdateSystem.UpdateJob.NativeFieldInfoPtr_EventPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, nameof (EventPrefab));
        SpawnRegionUpdateSystem.UpdateJob.NativeFieldInfoPtr_PrefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, nameof (PrefabLookupMap));
        SpawnRegionUpdateSystem.UpdateJob.NativeFieldInfoPtr_QueuedSpawnRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, nameof (QueuedSpawnRequests));
        SpawnRegionUpdateSystem.UpdateJob.NativeFieldInfoPtr_GetPlacementJobParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, nameof (GetPlacementJobParams));
        SpawnRegionUpdateSystem.UpdateJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, 100684511);
        SpawnRegionUpdateSystem.UpdateJob.NativeMethodInfoPtr_TryFindValidSpawnPositions_Private_Boolean_Entity_NativeArray_1_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, 100684512);
        SpawnRegionUpdateSystem.UpdateJob.NativeMethodInfoPtr_IsValidSpawnPosition_Private_Boolean_float3_Entity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, 100684513);
        SpawnRegionUpdateSystem.UpdateJob.NativeMethodInfoPtr_TryGetRandomSpawnTable_Private_Boolean_Int32_NativeArray_1_Int32_byref_DynamicBuffer_1_SpawnGroupBuffer_byref_Int32_byref_SpawnGroup_SpawnTableBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, 100684514);
        SpawnRegionUpdateSystem.UpdateJob.NativeMethodInfoPtr_TryGetNextSpawnGroupIndex_Private_Boolean_Int32_NativeArray_1_Int32_byref_DynamicBuffer_1_SpawnGroupBuffer_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, 100684515);
        SpawnRegionUpdateSystem.UpdateJob.NativeMethodInfoPtr_RemoveAvailableSpawnPoint_Private_Void_Int32_NativeList_1_AvailableSpawnPoint_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, 100684516);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct AvailableSpawnPoint
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_SpawnPointIndex;
        private static readonly System.IntPtr NativeFieldInfoPtr_SpawnPoint;
        [FieldOffset(0)]
        public int SpawnPointIndex;
        [FieldOffset(4)]
        public SpawnPointBuffer SpawnPoint;

        static AvailableSpawnPoint()
        {
          Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob.AvailableSpawnPoint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, nameof (AvailableSpawnPoint));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob.AvailableSpawnPoint>.NativeClassPtr);
          SpawnRegionUpdateSystem.UpdateJob.AvailableSpawnPoint.NativeFieldInfoPtr_SpawnPointIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob.AvailableSpawnPoint>.NativeClassPtr, nameof (SpawnPointIndex));
          SpawnRegionUpdateSystem.UpdateJob.AvailableSpawnPoint.NativeFieldInfoPtr_SpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob.AvailableSpawnPoint>.NativeClassPtr, nameof (SpawnPoint));
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob.AvailableSpawnPoint>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct FreeSpawnGroupRatio
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_FreeRatio;
        private static readonly System.IntPtr NativeFieldInfoPtr_SpawnGroupIndex;
        [FieldOffset(0)]
        public float FreeRatio;
        [FieldOffset(4)]
        public int SpawnGroupIndex;

        static FreeSpawnGroupRatio()
        {
          Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob.FreeSpawnGroupRatio>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob>.NativeClassPtr, nameof (FreeSpawnGroupRatio));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob.FreeSpawnGroupRatio>.NativeClassPtr);
          SpawnRegionUpdateSystem.UpdateJob.FreeSpawnGroupRatio.NativeFieldInfoPtr_FreeRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob.FreeSpawnGroupRatio>.NativeClassPtr, nameof (FreeRatio));
          SpawnRegionUpdateSystem.UpdateJob.FreeSpawnGroupRatio.NativeFieldInfoPtr_SpawnGroupIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob.FreeSpawnGroupRatio>.NativeClassPtr, nameof (SpawnGroupIndex));
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnRegionUpdateSystem.UpdateJob.FreeSpawnGroupRatio>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }

    [ObfuscatedName("ProjectM.SpawnRegionUpdateSystem/<>c__DisplayClass16_0")]
    public sealed class __c__DisplayClass16_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_replaceEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_detachEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_elapsed;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr_queuedSpawnRequests;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnECB;
      private static readonly System.IntPtr NativeFieldInfoPtr_replaceEventEntities;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ScheduleUpdateSpawnRegions_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_SpawnRegion_ActiveEntities_byref_DynamicBuffer_1_SpawnRegionSpawnSlotEntry_byref_SpawnRegion_byref_DynamicBuffer_1_SpawnPointBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ScheduleUpdateSpawnRegions_b__1_Internal_Void_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass16_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass16_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ScheduleUpdateSpawnRegions_b__0(
        Entity spawnRegionEntity,
        ref DynamicBuffer<SpawnRegion_ActiveEntities> activeEntities,
        ref DynamicBuffer<SpawnRegionSpawnSlotEntry> spawnSlots,
        ref SpawnRegion spawnRegion,
        [In] ref DynamicBuffer<SpawnPointBuffer> spawnPoints)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &spawnRegionEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeEntities;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnSlots;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnRegion;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnPoints;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeMethodInfoPtr__ScheduleUpdateSpawnRegions_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_SpawnRegion_ActiveEntities_byref_DynamicBuffer_1_SpawnRegionSpawnSlotEntry_byref_SpawnRegion_byref_DynamicBuffer_1_SpawnPointBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ScheduleUpdateSpawnRegions_b__1()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeMethodInfoPtr__ScheduleUpdateSpawnRegions_b__1_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass16_0()
      {
        Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, "<>c__DisplayClass16_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass16_0>.NativeClassPtr);
        SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_replaceEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass16_0>.NativeClassPtr, nameof (replaceEvents));
        SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_detachEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass16_0>.NativeClassPtr, nameof (detachEvents));
        SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass16_0>.NativeClassPtr, "<>4__this");
        SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_elapsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass16_0>.NativeClassPtr, nameof (elapsed));
        SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass16_0>.NativeClassPtr, nameof (random));
        SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_queuedSpawnRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass16_0>.NativeClassPtr, nameof (queuedSpawnRequests));
        SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_spawnECB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass16_0>.NativeClassPtr, nameof (spawnECB));
        SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_replaceEventEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass16_0>.NativeClassPtr, nameof (replaceEventEntities));
        SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass16_0>.NativeClassPtr, 100684517);
        SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeMethodInfoPtr__ScheduleUpdateSpawnRegions_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_SpawnRegion_ActiveEntities_byref_DynamicBuffer_1_SpawnRegionSpawnSlotEntry_byref_SpawnRegion_byref_DynamicBuffer_1_SpawnPointBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass16_0>.NativeClassPtr, 100684518);
        SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeMethodInfoPtr__ScheduleUpdateSpawnRegions_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass16_0>.NativeClassPtr, 100684519);
      }

      public __c__DisplayClass16_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass16_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass16_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass16_0>.NativeClassPtr, data));
      }

      public unsafe NativeArray<ReplaceAIEvent> replaceEvents
      {
        get
        {
          return *(NativeArray<ReplaceAIEvent>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_replaceEvents));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_replaceEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ReplaceAIEvent>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeArray<DetachEntityFromSpawnerEvent> detachEvents
      {
        get
        {
          return *(NativeArray<DetachEntityFromSpawnerEvent>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_detachEvents));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_detachEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<DetachEntityFromSpawnerEvent>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe SpawnRegionUpdateSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SpawnRegionUpdateSystem) null : new SpawnRegionUpdateSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe double elapsed
      {
        get
        {
          return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_elapsed));
        }
        [param: In] set
        {
          *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_elapsed)) = value;
        }
      }

      public unsafe Unity.Mathematics.Random random
      {
        get
        {
          return *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_random));
        }
        [param: In] set
        {
          *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_random)) = value;
        }
      }

      public unsafe NativeList<SpawnRegionUpdateSystem.QueuedSpawnRequest> queuedSpawnRequests
      {
        get
        {
          return *(NativeList<SpawnRegionUpdateSystem.QueuedSpawnRequest>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_queuedSpawnRequests));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_queuedSpawnRequests), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<SpawnRegionUpdateSystem.QueuedSpawnRequest>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe EntityCommandBuffer spawnECB
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_spawnECB));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_spawnECB)) = value;
        }
      }

      public unsafe NativeArray<Entity> replaceEventEntities
      {
        get
        {
          return *(NativeArray<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_replaceEventEntities));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnRegionUpdateSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_replaceEventEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.SpawnRegionUpdateSystem/ProjectM.<>c__DisplayClass_UpdateSpawnRegions")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateSpawnRegions
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_replaceEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_detachEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_elapsed;
      private static readonly System.IntPtr NativeFieldInfoPtr_random;
      private static readonly System.IntPtr NativeFieldInfoPtr_queuedSpawnRequests;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_SpawnRegion_ActiveEntities_byref_DynamicBuffer_1_SpawnRegionSpawnSlotEntry_byref_SpawnRegion_byref_DynamicBuffer_1_SpawnPointBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnRegionUpdateSystem_byref___c__DisplayClass16_0_0;
      [FieldOffset(0)]
      public NativeArray<ReplaceAIEvent> replaceEvents;
      [FieldOffset(16)]
      public NativeArray<DetachEntityFromSpawnerEvent> detachEvents;
      [FieldOffset(32)]
      public double elapsed;
      [FieldOffset(40)]
      public Unity.Mathematics.Random random;
      [FieldOffset(48)]
      public NativeList<SpawnRegionUpdateSystem.QueuedSpawnRequest> queuedSpawnRequests;
      [FieldOffset(64)]
      public ComponentDataFromEntity<PrefabGUID> _ComponentDataFromEntity_PrefabGUID_0;
      [FieldOffset(96)]
      public SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(256)]
      public unsafe SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072694, XrefRangeEnd = 1072758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity spawnRegionEntity,
        ref DynamicBuffer<SpawnRegion_ActiveEntities> activeEntities,
        ref DynamicBuffer<SpawnRegionSpawnSlotEntry> spawnSlots,
        ref SpawnRegion spawnRegion,
        [In] ref DynamicBuffer<SpawnPointBuffer> spawnPoints)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &spawnRegionEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeEntities;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnSlots;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnRegion;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnPoints;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_SpawnRegion_ActiveEntities_byref_DynamicBuffer_1_SpawnRegionSpawnSlotEntry_byref_SpawnRegion_byref_DynamicBuffer_1_SpawnPointBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1072758, RefRangeEnd = 1072759, XrefRangeStart = 1072758, XrefRangeEnd = 1072758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SpawnRegionUpdateSystem.__c__DisplayClass16_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072759, XrefRangeEnd = 1072761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1072776, RefRangeEnd = 1072777, XrefRangeStart = 1072761, XrefRangeEnd = 1072776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1072782, RefRangeEnd = 1072783, XrefRangeStart = 1072777, XrefRangeEnd = 1072782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SpawnRegionUpdateSystem componentSystem,
        ref SpawnRegionUpdateSystem.__c__DisplayClass16_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnRegionUpdateSystem_byref___c__DisplayClass16_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateSpawnRegions()
      {
        Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateSpawnRegions");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions>.NativeClassPtr);
        SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.NativeFieldInfoPtr_replaceEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions>.NativeClassPtr, nameof (replaceEvents));
        SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.NativeFieldInfoPtr_detachEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions>.NativeClassPtr, nameof (detachEvents));
        SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.NativeFieldInfoPtr_elapsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions>.NativeClassPtr, nameof (elapsed));
        SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions>.NativeClassPtr, nameof (random));
        SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.NativeFieldInfoPtr_queuedSpawnRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions>.NativeClassPtr, nameof (queuedSpawnRequests));
        SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions>.NativeClassPtr, nameof (_ComponentDataFromEntity_PrefabGUID_0));
        SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions>.NativeClassPtr, nameof (_runtimes));
        SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_SpawnRegion_ActiveEntities_byref_DynamicBuffer_1_SpawnRegionSpawnSlotEntry_byref_SpawnRegion_byref_DynamicBuffer_1_SpawnPointBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions>.NativeClassPtr, 100684520);
        SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions>.NativeClassPtr, 100684521);
        SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions>.NativeClassPtr, 100684522);
        SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions>.NativeClassPtr, 100684523);
        SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnRegionUpdateSystem_byref___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions>.NativeClassPtr, 100684524);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_spawnRegionEntity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_activeEntities;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_spawnSlots;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_spawnRegion;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_spawnPoints;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnRegionUpdateSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_spawnRegionEntity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<SpawnRegion_ActiveEntities> forParameter_activeEntities;
        [FieldOffset(48)]
        public LambdaParameterValueProvider_DynamicBuffer<SpawnRegionSpawnSlotEntry> forParameter_spawnSlots;
        [FieldOffset(88)]
        public LambdaParameterValueProvider_IComponentData<SpawnRegion> forParameter_spawnRegion;
        [FieldOffset(120)]
        public LambdaParameterValueProvider_DynamicBuffer<SpawnPointBuffer> forParameter_spawnPoints;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1072679, RefRangeEnd = 1072680, XrefRangeStart = 1072666, XrefRangeEnd = 1072679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SpawnRegionUpdateSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnRegionUpdateSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1072693, RefRangeEnd = 1072694, XrefRangeStart = 1072680, XrefRangeEnd = 1072693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_spawnRegionEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_spawnRegionEntity));
          SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_activeEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_activeEntities));
          SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_spawnSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_spawnSlots));
          SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_spawnRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_spawnRegion));
          SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_spawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_spawnPoints));
          SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnRegionUpdateSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders>.NativeClassPtr, 100684525);
          SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders>.NativeClassPtr, 100684526);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_spawnRegionEntity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_activeEntities;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_spawnSlots;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_spawnRegion;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_spawnPoints;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_spawnRegionEntity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<SpawnRegion_ActiveEntities>.Runtime runtime_activeEntities;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_DynamicBuffer<SpawnRegionSpawnSlotEntry>.Runtime runtime_spawnSlots;
          [FieldOffset(56)]
          public LambdaParameterValueProvider_IComponentData<SpawnRegion>.Runtime runtime_spawnRegion;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_DynamicBuffer<SpawnPointBuffer>.Runtime runtime_spawnPoints;

          static Runtimes()
          {
            Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_spawnRegionEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_spawnRegionEntity));
            SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_activeEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_activeEntities));
            SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_spawnSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_spawnSlots));
            SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_spawnRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_spawnRegion));
            SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_spawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_spawnPoints));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_UpdateSpawnRegions.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.SpawnRegionUpdateSystem/ProjectM.<>c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_queuedSpawnRequests;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnECB;
      private static readonly System.IntPtr NativeFieldInfoPtr_replaceEventEntities;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnRegionUpdateSystem_byref___c__DisplayClass16_0_0;
      [FieldOffset(0)]
      public NativeList<SpawnRegionUpdateSystem.QueuedSpawnRequest> queuedSpawnRequests;
      [FieldOffset(16)]
      public EntityCommandBuffer spawnECB;
      [FieldOffset(32)]
      public NativeArray<Entity> replaceEventEntities;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072783, XrefRangeEnd = 1072787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.__c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1072787, RefRangeEnd = 1072788, XrefRangeStart = 1072787, XrefRangeEnd = 1072787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SpawnRegionUpdateSystem.__c__DisplayClass16_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.__c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072788, XrefRangeEnd = 1072789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.__c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1072790, RefRangeEnd = 1072791, XrefRangeStart = 1072789, XrefRangeEnd = 1072790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SpawnRegionUpdateSystem componentSystem,
        ref SpawnRegionUpdateSystem.__c__DisplayClass16_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnRegionUpdateSystem.__c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnRegionUpdateSystem_byref___c__DisplayClass16_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents()
      {
        Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnRegionUpdateSystem>.NativeClassPtr, "<>c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents>.NativeClassPtr);
        SpawnRegionUpdateSystem.__c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents.NativeFieldInfoPtr_queuedSpawnRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents>.NativeClassPtr, nameof (queuedSpawnRequests));
        SpawnRegionUpdateSystem.__c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents.NativeFieldInfoPtr_spawnECB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents>.NativeClassPtr, nameof (spawnECB));
        SpawnRegionUpdateSystem.__c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents.NativeFieldInfoPtr_replaceEventEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents>.NativeClassPtr, nameof (replaceEventEntities));
        SpawnRegionUpdateSystem.__c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents>.NativeClassPtr, 100684527);
        SpawnRegionUpdateSystem.__c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents>.NativeClassPtr, 100684528);
        SpawnRegionUpdateSystem.__c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents>.NativeClassPtr, 100684529);
        SpawnRegionUpdateSystem.__c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnRegionUpdateSystem_byref___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents>.NativeClassPtr, 100684530);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnRegionUpdateSystem.__c__DisplayClass_PrioritizeSpawnRequestsAndDisposeEvents>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
