﻿// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTC.OnLeaveRoomCallback
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Epic.OnlineServices.RTC
{
  public sealed class OnLeaveRoomCallback : Il2CppSystem.MulticastDelegate
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_LeaveRoomCallbackInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_LeaveRoomCallbackInfo_AsyncCallback_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_LeaveRoomCallbackInfo_IAsyncResult_0;

    [CallerCount(5227)]
    [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OnLeaveRoomCallback(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnLeaveRoomCallback>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnLeaveRoomCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(156)]
    [CachedScanResults(RefRangeStart = 382315, RefRangeEnd = 382471, XrefRangeStart = 382315, XrefRangeEnd = 382471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Invoke(ref LeaveRoomCallbackInfo data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnLeaveRoomCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_LeaveRoomCallbackInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947262, XrefRangeEnd = 947266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
      ref LeaveRoomCallbackInfo data,
      Il2CppSystem.AsyncCallback callback,
      Il2CppSystem.Object @object)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnLeaveRoomCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_LeaveRoomCallbackInfo_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void EndInvoke(ref LeaveRoomCallbackInfo data, Il2CppSystem.IAsyncResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnLeaveRoomCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_LeaveRoomCallbackInfo_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static OnLeaveRoomCallback()
    {
      Il2CppClassPointerStore<OnLeaveRoomCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.RTC", nameof (OnLeaveRoomCallback));
      OnLeaveRoomCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnLeaveRoomCallback>.NativeClassPtr, 100667865);
      OnLeaveRoomCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_LeaveRoomCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnLeaveRoomCallback>.NativeClassPtr, 100667866);
      OnLeaveRoomCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_LeaveRoomCallbackInfo_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnLeaveRoomCallback>.NativeClassPtr, 100667867);
      OnLeaveRoomCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_LeaveRoomCallbackInfo_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnLeaveRoomCallback>.NativeClassPtr, 100667868);
    }

    public OnLeaveRoomCallback(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
