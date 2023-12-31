// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.NetherSpawnPositionData
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
  public struct NetherSpawnPositionData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnPositionEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnRotation;
    [FieldOffset(0)]
    public Entity SpawnPositionEntity;
    [FieldOffset(8)]
    public float3 SpawnPosition;
    [FieldOffset(20)]
    public quaternion SpawnRotation;

    static NetherSpawnPositionData()
    {
      Il2CppClassPointerStore<NetherSpawnPositionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (NetherSpawnPositionData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetherSpawnPositionData>.NativeClassPtr);
      NetherSpawnPositionData.NativeFieldInfoPtr_SpawnPositionEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetherSpawnPositionData>.NativeClassPtr, nameof (SpawnPositionEntity));
      NetherSpawnPositionData.NativeFieldInfoPtr_SpawnPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetherSpawnPositionData>.NativeClassPtr, nameof (SpawnPosition));
      NetherSpawnPositionData.NativeFieldInfoPtr_SpawnRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetherSpawnPositionData>.NativeClassPtr, nameof (SpawnRotation));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetherSpawnPositionData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
