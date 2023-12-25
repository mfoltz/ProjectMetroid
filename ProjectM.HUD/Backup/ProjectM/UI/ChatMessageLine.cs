// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ChatMessageLine
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using TMPro;

#nullable disable
namespace ProjectM.UI
{
  public class ChatMessageLine : UIEntry
  {
    private static readonly IntPtr NativeFieldInfoPtr_ChatLine;
    private static readonly IntPtr NativeFieldInfoPtr__ChatMessageType_k__BackingField;
    private static readonly IntPtr NativeFieldInfoPtr__User_k__BackingField;
    private static readonly IntPtr NativeFieldInfoPtr__LastText;
    private static readonly IntPtr NativeFieldInfoPtr__T;
    private static readonly IntPtr NativeMethodInfoPtr_get_ChatMessageType_Public_get_ServerChatMessageType_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_ChatMessageType_Private_set_Void_ServerChatMessageType_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_User_Public_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_User_Private_set_Void_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Boolean_String_ServerChatMessageType_MessageFromType_ChatColorsAsset_Single_String_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe ServerChatMessageType ChatMessageType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChatMessageLine.NativeMethodInfoPtr_get_ChatMessageType_Public_get_ServerChatMessageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ServerChatMessageType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChatMessageLine.NativeMethodInfoPtr_set_ChatMessageType_Private_set_Void_ServerChatMessageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe string User
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 22405, RefRangeEnd = 22406, XrefRangeStart = 22405, XrefRangeEnd = 22406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ChatMessageLine.NativeMethodInfoPtr_get_User_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 23672, RefRangeEnd = 23674, XrefRangeStart = 23672, XrefRangeEnd = 23674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChatMessageLine.NativeMethodInfoPtr_set_User_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1220084, RefRangeEnd = 1220085, XrefRangeStart = 1220069, XrefRangeEnd = 1220084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Set(
      string text,
      ServerChatMessageType messageType,
      MessageFromType fromType,
      ChatColorsAsset colors,
      float fontSize,
      string user,
      bool focused = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[7];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &messageType;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &fromType;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) colors);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &fontSize;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(user);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = (IntPtr) &focused;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChatMessageLine.NativeMethodInfoPtr_Set_Public_Boolean_String_ServerChatMessageType_MessageFromType_ChatColorsAsset_Single_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChatMessageLine()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatMessageLine>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChatMessageLine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChatMessageLine()
    {
      Il2CppClassPointerStore<ChatMessageLine>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ChatMessageLine));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatMessageLine>.NativeClassPtr);
      ChatMessageLine.NativeFieldInfoPtr_ChatLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageLine>.NativeClassPtr, nameof (ChatLine));
      ChatMessageLine.NativeFieldInfoPtr__ChatMessageType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageLine>.NativeClassPtr, "<ChatMessageType>k__BackingField");
      ChatMessageLine.NativeFieldInfoPtr__User_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageLine>.NativeClassPtr, "<User>k__BackingField");
      ChatMessageLine.NativeFieldInfoPtr__LastText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageLine>.NativeClassPtr, nameof (_LastText));
      ChatMessageLine.NativeFieldInfoPtr__T = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageLine>.NativeClassPtr, nameof (_T));
      ChatMessageLine.NativeMethodInfoPtr_get_ChatMessageType_Public_get_ServerChatMessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageLine>.NativeClassPtr, 100664582);
      ChatMessageLine.NativeMethodInfoPtr_set_ChatMessageType_Private_set_Void_ServerChatMessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageLine>.NativeClassPtr, 100664583);
      ChatMessageLine.NativeMethodInfoPtr_get_User_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageLine>.NativeClassPtr, 100664584);
      ChatMessageLine.NativeMethodInfoPtr_set_User_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageLine>.NativeClassPtr, 100664585);
      ChatMessageLine.NativeMethodInfoPtr_Set_Public_Boolean_String_ServerChatMessageType_MessageFromType_ChatColorsAsset_Single_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageLine>.NativeClassPtr, 100664586);
      ChatMessageLine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageLine>.NativeClassPtr, 100664587);
    }

    public ChatMessageLine(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TMP_Text ChatLine
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageLine.NativeFieldInfoPtr_ChatLine));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageLine.NativeFieldInfoPtr_ChatLine), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerChatMessageType _ChatMessageType_k__BackingField
    {
      get
      {
        return *(ServerChatMessageType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageLine.NativeFieldInfoPtr__ChatMessageType_k__BackingField));
      }
      [param: In] set
      {
        *(ServerChatMessageType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageLine.NativeFieldInfoPtr__ChatMessageType_k__BackingField)) = value;
      }
    }

    public unsafe string _User_k__BackingField
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageLine.NativeFieldInfoPtr__User_k__BackingField)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageLine.NativeFieldInfoPtr__User_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _LastText
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageLine.NativeFieldInfoPtr__LastText)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageLine.NativeFieldInfoPtr__LastText), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe float _T
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageLine.NativeFieldInfoPtr__T));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatMessageLine.NativeFieldInfoPtr__T)) = value;
      }
    }
  }
}
