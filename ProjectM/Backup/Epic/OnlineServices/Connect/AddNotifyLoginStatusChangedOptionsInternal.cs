﻿// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.AddNotifyLoginStatusChangedOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Connect
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AddNotifyLoginStatusChangedOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AddNotifyLoginStatusChangedOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_AddNotifyLoginStatusChangedOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;

    [CallerCount(59)]
    [CachedScanResults(RefRangeStart = 383282, RefRangeEnd = 383341, XrefRangeStart = 383282, XrefRangeEnd = 383341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref AddNotifyLoginStatusChangedOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AddNotifyLoginStatusChangedOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AddNotifyLoginStatusChangedOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964703, XrefRangeEnd = 964704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Nullable_Unboxed<AddNotifyLoginStatusChangedOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AddNotifyLoginStatusChangedOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_AddNotifyLoginStatusChangedOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AddNotifyLoginStatusChangedOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AddNotifyLoginStatusChangedOptionsInternal()
    {
      Il2CppClassPointerStore<AddNotifyLoginStatusChangedOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Connect", nameof (AddNotifyLoginStatusChangedOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddNotifyLoginStatusChangedOptionsInternal>.NativeClassPtr);
      AddNotifyLoginStatusChangedOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddNotifyLoginStatusChangedOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      AddNotifyLoginStatusChangedOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AddNotifyLoginStatusChangedOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNotifyLoginStatusChangedOptionsInternal>.NativeClassPtr, 100672628);
      AddNotifyLoginStatusChangedOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_AddNotifyLoginStatusChangedOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNotifyLoginStatusChangedOptionsInternal>.NativeClassPtr, 100672629);
      AddNotifyLoginStatusChangedOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNotifyLoginStatusChangedOptionsInternal>.NativeClassPtr, 100672630);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AddNotifyLoginStatusChangedOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
