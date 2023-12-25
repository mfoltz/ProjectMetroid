// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.LobbyModificationSetInvitesAllowedOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LobbyModificationSetInvitesAllowedOptions
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__InvitesAllowed_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_InvitesAllowed_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_InvitesAllowed_Public_set_Void_Boolean_0;
    [FieldOffset(0)]
    public bool _InvitesAllowed_k__BackingField;

    public unsafe bool InvitesAllowed
    {
      [CallerCount(83), CachedScanResults(RefRangeStart = 438794, RefRangeEnd = 438877, XrefRangeStart = 438794, XrefRangeEnd = 438877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyModificationSetInvitesAllowedOptions.NativeMethodInfoPtr_get_InvitesAllowed_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 246533, RefRangeEnd = 246534, XrefRangeStart = 246533, XrefRangeEnd = 246534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LobbyModificationSetInvitesAllowedOptions.NativeMethodInfoPtr_set_InvitesAllowed_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static LobbyModificationSetInvitesAllowedOptions()
    {
      Il2CppClassPointerStore<LobbyModificationSetInvitesAllowedOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Lobby", nameof (LobbyModificationSetInvitesAllowedOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyModificationSetInvitesAllowedOptions>.NativeClassPtr);
      LobbyModificationSetInvitesAllowedOptions.NativeFieldInfoPtr__InvitesAllowed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModificationSetInvitesAllowedOptions>.NativeClassPtr, "<InvitesAllowed>k__BackingField");
      LobbyModificationSetInvitesAllowedOptions.NativeMethodInfoPtr_get_InvitesAllowed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModificationSetInvitesAllowedOptions>.NativeClassPtr, 100670345);
      LobbyModificationSetInvitesAllowedOptions.NativeMethodInfoPtr_set_InvitesAllowed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModificationSetInvitesAllowedOptions>.NativeClassPtr, 100670346);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyModificationSetInvitesAllowedOptions>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
