// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SortChatMessages
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Network;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SortChatMessages
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_ChatMessageServerEvent_ChatMessageServerEvent_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220127, XrefRangeEnd = 1220128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe int Compare(ChatMessageServerEvent x, ChatMessageServerEvent y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SortChatMessages.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_ChatMessageServerEvent_ChatMessageServerEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SortChatMessages()
    {
      Il2CppClassPointerStore<SortChatMessages>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (SortChatMessages));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortChatMessages>.NativeClassPtr);
      SortChatMessages.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_ChatMessageServerEvent_ChatMessageServerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortChatMessages>.NativeClassPtr, 100664596);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SortChatMessages>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
