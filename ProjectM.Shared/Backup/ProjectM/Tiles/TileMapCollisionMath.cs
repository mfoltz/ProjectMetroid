// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileMapCollisionMath
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  public static class TileMapCollisionMath : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckMovingCircle_Public_Static_CollisionData_byref_MapData_float2_float2_Byte_Single_MapCollisionFlags_Boolean_WorldType_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckMovingCircle_Public_Static_CollisionData_byref_SnapshotMapData_float2_float2_Byte_Single_MapCollisionFlags_Boolean_WorldType_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileType_Private_Static_TileType_byref_TCollisionCheck_byref_CollisionIntersection_MapCollisionFlags_int2_int2_Boolean_byref_MapCollisionFlags_byref_MapCollisionFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckMovingCircle_Public_Static_CollisionData_byref_TMapData_float2_float2_Byte_Single_MapCollisionFlags_Boolean_WorldType_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckStaticCircle_Public_Static_Boolean_byref_MapData_float2_Byte_Single_MapCollisionFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckStaticCircle_Public_Static_Boolean_byref_TMapData_float2_Byte_Single_MapCollisionFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckStaticCircle_Public_Static_Boolean_byref_TMapData_float2_Byte_Single_MapCollisionFlags_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckCircleVsRectangleCollision_Private_Static_Boolean_float2_Single_float2_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckTilePolygonCollision_Private_Static_Boolean_NativeArray_1_Line_float2_float2_Single_float2_byref_float2_byref_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestPointOnLine_Private_Static_float2_float2_float2_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestPointOnLine_Public_Static_float2_float2_float2_float2_byref_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckLineToLineCollision_Private_Static_Boolean_float2_float2_float2_float2_byref_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckMovingCircleToLineCollision_Private_Static_Boolean_float2_float2_Single_float2_float2_byref_float2_byref_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileBoundsExclusive_Public_Static_Void_float2_float2_Single_int2_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileFromPosition_Public_Static_Void_float2_byref_Int32_byref_Int32_Boolean_0;

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 790697, RefRangeEnd = 790704, XrefRangeStart = 790694, XrefRangeEnd = 790697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileMapCollisionMath.CollisionData CheckMovingCircle(
      ref TileMapCollisionMath.MapData mapData,
      float2 startPosition,
      float2 endPosition,
      byte heightLevel,
      float radius,
      MapCollisionFlags collidesAgainstFlags,
      bool useTriangles,
      WorldType worldType,
      Entity optionalCheckOwner)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) ref mapData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &endPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesAgainstFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &useTriangles;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &worldType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &optionalCheckOwner;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.NativeMethodInfoPtr_CheckMovingCircle_Public_Static_CollisionData_byref_MapData_float2_float2_Byte_Single_MapCollisionFlags_Boolean_WorldType_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileMapCollisionMath.CollisionData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790704, XrefRangeEnd = 790707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileMapCollisionMath.CollisionData CheckMovingCircle(
      ref TileMapCollisionMath.SnapshotMapData mapData,
      float2 startPosition,
      float2 endPosition,
      byte heightLevel,
      float radius,
      MapCollisionFlags collidesAgainstFlags,
      bool useTriangles,
      WorldType worldType,
      Entity optionalCheckOwner)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) ref mapData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &endPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesAgainstFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &useTriangles;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &worldType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &optionalCheckOwner;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.NativeMethodInfoPtr_CheckMovingCircle_Public_Static_CollisionData_byref_SnapshotMapData_float2_float2_Byte_Single_MapCollisionFlags_Boolean_WorldType_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileMapCollisionMath.CollisionData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790707, XrefRangeEnd = 790714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileMapCollisionMath.TileType GetTileType<TCollisionCheck>(
      ref TCollisionCheck collisionCheck,
      ref TileMapCollisionMath.CollisionIntersection intersection,
      MapCollisionFlags collidesAgainstFlags,
      int2 tileXY,
      int2 tileOffset,
      bool useTriangles,
      out MapCollisionFlags tileCollisionFlags,
      out MapCollisionFlags overlappingCollisionFlags)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[8];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collisionCheck);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref intersection;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesAgainstFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &tileXY;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &tileOffset;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &useTriangles;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileCollisionFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref overlappingCollisionFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.MethodInfoStoreGeneric_GetTileType_Private_Static_TileType_byref_TCollisionCheck_byref_CollisionIntersection_MapCollisionFlags_int2_int2_Boolean_byref_MapCollisionFlags_byref_MapCollisionFlags_0<TCollisionCheck>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TCollisionCheck local = ref collisionCheck;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TCollisionCheck>(objectPointer, false, false);
      local = (TCollisionCheck) valueGeneric;
      return *(TileMapCollisionMath.TileType*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 790729, RefRangeEnd = 790730, XrefRangeStart = 790714, XrefRangeEnd = 790729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileMapCollisionMath.CollisionData CheckMovingCircle<TMapData, TCollisionCheck>(
      ref TMapData mapData,
      float2 startPosition,
      float2 endPosition,
      byte heightLevel,
      float radius,
      MapCollisionFlags collidesAgainstFlags,
      bool useTriangles,
      WorldType worldType,
      Entity optionalCheckOwner)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[9];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mapData);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &endPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesAgainstFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &useTriangles;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &worldType;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &optionalCheckOwner;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.MethodInfoStoreGeneric_CheckMovingCircle_Public_Static_CollisionData_byref_TMapData_float2_float2_Byte_Single_MapCollisionFlags_Boolean_WorldType_Entity_0<TMapData, TCollisionCheck>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TMapData local = ref mapData;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TMapData>(objectPointer, false, false);
      local = (TMapData) valueGeneric;
      return *(TileMapCollisionMath.CollisionData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 790733, RefRangeEnd = 790740, XrefRangeStart = 790730, XrefRangeEnd = 790733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CheckStaticCircle(
      ref TileMapCollisionMath.MapData mapData,
      float2 startPosition,
      byte heightLevel,
      float radius,
      MapCollisionFlags collidesAgainstFlags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref mapData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesAgainstFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.NativeMethodInfoPtr_CheckStaticCircle_Public_Static_Boolean_byref_MapData_float2_Byte_Single_MapCollisionFlags_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 790740, RefRangeEnd = 790741, XrefRangeStart = 790740, XrefRangeEnd = 790740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CheckStaticCircle<TMapData, TCollisionCheck>(
      ref TMapData mapData,
      float2 circlePosition,
      byte heightLevel,
      float circleRadius,
      MapCollisionFlags collidesAgainstFlags)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mapData);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &circlePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &circleRadius;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesAgainstFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.MethodInfoStoreGeneric_CheckStaticCircle_Public_Static_Boolean_byref_TMapData_float2_Byte_Single_MapCollisionFlags_0<TMapData, TCollisionCheck>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TMapData local = ref mapData;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TMapData>(objectPointer, false, false);
      local = (TMapData) valueGeneric;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790741, XrefRangeEnd = 790753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CheckStaticCircle<TMapData, TCollisionCheck>(
      ref TMapData mapData,
      float2 circlePosition,
      byte heightLevel,
      float circleRadius,
      MapCollisionFlags collidesAgainstFlags,
      out bool insideBounds)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[6];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mapData);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &circlePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &circleRadius;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &collidesAgainstFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref insideBounds;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.MethodInfoStoreGeneric_CheckStaticCircle_Public_Static_Boolean_byref_TMapData_float2_Byte_Single_MapCollisionFlags_byref_Boolean_0<TMapData, TCollisionCheck>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TMapData local = ref mapData;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TMapData>(objectPointer, false, false);
      local = (TMapData) valueGeneric;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 790757, RefRangeEnd = 790758, XrefRangeStart = 790753, XrefRangeEnd = 790757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CheckCircleVsRectangleCollision(
      float2 circlePosition,
      float circleRadius,
      float2 rectanglePosition,
      float2 rectangleSize)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &circlePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &circleRadius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rectanglePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &rectangleSize;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.NativeMethodInfoPtr_CheckCircleVsRectangleCollision_Private_Static_Boolean_float2_Single_float2_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 790762, RefRangeEnd = 790763, XrefRangeStart = 790758, XrefRangeEnd = 790762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CheckTilePolygonCollision(
      NativeArray<TileMapCollisionMath.Line> tilePolygons,
      float2 startPosition,
      float2 endPosition,
      float radius,
      float2 tilePosition,
      out float2 collisionPoint,
      out float2 collisionNormal)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &tilePolygons;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &endPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &tilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionPoint;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionNormal;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.NativeMethodInfoPtr_CheckTilePolygonCollision_Private_Static_Boolean_NativeArray_1_Line_float2_float2_Single_float2_byref_float2_byref_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790763, XrefRangeEnd = 790764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float2 GetClosestPointOnLine(
      float2 lineStart,
      float2 lineEnd,
      float2 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &lineStart;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &lineEnd;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.NativeMethodInfoPtr_GetClosestPointOnLine_Private_Static_float2_float2_float2_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 790767, RefRangeEnd = 790775, XrefRangeStart = 790764, XrefRangeEnd = 790767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float2 GetClosestPointOnLine(
      float2 lineStart,
      float2 lineEnd,
      float2 position,
      out float2 limitedClosestPoint)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &lineStart;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &lineEnd;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref limitedClosestPoint;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.NativeMethodInfoPtr_GetClosestPointOnLine_Public_Static_float2_float2_float2_float2_byref_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 790777, RefRangeEnd = 790778, XrefRangeStart = 790775, XrefRangeEnd = 790777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CheckLineToLineCollision(
      float2 lineStartA,
      float2 lineEndA,
      float2 lineStartB,
      float2 lineEndB,
      out float2 collisionPoint)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &lineStartA;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &lineEndA;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &lineStartB;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &lineEndB;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionPoint;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.NativeMethodInfoPtr_CheckLineToLineCollision_Private_Static_Boolean_float2_float2_float2_float2_byref_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 790798, RefRangeEnd = 790799, XrefRangeStart = 790778, XrefRangeEnd = 790798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CheckMovingCircleToLineCollision(
      float2 circleStartPosition,
      float2 circleEndPosition,
      float circleRadius,
      float2 lineStart,
      float2 lineEnd,
      out float2 collisionPoint,
      out float2 collisionNormal)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &circleStartPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &circleEndPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &circleRadius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &lineStart;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &lineEnd;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionPoint;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionNormal;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.NativeMethodInfoPtr_CheckMovingCircleToLineCollision_Private_Static_Boolean_float2_float2_Single_float2_float2_byref_float2_byref_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 790803, RefRangeEnd = 790807, XrefRangeStart = 790799, XrefRangeEnd = 790803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetTileBoundsExclusive(
      float2 circleStartPosition,
      float2 circleEndPosition,
      float circleRadius,
      int2 mapSizeInTiles,
      out int startTileX,
      out int startTileY,
      out int endTileX,
      out int endTileY,
      out bool isInsideBounds)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) &circleStartPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &circleEndPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &circleRadius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &mapSizeInTiles;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref startTileX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref startTileY;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref endTileX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref endTileY;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref isInsideBounds;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.NativeMethodInfoPtr_GetTileBoundsExclusive_Public_Static_Void_float2_float2_Single_int2_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 790824, RefRangeEnd = 790826, XrefRangeStart = 790807, XrefRangeEnd = 790824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetTileFromPosition(
      float2 position,
      out int tileX,
      out int tileY,
      bool useCeiling)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileY;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &useCeiling;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.NativeMethodInfoPtr_GetTileFromPosition_Public_Static_Void_float2_byref_Int32_byref_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TileMapCollisionMath()
    {
      Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileMapCollisionMath));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr);
      TileMapCollisionMath.NativeMethodInfoPtr_CheckMovingCircle_Public_Static_CollisionData_byref_MapData_float2_float2_Byte_Single_MapCollisionFlags_Boolean_WorldType_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr, 100669549);
      TileMapCollisionMath.NativeMethodInfoPtr_CheckMovingCircle_Public_Static_CollisionData_byref_SnapshotMapData_float2_float2_Byte_Single_MapCollisionFlags_Boolean_WorldType_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr, 100669550);
      TileMapCollisionMath.NativeMethodInfoPtr_GetTileType_Private_Static_TileType_byref_TCollisionCheck_byref_CollisionIntersection_MapCollisionFlags_int2_int2_Boolean_byref_MapCollisionFlags_byref_MapCollisionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr, 100669551);
      TileMapCollisionMath.NativeMethodInfoPtr_CheckMovingCircle_Public_Static_CollisionData_byref_TMapData_float2_float2_Byte_Single_MapCollisionFlags_Boolean_WorldType_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr, 100669552);
      TileMapCollisionMath.NativeMethodInfoPtr_CheckStaticCircle_Public_Static_Boolean_byref_MapData_float2_Byte_Single_MapCollisionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr, 100669553);
      TileMapCollisionMath.NativeMethodInfoPtr_CheckStaticCircle_Public_Static_Boolean_byref_TMapData_float2_Byte_Single_MapCollisionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr, 100669554);
      TileMapCollisionMath.NativeMethodInfoPtr_CheckStaticCircle_Public_Static_Boolean_byref_TMapData_float2_Byte_Single_MapCollisionFlags_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr, 100669555);
      TileMapCollisionMath.NativeMethodInfoPtr_CheckCircleVsRectangleCollision_Private_Static_Boolean_float2_Single_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr, 100669556);
      TileMapCollisionMath.NativeMethodInfoPtr_CheckTilePolygonCollision_Private_Static_Boolean_NativeArray_1_Line_float2_float2_Single_float2_byref_float2_byref_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr, 100669557);
      TileMapCollisionMath.NativeMethodInfoPtr_GetClosestPointOnLine_Private_Static_float2_float2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr, 100669558);
      TileMapCollisionMath.NativeMethodInfoPtr_GetClosestPointOnLine_Public_Static_float2_float2_float2_float2_byref_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr, 100669559);
      TileMapCollisionMath.NativeMethodInfoPtr_CheckLineToLineCollision_Private_Static_Boolean_float2_float2_float2_float2_byref_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr, 100669560);
      TileMapCollisionMath.NativeMethodInfoPtr_CheckMovingCircleToLineCollision_Private_Static_Boolean_float2_float2_Single_float2_float2_byref_float2_byref_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr, 100669561);
      TileMapCollisionMath.NativeMethodInfoPtr_GetTileBoundsExclusive_Public_Static_Void_float2_float2_Single_int2_byref_Int32_byref_Int32_byref_Int32_byref_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr, 100669562);
      TileMapCollisionMath.NativeMethodInfoPtr_GetTileFromPosition_Public_Static_Void_float2_byref_Int32_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr, 100669563);
    }

    public TileMapCollisionMath(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Line
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Start;
      private static readonly System.IntPtr NativeFieldInfoPtr_End;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_float2_float2_0;
      [FieldOffset(0)]
      public float2 Start;
      [FieldOffset(8)]
      public float2 End;

      [CallerCount(86)]
      [CachedScanResults(RefRangeStart = 212464, RefRangeEnd = 212550, XrefRangeStart = 212464, XrefRangeEnd = 212550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Line(float2 start, float2 end)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &start;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.Line.NativeMethodInfoPtr__ctor_Public_Void_float2_float2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Line()
      {
        Il2CppClassPointerStore<TileMapCollisionMath.Line>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr, nameof (Line));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileMapCollisionMath.Line>.NativeClassPtr);
        TileMapCollisionMath.Line.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.Line>.NativeClassPtr, nameof (Start));
        TileMapCollisionMath.Line.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.Line>.NativeClassPtr, nameof (End));
        TileMapCollisionMath.Line.NativeMethodInfoPtr__ctor_Public_Void_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.Line>.NativeClassPtr, 100669564);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileMapCollisionMath.Line>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CollisionData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CollisionPoint;
      private static readonly System.IntPtr NativeFieldInfoPtr_CollisionNormal;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsColliding;
      private static readonly System.IntPtr NativeFieldInfoPtr_InsideBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_OverlappingCollisionFlags;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileCollisionFlags;
      private static readonly System.IntPtr NativeFieldInfoPtr_CollidesAgainstFlags;
      private static readonly System.IntPtr NativeFieldInfoPtr_AlreadyInCollision;
      [FieldOffset(0)]
      public float2 CollisionPoint;
      [FieldOffset(8)]
      public float2 CollisionNormal;
      [FieldOffset(16)]
      public bool IsColliding;
      [FieldOffset(17)]
      public bool InsideBounds;
      [FieldOffset(18)]
      public MapCollisionFlags OverlappingCollisionFlags;
      [FieldOffset(19)]
      public MapCollisionFlags TileCollisionFlags;
      [FieldOffset(20)]
      public MapCollisionFlags CollidesAgainstFlags;
      [FieldOffset(21)]
      public bool AlreadyInCollision;

      static CollisionData()
      {
        Il2CppClassPointerStore<TileMapCollisionMath.CollisionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr, nameof (CollisionData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileMapCollisionMath.CollisionData>.NativeClassPtr);
        TileMapCollisionMath.CollisionData.NativeFieldInfoPtr_CollisionPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.CollisionData>.NativeClassPtr, nameof (CollisionPoint));
        TileMapCollisionMath.CollisionData.NativeFieldInfoPtr_CollisionNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.CollisionData>.NativeClassPtr, nameof (CollisionNormal));
        TileMapCollisionMath.CollisionData.NativeFieldInfoPtr_IsColliding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.CollisionData>.NativeClassPtr, nameof (IsColliding));
        TileMapCollisionMath.CollisionData.NativeFieldInfoPtr_InsideBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.CollisionData>.NativeClassPtr, nameof (InsideBounds));
        TileMapCollisionMath.CollisionData.NativeFieldInfoPtr_OverlappingCollisionFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.CollisionData>.NativeClassPtr, nameof (OverlappingCollisionFlags));
        TileMapCollisionMath.CollisionData.NativeFieldInfoPtr_TileCollisionFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.CollisionData>.NativeClassPtr, nameof (TileCollisionFlags));
        TileMapCollisionMath.CollisionData.NativeFieldInfoPtr_CollidesAgainstFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.CollisionData>.NativeClassPtr, nameof (CollidesAgainstFlags));
        TileMapCollisionMath.CollisionData.NativeFieldInfoPtr_AlreadyInCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.CollisionData>.NativeClassPtr, nameof (AlreadyInCollision));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileMapCollisionMath.CollisionData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CollisionIntersection
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CurrentCell;
      private static readonly System.IntPtr NativeFieldInfoPtr_CurrentCollisionTileLayer;
      private static readonly System.IntPtr NativeFieldInfoPtr_CurrentCollisionFlagsFilter;
      private static readonly System.IntPtr NativeFieldInfoPtr_CollisionFlagReader;
      private static readonly System.IntPtr NativeFieldInfoPtr_GameplayHeights;
      private static readonly System.IntPtr NativeFieldInfoPtr_Bounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileOffset;
      [FieldOffset(0)]
      public TileCell CurrentCell;
      [FieldOffset(8)]
      public TileLayer CurrentCollisionTileLayer;
      [FieldOffset(16)]
      public MapCollisionFlags CurrentCollisionFlagsFilter;
      [FieldOffset(18)]
      public TileCellEnumReader CollisionFlagReader;
      [FieldOffset(88)]
      public NativeArray<ushort> GameplayHeights;
      [FieldOffset(104)]
      public BoundsMinMax Bounds;
      [FieldOffset(120)]
      public int2 TileOffset;

      static CollisionIntersection()
      {
        Il2CppClassPointerStore<TileMapCollisionMath.CollisionIntersection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr, nameof (CollisionIntersection));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileMapCollisionMath.CollisionIntersection>.NativeClassPtr);
        TileMapCollisionMath.CollisionIntersection.NativeFieldInfoPtr_CurrentCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.CollisionIntersection>.NativeClassPtr, nameof (CurrentCell));
        TileMapCollisionMath.CollisionIntersection.NativeFieldInfoPtr_CurrentCollisionTileLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.CollisionIntersection>.NativeClassPtr, nameof (CurrentCollisionTileLayer));
        TileMapCollisionMath.CollisionIntersection.NativeFieldInfoPtr_CurrentCollisionFlagsFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.CollisionIntersection>.NativeClassPtr, nameof (CurrentCollisionFlagsFilter));
        TileMapCollisionMath.CollisionIntersection.NativeFieldInfoPtr_CollisionFlagReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.CollisionIntersection>.NativeClassPtr, nameof (CollisionFlagReader));
        TileMapCollisionMath.CollisionIntersection.NativeFieldInfoPtr_GameplayHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.CollisionIntersection>.NativeClassPtr, nameof (GameplayHeights));
        TileMapCollisionMath.CollisionIntersection.NativeFieldInfoPtr_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.CollisionIntersection>.NativeClassPtr, nameof (Bounds));
        TileMapCollisionMath.CollisionIntersection.NativeFieldInfoPtr_TileOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.CollisionIntersection>.NativeClassPtr, nameof (TileOffset));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileMapCollisionMath.CollisionIntersection>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public class ICollisionCheck : Il2CppObjectBase
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_IsValidIntersectionTile_Public_Abstract_Virtual_New_Boolean_int2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetCollisionFlags_Public_Abstract_Virtual_New_MapCollisionFlags_byref_CollisionIntersection_int2_MapCollisionFlags_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetGameplayHeight_Public_Abstract_Virtual_New_Single_byref_CollisionIntersection_int2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Boolean_byref_CollisionIntersection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0;

      [CallerCount(0)]
      public virtual unsafe bool IsValidIntersectionTile(int2 tile)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &tile;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileMapCollisionMath.ICollisionCheck.NativeMethodInfoPtr_IsValidIntersectionTile_Public_Abstract_Virtual_New_Boolean_int2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public virtual unsafe MapCollisionFlags GetCollisionFlags(
        ref TileMapCollisionMath.CollisionIntersection intersection,
        int2 tile,
        MapCollisionFlags relevantFlags)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref intersection;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tile;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &relevantFlags;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileMapCollisionMath.ICollisionCheck.NativeMethodInfoPtr_GetCollisionFlags_Public_Abstract_Virtual_New_MapCollisionFlags_byref_CollisionIntersection_int2_MapCollisionFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(MapCollisionFlags*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public virtual unsafe float GetGameplayHeight(
        ref TileMapCollisionMath.CollisionIntersection intersection,
        int2 tile)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref intersection;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tile;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileMapCollisionMath.ICollisionCheck.NativeMethodInfoPtr_GetGameplayHeight_Public_Abstract_Virtual_New_Single_byref_CollisionIntersection_int2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public virtual unsafe bool MoveNext(
        out TileMapCollisionMath.CollisionIntersection intersection)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref intersection;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileMapCollisionMath.ICollisionCheck.NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Boolean_byref_CollisionIntersection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public virtual unsafe void Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileMapCollisionMath.ICollisionCheck.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ICollisionCheck()
      {
        Il2CppClassPointerStore<TileMapCollisionMath.ICollisionCheck>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr, nameof (ICollisionCheck));
        TileMapCollisionMath.ICollisionCheck.NativeMethodInfoPtr_IsValidIntersectionTile_Public_Abstract_Virtual_New_Boolean_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.ICollisionCheck>.NativeClassPtr, 100669565);
        TileMapCollisionMath.ICollisionCheck.NativeMethodInfoPtr_GetCollisionFlags_Public_Abstract_Virtual_New_MapCollisionFlags_byref_CollisionIntersection_int2_MapCollisionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.ICollisionCheck>.NativeClassPtr, 100669566);
        TileMapCollisionMath.ICollisionCheck.NativeMethodInfoPtr_GetGameplayHeight_Public_Abstract_Virtual_New_Single_byref_CollisionIntersection_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.ICollisionCheck>.NativeClassPtr, 100669567);
        TileMapCollisionMath.ICollisionCheck.NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Boolean_byref_CollisionIntersection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.ICollisionCheck>.NativeClassPtr, 100669568);
        TileMapCollisionMath.ICollisionCheck.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.ICollisionCheck>.NativeClassPtr, 100669569);
      }

      public ICollisionCheck(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TilePolygons
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Square;
      private static readonly System.IntPtr NativeFieldInfoPtr_TriangleTopLeft;
      private static readonly System.IntPtr NativeFieldInfoPtr_TriangleTopRight;
      private static readonly System.IntPtr NativeFieldInfoPtr_TriangleBottomLeft;
      private static readonly System.IntPtr NativeFieldInfoPtr_TriangleBottomRight;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
      [FieldOffset(0)]
      public NativeArray<TileMapCollisionMath.Line> Square;
      [FieldOffset(16)]
      public NativeArray<TileMapCollisionMath.Line> TriangleTopLeft;
      [FieldOffset(32)]
      public NativeArray<TileMapCollisionMath.Line> TriangleTopRight;
      [FieldOffset(48)]
      public NativeArray<TileMapCollisionMath.Line> TriangleBottomLeft;
      [FieldOffset(64)]
      public NativeArray<TileMapCollisionMath.Line> TriangleBottomRight;

      [CallerCount(21)]
      [CachedScanResults(RefRangeStart = 790584, RefRangeEnd = 790605, XrefRangeStart = 790573, XrefRangeEnd = 790584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Dispose()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.TilePolygons.NativeMethodInfoPtr_Dispose_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TilePolygons()
      {
        Il2CppClassPointerStore<TileMapCollisionMath.TilePolygons>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr, nameof (TilePolygons));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileMapCollisionMath.TilePolygons>.NativeClassPtr);
        TileMapCollisionMath.TilePolygons.NativeFieldInfoPtr_Square = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.TilePolygons>.NativeClassPtr, nameof (Square));
        TileMapCollisionMath.TilePolygons.NativeFieldInfoPtr_TriangleTopLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.TilePolygons>.NativeClassPtr, nameof (TriangleTopLeft));
        TileMapCollisionMath.TilePolygons.NativeFieldInfoPtr_TriangleTopRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.TilePolygons>.NativeClassPtr, nameof (TriangleTopRight));
        TileMapCollisionMath.TilePolygons.NativeFieldInfoPtr_TriangleBottomLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.TilePolygons>.NativeClassPtr, nameof (TriangleBottomLeft));
        TileMapCollisionMath.TilePolygons.NativeFieldInfoPtr_TriangleBottomRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.TilePolygons>.NativeClassPtr, nameof (TriangleBottomRight));
        TileMapCollisionMath.TilePolygons.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.TilePolygons>.NativeClassPtr, 100669570);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileMapCollisionMath.TilePolygons>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public class IMapData<TCollisionCheck> : Il2CppObjectBase
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_get_MapSizeInTiles_Public_Abstract_Virtual_New_get_int2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_MapTileOffset_Public_Abstract_Virtual_New_get_int2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_TilePolygons_Public_Abstract_Virtual_New_get_TilePolygons_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_StartCollisionCheck_Public_Abstract_Virtual_New_TCollisionCheck_BoundsMinMax_Byte_Boolean_Allocator_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TileToWorld_Public_Abstract_Virtual_New_float2_Int32_Int32_0;

      public virtual unsafe int2 MapSizeInTiles
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileMapCollisionMath.IMapData<TCollisionCheck>.NativeMethodInfoPtr_get_MapSizeInTiles_Public_Abstract_Virtual_New_get_int2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int2*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public virtual unsafe int2 MapTileOffset
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileMapCollisionMath.IMapData<TCollisionCheck>.NativeMethodInfoPtr_get_MapTileOffset_Public_Abstract_Virtual_New_get_int2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int2*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public virtual unsafe TileMapCollisionMath.TilePolygons TilePolygons
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileMapCollisionMath.IMapData<TCollisionCheck>.NativeMethodInfoPtr_get_TilePolygons_Public_Abstract_Virtual_New_get_TilePolygons_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(TileMapCollisionMath.TilePolygons*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(0)]
      public virtual unsafe TCollisionCheck StartCollisionCheck(
        BoundsMinMax worldBounds,
        byte heightLevel,
        bool checkIfBoundsUnreasonable,
        Allocator allocator)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &worldBounds;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &checkIfBoundsUnreasonable;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
        System.IntPtr exc;
        System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileMapCollisionMath.IMapData<TCollisionCheck>.NativeMethodInfoPtr_StartCollisionCheck_Public_Abstract_Virtual_New_TCollisionCheck_BoundsMinMax_Byte_Boolean_Allocator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.PointerToValueGeneric<TCollisionCheck>(objectPointer, false, true);
      }

      [CallerCount(0)]
      public virtual unsafe float2 TileToWorld(int x, int y)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileMapCollisionMath.IMapData<TCollisionCheck>.NativeMethodInfoPtr_TileToWorld_Public_Abstract_Virtual_New_float2_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float2*) IL2CPP.il2cpp_object_unbox(num);
      }

      static IMapData()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<TileMapCollisionMath.IMapData<TCollisionCheck>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr, "IMapData`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCollisionCheck>.NativeClassPtr))
        }))).TypeHandle).value);
        TileMapCollisionMath.IMapData<TCollisionCheck>.NativeMethodInfoPtr_get_MapSizeInTiles_Public_Abstract_Virtual_New_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.IMapData<TCollisionCheck>>.NativeClassPtr, 100669571);
        TileMapCollisionMath.IMapData<TCollisionCheck>.NativeMethodInfoPtr_get_MapTileOffset_Public_Abstract_Virtual_New_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.IMapData<TCollisionCheck>>.NativeClassPtr, 100669572);
        TileMapCollisionMath.IMapData<TCollisionCheck>.NativeMethodInfoPtr_get_TilePolygons_Public_Abstract_Virtual_New_get_TilePolygons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.IMapData<TCollisionCheck>>.NativeClassPtr, 100669573);
        TileMapCollisionMath.IMapData<TCollisionCheck>.NativeMethodInfoPtr_StartCollisionCheck_Public_Abstract_Virtual_New_TCollisionCheck_BoundsMinMax_Byte_Boolean_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.IMapData<TCollisionCheck>>.NativeClassPtr, 100669574);
        TileMapCollisionMath.IMapData<TCollisionCheck>.NativeMethodInfoPtr_TileToWorld_Public_Abstract_Virtual_New_float2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.IMapData<TCollisionCheck>>.NativeClassPtr, 100669575);
      }

      public IMapData(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MapData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__TilePolygonData;
      private static readonly System.IntPtr NativeFieldInfoPtr__TileWorld;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TilePolygons_TileWorld_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_MapSizeInTiles_Public_Virtual_Final_New_get_int2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_MapTileOffset_Public_Virtual_Final_New_get_int2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_TilePolygons_Public_Virtual_Final_New_get_TilePolygons_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_StartCollisionCheck_Public_Virtual_Final_New_CollisionCheck_BoundsMinMax_Byte_Boolean_Allocator_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TileToWorld_Public_Virtual_Final_New_float2_Int32_Int32_0;
      [FieldOffset(0)]
      public readonly TileMapCollisionMath.TilePolygons _TilePolygonData;
      [FieldOffset(80)]
      public readonly TileWorld _TileWorld;

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 790651, RefRangeEnd = 790654, XrefRangeStart = 790651, XrefRangeEnd = 790651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe MapData(TileMapCollisionMath.TilePolygons tilePolygons, TileWorld tileWorld)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &tilePolygons;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileWorld;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.MapData.NativeMethodInfoPtr__ctor_Public_Void_TilePolygons_TileWorld_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe int2 MapSizeInTiles
      {
        [CallerCount(4), CachedScanResults(RefRangeStart = 790654, RefRangeEnd = 790658, XrefRangeStart = 790654, XrefRangeEnd = 790654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.MapData.NativeMethodInfoPtr_get_MapSizeInTiles_Public_Virtual_Final_New_get_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int2*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public virtual unsafe int2 MapTileOffset
      {
        [CallerCount(4), CachedScanResults(RefRangeStart = 790658, RefRangeEnd = 790662, XrefRangeStart = 790658, XrefRangeEnd = 790658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.MapData.NativeMethodInfoPtr_get_MapTileOffset_Public_Virtual_Final_New_get_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int2*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public virtual unsafe TileMapCollisionMath.TilePolygons TilePolygons
      {
        [CallerCount(1), CachedScanResults(RefRangeStart = 790662, RefRangeEnd = 790663, XrefRangeStart = 790662, XrefRangeEnd = 790662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.MapData.NativeMethodInfoPtr_get_TilePolygons_Public_Virtual_Final_New_get_TilePolygons_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(TileMapCollisionMath.TilePolygons*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 790665, RefRangeEnd = 790668, XrefRangeStart = 790663, XrefRangeEnd = 790665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe TileMapCollisionMath.MapData.CollisionCheck StartCollisionCheck(
        BoundsMinMax worldBounds,
        byte heightLevel,
        bool checkIfBoundsUnreasonable,
        Allocator allocator)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &worldBounds;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &checkIfBoundsUnreasonable;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.MapData.NativeMethodInfoPtr_StartCollisionCheck_Public_Virtual_Final_New_CollisionCheck_BoundsMinMax_Byte_Boolean_Allocator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TileMapCollisionMath.MapData.CollisionCheck*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 790669, RefRangeEnd = 790671, XrefRangeStart = 790668, XrefRangeEnd = 790669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe float2 TileToWorld(int x, int y)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.MapData.NativeMethodInfoPtr_TileToWorld_Public_Virtual_Final_New_float2_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float2*) IL2CPP.il2cpp_object_unbox(num);
      }

      static MapData()
      {
        Il2CppClassPointerStore<TileMapCollisionMath.MapData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr, nameof (MapData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileMapCollisionMath.MapData>.NativeClassPtr);
        TileMapCollisionMath.MapData.NativeFieldInfoPtr__TilePolygonData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.MapData>.NativeClassPtr, nameof (_TilePolygonData));
        TileMapCollisionMath.MapData.NativeFieldInfoPtr__TileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.MapData>.NativeClassPtr, nameof (_TileWorld));
        TileMapCollisionMath.MapData.NativeMethodInfoPtr__ctor_Public_Void_TilePolygons_TileWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.MapData>.NativeClassPtr, 100669576);
        TileMapCollisionMath.MapData.NativeMethodInfoPtr_get_MapSizeInTiles_Public_Virtual_Final_New_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.MapData>.NativeClassPtr, 100669577);
        TileMapCollisionMath.MapData.NativeMethodInfoPtr_get_MapTileOffset_Public_Virtual_Final_New_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.MapData>.NativeClassPtr, 100669578);
        TileMapCollisionMath.MapData.NativeMethodInfoPtr_get_TilePolygons_Public_Virtual_Final_New_get_TilePolygons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.MapData>.NativeClassPtr, 100669579);
        TileMapCollisionMath.MapData.NativeMethodInfoPtr_StartCollisionCheck_Public_Virtual_Final_New_CollisionCheck_BoundsMinMax_Byte_Boolean_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.MapData>.NativeClassPtr, 100669580);
        TileMapCollisionMath.MapData.NativeMethodInfoPtr_TileToWorld_Public_Virtual_Final_New_float2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.MapData>.NativeClassPtr, 100669581);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileMapCollisionMath.MapData>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct CollisionCheck
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_MapData;
        private static readonly System.IntPtr NativeFieldInfoPtr_HeightLevel;
        private static readonly System.IntPtr NativeFieldInfoPtr_CollisionIntersections;
        private static readonly System.IntPtr NativeFieldInfoPtr_CurrentIndex;
        private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_byref_CollisionIntersection_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_IsValidIntersectionTile_Public_Virtual_Final_New_Boolean_int2_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetCollisionFlags_Public_Virtual_Final_New_MapCollisionFlags_byref_CollisionIntersection_int2_MapCollisionFlags_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetGameplayHeight_Public_Virtual_Final_New_Single_byref_CollisionIntersection_int2_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
        [FieldOffset(0)]
        public TileMapCollisionMath.MapData MapData;
        [FieldOffset(104)]
        public byte HeightLevel;
        [FieldOffset(112)]
        public NativeArray<CellIntersection> CollisionIntersections;
        [FieldOffset(128)]
        public int CurrentIndex;

        [CallerCount(6)]
        [CachedScanResults(RefRangeStart = 790613, RefRangeEnd = 790619, XrefRangeStart = 790605, XrefRangeEnd = 790613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe bool MoveNext(
          out TileMapCollisionMath.CollisionIntersection intersection)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref intersection;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.MapData.CollisionCheck.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_byref_CollisionIntersection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(2)]
        [CachedScanResults(RefRangeStart = 790619, RefRangeEnd = 790621, XrefRangeStart = 790619, XrefRangeEnd = 790619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe bool IsValidIntersectionTile(int2 tile)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) &tile;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.MapData.CollisionCheck.NativeMethodInfoPtr_IsValidIntersectionTile_Public_Virtual_Final_New_Boolean_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(7)]
        [CachedScanResults(RefRangeStart = 790627, RefRangeEnd = 790634, XrefRangeStart = 790621, XrefRangeEnd = 790627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe MapCollisionFlags GetCollisionFlags(
          ref TileMapCollisionMath.CollisionIntersection intersection,
          int2 tile,
          MapCollisionFlags relevantFlags)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref intersection;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tile;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &relevantFlags;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.MapData.CollisionCheck.NativeMethodInfoPtr_GetCollisionFlags_Public_Virtual_Final_New_MapCollisionFlags_byref_CollisionIntersection_int2_MapCollisionFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(MapCollisionFlags*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 790643, RefRangeEnd = 790644, XrefRangeStart = 790634, XrefRangeEnd = 790643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe float GetGameplayHeight(
          ref TileMapCollisionMath.CollisionIntersection intersection,
          int2 tile)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) ref intersection;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tile;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.MapData.CollisionCheck.NativeMethodInfoPtr_GetGameplayHeight_Public_Virtual_Final_New_Single_byref_CollisionIntersection_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(float*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(4)]
        [CachedScanResults(RefRangeStart = 790647, RefRangeEnd = 790651, XrefRangeStart = 790644, XrefRangeEnd = 790647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Dispose()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.MapData.CollisionCheck.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static CollisionCheck()
        {
          Il2CppClassPointerStore<TileMapCollisionMath.MapData.CollisionCheck>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileMapCollisionMath.MapData>.NativeClassPtr, nameof (CollisionCheck));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileMapCollisionMath.MapData.CollisionCheck>.NativeClassPtr);
          TileMapCollisionMath.MapData.CollisionCheck.NativeFieldInfoPtr_MapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.MapData.CollisionCheck>.NativeClassPtr, nameof (MapData));
          TileMapCollisionMath.MapData.CollisionCheck.NativeFieldInfoPtr_HeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.MapData.CollisionCheck>.NativeClassPtr, nameof (HeightLevel));
          TileMapCollisionMath.MapData.CollisionCheck.NativeFieldInfoPtr_CollisionIntersections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.MapData.CollisionCheck>.NativeClassPtr, nameof (CollisionIntersections));
          TileMapCollisionMath.MapData.CollisionCheck.NativeFieldInfoPtr_CurrentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.MapData.CollisionCheck>.NativeClassPtr, nameof (CurrentIndex));
          TileMapCollisionMath.MapData.CollisionCheck.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_byref_CollisionIntersection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.MapData.CollisionCheck>.NativeClassPtr, 100669582);
          TileMapCollisionMath.MapData.CollisionCheck.NativeMethodInfoPtr_IsValidIntersectionTile_Public_Virtual_Final_New_Boolean_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.MapData.CollisionCheck>.NativeClassPtr, 100669583);
          TileMapCollisionMath.MapData.CollisionCheck.NativeMethodInfoPtr_GetCollisionFlags_Public_Virtual_Final_New_MapCollisionFlags_byref_CollisionIntersection_int2_MapCollisionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.MapData.CollisionCheck>.NativeClassPtr, 100669584);
          TileMapCollisionMath.MapData.CollisionCheck.NativeMethodInfoPtr_GetGameplayHeight_Public_Virtual_Final_New_Single_byref_CollisionIntersection_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.MapData.CollisionCheck>.NativeClassPtr, 100669585);
          TileMapCollisionMath.MapData.CollisionCheck.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.MapData.CollisionCheck>.NativeClassPtr, 100669586);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileMapCollisionMath.MapData.CollisionCheck>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SnapshotMapData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Collision;
      private static readonly System.IntPtr NativeFieldInfoPtr_GameplayHeights;
      private static readonly System.IntPtr NativeFieldInfoPtr_TilePolygons;
      private static readonly System.IntPtr NativeFieldInfoPtr_MapTileOffset;
      private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_Tiles_TileMapCollisionMath_IMapData_ProjectM_Tiles_TileMapCollisionMath_SnapshotMapData_CollisionCheck__get_TilePolygons_Private_Virtual_Final_New_get_TilePolygons_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_Tiles_TileMapCollisionMath_IMapData_ProjectM_Tiles_TileMapCollisionMath_SnapshotMapData_CollisionCheck__get_MapSizeInTiles_Private_Virtual_Final_New_get_int2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_Tiles_TileMapCollisionMath_IMapData_ProjectM_Tiles_TileMapCollisionMath_SnapshotMapData_CollisionCheck__get_MapTileOffset_Private_Virtual_Final_New_get_int2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NativeSlice_1_Byte_NativeSlice_1_UInt16_TilePolygons_int2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_Tiles_TileMapCollisionMath_IMapData_ProjectM_Tiles_TileMapCollisionMath_SnapshotMapData_CollisionCheck__StartCollisionCheck_Private_Virtual_Final_New_CollisionCheck_BoundsMinMax_Byte_Boolean_Allocator_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TileToWorld_Public_Virtual_Final_New_float2_Int32_Int32_0;
      [FieldOffset(0)]
      public NativeSlice<byte> Collision;
      [FieldOffset(16)]
      public NativeSlice<ushort> GameplayHeights;
      [FieldOffset(32)]
      public TileMapCollisionMath.TilePolygons TilePolygons;
      [FieldOffset(112)]
      public int2 MapTileOffset;

      public virtual unsafe TileMapCollisionMath.TilePolygons ProjectM\u002ETiles\u002ETileMapCollisionMath\u002EIMapData\u003CProjectM\u002ETiles\u002ETileMapCollisionMath\u002ESnapshotMapData\u002ECollisionCheck\u003E\u002ETilePolygons
      {
        [CallerCount(0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.SnapshotMapData.NativeMethodInfoPtr_ProjectM_Tiles_TileMapCollisionMath_IMapData_ProjectM_Tiles_TileMapCollisionMath_SnapshotMapData_CollisionCheck__get_TilePolygons_Private_Virtual_Final_New_get_TilePolygons_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(TileMapCollisionMath.TilePolygons*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public virtual unsafe int2 ProjectM\u002ETiles\u002ETileMapCollisionMath\u002EIMapData\u003CProjectM\u002ETiles\u002ETileMapCollisionMath\u002ESnapshotMapData\u002ECollisionCheck\u003E\u002EMapSizeInTiles
      {
        [CallerCount(0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.SnapshotMapData.NativeMethodInfoPtr_ProjectM_Tiles_TileMapCollisionMath_IMapData_ProjectM_Tiles_TileMapCollisionMath_SnapshotMapData_CollisionCheck__get_MapSizeInTiles_Private_Virtual_Final_New_get_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int2*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public virtual unsafe int2 ProjectM\u002ETiles\u002ETileMapCollisionMath\u002EIMapData\u003CProjectM\u002ETiles\u002ETileMapCollisionMath\u002ESnapshotMapData\u002ECollisionCheck\u003E\u002EMapTileOffset
      {
        [CallerCount(1), CachedScanResults(RefRangeStart = 22439, RefRangeEnd = 22440, XrefRangeStart = 22439, XrefRangeEnd = 22440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.SnapshotMapData.NativeMethodInfoPtr_ProjectM_Tiles_TileMapCollisionMath_IMapData_ProjectM_Tiles_TileMapCollisionMath_SnapshotMapData_CollisionCheck__get_MapTileOffset_Private_Virtual_Final_New_get_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int2*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 790683, RefRangeEnd = 790684, XrefRangeStart = 790683, XrefRangeEnd = 790683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SnapshotMapData(
        NativeSlice<byte> collision,
        NativeSlice<ushort> gameplayHeights,
        TileMapCollisionMath.TilePolygons tilePolygons,
        int2 mapTileOffset)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &collision;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gameplayHeights;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tilePolygons;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &mapTileOffset;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.SnapshotMapData.NativeMethodInfoPtr__ctor_Public_Void_NativeSlice_1_Byte_NativeSlice_1_UInt16_TilePolygons_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790684, XrefRangeEnd = 790693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe TileMapCollisionMath.SnapshotMapData.CollisionCheck ProjectM_Tiles_TileMapCollisionMath_IMapData_ProjectM_Tiles_TileMapCollisionMath_SnapshotMapData_CollisionCheck__StartCollisionCheck(
        BoundsMinMax worldBounds,
        byte heightLevel,
        bool checkIfBoundsUnreasonable,
        Allocator allocator)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &worldBounds;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &checkIfBoundsUnreasonable;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.SnapshotMapData.NativeMethodInfoPtr_ProjectM_Tiles_TileMapCollisionMath_IMapData_ProjectM_Tiles_TileMapCollisionMath_SnapshotMapData_CollisionCheck__StartCollisionCheck_Private_Virtual_Final_New_CollisionCheck_BoundsMinMax_Byte_Boolean_Allocator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TileMapCollisionMath.SnapshotMapData.CollisionCheck*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790693, XrefRangeEnd = 790694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe float2 TileToWorld(int x, int y)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &x;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.SnapshotMapData.NativeMethodInfoPtr_TileToWorld_Public_Virtual_Final_New_float2_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float2*) IL2CPP.il2cpp_object_unbox(num);
      }

      static SnapshotMapData()
      {
        Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr, nameof (SnapshotMapData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData>.NativeClassPtr);
        TileMapCollisionMath.SnapshotMapData.NativeFieldInfoPtr_Collision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData>.NativeClassPtr, nameof (Collision));
        TileMapCollisionMath.SnapshotMapData.NativeFieldInfoPtr_GameplayHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData>.NativeClassPtr, nameof (GameplayHeights));
        TileMapCollisionMath.SnapshotMapData.NativeFieldInfoPtr_TilePolygons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData>.NativeClassPtr, nameof (TilePolygons));
        TileMapCollisionMath.SnapshotMapData.NativeFieldInfoPtr_MapTileOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData>.NativeClassPtr, nameof (MapTileOffset));
        TileMapCollisionMath.SnapshotMapData.NativeMethodInfoPtr_ProjectM_Tiles_TileMapCollisionMath_IMapData_ProjectM_Tiles_TileMapCollisionMath_SnapshotMapData_CollisionCheck__get_TilePolygons_Private_Virtual_Final_New_get_TilePolygons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData>.NativeClassPtr, 100669587);
        TileMapCollisionMath.SnapshotMapData.NativeMethodInfoPtr_ProjectM_Tiles_TileMapCollisionMath_IMapData_ProjectM_Tiles_TileMapCollisionMath_SnapshotMapData_CollisionCheck__get_MapSizeInTiles_Private_Virtual_Final_New_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData>.NativeClassPtr, 100669588);
        TileMapCollisionMath.SnapshotMapData.NativeMethodInfoPtr_ProjectM_Tiles_TileMapCollisionMath_IMapData_ProjectM_Tiles_TileMapCollisionMath_SnapshotMapData_CollisionCheck__get_MapTileOffset_Private_Virtual_Final_New_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData>.NativeClassPtr, 100669589);
        TileMapCollisionMath.SnapshotMapData.NativeMethodInfoPtr__ctor_Public_Void_NativeSlice_1_Byte_NativeSlice_1_UInt16_TilePolygons_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData>.NativeClassPtr, 100669590);
        TileMapCollisionMath.SnapshotMapData.NativeMethodInfoPtr_ProjectM_Tiles_TileMapCollisionMath_IMapData_ProjectM_Tiles_TileMapCollisionMath_SnapshotMapData_CollisionCheck__StartCollisionCheck_Private_Virtual_Final_New_CollisionCheck_BoundsMinMax_Byte_Boolean_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData>.NativeClassPtr, 100669591);
        TileMapCollisionMath.SnapshotMapData.NativeMethodInfoPtr_TileToWorld_Public_Virtual_Final_New_float2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData>.NativeClassPtr, 100669592);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct CollisionCheck
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_MapData;
        private static readonly System.IntPtr NativeFieldInfoPtr_HeightLevel;
        private static readonly System.IntPtr NativeFieldInfoPtr_WorldBounds;
        private static readonly System.IntPtr NativeMethodInfoPtr_IsValidIntersectionTile_Public_Virtual_Final_New_Boolean_int2_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetCollision_Private_Byte_byref_CollisionIntersection_int2_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetCollisionFlags_Public_Virtual_Final_New_MapCollisionFlags_byref_CollisionIntersection_int2_MapCollisionFlags_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetGameplayHeight_Public_Virtual_Final_New_Single_byref_CollisionIntersection_int2_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_byref_CollisionIntersection_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
        [FieldOffset(0)]
        public TileMapCollisionMath.SnapshotMapData MapData;
        [FieldOffset(120)]
        public int HeightLevel;
        [FieldOffset(124)]
        public Nullable_Unboxed<BoundsMinMax> WorldBounds;

        [CallerCount(0)]
        public virtual unsafe bool IsValidIntersectionTile(int2 tile)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) &tile;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.SnapshotMapData.CollisionCheck.NativeMethodInfoPtr_IsValidIntersectionTile_Public_Virtual_Final_New_Boolean_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790671, XrefRangeEnd = 790674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe byte GetCollision(
          ref TileMapCollisionMath.CollisionIntersection intersection,
          int2 tile)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) ref intersection;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tile;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.SnapshotMapData.CollisionCheck.NativeMethodInfoPtr_GetCollision_Private_Byte_byref_CollisionIntersection_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(byte*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790674, XrefRangeEnd = 790677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe MapCollisionFlags GetCollisionFlags(
          ref TileMapCollisionMath.CollisionIntersection intersection,
          int2 tile,
          MapCollisionFlags relevantFlags)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref intersection;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tile;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &relevantFlags;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.SnapshotMapData.CollisionCheck.NativeMethodInfoPtr_GetCollisionFlags_Public_Virtual_Final_New_MapCollisionFlags_byref_CollisionIntersection_int2_MapCollisionFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(MapCollisionFlags*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790677, XrefRangeEnd = 790681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe float GetGameplayHeight(
          ref TileMapCollisionMath.CollisionIntersection intersection,
          int2 tile)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) ref intersection;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tile;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.SnapshotMapData.CollisionCheck.NativeMethodInfoPtr_GetGameplayHeight_Public_Virtual_Final_New_Single_byref_CollisionIntersection_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(float*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790681, XrefRangeEnd = 790683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe bool MoveNext(
          out TileMapCollisionMath.CollisionIntersection intersection)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref intersection;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.SnapshotMapData.CollisionCheck.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_byref_CollisionIntersection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        public virtual unsafe void Dispose()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(TileMapCollisionMath.SnapshotMapData.CollisionCheck.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static CollisionCheck()
        {
          Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData.CollisionCheck>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData>.NativeClassPtr, nameof (CollisionCheck));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData.CollisionCheck>.NativeClassPtr);
          TileMapCollisionMath.SnapshotMapData.CollisionCheck.NativeFieldInfoPtr_MapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData.CollisionCheck>.NativeClassPtr, nameof (MapData));
          TileMapCollisionMath.SnapshotMapData.CollisionCheck.NativeFieldInfoPtr_HeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData.CollisionCheck>.NativeClassPtr, nameof (HeightLevel));
          TileMapCollisionMath.SnapshotMapData.CollisionCheck.NativeFieldInfoPtr_WorldBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData.CollisionCheck>.NativeClassPtr, nameof (WorldBounds));
          TileMapCollisionMath.SnapshotMapData.CollisionCheck.NativeMethodInfoPtr_IsValidIntersectionTile_Public_Virtual_Final_New_Boolean_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData.CollisionCheck>.NativeClassPtr, 100669593);
          TileMapCollisionMath.SnapshotMapData.CollisionCheck.NativeMethodInfoPtr_GetCollision_Private_Byte_byref_CollisionIntersection_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData.CollisionCheck>.NativeClassPtr, 100669594);
          TileMapCollisionMath.SnapshotMapData.CollisionCheck.NativeMethodInfoPtr_GetCollisionFlags_Public_Virtual_Final_New_MapCollisionFlags_byref_CollisionIntersection_int2_MapCollisionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData.CollisionCheck>.NativeClassPtr, 100669595);
          TileMapCollisionMath.SnapshotMapData.CollisionCheck.NativeMethodInfoPtr_GetGameplayHeight_Public_Virtual_Final_New_Single_byref_CollisionIntersection_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData.CollisionCheck>.NativeClassPtr, 100669596);
          TileMapCollisionMath.SnapshotMapData.CollisionCheck.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_byref_CollisionIntersection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData.CollisionCheck>.NativeClassPtr, 100669597);
          TileMapCollisionMath.SnapshotMapData.CollisionCheck.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData.CollisionCheck>.NativeClassPtr, 100669598);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileMapCollisionMath.SnapshotMapData.CollisionCheck>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }

    public enum TileType
    {
      None,
      Square,
      TriangleTopLeft,
      TriangleTopRight,
      TriangleBottomLeft,
      TriangleBottomRight,
    }

    private sealed class MethodInfoStoreGeneric_GetTileType_Private_Static_TileType_byref_TCollisionCheck_byref_CollisionIntersection_MapCollisionFlags_int2_int2_Boolean_byref_MapCollisionFlags_byref_MapCollisionFlags_0<TCollisionCheck>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TileMapCollisionMath.NativeMethodInfoPtr_GetTileType_Private_Static_TileType_byref_TCollisionCheck_byref_CollisionIntersection_MapCollisionFlags_int2_int2_Boolean_byref_MapCollisionFlags_byref_MapCollisionFlags_0, Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCollisionCheck>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_CheckMovingCircle_Public_Static_CollisionData_byref_TMapData_float2_float2_Byte_Single_MapCollisionFlags_Boolean_WorldType_Entity_0<TMapData, TCollisionCheck>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TileMapCollisionMath.NativeMethodInfoPtr_CheckMovingCircle_Public_Static_CollisionData_byref_TMapData_float2_float2_Byte_Single_MapCollisionFlags_Boolean_WorldType_Entity_0, Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMapData>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCollisionCheck>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_CheckStaticCircle_Public_Static_Boolean_byref_TMapData_float2_Byte_Single_MapCollisionFlags_0<TMapData, TCollisionCheck>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TileMapCollisionMath.NativeMethodInfoPtr_CheckStaticCircle_Public_Static_Boolean_byref_TMapData_float2_Byte_Single_MapCollisionFlags_0, Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMapData>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCollisionCheck>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_CheckStaticCircle_Public_Static_Boolean_byref_TMapData_float2_Byte_Single_MapCollisionFlags_byref_Boolean_0<TMapData, TCollisionCheck>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TileMapCollisionMath.NativeMethodInfoPtr_CheckStaticCircle_Public_Static_Boolean_byref_TMapData_float2_Byte_Single_MapCollisionFlags_byref_Boolean_0, Il2CppClassPointerStore<TileMapCollisionMath>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMapData>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCollisionCheck>.NativeClassPtr))
      }))));
    }
  }
}
