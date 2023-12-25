// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.PlayerDataStorage.WriteFileOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.PlayerDataStorage
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WriteFileOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Filename;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ChunkLengthBytes;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_WriteFileDataCallback;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_FileTransferProgressCallback;
    private static readonly System.IntPtr NativeFieldInfoPtr_s_WriteFileDataCallback;
    private static readonly System.IntPtr NativeFieldInfoPtr_s_FileTransferProgressCallback;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Filename_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ChunkLengthBytes_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_WriteFileDataCallback_Public_Static_get_OnWriteFileDataCallbackInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_FileTransferProgressCallback_Public_Static_get_OnFileTransferProgressCallbackInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_WriteFileOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_WriteFileOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(16)]
    public System.IntPtr m_Filename;
    [FieldOffset(24)]
    public uint m_ChunkLengthBytes;
    [FieldOffset(32)]
    public System.IntPtr m_WriteFileDataCallback;
    [FieldOffset(40)]
    public System.IntPtr m_FileTransferProgressCallback;

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950751, XrefRangeEnd = 950755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WriteFileOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String Filename
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950755, XrefRangeEnd = 950759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WriteFileOptionsInternal.NativeMethodInfoPtr_set_Filename_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint ChunkLengthBytes
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 20483, RefRangeEnd = 20486, XrefRangeStart = 20483, XrefRangeEnd = 20486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WriteFileOptionsInternal.NativeMethodInfoPtr_set_ChunkLengthBytes_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public static unsafe OnWriteFileDataCallbackInternal WriteFileDataCallback
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 950770, RefRangeEnd = 950773, XrefRangeStart = 950759, XrefRangeEnd = 950770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WriteFileOptionsInternal.NativeMethodInfoPtr_get_WriteFileDataCallback_Public_Static_get_OnWriteFileDataCallbackInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (OnWriteFileDataCallbackInternal) null : new OnWriteFileDataCallbackInternal(pointer);
      }
    }

    public static unsafe OnFileTransferProgressCallbackInternal FileTransferProgressCallback
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 950784, RefRangeEnd = 950787, XrefRangeStart = 950773, XrefRangeEnd = 950784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WriteFileOptionsInternal.NativeMethodInfoPtr_get_FileTransferProgressCallback_Public_Static_get_OnFileTransferProgressCallbackInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (OnFileTransferProgressCallbackInternal) null : new OnFileTransferProgressCallbackInternal(pointer);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 950811, RefRangeEnd = 950812, XrefRangeStart = 950787, XrefRangeEnd = 950811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref WriteFileOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WriteFileOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_WriteFileOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950812, XrefRangeEnd = 950847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<WriteFileOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WriteFileOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_WriteFileOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950847, XrefRangeEnd = 950854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WriteFileOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WriteFileOptionsInternal()
    {
      Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.PlayerDataStorage", nameof (WriteFileOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr);
      WriteFileOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      WriteFileOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
      WriteFileOptionsInternal.NativeFieldInfoPtr_m_Filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, nameof (m_Filename));
      WriteFileOptionsInternal.NativeFieldInfoPtr_m_ChunkLengthBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, nameof (m_ChunkLengthBytes));
      WriteFileOptionsInternal.NativeFieldInfoPtr_m_WriteFileDataCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, nameof (m_WriteFileDataCallback));
      WriteFileOptionsInternal.NativeFieldInfoPtr_m_FileTransferProgressCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, nameof (m_FileTransferProgressCallback));
      WriteFileOptionsInternal.NativeFieldInfoPtr_s_WriteFileDataCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, nameof (s_WriteFileDataCallback));
      WriteFileOptionsInternal.NativeFieldInfoPtr_s_FileTransferProgressCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, nameof (s_FileTransferProgressCallback));
      WriteFileOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, 100668817);
      WriteFileOptionsInternal.NativeMethodInfoPtr_set_Filename_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, 100668818);
      WriteFileOptionsInternal.NativeMethodInfoPtr_set_ChunkLengthBytes_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, 100668819);
      WriteFileOptionsInternal.NativeMethodInfoPtr_get_WriteFileDataCallback_Public_Static_get_OnWriteFileDataCallbackInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, 100668820);
      WriteFileOptionsInternal.NativeMethodInfoPtr_get_FileTransferProgressCallback_Public_Static_get_OnFileTransferProgressCallbackInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, 100668821);
      WriteFileOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_WriteFileOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, 100668822);
      WriteFileOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_WriteFileOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, 100668823);
      WriteFileOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, 100668824);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WriteFileOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe OnWriteFileDataCallbackInternal s_WriteFileDataCallback
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(WriteFileOptionsInternal.NativeFieldInfoPtr_s_WriteFileDataCallback, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (OnWriteFileDataCallbackInternal) null : new OnWriteFileDataCallbackInternal(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(WriteFileOptionsInternal.NativeFieldInfoPtr_s_WriteFileDataCallback, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe OnFileTransferProgressCallbackInternal s_FileTransferProgressCallback
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(WriteFileOptionsInternal.NativeFieldInfoPtr_s_FileTransferProgressCallback, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (OnFileTransferProgressCallbackInternal) null : new OnFileTransferProgressCallbackInternal(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(WriteFileOptionsInternal.NativeFieldInfoPtr_s_FileTransferProgressCallback, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
