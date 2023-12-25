// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.SendEventToUser
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SendEventToUser
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UserIndex;
    [FieldOffset(0)]
    public int UserIndex;

    static SendEventToUser()
    {
      Il2CppClassPointerStore<SendEventToUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (SendEventToUser));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendEventToUser>.NativeClassPtr);
      SendEventToUser.NativeFieldInfoPtr_UserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendEventToUser>.NativeClassPtr, nameof (UserIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SendEventToUser>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
