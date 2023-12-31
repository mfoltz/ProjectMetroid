// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.ReceivedServerFrame
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ReceivedServerFrame
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LastServerFrameReceived;
    [FieldOffset(0)]
    public int LastServerFrameReceived;

    static ReceivedServerFrame()
    {
      Il2CppClassPointerStore<ReceivedServerFrame>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (ReceivedServerFrame));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivedServerFrame>.NativeClassPtr);
      ReceivedServerFrame.NativeFieldInfoPtr_LastServerFrameReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedServerFrame>.NativeClassPtr, nameof (LastServerFrameReceived));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReceivedServerFrame>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
