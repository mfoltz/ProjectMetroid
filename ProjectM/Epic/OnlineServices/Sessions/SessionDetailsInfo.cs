﻿// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionDetailsInfo
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
  public sealed class SessionDetailsInfo : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SessionId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__HostAddress_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__NumOpenPublicConnections_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Settings_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SessionId_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SessionId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HostAddress_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_HostAddress_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NumOpenPublicConnections_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_NumOpenPublicConnections_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Settings_Public_get_Nullable_1_SessionDetailsSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Settings_Public_set_Void_Nullable_1_SessionDetailsSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_SessionDetailsInfoInternal_0;

    public unsafe Epic.OnlineServices.Utf8String SessionId
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfo.NativeMethodInfoPtr_get_SessionId_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfo.NativeMethodInfoPtr_set_SessionId_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String HostAddress
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfo.NativeMethodInfoPtr_get_HostAddress_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 318047, RefRangeEnd = 318048, XrefRangeStart = 318047, XrefRangeEnd = 318048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfo.NativeMethodInfoPtr_set_HostAddress_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint NumOpenPublicConnections
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 23501, RefRangeEnd = 23506, XrefRangeStart = 23501, XrefRangeEnd = 23506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfo.NativeMethodInfoPtr_get_NumOpenPublicConnections_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfo.NativeMethodInfoPtr_set_NumOpenPublicConnections_Public_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppSystem.Nullable<SessionDetailsSettings> Settings
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfo.NativeMethodInfoPtr_get_Settings_Public_get_Nullable_1_SessionDetailsSettings_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new Il2CppSystem.Nullable<SessionDetailsSettings>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941595, XrefRangeEnd = 941596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfo.NativeMethodInfoPtr_set_Settings_Public_set_Void_Nullable_1_SessionDetailsSettings_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 941613, RefRangeEnd = 941614, XrefRangeStart = 941596, XrefRangeEnd = 941613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref SessionDetailsInfoInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionDetailsInfo.NativeMethodInfoPtr_Set_Internal_Void_byref_SessionDetailsInfoInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SessionDetailsInfo()
    {
      Il2CppClassPointerStore<SessionDetailsInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Sessions", nameof (SessionDetailsInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionDetailsInfo>.NativeClassPtr);
      SessionDetailsInfo.NativeFieldInfoPtr__SessionId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsInfo>.NativeClassPtr, "<SessionId>k__BackingField");
      SessionDetailsInfo.NativeFieldInfoPtr__HostAddress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsInfo>.NativeClassPtr, "<HostAddress>k__BackingField");
      SessionDetailsInfo.NativeFieldInfoPtr__NumOpenPublicConnections_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsInfo>.NativeClassPtr, "<NumOpenPublicConnections>k__BackingField");
      SessionDetailsInfo.NativeFieldInfoPtr__Settings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsInfo>.NativeClassPtr, "<Settings>k__BackingField");
      SessionDetailsInfo.NativeMethodInfoPtr_get_SessionId_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfo>.NativeClassPtr, 100666363);
      SessionDetailsInfo.NativeMethodInfoPtr_set_SessionId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfo>.NativeClassPtr, 100666364);
      SessionDetailsInfo.NativeMethodInfoPtr_get_HostAddress_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfo>.NativeClassPtr, 100666365);
      SessionDetailsInfo.NativeMethodInfoPtr_set_HostAddress_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfo>.NativeClassPtr, 100666366);
      SessionDetailsInfo.NativeMethodInfoPtr_get_NumOpenPublicConnections_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfo>.NativeClassPtr, 100666367);
      SessionDetailsInfo.NativeMethodInfoPtr_set_NumOpenPublicConnections_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfo>.NativeClassPtr, 100666368);
      SessionDetailsInfo.NativeMethodInfoPtr_get_Settings_Public_get_Nullable_1_SessionDetailsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfo>.NativeClassPtr, 100666369);
      SessionDetailsInfo.NativeMethodInfoPtr_set_Settings_Public_set_Void_Nullable_1_SessionDetailsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfo>.NativeClassPtr, 100666370);
      SessionDetailsInfo.NativeMethodInfoPtr_Set_Internal_Void_byref_SessionDetailsInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsInfo>.NativeClassPtr, 100666371);
    }

    public SessionDetailsInfo(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public SessionDetailsInfo()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SessionDetailsInfo>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SessionDetailsInfo>.NativeClassPtr, data));
    }

    public unsafe Epic.OnlineServices.Utf8String _SessionId_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionDetailsInfo.NativeFieldInfoPtr__SessionId_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SessionDetailsInfo.NativeFieldInfoPtr__SessionId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _HostAddress_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionDetailsInfo.NativeFieldInfoPtr__HostAddress_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SessionDetailsInfo.NativeFieldInfoPtr__HostAddress_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe uint _NumOpenPublicConnections_k__BackingField
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionDetailsInfo.NativeFieldInfoPtr__NumOpenPublicConnections_k__BackingField));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionDetailsInfo.NativeFieldInfoPtr__NumOpenPublicConnections_k__BackingField)) = value;
      }
    }

    public Il2CppSystem.Nullable<SessionDetailsSettings> _Settings_k__BackingField
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionDetailsInfo.NativeFieldInfoPtr__Settings_k__BackingField);
        return new Il2CppSystem.Nullable<SessionDetailsSettings>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<SessionDetailsSettings>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionDetailsInfo.NativeFieldInfoPtr__Settings_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<SessionDetailsSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
