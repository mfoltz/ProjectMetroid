// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.TerrainAuthoringUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

#nullable disable
namespace ProjectM.Terrain
{
  public static class TerrainAuthoringUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetChunkConfig_Public_Static_Boolean_GameObject_byref_ChunkSceneId_byref_OrthogonalRotation_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 767121, RefRangeEnd = 767122, XrefRangeStart = 767106, XrefRangeEnd = 767121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetChunkConfig(
      GameObject bakedTerrain,
      out ChunkSceneId chunkId,
      out OrthogonalRotation rotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bakedTerrain);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref chunkId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerrainAuthoringUtility.NativeMethodInfoPtr_TryGetChunkConfig_Public_Static_Boolean_GameObject_byref_ChunkSceneId_byref_OrthogonalRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TerrainAuthoringUtility()
    {
      Il2CppClassPointerStore<TerrainAuthoringUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (TerrainAuthoringUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainAuthoringUtility>.NativeClassPtr);
      TerrainAuthoringUtility.NativeMethodInfoPtr_TryGetChunkConfig_Public_Static_Boolean_GameObject_byref_ChunkSceneId_byref_OrthogonalRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainAuthoringUtility>.NativeClassPtr, 100667848);
    }

    public TerrainAuthoringUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
