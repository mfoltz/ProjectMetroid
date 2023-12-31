// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.PacketInfo
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PacketInfo
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ConfirmState;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyedCount;
    [FieldOffset(0)]
    public PacketConfirmState ConfirmState;
    [FieldOffset(1)]
    public byte UserIndex;
    [FieldOffset(2)]
    public byte EntityCount;
    [FieldOffset(3)]
    public byte DestroyedCount;

    static PacketInfo()
    {
      Il2CppClassPointerStore<PacketInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (PacketInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PacketInfo>.NativeClassPtr);
      PacketInfo.NativeFieldInfoPtr_ConfirmState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketInfo>.NativeClassPtr, nameof (ConfirmState));
      PacketInfo.NativeFieldInfoPtr_UserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketInfo>.NativeClassPtr, nameof (UserIndex));
      PacketInfo.NativeFieldInfoPtr_EntityCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketInfo>.NativeClassPtr, nameof (EntityCount));
      PacketInfo.NativeFieldInfoPtr_DestroyedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketInfo>.NativeClassPtr, nameof (DestroyedCount));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PacketInfo>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
