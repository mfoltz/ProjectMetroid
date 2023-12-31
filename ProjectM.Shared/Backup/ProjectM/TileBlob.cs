// Decompiled with JetBrains decompiler
// Type: ProjectM.TileBlob
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using ProjectM.Tiles;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileBlob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalBounds;
    private static readonly System.IntPtr NativeFieldInfoPtr_PivotSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_Layer;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileGridSnapType;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeightPlacementConfig;
    private static readonly System.IntPtr NativeFieldInfoPtr_MultiLevelTileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionTiles;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionTiles2D;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlacementTiles;
    private static readonly System.IntPtr NativeFieldInfoPtr_SurfaceFluffTiles;
    private static readonly System.IntPtr NativeFieldInfoPtr_PathfindingTiles;
    private static readonly System.IntPtr NativeFieldInfoPtr_LineOfSightTiles;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayHeightTiles;
    private static readonly System.IntPtr NativeFieldInfoPtr_TerrainHeightTiles;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHeightLevels_Public_TileModelHeightLevels_Single_0;
    [FieldOffset(0)]
    public float MinHeight;
    [FieldOffset(4)]
    public float MaxHeight;
    [FieldOffset(8)]
    public BoundsMinMax LocalBounds;
    [FieldOffset(24)]
    public TilePivotSettings PivotSettings;
    [FieldOffset(36)]
    public TileModelLayerEnum Layer;
    [FieldOffset(37)]
    public TileSnapType TileGridSnapType;
    [FieldOffset(38)]
    public TileType TileTypes;
    [FieldOffset(40)]
    public Nullable_Unboxed<ProjectM.HeightPlacementConfig> HeightPlacementConfig;
    [FieldOffset(76)]
    public bool MultiLevelTileModel;
    [FieldOffset(80)]
    public TileDatas<CollisionData> CollisionTiles;
    [FieldOffset(88)]
    public TileDatas2dArray<CollisionData> CollisionTiles2D;
    [FieldOffset(120)]
    public TileDatas2dArray<PlacementData> PlacementTiles;
    [FieldOffset(152)]
    public TileDatas<SurfaceFluffData> SurfaceFluffTiles;
    [FieldOffset(160)]
    public TileDatas<PathfindingTileData> PathfindingTiles;
    [FieldOffset(168)]
    public TileDatas<LineOfSightTileData> LineOfSightTiles;
    [FieldOffset(176)]
    public TileDatas<TileHeightData> GameplayHeightTiles;
    [FieldOffset(184)]
    public TileDatas<TileHeightData> TerrainHeightTiles;
    [FieldOffset(192)]
    public PrefabGUID PrefabGUID;

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 732136, RefRangeEnd = 732144, XrefRangeStart = 732132, XrefRangeEnd = 732136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileModelHeightLevels GetHeightLevels(float positionY)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &positionY;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBlob.NativeMethodInfoPtr_GetHeightLevels_Public_TileModelHeightLevels_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileModelHeightLevels*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TileBlob()
    {
      Il2CppClassPointerStore<TileBlob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TileBlob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileBlob>.NativeClassPtr);
      TileBlob.NativeFieldInfoPtr_MinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, nameof (MinHeight));
      TileBlob.NativeFieldInfoPtr_MaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, nameof (MaxHeight));
      TileBlob.NativeFieldInfoPtr_LocalBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, nameof (LocalBounds));
      TileBlob.NativeFieldInfoPtr_PivotSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, nameof (PivotSettings));
      TileBlob.NativeFieldInfoPtr_Layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, nameof (Layer));
      TileBlob.NativeFieldInfoPtr_TileGridSnapType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, nameof (TileGridSnapType));
      TileBlob.NativeFieldInfoPtr_TileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, nameof (TileTypes));
      TileBlob.NativeFieldInfoPtr_HeightPlacementConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, nameof (HeightPlacementConfig));
      TileBlob.NativeFieldInfoPtr_MultiLevelTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, nameof (MultiLevelTileModel));
      TileBlob.NativeFieldInfoPtr_CollisionTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, nameof (CollisionTiles));
      TileBlob.NativeFieldInfoPtr_CollisionTiles2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, nameof (CollisionTiles2D));
      TileBlob.NativeFieldInfoPtr_PlacementTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, nameof (PlacementTiles));
      TileBlob.NativeFieldInfoPtr_SurfaceFluffTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, nameof (SurfaceFluffTiles));
      TileBlob.NativeFieldInfoPtr_PathfindingTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, nameof (PathfindingTiles));
      TileBlob.NativeFieldInfoPtr_LineOfSightTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, nameof (LineOfSightTiles));
      TileBlob.NativeFieldInfoPtr_GameplayHeightTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, nameof (GameplayHeightTiles));
      TileBlob.NativeFieldInfoPtr_TerrainHeightTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, nameof (TerrainHeightTiles));
      TileBlob.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, nameof (PrefabGUID));
      TileBlob.NativeMethodInfoPtr_GetHeightLevels_Public_TileModelHeightLevels_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, 100664680);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
