// Decompiled with JetBrains decompiler
// Type: CritterGroupSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
public class CritterGroupSystem : SystemBase
{
  private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
  private static readonly System.IntPtr NativeFieldInfoPtr__Archetype;
  private static readonly System.IntPtr NativeFieldInfoPtr__PlayerPosQuery;
  private static readonly System.IntPtr NativeFieldInfoPtr__NewSpawnsQuery;
  private static readonly System.IntPtr NativeFieldInfoPtr__RemoveSpawnsQuery;
  private static readonly System.IntPtr NativeFieldInfoPtr__Random;
  private static readonly System.IntPtr NativeFieldInfoPtr___ToggleActiveCritterGroups_entityQuery;
  private static readonly System.IntPtr NativeFieldInfoPtr___ToggleActiveCritterGroups_profilerMarker;
  private static readonly System.IntPtr NativeFieldInfoPtr___UpdateCritterGroups_entityQuery;
  private static readonly System.IntPtr NativeFieldInfoPtr___UpdateCritterGroups_profilerMarker;
  private static readonly System.IntPtr NativeFieldInfoPtr___DestroyCritters_entityQuery;
  private static readonly System.IntPtr NativeFieldInfoPtr___DestroyCritters_profilerMarker;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneMetadataDependencies_Private_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkMetadataLoadedEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneDependencies_Private_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkLoadedEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForToggleActiveCritterGroups_From_Public_Static_EntityQuery_ComponentSystemBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateCritterGroups_From_Public_Static_EntityQuery_ComponentSystemBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDestroyCritters_From_Public_Static_EntityQuery_ComponentSystemBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912923, XrefRangeEnd = 912970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnCreate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CritterGroupSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912970, XrefRangeEnd = 913204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CritterGroupSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneMetadataDependencies(
    ref ConvertOnDemandContext convertOnDemandContext,
    TerrainChunkMetadataLoadedEvent loadedEvent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref convertOnDemandContext;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &loadedEvent;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.NativeMethodInfoPtr_ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneMetadataDependencies_Private_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkMetadataLoadedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 913204, XrefRangeEnd = 913234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneDependencies(
    ref ConvertOnDemandContext convertOnDemandContext,
    TerrainChunkLoadedEvent loadedEvent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref convertOnDemandContext;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &loadedEvent;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.NativeMethodInfoPtr_ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneDependencies_Private_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkLoadedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(105)]
  [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CritterGroupSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 913234, XrefRangeEnd = 913320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnCreateForCompiler()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CritterGroupSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 913320, XrefRangeEnd = 913339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe EntityQuery __GetEntityQuery_ForToggleActiveCritterGroups_From(
    ComponentSystemBase componentSystem)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.NativeMethodInfoPtr___GetEntityQuery_ForToggleActiveCritterGroups_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 913361, RefRangeEnd = 913362, XrefRangeStart = 913339, XrefRangeEnd = 913361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe EntityQuery __GetEntityQuery_ForUpdateCritterGroups_From(
    ComponentSystemBase componentSystem)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateCritterGroups_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 913362, XrefRangeEnd = 913381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe EntityQuery __GetEntityQuery_ForDestroyCritters_From(
    ComponentSystemBase componentSystem)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.NativeMethodInfoPtr___GetEntityQuery_ForDestroyCritters_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 913385, RefRangeEnd = 913386, XrefRangeStart = 913381, XrefRangeEnd = 913385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Method_Public_Static_Void_0()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 913390, RefRangeEnd = 913391, XrefRangeStart = 913386, XrefRangeEnd = 913390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Method_Public_Static_Void_1()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 913395, RefRangeEnd = 913396, XrefRangeStart = 913391, XrefRangeEnd = 913395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Method_Public_Static_Void_2()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CritterGroupSystem()
  {
    Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (CritterGroupSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr);
    CritterGroupSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
    CritterGroupSystem.NativeFieldInfoPtr__Archetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, nameof (_Archetype));
    CritterGroupSystem.NativeFieldInfoPtr__PlayerPosQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, nameof (_PlayerPosQuery));
    CritterGroupSystem.NativeFieldInfoPtr__NewSpawnsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, nameof (_NewSpawnsQuery));
    CritterGroupSystem.NativeFieldInfoPtr__RemoveSpawnsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, nameof (_RemoveSpawnsQuery));
    CritterGroupSystem.NativeFieldInfoPtr__Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, nameof (_Random));
    CritterGroupSystem.NativeFieldInfoPtr___ToggleActiveCritterGroups_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, "<>ToggleActiveCritterGroups_entityQuery");
    CritterGroupSystem.NativeFieldInfoPtr___ToggleActiveCritterGroups_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, "<>ToggleActiveCritterGroups_profilerMarker");
    CritterGroupSystem.NativeFieldInfoPtr___UpdateCritterGroups_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, "<>UpdateCritterGroups_entityQuery");
    CritterGroupSystem.NativeFieldInfoPtr___UpdateCritterGroups_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, "<>UpdateCritterGroups_profilerMarker");
    CritterGroupSystem.NativeFieldInfoPtr___DestroyCritters_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, "<>DestroyCritters_entityQuery");
    CritterGroupSystem.NativeFieldInfoPtr___DestroyCritters_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, "<>DestroyCritters_profilerMarker");
    CritterGroupSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, 100663404);
    CritterGroupSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, 100663405);
    CritterGroupSystem.NativeMethodInfoPtr_ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneMetadataDependencies_Private_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkMetadataLoadedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, 100663406);
    CritterGroupSystem.NativeMethodInfoPtr_ProjectM_IDeclareTerrainChunkDependenciesOnLoad_AddSceneDependencies_Private_Virtual_Final_New_Void_byref_ConvertOnDemandContext_TerrainChunkLoadedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, 100663407);
    CritterGroupSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, 100663408);
    CritterGroupSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, 100663409);
    CritterGroupSystem.NativeMethodInfoPtr___GetEntityQuery_ForToggleActiveCritterGroups_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, 100663410);
    CritterGroupSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateCritterGroups_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, 100663411);
    CritterGroupSystem.NativeMethodInfoPtr___GetEntityQuery_ForDestroyCritters_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, 100663412);
    CritterGroupSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, 100663413);
    CritterGroupSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, 100663414);
    CritterGroupSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, 100663415);
  }

  public CritterGroupSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe PrefabCollectionSystem _PrefabCollectionSystem
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
      return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EntityArchetype _Archetype
  {
    get
    {
      return *(EntityArchetype*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr__Archetype));
    }
    [param: In] set
    {
      *(EntityArchetype*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr__Archetype)) = value;
    }
  }

  public unsafe EntityQuery _PlayerPosQuery
  {
    get
    {
      return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr__PlayerPosQuery));
    }
    [param: In] set
    {
      *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr__PlayerPosQuery)) = value;
    }
  }

  public unsafe EntityQuery _NewSpawnsQuery
  {
    get
    {
      return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr__NewSpawnsQuery));
    }
    [param: In] set
    {
      *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr__NewSpawnsQuery)) = value;
    }
  }

  public unsafe EntityQuery _RemoveSpawnsQuery
  {
    get
    {
      return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr__RemoveSpawnsQuery));
    }
    [param: In] set
    {
      *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr__RemoveSpawnsQuery)) = value;
    }
  }

  public unsafe Unity.Mathematics.Random _Random
  {
    get
    {
      return *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr__Random));
    }
    [param: In] set
    {
      *(Unity.Mathematics.Random*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr__Random)) = value;
    }
  }

  public unsafe EntityQuery __ToggleActiveCritterGroups_entityQuery
  {
    get
    {
      return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr___ToggleActiveCritterGroups_entityQuery));
    }
    [param: In] set
    {
      *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr___ToggleActiveCritterGroups_entityQuery)) = value;
    }
  }

  public unsafe ProfilerMarker __ToggleActiveCritterGroups_profilerMarker
  {
    get
    {
      return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr___ToggleActiveCritterGroups_profilerMarker));
    }
    [param: In] set
    {
      *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr___ToggleActiveCritterGroups_profilerMarker)) = value;
    }
  }

  public unsafe EntityQuery __UpdateCritterGroups_entityQuery
  {
    get
    {
      return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr___UpdateCritterGroups_entityQuery));
    }
    [param: In] set
    {
      *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr___UpdateCritterGroups_entityQuery)) = value;
    }
  }

  public unsafe ProfilerMarker __UpdateCritterGroups_profilerMarker
  {
    get
    {
      return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr___UpdateCritterGroups_profilerMarker));
    }
    [param: In] set
    {
      *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr___UpdateCritterGroups_profilerMarker)) = value;
    }
  }

  public unsafe EntityQuery __DestroyCritters_entityQuery
  {
    get
    {
      return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr___DestroyCritters_entityQuery));
    }
    [param: In] set
    {
      *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr___DestroyCritters_entityQuery)) = value;
    }
  }

  public unsafe ProfilerMarker __DestroyCritters_profilerMarker
  {
    get
    {
      return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr___DestroyCritters_profilerMarker));
    }
    [param: In] set
    {
      *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterGroupSystem.NativeFieldInfoPtr___DestroyCritters_profilerMarker)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct CritterSpawnTransform
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    [FieldOffset(0)]
    public quaternion Rotation;
    [FieldOffset(16)]
    public float3 Position;

    static CritterSpawnTransform()
    {
      Il2CppClassPointerStore<CritterGroupSystem.CritterSpawnTransform>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, nameof (CritterSpawnTransform));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterGroupSystem.CritterSpawnTransform>.NativeClassPtr);
      CritterGroupSystem.CritterSpawnTransform.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.CritterSpawnTransform>.NativeClassPtr, nameof (Rotation));
      CritterGroupSystem.CritterSpawnTransform.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.CritterSpawnTransform>.NativeClassPtr, nameof (Position));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterGroupSystem.CritterSpawnTransform>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct CritterDespawnData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GroupEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_DespawnEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_BufferIndex;
    [FieldOffset(0)]
    public Entity GroupEntity;
    [FieldOffset(8)]
    public Entity DespawnEntity;
    [FieldOffset(16)]
    public int BufferIndex;

    static CritterDespawnData()
    {
      Il2CppClassPointerStore<CritterGroupSystem.CritterDespawnData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, nameof (CritterDespawnData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterGroupSystem.CritterDespawnData>.NativeClassPtr);
      CritterGroupSystem.CritterDespawnData.NativeFieldInfoPtr_GroupEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.CritterDespawnData>.NativeClassPtr, nameof (GroupEntity));
      CritterGroupSystem.CritterDespawnData.NativeFieldInfoPtr_DespawnEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.CritterDespawnData>.NativeClassPtr, nameof (DespawnEntity));
      CritterGroupSystem.CritterDespawnData.NativeFieldInfoPtr_BufferIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.CritterDespawnData>.NativeClassPtr, nameof (BufferIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterGroupSystem.CritterDespawnData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("CritterGroupSystem/<>c__DisplayClass9_0")]
  [StructLayout(LayoutKind.Explicit)]
  public struct __c__DisplayClass9_0
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_playerPositions;
    private static readonly System.IntPtr NativeFieldInfoPtr_closestPlayerPosPerEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_random;
    private static readonly System.IntPtr NativeFieldInfoPtr_newSpawnTransforms;
    private static readonly System.IntPtr NativeFieldInfoPtr_newSpawnedGrp;
    private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
    private static readonly System.IntPtr NativeFieldInfoPtr_escapeSoundGrp;
    private static readonly System.IntPtr NativeFieldInfoPtr_destroyCritters;
    private static readonly System.IntPtr NativeFieldInfoPtr_destroyGroups;
    private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_CritterGroup_byref_LocalToWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_DynamicBuffer_1_CritterDataBuffer_byref_CritterGroup_byref_LocalToWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_CritterGroup_byref_DynamicBuffer_1_CritterDataBuffer_0;
    [FieldOffset(0)]
    public NativeArray<float3> playerPositions;
    [FieldOffset(16)]
    public NativeHashMap<Entity, float3> closestPlayerPosPerEntity;
    [FieldOffset(32)]
    public Unity.Mathematics.Random random;
    [FieldOffset(40)]
    public NativeList<CritterGroupSystem.CritterSpawnTransform> newSpawnTransforms;
    [FieldOffset(56)]
    public NativeList<Entity> newSpawnedGrp;
    [FieldOffset(72)]
    public EntityManager entityManager;
    [FieldOffset(80)]
    public NativeList<Entity> escapeSoundGrp;
    [FieldOffset(96)]
    public NativeList<CritterGroupSystem.CritterDespawnData> destroyCritters;
    [FieldOffset(112)]
    public NativeList<Entity> destroyGroups;
    [FieldOffset(128)]
    public float deltaTime;

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass9_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__0(
      Entity entity,
      ref CritterGroup critterGroup,
      [In] ref LocalToWorld localToWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref critterGroup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref localToWorld;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_CritterGroup_byref_LocalToWorld_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__1(
      Entity entity,
      ref DynamicBuffer<CritterDataBuffer> buffer,
      ref CritterGroup critterGroup,
      [In] ref LocalToWorld localToWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref critterGroup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref localToWorld;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_DynamicBuffer_1_CritterDataBuffer_byref_CritterGroup_byref_LocalToWorld_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__2(
      Entity entity,
      ref CritterGroup critterGroup,
      [In] ref DynamicBuffer<CritterDataBuffer> buffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref critterGroup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_CritterGroup_byref_DynamicBuffer_1_CritterDataBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass9_0()
    {
      Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, "<>c__DisplayClass9_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass9_0>.NativeClassPtr);
      CritterGroupSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_playerPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (playerPositions));
      CritterGroupSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_closestPlayerPosPerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (closestPlayerPosPerEntity));
      CritterGroupSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (random));
      CritterGroupSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_newSpawnTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (newSpawnTransforms));
      CritterGroupSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_newSpawnedGrp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (newSpawnedGrp));
      CritterGroupSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (entityManager));
      CritterGroupSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_escapeSoundGrp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (escapeSoundGrp));
      CritterGroupSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_destroyCritters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (destroyCritters));
      CritterGroupSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_destroyGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (destroyGroups));
      CritterGroupSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (deltaTime));
      CritterGroupSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass9_0>.NativeClassPtr, 100663416);
      CritterGroupSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_CritterGroup_byref_LocalToWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass9_0>.NativeClassPtr, 100663417);
      CritterGroupSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_DynamicBuffer_1_CritterDataBuffer_byref_CritterGroup_byref_LocalToWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass9_0>.NativeClassPtr, 100663418);
      CritterGroupSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_CritterGroup_byref_DynamicBuffer_1_CritterDataBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass9_0>.NativeClassPtr, 100663419);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass9_0>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("CritterGroupSystem/<>c__DisplayClass_ToggleActiveCritterGroups")]
  [StructLayout(LayoutKind.Explicit)]
  public struct __c__DisplayClass_ToggleActiveCritterGroups
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_playerPositions;
    private static readonly System.IntPtr NativeFieldInfoPtr_closestPlayerPosPerEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
    private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
    private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
    private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
    private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CritterGroup_byref_LocalToWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterGroupSystem_byref___c__DisplayClass9_0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
    [FieldOffset(0)]
    public NativeArray<float3> playerPositions;
    [FieldOffset(16)]
    public NativeHashMap<Entity, float3> closestPlayerPosPerEntity;
    [FieldOffset(32)]
    public CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders _lambdaParameterValueProviders;
    [FieldOffset(104)]
    public unsafe CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders.Runtimes* _runtimes;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912575, XrefRangeEnd = 912581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OriginalLambdaBody(
      Entity entity,
      ref CritterGroup critterGroup,
      [In] ref LocalToWorld localToWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref critterGroup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref localToWorld;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CritterGroup_byref_LocalToWorld_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 752109, RefRangeEnd = 752124, XrefRangeStart = 752109, XrefRangeEnd = 752124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ReadFromDisplayClass(
      ref CritterGroupSystem.__c__DisplayClass9_0 displayClass)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref displayClass;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 752124, RefRangeEnd = 752141, XrefRangeStart = 752124, XrefRangeEnd = 752141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void WriteToDisplayClass(
      ref CritterGroupSystem.__c__DisplayClass9_0 displayClass)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref displayClass;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912581, XrefRangeEnd = 912583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &chunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 912592, RefRangeEnd = 912593, XrefRangeStart = 912583, XrefRangeEnd = 912592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void IterateEntities(
      ref ArchetypeChunk chunk,
      ref CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders.Runtimes runtimes)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref chunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 912595, RefRangeEnd = 912596, XrefRangeStart = 912593, XrefRangeEnd = 912595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ScheduleTimeInitialize(
      CritterGroupSystem componentSystem,
      ref CritterGroupSystem.__c__DisplayClass9_0 displayClass)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterGroupSystem_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912596, XrefRangeEnd = 912600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RunWithoutJobSystem(
      ArchetypeChunkIterator* archetypeChunkIterator,
      void* jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912600, XrefRangeEnd = 912606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
      ArchetypeChunkIterator* archetypeChunkIterator,
      void* jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass_ToggleActiveCritterGroups()
    {
      Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, "<>c__DisplayClass_ToggleActiveCritterGroups");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups>.NativeClassPtr);
      CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeFieldInfoPtr_playerPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups>.NativeClassPtr, nameof (playerPositions));
      CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeFieldInfoPtr_closestPlayerPosPerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups>.NativeClassPtr, nameof (closestPlayerPosPerEntity));
      CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
      CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups>.NativeClassPtr, nameof (_runtimes));
      CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
      CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
      CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CritterGroup_byref_LocalToWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups>.NativeClassPtr, 100663420);
      CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups>.NativeClassPtr, 100663421);
      CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups>.NativeClassPtr, 100663422);
      CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups>.NativeClassPtr, 100663423);
      CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups>.NativeClassPtr, 100663424);
      CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterGroupSystem_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups>.NativeClassPtr, 100663425);
      CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups>.NativeClassPtr, 100663426);
      CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups>.NativeClassPtr, 100663427);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LambdaParameterValueProviders
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_critterGroup;
      private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_localToWorld;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterGroupSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public LambdaParameterValueProvider_Entity forParameter_entity;
      [FieldOffset(8)]
      public LambdaParameterValueProvider_IComponentData<CritterGroup> forParameter_critterGroup;
      [FieldOffset(40)]
      public LambdaParameterValueProvider_IComponentData<LocalToWorld> forParameter_localToWorld;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 912491, RefRangeEnd = 912492, XrefRangeStart = 912484, XrefRangeEnd = 912491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(CritterGroupSystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterGroupSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 912499, RefRangeEnd = 912500, XrefRangeStart = 912492, XrefRangeEnd = 912499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
        ref ArchetypeChunk p0,
        int p1,
        int p2)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref p0;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
      }

      static LambdaParameterValueProviders()
      {
        Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups>.NativeClassPtr, nameof (LambdaParameterValueProviders));
        CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
        CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_critterGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_critterGroup));
        CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_localToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_localToWorld));
        CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterGroupSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders>.NativeClassPtr, 100663428);
        CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders>.NativeClassPtr, 100663429);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct Runtimes
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_runtime_critterGroup;
        private static readonly System.IntPtr NativeFieldInfoPtr_runtime_localToWorld;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<CritterGroup>.Runtime runtime_critterGroup;
        [FieldOffset(16)]
        public LambdaParameterValueProvider_IComponentData<LocalToWorld>.Runtime runtime_localToWorld;

        static Runtimes()
        {
          Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
          CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
          CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_critterGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_critterGroup));
          CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_localToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_localToWorld));
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }

    [ObfuscatedName("CritterGroupSystem/<>c__DisplayClass_ToggleActiveCritterGroups/RunWithoutJobSystem_0000007F$PostfixBurstDelegate")]
    public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static MulticastDelegateNPublicSealedVoObObUnique()
      {
        Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups>.NativeClassPtr, "RunWithoutJobSystem_0000007F$PostfixBurstDelegate");
        CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663430);
        CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663431);
        CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663432);
        CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663433);
      }

      public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [ObfuscatedName("CritterGroupSystem/<>c__DisplayClass_ToggleActiveCritterGroups/RunWithoutJobSystem_0000007F$BurstDirectCall")]
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
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912500, XrefRangeEnd = 912514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref _param0;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912514, XrefRangeEnd = 912532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe System.IntPtr GetFunctionPointer()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912532, XrefRangeEnd = 912547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Constructor()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Initialize()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 912574, RefRangeEnd = 912575, XrefRangeStart = 912547, XrefRangeEnd = 912574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Invoke(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ObjectNInternalAbstractSealedInPoDeInUnique()
      {
        Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups>.NativeClassPtr, "RunWithoutJobSystem_0000007F$BurstDirectCall");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
        CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
        CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
        CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663434);
        CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663435);
        CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663436);
        CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663437);
        CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663439);
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
          IL2CPP.il2cpp_field_static_get_value(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
          return pointer;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
        }
      }

      public static unsafe System.IntPtr DeferredCompilation
      {
        get
        {
          System.IntPtr deferredCompilation;
          IL2CPP.il2cpp_field_static_get_value(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
          return deferredCompilation;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CritterGroupSystem.__c__DisplayClass_ToggleActiveCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
        }
      }
    }
  }

  [ObfuscatedName("CritterGroupSystem/<>c__DisplayClass_UpdateCritterGroups")]
  [StructLayout(LayoutKind.Explicit)]
  public struct __c__DisplayClass_UpdateCritterGroups
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_random;
    private static readonly System.IntPtr NativeFieldInfoPtr_newSpawnTransforms;
    private static readonly System.IntPtr NativeFieldInfoPtr_newSpawnedGrp;
    private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
    private static readonly System.IntPtr NativeFieldInfoPtr_closestPlayerPosPerEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_escapeSoundGrp;
    private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
    private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
    private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
    private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
    private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_CritterDataBuffer_byref_CritterGroup_byref_LocalToWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterGroupSystem_byref___c__DisplayClass9_0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
    [FieldOffset(0)]
    public Unity.Mathematics.Random random;
    [FieldOffset(8)]
    public NativeList<CritterGroupSystem.CritterSpawnTransform> newSpawnTransforms;
    [FieldOffset(24)]
    public NativeList<Entity> newSpawnedGrp;
    [FieldOffset(40)]
    public EntityManager entityManager;
    [FieldOffset(48)]
    public NativeHashMap<Entity, float3> closestPlayerPosPerEntity;
    [FieldOffset(64)]
    public NativeList<Entity> escapeSoundGrp;
    [FieldOffset(80)]
    public CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders _lambdaParameterValueProviders;
    [FieldOffset(192)]
    public unsafe CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders.Runtimes* _runtimes;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912703, XrefRangeEnd = 912750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OriginalLambdaBody(
      Entity entity,
      ref DynamicBuffer<CritterDataBuffer> buffer,
      ref CritterGroup critterGroup,
      [In] ref LocalToWorld localToWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref critterGroup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref localToWorld;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_CritterDataBuffer_byref_CritterGroup_byref_LocalToWorld_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 912750, RefRangeEnd = 912751, XrefRangeStart = 912750, XrefRangeEnd = 912750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ReadFromDisplayClass(
      ref CritterGroupSystem.__c__DisplayClass9_0 displayClass)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref displayClass;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 912751, RefRangeEnd = 912752, XrefRangeStart = 912751, XrefRangeEnd = 912751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void WriteToDisplayClass(
      ref CritterGroupSystem.__c__DisplayClass9_0 displayClass)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref displayClass;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912752, XrefRangeEnd = 912754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &chunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 912766, RefRangeEnd = 912767, XrefRangeStart = 912754, XrefRangeEnd = 912766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void IterateEntities(
      ref ArchetypeChunk chunk,
      ref CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders.Runtimes runtimes)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref chunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 912769, RefRangeEnd = 912770, XrefRangeStart = 912767, XrefRangeEnd = 912769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ScheduleTimeInitialize(
      CritterGroupSystem componentSystem,
      ref CritterGroupSystem.__c__DisplayClass9_0 displayClass)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterGroupSystem_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912770, XrefRangeEnd = 912774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RunWithoutJobSystem(
      ArchetypeChunkIterator* archetypeChunkIterator,
      void* jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912774, XrefRangeEnd = 912780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
      ArchetypeChunkIterator* archetypeChunkIterator,
      void* jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass_UpdateCritterGroups()
    {
      Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateCritterGroups");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr);
      CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr, nameof (random));
      CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeFieldInfoPtr_newSpawnTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr, nameof (newSpawnTransforms));
      CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeFieldInfoPtr_newSpawnedGrp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr, nameof (newSpawnedGrp));
      CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr, nameof (entityManager));
      CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeFieldInfoPtr_closestPlayerPosPerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr, nameof (closestPlayerPosPerEntity));
      CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeFieldInfoPtr_escapeSoundGrp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr, nameof (escapeSoundGrp));
      CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
      CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr, nameof (_runtimes));
      CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
      CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
      CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_CritterDataBuffer_byref_CritterGroup_byref_LocalToWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr, 100663440);
      CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr, 100663441);
      CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr, 100663442);
      CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr, 100663443);
      CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr, 100663444);
      CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterGroupSystem_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr, 100663445);
      CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr, 100663446);
      CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr, 100663447);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LambdaParameterValueProviders
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_critterGroup;
      private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_localToWorld;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterGroupSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public LambdaParameterValueProvider_Entity forParameter_entity;
      [FieldOffset(8)]
      public LambdaParameterValueProvider_DynamicBuffer<CritterDataBuffer> forParameter_buffer;
      [FieldOffset(48)]
      public LambdaParameterValueProvider_IComponentData<CritterGroup> forParameter_critterGroup;
      [FieldOffset(80)]
      public LambdaParameterValueProvider_IComponentData<LocalToWorld> forParameter_localToWorld;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 912616, RefRangeEnd = 912617, XrefRangeStart = 912606, XrefRangeEnd = 912616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(CritterGroupSystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterGroupSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 912627, RefRangeEnd = 912628, XrefRangeStart = 912617, XrefRangeEnd = 912627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
        ref ArchetypeChunk p0,
        int p1,
        int p2)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref p0;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
      }

      static LambdaParameterValueProviders()
      {
        Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr, nameof (LambdaParameterValueProviders));
        CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
        CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buffer));
        CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_critterGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_critterGroup));
        CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_localToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_localToWorld));
        CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterGroupSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders>.NativeClassPtr, 100663448);
        CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders>.NativeClassPtr, 100663449);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct Runtimes
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_runtime_critterGroup;
        private static readonly System.IntPtr NativeFieldInfoPtr_runtime_localToWorld;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<CritterDataBuffer>.Runtime runtime_buffer;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<CritterGroup>.Runtime runtime_critterGroup;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<LocalToWorld>.Runtime runtime_localToWorld;

        static Runtimes()
        {
          Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
          CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
          CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buffer));
          CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_critterGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_critterGroup));
          CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_localToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_localToWorld));
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }

    [ObfuscatedName("CritterGroupSystem/<>c__DisplayClass_UpdateCritterGroups/RunWithoutJobSystem_00000088$PostfixBurstDelegate")]
    public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static MulticastDelegateNPublicSealedVoObObUnique()
      {
        Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr, "RunWithoutJobSystem_00000088$PostfixBurstDelegate");
        CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663450);
        CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663451);
        CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663452);
        CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663453);
      }

      public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [ObfuscatedName("CritterGroupSystem/<>c__DisplayClass_UpdateCritterGroups/RunWithoutJobSystem_00000088$BurstDirectCall")]
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
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912628, XrefRangeEnd = 912642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref _param0;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912642, XrefRangeEnd = 912660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe System.IntPtr GetFunctionPointer()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912660, XrefRangeEnd = 912675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Constructor()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Initialize()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 912702, RefRangeEnd = 912703, XrefRangeStart = 912675, XrefRangeEnd = 912702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Invoke(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ObjectNInternalAbstractSealedInPoDeInUnique()
      {
        Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups>.NativeClassPtr, "RunWithoutJobSystem_00000088$BurstDirectCall");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
        CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
        CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
        CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663454);
        CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663455);
        CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663456);
        CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663457);
        CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663459);
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
          IL2CPP.il2cpp_field_static_get_value(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
          return pointer;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
        }
      }

      public static unsafe System.IntPtr DeferredCompilation
      {
        get
        {
          System.IntPtr deferredCompilation;
          IL2CPP.il2cpp_field_static_get_value(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
          return deferredCompilation;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CritterGroupSystem.__c__DisplayClass_UpdateCritterGroups.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
        }
      }
    }
  }

  [ObfuscatedName("CritterGroupSystem/<>c__DisplayClass_DestroyCritters")]
  [StructLayout(LayoutKind.Explicit)]
  public struct __c__DisplayClass_DestroyCritters
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
    private static readonly System.IntPtr NativeFieldInfoPtr_destroyCritters;
    private static readonly System.IntPtr NativeFieldInfoPtr_destroyGroups;
    private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
    private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
    private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
    private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
    private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CritterGroup_byref_DynamicBuffer_1_CritterDataBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterGroupSystem_byref___c__DisplayClass9_0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
    [FieldOffset(0)]
    public EntityManager entityManager;
    [FieldOffset(8)]
    public NativeList<CritterGroupSystem.CritterDespawnData> destroyCritters;
    [FieldOffset(24)]
    public NativeList<Entity> destroyGroups;
    [FieldOffset(40)]
    public float deltaTime;
    [FieldOffset(48)]
    public CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders _lambdaParameterValueProviders;
    [FieldOffset(128)]
    public unsafe CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders.Runtimes* _runtimes;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912871, XrefRangeEnd = 912896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OriginalLambdaBody(
      Entity entity,
      ref CritterGroup critterGroup,
      [In] ref DynamicBuffer<CritterDataBuffer> buffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref critterGroup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CritterGroup_byref_DynamicBuffer_1_CritterDataBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 912896, RefRangeEnd = 912897, XrefRangeStart = 912896, XrefRangeEnd = 912896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ReadFromDisplayClass(
      ref CritterGroupSystem.__c__DisplayClass9_0 displayClass)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref displayClass;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 912897, RefRangeEnd = 912898, XrefRangeStart = 912897, XrefRangeEnd = 912897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void WriteToDisplayClass(
      ref CritterGroupSystem.__c__DisplayClass9_0 displayClass)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref displayClass;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912898, XrefRangeEnd = 912900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &chunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 912909, RefRangeEnd = 912910, XrefRangeStart = 912900, XrefRangeEnd = 912909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void IterateEntities(
      ref ArchetypeChunk chunk,
      ref CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders.Runtimes runtimes)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref chunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 912912, RefRangeEnd = 912913, XrefRangeStart = 912910, XrefRangeEnd = 912912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ScheduleTimeInitialize(
      CritterGroupSystem componentSystem,
      ref CritterGroupSystem.__c__DisplayClass9_0 displayClass)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterGroupSystem_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912913, XrefRangeEnd = 912917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RunWithoutJobSystem(
      ArchetypeChunkIterator* archetypeChunkIterator,
      void* jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912917, XrefRangeEnd = 912923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
      ArchetypeChunkIterator* archetypeChunkIterator,
      void* jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass_DestroyCritters()
    {
      Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterGroupSystem>.NativeClassPtr, "<>c__DisplayClass_DestroyCritters");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters>.NativeClassPtr);
      CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters>.NativeClassPtr, nameof (entityManager));
      CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeFieldInfoPtr_destroyCritters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters>.NativeClassPtr, nameof (destroyCritters));
      CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeFieldInfoPtr_destroyGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters>.NativeClassPtr, nameof (destroyGroups));
      CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters>.NativeClassPtr, nameof (deltaTime));
      CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
      CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters>.NativeClassPtr, nameof (_runtimes));
      CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
      CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
      CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CritterGroup_byref_DynamicBuffer_1_CritterDataBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters>.NativeClassPtr, 100663460);
      CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters>.NativeClassPtr, 100663461);
      CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters>.NativeClassPtr, 100663462);
      CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters>.NativeClassPtr, 100663463);
      CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters>.NativeClassPtr, 100663464);
      CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterGroupSystem_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters>.NativeClassPtr, 100663465);
      CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters>.NativeClassPtr, 100663466);
      CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters>.NativeClassPtr, 100663467);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CritterGroupSystem.__c__DisplayClass_DestroyCritters.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LambdaParameterValueProviders
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_critterGroup;
      private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buffer;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterGroupSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public LambdaParameterValueProvider_Entity forParameter_entity;
      [FieldOffset(8)]
      public LambdaParameterValueProvider_IComponentData<CritterGroup> forParameter_critterGroup;
      [FieldOffset(40)]
      public LambdaParameterValueProvider_DynamicBuffer<CritterDataBuffer> forParameter_buffer;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 912787, RefRangeEnd = 912788, XrefRangeStart = 912780, XrefRangeEnd = 912787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(CritterGroupSystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterGroupSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 912795, RefRangeEnd = 912796, XrefRangeStart = 912788, XrefRangeEnd = 912795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
        ref ArchetypeChunk p0,
        int p1,
        int p2)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref p0;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
      }

      static LambdaParameterValueProviders()
      {
        Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters>.NativeClassPtr, nameof (LambdaParameterValueProviders));
        CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
        CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_critterGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_critterGroup));
        CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buffer));
        CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CritterGroupSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders>.NativeClassPtr, 100663468);
        CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders>.NativeClassPtr, 100663469);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct Runtimes
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_runtime_critterGroup;
        private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buffer;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<CritterGroup>.Runtime runtime_critterGroup;
        [FieldOffset(16)]
        public LambdaParameterValueProvider_DynamicBuffer<CritterDataBuffer>.Runtime runtime_buffer;

        static Runtimes()
        {
          Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
          CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
          CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_critterGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_critterGroup));
          CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buffer));
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }

    [ObfuscatedName("CritterGroupSystem/<>c__DisplayClass_DestroyCritters/RunWithoutJobSystem_00000091$PostfixBurstDelegate")]
    public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

      [CallerCount(5227)]
      [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_DestroyCritters.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_DestroyCritters.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_DestroyCritters.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_DestroyCritters.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static MulticastDelegateNPublicSealedVoObObUnique()
      {
        Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters>.NativeClassPtr, "RunWithoutJobSystem_00000091$PostfixBurstDelegate");
        CritterGroupSystem.__c__DisplayClass_DestroyCritters.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663470);
        CritterGroupSystem.__c__DisplayClass_DestroyCritters.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663471);
        CritterGroupSystem.__c__DisplayClass_DestroyCritters.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663472);
        CritterGroupSystem.__c__DisplayClass_DestroyCritters.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663473);
      }

      public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [ObfuscatedName("CritterGroupSystem/<>c__DisplayClass_DestroyCritters/RunWithoutJobSystem_00000091$BurstDirectCall")]
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
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912796, XrefRangeEnd = 912810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref _param0;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912810, XrefRangeEnd = 912828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe System.IntPtr GetFunctionPointer()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 912828, XrefRangeEnd = 912843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Constructor()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Initialize()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 912870, RefRangeEnd = 912871, XrefRangeStart = 912843, XrefRangeEnd = 912870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Invoke(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ObjectNInternalAbstractSealedInPoDeInUnique()
      {
        Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters>.NativeClassPtr, "RunWithoutJobSystem_00000091$BurstDirectCall");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
        CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
        CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
        CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663474);
        CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663475);
        CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663476);
        CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663477);
        CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663479);
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
          IL2CPP.il2cpp_field_static_get_value(CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
          return pointer;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
        }
      }

      public static unsafe System.IntPtr DeferredCompilation
      {
        get
        {
          System.IntPtr deferredCompilation;
          IL2CPP.il2cpp_field_static_get_value(CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
          return deferredCompilation;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CritterGroupSystem.__c__DisplayClass_DestroyCritters.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
        }
      }
    }
  }
}
