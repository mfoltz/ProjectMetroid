﻿// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.UserInfo.CopyUserInfoOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.UserInfo
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CopyUserInfoOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetUserId;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CopyUserInfoOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CopyUserInfoOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(16)]
    public System.IntPtr m_TargetUserId;

    public unsafe EpicAccountId LocalUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936552, XrefRangeEnd = 936556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopyUserInfoOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe EpicAccountId TargetUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936556, XrefRangeEnd = 936560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopyUserInfoOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 936568, RefRangeEnd = 936569, XrefRangeStart = 936560, XrefRangeEnd = 936568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref CopyUserInfoOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CopyUserInfoOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CopyUserInfoOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936569, XrefRangeEnd = 936583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<CopyUserInfoOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CopyUserInfoOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CopyUserInfoOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936583, XrefRangeEnd = 936588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CopyUserInfoOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CopyUserInfoOptionsInternal()
    {
      Il2CppClassPointerStore<CopyUserInfoOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.UserInfo", nameof (CopyUserInfoOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyUserInfoOptionsInternal>.NativeClassPtr);
      CopyUserInfoOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyUserInfoOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      CopyUserInfoOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyUserInfoOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
      CopyUserInfoOptionsInternal.NativeFieldInfoPtr_m_TargetUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyUserInfoOptionsInternal>.NativeClassPtr, nameof (m_TargetUserId));
      CopyUserInfoOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyUserInfoOptionsInternal>.NativeClassPtr, 100664918);
      CopyUserInfoOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyUserInfoOptionsInternal>.NativeClassPtr, 100664919);
      CopyUserInfoOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CopyUserInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyUserInfoOptionsInternal>.NativeClassPtr, 100664920);
      CopyUserInfoOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CopyUserInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyUserInfoOptionsInternal>.NativeClassPtr, 100664921);
      CopyUserInfoOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyUserInfoOptionsInternal>.NativeClassPtr, 100664922);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CopyUserInfoOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
