﻿// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.OnRTCRoomConnectionChangedCallbackInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Epic.OnlineServices.Lobby
{
  public sealed class OnRTCRoomConnectionChangedCallbackInternal : Il2CppSystem.MulticastDelegate
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_RTCRoomConnectionChangedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_RTCRoomConnectionChangedCallbackInfoInternal_AsyncCallback_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_RTCRoomConnectionChangedCallbackInfoInternal_IAsyncResult_0;

    [CallerCount(5227)]
    [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OnRTCRoomConnectionChangedCallbackInternal(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnRTCRoomConnectionChangedCallbackInternal>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnRTCRoomConnectionChangedCallbackInternal.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(156)]
    [CachedScanResults(RefRangeStart = 382315, RefRangeEnd = 382471, XrefRangeStart = 382315, XrefRangeEnd = 382471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Invoke(
      ref RTCRoomConnectionChangedCallbackInfoInternal data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnRTCRoomConnectionChangedCallbackInternal.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_RTCRoomConnectionChangedCallbackInfoInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957652, XrefRangeEnd = 957656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
      ref RTCRoomConnectionChangedCallbackInfoInternal data,
      Il2CppSystem.AsyncCallback callback,
      Il2CppSystem.Object @object)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnRTCRoomConnectionChangedCallbackInternal.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_RTCRoomConnectionChangedCallbackInfoInternal_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void EndInvoke(
      ref RTCRoomConnectionChangedCallbackInfoInternal data,
      Il2CppSystem.IAsyncResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnRTCRoomConnectionChangedCallbackInternal.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_RTCRoomConnectionChangedCallbackInfoInternal_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static OnRTCRoomConnectionChangedCallbackInternal()
    {
      Il2CppClassPointerStore<OnRTCRoomConnectionChangedCallbackInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Lobby", nameof (OnRTCRoomConnectionChangedCallbackInternal));
      OnRTCRoomConnectionChangedCallbackInternal.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRTCRoomConnectionChangedCallbackInternal>.NativeClassPtr, 100670617);
      OnRTCRoomConnectionChangedCallbackInternal.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_RTCRoomConnectionChangedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRTCRoomConnectionChangedCallbackInternal>.NativeClassPtr, 100670618);
      OnRTCRoomConnectionChangedCallbackInternal.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_RTCRoomConnectionChangedCallbackInfoInternal_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRTCRoomConnectionChangedCallbackInternal>.NativeClassPtr, 100670619);
      OnRTCRoomConnectionChangedCallbackInternal.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_RTCRoomConnectionChangedCallbackInfoInternal_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRTCRoomConnectionChangedCallbackInternal>.NativeClassPtr, 100670620);
    }

    public OnRTCRoomConnectionChangedCallbackInternal(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
