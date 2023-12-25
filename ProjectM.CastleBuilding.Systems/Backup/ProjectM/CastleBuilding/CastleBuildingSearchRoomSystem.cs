// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleBuildingSearchRoomSystem
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class CastleBuildingSearchRoomSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EnableDebugLogs;
    private static readonly System.IntPtr NativeFieldInfoPtr__AddedWallsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__MovedWallsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__RemovedWallsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__AddedFloorsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__MovedFloorsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__RemovedFloorsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleFloorEvents_Private_Void_NativeList_1_Entity_NativeList_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleWallEvents_Private_Void_NativeList_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNeighboursToQueue_Private_Static_Void_NativeList_1_Entity_CastleFloor_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNeighboursToQueue_Private_Static_Void_NativeList_1_Entity_CastleRoomWall_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199986, XrefRangeEnd = 1200072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBuildingSearchRoomSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200072, XrefRangeEnd = 1200150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBuildingSearchRoomSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1200195, RefRangeEnd = 1200196, XrefRangeStart = 1200150, XrefRangeEnd = 1200195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleFloorEvents(
      NativeList<Entity> floorsScanQueue,
      NativeList<Entity> floorsRemoved)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &floorsScanQueue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &floorsRemoved;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.NativeMethodInfoPtr_HandleFloorEvents_Private_Void_NativeList_1_Entity_NativeList_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1200231, RefRangeEnd = 1200232, XrefRangeStart = 1200196, XrefRangeEnd = 1200231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleWallEvents(NativeList<Entity> floorsScanQueue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &floorsScanQueue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.NativeMethodInfoPtr_HandleWallEvents_Private_Void_NativeList_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1200257, RefRangeEnd = 1200259, XrefRangeStart = 1200232, XrefRangeEnd = 1200257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddNeighboursToQueue(
      NativeList<Entity> queue,
      CastleFloor castleFloor)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &queue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &castleFloor;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.NativeMethodInfoPtr_AddNeighboursToQueue_Private_Static_Void_NativeList_1_Entity_CastleFloor_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1200276, RefRangeEnd = 1200280, XrefRangeStart = 1200259, XrefRangeEnd = 1200276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddNeighboursToQueue(
      NativeList<Entity> queue,
      CastleRoomWall castleRoomWall)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &queue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &castleRoomWall;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.NativeMethodInfoPtr_AddNeighboursToQueue_Private_Static_Void_NativeList_1_Entity_CastleRoomWall_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleBuildingSearchRoomSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200280, XrefRangeEnd = 1200309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBuildingSearchRoomSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200309, XrefRangeEnd = 1200325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CastleBuildingSearchRoomSystem()
    {
      Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.CastleBuilding", nameof (CastleBuildingSearchRoomSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr);
      CastleBuildingSearchRoomSystem.NativeFieldInfoPtr_EnableDebugLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, nameof (EnableDebugLogs));
      CastleBuildingSearchRoomSystem.NativeFieldInfoPtr__AddedWallsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, nameof (_AddedWallsQuery));
      CastleBuildingSearchRoomSystem.NativeFieldInfoPtr__MovedWallsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, nameof (_MovedWallsQuery));
      CastleBuildingSearchRoomSystem.NativeFieldInfoPtr__RemovedWallsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, nameof (_RemovedWallsQuery));
      CastleBuildingSearchRoomSystem.NativeFieldInfoPtr__AddedFloorsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, nameof (_AddedFloorsQuery));
      CastleBuildingSearchRoomSystem.NativeFieldInfoPtr__MovedFloorsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, nameof (_MovedFloorsQuery));
      CastleBuildingSearchRoomSystem.NativeFieldInfoPtr__RemovedFloorsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, nameof (_RemovedFloorsQuery));
      CastleBuildingSearchRoomSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      CastleBuildingSearchRoomSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      CastleBuildingSearchRoomSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      CastleBuildingSearchRoomSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, 100664288);
      CastleBuildingSearchRoomSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, 100664289);
      CastleBuildingSearchRoomSystem.NativeMethodInfoPtr_HandleFloorEvents_Private_Void_NativeList_1_Entity_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, 100664290);
      CastleBuildingSearchRoomSystem.NativeMethodInfoPtr_HandleWallEvents_Private_Void_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, 100664291);
      CastleBuildingSearchRoomSystem.NativeMethodInfoPtr_AddNeighboursToQueue_Private_Static_Void_NativeList_1_Entity_CastleFloor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, 100664292);
      CastleBuildingSearchRoomSystem.NativeMethodInfoPtr_AddNeighboursToQueue_Private_Static_Void_NativeList_1_Entity_CastleRoomWall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, 100664293);
      CastleBuildingSearchRoomSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, 100664294);
      CastleBuildingSearchRoomSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, 100664295);
      CastleBuildingSearchRoomSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, 100664296);
    }

    public CastleBuildingSearchRoomSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool EnableDebugLogs
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingSearchRoomSystem.NativeFieldInfoPtr_EnableDebugLogs));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingSearchRoomSystem.NativeFieldInfoPtr_EnableDebugLogs)) = value;
      }
    }

    public unsafe EntityQuery _AddedWallsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingSearchRoomSystem.NativeFieldInfoPtr__AddedWallsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingSearchRoomSystem.NativeFieldInfoPtr__AddedWallsQuery)) = value;
      }
    }

    public unsafe EntityQuery _MovedWallsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingSearchRoomSystem.NativeFieldInfoPtr__MovedWallsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingSearchRoomSystem.NativeFieldInfoPtr__MovedWallsQuery)) = value;
      }
    }

    public unsafe EntityQuery _RemovedWallsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingSearchRoomSystem.NativeFieldInfoPtr__RemovedWallsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingSearchRoomSystem.NativeFieldInfoPtr__RemovedWallsQuery)) = value;
      }
    }

    public unsafe EntityQuery _AddedFloorsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingSearchRoomSystem.NativeFieldInfoPtr__AddedFloorsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingSearchRoomSystem.NativeFieldInfoPtr__AddedFloorsQuery)) = value;
      }
    }

    public unsafe EntityQuery _MovedFloorsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingSearchRoomSystem.NativeFieldInfoPtr__MovedFloorsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingSearchRoomSystem.NativeFieldInfoPtr__MovedFloorsQuery)) = value;
      }
    }

    public unsafe EntityQuery _RemovedFloorsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingSearchRoomSystem.NativeFieldInfoPtr__RemovedFloorsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingSearchRoomSystem.NativeFieldInfoPtr__RemovedFloorsQuery)) = value;
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingSearchRoomSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingSearchRoomSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingSearchRoomSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingSearchRoomSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingSearchRoomSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingSearchRoomSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ExistingWallForFloor
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Floor;
      private static readonly System.IntPtr NativeFieldInfoPtr_Wall;
      private static readonly System.IntPtr NativeFieldInfoPtr_WallDirection;
      [FieldOffset(0)]
      public Entity Floor;
      [FieldOffset(8)]
      public Entity Wall;
      [FieldOffset(16)]
      public CardinalDirection WallDirection;

      static ExistingWallForFloor()
      {
        Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.ExistingWallForFloor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, nameof (ExistingWallForFloor));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.ExistingWallForFloor>.NativeClassPtr);
        CastleBuildingSearchRoomSystem.ExistingWallForFloor.NativeFieldInfoPtr_Floor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.ExistingWallForFloor>.NativeClassPtr, nameof (Floor));
        CastleBuildingSearchRoomSystem.ExistingWallForFloor.NativeFieldInfoPtr_Wall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.ExistingWallForFloor>.NativeClassPtr, nameof (Wall));
        CastleBuildingSearchRoomSystem.ExistingWallForFloor.NativeFieldInfoPtr_WallDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.ExistingWallForFloor>.NativeClassPtr, nameof (WallDirection));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.ExistingWallForFloor>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MissingWallForFloor
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Floor;
      private static readonly System.IntPtr NativeFieldInfoPtr_WallDirection;
      [FieldOffset(0)]
      public Entity Floor;
      [FieldOffset(8)]
      public CardinalDirection WallDirection;

      static MissingWallForFloor()
      {
        Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.MissingWallForFloor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, nameof (MissingWallForFloor));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.MissingWallForFloor>.NativeClassPtr);
        CastleBuildingSearchRoomSystem.MissingWallForFloor.NativeFieldInfoPtr_Floor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.MissingWallForFloor>.NativeClassPtr, nameof (Floor));
        CastleBuildingSearchRoomSystem.MissingWallForFloor.NativeFieldInfoPtr_WallDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.MissingWallForFloor>.NativeClassPtr, nameof (WallDirection));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.MissingWallForFloor>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HandleAddedFloorEventsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_AddedEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_FloorsScanQueue;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_HandleAddedFloor_Private_Void_byref_EntityEvent_CastleFloor_TilePosition_byref_AddedEvent_CastleFloor_TilePosition_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.EntityEvent> EntityEventType;
      [FieldOffset(32)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.AddedEvent> AddedEventType;
      [FieldOffset(64)]
      public NativeList<Entity> FloorsScanQueue;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199207, XrefRangeEnd = 1199216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.HandleAddedFloorEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1199219, RefRangeEnd = 1199220, XrefRangeStart = 1199216, XrefRangeEnd = 1199219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void HandleAddedFloor(
        [In] ref EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.EntityEvent entityEvent,
        [In] ref EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.AddedEvent addedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref entityEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref addedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.HandleAddedFloorEventsJob.NativeMethodInfoPtr_HandleAddedFloor_Private_Void_byref_EntityEvent_CastleFloor_TilePosition_byref_AddedEvent_CastleFloor_TilePosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HandleAddedFloorEventsJob()
      {
        Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleAddedFloorEventsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, nameof (HandleAddedFloorEventsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleAddedFloorEventsJob>.NativeClassPtr);
        CastleBuildingSearchRoomSystem.HandleAddedFloorEventsJob.NativeFieldInfoPtr_EntityEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleAddedFloorEventsJob>.NativeClassPtr, nameof (EntityEventType));
        CastleBuildingSearchRoomSystem.HandleAddedFloorEventsJob.NativeFieldInfoPtr_AddedEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleAddedFloorEventsJob>.NativeClassPtr, nameof (AddedEventType));
        CastleBuildingSearchRoomSystem.HandleAddedFloorEventsJob.NativeFieldInfoPtr_FloorsScanQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleAddedFloorEventsJob>.NativeClassPtr, nameof (FloorsScanQueue));
        CastleBuildingSearchRoomSystem.HandleAddedFloorEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleAddedFloorEventsJob>.NativeClassPtr, 100664297);
        CastleBuildingSearchRoomSystem.HandleAddedFloorEventsJob.NativeMethodInfoPtr_HandleAddedFloor_Private_Void_byref_EntityEvent_CastleFloor_TilePosition_byref_AddedEvent_CastleFloor_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleAddedFloorEventsJob>.NativeClassPtr, 100664298);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleAddedFloorEventsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HandleRemovedFloorEventsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_RemovedEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleFloorPreviousData;
      private static readonly System.IntPtr NativeFieldInfoPtr_FloorsScanQueue;
      private static readonly System.IntPtr NativeFieldInfoPtr_FloorsRemoved;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetFloorsBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleRoomConnection;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_HandleRemovedFloor_Private_Void_byref_Entity_byref_EntityEvent_CastleFloor_TilePosition_byref_RemovedEvent_CastleFloor_TilePosition_0;
      [FieldOffset(0)]
      public EntityTypeHandle EntityType;
      [FieldOffset(8)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.EntityEvent> EntityEventType;
      [FieldOffset(40)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.RemovedEvent> RemovedEventType;
      [FieldOffset(72)]
      public ComponentDataFromEntity<CastleFloorPreviousData> GetCastleFloorPreviousData;
      [FieldOffset(104)]
      public NativeList<Entity> FloorsScanQueue;
      [FieldOffset(120)]
      public NativeList<Entity> FloorsRemoved;
      [FieldOffset(136)]
      public EntityCommandBuffer CommandBuffer;
      [FieldOffset(152)]
      public BufferFromEntity<CastleRoomFloorsBuffer> GetFloorsBuffer;
      [FieldOffset(192)]
      public ComponentDataFromEntity<CastleRoomConnection> GetCastleRoomConnection;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199220, XrefRangeEnd = 1199230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1199285, RefRangeEnd = 1199286, XrefRangeStart = 1199230, XrefRangeEnd = 1199285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void HandleRemovedFloor(
        [In] ref Entity eventEntity,
        [In] ref EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.EntityEvent entityEvent,
        [In] ref EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.RemovedEvent removedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref eventEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref removedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob.NativeMethodInfoPtr_HandleRemovedFloor_Private_Void_byref_Entity_byref_EntityEvent_CastleFloor_TilePosition_byref_RemovedEvent_CastleFloor_TilePosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HandleRemovedFloorEventsJob()
      {
        Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, nameof (HandleRemovedFloorEventsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob>.NativeClassPtr);
        CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob>.NativeClassPtr, nameof (EntityType));
        CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob.NativeFieldInfoPtr_EntityEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob>.NativeClassPtr, nameof (EntityEventType));
        CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob.NativeFieldInfoPtr_RemovedEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob>.NativeClassPtr, nameof (RemovedEventType));
        CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob.NativeFieldInfoPtr_GetCastleFloorPreviousData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob>.NativeClassPtr, nameof (GetCastleFloorPreviousData));
        CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob.NativeFieldInfoPtr_FloorsScanQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob>.NativeClassPtr, nameof (FloorsScanQueue));
        CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob.NativeFieldInfoPtr_FloorsRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob>.NativeClassPtr, nameof (FloorsRemoved));
        CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob>.NativeClassPtr, nameof (CommandBuffer));
        CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob.NativeFieldInfoPtr_GetFloorsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob>.NativeClassPtr, nameof (GetFloorsBuffer));
        CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob.NativeFieldInfoPtr_GetCastleRoomConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob>.NativeClassPtr, nameof (GetCastleRoomConnection));
        CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob>.NativeClassPtr, 100664299);
        CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob.NativeMethodInfoPtr_HandleRemovedFloor_Private_Void_byref_Entity_byref_EntityEvent_CastleFloor_TilePosition_byref_RemovedEvent_CastleFloor_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob>.NativeClassPtr, 100664300);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleRemovedFloorEventsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HandleMovedFloorEventsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_UpdatedEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleFloor;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleFloorPreviousData;
      private static readonly System.IntPtr NativeFieldInfoPtr_FloorsScanQueue;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_HandleMovedFloor_Private_Void_byref_Entity_byref_EntityEvent_CastleFloor_TilePosition_byref_UpdatedEvent_CastleFloor_TilePosition_0;
      [FieldOffset(0)]
      public EntityTypeHandle EntityType;
      [FieldOffset(8)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.EntityEvent> EntityEventType;
      [FieldOffset(40)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.UpdatedEvent> UpdatedEventType;
      [FieldOffset(72)]
      public ComponentDataFromEntity<CastleFloor> GetCastleFloor;
      [FieldOffset(104)]
      public ComponentDataFromEntity<CastleFloorPreviousData> GetCastleFloorPreviousData;
      [FieldOffset(136)]
      public NativeList<Entity> FloorsScanQueue;
      [FieldOffset(152)]
      public EntityCommandBuffer CommandBuffer;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199286, XrefRangeEnd = 1199296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.HandleMovedFloorEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1199335, RefRangeEnd = 1199336, XrefRangeStart = 1199296, XrefRangeEnd = 1199335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void HandleMovedFloor(
        [In] ref Entity eventEntity,
        [In] ref EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.EntityEvent entityEvent,
        [In] ref EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.UpdatedEvent updatedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref eventEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref updatedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.HandleMovedFloorEventsJob.NativeMethodInfoPtr_HandleMovedFloor_Private_Void_byref_Entity_byref_EntityEvent_CastleFloor_TilePosition_byref_UpdatedEvent_CastleFloor_TilePosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HandleMovedFloorEventsJob()
      {
        Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleMovedFloorEventsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, nameof (HandleMovedFloorEventsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleMovedFloorEventsJob>.NativeClassPtr);
        CastleBuildingSearchRoomSystem.HandleMovedFloorEventsJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleMovedFloorEventsJob>.NativeClassPtr, nameof (EntityType));
        CastleBuildingSearchRoomSystem.HandleMovedFloorEventsJob.NativeFieldInfoPtr_EntityEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleMovedFloorEventsJob>.NativeClassPtr, nameof (EntityEventType));
        CastleBuildingSearchRoomSystem.HandleMovedFloorEventsJob.NativeFieldInfoPtr_UpdatedEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleMovedFloorEventsJob>.NativeClassPtr, nameof (UpdatedEventType));
        CastleBuildingSearchRoomSystem.HandleMovedFloorEventsJob.NativeFieldInfoPtr_GetCastleFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleMovedFloorEventsJob>.NativeClassPtr, nameof (GetCastleFloor));
        CastleBuildingSearchRoomSystem.HandleMovedFloorEventsJob.NativeFieldInfoPtr_GetCastleFloorPreviousData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleMovedFloorEventsJob>.NativeClassPtr, nameof (GetCastleFloorPreviousData));
        CastleBuildingSearchRoomSystem.HandleMovedFloorEventsJob.NativeFieldInfoPtr_FloorsScanQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleMovedFloorEventsJob>.NativeClassPtr, nameof (FloorsScanQueue));
        CastleBuildingSearchRoomSystem.HandleMovedFloorEventsJob.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleMovedFloorEventsJob>.NativeClassPtr, nameof (CommandBuffer));
        CastleBuildingSearchRoomSystem.HandleMovedFloorEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleMovedFloorEventsJob>.NativeClassPtr, 100664301);
        CastleBuildingSearchRoomSystem.HandleMovedFloorEventsJob.NativeMethodInfoPtr_HandleMovedFloor_Private_Void_byref_Entity_byref_EntityEvent_CastleFloor_TilePosition_byref_UpdatedEvent_CastleFloor_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleMovedFloorEventsJob>.NativeClassPtr, 100664302);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleMovedFloorEventsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HandleAddedWallEventsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_AddedEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleWall;
      private static readonly System.IntPtr NativeFieldInfoPtr_FloorsScanQueue;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_HandleAddedWall_Private_Void_byref_EntityEvent_CastleRoomWall_TilePosition_byref_AddedEvent_CastleRoomWall_TilePosition_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.EntityEvent> EntityEventType;
      [FieldOffset(32)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.AddedEvent> AddedEventType;
      [FieldOffset(64)]
      public ComponentDataFromEntity<CastleRoomWall> GetCastleWall;
      [FieldOffset(96)]
      public NativeList<Entity> FloorsScanQueue;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199336, XrefRangeEnd = 1199345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.HandleAddedWallEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1199349, RefRangeEnd = 1199350, XrefRangeStart = 1199345, XrefRangeEnd = 1199349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void HandleAddedWall(
        [In] ref EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.EntityEvent entityEvent,
        [In] ref EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.AddedEvent addedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref entityEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref addedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.HandleAddedWallEventsJob.NativeMethodInfoPtr_HandleAddedWall_Private_Void_byref_EntityEvent_CastleRoomWall_TilePosition_byref_AddedEvent_CastleRoomWall_TilePosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HandleAddedWallEventsJob()
      {
        Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleAddedWallEventsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, nameof (HandleAddedWallEventsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleAddedWallEventsJob>.NativeClassPtr);
        CastleBuildingSearchRoomSystem.HandleAddedWallEventsJob.NativeFieldInfoPtr_EntityEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleAddedWallEventsJob>.NativeClassPtr, nameof (EntityEventType));
        CastleBuildingSearchRoomSystem.HandleAddedWallEventsJob.NativeFieldInfoPtr_AddedEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleAddedWallEventsJob>.NativeClassPtr, nameof (AddedEventType));
        CastleBuildingSearchRoomSystem.HandleAddedWallEventsJob.NativeFieldInfoPtr_GetCastleWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleAddedWallEventsJob>.NativeClassPtr, nameof (GetCastleWall));
        CastleBuildingSearchRoomSystem.HandleAddedWallEventsJob.NativeFieldInfoPtr_FloorsScanQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleAddedWallEventsJob>.NativeClassPtr, nameof (FloorsScanQueue));
        CastleBuildingSearchRoomSystem.HandleAddedWallEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleAddedWallEventsJob>.NativeClassPtr, 100664303);
        CastleBuildingSearchRoomSystem.HandleAddedWallEventsJob.NativeMethodInfoPtr_HandleAddedWall_Private_Void_byref_EntityEvent_CastleRoomWall_TilePosition_byref_AddedEvent_CastleRoomWall_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleAddedWallEventsJob>.NativeClassPtr, 100664304);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleAddedWallEventsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HandleRemovedWallEventsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_RemovedEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleWallPreviousData;
      private static readonly System.IntPtr NativeFieldInfoPtr_FloorsScanQueue;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_HandleRemovedWall_Private_Void_byref_Entity_byref_RemovedEvent_CastleRoomWall_TilePosition_0;
      [FieldOffset(0)]
      public EntityTypeHandle EntityType;
      [FieldOffset(8)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.RemovedEvent> RemovedEventType;
      [FieldOffset(40)]
      public ComponentDataFromEntity<CastleWallPreviousData> GetCastleWallPreviousData;
      [FieldOffset(72)]
      public NativeList<Entity> FloorsScanQueue;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199350, XrefRangeEnd = 1199357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.HandleRemovedWallEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1199361, RefRangeEnd = 1199362, XrefRangeStart = 1199357, XrefRangeEnd = 1199361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void HandleRemovedWall(
        [In] ref Entity eventEntity,
        [In] ref EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.RemovedEvent removedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref eventEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref removedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.HandleRemovedWallEventsJob.NativeMethodInfoPtr_HandleRemovedWall_Private_Void_byref_Entity_byref_RemovedEvent_CastleRoomWall_TilePosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HandleRemovedWallEventsJob()
      {
        Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleRemovedWallEventsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, nameof (HandleRemovedWallEventsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleRemovedWallEventsJob>.NativeClassPtr);
        CastleBuildingSearchRoomSystem.HandleRemovedWallEventsJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleRemovedWallEventsJob>.NativeClassPtr, nameof (EntityType));
        CastleBuildingSearchRoomSystem.HandleRemovedWallEventsJob.NativeFieldInfoPtr_RemovedEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleRemovedWallEventsJob>.NativeClassPtr, nameof (RemovedEventType));
        CastleBuildingSearchRoomSystem.HandleRemovedWallEventsJob.NativeFieldInfoPtr_GetCastleWallPreviousData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleRemovedWallEventsJob>.NativeClassPtr, nameof (GetCastleWallPreviousData));
        CastleBuildingSearchRoomSystem.HandleRemovedWallEventsJob.NativeFieldInfoPtr_FloorsScanQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleRemovedWallEventsJob>.NativeClassPtr, nameof (FloorsScanQueue));
        CastleBuildingSearchRoomSystem.HandleRemovedWallEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleRemovedWallEventsJob>.NativeClassPtr, 100664305);
        CastleBuildingSearchRoomSystem.HandleRemovedWallEventsJob.NativeMethodInfoPtr_HandleRemovedWall_Private_Void_byref_Entity_byref_RemovedEvent_CastleRoomWall_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleRemovedWallEventsJob>.NativeClassPtr, 100664306);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleRemovedWallEventsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HandleMovedWallEventsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_UpdatedEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleWall;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleWallPreviousData;
      private static readonly System.IntPtr NativeFieldInfoPtr_FloorsScanQueue;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_HandleMovedWall_Private_Void_byref_Entity_byref_EntityEvent_CastleRoomWall_TilePosition_byref_UpdatedEvent_CastleRoomWall_TilePosition_0;
      [FieldOffset(0)]
      public EntityTypeHandle EntityType;
      [FieldOffset(8)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.EntityEvent> EntityEventType;
      [FieldOffset(40)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.UpdatedEvent> UpdatedEventType;
      [FieldOffset(72)]
      public ComponentDataFromEntity<CastleRoomWall> GetCastleWall;
      [FieldOffset(104)]
      public ComponentDataFromEntity<CastleWallPreviousData> GetCastleWallPreviousData;
      [FieldOffset(136)]
      public NativeList<Entity> FloorsScanQueue;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199362, XrefRangeEnd = 1199372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.HandleMovedWallEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1199380, RefRangeEnd = 1199381, XrefRangeStart = 1199372, XrefRangeEnd = 1199380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void HandleMovedWall(
        [In] ref Entity eventEntity,
        [In] ref EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.EntityEvent entityEvent,
        [In] ref EntityAddUpdateRemoveEventSystem<CastleRoomWall, TilePosition>.UpdatedEvent updatedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref eventEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entityEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref updatedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.HandleMovedWallEventsJob.NativeMethodInfoPtr_HandleMovedWall_Private_Void_byref_Entity_byref_EntityEvent_CastleRoomWall_TilePosition_byref_UpdatedEvent_CastleRoomWall_TilePosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HandleMovedWallEventsJob()
      {
        Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleMovedWallEventsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, nameof (HandleMovedWallEventsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleMovedWallEventsJob>.NativeClassPtr);
        CastleBuildingSearchRoomSystem.HandleMovedWallEventsJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleMovedWallEventsJob>.NativeClassPtr, nameof (EntityType));
        CastleBuildingSearchRoomSystem.HandleMovedWallEventsJob.NativeFieldInfoPtr_EntityEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleMovedWallEventsJob>.NativeClassPtr, nameof (EntityEventType));
        CastleBuildingSearchRoomSystem.HandleMovedWallEventsJob.NativeFieldInfoPtr_UpdatedEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleMovedWallEventsJob>.NativeClassPtr, nameof (UpdatedEventType));
        CastleBuildingSearchRoomSystem.HandleMovedWallEventsJob.NativeFieldInfoPtr_GetCastleWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleMovedWallEventsJob>.NativeClassPtr, nameof (GetCastleWall));
        CastleBuildingSearchRoomSystem.HandleMovedWallEventsJob.NativeFieldInfoPtr_GetCastleWallPreviousData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleMovedWallEventsJob>.NativeClassPtr, nameof (GetCastleWallPreviousData));
        CastleBuildingSearchRoomSystem.HandleMovedWallEventsJob.NativeFieldInfoPtr_FloorsScanQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleMovedWallEventsJob>.NativeClassPtr, nameof (FloorsScanQueue));
        CastleBuildingSearchRoomSystem.HandleMovedWallEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleMovedWallEventsJob>.NativeClassPtr, 100664307);
        CastleBuildingSearchRoomSystem.HandleMovedWallEventsJob.NativeMethodInfoPtr_HandleMovedWall_Private_Void_byref_Entity_byref_EntityEvent_CastleRoomWall_TilePosition_byref_UpdatedEvent_CastleRoomWall_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleMovedWallEventsJob>.NativeClassPtr, 100664308);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.HandleMovedWallEventsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RoomScanFloorsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FloorsScanQueue;
      private static readonly System.IntPtr NativeFieldInfoPtr_FloorsRemoved;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleRoom;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetFloorsBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetWallsBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleRoomConnection;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleFloor;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleWall;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleStairs;
      private static readonly System.IntPtr NativeFieldInfoPtr_CastleRoomPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_EnableDebugLogs;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SearchRecursive_Private_Void_Entity_byref_ComponentDataFromEntity_1_CastleFloor_byref_ComponentDataFromEntity_1_CastleRoomWall_byref_ComponentDataFromEntity_1_CastleStairs_NativeList_1_Entity_NativeList_1_ExistingWallForFloor_byref_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CheckFloorIsStairCase_Private_Static_Void_Entity_byref_ComponentDataFromEntity_1_CastleStairs_byref_Boolean_byref_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CreateOrMergeRoom_Private_Void_NativeList_1_Entity_NativeList_1_ExistingWallForFloor_Boolean_NativeMultiHashMap_2_Entity_Entity_Int32_NativeHashSet_1_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CreateFloorElement_Private_CastleRoomFloorsBuffer_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CreateWallElement_Private_CastleRoomWallsBuffer_ExistingWallForFloor_0;
      [FieldOffset(0)]
      public NativeList<Entity> FloorsScanQueue;
      [FieldOffset(16)]
      public NativeList<Entity> FloorsRemoved;
      [FieldOffset(32)]
      public EntityCommandBuffer CommandBuffer;
      [FieldOffset(48)]
      public ComponentDataFromEntity<CastleRoom> GetCastleRoom;
      [FieldOffset(80)]
      public BufferFromEntity<CastleRoomFloorsBuffer> GetFloorsBuffer;
      [FieldOffset(120)]
      public BufferFromEntity<CastleRoomWallsBuffer> GetWallsBuffer;
      [FieldOffset(160)]
      public ComponentDataFromEntity<CastleRoomConnection> GetCastleRoomConnection;
      [FieldOffset(192)]
      public ComponentDataFromEntity<Translation> GetTranslation;
      [FieldOffset(224)]
      public ComponentDataFromEntity<CastleFloor> GetCastleFloor;
      [FieldOffset(256)]
      public ComponentDataFromEntity<CastleRoomWall> GetCastleWall;
      [FieldOffset(288)]
      public ComponentDataFromEntity<CastleStairs> GetCastleStairs;
      [FieldOffset(320)]
      public Entity CastleRoomPrefab;
      [FieldOffset(328)]
      public bool EnableDebugLogs;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199381, XrefRangeEnd = 1199486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1199519, RefRangeEnd = 1199521, XrefRangeStart = 1199486, XrefRangeEnd = 1199519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SearchRecursive(
        Entity floorFromScanQueue,
        ref ComponentDataFromEntity<CastleFloor> getCastleFloor,
        ref ComponentDataFromEntity<CastleRoomWall> getCastleWall,
        ref ComponentDataFromEntity<CastleStairs> getCastleStairs,
        NativeList<Entity> searchedFloors,
        NativeList<CastleBuildingSearchRoomSystem.ExistingWallForFloor> existingWalls,
        ref bool isMissingWalls)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) &floorFromScanQueue;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref getCastleFloor;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref getCastleWall;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref getCastleStairs;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &searchedFloors;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &existingWalls;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref isMissingWalls;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeMethodInfoPtr_SearchRecursive_Private_Void_Entity_byref_ComponentDataFromEntity_1_CastleFloor_byref_ComponentDataFromEntity_1_CastleRoomWall_byref_ComponentDataFromEntity_1_CastleStairs_NativeList_1_Entity_NativeList_1_ExistingWallForFloor_byref_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1199525, RefRangeEnd = 1199527, XrefRangeStart = 1199521, XrefRangeEnd = 1199525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void CheckFloorIsStairCase(
        Entity floorFromScanQueue,
        ref ComponentDataFromEntity<CastleStairs> getCastleStairs,
        out bool isStaircase,
        out bool floorIsBottomFloorStairs)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &floorFromScanQueue;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref getCastleStairs;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref isStaircase;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref floorIsBottomFloorStairs;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeMethodInfoPtr_CheckFloorIsStairCase_Private_Static_Void_Entity_byref_ComponentDataFromEntity_1_CastleStairs_byref_Boolean_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1199916, RefRangeEnd = 1199917, XrefRangeStart = 1199527, XrefRangeEnd = 1199916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CreateOrMergeRoom(
        NativeList<Entity> searchedFloors,
        NativeList<CastleBuildingSearchRoomSystem.ExistingWallForFloor> existingWalls,
        bool isMissingWalls,
        NativeMultiHashMap<Entity, Entity> roomsHandled,
        int internalRoomCounter,
        NativeHashSet<Entity> roomsRemoved)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) &searchedFloors;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &existingWalls;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isMissingWalls;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &roomsHandled;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &internalRoomCounter;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &roomsRemoved;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeMethodInfoPtr_CreateOrMergeRoom_Private_Void_NativeList_1_Entity_NativeList_1_ExistingWallForFloor_Boolean_NativeMultiHashMap_2_Entity_Entity_Int32_NativeHashSet_1_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1199921, RefRangeEnd = 1199924, XrefRangeStart = 1199917, XrefRangeEnd = 1199921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe CastleRoomFloorsBuffer CreateFloorElement(Entity floor)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &floor;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeMethodInfoPtr_CreateFloorElement_Private_CastleRoomFloorsBuffer_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CastleRoomFloorsBuffer*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1199928, RefRangeEnd = 1199931, XrefRangeStart = 1199924, XrefRangeEnd = 1199928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe CastleRoomWallsBuffer CreateWallElement(
        CastleBuildingSearchRoomSystem.ExistingWallForFloor wall)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &wall;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeMethodInfoPtr_CreateWallElement_Private_CastleRoomWallsBuffer_ExistingWallForFloor_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CastleRoomWallsBuffer*) IL2CPP.il2cpp_object_unbox(num);
      }

      static RoomScanFloorsJob()
      {
        Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.RoomScanFloorsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, nameof (RoomScanFloorsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.RoomScanFloorsJob>.NativeClassPtr);
        CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeFieldInfoPtr_FloorsScanQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.RoomScanFloorsJob>.NativeClassPtr, nameof (FloorsScanQueue));
        CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeFieldInfoPtr_FloorsRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.RoomScanFloorsJob>.NativeClassPtr, nameof (FloorsRemoved));
        CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.RoomScanFloorsJob>.NativeClassPtr, nameof (CommandBuffer));
        CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeFieldInfoPtr_GetCastleRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.RoomScanFloorsJob>.NativeClassPtr, nameof (GetCastleRoom));
        CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeFieldInfoPtr_GetFloorsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.RoomScanFloorsJob>.NativeClassPtr, nameof (GetFloorsBuffer));
        CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeFieldInfoPtr_GetWallsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.RoomScanFloorsJob>.NativeClassPtr, nameof (GetWallsBuffer));
        CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeFieldInfoPtr_GetCastleRoomConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.RoomScanFloorsJob>.NativeClassPtr, nameof (GetCastleRoomConnection));
        CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeFieldInfoPtr_GetTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.RoomScanFloorsJob>.NativeClassPtr, nameof (GetTranslation));
        CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeFieldInfoPtr_GetCastleFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.RoomScanFloorsJob>.NativeClassPtr, nameof (GetCastleFloor));
        CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeFieldInfoPtr_GetCastleWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.RoomScanFloorsJob>.NativeClassPtr, nameof (GetCastleWall));
        CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeFieldInfoPtr_GetCastleStairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.RoomScanFloorsJob>.NativeClassPtr, nameof (GetCastleStairs));
        CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeFieldInfoPtr_CastleRoomPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.RoomScanFloorsJob>.NativeClassPtr, nameof (CastleRoomPrefab));
        CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeFieldInfoPtr_EnableDebugLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.RoomScanFloorsJob>.NativeClassPtr, nameof (EnableDebugLogs));
        CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.RoomScanFloorsJob>.NativeClassPtr, 100664309);
        CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeMethodInfoPtr_SearchRecursive_Private_Void_Entity_byref_ComponentDataFromEntity_1_CastleFloor_byref_ComponentDataFromEntity_1_CastleRoomWall_byref_ComponentDataFromEntity_1_CastleStairs_NativeList_1_Entity_NativeList_1_ExistingWallForFloor_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.RoomScanFloorsJob>.NativeClassPtr, 100664310);
        CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeMethodInfoPtr_CheckFloorIsStairCase_Private_Static_Void_Entity_byref_ComponentDataFromEntity_1_CastleStairs_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.RoomScanFloorsJob>.NativeClassPtr, 100664311);
        CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeMethodInfoPtr_CreateOrMergeRoom_Private_Void_NativeList_1_Entity_NativeList_1_ExistingWallForFloor_Boolean_NativeMultiHashMap_2_Entity_Entity_Int32_NativeHashSet_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.RoomScanFloorsJob>.NativeClassPtr, 100664312);
        CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeMethodInfoPtr_CreateFloorElement_Private_CastleRoomFloorsBuffer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.RoomScanFloorsJob>.NativeClassPtr, 100664313);
        CastleBuildingSearchRoomSystem.RoomScanFloorsJob.NativeMethodInfoPtr_CreateWallElement_Private_CastleRoomWallsBuffer_ExistingWallForFloor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.RoomScanFloorsJob>.NativeClassPtr, 100664314);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.RoomScanFloorsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.CastleBuildingSearchRoomSystem/<>c__DisplayClass11_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass11_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_isServer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_CastleRoomEvent_0;
      [FieldOffset(0)]
      public bool isServer;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass11_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0([In] ref CastleRoomEvent castleRoomEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref castleRoomEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_CastleRoomEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass11_0()
      {
        Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, "<>c__DisplayClass11_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass11_0>.NativeClassPtr);
        CastleBuildingSearchRoomSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_isServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (isServer));
        CastleBuildingSearchRoomSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass11_0>.NativeClassPtr, 100664315);
        CastleBuildingSearchRoomSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_CastleRoomEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass11_0>.NativeClassPtr, 100664316);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass11_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.CastleBuildingSearchRoomSystem/ProjectM.CastleBuilding.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_isServer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CastleRoomEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingSearchRoomSystem_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      [FieldOffset(0)]
      public bool isServer;
      [FieldOffset(8)]
      public CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(40)]
      public unsafe CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1199968, RefRangeEnd = 1199969, XrefRangeStart = 1199939, XrefRangeEnd = 1199968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref CastleRoomEvent castleRoomEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref castleRoomEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CastleRoomEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1067868, RefRangeEnd = 1067871, XrefRangeStart = 1067868, XrefRangeEnd = 1067871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref CastleBuildingSearchRoomSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1067871, RefRangeEnd = 1067874, XrefRangeStart = 1067871, XrefRangeEnd = 1067874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref CastleBuildingSearchRoomSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199969, XrefRangeEnd = 1199971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1199976, RefRangeEnd = 1199977, XrefRangeStart = 1199971, XrefRangeEnd = 1199976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1199979, RefRangeEnd = 1199980, XrefRangeStart = 1199977, XrefRangeEnd = 1199979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        CastleBuildingSearchRoomSystem componentSystem,
        ref CastleBuildingSearchRoomSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingSearchRoomSystem_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199980, XrefRangeEnd = 1199986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_isServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (isServer));
        CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CastleRoomEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664317);
        CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664318);
        CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664319);
        CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664320);
        CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664321);
        CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingSearchRoomSystem_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664322);
        CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100664323);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castleRoomEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingSearchRoomSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<CastleRoomEvent> forParameter_castleRoomEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1199934, RefRangeEnd = 1199935, XrefRangeStart = 1199931, XrefRangeEnd = 1199934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(CastleBuildingSearchRoomSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingSearchRoomSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1199938, RefRangeEnd = 1199939, XrefRangeStart = 1199935, XrefRangeEnd = 1199938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castleRoomEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castleRoomEvent));
          CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingSearchRoomSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664324);
          CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664325);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castleRoomEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<CastleRoomEvent>.Runtime runtime_castleRoomEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castleRoomEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castleRoomEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingSearchRoomSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
