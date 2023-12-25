// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTC.ParticipantMetadataInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTC
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ParticipantMetadataInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Key;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Value;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Key_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Key_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ParticipantMetadata_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ParticipantMetadata_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_ParticipantMetadata_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_Key;
    [FieldOffset(16)]
    public System.IntPtr m_Value;

    public unsafe Epic.OnlineServices.Utf8String Key
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947289, XrefRangeEnd = 947293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticipantMetadataInternal.NativeMethodInfoPtr_get_Key_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947293, XrefRangeEnd = 947297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticipantMetadataInternal.NativeMethodInfoPtr_set_Key_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String Value
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947297, XrefRangeEnd = 947301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticipantMetadataInternal.NativeMethodInfoPtr_get_Value_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947301, XrefRangeEnd = 947305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticipantMetadataInternal.NativeMethodInfoPtr_set_Value_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947305, XrefRangeEnd = 947313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref ParticipantMetadata other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticipantMetadataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ParticipantMetadata_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947313, XrefRangeEnd = 947327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<ParticipantMetadata> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticipantMetadataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ParticipantMetadata_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947327, XrefRangeEnd = 947332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticipantMetadataInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947332, XrefRangeEnd = 947333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out ParticipantMetadata output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticipantMetadataInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_ParticipantMetadata_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ParticipantMetadata local = ref output;
      System.IntPtr pointer = zero;
      ParticipantMetadata participantMetadata = pointer == System.IntPtr.Zero ? (ParticipantMetadata) null : new ParticipantMetadata(pointer);
      local = participantMetadata;
    }

    static ParticipantMetadataInternal()
    {
      Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.RTC", nameof (ParticipantMetadataInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr);
      ParticipantMetadataInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr, nameof (m_ApiVersion));
      ParticipantMetadataInternal.NativeFieldInfoPtr_m_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr, nameof (m_Key));
      ParticipantMetadataInternal.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr, nameof (m_Value));
      ParticipantMetadataInternal.NativeMethodInfoPtr_get_Key_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr, 100667886);
      ParticipantMetadataInternal.NativeMethodInfoPtr_set_Key_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr, 100667887);
      ParticipantMetadataInternal.NativeMethodInfoPtr_get_Value_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr, 100667888);
      ParticipantMetadataInternal.NativeMethodInfoPtr_set_Value_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr, 100667889);
      ParticipantMetadataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ParticipantMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr, 100667890);
      ParticipantMetadataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ParticipantMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr, 100667891);
      ParticipantMetadataInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr, 100667892);
      ParticipantMetadataInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_ParticipantMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr, 100667893);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticipantMetadataInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
