// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.TerrainCoordinateSystemExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace ProjectM.Terrain
{
  public static class TerrainCoordinateSystemExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkWidth_Public_Static_UInt32_TerrainCoordinateSystem_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 768223, RefRangeEnd = 768224, XrefRangeStart = 768223, XrefRangeEnd = 768223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe uint GetChunkWidth(this TerrainCoordinateSystem coordinateSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &coordinateSystem;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainCoordinateSystemExtensions.NativeMethodInfoPtr_GetChunkWidth_Public_Static_UInt32_TerrainCoordinateSystem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TerrainCoordinateSystemExtensions()
    {
      Il2CppClassPointerStore<TerrainCoordinateSystemExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (TerrainCoordinateSystemExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainCoordinateSystemExtensions>.NativeClassPtr);
      TerrainCoordinateSystemExtensions.NativeMethodInfoPtr_GetChunkWidth_Public_Static_UInt32_TerrainCoordinateSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainCoordinateSystemExtensions>.NativeClassPtr, 100667961);
    }

    public TerrainCoordinateSystemExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
