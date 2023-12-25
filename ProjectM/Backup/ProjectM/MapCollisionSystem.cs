// Decompiled with JetBrains decompiler
// Type: ProjectM.MapCollisionSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class MapCollisionSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TilePolygons;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsClient;
    private static readonly System.IntPtr NativeFieldInfoPtr_USE_OLD_ENTITIES_FOREACH_SOLUTION;
    private static readonly System.IntPtr NativeFieldInfoPtr___MapCollisionJob_NonUnits_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___MapCollisionJob_NonUnits_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___MapCollisionJob_Units_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___MapCollisionJob_Units_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteJob_Private_Static_Void_Entity_byref_LastTranslation_byref_Translation_byref_MapCollision_byref_MapData_byref_BuffableFlagState_Boolean_ComponentDataFromEntity_1_PrefabGUID_Boolean_ComponentDataFromEntity_1_IsSpellControlled_ComponentDataFromEntity_1_NetworkInterpolated_Shared_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForMapCollisionJob_NonUnits_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForMapCollisionJob_Units_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025571, XrefRangeEnd = 1025598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MapCollisionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025598, XrefRangeEnd = 1025599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MapCollisionSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025599, XrefRangeEnd = 1025640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MapCollisionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1025666, RefRangeEnd = 1025668, XrefRangeStart = 1025640, XrefRangeEnd = 1025666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ExecuteJob(
      Entity entity,
      ref LastTranslation lastPosition,
      ref Translation position,
      ref MapCollision mapCollision,
      ref TileMapCollisionMath.MapData mapData,
      [In] ref BuffableFlagState buffableFlagState,
      bool useTriangles,
      ComponentDataFromEntity<PrefabGUID> getPrefabGUID,
      bool isClient,
      ComponentDataFromEntity<IsSpellControlled> getIsSpellControlled,
      ComponentDataFromEntity<NetworkInterpolated_Shared> getNetworkInterpolated_Shared)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[11];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lastPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapCollision;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffableFlagState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &useTriangles;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &getPrefabGUID;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &isClient;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &getIsSpellControlled;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &getNetworkInterpolated_Shared;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.NativeMethodInfoPtr_ExecuteJob_Private_Static_Void_Entity_byref_LastTranslation_byref_Translation_byref_MapCollision_byref_MapData_byref_BuffableFlagState_Boolean_ComponentDataFromEntity_1_PrefabGUID_Boolean_ComponentDataFromEntity_1_IsSpellControlled_ComponentDataFromEntity_1_NetworkInterpolated_Shared_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MapCollisionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025668, XrefRangeEnd = 1025702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MapCollisionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1025730, RefRangeEnd = 1025731, XrefRangeStart = 1025702, XrefRangeEnd = 1025730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForMapCollisionJob_NonUnits_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.NativeMethodInfoPtr___GetEntityQuery_ForMapCollisionJob_NonUnits_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1025762, RefRangeEnd = 1025763, XrefRangeStart = 1025731, XrefRangeEnd = 1025762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForMapCollisionJob_Units_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.NativeMethodInfoPtr___GetEntityQuery_ForMapCollisionJob_Units_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1025767, RefRangeEnd = 1025768, XrefRangeStart = 1025763, XrefRangeEnd = 1025767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1025772, RefRangeEnd = 1025773, XrefRangeStart = 1025768, XrefRangeEnd = 1025772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MapCollisionSystem()
    {
      Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (MapCollisionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr);
      MapCollisionSystem.NativeFieldInfoPtr__TilePolygons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr, nameof (_TilePolygons));
      MapCollisionSystem.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr, nameof (_TileWorldSystem));
      MapCollisionSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr, nameof (_Query));
      MapCollisionSystem.NativeFieldInfoPtr__IsClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr, nameof (_IsClient));
      MapCollisionSystem.NativeFieldInfoPtr_USE_OLD_ENTITIES_FOREACH_SOLUTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr, nameof (USE_OLD_ENTITIES_FOREACH_SOLUTION));
      MapCollisionSystem.NativeFieldInfoPtr___MapCollisionJob_NonUnits_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr, "<>MapCollisionJob_NonUnits_entityQuery");
      MapCollisionSystem.NativeFieldInfoPtr___MapCollisionJob_NonUnits_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr, "<>MapCollisionJob_NonUnits_profilerMarker");
      MapCollisionSystem.NativeFieldInfoPtr___MapCollisionJob_Units_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr, "<>MapCollisionJob_Units_entityQuery");
      MapCollisionSystem.NativeFieldInfoPtr___MapCollisionJob_Units_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr, "<>MapCollisionJob_Units_profilerMarker");
      MapCollisionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr, 100680133);
      MapCollisionSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr, 100680134);
      MapCollisionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr, 100680135);
      MapCollisionSystem.NativeMethodInfoPtr_ExecuteJob_Private_Static_Void_Entity_byref_LastTranslation_byref_Translation_byref_MapCollision_byref_MapData_byref_BuffableFlagState_Boolean_ComponentDataFromEntity_1_PrefabGUID_Boolean_ComponentDataFromEntity_1_IsSpellControlled_ComponentDataFromEntity_1_NetworkInterpolated_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr, 100680136);
      MapCollisionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr, 100680137);
      MapCollisionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr, 100680138);
      MapCollisionSystem.NativeMethodInfoPtr___GetEntityQuery_ForMapCollisionJob_NonUnits_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr, 100680139);
      MapCollisionSystem.NativeMethodInfoPtr___GetEntityQuery_ForMapCollisionJob_Units_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr, 100680140);
      MapCollisionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr, 100680141);
      MapCollisionSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr, 100680142);
    }

    public MapCollisionSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TileMapCollisionMath.TilePolygons _TilePolygons
    {
      get
      {
        return *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapCollisionSystem.NativeFieldInfoPtr__TilePolygons));
      }
      [param: In] set
      {
        *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapCollisionSystem.NativeFieldInfoPtr__TilePolygons)) = value;
      }
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapCollisionSystem.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapCollisionSystem.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapCollisionSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapCollisionSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe bool _IsClient
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapCollisionSystem.NativeFieldInfoPtr__IsClient));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapCollisionSystem.NativeFieldInfoPtr__IsClient)) = value;
      }
    }

    public static unsafe bool USE_OLD_ENTITIES_FOREACH_SOLUTION
    {
      get
      {
        bool entitiesForeachSolution;
        IL2CPP.il2cpp_field_static_get_value(MapCollisionSystem.NativeFieldInfoPtr_USE_OLD_ENTITIES_FOREACH_SOLUTION, (void*) &entitiesForeachSolution);
        return entitiesForeachSolution;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MapCollisionSystem.NativeFieldInfoPtr_USE_OLD_ENTITIES_FOREACH_SOLUTION, (void*) &value);
      }
    }

    public unsafe EntityQuery __MapCollisionJob_NonUnits_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapCollisionSystem.NativeFieldInfoPtr___MapCollisionJob_NonUnits_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapCollisionSystem.NativeFieldInfoPtr___MapCollisionJob_NonUnits_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __MapCollisionJob_NonUnits_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapCollisionSystem.NativeFieldInfoPtr___MapCollisionJob_NonUnits_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapCollisionSystem.NativeFieldInfoPtr___MapCollisionJob_NonUnits_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __MapCollisionJob_Units_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapCollisionSystem.NativeFieldInfoPtr___MapCollisionJob_Units_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapCollisionSystem.NativeFieldInfoPtr___MapCollisionJob_Units_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __MapCollisionJob_Units_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapCollisionSystem.NativeFieldInfoPtr___MapCollisionJob_Units_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapCollisionSystem.NativeFieldInfoPtr___MapCollisionJob_Units_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MapCollisionJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityHandle;
      private static readonly System.IntPtr NativeFieldInfoPtr_PlayerCharacterHandle;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsSpellControlledHandle;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkInterpolated_ClientHandle;
      private static readonly System.IntPtr NativeFieldInfoPtr_LastTranslationHandle;
      private static readonly System.IntPtr NativeFieldInfoPtr_TranslationHandle;
      private static readonly System.IntPtr NativeFieldInfoPtr_MapCollisionHandle;
      private static readonly System.IntPtr NativeFieldInfoPtr_BuffableFlagStateHandle;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetPrefabGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_MapData;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsClient;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public EntityTypeHandle EntityHandle;
      [FieldOffset(8)]
      public ComponentTypeHandle<PlayerCharacter> PlayerCharacterHandle;
      [FieldOffset(40)]
      public ComponentTypeHandle<IsSpellControlled> IsSpellControlledHandle;
      [FieldOffset(72)]
      public ComponentTypeHandle<NetworkInterpolated_Client> NetworkInterpolated_ClientHandle;
      [FieldOffset(104)]
      public ComponentTypeHandle<LastTranslation> LastTranslationHandle;
      [FieldOffset(136)]
      public ComponentTypeHandle<Translation> TranslationHandle;
      [FieldOffset(168)]
      public ComponentTypeHandle<MapCollision> MapCollisionHandle;
      [FieldOffset(200)]
      public ComponentTypeHandle<BuffableFlagState> BuffableFlagStateHandle;
      [FieldOffset(232)]
      public ComponentDataFromEntity<PrefabGUID> GetPrefabGUID;
      [FieldOffset(264)]
      public TileMapCollisionMath.MapData MapData;
      [FieldOffset(368)]
      public bool IsClient;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025245, XrefRangeEnd = 1025295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.MapCollisionJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static MapCollisionJob()
      {
        Il2CppClassPointerStore<MapCollisionSystem.MapCollisionJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr, nameof (MapCollisionJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapCollisionSystem.MapCollisionJob>.NativeClassPtr);
        MapCollisionSystem.MapCollisionJob.NativeFieldInfoPtr_EntityHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.MapCollisionJob>.NativeClassPtr, nameof (EntityHandle));
        MapCollisionSystem.MapCollisionJob.NativeFieldInfoPtr_PlayerCharacterHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.MapCollisionJob>.NativeClassPtr, nameof (PlayerCharacterHandle));
        MapCollisionSystem.MapCollisionJob.NativeFieldInfoPtr_IsSpellControlledHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.MapCollisionJob>.NativeClassPtr, nameof (IsSpellControlledHandle));
        MapCollisionSystem.MapCollisionJob.NativeFieldInfoPtr_NetworkInterpolated_ClientHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.MapCollisionJob>.NativeClassPtr, nameof (NetworkInterpolated_ClientHandle));
        MapCollisionSystem.MapCollisionJob.NativeFieldInfoPtr_LastTranslationHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.MapCollisionJob>.NativeClassPtr, nameof (LastTranslationHandle));
        MapCollisionSystem.MapCollisionJob.NativeFieldInfoPtr_TranslationHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.MapCollisionJob>.NativeClassPtr, nameof (TranslationHandle));
        MapCollisionSystem.MapCollisionJob.NativeFieldInfoPtr_MapCollisionHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.MapCollisionJob>.NativeClassPtr, nameof (MapCollisionHandle));
        MapCollisionSystem.MapCollisionJob.NativeFieldInfoPtr_BuffableFlagStateHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.MapCollisionJob>.NativeClassPtr, nameof (BuffableFlagStateHandle));
        MapCollisionSystem.MapCollisionJob.NativeFieldInfoPtr_GetPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.MapCollisionJob>.NativeClassPtr, nameof (GetPrefabGUID));
        MapCollisionSystem.MapCollisionJob.NativeFieldInfoPtr_MapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.MapCollisionJob>.NativeClassPtr, nameof (MapData));
        MapCollisionSystem.MapCollisionJob.NativeFieldInfoPtr_IsClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.MapCollisionJob>.NativeClassPtr, nameof (IsClient));
        MapCollisionSystem.MapCollisionJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.MapCollisionJob>.NativeClassPtr, 100680143);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapCollisionSystem.MapCollisionJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.MapCollisionSystem/<>c__DisplayClass7_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass7_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_mapData;
      private static readonly System.IntPtr NativeFieldInfoPtr_getPrefabGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_isClient;
      private static readonly System.IntPtr NativeFieldInfoPtr_getIsSpellControlled;
      private static readonly System.IntPtr NativeFieldInfoPtr_getNetworkInterpolated_Shared;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_LastTranslation_byref_Translation_byref_MapCollision_byref_BuffableFlagState_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_LastTranslation_byref_Translation_byref_MapCollision_byref_BuffableFlagState_0;
      [FieldOffset(0)]
      public TileMapCollisionMath.MapData mapData;
      [FieldOffset(104)]
      public ComponentDataFromEntity<PrefabGUID> getPrefabGUID;
      [FieldOffset(136)]
      public bool isClient;
      [FieldOffset(144)]
      public ComponentDataFromEntity<IsSpellControlled> getIsSpellControlled;
      [FieldOffset(176)]
      public ComponentDataFromEntity<NetworkInterpolated_Shared> getNetworkInterpolated_Shared;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref LastTranslation lastPosition,
        ref Translation position,
        ref MapCollision mapCollision,
        [In] ref BuffableFlagState buffableFlagState)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lastPosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapCollision;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffableFlagState;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_LastTranslation_byref_Translation_byref_MapCollision_byref_BuffableFlagState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        Entity entity,
        ref LastTranslation lastPosition,
        ref Translation position,
        ref MapCollision mapCollision,
        [In] ref BuffableFlagState buffableFlagState)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lastPosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapCollision;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffableFlagState;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_LastTranslation_byref_Translation_byref_MapCollision_byref_BuffableFlagState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_0()
      {
        Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr, "<>c__DisplayClass7_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass7_0>.NativeClassPtr);
        MapCollisionSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_mapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (mapData));
        MapCollisionSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_getPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (getPrefabGUID));
        MapCollisionSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_isClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (isClient));
        MapCollisionSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_getIsSpellControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (getIsSpellControlled));
        MapCollisionSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_getNetworkInterpolated_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (getNetworkInterpolated_Shared));
        MapCollisionSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass7_0>.NativeClassPtr, 100680144);
        MapCollisionSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_LastTranslation_byref_Translation_byref_MapCollision_byref_BuffableFlagState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass7_0>.NativeClassPtr, 100680145);
        MapCollisionSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_LastTranslation_byref_Translation_byref_MapCollision_byref_BuffableFlagState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass7_0>.NativeClassPtr, 100680146);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass7_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.MapCollisionSystem/ProjectM.<>c__DisplayClass_MapCollisionJob_NonUnits")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_MapCollisionJob_NonUnits
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_mapData;
      private static readonly System.IntPtr NativeFieldInfoPtr_getPrefabGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_isClient;
      private static readonly System.IntPtr NativeFieldInfoPtr_getIsSpellControlled;
      private static readonly System.IntPtr NativeFieldInfoPtr_getNetworkInterpolated_Shared;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_LastTranslation_byref_Translation_byref_MapCollision_byref_BuffableFlagState_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapCollisionSystem_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public TileMapCollisionMath.MapData mapData;
      [FieldOffset(104)]
      public ComponentDataFromEntity<PrefabGUID> getPrefabGUID;
      [FieldOffset(136)]
      public bool isClient;
      [FieldOffset(144)]
      public ComponentDataFromEntity<IsSpellControlled> getIsSpellControlled;
      [FieldOffset(176)]
      public ComponentDataFromEntity<NetworkInterpolated_Shared> getNetworkInterpolated_Shared;
      [FieldOffset(208)]
      public MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(344)]
      public unsafe MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1025399, RefRangeEnd = 1025400, XrefRangeStart = 1025398, XrefRangeEnd = 1025399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref LastTranslation lastPosition,
        ref Translation position,
        ref MapCollision mapCollision,
        [In] ref BuffableFlagState buffableFlagState)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lastPosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapCollision;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffableFlagState;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_LastTranslation_byref_Translation_byref_MapCollision_byref_BuffableFlagState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1025400, RefRangeEnd = 1025402, XrefRangeStart = 1025400, XrefRangeEnd = 1025400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref MapCollisionSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1025402, RefRangeEnd = 1025404, XrefRangeStart = 1025402, XrefRangeEnd = 1025402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref MapCollisionSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025404, XrefRangeEnd = 1025406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1025421, RefRangeEnd = 1025422, XrefRangeStart = 1025406, XrefRangeEnd = 1025421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1025424, RefRangeEnd = 1025425, XrefRangeStart = 1025422, XrefRangeEnd = 1025424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        MapCollisionSystem componentSystem,
        ref MapCollisionSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapCollisionSystem_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025425, XrefRangeEnd = 1025429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025429, XrefRangeEnd = 1025435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_MapCollisionJob_NonUnits()
      {
        Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr, "<>c__DisplayClass_MapCollisionJob_NonUnits");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits>.NativeClassPtr);
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeFieldInfoPtr_mapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits>.NativeClassPtr, nameof (mapData));
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeFieldInfoPtr_getPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits>.NativeClassPtr, nameof (getPrefabGUID));
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeFieldInfoPtr_isClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits>.NativeClassPtr, nameof (isClient));
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeFieldInfoPtr_getIsSpellControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits>.NativeClassPtr, nameof (getIsSpellControlled));
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeFieldInfoPtr_getNetworkInterpolated_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits>.NativeClassPtr, nameof (getNetworkInterpolated_Shared));
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits>.NativeClassPtr, nameof (_runtimes));
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_LastTranslation_byref_Translation_byref_MapCollision_byref_BuffableFlagState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits>.NativeClassPtr, 100680147);
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits>.NativeClassPtr, 100680148);
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits>.NativeClassPtr, 100680149);
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits>.NativeClassPtr, 100680150);
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits>.NativeClassPtr, 100680151);
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapCollisionSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits>.NativeClassPtr, 100680152);
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits>.NativeClassPtr, 100680153);
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits>.NativeClassPtr, 100680154);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_lastPosition;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_position;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_mapCollision;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buffableFlagState;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapCollisionSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<LastTranslation> forParameter_lastPosition;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_position;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<MapCollision> forParameter_mapCollision;
        [FieldOffset(104)]
        public LambdaParameterValueProvider_IComponentData<BuffableFlagState> forParameter_buffableFlagState;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1025308, RefRangeEnd = 1025309, XrefRangeStart = 1025295, XrefRangeEnd = 1025308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(MapCollisionSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapCollisionSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1025322, RefRangeEnd = 1025323, XrefRangeStart = 1025309, XrefRangeEnd = 1025322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_lastPosition));
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_position));
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_mapCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_mapCollision));
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buffableFlagState));
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapCollisionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders>.NativeClassPtr, 100680155);
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders>.NativeClassPtr, 100680156);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_lastPosition;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_position;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_mapCollision;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buffableFlagState;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<LastTranslation>.Runtime runtime_lastPosition;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_position;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<MapCollision>.Runtime runtime_mapCollision;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<BuffableFlagState>.Runtime runtime_buffableFlagState;

          static Runtimes()
          {
            Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_lastPosition));
            MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_position));
            MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_mapCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_mapCollision));
            MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buffableFlagState));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.MapCollisionSystem/ProjectM.<>c__DisplayClass_MapCollisionJob_NonUnits/ProjectM.RunWithoutJobSystem_00003E17$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits>.NativeClassPtr, "RunWithoutJobSystem_00003E17$PostfixBurstDelegate");
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100680157);
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100680158);
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100680159);
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100680160);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.MapCollisionSystem/ProjectM.<>c__DisplayClass_MapCollisionJob_NonUnits/ProjectM.RunWithoutJobSystem_00003E17$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025323, XrefRangeEnd = 1025337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025337, XrefRangeEnd = 1025355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025355, XrefRangeEnd = 1025370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1025397, RefRangeEnd = 1025398, XrefRangeStart = 1025370, XrefRangeEnd = 1025397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits>.NativeClassPtr, "RunWithoutJobSystem_00003E17$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680161);
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680162);
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680163);
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680164);
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680166);
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
            IL2CPP.il2cpp_field_static_get_value(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_NonUnits.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.MapCollisionSystem/ProjectM.<>c__DisplayClass_MapCollisionJob_Units")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_MapCollisionJob_Units
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_mapData;
      private static readonly System.IntPtr NativeFieldInfoPtr_getPrefabGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_isClient;
      private static readonly System.IntPtr NativeFieldInfoPtr_getIsSpellControlled;
      private static readonly System.IntPtr NativeFieldInfoPtr_getNetworkInterpolated_Shared;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_LastTranslation_byref_Translation_byref_MapCollision_byref_BuffableFlagState_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapCollisionSystem_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public TileMapCollisionMath.MapData mapData;
      [FieldOffset(104)]
      public ComponentDataFromEntity<PrefabGUID> getPrefabGUID;
      [FieldOffset(136)]
      public bool isClient;
      [FieldOffset(144)]
      public ComponentDataFromEntity<IsSpellControlled> getIsSpellControlled;
      [FieldOffset(176)]
      public ComponentDataFromEntity<NetworkInterpolated_Shared> getNetworkInterpolated_Shared;
      [FieldOffset(208)]
      public MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(344)]
      public unsafe MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1025539, RefRangeEnd = 1025540, XrefRangeStart = 1025538, XrefRangeEnd = 1025539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref LastTranslation lastPosition,
        ref Translation position,
        ref MapCollision mapCollision,
        [In] ref BuffableFlagState buffableFlagState)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lastPosition;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref position;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapCollision;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffableFlagState;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_LastTranslation_byref_Translation_byref_MapCollision_byref_BuffableFlagState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1025400, RefRangeEnd = 1025402, XrefRangeStart = 1025400, XrefRangeEnd = 1025402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref MapCollisionSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1025402, RefRangeEnd = 1025404, XrefRangeStart = 1025402, XrefRangeEnd = 1025404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref MapCollisionSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025540, XrefRangeEnd = 1025542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1025557, RefRangeEnd = 1025558, XrefRangeStart = 1025542, XrefRangeEnd = 1025557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1025560, RefRangeEnd = 1025561, XrefRangeStart = 1025558, XrefRangeEnd = 1025560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        MapCollisionSystem componentSystem,
        ref MapCollisionSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapCollisionSystem_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025561, XrefRangeEnd = 1025565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025565, XrefRangeEnd = 1025571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_MapCollisionJob_Units()
      {
        Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapCollisionSystem>.NativeClassPtr, "<>c__DisplayClass_MapCollisionJob_Units");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units>.NativeClassPtr);
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeFieldInfoPtr_mapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units>.NativeClassPtr, nameof (mapData));
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeFieldInfoPtr_getPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units>.NativeClassPtr, nameof (getPrefabGUID));
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeFieldInfoPtr_isClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units>.NativeClassPtr, nameof (isClient));
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeFieldInfoPtr_getIsSpellControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units>.NativeClassPtr, nameof (getIsSpellControlled));
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeFieldInfoPtr_getNetworkInterpolated_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units>.NativeClassPtr, nameof (getNetworkInterpolated_Shared));
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units>.NativeClassPtr, nameof (_runtimes));
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_LastTranslation_byref_Translation_byref_MapCollision_byref_BuffableFlagState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units>.NativeClassPtr, 100680167);
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units>.NativeClassPtr, 100680168);
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units>.NativeClassPtr, 100680169);
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units>.NativeClassPtr, 100680170);
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units>.NativeClassPtr, 100680171);
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapCollisionSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units>.NativeClassPtr, 100680172);
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units>.NativeClassPtr, 100680173);
        MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units>.NativeClassPtr, 100680174);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_lastPosition;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_position;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_mapCollision;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buffableFlagState;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapCollisionSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<LastTranslation> forParameter_lastPosition;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_position;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<MapCollision> forParameter_mapCollision;
        [FieldOffset(104)]
        public LambdaParameterValueProvider_IComponentData<BuffableFlagState> forParameter_buffableFlagState;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1025448, RefRangeEnd = 1025449, XrefRangeStart = 1025435, XrefRangeEnd = 1025448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(MapCollisionSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapCollisionSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1025462, RefRangeEnd = 1025463, XrefRangeStart = 1025449, XrefRangeEnd = 1025462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_lastPosition));
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_position));
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_mapCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_mapCollision));
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buffableFlagState));
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapCollisionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders>.NativeClassPtr, 100680175);
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders>.NativeClassPtr, 100680176);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_lastPosition;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_position;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_mapCollision;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buffableFlagState;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<LastTranslation>.Runtime runtime_lastPosition;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_position;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<MapCollision>.Runtime runtime_mapCollision;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<BuffableFlagState>.Runtime runtime_buffableFlagState;

          static Runtimes()
          {
            Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_lastPosition));
            MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_position));
            MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_mapCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_mapCollision));
            MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buffableFlagState));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.MapCollisionSystem/ProjectM.<>c__DisplayClass_MapCollisionJob_Units/ProjectM.RunWithoutJobSystem_00003E20$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units>.NativeClassPtr, "RunWithoutJobSystem_00003E20$PostfixBurstDelegate");
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100680177);
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100680178);
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100680179);
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100680180);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.MapCollisionSystem/ProjectM.<>c__DisplayClass_MapCollisionJob_Units/ProjectM.RunWithoutJobSystem_00003E20$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025463, XrefRangeEnd = 1025477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025477, XrefRangeEnd = 1025495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025495, XrefRangeEnd = 1025510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1025537, RefRangeEnd = 1025538, XrefRangeStart = 1025510, XrefRangeEnd = 1025537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units>.NativeClassPtr, "RunWithoutJobSystem_00003E20$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680181);
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680182);
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680183);
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680184);
          MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100680186);
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
            IL2CPP.il2cpp_field_static_get_value(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MapCollisionSystem.__c__DisplayClass_MapCollisionJob_Units.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
