// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAdmin.RTCAdminInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTCAdmin
{
  public sealed class RTCAdminInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyusertokenbyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyusertokenbyuseridApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_KickApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryjoinroomtokenApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetparticipanthardmuteApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_UsertokenApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyUserTokenByIndex_Public_Result_byref_CopyUserTokenByIndexOptions_byref_Nullable_1_UserToken_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyUserTokenByUserId_Public_Result_byref_CopyUserTokenByUserIdOptions_byref_Nullable_1_UserToken_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Kick_Public_Void_byref_KickOptions_Object_OnKickCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryJoinRoomToken_Public_Void_byref_QueryJoinRoomTokenOptions_Object_OnQueryJoinRoomTokenCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetParticipantHardMute_Public_Void_byref_SetParticipantHardMuteOptions_Object_OnSetParticipantHardMuteCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnKickCompleteCallbackInternalImplementation_Internal_Static_Void_byref_KickCompleteCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryJoinRoomTokenCompleteCallbackInternalImplementation_Internal_Static_Void_byref_QueryJoinRoomTokenCompleteCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnSetParticipantHardMuteCompleteCallbackInternalImplementation_Internal_Static_Void_byref_SetParticipantHardMuteCompleteCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RTCAdminInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAdminInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946325, XrefRangeEnd = 946339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyUserTokenByIndex(
      ref CopyUserTokenByIndexOptions options,
      out Il2CppSystem.Nullable<UserToken> outUserToken)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) ref options;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCAdminInterface.NativeMethodInfoPtr_CopyUserTokenByIndex_Public_Result_byref_CopyUserTokenByIndexOptions_byref_Nullable_1_UserToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<UserToken> local = ref outUserToken;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<UserToken>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946339, XrefRangeEnd = 946353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyUserTokenByUserId(
      ref CopyUserTokenByUserIdOptions options,
      out Il2CppSystem.Nullable<UserToken> outUserToken)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCAdminInterface.NativeMethodInfoPtr_CopyUserTokenByUserId_Public_Result_byref_CopyUserTokenByUserIdOptions_byref_Nullable_1_UserToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<UserToken> local = ref outUserToken;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<UserToken>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946353, XrefRangeEnd = 946372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Kick(
      ref KickOptions options,
      Il2CppSystem.Object clientData,
      OnKickCompleteCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAdminInterface.NativeMethodInfoPtr_Kick_Public_Void_byref_KickOptions_Object_OnKickCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946372, XrefRangeEnd = 946391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryJoinRoomToken(
      ref QueryJoinRoomTokenOptions options,
      Il2CppSystem.Object clientData,
      OnQueryJoinRoomTokenCompleteCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAdminInterface.NativeMethodInfoPtr_QueryJoinRoomToken_Public_Void_byref_QueryJoinRoomTokenOptions_Object_OnQueryJoinRoomTokenCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946391, XrefRangeEnd = 946410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetParticipantHardMute(
      ref SetParticipantHardMuteOptions options,
      Il2CppSystem.Object clientData,
      OnSetParticipantHardMuteCompleteCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAdminInterface.NativeMethodInfoPtr_SetParticipantHardMute_Public_Void_byref_SetParticipantHardMuteOptions_Object_OnSetParticipantHardMuteCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946410, XrefRangeEnd = 946417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnKickCompleteCallbackInternalImplementation(
      ref KickCompleteCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAdminInterface.NativeMethodInfoPtr_OnKickCompleteCallbackInternalImplementation_Internal_Static_Void_byref_KickCompleteCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946417, XrefRangeEnd = 946424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryJoinRoomTokenCompleteCallbackInternalImplementation(
      ref QueryJoinRoomTokenCompleteCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAdminInterface.NativeMethodInfoPtr_OnQueryJoinRoomTokenCompleteCallbackInternalImplementation_Internal_Static_Void_byref_QueryJoinRoomTokenCompleteCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946424, XrefRangeEnd = 946431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnSetParticipantHardMuteCompleteCallbackInternalImplementation(
      ref SetParticipantHardMuteCompleteCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCAdminInterface.NativeMethodInfoPtr_OnSetParticipantHardMuteCompleteCallbackInternalImplementation_Internal_Static_Void_byref_SetParticipantHardMuteCompleteCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RTCAdminInterface()
    {
      Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.RTCAdmin", nameof (RTCAdminInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr);
      RTCAdminInterface.NativeFieldInfoPtr_CopyusertokenbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, nameof (CopyusertokenbyindexApiLatest));
      RTCAdminInterface.NativeFieldInfoPtr_CopyusertokenbyuseridApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, nameof (CopyusertokenbyuseridApiLatest));
      RTCAdminInterface.NativeFieldInfoPtr_KickApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, nameof (KickApiLatest));
      RTCAdminInterface.NativeFieldInfoPtr_QueryjoinroomtokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, nameof (QueryjoinroomtokenApiLatest));
      RTCAdminInterface.NativeFieldInfoPtr_SetparticipanthardmuteApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, nameof (SetparticipanthardmuteApiLatest));
      RTCAdminInterface.NativeFieldInfoPtr_UsertokenApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, nameof (UsertokenApiLatest));
      RTCAdminInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, 100667622);
      RTCAdminInterface.NativeMethodInfoPtr_CopyUserTokenByIndex_Public_Result_byref_CopyUserTokenByIndexOptions_byref_Nullable_1_UserToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, 100667624);
      RTCAdminInterface.NativeMethodInfoPtr_CopyUserTokenByUserId_Public_Result_byref_CopyUserTokenByUserIdOptions_byref_Nullable_1_UserToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, 100667625);
      RTCAdminInterface.NativeMethodInfoPtr_Kick_Public_Void_byref_KickOptions_Object_OnKickCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, 100667626);
      RTCAdminInterface.NativeMethodInfoPtr_QueryJoinRoomToken_Public_Void_byref_QueryJoinRoomTokenOptions_Object_OnQueryJoinRoomTokenCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, 100667627);
      RTCAdminInterface.NativeMethodInfoPtr_SetParticipantHardMute_Public_Void_byref_SetParticipantHardMuteOptions_Object_OnSetParticipantHardMuteCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, 100667628);
      RTCAdminInterface.NativeMethodInfoPtr_OnKickCompleteCallbackInternalImplementation_Internal_Static_Void_byref_KickCompleteCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, 100667629);
      RTCAdminInterface.NativeMethodInfoPtr_OnQueryJoinRoomTokenCompleteCallbackInternalImplementation_Internal_Static_Void_byref_QueryJoinRoomTokenCompleteCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, 100667630);
      RTCAdminInterface.NativeMethodInfoPtr_OnSetParticipantHardMuteCompleteCallbackInternalImplementation_Internal_Static_Void_byref_SetParticipantHardMuteCompleteCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCAdminInterface>.NativeClassPtr, 100667631);
    }

    public RTCAdminInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int CopyusertokenbyindexApiLatest
    {
      get
      {
        int copyusertokenbyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAdminInterface.NativeFieldInfoPtr_CopyusertokenbyindexApiLatest, (void*) &copyusertokenbyindexApiLatest);
        return copyusertokenbyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAdminInterface.NativeFieldInfoPtr_CopyusertokenbyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyusertokenbyuseridApiLatest
    {
      get
      {
        int copyusertokenbyuseridApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAdminInterface.NativeFieldInfoPtr_CopyusertokenbyuseridApiLatest, (void*) &copyusertokenbyuseridApiLatest);
        return copyusertokenbyuseridApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAdminInterface.NativeFieldInfoPtr_CopyusertokenbyuseridApiLatest, (void*) &value);
      }
    }

    public static unsafe int KickApiLatest
    {
      get
      {
        int kickApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAdminInterface.NativeFieldInfoPtr_KickApiLatest, (void*) &kickApiLatest);
        return kickApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAdminInterface.NativeFieldInfoPtr_KickApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryjoinroomtokenApiLatest
    {
      get
      {
        int queryjoinroomtokenApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAdminInterface.NativeFieldInfoPtr_QueryjoinroomtokenApiLatest, (void*) &queryjoinroomtokenApiLatest);
        return queryjoinroomtokenApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAdminInterface.NativeFieldInfoPtr_QueryjoinroomtokenApiLatest, (void*) &value);
      }
    }

    public static unsafe int SetparticipanthardmuteApiLatest
    {
      get
      {
        int setparticipanthardmuteApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAdminInterface.NativeFieldInfoPtr_SetparticipanthardmuteApiLatest, (void*) &setparticipanthardmuteApiLatest);
        return setparticipanthardmuteApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAdminInterface.NativeFieldInfoPtr_SetparticipanthardmuteApiLatest, (void*) &value);
      }
    }

    public static unsafe int UsertokenApiLatest
    {
      get
      {
        int usertokenApiLatest;
        IL2CPP.il2cpp_field_static_get_value(RTCAdminInterface.NativeFieldInfoPtr_UsertokenApiLatest, (void*) &usertokenApiLatest);
        return usertokenApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RTCAdminInterface.NativeFieldInfoPtr_UsertokenApiLatest, (void*) &value);
      }
    }
  }
}
