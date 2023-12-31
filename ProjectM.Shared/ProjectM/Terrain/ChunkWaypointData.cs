// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.ChunkWaypointData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ChunkWaypointData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WaypointEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_WaypointPosition;
    [FieldOffset(0)]
    public Entity WaypointEntity;
    [FieldOffset(8)]
    public float3 WaypointPosition;

    static ChunkWaypointData()
    {
      Il2CppClassPointerStore<ChunkWaypointData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (ChunkWaypointData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkWaypointData>.NativeClassPtr);
      ChunkWaypointData.NativeFieldInfoPtr_WaypointEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkWaypointData>.NativeClassPtr, nameof (WaypointEntity));
      ChunkWaypointData.NativeFieldInfoPtr_WaypointPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkWaypointData>.NativeClassPtr, nameof (WaypointPosition));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkWaypointData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
