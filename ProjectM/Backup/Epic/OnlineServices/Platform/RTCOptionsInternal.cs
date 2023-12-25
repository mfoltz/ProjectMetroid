// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.RTCOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RTCOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PlatformSpecificOptions;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlatformSpecificOptions_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlatformSpecificOptions_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_RTCOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_RTCOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_RTCOptions_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_PlatformSpecificOptions;

    public unsafe System.IntPtr PlatformSpecificOptions
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RTCOptionsInternal.NativeMethodInfoPtr_get_PlatformSpecificOptions_Public_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RTCOptionsInternal.NativeMethodInfoPtr_set_PlatformSpecificOptions_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 937897, RefRangeEnd = 937902, XrefRangeStart = 937897, XrefRangeEnd = 937902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref RTCOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_RTCOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972258, XrefRangeEnd = 972262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Nullable_Unboxed<RTCOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_RTCOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972262, XrefRangeEnd = 972266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void Get(out RTCOptions output)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref output;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RTCOptionsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_RTCOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RTCOptionsInternal()
    {
      Il2CppClassPointerStore<RTCOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Platform", nameof (RTCOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTCOptionsInternal>.NativeClassPtr);
      RTCOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      RTCOptionsInternal.NativeFieldInfoPtr_m_PlatformSpecificOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCOptionsInternal>.NativeClassPtr, nameof (m_PlatformSpecificOptions));
      RTCOptionsInternal.NativeMethodInfoPtr_get_PlatformSpecificOptions_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCOptionsInternal>.NativeClassPtr, 100674755);
      RTCOptionsInternal.NativeMethodInfoPtr_set_PlatformSpecificOptions_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCOptionsInternal>.NativeClassPtr, 100674756);
      RTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_RTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCOptionsInternal>.NativeClassPtr, 100674757);
      RTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_RTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCOptionsInternal>.NativeClassPtr, 100674758);
      RTCOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCOptionsInternal>.NativeClassPtr, 100674759);
      RTCOptionsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_RTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCOptionsInternal>.NativeClassPtr, 100674760);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RTCOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
