// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.UI.PauseSocialOverlayOptionsInternal
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
  public struct PauseSocialOverlayOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_IsPaused;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IsPaused_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PauseSocialOverlayOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_PauseSocialOverlayOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(4)]
    public int m_IsPaused;

    public unsafe bool IsPaused
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937874, XrefRangeEnd = 937878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PauseSocialOverlayOptionsInternal.NativeMethodInfoPtr_set_IsPaused_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 937882, RefRangeEnd = 937883, XrefRangeStart = 937878, XrefRangeEnd = 937882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref PauseSocialOverlayOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PauseSocialOverlayOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PauseSocialOverlayOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937883, XrefRangeEnd = 937891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Nullable_Unboxed<PauseSocialOverlayOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PauseSocialOverlayOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_PauseSocialOverlayOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PauseSocialOverlayOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PauseSocialOverlayOptionsInternal()
    {
      Il2CppClassPointerStore<PauseSocialOverlayOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.UI", nameof (PauseSocialOverlayOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PauseSocialOverlayOptionsInternal>.NativeClassPtr);
      PauseSocialOverlayOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseSocialOverlayOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      PauseSocialOverlayOptionsInternal.NativeFieldInfoPtr_m_IsPaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseSocialOverlayOptionsInternal>.NativeClassPtr, nameof (m_IsPaused));
      PauseSocialOverlayOptionsInternal.NativeMethodInfoPtr_set_IsPaused_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseSocialOverlayOptionsInternal>.NativeClassPtr, 100665292);
      PauseSocialOverlayOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PauseSocialOverlayOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseSocialOverlayOptionsInternal>.NativeClassPtr, 100665293);
      PauseSocialOverlayOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_PauseSocialOverlayOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseSocialOverlayOptionsInternal>.NativeClassPtr, 100665294);
      PauseSocialOverlayOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseSocialOverlayOptionsInternal>.NativeClassPtr, 100665295);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PauseSocialOverlayOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
