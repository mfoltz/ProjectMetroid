// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.EntitlementInternal
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
  public struct EntitlementInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_EntitlementName;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_EntitlementId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_CatalogItemId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ServerIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Redeemed;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_EndTimestamp;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EntitlementName_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EntitlementName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EntitlementId_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EntitlementId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CatalogItemId_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CatalogItemId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ServerIndex_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ServerIndex_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Redeemed_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Redeemed_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EndTimestamp_Public_get_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EndTimestamp_Public_set_Void_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Entitlement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_Entitlement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_Entitlement_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_EntitlementName;
    [FieldOffset(16)]
    public System.IntPtr m_EntitlementId;
    [FieldOffset(24)]
    public System.IntPtr m_CatalogItemId;
    [FieldOffset(32)]
    public int m_ServerIndex;
    [FieldOffset(36)]
    public int m_Redeemed;
    [FieldOffset(40)]
    public long m_EndTimestamp;

    public unsafe Epic.OnlineServices.Utf8String EntitlementName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962729, XrefRangeEnd = 962733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_get_EntitlementName_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962733, XrefRangeEnd = 962737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_set_EntitlementName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String EntitlementId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962737, XrefRangeEnd = 962741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_get_EntitlementId_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962741, XrefRangeEnd = 962745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_set_EntitlementId_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String CatalogItemId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962745, XrefRangeEnd = 962749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_get_CatalogItemId_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962749, XrefRangeEnd = 962753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_set_CatalogItemId_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int ServerIndex
    {
      [CallerCount(36), CachedScanResults(RefRangeStart = 29682, RefRangeEnd = 29718, XrefRangeStart = 29682, XrefRangeEnd = 29718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_get_ServerIndex_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_set_ServerIndex_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool Redeemed
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962753, XrefRangeEnd = 962757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_get_Redeemed_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962757, XrefRangeEnd = 962761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_set_Redeemed_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe long EndTimestamp
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 22440, RefRangeEnd = 22452, XrefRangeStart = 22440, XrefRangeEnd = 22452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_get_EndTimestamp_Public_get_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(long*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_set_EndTimestamp_Public_set_Void_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962761, XrefRangeEnd = 962777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Entitlement other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Entitlement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962777, XrefRangeEnd = 962807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<Entitlement> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_Entitlement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962807, XrefRangeEnd = 962813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962813, XrefRangeEnd = 962814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out Entitlement output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntitlementInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_Entitlement_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Entitlement local = ref output;
      System.IntPtr pointer = zero;
      Entitlement entitlement = pointer == System.IntPtr.Zero ? (Entitlement) null : new Entitlement(pointer);
      local = entitlement;
    }

    static EntitlementInternal()
    {
      Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Ecom", nameof (EntitlementInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr);
      EntitlementInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, nameof (m_ApiVersion));
      EntitlementInternal.NativeFieldInfoPtr_m_EntitlementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, nameof (m_EntitlementName));
      EntitlementInternal.NativeFieldInfoPtr_m_EntitlementId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, nameof (m_EntitlementId));
      EntitlementInternal.NativeFieldInfoPtr_m_CatalogItemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, nameof (m_CatalogItemId));
      EntitlementInternal.NativeFieldInfoPtr_m_ServerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, nameof (m_ServerIndex));
      EntitlementInternal.NativeFieldInfoPtr_m_Redeemed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, nameof (m_Redeemed));
      EntitlementInternal.NativeFieldInfoPtr_m_EndTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, nameof (m_EndTimestamp));
      EntitlementInternal.NativeMethodInfoPtr_get_EntitlementName_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100672049);
      EntitlementInternal.NativeMethodInfoPtr_set_EntitlementName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100672050);
      EntitlementInternal.NativeMethodInfoPtr_get_EntitlementId_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100672051);
      EntitlementInternal.NativeMethodInfoPtr_set_EntitlementId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100672052);
      EntitlementInternal.NativeMethodInfoPtr_get_CatalogItemId_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100672053);
      EntitlementInternal.NativeMethodInfoPtr_set_CatalogItemId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100672054);
      EntitlementInternal.NativeMethodInfoPtr_get_ServerIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100672055);
      EntitlementInternal.NativeMethodInfoPtr_set_ServerIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100672056);
      EntitlementInternal.NativeMethodInfoPtr_get_Redeemed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100672057);
      EntitlementInternal.NativeMethodInfoPtr_set_Redeemed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100672058);
      EntitlementInternal.NativeMethodInfoPtr_get_EndTimestamp_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100672059);
      EntitlementInternal.NativeMethodInfoPtr_set_EndTimestamp_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100672060);
      EntitlementInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Entitlement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100672061);
      EntitlementInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_Entitlement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100672062);
      EntitlementInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100672063);
      EntitlementInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_Entitlement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, 100672064);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EntitlementInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
