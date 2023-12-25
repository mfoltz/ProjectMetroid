// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TemporaryTileModelSpatialLookupMap
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
  public class TemporaryTileModelSpatialLookupMap : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__LookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr__AllTileModelsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__OwnerSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__OverlappingCells;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Build_Public_JobHandle_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLookupParamsAsync_Public_Virtual_Final_New_SpatialLookupParams_ComponentSystemBase_byref_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLookupParamsAndComplete_Public_Virtual_Final_New_SpatialLookupParams_ComponentSystemBase_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1087920, RefRangeEnd = 1087921, XrefRangeStart = 1087889, XrefRangeEnd = 1087920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TemporaryTileModelSpatialLookupMap(ComponentSystemBase ownerSystem)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TemporaryTileModelSpatialLookupMap>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ownerSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TemporaryTileModelSpatialLookupMap.NativeMethodInfoPtr__ctor_Public_Void_ComponentSystemBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1087937, RefRangeEnd = 1087938, XrefRangeStart = 1087921, XrefRangeEnd = 1087937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe JobHandle Build(JobHandle dependency)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &dependency;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TemporaryTileModelSpatialLookupMap.NativeMethodInfoPtr_Build_Public_JobHandle_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(JobHandle*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1087945, RefRangeEnd = 1087946, XrefRangeStart = 1087938, XrefRangeEnd = 1087945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TemporaryTileModelSpatialLookupMap.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087946, XrefRangeEnd = 1087952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe SpatialLookupParams GetLookupParamsAsync(
      ComponentSystemBase system,
      out JobHandle lookupDeps)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lookupDeps;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TemporaryTileModelSpatialLookupMap.NativeMethodInfoPtr_GetLookupParamsAsync_Public_Virtual_Final_New_SpatialLookupParams_ComponentSystemBase_byref_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SpatialLookupParams*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1087958, RefRangeEnd = 1087959, XrefRangeStart = 1087952, XrefRangeEnd = 1087958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe SpatialLookupParams GetLookupParamsAndComplete(ComponentSystemBase system)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TemporaryTileModelSpatialLookupMap.NativeMethodInfoPtr_GetLookupParamsAndComplete_Public_Virtual_Final_New_SpatialLookupParams_ComponentSystemBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SpatialLookupParams*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TemporaryTileModelSpatialLookupMap()
    {
      Il2CppClassPointerStore<TemporaryTileModelSpatialLookupMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (TemporaryTileModelSpatialLookupMap));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemporaryTileModelSpatialLookupMap>.NativeClassPtr);
      TemporaryTileModelSpatialLookupMap.NativeFieldInfoPtr__LookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporaryTileModelSpatialLookupMap>.NativeClassPtr, nameof (_LookupMap));
      TemporaryTileModelSpatialLookupMap.NativeFieldInfoPtr__AllTileModelsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporaryTileModelSpatialLookupMap>.NativeClassPtr, nameof (_AllTileModelsQuery));
      TemporaryTileModelSpatialLookupMap.NativeFieldInfoPtr__OwnerSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporaryTileModelSpatialLookupMap>.NativeClassPtr, nameof (_OwnerSystem));
      TemporaryTileModelSpatialLookupMap.NativeFieldInfoPtr__OverlappingCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporaryTileModelSpatialLookupMap>.NativeClassPtr, nameof (_OverlappingCells));
      TemporaryTileModelSpatialLookupMap.NativeMethodInfoPtr__ctor_Public_Void_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporaryTileModelSpatialLookupMap>.NativeClassPtr, 100685634);
      TemporaryTileModelSpatialLookupMap.NativeMethodInfoPtr_Build_Public_JobHandle_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporaryTileModelSpatialLookupMap>.NativeClassPtr, 100685635);
      TemporaryTileModelSpatialLookupMap.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporaryTileModelSpatialLookupMap>.NativeClassPtr, 100685636);
      TemporaryTileModelSpatialLookupMap.NativeMethodInfoPtr_GetLookupParamsAsync_Public_Virtual_Final_New_SpatialLookupParams_ComponentSystemBase_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporaryTileModelSpatialLookupMap>.NativeClassPtr, 100685637);
      TemporaryTileModelSpatialLookupMap.NativeMethodInfoPtr_GetLookupParamsAndComplete_Public_Virtual_Final_New_SpatialLookupParams_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporaryTileModelSpatialLookupMap>.NativeClassPtr, 100685638);
    }

    public TemporaryTileModelSpatialLookupMap(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeMultiHashMap<TileModelSpatialCell, TileModelSpatialEntity> _LookupMap
    {
      get
      {
        return *(NativeMultiHashMap<TileModelSpatialCell, TileModelSpatialEntity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TemporaryTileModelSpatialLookupMap.NativeFieldInfoPtr__LookupMap));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TemporaryTileModelSpatialLookupMap.NativeFieldInfoPtr__LookupMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeMultiHashMap<TileModelSpatialCell, TileModelSpatialEntity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _AllTileModelsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TemporaryTileModelSpatialLookupMap.NativeFieldInfoPtr__AllTileModelsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TemporaryTileModelSpatialLookupMap.NativeFieldInfoPtr__AllTileModelsQuery)) = value;
      }
    }

    public unsafe ComponentSystemBase _OwnerSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TemporaryTileModelSpatialLookupMap.NativeFieldInfoPtr__OwnerSystem));
        return pointer == System.IntPtr.Zero ? (ComponentSystemBase) null : new ComponentSystemBase(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TemporaryTileModelSpatialLookupMap.NativeFieldInfoPtr__OwnerSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<TileModelSpatialCell> _OverlappingCells
    {
      get
      {
        return *(NativeList<TileModelSpatialCell>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TemporaryTileModelSpatialLookupMap.NativeFieldInfoPtr__OverlappingCells));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TemporaryTileModelSpatialLookupMap.NativeFieldInfoPtr__OverlappingCells), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<TileModelSpatialCell>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
