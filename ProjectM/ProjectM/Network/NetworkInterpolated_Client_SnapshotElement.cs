// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.NetworkInterpolated_Client_SnapshotElement
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
  public struct NetworkInterpolated_Client_SnapshotElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Time;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Velocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_MoveVelocity;
    [FieldOffset(0)]
    public double Time;
    [FieldOffset(8)]
    public float2 Position;
    [FieldOffset(16)]
    public quaternion Rotation;
    [FieldOffset(32)]
    public float2 Velocity;
    [FieldOffset(40)]
    public float MoveVelocity;

    static NetworkInterpolated_Client_SnapshotElement()
    {
      Il2CppClassPointerStore<NetworkInterpolated_Client_SnapshotElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (NetworkInterpolated_Client_SnapshotElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkInterpolated_Client_SnapshotElement>.NativeClassPtr);
      NetworkInterpolated_Client_SnapshotElement.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolated_Client_SnapshotElement>.NativeClassPtr, nameof (Time));
      NetworkInterpolated_Client_SnapshotElement.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolated_Client_SnapshotElement>.NativeClassPtr, nameof (Position));
      NetworkInterpolated_Client_SnapshotElement.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolated_Client_SnapshotElement>.NativeClassPtr, nameof (Rotation));
      NetworkInterpolated_Client_SnapshotElement.NativeFieldInfoPtr_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolated_Client_SnapshotElement>.NativeClassPtr, nameof (Velocity));
      NetworkInterpolated_Client_SnapshotElement.NativeFieldInfoPtr_MoveVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolated_Client_SnapshotElement>.NativeClassPtr, nameof (MoveVelocity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkInterpolated_Client_SnapshotElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
