// Decompiled with JetBrains decompiler
// Type: ProjectM.MapZoneCollection
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MapZoneCollection
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Empty;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpatialLookup;
    private static readonly System.IntPtr NativeFieldInfoPtr__MapZoneLookup;
    private static readonly System.IntPtr NativeFieldInfoPtr__GlobalCastleTerritory;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NativeReference_1_FixedList512_1_SpatialMapZoneData_NativeArray_1_FixedList512_1_SpatialMapZoneData_NativeHashMap_2_MapZoneId_SpatialMapZoneData_Nullable_Unboxed_1_SpatialMapZoneData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobalCastleTerritory_Public_Nullable_Unboxed_1_SpatialMapZoneData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetZonesInChunk_Public_byref_FixedList512_1_SpatialMapZoneData_TerrainChunk_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetZonesIntersectingBounds_Public_Void_BoundsMinMax_NativeList_1_SpatialMapZoneData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetZone_Public_Boolean_MapZoneId_byref_SpatialMapZoneData_0;
    [FieldOffset(0)]
    public readonly NativeReference<FixedList512<SpatialMapZoneData>> _Empty;
    [FieldOffset(16)]
    public readonly NativeArray<FixedList512<SpatialMapZoneData>> _SpatialLookup;
    [FieldOffset(32)]
    public readonly NativeHashMap<MapZoneId, SpatialMapZoneData> _MapZoneLookup;
    [FieldOffset(48)]
    public readonly Nullable_Unboxed<SpatialMapZoneData> _GlobalCastleTerritory;

    [CallerCount(0)]
    public unsafe MapZoneCollection(
      NativeReference<FixedList512<SpatialMapZoneData>> empty,
      NativeArray<FixedList512<SpatialMapZoneData>> spatialLookup,
      NativeHashMap<MapZoneId, SpatialMapZoneData> mapZoneLookup,
      Nullable_Unboxed<SpatialMapZoneData> globalCastleTerritory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &empty;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &spatialLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mapZoneLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &globalCastleTerritory;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneCollection.NativeMethodInfoPtr__ctor_Public_Void_NativeReference_1_FixedList512_1_SpatialMapZoneData_NativeArray_1_FixedList512_1_SpatialMapZoneData_NativeHashMap_2_MapZoneId_SpatialMapZoneData_Nullable_Unboxed_1_SpatialMapZoneData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe Nullable_Unboxed<SpatialMapZoneData> GetGlobalCastleTerritory()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneCollection.NativeMethodInfoPtr_GetGlobalCastleTerritory_Public_Nullable_Unboxed_1_SpatialMapZoneData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Nullable_Unboxed<SpatialMapZoneData>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 762280, RefRangeEnd = 762282, XrefRangeStart = 762273, XrefRangeEnd = 762280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public ref FixedList512<SpatialMapZoneData> GetZonesInChunk(TerrainChunk terrainChunk)
    {
      // ISSUE: unable to decompile the method.
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 762303, RefRangeEnd = 762308, XrefRangeStart = 762282, XrefRangeEnd = 762303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetZonesIntersectingBounds(
      BoundsMinMax worldBounds,
      NativeList<SpatialMapZoneData> zoneList)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &worldBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &zoneList;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapZoneCollection.NativeMethodInfoPtr_GetZonesIntersectingBounds_Public_Void_BoundsMinMax_NativeList_1_SpatialMapZoneData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 762311, RefRangeEnd = 762313, XrefRangeStart = 762308, XrefRangeEnd = 762311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetZone(MapZoneId mapZoneId, out SpatialMapZoneData mapZone)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &mapZoneId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapZone;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneCollection.NativeMethodInfoPtr_TryGetZone_Public_Boolean_MapZoneId_byref_SpatialMapZoneData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static MapZoneCollection()
    {
      Il2CppClassPointerStore<MapZoneCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MapZoneCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapZoneCollection>.NativeClassPtr);
      MapZoneCollection.NativeFieldInfoPtr__Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneCollection>.NativeClassPtr, nameof (_Empty));
      MapZoneCollection.NativeFieldInfoPtr__SpatialLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneCollection>.NativeClassPtr, nameof (_SpatialLookup));
      MapZoneCollection.NativeFieldInfoPtr__MapZoneLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneCollection>.NativeClassPtr, nameof (_MapZoneLookup));
      MapZoneCollection.NativeFieldInfoPtr__GlobalCastleTerritory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneCollection>.NativeClassPtr, nameof (_GlobalCastleTerritory));
      MapZoneCollection.NativeMethodInfoPtr__ctor_Public_Void_NativeReference_1_FixedList512_1_SpatialMapZoneData_NativeArray_1_FixedList512_1_SpatialMapZoneData_NativeHashMap_2_MapZoneId_SpatialMapZoneData_Nullable_Unboxed_1_SpatialMapZoneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneCollection>.NativeClassPtr, 100667356);
      MapZoneCollection.NativeMethodInfoPtr_GetGlobalCastleTerritory_Public_Nullable_Unboxed_1_SpatialMapZoneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneCollection>.NativeClassPtr, 100667357);
      MapZoneCollection.NativeMethodInfoPtr_GetZonesInChunk_Public_byref_FixedList512_1_SpatialMapZoneData_TerrainChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneCollection>.NativeClassPtr, 100667358);
      MapZoneCollection.NativeMethodInfoPtr_GetZonesIntersectingBounds_Public_Void_BoundsMinMax_NativeList_1_SpatialMapZoneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneCollection>.NativeClassPtr, 100667359);
      MapZoneCollection.NativeMethodInfoPtr_TryGetZone_Public_Boolean_MapZoneId_byref_SpatialMapZoneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneCollection>.NativeClassPtr, 100667360);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapZoneCollection>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
