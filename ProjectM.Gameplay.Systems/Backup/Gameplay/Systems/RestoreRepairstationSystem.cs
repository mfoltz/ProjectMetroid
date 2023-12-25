// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Systems.RestoreRepairstationSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding.Placement;
using ProjectM.Network;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Systems
{
  public class RestoreRepairstationSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__SpawnBarrier;
    private static readonly IntPtr NativeFieldInfoPtr__DestroyBarrierSystem;
    private static readonly IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly IntPtr NativeFieldInfoPtr__RestoreRepairStationQuery;
    private static readonly IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly IntPtr NativeFieldInfoPtr__PlacementSystemData;
    private static readonly IntPtr NativeFieldInfoPtr__ServerDebugSettings;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_TrySpawnThing_Private_Void_FullPlacementJobData_Entity_Entity_PrefabLookupMap_0;
    private static readonly IntPtr NativeMethodInfoPtr_RequirementsFulfilled_Private_Static_Boolean_EntityManager_Entity_DynamicBuffer_1_RepairRequirementBuffer_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1458130, XrefRangeEnd = 1458172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RestoreRepairstationSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1458172, XrefRangeEnd = 1458176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RestoreRepairstationSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1458176, XrefRangeEnd = 1458300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RestoreRepairstationSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1458345, RefRangeEnd = 1458346, XrefRangeStart = 1458300, XrefRangeEnd = 1458345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TrySpawnThing(
      FullPlacementJobData placementJobParams,
      Entity stationEntity,
      Entity characterEntity,
      PrefabLookupMap prefabMap)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &placementJobParams;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &stationEntity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &characterEntity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &prefabMap;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RestoreRepairstationSystem.NativeMethodInfoPtr_TrySpawnThing_Private_Void_FullPlacementJobData_Entity_Entity_PrefabLookupMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1458365, RefRangeEnd = 1458366, XrefRangeStart = 1458346, XrefRangeEnd = 1458365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool RequirementsFulfilled(
      EntityManager entityManager,
      Entity targetEntity,
      DynamicBuffer<RepairRequirementBuffer> requirements)
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entityManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &targetEntity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &requirements;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(RestoreRepairstationSystem.NativeMethodInfoPtr_RequirementsFulfilled_Private_Static_Boolean_EntityManager_Entity_DynamicBuffer_1_RepairRequirementBuffer_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RestoreRepairstationSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RestoreRepairstationSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RestoreRepairstationSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RestoreRepairstationSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RestoreRepairstationSystem()
    {
      Il2CppClassPointerStore<RestoreRepairstationSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay.Systems", nameof (RestoreRepairstationSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RestoreRepairstationSystem>.NativeClassPtr);
      RestoreRepairstationSystem.NativeFieldInfoPtr__SpawnBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestoreRepairstationSystem>.NativeClassPtr, nameof (_SpawnBarrier));
      RestoreRepairstationSystem.NativeFieldInfoPtr__DestroyBarrierSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestoreRepairstationSystem>.NativeClassPtr, nameof (_DestroyBarrierSystem));
      RestoreRepairstationSystem.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestoreRepairstationSystem>.NativeClassPtr, nameof (_GameDataSystem));
      RestoreRepairstationSystem.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestoreRepairstationSystem>.NativeClassPtr, nameof (_NetworkIdSystem));
      RestoreRepairstationSystem.NativeFieldInfoPtr__RestoreRepairStationQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestoreRepairstationSystem>.NativeClassPtr, nameof (_RestoreRepairStationQuery));
      RestoreRepairstationSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestoreRepairstationSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      RestoreRepairstationSystem.NativeFieldInfoPtr__PlacementSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestoreRepairstationSystem>.NativeClassPtr, nameof (_PlacementSystemData));
      RestoreRepairstationSystem.NativeFieldInfoPtr__ServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestoreRepairstationSystem>.NativeClassPtr, nameof (_ServerDebugSettings));
      RestoreRepairstationSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestoreRepairstationSystem>.NativeClassPtr, 100673423);
      RestoreRepairstationSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestoreRepairstationSystem>.NativeClassPtr, 100673424);
      RestoreRepairstationSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestoreRepairstationSystem>.NativeClassPtr, 100673425);
      RestoreRepairstationSystem.NativeMethodInfoPtr_TrySpawnThing_Private_Void_FullPlacementJobData_Entity_Entity_PrefabLookupMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestoreRepairstationSystem>.NativeClassPtr, 100673426);
      RestoreRepairstationSystem.NativeMethodInfoPtr_RequirementsFulfilled_Private_Static_Boolean_EntityManager_Entity_DynamicBuffer_1_RepairRequirementBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestoreRepairstationSystem>.NativeClassPtr, 100673427);
      RestoreRepairstationSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestoreRepairstationSystem>.NativeClassPtr, 100673428);
      RestoreRepairstationSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestoreRepairstationSystem>.NativeClassPtr, 100673429);
    }

    public RestoreRepairstationSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SpawnBarrier _SpawnBarrier
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RestoreRepairstationSystem.NativeFieldInfoPtr__SpawnBarrier));
        return pointer == IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RestoreRepairstationSystem.NativeFieldInfoPtr__SpawnBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PostUpdateBarrier _DestroyBarrierSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RestoreRepairstationSystem.NativeFieldInfoPtr__DestroyBarrierSystem));
        return pointer == IntPtr.Zero ? (PostUpdateBarrier) null : new PostUpdateBarrier(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RestoreRepairstationSystem.NativeFieldInfoPtr__DestroyBarrierSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RestoreRepairstationSystem.NativeFieldInfoPtr__GameDataSystem));
        return pointer == IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RestoreRepairstationSystem.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RestoreRepairstationSystem.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RestoreRepairstationSystem.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _RestoreRepairStationQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RestoreRepairstationSystem.NativeFieldInfoPtr__RestoreRepairStationQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RestoreRepairstationSystem.NativeFieldInfoPtr__RestoreRepairStationQuery)) = value;
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RestoreRepairstationSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RestoreRepairstationSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public GetPlacementResult.SystemData _PlacementSystemData
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RestoreRepairstationSystem.NativeFieldInfoPtr__PlacementSystemData);
        return new GetPlacementResult.SystemData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RestoreRepairstationSystem.NativeFieldInfoPtr__PlacementSystemData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GetPlacementResult.SystemData>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> _ServerDebugSettings
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RestoreRepairstationSystem.NativeFieldInfoPtr__ServerDebugSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RestoreRepairstationSystem.NativeFieldInfoPtr__ServerDebugSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }
  }
}
