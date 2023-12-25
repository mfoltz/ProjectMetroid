// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.NetworkInterpolated_Shared
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct NetworkInterpolated_Shared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LastClientCommandTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_NextSimulationSyncTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_NextSendTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Movement;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerMoveVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Simulate;
    private static readonly System.IntPtr NativeFieldInfoPtr_WasSpellControlled;
    [FieldOffset(0)]
    public double LastClientCommandTime;
    [FieldOffset(8)]
    public double NextSimulationSyncTime;
    [FieldOffset(16)]
    public double NextSendTime;
    [FieldOffset(24)]
    public quaternion ServerRotation;
    [FieldOffset(40)]
    public float2 ServerPosition;
    [FieldOffset(48)]
    public float2 ServerVelocity;
    [FieldOffset(56)]
    public float2 Movement;
    [FieldOffset(64)]
    public float ServerMoveVelocity;
    [FieldOffset(68)]
    public bool Simulate;
    [FieldOffset(69)]
    public bool WasSpellControlled;

    static NetworkInterpolated_Shared()
    {
      Il2CppClassPointerStore<NetworkInterpolated_Shared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (NetworkInterpolated_Shared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkInterpolated_Shared>.NativeClassPtr);
      NetworkInterpolated_Shared.NativeFieldInfoPtr_LastClientCommandTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolated_Shared>.NativeClassPtr, nameof (LastClientCommandTime));
      NetworkInterpolated_Shared.NativeFieldInfoPtr_NextSimulationSyncTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolated_Shared>.NativeClassPtr, nameof (NextSimulationSyncTime));
      NetworkInterpolated_Shared.NativeFieldInfoPtr_NextSendTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolated_Shared>.NativeClassPtr, nameof (NextSendTime));
      NetworkInterpolated_Shared.NativeFieldInfoPtr_ServerRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolated_Shared>.NativeClassPtr, nameof (ServerRotation));
      NetworkInterpolated_Shared.NativeFieldInfoPtr_ServerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolated_Shared>.NativeClassPtr, nameof (ServerPosition));
      NetworkInterpolated_Shared.NativeFieldInfoPtr_ServerVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolated_Shared>.NativeClassPtr, nameof (ServerVelocity));
      NetworkInterpolated_Shared.NativeFieldInfoPtr_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolated_Shared>.NativeClassPtr, nameof (Movement));
      NetworkInterpolated_Shared.NativeFieldInfoPtr_ServerMoveVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolated_Shared>.NativeClassPtr, nameof (ServerMoveVelocity));
      NetworkInterpolated_Shared.NativeFieldInfoPtr_Simulate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolated_Shared>.NativeClassPtr, nameof (Simulate));
      NetworkInterpolated_Shared.NativeFieldInfoPtr_WasSpellControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolated_Shared>.NativeClassPtr, nameof (WasSpellControlled));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkInterpolated_Shared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
