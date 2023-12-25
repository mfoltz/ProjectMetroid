// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAudio.RTCAudioInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTCAudio
{
  public sealed class RTCAudioInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyaudiobeforerenderApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyaudiobeforesendApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyaudiodeviceschangedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyaudioinputstateApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyaudiooutputstateApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyparticipantupdatedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AudiobufferApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AudioinputdeviceinfoApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AudiooutputdeviceinfoApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetaudioinputdevicebyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetaudioinputdevicescountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetaudiooutputdevicebyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetaudiooutputdevicescountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_RegisterplatformaudiouserApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SendaudioApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetaudioinputsettingsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetaudiooutputsettingsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnregisterplatformaudiouserApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_UpdateparticipantvolumeApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_UpdatereceivingApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_UpdatereceivingvolumeApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_UpdatesendingApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_UpdatesendingvolumeApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyAudioBeforeRender_Public_UInt64_byref_AddNotifyAudioBeforeRenderOptions_Object_OnAudioBeforeRenderCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyAudioBeforeSend_Public_UInt64_byref_AddNotifyAudioBeforeSendOptions_Object_OnAudioBeforeSendCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyAudioDevicesChanged_Public_UInt64_byref_AddNotifyAudioDevicesChangedOptions_Object_OnAudioDevicesChangedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyAudioInputState_Public_UInt64_byref_AddNotifyAudioInputStateOptions_Object_OnAudioInputStateCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyAudioOutputState_Public_UInt64_byref_AddNotifyAudioOutputStateOptions_Object_OnAudioOutputStateCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyParticipantUpdated_Public_UInt64_byref_AddNotifyParticipantUpdatedOptions_Object_OnParticipantUpdatedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAudioInputDeviceByIndex_Public_Nullable_1_AudioInputDeviceInfo_byref_GetAudioInputDeviceByIndexOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAudioInputDevicesCount_Public_UInt32_byref_GetAudioInputDevicesCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAudioOutputDeviceByIndex_Public_Nullable_1_AudioOutputDeviceInfo_byref_GetAudioOutputDeviceByIndexOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAudioOutputDevicesCount_Public_UInt32_byref_GetAudioOutputDevicesCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterPlatformAudioUser_Public_Result_byref_RegisterPlatformAudioUserOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyAudioBeforeRender_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyAudioBeforeSend_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyAudioDevicesChanged_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyAudioInputState_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyAudioOutputState_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyParticipantUpdated_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendAudio_Public_Result_byref_SendAudioOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAudioInputSettings_Public_Result_byref_SetAudioInputSettingsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAudioOutputSettings_Public_Result_byref_SetAudioOutputSettingsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterPlatformAudioUser_Public_Result_byref_UnregisterPlatformAudioUserOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateParticipantVolume_Public_Void_byref_UpdateParticipantVolumeOptions_Object_OnUpdateParticipantVolumeCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateReceiving_Public_Void_byref_UpdateReceivingOptions_Object_OnUpdateReceivingCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateReceivingVolume_Public_Void_byref_UpdateReceivingVolumeOptions_Object_OnUpdateReceivingVolumeCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSending_Public_Void_byref_UpdateSendingOptions_Object_OnUpdateSendingCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSendingVolume_Public_Void_byref_UpdateSendingVolumeOptions_Object_OnUpdateSendingVolumeCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnAudioBeforeRenderCallbackInternalImplementation_Internal_Static_Void_byref_AudioBeforeRenderCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnAudioBeforeSendCallbackInternalImplementation_Internal_Static_Void_byref_AudioBeforeSendCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnAudioDevicesChangedCallbackInternalImplementation_Internal_Static_Void_byref_AudioDevicesChangedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnAudioInputStateCallbackInternalImplementation_Internal_Static_Void_byref_AudioInputStateCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnAudioOutputStateCallbackInternalImplementation_Internal_Static_Void_byref_AudioOutputStateCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnParticipantUpdatedCallbackInternalImplementation_Internal_Static_Void_byref_ParticipantUpdatedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateParticipantVolumeCallbackInternalImplementation_Internal_Static_Void_byref_UpdateParticipantVolumeCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateReceivingCallbackInternalImplementation_Internal_Static_Void_byref_UpdateReceivingCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateReceivingVolumeCallbackInternalImplementation_Internal_Static_Void_byref_UpdateReceivingVolumeCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateSendingCallbackInternalImplementation_Internal_Static_Void_byref_UpdateSendingCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateSendingVolumeCallbackInternalImplementation_Internal_Static_Void_byref_UpdateSendingVolumeCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RTCAudioInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944727, XrefRangeEnd = 944747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyAudioBeforeRender(
      ref AddNotifyAudioBeforeRenderOptions options,
      Il2CppSystem.Object clientData,
      OnAudioBeforeRenderCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_AddNotifyAudioBeforeRender_Public_UInt64_byref_AddNotifyAudioBeforeRenderOptions_Object_OnAudioBeforeRenderCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944747, XrefRangeEnd = 944767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyAudioBeforeSend(
      ref AddNotifyAudioBeforeSendOptions options,
      Il2CppSystem.Object clientData,
      OnAudioBeforeSendCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_AddNotifyAudioBeforeSend_Public_UInt64_byref_AddNotifyAudioBeforeSendOptions_Object_OnAudioBeforeSendCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944767, XrefRangeEnd = 944787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyAudioDevicesChanged(
      ref AddNotifyAudioDevicesChangedOptions options,
      Il2CppSystem.Object clientData,
      OnAudioDevicesChangedCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_AddNotifyAudioDevicesChanged_Public_UInt64_byref_AddNotifyAudioDevicesChangedOptions_Object_OnAudioDevicesChangedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944787, XrefRangeEnd = 944807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyAudioInputState(
      ref AddNotifyAudioInputStateOptions options,
      Il2CppSystem.Object clientData,
      OnAudioInputStateCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_AddNotifyAudioInputState_Public_UInt64_byref_AddNotifyAudioInputStateOptions_Object_OnAudioInputStateCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944807, XrefRangeEnd = 944827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyAudioOutputState(
      ref AddNotifyAudioOutputStateOptions options,
      Il2CppSystem.Object clientData,
      OnAudioOutputStateCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_AddNotifyAudioOutputState_Public_UInt64_byref_AddNotifyAudioOutputStateOptions_Object_OnAudioOutputStateCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944827, XrefRangeEnd = 944847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyParticipantUpdated(
      ref AddNotifyParticipantUpdatedOptions options,
      Il2CppSystem.Object clientData,
      OnParticipantUpdatedCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_AddNotifyParticipantUpdated_Public_UInt64_byref_AddNotifyParticipantUpdatedOptions_Object_OnParticipantUpdatedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944847, XrefRangeEnd = 944858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppSystem.Nullable<AudioInputDeviceInfo> GetAudioInputDeviceByIndex(
      ref GetAudioInputDeviceByIndexOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_GetAudioInputDeviceByIndex_Public_Nullable_1_AudioInputDeviceInfo_byref_GetAudioInputDeviceByIndexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new Il2CppSystem.Nullable<AudioInputDeviceInfo>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944858, XrefRangeEnd = 944866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetAudioInputDevicesCount(ref GetAudioInputDevicesCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_GetAudioInputDevicesCount_Public_UInt32_byref_GetAudioInputDevicesCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944866, XrefRangeEnd = 944877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppSystem.Nullable<AudioOutputDeviceInfo> GetAudioOutputDeviceByIndex(
      ref GetAudioOutputDeviceByIndexOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_GetAudioOutputDeviceByIndex_Public_Nullable_1_AudioOutputDeviceInfo_byref_GetAudioOutputDeviceByIndexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new Il2CppSystem.Nullable<AudioOutputDeviceInfo>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944877, XrefRangeEnd = 944885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetAudioOutputDevicesCount(ref GetAudioOutputDevicesCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_GetAudioOutputDevicesCount_Public_UInt32_byref_GetAudioOutputDevicesCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944885, XrefRangeEnd = 944893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result RegisterPlatformAudioUser(ref RegisterPlatformAudioUserOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_RegisterPlatformAudioUser_Public_Result_byref_RegisterPlatformAudioUserOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944893, XrefRangeEnd = 944898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyAudioBeforeRender(ulong notificationId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyAudioBeforeRender_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944898, XrefRangeEnd = 944903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyAudioBeforeSend(ulong notificationId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyAudioBeforeSend_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944903, XrefRangeEnd = 944908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyAudioDevicesChanged(ulong notificationId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyAudioDevicesChanged_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944908, XrefRangeEnd = 944913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyAudioInputState(ulong notificationId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyAudioInputState_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944913, XrefRangeEnd = 944918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyAudioOutputState(ulong notificationId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyAudioOutputState_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944918, XrefRangeEnd = 944923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyParticipantUpdated(ulong notificationId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyParticipantUpdated_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944923, XrefRangeEnd = 944931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SendAudio(ref SendAudioOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_SendAudio_Public_Result_byref_SendAudioOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944931, XrefRangeEnd = 944939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetAudioInputSettings(ref SetAudioInputSettingsOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_SetAudioInputSettings_Public_Result_byref_SetAudioInputSettingsOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944939, XrefRangeEnd = 944947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetAudioOutputSettings(ref SetAudioOutputSettingsOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_SetAudioOutputSettings_Public_Result_byref_SetAudioOutputSettingsOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944947, XrefRangeEnd = 944955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result UnregisterPlatformAudioUser(ref UnregisterPlatformAudioUserOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_UnregisterPlatformAudioUser_Public_Result_byref_UnregisterPlatformAudioUserOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944955, XrefRangeEnd = 944974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateParticipantVolume(
      ref UpdateParticipantVolumeOptions options,
      Il2CppSystem.Object clientData,
      OnUpdateParticipantVolumeCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_UpdateParticipantVolume_Public_Void_byref_UpdateParticipantVolumeOptions_Object_OnUpdateParticipantVolumeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944974, XrefRangeEnd = 944993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateReceiving(
      ref UpdateReceivingOptions options,
      Il2CppSystem.Object clientData,
      OnUpdateReceivingCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_UpdateReceiving_Public_Void_byref_UpdateReceivingOptions_Object_OnUpdateReceivingCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944993, XrefRangeEnd = 945012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateReceivingVolume(
      ref UpdateReceivingVolumeOptions options,
      Il2CppSystem.Object clientData,
      OnUpdateReceivingVolumeCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_UpdateReceivingVolume_Public_Void_byref_UpdateReceivingVolumeOptions_Object_OnUpdateReceivingVolumeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945012, XrefRangeEnd = 945031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateSending(
      ref UpdateSendingOptions options,
      Il2CppSystem.Object clientData,
      OnUpdateSendingCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_UpdateSending_Public_Void_byref_UpdateSendingOptions_Object_OnUpdateSendingCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945031, XrefRangeEnd = 945050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateSendingVolume(
      ref UpdateSendingVolumeOptions options,
      Il2CppSystem.Object clientData,
      OnUpdateSendingVolumeCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_UpdateSendingVolume_Public_Void_byref_UpdateSendingVolumeOptions_Object_OnUpdateSendingVolumeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945050, XrefRangeEnd = 945057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnAudioBeforeRenderCallbackInternalImplementation(
      ref AudioBeforeRenderCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_OnAudioBeforeRenderCallbackInternalImplementation_Internal_Static_Void_byref_AudioBeforeRenderCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945057, XrefRangeEnd = 945064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnAudioBeforeSendCallbackInternalImplementation(
      ref AudioBeforeSendCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_OnAudioBeforeSendCallbackInternalImplementation_Internal_Static_Void_byref_AudioBeforeSendCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945064, XrefRangeEnd = 945071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnAudioDevicesChangedCallbackInternalImplementation(
      ref AudioDevicesChangedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_OnAudioDevicesChangedCallbackInternalImplementation_Internal_Static_Void_byref_AudioDevicesChangedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945071, XrefRangeEnd = 945078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnAudioInputStateCallbackInternalImplementation(
      ref AudioInputStateCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_OnAudioInputStateCallbackInternalImplementation_Internal_Static_Void_byref_AudioInputStateCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945078, XrefRangeEnd = 945085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnAudioOutputStateCallbackInternalImplementation(
      ref AudioOutputStateCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_OnAudioOutputStateCallbackInternalImplementation_Internal_Static_Void_byref_AudioOutputStateCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945085, XrefRangeEnd = 945092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnParticipantUpdatedCallbackInternalImplementation(
      ref ParticipantUpdatedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_OnParticipantUpdatedCallbackInternalImplementation_Internal_Static_Void_byref_ParticipantUpdatedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945092, XrefRangeEnd = 945099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnUpdateParticipantVolumeCallbackInternalImplementation(
      ref UpdateParticipantVolumeCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_OnUpdateParticipantVolumeCallbackInternalImplementation_Internal_Static_Void_byref_UpdateParticipantVolumeCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945099, XrefRangeEnd = 945106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnUpdateReceivingCallbackInternalImplementation(
      ref UpdateReceivingCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_OnUpdateReceivingCallbackInternalImplementation_Internal_Static_Void_byref_UpdateReceivingCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945106, XrefRangeEnd = 945113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnUpdateReceivingVolumeCallbackInternalImplementation(
      ref UpdateReceivingVolumeCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_OnUpdateReceivingVolumeCallbackInternalImplementation_Internal_Static_Void_byref_UpdateReceivingVolumeCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945113, XrefRangeEnd = 945120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnUpdateSendingCallbackInternalImplementation(
      ref UpdateSendingCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_OnUpdateSendingCallbackInternalImplementation_Internal_Static_Void_byref_UpdateSendingCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945120, XrefRangeEnd = 945127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnUpdateSendingVolumeCallbackInternalImplementation(
      ref UpdateSendingVolumeCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAudioInterface.NativeMethodInfoPtr_OnUpdateSendingVolumeCallbackInternalImplementation_Internal_Static_Void_byref_UpdateSendingVolumeCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RTCAudioInterface()
    {
      Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.RTCAudio", nameof (RTCAudioInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr);
      RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiobeforerenderApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (AddnotifyaudiobeforerenderApiLatest));
      RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiobeforesendApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (AddnotifyaudiobeforesendApiLatest));
      RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiodeviceschangedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (AddnotifyaudiodeviceschangedApiLatest));
      RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudioinputstateApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (AddnotifyaudioinputstateApiLatest));
      RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiooutputstateApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (AddnotifyaudiooutputstateApiLatest));
      RTCAudioInterface.NativeFieldInfoPtr_AddnotifyparticipantupdatedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (AddnotifyparticipantupdatedApiLatest));
      RTCAudioInterface.NativeFieldInfoPtr_AudiobufferApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (AudiobufferApiLatest));
      RTCAudioInterface.NativeFieldInfoPtr_AudioinputdeviceinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (AudioinputdeviceinfoApiLatest));
      RTCAudioInterface.NativeFieldInfoPtr_AudiooutputdeviceinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (AudiooutputdeviceinfoApiLatest));
      RTCAudioInterface.NativeFieldInfoPtr_GetaudioinputdevicebyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (GetaudioinputdevicebyindexApiLatest));
      RTCAudioInterface.NativeFieldInfoPtr_GetaudioinputdevicescountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (GetaudioinputdevicescountApiLatest));
      RTCAudioInterface.NativeFieldInfoPtr_GetaudiooutputdevicebyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (GetaudiooutputdevicebyindexApiLatest));
      RTCAudioInterface.NativeFieldInfoPtr_GetaudiooutputdevicescountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (GetaudiooutputdevicescountApiLatest));
      RTCAudioInterface.NativeFieldInfoPtr_RegisterplatformaudiouserApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (RegisterplatformaudiouserApiLatest));
      RTCAudioInterface.NativeFieldInfoPtr_SendaudioApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (SendaudioApiLatest));
      RTCAudioInterface.NativeFieldInfoPtr_SetaudioinputsettingsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (SetaudioinputsettingsApiLatest));
      RTCAudioInterface.NativeFieldInfoPtr_SetaudiooutputsettingsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (SetaudiooutputsettingsApiLatest));
      RTCAudioInterface.NativeFieldInfoPtr_UnregisterplatformaudiouserApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (UnregisterplatformaudiouserApiLatest));
      RTCAudioInterface.NativeFieldInfoPtr_UpdateparticipantvolumeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (UpdateparticipantvolumeApiLatest));
      RTCAudioInterface.NativeFieldInfoPtr_UpdatereceivingApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (UpdatereceivingApiLatest));
      RTCAudioInterface.NativeFieldInfoPtr_UpdatereceivingvolumeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (UpdatereceivingvolumeApiLatest));
      RTCAudioInterface.NativeFieldInfoPtr_UpdatesendingApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (UpdatesendingApiLatest));
      RTCAudioInterface.NativeFieldInfoPtr_UpdatesendingvolumeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, nameof (UpdatesendingvolumeApiLatest));
      RTCAudioInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667211);
      RTCAudioInterface.NativeMethodInfoPtr_AddNotifyAudioBeforeRender_Public_UInt64_byref_AddNotifyAudioBeforeRenderOptions_Object_OnAudioBeforeRenderCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667213);
      RTCAudioInterface.NativeMethodInfoPtr_AddNotifyAudioBeforeSend_Public_UInt64_byref_AddNotifyAudioBeforeSendOptions_Object_OnAudioBeforeSendCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667214);
      RTCAudioInterface.NativeMethodInfoPtr_AddNotifyAudioDevicesChanged_Public_UInt64_byref_AddNotifyAudioDevicesChangedOptions_Object_OnAudioDevicesChangedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667215);
      RTCAudioInterface.NativeMethodInfoPtr_AddNotifyAudioInputState_Public_UInt64_byref_AddNotifyAudioInputStateOptions_Object_OnAudioInputStateCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667216);
      RTCAudioInterface.NativeMethodInfoPtr_AddNotifyAudioOutputState_Public_UInt64_byref_AddNotifyAudioOutputStateOptions_Object_OnAudioOutputStateCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667217);
      RTCAudioInterface.NativeMethodInfoPtr_AddNotifyParticipantUpdated_Public_UInt64_byref_AddNotifyParticipantUpdatedOptions_Object_OnParticipantUpdatedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667218);
      RTCAudioInterface.NativeMethodInfoPtr_GetAudioInputDeviceByIndex_Public_Nullable_1_AudioInputDeviceInfo_byref_GetAudioInputDeviceByIndexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667219);
      RTCAudioInterface.NativeMethodInfoPtr_GetAudioInputDevicesCount_Public_UInt32_byref_GetAudioInputDevicesCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667220);
      RTCAudioInterface.NativeMethodInfoPtr_GetAudioOutputDeviceByIndex_Public_Nullable_1_AudioOutputDeviceInfo_byref_GetAudioOutputDeviceByIndexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667221);
      RTCAudioInterface.NativeMethodInfoPtr_GetAudioOutputDevicesCount_Public_UInt32_byref_GetAudioOutputDevicesCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667222);
      RTCAudioInterface.NativeMethodInfoPtr_RegisterPlatformAudioUser_Public_Result_byref_RegisterPlatformAudioUserOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667223);
      RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyAudioBeforeRender_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667224);
      RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyAudioBeforeSend_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667225);
      RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyAudioDevicesChanged_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667226);
      RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyAudioInputState_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667227);
      RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyAudioOutputState_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667228);
      RTCAudioInterface.NativeMethodInfoPtr_RemoveNotifyParticipantUpdated_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667229);
      RTCAudioInterface.NativeMethodInfoPtr_SendAudio_Public_Result_byref_SendAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667230);
      RTCAudioInterface.NativeMethodInfoPtr_SetAudioInputSettings_Public_Result_byref_SetAudioInputSettingsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667231);
      RTCAudioInterface.NativeMethodInfoPtr_SetAudioOutputSettings_Public_Result_byref_SetAudioOutputSettingsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667232);
      RTCAudioInterface.NativeMethodInfoPtr_UnregisterPlatformAudioUser_Public_Result_byref_UnregisterPlatformAudioUserOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667233);
      RTCAudioInterface.NativeMethodInfoPtr_UpdateParticipantVolume_Public_Void_byref_UpdateParticipantVolumeOptions_Object_OnUpdateParticipantVolumeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667234);
      RTCAudioInterface.NativeMethodInfoPtr_UpdateReceiving_Public_Void_byref_UpdateReceivingOptions_Object_OnUpdateReceivingCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667235);
      RTCAudioInterface.NativeMethodInfoPtr_UpdateReceivingVolume_Public_Void_byref_UpdateReceivingVolumeOptions_Object_OnUpdateReceivingVolumeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667236);
      RTCAudioInterface.NativeMethodInfoPtr_UpdateSending_Public_Void_byref_UpdateSendingOptions_Object_OnUpdateSendingCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667237);
      RTCAudioInterface.NativeMethodInfoPtr_UpdateSendingVolume_Public_Void_byref_UpdateSendingVolumeOptions_Object_OnUpdateSendingVolumeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667238);
      RTCAudioInterface.NativeMethodInfoPtr_OnAudioBeforeRenderCallbackInternalImplementation_Internal_Static_Void_byref_AudioBeforeRenderCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667239);
      RTCAudioInterface.NativeMethodInfoPtr_OnAudioBeforeSendCallbackInternalImplementation_Internal_Static_Void_byref_AudioBeforeSendCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667240);
      RTCAudioInterface.NativeMethodInfoPtr_OnAudioDevicesChangedCallbackInternalImplementation_Internal_Static_Void_byref_AudioDevicesChangedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667241);
      RTCAudioInterface.NativeMethodInfoPtr_OnAudioInputStateCallbackInternalImplementation_Internal_Static_Void_byref_AudioInputStateCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667242);
      RTCAudioInterface.NativeMethodInfoPtr_OnAudioOutputStateCallbackInternalImplementation_Internal_Static_Void_byref_AudioOutputStateCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667243);
      RTCAudioInterface.NativeMethodInfoPtr_OnParticipantUpdatedCallbackInternalImplementation_Internal_Static_Void_byref_ParticipantUpdatedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667244);
      RTCAudioInterface.NativeMethodInfoPtr_OnUpdateParticipantVolumeCallbackInternalImplementation_Internal_Static_Void_byref_UpdateParticipantVolumeCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667245);
      RTCAudioInterface.NativeMethodInfoPtr_OnUpdateReceivingCallbackInternalImplementation_Internal_Static_Void_byref_UpdateReceivingCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667246);
      RTCAudioInterface.NativeMethodInfoPtr_OnUpdateReceivingVolumeCallbackInternalImplementation_Internal_Static_Void_byref_UpdateReceivingVolumeCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667247);
      RTCAudioInterface.NativeMethodInfoPtr_OnUpdateSendingCallbackInternalImplementation_Internal_Static_Void_byref_UpdateSendingCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667248);
      RTCAudioInterface.NativeMethodInfoPtr_OnUpdateSendingVolumeCallbackInternalImplementation_Internal_Static_Void_byref_UpdateSendingVolumeCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAudioInterface>.NativeClassPtr, 100667249);
    }

    public RTCAudioInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int AddnotifyaudiobeforerenderApiLatest
    {
      get
      {
        int addnotifyaudiobeforerenderApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiobeforerenderApiLatest, (void*) &addnotifyaudiobeforerenderApiLatest);
        return addnotifyaudiobeforerenderApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiobeforerenderApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifyaudiobeforesendApiLatest
    {
      get
      {
        int addnotifyaudiobeforesendApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiobeforesendApiLatest, (void*) &addnotifyaudiobeforesendApiLatest);
        return addnotifyaudiobeforesendApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiobeforesendApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifyaudiodeviceschangedApiLatest
    {
      get
      {
        int addnotifyaudiodeviceschangedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiodeviceschangedApiLatest, (void*) &addnotifyaudiodeviceschangedApiLatest);
        return addnotifyaudiodeviceschangedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiodeviceschangedApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifyaudioinputstateApiLatest
    {
      get
      {
        int addnotifyaudioinputstateApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudioinputstateApiLatest, (void*) &addnotifyaudioinputstateApiLatest);
        return addnotifyaudioinputstateApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudioinputstateApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifyaudiooutputstateApiLatest
    {
      get
      {
        int addnotifyaudiooutputstateApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiooutputstateApiLatest, (void*) &addnotifyaudiooutputstateApiLatest);
        return addnotifyaudiooutputstateApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyaudiooutputstateApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifyparticipantupdatedApiLatest
    {
      get
      {
        int addnotifyparticipantupdatedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyparticipantupdatedApiLatest, (void*) &addnotifyparticipantupdatedApiLatest);
        return addnotifyparticipantupdatedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_AddnotifyparticipantupdatedApiLatest, (void*) &value);
      }
    }

    public static unsafe int AudiobufferApiLatest
    {
      get
      {
        int audiobufferApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_AudiobufferApiLatest, (void*) &audiobufferApiLatest);
        return audiobufferApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_AudiobufferApiLatest, (void*) &value);
      }
    }

    public static unsafe int AudioinputdeviceinfoApiLatest
    {
      get
      {
        int audioinputdeviceinfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_AudioinputdeviceinfoApiLatest, (void*) &audioinputdeviceinfoApiLatest);
        return audioinputdeviceinfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_AudioinputdeviceinfoApiLatest, (void*) &value);
      }
    }

    public static unsafe int AudiooutputdeviceinfoApiLatest
    {
      get
      {
        int audiooutputdeviceinfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_AudiooutputdeviceinfoApiLatest, (void*) &audiooutputdeviceinfoApiLatest);
        return audiooutputdeviceinfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_AudiooutputdeviceinfoApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetaudioinputdevicebyindexApiLatest
    {
      get
      {
        int getaudioinputdevicebyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_GetaudioinputdevicebyindexApiLatest, (void*) &getaudioinputdevicebyindexApiLatest);
        return getaudioinputdevicebyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_GetaudioinputdevicebyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetaudioinputdevicescountApiLatest
    {
      get
      {
        int getaudioinputdevicescountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_GetaudioinputdevicescountApiLatest, (void*) &getaudioinputdevicescountApiLatest);
        return getaudioinputdevicescountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_GetaudioinputdevicescountApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetaudiooutputdevicebyindexApiLatest
    {
      get
      {
        int getaudiooutputdevicebyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_GetaudiooutputdevicebyindexApiLatest, (void*) &getaudiooutputdevicebyindexApiLatest);
        return getaudiooutputdevicebyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_GetaudiooutputdevicebyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetaudiooutputdevicescountApiLatest
    {
      get
      {
        int getaudiooutputdevicescountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_GetaudiooutputdevicescountApiLatest, (void*) &getaudiooutputdevicescountApiLatest);
        return getaudiooutputdevicescountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_GetaudiooutputdevicescountApiLatest, (void*) &value);
      }
    }

    public static unsafe int RegisterplatformaudiouserApiLatest
    {
      get
      {
        int registerplatformaudiouserApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_RegisterplatformaudiouserApiLatest, (void*) &registerplatformaudiouserApiLatest);
        return registerplatformaudiouserApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_RegisterplatformaudiouserApiLatest, (void*) &value);
      }
    }

    public static unsafe int SendaudioApiLatest
    {
      get
      {
        int sendaudioApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_SendaudioApiLatest, (void*) &sendaudioApiLatest);
        return sendaudioApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_SendaudioApiLatest, (void*) &value);
      }
    }

    public static unsafe int SetaudioinputsettingsApiLatest
    {
      get
      {
        int setaudioinputsettingsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_SetaudioinputsettingsApiLatest, (void*) &setaudioinputsettingsApiLatest);
        return setaudioinputsettingsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_SetaudioinputsettingsApiLatest, (void*) &value);
      }
    }

    public static unsafe int SetaudiooutputsettingsApiLatest
    {
      get
      {
        int setaudiooutputsettingsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_SetaudiooutputsettingsApiLatest, (void*) &setaudiooutputsettingsApiLatest);
        return setaudiooutputsettingsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_SetaudiooutputsettingsApiLatest, (void*) &value);
      }
    }

    public static unsafe int UnregisterplatformaudiouserApiLatest
    {
      get
      {
        int unregisterplatformaudiouserApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_UnregisterplatformaudiouserApiLatest, (void*) &unregisterplatformaudiouserApiLatest);
        return unregisterplatformaudiouserApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_UnregisterplatformaudiouserApiLatest, (void*) &value);
      }
    }

    public static unsafe int UpdateparticipantvolumeApiLatest
    {
      get
      {
        int updateparticipantvolumeApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_UpdateparticipantvolumeApiLatest, (void*) &updateparticipantvolumeApiLatest);
        return updateparticipantvolumeApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_UpdateparticipantvolumeApiLatest, (void*) &value);
      }
    }

    public static unsafe int UpdatereceivingApiLatest
    {
      get
      {
        int updatereceivingApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_UpdatereceivingApiLatest, (void*) &updatereceivingApiLatest);
        return updatereceivingApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_UpdatereceivingApiLatest, (void*) &value);
      }
    }

    public static unsafe int UpdatereceivingvolumeApiLatest
    {
      get
      {
        int updatereceivingvolumeApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_UpdatereceivingvolumeApiLatest, (void*) &updatereceivingvolumeApiLatest);
        return updatereceivingvolumeApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_UpdatereceivingvolumeApiLatest, (void*) &value);
      }
    }

    public static unsafe int UpdatesendingApiLatest
    {
      get
      {
        int updatesendingApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_UpdatesendingApiLatest, (void*) &updatesendingApiLatest);
        return updatesendingApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_UpdatesendingApiLatest, (void*) &value);
      }
    }

    public static unsafe int UpdatesendingvolumeApiLatest
    {
      get
      {
        int updatesendingvolumeApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAudioInterface.NativeFieldInfoPtr_UpdatesendingvolumeApiLatest, (void*) &updatesendingvolumeApiLatest);
        return updatesendingvolumeApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAudioInterface.NativeFieldInfoPtr_UpdatesendingvolumeApiLatest, (void*) &value);
      }
    }
  }
}
