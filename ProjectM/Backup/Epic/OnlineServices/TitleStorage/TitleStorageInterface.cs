// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.TitleStorage.TitleStorageInterface
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
  public sealed class TitleStorageInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyfilemetadataatindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyfilemetadataatindexoptionsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyfilemetadatabyfilenameApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyfilemetadatabyfilenameoptionsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeletecacheApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeletecacheoptionsApiLatest;
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
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyFileMetadataAtIndex_Public_Result_byref_CopyFileMetadataAtIndexOptions_byref_Nullable_1_FileMetadata_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyFileMetadataByFilename_Public_Result_byref_CopyFileMetadataByFilenameOptions_byref_Nullable_1_FileMetadata_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeleteCache_Public_Result_byref_DeleteCacheOptions_Object_OnDeleteCacheCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFileMetadataCount_Public_UInt32_byref_GetFileMetadataCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryFile_Public_Void_byref_QueryFileOptions_Object_OnQueryFileCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryFileList_Public_Void_byref_QueryFileListOptions_Object_OnQueryFileListCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadFile_Public_TitleStorageFileTransferRequest_byref_ReadFileOptions_Object_OnReadFileCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDeleteCacheCompleteCallbackInternalImplementation_Internal_Static_Void_byref_DeleteCacheCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnFileTransferProgressCallbackInternalImplementation_Internal_Static_Void_byref_FileTransferProgressCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryFileCompleteCallbackInternalImplementation_Internal_Static_Void_byref_QueryFileCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryFileListCompleteCallbackInternalImplementation_Internal_Static_Void_byref_QueryFileListCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnReadFileCompleteCallbackInternalImplementation_Internal_Static_Void_byref_ReadFileCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnReadFileDataCallbackInternalImplementation_Internal_Static_ReadResult_byref_ReadFileDataCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TitleStorageInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939173, XrefRangeEnd = 939187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyFileMetadataAtIndex(
      ref CopyFileMetadataAtIndexOptions options,
      out Il2CppSystem.Nullable<FileMetadata> outMetadata)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_CopyFileMetadataAtIndex_Public_Result_byref_CopyFileMetadataAtIndexOptions_byref_Nullable_1_FileMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<FileMetadata> local = ref outMetadata;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<FileMetadata>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939187, XrefRangeEnd = 939201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyFileMetadataByFilename(
      ref CopyFileMetadataByFilenameOptions options,
      out Il2CppSystem.Nullable<FileMetadata> outMetadata)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_CopyFileMetadataByFilename_Public_Result_byref_CopyFileMetadataByFilenameOptions_byref_Nullable_1_FileMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<FileMetadata> local = ref outMetadata;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<FileMetadata>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939201, XrefRangeEnd = 939220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_DeleteCache_Public_Result_byref_DeleteCacheOptions_Object_OnDeleteCacheCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939220, XrefRangeEnd = 939228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetFileMetadataCount(ref GetFileMetadataCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_GetFileMetadataCount_Public_UInt32_byref_GetFileMetadataCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939228, XrefRangeEnd = 939247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryFile(
      ref QueryFileOptions options,
      Il2CppSystem.Object clientData,
      OnQueryFileCompleteCallback completionCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_QueryFile_Public_Void_byref_QueryFileOptions_Object_OnQueryFileCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939247, XrefRangeEnd = 939266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryFileList(
      ref QueryFileListOptions options,
      Il2CppSystem.Object clientData,
      OnQueryFileListCompleteCallback completionCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionCallback);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_QueryFileList_Public_Void_byref_QueryFileListOptions_Object_OnQueryFileListCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939266, XrefRangeEnd = 939298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TitleStorageFileTransferRequest ReadFile(
      ref ReadFileOptions options,
      Il2CppSystem.Object clientData,
      OnReadFileCompleteCallback completionCallback)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionCallback);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_ReadFile_Public_TitleStorageFileTransferRequest_byref_ReadFileOptions_Object_OnReadFileCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (TitleStorageFileTransferRequest) null : new TitleStorageFileTransferRequest(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939298, XrefRangeEnd = 939305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnDeleteCacheCompleteCallbackInternalImplementation(
      ref DeleteCacheCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_OnDeleteCacheCompleteCallbackInternalImplementation_Internal_Static_Void_byref_DeleteCacheCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939305, XrefRangeEnd = 939317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnFileTransferProgressCallbackInternalImplementation(
      ref FileTransferProgressCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_OnFileTransferProgressCallbackInternalImplementation_Internal_Static_Void_byref_FileTransferProgressCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939317, XrefRangeEnd = 939324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryFileCompleteCallbackInternalImplementation(
      ref QueryFileCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_OnQueryFileCompleteCallbackInternalImplementation_Internal_Static_Void_byref_QueryFileCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939324, XrefRangeEnd = 939331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryFileListCompleteCallbackInternalImplementation(
      ref QueryFileListCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_OnQueryFileListCompleteCallbackInternalImplementation_Internal_Static_Void_byref_QueryFileListCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939331, XrefRangeEnd = 939338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnReadFileCompleteCallbackInternalImplementation(
      ref ReadFileCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_OnReadFileCompleteCallbackInternalImplementation_Internal_Static_Void_byref_ReadFileCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939338, XrefRangeEnd = 939350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ReadResult OnReadFileDataCallbackInternalImplementation(
      ref ReadFileDataCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TitleStorageInterface.NativeMethodInfoPtr_OnReadFileDataCallbackInternalImplementation_Internal_Static_ReadResult_byref_ReadFileDataCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ReadResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TitleStorageInterface()
    {
      Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.TitleStorage", nameof (TitleStorageInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr);
      TitleStorageInterface.NativeFieldInfoPtr_CopyfilemetadataatindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (CopyfilemetadataatindexApiLatest));
      TitleStorageInterface.NativeFieldInfoPtr_CopyfilemetadataatindexoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (CopyfilemetadataatindexoptionsApiLatest));
      TitleStorageInterface.NativeFieldInfoPtr_CopyfilemetadatabyfilenameApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (CopyfilemetadatabyfilenameApiLatest));
      TitleStorageInterface.NativeFieldInfoPtr_CopyfilemetadatabyfilenameoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (CopyfilemetadatabyfilenameoptionsApiLatest));
      TitleStorageInterface.NativeFieldInfoPtr_DeletecacheApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (DeletecacheApiLatest));
      TitleStorageInterface.NativeFieldInfoPtr_DeletecacheoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (DeletecacheoptionsApiLatest));
      TitleStorageInterface.NativeFieldInfoPtr_FilemetadataApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (FilemetadataApiLatest));
      TitleStorageInterface.NativeFieldInfoPtr_FilenameMaxLengthBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (FilenameMaxLengthBytes));
      TitleStorageInterface.NativeFieldInfoPtr_GetfilemetadatacountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (GetfilemetadatacountApiLatest));
      TitleStorageInterface.NativeFieldInfoPtr_GetfilemetadatacountoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (GetfilemetadatacountoptionsApiLatest));
      TitleStorageInterface.NativeFieldInfoPtr_QueryfileApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (QueryfileApiLatest));
      TitleStorageInterface.NativeFieldInfoPtr_QueryfilelistApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (QueryfilelistApiLatest));
      TitleStorageInterface.NativeFieldInfoPtr_QueryfilelistoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (QueryfilelistoptionsApiLatest));
      TitleStorageInterface.NativeFieldInfoPtr_QueryfileoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (QueryfileoptionsApiLatest));
      TitleStorageInterface.NativeFieldInfoPtr_ReadfileApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (ReadfileApiLatest));
      TitleStorageInterface.NativeFieldInfoPtr_ReadfileoptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, nameof (ReadfileoptionsApiLatest));
      TitleStorageInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665675);
      TitleStorageInterface.NativeMethodInfoPtr_CopyFileMetadataAtIndex_Public_Result_byref_CopyFileMetadataAtIndexOptions_byref_Nullable_1_FileMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665677);
      TitleStorageInterface.NativeMethodInfoPtr_CopyFileMetadataByFilename_Public_Result_byref_CopyFileMetadataByFilenameOptions_byref_Nullable_1_FileMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665678);
      TitleStorageInterface.NativeMethodInfoPtr_DeleteCache_Public_Result_byref_DeleteCacheOptions_Object_OnDeleteCacheCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665679);
      TitleStorageInterface.NativeMethodInfoPtr_GetFileMetadataCount_Public_UInt32_byref_GetFileMetadataCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665680);
      TitleStorageInterface.NativeMethodInfoPtr_QueryFile_Public_Void_byref_QueryFileOptions_Object_OnQueryFileCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665681);
      TitleStorageInterface.NativeMethodInfoPtr_QueryFileList_Public_Void_byref_QueryFileListOptions_Object_OnQueryFileListCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665682);
      TitleStorageInterface.NativeMethodInfoPtr_ReadFile_Public_TitleStorageFileTransferRequest_byref_ReadFileOptions_Object_OnReadFileCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665683);
      TitleStorageInterface.NativeMethodInfoPtr_OnDeleteCacheCompleteCallbackInternalImplementation_Internal_Static_Void_byref_DeleteCacheCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665684);
      TitleStorageInterface.NativeMethodInfoPtr_OnFileTransferProgressCallbackInternalImplementation_Internal_Static_Void_byref_FileTransferProgressCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665685);
      TitleStorageInterface.NativeMethodInfoPtr_OnQueryFileCompleteCallbackInternalImplementation_Internal_Static_Void_byref_QueryFileCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665686);
      TitleStorageInterface.NativeMethodInfoPtr_OnQueryFileListCompleteCallbackInternalImplementation_Internal_Static_Void_byref_QueryFileListCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665687);
      TitleStorageInterface.NativeMethodInfoPtr_OnReadFileCompleteCallbackInternalImplementation_Internal_Static_Void_byref_ReadFileCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665688);
      TitleStorageInterface.NativeMethodInfoPtr_OnReadFileDataCallbackInternalImplementation_Internal_Static_ReadResult_byref_ReadFileDataCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageInterface>.NativeClassPtr, 100665689);
    }

    public TitleStorageInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int CopyfilemetadataatindexApiLatest
    {
      get
      {
        int copyfilemetadataatindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_CopyfilemetadataatindexApiLatest, (void*) &copyfilemetadataatindexApiLatest);
        return copyfilemetadataatindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_CopyfilemetadataatindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyfilemetadataatindexoptionsApiLatest
    {
      get
      {
        int copyfilemetadataatindexoptionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_CopyfilemetadataatindexoptionsApiLatest, (void*) &copyfilemetadataatindexoptionsApiLatest);
        return copyfilemetadataatindexoptionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_CopyfilemetadataatindexoptionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyfilemetadatabyfilenameApiLatest
    {
      get
      {
        int copyfilemetadatabyfilenameApiLatest;
        IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_CopyfilemetadatabyfilenameApiLatest, (void*) &copyfilemetadatabyfilenameApiLatest);
        return copyfilemetadatabyfilenameApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_CopyfilemetadatabyfilenameApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyfilemetadatabyfilenameoptionsApiLatest
    {
      get
      {
        int copyfilemetadatabyfilenameoptionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_CopyfilemetadatabyfilenameoptionsApiLatest, (void*) &copyfilemetadatabyfilenameoptionsApiLatest);
        return copyfilemetadatabyfilenameoptionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_CopyfilemetadatabyfilenameoptionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int DeletecacheApiLatest
    {
      get
      {
        int deletecacheApiLatest;
        IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_DeletecacheApiLatest, (void*) &deletecacheApiLatest);
        return deletecacheApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_DeletecacheApiLatest, (void*) &value);
      }
    }

    public static unsafe int DeletecacheoptionsApiLatest
    {
      get
      {
        int deletecacheoptionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_DeletecacheoptionsApiLatest, (void*) &deletecacheoptionsApiLatest);
        return deletecacheoptionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_DeletecacheoptionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int FilemetadataApiLatest
    {
      get
      {
        int filemetadataApiLatest;
        IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_FilemetadataApiLatest, (void*) &filemetadataApiLatest);
        return filemetadataApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_FilemetadataApiLatest, (void*) &value);
      }
    }

    public static unsafe int FilenameMaxLengthBytes
    {
      get
      {
        int filenameMaxLengthBytes;
        IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_FilenameMaxLengthBytes, (void*) &filenameMaxLengthBytes);
        return filenameMaxLengthBytes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_FilenameMaxLengthBytes, (void*) &value);
      }
    }

    public static unsafe int GetfilemetadatacountApiLatest
    {
      get
      {
        int getfilemetadatacountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_GetfilemetadatacountApiLatest, (void*) &getfilemetadatacountApiLatest);
        return getfilemetadatacountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_GetfilemetadatacountApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetfilemetadatacountoptionsApiLatest
    {
      get
      {
        int getfilemetadatacountoptionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_GetfilemetadatacountoptionsApiLatest, (void*) &getfilemetadatacountoptionsApiLatest);
        return getfilemetadatacountoptionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_GetfilemetadatacountoptionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryfileApiLatest
    {
      get
      {
        int queryfileApiLatest;
        IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_QueryfileApiLatest, (void*) &queryfileApiLatest);
        return queryfileApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_QueryfileApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryfilelistApiLatest
    {
      get
      {
        int queryfilelistApiLatest;
        IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_QueryfilelistApiLatest, (void*) &queryfilelistApiLatest);
        return queryfilelistApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_QueryfilelistApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryfilelistoptionsApiLatest
    {
      get
      {
        int queryfilelistoptionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_QueryfilelistoptionsApiLatest, (void*) &queryfilelistoptionsApiLatest);
        return queryfilelistoptionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_QueryfilelistoptionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryfileoptionsApiLatest
    {
      get
      {
        int queryfileoptionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_QueryfileoptionsApiLatest, (void*) &queryfileoptionsApiLatest);
        return queryfileoptionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_QueryfileoptionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int ReadfileApiLatest
    {
      get
      {
        int readfileApiLatest;
        IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_ReadfileApiLatest, (void*) &readfileApiLatest);
        return readfileApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_ReadfileApiLatest, (void*) &value);
      }
    }

    public static unsafe int ReadfileoptionsApiLatest
    {
      get
      {
        int readfileoptionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(TitleStorageInterface.NativeFieldInfoPtr_ReadfileoptionsApiLatest, (void*) &readfileoptionsApiLatest);
        return readfileoptionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TitleStorageInterface.NativeFieldInfoPtr_ReadfileoptionsApiLatest, (void*) &value);
      }
    }
  }
}
