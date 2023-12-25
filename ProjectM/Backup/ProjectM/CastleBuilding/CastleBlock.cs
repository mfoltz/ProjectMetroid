// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleBlock
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleBlock
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_int3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CastleBlock_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNeighbor_Public_CastleBlock_CardinalDirection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNeighbor_Public_CastleBlock_InterCardinalDirection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOriginPosition_Public_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCenterPosition_Public_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOriginTile_Public_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBounds_Public_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCenterTile_Public_int2_TilePivotType_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHeightLevel_Public_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_CastleBlock_byref_CastleBlock_byref_int3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_CastleBlock_byref_CastleBlock_byref_int3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_CastleBlock_byref_CastleBlock_byref_CastleBlock_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_CastleBlock_byref_CastleBlock_byref_CastleBlock_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_byref_CastleBlock_byref_CastleBlock_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_byref_CastleBlock_byref_CastleBlock_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFloorBlock_Public_Static_CastleBlock_byref_TilePosition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFloorBlock_Public_Static_CastleBlock_byref_TilePosition_byref_TilePivotSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFloorBlock_Public_Static_CastleBlock_byref_TileCoordinate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFloorBlock_Public_Static_CastleBlock_byref_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFloorBlock_Public_Static_CastleBlock_int2_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetWallBlock_Public_Static_CastleWallBlock_byref_TilePosition_byref_TilePivotSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPillarBlock_Public_Static_CastleBlock_byref_TilePosition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetWallBlockForFloor_Public_Static_CastleWallBlock_byref_CastleBlock_CardinalDirection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPillarBlockForFloor_Public_Static_CastleBlock_CastleBlock_InterCardinalDirection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_JustifyPillarBlock_Private_Static_Void_byref_int3_InterCardinalDirection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFrontDirection_Public_Static_int3_CartesianAxis_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCartesianAxis_Private_Static_CartesianAxis_TileRotation_0;
    [FieldOffset(0)]
    public int3 Value;

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 203152, RefRangeEnd = 203165, XrefRangeStart = 203152, XrefRangeEnd = 203165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleBlock(int3 value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr__ctor_Public_Void_int3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1126564, RefRangeEnd = 1126565, XrefRangeStart = 1126564, XrefRangeEnd = 1126564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleBlock(int2 tile, byte height)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr__ctor_Public_Void_int2_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1126565, RefRangeEnd = 1126567, XrefRangeStart = 1126565, XrefRangeEnd = 1126565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(CastleBlock other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CastleBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 254813, RefRangeEnd = 254814, XrefRangeStart = 254813, XrefRangeEnd = 254814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126567, XrefRangeEnd = 1126577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126577, XrefRangeEnd = 1126580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1126581, RefRangeEnd = 1126583, XrefRangeStart = 1126580, XrefRangeEnd = 1126581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleBlock GetNeighbor(CardinalDirection direction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &direction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_GetNeighbor_Public_CastleBlock_CardinalDirection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126583, XrefRangeEnd = 1126584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleBlock GetNeighbor(InterCardinalDirection direction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &direction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_GetNeighbor_Public_CastleBlock_InterCardinalDirection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1126585, RefRangeEnd = 1126588, XrefRangeStart = 1126584, XrefRangeEnd = 1126585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float3 GetOriginPosition()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_GetOriginPosition_Public_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1126589, RefRangeEnd = 1126591, XrefRangeStart = 1126588, XrefRangeEnd = 1126589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float3 GetCenterPosition()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_GetCenterPosition_Public_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1126591, RefRangeEnd = 1126593, XrefRangeStart = 1126591, XrefRangeEnd = 1126591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int2 GetOriginTile()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_GetOriginTile_Public_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1126594, RefRangeEnd = 1126597, XrefRangeStart = 1126593, XrefRangeEnd = 1126594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BoundsMinMax GetBounds()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_GetBounds_Public_BoundsMinMax_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1126598, RefRangeEnd = 1126599, XrefRangeStart = 1126597, XrefRangeEnd = 1126598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int2 GetCenterTile(TilePivotType tilePivot = TilePivotType.None, TileRotation tileRotation = TileRotation.None)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tilePivot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_GetCenterTile_Public_int2_TilePivotType_TileRotation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1126599, RefRangeEnd = 1126600, XrefRangeStart = 1126599, XrefRangeEnd = 1126599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe byte GetHeightLevel()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_GetHeightLevel_Public_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(byte*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(29)]
    [CachedScanResults(RefRangeStart = 1126600, RefRangeEnd = 1126629, XrefRangeStart = 1126600, XrefRangeEnd = 1126600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CastleBlock operator +([In] ref CastleBlock block, [In] ref int3 offset)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref block;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref offset;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_op_Addition_Public_Static_CastleBlock_byref_CastleBlock_byref_int3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 1126629, RefRangeEnd = 1126636, XrefRangeStart = 1126629, XrefRangeEnd = 1126629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CastleBlock operator -([In] ref CastleBlock block, [In] ref int3 offset)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref block;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref offset;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_op_Subtraction_Public_Static_CastleBlock_byref_CastleBlock_byref_int3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(29)]
    [CachedScanResults(RefRangeStart = 1126600, RefRangeEnd = 1126629, XrefRangeStart = 1126600, XrefRangeEnd = 1126629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CastleBlock operator +([In] ref CastleBlock block, [In] ref CastleBlock offset)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref block;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref offset;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_op_Addition_Public_Static_CastleBlock_byref_CastleBlock_byref_CastleBlock_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 1126629, RefRangeEnd = 1126636, XrefRangeStart = 1126629, XrefRangeEnd = 1126636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CastleBlock operator -([In] ref CastleBlock block, [In] ref CastleBlock offset)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref block;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref offset;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_op_Subtraction_Public_Static_CastleBlock_byref_CastleBlock_byref_CastleBlock_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1126565, RefRangeEnd = 1126567, XrefRangeStart = 1126565, XrefRangeEnd = 1126567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator ==([In] ref CastleBlock a, [In] ref CastleBlock b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_byref_CastleBlock_byref_CastleBlock_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool operator !=([In] ref CastleBlock a, [In] ref CastleBlock b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_byref_CastleBlock_byref_CastleBlock_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 1126639, RefRangeEnd = 1126646, XrefRangeStart = 1126636, XrefRangeEnd = 1126639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CastleBlock GetFloorBlock([In] ref TilePosition tilePosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref tilePosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_GetFloorBlock_Public_Static_CastleBlock_byref_TilePosition_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1126648, RefRangeEnd = 1126652, XrefRangeStart = 1126646, XrefRangeEnd = 1126648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CastleBlock GetFloorBlock(
      [In] ref TilePosition tilePosition,
      [In] ref TilePivotSettings tilePivot)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref tilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tilePivot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_GetFloorBlock_Public_Static_CastleBlock_byref_TilePosition_byref_TilePivotSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1126653, RefRangeEnd = 1126654, XrefRangeStart = 1126652, XrefRangeEnd = 1126653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CastleBlock GetFloorBlock([In] ref TileCoordinate tileCoordinate)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref tileCoordinate;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_GetFloorBlock_Public_Static_CastleBlock_byref_TileCoordinate_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126654, XrefRangeEnd = 1126656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CastleBlock GetFloorBlock([In] ref float3 worldPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref worldPosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_GetFloorBlock_Public_Static_CastleBlock_byref_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1126656, RefRangeEnd = 1126657, XrefRangeStart = 1126656, XrefRangeEnd = 1126656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CastleBlock GetFloorBlock(int2 worldTile, byte heightLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &worldTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_GetFloorBlock_Public_Static_CastleBlock_int2_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1126661, RefRangeEnd = 1126666, XrefRangeStart = 1126657, XrefRangeEnd = 1126661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CastleWallBlock GetWallBlock(
      [In] ref TilePosition tilePosition,
      [In] ref TilePivotSettings tilePivot)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref tilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tilePivot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_GetWallBlock_Public_Static_CastleWallBlock_byref_TilePosition_byref_TilePivotSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleWallBlock*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1126667, RefRangeEnd = 1126672, XrefRangeStart = 1126666, XrefRangeEnd = 1126667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CastleBlock GetPillarBlock([In] ref TilePosition tilePosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref tilePosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_GetPillarBlock_Public_Static_CastleBlock_byref_TilePosition_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1126678, RefRangeEnd = 1126682, XrefRangeStart = 1126672, XrefRangeEnd = 1126678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CastleWallBlock GetWallBlockForFloor(
      [In] ref CastleBlock floorBlock,
      CardinalDirection direction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref floorBlock;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_GetWallBlockForFloor_Public_Static_CastleWallBlock_byref_CastleBlock_CardinalDirection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleWallBlock*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1126683, RefRangeEnd = 1126688, XrefRangeStart = 1126682, XrefRangeEnd = 1126683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CastleBlock GetPillarBlockForFloor(
      CastleBlock floorBlock,
      InterCardinalDirection direction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &floorBlock;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_GetPillarBlockForFloor_Public_Static_CastleBlock_CastleBlock_InterCardinalDirection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe void JustifyPillarBlock(ref int3 block, InterCardinalDirection direction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref block;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_JustifyPillarBlock_Private_Static_Void_byref_int3_InterCardinalDirection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1126688, RefRangeEnd = 1126689, XrefRangeStart = 1126688, XrefRangeEnd = 1126688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int3 GetFrontDirection(CartesianAxis axis)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &axis;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_GetFrontDirection_Public_Static_int3_CartesianAxis_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe CartesianAxis GetCartesianAxis(TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.NativeMethodInfoPtr_GetCartesianAxis_Private_Static_CartesianAxis_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CartesianAxis*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CastleBlock()
    {
      Il2CppClassPointerStore<CastleBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (CastleBlock));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr);
      CastleBlock.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, nameof (Value));
      CastleBlock.NativeMethodInfoPtr__ctor_Public_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689389);
      CastleBlock.NativeMethodInfoPtr__ctor_Public_Void_int2_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689390);
      CastleBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689391);
      CastleBlock.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689392);
      CastleBlock.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689393);
      CastleBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689394);
      CastleBlock.NativeMethodInfoPtr_GetNeighbor_Public_CastleBlock_CardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689395);
      CastleBlock.NativeMethodInfoPtr_GetNeighbor_Public_CastleBlock_InterCardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689396);
      CastleBlock.NativeMethodInfoPtr_GetOriginPosition_Public_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689397);
      CastleBlock.NativeMethodInfoPtr_GetCenterPosition_Public_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689398);
      CastleBlock.NativeMethodInfoPtr_GetOriginTile_Public_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689399);
      CastleBlock.NativeMethodInfoPtr_GetBounds_Public_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689400);
      CastleBlock.NativeMethodInfoPtr_GetCenterTile_Public_int2_TilePivotType_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689401);
      CastleBlock.NativeMethodInfoPtr_GetHeightLevel_Public_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689402);
      CastleBlock.NativeMethodInfoPtr_op_Addition_Public_Static_CastleBlock_byref_CastleBlock_byref_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689403);
      CastleBlock.NativeMethodInfoPtr_op_Subtraction_Public_Static_CastleBlock_byref_CastleBlock_byref_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689404);
      CastleBlock.NativeMethodInfoPtr_op_Addition_Public_Static_CastleBlock_byref_CastleBlock_byref_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689405);
      CastleBlock.NativeMethodInfoPtr_op_Subtraction_Public_Static_CastleBlock_byref_CastleBlock_byref_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689406);
      CastleBlock.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_byref_CastleBlock_byref_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689407);
      CastleBlock.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_byref_CastleBlock_byref_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689408);
      CastleBlock.NativeMethodInfoPtr_GetFloorBlock_Public_Static_CastleBlock_byref_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689409);
      CastleBlock.NativeMethodInfoPtr_GetFloorBlock_Public_Static_CastleBlock_byref_TilePosition_byref_TilePivotSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689410);
      CastleBlock.NativeMethodInfoPtr_GetFloorBlock_Public_Static_CastleBlock_byref_TileCoordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689411);
      CastleBlock.NativeMethodInfoPtr_GetFloorBlock_Public_Static_CastleBlock_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689412);
      CastleBlock.NativeMethodInfoPtr_GetFloorBlock_Public_Static_CastleBlock_int2_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689413);
      CastleBlock.NativeMethodInfoPtr_GetWallBlock_Public_Static_CastleWallBlock_byref_TilePosition_byref_TilePivotSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689414);
      CastleBlock.NativeMethodInfoPtr_GetPillarBlock_Public_Static_CastleBlock_byref_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689415);
      CastleBlock.NativeMethodInfoPtr_GetWallBlockForFloor_Public_Static_CastleWallBlock_byref_CastleBlock_CardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689416);
      CastleBlock.NativeMethodInfoPtr_GetPillarBlockForFloor_Public_Static_CastleBlock_CastleBlock_InterCardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689417);
      CastleBlock.NativeMethodInfoPtr_JustifyPillarBlock_Private_Static_Void_byref_int3_InterCardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689418);
      CastleBlock.NativeMethodInfoPtr_GetFrontDirection_Public_Static_int3_CartesianAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689419);
      CastleBlock.NativeMethodInfoPtr_GetCartesianAxis_Private_Static_CartesianAxis_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, 100689420);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct FloorWallNeighborsEnumerator
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Block;
      private static readonly System.IntPtr NativeFieldInfoPtr_Step;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_CastleBlock_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_CastleWallBlock_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_CastleWallBlock_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_FloorWallNeighborsEnumerator_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_CastleBuilding_CastleWallBlock__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_CastleWallBlock_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
      [FieldOffset(0)]
      public readonly CastleBlock Block;
      [FieldOffset(12)]
      public int Step;

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1126473, RefRangeEnd = 1126477, XrefRangeStart = 1126473, XrefRangeEnd = 1126473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe FloorWallNeighborsEnumerator([In] ref CastleBlock floorBlock)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref floorBlock;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBlock.FloorWallNeighborsEnumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_CastleBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1126477, RefRangeEnd = 1126480, XrefRangeStart = 1126477, XrefRangeEnd = 1126477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.FloorWallNeighborsEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 137975, RefRangeEnd = 137979, XrefRangeStart = 137975, XrefRangeEnd = 137979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Reset()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBlock.FloorWallNeighborsEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe CastleWallBlock Current
      {
        [CallerCount(1), CachedScanResults(RefRangeStart = 1126481, RefRangeEnd = 1126482, XrefRangeStart = 1126480, XrefRangeEnd = 1126481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.FloorWallNeighborsEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_CastleWallBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CastleWallBlock*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public unsafe CastleWallBlock this[int index]
      {
        [CallerCount(2), CachedScanResults(RefRangeStart = 1126489, RefRangeEnd = 1126491, XrefRangeStart = 1126482, XrefRangeEnd = 1126489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) &index;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.FloorWallNeighborsEnumerator.NativeMethodInfoPtr_get_Item_Public_get_CastleWallBlock_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CastleWallBlock*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Dispose()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBlock.FloorWallNeighborsEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(46)]
      [CachedScanResults(RefRangeStart = 257985, RefRangeEnd = 258031, XrefRangeStart = 257985, XrefRangeEnd = 258031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe CastleBlock.FloorWallNeighborsEnumerator GetEnumerator()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.FloorWallNeighborsEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_FloorWallNeighborsEnumerator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CastleBlock.FloorWallNeighborsEnumerator*) IL2CPP.il2cpp_object_unbox(num);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126491, XrefRangeEnd = 1126495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.FloorWallNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126495, XrefRangeEnd = 1126498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe IEnumerator<CastleWallBlock> System_Collections_Generic_IEnumerable_ProjectM_CastleBuilding_CastleWallBlock__GetEnumerator()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.FloorWallNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_CastleBuilding_CastleWallBlock__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_CastleWallBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerator<CastleWallBlock>) null : new IEnumerator<CastleWallBlock>(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126498, XrefRangeEnd = 1126501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.FloorWallNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
      }

      static FloorWallNeighborsEnumerator()
      {
        Il2CppClassPointerStore<CastleBlock.FloorWallNeighborsEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, nameof (FloorWallNeighborsEnumerator));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBlock.FloorWallNeighborsEnumerator>.NativeClassPtr);
        CastleBlock.FloorWallNeighborsEnumerator.NativeFieldInfoPtr_Block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlock.FloorWallNeighborsEnumerator>.NativeClassPtr, nameof (Block));
        CastleBlock.FloorWallNeighborsEnumerator.NativeFieldInfoPtr_Step = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlock.FloorWallNeighborsEnumerator>.NativeClassPtr, nameof (Step));
        CastleBlock.FloorWallNeighborsEnumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.FloorWallNeighborsEnumerator>.NativeClassPtr, 100689421);
        CastleBlock.FloorWallNeighborsEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.FloorWallNeighborsEnumerator>.NativeClassPtr, 100689422);
        CastleBlock.FloorWallNeighborsEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.FloorWallNeighborsEnumerator>.NativeClassPtr, 100689423);
        CastleBlock.FloorWallNeighborsEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_CastleWallBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.FloorWallNeighborsEnumerator>.NativeClassPtr, 100689424);
        CastleBlock.FloorWallNeighborsEnumerator.NativeMethodInfoPtr_get_Item_Public_get_CastleWallBlock_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.FloorWallNeighborsEnumerator>.NativeClassPtr, 100689425);
        CastleBlock.FloorWallNeighborsEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.FloorWallNeighborsEnumerator>.NativeClassPtr, 100689426);
        CastleBlock.FloorWallNeighborsEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_FloorWallNeighborsEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.FloorWallNeighborsEnumerator>.NativeClassPtr, 100689427);
        CastleBlock.FloorWallNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.FloorWallNeighborsEnumerator>.NativeClassPtr, 100689428);
        CastleBlock.FloorWallNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_CastleBuilding_CastleWallBlock__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_CastleWallBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.FloorWallNeighborsEnumerator>.NativeClassPtr, 100689429);
        CastleBlock.FloorWallNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.FloorWallNeighborsEnumerator>.NativeClassPtr, 100689430);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBlock.FloorWallNeighborsEnumerator>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct WallFloorNeighborsEnumerator
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_WallBlock;
      private static readonly System.IntPtr NativeFieldInfoPtr_Step;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_CastleWallBlock_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_CastleBlock_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_CastleBlock_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_WallFloorNeighborsEnumerator_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_CastleBuilding_CastleBlock__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_CastleBlock_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
      [FieldOffset(0)]
      public readonly CastleWallBlock WallBlock;
      [FieldOffset(16)]
      public int Step;

      [CallerCount(9)]
      [CachedScanResults(RefRangeStart = 192785, RefRangeEnd = 192794, XrefRangeStart = 192785, XrefRangeEnd = 192794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe WallFloorNeighborsEnumerator([In] ref CastleWallBlock wallWallBlock)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref wallWallBlock;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBlock.WallFloorNeighborsEnumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_CastleWallBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public virtual unsafe bool MoveNext()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.WallFloorNeighborsEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 37032, RefRangeEnd = 37036, XrefRangeStart = 37032, XrefRangeEnd = 37036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Reset()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBlock.WallFloorNeighborsEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe CastleBlock Current
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126501, XrefRangeEnd = 1126502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.WallFloorNeighborsEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_CastleBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public unsafe CastleBlock this[int index]
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126502, XrefRangeEnd = 1126503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) &index;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.WallFloorNeighborsEnumerator.NativeMethodInfoPtr_get_Item_Public_get_CastleBlock_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Dispose()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBlock.WallFloorNeighborsEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe CastleBlock.WallFloorNeighborsEnumerator GetEnumerator()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.WallFloorNeighborsEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_WallFloorNeighborsEnumerator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CastleBlock.WallFloorNeighborsEnumerator*) IL2CPP.il2cpp_object_unbox(num);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126503, XrefRangeEnd = 1126508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.WallFloorNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126508, XrefRangeEnd = 1126511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe IEnumerator<CastleBlock> System_Collections_Generic_IEnumerable_ProjectM_CastleBuilding_CastleBlock__GetEnumerator()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.WallFloorNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_CastleBuilding_CastleBlock__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_CastleBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerator<CastleBlock>) null : new IEnumerator<CastleBlock>(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126511, XrefRangeEnd = 1126514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.WallFloorNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
      }

      static WallFloorNeighborsEnumerator()
      {
        Il2CppClassPointerStore<CastleBlock.WallFloorNeighborsEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, nameof (WallFloorNeighborsEnumerator));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBlock.WallFloorNeighborsEnumerator>.NativeClassPtr);
        CastleBlock.WallFloorNeighborsEnumerator.NativeFieldInfoPtr_WallBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlock.WallFloorNeighborsEnumerator>.NativeClassPtr, nameof (WallBlock));
        CastleBlock.WallFloorNeighborsEnumerator.NativeFieldInfoPtr_Step = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlock.WallFloorNeighborsEnumerator>.NativeClassPtr, nameof (Step));
        CastleBlock.WallFloorNeighborsEnumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_CastleWallBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.WallFloorNeighborsEnumerator>.NativeClassPtr, 100689431);
        CastleBlock.WallFloorNeighborsEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.WallFloorNeighborsEnumerator>.NativeClassPtr, 100689432);
        CastleBlock.WallFloorNeighborsEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.WallFloorNeighborsEnumerator>.NativeClassPtr, 100689433);
        CastleBlock.WallFloorNeighborsEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.WallFloorNeighborsEnumerator>.NativeClassPtr, 100689434);
        CastleBlock.WallFloorNeighborsEnumerator.NativeMethodInfoPtr_get_Item_Public_get_CastleBlock_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.WallFloorNeighborsEnumerator>.NativeClassPtr, 100689435);
        CastleBlock.WallFloorNeighborsEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.WallFloorNeighborsEnumerator>.NativeClassPtr, 100689436);
        CastleBlock.WallFloorNeighborsEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_WallFloorNeighborsEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.WallFloorNeighborsEnumerator>.NativeClassPtr, 100689437);
        CastleBlock.WallFloorNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.WallFloorNeighborsEnumerator>.NativeClassPtr, 100689438);
        CastleBlock.WallFloorNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_CastleBuilding_CastleBlock__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.WallFloorNeighborsEnumerator>.NativeClassPtr, 100689439);
        CastleBlock.WallFloorNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.WallFloorNeighborsEnumerator>.NativeClassPtr, 100689440);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBlock.WallFloorNeighborsEnumerator>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct FloorPillarNeighborsEnumerator
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Block;
      private static readonly System.IntPtr NativeFieldInfoPtr_Step;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_CastleBlock_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_CastleBlock_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_CastleBlock_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_FloorPillarNeighborsEnumerator_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_CastleBuilding_CastleBlock__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_CastleBlock_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
      [FieldOffset(0)]
      public readonly CastleBlock Block;
      [FieldOffset(12)]
      public int Step;

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1126473, RefRangeEnd = 1126477, XrefRangeStart = 1126473, XrefRangeEnd = 1126477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe FloorPillarNeighborsEnumerator([In] ref CastleBlock floorBlock)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref floorBlock;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBlock.FloorPillarNeighborsEnumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_CastleBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1126514, RefRangeEnd = 1126515, XrefRangeStart = 1126514, XrefRangeEnd = 1126514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.FloorPillarNeighborsEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 137975, RefRangeEnd = 137979, XrefRangeStart = 137975, XrefRangeEnd = 137979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Reset()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBlock.FloorPillarNeighborsEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe CastleBlock Current
      {
        [CallerCount(1), CachedScanResults(RefRangeStart = 1126516, RefRangeEnd = 1126517, XrefRangeStart = 1126515, XrefRangeEnd = 1126516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.FloorPillarNeighborsEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_CastleBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public unsafe CastleBlock this[int index]
      {
        [CallerCount(2), CachedScanResults(RefRangeStart = 1126517, RefRangeEnd = 1126519, XrefRangeStart = 1126517, XrefRangeEnd = 1126517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) &index;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.FloorPillarNeighborsEnumerator.NativeMethodInfoPtr_get_Item_Public_get_CastleBlock_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Dispose()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBlock.FloorPillarNeighborsEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(46)]
      [CachedScanResults(RefRangeStart = 257985, RefRangeEnd = 258031, XrefRangeStart = 257985, XrefRangeEnd = 258031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe CastleBlock.FloorPillarNeighborsEnumerator GetEnumerator()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.FloorPillarNeighborsEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_FloorPillarNeighborsEnumerator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CastleBlock.FloorPillarNeighborsEnumerator*) IL2CPP.il2cpp_object_unbox(num);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126519, XrefRangeEnd = 1126523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.FloorPillarNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126523, XrefRangeEnd = 1126526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe IEnumerator<CastleBlock> System_Collections_Generic_IEnumerable_ProjectM_CastleBuilding_CastleBlock__GetEnumerator()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.FloorPillarNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_CastleBuilding_CastleBlock__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_CastleBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerator<CastleBlock>) null : new IEnumerator<CastleBlock>(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126526, XrefRangeEnd = 1126529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.FloorPillarNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
      }

      static FloorPillarNeighborsEnumerator()
      {
        Il2CppClassPointerStore<CastleBlock.FloorPillarNeighborsEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, nameof (FloorPillarNeighborsEnumerator));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBlock.FloorPillarNeighborsEnumerator>.NativeClassPtr);
        CastleBlock.FloorPillarNeighborsEnumerator.NativeFieldInfoPtr_Block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlock.FloorPillarNeighborsEnumerator>.NativeClassPtr, nameof (Block));
        CastleBlock.FloorPillarNeighborsEnumerator.NativeFieldInfoPtr_Step = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlock.FloorPillarNeighborsEnumerator>.NativeClassPtr, nameof (Step));
        CastleBlock.FloorPillarNeighborsEnumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.FloorPillarNeighborsEnumerator>.NativeClassPtr, 100689441);
        CastleBlock.FloorPillarNeighborsEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.FloorPillarNeighborsEnumerator>.NativeClassPtr, 100689442);
        CastleBlock.FloorPillarNeighborsEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.FloorPillarNeighborsEnumerator>.NativeClassPtr, 100689443);
        CastleBlock.FloorPillarNeighborsEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.FloorPillarNeighborsEnumerator>.NativeClassPtr, 100689444);
        CastleBlock.FloorPillarNeighborsEnumerator.NativeMethodInfoPtr_get_Item_Public_get_CastleBlock_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.FloorPillarNeighborsEnumerator>.NativeClassPtr, 100689445);
        CastleBlock.FloorPillarNeighborsEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.FloorPillarNeighborsEnumerator>.NativeClassPtr, 100689446);
        CastleBlock.FloorPillarNeighborsEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_FloorPillarNeighborsEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.FloorPillarNeighborsEnumerator>.NativeClassPtr, 100689447);
        CastleBlock.FloorPillarNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.FloorPillarNeighborsEnumerator>.NativeClassPtr, 100689448);
        CastleBlock.FloorPillarNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_CastleBuilding_CastleBlock__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.FloorPillarNeighborsEnumerator>.NativeClassPtr, 100689449);
        CastleBlock.FloorPillarNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.FloorPillarNeighborsEnumerator>.NativeClassPtr, 100689450);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBlock.FloorPillarNeighborsEnumerator>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct PillarFloorNeighborsEnumerator
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Block;
      private static readonly System.IntPtr NativeFieldInfoPtr_Step;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_CastleBlock_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_CastleBlock_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_CastleBlock_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_PillarFloorNeighborsEnumerator_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_CastleBuilding_CastleBlock__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_CastleBlock_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
      [FieldOffset(0)]
      public readonly CastleBlock Block;
      [FieldOffset(12)]
      public int Step;

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1126473, RefRangeEnd = 1126477, XrefRangeStart = 1126473, XrefRangeEnd = 1126477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PillarFloorNeighborsEnumerator([In] ref CastleBlock pillarBlock)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref pillarBlock;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBlock.PillarFloorNeighborsEnumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_CastleBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1126514, RefRangeEnd = 1126515, XrefRangeStart = 1126514, XrefRangeEnd = 1126515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.PillarFloorNeighborsEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 137975, RefRangeEnd = 137979, XrefRangeStart = 137975, XrefRangeEnd = 137979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Reset()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBlock.PillarFloorNeighborsEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe CastleBlock Current
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126529, XrefRangeEnd = 1126530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.PillarFloorNeighborsEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_CastleBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public unsafe CastleBlock this[int index]
      {
        [CallerCount(2), CachedScanResults(RefRangeStart = 1126530, RefRangeEnd = 1126532, XrefRangeStart = 1126530, XrefRangeEnd = 1126530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) &index;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.PillarFloorNeighborsEnumerator.NativeMethodInfoPtr_get_Item_Public_get_CastleBlock_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Dispose()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBlock.PillarFloorNeighborsEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(46)]
      [CachedScanResults(RefRangeStart = 257985, RefRangeEnd = 258031, XrefRangeStart = 257985, XrefRangeEnd = 258031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe CastleBlock.PillarFloorNeighborsEnumerator GetEnumerator()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.PillarFloorNeighborsEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_PillarFloorNeighborsEnumerator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CastleBlock.PillarFloorNeighborsEnumerator*) IL2CPP.il2cpp_object_unbox(num);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126532, XrefRangeEnd = 1126536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.PillarFloorNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126536, XrefRangeEnd = 1126539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe IEnumerator<CastleBlock> System_Collections_Generic_IEnumerable_ProjectM_CastleBuilding_CastleBlock__GetEnumerator()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.PillarFloorNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_CastleBuilding_CastleBlock__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_CastleBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerator<CastleBlock>) null : new IEnumerator<CastleBlock>(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126539, XrefRangeEnd = 1126542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.PillarFloorNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
      }

      static PillarFloorNeighborsEnumerator()
      {
        Il2CppClassPointerStore<CastleBlock.PillarFloorNeighborsEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, nameof (PillarFloorNeighborsEnumerator));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBlock.PillarFloorNeighborsEnumerator>.NativeClassPtr);
        CastleBlock.PillarFloorNeighborsEnumerator.NativeFieldInfoPtr_Block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlock.PillarFloorNeighborsEnumerator>.NativeClassPtr, nameof (Block));
        CastleBlock.PillarFloorNeighborsEnumerator.NativeFieldInfoPtr_Step = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlock.PillarFloorNeighborsEnumerator>.NativeClassPtr, nameof (Step));
        CastleBlock.PillarFloorNeighborsEnumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.PillarFloorNeighborsEnumerator>.NativeClassPtr, 100689451);
        CastleBlock.PillarFloorNeighborsEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.PillarFloorNeighborsEnumerator>.NativeClassPtr, 100689452);
        CastleBlock.PillarFloorNeighborsEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.PillarFloorNeighborsEnumerator>.NativeClassPtr, 100689453);
        CastleBlock.PillarFloorNeighborsEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.PillarFloorNeighborsEnumerator>.NativeClassPtr, 100689454);
        CastleBlock.PillarFloorNeighborsEnumerator.NativeMethodInfoPtr_get_Item_Public_get_CastleBlock_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.PillarFloorNeighborsEnumerator>.NativeClassPtr, 100689455);
        CastleBlock.PillarFloorNeighborsEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.PillarFloorNeighborsEnumerator>.NativeClassPtr, 100689456);
        CastleBlock.PillarFloorNeighborsEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_PillarFloorNeighborsEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.PillarFloorNeighborsEnumerator>.NativeClassPtr, 100689457);
        CastleBlock.PillarFloorNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.PillarFloorNeighborsEnumerator>.NativeClassPtr, 100689458);
        CastleBlock.PillarFloorNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_CastleBuilding_CastleBlock__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.PillarFloorNeighborsEnumerator>.NativeClassPtr, 100689459);
        CastleBlock.PillarFloorNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.PillarFloorNeighborsEnumerator>.NativeClassPtr, 100689460);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBlock.PillarFloorNeighborsEnumerator>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct PillarWallNeighborsEnumerator
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Block;
      private static readonly System.IntPtr NativeFieldInfoPtr_Step;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_CastleBlock_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_CastleWallBlock_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_CastleWallBlock_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_PillarWallNeighborsEnumerator_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_CastleBuilding_CastleWallBlock__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_CastleWallBlock_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
      [FieldOffset(0)]
      public readonly CastleBlock Block;
      [FieldOffset(12)]
      public int Step;

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1126473, RefRangeEnd = 1126477, XrefRangeStart = 1126473, XrefRangeEnd = 1126477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PillarWallNeighborsEnumerator([In] ref CastleBlock pillarBlock)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref pillarBlock;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBlock.PillarWallNeighborsEnumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_CastleBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1126477, RefRangeEnd = 1126480, XrefRangeStart = 1126477, XrefRangeEnd = 1126480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.PillarWallNeighborsEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 137975, RefRangeEnd = 137979, XrefRangeStart = 137975, XrefRangeEnd = 137979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Reset()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBlock.PillarWallNeighborsEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe CastleWallBlock Current
      {
        [CallerCount(2), CachedScanResults(RefRangeStart = 1126543, RefRangeEnd = 1126545, XrefRangeStart = 1126542, XrefRangeEnd = 1126543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.PillarWallNeighborsEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_CastleWallBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CastleWallBlock*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      public unsafe CastleWallBlock this[int index]
      {
        [CallerCount(2), CachedScanResults(RefRangeStart = 1126552, RefRangeEnd = 1126554, XrefRangeStart = 1126545, XrefRangeEnd = 1126552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) &index;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.PillarWallNeighborsEnumerator.NativeMethodInfoPtr_get_Item_Public_get_CastleWallBlock_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CastleWallBlock*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Dispose()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBlock.PillarWallNeighborsEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(46)]
      [CachedScanResults(RefRangeStart = 257985, RefRangeEnd = 258031, XrefRangeStart = 257985, XrefRangeEnd = 258031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe CastleBlock.PillarWallNeighborsEnumerator GetEnumerator()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.PillarWallNeighborsEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_PillarWallNeighborsEnumerator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CastleBlock.PillarWallNeighborsEnumerator*) IL2CPP.il2cpp_object_unbox(num);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126554, XrefRangeEnd = 1126558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.PillarWallNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126558, XrefRangeEnd = 1126561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe IEnumerator<CastleWallBlock> System_Collections_Generic_IEnumerable_ProjectM_CastleBuilding_CastleWallBlock__GetEnumerator()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.PillarWallNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_CastleBuilding_CastleWallBlock__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_CastleWallBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerator<CastleWallBlock>) null : new IEnumerator<CastleWallBlock>(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126561, XrefRangeEnd = 1126564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBlock.PillarWallNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
      }

      static PillarWallNeighborsEnumerator()
      {
        Il2CppClassPointerStore<CastleBlock.PillarWallNeighborsEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBlock>.NativeClassPtr, nameof (PillarWallNeighborsEnumerator));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBlock.PillarWallNeighborsEnumerator>.NativeClassPtr);
        CastleBlock.PillarWallNeighborsEnumerator.NativeFieldInfoPtr_Block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlock.PillarWallNeighborsEnumerator>.NativeClassPtr, nameof (Block));
        CastleBlock.PillarWallNeighborsEnumerator.NativeFieldInfoPtr_Step = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlock.PillarWallNeighborsEnumerator>.NativeClassPtr, nameof (Step));
        CastleBlock.PillarWallNeighborsEnumerator.NativeMethodInfoPtr__ctor_Public_Void_byref_CastleBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.PillarWallNeighborsEnumerator>.NativeClassPtr, 100689461);
        CastleBlock.PillarWallNeighborsEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.PillarWallNeighborsEnumerator>.NativeClassPtr, 100689462);
        CastleBlock.PillarWallNeighborsEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.PillarWallNeighborsEnumerator>.NativeClassPtr, 100689463);
        CastleBlock.PillarWallNeighborsEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_CastleWallBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.PillarWallNeighborsEnumerator>.NativeClassPtr, 100689464);
        CastleBlock.PillarWallNeighborsEnumerator.NativeMethodInfoPtr_get_Item_Public_get_CastleWallBlock_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.PillarWallNeighborsEnumerator>.NativeClassPtr, 100689465);
        CastleBlock.PillarWallNeighborsEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.PillarWallNeighborsEnumerator>.NativeClassPtr, 100689466);
        CastleBlock.PillarWallNeighborsEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_PillarWallNeighborsEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.PillarWallNeighborsEnumerator>.NativeClassPtr, 100689467);
        CastleBlock.PillarWallNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.PillarWallNeighborsEnumerator>.NativeClassPtr, 100689468);
        CastleBlock.PillarWallNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_ProjectM_CastleBuilding_CastleWallBlock__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_CastleWallBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.PillarWallNeighborsEnumerator>.NativeClassPtr, 100689469);
        CastleBlock.PillarWallNeighborsEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlock.PillarWallNeighborsEnumerator>.NativeClassPtr, 100689470);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBlock.PillarWallNeighborsEnumerator>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
