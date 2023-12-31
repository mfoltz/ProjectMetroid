// Decompiled with JetBrains decompiler
// Type: ProjectM.TileHistoryConstants
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class TileHistoryConstants : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_SNAPSHOT_COUNT;
    private static readonly System.IntPtr NativeFieldInfoPtr_TILES_PER_SNAPSHOT;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_TILES;
    private static readonly System.IntPtr NativeFieldInfoPtr_HALF_SIZE;

    static TileHistoryConstants()
    {
      Il2CppClassPointerStore<TileHistoryConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TileHistoryConstants));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileHistoryConstants>.NativeClassPtr);
      TileHistoryConstants.NativeFieldInfoPtr_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHistoryConstants>.NativeClassPtr, nameof (SIZE));
      TileHistoryConstants.NativeFieldInfoPtr_SNAPSHOT_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHistoryConstants>.NativeClassPtr, nameof (SNAPSHOT_COUNT));
      TileHistoryConstants.NativeFieldInfoPtr_TILES_PER_SNAPSHOT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHistoryConstants>.NativeClassPtr, nameof (TILES_PER_SNAPSHOT));
      TileHistoryConstants.NativeFieldInfoPtr_MAX_TILES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHistoryConstants>.NativeClassPtr, nameof (MAX_TILES));
      TileHistoryConstants.NativeFieldInfoPtr_HALF_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileHistoryConstants>.NativeClassPtr, nameof (HALF_SIZE));
    }

    public TileHistoryConstants(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int SIZE
    {
      get
      {
        int size;
        IL2CPP.il2cpp_field_static_get_value(TileHistoryConstants.NativeFieldInfoPtr_SIZE, (void*) &size);
        return size;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileHistoryConstants.NativeFieldInfoPtr_SIZE, (void*) &value);
      }
    }

    public static unsafe int SNAPSHOT_COUNT
    {
      get
      {
        int snapshotCount;
        IL2CPP.il2cpp_field_static_get_value(TileHistoryConstants.NativeFieldInfoPtr_SNAPSHOT_COUNT, (void*) &snapshotCount);
        return snapshotCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileHistoryConstants.NativeFieldInfoPtr_SNAPSHOT_COUNT, (void*) &value);
      }
    }

    public static unsafe int TILES_PER_SNAPSHOT
    {
      get
      {
        int tilesPerSnapshot;
        IL2CPP.il2cpp_field_static_get_value(TileHistoryConstants.NativeFieldInfoPtr_TILES_PER_SNAPSHOT, (void*) &tilesPerSnapshot);
        return tilesPerSnapshot;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileHistoryConstants.NativeFieldInfoPtr_TILES_PER_SNAPSHOT, (void*) &value);
      }
    }

    public static unsafe int MAX_TILES
    {
      get
      {
        int maxTiles;
        IL2CPP.il2cpp_field_static_get_value(TileHistoryConstants.NativeFieldInfoPtr_MAX_TILES, (void*) &maxTiles);
        return maxTiles;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileHistoryConstants.NativeFieldInfoPtr_MAX_TILES, (void*) &value);
      }
    }

    public static unsafe int HALF_SIZE
    {
      get
      {
        int halfSize;
        IL2CPP.il2cpp_field_static_get_value(TileHistoryConstants.NativeFieldInfoPtr_HALF_SIZE, (void*) &halfSize);
        return halfSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileHistoryConstants.NativeFieldInfoPtr_HALF_SIZE, (void*) &value);
      }
    }
  }
}
