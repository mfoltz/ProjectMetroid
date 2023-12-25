// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ChatHelper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  public static class ChatHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ToggleChat_Public_Static_Void_World_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToggleChat_Public_Static_Void_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToggleChat_Public_Static_Void_World_NetworkId_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221092, XrefRangeEnd = 1221105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ToggleChat(World clientWorld, Entity whisperUser)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &whisperUser;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChatHelper.NativeMethodInfoPtr_ToggleChat_Public_Static_Void_World_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1221114, RefRangeEnd = 1221115, XrefRangeStart = 1221105, XrefRangeEnd = 1221114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ToggleChat(World clientWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChatHelper.NativeMethodInfoPtr_ToggleChat_Public_Static_Void_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221115, XrefRangeEnd = 1221120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ToggleChat(World clientWorld, NetworkId whisperUser)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientWorld);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &whisperUser;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChatHelper.NativeMethodInfoPtr_ToggleChat_Public_Static_Void_World_NetworkId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChatHelper()
    {
      Il2CppClassPointerStore<ChatHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ChatHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatHelper>.NativeClassPtr);
      ChatHelper.NativeMethodInfoPtr_ToggleChat_Public_Static_Void_World_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatHelper>.NativeClassPtr, 100664649);
      ChatHelper.NativeMethodInfoPtr_ToggleChat_Public_Static_Void_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatHelper>.NativeClassPtr, 100664650);
      ChatHelper.NativeMethodInfoPtr_ToggleChat_Public_Static_Void_World_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatHelper>.NativeClassPtr, 100664651);
    }

    public ChatHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
