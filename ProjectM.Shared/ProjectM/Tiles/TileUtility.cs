// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Tiles
{
  public static class TileUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TOTAL_ROTATION_STEPS;
    private static readonly System.IntPtr NativeMethodInfoPtr_RotateTilePosition_Public_Static_Void_byref_Int32_byref_Int32_TileRotation_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RotateTilePosition_Public_Static_Void_byref_Int32_byref_Int32_TileRotation_TilePivotSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RotateTilePosition_Public_Static_int2_int2_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RotateSquareBoundsBasedTilePosition_Public_Static_int2_int2_Int32_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TileRotationToOrthogonalRotation_Public_Static_OrthogonalRotation_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OrthogonalRotationToTileRotation_Public_Static_TileRotation_OrthogonalRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReverseRotation_Public_Static_TileRotation_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileRotationOffset_Public_Static_int2_TileRotation_TilePivotSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEulerRotation_Public_Static_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileRotationFromEulerY_Public_Static_TileRotation_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_nfmod_Private_Static_Single_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEulerRotationFromTileRotation_Public_Static_Single_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TransformLocalBounds_Public_Static_BoundsMinMax_float3_quaternion_TilePivotSettings_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileRotationFromQuaternion_Public_Static_TileRotation_quaternion_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAngleFromQuaternion_Public_Static_Single_quaternion_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileRotation_Public_Static_TileRotation_byref_LocalToWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAngleFromTileRotation_Public_Static_Single_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNormalFromRotation_Public_Static_float2_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSnappedPosition_Public_Static_float3_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSnappedPosition_Public_Static_float3_float3_TilePivotSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSnappedPosition_Public_Static_float3_float3_TilePivotSettings_TileSnapType_byref_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSnappedPositionWithHeight_Public_Static_float3_float3_TilePivotSettings_TileSnapType_byref_Single_Byte_ComponentDataFromEntity_1_TilePosition_Boolean_byref_Nullable_Unboxed_1_HeightPlacementConfig_byref_CollisionWorld_NativeHashSet_1_Entity_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSnappedPosition_Public_Static_float3_ComponentDataFromEntity_1_TileData_byref_CollisionWorld_Entity_float3_Single_Byte_ComponentDataFromEntity_1_TilePosition_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StandardSnap_Private_Static_float2_float2_float2_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Mod_Private_Static_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TileRotationFromInt_Public_Static_TileRotation_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddTileRotation_Public_Static_TileRotation_TileRotation_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SubtractTileRotation_Public_Static_TileRotation_TileRotation_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InsideMap_Public_Static_Boolean_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InsideMap_Public_Static_Boolean_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MapBounds_Public_Static_BoundsMinMax_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BlockCount_Public_Static_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSourceTileRespectPivotRotation_Public_Static_int2_TilePosition_TilePivotSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldFloorBoundsForTile_Public_Static_BoundsMinMax_int2_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 793712, RefRangeEnd = 793716, XrefRangeStart = 793710, XrefRangeEnd = 793712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RotateTilePosition(
      ref int x,
      ref int y,
      TileRotation tileRotation,
      bool rotateAroundTileCenter)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref y;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &rotateAroundTileCenter;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_RotateTilePosition_Public_Static_Void_byref_Int32_byref_Int32_TileRotation_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 793719, RefRangeEnd = 793723, XrefRangeStart = 793716, XrefRangeEnd = 793719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RotateTilePosition(
      ref int x,
      ref int y,
      TileRotation tileRotation,
      TilePivotSettings pivotSettings)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref y;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &pivotSettings;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_RotateTilePosition_Public_Static_Void_byref_Int32_byref_Int32_TileRotation_TilePivotSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(23)]
    [CachedScanResults(RefRangeStart = 793723, RefRangeEnd = 793746, XrefRangeStart = 793723, XrefRangeEnd = 793723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 RotateTilePosition(int2 tile, TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_RotateTilePosition_Public_Static_int2_int2_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe int2 RotateSquareBoundsBasedTilePosition(
      int2 tile,
      int boundsSize,
      TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &tile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &boundsSize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_RotateSquareBoundsBasedTilePosition_Public_Static_int2_int2_Int32_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793746, RefRangeEnd = 793747, XrefRangeStart = 793746, XrefRangeEnd = 793746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe OrthogonalRotation TileRotationToOrthogonalRotation(TileRotation rotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &rotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_TileRotationToOrthogonalRotation_Public_Static_OrthogonalRotation_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(OrthogonalRotation*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe TileRotation OrthogonalRotationToTileRotation(OrthogonalRotation rotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &rotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_OrthogonalRotationToTileRotation_Public_Static_TileRotation_OrthogonalRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileRotation*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe TileRotation ReverseRotation(TileRotation rotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &rotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_ReverseRotation_Public_Static_TileRotation_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileRotation*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793747, XrefRangeEnd = 793748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 GetTileRotationOffset(
      TileRotation tileRotation,
      TilePivotSettings pivotSettings)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tileRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pivotSettings;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_GetTileRotationOffset_Public_Static_int2_TileRotation_TilePivotSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe float GetEulerRotation(int stepsRotated)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &stepsRotated;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_GetEulerRotation_Public_Static_Single_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 793752, RefRangeEnd = 793760, XrefRangeStart = 793748, XrefRangeEnd = 793752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileRotation GetTileRotationFromEulerY(float eulerY)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &eulerY;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_GetTileRotationFromEulerY_Public_Static_TileRotation_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileRotation*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793760, XrefRangeEnd = 793764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float nfmod(float a, float b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_nfmod_Private_Static_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 793764, RefRangeEnd = 793772, XrefRangeStart = 793764, XrefRangeEnd = 793764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetEulerRotationFromTileRotation(TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_GetEulerRotationFromTileRotation_Public_Static_Single_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 793776, RefRangeEnd = 793778, XrefRangeStart = 793772, XrefRangeEnd = 793776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BoundsMinMax TransformLocalBounds(
      float3 position,
      quaternion rotation,
      TilePivotSettings pivotSettings,
      BoundsMinMax localBounds)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pivotSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &localBounds;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_TransformLocalBounds_Public_Static_BoundsMinMax_float3_quaternion_TilePivotSettings_BoundsMinMax_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(19)]
    [CachedScanResults(RefRangeStart = 793790, RefRangeEnd = 793809, XrefRangeStart = 793778, XrefRangeEnd = 793790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileRotation GetTileRotationFromQuaternion(quaternion rot)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &rot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_GetTileRotationFromQuaternion_Public_Static_TileRotation_quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileRotation*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 793810, RefRangeEnd = 793813, XrefRangeStart = 793809, XrefRangeEnd = 793810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetAngleFromQuaternion(quaternion rot)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &rot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_GetAngleFromQuaternion_Public_Static_Single_quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793827, RefRangeEnd = 793828, XrefRangeStart = 793813, XrefRangeEnd = 793827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileRotation GetTileRotation([In] ref LocalToWorld localToWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref localToWorld;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_GetTileRotation_Public_Static_TileRotation_byref_LocalToWorld_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileRotation*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793828, RefRangeEnd = 793829, XrefRangeStart = 793828, XrefRangeEnd = 793828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetAngleFromTileRotation(TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_GetAngleFromTileRotation_Public_Static_Single_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 793829, RefRangeEnd = 793831, XrefRangeStart = 793829, XrefRangeEnd = 793829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float2 GetNormalFromRotation(TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_GetNormalFromRotation_Public_Static_float2_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 793832, RefRangeEnd = 793836, XrefRangeStart = 793831, XrefRangeEnd = 793832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float3 GetSnappedPosition(float3 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_GetSnappedPosition_Public_Static_float3_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793836, XrefRangeEnd = 793837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float3 GetSnappedPosition(float3 position, TilePivotSettings pivotSettings)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pivotSettings;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_GetSnappedPosition_Public_Static_float3_float3_TilePivotSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 793864, RefRangeEnd = 793867, XrefRangeStart = 793837, XrefRangeEnd = 793864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float3 GetSnappedPosition(
      float3 position,
      TilePivotSettings pivotSettings,
      TileSnapType snapType,
      [In] ref float tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pivotSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &snapType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_GetSnappedPosition_Public_Static_float3_float3_TilePivotSettings_TileSnapType_byref_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793907, RefRangeEnd = 793908, XrefRangeStart = 793867, XrefRangeEnd = 793907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float3 GetSnappedPositionWithHeight(
      float3 position,
      TilePivotSettings pivotSettings,
      TileSnapType snapType,
      [In] ref float tileRotation,
      byte heightLevel,
      ComponentDataFromEntity<TilePosition> getTilePosition,
      bool filterByHeightLevel,
      [In] ref Nullable_Unboxed<HeightPlacementConfig> heightPickingConfig,
      ref CollisionWorld collisionWorld,
      NativeHashSet<Entity> ignoreWhenRaycasting = default (NativeHashSet<Entity>),
      float defaultHeight = 0.0f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[11];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pivotSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &snapType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &getTilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &filterByHeightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref heightPickingConfig;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreWhenRaycasting;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultHeight;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_GetSnappedPositionWithHeight_Public_Static_float3_float3_TilePivotSettings_TileSnapType_byref_Single_Byte_ComponentDataFromEntity_1_TilePosition_Boolean_byref_Nullable_Unboxed_1_HeightPlacementConfig_byref_CollisionWorld_NativeHashSet_1_Entity_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 793923, RefRangeEnd = 793926, XrefRangeStart = 793908, XrefRangeEnd = 793923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float3 GetSnappedPosition(
      ComponentDataFromEntity<TileData> getTileData,
      ref CollisionWorld collisionWorld,
      Entity tileModel,
      float3 position,
      float rotation,
      byte heightLevel,
      ComponentDataFromEntity<TilePosition> getTilePosition,
      bool autoSnapToGrid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &getTileData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref collisionWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tileModel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &getTilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &autoSnapToGrid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_GetSnappedPosition_Public_Static_float3_ComponentDataFromEntity_1_TileData_byref_CollisionWorld_Entity_float3_Single_Byte_ComponentDataFromEntity_1_TilePosition_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793928, RefRangeEnd = 793929, XrefRangeStart = 793926, XrefRangeEnd = 793928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float2 StandardSnap(float2 xz, float2 snapOffset, float2 snapSize)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &xz;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapOffset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &snapSize;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_StandardSnap_Private_Static_float2_float2_float2_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe int Mod(int x, int m)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &m;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_Mod_Private_Static_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 793929, RefRangeEnd = 793936, XrefRangeStart = 793929, XrefRangeEnd = 793929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileRotation TileRotationFromInt(int stepsRotated)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &stepsRotated;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_TileRotationFromInt_Public_Static_TileRotation_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileRotation*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 793936, RefRangeEnd = 793944, XrefRangeStart = 793936, XrefRangeEnd = 793936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileRotation AddTileRotation(
      TileRotation sourceTileRotation,
      TileRotation tileRotationToAdd)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &sourceTileRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotationToAdd;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_AddTileRotation_Public_Static_TileRotation_TileRotation_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileRotation*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 793944, RefRangeEnd = 793948, XrefRangeStart = 793944, XrefRangeEnd = 793944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileRotation SubtractTileRotation(
      TileRotation sourceTileRotation,
      TileRotation tileRotationToSubtract)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &sourceTileRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotationToSubtract;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_SubtractTileRotation_Public_Static_TileRotation_TileRotation_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileRotation*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 793948, RefRangeEnd = 793951, XrefRangeStart = 793948, XrefRangeEnd = 793948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool InsideMap(int2 tile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tile;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_InsideMap_Public_Static_Boolean_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool InsideMap(int x, int y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_InsideMap_Public_Static_Boolean_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793952, RefRangeEnd = 793953, XrefRangeStart = 793951, XrefRangeEnd = 793952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BoundsMinMax MapBounds()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_MapBounds_Public_Static_BoundsMinMax_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe int BlockCount()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_BlockCount_Public_Static_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 793954, RefRangeEnd = 793966, XrefRangeStart = 793953, XrefRangeEnd = 793954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 GetSourceTileRespectPivotRotation(
      TilePosition tilePosition,
      TilePivotSettings pivotSettings)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pivotSettings;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_GetSourceTileRespectPivotRotation_Public_Static_int2_TilePosition_TilePivotSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 793966, RefRangeEnd = 793967, XrefRangeStart = 793966, XrefRangeEnd = 793966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BoundsMinMax GetWorldFloorBoundsForTile(int2 tile)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tile;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileUtility.NativeMethodInfoPtr_GetWorldFloorBoundsForTile_Public_Static_BoundsMinMax_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BoundsMinMax*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TileUtility()
    {
      Il2CppClassPointerStore<TileUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileUtility>.NativeClassPtr);
      TileUtility.NativeFieldInfoPtr_TOTAL_ROTATION_STEPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, nameof (TOTAL_ROTATION_STEPS));
      TileUtility.NativeMethodInfoPtr_RotateTilePosition_Public_Static_Void_byref_Int32_byref_Int32_TileRotation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669951);
      TileUtility.NativeMethodInfoPtr_RotateTilePosition_Public_Static_Void_byref_Int32_byref_Int32_TileRotation_TilePivotSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669952);
      TileUtility.NativeMethodInfoPtr_RotateTilePosition_Public_Static_int2_int2_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669953);
      TileUtility.NativeMethodInfoPtr_RotateSquareBoundsBasedTilePosition_Public_Static_int2_int2_Int32_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669954);
      TileUtility.NativeMethodInfoPtr_TileRotationToOrthogonalRotation_Public_Static_OrthogonalRotation_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669955);
      TileUtility.NativeMethodInfoPtr_OrthogonalRotationToTileRotation_Public_Static_TileRotation_OrthogonalRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669956);
      TileUtility.NativeMethodInfoPtr_ReverseRotation_Public_Static_TileRotation_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669957);
      TileUtility.NativeMethodInfoPtr_GetTileRotationOffset_Public_Static_int2_TileRotation_TilePivotSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669958);
      TileUtility.NativeMethodInfoPtr_GetEulerRotation_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669959);
      TileUtility.NativeMethodInfoPtr_GetTileRotationFromEulerY_Public_Static_TileRotation_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669960);
      TileUtility.NativeMethodInfoPtr_nfmod_Private_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669961);
      TileUtility.NativeMethodInfoPtr_GetEulerRotationFromTileRotation_Public_Static_Single_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669962);
      TileUtility.NativeMethodInfoPtr_TransformLocalBounds_Public_Static_BoundsMinMax_float3_quaternion_TilePivotSettings_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669963);
      TileUtility.NativeMethodInfoPtr_GetTileRotationFromQuaternion_Public_Static_TileRotation_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669964);
      TileUtility.NativeMethodInfoPtr_GetAngleFromQuaternion_Public_Static_Single_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669965);
      TileUtility.NativeMethodInfoPtr_GetTileRotation_Public_Static_TileRotation_byref_LocalToWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669966);
      TileUtility.NativeMethodInfoPtr_GetAngleFromTileRotation_Public_Static_Single_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669967);
      TileUtility.NativeMethodInfoPtr_GetNormalFromRotation_Public_Static_float2_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669968);
      TileUtility.NativeMethodInfoPtr_GetSnappedPosition_Public_Static_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669969);
      TileUtility.NativeMethodInfoPtr_GetSnappedPosition_Public_Static_float3_float3_TilePivotSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669970);
      TileUtility.NativeMethodInfoPtr_GetSnappedPosition_Public_Static_float3_float3_TilePivotSettings_TileSnapType_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669971);
      TileUtility.NativeMethodInfoPtr_GetSnappedPositionWithHeight_Public_Static_float3_float3_TilePivotSettings_TileSnapType_byref_Single_Byte_ComponentDataFromEntity_1_TilePosition_Boolean_byref_Nullable_Unboxed_1_HeightPlacementConfig_byref_CollisionWorld_NativeHashSet_1_Entity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669972);
      TileUtility.NativeMethodInfoPtr_GetSnappedPosition_Public_Static_float3_ComponentDataFromEntity_1_TileData_byref_CollisionWorld_Entity_float3_Single_Byte_ComponentDataFromEntity_1_TilePosition_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669973);
      TileUtility.NativeMethodInfoPtr_StandardSnap_Private_Static_float2_float2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669974);
      TileUtility.NativeMethodInfoPtr_Mod_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669975);
      TileUtility.NativeMethodInfoPtr_TileRotationFromInt_Public_Static_TileRotation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669976);
      TileUtility.NativeMethodInfoPtr_AddTileRotation_Public_Static_TileRotation_TileRotation_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669977);
      TileUtility.NativeMethodInfoPtr_SubtractTileRotation_Public_Static_TileRotation_TileRotation_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669978);
      TileUtility.NativeMethodInfoPtr_InsideMap_Public_Static_Boolean_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669979);
      TileUtility.NativeMethodInfoPtr_InsideMap_Public_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669980);
      TileUtility.NativeMethodInfoPtr_MapBounds_Public_Static_BoundsMinMax_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669981);
      TileUtility.NativeMethodInfoPtr_BlockCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669982);
      TileUtility.NativeMethodInfoPtr_GetSourceTileRespectPivotRotation_Public_Static_int2_TilePosition_TilePivotSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669983);
      TileUtility.NativeMethodInfoPtr_GetWorldFloorBoundsForTile_Public_Static_BoundsMinMax_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileUtility>.NativeClassPtr, 100669984);
    }

    public TileUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int TOTAL_ROTATION_STEPS
    {
      get
      {
        int totalRotationSteps;
        IL2CPP.il2cpp_field_static_get_value(TileUtility.NativeFieldInfoPtr_TOTAL_ROTATION_STEPS, (void*) &totalRotationSteps);
        return totalRotationSteps;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileUtility.NativeFieldInfoPtr_TOTAL_ROTATION_STEPS, (void*) &value);
      }
    }
  }
}
