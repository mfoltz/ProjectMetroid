﻿// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatClient.ReceiveMessageFromServerOptionsInternal
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
  public struct ReceiveMessageFromServerOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DataLengthBytes;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Data;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_ArraySegment_1_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ReceiveMessageFromServerOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ReceiveMessageFromServerOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(4)]
    public uint m_DataLengthBytes;
    [FieldOffset(8)]
    public System.IntPtr m_Data;

    public unsafe Il2CppSystem.ArraySegment<byte> Data
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971313, XrefRangeEnd = 971317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReceiveMessageFromServerOptionsInternal.NativeMethodInfoPtr_set_Data_Public_set_Void_ArraySegment_1_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 971321, RefRangeEnd = 971322, XrefRangeStart = 971317, XrefRangeEnd = 971321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref ReceiveMessageFromServerOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReceiveMessageFromServerOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ReceiveMessageFromServerOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971322, XrefRangeEnd = 971330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<ReceiveMessageFromServerOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReceiveMessageFromServerOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ReceiveMessageFromServerOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971330, XrefRangeEnd = 971334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReceiveMessageFromServerOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ReceiveMessageFromServerOptionsInternal()
    {
      Il2CppClassPointerStore<ReceiveMessageFromServerOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatClient", nameof (ReceiveMessageFromServerOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceiveMessageFromServerOptionsInternal>.NativeClassPtr);
      ReceiveMessageFromServerOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceiveMessageFromServerOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      ReceiveMessageFromServerOptionsInternal.NativeFieldInfoPtr_m_DataLengthBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceiveMessageFromServerOptionsInternal>.NativeClassPtr, nameof (m_DataLengthBytes));
      ReceiveMessageFromServerOptionsInternal.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceiveMessageFromServerOptionsInternal>.NativeClassPtr, nameof (m_Data));
      ReceiveMessageFromServerOptionsInternal.NativeMethodInfoPtr_set_Data_Public_set_Void_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiveMessageFromServerOptionsInternal>.NativeClassPtr, 100674487);
      ReceiveMessageFromServerOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ReceiveMessageFromServerOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiveMessageFromServerOptionsInternal>.NativeClassPtr, 100674488);
      ReceiveMessageFromServerOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ReceiveMessageFromServerOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiveMessageFromServerOptionsInternal>.NativeClassPtr, 100674489);
      ReceiveMessageFromServerOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiveMessageFromServerOptionsInternal>.NativeClassPtr, 100674490);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReceiveMessageFromServerOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
