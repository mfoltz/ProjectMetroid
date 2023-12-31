// Decompiled with JetBrains decompiler
// Type: ProjectM.Pathfinding.WorldRoadGraphSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Pathfinding
{
  public class WorldRoadGraphSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldRoadGraph;
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldSetupQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RebuildWorldRoadGraph_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_WorldAssetSingleton_11;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetWorldRoadGraph_Public_Boolean_byref_WorldRoadGraph_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBusStopPosition_Public_Boolean_BusStopId_byref_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 769858, RefRangeEnd = 769861, XrefRangeStart = 769858, XrefRangeEnd = 769858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetWorldRoadGraph(out WorldRoadGraph worldRoadGraph)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref worldRoadGraph;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphSystem.NativeMethodInfoPtr_TryGetWorldRoadGraph_Public_Boolean_byref_WorldRoadGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769861, XrefRangeEnd = 769870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetBusStopPosition(BusStopId busStopId, out float3 worldPos)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &busStopId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref worldPos;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphSystem.NativeMethodInfoPtr_TryGetBusStopPosition_Public_Boolean_BusStopId_byref_float3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769870, XrefRangeEnd = 769881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WorldRoadGraphSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769881, XrefRangeEnd = 769893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WorldRoadGraphSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769893, XrefRangeEnd = 769929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WorldRoadGraphSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WorldRoadGraphSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldRoadGraphSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769929, XrefRangeEnd = 769953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WorldRoadGraphSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 769957, RefRangeEnd = 769958, XrefRangeStart = 769953, XrefRangeEnd = 769957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WorldRoadGraphSystem()
    {
      Il2CppClassPointerStore<WorldRoadGraphSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Pathfinding", nameof (WorldRoadGraphSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldRoadGraphSystem>.NativeClassPtr);
      WorldRoadGraphSystem.NativeFieldInfoPtr__WorldRoadGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphSystem>.NativeClassPtr, nameof (_WorldRoadGraph));
      WorldRoadGraphSystem.NativeFieldInfoPtr__WorldSetupQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphSystem>.NativeClassPtr, nameof (_WorldSetupQuery));
      WorldRoadGraphSystem.NativeFieldInfoPtr___RebuildWorldRoadGraph_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphSystem>.NativeClassPtr, "<>RebuildWorldRoadGraph_profilerMarker");
      WorldRoadGraphSystem.NativeFieldInfoPtr__SingletonEntityQuery_WorldAssetSingleton_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_WorldAssetSingleton_11));
      WorldRoadGraphSystem.NativeMethodInfoPtr_TryGetWorldRoadGraph_Public_Boolean_byref_WorldRoadGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem>.NativeClassPtr, 100668133);
      WorldRoadGraphSystem.NativeMethodInfoPtr_TryGetBusStopPosition_Public_Boolean_BusStopId_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem>.NativeClassPtr, 100668134);
      WorldRoadGraphSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem>.NativeClassPtr, 100668135);
      WorldRoadGraphSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem>.NativeClassPtr, 100668136);
      WorldRoadGraphSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem>.NativeClassPtr, 100668137);
      WorldRoadGraphSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem>.NativeClassPtr, 100668138);
      WorldRoadGraphSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem>.NativeClassPtr, 100668139);
      WorldRoadGraphSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem>.NativeClassPtr, 100668140);
    }

    public WorldRoadGraphSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WorldRoadGraph _WorldRoadGraph
    {
      get
      {
        return *(WorldRoadGraph*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldRoadGraphSystem.NativeFieldInfoPtr__WorldRoadGraph));
      }
      [param: In] set
      {
        *(WorldRoadGraph*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldRoadGraphSystem.NativeFieldInfoPtr__WorldRoadGraph)) = value;
      }
    }

    public unsafe EntityQuery _WorldSetupQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldRoadGraphSystem.NativeFieldInfoPtr__WorldSetupQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldRoadGraphSystem.NativeFieldInfoPtr__WorldSetupQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RebuildWorldRoadGraph_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldRoadGraphSystem.NativeFieldInfoPtr___RebuildWorldRoadGraph_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldRoadGraphSystem.NativeFieldInfoPtr___RebuildWorldRoadGraph_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_WorldAssetSingleton_11
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldRoadGraphSystem.NativeFieldInfoPtr__SingletonEntityQuery_WorldAssetSingleton_11));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldRoadGraphSystem.NativeFieldInfoPtr__SingletonEntityQuery_WorldAssetSingleton_11)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RoadGraphInitialized
    {
      static RoadGraphInitialized()
      {
        Il2CppClassPointerStore<WorldRoadGraphSystem.RoadGraphInitialized>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldRoadGraphSystem>.NativeClassPtr, nameof (RoadGraphInitialized));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldRoadGraphSystem.RoadGraphInitialized>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorldRoadGraphSystem.RoadGraphInitialized>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Pathfinding.WorldRoadGraphSystem/<>c__DisplayClass7_0")]
    public sealed class __c__DisplayClass7_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_chunks;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_newGraph;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass7_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_0()
      {
        Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldRoadGraphSystem>.NativeClassPtr, "<>c__DisplayClass7_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass7_0>.NativeClassPtr);
        WorldRoadGraphSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_chunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (chunks));
        WorldRoadGraphSystem.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
        WorldRoadGraphSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_newGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (newGraph));
        WorldRoadGraphSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass7_0>.NativeClassPtr, 100668141);
        WorldRoadGraphSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass7_0>.NativeClassPtr, 100668142);
      }

      public __c__DisplayClass7_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass7_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass7_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass7_0>.NativeClassPtr, data));
      }

      public unsafe DynamicBuffer<WorldAssetChunks> chunks
      {
        get
        {
          return *(DynamicBuffer<WorldAssetChunks>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldRoadGraphSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_chunks));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldRoadGraphSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_chunks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DynamicBuffer<WorldAssetChunks>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe WorldRoadGraphSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldRoadGraphSystem.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (WorldRoadGraphSystem) null : new WorldRoadGraphSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldRoadGraphSystem.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe WorldRoadGraph newGraph
      {
        get
        {
          return *(WorldRoadGraph*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldRoadGraphSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_newGraph));
        }
        [param: In] set
        {
          *(WorldRoadGraph*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldRoadGraphSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_newGraph)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Pathfinding.WorldRoadGraphSystem/ProjectM.Pathfinding.<>c__DisplayClass_RebuildWorldRoadGraph")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RebuildWorldRoadGraph
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_chunks;
      private static readonly System.IntPtr NativeFieldInfoPtr_newGraph;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_TerrainChunkMetadata_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ChunkRoadGraph_1;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_WorldRoadGraphSystem_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public DynamicBuffer<WorldAssetChunks> chunks;
      [FieldOffset(16)]
      public WorldRoadGraph newGraph;
      [FieldOffset(80)]
      public ComponentDataFromEntity<TerrainChunkMetadata> _ComponentDataFromEntity_TerrainChunkMetadata_0;
      [FieldOffset(112)]
      public ComponentDataFromEntity<ChunkRoadGraph> _ComponentDataFromEntity_ChunkRoadGraph_1;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769782, XrefRangeEnd = 769813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 769813, RefRangeEnd = 769814, XrefRangeStart = 769813, XrefRangeEnd = 769813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref WorldRoadGraphSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 769814, RefRangeEnd = 769815, XrefRangeStart = 769814, XrefRangeEnd = 769814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref WorldRoadGraphSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 769816, RefRangeEnd = 769817, XrefRangeStart = 769815, XrefRangeEnd = 769816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 769824, RefRangeEnd = 769825, XrefRangeStart = 769817, XrefRangeEnd = 769824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        WorldRoadGraphSystem componentSystem,
        ref WorldRoadGraphSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_WorldRoadGraphSystem_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769825, XrefRangeEnd = 769855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 769856, RefRangeEnd = 769858, XrefRangeStart = 769855, XrefRangeEnd = 769856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RebuildWorldRoadGraph()
      {
        Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldRoadGraphSystem>.NativeClassPtr, "<>c__DisplayClass_RebuildWorldRoadGraph");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph>.NativeClassPtr);
        WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeFieldInfoPtr_chunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph>.NativeClassPtr, nameof (chunks));
        WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeFieldInfoPtr_newGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph>.NativeClassPtr, nameof (newGraph));
        WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeFieldInfoPtr__ComponentDataFromEntity_TerrainChunkMetadata_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph>.NativeClassPtr, nameof (_ComponentDataFromEntity_TerrainChunkMetadata_0));
        WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeFieldInfoPtr__ComponentDataFromEntity_ChunkRoadGraph_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph>.NativeClassPtr, nameof (_ComponentDataFromEntity_ChunkRoadGraph_1));
        WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph>.NativeClassPtr, 100668143);
        WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph>.NativeClassPtr, 100668144);
        WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph>.NativeClassPtr, 100668145);
        WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph>.NativeClassPtr, 100668146);
        WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_WorldRoadGraphSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph>.NativeClassPtr, 100668147);
        WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph>.NativeClassPtr, 100668148);
        WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph>.NativeClassPtr, 100668149);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.Pathfinding.WorldRoadGraphSystem/ProjectM.Pathfinding.<>c__DisplayClass_RebuildWorldRoadGraph/ProjectM.Pathfinding.RunWithoutJobSystem_000010EF$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph>.NativeClassPtr, "RunWithoutJobSystem_000010EF$PostfixBurstDelegate");
          WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100668150);
          WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100668151);
          WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100668152);
          WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100668153);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Pathfinding.WorldRoadGraphSystem/ProjectM.Pathfinding.<>c__DisplayClass_RebuildWorldRoadGraph/ProjectM.Pathfinding.RunWithoutJobSystem_000010EF$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769708, XrefRangeEnd = 769722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769722, XrefRangeEnd = 769740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769740, XrefRangeEnd = 769755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769755, XrefRangeEnd = 769782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph>.NativeClassPtr, "RunWithoutJobSystem_000010EF$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668154);
          WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668155);
          WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668156);
          WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668157);
          WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668159);
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
            IL2CPP.il2cpp_field_static_get_value(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(WorldRoadGraphSystem.__c__DisplayClass_RebuildWorldRoadGraph.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
