// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CardinalDirectionExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public static class CardinalDirectionExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Directions;
    private static readonly System.IntPtr NativeFieldInfoPtr_DirectionsMultiFloors;
    private static readonly System.IntPtr NativeMethodInfoPtr_Mirror_Public_Static_CardinalDirection_CardinalDirection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOrnamentRotation_Public_Static_TileRotation_CardinalDirection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileRotation_Public_Static_TileRotation_CardinalDirection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddTileRotation_Public_Static_CardinalDirection_CardinalDirection_TileRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileDirection_Public_Static_int2_CardinalDirection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBlockDirection_Public_Static_int3_CardinalDirection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromTileRotation_Private_Static_CardinalDirection_TileRotation_0;

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 794164, RefRangeEnd = 794177, XrefRangeStart = 794164, XrefRangeEnd = 794164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CardinalDirection Mirror(this CardinalDirection cardinalDirection)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &cardinalDirection;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardinalDirectionExtensions.NativeMethodInfoPtr_Mirror_Public_Static_CardinalDirection_CardinalDirection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CardinalDirection*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 794178, RefRangeEnd = 794179, XrefRangeStart = 794177, XrefRangeEnd = 794178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileRotation GetOrnamentRotation(this CardinalDirection cardinalDirection)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &cardinalDirection;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardinalDirectionExtensions.NativeMethodInfoPtr_GetOrnamentRotation_Public_Static_TileRotation_CardinalDirection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileRotation*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 794179, RefRangeEnd = 794181, XrefRangeStart = 794179, XrefRangeEnd = 794179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TileRotation GetTileRotation(this CardinalDirection cardinalDirection)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &cardinalDirection;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardinalDirectionExtensions.NativeMethodInfoPtr_GetTileRotation_Public_Static_TileRotation_CardinalDirection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileRotation*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 794183, RefRangeEnd = 794189, XrefRangeStart = 794181, XrefRangeEnd = 794183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CardinalDirection AddTileRotation(
      this CardinalDirection cardinalDirection,
      TileRotation tileRotationToAdd)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &cardinalDirection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tileRotationToAdd;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardinalDirectionExtensions.NativeMethodInfoPtr_AddTileRotation_Public_Static_CardinalDirection_CardinalDirection_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CardinalDirection*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 794190, RefRangeEnd = 794191, XrefRangeStart = 794189, XrefRangeEnd = 794190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int2 GetTileDirection(this CardinalDirection cardinalDirection)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &cardinalDirection;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardinalDirectionExtensions.NativeMethodInfoPtr_GetTileDirection_Public_Static_int2_CardinalDirection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 794192, RefRangeEnd = 794205, XrefRangeStart = 794191, XrefRangeEnd = 794192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int3 GetBlockDirection(this CardinalDirection cardinalDirection)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &cardinalDirection;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardinalDirectionExtensions.NativeMethodInfoPtr_GetBlockDirection_Public_Static_int3_CardinalDirection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe CardinalDirection FromTileRotation(TileRotation tileRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tileRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardinalDirectionExtensions.NativeMethodInfoPtr_FromTileRotation_Private_Static_CardinalDirection_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CardinalDirection*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CardinalDirectionExtensions()
    {
      Il2CppClassPointerStore<CardinalDirectionExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding", nameof (CardinalDirectionExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardinalDirectionExtensions>.NativeClassPtr);
      CardinalDirectionExtensions.NativeFieldInfoPtr_Directions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardinalDirectionExtensions>.NativeClassPtr, nameof (Directions));
      CardinalDirectionExtensions.NativeFieldInfoPtr_DirectionsMultiFloors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardinalDirectionExtensions>.NativeClassPtr, nameof (DirectionsMultiFloors));
      CardinalDirectionExtensions.NativeMethodInfoPtr_Mirror_Public_Static_CardinalDirection_CardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardinalDirectionExtensions>.NativeClassPtr, 100670013);
      CardinalDirectionExtensions.NativeMethodInfoPtr_GetOrnamentRotation_Public_Static_TileRotation_CardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardinalDirectionExtensions>.NativeClassPtr, 100670014);
      CardinalDirectionExtensions.NativeMethodInfoPtr_GetTileRotation_Public_Static_TileRotation_CardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardinalDirectionExtensions>.NativeClassPtr, 100670015);
      CardinalDirectionExtensions.NativeMethodInfoPtr_AddTileRotation_Public_Static_CardinalDirection_CardinalDirection_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardinalDirectionExtensions>.NativeClassPtr, 100670016);
      CardinalDirectionExtensions.NativeMethodInfoPtr_GetTileDirection_Public_Static_int2_CardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardinalDirectionExtensions>.NativeClassPtr, 100670017);
      CardinalDirectionExtensions.NativeMethodInfoPtr_GetBlockDirection_Public_Static_int3_CardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardinalDirectionExtensions>.NativeClassPtr, 100670018);
      CardinalDirectionExtensions.NativeMethodInfoPtr_FromTileRotation_Private_Static_CardinalDirection_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardinalDirectionExtensions>.NativeClassPtr, 100670019);
    }

    public CardinalDirectionExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int Directions
    {
      get
      {
        int directions;
        IL2CPP.il2cpp_field_static_get_value(CardinalDirectionExtensions.NativeFieldInfoPtr_Directions, (void*) &directions);
        return directions;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CardinalDirectionExtensions.NativeFieldInfoPtr_Directions, (void*) &value);
      }
    }

    public static unsafe int DirectionsMultiFloors
    {
      get
      {
        int directionsMultiFloors;
        IL2CPP.il2cpp_field_static_get_value(CardinalDirectionExtensions.NativeFieldInfoPtr_DirectionsMultiFloors, (void*) &directionsMultiFloors);
        return directionsMultiFloors;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CardinalDirectionExtensions.NativeFieldInfoPtr_DirectionsMultiFloors, (void*) &value);
      }
    }
  }
}
