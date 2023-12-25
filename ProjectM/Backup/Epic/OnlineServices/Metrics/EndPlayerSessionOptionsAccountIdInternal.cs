// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Metrics.EndPlayerSessionOptionsAccountIdInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Metrics
{
  [StructLayout(LayoutKind.Explicit)]
  public struct EndPlayerSessionOptionsAccountIdInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountIdType;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Epic;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_External;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Epic_Public_get_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Epic_Public_set_Void_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_External_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_External_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_EndPlayerSessionOptionsAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_EndPlayerSessionOptionsAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_EndPlayerSessionOptionsAccountId_0;
    [FieldOffset(0)]
    public MetricsAccountIdType m_AccountIdType;
    [FieldOffset(4)]
    public System.IntPtr m_Epic;
    [FieldOffset(4)]
    public System.IntPtr m_External;

    public unsafe EpicAccountId Epic
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 953528, RefRangeEnd = 953530, XrefRangeStart = 953522, XrefRangeEnd = 953528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_get_Epic_Public_get_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (EpicAccountId) null : new EpicAccountId(pointer);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 953539, RefRangeEnd = 953541, XrefRangeStart = 953530, XrefRangeEnd = 953539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_set_Epic_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String External
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 953547, RefRangeEnd = 953549, XrefRangeStart = 953541, XrefRangeEnd = 953547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_get_External_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 953558, RefRangeEnd = 953560, XrefRangeStart = 953549, XrefRangeEnd = 953558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_set_External_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953560, XrefRangeEnd = 953564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref EndPlayerSessionOptionsAccountId other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_EndPlayerSessionOptionsAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953564, XrefRangeEnd = 953584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<EndPlayerSessionOptionsAccountId> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_EndPlayerSessionOptionsAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953584, XrefRangeEnd = 953591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953591, XrefRangeEnd = 953595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out EndPlayerSessionOptionsAccountId output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_EndPlayerSessionOptionsAccountId_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref EndPlayerSessionOptionsAccountId local = ref output;
      System.IntPtr pointer = zero;
      EndPlayerSessionOptionsAccountId optionsAccountId = pointer == System.IntPtr.Zero ? (EndPlayerSessionOptionsAccountId) null : new EndPlayerSessionOptionsAccountId(pointer);
      local = optionsAccountId;
    }

    static EndPlayerSessionOptionsAccountIdInternal()
    {
      Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Metrics", nameof (EndPlayerSessionOptionsAccountIdInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr);
      EndPlayerSessionOptionsAccountIdInternal.NativeFieldInfoPtr_m_AccountIdType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, nameof (m_AccountIdType));
      EndPlayerSessionOptionsAccountIdInternal.NativeFieldInfoPtr_m_Epic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, nameof (m_Epic));
      EndPlayerSessionOptionsAccountIdInternal.NativeFieldInfoPtr_m_External = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, nameof (m_External));
      EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_get_Epic_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100669542);
      EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_set_Epic_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100669543);
      EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_get_External_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100669544);
      EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_set_External_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100669545);
      EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_EndPlayerSessionOptionsAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100669546);
      EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_EndPlayerSessionOptionsAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100669547);
      EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100669548);
      EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_EndPlayerSessionOptionsAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100669549);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
