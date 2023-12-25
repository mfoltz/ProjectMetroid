// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.LobbyMemberUpdateReceivedCallbackInfoInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LobbyMemberUpdateReceivedCallbackInfoInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LobbyId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetUserId;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LobbyId_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LobbyId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetUserId_Public_get_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LobbyMemberUpdateReceivedCallbackInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LobbyMemberUpdateReceivedCallbackInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LobbyMemberUpdateReceivedCallbackInfo_0;
    [FieldOffset(0)]
    public System.IntPtr m_ClientData;
    [FieldOffset(8)]
    public System.IntPtr m_LobbyId;
    [FieldOffset(16)]
    public System.IntPtr m_TargetUserId;

    public unsafe Il2CppSystem.Object ClientData
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956856, XrefRangeEnd = 956860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyMemberUpdateReceivedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956860, XrefRangeEnd = 956864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LobbyMemberUpdateReceivedCallbackInfoInternal.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public virtual unsafe System.IntPtr ClientDataAddress
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyMemberUpdateReceivedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String LobbyId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956864, XrefRangeEnd = 956868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyMemberUpdateReceivedCallbackInfoInternal.NativeMethodInfoPtr_get_LobbyId_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956868, XrefRangeEnd = 956872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LobbyMemberUpdateReceivedCallbackInfoInternal.NativeMethodInfoPtr_set_LobbyId_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId TargetUserId
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 956878, RefRangeEnd = 956879, XrefRangeStart = 956872, XrefRangeEnd = 956878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LobbyMemberUpdateReceivedCallbackInfoInternal.NativeMethodInfoPtr_get_TargetUserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ProductUserId) null : new ProductUserId(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956879, XrefRangeEnd = 956883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LobbyMemberUpdateReceivedCallbackInfoInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956883, XrefRangeEnd = 956895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref LobbyMemberUpdateReceivedCallbackInfo other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyMemberUpdateReceivedCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LobbyMemberUpdateReceivedCallbackInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956895, XrefRangeEnd = 956915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<LobbyMemberUpdateReceivedCallbackInfo> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyMemberUpdateReceivedCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LobbyMemberUpdateReceivedCallbackInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956915, XrefRangeEnd = 956921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyMemberUpdateReceivedCallbackInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956921, XrefRangeEnd = 956922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out LobbyMemberUpdateReceivedCallbackInfo output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LobbyMemberUpdateReceivedCallbackInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LobbyMemberUpdateReceivedCallbackInfo_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref LobbyMemberUpdateReceivedCallbackInfo local = ref output;
      System.IntPtr pointer = zero;
      LobbyMemberUpdateReceivedCallbackInfo receivedCallbackInfo = pointer == System.IntPtr.Zero ? (LobbyMemberUpdateReceivedCallbackInfo) null : new LobbyMemberUpdateReceivedCallbackInfo(pointer);
      local = receivedCallbackInfo;
    }

    static LobbyMemberUpdateReceivedCallbackInfoInternal()
    {
      Il2CppClassPointerStore<LobbyMemberUpdateReceivedCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Lobby", nameof (LobbyMemberUpdateReceivedCallbackInfoInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyMemberUpdateReceivedCallbackInfoInternal>.NativeClassPtr);
      LobbyMemberUpdateReceivedCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyMemberUpdateReceivedCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
      LobbyMemberUpdateReceivedCallbackInfoInternal.NativeFieldInfoPtr_m_LobbyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyMemberUpdateReceivedCallbackInfoInternal>.NativeClassPtr, nameof (m_LobbyId));
      LobbyMemberUpdateReceivedCallbackInfoInternal.NativeFieldInfoPtr_m_TargetUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyMemberUpdateReceivedCallbackInfoInternal>.NativeClassPtr, nameof (m_TargetUserId));
      LobbyMemberUpdateReceivedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMemberUpdateReceivedCallbackInfoInternal>.NativeClassPtr, 100670287);
      LobbyMemberUpdateReceivedCallbackInfoInternal.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMemberUpdateReceivedCallbackInfoInternal>.NativeClassPtr, 100670288);
      LobbyMemberUpdateReceivedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMemberUpdateReceivedCallbackInfoInternal>.NativeClassPtr, 100670289);
      LobbyMemberUpdateReceivedCallbackInfoInternal.NativeMethodInfoPtr_get_LobbyId_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMemberUpdateReceivedCallbackInfoInternal>.NativeClassPtr, 100670290);
      LobbyMemberUpdateReceivedCallbackInfoInternal.NativeMethodInfoPtr_set_LobbyId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMemberUpdateReceivedCallbackInfoInternal>.NativeClassPtr, 100670291);
      LobbyMemberUpdateReceivedCallbackInfoInternal.NativeMethodInfoPtr_get_TargetUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMemberUpdateReceivedCallbackInfoInternal>.NativeClassPtr, 100670292);
      LobbyMemberUpdateReceivedCallbackInfoInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMemberUpdateReceivedCallbackInfoInternal>.NativeClassPtr, 100670293);
      LobbyMemberUpdateReceivedCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_LobbyMemberUpdateReceivedCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMemberUpdateReceivedCallbackInfoInternal>.NativeClassPtr, 100670294);
      LobbyMemberUpdateReceivedCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_LobbyMemberUpdateReceivedCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMemberUpdateReceivedCallbackInfoInternal>.NativeClassPtr, 100670295);
      LobbyMemberUpdateReceivedCallbackInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMemberUpdateReceivedCallbackInfoInternal>.NativeClassPtr, 100670296);
      LobbyMemberUpdateReceivedCallbackInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_LobbyMemberUpdateReceivedCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMemberUpdateReceivedCallbackInfoInternal>.NativeClassPtr, 100670297);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyMemberUpdateReceivedCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
