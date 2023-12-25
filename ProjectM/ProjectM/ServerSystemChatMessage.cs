// Decompiled with JetBrains decompiler
// Type: ProjectM.ServerSystemChatMessage
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ServerSystemChatMessage
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ToUser;
    private static readonly System.IntPtr NativeFieldInfoPtr_MessageText;
    [FieldOffset(0)]
    public User ToUser;
    [FieldOffset(152)]
    public FixedString512 MessageText;

    static ServerSystemChatMessage()
    {
      Il2CppClassPointerStore<ServerSystemChatMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ServerSystemChatMessage));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerSystemChatMessage>.NativeClassPtr);
      ServerSystemChatMessage.NativeFieldInfoPtr_ToUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSystemChatMessage>.NativeClassPtr, nameof (ToUser));
      ServerSystemChatMessage.NativeFieldInfoPtr_MessageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSystemChatMessage>.NativeClassPtr, nameof (MessageText));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerSystemChatMessage>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
