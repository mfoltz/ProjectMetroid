// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.TerrainChunk
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Terrain
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct TerrainChunk
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ChunkCoordinate;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MiddleOfTheWorld_Public_Static_get_TerrainChunk_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_X_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Y_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileOffset_Public_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBlockOffset_Public_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldOffset_Public_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldCenter_Public_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsWithinWorldLimit_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TerrainChunk_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromPosition_Public_Static_TerrainChunk_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromPosition_Public_Static_TerrainChunk_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromWorldTile_Public_Static_TerrainChunk_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRelativeTileCoordinate_Public_int2_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRelativeTileCoordinate_Public_int2_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRelativeTileCoordinate_Public_int2_float3_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalTileCoordinate_Public_Static_int2_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalTileCoordinate_Public_Static_int2_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalTileCoordinateFromWorldTile_Public_Static_int2_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBounds_Public_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAABB_Public_AABB_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToShared_Public_TerrainChunkShared_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetIntersectingChunks_Public_Static_Void_BoundsMinMax_NativeList_1_Intersection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetIntersectingChunks_Public_Static_NativeArray_1_Intersection_BoundsMinMax_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkTilesWithinWorldBounds_Public_Static_Void_TerrainChunkLookup_BufferFromEntity_1_T_BoundsMinMax_T_NativeArray_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FillTiles_Public_Static_Void_BoundsMinMax_int2_NativeArray_1_T_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldTransformMatrix_Public_float4x4_OrthogonalRotation_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldTransformMatrix_Public_Static_float4x4_OrthogonalRotation_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TerrainChunk_TerrainChunk_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TerrainChunk_TerrainChunk_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_TerrainChunk_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_TerrainChunk_0;
    [FieldOffset(0)]
    public int2 ChunkCoordinate;

    public static unsafe TerrainChunk MiddleOfTheWorld
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 767187, RefRangeEnd = 767189, XrefRangeStart = 767187, XrefRangeEnd = 767187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_get_MiddleOfTheWorld_Public_Static_get_TerrainChunk_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TerrainChunk*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int X
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_get_X_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int Y
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 107697, RefRangeEnd = 107730, XrefRangeStart = 107697, XrefRangeEnd = 107730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_get_Y_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(57)]
    [CachedScanResults(RefRangeStart = 56553, RefRangeEnd = 56610, XrefRangeStart = 56553, XrefRangeEnd = 56610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TerrainChunk(int x, int y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 261290, RefRangeEnd = 261301, XrefRangeStart = 261290, XrefRangeEnd = 261301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TerrainChunk(int2 xy)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &xy;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr__ctor_Public_Void_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 767189, RefRangeEnd = 767206, XrefRangeStart = 767189, XrefRangeEnd = 767189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int2 GetTileOffset()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_GetTileOffset_Public_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 767206, RefRangeEnd = 767207, XrefRangeStart = 767206, XrefRangeEnd = 767206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int2 GetBlockOffset()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_GetBlockOffset_Public_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 767207, RefRangeEnd = 767208, XrefRangeStart = 767207, XrefRangeEnd = 767207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float2 GetWorldOffset()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_GetWorldOffset_Public_float2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 767208, RefRangeEnd = 767212, XrefRangeStart = 767208, XrefRangeEnd = 767208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float2 GetWorldCenter()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_GetWorldCenter_Public_float2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 261553, RefRangeEnd = 261560, XrefRangeStart = 261553, XrefRangeEnd = 261560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767212, XrefRangeEnd = 767215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 767215, RefRangeEnd = 767218, XrefRangeStart = 767215, XrefRangeEnd = 767215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsWithinWorldLimit()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_IsWithinWorldLimit_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 767218, RefRangeEnd = 767231, XrefRangeStart = 767218, XrefRangeEnd = 767218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(int2 other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 767218, RefRangeEnd = 767231, XrefRangeStart = 767218, XrefRangeEnd = 767231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(TerrainChunk other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TerrainChunk_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(21)]
    [CachedScanResults(RefRangeStart = 767233, RefRangeEnd = 767254, XrefRangeStart = 767231, XrefRangeEnd = 767233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TerrainChunk FromPosition(float3 worldPos)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldPos;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_FromPosition_Public_Static_TerrainChunk_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TerrainChunk*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 767256, RefRangeEnd = 767270, XrefRangeStart = 767254, XrefRangeEnd = 767256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TerrainChunk FromPosition(float2 worldPos)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldPos;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_FromPosition_Public_Static_TerrainChunk_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TerrainChunk*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 767279, RefRangeEnd = 767285, XrefRangeStart = 767270, XrefRangeEnd = 767279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TerrainChunk FromWorldTile(int2 worldTile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldTile;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_FromWorldTile_Public_Static_TerrainChunk_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TerrainChunk*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 767286, RefRangeEnd = 767289, XrefRangeStart = 767285, XrefRangeEnd = 767286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int2 GetRelativeTileCoordinate(float3 worldPos)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldPos;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_GetRelativeTileCoordinate_Public_int2_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767289, XrefRangeEnd = 767290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int2 GetRelativeTileCoordinate(float2 worldPos)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldPos;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_GetRelativeTileCoordinate_Public_int2_float2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767290, XrefRangeEnd = 767292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int2 GetRelativeTileCoordinate(float3 worldPos, out bool insideChunk)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &worldPos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref insideChunk;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_GetRelativeTileCoordinate_Public_int2_float3_byref_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 767295, RefRangeEnd = 767296, XrefRangeStart = 767292, XrefRangeEnd = 767295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 GetLocalTileCoordinate(float3 worldPos)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldPos;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_GetLocalTileCoordinate_Public_Static_int2_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767296, XrefRangeEnd = 767299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 GetLocalTileCoordinate(float2 worldPos)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldPos;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_GetLocalTileCoordinate_Public_Static_int2_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767299, XrefRangeEnd = 767300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 GetLocalTileCoordinateFromWorldTile(int2 worldTile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldTile;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_GetLocalTileCoordinateFromWorldTile_Public_Static_int2_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 767300, RefRangeEnd = 767307, XrefRangeStart = 767300, XrefRangeEnd = 767300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BoundsMinMax GetBounds()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_GetBounds_Public_BoundsMinMax_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 767307, RefRangeEnd = 767308, XrefRangeStart = 767307, XrefRangeEnd = 767307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AABB GetAABB()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_GetAABB_Public_AABB_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AABB*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(54)]
    [CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TerrainChunkShared ToShared()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_ToShared_Public_TerrainChunkShared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TerrainChunkShared*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767308, XrefRangeEnd = 767321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetIntersectingChunks(
      BoundsMinMax worldBounds,
      NativeList<TerrainChunk.Intersection> intersections)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &worldBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &intersections;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_GetIntersectingChunks_Public_Static_Void_BoundsMinMax_NativeList_1_Intersection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 767393, RefRangeEnd = 767405, XrefRangeStart = 767321, XrefRangeEnd = 767393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeArray<TerrainChunk.Intersection> GetIntersectingChunks(
      BoundsMinMax worldBounds,
      Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &worldBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_GetIntersectingChunks_Public_Static_NativeArray_1_Intersection_BoundsMinMax_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeArray<TerrainChunk.Intersection>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe void GetChunkTilesWithinWorldBounds<T>(
      TerrainChunkLookup terrainChunks,
      BufferFromEntity<T> getTiles,
      BoundsMinMax worldBounds,
      T invalidDefaultValue,
      NativeArray<T> result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &terrainChunks;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getTiles;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &worldBounds;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) invalidDefaultValue;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref invalidDefaultValue;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TerrainChunk.MethodInfoStoreGeneric_GetChunkTilesWithinWorldBounds_Public_Static_Void_TerrainChunkLookup_BufferFromEntity_1_T_BoundsMinMax_T_NativeArray_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe void FillTiles<T>(
      BoundsMinMax arrayBounds,
      int2 arraySize,
      NativeArray<T> array,
      T value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &arrayBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &arraySize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &array;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) value;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TerrainChunk.MethodInfoStoreGeneric_FillTiles_Public_Static_Void_BoundsMinMax_int2_NativeArray_1_T_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 767407, RefRangeEnd = 767414, XrefRangeStart = 767405, XrefRangeEnd = 767407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float4x4 GetWorldTransformMatrix(
      OrthogonalRotation rotation,
      bool includeWorldOffset = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &includeWorldOffset;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_GetWorldTransformMatrix_Public_float4x4_OrthogonalRotation_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float4x4*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 767442, RefRangeEnd = 767447, XrefRangeStart = 767414, XrefRangeEnd = 767442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float4x4 GetWorldTransformMatrix(
      OrthogonalRotation rotation,
      float2 additionalWorldOffset = default (float2))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &additionalWorldOffset;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_GetWorldTransformMatrix_Public_Static_float4x4_OrthogonalRotation_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float4x4*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 767455, RefRangeEnd = 767457, XrefRangeStart = 767447, XrefRangeEnd = 767455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(658)]
    [CachedScanResults(RefRangeStart = 410500, RefRangeEnd = 411158, XrefRangeStart = 410500, XrefRangeEnd = 411158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator ==(TerrainChunk a, TerrainChunk b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TerrainChunk_TerrainChunk_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(543)]
    [CachedScanResults(RefRangeStart = 411158, RefRangeEnd = 411701, XrefRangeStart = 411158, XrefRangeEnd = 411701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator !=(TerrainChunk a, TerrainChunk b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TerrainChunk_TerrainChunk_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767457, XrefRangeEnd = 767464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryParse(string value, out TerrainChunk result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_TerrainChunk_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 767465, RefRangeEnd = 767466, XrefRangeStart = 767464, XrefRangeEnd = 767465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe int CompareTo(TerrainChunk other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_TerrainChunk_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TerrainChunk()
    {
      Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (TerrainChunk));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr);
      TerrainChunk.NativeFieldInfoPtr_ChunkCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, nameof (ChunkCoordinate));
      TerrainChunk.NativeMethodInfoPtr_get_MiddleOfTheWorld_Public_Static_get_TerrainChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667856);
      TerrainChunk.NativeMethodInfoPtr_get_X_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667857);
      TerrainChunk.NativeMethodInfoPtr_get_Y_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667858);
      TerrainChunk.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667859);
      TerrainChunk.NativeMethodInfoPtr__ctor_Public_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667860);
      TerrainChunk.NativeMethodInfoPtr_GetTileOffset_Public_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667861);
      TerrainChunk.NativeMethodInfoPtr_GetBlockOffset_Public_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667862);
      TerrainChunk.NativeMethodInfoPtr_GetWorldOffset_Public_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667863);
      TerrainChunk.NativeMethodInfoPtr_GetWorldCenter_Public_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667864);
      TerrainChunk.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667865);
      TerrainChunk.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667866);
      TerrainChunk.NativeMethodInfoPtr_IsWithinWorldLimit_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667867);
      TerrainChunk.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667868);
      TerrainChunk.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TerrainChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667869);
      TerrainChunk.NativeMethodInfoPtr_FromPosition_Public_Static_TerrainChunk_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667870);
      TerrainChunk.NativeMethodInfoPtr_FromPosition_Public_Static_TerrainChunk_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667871);
      TerrainChunk.NativeMethodInfoPtr_FromWorldTile_Public_Static_TerrainChunk_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667872);
      TerrainChunk.NativeMethodInfoPtr_GetRelativeTileCoordinate_Public_int2_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667873);
      TerrainChunk.NativeMethodInfoPtr_GetRelativeTileCoordinate_Public_int2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667874);
      TerrainChunk.NativeMethodInfoPtr_GetRelativeTileCoordinate_Public_int2_float3_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667875);
      TerrainChunk.NativeMethodInfoPtr_GetLocalTileCoordinate_Public_Static_int2_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667876);
      TerrainChunk.NativeMethodInfoPtr_GetLocalTileCoordinate_Public_Static_int2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667877);
      TerrainChunk.NativeMethodInfoPtr_GetLocalTileCoordinateFromWorldTile_Public_Static_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667878);
      TerrainChunk.NativeMethodInfoPtr_GetBounds_Public_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667879);
      TerrainChunk.NativeMethodInfoPtr_GetAABB_Public_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667880);
      TerrainChunk.NativeMethodInfoPtr_ToShared_Public_TerrainChunkShared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667881);
      TerrainChunk.NativeMethodInfoPtr_GetIntersectingChunks_Public_Static_Void_BoundsMinMax_NativeList_1_Intersection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667882);
      TerrainChunk.NativeMethodInfoPtr_GetIntersectingChunks_Public_Static_NativeArray_1_Intersection_BoundsMinMax_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667883);
      TerrainChunk.NativeMethodInfoPtr_GetChunkTilesWithinWorldBounds_Public_Static_Void_TerrainChunkLookup_BufferFromEntity_1_T_BoundsMinMax_T_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667884);
      TerrainChunk.NativeMethodInfoPtr_FillTiles_Public_Static_Void_BoundsMinMax_int2_NativeArray_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667885);
      TerrainChunk.NativeMethodInfoPtr_GetWorldTransformMatrix_Public_float4x4_OrthogonalRotation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667886);
      TerrainChunk.NativeMethodInfoPtr_GetWorldTransformMatrix_Public_Static_float4x4_OrthogonalRotation_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667887);
      TerrainChunk.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667888);
      TerrainChunk.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TerrainChunk_TerrainChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667889);
      TerrainChunk.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TerrainChunk_TerrainChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667890);
      TerrainChunk.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_TerrainChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667891);
      TerrainChunk.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_TerrainChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, 100667892);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Intersection
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TerrainChunk;
      private static readonly System.IntPtr NativeFieldInfoPtr_WorldBounds;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkBounds_Public_BoundsMinMax_0;
      [FieldOffset(0)]
      public TerrainChunk TerrainChunk;
      [FieldOffset(8)]
      public BoundsMinMax WorldBounds;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 767186, RefRangeEnd = 767187, XrefRangeStart = 767184, XrefRangeEnd = 767186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BoundsMinMax GetChunkBounds()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainChunk.Intersection.NativeMethodInfoPtr_GetChunkBounds_Public_BoundsMinMax_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Intersection()
      {
        Il2CppClassPointerStore<TerrainChunk.Intersection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr, nameof (Intersection));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainChunk.Intersection>.NativeClassPtr);
        TerrainChunk.Intersection.NativeFieldInfoPtr_TerrainChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainChunk.Intersection>.NativeClassPtr, nameof (TerrainChunk));
        TerrainChunk.Intersection.NativeFieldInfoPtr_WorldBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainChunk.Intersection>.NativeClassPtr, nameof (WorldBounds));
        TerrainChunk.Intersection.NativeMethodInfoPtr_GetChunkBounds_Public_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainChunk.Intersection>.NativeClassPtr, 100667893);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerrainChunk.Intersection>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    private sealed class MethodInfoStoreGeneric_GetChunkTilesWithinWorldBounds_Public_Static_Void_TerrainChunkLookup_BufferFromEntity_1_T_BoundsMinMax_T_NativeArray_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TerrainChunk.NativeMethodInfoPtr_GetChunkTilesWithinWorldBounds_Public_Static_Void_TerrainChunkLookup_BufferFromEntity_1_T_BoundsMinMax_T_NativeArray_1_T_0, Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_FillTiles_Public_Static_Void_BoundsMinMax_int2_NativeArray_1_T_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TerrainChunk.NativeMethodInfoPtr_FillTiles_Public_Static_Void_BoundsMinMax_int2_NativeArray_1_T_T_0, Il2CppClassPointerStore<TerrainChunk>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
