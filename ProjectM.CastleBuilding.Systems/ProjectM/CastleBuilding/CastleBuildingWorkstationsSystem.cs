// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleBuildingWorkstationsSystem
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class CastleBuildingWorkstationsSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TileModelSpatialLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr__WorkstationsWithNoConnection;
    private static readonly System.IntPtr NativeFieldInfoPtr__AddedFloorsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__MovedFloorsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__AddedWorkstationsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__MovedWorkstationsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__RemovedWorkstationsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__HandleRoomEventsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__RecalculateWorkstationLevelQuery;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddWorkstationEntity_Public_Static_Boolean_byref_DynamicBuffer_1_CastleRoomWorkstationsBuffer_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryConnectWorkstationsWithNoConnection_Public_Static_Void_Entity_NativeList_1_Entity_ComponentDataFromEntity_1_TilePosition_ComponentDataFromEntity_1_TileCollisionTag_ComponentDataFromEntity_1_TileBounds_ComponentDataFromEntity_1_CastleRoomConnection_BufferFromEntity_1_CastleRoomWorkstationsBuffer_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200754, XrefRangeEnd = 1200826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBuildingWorkstationsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200826, XrefRangeEnd = 1200829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBuildingWorkstationsSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200829, XrefRangeEnd = 1200993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBuildingWorkstationsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1201005, RefRangeEnd = 1201009, XrefRangeStart = 1200993, XrefRangeEnd = 1201005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool AddWorkstationEntity(
      ref DynamicBuffer<CastleRoomWorkstationsBuffer> buffer,
      Entity workstationEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &workstationEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuildingWorkstationsSystem.NativeMethodInfoPtr_AddWorkstationEntity_Public_Static_Boolean_byref_DynamicBuffer_1_CastleRoomWorkstationsBuffer_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1201064, RefRangeEnd = 1201066, XrefRangeStart = 1201009, XrefRangeEnd = 1201064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryConnectWorkstationsWithNoConnection(
      Entity floorEntity,
      NativeList<Entity> workstationsWithNoConnection,
      ComponentDataFromEntity<TilePosition> getTilePosition,
      ComponentDataFromEntity<TileCollisionTag> getCollisionTag,
      ComponentDataFromEntity<TileBounds> getTileBounds,
      ComponentDataFromEntity<CastleRoomConnection> getCastleRoomConnection,
      BufferFromEntity<CastleRoomWorkstationsBuffer> getRoomWorkstationsBuffer,
      EntityCommandBuffer commandBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &floorEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &workstationsWithNoConnection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getTilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &getCollisionTag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &getTileBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &getCastleRoomConnection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &getRoomWorkstationsBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuildingWorkstationsSystem.NativeMethodInfoPtr_TryConnectWorkstationsWithNoConnection_Public_Static_Void_Entity_NativeList_1_Entity_ComponentDataFromEntity_1_TilePosition_ComponentDataFromEntity_1_TileCollisionTag_ComponentDataFromEntity_1_TileBounds_ComponentDataFromEntity_1_CastleRoomConnection_BufferFromEntity_1_CastleRoomWorkstationsBuffer_EntityCommandBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleBuildingWorkstationsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuildingWorkstationsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBuildingWorkstationsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleBuildingWorkstationsSystem()
    {
      Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.CastleBuilding", nameof (CastleBuildingWorkstationsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr);
      CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr, nameof (_TileModelSpatialLookupMap));
      CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__WorkstationsWithNoConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr, nameof (_WorkstationsWithNoConnection));
      CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__AddedFloorsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr, nameof (_AddedFloorsQuery));
      CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__MovedFloorsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr, nameof (_MovedFloorsQuery));
      CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__AddedWorkstationsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr, nameof (_AddedWorkstationsQuery));
      CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__MovedWorkstationsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr, nameof (_MovedWorkstationsQuery));
      CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__RemovedWorkstationsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr, nameof (_RemovedWorkstationsQuery));
      CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__HandleRoomEventsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr, nameof (_HandleRoomEventsQuery));
      CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__RecalculateWorkstationLevelQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr, nameof (_RecalculateWorkstationLevelQuery));
      CastleBuildingWorkstationsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr, 100664331);
      CastleBuildingWorkstationsSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr, 100664332);
      CastleBuildingWorkstationsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr, 100664333);
      CastleBuildingWorkstationsSystem.NativeMethodInfoPtr_AddWorkstationEntity_Public_Static_Boolean_byref_DynamicBuffer_1_CastleRoomWorkstationsBuffer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr, 100664334);
      CastleBuildingWorkstationsSystem.NativeMethodInfoPtr_TryConnectWorkstationsWithNoConnection_Public_Static_Void_Entity_NativeList_1_Entity_ComponentDataFromEntity_1_TilePosition_ComponentDataFromEntity_1_TileCollisionTag_ComponentDataFromEntity_1_TileBounds_ComponentDataFromEntity_1_CastleRoomConnection_BufferFromEntity_1_CastleRoomWorkstationsBuffer_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr, 100664335);
      CastleBuildingWorkstationsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr, 100664336);
      CastleBuildingWorkstationsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr, 100664337);
    }

    public CastleBuildingWorkstationsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TileModelSpatialLookupMap _TileModelSpatialLookupMap
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap));
        return pointer == System.IntPtr.Zero ? (TileModelSpatialLookupMap) null : new TileModelSpatialLookupMap(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__TileModelSpatialLookupMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<Entity> _WorkstationsWithNoConnection
    {
      get
      {
        return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__WorkstationsWithNoConnection));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__WorkstationsWithNoConnection), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _AddedFloorsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__AddedFloorsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__AddedFloorsQuery)) = value;
      }
    }

    public unsafe EntityQuery _MovedFloorsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__MovedFloorsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__MovedFloorsQuery)) = value;
      }
    }

    public unsafe EntityQuery _AddedWorkstationsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__AddedWorkstationsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__AddedWorkstationsQuery)) = value;
      }
    }

    public unsafe EntityQuery _MovedWorkstationsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__MovedWorkstationsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__MovedWorkstationsQuery)) = value;
      }
    }

    public unsafe EntityQuery _RemovedWorkstationsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__RemovedWorkstationsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__RemovedWorkstationsQuery)) = value;
      }
    }

    public unsafe EntityQuery _HandleRoomEventsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__HandleRoomEventsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__HandleRoomEventsQuery)) = value;
      }
    }

    public unsafe EntityQuery _RecalculateWorkstationLevelQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__RecalculateWorkstationLevelQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingWorkstationsSystem.NativeFieldInfoPtr__RecalculateWorkstationLevelQuery)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HandleAddedWorkstationsEventsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_AddedEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleRoomConnection;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleFloor;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTileData;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpatialLookupParams;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRoomWorkstationsBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_WorkstationsWithNoConnection;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_HandleAddedWorkstation_Private_Void_byref_EntityEvent_CastleWorkstation_TilePosition_byref_AddedEvent_CastleWorkstation_TilePosition_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleWorkstation, TilePosition>.EntityEvent> EntityEventType;
      [FieldOffset(32)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleWorkstation, TilePosition>.AddedEvent> AddedEventType;
      [FieldOffset(64)]
      public ComponentDataFromEntity<CastleRoomConnection> GetCastleRoomConnection;
      [FieldOffset(96)]
      public ComponentDataFromEntity<CastleFloor> GetCastleFloor;
      [FieldOffset(128)]
      public ComponentDataFromEntity<TilePosition> GetTilePosition;
      [FieldOffset(160)]
      public ComponentDataFromEntity<TileData> GetTileData;
      [FieldOffset(192)]
      public SpatialLookupParams SpatialLookupParams;
      [FieldOffset(272)]
      public BufferFromEntity<CastleRoomWorkstationsBuffer> GetRoomWorkstationsBuffer;
      [FieldOffset(312)]
      public NativeList<Entity> WorkstationsWithNoConnection;
      [FieldOffset(328)]
      public EntityCommandBuffer CommandBuffer;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200354, XrefRangeEnd = 1200363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1200405, RefRangeEnd = 1200406, XrefRangeStart = 1200363, XrefRangeEnd = 1200405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void HandleAddedWorkstation(
        [In] ref EntityAddUpdateRemoveEventSystem<CastleWorkstation, TilePosition>.EntityEvent entityEvent,
        [In] ref EntityAddUpdateRemoveEventSystem<CastleWorkstation, TilePosition>.AddedEvent addedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref entityEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref addedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob.NativeMethodInfoPtr_HandleAddedWorkstation_Private_Void_byref_EntityEvent_CastleWorkstation_TilePosition_byref_AddedEvent_CastleWorkstation_TilePosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HandleAddedWorkstationsEventsJob()
      {
        Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr, nameof (HandleAddedWorkstationsEventsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob>.NativeClassPtr);
        CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob.NativeFieldInfoPtr_EntityEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob>.NativeClassPtr, nameof (EntityEventType));
        CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob.NativeFieldInfoPtr_AddedEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob>.NativeClassPtr, nameof (AddedEventType));
        CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob.NativeFieldInfoPtr_GetCastleRoomConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob>.NativeClassPtr, nameof (GetCastleRoomConnection));
        CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob.NativeFieldInfoPtr_GetCastleFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob>.NativeClassPtr, nameof (GetCastleFloor));
        CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob.NativeFieldInfoPtr_GetTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob>.NativeClassPtr, nameof (GetTilePosition));
        CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob.NativeFieldInfoPtr_GetTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob>.NativeClassPtr, nameof (GetTileData));
        CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob.NativeFieldInfoPtr_SpatialLookupParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob>.NativeClassPtr, nameof (SpatialLookupParams));
        CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob.NativeFieldInfoPtr_GetRoomWorkstationsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob>.NativeClassPtr, nameof (GetRoomWorkstationsBuffer));
        CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob.NativeFieldInfoPtr_WorkstationsWithNoConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob>.NativeClassPtr, nameof (WorkstationsWithNoConnection));
        CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob>.NativeClassPtr, nameof (CommandBuffer));
        CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob>.NativeClassPtr, 100664338);
        CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob.NativeMethodInfoPtr_HandleAddedWorkstation_Private_Void_byref_EntityEvent_CastleWorkstation_TilePosition_byref_AddedEvent_CastleWorkstation_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob>.NativeClassPtr, 100664339);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedWorkstationsEventsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HandleRemovedWorkstationsEventsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_RemovedEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleRoomConnection;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRoomWorkstationsBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_WorkstationsWithNoConnection;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_HandleRemovedWorkstation_Private_Void_byref_EntityEvent_CastleWorkstation_TilePosition_byref_RemovedEvent_CastleWorkstation_TilePosition_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleWorkstation, TilePosition>.EntityEvent> EntityEventType;
      [FieldOffset(32)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleWorkstation, TilePosition>.RemovedEvent> RemovedEventType;
      [FieldOffset(64)]
      public ComponentDataFromEntity<CastleRoomConnection> GetCastleRoomConnection;
      [FieldOffset(96)]
      public BufferFromEntity<CastleRoomWorkstationsBuffer> GetRoomWorkstationsBuffer;
      [FieldOffset(136)]
      public NativeList<Entity> WorkstationsWithNoConnection;
      [FieldOffset(152)]
      public EntityCommandBuffer CommandBuffer;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200406, XrefRangeEnd = 1200415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingWorkstationsSystem.HandleRemovedWorkstationsEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1200438, RefRangeEnd = 1200439, XrefRangeStart = 1200415, XrefRangeEnd = 1200438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void HandleRemovedWorkstation(
        [In] ref EntityAddUpdateRemoveEventSystem<CastleWorkstation, TilePosition>.EntityEvent entityEvent,
        [In] ref EntityAddUpdateRemoveEventSystem<CastleWorkstation, TilePosition>.RemovedEvent removedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref entityEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref removedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingWorkstationsSystem.HandleRemovedWorkstationsEventsJob.NativeMethodInfoPtr_HandleRemovedWorkstation_Private_Void_byref_EntityEvent_CastleWorkstation_TilePosition_byref_RemovedEvent_CastleWorkstation_TilePosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HandleRemovedWorkstationsEventsJob()
      {
        Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRemovedWorkstationsEventsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr, nameof (HandleRemovedWorkstationsEventsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRemovedWorkstationsEventsJob>.NativeClassPtr);
        CastleBuildingWorkstationsSystem.HandleRemovedWorkstationsEventsJob.NativeFieldInfoPtr_EntityEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRemovedWorkstationsEventsJob>.NativeClassPtr, nameof (EntityEventType));
        CastleBuildingWorkstationsSystem.HandleRemovedWorkstationsEventsJob.NativeFieldInfoPtr_RemovedEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRemovedWorkstationsEventsJob>.NativeClassPtr, nameof (RemovedEventType));
        CastleBuildingWorkstationsSystem.HandleRemovedWorkstationsEventsJob.NativeFieldInfoPtr_GetCastleRoomConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRemovedWorkstationsEventsJob>.NativeClassPtr, nameof (GetCastleRoomConnection));
        CastleBuildingWorkstationsSystem.HandleRemovedWorkstationsEventsJob.NativeFieldInfoPtr_GetRoomWorkstationsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRemovedWorkstationsEventsJob>.NativeClassPtr, nameof (GetRoomWorkstationsBuffer));
        CastleBuildingWorkstationsSystem.HandleRemovedWorkstationsEventsJob.NativeFieldInfoPtr_WorkstationsWithNoConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRemovedWorkstationsEventsJob>.NativeClassPtr, nameof (WorkstationsWithNoConnection));
        CastleBuildingWorkstationsSystem.HandleRemovedWorkstationsEventsJob.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRemovedWorkstationsEventsJob>.NativeClassPtr, nameof (CommandBuffer));
        CastleBuildingWorkstationsSystem.HandleRemovedWorkstationsEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRemovedWorkstationsEventsJob>.NativeClassPtr, 100664340);
        CastleBuildingWorkstationsSystem.HandleRemovedWorkstationsEventsJob.NativeMethodInfoPtr_HandleRemovedWorkstation_Private_Void_byref_EntityEvent_CastleWorkstation_TilePosition_byref_RemovedEvent_CastleWorkstation_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRemovedWorkstationsEventsJob>.NativeClassPtr, 100664341);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRemovedWorkstationsEventsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HandleMovedWorkstationsEventsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_UpdatedEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleRoomConnection;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleFloor;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTileData;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpatialLookupParams;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRoomWorkstationsBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_WorkstationsWithNoConnection;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_HandleMovedWorkstation_Private_Void_byref_EntityEvent_CastleWorkstation_TilePosition_byref_UpdatedEvent_CastleWorkstation_TilePosition_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleWorkstation, TilePosition>.EntityEvent> EntityEventType;
      [FieldOffset(32)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleWorkstation, TilePosition>.UpdatedEvent> UpdatedEventType;
      [FieldOffset(64)]
      public ComponentDataFromEntity<CastleRoomConnection> GetCastleRoomConnection;
      [FieldOffset(96)]
      public ComponentDataFromEntity<CastleFloor> GetCastleFloor;
      [FieldOffset(128)]
      public ComponentDataFromEntity<TilePosition> GetTilePosition;
      [FieldOffset(160)]
      public ComponentDataFromEntity<TileData> GetTileData;
      [FieldOffset(192)]
      public SpatialLookupParams SpatialLookupParams;
      [FieldOffset(272)]
      public BufferFromEntity<CastleRoomWorkstationsBuffer> GetRoomWorkstationsBuffer;
      [FieldOffset(312)]
      public NativeList<Entity> WorkstationsWithNoConnection;
      [FieldOffset(328)]
      public EntityCommandBuffer CommandBuffer;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200439, XrefRangeEnd = 1200448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1200529, RefRangeEnd = 1200530, XrefRangeStart = 1200448, XrefRangeEnd = 1200529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void HandleMovedWorkstation(
        [In] ref EntityAddUpdateRemoveEventSystem<CastleWorkstation, TilePosition>.EntityEvent entityEvent,
        [In] ref EntityAddUpdateRemoveEventSystem<CastleWorkstation, TilePosition>.UpdatedEvent updatedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref entityEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref updatedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob.NativeMethodInfoPtr_HandleMovedWorkstation_Private_Void_byref_EntityEvent_CastleWorkstation_TilePosition_byref_UpdatedEvent_CastleWorkstation_TilePosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HandleMovedWorkstationsEventsJob()
      {
        Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr, nameof (HandleMovedWorkstationsEventsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob>.NativeClassPtr);
        CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob.NativeFieldInfoPtr_EntityEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob>.NativeClassPtr, nameof (EntityEventType));
        CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob.NativeFieldInfoPtr_UpdatedEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob>.NativeClassPtr, nameof (UpdatedEventType));
        CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob.NativeFieldInfoPtr_GetCastleRoomConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob>.NativeClassPtr, nameof (GetCastleRoomConnection));
        CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob.NativeFieldInfoPtr_GetCastleFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob>.NativeClassPtr, nameof (GetCastleFloor));
        CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob.NativeFieldInfoPtr_GetTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob>.NativeClassPtr, nameof (GetTilePosition));
        CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob.NativeFieldInfoPtr_GetTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob>.NativeClassPtr, nameof (GetTileData));
        CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob.NativeFieldInfoPtr_SpatialLookupParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob>.NativeClassPtr, nameof (SpatialLookupParams));
        CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob.NativeFieldInfoPtr_GetRoomWorkstationsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob>.NativeClassPtr, nameof (GetRoomWorkstationsBuffer));
        CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob.NativeFieldInfoPtr_WorkstationsWithNoConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob>.NativeClassPtr, nameof (WorkstationsWithNoConnection));
        CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob>.NativeClassPtr, nameof (CommandBuffer));
        CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob>.NativeClassPtr, 100664342);
        CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob.NativeMethodInfoPtr_HandleMovedWorkstation_Private_Void_byref_EntityEvent_CastleWorkstation_TilePosition_byref_UpdatedEvent_CastleWorkstation_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob>.NativeClassPtr, 100664343);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedWorkstationsEventsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HandleAddedFloorsEventsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_AddedEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleRoomConnection;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCollisionTag;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTileBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRoomWorkstationsBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_WorkstationsWithNoConnection;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.EntityEvent> EntityEventType;
      [FieldOffset(32)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.AddedEvent> AddedEventType;
      [FieldOffset(64)]
      public ComponentDataFromEntity<CastleRoomConnection> GetCastleRoomConnection;
      [FieldOffset(96)]
      public ComponentDataFromEntity<TileCollisionTag> GetCollisionTag;
      [FieldOffset(128)]
      public ComponentDataFromEntity<TileBounds> GetTileBounds;
      [FieldOffset(160)]
      public ComponentDataFromEntity<TilePosition> GetTilePosition;
      [FieldOffset(192)]
      public BufferFromEntity<CastleRoomWorkstationsBuffer> GetRoomWorkstationsBuffer;
      [FieldOffset(232)]
      public NativeList<Entity> WorkstationsWithNoConnection;
      [FieldOffset(248)]
      public EntityCommandBuffer CommandBuffer;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200530, XrefRangeEnd = 1200539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HandleAddedFloorsEventsJob()
      {
        Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr, nameof (HandleAddedFloorsEventsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob>.NativeClassPtr);
        CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob.NativeFieldInfoPtr_EntityEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob>.NativeClassPtr, nameof (EntityEventType));
        CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob.NativeFieldInfoPtr_AddedEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob>.NativeClassPtr, nameof (AddedEventType));
        CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob.NativeFieldInfoPtr_GetCastleRoomConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob>.NativeClassPtr, nameof (GetCastleRoomConnection));
        CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob.NativeFieldInfoPtr_GetCollisionTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob>.NativeClassPtr, nameof (GetCollisionTag));
        CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob.NativeFieldInfoPtr_GetTileBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob>.NativeClassPtr, nameof (GetTileBounds));
        CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob.NativeFieldInfoPtr_GetTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob>.NativeClassPtr, nameof (GetTilePosition));
        CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob.NativeFieldInfoPtr_GetRoomWorkstationsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob>.NativeClassPtr, nameof (GetRoomWorkstationsBuffer));
        CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob.NativeFieldInfoPtr_WorkstationsWithNoConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob>.NativeClassPtr, nameof (WorkstationsWithNoConnection));
        CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob>.NativeClassPtr, nameof (CommandBuffer));
        CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob>.NativeClassPtr, 100664344);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleAddedFloorsEventsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HandleMovedFloorsEventsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_UpdatedEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleRoomConnection;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCollisionTag;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTileBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRoomWorkstationsBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_WorkstationsWithNoConnection;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.EntityEvent> EntityEventType;
      [FieldOffset(32)]
      public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<CastleFloor, TilePosition>.UpdatedEvent> UpdatedEventType;
      [FieldOffset(64)]
      public ComponentDataFromEntity<CastleRoomConnection> GetCastleRoomConnection;
      [FieldOffset(96)]
      public ComponentDataFromEntity<TileCollisionTag> GetCollisionTag;
      [FieldOffset(128)]
      public ComponentDataFromEntity<TileBounds> GetTileBounds;
      [FieldOffset(160)]
      public ComponentDataFromEntity<TilePosition> GetTilePosition;
      [FieldOffset(192)]
      public BufferFromEntity<CastleRoomWorkstationsBuffer> GetRoomWorkstationsBuffer;
      [FieldOffset(232)]
      public NativeList<Entity> WorkstationsWithNoConnection;
      [FieldOffset(248)]
      public EntityCommandBuffer CommandBuffer;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200539, XrefRangeEnd = 1200548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HandleMovedFloorsEventsJob()
      {
        Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr, nameof (HandleMovedFloorsEventsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob>.NativeClassPtr);
        CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob.NativeFieldInfoPtr_EntityEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob>.NativeClassPtr, nameof (EntityEventType));
        CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob.NativeFieldInfoPtr_UpdatedEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob>.NativeClassPtr, nameof (UpdatedEventType));
        CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob.NativeFieldInfoPtr_GetCastleRoomConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob>.NativeClassPtr, nameof (GetCastleRoomConnection));
        CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob.NativeFieldInfoPtr_GetCollisionTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob>.NativeClassPtr, nameof (GetCollisionTag));
        CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob.NativeFieldInfoPtr_GetTileBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob>.NativeClassPtr, nameof (GetTileBounds));
        CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob.NativeFieldInfoPtr_GetTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob>.NativeClassPtr, nameof (GetTilePosition));
        CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob.NativeFieldInfoPtr_GetRoomWorkstationsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob>.NativeClassPtr, nameof (GetRoomWorkstationsBuffer));
        CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob.NativeFieldInfoPtr_WorkstationsWithNoConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob>.NativeClassPtr, nameof (WorkstationsWithNoConnection));
        CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob>.NativeClassPtr, nameof (CommandBuffer));
        CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob>.NativeClassPtr, 100664345);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleMovedFloorsEventsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HandleRoomEventsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CastleRoomEventComponentType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTilePosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleFloor;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTileData;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpatialLookupParams;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleRoomConnection;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetRoomWorkstationsBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_WorkstationsWithNoConnection;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_HandleRoomEvent_Private_Void_byref_CastleRoomEvent_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<CastleRoomEvent> CastleRoomEventComponentType;
      [FieldOffset(32)]
      public ComponentDataFromEntity<TilePosition> GetTilePosition;
      [FieldOffset(64)]
      public ComponentDataFromEntity<CastleFloor> GetCastleFloor;
      [FieldOffset(96)]
      public ComponentDataFromEntity<TileData> GetTileData;
      [FieldOffset(128)]
      public SpatialLookupParams SpatialLookupParams;
      [FieldOffset(208)]
      public ComponentDataFromEntity<CastleRoomConnection> GetCastleRoomConnection;
      [FieldOffset(240)]
      public BufferFromEntity<CastleRoomWorkstationsBuffer> GetRoomWorkstationsBuffer;
      [FieldOffset(280)]
      public NativeList<Entity> WorkstationsWithNoConnection;
      [FieldOffset(296)]
      public EntityCommandBuffer CommandBuffer;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200548, XrefRangeEnd = 1200554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingWorkstationsSystem.HandleRoomEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1200689, RefRangeEnd = 1200690, XrefRangeStart = 1200554, XrefRangeEnd = 1200689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void HandleRoomEvent([In] ref CastleRoomEvent roomEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref roomEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingWorkstationsSystem.HandleRoomEventsJob.NativeMethodInfoPtr_HandleRoomEvent_Private_Void_byref_CastleRoomEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HandleRoomEventsJob()
      {
        Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRoomEventsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr, nameof (HandleRoomEventsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRoomEventsJob>.NativeClassPtr);
        CastleBuildingWorkstationsSystem.HandleRoomEventsJob.NativeFieldInfoPtr_CastleRoomEventComponentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRoomEventsJob>.NativeClassPtr, nameof (CastleRoomEventComponentType));
        CastleBuildingWorkstationsSystem.HandleRoomEventsJob.NativeFieldInfoPtr_GetTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRoomEventsJob>.NativeClassPtr, nameof (GetTilePosition));
        CastleBuildingWorkstationsSystem.HandleRoomEventsJob.NativeFieldInfoPtr_GetCastleFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRoomEventsJob>.NativeClassPtr, nameof (GetCastleFloor));
        CastleBuildingWorkstationsSystem.HandleRoomEventsJob.NativeFieldInfoPtr_GetTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRoomEventsJob>.NativeClassPtr, nameof (GetTileData));
        CastleBuildingWorkstationsSystem.HandleRoomEventsJob.NativeFieldInfoPtr_SpatialLookupParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRoomEventsJob>.NativeClassPtr, nameof (SpatialLookupParams));
        CastleBuildingWorkstationsSystem.HandleRoomEventsJob.NativeFieldInfoPtr_GetCastleRoomConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRoomEventsJob>.NativeClassPtr, nameof (GetCastleRoomConnection));
        CastleBuildingWorkstationsSystem.HandleRoomEventsJob.NativeFieldInfoPtr_GetRoomWorkstationsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRoomEventsJob>.NativeClassPtr, nameof (GetRoomWorkstationsBuffer));
        CastleBuildingWorkstationsSystem.HandleRoomEventsJob.NativeFieldInfoPtr_WorkstationsWithNoConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRoomEventsJob>.NativeClassPtr, nameof (WorkstationsWithNoConnection));
        CastleBuildingWorkstationsSystem.HandleRoomEventsJob.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRoomEventsJob>.NativeClassPtr, nameof (CommandBuffer));
        CastleBuildingWorkstationsSystem.HandleRoomEventsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRoomEventsJob>.NativeClassPtr, 100664346);
        CastleBuildingWorkstationsSystem.HandleRoomEventsJob.NativeMethodInfoPtr_HandleRoomEvent_Private_Void_byref_CastleRoomEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRoomEventsJob>.NativeClassPtr, 100664347);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.HandleRoomEventsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RecalculateWorkstationLevelJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_CastleWorkstationType;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleRoomConnection;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetStationServants;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleRoom;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetFloorsBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleFloor;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleHeart;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RecalculateWorkstationLevel_Private_Void_Entity_byref_CastleWorkstation_0;
      [FieldOffset(0)]
      public EntityTypeHandle EntityType;
      [FieldOffset(8)]
      public ComponentTypeHandle<CastleWorkstation> CastleWorkstationType;
      [FieldOffset(40)]
      public EntityCommandBuffer CommandBuffer;
      [FieldOffset(56)]
      public ComponentDataFromEntity<CastleRoomConnection> GetCastleRoomConnection;
      [FieldOffset(88)]
      public ComponentDataFromEntity<StationServants> GetStationServants;
      [FieldOffset(120)]
      public ComponentDataFromEntity<CastleRoom> GetCastleRoom;
      [FieldOffset(152)]
      public BufferFromEntity<CastleRoomFloorsBuffer> GetFloorsBuffer;
      [FieldOffset(192)]
      public ComponentDataFromEntity<CastleFloor> GetCastleFloor;
      [FieldOffset(224)]
      public ComponentDataFromEntity<CastleHeart> GetCastleHeart;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200690, XrefRangeEnd = 1200697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1200753, RefRangeEnd = 1200754, XrefRangeStart = 1200697, XrefRangeEnd = 1200753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void RecalculateWorkstationLevel(
        Entity workstationEntity,
        ref CastleWorkstation castleWorkstation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &workstationEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleWorkstation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob.NativeMethodInfoPtr_RecalculateWorkstationLevel_Private_Void_Entity_byref_CastleWorkstation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RecalculateWorkstationLevelJob()
      {
        Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem>.NativeClassPtr, nameof (RecalculateWorkstationLevelJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob>.NativeClassPtr);
        CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob>.NativeClassPtr, nameof (EntityType));
        CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob.NativeFieldInfoPtr_CastleWorkstationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob>.NativeClassPtr, nameof (CastleWorkstationType));
        CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob>.NativeClassPtr, nameof (CommandBuffer));
        CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob.NativeFieldInfoPtr_GetCastleRoomConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob>.NativeClassPtr, nameof (GetCastleRoomConnection));
        CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob.NativeFieldInfoPtr_GetStationServants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob>.NativeClassPtr, nameof (GetStationServants));
        CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob.NativeFieldInfoPtr_GetCastleRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob>.NativeClassPtr, nameof (GetCastleRoom));
        CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob.NativeFieldInfoPtr_GetFloorsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob>.NativeClassPtr, nameof (GetFloorsBuffer));
        CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob.NativeFieldInfoPtr_GetCastleFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob>.NativeClassPtr, nameof (GetCastleFloor));
        CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob.NativeFieldInfoPtr_GetCastleHeart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob>.NativeClassPtr, nameof (GetCastleHeart));
        CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob>.NativeClassPtr, 100664348);
        CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob.NativeMethodInfoPtr_RecalculateWorkstationLevel_Private_Void_Entity_byref_CastleWorkstation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob>.NativeClassPtr, 100664349);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingWorkstationsSystem.RecalculateWorkstationLevelJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
