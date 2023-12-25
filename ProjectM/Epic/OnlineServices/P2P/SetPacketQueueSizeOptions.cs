// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.SetPacketQueueSizeOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SetPacketQueueSizeOptions
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__IncomingPacketQueueMaxSizeBytes_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__OutgoingPacketQueueMaxSizeBytes_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IncomingPacketQueueMaxSizeBytes_Public_get_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IncomingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OutgoingPacketQueueMaxSizeBytes_Public_get_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OutgoingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0;
    [FieldOffset(0)]
    public ulong _IncomingPacketQueueMaxSizeBytes_k__BackingField;
    [FieldOffset(8)]
    public ulong _OutgoingPacketQueueMaxSizeBytes_k__BackingField;

    public unsafe ulong IncomingPacketQueueMaxSizeBytes
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetPacketQueueSizeOptions.NativeMethodInfoPtr_get_IncomingPacketQueueMaxSizeBytes_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetPacketQueueSizeOptions.NativeMethodInfoPtr_set_IncomingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ulong OutgoingPacketQueueMaxSizeBytes
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetPacketQueueSizeOptions.NativeMethodInfoPtr_get_OutgoingPacketQueueMaxSizeBytes_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetPacketQueueSizeOptions.NativeMethodInfoPtr_set_OutgoingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static SetPacketQueueSizeOptions()
    {
      Il2CppClassPointerStore<SetPacketQueueSizeOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.P2P", nameof (SetPacketQueueSizeOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPacketQueueSizeOptions>.NativeClassPtr);
      SetPacketQueueSizeOptions.NativeFieldInfoPtr__IncomingPacketQueueMaxSizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPacketQueueSizeOptions>.NativeClassPtr, "<IncomingPacketQueueMaxSizeBytes>k__BackingField");
      SetPacketQueueSizeOptions.NativeFieldInfoPtr__OutgoingPacketQueueMaxSizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPacketQueueSizeOptions>.NativeClassPtr, "<OutgoingPacketQueueMaxSizeBytes>k__BackingField");
      SetPacketQueueSizeOptions.NativeMethodInfoPtr_get_IncomingPacketQueueMaxSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPacketQueueSizeOptions>.NativeClassPtr, 100669236);
      SetPacketQueueSizeOptions.NativeMethodInfoPtr_set_IncomingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPacketQueueSizeOptions>.NativeClassPtr, 100669237);
      SetPacketQueueSizeOptions.NativeMethodInfoPtr_get_OutgoingPacketQueueMaxSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPacketQueueSizeOptions>.NativeClassPtr, 100669238);
      SetPacketQueueSizeOptions.NativeMethodInfoPtr_set_OutgoingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPacketQueueSizeOptions>.NativeClassPtr, 100669239);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetPacketQueueSizeOptions>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
