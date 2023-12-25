// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTC.JoinRoomOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTC
{
  [StructLayout(LayoutKind.Explicit)]
  public struct JoinRoomOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_RoomName;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientBaseUrl;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ParticipantToken;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ParticipantId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ManualAudioInputEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ManualAudioOutputEnabled;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RoomName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientBaseUrl_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ParticipantToken_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ParticipantId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Flags_Public_set_Void_JoinRoomFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ManualAudioInputEnabled_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ManualAudioOutputEnabled_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_JoinRoomOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_JoinRoomOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(16)]
    public System.IntPtr m_RoomName;
    [FieldOffset(24)]
    public System.IntPtr m_ClientBaseUrl;
    [FieldOffset(32)]
    public System.IntPtr m_ParticipantToken;
    [FieldOffset(40)]
    public System.IntPtr m_ParticipantId;
    [FieldOffset(48)]
    public JoinRoomFlags m_Flags;
    [FieldOffset(52)]
    public int m_ManualAudioInputEnabled;
    [FieldOffset(56)]
    public int m_ManualAudioOutputEnabled;

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947007, XrefRangeEnd = 947011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JoinRoomOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String RoomName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947011, XrefRangeEnd = 947015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JoinRoomOptionsInternal.NativeMethodInfoPtr_set_RoomName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String ClientBaseUrl
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947015, XrefRangeEnd = 947019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JoinRoomOptionsInternal.NativeMethodInfoPtr_set_ClientBaseUrl_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String ParticipantToken
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947019, XrefRangeEnd = 947023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JoinRoomOptionsInternal.NativeMethodInfoPtr_set_ParticipantToken_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId ParticipantId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947023, XrefRangeEnd = 947027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JoinRoomOptionsInternal.NativeMethodInfoPtr_set_ParticipantId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe JoinRoomFlags Flags
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 42947, RefRangeEnd = 42948, XrefRangeStart = 42947, XrefRangeEnd = 42948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JoinRoomOptionsInternal.NativeMethodInfoPtr_set_Flags_Public_set_Void_JoinRoomFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool ManualAudioInputEnabled
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947027, XrefRangeEnd = 947031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JoinRoomOptionsInternal.NativeMethodInfoPtr_set_ManualAudioInputEnabled_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool ManualAudioOutputEnabled
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947031, XrefRangeEnd = 947035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JoinRoomOptionsInternal.NativeMethodInfoPtr_set_ManualAudioOutputEnabled_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 947063, RefRangeEnd = 947064, XrefRangeStart = 947035, XrefRangeEnd = 947063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref JoinRoomOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JoinRoomOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_JoinRoomOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947064, XrefRangeEnd = 947110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<JoinRoomOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JoinRoomOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_JoinRoomOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947110, XrefRangeEnd = 947118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JoinRoomOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static JoinRoomOptionsInternal()
    {
      Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.RTC", nameof (JoinRoomOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr);
      JoinRoomOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      JoinRoomOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
      JoinRoomOptionsInternal.NativeFieldInfoPtr_m_RoomName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, nameof (m_RoomName));
      JoinRoomOptionsInternal.NativeFieldInfoPtr_m_ClientBaseUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, nameof (m_ClientBaseUrl));
      JoinRoomOptionsInternal.NativeFieldInfoPtr_m_ParticipantToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, nameof (m_ParticipantToken));
      JoinRoomOptionsInternal.NativeFieldInfoPtr_m_ParticipantId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, nameof (m_ParticipantId));
      JoinRoomOptionsInternal.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, nameof (m_Flags));
      JoinRoomOptionsInternal.NativeFieldInfoPtr_m_ManualAudioInputEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, nameof (m_ManualAudioInputEnabled));
      JoinRoomOptionsInternal.NativeFieldInfoPtr_m_ManualAudioOutputEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, nameof (m_ManualAudioOutputEnabled));
      JoinRoomOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, 100667798);
      JoinRoomOptionsInternal.NativeMethodInfoPtr_set_RoomName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, 100667799);
      JoinRoomOptionsInternal.NativeMethodInfoPtr_set_ClientBaseUrl_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, 100667800);
      JoinRoomOptionsInternal.NativeMethodInfoPtr_set_ParticipantToken_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, 100667801);
      JoinRoomOptionsInternal.NativeMethodInfoPtr_set_ParticipantId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, 100667802);
      JoinRoomOptionsInternal.NativeMethodInfoPtr_set_Flags_Public_set_Void_JoinRoomFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, 100667803);
      JoinRoomOptionsInternal.NativeMethodInfoPtr_set_ManualAudioInputEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, 100667804);
      JoinRoomOptionsInternal.NativeMethodInfoPtr_set_ManualAudioOutputEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, 100667805);
      JoinRoomOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_JoinRoomOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, 100667806);
      JoinRoomOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_JoinRoomOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, 100667807);
      JoinRoomOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, 100667808);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JoinRoomOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
