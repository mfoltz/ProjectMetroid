// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionDetailsSettingsInternal
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
  public struct SessionDetailsSettingsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_BucketId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_NumPublicConnections;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AllowJoinInProgress;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PermissionLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_InvitesAllowed;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SanctionsEnabled;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_BucketId_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_BucketId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NumPublicConnections_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_NumPublicConnections_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AllowJoinInProgress_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AllowJoinInProgress_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PermissionLevel_Public_get_OnlineSessionPermissionLevel_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PermissionLevel_Public_set_Void_OnlineSessionPermissionLevel_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_InvitesAllowed_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_InvitesAllowed_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SanctionsEnabled_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SanctionsEnabled_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SessionDetailsSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_SessionDetailsSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_SessionDetailsSettings_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_BucketId;
    [FieldOffset(16)]
    public uint m_NumPublicConnections;
    [FieldOffset(20)]
    public int m_AllowJoinInProgress;
    [FieldOffset(24)]
    public OnlineSessionPermissionLevel m_PermissionLevel;
    [FieldOffset(28)]
    public int m_InvitesAllowed;
    [FieldOffset(32)]
    public int m_SanctionsEnabled;

    public unsafe Epic.OnlineServices.Utf8String BucketId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941705, XrefRangeEnd = 941709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_BucketId_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941709, XrefRangeEnd = 941713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_BucketId_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint NumPublicConnections
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 23501, RefRangeEnd = 23506, XrefRangeStart = 23501, XrefRangeEnd = 23506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_NumPublicConnections_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_NumPublicConnections_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool AllowJoinInProgress
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941713, XrefRangeEnd = 941717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_AllowJoinInProgress_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941717, XrefRangeEnd = 941721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_AllowJoinInProgress_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe OnlineSessionPermissionLevel PermissionLevel
    {
      [CallerCount(264), CachedScanResults(RefRangeStart = 39170, RefRangeEnd = 39434, XrefRangeStart = 39170, XrefRangeEnd = 39434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_PermissionLevel_Public_get_OnlineSessionPermissionLevel_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(OnlineSessionPermissionLevel*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 20483, RefRangeEnd = 20486, XrefRangeStart = 20483, XrefRangeEnd = 20486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_PermissionLevel_Public_set_Void_OnlineSessionPermissionLevel_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool InvitesAllowed
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941721, XrefRangeEnd = 941725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_InvitesAllowed_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941725, XrefRangeEnd = 941729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_InvitesAllowed_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool SanctionsEnabled
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941729, XrefRangeEnd = 941733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_SanctionsEnabled_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941733, XrefRangeEnd = 941737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_SanctionsEnabled_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941737, XrefRangeEnd = 941753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref SessionDetailsSettings other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SessionDetailsSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941753, XrefRangeEnd = 941783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<SessionDetailsSettings> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_SessionDetailsSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941783, XrefRangeEnd = 941787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941787, XrefRangeEnd = 941788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out SessionDetailsSettings output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionDetailsSettingsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_SessionDetailsSettings_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref SessionDetailsSettings local = ref output;
      System.IntPtr pointer = zero;
      SessionDetailsSettings sessionDetailsSettings = pointer == System.IntPtr.Zero ? (SessionDetailsSettings) null : new SessionDetailsSettings(pointer);
      local = sessionDetailsSettings;
    }

    static SessionDetailsSettingsInternal()
    {
      Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Sessions", nameof (SessionDetailsSettingsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr);
      SessionDetailsSettingsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      SessionDetailsSettingsInternal.NativeFieldInfoPtr_m_BucketId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, nameof (m_BucketId));
      SessionDetailsSettingsInternal.NativeFieldInfoPtr_m_NumPublicConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, nameof (m_NumPublicConnections));
      SessionDetailsSettingsInternal.NativeFieldInfoPtr_m_AllowJoinInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, nameof (m_AllowJoinInProgress));
      SessionDetailsSettingsInternal.NativeFieldInfoPtr_m_PermissionLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, nameof (m_PermissionLevel));
      SessionDetailsSettingsInternal.NativeFieldInfoPtr_m_InvitesAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, nameof (m_InvitesAllowed));
      SessionDetailsSettingsInternal.NativeFieldInfoPtr_m_SanctionsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, nameof (m_SanctionsEnabled));
      SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_BucketId_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100666397);
      SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_BucketId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100666398);
      SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_NumPublicConnections_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100666399);
      SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_NumPublicConnections_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100666400);
      SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_AllowJoinInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100666401);
      SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_AllowJoinInProgress_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100666402);
      SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_PermissionLevel_Public_get_OnlineSessionPermissionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100666403);
      SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_PermissionLevel_Public_set_Void_OnlineSessionPermissionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100666404);
      SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_InvitesAllowed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100666405);
      SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_InvitesAllowed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100666406);
      SessionDetailsSettingsInternal.NativeMethodInfoPtr_get_SanctionsEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100666407);
      SessionDetailsSettingsInternal.NativeMethodInfoPtr_set_SanctionsEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100666408);
      SessionDetailsSettingsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SessionDetailsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100666409);
      SessionDetailsSettingsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_SessionDetailsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100666410);
      SessionDetailsSettingsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100666411);
      SessionDetailsSettingsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_SessionDetailsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, 100666412);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SessionDetailsSettingsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
