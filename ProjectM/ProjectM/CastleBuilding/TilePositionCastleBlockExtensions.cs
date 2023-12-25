// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.TilePositionCastleBlockExtensions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public static class TilePositionCastleBlockExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFloorBlock_Public_Static_CastleBlock_byref_TilePosition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetWallBlock_Public_Static_CastleWallBlock_byref_TilePosition_byref_TilePivotSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPillarBlock_Public_Static_CastleBlock_byref_TilePosition_0;

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1126743, RefRangeEnd = 1126748, XrefRangeStart = 1126742, XrefRangeEnd = 1126743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CastleBlock GetFloorBlock([In] ref this TilePosition tilePosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref tilePosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TilePositionCastleBlockExtensions.NativeMethodInfoPtr_GetFloorBlock_Public_Static_CastleBlock_byref_TilePosition_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 1126749, RefRangeEnd = 1126757, XrefRangeStart = 1126748, XrefRangeEnd = 1126749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CastleWallBlock GetWallBlock(
      [In] ref this TilePosition tilePosition,
      [In] ref TilePivotSettings tilePivot)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref tilePosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tilePivot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TilePositionCastleBlockExtensions.NativeMethodInfoPtr_GetWallBlock_Public_Static_CastleWallBlock_byref_TilePosition_byref_TilePivotSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleWallBlock*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 1126758, RefRangeEnd = 1126766, XrefRangeStart = 1126757, XrefRangeEnd = 1126758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CastleBlock GetPillarBlock([In] ref this TilePosition tilePosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref tilePosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TilePositionCastleBlockExtensions.NativeMethodInfoPtr_GetPillarBlock_Public_Static_CastleBlock_byref_TilePosition_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleBlock*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TilePositionCastleBlockExtensions()
    {
      Il2CppClassPointerStore<TilePositionCastleBlockExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (TilePositionCastleBlockExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TilePositionCastleBlockExtensions>.NativeClassPtr);
      TilePositionCastleBlockExtensions.NativeMethodInfoPtr_GetFloorBlock_Public_Static_CastleBlock_byref_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilePositionCastleBlockExtensions>.NativeClassPtr, 100689484);
      TilePositionCastleBlockExtensions.NativeMethodInfoPtr_GetWallBlock_Public_Static_CastleWallBlock_byref_TilePosition_byref_TilePivotSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilePositionCastleBlockExtensions>.NativeClassPtr, 100689485);
      TilePositionCastleBlockExtensions.NativeMethodInfoPtr_GetPillarBlock_Public_Static_CastleBlock_byref_TilePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilePositionCastleBlockExtensions>.NativeClassPtr, 100689486);
    }

    public TilePositionCastleBlockExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
