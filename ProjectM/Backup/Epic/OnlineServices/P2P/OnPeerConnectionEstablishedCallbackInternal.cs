﻿// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.OnPeerConnectionEstablishedCallbackInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Epic.OnlineServices.P2P
{
  public sealed class OnPeerConnectionEstablishedCallbackInternal : Il2CppSystem.MulticastDelegate
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_OnPeerConnectionEstablishedInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_OnPeerConnectionEstablishedInfoInternal_AsyncCallback_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_OnPeerConnectionEstablishedInfoInternal_IAsyncResult_0;

    [CallerCount(5227)]
    [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OnPeerConnectionEstablishedCallbackInternal(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnPeerConnectionEstablishedCallbackInternal>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnPeerConnectionEstablishedCallbackInternal.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(156)]
    [CachedScanResults(RefRangeStart = 382315, RefRangeEnd = 382471, XrefRangeStart = 382315, XrefRangeEnd = 382471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Invoke(ref OnPeerConnectionEstablishedInfoInternal data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnPeerConnectionEstablishedCallbackInternal.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_OnPeerConnectionEstablishedInfoInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951473, XrefRangeEnd = 951477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
      ref OnPeerConnectionEstablishedInfoInternal data,
      Il2CppSystem.AsyncCallback callback,
      Il2CppSystem.Object @object)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnPeerConnectionEstablishedCallbackInternal.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_OnPeerConnectionEstablishedInfoInternal_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void EndInvoke(
      ref OnPeerConnectionEstablishedInfoInternal data,
      Il2CppSystem.IAsyncResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnPeerConnectionEstablishedCallbackInternal.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_OnPeerConnectionEstablishedInfoInternal_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static OnPeerConnectionEstablishedCallbackInternal()
    {
      Il2CppClassPointerStore<OnPeerConnectionEstablishedCallbackInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.P2P", nameof (OnPeerConnectionEstablishedCallbackInternal));
      OnPeerConnectionEstablishedCallbackInternal.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPeerConnectionEstablishedCallbackInternal>.NativeClassPtr, 100669004);
      OnPeerConnectionEstablishedCallbackInternal.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_OnPeerConnectionEstablishedInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPeerConnectionEstablishedCallbackInternal>.NativeClassPtr, 100669005);
      OnPeerConnectionEstablishedCallbackInternal.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_OnPeerConnectionEstablishedInfoInternal_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPeerConnectionEstablishedCallbackInternal>.NativeClassPtr, 100669006);
      OnPeerConnectionEstablishedCallbackInternal.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_OnPeerConnectionEstablishedInfoInternal_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnPeerConnectionEstablishedCallbackInternal>.NativeClassPtr, 100669007);
    }

    public OnPeerConnectionEstablishedCallbackInternal(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}