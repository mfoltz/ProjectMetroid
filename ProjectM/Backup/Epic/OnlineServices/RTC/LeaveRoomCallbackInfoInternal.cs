﻿// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTC.LeaveRoomCallbackInfoInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTC
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LeaveRoomCallbackInfoInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ResultCode;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_RoomName;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ResultCode_Public_set_Void_Result_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RoomName_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RoomName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LeaveRoomCallbackInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LeaveRoomCallbackInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LeaveRoomCallbackInfo_0;
    [FieldOffset(0)]
    public Result m_ResultCode;
    [FieldOffset(8)]
    public System.IntPtr m_ClientData;
    [FieldOffset(16)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(24)]
    public System.IntPtr m_RoomName;

    public unsafe Result ResultCode
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Result*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_set_ResultCode_Public_set_Void_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppSystem.Object ClientData
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947134, XrefRangeEnd = 947138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947138, XrefRangeEnd = 947142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public virtual unsafe System.IntPtr ClientDataAddress
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 947148, RefRangeEnd = 947149, XrefRangeStart = 947142, XrefRangeEnd = 947148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947149, XrefRangeEnd = 947153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String RoomName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947153, XrefRangeEnd = 947157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_get_RoomName_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947157, XrefRangeEnd = 947161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_set_RoomName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947161, XrefRangeEnd = 947173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref LeaveRoomCallbackInfo other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LeaveRoomCallbackInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947173, XrefRangeEnd = 947195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<LeaveRoomCallbackInfo> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LeaveRoomCallbackInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947195, XrefRangeEnd = 947201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947201, XrefRangeEnd = 947202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out LeaveRoomCallbackInfo output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LeaveRoomCallbackInfo_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref LeaveRoomCallbackInfo local = ref output;
      System.IntPtr pointer = zero;
      LeaveRoomCallbackInfo roomCallbackInfo = pointer == System.IntPtr.Zero ? (LeaveRoomCallbackInfo) null : new LeaveRoomCallbackInfo(pointer);
      local = roomCallbackInfo;
    }

    static LeaveRoomCallbackInfoInternal()
    {
      Il2CppClassPointerStore<LeaveRoomCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.RTC", nameof (LeaveRoomCallbackInfoInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaveRoomCallbackInfoInternal>.NativeClassPtr);
      LeaveRoomCallbackInfoInternal.NativeFieldInfoPtr_m_ResultCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaveRoomCallbackInfoInternal>.NativeClassPtr, nameof (m_ResultCode));
      LeaveRoomCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaveRoomCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
      LeaveRoomCallbackInfoInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaveRoomCallbackInfoInternal>.NativeClassPtr, nameof (m_LocalUserId));
      LeaveRoomCallbackInfoInternal.NativeFieldInfoPtr_m_RoomName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaveRoomCallbackInfoInternal>.NativeClassPtr, nameof (m_RoomName));
      LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaveRoomCallbackInfoInternal>.NativeClassPtr, 100667819);
      LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_set_ResultCode_Public_set_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaveRoomCallbackInfoInternal>.NativeClassPtr, 100667820);
      LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaveRoomCallbackInfoInternal>.NativeClassPtr, 100667821);
      LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaveRoomCallbackInfoInternal>.NativeClassPtr, 100667822);
      LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaveRoomCallbackInfoInternal>.NativeClassPtr, 100667823);
      LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaveRoomCallbackInfoInternal>.NativeClassPtr, 100667824);
      LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaveRoomCallbackInfoInternal>.NativeClassPtr, 100667825);
      LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_get_RoomName_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaveRoomCallbackInfoInternal>.NativeClassPtr, 100667826);
      LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_set_RoomName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaveRoomCallbackInfoInternal>.NativeClassPtr, 100667827);
      LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LeaveRoomCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaveRoomCallbackInfoInternal>.NativeClassPtr, 100667828);
      LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LeaveRoomCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaveRoomCallbackInfoInternal>.NativeClassPtr, 100667829);
      LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaveRoomCallbackInfoInternal>.NativeClassPtr, 100667830);
      LeaveRoomCallbackInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LeaveRoomCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaveRoomCallbackInfoInternal>.NativeClassPtr, 100667831);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LeaveRoomCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
