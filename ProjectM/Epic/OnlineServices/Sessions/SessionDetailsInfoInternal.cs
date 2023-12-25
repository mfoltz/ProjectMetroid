// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionDetailsInfoInternal
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
  public struct SessionDetailsInfoInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SessionId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_HostAddress;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_NumOpenPublicConnections;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Settings;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SessionId_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SessionId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HostAddress_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_HostAddress_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NumOpenPublicConnections_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_NumOpenPublicConnections_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Settings_Public_get_Nullable_1_SessionDetailsSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Settings_Public_set_Void_Nullable_1_SessionDetailsSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SessionDetailsInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_SessionDetailsInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_SessionDetailsInfo_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_SessionId;
    [FieldOffset(16)]
    public System.IntPtr m_HostAddress;
    [FieldOffset(24)]
    public uint m_NumOpenPublicConnections;
    [FieldOffset(32)]
    public System.IntPtr m_Settings;

    public unsafe Epic.OnlineServices.Utf8String SessionId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941614, XrefRangeEnd = 941618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfoInternal.NativeMethodInfoPtr_get_SessionId_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941618, XrefRangeEnd = 941622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfoInternal.NativeMethodInfoPtr_set_SessionId_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String HostAddress
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941622, XrefRangeEnd = 941626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfoInternal.NativeMethodInfoPtr_get_HostAddress_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941626, XrefRangeEnd = 941630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfoInternal.NativeMethodInfoPtr_set_HostAddress_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint NumOpenPublicConnections
    {
      [CallerCount(264), CachedScanResults(RefRangeStart = 39170, RefRangeEnd = 39434, XrefRangeStart = 39170, XrefRangeEnd = 39434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfoInternal.NativeMethodInfoPtr_get_NumOpenPublicConnections_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 20483, RefRangeEnd = 20486, XrefRangeStart = 20483, XrefRangeEnd = 20486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfoInternal.NativeMethodInfoPtr_set_NumOpenPublicConnections_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppSystem.Nullable<SessionDetailsSettings> Settings
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941630, XrefRangeEnd = 941636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfoInternal.NativeMethodInfoPtr_get_Settings_Public_get_Nullable_1_SessionDetailsSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new Il2CppSystem.Nullable<SessionDetailsSettings>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941636, XrefRangeEnd = 941642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfoInternal.NativeMethodInfoPtr_set_Settings_Public_set_Void_Nullable_1_SessionDetailsSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941642, XrefRangeEnd = 941656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref SessionDetailsInfo other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SessionDetailsInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941656, XrefRangeEnd = 941680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<SessionDetailsInfo> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_SessionDetailsInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941680, XrefRangeEnd = 941686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941686, XrefRangeEnd = 941687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out SessionDetailsInfo output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_SessionDetailsInfo_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref SessionDetailsInfo local = ref output;
      System.IntPtr pointer = zero;
      SessionDetailsInfo sessionDetailsInfo = pointer == System.IntPtr.Zero ? (SessionDetailsInfo) null : new SessionDetailsInfo(pointer);
      local = sessionDetailsInfo;
    }

    static SessionDetailsInfoInternal()
    {
      Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Sessions", nameof (SessionDetailsInfoInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr);
      SessionDetailsInfoInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, nameof (m_ApiVersion));
      SessionDetailsInfoInternal.NativeFieldInfoPtr_m_SessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, nameof (m_SessionId));
      SessionDetailsInfoInternal.NativeFieldInfoPtr_m_HostAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, nameof (m_HostAddress));
      SessionDetailsInfoInternal.NativeFieldInfoPtr_m_NumOpenPublicConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, nameof (m_NumOpenPublicConnections));
      SessionDetailsInfoInternal.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, nameof (m_Settings));
      SessionDetailsInfoInternal.NativeMethodInfoPtr_get_SessionId_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, 100666372);
      SessionDetailsInfoInternal.NativeMethodInfoPtr_set_SessionId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, 100666373);
      SessionDetailsInfoInternal.NativeMethodInfoPtr_get_HostAddress_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, 100666374);
      SessionDetailsInfoInternal.NativeMethodInfoPtr_set_HostAddress_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, 100666375);
      SessionDetailsInfoInternal.NativeMethodInfoPtr_get_NumOpenPublicConnections_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, 100666376);
      SessionDetailsInfoInternal.NativeMethodInfoPtr_set_NumOpenPublicConnections_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, 100666377);
      SessionDetailsInfoInternal.NativeMethodInfoPtr_get_Settings_Public_get_Nullable_1_SessionDetailsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, 100666378);
      SessionDetailsInfoInternal.NativeMethodInfoPtr_set_Settings_Public_set_Void_Nullable_1_SessionDetailsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, 100666379);
      SessionDetailsInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SessionDetailsInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, 100666380);
      SessionDetailsInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_SessionDetailsInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, 100666381);
      SessionDetailsInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, 100666382);
      SessionDetailsInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_SessionDetailsInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, 100666383);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SessionDetailsInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
