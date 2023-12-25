// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.ReceivedPacket
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ReceivedPacket
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_LengthBits;
    private static readonly System.IntPtr NativeFieldInfoPtr_Skip;
    [FieldOffset(0)]
    public int Position;
    [FieldOffset(4)]
    public int LengthBits;
    [FieldOffset(8)]
    public bool Skip;

    static ReceivedPacket()
    {
      Il2CppClassPointerStore<ReceivedPacket>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (ReceivedPacket));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivedPacket>.NativeClassPtr);
      ReceivedPacket.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedPacket>.NativeClassPtr, nameof (Position));
      ReceivedPacket.NativeFieldInfoPtr_LengthBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedPacket>.NativeClassPtr, nameof (LengthBits));
      ReceivedPacket.NativeFieldInfoPtr_Skip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedPacket>.NativeClassPtr, nameof (Skip));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReceivedPacket>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
