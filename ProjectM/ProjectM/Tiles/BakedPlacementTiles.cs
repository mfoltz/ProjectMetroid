// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.BakedPlacementTiles
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
  public struct BakedPlacementTiles
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Data;
    private static readonly System.IntPtr NativeFieldInfoPtr_TilePosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_LevelCount;
    [FieldOffset(0)]
    public BlobAssetReference<TileDatas2dArray<PlacementData>> Data;
    [FieldOffset(8)]
    public TilePosition TilePosition;
    [FieldOffset(20)]
    public PrefabGUID PrefabGUID;
    [FieldOffset(24)]
    public byte LevelCount;

    static BakedPlacementTiles()
    {
      Il2CppClassPointerStore<BakedPlacementTiles>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (BakedPlacementTiles));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BakedPlacementTiles>.NativeClassPtr);
      BakedPlacementTiles.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BakedPlacementTiles>.NativeClassPtr, nameof (Data));
      BakedPlacementTiles.NativeFieldInfoPtr_TilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BakedPlacementTiles>.NativeClassPtr, nameof (TilePosition));
      BakedPlacementTiles.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BakedPlacementTiles>.NativeClassPtr, nameof (PrefabGUID));
      BakedPlacementTiles.NativeFieldInfoPtr_LevelCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BakedPlacementTiles>.NativeClassPtr, nameof (LevelCount));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BakedPlacementTiles>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
