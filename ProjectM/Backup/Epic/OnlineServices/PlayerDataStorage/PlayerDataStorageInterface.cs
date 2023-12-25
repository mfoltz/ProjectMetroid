// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.PlayerDataStorage.PlayerDataStorageInterface
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
  public sealed class PlayerDataStorageInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyfilemetadataatindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyfilemetadataatindexoptionsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyfilemetadatabyfilenameApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyfilemetadatabyfilenameoptionsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeletecacheApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeletecacheoptionsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeletefileApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeletefileoptionsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_DuplicatefileApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_DuplicatefileoptionsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_FileMaxSizeBytes;
    private static readonly System.IntPtr NativeFieldInfoPtr_FilemetadataApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_FilenameMaxLengthBytes;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetfilemetadatacountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetfilemetadatacountoptionsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryfileApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryfilelistApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryfilelistoptionsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryfileoptionsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReadfileApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReadfileoptionsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_WritefileApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_WritefileoptionsApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyFileMetadataAtIndex_Public_Result_byref_CopyFileMetadataAtIndexOptions_byref_Nullable_1_FileMetadata_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyFileMetadataByFilename_Public_Result_byref_CopyFileMetadataByFilenameOptions_byref_Nullable_1_FileMetadata_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeleteCache_Public_Result_byref_DeleteCacheOptions_Object_OnDeleteCacheCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeleteFile_Public_Void_byref_DeleteFileOptions_Object_OnDeleteFileCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DuplicateFile_Public_Void_byref_DuplicateFileOptions_Object_OnDuplicateFileCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFileMetadataCount_Public_Result_byref_GetFileMetadataCountOptions_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryFile_Public_Void_byref_QueryFileOptions_Object_OnQueryFileCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryFileList_Public_Void_byref_QueryFileListOptions_Object_OnQueryFileListCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadFile_Public_PlayerDataStorageFileTransferRequest_byref_ReadFileOptions_Object_OnReadFileCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteFile_Public_PlayerDataStorageFileTransferRequest_byref_WriteFileOptions_Object_OnWriteFileCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDeleteCacheCompleteCallbackInternalImplementation_Internal_Static_Void_byref_DeleteCacheCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDeleteFileCompleteCallbackInternalImplementation_Internal_Static_Void_byref_DeleteFileCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDuplicateFileCompleteCallbackInternalImplementation_Internal_Static_Void_byref_DuplicateFileCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnFileTransferProgressCallbackInternalImplementation_Internal_Static_Void_byref_FileTransferProgressCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryFileCompleteCallbackInternalImplementation_Internal_Static_Void_byref_QueryFileCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryFileListCompleteCallbackInternalImplementation_Internal_Static_Void_byref_QueryFileListCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnReadFileCompleteCallbackInternalImplementation_Internal_Static_Void_byref_ReadFileCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnReadFileDataCallbackInternalImplementation_Internal_Static_ReadResult_byref_ReadFileDataCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnWriteFileCompleteCallbackInternalImplementation_Internal_Static_Void_byref_WriteFileCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnWriteFileDataCallbackInternalImplementation_Internal_Static_WriteResult_byref_WriteFileDataCallbackInfoInternal_IntPtr_byref_UInt32_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlayerDataStorageInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949809, XrefRangeEnd = 949823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyFileMetadataAtIndex(
      ref CopyFileMetadataAtIndexOptions copyFileMetadataOptions,
      out Il2CppSystem.Nullable<FileMetadata> outMetadata)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) copyFileMetadataOptions);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_CopyFileMetadataAtIndex_Public_Result_byref_CopyFileMetadataAtIndexOptions_byref_Nullable_1_FileMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<FileMetadata> local = ref outMetadata;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<FileMetadata>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949823, XrefRangeEnd = 949837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyFileMetadataByFilename(
      ref CopyFileMetadataByFilenameOptions copyFileMetadataOptions,
      out Il2CppSystem.Nullable<FileMetadata> outMetadata)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) copyFileMetadataOptions);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_CopyFileMetadataByFilename_Public_Result_byref_CopyFileMetadataByFilenameOptions_byref_Nullable_1_FileMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<FileMetadata> local = ref outMetadata;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<FileMetadata>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949837, XrefRangeEnd = 949856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result DeleteCache(
      ref DeleteCacheOptions options,
      Il2CppSystem.Object clientData,
      OnDeleteCacheCompleteCallback completionCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionCallback);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_DeleteCache_Public_Result_byref_DeleteCacheOptions_Object_OnDeleteCacheCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949856, XrefRangeEnd = 949875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeleteFile(
      ref DeleteFileOptions deleteOptions,
      Il2CppSystem.Object clientData,
      OnDeleteFileCompleteCallback completionCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) deleteOptions);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_DeleteFile_Public_Void_byref_DeleteFileOptions_Object_OnDeleteFileCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949875, XrefRangeEnd = 949894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DuplicateFile(
      ref DuplicateFileOptions duplicateOptions,
      Il2CppSystem.Object clientData,
      OnDuplicateFileCompleteCallback completionCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) duplicateOptions);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_DuplicateFile_Public_Void_byref_DuplicateFileOptions_Object_OnDuplicateFileCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949894, XrefRangeEnd = 949905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result GetFileMetadataCount(
      ref GetFileMetadataCountOptions getFileMetadataCountOptions,
      out int outFileMetadataCount)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) getFileMetadataCountOptions);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outFileMetadataCount;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_GetFileMetadataCount_Public_Result_byref_GetFileMetadataCountOptions_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949905, XrefRangeEnd = 949924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryFile(
      ref QueryFileOptions queryFileOptions,
      Il2CppSystem.Object clientData,
      OnQueryFileCompleteCallback completionCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) queryFileOptions);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_QueryFile_Public_Void_byref_QueryFileOptions_Object_OnQueryFileCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949924, XrefRangeEnd = 949943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryFileList(
      ref QueryFileListOptions queryFileListOptions,
      Il2CppSystem.Object clientData,
      OnQueryFileListCompleteCallback completionCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) queryFileListOptions);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_QueryFileList_Public_Void_byref_QueryFileListOptions_Object_OnQueryFileListCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949943, XrefRangeEnd = 949975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlayerDataStorageFileTransferRequest ReadFile(
      ref ReadFileOptions readOptions,
      Il2CppSystem.Object clientData,
      OnReadFileCompleteCallback completionCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) readOptions);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionCallback);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_ReadFile_Public_PlayerDataStorageFileTransferRequest_byref_ReadFileOptions_Object_OnReadFileCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (PlayerDataStorageFileTransferRequest) null : new PlayerDataStorageFileTransferRequest(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949975, XrefRangeEnd = 950007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlayerDataStorageFileTransferRequest WriteFile(
      ref WriteFileOptions writeOptions,
      Il2CppSystem.Object clientData,
      OnWriteFileCompleteCallback completionCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) writeOptions);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionCallback);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_WriteFile_Public_PlayerDataStorageFileTransferRequest_byref_WriteFileOptions_Object_OnWriteFileCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (PlayerDataStorageFileTransferRequest) null : new PlayerDataStorageFileTransferRequest(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950007, XrefRangeEnd = 950014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnDeleteCacheCompleteCallbackInternalImplementation(
      ref DeleteCacheCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_OnDeleteCacheCompleteCallbackInternalImplementation_Internal_Static_Void_byref_DeleteCacheCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950014, XrefRangeEnd = 950021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnDeleteFileCompleteCallbackInternalImplementation(
      ref DeleteFileCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_OnDeleteFileCompleteCallbackInternalImplementation_Internal_Static_Void_byref_DeleteFileCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950021, XrefRangeEnd = 950028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnDuplicateFileCompleteCallbackInternalImplementation(
      ref DuplicateFileCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_OnDuplicateFileCompleteCallbackInternalImplementation_Internal_Static_Void_byref_DuplicateFileCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950028, XrefRangeEnd = 950040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnFileTransferProgressCallbackInternalImplementation(
      ref FileTransferProgressCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_OnFileTransferProgressCallbackInternalImplementation_Internal_Static_Void_byref_FileTransferProgressCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950040, XrefRangeEnd = 950047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryFileCompleteCallbackInternalImplementation(
      ref QueryFileCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_OnQueryFileCompleteCallbackInternalImplementation_Internal_Static_Void_byref_QueryFileCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950047, XrefRangeEnd = 950054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryFileListCompleteCallbackInternalImplementation(
      ref QueryFileListCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_OnQueryFileListCompleteCallbackInternalImplementation_Internal_Static_Void_byref_QueryFileListCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950054, XrefRangeEnd = 950061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnReadFileCompleteCallbackInternalImplementation(
      ref ReadFileCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_OnReadFileCompleteCallbackInternalImplementation_Internal_Static_Void_byref_ReadFileCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950061, XrefRangeEnd = 950073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ReadResult OnReadFileDataCallbackInternalImplementation(
      ref ReadFileDataCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_OnReadFileDataCallbackInternalImplementation_Internal_Static_ReadResult_byref_ReadFileDataCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ReadResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950073, XrefRangeEnd = 950080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnWriteFileCompleteCallbackInternalImplementation(
      ref WriteFileCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_OnWriteFileCompleteCallbackInternalImplementation_Internal_Static_Void_byref_WriteFileCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950080, XrefRangeEnd = 950093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe WriteResult OnWriteFileDataCallbackInternalImplementation(
      ref WriteFileDataCallbackInfoInternal data,
      System.IntPtr outDataBuffer,
      ref uint outDataWritten)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &outDataBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref outDataWritten;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageInterface.NativeMethodInfoPtr_OnWriteFileDataCallbackInternalImplementation_Internal_Static_WriteResult_byref_WriteFileDataCallbackInfoInternal_IntPtr_byref_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(WriteResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    static PlayerDataStorageInterface()
    {
      Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.PlayerDataStorage", nameof (PlayerDataStorageInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr);
      PlayerDataStorageInterface.NativeFieldInfoPtr_CopyfilemetadataatindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (CopyfilemetadataatindexApiLatest));
      PlayerDataStorageInterface.NativeFieldInfoPtr_CopyfilemetadataatindexoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (CopyfilemetadataatindexoptionsApiLatest));
      PlayerDataStorageInterface.NativeFieldInfoPtr_CopyfilemetadatabyfilenameApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (CopyfilemetadatabyfilenameApiLatest));
      PlayerDataStorageInterface.NativeFieldInfoPtr_CopyfilemetadatabyfilenameoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (CopyfilemetadatabyfilenameoptionsApiLatest));
      PlayerDataStorageInterface.NativeFieldInfoPtr_DeletecacheApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (DeletecacheApiLatest));
      PlayerDataStorageInterface.NativeFieldInfoPtr_DeletecacheoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (DeletecacheoptionsApiLatest));
      PlayerDataStorageInterface.NativeFieldInfoPtr_DeletefileApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (DeletefileApiLatest));
      PlayerDataStorageInterface.NativeFieldInfoPtr_DeletefileoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (DeletefileoptionsApiLatest));
      PlayerDataStorageInterface.NativeFieldInfoPtr_DuplicatefileApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (DuplicatefileApiLatest));
      PlayerDataStorageInterface.NativeFieldInfoPtr_DuplicatefileoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (DuplicatefileoptionsApiLatest));
      PlayerDataStorageInterface.NativeFieldInfoPtr_FileMaxSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (FileMaxSizeBytes));
      PlayerDataStorageInterface.NativeFieldInfoPtr_FilemetadataApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (FilemetadataApiLatest));
      PlayerDataStorageInterface.NativeFieldInfoPtr_FilenameMaxLengthBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (FilenameMaxLengthBytes));
      PlayerDataStorageInterface.NativeFieldInfoPtr_GetfilemetadatacountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (GetfilemetadatacountApiLatest));
      PlayerDataStorageInterface.NativeFieldInfoPtr_GetfilemetadatacountoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (GetfilemetadatacountoptionsApiLatest));
      PlayerDataStorageInterface.NativeFieldInfoPtr_QueryfileApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (QueryfileApiLatest));
      PlayerDataStorageInterface.NativeFieldInfoPtr_QueryfilelistApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (QueryfilelistApiLatest));
      PlayerDataStorageInterface.NativeFieldInfoPtr_QueryfilelistoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (QueryfilelistoptionsApiLatest));
      PlayerDataStorageInterface.NativeFieldInfoPtr_QueryfileoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (QueryfileoptionsApiLatest));
      PlayerDataStorageInterface.NativeFieldInfoPtr_ReadfileApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (ReadfileApiLatest));
      PlayerDataStorageInterface.NativeFieldInfoPtr_ReadfileoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (ReadfileoptionsApiLatest));
      PlayerDataStorageInterface.NativeFieldInfoPtr_WritefileApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (WritefileApiLatest));
      PlayerDataStorageInterface.NativeFieldInfoPtr_WritefileoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, nameof (WritefileoptionsApiLatest));
      PlayerDataStorageInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100668610);
      PlayerDataStorageInterface.NativeMethodInfoPtr_CopyFileMetadataAtIndex_Public_Result_byref_CopyFileMetadataAtIndexOptions_byref_Nullable_1_FileMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100668612);
      PlayerDataStorageInterface.NativeMethodInfoPtr_CopyFileMetadataByFilename_Public_Result_byref_CopyFileMetadataByFilenameOptions_byref_Nullable_1_FileMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100668613);
      PlayerDataStorageInterface.NativeMethodInfoPtr_DeleteCache_Public_Result_byref_DeleteCacheOptions_Object_OnDeleteCacheCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100668614);
      PlayerDataStorageInterface.NativeMethodInfoPtr_DeleteFile_Public_Void_byref_DeleteFileOptions_Object_OnDeleteFileCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100668615);
      PlayerDataStorageInterface.NativeMethodInfoPtr_DuplicateFile_Public_Void_byref_DuplicateFileOptions_Object_OnDuplicateFileCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100668616);
      PlayerDataStorageInterface.NativeMethodInfoPtr_GetFileMetadataCount_Public_Result_byref_GetFileMetadataCountOptions_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100668617);
      PlayerDataStorageInterface.NativeMethodInfoPtr_QueryFile_Public_Void_byref_QueryFileOptions_Object_OnQueryFileCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100668618);
      PlayerDataStorageInterface.NativeMethodInfoPtr_QueryFileList_Public_Void_byref_QueryFileListOptions_Object_OnQueryFileListCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100668619);
      PlayerDataStorageInterface.NativeMethodInfoPtr_ReadFile_Public_PlayerDataStorageFileTransferRequest_byref_ReadFileOptions_Object_OnReadFileCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100668620);
      PlayerDataStorageInterface.NativeMethodInfoPtr_WriteFile_Public_PlayerDataStorageFileTransferRequest_byref_WriteFileOptions_Object_OnWriteFileCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100668621);
      PlayerDataStorageInterface.NativeMethodInfoPtr_OnDeleteCacheCompleteCallbackInternalImplementation_Internal_Static_Void_byref_DeleteCacheCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100668622);
      PlayerDataStorageInterface.NativeMethodInfoPtr_OnDeleteFileCompleteCallbackInternalImplementation_Internal_Static_Void_byref_DeleteFileCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100668623);
      PlayerDataStorageInterface.NativeMethodInfoPtr_OnDuplicateFileCompleteCallbackInternalImplementation_Internal_Static_Void_byref_DuplicateFileCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100668624);
      PlayerDataStorageInterface.NativeMethodInfoPtr_OnFileTransferProgressCallbackInternalImplementation_Internal_Static_Void_byref_FileTransferProgressCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100668625);
      PlayerDataStorageInterface.NativeMethodInfoPtr_OnQueryFileCompleteCallbackInternalImplementation_Internal_Static_Void_byref_QueryFileCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100668626);
      PlayerDataStorageInterface.NativeMethodInfoPtr_OnQueryFileListCompleteCallbackInternalImplementation_Internal_Static_Void_byref_QueryFileListCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100668627);
      PlayerDataStorageInterface.NativeMethodInfoPtr_OnReadFileCompleteCallbackInternalImplementation_Internal_Static_Void_byref_ReadFileCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100668628);
      PlayerDataStorageInterface.NativeMethodInfoPtr_OnReadFileDataCallbackInternalImplementation_Internal_Static_ReadResult_byref_ReadFileDataCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100668629);
      PlayerDataStorageInterface.NativeMethodInfoPtr_OnWriteFileCompleteCallbackInternalImplementation_Internal_Static_Void_byref_WriteFileCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100668630);
      PlayerDataStorageInterface.NativeMethodInfoPtr_OnWriteFileDataCallbackInternalImplementation_Internal_Static_WriteResult_byref_WriteFileDataCallbackInfoInternal_IntPtr_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageInterface>.NativeClassPtr, 100668631);
    }

    public PlayerDataStorageInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int CopyfilemetadataatindexApiLatest
    {
      get
      {
        int copyfilemetadataatindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_CopyfilemetadataatindexApiLatest, (void*) &copyfilemetadataatindexApiLatest);
        return copyfilemetadataatindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_CopyfilemetadataatindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyfilemetadataatindexoptionsApiLatest
    {
      get
      {
        int copyfilemetadataatindexoptionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_CopyfilemetadataatindexoptionsApiLatest, (void*) &copyfilemetadataatindexoptionsApiLatest);
        return copyfilemetadataatindexoptionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_CopyfilemetadataatindexoptionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyfilemetadatabyfilenameApiLatest
    {
      get
      {
        int copyfilemetadatabyfilenameApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_CopyfilemetadatabyfilenameApiLatest, (void*) &copyfilemetadatabyfilenameApiLatest);
        return copyfilemetadatabyfilenameApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_CopyfilemetadatabyfilenameApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyfilemetadatabyfilenameoptionsApiLatest
    {
      get
      {
        int copyfilemetadatabyfilenameoptionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_CopyfilemetadatabyfilenameoptionsApiLatest, (void*) &copyfilemetadatabyfilenameoptionsApiLatest);
        return copyfilemetadatabyfilenameoptionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_CopyfilemetadatabyfilenameoptionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int DeletecacheApiLatest
    {
      get
      {
        int deletecacheApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_DeletecacheApiLatest, (void*) &deletecacheApiLatest);
        return deletecacheApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_DeletecacheApiLatest, (void*) &value);
      }
    }

    public static unsafe int DeletecacheoptionsApiLatest
    {
      get
      {
        int deletecacheoptionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_DeletecacheoptionsApiLatest, (void*) &deletecacheoptionsApiLatest);
        return deletecacheoptionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_DeletecacheoptionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int DeletefileApiLatest
    {
      get
      {
        int deletefileApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_DeletefileApiLatest, (void*) &deletefileApiLatest);
        return deletefileApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_DeletefileApiLatest, (void*) &value);
      }
    }

    public static unsafe int DeletefileoptionsApiLatest
    {
      get
      {
        int deletefileoptionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_DeletefileoptionsApiLatest, (void*) &deletefileoptionsApiLatest);
        return deletefileoptionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_DeletefileoptionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int DuplicatefileApiLatest
    {
      get
      {
        int duplicatefileApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_DuplicatefileApiLatest, (void*) &duplicatefileApiLatest);
        return duplicatefileApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_DuplicatefileApiLatest, (void*) &value);
      }
    }

    public static unsafe int DuplicatefileoptionsApiLatest
    {
      get
      {
        int duplicatefileoptionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_DuplicatefileoptionsApiLatest, (void*) &duplicatefileoptionsApiLatest);
        return duplicatefileoptionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_DuplicatefileoptionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int FileMaxSizeBytes
    {
      get
      {
        int fileMaxSizeBytes;
        IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_FileMaxSizeBytes, (void*) &fileMaxSizeBytes);
        return fileMaxSizeBytes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_FileMaxSizeBytes, (void*) &value);
      }
    }

    public static unsafe int FilemetadataApiLatest
    {
      get
      {
        int filemetadataApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_FilemetadataApiLatest, (void*) &filemetadataApiLatest);
        return filemetadataApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_FilemetadataApiLatest, (void*) &value);
      }
    }

    public static unsafe int FilenameMaxLengthBytes
    {
      get
      {
        int filenameMaxLengthBytes;
        IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_FilenameMaxLengthBytes, (void*) &filenameMaxLengthBytes);
        return filenameMaxLengthBytes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_FilenameMaxLengthBytes, (void*) &value);
      }
    }

    public static unsafe int GetfilemetadatacountApiLatest
    {
      get
      {
        int getfilemetadatacountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_GetfilemetadatacountApiLatest, (void*) &getfilemetadatacountApiLatest);
        return getfilemetadatacountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_GetfilemetadatacountApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetfilemetadatacountoptionsApiLatest
    {
      get
      {
        int getfilemetadatacountoptionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_GetfilemetadatacountoptionsApiLatest, (void*) &getfilemetadatacountoptionsApiLatest);
        return getfilemetadatacountoptionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_GetfilemetadatacountoptionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryfileApiLatest
    {
      get
      {
        int queryfileApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_QueryfileApiLatest, (void*) &queryfileApiLatest);
        return queryfileApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_QueryfileApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryfilelistApiLatest
    {
      get
      {
        int queryfilelistApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_QueryfilelistApiLatest, (void*) &queryfilelistApiLatest);
        return queryfilelistApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_QueryfilelistApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryfilelistoptionsApiLatest
    {
      get
      {
        int queryfilelistoptionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_QueryfilelistoptionsApiLatest, (void*) &queryfilelistoptionsApiLatest);
        return queryfilelistoptionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_QueryfilelistoptionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryfileoptionsApiLatest
    {
      get
      {
        int queryfileoptionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_QueryfileoptionsApiLatest, (void*) &queryfileoptionsApiLatest);
        return queryfileoptionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_QueryfileoptionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int ReadfileApiLatest
    {
      get
      {
        int readfileApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_ReadfileApiLatest, (void*) &readfileApiLatest);
        return readfileApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_ReadfileApiLatest, (void*) &value);
      }
    }

    public static unsafe int ReadfileoptionsApiLatest
    {
      get
      {
        int readfileoptionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_ReadfileoptionsApiLatest, (void*) &readfileoptionsApiLatest);
        return readfileoptionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_ReadfileoptionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int WritefileApiLatest
    {
      get
      {
        int writefileApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_WritefileApiLatest, (void*) &writefileApiLatest);
        return writefileApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_WritefileApiLatest, (void*) &value);
      }
    }

    public static unsafe int WritefileoptionsApiLatest
    {
      get
      {
        int writefileoptionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(PlayerDataStorageInterface.NativeFieldInfoPtr_WritefileoptionsApiLatest, (void*) &writefileoptionsApiLatest);
        return writefileoptionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PlayerDataStorageInterface.NativeFieldInfoPtr_WritefileoptionsApiLatest, (void*) &value);
      }
    }
  }
}
