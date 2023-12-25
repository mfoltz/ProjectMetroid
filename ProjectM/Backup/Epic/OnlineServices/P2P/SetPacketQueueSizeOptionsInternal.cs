// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.SetPacketQueueSizeOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SetPacketQueueSizeOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_IncomingPacketQueueMaxSizeBytes;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OutgoingPacketQueueMaxSizeBytes;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IncomingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OutgoingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SetPacketQueueSizeOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_SetPacketQueueSizeOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public ulong m_IncomingPacketQueueMaxSizeBytes;
    [FieldOffset(16)]
    public ulong m_OutgoingPacketQueueMaxSizeBytes;

    public unsafe ulong IncomingPacketQueueMaxSizeBytes
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetPacketQueueSizeOptionsInternal.NativeMethodInfoPtr_set_IncomingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong OutgoingPacketQueueMaxSizeBytes
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetPacketQueueSizeOptionsInternal.NativeMethodInfoPtr_set_OutgoingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 952374, RefRangeEnd = 952376, XrefRangeStart = 952374, XrefRangeEnd = 952374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref SetPacketQueueSizeOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetPacketQueueSizeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SetPacketQueueSizeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952376, XrefRangeEnd = 952382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Nullable_Unboxed<SetPacketQueueSizeOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetPacketQueueSizeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_SetPacketQueueSizeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetPacketQueueSizeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SetPacketQueueSizeOptionsInternal()
    {
      Il2CppClassPointerStore<SetPacketQueueSizeOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.P2P", nameof (SetPacketQueueSizeOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPacketQueueSizeOptionsInternal>.NativeClassPtr);
      SetPacketQueueSizeOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPacketQueueSizeOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      SetPacketQueueSizeOptionsInternal.NativeFieldInfoPtr_m_IncomingPacketQueueMaxSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPacketQueueSizeOptionsInternal>.NativeClassPtr, nameof (m_IncomingPacketQueueMaxSizeBytes));
      SetPacketQueueSizeOptionsInternal.NativeFieldInfoPtr_m_OutgoingPacketQueueMaxSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPacketQueueSizeOptionsInternal>.NativeClassPtr, nameof (m_OutgoingPacketQueueMaxSizeBytes));
      SetPacketQueueSizeOptionsInternal.NativeMethodInfoPtr_set_IncomingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPacketQueueSizeOptionsInternal>.NativeClassPtr, 100669240);
      SetPacketQueueSizeOptionsInternal.NativeMethodInfoPtr_set_OutgoingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPacketQueueSizeOptionsInternal>.NativeClassPtr, 100669241);
      SetPacketQueueSizeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SetPacketQueueSizeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPacketQueueSizeOptionsInternal>.NativeClassPtr, 100669242);
      SetPacketQueueSizeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_SetPacketQueueSizeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPacketQueueSizeOptionsInternal>.NativeClassPtr, 100669243);
      SetPacketQueueSizeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPacketQueueSizeOptionsInternal>.NativeClassPtr, 100669244);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetPacketQueueSizeOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
