// Decompiled with JetBrains decompiler
// Type: ProjectM.UserConnectionChangedEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UserConnectionChangedEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UserEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConnectedUser;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    [FieldOffset(0)]
    public Entity UserEntity;
    [FieldOffset(8)]
    public ConnectedUser ConnectedUser;
    [FieldOffset(12)]
    public UserConnectionChangedType Type;

    static UserConnectionChangedEvent()
    {
      Il2CppClassPointerStore<UserConnectionChangedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (UserConnectionChangedEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserConnectionChangedEvent>.NativeClassPtr);
      UserConnectionChangedEvent.NativeFieldInfoPtr_UserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserConnectionChangedEvent>.NativeClassPtr, nameof (UserEntity));
      UserConnectionChangedEvent.NativeFieldInfoPtr_ConnectedUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserConnectionChangedEvent>.NativeClassPtr, nameof (ConnectedUser));
      UserConnectionChangedEvent.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserConnectionChangedEvent>.NativeClassPtr, nameof (Type));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserConnectionChangedEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
