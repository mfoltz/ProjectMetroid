// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_RespawnPointOwnerBuffer
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_RespawnPointOwnerBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_IsLocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_RespawnPoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_RespawnPointNetworkId;
    [FieldOffset(0)]
    public bool IsLocked;
    [FieldOffset(4)]
    public NetworkId RespawnPoint;
    [FieldOffset(12)]
    public NetworkId RespawnPointNetworkId;

    static Snapshot_RespawnPointOwnerBuffer()
    {
      Il2CppClassPointerStore<Snapshot_RespawnPointOwnerBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_RespawnPointOwnerBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_RespawnPointOwnerBuffer>.NativeClassPtr);
      Snapshot_RespawnPointOwnerBuffer.NativeFieldInfoPtr_IsLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_RespawnPointOwnerBuffer>.NativeClassPtr, nameof (IsLocked));
      Snapshot_RespawnPointOwnerBuffer.NativeFieldInfoPtr_RespawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_RespawnPointOwnerBuffer>.NativeClassPtr, nameof (RespawnPoint));
      Snapshot_RespawnPointOwnerBuffer.NativeFieldInfoPtr_RespawnPointNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_RespawnPointOwnerBuffer>.NativeClassPtr, nameof (RespawnPointNetworkId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_RespawnPointOwnerBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
