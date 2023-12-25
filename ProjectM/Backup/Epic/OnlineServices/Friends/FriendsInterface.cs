// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Friends.FriendsInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Friends
{
  public sealed class FriendsInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AcceptinviteApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyfriendsupdateApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetfriendatindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetfriendscountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetstatusApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryfriendsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_RejectinviteApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SendinviteApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AcceptInvite_Public_Void_byref_AcceptInviteOptions_Object_OnAcceptInviteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyFriendsUpdate_Public_UInt64_byref_AddNotifyFriendsUpdateOptions_Object_OnFriendsUpdateCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFriendAtIndex_Public_EpicAccountId_byref_GetFriendAtIndexOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFriendsCount_Public_Int32_byref_GetFriendsCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetStatus_Public_FriendsStatus_byref_GetStatusOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryFriends_Public_Void_byref_QueryFriendsOptions_Object_OnQueryFriendsCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RejectInvite_Public_Void_byref_RejectInviteOptions_Object_OnRejectInviteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyFriendsUpdate_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendInvite_Public_Void_byref_SendInviteOptions_Object_OnSendInviteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnAcceptInviteCallbackInternalImplementation_Internal_Static_Void_byref_AcceptInviteCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnFriendsUpdateCallbackInternalImplementation_Internal_Static_Void_byref_OnFriendsUpdateInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryFriendsCallbackInternalImplementation_Internal_Static_Void_byref_QueryFriendsCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnRejectInviteCallbackInternalImplementation_Internal_Static_Void_byref_RejectInviteCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnSendInviteCallbackInternalImplementation_Internal_Static_Void_byref_SendInviteCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FriendsInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960497, XrefRangeEnd = 960516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AcceptInvite(
      ref AcceptInviteOptions options,
      Il2CppSystem.Object clientData,
      OnAcceptInviteCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_AcceptInvite_Public_Void_byref_AcceptInviteOptions_Object_OnAcceptInviteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960516, XrefRangeEnd = 960536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyFriendsUpdate(
      ref AddNotifyFriendsUpdateOptions options,
      Il2CppSystem.Object clientData,
      OnFriendsUpdateCallback friendsUpdateHandler)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) friendsUpdateHandler);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_AddNotifyFriendsUpdate_Public_UInt64_byref_AddNotifyFriendsUpdateOptions_Object_OnFriendsUpdateCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960536, XrefRangeEnd = 960550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EpicAccountId GetFriendAtIndex(ref GetFriendAtIndexOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_GetFriendAtIndex_Public_EpicAccountId_byref_GetFriendAtIndexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (EpicAccountId) null : new EpicAccountId(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960550, XrefRangeEnd = 960561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetFriendsCount(ref GetFriendsCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_GetFriendsCount_Public_Int32_byref_GetFriendsCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960561, XrefRangeEnd = 960569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FriendsStatus GetStatus(ref GetStatusOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_GetStatus_Public_FriendsStatus_byref_GetStatusOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(FriendsStatus*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960569, XrefRangeEnd = 960588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryFriends(
      ref QueryFriendsOptions options,
      Il2CppSystem.Object clientData,
      OnQueryFriendsCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_QueryFriends_Public_Void_byref_QueryFriendsOptions_Object_OnQueryFriendsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960588, XrefRangeEnd = 960607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RejectInvite(
      ref RejectInviteOptions options,
      Il2CppSystem.Object clientData,
      OnRejectInviteCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_RejectInvite_Public_Void_byref_RejectInviteOptions_Object_OnRejectInviteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960607, XrefRangeEnd = 960612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyFriendsUpdate(ulong notificationId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &notificationId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_RemoveNotifyFriendsUpdate_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960612, XrefRangeEnd = 960631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendInvite(
      ref SendInviteOptions options,
      Il2CppSystem.Object clientData,
      OnSendInviteCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_SendInvite_Public_Void_byref_SendInviteOptions_Object_OnSendInviteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960631, XrefRangeEnd = 960638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnAcceptInviteCallbackInternalImplementation(
      ref AcceptInviteCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_OnAcceptInviteCallbackInternalImplementation_Internal_Static_Void_byref_AcceptInviteCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960638, XrefRangeEnd = 960645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnFriendsUpdateCallbackInternalImplementation(
      ref OnFriendsUpdateInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_OnFriendsUpdateCallbackInternalImplementation_Internal_Static_Void_byref_OnFriendsUpdateInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960645, XrefRangeEnd = 960652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryFriendsCallbackInternalImplementation(
      ref QueryFriendsCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_OnQueryFriendsCallbackInternalImplementation_Internal_Static_Void_byref_QueryFriendsCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960652, XrefRangeEnd = 960659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnRejectInviteCallbackInternalImplementation(
      ref RejectInviteCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_OnRejectInviteCallbackInternalImplementation_Internal_Static_Void_byref_RejectInviteCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960659, XrefRangeEnd = 960666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnSendInviteCallbackInternalImplementation(
      ref SendInviteCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FriendsInterface.NativeMethodInfoPtr_OnSendInviteCallbackInternalImplementation_Internal_Static_Void_byref_SendInviteCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FriendsInterface()
    {
      Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Friends", nameof (FriendsInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr);
      FriendsInterface.NativeFieldInfoPtr_AcceptinviteApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, nameof (AcceptinviteApiLatest));
      FriendsInterface.NativeFieldInfoPtr_AddnotifyfriendsupdateApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, nameof (AddnotifyfriendsupdateApiLatest));
      FriendsInterface.NativeFieldInfoPtr_GetfriendatindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, nameof (GetfriendatindexApiLatest));
      FriendsInterface.NativeFieldInfoPtr_GetfriendscountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, nameof (GetfriendscountApiLatest));
      FriendsInterface.NativeFieldInfoPtr_GetstatusApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, nameof (GetstatusApiLatest));
      FriendsInterface.NativeFieldInfoPtr_QueryfriendsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, nameof (QueryfriendsApiLatest));
      FriendsInterface.NativeFieldInfoPtr_RejectinviteApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, nameof (RejectinviteApiLatest));
      FriendsInterface.NativeFieldInfoPtr_SendinviteApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, nameof (SendinviteApiLatest));
      FriendsInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100671475);
      FriendsInterface.NativeMethodInfoPtr_AcceptInvite_Public_Void_byref_AcceptInviteOptions_Object_OnAcceptInviteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100671477);
      FriendsInterface.NativeMethodInfoPtr_AddNotifyFriendsUpdate_Public_UInt64_byref_AddNotifyFriendsUpdateOptions_Object_OnFriendsUpdateCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100671478);
      FriendsInterface.NativeMethodInfoPtr_GetFriendAtIndex_Public_EpicAccountId_byref_GetFriendAtIndexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100671479);
      FriendsInterface.NativeMethodInfoPtr_GetFriendsCount_Public_Int32_byref_GetFriendsCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100671480);
      FriendsInterface.NativeMethodInfoPtr_GetStatus_Public_FriendsStatus_byref_GetStatusOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100671481);
      FriendsInterface.NativeMethodInfoPtr_QueryFriends_Public_Void_byref_QueryFriendsOptions_Object_OnQueryFriendsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100671482);
      FriendsInterface.NativeMethodInfoPtr_RejectInvite_Public_Void_byref_RejectInviteOptions_Object_OnRejectInviteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100671483);
      FriendsInterface.NativeMethodInfoPtr_RemoveNotifyFriendsUpdate_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100671484);
      FriendsInterface.NativeMethodInfoPtr_SendInvite_Public_Void_byref_SendInviteOptions_Object_OnSendInviteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100671485);
      FriendsInterface.NativeMethodInfoPtr_OnAcceptInviteCallbackInternalImplementation_Internal_Static_Void_byref_AcceptInviteCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100671486);
      FriendsInterface.NativeMethodInfoPtr_OnFriendsUpdateCallbackInternalImplementation_Internal_Static_Void_byref_OnFriendsUpdateInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100671487);
      FriendsInterface.NativeMethodInfoPtr_OnQueryFriendsCallbackInternalImplementation_Internal_Static_Void_byref_QueryFriendsCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100671488);
      FriendsInterface.NativeMethodInfoPtr_OnRejectInviteCallbackInternalImplementation_Internal_Static_Void_byref_RejectInviteCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100671489);
      FriendsInterface.NativeMethodInfoPtr_OnSendInviteCallbackInternalImplementation_Internal_Static_Void_byref_SendInviteCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsInterface>.NativeClassPtr, 100671490);
    }

    public FriendsInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int AcceptinviteApiLatest
    {
      get
      {
        int acceptinviteApiLatest;
        IL2CPP.il2cpp_field_static_get_value(FriendsInterface.NativeFieldInfoPtr_AcceptinviteApiLatest, (void*) &acceptinviteApiLatest);
        return acceptinviteApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FriendsInterface.NativeFieldInfoPtr_AcceptinviteApiLatest, (void*) &value);
      }
    }

    public static unsafe int AddnotifyfriendsupdateApiLatest
    {
      get
      {
        int addnotifyfriendsupdateApiLatest;
        IL2CPP.il2cpp_field_static_get_value(FriendsInterface.NativeFieldInfoPtr_AddnotifyfriendsupdateApiLatest, (void*) &addnotifyfriendsupdateApiLatest);
        return addnotifyfriendsupdateApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FriendsInterface.NativeFieldInfoPtr_AddnotifyfriendsupdateApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetfriendatindexApiLatest
    {
      get
      {
        int getfriendatindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(FriendsInterface.NativeFieldInfoPtr_GetfriendatindexApiLatest, (void*) &getfriendatindexApiLatest);
        return getfriendatindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FriendsInterface.NativeFieldInfoPtr_GetfriendatindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetfriendscountApiLatest
    {
      get
      {
        int getfriendscountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(FriendsInterface.NativeFieldInfoPtr_GetfriendscountApiLatest, (void*) &getfriendscountApiLatest);
        return getfriendscountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FriendsInterface.NativeFieldInfoPtr_GetfriendscountApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetstatusApiLatest
    {
      get
      {
        int getstatusApiLatest;
        IL2CPP.il2cpp_field_static_get_value(FriendsInterface.NativeFieldInfoPtr_GetstatusApiLatest, (void*) &getstatusApiLatest);
        return getstatusApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FriendsInterface.NativeFieldInfoPtr_GetstatusApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryfriendsApiLatest
    {
      get
      {
        int queryfriendsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(FriendsInterface.NativeFieldInfoPtr_QueryfriendsApiLatest, (void*) &queryfriendsApiLatest);
        return queryfriendsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FriendsInterface.NativeFieldInfoPtr_QueryfriendsApiLatest, (void*) &value);
      }
    }

    public static unsafe int RejectinviteApiLatest
    {
      get
      {
        int rejectinviteApiLatest;
        IL2CPP.il2cpp_field_static_get_value(FriendsInterface.NativeFieldInfoPtr_RejectinviteApiLatest, (void*) &rejectinviteApiLatest);
        return rejectinviteApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FriendsInterface.NativeFieldInfoPtr_RejectinviteApiLatest, (void*) &value);
      }
    }

    public static unsafe int SendinviteApiLatest
    {
      get
      {
        int sendinviteApiLatest;
        IL2CPP.il2cpp_field_static_get_value(FriendsInterface.NativeFieldInfoPtr_SendinviteApiLatest, (void*) &sendinviteApiLatest);
        return sendinviteApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FriendsInterface.NativeFieldInfoPtr_SendinviteApiLatest, (void*) &value);
      }
    }
  }
}
