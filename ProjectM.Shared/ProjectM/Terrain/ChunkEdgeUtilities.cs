// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.ChunkEdgeUtilities
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace ProjectM.Terrain
{
  public static class ChunkEdgeUtilities : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_RotateChunkEdgeToWorldSpace_Public_Static_ChunkEdge_OrthogonalRotation_ChunkEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RotateWorldEdgeToChunkSpace_Public_Static_ChunkEdge_OrthogonalRotation_ChunkEdge_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 765995, RefRangeEnd = 765996, XrefRangeStart = 765992, XrefRangeEnd = 765995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ChunkEdge RotateChunkEdgeToWorldSpace(
      OrthogonalRotation chunkRotation,
      ChunkEdge chunkSpaceEdge)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &chunkRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkSpaceEdge;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkEdgeUtilities.NativeMethodInfoPtr_RotateChunkEdgeToWorldSpace_Public_Static_ChunkEdge_OrthogonalRotation_ChunkEdge_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ChunkEdge*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765996, XrefRangeEnd = 765999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ChunkEdge RotateWorldEdgeToChunkSpace(
      OrthogonalRotation chunkRotation,
      ChunkEdge worldSpaceEdge)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &chunkRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &worldSpaceEdge;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkEdgeUtilities.NativeMethodInfoPtr_RotateWorldEdgeToChunkSpace_Public_Static_ChunkEdge_OrthogonalRotation_ChunkEdge_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ChunkEdge*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ChunkEdgeUtilities()
    {
      Il2CppClassPointerStore<ChunkEdgeUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (ChunkEdgeUtilities));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkEdgeUtilities>.NativeClassPtr);
      ChunkEdgeUtilities.NativeMethodInfoPtr_RotateChunkEdgeToWorldSpace_Public_Static_ChunkEdge_OrthogonalRotation_ChunkEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkEdgeUtilities>.NativeClassPtr, 100667706);
      ChunkEdgeUtilities.NativeMethodInfoPtr_RotateWorldEdgeToChunkSpace_Public_Static_ChunkEdge_OrthogonalRotation_ChunkEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkEdgeUtilities>.NativeClassPtr, 100667707);
    }

    public ChunkEdgeUtilities(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
