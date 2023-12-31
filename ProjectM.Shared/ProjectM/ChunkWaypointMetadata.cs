// Decompiled with JetBrains decompiler
// Type: ProjectM.ChunkWaypointMetadata
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ChunkWaypointMetadata
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WaypointGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalChunkTRS;
    private static readonly System.IntPtr NativeFieldInfoPtr_TransformIndex;
    [FieldOffset(0)]
    public PrefabGUID WaypointGUID;
    [FieldOffset(4)]
    public float4x4 LocalChunkTRS;
    [FieldOffset(68)]
    public StaticTransformIndex TransformIndex;

    static ChunkWaypointMetadata()
    {
      Il2CppClassPointerStore<ChunkWaypointMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ChunkWaypointMetadata));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkWaypointMetadata>.NativeClassPtr);
      ChunkWaypointMetadata.NativeFieldInfoPtr_WaypointGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkWaypointMetadata>.NativeClassPtr, nameof (WaypointGUID));
      ChunkWaypointMetadata.NativeFieldInfoPtr_LocalChunkTRS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkWaypointMetadata>.NativeClassPtr, nameof (LocalChunkTRS));
      ChunkWaypointMetadata.NativeFieldInfoPtr_TransformIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkWaypointMetadata>.NativeClassPtr, nameof (TransformIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkWaypointMetadata>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
