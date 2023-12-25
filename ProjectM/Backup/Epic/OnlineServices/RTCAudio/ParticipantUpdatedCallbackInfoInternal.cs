// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAudio.ParticipantUpdatedCallbackInfoInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTCAudio
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ParticipantUpdatedCallbackInfoInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_RoomName;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ParticipantId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Speaking;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AudioStatus;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RoomName_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RoomName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ParticipantId_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ParticipantId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Speaking_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Speaking_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AudioStatus_Public_get_RTCAudioStatus_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AudioStatus_Public_set_Void_RTCAudioStatus_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ParticipantUpdatedCallbackInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ParticipantUpdatedCallbackInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_ParticipantUpdatedCallbackInfo_0;
    [FieldOffset(0)]
    public System.IntPtr m_ClientData;
    [FieldOffset(8)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(16)]
    public System.IntPtr m_RoomName;
    [FieldOffset(24)]
    public System.IntPtr m_ParticipantId;
    [FieldOffset(32)]
    public int m_Speaking;
    [FieldOffset(36)]
    public RTCAudioStatus m_AudioStatus;

    public unsafe Il2CppSystem.Object ClientData
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944619, XrefRangeEnd = 944623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944623, XrefRangeEnd = 944627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public virtual unsafe System.IntPtr ClientDataAddress
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 944633, RefRangeEnd = 944634, XrefRangeStart = 944627, XrefRangeEnd = 944633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944634, XrefRangeEnd = 944638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String RoomName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944638, XrefRangeEnd = 944642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_RoomName_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944642, XrefRangeEnd = 944646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_set_RoomName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId ParticipantId
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 944652, RefRangeEnd = 944653, XrefRangeStart = 944646, XrefRangeEnd = 944652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_ParticipantId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944653, XrefRangeEnd = 944657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_set_ParticipantId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool Speaking
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944657, XrefRangeEnd = 944661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_Speaking_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944661, XrefRangeEnd = 944665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_set_Speaking_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe RTCAudioStatus AudioStatus
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_AudioStatus_Public_get_RTCAudioStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(RTCAudioStatus*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_set_AudioStatus_Public_set_Void_RTCAudioStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944665, XrefRangeEnd = 944685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref ParticipantUpdatedCallbackInfo other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ParticipantUpdatedCallbackInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944685, XrefRangeEnd = 944719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<ParticipantUpdatedCallbackInfo> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ParticipantUpdatedCallbackInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944719, XrefRangeEnd = 944726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944726, XrefRangeEnd = 944727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out ParticipantUpdatedCallbackInfo output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_ParticipantUpdatedCallbackInfo_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ParticipantUpdatedCallbackInfo local = ref output;
      System.IntPtr pointer = zero;
      ParticipantUpdatedCallbackInfo updatedCallbackInfo = pointer == System.IntPtr.Zero ? (ParticipantUpdatedCallbackInfo) null : new ParticipantUpdatedCallbackInfo(pointer);
      local = updatedCallbackInfo;
    }

    static ParticipantUpdatedCallbackInfoInternal()
    {
      Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.RTCAudio", nameof (ParticipantUpdatedCallbackInfoInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr);
      ParticipantUpdatedCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
      ParticipantUpdatedCallbackInfoInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, nameof (m_LocalUserId));
      ParticipantUpdatedCallbackInfoInternal.NativeFieldInfoPtr_m_RoomName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, nameof (m_RoomName));
      ParticipantUpdatedCallbackInfoInternal.NativeFieldInfoPtr_m_ParticipantId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, nameof (m_ParticipantId));
      ParticipantUpdatedCallbackInfoInternal.NativeFieldInfoPtr_m_Speaking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, nameof (m_Speaking));
      ParticipantUpdatedCallbackInfoInternal.NativeFieldInfoPtr_m_AudioStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, nameof (m_AudioStatus));
      ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100667194);
      ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100667195);
      ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100667196);
      ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100667197);
      ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100667198);
      ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_RoomName_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100667199);
      ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_set_RoomName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100667200);
      ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_ParticipantId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100667201);
      ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_set_ParticipantId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100667202);
      ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_Speaking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100667203);
      ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_set_Speaking_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100667204);
      ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_AudioStatus_Public_get_RTCAudioStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100667205);
      ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_set_AudioStatus_Public_set_Void_RTCAudioStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100667206);
      ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ParticipantUpdatedCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100667207);
      ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ParticipantUpdatedCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100667208);
      ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100667209);
      ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_ParticipantUpdatedCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100667210);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
