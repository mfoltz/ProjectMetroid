// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatClient.UnprotectMessageOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatClient
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UnprotectMessageOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DataLengthBytes;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Data;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OutBufferSizeBytes;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_ArraySegment_1_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OutBufferSizeBytes_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UnprotectMessageOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UnprotectMessageOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(4)]
    public uint m_DataLengthBytes;
    [FieldOffset(8)]
    public System.IntPtr m_Data;
    [FieldOffset(16)]
    public uint m_OutBufferSizeBytes;

    public unsafe Il2CppSystem.ArraySegment<byte> Data
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971394, XrefRangeEnd = 971398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
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
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnprotectMessageOptionsInternal.NativeMethodInfoPtr_set_OutBufferSizeBytes_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 971402, RefRangeEnd = 971403, XrefRangeStart = 971398, XrefRangeEnd = 971402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref UnprotectMessageOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnprotectMessageOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UnprotectMessageOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971403, XrefRangeEnd = 971413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<UnprotectMessageOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnprotectMessageOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UnprotectMessageOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971413, XrefRangeEnd = 971417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnprotectMessageOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnprotectMessageOptionsInternal()
    {
      Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatClient", nameof (UnprotectMessageOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr);
      UnprotectMessageOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      UnprotectMessageOptionsInternal.NativeFieldInfoPtr_m_DataLengthBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr, nameof (m_DataLengthBytes));
      UnprotectMessageOptionsInternal.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr, nameof (m_Data));
      UnprotectMessageOptionsInternal.NativeFieldInfoPtr_m_OutBufferSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr, nameof (m_OutBufferSizeBytes));
      UnprotectMessageOptionsInternal.NativeMethodInfoPtr_set_Data_Public_set_Void_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr, 100674519);
      UnprotectMessageOptionsInternal.NativeMethodInfoPtr_set_OutBufferSizeBytes_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr, 100674520);
      UnprotectMessageOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UnprotectMessageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr, 100674521);
      UnprotectMessageOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UnprotectMessageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr, 100674522);
      UnprotectMessageOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr, 100674523);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnprotectMessageOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
