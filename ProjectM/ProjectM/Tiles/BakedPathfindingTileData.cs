// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.BakedPathfindingTileData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BakedPathfindingTileData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Data;
    private static readonly System.IntPtr NativeFieldInfoPtr_TilePosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTileModelData;
    [FieldOffset(0)]
    public BlobAssetReference<TileDatas<PathfindingTileData>> Data;
    [FieldOffset(8)]
    public TilePosition TilePosition;
    [FieldOffset(20)]
    public StaticTileModelData StaticTileModelData;

    static BakedPathfindingTileData()
    {
      Il2CppClassPointerStore<BakedPathfindingTileData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (BakedPathfindingTileData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BakedPathfindingTileData>.NativeClassPtr);
      BakedPathfindingTileData.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BakedPathfindingTileData>.NativeClassPtr, nameof (Data));
      BakedPathfindingTileData.NativeFieldInfoPtr_TilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BakedPathfindingTileData>.NativeClassPtr, nameof (TilePosition));
      BakedPathfindingTileData.NativeFieldInfoPtr_StaticTileModelData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BakedPathfindingTileData>.NativeClassPtr, nameof (StaticTileModelData));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BakedPathfindingTileData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
