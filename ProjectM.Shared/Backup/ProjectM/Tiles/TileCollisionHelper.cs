// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileCollisionHelper
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  public static class TileCollisionHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OurEpsilon;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateLinePolygon_Public_Static_TilePolygons_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateMapData_Public_Static_MapData_TilePolygons_TileWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateSnapshotMapData_Public_Static_SnapshotMapData_NativeSlice_1_Byte_NativeSlice_1_UInt16_TilePolygons_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SolveSlideCollision_Public_Static_float2_byref_TMapData_float2_float2_Byte_Single_byref_CollisionData_Boolean_byref_Boolean_WorldType_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SolveSlideCollision_Public_Static_float2_byref_TMapData_float2_float2_Byte_Single_byref_CollisionData_Boolean_byref_Boolean_byref_Boolean_WorldType_Entity_0;

    [CallerCount(21)]
    [CachedScanResults(RefRangeStart = 790521, RefRangeEnd = 790542, XrefRangeStart = 790494, XrefRangeEnd = 790521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileMapCollisionMath.TilePolygons CreateLinePolygon()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCollisionHelper.NativeMethodInfoPtr_CreateLinePolygon_Public_Static_TilePolygons_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileMapCollisionMath.TilePolygons*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(18)]
    [CachedScanResults(RefRangeStart = 790543, RefRangeEnd = 790561, XrefRangeStart = 790542, XrefRangeEnd = 790543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileMapCollisionMath.MapData CreateMapData(
      TileMapCollisionMath.TilePolygons tilePolygons,
      TileWorld tileWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tilePolygons;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileWorld;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCollisionHelper.NativeMethodInfoPtr_CreateMapData_Public_Static_MapData_TilePolygons_TileWorld_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileMapCollisionMath.MapData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 790562, RefRangeEnd = 790564, XrefRangeStart = 790561, XrefRangeEnd = 790562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileMapCollisionMath.SnapshotMapData CreateSnapshotMapData(
      NativeSlice<byte> collision,
      NativeSlice<ushort> gameplayHeights,
      TileMapCollisionMath.TilePolygons tilePolygons,
      int2 snapshotMapTileOffset)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &collision;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gameplayHeights;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tilePolygons;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotMapTileOffset;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCollisionHelper.NativeMethodInfoPtr_CreateSnapshotMapData_Public_Static_SnapshotMapData_NativeSlice_1_Byte_NativeSlice_1_UInt16_TilePolygons_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileMapCollisionMath.SnapshotMapData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe float2 SolveSlideCollision<TMapData, TCollisionCheck>(
      ref TMapData mapData,
      float2 startPosition,
      float2 endPosition,
      byte heightLevel,
      float radius,
      [In] ref TileMapCollisionMath.CollisionData collisionData,
      bool useTriangles,
      out bool insideBounds,
      WorldType worldType,
      Entity optionalCheckOwner)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[10];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mapData);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &endPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionData;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &useTriangles;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref insideBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &worldType;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &optionalCheckOwner;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCollisionHelper.MethodInfoStoreGeneric_SolveSlideCollision_Public_Static_float2_byref_TMapData_float2_float2_Byte_Single_byref_CollisionData_Boolean_byref_Boolean_WorldType_Entity_0<TMapData, TCollisionCheck>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TMapData local = ref mapData;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TMapData>(objectPointer, false, false);
      local = (TMapData) valueGeneric;
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 790571, RefRangeEnd = 790573, XrefRangeStart = 790564, XrefRangeEnd = 790571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float2 SolveSlideCollision<TMapData, TCollisionCheck>(
      ref TMapData mapData,
      float2 startPosition,
      float2 endPosition,
      byte heightLevel,
      float radius,
      [In] ref TileMapCollisionMath.CollisionData collisionData,
      bool useTriangles,
      out bool insideBounds,
      out bool alreadyInCollision,
      WorldType worldType,
      Entity optionalCheckOwner)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[11];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mapData);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &endPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionData;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &useTriangles;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref insideBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref alreadyInCollision;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &worldType;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &optionalCheckOwner;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCollisionHelper.MethodInfoStoreGeneric_SolveSlideCollision_Public_Static_float2_byref_TMapData_float2_float2_Byte_Single_byref_CollisionData_Boolean_byref_Boolean_byref_Boolean_WorldType_Entity_0<TMapData, TCollisionCheck>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TMapData local = ref mapData;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TMapData>(objectPointer, false, false);
      local = (TMapData) valueGeneric;
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TileCollisionHelper()
    {
      Il2CppClassPointerStore<TileCollisionHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileCollisionHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileCollisionHelper>.NativeClassPtr);
      TileCollisionHelper.NativeFieldInfoPtr_OurEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCollisionHelper>.NativeClassPtr, nameof (OurEpsilon));
      TileCollisionHelper.NativeMethodInfoPtr_CreateLinePolygon_Public_Static_TilePolygons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCollisionHelper>.NativeClassPtr, 100669544);
      TileCollisionHelper.NativeMethodInfoPtr_CreateMapData_Public_Static_MapData_TilePolygons_TileWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCollisionHelper>.NativeClassPtr, 100669545);
      TileCollisionHelper.NativeMethodInfoPtr_CreateSnapshotMapData_Public_Static_SnapshotMapData_NativeSlice_1_Byte_NativeSlice_1_UInt16_TilePolygons_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCollisionHelper>.NativeClassPtr, 100669546);
      TileCollisionHelper.NativeMethodInfoPtr_SolveSlideCollision_Public_Static_float2_byref_TMapData_float2_float2_Byte_Single_byref_CollisionData_Boolean_byref_Boolean_WorldType_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCollisionHelper>.NativeClassPtr, 100669547);
      TileCollisionHelper.NativeMethodInfoPtr_SolveSlideCollision_Public_Static_float2_byref_TMapData_float2_float2_Byte_Single_byref_CollisionData_Boolean_byref_Boolean_byref_Boolean_WorldType_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCollisionHelper>.NativeClassPtr, 100669548);
    }

    public TileCollisionHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe float OurEpsilon
    {
      get
      {
        float ourEpsilon;
        IL2CPP.il2cpp_field_static_get_value(TileCollisionHelper.NativeFieldInfoPtr_OurEpsilon, (void*) &ourEpsilon);
        return ourEpsilon;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileCollisionHelper.NativeFieldInfoPtr_OurEpsilon, (void*) &value);
      }
    }

    private sealed class MethodInfoStoreGeneric_SolveSlideCollision_Public_Static_float2_byref_TMapData_float2_float2_Byte_Single_byref_CollisionData_Boolean_byref_Boolean_WorldType_Entity_0<TMapData, TCollisionCheck>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TileCollisionHelper.NativeMethodInfoPtr_SolveSlideCollision_Public_Static_float2_byref_TMapData_float2_float2_Byte_Single_byref_CollisionData_Boolean_byref_Boolean_WorldType_Entity_0, Il2CppClassPointerStore<TileCollisionHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMapData>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCollisionCheck>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_SolveSlideCollision_Public_Static_float2_byref_TMapData_float2_float2_Byte_Single_byref_CollisionData_Boolean_byref_Boolean_byref_Boolean_WorldType_Entity_0<TMapData, TCollisionCheck>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TileCollisionHelper.NativeMethodInfoPtr_SolveSlideCollision_Public_Static_float2_byref_TMapData_float2_float2_Byte_Single_byref_CollisionData_Boolean_byref_Boolean_byref_Boolean_WorldType_Entity_0, Il2CppClassPointerStore<TileCollisionHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMapData>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCollisionCheck>.NativeClassPtr))
      }))));
    }
  }
}
