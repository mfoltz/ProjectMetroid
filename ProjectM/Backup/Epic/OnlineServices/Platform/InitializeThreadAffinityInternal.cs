// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.InitializeThreadAffinityInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform
{
  [StructLayout(LayoutKind.Explicit)]
  public struct InitializeThreadAffinityInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_NetworkWork;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_StorageIo;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_WebSocketIo;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_P2PIo;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_HttpRequestIo;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_RTCIo;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NetworkWork_Public_get_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_NetworkWork_Public_set_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_StorageIo_Public_get_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_StorageIo_Public_set_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_WebSocketIo_Public_get_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_WebSocketIo_Public_set_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_P2PIo_Public_get_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_P2PIo_Public_set_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HttpRequestIo_Public_get_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_HttpRequestIo_Public_set_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RTCIo_Public_get_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RTCIo_Public_set_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_InitializeThreadAffinity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_InitializeThreadAffinity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_InitializeThreadAffinity_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public ulong m_NetworkWork;
    [FieldOffset(16)]
    public ulong m_StorageIo;
    [FieldOffset(24)]
    public ulong m_WebSocketIo;
    [FieldOffset(32)]
    public ulong m_P2PIo;
    [FieldOffset(40)]
    public ulong m_HttpRequestIo;
    [FieldOffset(48)]
    public ulong m_RTCIo;

    public unsafe ulong NetworkWork
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_get_NetworkWork_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_set_NetworkWork_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong StorageIo
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_get_StorageIo_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_set_StorageIo_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong WebSocketIo
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_get_WebSocketIo_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_set_WebSocketIo_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong P2PIo
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_get_P2PIo_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_set_P2PIo_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong HttpRequestIo
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 22440, RefRangeEnd = 22452, XrefRangeStart = 22440, XrefRangeEnd = 22452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_get_HttpRequestIo_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_set_HttpRequestIo_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong RTCIo
    {
      [CallerCount(343), CachedScanResults(RefRangeStart = 22462, RefRangeEnd = 22805, XrefRangeStart = 22462, XrefRangeEnd = 22805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_get_RTCIo_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_set_RTCIo_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    public virtual unsafe void Set(ref InitializeThreadAffinity other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_InitializeThreadAffinity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972053, XrefRangeEnd = 972067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Nullable_Unboxed<InitializeThreadAffinity> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_InitializeThreadAffinity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void Get(out InitializeThreadAffinity output)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref output;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_InitializeThreadAffinity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InitializeThreadAffinityInternal()
    {
      Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Platform", nameof (InitializeThreadAffinityInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr);
      InitializeThreadAffinityInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, nameof (m_ApiVersion));
      InitializeThreadAffinityInternal.NativeFieldInfoPtr_m_NetworkWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, nameof (m_NetworkWork));
      InitializeThreadAffinityInternal.NativeFieldInfoPtr_m_StorageIo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, nameof (m_StorageIo));
      InitializeThreadAffinityInternal.NativeFieldInfoPtr_m_WebSocketIo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, nameof (m_WebSocketIo));
      InitializeThreadAffinityInternal.NativeFieldInfoPtr_m_P2PIo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, nameof (m_P2PIo));
      InitializeThreadAffinityInternal.NativeFieldInfoPtr_m_HttpRequestIo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, nameof (m_HttpRequestIo));
      InitializeThreadAffinityInternal.NativeFieldInfoPtr_m_RTCIo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, nameof (m_RTCIo));
      InitializeThreadAffinityInternal.NativeMethodInfoPtr_get_NetworkWork_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100674691);
      InitializeThreadAffinityInternal.NativeMethodInfoPtr_set_NetworkWork_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100674692);
      InitializeThreadAffinityInternal.NativeMethodInfoPtr_get_StorageIo_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100674693);
      InitializeThreadAffinityInternal.NativeMethodInfoPtr_set_StorageIo_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100674694);
      InitializeThreadAffinityInternal.NativeMethodInfoPtr_get_WebSocketIo_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100674695);
      InitializeThreadAffinityInternal.NativeMethodInfoPtr_set_WebSocketIo_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100674696);
      InitializeThreadAffinityInternal.NativeMethodInfoPtr_get_P2PIo_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100674697);
      InitializeThreadAffinityInternal.NativeMethodInfoPtr_set_P2PIo_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100674698);
      InitializeThreadAffinityInternal.NativeMethodInfoPtr_get_HttpRequestIo_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100674699);
      InitializeThreadAffinityInternal.NativeMethodInfoPtr_set_HttpRequestIo_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100674700);
      InitializeThreadAffinityInternal.NativeMethodInfoPtr_get_RTCIo_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100674701);
      InitializeThreadAffinityInternal.NativeMethodInfoPtr_set_RTCIo_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100674702);
      InitializeThreadAffinityInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_InitializeThreadAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100674703);
      InitializeThreadAffinityInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_InitializeThreadAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100674704);
      InitializeThreadAffinityInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100674705);
      InitializeThreadAffinityInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_InitializeThreadAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100674706);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
