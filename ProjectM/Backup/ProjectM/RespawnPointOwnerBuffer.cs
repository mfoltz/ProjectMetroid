// Decompiled with JetBrains decompiler
// Type: ProjectM.RespawnPointOwnerBuffer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Network;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RespawnPointOwnerBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RespawnPoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_RespawnPointNetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsLocked;
    [FieldOffset(0)]
    public NetworkedEntity RespawnPoint;
    [FieldOffset(12)]
    public NetworkId RespawnPointNetworkId;
    [FieldOffset(20)]
    public bool IsLocked;

    static RespawnPointOwnerBuffer()
    {
      Il2CppClassPointerStore<RespawnPointOwnerBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RespawnPointOwnerBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RespawnPointOwnerBuffer>.NativeClassPtr);
      RespawnPointOwnerBuffer.NativeFieldInfoPtr_RespawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnPointOwnerBuffer>.NativeClassPtr, nameof (RespawnPoint));
      RespawnPointOwnerBuffer.NativeFieldInfoPtr_RespawnPointNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnPointOwnerBuffer>.NativeClassPtr, nameof (RespawnPointNetworkId));
      RespawnPointOwnerBuffer.NativeFieldInfoPtr_IsLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RespawnPointOwnerBuffer>.NativeClassPtr, nameof (IsLocked));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RespawnPointOwnerBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
