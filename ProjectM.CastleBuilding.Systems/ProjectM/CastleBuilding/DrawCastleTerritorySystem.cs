// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.DrawCastleTerritorySystem
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class DrawCastleTerritorySystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TerritoryMeshCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr__Mpb;
    private static readonly System.IntPtr NativeFieldInfoPtr__InBuildMode;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__MouseWorldPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr__BorderCursorMaxDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___DrawMapZone_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___DrawMapZone_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_BuildMenuState_5;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddBlock_Private_Static_Void_int2_Single_NativeList_1_Matrix4x4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DrawMapZone_Private_Void_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDrawMapZone_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201254, XrefRangeEnd = 1201278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DrawCastleTerritorySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201278, XrefRangeEnd = 1201288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DrawCastleTerritorySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201288, XrefRangeEnd = 1201301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddBlock(int2 block, float y, NativeList<Matrix4x4> matrices)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &block;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &matrices;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.NativeMethodInfoPtr_AddBlock_Private_Static_Void_int2_Single_NativeList_1_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1201361, RefRangeEnd = 1201362, XrefRangeStart = 1201301, XrefRangeEnd = 1201361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DrawMapZone(float3 localPlayerPosition)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &localPlayerPosition;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.NativeMethodInfoPtr_DrawMapZone_Private_Void_float3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201362, XrefRangeEnd = 1201363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DrawCastleTerritorySystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawCastleTerritorySystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201363, XrefRangeEnd = 1201388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DrawCastleTerritorySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1201413, RefRangeEnd = 1201414, XrefRangeStart = 1201388, XrefRangeEnd = 1201413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForDrawMapZone_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.NativeMethodInfoPtr___GetEntityQuery_ForDrawMapZone_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1201418, RefRangeEnd = 1201419, XrefRangeStart = 1201414, XrefRangeEnd = 1201418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DrawCastleTerritorySystem()
    {
      Il2CppClassPointerStore<DrawCastleTerritorySystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.CastleBuilding", nameof (DrawCastleTerritorySystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawCastleTerritorySystem>.NativeClassPtr);
      DrawCastleTerritorySystem.NativeFieldInfoPtr__TerritoryMeshCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem>.NativeClassPtr, nameof (_TerritoryMeshCollection));
      DrawCastleTerritorySystem.NativeFieldInfoPtr__Mpb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem>.NativeClassPtr, nameof (_Mpb));
      DrawCastleTerritorySystem.NativeFieldInfoPtr__InBuildMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem>.NativeClassPtr, nameof (_InBuildMode));
      DrawCastleTerritorySystem.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem>.NativeClassPtr, nameof (_InputSystem));
      DrawCastleTerritorySystem.NativeFieldInfoPtr__MouseWorldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem>.NativeClassPtr, nameof (_MouseWorldPosition));
      DrawCastleTerritorySystem.NativeFieldInfoPtr__BorderCursorMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem>.NativeClassPtr, nameof (_BorderCursorMaxDistance));
      DrawCastleTerritorySystem.NativeFieldInfoPtr__ClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem>.NativeClassPtr, nameof (_ClientDataSystem));
      DrawCastleTerritorySystem.NativeFieldInfoPtr___DrawMapZone_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem>.NativeClassPtr, "<>DrawMapZone_LambdaJob0_entityQuery");
      DrawCastleTerritorySystem.NativeFieldInfoPtr___DrawMapZone_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem>.NativeClassPtr, "<>DrawMapZone_LambdaJob0_profilerMarker");
      DrawCastleTerritorySystem.NativeFieldInfoPtr__SingletonEntityQuery_BuildMenuState_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem>.NativeClassPtr, nameof (_SingletonEntityQuery_BuildMenuState_5));
      DrawCastleTerritorySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem>.NativeClassPtr, 100664350);
      DrawCastleTerritorySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem>.NativeClassPtr, 100664351);
      DrawCastleTerritorySystem.NativeMethodInfoPtr_AddBlock_Private_Static_Void_int2_Single_NativeList_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem>.NativeClassPtr, 100664352);
      DrawCastleTerritorySystem.NativeMethodInfoPtr_DrawMapZone_Private_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem>.NativeClassPtr, 100664353);
      DrawCastleTerritorySystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem>.NativeClassPtr, 100664354);
      DrawCastleTerritorySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem>.NativeClassPtr, 100664355);
      DrawCastleTerritorySystem.NativeMethodInfoPtr___GetEntityQuery_ForDrawMapZone_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem>.NativeClassPtr, 100664356);
      DrawCastleTerritorySystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem>.NativeClassPtr, 100664357);
    }

    public DrawCastleTerritorySystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TerritoryMeshCollection _TerritoryMeshCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawCastleTerritorySystem.NativeFieldInfoPtr__TerritoryMeshCollection));
        return pointer == System.IntPtr.Zero ? (TerritoryMeshCollection) null : new TerritoryMeshCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DrawCastleTerritorySystem.NativeFieldInfoPtr__TerritoryMeshCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MaterialPropertyBlock _Mpb
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawCastleTerritorySystem.NativeFieldInfoPtr__Mpb));
        return pointer == System.IntPtr.Zero ? (MaterialPropertyBlock) null : new MaterialPropertyBlock(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DrawCastleTerritorySystem.NativeFieldInfoPtr__Mpb), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _InBuildMode
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawCastleTerritorySystem.NativeFieldInfoPtr__InBuildMode));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawCastleTerritorySystem.NativeFieldInfoPtr__InBuildMode)) = value;
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawCastleTerritorySystem.NativeFieldInfoPtr__InputSystem));
        return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DrawCastleTerritorySystem.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float3 _MouseWorldPosition
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawCastleTerritorySystem.NativeFieldInfoPtr__MouseWorldPosition));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawCastleTerritorySystem.NativeFieldInfoPtr__MouseWorldPosition)) = value;
      }
    }

    public unsafe float _BorderCursorMaxDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawCastleTerritorySystem.NativeFieldInfoPtr__BorderCursorMaxDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawCastleTerritorySystem.NativeFieldInfoPtr__BorderCursorMaxDistance)) = value;
      }
    }

    public unsafe CommonClientDataSystem _ClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawCastleTerritorySystem.NativeFieldInfoPtr__ClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DrawCastleTerritorySystem.NativeFieldInfoPtr__ClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __DrawMapZone_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawCastleTerritorySystem.NativeFieldInfoPtr___DrawMapZone_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawCastleTerritorySystem.NativeFieldInfoPtr___DrawMapZone_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __DrawMapZone_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawCastleTerritorySystem.NativeFieldInfoPtr___DrawMapZone_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawCastleTerritorySystem.NativeFieldInfoPtr___DrawMapZone_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_BuildMenuState_5
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawCastleTerritorySystem.NativeFieldInfoPtr__SingletonEntityQuery_BuildMenuState_5));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DrawCastleTerritorySystem.NativeFieldInfoPtr__SingletonEntityQuery_BuildMenuState_5)) = value;
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.DrawCastleTerritorySystem/<>c__DisplayClass10_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass10_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUserTeam;
      private static readonly System.IntPtr NativeFieldInfoPtr_filledBlocks;
      private static readonly System.IntPtr NativeFieldInfoPtr_renderY;
      private static readonly System.IntPtr NativeFieldInfoPtr_mousePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_maxDistanceCursorSq;
      private static readonly System.IntPtr NativeFieldInfoPtr_matrices;
      private static readonly System.IntPtr NativeFieldInfoPtr_cornerSetups;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DrawMapZone_b__0_Internal_Void_Entity_byref_MapZoneData_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryBlocks_byref_DynamicBuffer_1_CastleTerritoryTiles_0;
      [FieldOffset(0)]
      public float3 localPlayerPosition;
      [FieldOffset(16)]
      public EntityManager entityManager;
      [FieldOffset(24)]
      public Team localUserTeam;
      [FieldOffset(32)]
      public NativeHashSet<int2> filledBlocks;
      [FieldOffset(48)]
      public float renderY;
      [FieldOffset(52)]
      public float3 mousePosition;
      [FieldOffset(64)]
      public float maxDistanceCursorSq;
      [FieldOffset(72)]
      public NativeList<Matrix4x4> matrices;
      [FieldOffset(88)]
      public NativeList<int> cornerSetups;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass10_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _DrawMapZone_b__0(
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
        IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.__c__DisplayClass10_0.NativeMethodInfoPtr__DrawMapZone_b__0_Internal_Void_Entity_byref_MapZoneData_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryBlocks_byref_DynamicBuffer_1_CastleTerritoryTiles_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass10_0()
      {
        Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawCastleTerritorySystem>.NativeClassPtr, "<>c__DisplayClass10_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass10_0>.NativeClassPtr);
        DrawCastleTerritorySystem.__c__DisplayClass10_0.NativeFieldInfoPtr_localPlayerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (localPlayerPosition));
        DrawCastleTerritorySystem.__c__DisplayClass10_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (entityManager));
        DrawCastleTerritorySystem.__c__DisplayClass10_0.NativeFieldInfoPtr_localUserTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (localUserTeam));
        DrawCastleTerritorySystem.__c__DisplayClass10_0.NativeFieldInfoPtr_filledBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (filledBlocks));
        DrawCastleTerritorySystem.__c__DisplayClass10_0.NativeFieldInfoPtr_renderY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (renderY));
        DrawCastleTerritorySystem.__c__DisplayClass10_0.NativeFieldInfoPtr_mousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (mousePosition));
        DrawCastleTerritorySystem.__c__DisplayClass10_0.NativeFieldInfoPtr_maxDistanceCursorSq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (maxDistanceCursorSq));
        DrawCastleTerritorySystem.__c__DisplayClass10_0.NativeFieldInfoPtr_matrices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (matrices));
        DrawCastleTerritorySystem.__c__DisplayClass10_0.NativeFieldInfoPtr_cornerSetups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (cornerSetups));
        DrawCastleTerritorySystem.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass10_0>.NativeClassPtr, 100664358);
        DrawCastleTerritorySystem.__c__DisplayClass10_0.NativeMethodInfoPtr__DrawMapZone_b__0_Internal_Void_Entity_byref_MapZoneData_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryBlocks_byref_DynamicBuffer_1_CastleTerritoryTiles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass10_0>.NativeClassPtr, 100664359);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass10_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.DrawCastleTerritorySystem/ProjectM.CastleBuilding.<>c__DisplayClass_DrawMapZone_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_DrawMapZone_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUserTeam;
      private static readonly System.IntPtr NativeFieldInfoPtr_filledBlocks;
      private static readonly System.IntPtr NativeFieldInfoPtr_renderY;
      private static readonly System.IntPtr NativeFieldInfoPtr_mousePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_maxDistanceCursorSq;
      private static readonly System.IntPtr NativeFieldInfoPtr_matrices;
      private static readonly System.IntPtr NativeFieldInfoPtr_cornerSetups;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MapZoneData_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryBlocks_byref_DynamicBuffer_1_CastleTerritoryTiles_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DrawCastleTerritorySystem_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public float3 localPlayerPosition;
      [FieldOffset(16)]
      public EntityManager entityManager;
      [FieldOffset(24)]
      public Team localUserTeam;
      [FieldOffset(32)]
      public NativeHashSet<int2> filledBlocks;
      [FieldOffset(48)]
      public float renderY;
      [FieldOffset(52)]
      public float3 mousePosition;
      [FieldOffset(64)]
      public float maxDistanceCursorSq;
      [FieldOffset(72)]
      public NativeList<Matrix4x4> matrices;
      [FieldOffset(88)]
      public NativeList<int> cornerSetups;
      [FieldOffset(104)]
      public DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(256)]
      public unsafe DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201169, XrefRangeEnd = 1201221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MapZoneData_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryBlocks_byref_DynamicBuffer_1_CastleTerritoryTiles_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1201221, RefRangeEnd = 1201222, XrefRangeStart = 1201221, XrefRangeEnd = 1201221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DrawCastleTerritorySystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1201222, RefRangeEnd = 1201223, XrefRangeStart = 1201222, XrefRangeEnd = 1201222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DrawCastleTerritorySystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201223, XrefRangeEnd = 1201225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1201240, RefRangeEnd = 1201241, XrefRangeStart = 1201225, XrefRangeEnd = 1201240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1201243, RefRangeEnd = 1201244, XrefRangeStart = 1201241, XrefRangeEnd = 1201243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DrawCastleTerritorySystem componentSystem,
        ref DrawCastleTerritorySystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DrawCastleTerritorySystem_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201244, XrefRangeEnd = 1201248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201248, XrefRangeEnd = 1201254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DrawMapZone_LambdaJob0()
      {
        Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawCastleTerritorySystem>.NativeClassPtr, "<>c__DisplayClass_DrawMapZone_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr);
        DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeFieldInfoPtr_localPlayerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, nameof (localPlayerPosition));
        DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, nameof (entityManager));
        DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeFieldInfoPtr_localUserTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, nameof (localUserTeam));
        DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeFieldInfoPtr_filledBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, nameof (filledBlocks));
        DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeFieldInfoPtr_renderY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, nameof (renderY));
        DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeFieldInfoPtr_mousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, nameof (mousePosition));
        DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeFieldInfoPtr_maxDistanceCursorSq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, nameof (maxDistanceCursorSq));
        DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeFieldInfoPtr_matrices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, nameof (matrices));
        DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeFieldInfoPtr_cornerSetups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, nameof (cornerSetups));
        DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MapZoneData_byref_CastleTerritory_byref_DynamicBuffer_1_CastleTerritoryBlocks_byref_DynamicBuffer_1_CastleTerritoryTiles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, 100664360);
        DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, 100664361);
        DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, 100664362);
        DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, 100664363);
        DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, 100664364);
        DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DrawCastleTerritorySystem_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, 100664365);
        DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, 100664366);
        DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, 100664367);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
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
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DrawCastleTerritorySystem_0;
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
        [CachedScanResults(RefRangeStart = 1201079, RefRangeEnd = 1201080, XrefRangeStart = 1201066, XrefRangeEnd = 1201079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DrawCastleTerritorySystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DrawCastleTerritorySystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1201093, RefRangeEnd = 1201094, XrefRangeStart = 1201080, XrefRangeEnd = 1201093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_mapZoneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_mapZoneData));
          DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castleTerritory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castleTerritory));
          DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_blocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_blocks));
          DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_tiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_tiles));
          DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DrawCastleTerritorySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664368);
          DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664369);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
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
            Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_mapZoneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_mapZoneData));
            DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castleTerritory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castleTerritory));
            DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_blocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_blocks));
            DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_tiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_tiles));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.DrawCastleTerritorySystem/ProjectM.CastleBuilding.<>c__DisplayClass_DrawMapZone_LambdaJob0/ProjectM.CastleBuilding.RunWithoutJobSystem_000002E9$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000002E9$PostfixBurstDelegate");
          DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664370);
          DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664371);
          DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664372);
          DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664373);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.DrawCastleTerritorySystem/ProjectM.CastleBuilding.<>c__DisplayClass_DrawMapZone_LambdaJob0/ProjectM.CastleBuilding.RunWithoutJobSystem_000002E9$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201094, XrefRangeEnd = 1201108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201108, XrefRangeEnd = 1201126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201126, XrefRangeEnd = 1201141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1201168, RefRangeEnd = 1201169, XrefRangeStart = 1201141, XrefRangeEnd = 1201168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000002E9$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664374);
          DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664375);
          DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664376);
          DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664377);
          DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664379);
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
            IL2CPP.il2cpp_field_static_get_value(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DrawCastleTerritorySystem.__c__DisplayClass_DrawMapZone_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
