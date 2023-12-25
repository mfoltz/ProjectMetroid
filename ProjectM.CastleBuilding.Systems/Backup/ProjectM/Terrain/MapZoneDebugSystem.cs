// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.MapZoneDebugSystem
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;

#nullable disable
namespace ProjectM.Terrain
{
  public class MapZoneDebugSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__MapZoneCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___DrawMapZones_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___DrawMapZones_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___DrawMapZones_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___DrawMapZones_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_MapZoneDebugEnabled_2;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_3;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawMapZones_Private_Void_Entity_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddBlock_Private_Static_Void_int2_Single_Color_NativeList_1_float4x4_NativeList_1_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddTile_Private_Static_Void_int2_Single_Color_NativeList_1_float4x4_NativeList_1_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDrawMapZones_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDrawMapZones_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192797, XrefRangeEnd = 1192806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MapZoneDebugSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192806, XrefRangeEnd = 1192850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MapZoneDebugSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1192909, RefRangeEnd = 1192910, XrefRangeStart = 1192850, XrefRangeEnd = 1192909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrawMapZones(Entity localMapZone, float3 localPlayerPosition)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &localMapZone;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localPlayerPosition;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.NativeMethodInfoPtr_DrawMapZones_Private_Void_Entity_float3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1192925, RefRangeEnd = 1192926, XrefRangeStart = 1192910, XrefRangeEnd = 1192925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddBlock(
      int2 block,
      float y,
      Color color,
      NativeList<float4x4> matrices,
      NativeList<Color> colors)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &block;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &matrices;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &colors;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.NativeMethodInfoPtr_AddBlock_Private_Static_Void_int2_Single_Color_NativeList_1_float4x4_NativeList_1_Color_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1192942, RefRangeEnd = 1192943, XrefRangeStart = 1192926, XrefRangeEnd = 1192942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddTile(
      int2 worldTile,
      float y,
      Color color,
      NativeList<float4x4> matrices,
      NativeList<Color> colors)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &worldTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &matrices;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &colors;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.NativeMethodInfoPtr_AddTile_Private_Static_Void_int2_Single_Color_NativeList_1_float4x4_NativeList_1_Color_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MapZoneDebugSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192943, XrefRangeEnd = 1193005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MapZoneDebugSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193005, XrefRangeEnd = 1193021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForDrawMapZones_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.NativeMethodInfoPtr___GetEntityQuery_ForDrawMapZones_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1193046, RefRangeEnd = 1193047, XrefRangeStart = 1193021, XrefRangeEnd = 1193046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForDrawMapZones_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.NativeMethodInfoPtr___GetEntityQuery_ForDrawMapZones_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1193051, RefRangeEnd = 1193052, XrefRangeStart = 1193047, XrefRangeEnd = 1193051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1193056, RefRangeEnd = 1193057, XrefRangeStart = 1193052, XrefRangeEnd = 1193056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MapZoneDebugSystem()
    {
      Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.Terrain", nameof (MapZoneDebugSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr);
      MapZoneDebugSystem.NativeFieldInfoPtr__MapZoneCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr, nameof (_MapZoneCollectionSystem));
      MapZoneDebugSystem.NativeFieldInfoPtr___DrawMapZones_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr, "<>DrawMapZones_LambdaJob0_entityQuery");
      MapZoneDebugSystem.NativeFieldInfoPtr___DrawMapZones_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr, "<>DrawMapZones_LambdaJob0_profilerMarker");
      MapZoneDebugSystem.NativeFieldInfoPtr___DrawMapZones_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr, "<>DrawMapZones_LambdaJob1_entityQuery");
      MapZoneDebugSystem.NativeFieldInfoPtr___DrawMapZones_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr, "<>DrawMapZones_LambdaJob1_profilerMarker");
      MapZoneDebugSystem.NativeFieldInfoPtr__SingletonEntityQuery_MapZoneDebugEnabled_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_MapZoneDebugEnabled_2));
      MapZoneDebugSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_LocalCharacter_3));
      MapZoneDebugSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr, 100663547);
      MapZoneDebugSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr, 100663548);
      MapZoneDebugSystem.NativeMethodInfoPtr_DrawMapZones_Private_Void_Entity_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr, 100663549);
      MapZoneDebugSystem.NativeMethodInfoPtr_AddBlock_Private_Static_Void_int2_Single_Color_NativeList_1_float4x4_NativeList_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr, 100663550);
      MapZoneDebugSystem.NativeMethodInfoPtr_AddTile_Private_Static_Void_int2_Single_Color_NativeList_1_float4x4_NativeList_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr, 100663551);
      MapZoneDebugSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr, 100663552);
      MapZoneDebugSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr, 100663553);
      MapZoneDebugSystem.NativeMethodInfoPtr___GetEntityQuery_ForDrawMapZones_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr, 100663554);
      MapZoneDebugSystem.NativeMethodInfoPtr___GetEntityQuery_ForDrawMapZones_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr, 100663555);
      MapZoneDebugSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr, 100663556);
      MapZoneDebugSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr, 100663557);
    }

    public MapZoneDebugSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe MapZoneCollectionSystem _MapZoneCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.NativeFieldInfoPtr__MapZoneCollectionSystem));
        return pointer == System.IntPtr.Zero ? (MapZoneCollectionSystem) null : new MapZoneCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.NativeFieldInfoPtr__MapZoneCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __DrawMapZones_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.NativeFieldInfoPtr___DrawMapZones_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.NativeFieldInfoPtr___DrawMapZones_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __DrawMapZones_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.NativeFieldInfoPtr___DrawMapZones_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.NativeFieldInfoPtr___DrawMapZones_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __DrawMapZones_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.NativeFieldInfoPtr___DrawMapZones_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.NativeFieldInfoPtr___DrawMapZones_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __DrawMapZones_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.NativeFieldInfoPtr___DrawMapZones_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.NativeFieldInfoPtr___DrawMapZones_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_MapZoneDebugEnabled_2
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.NativeFieldInfoPtr__SingletonEntityQuery_MapZoneDebugEnabled_2));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.NativeFieldInfoPtr__SingletonEntityQuery_MapZoneDebugEnabled_2)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_LocalCharacter_3
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_3));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalCharacter_3)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Terrain.MapZoneDebugSystem/<>c__DisplayClass3_0")]
    public sealed class __c__DisplayClass3_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_renderY;
      private static readonly System.IntPtr NativeFieldInfoPtr_localMapZone;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_cubeMatrices;
      private static readonly System.IntPtr NativeFieldInfoPtr_cubeColors;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DrawMapZones_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_MapZonePolygonVertexElement_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DrawMapZones_b__1_Internal_Void_Entity_byref_MapZoneData_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryBlocks_byref_DynamicBuffer_1_CastleTerritoryTiles_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass3_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass3_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _DrawMapZones_b__0(
        Entity entity,
        [In] ref DynamicBuffer<MapZonePolygonVertexElement> polygonData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref polygonData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__DrawMapZones_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_MapZonePolygonVertexElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _DrawMapZones_b__1(
        Entity entity,
        [In] ref MapZoneData mapZoneData,
        [In] ref CastleTerritory castleTerritory,
        [In] ref DynamicBuffer<CastleTerritoryBlocks> blocks,
        [In] ref DynamicBuffer<CastleTerritoryTiles> tiles)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapZoneData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleTerritory;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref blocks;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref tiles;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__DrawMapZones_b__1_Internal_Void_Entity_byref_MapZoneData_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryBlocks_byref_DynamicBuffer_1_CastleTerritoryTiles_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass3_0()
      {
        Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr, "<>c__DisplayClass3_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass3_0>.NativeClassPtr);
        MapZoneDebugSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_renderY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (renderY));
        MapZoneDebugSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_localMapZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (localMapZone));
        MapZoneDebugSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
        MapZoneDebugSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_localPlayerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (localPlayerPosition));
        MapZoneDebugSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_cubeMatrices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (cubeMatrices));
        MapZoneDebugSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_cubeColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (cubeColors));
        MapZoneDebugSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass3_0>.NativeClassPtr, 100663558);
        MapZoneDebugSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__DrawMapZones_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_MapZonePolygonVertexElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass3_0>.NativeClassPtr, 100663559);
        MapZoneDebugSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__DrawMapZones_b__1_Internal_Void_Entity_byref_MapZoneData_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryBlocks_byref_DynamicBuffer_1_CastleTerritoryTiles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass3_0>.NativeClassPtr, 100663560);
      }

      public __c__DisplayClass3_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass3_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass3_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass3_0>.NativeClassPtr, data));
      }

      public unsafe float renderY
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_renderY));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_renderY)) = value;
        }
      }

      public unsafe Entity localMapZone
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_localMapZone));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_localMapZone)) = value;
        }
      }

      public unsafe MapZoneDebugSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (MapZoneDebugSystem) null : new MapZoneDebugSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float3 localPlayerPosition
      {
        get
        {
          return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_localPlayerPosition));
        }
        [param: In] set
        {
          *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_localPlayerPosition)) = value;
        }
      }

      public unsafe NativeList<float4x4> cubeMatrices
      {
        get
        {
          return *(NativeList<float4x4>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_cubeMatrices));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_cubeMatrices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<float4x4>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<Color> cubeColors
      {
        get
        {
          return *(NativeList<Color>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_cubeColors));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapZoneDebugSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_cubeColors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Color>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.Terrain.MapZoneDebugSystem/ProjectM.Terrain.<>c__DisplayClass_DrawMapZones_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_DrawMapZones_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_renderY;
      private static readonly System.IntPtr NativeFieldInfoPtr_localMapZone;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_CastleTerritory_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_MapZonePolygonVertexElement_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapZoneDebugSystem_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public float renderY;
      [FieldOffset(4)]
      public Entity localMapZone;
      [FieldOffset(16)]
      public ComponentDataFromEntity<CastleTerritory> _ComponentDataFromEntity_CastleTerritory_0;
      [FieldOffset(48)]
      public MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(96)]
      public unsafe MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192560, XrefRangeEnd = 1192585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref DynamicBuffer<MapZonePolygonVertexElement> polygonData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref polygonData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_MapZonePolygonVertexElement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 1192585, RefRangeEnd = 1192592, XrefRangeStart = 1192585, XrefRangeEnd = 1192585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref MapZoneDebugSystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 1192592, RefRangeEnd = 1192603, XrefRangeStart = 1192592, XrefRangeEnd = 1192592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref MapZoneDebugSystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192603, XrefRangeEnd = 1192605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1192611, RefRangeEnd = 1192612, XrefRangeStart = 1192605, XrefRangeEnd = 1192611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1192617, RefRangeEnd = 1192618, XrefRangeStart = 1192612, XrefRangeEnd = 1192617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        MapZoneDebugSystem componentSystem,
        ref MapZoneDebugSystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapZoneDebugSystem_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192618, XrefRangeEnd = 1192622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192622, XrefRangeEnd = 1192628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DrawMapZones_LambdaJob0()
      {
        Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr, "<>c__DisplayClass_DrawMapZones_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0>.NativeClassPtr);
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeFieldInfoPtr_renderY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0>.NativeClassPtr, nameof (renderY));
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeFieldInfoPtr_localMapZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0>.NativeClassPtr, nameof (localMapZone));
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_CastleTerritory_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_CastleTerritory_0));
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_MapZonePolygonVertexElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0>.NativeClassPtr, 100663561);
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0>.NativeClassPtr, 100663562);
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0>.NativeClassPtr, 100663563);
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0>.NativeClassPtr, 100663564);
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0>.NativeClassPtr, 100663565);
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapZoneDebugSystem_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0>.NativeClassPtr, 100663566);
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0>.NativeClassPtr, 100663567);
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0>.NativeClassPtr, 100663568);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_polygonData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapZoneDebugSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<MapZonePolygonVertexElement> forParameter_polygonData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1192479, RefRangeEnd = 1192480, XrefRangeStart = 1192475, XrefRangeEnd = 1192479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(MapZoneDebugSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapZoneDebugSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1192484, RefRangeEnd = 1192485, XrefRangeStart = 1192480, XrefRangeEnd = 1192484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_polygonData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_polygonData));
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapZoneDebugSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663569);
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663570);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_polygonData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<MapZonePolygonVertexElement>.Runtime runtime_polygonData;

          static Runtimes()
          {
            Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_polygonData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_polygonData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Terrain.MapZoneDebugSystem/ProjectM.Terrain.<>c__DisplayClass_DrawMapZones_LambdaJob0/ProjectM.Terrain.RunWithoutJobSystem_000000D1$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000000D1$PostfixBurstDelegate");
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663571);
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663572);
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663573);
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663574);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Terrain.MapZoneDebugSystem/ProjectM.Terrain.<>c__DisplayClass_DrawMapZones_LambdaJob0/ProjectM.Terrain.RunWithoutJobSystem_000000D1$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192485, XrefRangeEnd = 1192499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192499, XrefRangeEnd = 1192517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192517, XrefRangeEnd = 1192532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1192559, RefRangeEnd = 1192560, XrefRangeStart = 1192532, XrefRangeEnd = 1192559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000000D1$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663575);
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663576);
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663577);
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663578);
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663580);
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
            IL2CPP.il2cpp_field_static_get_value(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Terrain.MapZoneDebugSystem/ProjectM.Terrain.<>c__DisplayClass_DrawMapZones_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_DrawMapZones_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_renderY;
      private static readonly System.IntPtr NativeFieldInfoPtr_cubeMatrices;
      private static readonly System.IntPtr NativeFieldInfoPtr_cubeColors;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MapZoneData_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryBlocks_byref_DynamicBuffer_1_CastleTerritoryTiles_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapZoneDebugSystem_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public float3 localPlayerPosition;
      [FieldOffset(12)]
      public float renderY;
      [FieldOffset(16)]
      public NativeList<float4x4> cubeMatrices;
      [FieldOffset(32)]
      public NativeList<Color> cubeColors;
      [FieldOffset(48)]
      public MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(200)]
      public unsafe MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192731, XrefRangeEnd = 1192764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref MapZoneData mapZoneData,
        [In] ref CastleTerritory castleTerritory,
        [In] ref DynamicBuffer<CastleTerritoryBlocks> blocks,
        [In] ref DynamicBuffer<CastleTerritoryTiles> tiles)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapZoneData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleTerritory;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref blocks;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref tiles;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MapZoneData_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryBlocks_byref_DynamicBuffer_1_CastleTerritoryTiles_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1192764, RefRangeEnd = 1192765, XrefRangeStart = 1192764, XrefRangeEnd = 1192764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref MapZoneDebugSystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1192765, RefRangeEnd = 1192766, XrefRangeStart = 1192765, XrefRangeEnd = 1192765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref MapZoneDebugSystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192766, XrefRangeEnd = 1192768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1192783, RefRangeEnd = 1192784, XrefRangeStart = 1192768, XrefRangeEnd = 1192783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1192786, RefRangeEnd = 1192787, XrefRangeStart = 1192784, XrefRangeEnd = 1192786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        MapZoneDebugSystem componentSystem,
        ref MapZoneDebugSystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapZoneDebugSystem_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192787, XrefRangeEnd = 1192791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192791, XrefRangeEnd = 1192797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DrawMapZones_LambdaJob1()
      {
        Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapZoneDebugSystem>.NativeClassPtr, "<>c__DisplayClass_DrawMapZones_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1>.NativeClassPtr);
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeFieldInfoPtr_localPlayerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1>.NativeClassPtr, nameof (localPlayerPosition));
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeFieldInfoPtr_renderY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1>.NativeClassPtr, nameof (renderY));
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeFieldInfoPtr_cubeMatrices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1>.NativeClassPtr, nameof (cubeMatrices));
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeFieldInfoPtr_cubeColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1>.NativeClassPtr, nameof (cubeColors));
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MapZoneData_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryBlocks_byref_DynamicBuffer_1_CastleTerritoryTiles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1>.NativeClassPtr, 100663581);
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1>.NativeClassPtr, 100663582);
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1>.NativeClassPtr, 100663583);
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1>.NativeClassPtr, 100663584);
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1>.NativeClassPtr, 100663585);
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapZoneDebugSystem_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1>.NativeClassPtr, 100663586);
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1>.NativeClassPtr, 100663587);
        MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1>.NativeClassPtr, 100663588);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_mapZoneData;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castleTerritory;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_blocks;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_tiles;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapZoneDebugSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<MapZoneData> forParameter_mapZoneData;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<CastleTerritory> forParameter_castleTerritory;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_DynamicBuffer<CastleTerritoryBlocks> forParameter_blocks;
        [FieldOffset(112)]
        public LambdaParameterValueProvider_DynamicBuffer<CastleTerritoryTiles> forParameter_tiles;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1192641, RefRangeEnd = 1192642, XrefRangeStart = 1192628, XrefRangeEnd = 1192641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(MapZoneDebugSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapZoneDebugSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1192655, RefRangeEnd = 1192656, XrefRangeStart = 1192642, XrefRangeEnd = 1192655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_mapZoneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_mapZoneData));
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castleTerritory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castleTerritory));
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_blocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_blocks));
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_tiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_tiles));
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MapZoneDebugSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100663589);
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100663590);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_mapZoneData;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castleTerritory;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_blocks;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_tiles;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<MapZoneData>.Runtime runtime_mapZoneData;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<CastleTerritory>.Runtime runtime_castleTerritory;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_DynamicBuffer<CastleTerritoryBlocks>.Runtime runtime_blocks;
          [FieldOffset(48)]
          public LambdaParameterValueProvider_DynamicBuffer<CastleTerritoryTiles>.Runtime runtime_tiles;

          static Runtimes()
          {
            Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_mapZoneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_mapZoneData));
            MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castleTerritory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castleTerritory));
            MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_blocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_blocks));
            MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_tiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_tiles));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Terrain.MapZoneDebugSystem/ProjectM.Terrain.<>c__DisplayClass_DrawMapZones_LambdaJob1/ProjectM.Terrain.RunWithoutJobSystem_000000DA$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_000000DA$PostfixBurstDelegate");
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663591);
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663592);
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663593);
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663594);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Terrain.MapZoneDebugSystem/ProjectM.Terrain.<>c__DisplayClass_DrawMapZones_LambdaJob1/ProjectM.Terrain.RunWithoutJobSystem_000000DA$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192656, XrefRangeEnd = 1192670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192670, XrefRangeEnd = 1192688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192688, XrefRangeEnd = 1192703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1192730, RefRangeEnd = 1192731, XrefRangeStart = 1192703, XrefRangeEnd = 1192730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_000000DA$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663595);
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663596);
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663597);
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663598);
          MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663600);
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
            IL2CPP.il2cpp_field_static_get_value(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MapZoneDebugSystem.__c__DisplayClass_DrawMapZones_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
