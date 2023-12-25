// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.InitializeThreadAffinity
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform
{
  [StructLayout(LayoutKind.Explicit)]
  public struct InitializeThreadAffinity
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkWork_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__StorageIo_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__WebSocketIo_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__P2PIo_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__HttpRequestIo_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__RTCIo_k__BackingField;
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
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_InitializeThreadAffinityInternal_0;
    [FieldOffset(0)]
    public ulong _NetworkWork_k__BackingField;
    [FieldOffset(8)]
    public ulong _StorageIo_k__BackingField;
    [FieldOffset(16)]
    public ulong _WebSocketIo_k__BackingField;
    [FieldOffset(24)]
    public ulong _P2PIo_k__BackingField;
    [FieldOffset(32)]
    public ulong _HttpRequestIo_k__BackingField;
    [FieldOffset(40)]
    public ulong _RTCIo_k__BackingField;

    public unsafe ulong NetworkWork
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_get_NetworkWork_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_set_NetworkWork_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong StorageIo
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_get_StorageIo_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_set_StorageIo_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong WebSocketIo
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_get_WebSocketIo_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_set_WebSocketIo_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong P2PIo
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_get_P2PIo_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_set_P2PIo_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong HttpRequestIo
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_get_HttpRequestIo_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_set_HttpRequestIo_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong RTCIo
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 22440, RefRangeEnd = 22452, XrefRangeStart = 22440, XrefRangeEnd = 22452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_get_RTCIo_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_set_RTCIo_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    public unsafe void Set(ref InitializeThreadAffinityInternal other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_Set_Internal_Void_byref_InitializeThreadAffinityInternal_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InitializeThreadAffinity()
    {
      Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Platform", nameof (InitializeThreadAffinity));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr);
      InitializeThreadAffinity.NativeFieldInfoPtr__NetworkWork_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, "<NetworkWork>k__BackingField");
      InitializeThreadAffinity.NativeFieldInfoPtr__StorageIo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, "<StorageIo>k__BackingField");
      InitializeThreadAffinity.NativeFieldInfoPtr__WebSocketIo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, "<WebSocketIo>k__BackingField");
      InitializeThreadAffinity.NativeFieldInfoPtr__P2PIo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, "<P2PIo>k__BackingField");
      InitializeThreadAffinity.NativeFieldInfoPtr__HttpRequestIo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, "<HttpRequestIo>k__BackingField");
      InitializeThreadAffinity.NativeFieldInfoPtr__RTCIo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, "<RTCIo>k__BackingField");
      InitializeThreadAffinity.NativeMethodInfoPtr_get_NetworkWork_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100674678);
      InitializeThreadAffinity.NativeMethodInfoPtr_set_NetworkWork_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100674679);
      InitializeThreadAffinity.NativeMethodInfoPtr_get_StorageIo_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100674680);
      InitializeThreadAffinity.NativeMethodInfoPtr_set_StorageIo_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100674681);
      InitializeThreadAffinity.NativeMethodInfoPtr_get_WebSocketIo_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100674682);
      InitializeThreadAffinity.NativeMethodInfoPtr_set_WebSocketIo_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100674683);
      InitializeThreadAffinity.NativeMethodInfoPtr_get_P2PIo_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100674684);
      InitializeThreadAffinity.NativeMethodInfoPtr_set_P2PIo_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100674685);
      InitializeThreadAffinity.NativeMethodInfoPtr_get_HttpRequestIo_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100674686);
      InitializeThreadAffinity.NativeMethodInfoPtr_set_HttpRequestIo_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100674687);
      InitializeThreadAffinity.NativeMethodInfoPtr_get_RTCIo_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100674688);
      InitializeThreadAffinity.NativeMethodInfoPtr_set_RTCIo_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100674689);
      InitializeThreadAffinity.NativeMethodInfoPtr_Set_Internal_Void_byref_InitializeThreadAffinityInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100674690);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
