﻿// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Friends.SendInviteCallbackInfoInternal
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
  [StructLayout(LayoutKind.Explicit)]
  public struct SendInviteCallbackInfoInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ResultCode;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetUserId;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ResultCode_Public_set_Void_Result_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetUserId_Public_get_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SendInviteCallbackInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_SendInviteCallbackInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_SendInviteCallbackInfo_0;
    [FieldOffset(0)]
    public Result m_ResultCode;
    [FieldOffset(8)]
    public System.IntPtr m_ClientData;
    [FieldOffset(16)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(24)]
    public System.IntPtr m_TargetUserId;

    public unsafe Result ResultCode
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SendInviteCallbackInfoInternal.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Result*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SendInviteCallbackInfoInternal.NativeMethodInfoPtr_set_ResultCode_Public_set_Void_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppSystem.Object ClientData
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961081, XrefRangeEnd = 961085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SendInviteCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961085, XrefRangeEnd = 961089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SendInviteCallbackInfoInternal.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public virtual unsafe System.IntPtr ClientDataAddress
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SendInviteCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe EpicAccountId LocalUserId
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 961095, RefRangeEnd = 961096, XrefRangeStart = 961089, XrefRangeEnd = 961095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SendInviteCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (EpicAccountId) null : new EpicAccountId(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961096, XrefRangeEnd = 961100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SendInviteCallbackInfoInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe EpicAccountId TargetUserId
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 961106, RefRangeEnd = 961107, XrefRangeStart = 961100, XrefRangeEnd = 961106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SendInviteCallbackInfoInternal.NativeMethodInfoPtr_get_TargetUserId_Public_get_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (EpicAccountId) null : new EpicAccountId(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961107, XrefRangeEnd = 961111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SendInviteCallbackInfoInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961111, XrefRangeEnd = 961123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref SendInviteCallbackInfo other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SendInviteCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SendInviteCallbackInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961123, XrefRangeEnd = 961145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<SendInviteCallbackInfo> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SendInviteCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_SendInviteCallbackInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961145, XrefRangeEnd = 961151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SendInviteCallbackInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 961151, XrefRangeEnd = 961152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out SendInviteCallbackInfo output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SendInviteCallbackInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_SendInviteCallbackInfo_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref SendInviteCallbackInfo local = ref output;
      System.IntPtr pointer = zero;
      SendInviteCallbackInfo inviteCallbackInfo = pointer == System.IntPtr.Zero ? (SendInviteCallbackInfo) null : new SendInviteCallbackInfo(pointer);
      local = inviteCallbackInfo;
    }

    static SendInviteCallbackInfoInternal()
    {
      Il2CppClassPointerStore<SendInviteCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Friends", nameof (SendInviteCallbackInfoInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendInviteCallbackInfoInternal>.NativeClassPtr);
      SendInviteCallbackInfoInternal.NativeFieldInfoPtr_m_ResultCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendInviteCallbackInfoInternal>.NativeClassPtr, nameof (m_ResultCode));
      SendInviteCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendInviteCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
      SendInviteCallbackInfoInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendInviteCallbackInfoInternal>.NativeClassPtr, nameof (m_LocalUserId));
      SendInviteCallbackInfoInternal.NativeFieldInfoPtr_m_TargetUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendInviteCallbackInfoInternal>.NativeClassPtr, nameof (m_TargetUserId));
      SendInviteCallbackInfoInternal.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInviteCallbackInfoInternal>.NativeClassPtr, 100671649);
      SendInviteCallbackInfoInternal.NativeMethodInfoPtr_set_ResultCode_Public_set_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInviteCallbackInfoInternal>.NativeClassPtr, 100671650);
      SendInviteCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInviteCallbackInfoInternal>.NativeClassPtr, 100671651);
      SendInviteCallbackInfoInternal.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInviteCallbackInfoInternal>.NativeClassPtr, 100671652);
      SendInviteCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInviteCallbackInfoInternal>.NativeClassPtr, 100671653);
      SendInviteCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInviteCallbackInfoInternal>.NativeClassPtr, 100671654);
      SendInviteCallbackInfoInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInviteCallbackInfoInternal>.NativeClassPtr, 100671655);
      SendInviteCallbackInfoInternal.NativeMethodInfoPtr_get_TargetUserId_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInviteCallbackInfoInternal>.NativeClassPtr, 100671656);
      SendInviteCallbackInfoInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInviteCallbackInfoInternal>.NativeClassPtr, 100671657);
      SendInviteCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SendInviteCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInviteCallbackInfoInternal>.NativeClassPtr, 100671658);
      SendInviteCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_SendInviteCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInviteCallbackInfoInternal>.NativeClassPtr, 100671659);
      SendInviteCallbackInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInviteCallbackInfoInternal>.NativeClassPtr, 100671660);
      SendInviteCallbackInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_SendInviteCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInviteCallbackInfoInternal>.NativeClassPtr, 100671661);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SendInviteCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
