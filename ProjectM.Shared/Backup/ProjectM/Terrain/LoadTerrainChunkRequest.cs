// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.LoadTerrainChunkRequest
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LoadTerrainChunkRequest
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SceneId;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubSceneGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    [FieldOffset(0)]
    public ChunkSceneId SceneId;
    [FieldOffset(8)]
    public SubSceneGUID SubSceneGUID;
    [FieldOffset(24)]
    public OrthogonalRotation Rotation;

    static LoadTerrainChunkRequest()
    {
      Il2CppClassPointerStore<LoadTerrainChunkRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (LoadTerrainChunkRequest));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadTerrainChunkRequest>.NativeClassPtr);
      LoadTerrainChunkRequest.NativeFieldInfoPtr_SceneId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadTerrainChunkRequest>.NativeClassPtr, nameof (SceneId));
      LoadTerrainChunkRequest.NativeFieldInfoPtr_SubSceneGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadTerrainChunkRequest>.NativeClassPtr, nameof (SubSceneGUID));
      LoadTerrainChunkRequest.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadTerrainChunkRequest>.NativeClassPtr, nameof (Rotation));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LoadTerrainChunkRequest>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
