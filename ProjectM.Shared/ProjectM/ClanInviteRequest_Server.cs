// Decompiled with JetBrains decompiler
// Type: ProjectM.ClanInviteRequest_Server
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ClanInviteRequest_Server
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToUser;
    private static readonly System.IntPtr NativeFieldInfoPtr_FromUser;
    [FieldOffset(0)]
    public Entity ClanEntity;
    [FieldOffset(8)]
    public Entity ToUser;
    [FieldOffset(16)]
    public Entity FromUser;

    static ClanInviteRequest_Server()
    {
      Il2CppClassPointerStore<ClanInviteRequest_Server>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ClanInviteRequest_Server));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanInviteRequest_Server>.NativeClassPtr);
      ClanInviteRequest_Server.NativeFieldInfoPtr_ClanEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInviteRequest_Server>.NativeClassPtr, nameof (ClanEntity));
      ClanInviteRequest_Server.NativeFieldInfoPtr_ToUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInviteRequest_Server>.NativeClassPtr, nameof (ToUser));
      ClanInviteRequest_Server.NativeFieldInfoPtr_FromUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInviteRequest_Server>.NativeClassPtr, nameof (FromUser));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanInviteRequest_Server>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
