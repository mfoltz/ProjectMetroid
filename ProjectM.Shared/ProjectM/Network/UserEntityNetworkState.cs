// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.UserEntityNetworkState
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UserEntityNetworkState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NextSendTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Generation;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastAckedServerFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastFrameSent;
    private static readonly System.IntPtr NativeFieldInfoPtr_NumOfTimesSyncedSinceReset;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasBeenSentEntity;
    [FieldOffset(0)]
    public double NextSendTime;
    [FieldOffset(8)]
    public int Generation;
    [FieldOffset(12)]
    public int LastAckedServerFrame;
    [FieldOffset(16)]
    public int LastFrameSent;
    [FieldOffset(20)]
    public byte NumOfTimesSyncedSinceReset;
    [FieldOffset(21)]
    public bool HasBeenSentEntity;

    static UserEntityNetworkState()
    {
      Il2CppClassPointerStore<UserEntityNetworkState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (UserEntityNetworkState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserEntityNetworkState>.NativeClassPtr);
      UserEntityNetworkState.NativeFieldInfoPtr_NextSendTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserEntityNetworkState>.NativeClassPtr, nameof (NextSendTime));
      UserEntityNetworkState.NativeFieldInfoPtr_Generation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserEntityNetworkState>.NativeClassPtr, nameof (Generation));
      UserEntityNetworkState.NativeFieldInfoPtr_LastAckedServerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserEntityNetworkState>.NativeClassPtr, nameof (LastAckedServerFrame));
      UserEntityNetworkState.NativeFieldInfoPtr_LastFrameSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserEntityNetworkState>.NativeClassPtr, nameof (LastFrameSent));
      UserEntityNetworkState.NativeFieldInfoPtr_NumOfTimesSyncedSinceReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserEntityNetworkState>.NativeClassPtr, nameof (NumOfTimesSyncedSinceReset));
      UserEntityNetworkState.NativeFieldInfoPtr_HasBeenSentEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserEntityNetworkState>.NativeClassPtr, nameof (HasBeenSentEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserEntityNetworkState>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
