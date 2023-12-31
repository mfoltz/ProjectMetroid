// Decompiled with JetBrains decompiler
// Type: ProjectM.ClanInviteRequest_Shared
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ClanInviteRequest_Shared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanNetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanName;
    private static readonly System.IntPtr NativeFieldInfoPtr_FromUserName;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToUserName;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToUserIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FromUserIndex;
    [FieldOffset(0)]
    public NetworkId ClanNetworkId;
    [FieldOffset(8)]
    public FixedString64 ClanName;
    [FieldOffset(72)]
    public FixedString64 FromUserName;
    [FieldOffset(136)]
    public FixedString64 ToUserName;
    [FieldOffset(200)]
    public int ToUserIndex;
    [FieldOffset(204)]
    public int FromUserIndex;

    static ClanInviteRequest_Shared()
    {
      Il2CppClassPointerStore<ClanInviteRequest_Shared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ClanInviteRequest_Shared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanInviteRequest_Shared>.NativeClassPtr);
      ClanInviteRequest_Shared.NativeFieldInfoPtr_ClanNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInviteRequest_Shared>.NativeClassPtr, nameof (ClanNetworkId));
      ClanInviteRequest_Shared.NativeFieldInfoPtr_ClanName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInviteRequest_Shared>.NativeClassPtr, nameof (ClanName));
      ClanInviteRequest_Shared.NativeFieldInfoPtr_FromUserName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInviteRequest_Shared>.NativeClassPtr, nameof (FromUserName));
      ClanInviteRequest_Shared.NativeFieldInfoPtr_ToUserName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInviteRequest_Shared>.NativeClassPtr, nameof (ToUserName));
      ClanInviteRequest_Shared.NativeFieldInfoPtr_ToUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInviteRequest_Shared>.NativeClassPtr, nameof (ToUserIndex));
      ClanInviteRequest_Shared.NativeFieldInfoPtr_FromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInviteRequest_Shared>.NativeClassPtr, nameof (FromUserIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanInviteRequest_Shared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
