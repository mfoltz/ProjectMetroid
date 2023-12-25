// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.NetworkInterpolated_Client
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
  public struct NetworkInterpolated_Client
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviousLastCommandTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotBufferIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_WasSimulating;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsExtrapolating;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewDataReceived;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellControl_ServerStartPos;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellControl_ClientStartPos;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellControl_TimeSinceStart;
    [FieldOffset(0)]
    public double PreviousLastCommandTime;
    [FieldOffset(8)]
    public int SnapshotBufferIndex;
    [FieldOffset(12)]
    public bool WasSimulating;
    [FieldOffset(13)]
    public bool IsExtrapolating;
    [FieldOffset(14)]
    public bool NewDataReceived;
    [FieldOffset(16)]
    public float2 SpellControl_ServerStartPos;
    [FieldOffset(24)]
    public float2 SpellControl_ClientStartPos;
    [FieldOffset(32)]
    public float SpellControl_TimeSinceStart;

    static NetworkInterpolated_Client()
    {
      Il2CppClassPointerStore<NetworkInterpolated_Client>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (NetworkInterpolated_Client));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkInterpolated_Client>.NativeClassPtr);
      NetworkInterpolated_Client.NativeFieldInfoPtr_PreviousLastCommandTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolated_Client>.NativeClassPtr, nameof (PreviousLastCommandTime));
      NetworkInterpolated_Client.NativeFieldInfoPtr_SnapshotBufferIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolated_Client>.NativeClassPtr, nameof (SnapshotBufferIndex));
      NetworkInterpolated_Client.NativeFieldInfoPtr_WasSimulating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolated_Client>.NativeClassPtr, nameof (WasSimulating));
      NetworkInterpolated_Client.NativeFieldInfoPtr_IsExtrapolating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolated_Client>.NativeClassPtr, nameof (IsExtrapolating));
      NetworkInterpolated_Client.NativeFieldInfoPtr_NewDataReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolated_Client>.NativeClassPtr, nameof (NewDataReceived));
      NetworkInterpolated_Client.NativeFieldInfoPtr_SpellControl_ServerStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolated_Client>.NativeClassPtr, nameof (SpellControl_ServerStartPos));
      NetworkInterpolated_Client.NativeFieldInfoPtr_SpellControl_ClientStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolated_Client>.NativeClassPtr, nameof (SpellControl_ClientStartPos));
      NetworkInterpolated_Client.NativeFieldInfoPtr_SpellControl_TimeSinceStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkInterpolated_Client>.NativeClassPtr, nameof (SpellControl_TimeSinceStart));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkInterpolated_Client>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
