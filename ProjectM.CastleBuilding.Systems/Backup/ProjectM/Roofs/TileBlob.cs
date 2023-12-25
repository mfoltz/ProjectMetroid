// Decompiled with JetBrains decompiler
// Type: ProjectM.Roofs.TileBlob
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Terrain;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Roofs
{
  public static class TileBlob : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRootBlobCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxBlobCount;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBlobType_Public_Static_Boolean_TileBlobDefinition_byref_TileBlobRootType_byref_OrthogonalRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetStandardBlobType_Public_Static_TileBlobType_TileBlobRootType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBlobType_Public_Static_Boolean_TileBlobType_byref_TileBlobRootType_byref_OrthogonalRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TileTypeToDefinition_Public_Static_TileBlobDefinition_TileBlobType_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191593, XrefRangeEnd = 1191594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetBlobType(
      TileBlobDefinition definition,
      out TileBlobRootType rootType,
      out OrthogonalRotation rotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &definition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref rootType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBlob.NativeMethodInfoPtr_TryGetBlobType_Public_Static_Boolean_TileBlobDefinition_byref_TileBlobRootType_byref_OrthogonalRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe TileBlobType GetStandardBlobType(TileBlobRootType rootType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &rootType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBlob.NativeMethodInfoPtr_GetStandardBlobType_Public_Static_TileBlobType_TileBlobRootType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileBlobType*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1191594, RefRangeEnd = 1191597, XrefRangeStart = 1191594, XrefRangeEnd = 1191594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetBlobType(
      TileBlobType blobTileType,
      out TileBlobRootType rootType,
      out OrthogonalRotation rotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &blobTileType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref rootType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBlob.NativeMethodInfoPtr_TryGetBlobType_Public_Static_Boolean_TileBlobType_byref_TileBlobRootType_byref_OrthogonalRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe TileBlobDefinition TileTypeToDefinition(TileBlobType tileType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &tileType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBlob.NativeMethodInfoPtr_TileTypeToDefinition_Public_Static_TileBlobDefinition_TileBlobType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileBlobDefinition*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TileBlob()
    {
      Il2CppClassPointerStore<TileBlob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.Roofs", nameof (TileBlob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileBlob>.NativeClassPtr);
      TileBlob.NativeFieldInfoPtr_MaxRootBlobCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, nameof (MaxRootBlobCount));
      TileBlob.NativeFieldInfoPtr_MaxBlobCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, nameof (MaxBlobCount));
      TileBlob.NativeMethodInfoPtr_TryGetBlobType_Public_Static_Boolean_TileBlobDefinition_byref_TileBlobRootType_byref_OrthogonalRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, 100663466);
      TileBlob.NativeMethodInfoPtr_GetStandardBlobType_Public_Static_TileBlobType_TileBlobRootType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, 100663467);
      TileBlob.NativeMethodInfoPtr_TryGetBlobType_Public_Static_Boolean_TileBlobType_byref_TileBlobRootType_byref_OrthogonalRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, 100663468);
      TileBlob.NativeMethodInfoPtr_TileTypeToDefinition_Public_Static_TileBlobDefinition_TileBlobType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBlob>.NativeClassPtr, 100663469);
    }

    public TileBlob(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int MaxRootBlobCount
    {
      get
      {
        int maxRootBlobCount;
        IL2CPP.il2cpp_field_static_get_value(TileBlob.NativeFieldInfoPtr_MaxRootBlobCount, (void*) &maxRootBlobCount);
        return maxRootBlobCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileBlob.NativeFieldInfoPtr_MaxRootBlobCount, (void*) &value);
      }
    }

    public static unsafe int MaxBlobCount
    {
      get
      {
        int maxBlobCount;
        IL2CPP.il2cpp_field_static_get_value(TileBlob.NativeFieldInfoPtr_MaxBlobCount, (void*) &maxBlobCount);
        return maxBlobCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TileBlob.NativeFieldInfoPtr_MaxBlobCount, (void*) &value);
      }
    }
  }
}
