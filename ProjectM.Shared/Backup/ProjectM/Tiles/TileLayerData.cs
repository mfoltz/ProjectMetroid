// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileLayerData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileLayerData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayMinHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayMaxHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayHeightsIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_PathfindingTile;
    private static readonly System.IntPtr NativeFieldInfoPtr_PathfindingTileSizeTwo;
    private static readonly System.IntPtr NativeFieldInfoPtr_StandardLayerFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapCollisionFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_LineOfSightTileFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_StandardLayerFlagCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapCollisionFlagCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_LineOfSightTileFlagCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaskIndexInCell;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_StandardLayerFlagOffset_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MapCollisionFlagOffset_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LineOfSightTileFlagOffset_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
    [FieldOffset(0)]
    public float GameplayMinHeight;
    [FieldOffset(4)]
    public float GameplayMaxHeight;
    [FieldOffset(8)]
    public byte GameplayHeightsIndex;
    [FieldOffset(16)]
    public UnsafeList<ProjectM.Pathfinding.PathfindingTile> PathfindingTile;
    [FieldOffset(40)]
    public UnsafeList<ProjectM.Pathfinding.PathfindingTile> PathfindingTileSizeTwo;
    [FieldOffset(64)]
    public StandardLayerFlags StandardLayerFlags;
    [FieldOffset(65)]
    public MapCollisionFlags MapCollisionFlags;
    [FieldOffset(66)]
    public LineOfSightTileFlags LineOfSightTileFlags;
    [FieldOffset(67)]
    public byte StandardLayerFlagCount;
    [FieldOffset(68)]
    public byte MapCollisionFlagCount;
    [FieldOffset(69)]
    public byte LineOfSightTileFlagCount;
    [FieldOffset(70)]
    public FixedList32<byte> MaskIndexInCell;

    public unsafe int StandardLayerFlagOffset
    {
      [CallerCount(1474), CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerData.NativeMethodInfoPtr_get_StandardLayerFlagOffset_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int MapCollisionFlagOffset
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerData.NativeMethodInfoPtr_get_MapCollisionFlagOffset_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int LineOfSightTileFlagOffset
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileLayerData.NativeMethodInfoPtr_get_LineOfSightTileFlagOffset_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792145, XrefRangeEnd = 792155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileLayerData.NativeMethodInfoPtr_Dispose_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TileLayerData()
    {
      Il2CppClassPointerStore<TileLayerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileLayerData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileLayerData>.NativeClassPtr);
      TileLayerData.NativeFieldInfoPtr_GameplayMinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLayerData>.NativeClassPtr, nameof (GameplayMinHeight));
      TileLayerData.NativeFieldInfoPtr_GameplayMaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLayerData>.NativeClassPtr, nameof (GameplayMaxHeight));
      TileLayerData.NativeFieldInfoPtr_GameplayHeightsIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLayerData>.NativeClassPtr, nameof (GameplayHeightsIndex));
      TileLayerData.NativeFieldInfoPtr_PathfindingTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLayerData>.NativeClassPtr, nameof (PathfindingTile));
      TileLayerData.NativeFieldInfoPtr_PathfindingTileSizeTwo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLayerData>.NativeClassPtr, nameof (PathfindingTileSizeTwo));
      TileLayerData.NativeFieldInfoPtr_StandardLayerFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLayerData>.NativeClassPtr, nameof (StandardLayerFlags));
      TileLayerData.NativeFieldInfoPtr_MapCollisionFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLayerData>.NativeClassPtr, nameof (MapCollisionFlags));
      TileLayerData.NativeFieldInfoPtr_LineOfSightTileFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLayerData>.NativeClassPtr, nameof (LineOfSightTileFlags));
      TileLayerData.NativeFieldInfoPtr_StandardLayerFlagCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLayerData>.NativeClassPtr, nameof (StandardLayerFlagCount));
      TileLayerData.NativeFieldInfoPtr_MapCollisionFlagCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLayerData>.NativeClassPtr, nameof (MapCollisionFlagCount));
      TileLayerData.NativeFieldInfoPtr_LineOfSightTileFlagCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLayerData>.NativeClassPtr, nameof (LineOfSightTileFlagCount));
      TileLayerData.NativeFieldInfoPtr_MaskIndexInCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileLayerData>.NativeClassPtr, nameof (MaskIndexInCell));
      TileLayerData.NativeMethodInfoPtr_get_StandardLayerFlagOffset_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerData>.NativeClassPtr, 100669711);
      TileLayerData.NativeMethodInfoPtr_get_MapCollisionFlagOffset_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerData>.NativeClassPtr, 100669712);
      TileLayerData.NativeMethodInfoPtr_get_LineOfSightTileFlagOffset_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerData>.NativeClassPtr, 100669713);
      TileLayerData.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayerData>.NativeClassPtr, 100669714);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileLayerData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
