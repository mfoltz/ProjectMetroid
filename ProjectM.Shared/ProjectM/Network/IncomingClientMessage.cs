// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.IncomingClientMessage
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct IncomingClientMessage
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BufferLengthBits;
    private static readonly System.IntPtr NativeFieldInfoPtr_BufferPosition;
    [FieldOffset(0)]
    public ushort BufferLengthBits;
    [FieldOffset(2)]
    public ushort BufferPosition;

    static IncomingClientMessage()
    {
      Il2CppClassPointerStore<IncomingClientMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (IncomingClientMessage));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomingClientMessage>.NativeClassPtr);
      IncomingClientMessage.NativeFieldInfoPtr_BufferLengthBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomingClientMessage>.NativeClassPtr, nameof (BufferLengthBits));
      IncomingClientMessage.NativeFieldInfoPtr_BufferPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomingClientMessage>.NativeClassPtr, nameof (BufferPosition));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IncomingClientMessage>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
