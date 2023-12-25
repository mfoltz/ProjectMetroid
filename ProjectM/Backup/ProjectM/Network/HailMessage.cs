// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.HailMessage
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HailMessage
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PositionBits;
    private static readonly System.IntPtr NativeFieldInfoPtr_LengthBits;
    [FieldOffset(0)]
    public int PositionBits;
    [FieldOffset(4)]
    public int LengthBits;

    static HailMessage()
    {
      Il2CppClassPointerStore<HailMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (HailMessage));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HailMessage>.NativeClassPtr);
      HailMessage.NativeFieldInfoPtr_PositionBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HailMessage>.NativeClassPtr, nameof (PositionBits));
      HailMessage.NativeFieldInfoPtr_LengthBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HailMessage>.NativeClassPtr, nameof (LengthBits));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HailMessage>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
