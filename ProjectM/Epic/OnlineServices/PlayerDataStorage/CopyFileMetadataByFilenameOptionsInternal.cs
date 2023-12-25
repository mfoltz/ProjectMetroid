﻿// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.PlayerDataStorage.CopyFileMetadataByFilenameOptionsInternal
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
  public struct CopyFileMetadataByFilenameOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Filename;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Filename_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CopyFileMetadataByFilenameOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CopyFileMetadataByFilenameOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(16)]
    public System.IntPtr m_Filename;

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949201, XrefRangeEnd = 949205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopyFileMetadataByFilenameOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String Filename
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949205, XrefRangeEnd = 949209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopyFileMetadataByFilenameOptionsInternal.NativeMethodInfoPtr_set_Filename_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 949217, RefRangeEnd = 949218, XrefRangeStart = 949209, XrefRangeEnd = 949217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref CopyFileMetadataByFilenameOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CopyFileMetadataByFilenameOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CopyFileMetadataByFilenameOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949218, XrefRangeEnd = 949232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<CopyFileMetadataByFilenameOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CopyFileMetadataByFilenameOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CopyFileMetadataByFilenameOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 949232, XrefRangeEnd = 949237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CopyFileMetadataByFilenameOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CopyFileMetadataByFilenameOptionsInternal()
    {
      Il2CppClassPointerStore<CopyFileMetadataByFilenameOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.PlayerDataStorage", nameof (CopyFileMetadataByFilenameOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyFileMetadataByFilenameOptionsInternal>.NativeClassPtr);
      CopyFileMetadataByFilenameOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyFileMetadataByFilenameOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      CopyFileMetadataByFilenameOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyFileMetadataByFilenameOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
      CopyFileMetadataByFilenameOptionsInternal.NativeFieldInfoPtr_m_Filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyFileMetadataByFilenameOptionsInternal>.NativeClassPtr, nameof (m_Filename));
      CopyFileMetadataByFilenameOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyFileMetadataByFilenameOptionsInternal>.NativeClassPtr, 100668377);
      CopyFileMetadataByFilenameOptionsInternal.NativeMethodInfoPtr_set_Filename_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyFileMetadataByFilenameOptionsInternal>.NativeClassPtr, 100668378);
      CopyFileMetadataByFilenameOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CopyFileMetadataByFilenameOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyFileMetadataByFilenameOptionsInternal>.NativeClassPtr, 100668379);
      CopyFileMetadataByFilenameOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CopyFileMetadataByFilenameOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyFileMetadataByFilenameOptionsInternal>.NativeClassPtr, 100668380);
      CopyFileMetadataByFilenameOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyFileMetadataByFilenameOptionsInternal>.NativeClassPtr, 100668381);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CopyFileMetadataByFilenameOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
