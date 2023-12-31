// Decompiled with JetBrains decompiler
// Type: ProjectM.LineOfSightUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Physics;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public static class LineOfSightUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_InLineOfSight_Public_Static_Boolean_byref_TileWorld_float3_float3_LineOfSightTileFlags_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InLineOfSightWithDebugging_Public_Static_Boolean_byref_TileWorld_float3_float3_LineOfSightTileFlags_NativeList_1_CellsTraversed_NativeHashMap_2_int3_Color_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Private_Static_Boolean_Ray_Aabb_Single_byref_Single_byref_Single_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 764844, RefRangeEnd = 764855, XrefRangeStart = 764816, XrefRangeEnd = 764844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool InLineOfSight(
      ref TileWorld tileWorld,
      float3 sourcePosition,
      float3 targetPosition,
      LineOfSightTileFlags relevantFlags,
      bool addEyeOffset = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sourcePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &targetPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &relevantFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &addEyeOffset;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LineOfSightUtility.NativeMethodInfoPtr_InLineOfSight_Public_Static_Boolean_byref_TileWorld_float3_float3_LineOfSightTileFlags_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 764890, RefRangeEnd = 764891, XrefRangeStart = 764855, XrefRangeEnd = 764890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool InLineOfSightWithDebugging(
      ref TileWorld tileWorld,
      float3 sourcePosition,
      float3 targetPosition,
      LineOfSightTileFlags relevantFlags,
      NativeList<LineOfSightUtility.CellsTraversed> tileCellsThatPassedThrough,
      NativeHashMap<int3, Color> customColors,
      bool addEyeOffset = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) ref tileWorld;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sourcePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &targetPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &relevantFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &tileCellsThatPassedThrough;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &customColors;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &addEyeOffset;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LineOfSightUtility.NativeMethodInfoPtr_InLineOfSightWithDebugging_Public_Static_Boolean_byref_TileWorld_float3_float3_LineOfSightTileFlags_NativeList_1_CellsTraversed_NativeHashMap_2_int3_Color_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 764908, RefRangeEnd = 764910, XrefRangeStart = 764891, XrefRangeEnd = 764908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Raycast(
      Unity.Physics.Ray ray,
      Aabb aabb,
      float maxFraction,
      out float enter,
      out float exit)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &ray;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aabb;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxFraction;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref enter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref exit;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LineOfSightUtility.NativeMethodInfoPtr_Raycast_Private_Static_Boolean_Ray_Aabb_Single_byref_Single_byref_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static LineOfSightUtility()
    {
      Il2CppClassPointerStore<LineOfSightUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (LineOfSightUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineOfSightUtility>.NativeClassPtr);
      LineOfSightUtility.NativeMethodInfoPtr_InLineOfSight_Public_Static_Boolean_byref_TileWorld_float3_float3_LineOfSightTileFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineOfSightUtility>.NativeClassPtr, 100667545);
      LineOfSightUtility.NativeMethodInfoPtr_InLineOfSightWithDebugging_Public_Static_Boolean_byref_TileWorld_float3_float3_LineOfSightTileFlags_NativeList_1_CellsTraversed_NativeHashMap_2_int3_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineOfSightUtility>.NativeClassPtr, 100667546);
      LineOfSightUtility.NativeMethodInfoPtr_Raycast_Private_Static_Boolean_Ray_Aabb_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineOfSightUtility>.NativeClassPtr, 100667547);
    }

    public LineOfSightUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CellsTraversed
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Aabb;
      private static readonly System.IntPtr NativeFieldInfoPtr_CellCoordinate;
      private static readonly System.IntPtr NativeFieldInfoPtr_LayerIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_EnterFraction;
      private static readonly System.IntPtr NativeFieldInfoPtr_ExitFraction;
      private static readonly System.IntPtr NativeFieldInfoPtr_Blocked;
      private static readonly System.IntPtr NativeFieldInfoPtr_Skipped;
      [FieldOffset(0)]
      public Aabb Aabb;
      [FieldOffset(24)]
      public TileCellCoordinate CellCoordinate;
      [FieldOffset(32)]
      public TileLayerIndex LayerIndex;
      [FieldOffset(36)]
      public float EnterFraction;
      [FieldOffset(40)]
      public float ExitFraction;
      [FieldOffset(44)]
      public bool Blocked;
      [FieldOffset(45)]
      public bool Skipped;

      static CellsTraversed()
      {
        Il2CppClassPointerStore<LineOfSightUtility.CellsTraversed>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LineOfSightUtility>.NativeClassPtr, nameof (CellsTraversed));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineOfSightUtility.CellsTraversed>.NativeClassPtr);
        LineOfSightUtility.CellsTraversed.NativeFieldInfoPtr_Aabb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightUtility.CellsTraversed>.NativeClassPtr, nameof (Aabb));
        LineOfSightUtility.CellsTraversed.NativeFieldInfoPtr_CellCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightUtility.CellsTraversed>.NativeClassPtr, nameof (CellCoordinate));
        LineOfSightUtility.CellsTraversed.NativeFieldInfoPtr_LayerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightUtility.CellsTraversed>.NativeClassPtr, nameof (LayerIndex));
        LineOfSightUtility.CellsTraversed.NativeFieldInfoPtr_EnterFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightUtility.CellsTraversed>.NativeClassPtr, nameof (EnterFraction));
        LineOfSightUtility.CellsTraversed.NativeFieldInfoPtr_ExitFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightUtility.CellsTraversed>.NativeClassPtr, nameof (ExitFraction));
        LineOfSightUtility.CellsTraversed.NativeFieldInfoPtr_Blocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightUtility.CellsTraversed>.NativeClassPtr, nameof (Blocked));
        LineOfSightUtility.CellsTraversed.NativeFieldInfoPtr_Skipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightUtility.CellsTraversed>.NativeClassPtr, nameof (Skipped));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LineOfSightUtility.CellsTraversed>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CellAccessCache
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CellCoordinate;
      private static readonly System.IntPtr NativeFieldInfoPtr_HeightLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileLayerIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_Cell;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileLayer;
      private static readonly System.IntPtr NativeFieldInfoPtr_GameplayHeights;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileCellEnumReader;
      private static readonly System.IntPtr NativeFieldInfoPtr_AnyFlagSetMask;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCache_Public_Boolean_byref_TileWorld_int2_Byte_LineOfSightTileFlags_0;
      [FieldOffset(0)]
      public TileCellCoordinate CellCoordinate;
      [FieldOffset(8)]
      public byte HeightLevel;
      [FieldOffset(9)]
      public TileLayerIndex TileLayerIndex;
      [FieldOffset(16)]
      public TileCell Cell;
      [FieldOffset(24)]
      public TileLayer TileLayer;
      [FieldOffset(32)]
      public NativeArray<ushort> GameplayHeights;
      [FieldOffset(48)]
      public TileCellEnumReader TileCellEnumReader;
      [FieldOffset(112)]
      public BitMask2D_16x16 AnyFlagSetMask;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 764814, RefRangeEnd = 764816, XrefRangeStart = 764804, XrefRangeEnd = 764814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool UpdateCache(
        ref TileWorld tileWorld,
        int2 worldTile,
        byte heightLevel,
        LineOfSightTileFlags relevantFlags)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref tileWorld;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &worldTile;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &relevantFlags;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LineOfSightUtility.CellAccessCache.NativeMethodInfoPtr_UpdateCache_Public_Boolean_byref_TileWorld_int2_Byte_LineOfSightTileFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static CellAccessCache()
      {
        Il2CppClassPointerStore<LineOfSightUtility.CellAccessCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LineOfSightUtility>.NativeClassPtr, nameof (CellAccessCache));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineOfSightUtility.CellAccessCache>.NativeClassPtr);
        LineOfSightUtility.CellAccessCache.NativeFieldInfoPtr_CellCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightUtility.CellAccessCache>.NativeClassPtr, nameof (CellCoordinate));
        LineOfSightUtility.CellAccessCache.NativeFieldInfoPtr_HeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightUtility.CellAccessCache>.NativeClassPtr, nameof (HeightLevel));
        LineOfSightUtility.CellAccessCache.NativeFieldInfoPtr_TileLayerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightUtility.CellAccessCache>.NativeClassPtr, nameof (TileLayerIndex));
        LineOfSightUtility.CellAccessCache.NativeFieldInfoPtr_Cell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightUtility.CellAccessCache>.NativeClassPtr, nameof (Cell));
        LineOfSightUtility.CellAccessCache.NativeFieldInfoPtr_TileLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightUtility.CellAccessCache>.NativeClassPtr, nameof (TileLayer));
        LineOfSightUtility.CellAccessCache.NativeFieldInfoPtr_GameplayHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightUtility.CellAccessCache>.NativeClassPtr, nameof (GameplayHeights));
        LineOfSightUtility.CellAccessCache.NativeFieldInfoPtr_TileCellEnumReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightUtility.CellAccessCache>.NativeClassPtr, nameof (TileCellEnumReader));
        LineOfSightUtility.CellAccessCache.NativeFieldInfoPtr_AnyFlagSetMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineOfSightUtility.CellAccessCache>.NativeClassPtr, nameof (AnyFlagSetMask));
        LineOfSightUtility.CellAccessCache.NativeMethodInfoPtr_UpdateCache_Public_Boolean_byref_TileWorld_int2_Byte_LineOfSightTileFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineOfSightUtility.CellAccessCache>.NativeClassPtr, 100667548);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LineOfSightUtility.CellAccessCache>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
