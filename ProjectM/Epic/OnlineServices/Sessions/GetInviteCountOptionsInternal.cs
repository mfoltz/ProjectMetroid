﻿// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.GetInviteCountOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GetInviteCountOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_GetInviteCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_GetInviteCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_LocalUserId;

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940776, XrefRangeEnd = 940780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GetInviteCountOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 940784, RefRangeEnd = 940785, XrefRangeStart = 940780, XrefRangeEnd = 940784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref GetInviteCountOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetInviteCountOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_GetInviteCountOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940785, XrefRangeEnd = 940793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<GetInviteCountOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetInviteCountOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_GetInviteCountOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940793, XrefRangeEnd = 940797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetInviteCountOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GetInviteCountOptionsInternal()
    {
      Il2CppClassPointerStore<GetInviteCountOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Sessions", nameof (GetInviteCountOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetInviteCountOptionsInternal>.NativeClassPtr);
      GetInviteCountOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetInviteCountOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      GetInviteCountOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetInviteCountOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
      GetInviteCountOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetInviteCountOptionsInternal>.NativeClassPtr, 100666042);
      GetInviteCountOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_GetInviteCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetInviteCountOptionsInternal>.NativeClassPtr, 100666043);
      GetInviteCountOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_GetInviteCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetInviteCountOptionsInternal>.NativeClassPtr, 100666044);
      GetInviteCountOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetInviteCountOptionsInternal>.NativeClassPtr, 100666045);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetInviteCountOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
