// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.UI.PrePresentOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PrePresentOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PlatformSpecificData;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlatformSpecificData_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlatformSpecificData_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PrePresentOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_PrePresentOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PrePresentOptions_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_PlatformSpecificData;

    public unsafe System.IntPtr PlatformSpecificData
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrePresentOptionsInternal.NativeMethodInfoPtr_get_PlatformSpecificData_Public_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrePresentOptionsInternal.NativeMethodInfoPtr_set_PlatformSpecificData_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 937897, RefRangeEnd = 937902, XrefRangeStart = 937897, XrefRangeEnd = 937897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref PrePresentOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrePresentOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PrePresentOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937902, XrefRangeEnd = 937906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Nullable_Unboxed<PrePresentOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrePresentOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_PrePresentOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937906, XrefRangeEnd = 937910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrePresentOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void Get(out PrePresentOptions output)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref output;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrePresentOptionsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PrePresentOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PrePresentOptionsInternal()
    {
      Il2CppClassPointerStore<PrePresentOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.UI", nameof (PrePresentOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrePresentOptionsInternal>.NativeClassPtr);
      PrePresentOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrePresentOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      PrePresentOptionsInternal.NativeFieldInfoPtr_m_PlatformSpecificData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrePresentOptionsInternal>.NativeClassPtr, nameof (m_PlatformSpecificData));
      PrePresentOptionsInternal.NativeMethodInfoPtr_get_PlatformSpecificData_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrePresentOptionsInternal>.NativeClassPtr, 100665299);
      PrePresentOptionsInternal.NativeMethodInfoPtr_set_PlatformSpecificData_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrePresentOptionsInternal>.NativeClassPtr, 100665300);
      PrePresentOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PrePresentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrePresentOptionsInternal>.NativeClassPtr, 100665301);
      PrePresentOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_PrePresentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrePresentOptionsInternal>.NativeClassPtr, 100665302);
      PrePresentOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrePresentOptionsInternal>.NativeClassPtr, 100665303);
      PrePresentOptionsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PrePresentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrePresentOptionsInternal>.NativeClassPtr, 100665304);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrePresentOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
