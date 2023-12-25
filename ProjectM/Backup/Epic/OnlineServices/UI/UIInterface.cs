// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.UI.UIInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.UI
{
  public sealed class UIInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AcknowledgecorrelationidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AcknowledgeeventidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifydisplaysettingsupdatedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_EventidInvalid;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetfriendsexclusiveinputApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetfriendsvisibleApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GettogglefriendskeyApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_HidefriendsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_IssocialoverlaypausedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_PausesocialoverlayApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrepresentApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReportkeyeventApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetdisplaypreferenceApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SettogglefriendskeyApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowblockplayerApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowfriendsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowreportplayerApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AcknowledgeEventId_Public_Result_byref_AcknowledgeEventIdOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyDisplaySettingsUpdated_Public_UInt64_byref_AddNotifyDisplaySettingsUpdatedOptions_Object_OnDisplaySettingsUpdatedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFriendsExclusiveInput_Public_Boolean_byref_GetFriendsExclusiveInputOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFriendsVisible_Public_Boolean_byref_GetFriendsVisibleOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNotificationLocationPreference_Public_NotificationLocation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetToggleFriendsKey_Public_KeyCombination_byref_GetToggleFriendsKeyOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HideFriends_Public_Void_byref_HideFriendsOptions_Object_OnHideFriendsCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSocialOverlayPaused_Public_Boolean_byref_IsSocialOverlayPausedOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValidKeyCombination_Public_Boolean_KeyCombination_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PauseSocialOverlay_Public_Result_byref_PauseSocialOverlayOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyDisplaySettingsUpdated_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetDisplayPreference_Public_Result_byref_SetDisplayPreferenceOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetToggleFriendsKey_Public_Result_byref_SetToggleFriendsKeyOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowBlockPlayer_Public_Void_byref_ShowBlockPlayerOptions_Object_OnShowBlockPlayerCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowFriends_Public_Void_byref_ShowFriendsOptions_Object_OnShowFriendsCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowReportPlayer_Public_Void_byref_ShowReportPlayerOptions_Object_OnShowReportPlayerCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisplaySettingsUpdatedCallbackInternalImplementation_Internal_Static_Void_byref_OnDisplaySettingsUpdatedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnHideFriendsCallbackInternalImplementation_Internal_Static_Void_byref_HideFriendsCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnShowBlockPlayerCallbackInternalImplementation_Internal_Static_Void_byref_OnShowBlockPlayerCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnShowFriendsCallbackInternalImplementation_Internal_Static_Void_byref_ShowFriendsCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnShowReportPlayerCallbackInternalImplementation_Internal_Static_Void_byref_OnShowReportPlayerCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UIInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938096, XrefRangeEnd = 938104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result AcknowledgeEventId(ref AcknowledgeEventIdOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_AcknowledgeEventId_Public_Result_byref_AcknowledgeEventIdOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938104, XrefRangeEnd = 938124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyDisplaySettingsUpdated(
      ref AddNotifyDisplaySettingsUpdatedOptions options,
      Il2CppSystem.Object clientData,
      OnDisplaySettingsUpdatedCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_AddNotifyDisplaySettingsUpdated_Public_UInt64_byref_AddNotifyDisplaySettingsUpdatedOptions_Object_OnDisplaySettingsUpdatedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938124, XrefRangeEnd = 938133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetFriendsExclusiveInput(ref GetFriendsExclusiveInputOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_GetFriendsExclusiveInput_Public_Boolean_byref_GetFriendsExclusiveInputOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938133, XrefRangeEnd = 938142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetFriendsVisible(ref GetFriendsVisibleOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_GetFriendsVisible_Public_Boolean_byref_GetFriendsVisibleOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938142, XrefRangeEnd = 938143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NotificationLocation GetNotificationLocationPreference()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_GetNotificationLocationPreference_Public_NotificationLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NotificationLocation*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938143, XrefRangeEnd = 938151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe KeyCombination GetToggleFriendsKey(ref GetToggleFriendsKeyOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_GetToggleFriendsKey_Public_KeyCombination_byref_GetToggleFriendsKeyOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(KeyCombination*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938151, XrefRangeEnd = 938170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HideFriends(
      ref HideFriendsOptions options,
      Il2CppSystem.Object clientData,
      OnHideFriendsCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_HideFriends_Public_Void_byref_HideFriendsOptions_Object_OnHideFriendsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938170, XrefRangeEnd = 938179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsSocialOverlayPaused(ref IsSocialOverlayPausedOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_IsSocialOverlayPaused_Public_Boolean_byref_IsSocialOverlayPausedOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938179, XrefRangeEnd = 938184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsValidKeyCombination(KeyCombination keyCombination)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &keyCombination;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_IsValidKeyCombination_Public_Boolean_KeyCombination_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938184, XrefRangeEnd = 938192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result PauseSocialOverlay(ref PauseSocialOverlayOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_PauseSocialOverlay_Public_Result_byref_PauseSocialOverlayOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938192, XrefRangeEnd = 938197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyDisplaySettingsUpdated(ulong id)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &id;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_RemoveNotifyDisplaySettingsUpdated_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938197, XrefRangeEnd = 938205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetDisplayPreference(ref SetDisplayPreferenceOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_SetDisplayPreference_Public_Result_byref_SetDisplayPreferenceOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938205, XrefRangeEnd = 938213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetToggleFriendsKey(ref SetToggleFriendsKeyOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_SetToggleFriendsKey_Public_Result_byref_SetToggleFriendsKeyOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938213, XrefRangeEnd = 938232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowBlockPlayer(
      ref ShowBlockPlayerOptions options,
      Il2CppSystem.Object clientData,
      OnShowBlockPlayerCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_ShowBlockPlayer_Public_Void_byref_ShowBlockPlayerOptions_Object_OnShowBlockPlayerCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938232, XrefRangeEnd = 938251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowFriends(
      ref ShowFriendsOptions options,
      Il2CppSystem.Object clientData,
      OnShowFriendsCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_ShowFriends_Public_Void_byref_ShowFriendsOptions_Object_OnShowFriendsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938251, XrefRangeEnd = 938270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowReportPlayer(
      ref ShowReportPlayerOptions options,
      Il2CppSystem.Object clientData,
      OnShowReportPlayerCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_ShowReportPlayer_Public_Void_byref_ShowReportPlayerOptions_Object_OnShowReportPlayerCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938270, XrefRangeEnd = 938277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnDisplaySettingsUpdatedCallbackInternalImplementation(
      ref OnDisplaySettingsUpdatedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_OnDisplaySettingsUpdatedCallbackInternalImplementation_Internal_Static_Void_byref_OnDisplaySettingsUpdatedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938277, XrefRangeEnd = 938284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnHideFriendsCallbackInternalImplementation(
      ref HideFriendsCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_OnHideFriendsCallbackInternalImplementation_Internal_Static_Void_byref_HideFriendsCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938284, XrefRangeEnd = 938291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnShowBlockPlayerCallbackInternalImplementation(
      ref OnShowBlockPlayerCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_OnShowBlockPlayerCallbackInternalImplementation_Internal_Static_Void_byref_OnShowBlockPlayerCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938291, XrefRangeEnd = 938298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnShowFriendsCallbackInternalImplementation(
      ref ShowFriendsCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_OnShowFriendsCallbackInternalImplementation_Internal_Static_Void_byref_ShowFriendsCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938298, XrefRangeEnd = 938305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnShowReportPlayerCallbackInternalImplementation(
      ref OnShowReportPlayerCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIInterface.NativeMethodInfoPtr_OnShowReportPlayerCallbackInternalImplementation_Internal_Static_Void_byref_OnShowReportPlayerCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UIInterface()
    {
      Il2CppClassPointerStore<UIInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.UI", nameof (UIInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIInterface>.NativeClassPtr);
      UIInterface.NativeFieldInfoPtr_AcknowledgecorrelationidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (AcknowledgecorrelationidApiLatest));
      UIInterface.NativeFieldInfoPtr_AcknowledgeeventidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (AcknowledgeeventidApiLatest));
      UIInterface.NativeFieldInfoPtr_AddnotifydisplaysettingsupdatedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (AddnotifydisplaysettingsupdatedApiLatest));
      UIInterface.NativeFieldInfoPtr_EventidInvalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (EventidInvalid));
      UIInterface.NativeFieldInfoPtr_GetfriendsexclusiveinputApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (GetfriendsexclusiveinputApiLatest));
      UIInterface.NativeFieldInfoPtr_GetfriendsvisibleApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (GetfriendsvisibleApiLatest));
      UIInterface.NativeFieldInfoPtr_GettogglefriendskeyApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (GettogglefriendskeyApiLatest));
      UIInterface.NativeFieldInfoPtr_HidefriendsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (HidefriendsApiLatest));
      UIInterface.NativeFieldInfoPtr_IssocialoverlaypausedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (IssocialoverlaypausedApiLatest));
      UIInterface.NativeFieldInfoPtr_PausesocialoverlayApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (PausesocialoverlayApiLatest));
      UIInterface.NativeFieldInfoPtr_PrepresentApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (PrepresentApiLatest));
      UIInterface.NativeFieldInfoPtr_ReportkeyeventApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (ReportkeyeventApiLatest));
      UIInterface.NativeFieldInfoPtr_SetdisplaypreferenceApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (SetdisplaypreferenceApiLatest));
      UIInterface.NativeFieldInfoPtr_SettogglefriendskeyApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (SettogglefriendskeyApiLatest));
      UIInterface.NativeFieldInfoPtr_ShowblockplayerApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (ShowblockplayerApiLatest));
      UIInterface.NativeFieldInfoPtr_ShowfriendsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (ShowfriendsApiLatest));
      UIInterface.NativeFieldInfoPtr_ShowreportplayerApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, nameof (ShowreportplayerApiLatest));
      UIInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100665369);
      UIInterface.NativeMethodInfoPtr_AcknowledgeEventId_Public_Result_byref_AcknowledgeEventIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100665371);
      UIInterface.NativeMethodInfoPtr_AddNotifyDisplaySettingsUpdated_Public_UInt64_byref_AddNotifyDisplaySettingsUpdatedOptions_Object_OnDisplaySettingsUpdatedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100665372);
      UIInterface.NativeMethodInfoPtr_GetFriendsExclusiveInput_Public_Boolean_byref_GetFriendsExclusiveInputOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100665373);
      UIInterface.NativeMethodInfoPtr_GetFriendsVisible_Public_Boolean_byref_GetFriendsVisibleOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100665374);
      UIInterface.NativeMethodInfoPtr_GetNotificationLocationPreference_Public_NotificationLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100665375);
      UIInterface.NativeMethodInfoPtr_GetToggleFriendsKey_Public_KeyCombination_byref_GetToggleFriendsKeyOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100665376);
      UIInterface.NativeMethodInfoPtr_HideFriends_Public_Void_byref_HideFriendsOptions_Object_OnHideFriendsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100665377);
      UIInterface.NativeMethodInfoPtr_IsSocialOverlayPaused_Public_Boolean_byref_IsSocialOverlayPausedOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100665378);
      UIInterface.NativeMethodInfoPtr_IsValidKeyCombination_Public_Boolean_KeyCombination_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100665379);
      UIInterface.NativeMethodInfoPtr_PauseSocialOverlay_Public_Result_byref_PauseSocialOverlayOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100665380);
      UIInterface.NativeMethodInfoPtr_RemoveNotifyDisplaySettingsUpdated_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100665381);
      UIInterface.NativeMethodInfoPtr_SetDisplayPreference_Public_Result_byref_SetDisplayPreferenceOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100665382);
      UIInterface.NativeMethodInfoPtr_SetToggleFriendsKey_Public_Result_byref_SetToggleFriendsKeyOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100665383);
      UIInterface.NativeMethodInfoPtr_ShowBlockPlayer_Public_Void_byref_ShowBlockPlayerOptions_Object_OnShowBlockPlayerCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100665384);
      UIInterface.NativeMethodInfoPtr_ShowFriends_Public_Void_byref_ShowFriendsOptions_Object_OnShowFriendsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100665385);
      UIInterface.NativeMethodInfoPtr_ShowReportPlayer_Public_Void_byref_ShowReportPlayerOptions_Object_OnShowReportPlayerCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100665386);
      UIInterface.NativeMethodInfoPtr_OnDisplaySettingsUpdatedCallbackInternalImplementation_Internal_Static_Void_byref_OnDisplaySettingsUpdatedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100665387);
      UIInterface.NativeMethodInfoPtr_OnHideFriendsCallbackInternalImplementation_Internal_Static_Void_byref_HideFriendsCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100665388);
      UIInterface.NativeMethodInfoPtr_OnShowBlockPlayerCallbackInternalImplementation_Internal_Static_Void_byref_OnShowBlockPlayerCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100665389);
      UIInterface.NativeMethodInfoPtr_OnShowFriendsCallbackInternalImplementation_Internal_Static_Void_byref_ShowFriendsCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100665390);
      UIInterface.NativeMethodInfoPtr_OnShowReportPlayerCallbackInternalImplementation_Internal_Static_Void_byref_OnShowReportPlayerCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIInterface>.NativeClassPtr, 100665391);
    }

    public UIInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int AcknowledgecorrelationidApiLatest
    {
      get
      {
        int acknowledgecorrelationidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_AcknowledgecorrelationidApiLatest, (void*) &acknowledgecorrelationidApiLatest);
        return acknowledgecorrelationidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_AcknowledgecorrelationidApiLatest, (void*) &value);
      }
    }

    public static unsafe int AcknowledgeeventidApiLatest
    {
      get
      {
        int acknowledgeeventidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_AcknowledgeeventidApiLatest, (void*) &acknowledgeeventidApiLatest);
        return acknowledgeeventidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_AcknowledgeeventidApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifydisplaysettingsupdatedApiLatest
    {
      get
      {
        int addnotifydisplaysettingsupdatedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_AddnotifydisplaysettingsupdatedApiLatest, (void*) &addnotifydisplaysettingsupdatedApiLatest);
        return addnotifydisplaysettingsupdatedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_AddnotifydisplaysettingsupdatedApiLatest, (void*) &value);
      }
    }

    public static unsafe int EventidInvalid
    {
      get
      {
        int eventidInvalid;
        IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_EventidInvalid, (void*) &eventidInvalid);
        return eventidInvalid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_EventidInvalid, (void*) &value);
      }
    }

    public static unsafe int GetfriendsexclusiveinputApiLatest
    {
      get
      {
        int getfriendsexclusiveinputApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_GetfriendsexclusiveinputApiLatest, (void*) &getfriendsexclusiveinputApiLatest);
        return getfriendsexclusiveinputApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_GetfriendsexclusiveinputApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetfriendsvisibleApiLatest
    {
      get
      {
        int getfriendsvisibleApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_GetfriendsvisibleApiLatest, (void*) &getfriendsvisibleApiLatest);
        return getfriendsvisibleApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_GetfriendsvisibleApiLatest, (void*) &value);
      }
    }

    public static unsafe int GettogglefriendskeyApiLatest
    {
      get
      {
        int gettogglefriendskeyApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_GettogglefriendskeyApiLatest, (void*) &gettogglefriendskeyApiLatest);
        return gettogglefriendskeyApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_GettogglefriendskeyApiLatest, (void*) &value);
      }
    }

    public static unsafe int HidefriendsApiLatest
    {
      get
      {
        int hidefriendsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_HidefriendsApiLatest, (void*) &hidefriendsApiLatest);
        return hidefriendsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_HidefriendsApiLatest, (void*) &value);
      }
    }

    public static unsafe int IssocialoverlaypausedApiLatest
    {
      get
      {
        int issocialoverlaypausedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_IssocialoverlaypausedApiLatest, (void*) &issocialoverlaypausedApiLatest);
        return issocialoverlaypausedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_IssocialoverlaypausedApiLatest, (void*) &value);
      }
    }

    public static unsafe int PausesocialoverlayApiLatest
    {
      get
      {
        int pausesocialoverlayApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_PausesocialoverlayApiLatest, (void*) &pausesocialoverlayApiLatest);
        return pausesocialoverlayApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_PausesocialoverlayApiLatest, (void*) &value);
      }
    }

    public static unsafe int PrepresentApiLatest
    {
      get
      {
        int prepresentApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_PrepresentApiLatest, (void*) &prepresentApiLatest);
        return prepresentApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_PrepresentApiLatest, (void*) &value);
      }
    }

    public static unsafe int ReportkeyeventApiLatest
    {
      get
      {
        int reportkeyeventApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_ReportkeyeventApiLatest, (void*) &reportkeyeventApiLatest);
        return reportkeyeventApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_ReportkeyeventApiLatest, (void*) &value);
      }
    }

    public static unsafe int SetdisplaypreferenceApiLatest
    {
      get
      {
        int setdisplaypreferenceApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_SetdisplaypreferenceApiLatest, (void*) &setdisplaypreferenceApiLatest);
        return setdisplaypreferenceApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_SetdisplaypreferenceApiLatest, (void*) &value);
      }
    }

    public static unsafe int SettogglefriendskeyApiLatest
    {
      get
      {
        int settogglefriendskeyApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_SettogglefriendskeyApiLatest, (void*) &settogglefriendskeyApiLatest);
        return settogglefriendskeyApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_SettogglefriendskeyApiLatest, (void*) &value);
      }
    }

    public static unsafe int ShowblockplayerApiLatest
    {
      get
      {
        int showblockplayerApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_ShowblockplayerApiLatest, (void*) &showblockplayerApiLatest);
        return showblockplayerApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_ShowblockplayerApiLatest, (void*) &value);
      }
    }

    public static unsafe int ShowfriendsApiLatest
    {
      get
      {
        int showfriendsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_ShowfriendsApiLatest, (void*) &showfriendsApiLatest);
        return showfriendsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_ShowfriendsApiLatest, (void*) &value);
      }
    }

    public static unsafe int ShowreportplayerApiLatest
    {
      get
      {
        int showreportplayerApiLatest;
        IL2CPP.il2cpp_field_static_get_value(UIInterface.NativeFieldInfoPtr_ShowreportplayerApiLatest, (void*) &showreportplayerApiLatest);
        return showreportplayerApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIInterface.NativeFieldInfoPtr_ShowreportplayerApiLatest, (void*) &value);
      }
    }
  }
}
