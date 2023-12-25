// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatClient.UnregisterPeerOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatClient
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UnregisterPeerOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PeerHandle;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PeerHandle_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UnregisterPeerOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_UnregisterPeerOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_PeerHandle;

    public unsafe System.IntPtr PeerHandle
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnregisterPeerOptionsInternal.NativeMethodInfoPtr_set_PeerHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 937897, RefRangeEnd = 937902, XrefRangeStart = 937897, XrefRangeEnd = 937902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref UnregisterPeerOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnregisterPeerOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UnregisterPeerOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971417, XrefRangeEnd = 971421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Nullable_Unboxed<UnregisterPeerOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnregisterPeerOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_UnregisterPeerOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971421, XrefRangeEnd = 971425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnregisterPeerOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnregisterPeerOptionsInternal()
    {
      Il2CppClassPointerStore<UnregisterPeerOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatClient", nameof (UnregisterPeerOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnregisterPeerOptionsInternal>.NativeClassPtr);
      UnregisterPeerOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnregisterPeerOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      UnregisterPeerOptionsInternal.NativeFieldInfoPtr_m_PeerHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnregisterPeerOptionsInternal>.NativeClassPtr, nameof (m_PeerHandle));
      UnregisterPeerOptionsInternal.NativeMethodInfoPtr_set_PeerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnregisterPeerOptionsInternal>.NativeClassPtr, 100674526);
      UnregisterPeerOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UnregisterPeerOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnregisterPeerOptionsInternal>.NativeClassPtr, 100674527);
      UnregisterPeerOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_UnregisterPeerOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnregisterPeerOptionsInternal>.NativeClassPtr, 100674528);
      UnregisterPeerOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnregisterPeerOptionsInternal>.NativeClassPtr, 100674529);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnregisterPeerOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
