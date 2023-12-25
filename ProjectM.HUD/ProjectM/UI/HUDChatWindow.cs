// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.HUDChatWindow
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using TMPro;
using Unity.Entities;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class HUDChatWindow : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ContentCanvasGroup;
    private static readonly IntPtr NativeFieldInfoPtr_TextNode;
    private static readonly IntPtr NativeFieldInfoPtr_ChatMessagePrefab;
    private static readonly IntPtr NativeFieldInfoPtr_ChatInputField;
    private static readonly IntPtr NativeFieldInfoPtr_ScrollViewGraphic;
    private static readonly IntPtr NativeFieldInfoPtr_ScrollViewportGraphic;
    private static readonly IntPtr NativeFieldInfoPtr_PlaceholderText;
    private static readonly IntPtr NativeFieldInfoPtr_GlobalModeKey;
    private static readonly IntPtr NativeFieldInfoPtr_AlliesModeKey;
    private static readonly IntPtr NativeFieldInfoPtr_WhisperModeKey;
    private static readonly IntPtr NativeFieldInfoPtr_LocalModeKey;
    private static readonly IntPtr NativeFieldInfoPtr_SystemModeKey;
    private static readonly IntPtr NativeFieldInfoPtr_GlobalKey;
    private static readonly IntPtr NativeFieldInfoPtr_AlliesKey;
    private static readonly IntPtr NativeFieldInfoPtr_WhisperKey;
    private static readonly IntPtr NativeFieldInfoPtr_LocalKey;
    private static readonly IntPtr NativeFieldInfoPtr_SystemKey;
    private static readonly IntPtr NativeFieldInfoPtr_NoSuchCommandExists;
    private static readonly IntPtr NativeFieldInfoPtr_NoVampireWithThatNameFound;
    private static readonly IntPtr NativeFieldInfoPtr_YouAreNotInAClan;
    private static readonly IntPtr NativeFieldInfoPtr_ToWhisperKey;
    private static readonly IntPtr NativeFieldInfoPtr_FromWhisperKey;
    private static readonly IntPtr NativeFieldInfoPtr_KillCommandWarning;
    private static readonly IntPtr NativeFieldInfoPtr_NoteToSelf;
    private static readonly IntPtr NativeFieldInfoPtr_NoRecentWhispers;
    private static readonly IntPtr NativeFieldInfoPtr_ScrollView;
    private static readonly IntPtr NativeFieldInfoPtr_Colors;
    private static readonly IntPtr NativeFieldInfoPtr__ChatLines;
    private static readonly IntPtr NativeMethodInfoPtr_get_ChatLines_Public_get_UI_Cache_1_ChatMessageLine_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ClearInputText_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_FocusInputField_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetPlaceholderMode_Public_Void_ChatMessageType_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_MessageTypeString_Public_String_ServerChatMessageType_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe UI_Cache<ChatMessageLine> ChatLines
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(HUDChatWindow.NativeMethodInfoPtr_get_ChatLines_Public_get_UI_Cache_1_ChatMessageLine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (UI_Cache<ChatMessageLine>) null : new UI_Cache<ChatMessageLine>(pointer);
      }
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDChatWindow.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1220092, RefRangeEnd = 1220093, XrefRangeStart = 1220085, XrefRangeEnd = 1220092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDChatWindow.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1220097, RefRangeEnd = 1220099, XrefRangeStart = 1220093, XrefRangeEnd = 1220097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearInputText()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDChatWindow.NativeMethodInfoPtr_ClearInputText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220099, XrefRangeEnd = 1220101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FocusInputField()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDChatWindow.NativeMethodInfoPtr_FocusInputField_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1220113, RefRangeEnd = 1220114, XrefRangeStart = 1220101, XrefRangeEnd = 1220113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetPlaceholderMode(ChatMessageType type, string whisperUserName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &type;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(whisperUserName);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDChatWindow.NativeMethodInfoPtr_SetPlaceholderMode_Public_Void_ChatMessageType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1220126, RefRangeEnd = 1220127, XrefRangeStart = 1220114, XrefRangeEnd = 1220126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string MessageTypeString(ServerChatMessageType messageType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &messageType;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(HUDChatWindow.NativeMethodInfoPtr_MessageTypeString_Public_String_ServerChatMessageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HUDChatWindow()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDChatWindow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HUDChatWindow()
    {
      Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (HUDChatWindow));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr);
      HUDChatWindow.NativeFieldInfoPtr_ContentCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (ContentCanvasGroup));
      HUDChatWindow.NativeFieldInfoPtr_TextNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (TextNode));
      HUDChatWindow.NativeFieldInfoPtr_ChatMessagePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (ChatMessagePrefab));
      HUDChatWindow.NativeFieldInfoPtr_ChatInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (ChatInputField));
      HUDChatWindow.NativeFieldInfoPtr_ScrollViewGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (ScrollViewGraphic));
      HUDChatWindow.NativeFieldInfoPtr_ScrollViewportGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (ScrollViewportGraphic));
      HUDChatWindow.NativeFieldInfoPtr_PlaceholderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (PlaceholderText));
      HUDChatWindow.NativeFieldInfoPtr_GlobalModeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (GlobalModeKey));
      HUDChatWindow.NativeFieldInfoPtr_AlliesModeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (AlliesModeKey));
      HUDChatWindow.NativeFieldInfoPtr_WhisperModeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (WhisperModeKey));
      HUDChatWindow.NativeFieldInfoPtr_LocalModeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (LocalModeKey));
      HUDChatWindow.NativeFieldInfoPtr_SystemModeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (SystemModeKey));
      HUDChatWindow.NativeFieldInfoPtr_GlobalKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (GlobalKey));
      HUDChatWindow.NativeFieldInfoPtr_AlliesKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (AlliesKey));
      HUDChatWindow.NativeFieldInfoPtr_WhisperKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (WhisperKey));
      HUDChatWindow.NativeFieldInfoPtr_LocalKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (LocalKey));
      HUDChatWindow.NativeFieldInfoPtr_SystemKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (SystemKey));
      HUDChatWindow.NativeFieldInfoPtr_NoSuchCommandExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (NoSuchCommandExists));
      HUDChatWindow.NativeFieldInfoPtr_NoVampireWithThatNameFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (NoVampireWithThatNameFound));
      HUDChatWindow.NativeFieldInfoPtr_YouAreNotInAClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (YouAreNotInAClan));
      HUDChatWindow.NativeFieldInfoPtr_ToWhisperKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (ToWhisperKey));
      HUDChatWindow.NativeFieldInfoPtr_FromWhisperKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (FromWhisperKey));
      HUDChatWindow.NativeFieldInfoPtr_KillCommandWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (KillCommandWarning));
      HUDChatWindow.NativeFieldInfoPtr_NoteToSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (NoteToSelf));
      HUDChatWindow.NativeFieldInfoPtr_NoRecentWhispers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (NoRecentWhispers));
      HUDChatWindow.NativeFieldInfoPtr_ScrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (ScrollView));
      HUDChatWindow.NativeFieldInfoPtr_Colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (Colors));
      HUDChatWindow.NativeFieldInfoPtr__ChatLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, nameof (_ChatLines));
      HUDChatWindow.NativeMethodInfoPtr_get_ChatLines_Public_get_UI_Cache_1_ChatMessageLine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, 100664588);
      HUDChatWindow.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, 100664589);
      HUDChatWindow.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, 100664590);
      HUDChatWindow.NativeMethodInfoPtr_ClearInputText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, 100664591);
      HUDChatWindow.NativeMethodInfoPtr_FocusInputField_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, 100664592);
      HUDChatWindow.NativeMethodInfoPtr_SetPlaceholderMode_Public_Void_ChatMessageType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, 100664593);
      HUDChatWindow.NativeMethodInfoPtr_MessageTypeString_Public_String_ServerChatMessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, 100664594);
      HUDChatWindow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDChatWindow>.NativeClassPtr, 100664595);
    }

    public HUDChatWindow(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CanvasGroup ContentCanvasGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_ContentCanvasGroup));
        return pointer == IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_ContentCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform TextNode
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_TextNode));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_TextNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ChatMessageLine ChatMessagePrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_ChatMessagePrefab));
        return pointer == IntPtr.Zero ? (ChatMessageLine) null : new ChatMessageLine(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_ChatMessagePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField ChatInputField
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_ChatInputField));
        return pointer == IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_ChatInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Graphic ScrollViewGraphic
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_ScrollViewGraphic));
        return pointer == IntPtr.Zero ? (Graphic) null : new Graphic(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_ScrollViewGraphic), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Graphic ScrollViewportGraphic
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_ScrollViewportGraphic));
        return pointer == IntPtr.Zero ? (Graphic) null : new Graphic(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_ScrollViewportGraphic), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText PlaceholderText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_PlaceholderText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_PlaceholderText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey GlobalModeKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_GlobalModeKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_GlobalModeKey)) = value;
      }
    }

    public unsafe LocalizationKey AlliesModeKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_AlliesModeKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_AlliesModeKey)) = value;
      }
    }

    public unsafe LocalizationKey WhisperModeKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_WhisperModeKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_WhisperModeKey)) = value;
      }
    }

    public unsafe LocalizationKey LocalModeKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_LocalModeKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_LocalModeKey)) = value;
      }
    }

    public unsafe LocalizationKey SystemModeKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_SystemModeKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_SystemModeKey)) = value;
      }
    }

    public unsafe LocalizationKey GlobalKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_GlobalKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_GlobalKey)) = value;
      }
    }

    public unsafe LocalizationKey AlliesKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_AlliesKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_AlliesKey)) = value;
      }
    }

    public unsafe LocalizationKey WhisperKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_WhisperKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_WhisperKey)) = value;
      }
    }

    public unsafe LocalizationKey LocalKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_LocalKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_LocalKey)) = value;
      }
    }

    public unsafe LocalizationKey SystemKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_SystemKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_SystemKey)) = value;
      }
    }

    public unsafe LocalizationKey NoSuchCommandExists
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_NoSuchCommandExists));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_NoSuchCommandExists)) = value;
      }
    }

    public unsafe LocalizationKey NoVampireWithThatNameFound
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_NoVampireWithThatNameFound));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_NoVampireWithThatNameFound)) = value;
      }
    }

    public unsafe LocalizationKey YouAreNotInAClan
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_YouAreNotInAClan));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_YouAreNotInAClan)) = value;
      }
    }

    public unsafe LocalizationKey ToWhisperKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_ToWhisperKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_ToWhisperKey)) = value;
      }
    }

    public unsafe LocalizationKey FromWhisperKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_FromWhisperKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_FromWhisperKey)) = value;
      }
    }

    public unsafe LocalizationKey KillCommandWarning
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_KillCommandWarning));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_KillCommandWarning)) = value;
      }
    }

    public unsafe LocalizationKey NoteToSelf
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_NoteToSelf));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_NoteToSelf)) = value;
      }
    }

    public unsafe LocalizationKey NoRecentWhispers
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_NoRecentWhispers));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_NoRecentWhispers)) = value;
      }
    }

    public unsafe ScrollRect ScrollView
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_ScrollView));
        return pointer == IntPtr.Zero ? (ScrollRect) null : new ScrollRect(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_ScrollView), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ChatColorsAsset Colors
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_Colors));
        return pointer == IntPtr.Zero ? (ChatColorsAsset) null : new ChatColorsAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr_Colors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<ChatMessageLine> _ChatLines
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr__ChatLines));
        return pointer == IntPtr.Zero ? (UI_Cache<ChatMessageLine>) null : new UI_Cache<ChatMessageLine>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HUDChatWindow.NativeFieldInfoPtr__ChatLines), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
