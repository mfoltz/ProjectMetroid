// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.JoinLobbyOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby
{
  [StructLayout(LayoutKind.Explicit)]
  public struct JoinLobbyOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LobbyDetailsHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PresenceEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalRTCOptions;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LobbyDetailsHandle_Public_set_Void_LobbyDetails_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalRTCOptions_Public_set_Void_Nullable_Unboxed_1_LocalRTCOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_JoinLobbyOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_JoinLobbyOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_LobbyDetailsHandle;
    [FieldOffset(16)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(24)]
    public int m_PresenceEnabled;
    [FieldOffset(32)]
    public System.IntPtr m_LocalRTCOptions;

    public unsafe LobbyDetails LobbyDetailsHandle
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955003, XrefRangeEnd = 955007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptionsInternal.NativeMethodInfoPtr_set_LobbyDetailsHandle_Public_set_Void_LobbyDetails_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955007, XrefRangeEnd = 955011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool PresenceEnabled
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955011, XrefRangeEnd = 955015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptionsInternal.NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<Epic.OnlineServices.Lobby.LocalRTCOptions> LocalRTCOptions
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955015, XrefRangeEnd = 955021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptionsInternal.NativeMethodInfoPtr_set_LocalRTCOptions_Public_set_Void_Nullable_Unboxed_1_LocalRTCOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 955039, RefRangeEnd = 955040, XrefRangeStart = 955021, XrefRangeEnd = 955039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref JoinLobbyOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_JoinLobbyOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955040, XrefRangeEnd = 955068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<JoinLobbyOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_JoinLobbyOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 955068, XrefRangeEnd = 955074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static JoinLobbyOptionsInternal()
    {
      Il2CppClassPointerStore<JoinLobbyOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Lobby", nameof (JoinLobbyOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinLobbyOptionsInternal>.NativeClassPtr);
      JoinLobbyOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinLobbyOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      JoinLobbyOptionsInternal.NativeFieldInfoPtr_m_LobbyDetailsHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinLobbyOptionsInternal>.NativeClassPtr, nameof (m_LobbyDetailsHandle));
      JoinLobbyOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinLobbyOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
      JoinLobbyOptionsInternal.NativeFieldInfoPtr_m_PresenceEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinLobbyOptionsInternal>.NativeClassPtr, nameof (m_PresenceEnabled));
      JoinLobbyOptionsInternal.NativeFieldInfoPtr_m_LocalRTCOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinLobbyOptionsInternal>.NativeClassPtr, nameof (m_LocalRTCOptions));
      JoinLobbyOptionsInternal.NativeMethodInfoPtr_set_LobbyDetailsHandle_Public_set_Void_LobbyDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptionsInternal>.NativeClassPtr, 100669934);
      JoinLobbyOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptionsInternal>.NativeClassPtr, 100669935);
      JoinLobbyOptionsInternal.NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptionsInternal>.NativeClassPtr, 100669936);
      JoinLobbyOptionsInternal.NativeMethodInfoPtr_set_LocalRTCOptions_Public_set_Void_Nullable_Unboxed_1_LocalRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptionsInternal>.NativeClassPtr, 100669937);
      JoinLobbyOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_JoinLobbyOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptionsInternal>.NativeClassPtr, 100669938);
      JoinLobbyOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_JoinLobbyOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptionsInternal>.NativeClassPtr, 100669939);
      JoinLobbyOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptionsInternal>.NativeClassPtr, 100669940);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JoinLobbyOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
