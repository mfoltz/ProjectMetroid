// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatServer.ReceiveMessageFromClientOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatServer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ReceiveMessageFromClientOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DataLengthBytes;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Data;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_ArraySegment_1_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ReceiveMessageFromClientOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ReceiveMessageFromClientOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_ClientHandle;
    [FieldOffset(16)]
    public uint m_DataLengthBytes;
    [FieldOffset(24)]
    public System.IntPtr m_Data;

    public unsafe System.IntPtr ClientHandle
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReceiveMessageFromClientOptionsInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppSystem.ArraySegment<byte> Data
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969278, XrefRangeEnd = 969282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReceiveMessageFromClientOptionsInternal.NativeMethodInfoPtr_set_Data_Public_set_Void_ArraySegment_1_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 969286, RefRangeEnd = 969287, XrefRangeStart = 969282, XrefRangeEnd = 969286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref ReceiveMessageFromClientOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReceiveMessageFromClientOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ReceiveMessageFromClientOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969287, XrefRangeEnd = 969297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<ReceiveMessageFromClientOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReceiveMessageFromClientOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ReceiveMessageFromClientOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969297, XrefRangeEnd = 969302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReceiveMessageFromClientOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ReceiveMessageFromClientOptionsInternal()
    {
      Il2CppClassPointerStore<ReceiveMessageFromClientOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatServer", nameof (ReceiveMessageFromClientOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceiveMessageFromClientOptionsInternal>.NativeClassPtr);
      ReceiveMessageFromClientOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceiveMessageFromClientOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      ReceiveMessageFromClientOptionsInternal.NativeFieldInfoPtr_m_ClientHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceiveMessageFromClientOptionsInternal>.NativeClassPtr, nameof (m_ClientHandle));
      ReceiveMessageFromClientOptionsInternal.NativeFieldInfoPtr_m_DataLengthBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceiveMessageFromClientOptionsInternal>.NativeClassPtr, nameof (m_DataLengthBytes));
      ReceiveMessageFromClientOptionsInternal.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceiveMessageFromClientOptionsInternal>.NativeClassPtr, nameof (m_Data));
      ReceiveMessageFromClientOptionsInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiveMessageFromClientOptionsInternal>.NativeClassPtr, 100673872);
      ReceiveMessageFromClientOptionsInternal.NativeMethodInfoPtr_set_Data_Public_set_Void_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiveMessageFromClientOptionsInternal>.NativeClassPtr, 100673873);
      ReceiveMessageFromClientOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ReceiveMessageFromClientOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiveMessageFromClientOptionsInternal>.NativeClassPtr, 100673874);
      ReceiveMessageFromClientOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ReceiveMessageFromClientOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiveMessageFromClientOptionsInternal>.NativeClassPtr, 100673875);
      ReceiveMessageFromClientOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiveMessageFromClientOptionsInternal>.NativeClassPtr, 100673876);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReceiveMessageFromClientOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
