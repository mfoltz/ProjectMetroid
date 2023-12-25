// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.BakedLineOfSightTiles
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
  public struct BakedLineOfSightTiles
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Data;
    private static readonly System.IntPtr NativeFieldInfoPtr_TilePosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Layer;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaticTileModelData;
    [FieldOffset(0)]
    public BlobAssetReference<TileDatas<LineOfSightTileData>> Data;
    [FieldOffset(8)]
    public TilePosition TilePosition;
    [FieldOffset(20)]
    public TileModelLayerEnum Layer;
    [FieldOffset(21)]
    public StaticTileModelData StaticTileModelData;

    static BakedLineOfSightTiles()
    {
      Il2CppClassPointerStore<BakedLineOfSightTiles>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (BakedLineOfSightTiles));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BakedLineOfSightTiles>.NativeClassPtr);
      BakedLineOfSightTiles.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BakedLineOfSightTiles>.NativeClassPtr, nameof (Data));
      BakedLineOfSightTiles.NativeFieldInfoPtr_TilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BakedLineOfSightTiles>.NativeClassPtr, nameof (TilePosition));
      BakedLineOfSightTiles.NativeFieldInfoPtr_Layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BakedLineOfSightTiles>.NativeClassPtr, nameof (Layer));
      BakedLineOfSightTiles.NativeFieldInfoPtr_StaticTileModelData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BakedLineOfSightTiles>.NativeClassPtr, nameof (StaticTileModelData));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BakedLineOfSightTiles>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
