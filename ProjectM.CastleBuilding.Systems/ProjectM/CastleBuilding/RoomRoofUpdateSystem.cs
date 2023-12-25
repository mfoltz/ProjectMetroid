// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.RoomRoofUpdateSystem
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Roofs;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Transforms;
using UnityEngine;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class RoomRoofUpdateSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LinnCastleRoofHeightOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__DestroyBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CastleBlockSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequireWalls;
    private static readonly System.IntPtr NativeFieldInfoPtr_DebuggingEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr___ProcessDirtyRooms_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ProcessDirtyRooms_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ProcessDirtyRooms_LambdaJob2_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ProcessAllRooms_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessDirtyRooms_Private_Void_NativeList_1_Entity_CastleBlockCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryAddfNeighbourRoom_Private_Static_Void_CastleBlock_ComponentDataFromEntity_1_CastleRoomConnection_ComponentDataFromEntity_1_CastleRoom_CastleBlockCollection_NativeList_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessAllRooms_Private_Void_NativeList_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForProcessDirtyRooms_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForProcessDirtyRooms_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForProcessDirtyRooms_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForProcessAllRooms_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198741, XrefRangeEnd = 1198767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RoomRoofUpdateSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RoomRoofUpdateSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198767, XrefRangeEnd = 1198861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RoomRoofUpdateSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1198889, RefRangeEnd = 1198890, XrefRangeStart = 1198861, XrefRangeEnd = 1198889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessDirtyRooms(
      NativeList<Entity> roomsToProcess,
      CastleBlockCollection castleBlockCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &roomsToProcess;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &castleBlockCollection;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.NativeMethodInfoPtr_ProcessDirtyRooms_Private_Void_NativeList_1_Entity_CastleBlockCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1198900, RefRangeEnd = 1198901, XrefRangeStart = 1198890, XrefRangeEnd = 1198900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryAddfNeighbourRoom(
      CastleBlock floorBlock,
      ComponentDataFromEntity<CastleRoomConnection> roomConnectionromEntity,
      ComponentDataFromEntity<CastleRoom> castleRoomFromEntity,
      CastleBlockCollection castleBlockCollection,
      NativeList<Entity> roomsToProcess)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &floorBlock;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &roomConnectionromEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &castleRoomFromEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &castleBlockCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &roomsToProcess;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.NativeMethodInfoPtr_TryAddfNeighbourRoom_Private_Static_Void_CastleBlock_ComponentDataFromEntity_1_CastleRoomConnection_ComponentDataFromEntity_1_CastleRoom_CastleBlockCollection_NativeList_1_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198901, XrefRangeEnd = 1198908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessAllRooms(NativeList<Entity> roomsToProcess)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &roomsToProcess;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.NativeMethodInfoPtr_ProcessAllRooms_Private_Void_NativeList_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198908, XrefRangeEnd = 1198909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RoomRoofUpdateSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198909, XrefRangeEnd = 1198962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RoomRoofUpdateSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198962, XrefRangeEnd = 1198981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForProcessDirtyRooms_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.NativeMethodInfoPtr___GetEntityQuery_ForProcessDirtyRooms_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1199003, RefRangeEnd = 1199004, XrefRangeStart = 1198981, XrefRangeEnd = 1199003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForProcessDirtyRooms_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.NativeMethodInfoPtr___GetEntityQuery_ForProcessDirtyRooms_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199004, XrefRangeEnd = 1199020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForProcessDirtyRooms_LambdaJob2_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.NativeMethodInfoPtr___GetEntityQuery_ForProcessDirtyRooms_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1199020, XrefRangeEnd = 1199036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForProcessAllRooms_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.NativeMethodInfoPtr___GetEntityQuery_ForProcessAllRooms_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static RoomRoofUpdateSystem()
    {
      Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.CastleBuilding", nameof (RoomRoofUpdateSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr);
      RoomRoofUpdateSystem.NativeFieldInfoPtr_LinnCastleRoofHeightOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, nameof (LinnCastleRoofHeightOffset));
      RoomRoofUpdateSystem.NativeFieldInfoPtr__SpawnBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, nameof (_SpawnBarrier));
      RoomRoofUpdateSystem.NativeFieldInfoPtr__DestroyBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, nameof (_DestroyBarrier));
      RoomRoofUpdateSystem.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, nameof (_GameDataSystem));
      RoomRoofUpdateSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      RoomRoofUpdateSystem.NativeFieldInfoPtr__CastleBlockSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, nameof (_CastleBlockSystem));
      RoomRoofUpdateSystem.NativeFieldInfoPtr_RequireWalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, nameof (RequireWalls));
      RoomRoofUpdateSystem.NativeFieldInfoPtr_DebuggingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, nameof (DebuggingEnabled));
      RoomRoofUpdateSystem.NativeFieldInfoPtr___ProcessDirtyRooms_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, "<>ProcessDirtyRooms_LambdaJob0_entityQuery");
      RoomRoofUpdateSystem.NativeFieldInfoPtr___ProcessDirtyRooms_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, "<>ProcessDirtyRooms_LambdaJob1_entityQuery");
      RoomRoofUpdateSystem.NativeFieldInfoPtr___ProcessDirtyRooms_LambdaJob2_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, "<>ProcessDirtyRooms_LambdaJob2_entityQuery");
      RoomRoofUpdateSystem.NativeFieldInfoPtr___ProcessAllRooms_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, "<>ProcessAllRooms_LambdaJob0_entityQuery");
      RoomRoofUpdateSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, 100664190);
      RoomRoofUpdateSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, 100664191);
      RoomRoofUpdateSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, 100664192);
      RoomRoofUpdateSystem.NativeMethodInfoPtr_ProcessDirtyRooms_Private_Void_NativeList_1_Entity_CastleBlockCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, 100664193);
      RoomRoofUpdateSystem.NativeMethodInfoPtr_TryAddfNeighbourRoom_Private_Static_Void_CastleBlock_ComponentDataFromEntity_1_CastleRoomConnection_ComponentDataFromEntity_1_CastleRoom_CastleBlockCollection_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, 100664194);
      RoomRoofUpdateSystem.NativeMethodInfoPtr_ProcessAllRooms_Private_Void_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, 100664195);
      RoomRoofUpdateSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, 100664196);
      RoomRoofUpdateSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, 100664197);
      RoomRoofUpdateSystem.NativeMethodInfoPtr___GetEntityQuery_ForProcessDirtyRooms_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, 100664198);
      RoomRoofUpdateSystem.NativeMethodInfoPtr___GetEntityQuery_ForProcessDirtyRooms_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, 100664199);
      RoomRoofUpdateSystem.NativeMethodInfoPtr___GetEntityQuery_ForProcessDirtyRooms_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, 100664200);
      RoomRoofUpdateSystem.NativeMethodInfoPtr___GetEntityQuery_ForProcessAllRooms_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, 100664201);
    }

    public RoomRoofUpdateSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe float LinnCastleRoofHeightOffset
    {
      get
      {
        float roofHeightOffset;
        IL2CPP.il2cpp_field_static_get_value(RoomRoofUpdateSystem.NativeFieldInfoPtr_LinnCastleRoofHeightOffset, (void*) &roofHeightOffset);
        return roofHeightOffset;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RoomRoofUpdateSystem.NativeFieldInfoPtr_LinnCastleRoofHeightOffset, (void*) &value);
      }
    }

    public unsafe EntityCommandBufferSystem _SpawnBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoomRoofUpdateSystem.NativeFieldInfoPtr__SpawnBarrier));
        return pointer == System.IntPtr.Zero ? (EntityCommandBufferSystem) null : new EntityCommandBufferSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RoomRoofUpdateSystem.NativeFieldInfoPtr__SpawnBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityCommandBufferSystem _DestroyBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoomRoofUpdateSystem.NativeFieldInfoPtr__DestroyBarrier));
        return pointer == System.IntPtr.Zero ? (EntityCommandBufferSystem) null : new EntityCommandBufferSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RoomRoofUpdateSystem.NativeFieldInfoPtr__DestroyBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoomRoofUpdateSystem.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RoomRoofUpdateSystem.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoomRoofUpdateSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RoomRoofUpdateSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CastleBlockSystem _CastleBlockSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoomRoofUpdateSystem.NativeFieldInfoPtr__CastleBlockSystem));
        return pointer == System.IntPtr.Zero ? (CastleBlockSystem) null : new CastleBlockSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RoomRoofUpdateSystem.NativeFieldInfoPtr__CastleBlockSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool RequireWalls
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoomRoofUpdateSystem.NativeFieldInfoPtr_RequireWalls));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoomRoofUpdateSystem.NativeFieldInfoPtr_RequireWalls)) = value;
      }
    }

    public unsafe bool DebuggingEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoomRoofUpdateSystem.NativeFieldInfoPtr_DebuggingEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoomRoofUpdateSystem.NativeFieldInfoPtr_DebuggingEnabled)) = value;
      }
    }

    public unsafe EntityQuery __ProcessDirtyRooms_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoomRoofUpdateSystem.NativeFieldInfoPtr___ProcessDirtyRooms_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoomRoofUpdateSystem.NativeFieldInfoPtr___ProcessDirtyRooms_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe EntityQuery __ProcessDirtyRooms_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoomRoofUpdateSystem.NativeFieldInfoPtr___ProcessDirtyRooms_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoomRoofUpdateSystem.NativeFieldInfoPtr___ProcessDirtyRooms_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe EntityQuery __ProcessDirtyRooms_LambdaJob2_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoomRoofUpdateSystem.NativeFieldInfoPtr___ProcessDirtyRooms_LambdaJob2_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoomRoofUpdateSystem.NativeFieldInfoPtr___ProcessDirtyRooms_LambdaJob2_entityQuery)) = value;
      }
    }

    public unsafe EntityQuery __ProcessAllRooms_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoomRoofUpdateSystem.NativeFieldInfoPtr___ProcessAllRooms_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RoomRoofUpdateSystem.NativeFieldInfoPtr___ProcessAllRooms_LambdaJob0_entityQuery)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RoomRoofKey
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FloorEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_RoomOwnerEntity;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RoomRoofKey_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      [FieldOffset(0)]
      public Entity FloorEntity;
      [FieldOffset(8)]
      public Entity RoomOwnerEntity;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197992, XrefRangeEnd = 1197993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(RoomRoofUpdateSystem.RoomRoofKey other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.RoomRoofKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RoomRoofKey_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1197993, XrefRangeEnd = 1197996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.RoomRoofKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.RoomRoofKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static RoomRoofKey()
      {
        Il2CppClassPointerStore<RoomRoofUpdateSystem.RoomRoofKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, nameof (RoomRoofKey));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomRoofUpdateSystem.RoomRoofKey>.NativeClassPtr);
        RoomRoofUpdateSystem.RoomRoofKey.NativeFieldInfoPtr_FloorEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.RoomRoofKey>.NativeClassPtr, nameof (FloorEntity));
        RoomRoofUpdateSystem.RoomRoofKey.NativeFieldInfoPtr_RoomOwnerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.RoomRoofKey>.NativeClassPtr, nameof (RoomOwnerEntity));
        RoomRoofUpdateSystem.RoomRoofKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RoomRoofKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.RoomRoofKey>.NativeClassPtr, 100664202);
        RoomRoofUpdateSystem.RoomRoofKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.RoomRoofKey>.NativeClassPtr, 100664203);
        RoomRoofUpdateSystem.RoomRoofKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.RoomRoofKey>.NativeClassPtr, 100664204);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomRoofUpdateSystem.RoomRoofKey>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RoomRoofValue
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CurrentRoof;
      private static readonly System.IntPtr NativeFieldInfoPtr_RespawnedRoof;
      private static readonly System.IntPtr NativeFieldInfoPtr_ShouldHaveRoof;
      [FieldOffset(0)]
      public Entity CurrentRoof;
      [FieldOffset(8)]
      public bool RespawnedRoof;
      [FieldOffset(9)]
      public bool ShouldHaveRoof;

      static RoomRoofValue()
      {
        Il2CppClassPointerStore<RoomRoofUpdateSystem.RoomRoofValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, nameof (RoomRoofValue));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomRoofUpdateSystem.RoomRoofValue>.NativeClassPtr);
        RoomRoofUpdateSystem.RoomRoofValue.NativeFieldInfoPtr_CurrentRoof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.RoomRoofValue>.NativeClassPtr, nameof (CurrentRoof));
        RoomRoofUpdateSystem.RoomRoofValue.NativeFieldInfoPtr_RespawnedRoof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.RoomRoofValue>.NativeClassPtr, nameof (RespawnedRoof));
        RoomRoofUpdateSystem.RoomRoofValue.NativeFieldInfoPtr_ShouldHaveRoof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.RoomRoofValue>.NativeClassPtr, nameof (ShouldHaveRoof));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomRoofUpdateSystem.RoomRoofValue>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct UpdateRoofsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DestroyCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_RoofCategoryEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_RoomsToProcess;
      private static readonly System.IntPtr NativeFieldInfoPtr_RoofStates;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRoomConnection;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetWallRoofOrnament;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleRoofOrnaments;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRoofInstanceTypeId;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetDestroyTag;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleFloor;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleRoof;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleStairs;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetPrefabGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRoofTileVariations;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRoofRootBlobElements;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetFloors;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRoom;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleFloorRoof;
      private static readonly System.IntPtr NativeFieldInfoPtr_BlockCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_RequireWalls;
      private static readonly System.IntPtr NativeFieldInfoPtr_Random;
      private static readonly System.IntPtr NativeFieldInfoPtr_LinnCastleRoofs;
      private static readonly System.IntPtr NativeFieldInfoPtr_FloodFillMarker;
      private static readonly System.IntPtr NativeFieldInfoPtr_GenerateMarker;
      private static readonly System.IntPtr NativeFieldInfoPtr_DebuggingEnabled;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_DrawFloodAsGizmos_Private_Void_NativeList_1_StructureBlock_StructureBlock_LocalAreaContext_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_DebugSquareGizmo_Private_Static_Void_StructureBlock_LocalAreaContext_Color_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_DebugSquareGizmo_Private_Static_Void_CastleBlock_Color_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RespawnRoofs_Private_Void_NativeList_1_RoofData_byref_LocalAreaContext_NativeArray_1_StructureFloorData_RoofCategoryType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TrySpawnOrnament_Private_Entity_PrefabGUID_float3_CardinalDirection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompileStructureData_Private_Void_Entity_NativeHashSet_1_Entity_NativeList_1_StructureFloorData_byref_CastleBlock_byref_CastleBlock_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IsFloor_Private_Static_Boolean_ComponentDataFromEntity_1_CastleStairs_byref_CastleFloorBlockCollection_CastleBlock_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetOrnament_Private_Void_Entity_RoofCategoryOrnamentCustomization_Boolean_byref_RoofCategoryOrnamentCustomization_byref_DirData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_DestroyRoof_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_FloodFill_Private_Void_NativeArray_1_RoofCategoryType_NativeList_1_StructureBlock_StructureBlock_LocalAreaContext_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CalculateRoofsToSpawn_Private_Void_byref_LocalAreaContext_NativeArray_1_Boolean_byref_LocalAreaContext_NativeArray_1_StructureFloorData_byref_DynamicBuffer_1_RoofRootBlobElement_DynamicBuffer_1_RoofTileVariations_NativeList_1_RoofData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CheckEdgeHasTallWall_Private_Void_byref_Boolean_CastleWallBlock_NativeHashMap_2_CastleWallBlock_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CheckIfCornerTall_Private_Void_byref_Boolean_CastleBlock_byref_LocalAreaContext_NativeArray_1_Boolean_NativeHashMap_2_CastleWallBlock_Boolean_NativeHashMap_2_CastleBlock_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_float3_int3_0;
      [FieldOffset(0)]
      public EntityCommandBuffer DestroyCommandBuffer;
      [FieldOffset(16)]
      public EntityCommandBuffer SpawnCommandBuffer;
      [FieldOffset(32)]
      public PrefabLookupMap PrefabLookupMap;
      [FieldOffset(80)]
      public NativeHashMap<int, Entity> RoofCategoryEntities;
      [FieldOffset(96)]
      public NativeList<Entity> RoomsToProcess;
      [FieldOffset(112)]
      public NativeHashMap<RoomRoofUpdateSystem.RoomRoofKey, RoomRoofUpdateSystem.RoomRoofValue> RoofStates;
      [FieldOffset(128)]
      public ComponentDataFromEntity<CastleRoomConnection> GetRoomConnection;
      [FieldOffset(160)]
      public ComponentDataFromEntity<WallRoofOrnament> GetWallRoofOrnament;
      [FieldOffset(192)]
      public ComponentDataFromEntity<CastleRoofOrnaments> GetCastleRoofOrnaments;
      [FieldOffset(224)]
      public ComponentDataFromEntity<RoofInstanceTypeId> GetRoofInstanceTypeId;
      [FieldOffset(256)]
      public ComponentDataFromEntity<Translation> GetTranslation;
      [FieldOffset(288)]
      public ComponentDataFromEntity<DestroyTag> GetDestroyTag;
      [FieldOffset(320)]
      public ComponentDataFromEntity<CastleFloor> GetCastleFloor;
      [FieldOffset(352)]
      public ComponentDataFromEntity<CastleRoof> GetCastleRoof;
      [FieldOffset(384)]
      public ComponentDataFromEntity<CastleStairs> GetCastleStairs;
      [FieldOffset(416)]
      public ComponentDataFromEntity<TilePosition> GetTilePosition;
      [FieldOffset(448)]
      public ComponentDataFromEntity<PrefabGUID> GetPrefabGUID;
      [FieldOffset(480)]
      public BufferFromEntity<RoofTileVariations> GetRoofTileVariations;
      [FieldOffset(520)]
      public BufferFromEntity<RoofRootBlobElement> GetRoofRootBlobElements;
      [FieldOffset(560)]
      public BufferFromEntity<CastleRoomFloorsBuffer> GetFloors;
      [FieldOffset(600)]
      public ComponentDataFromEntity<CastleRoom> GetRoom;
      [FieldOffset(632)]
      public ComponentDataFromEntity<CastleFloorRoof> GetCastleFloorRoof;
      [FieldOffset(664)]
      public CastleBlockCollection BlockCollection;
      [FieldOffset(712)]
      public bool RequireWalls;
      [FieldOffset(716)]
      public Unity.Mathematics.Random Random;
      [FieldOffset(720)]
      public bool LinnCastleRoofs;
      [FieldOffset(728)]
      public ProfilerMarker FloodFillMarker;
      [FieldOffset(736)]
      public ProfilerMarker GenerateMarker;
      [FieldOffset(744)]
      public bool DebuggingEnabled;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198040, XrefRangeEnd = 1198169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void DrawFloodAsGizmos(
        NativeList<RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock> roofTiles,
        RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock originStructureTile,
        RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext structureArea,
        float indexFraction)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &roofTiles;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &originStructureTile;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &structureArea;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &indexFraction;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_DrawFloodAsGizmos_Private_Void_NativeList_1_StructureBlock_StructureBlock_LocalAreaContext_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1198171, RefRangeEnd = 1198172, XrefRangeStart = 1198169, XrefRangeEnd = 1198171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void DebugSquareGizmo(
        RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock structureBlock,
        RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext structureArea,
        Color color,
        int style)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &structureBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &structureArea;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &style;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_DebugSquareGizmo_Private_Static_Void_StructureBlock_LocalAreaContext_Color_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1198182, RefRangeEnd = 1198183, XrefRangeStart = 1198172, XrefRangeEnd = 1198182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void DebugSquareGizmo(CastleBlock block, Color color, int style)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &block;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &style;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_DebugSquareGizmo_Private_Static_Void_CastleBlock_Color_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1198289, RefRangeEnd = 1198290, XrefRangeStart = 1198183, XrefRangeEnd = 1198289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void RespawnRoofs(
        NativeList<RoomRoofUpdateSystem.UpdateRoofsJob.RoofData> resultRoofsInAffectedFloors,
        [In] ref RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext structureArea,
        NativeArray<RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData> floorDataArray,
        RoofCategoryType category)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &resultRoofsInAffectedFloors;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref structureArea;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &floorDataArray;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &category;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_RespawnRoofs_Private_Void_NativeList_1_RoofData_byref_LocalAreaContext_NativeArray_1_StructureFloorData_RoofCategoryType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1198307, RefRangeEnd = 1198311, XrefRangeStart = 1198290, XrefRangeEnd = 1198307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Entity TrySpawnOrnament(
        PrefabGUID ornamentPrefabGUID,
        float3 wallPos,
        CardinalDirection dir)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &ornamentPrefabGUID;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &wallPos;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dir;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_TrySpawnOrnament_Private_Entity_PrefabGUID_float3_CardinalDirection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1198427, RefRangeEnd = 1198428, XrefRangeStart = 1198311, XrefRangeEnd = 1198427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CompileStructureData(
        Entity rootRoom,
        NativeHashSet<Entity> processedRooms,
        NativeList<RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData> floorDatas,
        out CastleBlock minFloorBlock,
        out CastleBlock maxFloorBlock)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &rootRoom;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &processedRooms;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &floorDatas;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref minFloorBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref maxFloorBlock;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_CompileStructureData_Private_Void_Entity_NativeHashSet_1_Entity_NativeList_1_StructureFloorData_byref_CastleBlock_byref_CastleBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(5)]
      [CachedScanResults(RefRangeStart = 1198433, RefRangeEnd = 1198438, XrefRangeStart = 1198428, XrefRangeEnd = 1198433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool IsFloor(
        ComponentDataFromEntity<CastleStairs> castleStairsFromEntity,
        [In] ref CastleFloorBlockCollection floorCollection,
        CastleBlock block)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &castleStairsFromEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref floorCollection;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &block;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_IsFloor_Private_Static_Boolean_ComponentDataFromEntity_1_CastleStairs_byref_CastleFloorBlockCollection_CastleBlock_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1198451, RefRangeEnd = 1198455, XrefRangeStart = 1198438, XrefRangeEnd = 1198451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void GetOrnament(
        Entity wallEntity,
        RoofCategoryOrnamentCustomization direction,
        bool wallPosHasFloorAbove,
        ref RoofCategoryOrnamentCustomization roofCategory,
        ref RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData.DirData dirData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &wallEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &wallPosHasFloorAbove;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref roofCategory;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref dirData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_GetOrnament_Private_Void_Entity_RoofCategoryOrnamentCustomization_Boolean_byref_RoofCategoryOrnamentCustomization_byref_DirData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1198498, RefRangeEnd = 1198499, XrefRangeStart = 1198455, XrefRangeEnd = 1198498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void DestroyRoof(Entity roofFloor)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &roofFloor;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_DestroyRoof_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1198538, RefRangeEnd = 1198539, XrefRangeStart = 1198499, XrefRangeEnd = 1198538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void FloodFill(
        NativeArray<RoofCategoryType> categories,
        NativeList<RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock> points,
        RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock origin,
        RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext structureArea)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &categories;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &points;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &origin;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &structureArea;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_FloodFill_Private_Void_NativeArray_1_RoofCategoryType_NativeList_1_StructureBlock_StructureBlock_LocalAreaContext_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1198639, RefRangeEnd = 1198640, XrefRangeStart = 1198539, XrefRangeEnd = 1198639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CalculateRoofsToSpawn(
        [In] ref RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext roofArea,
        NativeArray<bool> floorsForRoom,
        [In] ref RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext structureArea,
        NativeArray<RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData> structureFloorArray,
        [In] ref DynamicBuffer<RoofRootBlobElement> rootBlobs,
        DynamicBuffer<RoofTileVariations> tileVariations,
        NativeList<RoomRoofUpdateSystem.UpdateRoofsJob.RoofData> out_RoofsToSpawn)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[7];
        numPtr[0] = (System.IntPtr) ref roofArea;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &floorsForRoom;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref structureArea;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &structureFloorArray;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref rootBlobs;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &tileVariations;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &out_RoofsToSpawn;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_CalculateRoofsToSpawn_Private_Void_byref_LocalAreaContext_NativeArray_1_Boolean_byref_LocalAreaContext_NativeArray_1_StructureFloorData_byref_DynamicBuffer_1_RoofRootBlobElement_DynamicBuffer_1_RoofTileVariations_NativeList_1_RoofData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1198649, RefRangeEnd = 1198653, XrefRangeStart = 1198640, XrefRangeEnd = 1198649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CheckEdgeHasTallWall(
        ref bool currentState,
        CastleWallBlock edgeBlock,
        NativeHashMap<CastleWallBlock, bool> floorEdgeTallCollection)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref currentState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &edgeBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &floorEdgeTallCollection;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_CheckEdgeHasTallWall_Private_Void_byref_Boolean_CastleWallBlock_NativeHashMap_2_CastleWallBlock_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1198670, RefRangeEnd = 1198674, XrefRangeStart = 1198653, XrefRangeEnd = 1198670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CheckIfCornerTall(
        ref bool currentCornerState,
        CastleBlock pillarBlock,
        [In] ref RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext roofArea,
        NativeArray<bool> floorsForRoom,
        NativeHashMap<CastleWallBlock, bool> wallBlockIsTall,
        NativeHashMap<CastleBlock, bool> pillarBlockIsTall)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) ref currentCornerState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pillarBlock;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref roofArea;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &floorsForRoom;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &wallBlockIsTall;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &pillarBlockIsTall;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_CheckIfCornerTall_Private_Void_byref_Boolean_CastleBlock_byref_LocalAreaContext_NativeArray_1_Boolean_NativeHashMap_2_CastleWallBlock_Boolean_NativeHashMap_2_CastleBlock_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1198676, RefRangeEnd = 1198677, XrefRangeStart = 1198674, XrefRangeEnd = 1198676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe float3 Method_Internal_Static_float3_int3_0(int3 blockPos)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &blockPos;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_Method_Internal_Static_float3_int3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float3*) IL2CPP.il2cpp_object_unbox(num);
      }

      static UpdateRoofsJob()
      {
        Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, nameof (UpdateRoofsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr);
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_DestroyCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (DestroyCommandBuffer));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_SpawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (SpawnCommandBuffer));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_PrefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (PrefabLookupMap));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_RoofCategoryEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (RoofCategoryEntities));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_RoomsToProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (RoomsToProcess));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_RoofStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (RoofStates));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_GetRoomConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (GetRoomConnection));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_GetWallRoofOrnament = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (GetWallRoofOrnament));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_GetCastleRoofOrnaments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (GetCastleRoofOrnaments));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_GetRoofInstanceTypeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (GetRoofInstanceTypeId));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_GetTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (GetTranslation));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_GetDestroyTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (GetDestroyTag));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_GetCastleFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (GetCastleFloor));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_GetCastleRoof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (GetCastleRoof));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_GetCastleStairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (GetCastleStairs));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_GetTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (GetTilePosition));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_GetPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (GetPrefabGUID));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_GetRoofTileVariations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (GetRoofTileVariations));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_GetRoofRootBlobElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (GetRoofRootBlobElements));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_GetFloors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (GetFloors));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_GetRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (GetRoom));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_GetCastleFloorRoof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (GetCastleFloorRoof));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_BlockCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (BlockCollection));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_RequireWalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (RequireWalls));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (Random));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_LinnCastleRoofs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (LinnCastleRoofs));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_FloodFillMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (FloodFillMarker));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_GenerateMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (GenerateMarker));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeFieldInfoPtr_DebuggingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (DebuggingEnabled));
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, 100664205);
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_DrawFloodAsGizmos_Private_Void_NativeList_1_StructureBlock_StructureBlock_LocalAreaContext_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, 100664206);
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_DebugSquareGizmo_Private_Static_Void_StructureBlock_LocalAreaContext_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, 100664207);
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_DebugSquareGizmo_Private_Static_Void_CastleBlock_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, 100664208);
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_RespawnRoofs_Private_Void_NativeList_1_RoofData_byref_LocalAreaContext_NativeArray_1_StructureFloorData_RoofCategoryType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, 100664209);
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_TrySpawnOrnament_Private_Entity_PrefabGUID_float3_CardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, 100664210);
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_CompileStructureData_Private_Void_Entity_NativeHashSet_1_Entity_NativeList_1_StructureFloorData_byref_CastleBlock_byref_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, 100664211);
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_IsFloor_Private_Static_Boolean_ComponentDataFromEntity_1_CastleStairs_byref_CastleFloorBlockCollection_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, 100664212);
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_GetOrnament_Private_Void_Entity_RoofCategoryOrnamentCustomization_Boolean_byref_RoofCategoryOrnamentCustomization_byref_DirData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, 100664213);
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_DestroyRoof_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, 100664214);
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_FloodFill_Private_Void_NativeArray_1_RoofCategoryType_NativeList_1_StructureBlock_StructureBlock_LocalAreaContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, 100664215);
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_CalculateRoofsToSpawn_Private_Void_byref_LocalAreaContext_NativeArray_1_Boolean_byref_LocalAreaContext_NativeArray_1_StructureFloorData_byref_DynamicBuffer_1_RoofRootBlobElement_DynamicBuffer_1_RoofTileVariations_NativeList_1_RoofData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, 100664216);
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_CheckEdgeHasTallWall_Private_Void_byref_Boolean_CastleWallBlock_NativeHashMap_2_CastleWallBlock_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, 100664217);
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_CheckIfCornerTall_Private_Void_byref_Boolean_CastleBlock_byref_LocalAreaContext_NativeArray_1_Boolean_NativeHashMap_2_CastleWallBlock_Boolean_NativeHashMap_2_CastleBlock_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, 100664218);
        RoomRoofUpdateSystem.UpdateRoofsJob.NativeMethodInfoPtr_Method_Internal_Static_float3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, 100664219);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct StructureBlock
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_LocalBlock;
        private static readonly System.IntPtr NativeMethodInfoPtr_FromWorldSpace_Public_Static_StructureBlock_CastleBlock_byref_LocalAreaContext_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_FromRoofSpace_Public_Static_StructureBlock_int3_byref_LocalAreaContext_byref_LocalAreaContext_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetStructureBlockIndex_Public_Int32_byref_LocalAreaContext_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_ToWorldBlock_Public_CastleBlock_byref_LocalAreaContext_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StructureBlock_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
        [FieldOffset(0)]
        public int3 LocalBlock;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1197997, RefRangeEnd = 1197998, XrefRangeStart = 1197996, XrefRangeEnd = 1197997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock FromWorldSpace(
          CastleBlock block,
          [In] ref RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext structureArea)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) &block;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref structureArea;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock.NativeMethodInfoPtr_FromWorldSpace_Public_Static_StructureBlock_CastleBlock_byref_LocalAreaContext_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 1198000, RefRangeEnd = 1198002, XrefRangeStart = 1197998, XrefRangeEnd = 1198000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock FromRoofSpace(
          int3 roofSpaceBlock,
          [In] ref RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext roofArea,
          [In] ref RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext structureArea)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) &roofSpaceBlock;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref roofArea;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref structureArea;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock.NativeMethodInfoPtr_FromRoofSpace_Public_Static_StructureBlock_int3_byref_LocalAreaContext_byref_LocalAreaContext_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(7)]
        [CachedScanResults(RefRangeStart = 1198002, RefRangeEnd = 1198009, XrefRangeStart = 1198002, XrefRangeEnd = 1198002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe int GetStructureBlockIndex(
          [In] ref RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext structureArea)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref structureArea;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock.NativeMethodInfoPtr_GetStructureBlockIndex_Public_Int32_byref_LocalAreaContext_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(29)]
        [CachedScanResults(RefRangeStart = 1126600, RefRangeEnd = 1126629, XrefRangeStart = 1126600, XrefRangeEnd = 1126629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe CastleBlock ToWorldBlock(
          [In] ref RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext structureArea)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref structureArea;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock.NativeMethodInfoPtr_ToWorldBlock_Public_CastleBlock_byref_LocalAreaContext_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        public virtual unsafe bool Equals(
          RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock other)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) &other;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StructureBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198009, XrefRangeEnd = 1198012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe bool Equals(Il2CppSystem.Object obj)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 254813, RefRangeEnd = 254814, XrefRangeStart = 254813, XrefRangeEnd = 254814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public override unsafe int GetHashCode()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }

        static StructureBlock()
        {
          Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (StructureBlock));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock>.NativeClassPtr);
          RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock.NativeFieldInfoPtr_LocalBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock>.NativeClassPtr, nameof (LocalBlock));
          RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock.NativeMethodInfoPtr_FromWorldSpace_Public_Static_StructureBlock_CastleBlock_byref_LocalAreaContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock>.NativeClassPtr, 100664220);
          RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock.NativeMethodInfoPtr_FromRoofSpace_Public_Static_StructureBlock_int3_byref_LocalAreaContext_byref_LocalAreaContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock>.NativeClassPtr, 100664221);
          RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock.NativeMethodInfoPtr_GetStructureBlockIndex_Public_Int32_byref_LocalAreaContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock>.NativeClassPtr, 100664222);
          RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock.NativeMethodInfoPtr_ToWorldBlock_Public_CastleBlock_byref_LocalAreaContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock>.NativeClassPtr, 100664223);
          RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StructureBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock>.NativeClassPtr, 100664224);
          RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock>.NativeClassPtr, 100664225);
          RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock>.NativeClassPtr, 100664226);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct StructureFloorData
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_StructureTileArrayIndex;
        private static readonly System.IntPtr NativeFieldInfoPtr_StructureBlock;
        private static readonly System.IntPtr NativeFieldInfoPtr_FloorBlock;
        private static readonly System.IntPtr NativeFieldInfoPtr_FloorEntity;
        private static readonly System.IntPtr NativeFieldInfoPtr_RoomEntity;
        private static readonly System.IntPtr NativeFieldInfoPtr_RoofCategoryType;
        private static readonly System.IntPtr NativeFieldInfoPtr_RoofOrnamentation;
        private static readonly System.IntPtr NativeFieldInfoPtr_South;
        private static readonly System.IntPtr NativeFieldInfoPtr_North;
        private static readonly System.IntPtr NativeFieldInfoPtr_West;
        private static readonly System.IntPtr NativeFieldInfoPtr_East;
        [FieldOffset(0)]
        public int StructureTileArrayIndex;
        [FieldOffset(4)]
        public RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock StructureBlock;
        [FieldOffset(16)]
        public CastleBlock FloorBlock;
        [FieldOffset(28)]
        public Entity FloorEntity;
        [FieldOffset(36)]
        public Entity RoomEntity;
        [FieldOffset(44)]
        public RoofCategoryType RoofCategoryType;
        [FieldOffset(45)]
        public RoofCategoryOrnamentCustomization RoofOrnamentation;
        [FieldOffset(48)]
        public RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData.DirData South;
        [FieldOffset(64)]
        public RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData.DirData North;
        [FieldOffset(80)]
        public RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData.DirData West;
        [FieldOffset(96)]
        public RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData.DirData East;

        static StructureFloorData()
        {
          Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (StructureFloorData));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData>.NativeClassPtr);
          RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData.NativeFieldInfoPtr_StructureTileArrayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData>.NativeClassPtr, nameof (StructureTileArrayIndex));
          RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData.NativeFieldInfoPtr_StructureBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData>.NativeClassPtr, nameof (StructureBlock));
          RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData.NativeFieldInfoPtr_FloorBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData>.NativeClassPtr, nameof (FloorBlock));
          RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData.NativeFieldInfoPtr_FloorEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData>.NativeClassPtr, nameof (FloorEntity));
          RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData.NativeFieldInfoPtr_RoomEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData>.NativeClassPtr, nameof (RoomEntity));
          RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData.NativeFieldInfoPtr_RoofCategoryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData>.NativeClassPtr, nameof (RoofCategoryType));
          RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData.NativeFieldInfoPtr_RoofOrnamentation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData>.NativeClassPtr, nameof (RoofOrnamentation));
          RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData.NativeFieldInfoPtr_South = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData>.NativeClassPtr, nameof (South));
          RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData.NativeFieldInfoPtr_North = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData>.NativeClassPtr, nameof (North));
          RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData.NativeFieldInfoPtr_West = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData>.NativeClassPtr, nameof (West));
          RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData.NativeFieldInfoPtr_East = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData>.NativeClassPtr, nameof (East));
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct DirData
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_WallPos;
          private static readonly System.IntPtr NativeFieldInfoPtr_OrnamentPrefab;
          [FieldOffset(0)]
          public float3 WallPos;
          [FieldOffset(12)]
          public PrefabGUID OrnamentPrefab;

          static DirData()
          {
            Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData.DirData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData>.NativeClassPtr, nameof (DirData));
            IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData.DirData>.NativeClassPtr);
            RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData.DirData.NativeFieldInfoPtr_WallPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData.DirData>.NativeClassPtr, nameof (WallPos));
            RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData.DirData.NativeFieldInfoPtr_OrnamentPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData.DirData>.NativeClassPtr, nameof (OrnamentPrefab));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.StructureFloorData.DirData>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LocalAreaContext
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_MinBlock;
        private static readonly System.IntPtr NativeFieldInfoPtr_AreaSize;
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CastleBlock_CastleBlock_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Private_Boolean_int3_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Get3DTileCount_Public_Int32_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Get2DTileCount_Public_Int32_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalBlockIndex_Public_Int32_int3_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalBlockIndex_Public_Int32_Int32_Int32_Int32_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_TryGetLocalBlock_Public_Boolean_CastleBlock_byref_StructureBlock_0;
        [FieldOffset(0)]
        public readonly CastleBlock MinBlock;
        [FieldOffset(12)]
        public readonly int3 AreaSize;

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 1198013, RefRangeEnd = 1198015, XrefRangeStart = 1198012, XrefRangeEnd = 1198013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe LocalAreaContext(CastleBlock minBlock, CastleBlock maxBlock)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) &minBlock;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxBlock;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext.NativeMethodInfoPtr__ctor_Public_Void_CastleBlock_CastleBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        public unsafe bool Contains(int3 localBlock)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) &localBlock;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext.NativeMethodInfoPtr_Contains_Private_Boolean_int3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(4)]
        [CachedScanResults(RefRangeStart = 1198015, RefRangeEnd = 1198019, XrefRangeStart = 1198015, XrefRangeEnd = 1198015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe int Get3DTileCount()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext.NativeMethodInfoPtr_Get3DTileCount_Public_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1198019, RefRangeEnd = 1198020, XrefRangeStart = 1198019, XrefRangeEnd = 1198019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe int Get2DTileCount()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext.NativeMethodInfoPtr_Get2DTileCount_Public_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 1198020, RefRangeEnd = 1198023, XrefRangeStart = 1198020, XrefRangeEnd = 1198020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe int GetLocalBlockIndex(int3 localBlock)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) &localBlock;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext.NativeMethodInfoPtr_GetLocalBlockIndex_Public_Int32_int3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(15)]
        [CachedScanResults(RefRangeStart = 1198023, RefRangeEnd = 1198038, XrefRangeStart = 1198023, XrefRangeEnd = 1198023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe int GetLocalBlockIndex(int localX, int localY, int localZ)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) &localX;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localY;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &localZ;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext.NativeMethodInfoPtr_GetLocalBlockIndex_Public_Int32_Int32_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 1198038, RefRangeEnd = 1198040, XrefRangeStart = 1198038, XrefRangeEnd = 1198038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe bool TryGetLocalBlock(
          CastleBlock floorBlock,
          out RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock structureBlock)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) &floorBlock;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref structureBlock;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext.NativeMethodInfoPtr_TryGetLocalBlock_Public_Boolean_CastleBlock_byref_StructureBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LocalAreaContext()
        {
          Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (LocalAreaContext));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext>.NativeClassPtr);
          RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext.NativeFieldInfoPtr_MinBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext>.NativeClassPtr, nameof (MinBlock));
          RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext.NativeFieldInfoPtr_AreaSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext>.NativeClassPtr, nameof (AreaSize));
          RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext.NativeMethodInfoPtr__ctor_Public_Void_CastleBlock_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext>.NativeClassPtr, 100664227);
          RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext.NativeMethodInfoPtr_Contains_Private_Boolean_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext>.NativeClassPtr, 100664228);
          RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext.NativeMethodInfoPtr_Get3DTileCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext>.NativeClassPtr, 100664229);
          RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext.NativeMethodInfoPtr_Get2DTileCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext>.NativeClassPtr, 100664230);
          RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext.NativeMethodInfoPtr_GetLocalBlockIndex_Public_Int32_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext>.NativeClassPtr, 100664231);
          RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext.NativeMethodInfoPtr_GetLocalBlockIndex_Public_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext>.NativeClassPtr, 100664232);
          RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext.NativeMethodInfoPtr_TryGetLocalBlock_Public_Boolean_CastleBlock_byref_StructureBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext>.NativeClassPtr, 100664233);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.LocalAreaContext>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct RoofData
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_FloorBlock;
        private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
        private static readonly System.IntPtr NativeFieldInfoPtr_PrefabRotation;
        private static readonly System.IntPtr NativeFieldInfoPtr_RoofTypeId;
        private static readonly System.IntPtr NativeFieldInfoPtr_NorthWallPos;
        private static readonly System.IntPtr NativeFieldInfoPtr_SouthWallPos;
        private static readonly System.IntPtr NativeFieldInfoPtr_WestWallPos;
        private static readonly System.IntPtr NativeFieldInfoPtr_EastWallPos;
        [FieldOffset(0)]
        public RoomRoofUpdateSystem.UpdateRoofsJob.StructureBlock FloorBlock;
        [FieldOffset(12)]
        public PrefabGUID PrefabGUID;
        [FieldOffset(16)]
        public OrthogonalRotation PrefabRotation;
        [FieldOffset(20)]
        public RoofInstanceTypeId RoofTypeId;
        [FieldOffset(48)]
        public float3 NorthWallPos;
        [FieldOffset(60)]
        public float3 SouthWallPos;
        [FieldOffset(72)]
        public float3 WestWallPos;
        [FieldOffset(84)]
        public float3 EastWallPos;

        static RoofData()
        {
          Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.RoofData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob>.NativeClassPtr, nameof (RoofData));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.RoofData>.NativeClassPtr);
          RoomRoofUpdateSystem.UpdateRoofsJob.RoofData.NativeFieldInfoPtr_FloorBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.RoofData>.NativeClassPtr, nameof (FloorBlock));
          RoomRoofUpdateSystem.UpdateRoofsJob.RoofData.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.RoofData>.NativeClassPtr, nameof (PrefabGUID));
          RoomRoofUpdateSystem.UpdateRoofsJob.RoofData.NativeFieldInfoPtr_PrefabRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.RoofData>.NativeClassPtr, nameof (PrefabRotation));
          RoomRoofUpdateSystem.UpdateRoofsJob.RoofData.NativeFieldInfoPtr_RoofTypeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.RoofData>.NativeClassPtr, nameof (RoofTypeId));
          RoomRoofUpdateSystem.UpdateRoofsJob.RoofData.NativeFieldInfoPtr_NorthWallPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.RoofData>.NativeClassPtr, nameof (NorthWallPos));
          RoomRoofUpdateSystem.UpdateRoofsJob.RoofData.NativeFieldInfoPtr_SouthWallPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.RoofData>.NativeClassPtr, nameof (SouthWallPos));
          RoomRoofUpdateSystem.UpdateRoofsJob.RoofData.NativeFieldInfoPtr_WestWallPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.RoofData>.NativeClassPtr, nameof (WestWallPos));
          RoomRoofUpdateSystem.UpdateRoofsJob.RoofData.NativeFieldInfoPtr_EastWallPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.RoofData>.NativeClassPtr, nameof (EastWallPos));
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomRoofUpdateSystem.UpdateRoofsJob.RoofData>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.RoomRoofUpdateSystem/<>c__DisplayClass11_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass11_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_roomsToProcess;
      private static readonly System.IntPtr NativeFieldInfoPtr_roomConnectionromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_castleRoomFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_castleBlockCollection;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ProcessDirtyRooms_b__0_Internal_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ProcessDirtyRooms_b__1_Internal_Void_byref_TilePosition_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ProcessDirtyRooms_b__2_Internal_Void_byref_CastleRoomEvent_0;
      [FieldOffset(0)]
      public NativeList<Entity> roomsToProcess;
      [FieldOffset(16)]
      public ComponentDataFromEntity<CastleRoomConnection> roomConnectionromEntity;
      [FieldOffset(48)]
      public ComponentDataFromEntity<CastleRoom> castleRoomFromEntity;
      [FieldOffset(80)]
      public CastleBlockCollection castleBlockCollection;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass11_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ProcessDirtyRooms_b__0(Entity roomEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &roomEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__ProcessDirtyRooms_b__0_Internal_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ProcessDirtyRooms_b__1([In] ref TilePosition tilePosition)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref tilePosition;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__ProcessDirtyRooms_b__1_Internal_Void_byref_TilePosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ProcessDirtyRooms_b__2([In] ref CastleRoomEvent castleRoomEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref castleRoomEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__ProcessDirtyRooms_b__2_Internal_Void_byref_CastleRoomEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass11_0()
      {
        Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, "<>c__DisplayClass11_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass11_0>.NativeClassPtr);
        RoomRoofUpdateSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_roomsToProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (roomsToProcess));
        RoomRoofUpdateSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_roomConnectionromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (roomConnectionromEntity));
        RoomRoofUpdateSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_castleRoomFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (castleRoomFromEntity));
        RoomRoofUpdateSystem.__c__DisplayClass11_0.NativeFieldInfoPtr_castleBlockCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass11_0>.NativeClassPtr, nameof (castleBlockCollection));
        RoomRoofUpdateSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass11_0>.NativeClassPtr, 100664234);
        RoomRoofUpdateSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__ProcessDirtyRooms_b__0_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass11_0>.NativeClassPtr, 100664235);
        RoomRoofUpdateSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__ProcessDirtyRooms_b__1_Internal_Void_byref_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass11_0>.NativeClassPtr, 100664236);
        RoomRoofUpdateSystem.__c__DisplayClass11_0.NativeMethodInfoPtr__ProcessDirtyRooms_b__2_Internal_Void_byref_CastleRoomEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass11_0>.NativeClassPtr, 100664237);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass11_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.RoomRoofUpdateSystem/<>c__DisplayClass13_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass13_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_roomsToProcess;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ProcessAllRooms_b__0_Internal_Void_Entity_0;
      [FieldOffset(0)]
      public NativeList<Entity> roomsToProcess;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass13_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ProcessAllRooms_b__0(Entity roomEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &roomEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ProcessAllRooms_b__0_Internal_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass13_0()
      {
        Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, "<>c__DisplayClass13_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass13_0>.NativeClassPtr);
        RoomRoofUpdateSystem.__c__DisplayClass13_0.NativeFieldInfoPtr_roomsToProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass13_0>.NativeClassPtr, nameof (roomsToProcess));
        RoomRoofUpdateSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass13_0>.NativeClassPtr, 100664238);
        RoomRoofUpdateSystem.__c__DisplayClass13_0.NativeMethodInfoPtr__ProcessAllRooms_b__0_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass13_0>.NativeClassPtr, 100664239);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass13_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.RoomRoofUpdateSystem/ProjectM.CastleBuilding.<>c__DisplayClass_ProcessDirtyRooms_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ProcessDirtyRooms_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_roomsToProcess;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_byref___c__DisplayClass11_0_0;
      [FieldOffset(0)]
      public NativeList<Entity> roomsToProcess;
      [FieldOffset(16)]
      public RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(24)]
      public unsafe RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198677, XrefRangeEnd = 1198680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity roomEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &roomEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref RoomRoofUpdateSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198680, XrefRangeEnd = 1198682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1198685, RefRangeEnd = 1198686, XrefRangeStart = 1198682, XrefRangeEnd = 1198685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10)]
      [CachedScanResults(RefRangeStart = 1035887, RefRangeEnd = 1035897, XrefRangeStart = 1035887, XrefRangeEnd = 1035897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        RoomRoofUpdateSystem componentSystem,
        ref RoomRoofUpdateSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ProcessDirtyRooms_LambdaJob0()
      {
        Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, "<>c__DisplayClass_ProcessDirtyRooms_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0>.NativeClassPtr);
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.NativeFieldInfoPtr_roomsToProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0>.NativeClassPtr, nameof (roomsToProcess));
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0>.NativeClassPtr, 100664240);
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0>.NativeClassPtr, 100664241);
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0>.NativeClassPtr, 100664242);
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0>.NativeClassPtr, 100664243);
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0>.NativeClassPtr, 100664244);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_roomEntity;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_roomEntity;

        [CallerCount(25)]
        [CachedScanResults(RefRangeStart = 742675, RefRangeEnd = 742700, XrefRangeStart = 742675, XrefRangeEnd = 742700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(RoomRoofUpdateSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(25)]
        [CachedScanResults(RefRangeStart = 742701, RefRangeEnd = 742726, XrefRangeStart = 742701, XrefRangeEnd = 742726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_roomEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_roomEntity));
          RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664245);
          RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664246);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_roomEntity;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_roomEntity;

          static Runtimes()
          {
            Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_roomEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_roomEntity));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.RoomRoofUpdateSystem/ProjectM.CastleBuilding.<>c__DisplayClass_ProcessDirtyRooms_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ProcessDirtyRooms_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_roomConnectionromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_castleRoomFromEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_castleBlockCollection;
      private static readonly System.IntPtr NativeFieldInfoPtr_roomsToProcess;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_TilePosition_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_byref___c__DisplayClass11_0_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<CastleRoomConnection> roomConnectionromEntity;
      [FieldOffset(32)]
      public ComponentDataFromEntity<CastleRoom> castleRoomFromEntity;
      [FieldOffset(64)]
      public CastleBlockCollection castleBlockCollection;
      [FieldOffset(112)]
      public NativeList<Entity> roomsToProcess;
      [FieldOffset(128)]
      public RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(160)]
      public unsafe RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1198697, RefRangeEnd = 1198698, XrefRangeStart = 1198694, XrefRangeEnd = 1198697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref TilePosition tilePosition)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref tilePosition;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_TilePosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1198698, RefRangeEnd = 1198699, XrefRangeStart = 1198698, XrefRangeEnd = 1198698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref RoomRoofUpdateSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198699, XrefRangeEnd = 1198701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1198706, RefRangeEnd = 1198707, XrefRangeStart = 1198701, XrefRangeEnd = 1198706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1198709, RefRangeEnd = 1198710, XrefRangeStart = 1198707, XrefRangeEnd = 1198709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        RoomRoofUpdateSystem componentSystem,
        ref RoomRoofUpdateSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ProcessDirtyRooms_LambdaJob1()
      {
        Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, "<>c__DisplayClass_ProcessDirtyRooms_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1>.NativeClassPtr);
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.NativeFieldInfoPtr_roomConnectionromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1>.NativeClassPtr, nameof (roomConnectionromEntity));
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.NativeFieldInfoPtr_castleRoomFromEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1>.NativeClassPtr, nameof (castleRoomFromEntity));
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.NativeFieldInfoPtr_castleBlockCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1>.NativeClassPtr, nameof (castleBlockCollection));
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.NativeFieldInfoPtr_roomsToProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1>.NativeClassPtr, nameof (roomsToProcess));
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1>.NativeClassPtr, 100664247);
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1>.NativeClassPtr, 100664248);
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1>.NativeClassPtr, 100664249);
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1>.NativeClassPtr, 100664250);
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1>.NativeClassPtr, 100664251);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_tilePosition;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<TilePosition> forParameter_tilePosition;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1198689, RefRangeEnd = 1198690, XrefRangeStart = 1198686, XrefRangeEnd = 1198689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(RoomRoofUpdateSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1198693, RefRangeEnd = 1198694, XrefRangeStart = 1198690, XrefRangeEnd = 1198693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_tilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_tilePosition));
          RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100664252);
          RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100664253);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_tilePosition;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<TilePosition>.Runtime runtime_tilePosition;

          static Runtimes()
          {
            Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_tilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_tilePosition));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.RoomRoofUpdateSystem/ProjectM.CastleBuilding.<>c__DisplayClass_ProcessDirtyRooms_LambdaJob2")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ProcessDirtyRooms_LambdaJob2
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_roomsToProcess;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CastleRoomEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_byref___c__DisplayClass11_0_0;
      [FieldOffset(0)]
      public NativeList<Entity> roomsToProcess;
      [FieldOffset(16)]
      public RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(48)]
      public unsafe RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198718, XrefRangeEnd = 1198721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref CastleRoomEvent castleRoomEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref castleRoomEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CastleRoomEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref RoomRoofUpdateSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198721, XrefRangeEnd = 1198723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1198728, RefRangeEnd = 1198729, XrefRangeStart = 1198723, XrefRangeEnd = 1198728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1198731, RefRangeEnd = 1198732, XrefRangeStart = 1198729, XrefRangeEnd = 1198731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        RoomRoofUpdateSystem componentSystem,
        ref RoomRoofUpdateSystem.__c__DisplayClass11_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_byref___c__DisplayClass11_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ProcessDirtyRooms_LambdaJob2()
      {
        Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, "<>c__DisplayClass_ProcessDirtyRooms_LambdaJob2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2>.NativeClassPtr);
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.NativeFieldInfoPtr_roomsToProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2>.NativeClassPtr, nameof (roomsToProcess));
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2>.NativeClassPtr, nameof (_runtimes));
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CastleRoomEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2>.NativeClassPtr, 100664254);
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2>.NativeClassPtr, 100664255);
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2>.NativeClassPtr, 100664256);
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2>.NativeClassPtr, 100664257);
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_byref___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2>.NativeClassPtr, 100664258);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castleRoomEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<CastleRoomEvent> forParameter_castleRoomEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1198713, RefRangeEnd = 1198714, XrefRangeStart = 1198710, XrefRangeEnd = 1198713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(RoomRoofUpdateSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1198717, RefRangeEnd = 1198718, XrefRangeStart = 1198714, XrefRangeEnd = 1198717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castleRoomEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castleRoomEvent));
          RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100664259);
          RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100664260);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castleRoomEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<CastleRoomEvent>.Runtime runtime_castleRoomEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castleRoomEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castleRoomEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessDirtyRooms_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.RoomRoofUpdateSystem/ProjectM.CastleBuilding.<>c__DisplayClass_ProcessAllRooms_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ProcessAllRooms_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_roomsToProcess;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_byref___c__DisplayClass13_0_0;
      [FieldOffset(0)]
      public NativeList<Entity> roomsToProcess;
      [FieldOffset(16)]
      public RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(24)]
      public unsafe RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198732, XrefRangeEnd = 1198735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity roomEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &roomEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref RoomRoofUpdateSystem.__c__DisplayClass13_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1198735, XrefRangeEnd = 1198737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1198740, RefRangeEnd = 1198741, XrefRangeStart = 1198737, XrefRangeEnd = 1198740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10)]
      [CachedScanResults(RefRangeStart = 1035887, RefRangeEnd = 1035897, XrefRangeStart = 1035887, XrefRangeEnd = 1035897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        RoomRoofUpdateSystem componentSystem,
        ref RoomRoofUpdateSystem.__c__DisplayClass13_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_byref___c__DisplayClass13_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ProcessAllRooms_LambdaJob0()
      {
        Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomRoofUpdateSystem>.NativeClassPtr, "<>c__DisplayClass_ProcessAllRooms_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0>.NativeClassPtr);
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.NativeFieldInfoPtr_roomsToProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0>.NativeClassPtr, nameof (roomsToProcess));
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0>.NativeClassPtr, 100664261);
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0>.NativeClassPtr, 100664262);
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0>.NativeClassPtr, 100664263);
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0>.NativeClassPtr, 100664264);
        RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_byref___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0>.NativeClassPtr, 100664265);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_roomEntity;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_roomEntity;

        [CallerCount(25)]
        [CachedScanResults(RefRangeStart = 742675, RefRangeEnd = 742700, XrefRangeStart = 742675, XrefRangeEnd = 742700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(RoomRoofUpdateSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(25)]
        [CachedScanResults(RefRangeStart = 742701, RefRangeEnd = 742726, XrefRangeStart = 742701, XrefRangeEnd = 742726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_roomEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_roomEntity));
          RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RoomRoofUpdateSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664266);
          RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100664267);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_roomEntity;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_roomEntity;

          static Runtimes()
          {
            Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_roomEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_roomEntity));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoomRoofUpdateSystem.__c__DisplayClass_ProcessAllRooms_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
