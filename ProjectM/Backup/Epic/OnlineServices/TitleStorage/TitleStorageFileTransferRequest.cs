// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.TitleStorage.TitleStorageFileTransferRequest
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Epic.OnlineServices.TitleStorage
{
  public sealed class TitleStorageFileTransferRequest : Handle
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_CancelRequest_Public_Result_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetFileRequestState_Public_Result_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetFilename_Public_Result_byref_Utf8String_0;
    private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TitleStorageFileTransferRequest()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TitleStorageFileTransferRequest>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TitleStorageFileTransferRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939163, XrefRangeEnd = 939164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CancelRequest()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(TitleStorageFileTransferRequest.NativeMethodInfoPtr_CancelRequest_Public_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939164, XrefRangeEnd = 939165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result GetFileRequestState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(TitleStorageFileTransferRequest.NativeMethodInfoPtr_GetFileRequestState_Public_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939165, XrefRangeEnd = 939172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result GetFilename(out Epic.OnlineServices.Utf8String outStringBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr1 = stackalloc IntPtr[1];
      IntPtr* numPtr2 = numPtr1;
      IntPtr zero = IntPtr.Zero;
      IntPtr* numPtr3 = &zero;
      *numPtr2 = (IntPtr) numPtr3;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(TitleStorageFileTransferRequest.NativeMethodInfoPtr_GetFilename_Public_Result_byref_Utf8String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Epic.OnlineServices.Utf8String local = ref outStringBuffer;
      IntPtr pointer = zero;
      Epic.OnlineServices.Utf8String utf8String = pointer == IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      local = utf8String;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939172, XrefRangeEnd = 939173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Release()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TitleStorageFileTransferRequest.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TitleStorageFileTransferRequest()
    {
      Il2CppClassPointerStore<TitleStorageFileTransferRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.TitleStorage", nameof (TitleStorageFileTransferRequest));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TitleStorageFileTransferRequest>.NativeClassPtr);
      TitleStorageFileTransferRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageFileTransferRequest>.NativeClassPtr, 100665669);
      TitleStorageFileTransferRequest.NativeMethodInfoPtr_CancelRequest_Public_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageFileTransferRequest>.NativeClassPtr, 100665671);
      TitleStorageFileTransferRequest.NativeMethodInfoPtr_GetFileRequestState_Public_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageFileTransferRequest>.NativeClassPtr, 100665672);
      TitleStorageFileTransferRequest.NativeMethodInfoPtr_GetFilename_Public_Result_byref_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageFileTransferRequest>.NativeClassPtr, 100665673);
      TitleStorageFileTransferRequest.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageFileTransferRequest>.NativeClassPtr, 100665674);
    }

    public TitleStorageFileTransferRequest(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
