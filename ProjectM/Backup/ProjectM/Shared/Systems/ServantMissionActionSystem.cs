// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.Systems.ServantMissionActionSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Shared.Systems
{
  public class ServantMissionActionSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__StartMissionEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__AbortMissionEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServantCoffinList;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServantList;
    private static readonly System.IntPtr NativeFieldInfoPtr__AllServantsList;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServantMissionSettingsAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTimeAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__PostUpdateBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__BuffSpawnerSystemData;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___SendOnMissionJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SendOnMissionJob_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___AbortMissionJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___AbortMissionJob_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetMissionIdForMapZone_Private_Static_Boolean_EntityManager_byref_MapZoneId_NativeArray_1_MapZoneData_Entity_Boolean_byref_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidateThroneAndServants_Private_Boolean_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSendOnMissionJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForAbortMissionJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120356, XrefRangeEnd = 1120388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServantMissionActionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120388, XrefRangeEnd = 1120400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServantMissionActionSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120400, XrefRangeEnd = 1120497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServantMissionActionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1120503, RefRangeEnd = 1120505, XrefRangeStart = 1120497, XrefRangeEnd = 1120503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetMissionIdForMapZone(
      EntityManager entityManager,
      [In] ref MapZoneId mapZoneId,
      NativeArray<MapZoneData> mapZoneDatas,
      Entity userEntity,
      bool skipProgressionCheck,
      out PrefabGUID result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapZoneId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mapZoneDatas;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &skipProgressionCheck;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.NativeMethodInfoPtr_TryGetMissionIdForMapZone_Private_Static_Boolean_EntityManager_byref_MapZoneId_NativeArray_1_MapZoneData_Entity_Boolean_byref_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1120552, RefRangeEnd = 1120554, XrefRangeStart = 1120505, XrefRangeEnd = 1120552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ValidateThroneAndServants(Entity throneEntity, Entity fromCharacter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &throneEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromCharacter;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.NativeMethodInfoPtr_ValidateThroneAndServants_Private_Boolean_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServantMissionActionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120554, XrefRangeEnd = 1120639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServantMissionActionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120639, XrefRangeEnd = 1120655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120655, XrefRangeEnd = 1120674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSendOnMissionJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.NativeMethodInfoPtr___GetEntityQuery_ForSendOnMissionJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120674, XrefRangeEnd = 1120693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForAbortMissionJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.NativeMethodInfoPtr___GetEntityQuery_ForAbortMissionJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1120697, RefRangeEnd = 1120698, XrefRangeStart = 1120693, XrefRangeEnd = 1120697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServantMissionActionSystem()
    {
      Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Shared.Systems", nameof (ServantMissionActionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr);
      ServantMissionActionSystem.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, nameof (_NetworkIdSystem));
      ServantMissionActionSystem.NativeFieldInfoPtr__StartMissionEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, nameof (_StartMissionEventQuery));
      ServantMissionActionSystem.NativeFieldInfoPtr__AbortMissionEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, nameof (_AbortMissionEventQuery));
      ServantMissionActionSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      ServantMissionActionSystem.NativeFieldInfoPtr__ServantCoffinList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, nameof (_ServantCoffinList));
      ServantMissionActionSystem.NativeFieldInfoPtr__ServantList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, nameof (_ServantList));
      ServantMissionActionSystem.NativeFieldInfoPtr__AllServantsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, nameof (_AllServantsList));
      ServantMissionActionSystem.NativeFieldInfoPtr__ServantMissionSettingsAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, nameof (_ServantMissionSettingsAccessor));
      ServantMissionActionSystem.NativeFieldInfoPtr__ServerTimeAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, nameof (_ServerTimeAccessor));
      ServantMissionActionSystem.NativeFieldInfoPtr__PostUpdateBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, nameof (_PostUpdateBarrier));
      ServantMissionActionSystem.NativeFieldInfoPtr__BuffSpawnerSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, nameof (_BuffSpawnerSystemData));
      ServantMissionActionSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      ServantMissionActionSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      ServantMissionActionSystem.NativeFieldInfoPtr___SendOnMissionJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, "<>SendOnMissionJob_entityQuery");
      ServantMissionActionSystem.NativeFieldInfoPtr___SendOnMissionJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, "<>SendOnMissionJob_profilerMarker");
      ServantMissionActionSystem.NativeFieldInfoPtr___AbortMissionJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, "<>AbortMissionJob_entityQuery");
      ServantMissionActionSystem.NativeFieldInfoPtr___AbortMissionJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, "<>AbortMissionJob_profilerMarker");
      ServantMissionActionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, 100688864);
      ServantMissionActionSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, 100688865);
      ServantMissionActionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, 100688866);
      ServantMissionActionSystem.NativeMethodInfoPtr_TryGetMissionIdForMapZone_Private_Static_Boolean_EntityManager_byref_MapZoneId_NativeArray_1_MapZoneData_Entity_Boolean_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, 100688867);
      ServantMissionActionSystem.NativeMethodInfoPtr_ValidateThroneAndServants_Private_Boolean_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, 100688868);
      ServantMissionActionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, 100688869);
      ServantMissionActionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, 100688870);
      ServantMissionActionSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, 100688871);
      ServantMissionActionSystem.NativeMethodInfoPtr___GetEntityQuery_ForSendOnMissionJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, 100688872);
      ServantMissionActionSystem.NativeMethodInfoPtr___GetEntityQuery_ForAbortMissionJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, 100688873);
      ServantMissionActionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, 100688874);
    }

    public ServantMissionActionSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == System.IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _StartMissionEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr__StartMissionEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr__StartMissionEventQuery)) = value;
      }
    }

    public unsafe EntityQuery _AbortMissionEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr__AbortMissionEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr__AbortMissionEventQuery)) = value;
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<Entity> _ServantCoffinList
    {
      get
      {
        return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr__ServantCoffinList));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr__ServantCoffinList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<Entity> _ServantList
    {
      get
      {
        return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr__ServantList));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr__ServantList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<Entity> _AllServantsList
    {
      get
      {
        return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr__AllServantsList));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr__AllServantsList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServantMissionSettingsSingleton> _ServantMissionSettingsAccessor
    {
      get
      {
        return *(SingletonAccessor<ServantMissionSettingsSingleton>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr__ServantMissionSettingsAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr__ServantMissionSettingsAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServantMissionSettingsSingleton>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTimeAccessor
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr__ServerTimeAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr__ServerTimeAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe PostUpdateBarrier _PostUpdateBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr__PostUpdateBarrier));
        return pointer == System.IntPtr.Zero ? (PostUpdateBarrier) null : new PostUpdateBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr__PostUpdateBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BuffUtility.BuffSpawnerSystemData _BuffSpawnerSystemData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr__BuffSpawnerSystemData));
        return pointer == System.IntPtr.Zero ? (BuffUtility.BuffSpawnerSystemData) null : new BuffUtility.BuffSpawnerSystemData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr__BuffSpawnerSystemData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __SendOnMissionJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr___SendOnMissionJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr___SendOnMissionJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SendOnMissionJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr___SendOnMissionJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr___SendOnMissionJob_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __AbortMissionJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr___AbortMissionJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr___AbortMissionJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __AbortMissionJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr___AbortMissionJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.NativeFieldInfoPtr___AbortMissionJob_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Shared.Systems.ServantMissionActionSystem/<>c__DisplayClass13_0")]
    public sealed class __c__DisplayClass13_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_servantCoffinList;
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_skipProgressionCheck;
      private static readonly System.IntPtr NativeFieldInfoPtr_mapZoneDatas;
      private static readonly System.IntPtr NativeFieldInfoPtr_castleHeartConnectionRequirementDisabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabMapping;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentTicks;
      private static readonly System.IntPtr NativeFieldInfoPtr_servantMissionSettingsEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_buildCostsDisabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_missionBuffFound;
      private static readonly System.IntPtr NativeFieldInfoPtr_missionBuffEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_postUpdateCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_servantList;
      private static readonly System.IntPtr NativeFieldInfoPtr_buffSpawner;
      private static readonly System.IntPtr NativeFieldInfoPtr_missionSettings;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_SendOnMissionEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_AbortMissionEvent_byref_FromCharacter_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass13_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        Entity entity,
        [In] ref SendOnMissionEvent startMissionEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref startMissionEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_SendOnMissionEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(
        Entity entity,
        [In] ref AbortMissionEvent abortMissionEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref abortMissionEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_AbortMissionEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass13_0()
      {
        Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, "<>c__DisplayClass13_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr);
        ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_servantCoffinList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (servantCoffinList));
        ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (networkIdToEntityMap));
        ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
        ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_skipProgressionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (skipProgressionCheck));
        ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_mapZoneDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (mapZoneDatas));
        ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_castleHeartConnectionRequirementDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (castleHeartConnectionRequirementDisabled));
        ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_prefabMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (prefabMapping));
        ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_currentTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (currentTicks));
        ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_servantMissionSettingsEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (servantMissionSettingsEntity));
        ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_buildCostsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (buildCostsDisabled));
        ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_missionBuffFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (missionBuffFound));
        ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_missionBuffEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (missionBuffEntity));
        ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_postUpdateCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (postUpdateCommandBuffer));
        ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_servantList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (servantList));
        ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_buffSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (buffSpawner));
        ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_missionSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (missionSettings));
        ServantMissionActionSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr, 100688875);
        ServantMissionActionSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr, 100688876);
        ServantMissionActionSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_SendOnMissionEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr, 100688877);
        ServantMissionActionSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_AbortMissionEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr, 100688878);
      }

      public __c__DisplayClass13_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass13_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass13_0>.NativeClassPtr, data));
      }

      public unsafe NativeList<Entity> servantCoffinList
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_servantCoffinList));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_servantCoffinList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ServantMissionActionSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServantMissionActionSystem) null : new ServantMissionActionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool skipProgressionCheck
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_skipProgressionCheck));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_skipProgressionCheck)) = value;
        }
      }

      public unsafe NativeArray<MapZoneData> mapZoneDatas
      {
        get
        {
          return *(NativeArray<MapZoneData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_mapZoneDatas));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_mapZoneDatas), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<MapZoneData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe bool castleHeartConnectionRequirementDisabled
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_castleHeartConnectionRequirementDisabled));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_castleHeartConnectionRequirementDisabled)) = value;
        }
      }

      public unsafe PrefabLookupMap prefabMapping
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_prefabMapping));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_prefabMapping)) = value;
        }
      }

      public unsafe long currentTicks
      {
        get
        {
          return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_currentTicks));
        }
        [param: In] set
        {
          *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_currentTicks)) = value;
        }
      }

      public unsafe Entity servantMissionSettingsEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_servantMissionSettingsEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_servantMissionSettingsEntity)) = value;
        }
      }

      public unsafe bool buildCostsDisabled
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_buildCostsDisabled));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_buildCostsDisabled)) = value;
        }
      }

      public unsafe bool missionBuffFound
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_missionBuffFound));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_missionBuffFound)) = value;
        }
      }

      public unsafe Entity missionBuffEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_missionBuffEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_missionBuffEntity)) = value;
        }
      }

      public unsafe EntityCommandBuffer postUpdateCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_postUpdateCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_postUpdateCommandBuffer)) = value;
        }
      }

      public unsafe NativeList<Entity> servantList
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_servantList));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_servantList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe BuffUtility.BuffSpawner buffSpawner
      {
        get
        {
          return *(BuffUtility.BuffSpawner*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_buffSpawner));
        }
        [param: In] set
        {
          *(BuffUtility.BuffSpawner*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_buffSpawner)) = value;
        }
      }

      public unsafe ServantMissionSettingsSingleton missionSettings
      {
        get
        {
          return *(ServantMissionSettingsSingleton*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_missionSettings));
        }
        [param: In] set
        {
          *(ServantMissionSettingsSingleton*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_missionSettings)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Shared.Systems.ServantMissionActionSystem/ProjectM.Shared.Systems.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_servantCoffinList;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionActionSystem_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeList<Entity> servantCoffinList;
      [FieldOffset(16)]
      public ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(24)]
      public unsafe ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120003, XrefRangeEnd = 1120006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServantMissionActionSystem.__c__DisplayClass13_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServantMissionActionSystem.__c__DisplayClass13_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120006, XrefRangeEnd = 1120008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1120011, RefRangeEnd = 1120012, XrefRangeStart = 1120008, XrefRangeEnd = 1120011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10)]
      [CachedScanResults(RefRangeStart = 1035887, RefRangeEnd = 1035897, XrefRangeStart = 1035887, XrefRangeEnd = 1035897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServantMissionActionSystem componentSystem,
        ref ServantMissionActionSystem.__c__DisplayClass13_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionActionSystem_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120012, XrefRangeEnd = 1120016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120016, XrefRangeEnd = 1120022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_servantCoffinList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (servantCoffinList));
        ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100688879);
        ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100688880);
        ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100688881);
        ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100688882);
        ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100688883);
        ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionActionSystem_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100688884);
        ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100688885);
        ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100688886);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionActionSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;

        [CallerCount(25)]
        [CachedScanResults(RefRangeStart = 742675, RefRangeEnd = 742700, XrefRangeStart = 742675, XrefRangeEnd = 742700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServantMissionActionSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionActionSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(25)]
        [CachedScanResults(RefRangeStart = 742701, RefRangeEnd = 742726, XrefRangeStart = 742701, XrefRangeEnd = 742726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionActionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100688887);
          ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100688888);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Shared.Systems.ServantMissionActionSystem/ProjectM.Shared.Systems.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.Shared.Systems.RunWithoutJobSystem_00005920$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00005920$PostfixBurstDelegate");
          ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688889);
          ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688890);
          ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688891);
          ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100688892);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Shared.Systems.ServantMissionActionSystem/ProjectM.Shared.Systems.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.Shared.Systems.RunWithoutJobSystem_00005920$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119928, XrefRangeEnd = 1119942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119942, XrefRangeEnd = 1119960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119960, XrefRangeEnd = 1119975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1120002, RefRangeEnd = 1120003, XrefRangeStart = 1119975, XrefRangeEnd = 1120002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00005920$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688893);
          ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688894);
          ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688895);
          ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688896);
          ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100688898);
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
            IL2CPP.il2cpp_field_static_get_value(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ServantMissionActionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Shared.Systems.ServantMissionActionSystem/ProjectM.Shared.Systems.<>c__DisplayClass_SendOnMissionJob")]
    public sealed class __c__DisplayClass_SendOnMissionJob : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_skipProgressionCheck;
      private static readonly System.IntPtr NativeFieldInfoPtr_mapZoneDatas;
      private static readonly System.IntPtr NativeFieldInfoPtr_castleHeartConnectionRequirementDisabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabMapping;
      private static readonly System.IntPtr NativeFieldInfoPtr_servantCoffinList;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentTicks;
      private static readonly System.IntPtr NativeFieldInfoPtr_servantMissionSettingsEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_buildCostsDisabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_missionBuffFound;
      private static readonly System.IntPtr NativeFieldInfoPtr_missionBuffEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_postUpdateCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SendOnMissionEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionActionSystem_byref___c__DisplayClass13_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1120267, RefRangeEnd = 1120268, XrefRangeStart = 1120038, XrefRangeEnd = 1120267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref SendOnMissionEvent startMissionEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref startMissionEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SendOnMissionEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1120269, RefRangeEnd = 1120270, XrefRangeStart = 1120268, XrefRangeEnd = 1120269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServantMissionActionSystem.__c__DisplayClass13_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1120271, RefRangeEnd = 1120272, XrefRangeStart = 1120270, XrefRangeEnd = 1120271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServantMissionActionSystem.__c__DisplayClass13_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120272, XrefRangeEnd = 1120286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1120292, RefRangeEnd = 1120293, XrefRangeStart = 1120286, XrefRangeEnd = 1120292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1120294, RefRangeEnd = 1120295, XrefRangeStart = 1120293, XrefRangeEnd = 1120294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServantMissionActionSystem componentSystem,
        ref ServantMissionActionSystem.__c__DisplayClass13_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionActionSystem_byref___c__DisplayClass13_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SendOnMissionJob()
      {
        Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, "<>c__DisplayClass_SendOnMissionJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr);
        ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, nameof (networkIdToEntityMap));
        ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, "<>4__this");
        ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_skipProgressionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, nameof (skipProgressionCheck));
        ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_mapZoneDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, nameof (mapZoneDatas));
        ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_castleHeartConnectionRequirementDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, nameof (castleHeartConnectionRequirementDisabled));
        ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_prefabMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, nameof (prefabMapping));
        ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_servantCoffinList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, nameof (servantCoffinList));
        ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_currentTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, nameof (currentTicks));
        ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_servantMissionSettingsEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, nameof (servantMissionSettingsEntity));
        ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_buildCostsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, nameof (buildCostsDisabled));
        ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_missionBuffFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, nameof (missionBuffFound));
        ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_missionBuffEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, nameof (missionBuffEntity));
        ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_postUpdateCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, nameof (postUpdateCommandBuffer));
        ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, nameof (_runtimes));
        ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, nameof (_performLambdaDelegate));
        ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SendOnMissionEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, 100688899);
        ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, 100688900);
        ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, 100688901);
        ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, 100688903);
        ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, 100688904);
        ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionActionSystem_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, 100688905);
      }

      public __c__DisplayClass_SendOnMissionJob(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_SendOnMissionJob()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, data));
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ServantMissionActionSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServantMissionActionSystem) null : new ServantMissionActionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool skipProgressionCheck
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_skipProgressionCheck));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_skipProgressionCheck)) = value;
        }
      }

      public unsafe NativeArray<MapZoneData> mapZoneDatas
      {
        get
        {
          return *(NativeArray<MapZoneData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_mapZoneDatas));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_mapZoneDatas), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<MapZoneData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe bool castleHeartConnectionRequirementDisabled
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_castleHeartConnectionRequirementDisabled));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_castleHeartConnectionRequirementDisabled)) = value;
        }
      }

      public unsafe PrefabLookupMap prefabMapping
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_prefabMapping));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_prefabMapping)) = value;
        }
      }

      public unsafe NativeList<Entity> servantCoffinList
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_servantCoffinList));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_servantCoffinList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe long currentTicks
      {
        get
        {
          return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_currentTicks));
        }
        [param: In] set
        {
          *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_currentTicks)) = value;
        }
      }

      public unsafe Entity servantMissionSettingsEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_servantMissionSettingsEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_servantMissionSettingsEntity)) = value;
        }
      }

      public unsafe bool buildCostsDisabled
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_buildCostsDisabled));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_buildCostsDisabled)) = value;
        }
      }

      public unsafe bool missionBuffFound
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_missionBuffFound));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_missionBuffFound)) = value;
        }
      }

      public unsafe Entity missionBuffEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_missionBuffEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_missionBuffEntity)) = value;
        }
      }

      public unsafe EntityCommandBuffer postUpdateCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_postUpdateCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr_postUpdateCommandBuffer)) = value;
        }
      }

      public unsafe ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_startMissionEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionActionSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<SendOnMissionEvent> forParameter_startMissionEvent;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120022, XrefRangeEnd = 1120029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServantMissionActionSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionActionSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1120037, RefRangeEnd = 1120038, XrefRangeStart = 1120029, XrefRangeEnd = 1120037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_startMissionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_startMissionEvent));
          ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionActionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders>.NativeClassPtr, 100688906);
          ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders>.NativeClassPtr, 100688907);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_startMissionEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<SendOnMissionEvent>.StructuralChangeRuntime runtime_startMissionEvent;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.StructuralChangeRuntime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_startMissionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_startMissionEvent));
            ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_SendOnMissionJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Shared.Systems.ServantMissionActionSystem/ProjectM.Shared.Systems.<>c__DisplayClass_AbortMissionJob")]
    public sealed class __c__DisplayClass_AbortMissionJob : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_castleHeartConnectionRequirementDisabled;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_mapZoneDatas;
      private static readonly System.IntPtr NativeFieldInfoPtr_skipProgressionCheck;
      private static readonly System.IntPtr NativeFieldInfoPtr_servantList;
      private static readonly System.IntPtr NativeFieldInfoPtr_buffSpawner;
      private static readonly System.IntPtr NativeFieldInfoPtr_postUpdateCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_missionSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AbortMissionEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionActionSystem_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1120330, RefRangeEnd = 1120331, XrefRangeStart = 1120311, XrefRangeEnd = 1120330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref AbortMissionEvent abortMissionEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref abortMissionEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AbortMissionEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1120332, RefRangeEnd = 1120333, XrefRangeStart = 1120331, XrefRangeEnd = 1120332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServantMissionActionSystem.__c__DisplayClass13_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1120334, RefRangeEnd = 1120335, XrefRangeStart = 1120333, XrefRangeEnd = 1120334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServantMissionActionSystem.__c__DisplayClass13_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120335, XrefRangeEnd = 1120337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1120346, RefRangeEnd = 1120347, XrefRangeStart = 1120337, XrefRangeEnd = 1120346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1120349, RefRangeEnd = 1120350, XrefRangeStart = 1120347, XrefRangeEnd = 1120349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServantMissionActionSystem componentSystem,
        ref ServantMissionActionSystem.__c__DisplayClass13_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionActionSystem_byref___c__DisplayClass13_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120350, XrefRangeEnd = 1120356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_AbortMissionJob()
      {
        Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionActionSystem>.NativeClassPtr, "<>c__DisplayClass_AbortMissionJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr);
        ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr, nameof (networkIdToEntityMap));
        ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_castleHeartConnectionRequirementDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr, nameof (castleHeartConnectionRequirementDisabled));
        ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr, "<>4__this");
        ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_mapZoneDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr, nameof (mapZoneDatas));
        ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_skipProgressionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr, nameof (skipProgressionCheck));
        ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_servantList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr, nameof (servantList));
        ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_buffSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr, nameof (buffSpawner));
        ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_postUpdateCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr, nameof (postUpdateCommandBuffer));
        ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_missionSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr, nameof (missionSettings));
        ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr, nameof (_runtimes));
        ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AbortMissionEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr, 100688908);
        ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr, 100688909);
        ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr, 100688910);
        ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr, 100688911);
        ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr, 100688912);
        ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionActionSystem_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr, 100688913);
        ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr, 100688914);
      }

      public __c__DisplayClass_AbortMissionJob(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_AbortMissionJob()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr, data));
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe bool castleHeartConnectionRequirementDisabled
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_castleHeartConnectionRequirementDisabled));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_castleHeartConnectionRequirementDisabled)) = value;
        }
      }

      public unsafe ServantMissionActionSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServantMissionActionSystem) null : new ServantMissionActionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeArray<MapZoneData> mapZoneDatas
      {
        get
        {
          return *(NativeArray<MapZoneData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_mapZoneDatas));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_mapZoneDatas), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<MapZoneData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe bool skipProgressionCheck
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_skipProgressionCheck));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_skipProgressionCheck)) = value;
        }
      }

      public unsafe NativeList<Entity> servantList
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_servantList));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_servantList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe BuffUtility.BuffSpawner buffSpawner
      {
        get
        {
          return *(BuffUtility.BuffSpawner*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_buffSpawner));
        }
        [param: In] set
        {
          *(BuffUtility.BuffSpawner*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_buffSpawner)) = value;
        }
      }

      public unsafe EntityCommandBuffer postUpdateCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_postUpdateCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_postUpdateCommandBuffer)) = value;
        }
      }

      public unsafe ServantMissionSettingsSingleton missionSettings
      {
        get
        {
          return *(ServantMissionSettingsSingleton*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_missionSettings));
        }
        [param: In] set
        {
          *(ServantMissionSettingsSingleton*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_missionSettings)) = value;
        }
      }

      public unsafe ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_abortMissionEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionActionSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<AbortMissionEvent> forParameter_abortMissionEvent;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1120302, RefRangeEnd = 1120303, XrefRangeStart = 1120295, XrefRangeEnd = 1120302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServantMissionActionSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionActionSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1120310, RefRangeEnd = 1120311, XrefRangeStart = 1120303, XrefRangeEnd = 1120310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_abortMissionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_abortMissionEvent));
          ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionActionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders>.NativeClassPtr, 100688915);
          ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders>.NativeClassPtr, 100688916);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_abortMissionEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<AbortMissionEvent>.Runtime runtime_abortMissionEvent;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.Runtime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_abortMissionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_abortMissionEvent));
            ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionActionSystem.__c__DisplayClass_AbortMissionJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
