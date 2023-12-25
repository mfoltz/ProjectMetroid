// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Presence.PresenceInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Presence
{
  public sealed class PresenceInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyjoingameacceptedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyonpresencechangedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopypresenceApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreatepresencemodificationApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_DataMaxKeyLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_DataMaxKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr_DataMaxValueLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_DatarecordApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeletedataApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetjoininfoApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_HaspresenceApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_InfoApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_KeyPlatformPresence;
    private static readonly System.IntPtr NativeFieldInfoPtr_QuerypresenceApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_RichTextMaxValueLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetdataApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetpresenceApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetrawrichtextApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetstatusApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyJoinGameAccepted_Public_UInt64_byref_AddNotifyJoinGameAcceptedOptions_Object_OnJoinGameAcceptedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyOnPresenceChanged_Public_UInt64_byref_AddNotifyOnPresenceChangedOptions_Object_OnPresenceChangedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyPresence_Public_Result_byref_CopyPresenceOptions_byref_Nullable_1_Info_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreatePresenceModification_Public_Result_byref_CreatePresenceModificationOptions_byref_PresenceModification_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetJoinInfo_Public_Result_byref_GetJoinInfoOptions_byref_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasPresence_Public_Boolean_byref_HasPresenceOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryPresence_Public_Void_byref_QueryPresenceOptions_Object_OnQueryPresenceCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyJoinGameAccepted_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyOnPresenceChanged_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetPresence_Public_Void_byref_SetPresenceOptions_Object_SetPresenceCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnJoinGameAcceptedCallbackInternalImplementation_Internal_Static_Void_byref_JoinGameAcceptedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPresenceChangedCallbackInternalImplementation_Internal_Static_Void_byref_PresenceChangedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryPresenceCompleteCallbackInternalImplementation_Internal_Static_Void_byref_QueryPresenceCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetPresenceCompleteCallbackInternalImplementation_Internal_Static_Void_byref_SetPresenceCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PresenceInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948625, XrefRangeEnd = 948645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyJoinGameAccepted(
      ref AddNotifyJoinGameAcceptedOptions options,
      Il2CppSystem.Object clientData,
      OnJoinGameAcceptedCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_AddNotifyJoinGameAccepted_Public_UInt64_byref_AddNotifyJoinGameAcceptedOptions_Object_OnJoinGameAcceptedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948645, XrefRangeEnd = 948665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyOnPresenceChanged(
      ref AddNotifyOnPresenceChangedOptions options,
      Il2CppSystem.Object clientData,
      OnPresenceChangedCallback notificationHandler)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationHandler);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_AddNotifyOnPresenceChanged_Public_UInt64_byref_AddNotifyOnPresenceChangedOptions_Object_OnPresenceChangedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948665, XrefRangeEnd = 948679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyPresence(
      ref CopyPresenceOptions options,
      out Il2CppSystem.Nullable<Info> outPresence)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_CopyPresence_Public_Result_byref_CopyPresenceOptions_byref_Nullable_1_Info_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<Info> local = ref outPresence;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<Info>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948679, XrefRangeEnd = 948691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CreatePresenceModification(
      ref CreatePresenceModificationOptions options,
      out PresenceModification outPresenceModificationHandle)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_CreatePresenceModification_Public_Result_byref_CreatePresenceModificationOptions_byref_PresenceModification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref PresenceModification local = ref outPresenceModificationHandle;
      System.IntPtr pointer = zero;
      PresenceModification presenceModification = pointer == System.IntPtr.Zero ? (PresenceModification) null : new PresenceModification(pointer);
      local = presenceModification;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948691, XrefRangeEnd = 948702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result GetJoinInfo(ref GetJoinInfoOptions options, out Epic.OnlineServices.Utf8String outBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_GetJoinInfo_Public_Result_byref_GetJoinInfoOptions_byref_Utf8String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Epic.OnlineServices.Utf8String local = ref outBuffer;
      System.IntPtr pointer = zero;
      Epic.OnlineServices.Utf8String utf8String = pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      local = utf8String;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948702, XrefRangeEnd = 948711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasPresence(ref HasPresenceOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_HasPresence_Public_Boolean_byref_HasPresenceOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948711, XrefRangeEnd = 948730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryPresence(
      ref QueryPresenceOptions options,
      Il2CppSystem.Object clientData,
      OnQueryPresenceCompleteCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_QueryPresence_Public_Void_byref_QueryPresenceOptions_Object_OnQueryPresenceCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948730, XrefRangeEnd = 948735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyJoinGameAccepted(ulong inId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_RemoveNotifyJoinGameAccepted_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948735, XrefRangeEnd = 948740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyOnPresenceChanged(ulong notificationId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_RemoveNotifyOnPresenceChanged_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948740, XrefRangeEnd = 948759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetPresence(
      ref SetPresenceOptions options,
      Il2CppSystem.Object clientData,
      SetPresenceCompleteCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_SetPresence_Public_Void_byref_SetPresenceOptions_Object_SetPresenceCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948759, XrefRangeEnd = 948766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnJoinGameAcceptedCallbackInternalImplementation(
      ref JoinGameAcceptedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_OnJoinGameAcceptedCallbackInternalImplementation_Internal_Static_Void_byref_JoinGameAcceptedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948766, XrefRangeEnd = 948773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnPresenceChangedCallbackInternalImplementation(
      ref PresenceChangedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_OnPresenceChangedCallbackInternalImplementation_Internal_Static_Void_byref_PresenceChangedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948773, XrefRangeEnd = 948780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryPresenceCompleteCallbackInternalImplementation(
      ref QueryPresenceCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_OnQueryPresenceCompleteCallbackInternalImplementation_Internal_Static_Void_byref_QueryPresenceCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948780, XrefRangeEnd = 948787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetPresenceCompleteCallbackInternalImplementation(
      ref SetPresenceCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PresenceInterface.NativeMethodInfoPtr_SetPresenceCompleteCallbackInternalImplementation_Internal_Static_Void_byref_SetPresenceCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PresenceInterface()
    {
      Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Presence", nameof (PresenceInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr);
      PresenceInterface.NativeFieldInfoPtr_AddnotifyjoingameacceptedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (AddnotifyjoingameacceptedApiLatest));
      PresenceInterface.NativeFieldInfoPtr_AddnotifyonpresencechangedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (AddnotifyonpresencechangedApiLatest));
      PresenceInterface.NativeFieldInfoPtr_CopypresenceApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (CopypresenceApiLatest));
      PresenceInterface.NativeFieldInfoPtr_CreatepresencemodificationApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (CreatepresencemodificationApiLatest));
      PresenceInterface.NativeFieldInfoPtr_DataMaxKeyLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (DataMaxKeyLength));
      PresenceInterface.NativeFieldInfoPtr_DataMaxKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (DataMaxKeys));
      PresenceInterface.NativeFieldInfoPtr_DataMaxValueLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (DataMaxValueLength));
      PresenceInterface.NativeFieldInfoPtr_DatarecordApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (DatarecordApiLatest));
      PresenceInterface.NativeFieldInfoPtr_DeletedataApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (DeletedataApiLatest));
      PresenceInterface.NativeFieldInfoPtr_GetjoininfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (GetjoininfoApiLatest));
      PresenceInterface.NativeFieldInfoPtr_HaspresenceApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (HaspresenceApiLatest));
      PresenceInterface.NativeFieldInfoPtr_InfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (InfoApiLatest));
      PresenceInterface.NativeFieldInfoPtr_KeyPlatformPresence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (KeyPlatformPresence));
      PresenceInterface.NativeFieldInfoPtr_QuerypresenceApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (QuerypresenceApiLatest));
      PresenceInterface.NativeFieldInfoPtr_RichTextMaxValueLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (RichTextMaxValueLength));
      PresenceInterface.NativeFieldInfoPtr_SetdataApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (SetdataApiLatest));
      PresenceInterface.NativeFieldInfoPtr_SetpresenceApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (SetpresenceApiLatest));
      PresenceInterface.NativeFieldInfoPtr_SetrawrichtextApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (SetrawrichtextApiLatest));
      PresenceInterface.NativeFieldInfoPtr_SetstatusApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, nameof (SetstatusApiLatest));
      PresenceInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100668232);
      PresenceInterface.NativeMethodInfoPtr_AddNotifyJoinGameAccepted_Public_UInt64_byref_AddNotifyJoinGameAcceptedOptions_Object_OnJoinGameAcceptedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100668234);
      PresenceInterface.NativeMethodInfoPtr_AddNotifyOnPresenceChanged_Public_UInt64_byref_AddNotifyOnPresenceChangedOptions_Object_OnPresenceChangedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100668235);
      PresenceInterface.NativeMethodInfoPtr_CopyPresence_Public_Result_byref_CopyPresenceOptions_byref_Nullable_1_Info_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100668236);
      PresenceInterface.NativeMethodInfoPtr_CreatePresenceModification_Public_Result_byref_CreatePresenceModificationOptions_byref_PresenceModification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100668237);
      PresenceInterface.NativeMethodInfoPtr_GetJoinInfo_Public_Result_byref_GetJoinInfoOptions_byref_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100668238);
      PresenceInterface.NativeMethodInfoPtr_HasPresence_Public_Boolean_byref_HasPresenceOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100668239);
      PresenceInterface.NativeMethodInfoPtr_QueryPresence_Public_Void_byref_QueryPresenceOptions_Object_OnQueryPresenceCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100668240);
      PresenceInterface.NativeMethodInfoPtr_RemoveNotifyJoinGameAccepted_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100668241);
      PresenceInterface.NativeMethodInfoPtr_RemoveNotifyOnPresenceChanged_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100668242);
      PresenceInterface.NativeMethodInfoPtr_SetPresence_Public_Void_byref_SetPresenceOptions_Object_SetPresenceCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100668243);
      PresenceInterface.NativeMethodInfoPtr_OnJoinGameAcceptedCallbackInternalImplementation_Internal_Static_Void_byref_JoinGameAcceptedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100668244);
      PresenceInterface.NativeMethodInfoPtr_OnPresenceChangedCallbackInternalImplementation_Internal_Static_Void_byref_PresenceChangedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100668245);
      PresenceInterface.NativeMethodInfoPtr_OnQueryPresenceCompleteCallbackInternalImplementation_Internal_Static_Void_byref_QueryPresenceCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100668246);
      PresenceInterface.NativeMethodInfoPtr_SetPresenceCompleteCallbackInternalImplementation_Internal_Static_Void_byref_SetPresenceCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceInterface>.NativeClassPtr, 100668247);
    }

    public PresenceInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int AddnotifyjoingameacceptedApiLatest
    {
      get
      {
        int addnotifyjoingameacceptedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_AddnotifyjoingameacceptedApiLatest, (void*) &addnotifyjoingameacceptedApiLatest);
        return addnotifyjoingameacceptedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_AddnotifyjoingameacceptedApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifyonpresencechangedApiLatest
    {
      get
      {
        int addnotifyonpresencechangedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_AddnotifyonpresencechangedApiLatest, (void*) &addnotifyonpresencechangedApiLatest);
        return addnotifyonpresencechangedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_AddnotifyonpresencechangedApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopypresenceApiLatest
    {
      get
      {
        int copypresenceApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_CopypresenceApiLatest, (void*) &copypresenceApiLatest);
        return copypresenceApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_CopypresenceApiLatest, (void*) &value);
      }
    }

    public static unsafe int CreatepresencemodificationApiLatest
    {
      get
      {
        int createpresencemodificationApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_CreatepresencemodificationApiLatest, (void*) &createpresencemodificationApiLatest);
        return createpresencemodificationApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_CreatepresencemodificationApiLatest, (void*) &value);
      }
    }

    public static unsafe int DataMaxKeyLength
    {
      get
      {
        int dataMaxKeyLength;
        IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_DataMaxKeyLength, (void*) &dataMaxKeyLength);
        return dataMaxKeyLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_DataMaxKeyLength, (void*) &value);
      }
    }

    public static unsafe int DataMaxKeys
    {
      get
      {
        int dataMaxKeys;
        IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_DataMaxKeys, (void*) &dataMaxKeys);
        return dataMaxKeys;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_DataMaxKeys, (void*) &value);
      }
    }

    public static unsafe int DataMaxValueLength
    {
      get
      {
        int dataMaxValueLength;
        IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_DataMaxValueLength, (void*) &dataMaxValueLength);
        return dataMaxValueLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_DataMaxValueLength, (void*) &value);
      }
    }

    public static unsafe int DatarecordApiLatest
    {
      get
      {
        int datarecordApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_DatarecordApiLatest, (void*) &datarecordApiLatest);
        return datarecordApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_DatarecordApiLatest, (void*) &value);
      }
    }

    public static unsafe int DeletedataApiLatest
    {
      get
      {
        int deletedataApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_DeletedataApiLatest, (void*) &deletedataApiLatest);
        return deletedataApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_DeletedataApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetjoininfoApiLatest
    {
      get
      {
        int getjoininfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_GetjoininfoApiLatest, (void*) &getjoininfoApiLatest);
        return getjoininfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_GetjoininfoApiLatest, (void*) &value);
      }
    }

    public static unsafe int HaspresenceApiLatest
    {
      get
      {
        int haspresenceApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_HaspresenceApiLatest, (void*) &haspresenceApiLatest);
        return haspresenceApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_HaspresenceApiLatest, (void*) &value);
      }
    }

    public static unsafe int InfoApiLatest
    {
      get
      {
        int infoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_InfoApiLatest, (void*) &infoApiLatest);
        return infoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_InfoApiLatest, (void*) &value);
      }
    }

    public static unsafe Epic.OnlineServices.Utf8String KeyPlatformPresence
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_KeyPlatformPresence, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_KeyPlatformPresence, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe int QuerypresenceApiLatest
    {
      get
      {
        int querypresenceApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_QuerypresenceApiLatest, (void*) &querypresenceApiLatest);
        return querypresenceApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_QuerypresenceApiLatest, (void*) &value);
      }
    }

    public static unsafe int RichTextMaxValueLength
    {
      get
      {
        int textMaxValueLength;
        IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_RichTextMaxValueLength, (void*) &textMaxValueLength);
        return textMaxValueLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_RichTextMaxValueLength, (void*) &value);
      }
    }

    public static unsafe int SetdataApiLatest
    {
      get
      {
        int setdataApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_SetdataApiLatest, (void*) &setdataApiLatest);
        return setdataApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_SetdataApiLatest, (void*) &value);
      }
    }

    public static unsafe int SetpresenceApiLatest
    {
      get
      {
        int setpresenceApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_SetpresenceApiLatest, (void*) &setpresenceApiLatest);
        return setpresenceApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_SetpresenceApiLatest, (void*) &value);
      }
    }

    public static unsafe int SetrawrichtextApiLatest
    {
      get
      {
        int setrawrichtextApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_SetrawrichtextApiLatest, (void*) &setrawrichtextApiLatest);
        return setrawrichtextApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_SetrawrichtextApiLatest, (void*) &value);
      }
    }

    public static unsafe int SetstatusApiLatest
    {
      get
      {
        int setstatusApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PresenceInterface.NativeFieldInfoPtr_SetstatusApiLatest, (void*) &setstatusApiLatest);
        return setstatusApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PresenceInterface.NativeFieldInfoPtr_SetstatusApiLatest, (void*) &value);
      }
    }
  }
}
