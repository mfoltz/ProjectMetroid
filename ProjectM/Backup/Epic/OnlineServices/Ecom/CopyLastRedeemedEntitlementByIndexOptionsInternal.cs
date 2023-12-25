// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.CopyLastRedeemedEntitlementByIndexOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Ecom
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CopyLastRedeemedEntitlementByIndexOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_RedeemedEntitlementIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RedeemedEntitlementIndex_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CopyLastRedeemedEntitlementByIndexOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CopyLastRedeemedEntitlementByIndexOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(16)]
    public uint m_RedeemedEntitlementIndex;

    public unsafe EpicAccountId LocalUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962063, XrefRangeEnd = 962067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopyLastRedeemedEntitlementByIndexOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint RedeemedEntitlementIndex
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopyLastRedeemedEntitlementByIndexOptionsInternal.NativeMethodInfoPtr_set_RedeemedEntitlementIndex_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 962071, RefRangeEnd = 962072, XrefRangeStart = 962067, XrefRangeEnd = 962071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref CopyLastRedeemedEntitlementByIndexOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CopyLastRedeemedEntitlementByIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CopyLastRedeemedEntitlementByIndexOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962072, XrefRangeEnd = 962082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<CopyLastRedeemedEntitlementByIndexOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CopyLastRedeemedEntitlementByIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CopyLastRedeemedEntitlementByIndexOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962082, XrefRangeEnd = 962086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CopyLastRedeemedEntitlementByIndexOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CopyLastRedeemedEntitlementByIndexOptionsInternal()
    {
      Il2CppClassPointerStore<CopyLastRedeemedEntitlementByIndexOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Ecom", nameof (CopyLastRedeemedEntitlementByIndexOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyLastRedeemedEntitlementByIndexOptionsInternal>.NativeClassPtr);
      CopyLastRedeemedEntitlementByIndexOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLastRedeemedEntitlementByIndexOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      CopyLastRedeemedEntitlementByIndexOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLastRedeemedEntitlementByIndexOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
      CopyLastRedeemedEntitlementByIndexOptionsInternal.NativeFieldInfoPtr_m_RedeemedEntitlementIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLastRedeemedEntitlementByIndexOptionsInternal>.NativeClassPtr, nameof (m_RedeemedEntitlementIndex));
      CopyLastRedeemedEntitlementByIndexOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLastRedeemedEntitlementByIndexOptionsInternal>.NativeClassPtr, 100671933);
      CopyLastRedeemedEntitlementByIndexOptionsInternal.NativeMethodInfoPtr_set_RedeemedEntitlementIndex_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLastRedeemedEntitlementByIndexOptionsInternal>.NativeClassPtr, 100671934);
      CopyLastRedeemedEntitlementByIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CopyLastRedeemedEntitlementByIndexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLastRedeemedEntitlementByIndexOptionsInternal>.NativeClassPtr, 100671935);
      CopyLastRedeemedEntitlementByIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CopyLastRedeemedEntitlementByIndexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLastRedeemedEntitlementByIndexOptionsInternal>.NativeClassPtr, 100671936);
      CopyLastRedeemedEntitlementByIndexOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLastRedeemedEntitlementByIndexOptionsInternal>.NativeClassPtr, 100671937);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CopyLastRedeemedEntitlementByIndexOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
