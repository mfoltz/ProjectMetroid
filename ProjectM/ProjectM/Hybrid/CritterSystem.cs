// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.CritterSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Hybrid
{
  public class CritterSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TilePolygons;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CollisionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__LocalPlayerQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr_MIN_ANGLES_TO_ESCAPE;
    private static readonly System.IntPtr NativeFieldInfoPtr_FLYING_CRITTER_MAX_UP_ANGLE;
    private static readonly System.IntPtr NativeFieldInfoPtr_FLYING_CRITTER_UP_SPEED;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_OBSTACLE_DETECTION_DIST;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_OBSTACLE_DETECTION_DIST_SQ;
    private static readonly System.IntPtr NativeFieldInfoPtr_RAY_ANGLE_RADIAN;
    private static readonly System.IntPtr NativeFieldInfoPtr_NUM_OBSTACLE_DETECTION_RAYS;
    private static readonly System.IntPtr NativeFieldInfoPtr_RAY_ANGLE_INCREMENT;
    private static readonly System.IntPtr NativeFieldInfoPtr_CIRCLE_CHECK_RADIUS;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateCrittersHybrid_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateCrittersHybrid_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateCrittersDOTS_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateCrittersDOTS_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___FlyingCritter_AvoidObstacles_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___FlyingCritter_AvoidObstacles_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___SpawnCritterSequences_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SpawnCritterSequences_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___GroundCritter_AvoidObstacles_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___GroundCritter_AvoidObstacles_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalUser_Private_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateCrittersHybrid_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateCrittersDOTS_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForFlyingCritter_AvoidObstacles_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSpawnCritterSequences_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForGroundCritter_AvoidObstacles_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155972, XrefRangeEnd = 1156008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CritterSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CritterSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156008, XrefRangeEnd = 1156095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CritterSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1156105, RefRangeEnd = 1156106, XrefRangeStart = 1156095, XrefRangeEnd = 1156105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetLocalUser()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterSystem.NativeMethodInfoPtr_GetLocalUser_Private_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CritterSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156106, XrefRangeEnd = 1156205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CritterSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156205, XrefRangeEnd = 1156224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateCrittersHybrid_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateCrittersHybrid_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1156249, RefRangeEnd = 1156250, XrefRangeStart = 1156224, XrefRangeEnd = 1156249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateCrittersDOTS_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateCrittersDOTS_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1156275, RefRangeEnd = 1156276, XrefRangeStart = 1156250, XrefRangeEnd = 1156275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForFlyingCritter_AvoidObstacles_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterSystem.NativeMethodInfoPtr___GetEntityQuery_ForFlyingCritter_AvoidObstacles_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156276, XrefRangeEnd = 1156292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSpawnCritterSequences_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawnCritterSequences_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1156317, RefRangeEnd = 1156318, XrefRangeStart = 1156292, XrefRangeEnd = 1156317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForGroundCritter_AvoidObstacles_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterSystem.NativeMethodInfoPtr___GetEntityQuery_ForGroundCritter_AvoidObstacles_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1156322, RefRangeEnd = 1156323, XrefRangeStart = 1156318, XrefRangeEnd = 1156322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1156327, RefRangeEnd = 1156328, XrefRangeStart = 1156323, XrefRangeEnd = 1156327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1156332, RefRangeEnd = 1156333, XrefRangeStart = 1156328, XrefRangeEnd = 1156332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CritterSystem()
    {
      Il2CppClassPointerStore<CritterSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (CritterSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr);
      CritterSystem.NativeFieldInfoPtr__TilePolygons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, nameof (_TilePolygons));
      CritterSystem.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, nameof (_TileWorldSystem));
      CritterSystem.NativeFieldInfoPtr__CollisionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, nameof (_CollisionSystem));
      CritterSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      CritterSystem.NativeFieldInfoPtr__LocalPlayerQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, nameof (_LocalPlayerQuery));
      CritterSystem.NativeFieldInfoPtr_MIN_ANGLES_TO_ESCAPE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, nameof (MIN_ANGLES_TO_ESCAPE));
      CritterSystem.NativeFieldInfoPtr_FLYING_CRITTER_MAX_UP_ANGLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, nameof (FLYING_CRITTER_MAX_UP_ANGLE));
      CritterSystem.NativeFieldInfoPtr_FLYING_CRITTER_UP_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, nameof (FLYING_CRITTER_UP_SPEED));
      CritterSystem.NativeFieldInfoPtr_MAX_OBSTACLE_DETECTION_DIST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, nameof (MAX_OBSTACLE_DETECTION_DIST));
      CritterSystem.NativeFieldInfoPtr_MAX_OBSTACLE_DETECTION_DIST_SQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, nameof (MAX_OBSTACLE_DETECTION_DIST_SQ));
      CritterSystem.NativeFieldInfoPtr_RAY_ANGLE_RADIAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, nameof (RAY_ANGLE_RADIAN));
      CritterSystem.NativeFieldInfoPtr_NUM_OBSTACLE_DETECTION_RAYS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, nameof (NUM_OBSTACLE_DETECTION_RAYS));
      CritterSystem.NativeFieldInfoPtr_RAY_ANGLE_INCREMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, nameof (RAY_ANGLE_INCREMENT));
      CritterSystem.NativeFieldInfoPtr_CIRCLE_CHECK_RADIUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, nameof (CIRCLE_CHECK_RADIUS));
      CritterSystem.NativeFieldInfoPtr___UpdateCrittersHybrid_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, "<>UpdateCrittersHybrid_entityQuery");
      CritterSystem.NativeFieldInfoPtr___UpdateCrittersHybrid_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, "<>UpdateCrittersHybrid_profilerMarker");
      CritterSystem.NativeFieldInfoPtr___UpdateCrittersDOTS_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, "<>UpdateCrittersDOTS_entityQuery");
      CritterSystem.NativeFieldInfoPtr___UpdateCrittersDOTS_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, "<>UpdateCrittersDOTS_profilerMarker");
      CritterSystem.NativeFieldInfoPtr___FlyingCritter_AvoidObstacles_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, "<>FlyingCritter_AvoidObstacles_entityQuery");
      CritterSystem.NativeFieldInfoPtr___FlyingCritter_AvoidObstacles_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, "<>FlyingCritter_AvoidObstacles_profilerMarker");
      CritterSystem.NativeFieldInfoPtr___SpawnCritterSequences_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, "<>SpawnCritterSequences_entityQuery");
      CritterSystem.NativeFieldInfoPtr___SpawnCritterSequences_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, "<>SpawnCritterSequences_profilerMarker");
      CritterSystem.NativeFieldInfoPtr___GroundCritter_AvoidObstacles_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, "<>GroundCritter_AvoidObstacles_entityQuery");
      CritterSystem.NativeFieldInfoPtr___GroundCritter_AvoidObstacles_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, "<>GroundCritter_AvoidObstacles_profilerMarker");
      CritterSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, 100691930);
      CritterSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, 100691931);
      CritterSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, 100691932);
      CritterSystem.NativeMethodInfoPtr_GetLocalUser_Private_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, 100691933);
      CritterSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, 100691934);
      CritterSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, 100691935);
      CritterSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateCrittersHybrid_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, 100691936);
      CritterSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateCrittersDOTS_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, 100691937);
      CritterSystem.NativeMethodInfoPtr___GetEntityQuery_ForFlyingCritter_AvoidObstacles_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, 100691938);
      CritterSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawnCritterSequences_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, 100691939);
      CritterSystem.NativeMethodInfoPtr___GetEntityQuery_ForGroundCritter_AvoidObstacles_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, 100691940);
      CritterSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, 100691941);
      CritterSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, 100691942);
      CritterSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, 100691943);
    }

    public CritterSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TileMapCollisionMath.TilePolygons _TilePolygons
    {
      get
      {
        return *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr__TilePolygons));
      }
      [param: In] set
      {
        *(TileMapCollisionMath.TilePolygons*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr__TilePolygons)) = value;
      }
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CollisionSystem _CollisionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr__CollisionSystem));
        return pointer == System.IntPtr.Zero ? (CollisionSystem) null : new CollisionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr__CollisionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _LocalPlayerQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr__LocalPlayerQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr__LocalPlayerQuery)) = value;
      }
    }

    public static unsafe float MIN_ANGLES_TO_ESCAPE
    {
      get
      {
        float minAnglesToEscape;
        IL2CPP.il2cpp_field_static_get_value(CritterSystem.NativeFieldInfoPtr_MIN_ANGLES_TO_ESCAPE, (void*) &minAnglesToEscape);
        return minAnglesToEscape;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CritterSystem.NativeFieldInfoPtr_MIN_ANGLES_TO_ESCAPE, (void*) &value);
      }
    }

    public static unsafe float FLYING_CRITTER_MAX_UP_ANGLE
    {
      get
      {
        float critterMaxUpAngle;
        IL2CPP.il2cpp_field_static_get_value(CritterSystem.NativeFieldInfoPtr_FLYING_CRITTER_MAX_UP_ANGLE, (void*) &critterMaxUpAngle);
        return critterMaxUpAngle;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CritterSystem.NativeFieldInfoPtr_FLYING_CRITTER_MAX_UP_ANGLE, (void*) &value);
      }
    }

    public static unsafe float FLYING_CRITTER_UP_SPEED
    {
      get
      {
        float flyingCritterUpSpeed;
        IL2CPP.il2cpp_field_static_get_value(CritterSystem.NativeFieldInfoPtr_FLYING_CRITTER_UP_SPEED, (void*) &flyingCritterUpSpeed);
        return flyingCritterUpSpeed;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CritterSystem.NativeFieldInfoPtr_FLYING_CRITTER_UP_SPEED, (void*) &value);
      }
    }

    public static unsafe float MAX_OBSTACLE_DETECTION_DIST
    {
      get
      {
        float obstacleDetectionDist;
        IL2CPP.il2cpp_field_static_get_value(CritterSystem.NativeFieldInfoPtr_MAX_OBSTACLE_DETECTION_DIST, (void*) &obstacleDetectionDist);
        return obstacleDetectionDist;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CritterSystem.NativeFieldInfoPtr_MAX_OBSTACLE_DETECTION_DIST, (void*) &value);
      }
    }

    public static unsafe float MAX_OBSTACLE_DETECTION_DIST_SQ
    {
      get
      {
        float obstacleDetectionDistSq;
        IL2CPP.il2cpp_field_static_get_value(CritterSystem.NativeFieldInfoPtr_MAX_OBSTACLE_DETECTION_DIST_SQ, (void*) &obstacleDetectionDistSq);
        return obstacleDetectionDistSq;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CritterSystem.NativeFieldInfoPtr_MAX_OBSTACLE_DETECTION_DIST_SQ, (void*) &value);
      }
    }

    public static unsafe float RAY_ANGLE_RADIAN
    {
      get
      {
        float rayAngleRadian;
        IL2CPP.il2cpp_field_static_get_value(CritterSystem.NativeFieldInfoPtr_RAY_ANGLE_RADIAN, (void*) &rayAngleRadian);
        return rayAngleRadian;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CritterSystem.NativeFieldInfoPtr_RAY_ANGLE_RADIAN, (void*) &value);
      }
    }

    public static unsafe int NUM_OBSTACLE_DETECTION_RAYS
    {
      get
      {
        int obstacleDetectionRays;
        IL2CPP.il2cpp_field_static_get_value(CritterSystem.NativeFieldInfoPtr_NUM_OBSTACLE_DETECTION_RAYS, (void*) &obstacleDetectionRays);
        return obstacleDetectionRays;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CritterSystem.NativeFieldInfoPtr_NUM_OBSTACLE_DETECTION_RAYS, (void*) &value);
      }
    }

    public static unsafe float RAY_ANGLE_INCREMENT
    {
      get
      {
        float rayAngleIncrement;
        IL2CPP.il2cpp_field_static_get_value(CritterSystem.NativeFieldInfoPtr_RAY_ANGLE_INCREMENT, (void*) &rayAngleIncrement);
        return rayAngleIncrement;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CritterSystem.NativeFieldInfoPtr_RAY_ANGLE_INCREMENT, (void*) &value);
      }
    }

    public static unsafe float CIRCLE_CHECK_RADIUS
    {
      get
      {
        float circleCheckRadius;
        IL2CPP.il2cpp_field_static_get_value(CritterSystem.NativeFieldInfoPtr_CIRCLE_CHECK_RADIUS, (void*) &circleCheckRadius);
        return circleCheckRadius;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CritterSystem.NativeFieldInfoPtr_CIRCLE_CHECK_RADIUS, (void*) &value);
      }
    }

    public unsafe EntityQuery __UpdateCrittersHybrid_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr___UpdateCrittersHybrid_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr___UpdateCrittersHybrid_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateCrittersHybrid_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr___UpdateCrittersHybrid_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr___UpdateCrittersHybrid_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateCrittersDOTS_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr___UpdateCrittersDOTS_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr___UpdateCrittersDOTS_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateCrittersDOTS_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr___UpdateCrittersDOTS_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr___UpdateCrittersDOTS_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __FlyingCritter_AvoidObstacles_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr___FlyingCritter_AvoidObstacles_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr___FlyingCritter_AvoidObstacles_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __FlyingCritter_AvoidObstacles_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr___FlyingCritter_AvoidObstacles_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr___FlyingCritter_AvoidObstacles_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __SpawnCritterSequences_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr___SpawnCritterSequences_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr___SpawnCritterSequences_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SpawnCritterSequences_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr___SpawnCritterSequences_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr___SpawnCritterSequences_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __GroundCritter_AvoidObstacles_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr___GroundCritter_AvoidObstacles_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr___GroundCritter_AvoidObstacles_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __GroundCritter_AvoidObstacles_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr___GroundCritter_AvoidObstacles_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.NativeFieldInfoPtr___GroundCritter_AvoidObstacles_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Hybrid.CritterSystem/<>c__DisplayClass16_0")]
    public sealed class __c__DisplayClass16_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerMoving;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerPos;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_globalUp;
      private static readonly System.IntPtr NativeFieldInfoPtr_mapData;
      private static readonly System.IntPtr NativeFieldInfoPtr_worldType;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_HybridCritterComponent_byref_HybridModel_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_CritterData_byref_Rotation_byref_Translation_byref_Entity_byref_LocalToWorld_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_CritterData_byref_Rotation_byref_Translation_byref_LocalToWorld_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_byref_Entity_byref_CritterData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_CritterData_byref_Rotation_byref_Translation_byref_LocalToWorld_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass16_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass16_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(HybridCritterComponent hc, ref HybridModel hm)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hc);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hm;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass16_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_HybridCritterComponent_byref_HybridModel_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        ref CritterData critter,
        ref Rotation rotation,
        ref Translation translation,
        [In] ref Entity entity,
        [In] ref LocalToWorld localToWorldVar)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref critter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref localToWorldVar;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass16_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_CritterData_byref_Rotation_byref_Translation_byref_Entity_byref_LocalToWorld_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(
        ref CritterData critter,
        ref Rotation rotation,
        ref Translation translation,
        [In] ref LocalToWorld localToWorldVar)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref critter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref localToWorldVar;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass16_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_CritterData_byref_Rotation_byref_Translation_byref_LocalToWorld_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__3([In] ref Entity entity, [In] ref CritterData critter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref critter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass16_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_byref_Entity_byref_CritterData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__4(
        Entity entity,
        ref CritterData critter,
        ref Rotation rotation,
        ref Translation translation,
        [In] ref LocalToWorld localToWorldVar)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref critter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref localToWorldVar;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass16_0.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_CritterData_byref_Rotation_byref_Translation_byref_LocalToWorld_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass16_0()
      {
        Il2CppClassPointerStore<CritterSystem.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, "<>c__DisplayClass16_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass16_0>.NativeClassPtr);
        CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass16_0>.NativeClassPtr, "<>4__this");
        CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_localPlayerMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass16_0>.NativeClassPtr, nameof (localPlayerMoving));
        CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_localPlayerPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass16_0>.NativeClassPtr, nameof (localPlayerPos));
        CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass16_0>.NativeClassPtr, nameof (deltaTime));
        CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_collisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass16_0>.NativeClassPtr, nameof (collisionWorld));
        CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_globalUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass16_0>.NativeClassPtr, nameof (globalUp));
        CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_mapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass16_0>.NativeClassPtr, nameof (mapData));
        CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_worldType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass16_0>.NativeClassPtr, nameof (worldType));
        CritterSystem.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass16_0>.NativeClassPtr, 100691944);
        CritterSystem.__c__DisplayClass16_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_HybridCritterComponent_byref_HybridModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass16_0>.NativeClassPtr, 100691945);
        CritterSystem.__c__DisplayClass16_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_CritterData_byref_Rotation_byref_Translation_byref_Entity_byref_LocalToWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass16_0>.NativeClassPtr, 100691946);
        CritterSystem.__c__DisplayClass16_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_CritterData_byref_Rotation_byref_Translation_byref_LocalToWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass16_0>.NativeClassPtr, 100691947);
        CritterSystem.__c__DisplayClass16_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_byref_Entity_byref_CritterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass16_0>.NativeClassPtr, 100691948);
        CritterSystem.__c__DisplayClass16_0.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_Entity_byref_CritterData_byref_Rotation_byref_Translation_byref_LocalToWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass16_0>.NativeClassPtr, 100691949);
      }

      public __c__DisplayClass16_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass16_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass16_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass16_0>.NativeClassPtr, data));
      }

      public unsafe CritterSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (CritterSystem) null : new CritterSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool localPlayerMoving
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_localPlayerMoving));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_localPlayerMoving)) = value;
        }
      }

      public unsafe Translation localPlayerPos
      {
        get
        {
          return *(Translation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_localPlayerPos));
        }
        [param: In] set
        {
          *(Translation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_localPlayerPos)) = value;
        }
      }

      public unsafe float deltaTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_deltaTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_deltaTime)) = value;
        }
      }

      public unsafe CollisionWorld collisionWorld
      {
        get
        {
          return *(CollisionWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_collisionWorld));
        }
        [param: In] set
        {
          *(CollisionWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_collisionWorld)) = value;
        }
      }

      public unsafe float3 globalUp
      {
        get
        {
          return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_globalUp));
        }
        [param: In] set
        {
          *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_globalUp)) = value;
        }
      }

      public unsafe TileMapCollisionMath.MapData mapData
      {
        get
        {
          return *(TileMapCollisionMath.MapData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_mapData));
        }
        [param: In] set
        {
          *(TileMapCollisionMath.MapData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_mapData)) = value;
        }
      }

      public unsafe WorldType worldType
      {
        get
        {
          return *(WorldType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_worldType));
        }
        [param: In] set
        {
          *(WorldType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass16_0.NativeFieldInfoPtr_worldType)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Hybrid.CritterSystem/ProjectM.Hybrid.<>c__DisplayClass_UpdateCrittersHybrid")]
    public sealed class __c__DisplayClass_UpdateCrittersHybrid : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_HybridCritterComponent_byref_HybridModel_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_byref___c__DisplayClass16_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1155414, RefRangeEnd = 1155415, XrefRangeStart = 1155404, XrefRangeEnd = 1155414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(HybridCritterComponent hc, ref HybridModel hm)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hc);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hm;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_HybridCritterComponent_byref_HybridModel_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(18)]
      [CachedScanResults(RefRangeStart = 755322, RefRangeEnd = 755340, XrefRangeStart = 755322, XrefRangeEnd = 755340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref CritterSystem.__c__DisplayClass16_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(24)]
      [CachedScanResults(RefRangeStart = 755341, RefRangeEnd = 755365, XrefRangeStart = 755341, XrefRangeEnd = 755365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref CritterSystem.__c__DisplayClass16_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155415, XrefRangeEnd = 1155417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1155425, RefRangeEnd = 1155426, XrefRangeStart = 1155417, XrefRangeEnd = 1155425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) runtimes);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1155458, RefRangeEnd = 1155459, XrefRangeStart = 1155426, XrefRangeEnd = 1155458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        CritterSystem componentSystem,
        ref CritterSystem.__c__DisplayClass16_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_byref___c__DisplayClass16_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155459, XrefRangeEnd = 1155465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateCrittersHybrid()
      {
        Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateCrittersHybrid");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid>.NativeClassPtr);
        CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid>.NativeClassPtr, "<>4__this");
        CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid>.NativeClassPtr, nameof (_runtimes));
        CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_HybridCritterComponent_byref_HybridModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid>.NativeClassPtr, 100691950);
        CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid>.NativeClassPtr, 100691951);
        CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid>.NativeClassPtr, 100691952);
        CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid>.NativeClassPtr, 100691953);
        CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid>.NativeClassPtr, 100691954);
        CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_byref___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid>.NativeClassPtr, 100691955);
        CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid>.NativeClassPtr, 100691956);
      }

      public __c__DisplayClass_UpdateCrittersHybrid(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_UpdateCrittersHybrid()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid>.NativeClassPtr, data));
      }

      public unsafe CritterSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (CritterSystem) null : new CritterSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_hc;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_hm;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_ManagedComponentData<HybridCritterComponent> forParameter_hc;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<HybridModel> forParameter_hm;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1155395, RefRangeEnd = 1155396, XrefRangeStart = 1155389, XrefRangeEnd = 1155395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(CritterSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1155403, RefRangeEnd = 1155404, XrefRangeStart = 1155396, XrefRangeEnd = 1155403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return new CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders.Runtimes(pointer);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_hc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_hc));
          CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_hm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_hm));
          CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders>.NativeClassPtr, 100691957);
          CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders>.NativeClassPtr, 100691958);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public sealed class Runtimes : Il2CppSystem.ValueType
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_hc;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_hm;

          static Runtimes()
          {
            Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_hc));
            CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_hm));
          }

          public Runtimes(System.IntPtr pointer)
            : base(pointer)
          {
          }

          public Runtimes()
          {
            // ISSUE: cast to a reference type
            // ISSUE: untyped stack allocation
            System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            // ISSUE: explicit constructor call
            base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, data));
          }

          public LambdaParameterValueProvider_ManagedComponentData<HybridCritterComponent>.Runtime runtime_hc
          {
            get
            {
              System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hc);
              return new LambdaParameterValueProvider_ManagedComponentData<HybridCritterComponent>.Runtime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<HybridCritterComponent>.Runtime>.NativeClassPtr, data));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hc), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<HybridCritterComponent>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }

          public unsafe LambdaParameterValueProvider_IComponentData<HybridModel>.Runtime runtime_hm
          {
            get
            {
              return *(LambdaParameterValueProvider_IComponentData<HybridModel>.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hm));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass_UpdateCrittersHybrid.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hm), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_IComponentData<HybridModel>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Hybrid.CritterSystem/ProjectM.Hybrid.<>c__DisplayClass_UpdateCrittersDOTS")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateCrittersDOTS
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerMoving;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerPos;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CritterData_byref_Rotation_byref_Translation_byref_Entity_byref_LocalToWorld_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_byref___c__DisplayClass16_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public bool localPlayerMoving;
      [FieldOffset(4)]
      public Translation localPlayerPos;
      [FieldOffset(16)]
      public float deltaTime;
      [FieldOffset(24)]
      public CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(160)]
      public unsafe CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155568, XrefRangeEnd = 1155569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref CritterData critter,
        ref Rotation rotation,
        ref Translation translation,
        [In] ref Entity entity,
        [In] ref LocalToWorld localToWorldVar)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) ref critter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref localToWorldVar;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CritterData_byref_Rotation_byref_Translation_byref_Entity_byref_LocalToWorld_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1155569, RefRangeEnd = 1155570, XrefRangeStart = 1155569, XrefRangeEnd = 1155569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref CritterSystem.__c__DisplayClass16_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1155570, RefRangeEnd = 1155571, XrefRangeStart = 1155570, XrefRangeEnd = 1155570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref CritterSystem.__c__DisplayClass16_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155571, XrefRangeEnd = 1155573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1155588, RefRangeEnd = 1155589, XrefRangeStart = 1155573, XrefRangeEnd = 1155588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1155591, RefRangeEnd = 1155592, XrefRangeStart = 1155589, XrefRangeEnd = 1155591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        CritterSystem componentSystem,
        ref CritterSystem.__c__DisplayClass16_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_byref___c__DisplayClass16_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155592, XrefRangeEnd = 1155596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155596, XrefRangeEnd = 1155602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateCrittersDOTS()
      {
        Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateCrittersDOTS");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS>.NativeClassPtr);
        CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeFieldInfoPtr_localPlayerMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS>.NativeClassPtr, nameof (localPlayerMoving));
        CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeFieldInfoPtr_localPlayerPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS>.NativeClassPtr, nameof (localPlayerPos));
        CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS>.NativeClassPtr, nameof (deltaTime));
        CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS>.NativeClassPtr, nameof (_runtimes));
        CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CritterData_byref_Rotation_byref_Translation_byref_Entity_byref_LocalToWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS>.NativeClassPtr, 100691959);
        CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS>.NativeClassPtr, 100691960);
        CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS>.NativeClassPtr, 100691961);
        CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS>.NativeClassPtr, 100691962);
        CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS>.NativeClassPtr, 100691963);
        CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_byref___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS>.NativeClassPtr, 100691964);
        CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS>.NativeClassPtr, 100691965);
        CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS>.NativeClassPtr, 100691966);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_critter;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_rotation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_localToWorldVar;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<CritterData> forParameter_critter;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<Rotation> forParameter_rotation;
        [FieldOffset(64)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(96)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(104)]
        public LambdaParameterValueProvider_IComponentData<LocalToWorld> forParameter_localToWorldVar;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1155478, RefRangeEnd = 1155479, XrefRangeStart = 1155465, XrefRangeEnd = 1155478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(CritterSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1155492, RefRangeEnd = 1155493, XrefRangeStart = 1155479, XrefRangeEnd = 1155492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_critter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_critter));
          CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_rotation));
          CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_localToWorldVar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_localToWorldVar));
          CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders>.NativeClassPtr, 100691967);
          CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders>.NativeClassPtr, 100691968);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_critter;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_rotation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_localToWorldVar;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<CritterData>.Runtime runtime_critter;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Rotation>.Runtime runtime_rotation;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<LocalToWorld>.Runtime runtime_localToWorldVar;

          static Runtimes()
          {
            Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_critter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_critter));
            CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_rotation));
            CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_localToWorldVar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_localToWorldVar));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Hybrid.CritterSystem/ProjectM.Hybrid.<>c__DisplayClass_UpdateCrittersDOTS/ProjectM.Hybrid.RunWithoutJobSystem_000062FA$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS>.NativeClassPtr, "RunWithoutJobSystem_000062FA$PostfixBurstDelegate");
          CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691969);
          CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691970);
          CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691971);
          CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691972);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Hybrid.CritterSystem/ProjectM.Hybrid.<>c__DisplayClass_UpdateCrittersDOTS/ProjectM.Hybrid.RunWithoutJobSystem_000062FA$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155493, XrefRangeEnd = 1155507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155507, XrefRangeEnd = 1155525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155525, XrefRangeEnd = 1155540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1155567, RefRangeEnd = 1155568, XrefRangeStart = 1155540, XrefRangeEnd = 1155567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS>.NativeClassPtr, "RunWithoutJobSystem_000062FA$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691973);
          CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691974);
          CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691975);
          CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691976);
          CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691978);
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
            IL2CPP.il2cpp_field_static_get_value(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CritterSystem.__c__DisplayClass_UpdateCrittersDOTS.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Hybrid.CritterSystem/ProjectM.Hybrid.<>c__DisplayClass_FlyingCritter_AvoidObstacles")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_FlyingCritter_AvoidObstacles
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_globalUp;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CritterData_byref_Rotation_byref_Translation_byref_LocalToWorld_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_byref___c__DisplayClass16_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public CollisionWorld collisionWorld;
      [FieldOffset(344)]
      public float deltaTime;
      [FieldOffset(348)]
      public float3 globalUp;
      [FieldOffset(360)]
      public CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(488)]
      public unsafe CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155703, XrefRangeEnd = 1155730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref CritterData critter,
        ref Rotation rotation,
        ref Translation translation,
        [In] ref LocalToWorld localToWorldVar)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref critter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref localToWorldVar;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CritterData_byref_Rotation_byref_Translation_byref_LocalToWorld_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1155730, RefRangeEnd = 1155731, XrefRangeStart = 1155730, XrefRangeEnd = 1155730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref CritterSystem.__c__DisplayClass16_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1155731, RefRangeEnd = 1155732, XrefRangeStart = 1155731, XrefRangeEnd = 1155731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref CritterSystem.__c__DisplayClass16_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155732, XrefRangeEnd = 1155734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1155748, RefRangeEnd = 1155749, XrefRangeStart = 1155734, XrefRangeEnd = 1155748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1155751, RefRangeEnd = 1155752, XrefRangeStart = 1155749, XrefRangeEnd = 1155751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        CritterSystem componentSystem,
        ref CritterSystem.__c__DisplayClass16_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_byref___c__DisplayClass16_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155752, XrefRangeEnd = 1155756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155756, XrefRangeEnd = 1155762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_FlyingCritter_AvoidObstacles()
      {
        Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, "<>c__DisplayClass_FlyingCritter_AvoidObstacles");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles>.NativeClassPtr);
        CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeFieldInfoPtr_collisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles>.NativeClassPtr, nameof (collisionWorld));
        CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles>.NativeClassPtr, nameof (deltaTime));
        CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeFieldInfoPtr_globalUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles>.NativeClassPtr, nameof (globalUp));
        CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles>.NativeClassPtr, nameof (_runtimes));
        CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CritterData_byref_Rotation_byref_Translation_byref_LocalToWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles>.NativeClassPtr, 100691979);
        CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles>.NativeClassPtr, 100691980);
        CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles>.NativeClassPtr, 100691981);
        CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles>.NativeClassPtr, 100691982);
        CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles>.NativeClassPtr, 100691983);
        CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_byref___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles>.NativeClassPtr, 100691984);
        CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles>.NativeClassPtr, 100691985);
        CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles>.NativeClassPtr, 100691986);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_critter;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_rotation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_localToWorldVar;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<CritterData> forParameter_critter;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<Rotation> forParameter_rotation;
        [FieldOffset(64)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(96)]
        public LambdaParameterValueProvider_IComponentData<LocalToWorld> forParameter_localToWorldVar;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1155614, RefRangeEnd = 1155615, XrefRangeStart = 1155602, XrefRangeEnd = 1155614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(CritterSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1155627, RefRangeEnd = 1155628, XrefRangeStart = 1155615, XrefRangeEnd = 1155627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_critter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_critter));
          CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_rotation));
          CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_localToWorldVar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_localToWorldVar));
          CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders>.NativeClassPtr, 100691987);
          CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders>.NativeClassPtr, 100691988);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_critter;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_rotation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_localToWorldVar;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<CritterData>.Runtime runtime_critter;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Rotation>.Runtime runtime_rotation;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<LocalToWorld>.Runtime runtime_localToWorldVar;

          static Runtimes()
          {
            Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_critter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_critter));
            CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_rotation));
            CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_localToWorldVar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_localToWorldVar));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Hybrid.CritterSystem/ProjectM.Hybrid.<>c__DisplayClass_FlyingCritter_AvoidObstacles/ProjectM.Hybrid.RunWithoutJobSystem_00006303$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles>.NativeClassPtr, "RunWithoutJobSystem_00006303$PostfixBurstDelegate");
          CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691989);
          CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691990);
          CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691991);
          CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100691992);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Hybrid.CritterSystem/ProjectM.Hybrid.<>c__DisplayClass_FlyingCritter_AvoidObstacles/ProjectM.Hybrid.RunWithoutJobSystem_00006303$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155628, XrefRangeEnd = 1155642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155642, XrefRangeEnd = 1155660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155660, XrefRangeEnd = 1155675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1155702, RefRangeEnd = 1155703, XrefRangeStart = 1155675, XrefRangeEnd = 1155702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles>.NativeClassPtr, "RunWithoutJobSystem_00006303$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691993);
          CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691994);
          CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691995);
          CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691996);
          CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100691998);
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
            IL2CPP.il2cpp_field_static_get_value(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CritterSystem.__c__DisplayClass_FlyingCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Hybrid.CritterSystem/ProjectM.Hybrid.<>c__DisplayClass_SpawnCritterSequences")]
    public sealed class __c__DisplayClass_SpawnCritterSequences : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Entity_byref_CritterData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_byref___c__DisplayClass16_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1155798, RefRangeEnd = 1155799, XrefRangeStart = 1155772, XrefRangeEnd = 1155798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref Entity entity, [In] ref CritterData critter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref critter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Entity_byref_CritterData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(18)]
      [CachedScanResults(RefRangeStart = 755322, RefRangeEnd = 755340, XrefRangeStart = 755322, XrefRangeEnd = 755340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref CritterSystem.__c__DisplayClass16_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(24)]
      [CachedScanResults(RefRangeStart = 755341, RefRangeEnd = 755365, XrefRangeStart = 755341, XrefRangeEnd = 755365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref CritterSystem.__c__DisplayClass16_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155799, XrefRangeEnd = 1155810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1155816, RefRangeEnd = 1155817, XrefRangeStart = 1155810, XrefRangeEnd = 1155816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 855576, RefRangeEnd = 855582, XrefRangeStart = 855576, XrefRangeEnd = 855582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        CritterSystem componentSystem,
        ref CritterSystem.__c__DisplayClass16_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_byref___c__DisplayClass16_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SpawnCritterSequences()
      {
        Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, "<>c__DisplayClass_SpawnCritterSequences");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences>.NativeClassPtr);
        CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences>.NativeClassPtr, "<>4__this");
        CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences>.NativeClassPtr, nameof (_runtimes));
        CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences>.NativeClassPtr, nameof (_performLambdaDelegate));
        CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Entity_byref_CritterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences>.NativeClassPtr, 100691999);
        CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences>.NativeClassPtr, 100692000);
        CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences>.NativeClassPtr, 100692001);
        CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences>.NativeClassPtr, 100692003);
        CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences>.NativeClassPtr, 100692004);
        CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_byref___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences>.NativeClassPtr, 100692005);
      }

      public __c__DisplayClass_SpawnCritterSequences(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_SpawnCritterSequences()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences>.NativeClassPtr, data));
      }

      public unsafe CritterSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (CritterSystem) null : new CritterSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CritterSystem.__c__DisplayClass_SpawnCritterSequences.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_critter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<CritterData> forParameter_critter;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155762, XrefRangeEnd = 1155766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(CritterSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1155771, RefRangeEnd = 1155772, XrefRangeStart = 1155766, XrefRangeEnd = 1155771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_critter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_critter));
          CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders>.NativeClassPtr, 100692006);
          CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders>.NativeClassPtr, 100692007);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_critter;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<CritterData>.StructuralChangeRuntime runtime_critter;

          static Runtimes()
          {
            Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_critter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_critter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_SpawnCritterSequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Hybrid.CritterSystem/ProjectM.Hybrid.<>c__DisplayClass_GroundCritter_AvoidObstacles")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_GroundCritter_AvoidObstacles
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_mapData;
      private static readonly System.IntPtr NativeFieldInfoPtr_worldType;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CritterData_byref_Rotation_byref_Translation_byref_LocalToWorld_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_byref___c__DisplayClass16_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public TileMapCollisionMath.MapData mapData;
      [FieldOffset(104)]
      public WorldType worldType;
      [FieldOffset(108)]
      public float deltaTime;
      [FieldOffset(112)]
      public CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(248)]
      public unsafe CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155920, XrefRangeEnd = 1155939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref CritterData critter,
        ref Rotation rotation,
        ref Translation translation,
        [In] ref LocalToWorld localToWorldVar)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref critter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref localToWorldVar;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CritterData_byref_Rotation_byref_Translation_byref_LocalToWorld_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1155939, RefRangeEnd = 1155940, XrefRangeStart = 1155939, XrefRangeEnd = 1155939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref CritterSystem.__c__DisplayClass16_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1155940, RefRangeEnd = 1155941, XrefRangeStart = 1155940, XrefRangeEnd = 1155940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref CritterSystem.__c__DisplayClass16_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155941, XrefRangeEnd = 1155943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1155958, RefRangeEnd = 1155959, XrefRangeStart = 1155943, XrefRangeEnd = 1155958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1155961, RefRangeEnd = 1155962, XrefRangeStart = 1155959, XrefRangeEnd = 1155961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        CritterSystem componentSystem,
        ref CritterSystem.__c__DisplayClass16_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_byref___c__DisplayClass16_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155962, XrefRangeEnd = 1155966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155966, XrefRangeEnd = 1155972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_GroundCritter_AvoidObstacles()
      {
        Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterSystem>.NativeClassPtr, "<>c__DisplayClass_GroundCritter_AvoidObstacles");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles>.NativeClassPtr);
        CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeFieldInfoPtr_mapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles>.NativeClassPtr, nameof (mapData));
        CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeFieldInfoPtr_worldType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles>.NativeClassPtr, nameof (worldType));
        CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles>.NativeClassPtr, nameof (deltaTime));
        CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles>.NativeClassPtr, nameof (_runtimes));
        CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CritterData_byref_Rotation_byref_Translation_byref_LocalToWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles>.NativeClassPtr, 100692008);
        CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles>.NativeClassPtr, 100692009);
        CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles>.NativeClassPtr, 100692010);
        CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles>.NativeClassPtr, 100692011);
        CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles>.NativeClassPtr, 100692012);
        CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_byref___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles>.NativeClassPtr, 100692013);
        CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles>.NativeClassPtr, 100692014);
        CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles>.NativeClassPtr, 100692015);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_critter;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_rotation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_localToWorldVar;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<CritterData> forParameter_critter;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Rotation> forParameter_rotation;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(104)]
        public LambdaParameterValueProvider_IComponentData<LocalToWorld> forParameter_localToWorldVar;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1155830, RefRangeEnd = 1155831, XrefRangeStart = 1155817, XrefRangeEnd = 1155830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(CritterSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1155844, RefRangeEnd = 1155845, XrefRangeStart = 1155831, XrefRangeEnd = 1155844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_critter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_critter));
          CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_rotation));
          CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_localToWorldVar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_localToWorldVar));
          CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders>.NativeClassPtr, 100692016);
          CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders>.NativeClassPtr, 100692017);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_critter;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_rotation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_localToWorldVar;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<CritterData>.Runtime runtime_critter;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Rotation>.Runtime runtime_rotation;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<LocalToWorld>.Runtime runtime_localToWorldVar;

          static Runtimes()
          {
            Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_critter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_critter));
            CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_rotation));
            CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_localToWorldVar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_localToWorldVar));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Hybrid.CritterSystem/ProjectM.Hybrid.<>c__DisplayClass_GroundCritter_AvoidObstacles/ProjectM.Hybrid.RunWithoutJobSystem_00006315$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles>.NativeClassPtr, "RunWithoutJobSystem_00006315$PostfixBurstDelegate");
          CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100692018);
          CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100692019);
          CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100692020);
          CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100692021);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Hybrid.CritterSystem/ProjectM.Hybrid.<>c__DisplayClass_GroundCritter_AvoidObstacles/ProjectM.Hybrid.RunWithoutJobSystem_00006315$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155845, XrefRangeEnd = 1155859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155859, XrefRangeEnd = 1155877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155877, XrefRangeEnd = 1155892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1155919, RefRangeEnd = 1155920, XrefRangeStart = 1155892, XrefRangeEnd = 1155919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles>.NativeClassPtr, "RunWithoutJobSystem_00006315$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100692022);
          CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100692023);
          CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100692024);
          CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100692025);
          CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100692027);
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
            IL2CPP.il2cpp_field_static_get_value(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CritterSystem.__c__DisplayClass_GroundCritter_AvoidObstacles.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
