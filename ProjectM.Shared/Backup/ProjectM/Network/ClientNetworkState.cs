// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.ClientNetworkState
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ClientNetworkState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalUserIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalUserGeneration;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastServerFrameReceived;
    private static readonly System.IntPtr NativeFieldInfoPtr_BufferPositionBits;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastClientFrameReceivedPacket;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastClientUnscaledTimeReceivedPacket;
    [FieldOffset(0)]
    public int LocalUserIndex;
    [FieldOffset(4)]
    public int LocalUserGeneration;
    [FieldOffset(8)]
    public int LastServerFrameReceived;
    [FieldOffset(12)]
    public int BufferPositionBits;
    [FieldOffset(16)]
    public int LastClientFrameReceivedPacket;
    [FieldOffset(20)]
    public float LastClientUnscaledTimeReceivedPacket;

    static ClientNetworkState()
    {
      Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (ClientNetworkState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr);
      ClientNetworkState.NativeFieldInfoPtr_LocalUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, nameof (LocalUserIndex));
      ClientNetworkState.NativeFieldInfoPtr_LocalUserGeneration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, nameof (LocalUserGeneration));
      ClientNetworkState.NativeFieldInfoPtr_LastServerFrameReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, nameof (LastServerFrameReceived));
      ClientNetworkState.NativeFieldInfoPtr_BufferPositionBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, nameof (BufferPositionBits));
      ClientNetworkState.NativeFieldInfoPtr_LastClientFrameReceivedPacket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, nameof (LastClientFrameReceivedPacket));
      ClientNetworkState.NativeFieldInfoPtr_LastClientUnscaledTimeReceivedPacket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, nameof (LastClientUnscaledTimeReceivedPacket));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
