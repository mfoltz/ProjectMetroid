// Decompiled with JetBrains decompiler
// Type: ProjectM.BoundsMinMax
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using ProjectM.Tiles;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct BoundsMinMax
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Min;
    private static readonly System.IntPtr NativeFieldInfoPtr_Max;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Empty_Public_Static_get_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Center_Public_get_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Combine_Public_Static_BoundsMinMax_BoundsMinMax_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Intersection_Public_Static_BoundsMinMax_BoundsMinMax_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Intersects_Public_Static_Boolean_BoundsMinMax_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BoundsMinMax_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BoundsMinMax_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSize_Public_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTiles_Public_TileEnumerator_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalTiles_Public_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEmpty_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalTileFromLocalIndex_Public_int2_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldTileFromLocalIndex_Public_int2_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalIndexFromLocalTile_Public_Int32_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalIndexFromWorldTile_Public_Int32_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Offset_Public_BoundsMinMax_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToWorldSpaceAABB_Public_AABB_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToLocalSpaceAABB_Public_AABB_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToAABB_Private_AABB_Single_Single_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToWorldSpaceBounds_Public_Bounds_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToLocalSpaceBounds_Public_Bounds_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToBounds_Private_Bounds_Single_Single_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rotate_Public_BoundsMinMax_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Rotate_Public_BoundsMinMax_TileRotation_TilePivotSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Transform_Public_BoundsMinMax_byref_float4x4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogIfUnreasonable_Public_Void_BoundsCheckSource_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogIfUnreasonable_Public_Void_BoundsCheckSource_WorldType_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpBoundsMinMaxIssue_Private_Static_Void_BoundsCheckSource_WorldType_Entity_0;
    [FieldOffset(0)]
    public int2 Min;
    [FieldOffset(8)]
    public int2 Max;

    public static unsafe BoundsMinMax Empty
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 533439, RefRangeEnd = 533493, XrefRangeStart = 533439, XrefRangeEnd = 533493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_get_Empty_Public_Static_get_BoundsMinMax_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float2 Center
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 765296, RefRangeEnd = 765300, XrefRangeStart = 765296, XrefRangeEnd = 765296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_get_Center_Public_get_float2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float2*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsValid
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 765300, RefRangeEnd = 765302, XrefRangeStart = 765300, XrefRangeEnd = 765300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 765302, RefRangeEnd = 765316, XrefRangeStart = 765302, XrefRangeEnd = 765302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BoundsMinMax(int minX, int minY, int maxX, int maxY)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &minX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &minY;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &maxY;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(86)]
    [CachedScanResults(RefRangeStart = 212464, RefRangeEnd = 212550, XrefRangeStart = 212464, XrefRangeEnd = 212550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BoundsMinMax(int2 min, int2 max)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &min;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &max;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr__ctor_Public_Void_int2_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool Contains(BoundsMinMax bounds)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &bounds;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_Contains_Public_Boolean_BoundsMinMax_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(35)]
    [CachedScanResults(RefRangeStart = 765317, RefRangeEnd = 765352, XrefRangeStart = 765316, XrefRangeEnd = 765317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Contains(int2 tile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tile;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_Contains_Public_Boolean_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(18)]
    [CachedScanResults(RefRangeStart = 765354, RefRangeEnd = 765372, XrefRangeStart = 765352, XrefRangeEnd = 765354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BoundsMinMax Combine(BoundsMinMax bounds1, BoundsMinMax bounds2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &bounds1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bounds2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_Combine_Public_Static_BoundsMinMax_BoundsMinMax_BoundsMinMax_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(28)]
    [CachedScanResults(RefRangeStart = 765372, RefRangeEnd = 765400, XrefRangeStart = 765372, XrefRangeEnd = 765372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BoundsMinMax Intersection(BoundsMinMax bounds1, BoundsMinMax bounds2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &bounds1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bounds2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_Intersection_Public_Static_BoundsMinMax_BoundsMinMax_BoundsMinMax_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 765402, RefRangeEnd = 765405, XrefRangeStart = 765400, XrefRangeEnd = 765402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Contains(float2 worldPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldPosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_Contains_Public_Boolean_float2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 765405, RefRangeEnd = 765414, XrefRangeStart = 765405, XrefRangeEnd = 765405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Intersects(BoundsMinMax bounds1, BoundsMinMax bounds2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &bounds1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bounds2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_Intersects_Public_Static_Boolean_BoundsMinMax_BoundsMinMax_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 765414, RefRangeEnd = 765420, XrefRangeStart = 765414, XrefRangeEnd = 765414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(BoundsMinMax other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoundsMinMax_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765420, XrefRangeEnd = 765423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 765423, RefRangeEnd = 765424, XrefRangeStart = 765423, XrefRangeEnd = 765423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 765414, RefRangeEnd = 765420, XrefRangeStart = 765414, XrefRangeEnd = 765420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator ==(BoundsMinMax a, BoundsMinMax b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BoundsMinMax_BoundsMinMax_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 765424, RefRangeEnd = 765425, XrefRangeStart = 765424, XrefRangeEnd = 765424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator !=(BoundsMinMax a, BoundsMinMax b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BoundsMinMax_BoundsMinMax_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(28)]
    [CachedScanResults(RefRangeStart = 765425, RefRangeEnd = 765453, XrefRangeStart = 765425, XrefRangeEnd = 765425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int2 GetSize()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_GetSize_Public_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 765454, RefRangeEnd = 765457, XrefRangeStart = 765453, XrefRangeEnd = 765454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BoundsMinMax.TileEnumerator GetTiles(bool includeMaxBoundary = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &includeMaxBoundary;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_GetTiles_Public_TileEnumerator_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax.TileEnumerator*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 765457, RefRangeEnd = 765471, XrefRangeStart = 765457, XrefRangeEnd = 765457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetTotalTiles()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_GetTotalTiles_Public_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(19)]
    [CachedScanResults(RefRangeStart = 765471, RefRangeEnd = 765490, XrefRangeStart = 765471, XrefRangeEnd = 765471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsEmpty()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765490, XrefRangeEnd = 765498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 765498, RefRangeEnd = 765499, XrefRangeStart = 765498, XrefRangeEnd = 765498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int2 GetLocalTileFromLocalIndex(int localIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &localIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_GetLocalTileFromLocalIndex_Public_int2_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 765500, RefRangeEnd = 765504, XrefRangeStart = 765499, XrefRangeEnd = 765500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int2 GetWorldTileFromLocalIndex(int localIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &localIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_GetWorldTileFromLocalIndex_Public_int2_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 765504, RefRangeEnd = 765506, XrefRangeStart = 765504, XrefRangeEnd = 765504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetLocalIndexFromLocalTile(int2 localTile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &localTile;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_GetLocalIndexFromLocalTile_Public_Int32_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 765514, RefRangeEnd = 765515, XrefRangeStart = 765506, XrefRangeEnd = 765514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetLocalIndexFromWorldTile(int2 worldTile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldTile;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_GetLocalIndexFromWorldTile_Public_Int32_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(28)]
    [CachedScanResults(RefRangeStart = 765515, RefRangeEnd = 765543, XrefRangeStart = 765515, XrefRangeEnd = 765515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BoundsMinMax Offset(int2 tileOffset)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tileOffset;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_Offset_Public_BoundsMinMax_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765543, XrefRangeEnd = 765545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AABB ToWorldSpaceAABB(float yCenter, float yHeight)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &yCenter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &yHeight;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_ToWorldSpaceAABB_Public_AABB_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AABB*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765545, XrefRangeEnd = 765547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AABB ToLocalSpaceAABB(float yCenter, float yHeight)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &yCenter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &yHeight;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_ToLocalSpaceAABB_Public_AABB_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AABB*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765547, XrefRangeEnd = 765548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AABB ToAABB(float yCenter, float yHeight, float2 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &yCenter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &yHeight;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_ToAABB_Private_AABB_Single_Single_float2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AABB*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 765550, RefRangeEnd = 765551, XrefRangeStart = 765548, XrefRangeEnd = 765550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Bounds ToWorldSpaceBounds(float yCenter, float yHeight)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &yCenter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &yHeight;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_ToWorldSpaceBounds_Public_Bounds_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Bounds*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765551, XrefRangeEnd = 765553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Bounds ToLocalSpaceBounds(float yCenter, float yHeight)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &yCenter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &yHeight;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_ToLocalSpaceBounds_Public_Bounds_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Bounds*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 765558, RefRangeEnd = 765560, XrefRangeStart = 765553, XrefRangeEnd = 765558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Bounds ToBounds(float yCenter, float yHeight, float2 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &yCenter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &yHeight;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_ToBounds_Private_Bounds_Single_Single_float2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Bounds*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(21)]
    [CachedScanResults(RefRangeStart = 765563, RefRangeEnd = 765584, XrefRangeStart = 765560, XrefRangeEnd = 765563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BoundsMinMax Rotate(TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_Rotate_Public_BoundsMinMax_TileRotation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 765587, RefRangeEnd = 765592, XrefRangeStart = 765584, XrefRangeEnd = 765587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BoundsMinMax Rotate(
      TileRotation tileRotation,
      TilePivotSettings tilePivotSettings)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tileRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tilePivotSettings;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_Rotate_Public_BoundsMinMax_TileRotation_TilePivotSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765592, XrefRangeEnd = 765598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BoundsMinMax Transform([In] ref float4x4 transformationMatrix)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref transformationMatrix;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_Transform_Public_BoundsMinMax_byref_float4x4_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 765600, RefRangeEnd = 765614, XrefRangeStart = 765598, XrefRangeEnd = 765600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LogIfUnreasonable(BoundsCheckSource source)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &source;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_LogIfUnreasonable_Public_Void_BoundsCheckSource_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 765733, RefRangeEnd = 765737, XrefRangeStart = 765614, XrefRangeEnd = 765733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LogIfUnreasonable(
      BoundsCheckSource source,
      WorldType worldType,
      Entity attachedEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &worldType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &attachedEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_LogIfUnreasonable_Public_Void_BoundsCheckSource_WorldType_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765737, XrefRangeEnd = 765753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DumpBoundsMinMaxIssue(
      BoundsCheckSource source,
      WorldType worldType,
      Entity attachedEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &worldType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &attachedEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.NativeMethodInfoPtr_DumpBoundsMinMaxIssue_Private_Static_Void_BoundsCheckSource_WorldType_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BoundsMinMax()
    {
      Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BoundsMinMax));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr);
      BoundsMinMax.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, nameof (Min));
      BoundsMinMax.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, nameof (Max));
      BoundsMinMax.NativeMethodInfoPtr_get_Empty_Public_Static_get_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667608);
      BoundsMinMax.NativeMethodInfoPtr_get_Center_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667609);
      BoundsMinMax.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667610);
      BoundsMinMax.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667611);
      BoundsMinMax.NativeMethodInfoPtr__ctor_Public_Void_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667612);
      BoundsMinMax.NativeMethodInfoPtr_Contains_Public_Boolean_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667613);
      BoundsMinMax.NativeMethodInfoPtr_Contains_Public_Boolean_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667614);
      BoundsMinMax.NativeMethodInfoPtr_Combine_Public_Static_BoundsMinMax_BoundsMinMax_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667615);
      BoundsMinMax.NativeMethodInfoPtr_Intersection_Public_Static_BoundsMinMax_BoundsMinMax_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667616);
      BoundsMinMax.NativeMethodInfoPtr_Contains_Public_Boolean_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667617);
      BoundsMinMax.NativeMethodInfoPtr_Intersects_Public_Static_Boolean_BoundsMinMax_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667618);
      BoundsMinMax.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667619);
      BoundsMinMax.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667620);
      BoundsMinMax.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667621);
      BoundsMinMax.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BoundsMinMax_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667622);
      BoundsMinMax.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BoundsMinMax_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667623);
      BoundsMinMax.NativeMethodInfoPtr_GetSize_Public_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667624);
      BoundsMinMax.NativeMethodInfoPtr_GetTiles_Public_TileEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667625);
      BoundsMinMax.NativeMethodInfoPtr_GetTotalTiles_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667626);
      BoundsMinMax.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667627);
      BoundsMinMax.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667628);
      BoundsMinMax.NativeMethodInfoPtr_GetLocalTileFromLocalIndex_Public_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667629);
      BoundsMinMax.NativeMethodInfoPtr_GetWorldTileFromLocalIndex_Public_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667630);
      BoundsMinMax.NativeMethodInfoPtr_GetLocalIndexFromLocalTile_Public_Int32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667631);
      BoundsMinMax.NativeMethodInfoPtr_GetLocalIndexFromWorldTile_Public_Int32_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667632);
      BoundsMinMax.NativeMethodInfoPtr_Offset_Public_BoundsMinMax_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667633);
      BoundsMinMax.NativeMethodInfoPtr_ToWorldSpaceAABB_Public_AABB_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667634);
      BoundsMinMax.NativeMethodInfoPtr_ToLocalSpaceAABB_Public_AABB_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667635);
      BoundsMinMax.NativeMethodInfoPtr_ToAABB_Private_AABB_Single_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667636);
      BoundsMinMax.NativeMethodInfoPtr_ToWorldSpaceBounds_Public_Bounds_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667637);
      BoundsMinMax.NativeMethodInfoPtr_ToLocalSpaceBounds_Public_Bounds_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667638);
      BoundsMinMax.NativeMethodInfoPtr_ToBounds_Private_Bounds_Single_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667639);
      BoundsMinMax.NativeMethodInfoPtr_Rotate_Public_BoundsMinMax_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667640);
      BoundsMinMax.NativeMethodInfoPtr_Rotate_Public_BoundsMinMax_TileRotation_TilePivotSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667641);
      BoundsMinMax.NativeMethodInfoPtr_Transform_Public_BoundsMinMax_byref_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667642);
      BoundsMinMax.NativeMethodInfoPtr_LogIfUnreasonable_Public_Void_BoundsCheckSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667643);
      BoundsMinMax.NativeMethodInfoPtr_LogIfUnreasonable_Public_Void_BoundsCheckSource_WorldType_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667644);
      BoundsMinMax.NativeMethodInfoPtr_DumpBoundsMinMaxIssue_Private_Static_Void_BoundsCheckSource_WorldType_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, 100667645);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TileEnumerator
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Bounds;
      private static readonly System.IntPtr NativeFieldInfoPtr__Current;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BoundsMinMax_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_int2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_TileEnumerator_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Unity_Mathematics_int2__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_int2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
      [FieldOffset(0)]
      public readonly BoundsMinMax Bounds;
      [FieldOffset(16)]
      public int2 _Current;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 765281, RefRangeEnd = 765282, XrefRangeStart = 765279, XrefRangeEnd = 765281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TileEnumerator(BoundsMinMax bounds, bool includeMaxBoundary = false)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &bounds;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &includeMaxBoundary;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.TileEnumerator.NativeMethodInfoPtr__ctor_Public_Void_BoundsMinMax_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe int2 Current
      {
        [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.TileEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int2*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 765282, RefRangeEnd = 765286, XrefRangeStart = 765282, XrefRangeEnd = 765282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.TileEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765286, XrefRangeEnd = 765287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Reset()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.TileEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Dispose()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.TileEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 242918, RefRangeEnd = 242920, XrefRangeStart = 242918, XrefRangeEnd = 242920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe BoundsMinMax.TileEnumerator GetEnumerator()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.TileEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_TileEnumerator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BoundsMinMax.TileEnumerator*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765287, XrefRangeEnd = 765290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe IEnumerator<int2> System_Collections_Generic_IEnumerable_Unity_Mathematics_int2__GetEnumerator()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.TileEnumerator.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Unity_Mathematics_int2__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerator<int2>) null : new IEnumerator<int2>(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765290, XrefRangeEnd = 765293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.TileEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765293, XrefRangeEnd = 765296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BoundsMinMax.TileEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      static TileEnumerator()
      {
        Il2CppClassPointerStore<BoundsMinMax.TileEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BoundsMinMax>.NativeClassPtr, nameof (TileEnumerator));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundsMinMax.TileEnumerator>.NativeClassPtr);
        BoundsMinMax.TileEnumerator.NativeFieldInfoPtr_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsMinMax.TileEnumerator>.NativeClassPtr, nameof (Bounds));
        BoundsMinMax.TileEnumerator.NativeFieldInfoPtr__Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsMinMax.TileEnumerator>.NativeClassPtr, nameof (_Current));
        BoundsMinMax.TileEnumerator.NativeMethodInfoPtr__ctor_Public_Void_BoundsMinMax_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax.TileEnumerator>.NativeClassPtr, 100667646);
        BoundsMinMax.TileEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax.TileEnumerator>.NativeClassPtr, 100667647);
        BoundsMinMax.TileEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax.TileEnumerator>.NativeClassPtr, 100667648);
        BoundsMinMax.TileEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax.TileEnumerator>.NativeClassPtr, 100667649);
        BoundsMinMax.TileEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax.TileEnumerator>.NativeClassPtr, 100667650);
        BoundsMinMax.TileEnumerator.NativeMethodInfoPtr_GetEnumerator_Public_TileEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax.TileEnumerator>.NativeClassPtr, 100667651);
        BoundsMinMax.TileEnumerator.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Unity_Mathematics_int2__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax.TileEnumerator>.NativeClassPtr, 100667652);
        BoundsMinMax.TileEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax.TileEnumerator>.NativeClassPtr, 100667653);
        BoundsMinMax.TileEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsMinMax.TileEnumerator>.NativeClassPtr, 100667654);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoundsMinMax.TileEnumerator>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
