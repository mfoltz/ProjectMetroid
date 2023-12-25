// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.StatusChangedEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct StatusChangedEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Status;
    [FieldOffset(0)]
    public ClientConnectState Status;

    static StatusChangedEvent()
    {
      Il2CppClassPointerStore<StatusChangedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (StatusChangedEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusChangedEvent>.NativeClassPtr);
      StatusChangedEvent.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusChangedEvent>.NativeClassPtr, nameof (Status));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatusChangedEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
