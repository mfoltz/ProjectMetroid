// Decompiled with JetBrains decompiler
// Type: ProjectM.Roofs.RoomTestingUtility
// Assembly: ProjectM.Roofs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D6B6D22B-4E3A-4809-82A6-CC2DECC85297
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Roofs.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.CastleBuilding;
using System.Runtime.InteropServices;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Roofs
{
  public static class RoomTestingUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FloorSpacing;
    private static readonly System.IntPtr NativeMethodInfoPtr_WallLocation_Public_Static_TilePosition_Int32_Int32_CardinalDirection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FloorLocation_Public_Static_TilePosition_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WallTransform_Public_Static_LocalToWorld_Int32_Int32_Single_CardinalDirection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FloorTransform_Public_Static_LocalToWorld_Int32_Int32_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TileModelTransform_Public_Static_LocalToWorld_Int32_Int32_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1638111, RefRangeEnd = 1638113, XrefRangeStart = 1638111, XrefRangeEnd = 1638111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TilePosition WallLocation(
      int floorX,
      int floorY,
      CardinalDirection direction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &floorX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &floorY;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomTestingUtility.NativeMethodInfoPtr_WallLocation_Public_Static_TilePosition_Int32_Int32_CardinalDirection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TilePosition*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe TilePosition FloorLocation(int floorX, int floorY)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &floorX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &floorY;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomTestingUtility.NativeMethodInfoPtr_FloorLocation_Public_Static_TilePosition_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TilePosition*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638113, XrefRangeEnd = 1638127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe LocalToWorld WallTransform(
      int floorTileX,
      int floorTileY,
      float posY,
      CardinalDirection direction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &floorTileX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &floorTileY;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &posY;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomTestingUtility.NativeMethodInfoPtr_WallTransform_Public_Static_LocalToWorld_Int32_Int32_Single_CardinalDirection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(LocalToWorld*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638127, XrefRangeEnd = 1638136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe LocalToWorld FloorTransform(int floorTileX, int floorTileY, float posY)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &floorTileX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &floorTileY;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &posY;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomTestingUtility.NativeMethodInfoPtr_FloorTransform_Public_Static_LocalToWorld_Int32_Int32_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(LocalToWorld*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638136, XrefRangeEnd = 1638145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe LocalToWorld TileModelTransform(int tileX, int tileY)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &tileX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileY;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoomTestingUtility.NativeMethodInfoPtr_TileModelTransform_Public_Static_LocalToWorld_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(LocalToWorld*) IL2CPP.il2cpp_object_unbox(num);
    }

    static RoomTestingUtility()
    {
      Il2CppClassPointerStore<RoomTestingUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Roofs.dll", "ProjectM.Roofs", nameof (RoomTestingUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomTestingUtility>.NativeClassPtr);
      RoomTestingUtility.NativeFieldInfoPtr_FloorSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomTestingUtility>.NativeClassPtr, nameof (FloorSpacing));
      RoomTestingUtility.NativeMethodInfoPtr_WallLocation_Public_Static_TilePosition_Int32_Int32_CardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomTestingUtility>.NativeClassPtr, 100663341);
      RoomTestingUtility.NativeMethodInfoPtr_FloorLocation_Public_Static_TilePosition_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomTestingUtility>.NativeClassPtr, 100663342);
      RoomTestingUtility.NativeMethodInfoPtr_WallTransform_Public_Static_LocalToWorld_Int32_Int32_Single_CardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomTestingUtility>.NativeClassPtr, 100663343);
      RoomTestingUtility.NativeMethodInfoPtr_FloorTransform_Public_Static_LocalToWorld_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomTestingUtility>.NativeClassPtr, 100663344);
      RoomTestingUtility.NativeMethodInfoPtr_TileModelTransform_Public_Static_LocalToWorld_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomTestingUtility>.NativeClassPtr, 100663345);
    }

    public RoomTestingUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int FloorSpacing
    {
      get
      {
        int floorSpacing;
        IL2CPP.il2cpp_field_static_get_value(RoomTestingUtility.NativeFieldInfoPtr_FloorSpacing, (void*) &floorSpacing);
        return floorSpacing;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RoomTestingUtility.NativeFieldInfoPtr_FloorSpacing, (void*) &value);
      }
    }
  }
}
