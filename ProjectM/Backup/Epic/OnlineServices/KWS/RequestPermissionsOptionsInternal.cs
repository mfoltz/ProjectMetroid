// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.KWS.RequestPermissionsOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.KWS
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RequestPermissionsOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PermissionKeyCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PermissionKeys;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PermissionKeys_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_RequestPermissionsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_RequestPermissionsOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(16)]
    public uint m_PermissionKeyCount;
    [FieldOffset(24)]
    public System.IntPtr m_PermissionKeys;

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960118, XrefRangeEnd = 960122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RequestPermissionsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppReferenceArray<Epic.OnlineServices.Utf8String> PermissionKeys
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 960128, RefRangeEnd = 960130, XrefRangeStart = 960122, XrefRangeEnd = 960128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RequestPermissionsOptionsInternal.NativeMethodInfoPtr_set_PermissionKeys_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 960135, RefRangeEnd = 960136, XrefRangeStart = 960130, XrefRangeEnd = 960135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref RequestPermissionsOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RequestPermissionsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_RequestPermissionsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960136, XrefRangeEnd = 960147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<RequestPermissionsOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RequestPermissionsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_RequestPermissionsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960147, XrefRangeEnd = 960152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RequestPermissionsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RequestPermissionsOptionsInternal()
    {
      Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.KWS", nameof (RequestPermissionsOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr);
      RequestPermissionsOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      RequestPermissionsOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
      RequestPermissionsOptionsInternal.NativeFieldInfoPtr_m_PermissionKeyCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr, nameof (m_PermissionKeyCount));
      RequestPermissionsOptionsInternal.NativeFieldInfoPtr_m_PermissionKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr, nameof (m_PermissionKeys));
      RequestPermissionsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr, 100671357);
      RequestPermissionsOptionsInternal.NativeMethodInfoPtr_set_PermissionKeys_Public_set_Void_Il2CppReferenceArray_1_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr, 100671358);
      RequestPermissionsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_RequestPermissionsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr, 100671359);
      RequestPermissionsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_RequestPermissionsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr, 100671360);
      RequestPermissionsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr, 100671361);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
