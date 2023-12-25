// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.OnClientActionRequiredCallbackInfoInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon
{
  [StructLayout(LayoutKind.Explicit)]
  public struct OnClientActionRequiredCallbackInfoInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientAction;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ActionReasonCode;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ActionReasonDetailsString;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientAction_Public_get_AntiCheatCommonClientAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientAction_Public_set_Void_AntiCheatCommonClientAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ActionReasonCode_Public_get_AntiCheatCommonClientActionReason_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ActionReasonCode_Public_set_Void_AntiCheatCommonClientActionReason_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ActionReasonDetailsString_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ActionReasonDetailsString_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_OnClientActionRequiredCallbackInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_OnClientActionRequiredCallbackInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_OnClientActionRequiredCallbackInfo_0;
    [FieldOffset(0)]
    public System.IntPtr m_ClientData;
    [FieldOffset(8)]
    public System.IntPtr m_ClientHandle;
    [FieldOffset(16)]
    public AntiCheatCommonClientAction m_ClientAction;
    [FieldOffset(20)]
    public AntiCheatCommonClientActionReason m_ActionReasonCode;
    [FieldOffset(24)]
    public System.IntPtr m_ActionReasonDetailsString;

    public unsafe Il2CppSystem.Object ClientData
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970525, XrefRangeEnd = 970529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970529, XrefRangeEnd = 970533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public virtual unsafe System.IntPtr ClientDataAddress
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe System.IntPtr ClientHandle
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AntiCheatCommonClientAction ClientAction
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 23501, RefRangeEnd = 23506, XrefRangeStart = 23501, XrefRangeEnd = 23506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ClientAction_Public_get_AntiCheatCommonClientAction_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(AntiCheatCommonClientAction*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_set_ClientAction_Public_set_Void_AntiCheatCommonClientAction_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AntiCheatCommonClientActionReason ActionReasonCode
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 23498, RefRangeEnd = 23499, XrefRangeStart = 23498, XrefRangeEnd = 23499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ActionReasonCode_Public_get_AntiCheatCommonClientActionReason_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(AntiCheatCommonClientActionReason*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 23499, RefRangeEnd = 23501, XrefRangeStart = 23499, XrefRangeEnd = 23501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_set_ActionReasonCode_Public_set_Void_AntiCheatCommonClientActionReason_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String ActionReasonDetailsString
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970533, XrefRangeEnd = 970537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ActionReasonDetailsString_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970537, XrefRangeEnd = 970541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_set_ActionReasonDetailsString_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970541, XrefRangeEnd = 970549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref OnClientActionRequiredCallbackInfo other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_OnClientActionRequiredCallbackInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970549, XrefRangeEnd = 970569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<OnClientActionRequiredCallbackInfo> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_OnClientActionRequiredCallbackInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970569, XrefRangeEnd = 970575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970575, XrefRangeEnd = 970576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out OnClientActionRequiredCallbackInfo output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_OnClientActionRequiredCallbackInfo_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref OnClientActionRequiredCallbackInfo local = ref output;
      System.IntPtr pointer = zero;
      OnClientActionRequiredCallbackInfo requiredCallbackInfo = pointer == System.IntPtr.Zero ? (OnClientActionRequiredCallbackInfo) null : new OnClientActionRequiredCallbackInfo(pointer);
      local = requiredCallbackInfo;
    }

    static OnClientActionRequiredCallbackInfoInternal()
    {
      Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (OnClientActionRequiredCallbackInfoInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr);
      OnClientActionRequiredCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
      OnClientActionRequiredCallbackInfoInternal.NativeFieldInfoPtr_m_ClientHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientHandle));
      OnClientActionRequiredCallbackInfoInternal.NativeFieldInfoPtr_m_ClientAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientAction));
      OnClientActionRequiredCallbackInfoInternal.NativeFieldInfoPtr_m_ActionReasonCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, nameof (m_ActionReasonCode));
      OnClientActionRequiredCallbackInfoInternal.NativeFieldInfoPtr_m_ActionReasonDetailsString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, nameof (m_ActionReasonDetailsString));
      OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, 100674183);
      OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, 100674184);
      OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, 100674185);
      OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, 100674186);
      OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, 100674187);
      OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ClientAction_Public_get_AntiCheatCommonClientAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, 100674188);
      OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_set_ClientAction_Public_set_Void_AntiCheatCommonClientAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, 100674189);
      OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ActionReasonCode_Public_get_AntiCheatCommonClientActionReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, 100674190);
      OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_set_ActionReasonCode_Public_set_Void_AntiCheatCommonClientActionReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, 100674191);
      OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ActionReasonDetailsString_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, 100674192);
      OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_set_ActionReasonDetailsString_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, 100674193);
      OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_OnClientActionRequiredCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, 100674194);
      OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_OnClientActionRequiredCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, 100674195);
      OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, 100674196);
      OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_OnClientActionRequiredCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, 100674197);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
