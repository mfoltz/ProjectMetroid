// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.CustomInvites.CustomInvitesInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.CustomInvites
{
  public sealed class CustomInvitesInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifycustominviteacceptedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifycustominvitereceivedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifycustominviterejectedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_FinalizeinviteApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxPayloadLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_SendcustominviteApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetcustominviteApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyCustomInviteAccepted_Public_UInt64_byref_AddNotifyCustomInviteAcceptedOptions_Object_OnCustomInviteAcceptedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyCustomInviteReceived_Public_UInt64_byref_AddNotifyCustomInviteReceivedOptions_Object_OnCustomInviteReceivedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyCustomInviteRejected_Public_UInt64_byref_AddNotifyCustomInviteRejectedOptions_Object_OnCustomInviteRejectedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeInvite_Public_Result_byref_FinalizeInviteOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyCustomInviteAccepted_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyCustomInviteReceived_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyCustomInviteRejected_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendCustomInvite_Public_Void_byref_SendCustomInviteOptions_Object_OnSendCustomInviteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetCustomInvite_Public_Result_byref_SetCustomInviteOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCustomInviteAcceptedCallbackInternalImplementation_Internal_Static_Void_byref_OnCustomInviteAcceptedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCustomInviteReceivedCallbackInternalImplementation_Internal_Static_Void_byref_OnCustomInviteReceivedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCustomInviteRejectedCallbackInternalImplementation_Internal_Static_Void_byref_CustomInviteRejectedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnSendCustomInviteCallbackInternalImplementation_Internal_Static_Void_byref_SendCustomInviteCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CustomInvitesInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964072, XrefRangeEnd = 964092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyCustomInviteAccepted(
      ref AddNotifyCustomInviteAcceptedOptions options,
      Il2CppSystem.Object clientData,
      OnCustomInviteAcceptedCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr_AddNotifyCustomInviteAccepted_Public_UInt64_byref_AddNotifyCustomInviteAcceptedOptions_Object_OnCustomInviteAcceptedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964092, XrefRangeEnd = 964112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyCustomInviteReceived(
      ref AddNotifyCustomInviteReceivedOptions options,
      Il2CppSystem.Object clientData,
      OnCustomInviteReceivedCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr_AddNotifyCustomInviteReceived_Public_UInt64_byref_AddNotifyCustomInviteReceivedOptions_Object_OnCustomInviteReceivedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964112, XrefRangeEnd = 964132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyCustomInviteRejected(
      ref AddNotifyCustomInviteRejectedOptions options,
      Il2CppSystem.Object clientData,
      OnCustomInviteRejectedCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr_AddNotifyCustomInviteRejected_Public_UInt64_byref_AddNotifyCustomInviteRejectedOptions_Object_OnCustomInviteRejectedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964132, XrefRangeEnd = 964140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result FinalizeInvite(ref FinalizeInviteOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr_FinalizeInvite_Public_Result_byref_FinalizeInviteOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964140, XrefRangeEnd = 964145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyCustomInviteAccepted(ulong inId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr_RemoveNotifyCustomInviteAccepted_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964145, XrefRangeEnd = 964150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyCustomInviteReceived(ulong inId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr_RemoveNotifyCustomInviteReceived_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964150, XrefRangeEnd = 964155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyCustomInviteRejected(ulong inId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr_RemoveNotifyCustomInviteRejected_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964155, XrefRangeEnd = 964174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendCustomInvite(
      ref SendCustomInviteOptions options,
      Il2CppSystem.Object clientData,
      OnSendCustomInviteCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr_SendCustomInvite_Public_Void_byref_SendCustomInviteOptions_Object_OnSendCustomInviteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964174, XrefRangeEnd = 964182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result SetCustomInvite(ref SetCustomInviteOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr_SetCustomInvite_Public_Result_byref_SetCustomInviteOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964182, XrefRangeEnd = 964189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnCustomInviteAcceptedCallbackInternalImplementation(
      ref OnCustomInviteAcceptedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr_OnCustomInviteAcceptedCallbackInternalImplementation_Internal_Static_Void_byref_OnCustomInviteAcceptedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964189, XrefRangeEnd = 964196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnCustomInviteReceivedCallbackInternalImplementation(
      ref OnCustomInviteReceivedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr_OnCustomInviteReceivedCallbackInternalImplementation_Internal_Static_Void_byref_OnCustomInviteReceivedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964196, XrefRangeEnd = 964203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnCustomInviteRejectedCallbackInternalImplementation(
      ref CustomInviteRejectedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr_OnCustomInviteRejectedCallbackInternalImplementation_Internal_Static_Void_byref_CustomInviteRejectedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964203, XrefRangeEnd = 964210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnSendCustomInviteCallbackInternalImplementation(
      ref SendCustomInviteCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr_OnSendCustomInviteCallbackInternalImplementation_Internal_Static_Void_byref_SendCustomInviteCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CustomInvitesInterface()
    {
      Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.CustomInvites", nameof (CustomInvitesInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr);
      CustomInvitesInterface.NativeFieldInfoPtr_AddnotifycustominviteacceptedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, nameof (AddnotifycustominviteacceptedApiLatest));
      CustomInvitesInterface.NativeFieldInfoPtr_AddnotifycustominvitereceivedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, nameof (AddnotifycustominvitereceivedApiLatest));
      CustomInvitesInterface.NativeFieldInfoPtr_AddnotifycustominviterejectedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, nameof (AddnotifycustominviterejectedApiLatest));
      CustomInvitesInterface.NativeFieldInfoPtr_FinalizeinviteApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, nameof (FinalizeinviteApiLatest));
      CustomInvitesInterface.NativeFieldInfoPtr_MaxPayloadLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, nameof (MaxPayloadLength));
      CustomInvitesInterface.NativeFieldInfoPtr_SendcustominviteApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, nameof (SendcustominviteApiLatest));
      CustomInvitesInterface.NativeFieldInfoPtr_SetcustominviteApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, nameof (SetcustominviteApiLatest));
      CustomInvitesInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100672468);
      CustomInvitesInterface.NativeMethodInfoPtr_AddNotifyCustomInviteAccepted_Public_UInt64_byref_AddNotifyCustomInviteAcceptedOptions_Object_OnCustomInviteAcceptedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100672470);
      CustomInvitesInterface.NativeMethodInfoPtr_AddNotifyCustomInviteReceived_Public_UInt64_byref_AddNotifyCustomInviteReceivedOptions_Object_OnCustomInviteReceivedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100672471);
      CustomInvitesInterface.NativeMethodInfoPtr_AddNotifyCustomInviteRejected_Public_UInt64_byref_AddNotifyCustomInviteRejectedOptions_Object_OnCustomInviteRejectedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100672472);
      CustomInvitesInterface.NativeMethodInfoPtr_FinalizeInvite_Public_Result_byref_FinalizeInviteOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100672473);
      CustomInvitesInterface.NativeMethodInfoPtr_RemoveNotifyCustomInviteAccepted_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100672474);
      CustomInvitesInterface.NativeMethodInfoPtr_RemoveNotifyCustomInviteReceived_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100672475);
      CustomInvitesInterface.NativeMethodInfoPtr_RemoveNotifyCustomInviteRejected_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100672476);
      CustomInvitesInterface.NativeMethodInfoPtr_SendCustomInvite_Public_Void_byref_SendCustomInviteOptions_Object_OnSendCustomInviteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100672477);
      CustomInvitesInterface.NativeMethodInfoPtr_SetCustomInvite_Public_Result_byref_SetCustomInviteOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100672478);
      CustomInvitesInterface.NativeMethodInfoPtr_OnCustomInviteAcceptedCallbackInternalImplementation_Internal_Static_Void_byref_OnCustomInviteAcceptedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100672479);
      CustomInvitesInterface.NativeMethodInfoPtr_OnCustomInviteReceivedCallbackInternalImplementation_Internal_Static_Void_byref_OnCustomInviteReceivedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100672480);
      CustomInvitesInterface.NativeMethodInfoPtr_OnCustomInviteRejectedCallbackInternalImplementation_Internal_Static_Void_byref_CustomInviteRejectedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100672481);
      CustomInvitesInterface.NativeMethodInfoPtr_OnSendCustomInviteCallbackInternalImplementation_Internal_Static_Void_byref_SendCustomInviteCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100672482);
    }

    public CustomInvitesInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int AddnotifycustominviteacceptedApiLatest
    {
      get
      {
        int addnotifycustominviteacceptedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(CustomInvitesInterface.NativeFieldInfoPtr_AddnotifycustominviteacceptedApiLatest, (void*) &addnotifycustominviteacceptedApiLatest);
        return addnotifycustominviteacceptedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CustomInvitesInterface.NativeFieldInfoPtr_AddnotifycustominviteacceptedApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifycustominvitereceivedApiLatest
    {
      get
      {
        int addnotifycustominvitereceivedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(CustomInvitesInterface.NativeFieldInfoPtr_AddnotifycustominvitereceivedApiLatest, (void*) &addnotifycustominvitereceivedApiLatest);
        return addnotifycustominvitereceivedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CustomInvitesInterface.NativeFieldInfoPtr_AddnotifycustominvitereceivedApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifycustominviterejectedApiLatest
    {
      get
      {
        int addnotifycustominviterejectedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(CustomInvitesInterface.NativeFieldInfoPtr_AddnotifycustominviterejectedApiLatest, (void*) &addnotifycustominviterejectedApiLatest);
        return addnotifycustominviterejectedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CustomInvitesInterface.NativeFieldInfoPtr_AddnotifycustominviterejectedApiLatest, (void*) &value);
      }
    }

    public static unsafe int FinalizeinviteApiLatest
    {
      get
      {
        int finalizeinviteApiLatest;
        IL2CPP.il2cpp_field_static_get_value(CustomInvitesInterface.NativeFieldInfoPtr_FinalizeinviteApiLatest, (void*) &finalizeinviteApiLatest);
        return finalizeinviteApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CustomInvitesInterface.NativeFieldInfoPtr_FinalizeinviteApiLatest, (void*) &value);
      }
    }

    public static unsafe int MaxPayloadLength
    {
      get
      {
        int maxPayloadLength;
        IL2CPP.il2cpp_field_static_get_value(CustomInvitesInterface.NativeFieldInfoPtr_MaxPayloadLength, (void*) &maxPayloadLength);
        return maxPayloadLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CustomInvitesInterface.NativeFieldInfoPtr_MaxPayloadLength, (void*) &value);
      }
    }

    public static unsafe int SendcustominviteApiLatest
    {
      get
      {
        int sendcustominviteApiLatest;
        IL2CPP.il2cpp_field_static_get_value(CustomInvitesInterface.NativeFieldInfoPtr_SendcustominviteApiLatest, (void*) &sendcustominviteApiLatest);
        return sendcustominviteApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CustomInvitesInterface.NativeFieldInfoPtr_SendcustominviteApiLatest, (void*) &value);
      }
    }

    public static unsafe int SetcustominviteApiLatest
    {
      get
      {
        int setcustominviteApiLatest;
        IL2CPP.il2cpp_field_static_get_value(CustomInvitesInterface.NativeFieldInfoPtr_SetcustominviteApiLatest, (void*) &setcustominviteApiLatest);
        return setcustominviteApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CustomInvitesInterface.NativeFieldInfoPtr_SetcustominviteApiLatest, (void*) &value);
      }
    }
  }
}
