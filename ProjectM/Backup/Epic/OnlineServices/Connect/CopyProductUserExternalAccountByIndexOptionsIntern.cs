// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.CopyProductUserExternalAccountByIndexOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Connect
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CopyProductUserExternalAccountByIndexOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ExternalAccountInfoIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ExternalAccountInfoIndex_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CopyProductUserExternalAccountByIndexOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CopyProductUserExternalAccountByIndexOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_TargetUserId;
    [FieldOffset(16)]
    public uint m_ExternalAccountInfoIndex;

    public unsafe ProductUserId TargetUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965299, XrefRangeEnd = 965303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopyProductUserExternalAccountByIndexOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint ExternalAccountInfoIndex
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CopyProductUserExternalAccountByIndexOptionsInternal.NativeMethodInfoPtr_set_ExternalAccountInfoIndex_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965303, XrefRangeEnd = 965307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref CopyProductUserExternalAccountByIndexOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CopyProductUserExternalAccountByIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CopyProductUserExternalAccountByIndexOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965307, XrefRangeEnd = 965317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<CopyProductUserExternalAccountByIndexOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CopyProductUserExternalAccountByIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CopyProductUserExternalAccountByIndexOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965317, XrefRangeEnd = 965321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CopyProductUserExternalAccountByIndexOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CopyProductUserExternalAccountByIndexOptionsInternal()
    {
      Il2CppClassPointerStore<CopyProductUserExternalAccountByIndexOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Connect", nameof (CopyProductUserExternalAccountByIndexOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyProductUserExternalAccountByIndexOptionsInternal>.NativeClassPtr);
      CopyProductUserExternalAccountByIndexOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyProductUserExternalAccountByIndexOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      CopyProductUserExternalAccountByIndexOptionsInternal.NativeFieldInfoPtr_m_TargetUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyProductUserExternalAccountByIndexOptionsInternal>.NativeClassPtr, nameof (m_TargetUserId));
      CopyProductUserExternalAccountByIndexOptionsInternal.NativeFieldInfoPtr_m_ExternalAccountInfoIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyProductUserExternalAccountByIndexOptionsInternal>.NativeClassPtr, nameof (m_ExternalAccountInfoIndex));
      CopyProductUserExternalAccountByIndexOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyProductUserExternalAccountByIndexOptionsInternal>.NativeClassPtr, 100672713);
      CopyProductUserExternalAccountByIndexOptionsInternal.NativeMethodInfoPtr_set_ExternalAccountInfoIndex_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyProductUserExternalAccountByIndexOptionsInternal>.NativeClassPtr, 100672714);
      CopyProductUserExternalAccountByIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CopyProductUserExternalAccountByIndexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyProductUserExternalAccountByIndexOptionsInternal>.NativeClassPtr, 100672715);
      CopyProductUserExternalAccountByIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CopyProductUserExternalAccountByIndexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyProductUserExternalAccountByIndexOptionsInternal>.NativeClassPtr, 100672716);
      CopyProductUserExternalAccountByIndexOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyProductUserExternalAccountByIndexOptionsInternal>.NativeClassPtr, 100672717);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CopyProductUserExternalAccountByIndexOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
