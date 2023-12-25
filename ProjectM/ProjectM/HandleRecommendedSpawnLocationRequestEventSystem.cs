// Decompiled with JetBrains decompiler
// Type: ProjectM.HandleRecommendedSpawnLocationRequestEventSystem
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
using Unity.Physics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class HandleRecommendedSpawnLocationRequestEventSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__EventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__FarbanePolygon;
    private static readonly System.IntPtr NativeFieldInfoPtr__FarbanePolygonBounds;
    private static readonly System.IntPtr NativeFieldInfoPtr__TerrainManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnLocations;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob3_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob3_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob4_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob4_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AllSamePoints_Private_Static_Boolean_NativeHashMap_2_NetworkId_SpawnLocationData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AdjustPointsOfClosest_Private_Static_Void_NativeHashMap_2_NetworkId_SpawnLocationData_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob4_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_3;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009990, XrefRangeEnd = 1010007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1010007, XrefRangeEnd = 1010010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1010010, XrefRangeEnd = 1010195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1010217, RefRangeEnd = 1010218, XrefRangeStart = 1010195, XrefRangeEnd = 1010217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool AllSamePoints(
      NativeHashMap<NetworkId, SpawnLocationData> spawnLocations)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &spawnLocations;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr_AllSamePoints_Private_Static_Boolean_NativeHashMap_2_NetworkId_SpawnLocationData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1010250, RefRangeEnd = 1010252, XrefRangeStart = 1010218, XrefRangeEnd = 1010250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AdjustPointsOfClosest(
      NativeHashMap<NetworkId, SpawnLocationData> spawnLocations,
      float x,
      int points)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &spawnLocations;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &points;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr_AdjustPointsOfClosest_Private_Static_Void_NativeHashMap_2_NetworkId_SpawnLocationData_Single_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HandleRecommendedSpawnLocationRequestEventSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1010252, XrefRangeEnd = 1010366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1010366, XrefRangeEnd = 1010385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1010385, XrefRangeEnd = 1010404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1010432, RefRangeEnd = 1010433, XrefRangeStart = 1010404, XrefRangeEnd = 1010432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob2_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1010455, RefRangeEnd = 1010456, XrefRangeStart = 1010433, XrefRangeEnd = 1010455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob3_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1010484, RefRangeEnd = 1010485, XrefRangeStart = 1010456, XrefRangeEnd = 1010484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob4_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob4_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1010489, RefRangeEnd = 1010490, XrefRangeStart = 1010485, XrefRangeEnd = 1010489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1010494, RefRangeEnd = 1010495, XrefRangeStart = 1010490, XrefRangeEnd = 1010494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1010499, RefRangeEnd = 1010500, XrefRangeStart = 1010495, XrefRangeEnd = 1010499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1010504, RefRangeEnd = 1010505, XrefRangeStart = 1010500, XrefRangeEnd = 1010504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HandleRecommendedSpawnLocationRequestEventSystem()
    {
      Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (HandleRecommendedSpawnLocationRequestEventSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr);
      HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr__EventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, nameof (_EventQuery));
      HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr__FarbanePolygon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, nameof (_FarbanePolygon));
      HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr__FarbanePolygonBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, nameof (_FarbanePolygonBounds));
      HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr__TerrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, nameof (_TerrainManager));
      HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr__SpawnLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, nameof (_SpawnLocations));
      HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob1_entityQuery");
      HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob1_profilerMarker");
      HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob2_entityQuery");
      HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob2_profilerMarker");
      HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob3_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob3_entityQuery");
      HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob3_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob3_profilerMarker");
      HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob4_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob4_entityQuery");
      HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob4_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob4_profilerMarker");
      HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, 100678467);
      HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, 100678468);
      HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, 100678469);
      HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr_AllSamePoints_Private_Static_Boolean_NativeHashMap_2_NetworkId_SpawnLocationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, 100678470);
      HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr_AdjustPointsOfClosest_Private_Static_Void_NativeHashMap_2_NetworkId_SpawnLocationData_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, 100678471);
      HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, 100678472);
      HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, 100678473);
      HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, 100678474);
      HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, 100678475);
      HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, 100678476);
      HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, 100678477);
      HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob4_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, 100678478);
      HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, 100678479);
      HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, 100678480);
      HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, 100678481);
      HandleRecommendedSpawnLocationRequestEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, 100678482);
    }

    public HandleRecommendedSpawnLocationRequestEventSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _EventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr__EventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr__EventQuery)) = value;
      }
    }

    public unsafe Entity _FarbanePolygon
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr__FarbanePolygon));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr__FarbanePolygon)) = value;
      }
    }

    public unsafe Aabb _FarbanePolygonBounds
    {
      get
      {
        return *(Aabb*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr__FarbanePolygonBounds));
      }
      [param: In] set
      {
        *(Aabb*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr__FarbanePolygonBounds)) = value;
      }
    }

    public unsafe TerrainManager _TerrainManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr__TerrainManager));
        return pointer == System.IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr__TerrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeHashMap<NetworkId, SpawnLocationData> _SpawnLocations
    {
      get
      {
        return *(NativeHashMap<NetworkId, SpawnLocationData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr__SpawnLocations));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr__SpawnLocations), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, SpawnLocationData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob2_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob2_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob3_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob3_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob3_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob3_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob3_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob3_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob4_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob4_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob4_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob4_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob4_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob4_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.HandleRecommendedSpawnLocationRequestEventSystem/<>c__DisplayClass7_0")]
    public sealed class __c__DisplayClass7_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_userList;
      private static readonly System.IntPtr NativeFieldInfoPtr_farbanePolygon;
      private static readonly System.IntPtr NativeFieldInfoPtr_farbanePolygonBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnLocations;
      private static readonly System.IntPtr NativeFieldInfoPtr_castlesWithTeamsHashmap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_WorldRegionPolygon_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_NetworkId_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_byref_Team_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_byref_Team_byref_CurrentWorldRegion_byref_Translation_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0([In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(Entity entity, [In] ref WorldRegionPolygon polygon)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref polygon;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_WorldRegionPolygon_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2([In] ref NetworkId networkId, [In] ref Translation translation)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref networkId;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_NetworkId_byref_Translation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__3([In] ref Team team, [In] ref Translation translation)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref team;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_byref_Team_byref_Translation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__4(
        [In] ref Team team,
        [In] ref CurrentWorldRegion region,
        [In] ref Translation translation)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref team;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref region;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_byref_Team_byref_CurrentWorldRegion_byref_Translation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_0()
      {
        Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, "<>c__DisplayClass7_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0>.NativeClassPtr);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_userList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (userList));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_farbanePolygon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (farbanePolygon));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_farbanePolygonBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (farbanePolygonBounds));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_spawnLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (spawnLocations));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_castlesWithTeamsHashmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (castlesWithTeamsHashmap));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0>.NativeClassPtr, 100678483);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0>.NativeClassPtr, 100678484);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_WorldRegionPolygon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0>.NativeClassPtr, 100678485);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_byref_NetworkId_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0>.NativeClassPtr, 100678486);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_byref_Team_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0>.NativeClassPtr, 100678487);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_byref_Team_byref_CurrentWorldRegion_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0>.NativeClassPtr, 100678488);
      }

      public __c__DisplayClass7_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass7_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0>.NativeClassPtr, data));
      }

      public unsafe HandleRecommendedSpawnLocationRequestEventSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (HandleRecommendedSpawnLocationRequestEventSystem) null : new HandleRecommendedSpawnLocationRequestEventSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeList<int> userList
      {
        get
        {
          return *(NativeList<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_userList));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_userList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Entity farbanePolygon
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_farbanePolygon));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_farbanePolygon)) = value;
        }
      }

      public unsafe Aabb farbanePolygonBounds
      {
        get
        {
          return *(Aabb*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_farbanePolygonBounds));
        }
        [param: In] set
        {
          *(Aabb*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_farbanePolygonBounds)) = value;
        }
      }

      public unsafe NativeHashMap<NetworkId, SpawnLocationData> spawnLocations
      {
        get
        {
          return *(NativeHashMap<NetworkId, SpawnLocationData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_spawnLocations));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_spawnLocations), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, SpawnLocationData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeHashSet<int> castlesWithTeamsHashmap
      {
        get
        {
          return *(NativeHashSet<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_castlesWithTeamsHashmap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_castlesWithTeamsHashmap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashSet<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.HandleRecommendedSpawnLocationRequestEventSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    public sealed class __c__DisplayClass_OnUpdate_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_userList;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1009498, RefRangeEnd = 1009499, XrefRangeStart = 1009485, XrefRangeEnd = 1009498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 996504, RefRangeEnd = 996510, XrefRangeStart = 996504, XrefRangeEnd = 996510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(12)]
      [CachedScanResults(RefRangeStart = 996511, RefRangeEnd = 996523, XrefRangeStart = 996511, XrefRangeEnd = 996523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009499, XrefRangeEnd = 1009501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1009506, RefRangeEnd = 1009507, XrefRangeStart = 1009501, XrefRangeEnd = 1009506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1009509, RefRangeEnd = 1009510, XrefRangeStart = 1009507, XrefRangeEnd = 1009509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        HandleRecommendedSpawnLocationRequestEventSystem componentSystem,
        ref HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_byref___c__DisplayClass7_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009510, XrefRangeEnd = 1009516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "<>4__this");
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_userList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (userList));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100678489);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100678490);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100678491);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100678492);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100678493);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100678494);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100678495);
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe HandleRecommendedSpawnLocationRequestEventSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (HandleRecommendedSpawnLocationRequestEventSystem) null : new HandleRecommendedSpawnLocationRequestEventSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeList<int> userList
      {
        get
        {
          return *(NativeList<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_userList));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_userList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1009480, RefRangeEnd = 1009481, XrefRangeStart = 1009477, XrefRangeEnd = 1009480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          HandleRecommendedSpawnLocationRequestEventSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1009484, RefRangeEnd = 1009485, XrefRangeStart = 1009481, XrefRangeEnd = 1009484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100678496);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100678497);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.Runtime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.HandleRecommendedSpawnLocationRequestEventSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_farbanePolygon;
      private static readonly System.IntPtr NativeFieldInfoPtr_farbanePolygonBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_WorldRegionPolygon_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public Entity farbanePolygon;
      [FieldOffset(8)]
      public Aabb farbanePolygonBounds;
      [FieldOffset(32)]
      public HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(72)]
      public unsafe HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1009601, RefRangeEnd = 1009602, XrefRangeStart = 1009601, XrefRangeEnd = 1009601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref WorldRegionPolygon polygon)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref polygon;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_WorldRegionPolygon_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1009602, RefRangeEnd = 1009603, XrefRangeStart = 1009602, XrefRangeEnd = 1009602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1009603, RefRangeEnd = 1009604, XrefRangeStart = 1009603, XrefRangeEnd = 1009603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009604, XrefRangeEnd = 1009606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1009612, RefRangeEnd = 1009613, XrefRangeStart = 1009606, XrefRangeEnd = 1009612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1009615, RefRangeEnd = 1009616, XrefRangeStart = 1009613, XrefRangeEnd = 1009615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        HandleRecommendedSpawnLocationRequestEventSystem componentSystem,
        ref HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009616, XrefRangeEnd = 1009620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009620, XrefRangeEnd = 1009626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob1()
      {
        Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_farbanePolygon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (farbanePolygon));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_farbanePolygonBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (farbanePolygonBounds));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_WorldRegionPolygon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100678498);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100678499);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100678500);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100678501);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100678502);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100678503);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100678504);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100678505);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_polygon;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<WorldRegionPolygon> forParameter_polygon;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1009520, RefRangeEnd = 1009521, XrefRangeStart = 1009516, XrefRangeEnd = 1009520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          HandleRecommendedSpawnLocationRequestEventSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1009525, RefRangeEnd = 1009526, XrefRangeStart = 1009521, XrefRangeEnd = 1009525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_polygon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_polygon));
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100678506);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100678507);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_polygon;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<WorldRegionPolygon>.Runtime runtime_polygon;

          static Runtimes()
          {
            Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_polygon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_polygon));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.HandleRecommendedSpawnLocationRequestEventSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob1/ProjectM.RunWithoutJobSystem_000038B8$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_000038B8$PostfixBurstDelegate");
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100678508);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100678509);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100678510);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100678511);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.HandleRecommendedSpawnLocationRequestEventSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob1/ProjectM.RunWithoutJobSystem_000038B8$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009526, XrefRangeEnd = 1009540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009540, XrefRangeEnd = 1009558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009558, XrefRangeEnd = 1009573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1009600, RefRangeEnd = 1009601, XrefRangeStart = 1009573, XrefRangeEnd = 1009600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_000038B8$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678512);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678513);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678514);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678515);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678517);
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
            IL2CPP.il2cpp_field_static_get_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.HandleRecommendedSpawnLocationRequestEventSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob2")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob2
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnLocations;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_NetworkId_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<NetworkId, SpawnLocationData> spawnLocations;
      [FieldOffset(16)]
      public HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009715, XrefRangeEnd = 1009718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref NetworkId networkId, [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref networkId;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_NetworkId_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 759725, RefRangeEnd = 759727, XrefRangeStart = 759725, XrefRangeEnd = 759727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 759727, RefRangeEnd = 759729, XrefRangeStart = 759727, XrefRangeEnd = 759729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009718, XrefRangeEnd = 1009720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1009728, RefRangeEnd = 1009729, XrefRangeStart = 1009720, XrefRangeEnd = 1009728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1009731, RefRangeEnd = 1009732, XrefRangeStart = 1009729, XrefRangeEnd = 1009731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        HandleRecommendedSpawnLocationRequestEventSystem componentSystem,
        ref HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009732, XrefRangeEnd = 1009736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009736, XrefRangeEnd = 1009742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob2()
      {
        Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_spawnLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (spawnLocations));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_runtimes));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_NetworkId_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100678518);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100678519);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100678520);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100678521);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100678522);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100678523);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100678524);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100678525);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_networkId;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<NetworkId> forParameter_networkId;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1009632, RefRangeEnd = 1009633, XrefRangeStart = 1009626, XrefRangeEnd = 1009632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          HandleRecommendedSpawnLocationRequestEventSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1009639, RefRangeEnd = 1009640, XrefRangeStart = 1009633, XrefRangeEnd = 1009639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_networkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_networkId));
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100678526);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100678527);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_networkId;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<NetworkId>.Runtime runtime_networkId;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;

          static Runtimes()
          {
            Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_networkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_networkId));
            HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.HandleRecommendedSpawnLocationRequestEventSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob2/ProjectM.RunWithoutJobSystem_000038C1$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_000038C1$PostfixBurstDelegate");
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100678528);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100678529);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100678530);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100678531);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.HandleRecommendedSpawnLocationRequestEventSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob2/ProjectM.RunWithoutJobSystem_000038C1$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009640, XrefRangeEnd = 1009654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009654, XrefRangeEnd = 1009672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009672, XrefRangeEnd = 1009687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1009714, RefRangeEnd = 1009715, XrefRangeStart = 1009687, XrefRangeEnd = 1009714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_000038C1$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678532);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678533);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678534);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678535);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678537);
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
            IL2CPP.il2cpp_field_static_get_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.HandleRecommendedSpawnLocationRequestEventSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob3")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob3
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_castlesWithTeamsHashmap;
      private static readonly System.IntPtr NativeFieldInfoPtr_farbanePolygonBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnLocations;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Team_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashSet<int> castlesWithTeamsHashmap;
      [FieldOffset(16)]
      public Aabb farbanePolygonBounds;
      [FieldOffset(40)]
      public NativeHashMap<NetworkId, SpawnLocationData> spawnLocations;
      [FieldOffset(56)]
      public HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(120)]
      public unsafe HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009831, XrefRangeEnd = 1009836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref Team team, [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref team;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Team_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1009836, RefRangeEnd = 1009837, XrefRangeStart = 1009836, XrefRangeEnd = 1009836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1009837, RefRangeEnd = 1009838, XrefRangeStart = 1009837, XrefRangeEnd = 1009837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009838, XrefRangeEnd = 1009840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1009848, RefRangeEnd = 1009849, XrefRangeStart = 1009840, XrefRangeEnd = 1009848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1009851, RefRangeEnd = 1009852, XrefRangeStart = 1009849, XrefRangeEnd = 1009851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        HandleRecommendedSpawnLocationRequestEventSystem componentSystem,
        ref HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009852, XrefRangeEnd = 1009856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009856, XrefRangeEnd = 1009862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob3()
      {
        Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob3");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_castlesWithTeamsHashmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (castlesWithTeamsHashmap));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_farbanePolygonBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (farbanePolygonBounds));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_spawnLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (spawnLocations));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (_runtimes));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Team_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100678538);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100678539);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100678540);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100678541);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100678542);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100678543);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100678544);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, 100678545);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_team;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<Team> forParameter_team;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1009748, RefRangeEnd = 1009749, XrefRangeStart = 1009742, XrefRangeEnd = 1009748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          HandleRecommendedSpawnLocationRequestEventSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1009755, RefRangeEnd = 1009756, XrefRangeStart = 1009749, XrefRangeEnd = 1009755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_team));
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, 100678546);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, 100678547);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_team;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<Team>.Runtime runtime_team;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;

          static Runtimes()
          {
            Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_team));
            HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.HandleRecommendedSpawnLocationRequestEventSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob3/ProjectM.RunWithoutJobSystem_000038CA$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, "RunWithoutJobSystem_000038CA$PostfixBurstDelegate");
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100678548);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100678549);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100678550);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100678551);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.HandleRecommendedSpawnLocationRequestEventSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob3/ProjectM.RunWithoutJobSystem_000038CA$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009756, XrefRangeEnd = 1009770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009770, XrefRangeEnd = 1009788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009788, XrefRangeEnd = 1009803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1009830, RefRangeEnd = 1009831, XrefRangeStart = 1009803, XrefRangeEnd = 1009830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3>.NativeClassPtr, "RunWithoutJobSystem_000038CA$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678552);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678553);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678554);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678555);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678557);
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
            IL2CPP.il2cpp_field_static_get_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.HandleRecommendedSpawnLocationRequestEventSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob4")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob4
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_castlesWithTeamsHashmap;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnLocations;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Team_byref_CurrentWorldRegion_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashSet<int> castlesWithTeamsHashmap;
      [FieldOffset(16)]
      public NativeHashMap<NetworkId, SpawnLocationData> spawnLocations;
      [FieldOffset(32)]
      public HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(128)]
      public unsafe HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009957, XrefRangeEnd = 1009961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref Team team,
        [In] ref CurrentWorldRegion region,
        [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref team;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref region;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Team_byref_CurrentWorldRegion_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1009961, RefRangeEnd = 1009962, XrefRangeStart = 1009961, XrefRangeEnd = 1009961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1009962, RefRangeEnd = 1009963, XrefRangeStart = 1009962, XrefRangeEnd = 1009962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009963, XrefRangeEnd = 1009965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1009976, RefRangeEnd = 1009977, XrefRangeStart = 1009965, XrefRangeEnd = 1009976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1009979, RefRangeEnd = 1009980, XrefRangeStart = 1009977, XrefRangeEnd = 1009979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        HandleRecommendedSpawnLocationRequestEventSystem componentSystem,
        ref HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009980, XrefRangeEnd = 1009984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009984, XrefRangeEnd = 1009990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob4()
      {
        Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob4");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_castlesWithTeamsHashmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (castlesWithTeamsHashmap));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_spawnLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (spawnLocations));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (_runtimes));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Team_byref_CurrentWorldRegion_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100678558);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100678559);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100678560);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100678561);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100678562);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100678563);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100678564);
        HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, 100678565);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_team;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_region;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<Team> forParameter_team;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<CurrentWorldRegion> forParameter_region;
        [FieldOffset(64)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1009871, RefRangeEnd = 1009872, XrefRangeStart = 1009862, XrefRangeEnd = 1009871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          HandleRecommendedSpawnLocationRequestEventSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1009881, RefRangeEnd = 1009882, XrefRangeStart = 1009872, XrefRangeEnd = 1009881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_team));
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_region));
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HandleRecommendedSpawnLocationRequestEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, 100678566);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, 100678567);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_team;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_region;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<Team>.Runtime runtime_team;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<CurrentWorldRegion>.Runtime runtime_region;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;

          static Runtimes()
          {
            Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_team));
            HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_region));
            HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.HandleRecommendedSpawnLocationRequestEventSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob4/ProjectM.RunWithoutJobSystem_000038D3$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, "RunWithoutJobSystem_000038D3$PostfixBurstDelegate");
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100678568);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100678569);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100678570);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100678571);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.HandleRecommendedSpawnLocationRequestEventSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob4/ProjectM.RunWithoutJobSystem_000038D3$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009882, XrefRangeEnd = 1009896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009896, XrefRangeEnd = 1009914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009914, XrefRangeEnd = 1009929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1009956, RefRangeEnd = 1009957, XrefRangeStart = 1009929, XrefRangeEnd = 1009956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4>.NativeClassPtr, "RunWithoutJobSystem_000038D3$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678572);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678573);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678574);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678575);
          HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100678577);
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
            IL2CPP.il2cpp_field_static_get_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(HandleRecommendedSpawnLocationRequestEventSystem.__c__DisplayClass_OnUpdate_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
