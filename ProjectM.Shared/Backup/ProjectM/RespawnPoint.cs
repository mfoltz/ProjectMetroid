// Decompiled with JetBrains decompiler
// Type: ProjectM.RespawnPoint
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
  public struct RespawnPoint
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnExitOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnDelayBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnSleepingBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_RespawnPointType;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasRespawnPointOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_RespawnPointOwner;
    [FieldOffset(0)]
    public float3 SpawnExitOffset;
    [FieldOffset(12)]
    public PrefabGUID SpawnDelayBuff;
    [FieldOffset(16)]
    public PrefabGUID SpawnSleepingBuff;
    [FieldOffset(20)]
    public RespawnPointType RespawnPointType;
    [FieldOffset(21)]
    public bool HasRespawnPointOwner;
    [FieldOffset(24)]
    public NetworkedEntity RespawnPointOwner;

    static RespawnPoint()
    {
      Il2CppClassPointerStore<RespawnPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RespawnPoint));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RespawnPoint>.NativeClassPtr);
      RespawnPoint.NativeFieldInfoPtr_SpawnExitOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnPoint>.NativeClassPtr, nameof (SpawnExitOffset));
      RespawnPoint.NativeFieldInfoPtr_SpawnDelayBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnPoint>.NativeClassPtr, nameof (SpawnDelayBuff));
      RespawnPoint.NativeFieldInfoPtr_SpawnSleepingBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnPoint>.NativeClassPtr, nameof (SpawnSleepingBuff));
      RespawnPoint.NativeFieldInfoPtr_RespawnPointType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnPoint>.NativeClassPtr, nameof (RespawnPointType));
      RespawnPoint.NativeFieldInfoPtr_HasRespawnPointOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnPoint>.NativeClassPtr, nameof (HasRespawnPointOwner));
      RespawnPoint.NativeFieldInfoPtr_RespawnPointOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnPoint>.NativeClassPtr, nameof (RespawnPointOwner));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RespawnPoint>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
