// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.NetworkedTimeout
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct NetworkedTimeout
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LastTimeSynced;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeoutAfter;
    private static readonly System.IntPtr NativeFieldInfoPtr_Enabled;
    [FieldOffset(0)]
    public double LastTimeSynced;
    [FieldOffset(8)]
    public float TimeoutAfter;
    [FieldOffset(12)]
    public bool Enabled;

    static NetworkedTimeout()
    {
      Il2CppClassPointerStore<NetworkedTimeout>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (NetworkedTimeout));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkedTimeout>.NativeClassPtr);
      NetworkedTimeout.NativeFieldInfoPtr_LastTimeSynced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedTimeout>.NativeClassPtr, nameof (LastTimeSynced));
      NetworkedTimeout.NativeFieldInfoPtr_TimeoutAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedTimeout>.NativeClassPtr, nameof (TimeoutAfter));
      NetworkedTimeout.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedTimeout>.NativeClassPtr, nameof (Enabled));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkedTimeout>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
