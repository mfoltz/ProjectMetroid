// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Metrics.BeginPlayerSessionOptionsAccountIdInternal
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
  public struct BeginPlayerSessionOptionsAccountIdInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountIdType;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Epic;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_External;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Epic_Public_get_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Epic_Public_set_Void_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_External_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_External_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_BeginPlayerSessionOptionsAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_BeginPlayerSessionOptionsAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_BeginPlayerSessionOptionsAccountId_0;
    [FieldOffset(0)]
    public MetricsAccountIdType m_AccountIdType;
    [FieldOffset(4)]
    public System.IntPtr m_Epic;
    [FieldOffset(4)]
    public System.IntPtr m_External;

    public unsafe EpicAccountId Epic
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 953385, RefRangeEnd = 953387, XrefRangeStart = 953379, XrefRangeEnd = 953385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_get_Epic_Public_get_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (EpicAccountId) null : new EpicAccountId(pointer);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 953396, RefRangeEnd = 953398, XrefRangeStart = 953387, XrefRangeEnd = 953396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_set_Epic_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String External
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 953404, RefRangeEnd = 953406, XrefRangeStart = 953398, XrefRangeEnd = 953404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_get_External_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 953415, RefRangeEnd = 953417, XrefRangeStart = 953406, XrefRangeEnd = 953415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_set_External_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953417, XrefRangeEnd = 953421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref BeginPlayerSessionOptionsAccountId other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_BeginPlayerSessionOptionsAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953421, XrefRangeEnd = 953441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<BeginPlayerSessionOptionsAccountId> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_BeginPlayerSessionOptionsAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953441, XrefRangeEnd = 953448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953448, XrefRangeEnd = 953452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out BeginPlayerSessionOptionsAccountId output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_BeginPlayerSessionOptionsAccountId_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref BeginPlayerSessionOptionsAccountId local = ref output;
      System.IntPtr pointer = zero;
      BeginPlayerSessionOptionsAccountId optionsAccountId = pointer == System.IntPtr.Zero ? (BeginPlayerSessionOptionsAccountId) null : new BeginPlayerSessionOptionsAccountId(pointer);
      local = optionsAccountId;
    }

    static BeginPlayerSessionOptionsAccountIdInternal()
    {
      Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Metrics", nameof (BeginPlayerSessionOptionsAccountIdInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr);
      BeginPlayerSessionOptionsAccountIdInternal.NativeFieldInfoPtr_m_AccountIdType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, nameof (m_AccountIdType));
      BeginPlayerSessionOptionsAccountIdInternal.NativeFieldInfoPtr_m_Epic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, nameof (m_Epic));
      BeginPlayerSessionOptionsAccountIdInternal.NativeFieldInfoPtr_m_External = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, nameof (m_External));
      BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_get_Epic_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100669518);
      BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_set_Epic_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100669519);
      BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_get_External_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100669520);
      BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_set_External_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100669521);
      BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_BeginPlayerSessionOptionsAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100669522);
      BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_BeginPlayerSessionOptionsAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100669523);
      BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100669524);
      BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_BeginPlayerSessionOptionsAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100669525);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
