// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.SpaceConversion
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  public static class SpaceConversion : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_WorldTileToIndex_Public_Static_Int32_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WorldTileToIndex_Public_Static_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WorldToIndex_Public_Static_Int32_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WorldToIndex_Public_Static_Int32_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ChunkTileToIndex_Public_Static_Int32_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ChunkTileToIndex_Public_Static_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WorldIndexToTile_Public_Static_int2_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WorldIndexToWorld_Public_Static_float2_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ChunkIndexToTile_Public_Static_int2_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WorldToTile_Public_Static_int2_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WorldToTile_Public_Static_int2_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WorldToTile_Public_Static_TileCoordinate_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WorldToTileSamples_Public_Static_int2x4_float2_byref_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WorldToTile_Public_Static_Int32_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WorldToPivotedTile_Public_Static_int2_Single_Single_TilePivotSettings_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WorldToPivotedTile_Public_Static_int2_float2_TilePivotSettings_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WorldToTileUnsnapped_Public_Static_float2_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WorldToTileUnsnapped_Public_Static_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LocalToTile_Public_Static_int2_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LocalToTile_Public_Static_int2_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LocalToTile_Public_Static_Int32_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LocalToPivotedTile_Public_Static_int2_Single_Single_TilePivotSettings_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LocalToPivotedTile_Public_Static_int2_float2_TilePivotSettings_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LocalToTileUnsnapped_Public_Static_float2_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LocalToTileUnsnapped_Public_Static_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TileToWorld_Public_Static_float2_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TileToWorld_Public_Static_float2_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TileToWorld_Public_Static_float2_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TileToWorld_Public_Static_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TileToWorld_Public_Static_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TileToWorld_Public_Static_float3_TileCoordinate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PivotedTileToWorld_Public_Static_float2_Int32_Int32_TilePivotSettings_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PivotedTileToWorld_Public_Static_float2_int2_TilePivotSettings_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TileToLocal_Public_Static_float2_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TileToLocal_Public_Static_float2_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TileToLocal_Public_Static_float2_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TileToLocal_Public_Static_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TileToLocal_Public_Static_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PivotedTileToLocal_Public_Static_float2_Int32_Int32_TilePivotSettings_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PivotedTileToLocal_Public_Static_float2_int2_TilePivotSettings_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PivotedTileToLocal_Public_Static_float2_float2_TilePivotSettings_TileRotation_0;

    [CallerCount(0)]
    public static unsafe int WorldTileToIndex(int2 pos)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &pos;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_WorldTileToIndex_Public_Static_Int32_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe int WorldTileToIndex(int x, int y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_WorldTileToIndex_Public_Static_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793462, XrefRangeEnd = 793463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int WorldToIndex(float x, float y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_WorldToIndex_Public_Static_Int32_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793463, XrefRangeEnd = 793464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int WorldToIndex(float2 pos)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &pos;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_WorldToIndex_Public_Static_Int32_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 768218, RefRangeEnd = 768223, XrefRangeStart = 768218, XrefRangeEnd = 768223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int ChunkTileToIndex(int2 pos)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &pos;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_ChunkTileToIndex_Public_Static_Int32_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 793464, RefRangeEnd = 793472, XrefRangeStart = 793464, XrefRangeEnd = 793464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int ChunkTileToIndex(int x, int y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_ChunkTileToIndex_Public_Static_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe int2 WorldIndexToTile(int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_WorldIndexToTile_Public_Static_int2_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe float2 WorldIndexToWorld(int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_WorldIndexToWorld_Public_Static_float2_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793472, RefRangeEnd = 793473, XrefRangeStart = 793472, XrefRangeEnd = 793472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 ChunkIndexToTile(int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_ChunkIndexToTile_Public_Static_int2_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793473, XrefRangeEnd = 793474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 WorldToTile(float x, float y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_WorldToTile_Public_Static_int2_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(73)]
    [CachedScanResults(RefRangeStart = 793475, RefRangeEnd = 793548, XrefRangeStart = 793474, XrefRangeEnd = 793475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 WorldToTile(float2 pos)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &pos;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_WorldToTile_Public_Static_int2_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 793549, RefRangeEnd = 793555, XrefRangeStart = 793548, XrefRangeEnd = 793549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileCoordinate WorldToTile(float3 pos)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &pos;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_WorldToTile_Public_Static_TileCoordinate_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileCoordinate*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793556, RefRangeEnd = 793557, XrefRangeStart = 793555, XrefRangeEnd = 793556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2x4 WorldToTileSamples(float2 pos, out float2 tileT)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileT;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_WorldToTileSamples_Public_Static_int2x4_float2_byref_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2x4*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793557, XrefRangeEnd = 793561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int WorldToTile(float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_WorldToTile_Public_Static_Int32_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793561, XrefRangeEnd = 793562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 WorldToPivotedTile(
      float x,
      float y,
      TilePivotSettings pivotSettings,
      TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pivotSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_WorldToPivotedTile_Public_Static_int2_Single_Single_TilePivotSettings_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793563, RefRangeEnd = 793564, XrefRangeStart = 793562, XrefRangeEnd = 793563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 WorldToPivotedTile(
      float2 pos,
      TilePivotSettings pivotSettings,
      TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pivotSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_WorldToPivotedTile_Public_Static_int2_float2_TilePivotSettings_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 793564, RefRangeEnd = 793568, XrefRangeStart = 793564, XrefRangeEnd = 793564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float2 WorldToTileUnsnapped(float2 pos)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &pos;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_WorldToTileUnsnapped_Public_Static_float2_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe float WorldToTileUnsnapped(float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_WorldToTileUnsnapped_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793568, XrefRangeEnd = 793569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 LocalToTile(float x, float y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_LocalToTile_Public_Static_int2_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 793570, RefRangeEnd = 793580, XrefRangeStart = 793569, XrefRangeEnd = 793570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 LocalToTile(float2 pos)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &pos;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_LocalToTile_Public_Static_int2_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793584, RefRangeEnd = 793585, XrefRangeStart = 793580, XrefRangeEnd = 793584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int LocalToTile(float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_LocalToTile_Public_Static_Int32_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793585, XrefRangeEnd = 793586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 LocalToPivotedTile(
      float x,
      float y,
      TilePivotSettings pivotSettings,
      TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pivotSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_LocalToPivotedTile_Public_Static_int2_Single_Single_TilePivotSettings_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793586, XrefRangeEnd = 793587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 LocalToPivotedTile(
      float2 pos,
      TilePivotSettings pivotSettings,
      TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pivotSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_LocalToPivotedTile_Public_Static_int2_float2_TilePivotSettings_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe float2 LocalToTileUnsnapped(float2 pos)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &pos;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_LocalToTileUnsnapped_Public_Static_float2_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793587, RefRangeEnd = 793588, XrefRangeStart = 793587, XrefRangeEnd = 793587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float LocalToTileUnsnapped(float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_LocalToTileUnsnapped_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793588, RefRangeEnd = 793589, XrefRangeStart = 793588, XrefRangeEnd = 793588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float2 TileToWorld(int x, int y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_TileToWorld_Public_Static_float2_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(42)]
    [CachedScanResults(RefRangeStart = 793589, RefRangeEnd = 793631, XrefRangeStart = 793589, XrefRangeEnd = 793589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float2 TileToWorld(int2 tile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tile;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_TileToWorld_Public_Static_float2_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 793631, RefRangeEnd = 793637, XrefRangeStart = 793631, XrefRangeEnd = 793631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float2 TileToWorld(float2 tile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tile;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_TileToWorld_Public_Static_float2_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe float TileToWorld(int value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_TileToWorld_Public_Static_Single_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe float TileToWorld(float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_TileToWorld_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 793638, RefRangeEnd = 793640, XrefRangeStart = 793637, XrefRangeEnd = 793638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float3 TileToWorld(TileCoordinate tile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tile;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_TileToWorld_Public_Static_float3_TileCoordinate_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793640, XrefRangeEnd = 793641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float2 PivotedTileToWorld(
      int x,
      int y,
      TilePivotSettings pivotSettings,
      TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pivotSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_PivotedTileToWorld_Public_Static_float2_Int32_Int32_TilePivotSettings_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793641, XrefRangeEnd = 793642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float2 PivotedTileToWorld(
      int2 tile,
      TilePivotSettings pivotSettings,
      TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &tile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pivotSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_PivotedTileToWorld_Public_Static_float2_int2_TilePivotSettings_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 793642, RefRangeEnd = 793649, XrefRangeStart = 793642, XrefRangeEnd = 793642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float2 TileToLocal(int x, int y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_TileToLocal_Public_Static_float2_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 793649, RefRangeEnd = 793658, XrefRangeStart = 793649, XrefRangeEnd = 793649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float2 TileToLocal(int2 tile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tile;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_TileToLocal_Public_Static_float2_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe float2 TileToLocal(float2 tile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tile;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_TileToLocal_Public_Static_float2_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 793658, RefRangeEnd = 793661, XrefRangeStart = 793658, XrefRangeEnd = 793658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float TileToLocal(int value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_TileToLocal_Public_Static_Single_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 793661, RefRangeEnd = 793665, XrefRangeStart = 793661, XrefRangeEnd = 793661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float TileToLocal(float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_TileToLocal_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793665, XrefRangeEnd = 793666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float2 PivotedTileToLocal(
      int x,
      int y,
      TilePivotSettings pivotSettings,
      TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pivotSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_PivotedTileToLocal_Public_Static_float2_Int32_Int32_TilePivotSettings_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793666, XrefRangeEnd = 793667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float2 PivotedTileToLocal(
      int2 tile,
      TilePivotSettings pivotSettings,
      TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &tile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pivotSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_PivotedTileToLocal_Public_Static_float2_int2_TilePivotSettings_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793667, XrefRangeEnd = 793668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float2 PivotedTileToLocal(
      float2 tile,
      TilePivotSettings pivotSettings,
      TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &tile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pivotSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpaceConversion.NativeMethodInfoPtr_PivotedTileToLocal_Public_Static_float2_float2_TilePivotSettings_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SpaceConversion()
    {
      Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (SpaceConversion));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr);
      SpaceConversion.NativeMethodInfoPtr_WorldTileToIndex_Public_Static_Int32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669897);
      SpaceConversion.NativeMethodInfoPtr_WorldTileToIndex_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669898);
      SpaceConversion.NativeMethodInfoPtr_WorldToIndex_Public_Static_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669899);
      SpaceConversion.NativeMethodInfoPtr_WorldToIndex_Public_Static_Int32_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669900);
      SpaceConversion.NativeMethodInfoPtr_ChunkTileToIndex_Public_Static_Int32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669901);
      SpaceConversion.NativeMethodInfoPtr_ChunkTileToIndex_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669902);
      SpaceConversion.NativeMethodInfoPtr_WorldIndexToTile_Public_Static_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669903);
      SpaceConversion.NativeMethodInfoPtr_WorldIndexToWorld_Public_Static_float2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669904);
      SpaceConversion.NativeMethodInfoPtr_ChunkIndexToTile_Public_Static_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669905);
      SpaceConversion.NativeMethodInfoPtr_WorldToTile_Public_Static_int2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669906);
      SpaceConversion.NativeMethodInfoPtr_WorldToTile_Public_Static_int2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669907);
      SpaceConversion.NativeMethodInfoPtr_WorldToTile_Public_Static_TileCoordinate_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669908);
      SpaceConversion.NativeMethodInfoPtr_WorldToTileSamples_Public_Static_int2x4_float2_byref_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669909);
      SpaceConversion.NativeMethodInfoPtr_WorldToTile_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669910);
      SpaceConversion.NativeMethodInfoPtr_WorldToPivotedTile_Public_Static_int2_Single_Single_TilePivotSettings_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669911);
      SpaceConversion.NativeMethodInfoPtr_WorldToPivotedTile_Public_Static_int2_float2_TilePivotSettings_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669912);
      SpaceConversion.NativeMethodInfoPtr_WorldToTileUnsnapped_Public_Static_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669913);
      SpaceConversion.NativeMethodInfoPtr_WorldToTileUnsnapped_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669914);
      SpaceConversion.NativeMethodInfoPtr_LocalToTile_Public_Static_int2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669915);
      SpaceConversion.NativeMethodInfoPtr_LocalToTile_Public_Static_int2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669916);
      SpaceConversion.NativeMethodInfoPtr_LocalToTile_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669917);
      SpaceConversion.NativeMethodInfoPtr_LocalToPivotedTile_Public_Static_int2_Single_Single_TilePivotSettings_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669918);
      SpaceConversion.NativeMethodInfoPtr_LocalToPivotedTile_Public_Static_int2_float2_TilePivotSettings_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669919);
      SpaceConversion.NativeMethodInfoPtr_LocalToTileUnsnapped_Public_Static_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669920);
      SpaceConversion.NativeMethodInfoPtr_LocalToTileUnsnapped_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669921);
      SpaceConversion.NativeMethodInfoPtr_TileToWorld_Public_Static_float2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669922);
      SpaceConversion.NativeMethodInfoPtr_TileToWorld_Public_Static_float2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669923);
      SpaceConversion.NativeMethodInfoPtr_TileToWorld_Public_Static_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669924);
      SpaceConversion.NativeMethodInfoPtr_TileToWorld_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669925);
      SpaceConversion.NativeMethodInfoPtr_TileToWorld_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669926);
      SpaceConversion.NativeMethodInfoPtr_TileToWorld_Public_Static_float3_TileCoordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669927);
      SpaceConversion.NativeMethodInfoPtr_PivotedTileToWorld_Public_Static_float2_Int32_Int32_TilePivotSettings_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669928);
      SpaceConversion.NativeMethodInfoPtr_PivotedTileToWorld_Public_Static_float2_int2_TilePivotSettings_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669929);
      SpaceConversion.NativeMethodInfoPtr_TileToLocal_Public_Static_float2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669930);
      SpaceConversion.NativeMethodInfoPtr_TileToLocal_Public_Static_float2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669931);
      SpaceConversion.NativeMethodInfoPtr_TileToLocal_Public_Static_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669932);
      SpaceConversion.NativeMethodInfoPtr_TileToLocal_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669933);
      SpaceConversion.NativeMethodInfoPtr_TileToLocal_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669934);
      SpaceConversion.NativeMethodInfoPtr_PivotedTileToLocal_Public_Static_float2_Int32_Int32_TilePivotSettings_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669935);
      SpaceConversion.NativeMethodInfoPtr_PivotedTileToLocal_Public_Static_float2_int2_TilePivotSettings_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669936);
      SpaceConversion.NativeMethodInfoPtr_PivotedTileToLocal_Public_Static_float2_float2_TilePivotSettings_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceConversion>.NativeClassPtr, 100669937);
    }

    public SpaceConversion(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
