// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ChatEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public class ChatEntry : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Timestamp;
    private static readonly System.IntPtr NativeFieldInfoPtr_MessageType;
    private static readonly System.IntPtr NativeFieldInfoPtr_From;
    private static readonly System.IntPtr NativeFieldInfoPtr_FromType;
    private static readonly System.IntPtr NativeFieldInfoPtr_MessageText;
    private static readonly System.IntPtr NativeFieldInfoPtr_FullText;
    private static readonly System.IntPtr NativeFieldInfoPtr_User;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChatEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChatEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChatEntry()
    {
      Il2CppClassPointerStore<ChatEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ChatEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatEntry>.NativeClassPtr);
      ChatEntry.NativeFieldInfoPtr_Timestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatEntry>.NativeClassPtr, nameof (Timestamp));
      ChatEntry.NativeFieldInfoPtr_MessageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatEntry>.NativeClassPtr, nameof (MessageType));
      ChatEntry.NativeFieldInfoPtr_From = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatEntry>.NativeClassPtr, nameof (From));
      ChatEntry.NativeFieldInfoPtr_FromType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatEntry>.NativeClassPtr, nameof (FromType));
      ChatEntry.NativeFieldInfoPtr_MessageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatEntry>.NativeClassPtr, nameof (MessageText));
      ChatEntry.NativeFieldInfoPtr_FullText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatEntry>.NativeClassPtr, nameof (FullText));
      ChatEntry.NativeFieldInfoPtr_User = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatEntry>.NativeClassPtr, nameof (User));
      ChatEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatEntry>.NativeClassPtr, 100664597);
    }

    public ChatEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe long Timestamp
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatEntry.NativeFieldInfoPtr_Timestamp));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatEntry.NativeFieldInfoPtr_Timestamp)) = value;
      }
    }

    public unsafe ServerChatMessageType MessageType
    {
      get
      {
        return *(ServerChatMessageType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatEntry.NativeFieldInfoPtr_MessageType));
      }
      [param: In] set
      {
        *(ServerChatMessageType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatEntry.NativeFieldInfoPtr_MessageType)) = value;
      }
    }

    public unsafe NetworkId From
    {
      get
      {
        return *(NetworkId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatEntry.NativeFieldInfoPtr_From));
      }
      [param: In] set
      {
        *(NetworkId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatEntry.NativeFieldInfoPtr_From)) = value;
      }
    }

    public unsafe MessageFromType FromType
    {
      get
      {
        return *(MessageFromType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatEntry.NativeFieldInfoPtr_FromType));
      }
      [param: In] set
      {
        *(MessageFromType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatEntry.NativeFieldInfoPtr_FromType)) = value;
      }
    }

    public unsafe string MessageText
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatEntry.NativeFieldInfoPtr_MessageText)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChatEntry.NativeFieldInfoPtr_MessageText), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string FullText
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatEntry.NativeFieldInfoPtr_FullText)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChatEntry.NativeFieldInfoPtr_FullText), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string User
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatEntry.NativeFieldInfoPtr_User)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChatEntry.NativeFieldInfoPtr_User), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
