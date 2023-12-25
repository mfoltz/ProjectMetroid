// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatServer.UnprotectMessageOptionsInternal
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
  public struct UnprotectMessageOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DataLengthBytes;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Data;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OutBufferSizeBytes;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_ArraySegment_1_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OutBufferSizeBytes_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UnprotectMessageOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UnprotectMessageOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_ClientHandle;
    [FieldOffset(16)]
    public uint m_DataLengthBytes;
    [FieldOffset(24)]
    public System.IntPtr m_Data;
    [FieldOffset(32)]
    public uint m_OutBufferSizeBytes;

    public unsafe System.IntPtr ClientHandle
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnprotectMessageOptionsInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppSystem.ArraySegment<byte> Data
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969383, XrefRangeEnd = 969387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnprotectMessageOptionsInternal.NativeMethodInfoPtr_set_Data_Public_set_Void_ArraySegment_1_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint OutBufferSizeBytes
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnprotectMessageOptionsInternal.NativeMethodInfoPtr_set_OutBufferSizeBytes_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 969391, RefRangeEnd = 969392, XrefRangeStart = 969387, XrefRangeEnd = 969391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref UnprotectMessageOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnprotectMessageOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UnprotectMessageOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969392, XrefRangeEnd = 969404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<UnprotectMessageOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnprotectMessageOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UnprotectMessageOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969404, XrefRangeEnd = 969409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnprotectMessageOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnprotectMessageOptionsInternal()
    {
      Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatServer", nameof (UnprotectMessageOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr);
      UnprotectMessageOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      UnprotectMessageOptionsInternal.NativeFieldInfoPtr_m_ClientHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr, nameof (m_ClientHandle));
      UnprotectMessageOptionsInternal.NativeFieldInfoPtr_m_DataLengthBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr, nameof (m_DataLengthBytes));
      UnprotectMessageOptionsInternal.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr, nameof (m_Data));
      UnprotectMessageOptionsInternal.NativeFieldInfoPtr_m_OutBufferSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr, nameof (m_OutBufferSizeBytes));
      UnprotectMessageOptionsInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr, 100673913);
      UnprotectMessageOptionsInternal.NativeMethodInfoPtr_set_Data_Public_set_Void_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr, 100673914);
      UnprotectMessageOptionsInternal.NativeMethodInfoPtr_set_OutBufferSizeBytes_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr, 100673915);
      UnprotectMessageOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UnprotectMessageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr, 100673916);
      UnprotectMessageOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UnprotectMessageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr, 100673917);
      UnprotectMessageOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr, 100673918);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
