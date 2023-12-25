// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.TitleStorage.ReadFileOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.TitleStorage
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ReadFileOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Filename;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ReadChunkLengthBytes;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ReadFileDataCallback;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_FileTransferProgressCallback;
    private static readonly System.IntPtr NativeFieldInfoPtr_s_ReadFileDataCallback;
    private static readonly System.IntPtr NativeFieldInfoPtr_s_FileTransferProgressCallback;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Filename_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ReadChunkLengthBytes_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ReadFileDataCallback_Public_Static_get_OnReadFileDataCallbackInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_FileTransferProgressCallback_Public_Static_get_OnFileTransferProgressCallbackInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ReadFileOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ReadFileOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(16)]
    public System.IntPtr m_Filename;
    [FieldOffset(24)]
    public uint m_ReadChunkLengthBytes;
    [FieldOffset(32)]
    public System.IntPtr m_ReadFileDataCallback;
    [FieldOffset(40)]
    public System.IntPtr m_FileTransferProgressCallback;

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939060, XrefRangeEnd = 939064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReadFileOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String Filename
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939064, XrefRangeEnd = 939068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReadFileOptionsInternal.NativeMethodInfoPtr_set_Filename_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint ReadChunkLengthBytes
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 20483, RefRangeEnd = 20486, XrefRangeStart = 20483, XrefRangeEnd = 20486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReadFileOptionsInternal.NativeMethodInfoPtr_set_ReadChunkLengthBytes_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public static unsafe OnReadFileDataCallbackInternal ReadFileDataCallback
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 939079, RefRangeEnd = 939082, XrefRangeStart = 939068, XrefRangeEnd = 939079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReadFileOptionsInternal.NativeMethodInfoPtr_get_ReadFileDataCallback_Public_Static_get_OnReadFileDataCallbackInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (OnReadFileDataCallbackInternal) null : new OnReadFileDataCallbackInternal(pointer);
      }
    }

    public static unsafe OnFileTransferProgressCallbackInternal FileTransferProgressCallback
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 939093, RefRangeEnd = 939096, XrefRangeStart = 939082, XrefRangeEnd = 939093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReadFileOptionsInternal.NativeMethodInfoPtr_get_FileTransferProgressCallback_Public_Static_get_OnFileTransferProgressCallbackInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (OnFileTransferProgressCallbackInternal) null : new OnFileTransferProgressCallbackInternal(pointer);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 939120, RefRangeEnd = 939121, XrefRangeStart = 939096, XrefRangeEnd = 939120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref ReadFileOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReadFileOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ReadFileOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939121, XrefRangeEnd = 939156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<ReadFileOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReadFileOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ReadFileOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939156, XrefRangeEnd = 939163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReadFileOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ReadFileOptionsInternal()
    {
      Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.TitleStorage", nameof (ReadFileOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr);
      ReadFileOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      ReadFileOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
      ReadFileOptionsInternal.NativeFieldInfoPtr_m_Filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, nameof (m_Filename));
      ReadFileOptionsInternal.NativeFieldInfoPtr_m_ReadChunkLengthBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, nameof (m_ReadChunkLengthBytes));
      ReadFileOptionsInternal.NativeFieldInfoPtr_m_ReadFileDataCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, nameof (m_ReadFileDataCallback));
      ReadFileOptionsInternal.NativeFieldInfoPtr_m_FileTransferProgressCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, nameof (m_FileTransferProgressCallback));
      ReadFileOptionsInternal.NativeFieldInfoPtr_s_ReadFileDataCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, nameof (s_ReadFileDataCallback));
      ReadFileOptionsInternal.NativeFieldInfoPtr_s_FileTransferProgressCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, nameof (s_FileTransferProgressCallback));
      ReadFileOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, 100665661);
      ReadFileOptionsInternal.NativeMethodInfoPtr_set_Filename_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, 100665662);
      ReadFileOptionsInternal.NativeMethodInfoPtr_set_ReadChunkLengthBytes_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, 100665663);
      ReadFileOptionsInternal.NativeMethodInfoPtr_get_ReadFileDataCallback_Public_Static_get_OnReadFileDataCallbackInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, 100665664);
      ReadFileOptionsInternal.NativeMethodInfoPtr_get_FileTransferProgressCallback_Public_Static_get_OnFileTransferProgressCallbackInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, 100665665);
      ReadFileOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ReadFileOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, 100665666);
      ReadFileOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ReadFileOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, 100665667);
      ReadFileOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, 100665668);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe OnReadFileDataCallbackInternal s_ReadFileDataCallback
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ReadFileOptionsInternal.NativeFieldInfoPtr_s_ReadFileDataCallback, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (OnReadFileDataCallbackInternal) null : new OnReadFileDataCallbackInternal(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ReadFileOptionsInternal.NativeFieldInfoPtr_s_ReadFileDataCallback, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe OnFileTransferProgressCallbackInternal s_FileTransferProgressCallback
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ReadFileOptionsInternal.NativeFieldInfoPtr_s_FileTransferProgressCallback, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (OnFileTransferProgressCallbackInternal) null : new OnFileTransferProgressCallbackInternal(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ReadFileOptionsInternal.NativeFieldInfoPtr_s_FileTransferProgressCallback, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
