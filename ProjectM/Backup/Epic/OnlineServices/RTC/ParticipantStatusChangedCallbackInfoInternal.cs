// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTC.ParticipantStatusChangedCallbackInfoInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTC
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ParticipantStatusChangedCallbackInfoInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_RoomName;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ParticipantId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ParticipantStatus;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ParticipantMetadataCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ParticipantMetadata;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ParticipantInBlocklist;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RoomName_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RoomName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ParticipantId_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ParticipantId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ParticipantStatus_Public_get_RTCParticipantStatus_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ParticipantStatus_Public_set_Void_RTCParticipantStatus_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ParticipantMetadata_Public_get_Il2CppReferenceArray_1_ParticipantMetadata_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ParticipantMetadata_Public_set_Void_Il2CppReferenceArray_1_ParticipantMetadata_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ParticipantInBlocklist_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ParticipantInBlocklist_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ParticipantStatusChangedCallbackInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ParticipantStatusChangedCallbackInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_ParticipantStatusChangedCallbackInfo_0;
    [FieldOffset(0)]
    public System.IntPtr m_ClientData;
    [FieldOffset(8)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(16)]
    public System.IntPtr m_RoomName;
    [FieldOffset(24)]
    public System.IntPtr m_ParticipantId;
    [FieldOffset(32)]
    public RTCParticipantStatus m_ParticipantStatus;
    [FieldOffset(36)]
    public uint m_ParticipantMetadataCount;
    [FieldOffset(40)]
    public System.IntPtr m_ParticipantMetadata;
    [FieldOffset(48)]
    public int m_ParticipantInBlocklist;

    public unsafe Il2CppSystem.Object ClientData
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947354, XrefRangeEnd = 947358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947358, XrefRangeEnd = 947362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public virtual unsafe System.IntPtr ClientDataAddress
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 947368, RefRangeEnd = 947369, XrefRangeStart = 947362, XrefRangeEnd = 947368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947369, XrefRangeEnd = 947373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String RoomName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947373, XrefRangeEnd = 947377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_RoomName_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947377, XrefRangeEnd = 947381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_set_RoomName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId ParticipantId
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 947387, RefRangeEnd = 947388, XrefRangeStart = 947381, XrefRangeEnd = 947387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ParticipantId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947388, XrefRangeEnd = 947392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_set_ParticipantId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe RTCParticipantStatus ParticipantStatus
    {
      [CallerCount(36), CachedScanResults(RefRangeStart = 29682, RefRangeEnd = 29718, XrefRangeStart = 29682, XrefRangeEnd = 29718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ParticipantStatus_Public_get_RTCParticipantStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(RTCParticipantStatus*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_set_ParticipantStatus_Public_set_Void_RTCParticipantStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppReferenceArray<Epic.OnlineServices.RTC.ParticipantMetadata> ParticipantMetadata
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 947398, RefRangeEnd = 947399, XrefRangeStart = 947392, XrefRangeEnd = 947398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ParticipantMetadata_Public_get_Il2CppReferenceArray_1_ParticipantMetadata_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Epic.OnlineServices.RTC.ParticipantMetadata>) null : new Il2CppReferenceArray<Epic.OnlineServices.RTC.ParticipantMetadata>(nativeObject);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 947405, RefRangeEnd = 947407, XrefRangeStart = 947399, XrefRangeEnd = 947405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_set_ParticipantMetadata_Public_set_Void_Il2CppReferenceArray_1_ParticipantMetadata_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool ParticipantInBlocklist
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947407, XrefRangeEnd = 947411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ParticipantInBlocklist_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947411, XrefRangeEnd = 947415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_set_ParticipantInBlocklist_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947415, XrefRangeEnd = 947436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref ParticipantStatusChangedCallbackInfo other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ParticipantStatusChangedCallbackInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947436, XrefRangeEnd = 947473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<ParticipantStatusChangedCallbackInfo> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ParticipantStatusChangedCallbackInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947473, XrefRangeEnd = 947481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947481, XrefRangeEnd = 947482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out ParticipantStatusChangedCallbackInfo output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_ParticipantStatusChangedCallbackInfo_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ParticipantStatusChangedCallbackInfo local = ref output;
      System.IntPtr pointer = zero;
      ParticipantStatusChangedCallbackInfo changedCallbackInfo = pointer == System.IntPtr.Zero ? (ParticipantStatusChangedCallbackInfo) null : new ParticipantStatusChangedCallbackInfo(pointer);
      local = changedCallbackInfo;
    }

    static ParticipantStatusChangedCallbackInfoInternal()
    {
      Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.RTC", nameof (ParticipantStatusChangedCallbackInfoInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr);
      ParticipantStatusChangedCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
      ParticipantStatusChangedCallbackInfoInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_LocalUserId));
      ParticipantStatusChangedCallbackInfoInternal.NativeFieldInfoPtr_m_RoomName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_RoomName));
      ParticipantStatusChangedCallbackInfoInternal.NativeFieldInfoPtr_m_ParticipantId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_ParticipantId));
      ParticipantStatusChangedCallbackInfoInternal.NativeFieldInfoPtr_m_ParticipantStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_ParticipantStatus));
      ParticipantStatusChangedCallbackInfoInternal.NativeFieldInfoPtr_m_ParticipantMetadataCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_ParticipantMetadataCount));
      ParticipantStatusChangedCallbackInfoInternal.NativeFieldInfoPtr_m_ParticipantMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_ParticipantMetadata));
      ParticipantStatusChangedCallbackInfoInternal.NativeFieldInfoPtr_m_ParticipantInBlocklist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_ParticipantInBlocklist));
      ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667910);
      ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667911);
      ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667912);
      ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667913);
      ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667914);
      ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_RoomName_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667915);
      ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_set_RoomName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667916);
      ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ParticipantId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667917);
      ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_set_ParticipantId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667918);
      ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ParticipantStatus_Public_get_RTCParticipantStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667919);
      ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_set_ParticipantStatus_Public_set_Void_RTCParticipantStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667920);
      ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ParticipantMetadata_Public_get_Il2CppReferenceArray_1_ParticipantMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667921);
      ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_set_ParticipantMetadata_Public_set_Void_Il2CppReferenceArray_1_ParticipantMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667922);
      ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ParticipantInBlocklist_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667923);
      ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_set_ParticipantInBlocklist_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667924);
      ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ParticipantStatusChangedCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667925);
      ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ParticipantStatusChangedCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667926);
      ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667927);
      ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_ParticipantStatusChangedCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667928);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
