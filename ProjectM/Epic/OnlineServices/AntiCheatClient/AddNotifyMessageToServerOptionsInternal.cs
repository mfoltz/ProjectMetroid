﻿// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatClient.AddNotifyMessageToServerOptionsInternal
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
  public struct AddNotifyMessageToServerOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AddNotifyMessageToServerOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_AddNotifyMessageToServerOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;

    [CallerCount(59)]
    [CachedScanResults(RefRangeStart = 383282, RefRangeEnd = 383341, XrefRangeStart = 383282, XrefRangeEnd = 383341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref AddNotifyMessageToServerOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AddNotifyMessageToServerOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AddNotifyMessageToServerOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970815, XrefRangeEnd = 970816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Nullable_Unboxed<AddNotifyMessageToServerOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AddNotifyMessageToServerOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_AddNotifyMessageToServerOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AddNotifyMessageToServerOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AddNotifyMessageToServerOptionsInternal()
    {
      Il2CppClassPointerStore<AddNotifyMessageToServerOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatClient", nameof (AddNotifyMessageToServerOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddNotifyMessageToServerOptionsInternal>.NativeClassPtr);
      AddNotifyMessageToServerOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddNotifyMessageToServerOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      AddNotifyMessageToServerOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AddNotifyMessageToServerOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNotifyMessageToServerOptionsInternal>.NativeClassPtr, 100674332);
      AddNotifyMessageToServerOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_AddNotifyMessageToServerOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNotifyMessageToServerOptionsInternal>.NativeClassPtr, 100674333);
      AddNotifyMessageToServerOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNotifyMessageToServerOptionsInternal>.NativeClassPtr, 100674334);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AddNotifyMessageToServerOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
