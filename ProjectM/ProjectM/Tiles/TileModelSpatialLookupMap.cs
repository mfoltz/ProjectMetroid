// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileModelSpatialLookupMap
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;

#nullable disable
namespace ProjectM.Tiles
{
  public class TileModelSpatialLookupMap : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpatialLookupCapacity;
    private static readonly System.IntPtr NativeFieldInfoPtr__LookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr__OverlappingCells;
    private static readonly System.IntPtr NativeFieldInfoPtr__PreviousOverlappingCells;
    private static readonly System.IntPtr NativeFieldInfoPtr__AddedQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__UpdatedQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__RemovedQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputJobHandle;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddInputJobHandle_Public_Void_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLookupParamsAsync_Public_Virtual_Final_New_SpatialLookupParams_ComponentSystemBase_byref_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLookupParamsAndComplete_Public_Virtual_Final_New_SpatialLookupParams_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntities_Public_NativeList_1_Entity_ComponentSystemBase_BoundsMinMax_TileType_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesAsJob_Public_Static_Void_BoundsMinMax_TileType_SpatialLookupParams_NativeList_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087714, XrefRangeEnd = 1087786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileModelSpatialLookupMap.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087786, XrefRangeEnd = 1087795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileModelSpatialLookupMap.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087795, XrefRangeEnd = 1087830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileModelSpatialLookupMap.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1087831, RefRangeEnd = 1087834, XrefRangeStart = 1087830, XrefRangeEnd = 1087831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddInputJobHandle(JobHandle inputDeps)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputDeps;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelSpatialLookupMap.NativeMethodInfoPtr_AddInputJobHandle_Public_Void_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1087841, RefRangeEnd = 1087845, XrefRangeStart = 1087834, XrefRangeEnd = 1087841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe SpatialLookupParams GetLookupParamsAsync(
      ComponentSystemBase system,
      out JobHandle lookupDeps)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lookupDeps;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelSpatialLookupMap.NativeMethodInfoPtr_GetLookupParamsAsync_Public_Virtual_Final_New_SpatialLookupParams_ComponentSystemBase_byref_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SpatialLookupParams*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(18)]
    [CachedScanResults(RefRangeStart = 1087853, RefRangeEnd = 1087871, XrefRangeStart = 1087845, XrefRangeEnd = 1087853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe SpatialLookupParams GetLookupParamsAndComplete(ComponentSystemBase system)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelSpatialLookupMap.NativeMethodInfoPtr_GetLookupParamsAndComplete_Public_Virtual_Final_New_SpatialLookupParams_ComponentSystemBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SpatialLookupParams*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1087885, RefRangeEnd = 1087886, XrefRangeStart = 1087871, XrefRangeEnd = 1087885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeList<Entity> GetEntities(
      ComponentSystemBase system,
      BoundsMinMax bounds,
      ProjectM.TileType tileTypes,
      Allocator allocator)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileTypes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelSpatialLookupMap.NativeMethodInfoPtr_GetEntities_Public_NativeList_1_Entity_ComponentSystemBase_BoundsMinMax_TileType_Allocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<Entity>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087886, XrefRangeEnd = 1087889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetEntitiesAsJob(
      BoundsMinMax bounds,
      ProjectM.TileType tileTypes,
      SpatialLookupParams lookupParams,
      NativeList<Entity> result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &bounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileTypes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &lookupParams;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelSpatialLookupMap.NativeMethodInfoPtr_GetEntitiesAsJob_Public_Static_Void_BoundsMinMax_TileType_SpatialLookupParams_NativeList_1_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileModelSpatialLookupMap()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelSpatialLookupMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileModelSpatialLookupMap.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TileModelSpatialLookupMap()
    {
      Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (TileModelSpatialLookupMap));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr);
      TileModelSpatialLookupMap.NativeFieldInfoPtr_SpatialLookupCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr, nameof (SpatialLookupCapacity));
      TileModelSpatialLookupMap.NativeFieldInfoPtr__LookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr, nameof (_LookupMap));
      TileModelSpatialLookupMap.NativeFieldInfoPtr__OverlappingCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr, nameof (_OverlappingCells));
      TileModelSpatialLookupMap.NativeFieldInfoPtr__PreviousOverlappingCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr, nameof (_PreviousOverlappingCells));
      TileModelSpatialLookupMap.NativeFieldInfoPtr__AddedQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr, nameof (_AddedQuery));
      TileModelSpatialLookupMap.NativeFieldInfoPtr__UpdatedQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr, nameof (_UpdatedQuery));
      TileModelSpatialLookupMap.NativeFieldInfoPtr__RemovedQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr, nameof (_RemovedQuery));
      TileModelSpatialLookupMap.NativeFieldInfoPtr__InputJobHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr, nameof (_InputJobHandle));
      TileModelSpatialLookupMap.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr, 100685620);
      TileModelSpatialLookupMap.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr, 100685621);
      TileModelSpatialLookupMap.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr, 100685622);
      TileModelSpatialLookupMap.NativeMethodInfoPtr_AddInputJobHandle_Public_Void_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr, 100685623);
      TileModelSpatialLookupMap.NativeMethodInfoPtr_GetLookupParamsAsync_Public_Virtual_Final_New_SpatialLookupParams_ComponentSystemBase_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr, 100685624);
      TileModelSpatialLookupMap.NativeMethodInfoPtr_GetLookupParamsAndComplete_Public_Virtual_Final_New_SpatialLookupParams_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr, 100685625);
      TileModelSpatialLookupMap.NativeMethodInfoPtr_GetEntities_Public_NativeList_1_Entity_ComponentSystemBase_BoundsMinMax_TileType_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr, 100685626);
      TileModelSpatialLookupMap.NativeMethodInfoPtr_GetEntitiesAsJob_Public_Static_Void_BoundsMinMax_TileType_SpatialLookupParams_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr, 100685627);
      TileModelSpatialLookupMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr, 100685628);
      TileModelSpatialLookupMap.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr, 100685629);
    }

    public TileModelSpatialLookupMap(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int SpatialLookupCapacity
    {
      get
      {
        int spatialLookupCapacity;
        IL2CPP.il2cpp_field_static_get_value(TileModelSpatialLookupMap.NativeFieldInfoPtr_SpatialLookupCapacity, (void*) &spatialLookupCapacity);
        return spatialLookupCapacity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileModelSpatialLookupMap.NativeFieldInfoPtr_SpatialLookupCapacity, (void*) &value);
      }
    }

    public unsafe NativeMultiHashMap<TileModelSpatialCell, TileModelSpatialEntity> _LookupMap
    {
      get
      {
        return *(NativeMultiHashMap<TileModelSpatialCell, TileModelSpatialEntity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileModelSpatialLookupMap.NativeFieldInfoPtr__LookupMap));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileModelSpatialLookupMap.NativeFieldInfoPtr__LookupMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeMultiHashMap<TileModelSpatialCell, TileModelSpatialEntity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<TileModelSpatialCell> _OverlappingCells
    {
      get
      {
        return *(NativeList<TileModelSpatialCell>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileModelSpatialLookupMap.NativeFieldInfoPtr__OverlappingCells));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileModelSpatialLookupMap.NativeFieldInfoPtr__OverlappingCells), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<TileModelSpatialCell>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<TileModelSpatialCell> _PreviousOverlappingCells
    {
      get
      {
        return *(NativeList<TileModelSpatialCell>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileModelSpatialLookupMap.NativeFieldInfoPtr__PreviousOverlappingCells));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileModelSpatialLookupMap.NativeFieldInfoPtr__PreviousOverlappingCells), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<TileModelSpatialCell>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _AddedQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileModelSpatialLookupMap.NativeFieldInfoPtr__AddedQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileModelSpatialLookupMap.NativeFieldInfoPtr__AddedQuery)) = value;
      }
    }

    public unsafe EntityQuery _UpdatedQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileModelSpatialLookupMap.NativeFieldInfoPtr__UpdatedQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileModelSpatialLookupMap.NativeFieldInfoPtr__UpdatedQuery)) = value;
      }
    }

    public unsafe EntityQuery _RemovedQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileModelSpatialLookupMap.NativeFieldInfoPtr__RemovedQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileModelSpatialLookupMap.NativeFieldInfoPtr__RemovedQuery)) = value;
      }
    }

    public unsafe JobHandleManager _InputJobHandle
    {
      get
      {
        return *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileModelSpatialLookupMap.NativeFieldInfoPtr__InputJobHandle));
      }
      [param: In] set
      {
        *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileModelSpatialLookupMap.NativeFieldInfoPtr__InputJobHandle)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GetEntitiesJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Bounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileTypes;
      private static readonly System.IntPtr NativeFieldInfoPtr_LookupParams;
      private static readonly System.IntPtr NativeFieldInfoPtr_Result;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      [FieldOffset(0)]
      public BoundsMinMax Bounds;
      [FieldOffset(16)]
      public ProjectM.TileType TileTypes;
      [FieldOffset(24)]
      public SpatialLookupParams LookupParams;
      [FieldOffset(104)]
      public NativeList<Entity> Result;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087580, XrefRangeEnd = 1087581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TileModelSpatialLookupMap.GetEntitiesJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static GetEntitiesJob()
      {
        Il2CppClassPointerStore<TileModelSpatialLookupMap.GetEntitiesJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr, nameof (GetEntitiesJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileModelSpatialLookupMap.GetEntitiesJob>.NativeClassPtr);
        TileModelSpatialLookupMap.GetEntitiesJob.NativeFieldInfoPtr_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.GetEntitiesJob>.NativeClassPtr, nameof (Bounds));
        TileModelSpatialLookupMap.GetEntitiesJob.NativeFieldInfoPtr_TileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.GetEntitiesJob>.NativeClassPtr, nameof (TileTypes));
        TileModelSpatialLookupMap.GetEntitiesJob.NativeFieldInfoPtr_LookupParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.GetEntitiesJob>.NativeClassPtr, nameof (LookupParams));
        TileModelSpatialLookupMap.GetEntitiesJob.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.GetEntitiesJob>.NativeClassPtr, nameof (Result));
        TileModelSpatialLookupMap.GetEntitiesJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupMap.GetEntitiesJob>.NativeClassPtr, 100685630);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileModelSpatialLookupMap.GetEntitiesJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct AddedJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_TilePositionType;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileDataType;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileBoundsType;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpatialDataType;
      private static readonly System.IntPtr NativeFieldInfoPtr_WriteSpatialLookupState;
      private static readonly System.IntPtr NativeFieldInfoPtr_LookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_OverlappingCells;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public EntityTypeHandle EntityType;
      [FieldOffset(8)]
      public ComponentTypeHandle<TilePosition> TilePositionType;
      [FieldOffset(40)]
      public ComponentTypeHandle<TileData> TileDataType;
      [FieldOffset(72)]
      public ComponentTypeHandle<TileBounds> TileBoundsType;
      [FieldOffset(104)]
      public ComponentTypeHandle<TileModelSpatialData> SpatialDataType;
      [FieldOffset(136)]
      public bool WriteSpatialLookupState;
      [FieldOffset(144)]
      public NativeMultiHashMap<TileModelSpatialCell, TileModelSpatialEntity> LookupMap;
      [FieldOffset(160)]
      public NativeList<TileModelSpatialCell> OverlappingCells;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087581, XrefRangeEnd = 1087612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(TileModelSpatialLookupMap.AddedJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static AddedJob()
      {
        Il2CppClassPointerStore<TileModelSpatialLookupMap.AddedJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr, nameof (AddedJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileModelSpatialLookupMap.AddedJob>.NativeClassPtr);
        TileModelSpatialLookupMap.AddedJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.AddedJob>.NativeClassPtr, nameof (EntityType));
        TileModelSpatialLookupMap.AddedJob.NativeFieldInfoPtr_TilePositionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.AddedJob>.NativeClassPtr, nameof (TilePositionType));
        TileModelSpatialLookupMap.AddedJob.NativeFieldInfoPtr_TileDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.AddedJob>.NativeClassPtr, nameof (TileDataType));
        TileModelSpatialLookupMap.AddedJob.NativeFieldInfoPtr_TileBoundsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.AddedJob>.NativeClassPtr, nameof (TileBoundsType));
        TileModelSpatialLookupMap.AddedJob.NativeFieldInfoPtr_SpatialDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.AddedJob>.NativeClassPtr, nameof (SpatialDataType));
        TileModelSpatialLookupMap.AddedJob.NativeFieldInfoPtr_WriteSpatialLookupState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.AddedJob>.NativeClassPtr, nameof (WriteSpatialLookupState));
        TileModelSpatialLookupMap.AddedJob.NativeFieldInfoPtr_LookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.AddedJob>.NativeClassPtr, nameof (LookupMap));
        TileModelSpatialLookupMap.AddedJob.NativeFieldInfoPtr_OverlappingCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.AddedJob>.NativeClassPtr, nameof (OverlappingCells));
        TileModelSpatialLookupMap.AddedJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupMap.AddedJob>.NativeClassPtr, 100685631);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileModelSpatialLookupMap.AddedJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RemovedJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpatialDataType;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileDataType;
      private static readonly System.IntPtr NativeFieldInfoPtr_LookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_OverlappingCells;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public EntityTypeHandle EntityType;
      [FieldOffset(8)]
      public ComponentTypeHandle<TileModelSpatialData> SpatialDataType;
      [FieldOffset(40)]
      public ComponentTypeHandle<TileData> TileDataType;
      [FieldOffset(72)]
      public NativeMultiHashMap<TileModelSpatialCell, TileModelSpatialEntity> LookupMap;
      [FieldOffset(88)]
      public NativeList<TileModelSpatialCell> OverlappingCells;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087612, XrefRangeEnd = 1087638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(TileModelSpatialLookupMap.RemovedJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RemovedJob()
      {
        Il2CppClassPointerStore<TileModelSpatialLookupMap.RemovedJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr, nameof (RemovedJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileModelSpatialLookupMap.RemovedJob>.NativeClassPtr);
        TileModelSpatialLookupMap.RemovedJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.RemovedJob>.NativeClassPtr, nameof (EntityType));
        TileModelSpatialLookupMap.RemovedJob.NativeFieldInfoPtr_SpatialDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.RemovedJob>.NativeClassPtr, nameof (SpatialDataType));
        TileModelSpatialLookupMap.RemovedJob.NativeFieldInfoPtr_TileDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.RemovedJob>.NativeClassPtr, nameof (TileDataType));
        TileModelSpatialLookupMap.RemovedJob.NativeFieldInfoPtr_LookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.RemovedJob>.NativeClassPtr, nameof (LookupMap));
        TileModelSpatialLookupMap.RemovedJob.NativeFieldInfoPtr_OverlappingCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.RemovedJob>.NativeClassPtr, nameof (OverlappingCells));
        TileModelSpatialLookupMap.RemovedJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupMap.RemovedJob>.NativeClassPtr, 100685632);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileModelSpatialLookupMap.RemovedJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct UpdatedJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_TilePositionType;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileBoundsType;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileDataType;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpatialDataType;
      private static readonly System.IntPtr NativeFieldInfoPtr_LookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_PreviousOverlappingCells;
      private static readonly System.IntPtr NativeFieldInfoPtr_CurrentOverlappingCells;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public EntityTypeHandle EntityType;
      [FieldOffset(8)]
      public ComponentTypeHandle<TilePosition> TilePositionType;
      [FieldOffset(40)]
      public ComponentTypeHandle<TileBounds> TileBoundsType;
      [FieldOffset(72)]
      public ComponentTypeHandle<TileData> TileDataType;
      [FieldOffset(104)]
      public ComponentTypeHandle<TileModelSpatialData> SpatialDataType;
      [FieldOffset(136)]
      public NativeMultiHashMap<TileModelSpatialCell, TileModelSpatialEntity> LookupMap;
      [FieldOffset(152)]
      public NativeList<TileModelSpatialCell> PreviousOverlappingCells;
      [FieldOffset(168)]
      public NativeList<TileModelSpatialCell> CurrentOverlappingCells;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087638, XrefRangeEnd = 1087714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(TileModelSpatialLookupMap.UpdatedJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static UpdatedJob()
      {
        Il2CppClassPointerStore<TileModelSpatialLookupMap.UpdatedJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileModelSpatialLookupMap>.NativeClassPtr, nameof (UpdatedJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileModelSpatialLookupMap.UpdatedJob>.NativeClassPtr);
        TileModelSpatialLookupMap.UpdatedJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.UpdatedJob>.NativeClassPtr, nameof (EntityType));
        TileModelSpatialLookupMap.UpdatedJob.NativeFieldInfoPtr_TilePositionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.UpdatedJob>.NativeClassPtr, nameof (TilePositionType));
        TileModelSpatialLookupMap.UpdatedJob.NativeFieldInfoPtr_TileBoundsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.UpdatedJob>.NativeClassPtr, nameof (TileBoundsType));
        TileModelSpatialLookupMap.UpdatedJob.NativeFieldInfoPtr_TileDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.UpdatedJob>.NativeClassPtr, nameof (TileDataType));
        TileModelSpatialLookupMap.UpdatedJob.NativeFieldInfoPtr_SpatialDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.UpdatedJob>.NativeClassPtr, nameof (SpatialDataType));
        TileModelSpatialLookupMap.UpdatedJob.NativeFieldInfoPtr_LookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.UpdatedJob>.NativeClassPtr, nameof (LookupMap));
        TileModelSpatialLookupMap.UpdatedJob.NativeFieldInfoPtr_PreviousOverlappingCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.UpdatedJob>.NativeClassPtr, nameof (PreviousOverlappingCells));
        TileModelSpatialLookupMap.UpdatedJob.NativeFieldInfoPtr_CurrentOverlappingCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelSpatialLookupMap.UpdatedJob>.NativeClassPtr, nameof (CurrentOverlappingCells));
        TileModelSpatialLookupMap.UpdatedJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelSpatialLookupMap.UpdatedJob>.NativeClassPtr, 100685633);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileModelSpatialLookupMap.UpdatedJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
