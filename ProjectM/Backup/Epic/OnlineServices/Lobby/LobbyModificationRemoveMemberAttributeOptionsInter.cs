﻿// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.LobbyModificationRemoveMemberAttributeOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LobbyModificationRemoveMemberAttributeOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Key;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Key_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LobbyModificationRemoveMemberAttributeOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LobbyModificationRemoveMemberAttributeOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_Key;

    public unsafe Epic.OnlineServices.Utf8String Key
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957075, XrefRangeEnd = 957079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LobbyModificationRemoveMemberAttributeOptionsInternal.NativeMethodInfoPtr_set_Key_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957079, XrefRangeEnd = 957083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref LobbyModificationRemoveMemberAttributeOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyModificationRemoveMemberAttributeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LobbyModificationRemoveMemberAttributeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957083, XrefRangeEnd = 957091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<LobbyModificationRemoveMemberAttributeOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyModificationRemoveMemberAttributeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LobbyModificationRemoveMemberAttributeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957091, XrefRangeEnd = 957095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyModificationRemoveMemberAttributeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LobbyModificationRemoveMemberAttributeOptionsInternal()
    {
      Il2CppClassPointerStore<LobbyModificationRemoveMemberAttributeOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Lobby", nameof (LobbyModificationRemoveMemberAttributeOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyModificationRemoveMemberAttributeOptionsInternal>.NativeClassPtr);
      LobbyModificationRemoveMemberAttributeOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModificationRemoveMemberAttributeOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      LobbyModificationRemoveMemberAttributeOptionsInternal.NativeFieldInfoPtr_m_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModificationRemoveMemberAttributeOptionsInternal>.NativeClassPtr, nameof (m_Key));
      LobbyModificationRemoveMemberAttributeOptionsInternal.NativeMethodInfoPtr_set_Key_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModificationRemoveMemberAttributeOptionsInternal>.NativeClassPtr, 100670335);
      LobbyModificationRemoveMemberAttributeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LobbyModificationRemoveMemberAttributeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModificationRemoveMemberAttributeOptionsInternal>.NativeClassPtr, 100670336);
      LobbyModificationRemoveMemberAttributeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LobbyModificationRemoveMemberAttributeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModificationRemoveMemberAttributeOptionsInternal>.NativeClassPtr, 100670337);
      LobbyModificationRemoveMemberAttributeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModificationRemoveMemberAttributeOptionsInternal>.NativeClassPtr, 100670338);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyModificationRemoveMemberAttributeOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
