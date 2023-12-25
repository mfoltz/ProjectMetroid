// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.SetRelayControlOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SetRelayControlOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_RelayControl;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RelayControl_Public_set_Void_RelayControl_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SetRelayControlOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_SetRelayControlOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(4)]
    public RelayControl m_RelayControl;

    public unsafe RelayControl RelayControl
    {
      [CallerCount(14), CachedScanResults(RefRangeStart = 204767, RefRangeEnd = 204781, XrefRangeStart = 204767, XrefRangeEnd = 204781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetRelayControlOptionsInternal.NativeMethodInfoPtr_set_RelayControl_Public_set_Void_RelayControl_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 937918, RefRangeEnd = 937935, XrefRangeStart = 937918, XrefRangeEnd = 937935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref SetRelayControlOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetRelayControlOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SetRelayControlOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952389, XrefRangeEnd = 952393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Nullable_Unboxed<SetRelayControlOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetRelayControlOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_SetRelayControlOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetRelayControlOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SetRelayControlOptionsInternal()
    {
      Il2CppClassPointerStore<SetRelayControlOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.P2P", nameof (SetRelayControlOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetRelayControlOptionsInternal>.NativeClassPtr);
      SetRelayControlOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRelayControlOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      SetRelayControlOptionsInternal.NativeFieldInfoPtr_m_RelayControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRelayControlOptionsInternal>.NativeClassPtr, nameof (m_RelayControl));
      SetRelayControlOptionsInternal.NativeMethodInfoPtr_set_RelayControl_Public_set_Void_RelayControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRelayControlOptionsInternal>.NativeClassPtr, 100669256);
      SetRelayControlOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SetRelayControlOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRelayControlOptionsInternal>.NativeClassPtr, 100669257);
      SetRelayControlOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_SetRelayControlOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRelayControlOptionsInternal>.NativeClassPtr, 100669258);
      SetRelayControlOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRelayControlOptionsInternal>.NativeClassPtr, 100669259);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetRelayControlOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
