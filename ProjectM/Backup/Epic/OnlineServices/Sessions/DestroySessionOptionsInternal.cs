﻿// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.DestroySessionOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DestroySessionOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SessionName;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SessionName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_DestroySessionOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_DestroySessionOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_SessionName;

    public unsafe Epic.OnlineServices.Utf8String SessionName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940675, XrefRangeEnd = 940679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroySessionOptionsInternal.NativeMethodInfoPtr_set_SessionName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 940683, RefRangeEnd = 940685, XrefRangeStart = 940679, XrefRangeEnd = 940683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref DestroySessionOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroySessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_DestroySessionOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940685, XrefRangeEnd = 940693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<DestroySessionOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroySessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_DestroySessionOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940693, XrefRangeEnd = 940697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroySessionOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DestroySessionOptionsInternal()
    {
      Il2CppClassPointerStore<DestroySessionOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Sessions", nameof (DestroySessionOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroySessionOptionsInternal>.NativeClassPtr);
      DestroySessionOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroySessionOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      DestroySessionOptionsInternal.NativeFieldInfoPtr_m_SessionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroySessionOptionsInternal>.NativeClassPtr, nameof (m_SessionName));
      DestroySessionOptionsInternal.NativeMethodInfoPtr_set_SessionName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroySessionOptionsInternal>.NativeClassPtr, 100666009);
      DestroySessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_DestroySessionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroySessionOptionsInternal>.NativeClassPtr, 100666010);
      DestroySessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_DestroySessionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroySessionOptionsInternal>.NativeClassPtr, 100666011);
      DestroySessionOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroySessionOptionsInternal>.NativeClassPtr, 100666012);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroySessionOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
