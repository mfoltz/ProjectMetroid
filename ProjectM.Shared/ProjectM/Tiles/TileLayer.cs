// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileLayer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using ProjectM.Pathfinding;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileLayer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Ptr;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ptr_TileLayerData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetReadonlyRef_Public_byref_TileLayerData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsCreated_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_GameplayMinHeight_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_GameplayMaxHeight_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_StandardLayerFlags_Public_get_StandardLayerFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MapCollisionFlags_Public_get_MapCollisionFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LineOfSightTileFlags_Public_get_LineOfSightTileFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetGameplayHeights_Public_NativeArray_1_UInt16_TileCell_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetGameplayHeight_Public_Single_TileCell_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellMask_SingleFlag_Public_byref_BitMask2D_16x16_TileCell_StandardLayerFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellMask_SingleFlag_Public_byref_BitMask2D_16x16_TileCell_MapCollisionFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellMask_SingleFlag_Public_byref_BitMask2D_16x16_TileCell_LineOfSightTileFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellMask_SingleFlag_Public_byref_BitMask2D_16x16_TileCell_TileCellMaskType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellMask_CombinedMultiFlags_OR_Public_BitMask2D_16x16_TileCell_StandardLayerFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellMask_CombinedMultiFlags_OR_Public_BitMask2D_16x16_TileCell_MapCollisionFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellMask_CombinedMultiFlags_OR_Public_BitMask2D_16x16_TileCell_LineOfSightTileFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellMask_CombinedMultiFlags_AND_Public_BitMask2D_16x16_TileCell_StandardLayerFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellMask_CombinedMultiFlags_AND_Public_BitMask2D_16x16_TileCell_MapCollisionFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellMask_CombinedMultiFlags_AND_Public_BitMask2D_16x16_TileCell_LineOfSightTileFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellEnumReader_Public_TileCellEnumReader_StandardLayerFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellEnumReader_Public_TileCellEnumReader_MapCollisionFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellEnumReader_Public_TileCellEnumReader_LineOfSightTileFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTile_SingleFlag_Public_Boolean_TileCell_int2_StandardLayerFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTile_SingleFlag_Public_Boolean_TileCell_int2_MapCollisionFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTile_SingleFlag_Public_Boolean_TileCell_int2_LineOfSightTileFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTile_MultiFlags_Expensive_Public_StandardLayerFlags_TileCell_int2_StandardLayerFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTile_MultiFlags_Expensive_Public_MapCollisionFlags_TileCell_int2_MapCollisionFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTile_MultiFlags_Expensive_Public_LineOfSightTileFlags_TileCell_int2_LineOfSightTileFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellMaskIndex_Public_Int32_StandardLayerFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellMaskIndex_Public_Int32_MapCollisionFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellMaskIndex_Public_Int32_LineOfSightTileFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellMaskIndex_Public_Int32_TileCellMaskType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPathfindingTiles_Public_NativeArray_1_PathfindingTile_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPathfindingTilesSizeTwo_Public_NativeArray_1_PathfindingTile_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToTempNativeArray_Private_Static_NativeArray_1_T_ptr_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellMaskIndex_Private_Int32_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCombinedFlags_OR_Private_BitMask2D_16x16_TileCell_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCombinedFlags_AND_Private_BitMask2D_16x16_TileCell_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFlags_Private_TileCellEnumReader_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumValue_Private_Int32_TileCell_int2_Int32_Int32_Int32_0;
    [FieldOffset(0)]
    public unsafe TileLayerData* Ptr;

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileLayer(TileLayerData* ptr)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) (void*) ptr;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr__ctor_Internal_Void_ptr_TileLayerData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(54)]
    [CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public ref TileLayerData GetReadonlyRef()
    {
      // ISSUE: unable to decompile the method.
    }

    [CallerCount(415)]
    [CachedScanResults(RefRangeStart = 193763, RefRangeEnd = 194178, XrefRangeStart = 193763, XrefRangeEnd = 194178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsCreated()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_IsCreated_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    public unsafe float GameplayMinHeight
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_get_GameplayMinHeight_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float GameplayMaxHeight
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_get_GameplayMaxHeight_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe StandardLayerFlags StandardLayerFlags
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_get_StandardLayerFlags_Public_get_StandardLayerFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(StandardLayerFlags*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe MapCollisionFlags MapCollisionFlags
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_get_MapCollisionFlags_Public_get_MapCollisionFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(MapCollisionFlags*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe LineOfSightTileFlags LineOfSightTileFlags
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_get_LineOfSightTileFlags_Public_get_LineOfSightTileFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LineOfSightTileFlags*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 792211, RefRangeEnd = 792228, XrefRangeStart = 792188, XrefRangeEnd = 792211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeArray<ushort> GetGameplayHeights(TileCell tileCell)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tileCell;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetGameplayHeights_Public_NativeArray_1_UInt16_TileCell_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeArray<ushort>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 792255, RefRangeEnd = 792258, XrefRangeStart = 792228, XrefRangeEnd = 792255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetGameplayHeight(TileCell tileCell, int2 cellCoordinate)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tileCell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cellCoordinate;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetGameplayHeight_Public_Single_TileCell_int2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 792260, RefRangeEnd = 792264, XrefRangeStart = 792258, XrefRangeEnd = 792260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public ref BitMask2D_16x16 GetCellMask_SingleFlag(TileCell tileCell, StandardLayerFlags flag)
    {
      // ISSUE: unable to decompile the method.
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 792266, RefRangeEnd = 792269, XrefRangeStart = 792264, XrefRangeEnd = 792266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public ref BitMask2D_16x16 GetCellMask_SingleFlag(TileCell tileCell, MapCollisionFlags flag)
    {
      // ISSUE: unable to decompile the method.
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 792271, RefRangeEnd = 792273, XrefRangeStart = 792269, XrefRangeEnd = 792271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public ref BitMask2D_16x16 GetCellMask_SingleFlag(TileCell tileCell, LineOfSightTileFlags flag)
    {
      // ISSUE: unable to decompile the method.
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 792275, RefRangeEnd = 792276, XrefRangeStart = 792273, XrefRangeEnd = 792275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public ref BitMask2D_16x16 GetCellMask_SingleFlag(
      TileCell tileCell,
      TileCellMaskType type,
      int flagIndex)
    {
      // ISSUE: unable to decompile the method.
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792276, XrefRangeEnd = 792277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BitMask2D_16x16 GetCellMask_CombinedMultiFlags_OR(
      TileCell tileCell,
      StandardLayerFlags relevantFlags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tileCell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &relevantFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetCellMask_CombinedMultiFlags_OR_Public_BitMask2D_16x16_TileCell_StandardLayerFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_16x16*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 792278, RefRangeEnd = 792281, XrefRangeStart = 792277, XrefRangeEnd = 792278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BitMask2D_16x16 GetCellMask_CombinedMultiFlags_OR(
      TileCell tileCell,
      MapCollisionFlags relevantFlags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tileCell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &relevantFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetCellMask_CombinedMultiFlags_OR_Public_BitMask2D_16x16_TileCell_MapCollisionFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_16x16*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792281, XrefRangeEnd = 792282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BitMask2D_16x16 GetCellMask_CombinedMultiFlags_OR(
      TileCell tileCell,
      LineOfSightTileFlags relevantFlags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tileCell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &relevantFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetCellMask_CombinedMultiFlags_OR_Public_BitMask2D_16x16_TileCell_LineOfSightTileFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_16x16*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792282, XrefRangeEnd = 792283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BitMask2D_16x16 GetCellMask_CombinedMultiFlags_AND(
      TileCell tileCell,
      StandardLayerFlags relevantFlags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tileCell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &relevantFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetCellMask_CombinedMultiFlags_AND_Public_BitMask2D_16x16_TileCell_StandardLayerFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_16x16*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792283, XrefRangeEnd = 792284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BitMask2D_16x16 GetCellMask_CombinedMultiFlags_AND(
      TileCell tileCell,
      MapCollisionFlags relevantFlags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tileCell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &relevantFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetCellMask_CombinedMultiFlags_AND_Public_BitMask2D_16x16_TileCell_MapCollisionFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_16x16*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792284, XrefRangeEnd = 792285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BitMask2D_16x16 GetCellMask_CombinedMultiFlags_AND(
      TileCell tileCell,
      LineOfSightTileFlags relevantFlags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tileCell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &relevantFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetCellMask_CombinedMultiFlags_AND_Public_BitMask2D_16x16_TileCell_LineOfSightTileFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_16x16*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792285, XrefRangeEnd = 792286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileCellEnumReader GetCellEnumReader(StandardLayerFlags relevantFlags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &relevantFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetCellEnumReader_Public_TileCellEnumReader_StandardLayerFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileCellEnumReader*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 792287, RefRangeEnd = 792291, XrefRangeStart = 792286, XrefRangeEnd = 792287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileCellEnumReader GetCellEnumReader(MapCollisionFlags relevantFlags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &relevantFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetCellEnumReader_Public_TileCellEnumReader_MapCollisionFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileCellEnumReader*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 792292, RefRangeEnd = 792294, XrefRangeStart = 792291, XrefRangeEnd = 792292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileCellEnumReader GetCellEnumReader(LineOfSightTileFlags relevantFlags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &relevantFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetCellEnumReader_Public_TileCellEnumReader_LineOfSightTileFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileCellEnumReader*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792294, XrefRangeEnd = 792298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetTile_SingleFlag(
      TileCell tileCell,
      int2 cellTile,
      StandardLayerFlags flag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &tileCell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cellTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &flag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetTile_SingleFlag_Public_Boolean_TileCell_int2_StandardLayerFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792298, XrefRangeEnd = 792302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetTile_SingleFlag(TileCell tileCell, int2 cellTile, MapCollisionFlags flag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &tileCell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cellTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &flag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetTile_SingleFlag_Public_Boolean_TileCell_int2_MapCollisionFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792302, XrefRangeEnd = 792306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetTile_SingleFlag(
      TileCell tileCell,
      int2 cellTile,
      LineOfSightTileFlags flag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &tileCell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cellTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &flag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetTile_SingleFlag_Public_Boolean_TileCell_int2_LineOfSightTileFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792306, XrefRangeEnd = 792307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StandardLayerFlags GetTile_MultiFlags_Expensive(
      TileCell tileCell,
      int2 cellTile,
      StandardLayerFlags relevantFlags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &tileCell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cellTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &relevantFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetTile_MultiFlags_Expensive_Public_StandardLayerFlags_TileCell_int2_StandardLayerFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(StandardLayerFlags*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792307, XrefRangeEnd = 792308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MapCollisionFlags GetTile_MultiFlags_Expensive(
      TileCell tileCell,
      int2 cellTile,
      MapCollisionFlags relevantFlags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &tileCell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cellTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &relevantFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetTile_MultiFlags_Expensive_Public_MapCollisionFlags_TileCell_int2_MapCollisionFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(MapCollisionFlags*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792308, XrefRangeEnd = 792309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LineOfSightTileFlags GetTile_MultiFlags_Expensive(
      TileCell tileCell,
      int2 cellTile,
      LineOfSightTileFlags relevantFlags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &tileCell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cellTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &relevantFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetTile_MultiFlags_Expensive_Public_LineOfSightTileFlags_TileCell_int2_LineOfSightTileFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(LineOfSightTileFlags*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792309, XrefRangeEnd = 792310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetCellMaskIndex(StandardLayerFlags flag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &flag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetCellMaskIndex_Public_Int32_StandardLayerFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792310, XrefRangeEnd = 792311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetCellMaskIndex(MapCollisionFlags flag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &flag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetCellMaskIndex_Public_Int32_MapCollisionFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792311, XrefRangeEnd = 792312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetCellMaskIndex(LineOfSightTileFlags flag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &flag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetCellMaskIndex_Public_Int32_LineOfSightTileFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 792314, RefRangeEnd = 792316, XrefRangeStart = 792312, XrefRangeEnd = 792314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetCellMaskIndex(TileCellMaskType type, int flagIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &flagIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetCellMaskIndex_Public_Int32_TileCellMaskType_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 792325, RefRangeEnd = 792332, XrefRangeStart = 792316, XrefRangeEnd = 792325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeArray<PathfindingTile> GetPathfindingTiles()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetPathfindingTiles_Public_NativeArray_1_PathfindingTile_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeArray<PathfindingTile>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 792341, RefRangeEnd = 792349, XrefRangeStart = 792332, XrefRangeEnd = 792341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeArray<PathfindingTile> GetPathfindingTilesSizeTwo()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetPathfindingTilesSizeTwo_Public_NativeArray_1_PathfindingTile_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeArray<PathfindingTile>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 296180, RefRangeEnd = 296186, XrefRangeStart = 296180, XrefRangeEnd = 296186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeArray<T> ToTempNativeArray<T>(void* ptr, int length)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ptr;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.MethodInfoStoreGeneric_ToTempNativeArray_Private_Static_NativeArray_1_T_ptr_Void_Int32_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeArray<T>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 792360, RefRangeEnd = 792370, XrefRangeStart = 792349, XrefRangeEnd = 792360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetCellMaskIndex(int allSetEnumFlags, int flagTypeOffset, int targetFlag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &allSetEnumFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &flagTypeOffset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &targetFlag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetCellMaskIndex_Private_Int32_Int32_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 792381, RefRangeEnd = 792384, XrefRangeStart = 792370, XrefRangeEnd = 792381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BitMask2D_16x16 GetCombinedFlags_OR(
      TileCell tileCell,
      int allFlagsForType,
      int typeFlagOffset,
      int relevantFlags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &tileCell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allFlagsForType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &typeFlagOffset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &relevantFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetCombinedFlags_OR_Private_BitMask2D_16x16_TileCell_Int32_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_16x16*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 792395, RefRangeEnd = 792398, XrefRangeStart = 792384, XrefRangeEnd = 792395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BitMask2D_16x16 GetCombinedFlags_AND(
      TileCell tileCell,
      int allFlagsForType,
      int typeFlagOffset,
      int relevantFlags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &tileCell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allFlagsForType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &typeFlagOffset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &relevantFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetCombinedFlags_AND_Private_BitMask2D_16x16_TileCell_Int32_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BitMask2D_16x16*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 792407, RefRangeEnd = 792410, XrefRangeStart = 792398, XrefRangeEnd = 792407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileCellEnumReader GetFlags(
      int allFlagsForType,
      int typeFlagOffset,
      int relevantFlags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &allFlagsForType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &typeFlagOffset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &relevantFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetFlags_Private_TileCellEnumReader_Int32_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileCellEnumReader*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 792420, RefRangeEnd = 792423, XrefRangeStart = 792410, XrefRangeEnd = 792420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetEnumValue(
      TileCell tileCell,
      int2 cellTile,
      int allFlagsForType,
      int typeFlagOffset,
      int relevantFlags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &tileCell;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cellTile;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &allFlagsForType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &typeFlagOffset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &relevantFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayer.NativeMethodInfoPtr_GetEnumValue_Private_Int32_TileCell_int2_Int32_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TileLayer()
    {
      Il2CppClassPointerStore<TileLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileLayer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileLayer>.NativeClassPtr);
      TileLayer.NativeFieldInfoPtr_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, nameof (Ptr));
      TileLayer.NativeMethodInfoPtr__ctor_Internal_Void_ptr_TileLayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669736);
      TileLayer.NativeMethodInfoPtr_GetReadonlyRef_Public_byref_TileLayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669737);
      TileLayer.NativeMethodInfoPtr_IsCreated_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669738);
      TileLayer.NativeMethodInfoPtr_get_GameplayMinHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669739);
      TileLayer.NativeMethodInfoPtr_get_GameplayMaxHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669740);
      TileLayer.NativeMethodInfoPtr_get_StandardLayerFlags_Public_get_StandardLayerFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669741);
      TileLayer.NativeMethodInfoPtr_get_MapCollisionFlags_Public_get_MapCollisionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669742);
      TileLayer.NativeMethodInfoPtr_get_LineOfSightTileFlags_Public_get_LineOfSightTileFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669743);
      TileLayer.NativeMethodInfoPtr_GetGameplayHeights_Public_NativeArray_1_UInt16_TileCell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669744);
      TileLayer.NativeMethodInfoPtr_GetGameplayHeight_Public_Single_TileCell_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669745);
      TileLayer.NativeMethodInfoPtr_GetCellMask_SingleFlag_Public_byref_BitMask2D_16x16_TileCell_StandardLayerFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669746);
      TileLayer.NativeMethodInfoPtr_GetCellMask_SingleFlag_Public_byref_BitMask2D_16x16_TileCell_MapCollisionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669747);
      TileLayer.NativeMethodInfoPtr_GetCellMask_SingleFlag_Public_byref_BitMask2D_16x16_TileCell_LineOfSightTileFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669748);
      TileLayer.NativeMethodInfoPtr_GetCellMask_SingleFlag_Public_byref_BitMask2D_16x16_TileCell_TileCellMaskType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669749);
      TileLayer.NativeMethodInfoPtr_GetCellMask_CombinedMultiFlags_OR_Public_BitMask2D_16x16_TileCell_StandardLayerFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669750);
      TileLayer.NativeMethodInfoPtr_GetCellMask_CombinedMultiFlags_OR_Public_BitMask2D_16x16_TileCell_MapCollisionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669751);
      TileLayer.NativeMethodInfoPtr_GetCellMask_CombinedMultiFlags_OR_Public_BitMask2D_16x16_TileCell_LineOfSightTileFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669752);
      TileLayer.NativeMethodInfoPtr_GetCellMask_CombinedMultiFlags_AND_Public_BitMask2D_16x16_TileCell_StandardLayerFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669753);
      TileLayer.NativeMethodInfoPtr_GetCellMask_CombinedMultiFlags_AND_Public_BitMask2D_16x16_TileCell_MapCollisionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669754);
      TileLayer.NativeMethodInfoPtr_GetCellMask_CombinedMultiFlags_AND_Public_BitMask2D_16x16_TileCell_LineOfSightTileFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669755);
      TileLayer.NativeMethodInfoPtr_GetCellEnumReader_Public_TileCellEnumReader_StandardLayerFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669756);
      TileLayer.NativeMethodInfoPtr_GetCellEnumReader_Public_TileCellEnumReader_MapCollisionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669757);
      TileLayer.NativeMethodInfoPtr_GetCellEnumReader_Public_TileCellEnumReader_LineOfSightTileFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669758);
      TileLayer.NativeMethodInfoPtr_GetTile_SingleFlag_Public_Boolean_TileCell_int2_StandardLayerFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669759);
      TileLayer.NativeMethodInfoPtr_GetTile_SingleFlag_Public_Boolean_TileCell_int2_MapCollisionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669760);
      TileLayer.NativeMethodInfoPtr_GetTile_SingleFlag_Public_Boolean_TileCell_int2_LineOfSightTileFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669761);
      TileLayer.NativeMethodInfoPtr_GetTile_MultiFlags_Expensive_Public_StandardLayerFlags_TileCell_int2_StandardLayerFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669762);
      TileLayer.NativeMethodInfoPtr_GetTile_MultiFlags_Expensive_Public_MapCollisionFlags_TileCell_int2_MapCollisionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669763);
      TileLayer.NativeMethodInfoPtr_GetTile_MultiFlags_Expensive_Public_LineOfSightTileFlags_TileCell_int2_LineOfSightTileFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669764);
      TileLayer.NativeMethodInfoPtr_GetCellMaskIndex_Public_Int32_StandardLayerFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669765);
      TileLayer.NativeMethodInfoPtr_GetCellMaskIndex_Public_Int32_MapCollisionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669766);
      TileLayer.NativeMethodInfoPtr_GetCellMaskIndex_Public_Int32_LineOfSightTileFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669767);
      TileLayer.NativeMethodInfoPtr_GetCellMaskIndex_Public_Int32_TileCellMaskType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669768);
      TileLayer.NativeMethodInfoPtr_GetPathfindingTiles_Public_NativeArray_1_PathfindingTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669769);
      TileLayer.NativeMethodInfoPtr_GetPathfindingTilesSizeTwo_Public_NativeArray_1_PathfindingTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669770);
      TileLayer.NativeMethodInfoPtr_ToTempNativeArray_Private_Static_NativeArray_1_T_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669771);
      TileLayer.NativeMethodInfoPtr_GetCellMaskIndex_Private_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669772);
      TileLayer.NativeMethodInfoPtr_GetCombinedFlags_OR_Private_BitMask2D_16x16_TileCell_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669773);
      TileLayer.NativeMethodInfoPtr_GetCombinedFlags_AND_Private_BitMask2D_16x16_TileCell_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669774);
      TileLayer.NativeMethodInfoPtr_GetFlags_Private_TileCellEnumReader_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669775);
      TileLayer.NativeMethodInfoPtr_GetEnumValue_Private_Int32_TileCell_int2_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, 100669776);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileLayer>.NativeClassPtr, (System.IntPtr) ref this));
    }

    private sealed class MethodInfoStoreGeneric_ToTempNativeArray_Private_Static_NativeArray_1_T_ptr_Void_Int32_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TileLayer.NativeMethodInfoPtr_ToTempNativeArray_Private_Static_NativeArray_1_T_ptr_Void_Int32_0, Il2CppClassPointerStore<TileLayer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
