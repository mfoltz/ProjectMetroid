// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.NetworkedSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct NetworkedSettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BasePriority;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncRate;
    [FieldOffset(0)]
    public float BasePriority;
    [FieldOffset(4)]
    public float SyncRate;

    static NetworkedSettings()
    {
      Il2CppClassPointerStore<NetworkedSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (NetworkedSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkedSettings>.NativeClassPtr);
      NetworkedSettings.NativeFieldInfoPtr_BasePriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedSettings>.NativeClassPtr, nameof (BasePriority));
      NetworkedSettings.NativeFieldInfoPtr_SyncRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedSettings>.NativeClassPtr, nameof (SyncRate));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkedSettings>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
