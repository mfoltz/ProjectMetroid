// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SocialMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class SocialMenu : HUDMenu
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SocialMenuMemberEntryData;
    private static readonly System.IntPtr NativeFieldInfoPtr_Speaking;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConnectedToVoiceChat;
    private static readonly System.IntPtr NativeFieldInfoPtr_NotConnectedToVoiceChat;
    private static readonly System.IntPtr NativeFieldInfoPtr_MuteChat;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnMuteChat;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConnectionStatus;
    private static readonly System.IntPtr NativeFieldInfoPtr_NotConnectedInfo;
    private static readonly System.IntPtr NativeFieldInfoPtr_NoVoipServerInfo;
    private static readonly System.IntPtr NativeFieldInfoPtr_Social_MemberEntryParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_Social_MemberEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr_Social_MemberEntryPrefab;
    private static readonly System.IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__13_0_Private_Void_SocialMenu_MemberEntry_Data_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232507, XrefRangeEnd = 1232522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SocialMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SocialMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocialMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SocialMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232522, XrefRangeEnd = 1232523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StunShared_UI_IInitializeableUI_InitializeUI_b__13_0(
      SocialMenu_MemberEntry entry,
      SocialMenu_MemberEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SocialMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__13_0_Private_Void_SocialMenu_MemberEntry_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SocialMenu()
    {
      Il2CppClassPointerStore<SocialMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (SocialMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocialMenu>.NativeClassPtr);
      SocialMenu.NativeFieldInfoPtr_SocialMenuMemberEntryData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu>.NativeClassPtr, nameof (SocialMenuMemberEntryData));
      SocialMenu.NativeFieldInfoPtr_Speaking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu>.NativeClassPtr, nameof (Speaking));
      SocialMenu.NativeFieldInfoPtr_ConnectedToVoiceChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu>.NativeClassPtr, nameof (ConnectedToVoiceChat));
      SocialMenu.NativeFieldInfoPtr_NotConnectedToVoiceChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu>.NativeClassPtr, nameof (NotConnectedToVoiceChat));
      SocialMenu.NativeFieldInfoPtr_MuteChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu>.NativeClassPtr, nameof (MuteChat));
      SocialMenu.NativeFieldInfoPtr_UnMuteChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu>.NativeClassPtr, nameof (UnMuteChat));
      SocialMenu.NativeFieldInfoPtr_ConnectionStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu>.NativeClassPtr, nameof (ConnectionStatus));
      SocialMenu.NativeFieldInfoPtr_NotConnectedInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu>.NativeClassPtr, nameof (NotConnectedInfo));
      SocialMenu.NativeFieldInfoPtr_NoVoipServerInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu>.NativeClassPtr, nameof (NoVoipServerInfo));
      SocialMenu.NativeFieldInfoPtr_Social_MemberEntryParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu>.NativeClassPtr, nameof (Social_MemberEntryParent));
      SocialMenu.NativeFieldInfoPtr_Social_MemberEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu>.NativeClassPtr, nameof (Social_MemberEntries));
      SocialMenu.NativeFieldInfoPtr_Social_MemberEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu>.NativeClassPtr, nameof (Social_MemberEntryPrefab));
      SocialMenu.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialMenu>.NativeClassPtr, 100665474);
      SocialMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialMenu>.NativeClassPtr, 100665475);
      SocialMenu.NativeMethodInfoPtr__StunShared_UI_IInitializeableUI_InitializeUI_b__13_0_Private_Void_SocialMenu_MemberEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialMenu>.NativeClassPtr, 100665476);
    }

    public SocialMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public SocialMenu.SocialMenuMemberData SocialMenuMemberEntryData
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_SocialMenuMemberEntryData);
        return new SocialMenu.SocialMenuMemberData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SocialMenu.SocialMenuMemberData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_SocialMenuMemberEntryData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SocialMenu.SocialMenuMemberData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe LocalizationKey Speaking
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_Speaking));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_Speaking)) = value;
      }
    }

    public unsafe LocalizationKey ConnectedToVoiceChat
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_ConnectedToVoiceChat));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_ConnectedToVoiceChat)) = value;
      }
    }

    public unsafe LocalizationKey NotConnectedToVoiceChat
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_NotConnectedToVoiceChat));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_NotConnectedToVoiceChat)) = value;
      }
    }

    public unsafe LocalizationKey MuteChat
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_MuteChat));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_MuteChat)) = value;
      }
    }

    public unsafe LocalizationKey UnMuteChat
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_UnMuteChat));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_UnMuteChat)) = value;
      }
    }

    public unsafe LocalizedText ConnectionStatus
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_ConnectionStatus));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_ConnectionStatus), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText NotConnectedInfo
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_NotConnectedInfo));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_NotConnectedInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText NoVoipServerInfo
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_NoVoipServerInfo));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_NoVoipServerInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup Social_MemberEntryParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_Social_MemberEntryParent));
        return pointer == System.IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_Social_MemberEntryParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridSelectionGroup<SocialMenu_MemberEntry, SocialMenu_MemberEntry.Data> Social_MemberEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_Social_MemberEntries));
        return pointer == System.IntPtr.Zero ? (GridSelectionGroup<SocialMenu_MemberEntry, SocialMenu_MemberEntry.Data>) null : new GridSelectionGroup<SocialMenu_MemberEntry, SocialMenu_MemberEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_Social_MemberEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SocialMenu_MemberEntry Social_MemberEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_Social_MemberEntryPrefab));
        return pointer == System.IntPtr.Zero ? (SocialMenu_MemberEntry) null : new SocialMenu_MemberEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.NativeFieldInfoPtr_Social_MemberEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public sealed class SocialMenuMemberData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntryPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntryParent;
      private static readonly System.IntPtr NativeFieldInfoPtr_MuteVoice;
      private static readonly System.IntPtr NativeFieldInfoPtr_UnMuteVoice;

      static SocialMenuMemberData()
      {
        Il2CppClassPointerStore<SocialMenu.SocialMenuMemberData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SocialMenu>.NativeClassPtr, nameof (SocialMenuMemberData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocialMenu.SocialMenuMemberData>.NativeClassPtr);
        SocialMenu.SocialMenuMemberData.NativeFieldInfoPtr_EntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu.SocialMenuMemberData>.NativeClassPtr, nameof (EntryPrefab));
        SocialMenu.SocialMenuMemberData.NativeFieldInfoPtr_EntryParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu.SocialMenuMemberData>.NativeClassPtr, nameof (EntryParent));
        SocialMenu.SocialMenuMemberData.NativeFieldInfoPtr_MuteVoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu.SocialMenuMemberData>.NativeClassPtr, nameof (MuteVoice));
        SocialMenu.SocialMenuMemberData.NativeFieldInfoPtr_UnMuteVoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialMenu.SocialMenuMemberData>.NativeClassPtr, nameof (UnMuteVoice));
      }

      public SocialMenuMemberData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SocialMenuMemberData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SocialMenu.SocialMenuMemberData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SocialMenu.SocialMenuMemberData>.NativeClassPtr, data));
      }

      public unsafe SocialMenu_MemberContextMenuEntry EntryPrefab
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.SocialMenuMemberData.NativeFieldInfoPtr_EntryPrefab));
          return pointer == System.IntPtr.Zero ? (SocialMenu_MemberContextMenuEntry) null : new SocialMenu_MemberContextMenuEntry(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.SocialMenuMemberData.NativeFieldInfoPtr_EntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SocialMenu_MemberContextMenu EntryParent
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.SocialMenuMemberData.NativeFieldInfoPtr_EntryParent));
          return pointer == System.IntPtr.Zero ? (SocialMenu_MemberContextMenu) null : new SocialMenu_MemberContextMenu(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.SocialMenuMemberData.NativeFieldInfoPtr_EntryParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe LocalizationKey MuteVoice
      {
        get
        {
          return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.SocialMenuMemberData.NativeFieldInfoPtr_MuteVoice));
        }
        [param: In] set
        {
          *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.SocialMenuMemberData.NativeFieldInfoPtr_MuteVoice)) = value;
        }
      }

      public unsafe LocalizationKey UnMuteVoice
      {
        get
        {
          return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.SocialMenuMemberData.NativeFieldInfoPtr_UnMuteVoice));
        }
        [param: In] set
        {
          *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocialMenu.SocialMenuMemberData.NativeFieldInfoPtr_UnMuteVoice)) = value;
        }
      }
    }
  }
}
