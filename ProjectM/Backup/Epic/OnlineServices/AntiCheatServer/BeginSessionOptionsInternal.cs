// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatServer.BeginSessionOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatServer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BeginSessionOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_RegisterTimeoutSeconds;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ServerName;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_EnableGameplayData;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RegisterTimeoutSeconds_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ServerName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EnableGameplayData_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_BeginSessionOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_BeginSessionOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(4)]
    public uint m_RegisterTimeoutSeconds;
    [FieldOffset(8)]
    public System.IntPtr m_ServerName;
    [FieldOffset(16)]
    public int m_EnableGameplayData;
    [FieldOffset(24)]
    public System.IntPtr m_LocalUserId;

    public unsafe uint RegisterTimeoutSeconds
    {
      [CallerCount(14), CachedScanResults(RefRangeStart = 204767, RefRangeEnd = 204781, XrefRangeStart = 204767, XrefRangeEnd = 204781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BeginSessionOptionsInternal.NativeMethodInfoPtr_set_RegisterTimeoutSeconds_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String ServerName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969171, XrefRangeEnd = 969175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BeginSessionOptionsInternal.NativeMethodInfoPtr_set_ServerName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool EnableGameplayData
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969175, XrefRangeEnd = 969179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BeginSessionOptionsInternal.NativeMethodInfoPtr_set_EnableGameplayData_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969179, XrefRangeEnd = 969183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BeginSessionOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 969195, RefRangeEnd = 969196, XrefRangeStart = 969183, XrefRangeEnd = 969195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref BeginSessionOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BeginSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_BeginSessionOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969196, XrefRangeEnd = 969218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<BeginSessionOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BeginSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_BeginSessionOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969218, XrefRangeEnd = 969223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BeginSessionOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BeginSessionOptionsInternal()
    {
      Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatServer", nameof (BeginSessionOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr);
      BeginSessionOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      BeginSessionOptionsInternal.NativeFieldInfoPtr_m_RegisterTimeoutSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, nameof (m_RegisterTimeoutSeconds));
      BeginSessionOptionsInternal.NativeFieldInfoPtr_m_ServerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, nameof (m_ServerName));
      BeginSessionOptionsInternal.NativeFieldInfoPtr_m_EnableGameplayData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, nameof (m_EnableGameplayData));
      BeginSessionOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
      BeginSessionOptionsInternal.NativeMethodInfoPtr_set_RegisterTimeoutSeconds_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, 100673816);
      BeginSessionOptionsInternal.NativeMethodInfoPtr_set_ServerName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, 100673817);
      BeginSessionOptionsInternal.NativeMethodInfoPtr_set_EnableGameplayData_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, 100673818);
      BeginSessionOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, 100673819);
      BeginSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_BeginSessionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, 100673820);
      BeginSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_BeginSessionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, 100673821);
      BeginSessionOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, 100673822);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
