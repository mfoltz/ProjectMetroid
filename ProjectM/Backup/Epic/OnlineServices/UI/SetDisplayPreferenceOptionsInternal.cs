// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.UI.SetDisplayPreferenceOptionsInternal
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
  public struct SetDisplayPreferenceOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_NotificationLocation;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_NotificationLocation_Public_set_Void_NotificationLocation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SetDisplayPreferenceOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_SetDisplayPreferenceOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(4)]
    public NotificationLocation m_NotificationLocation;

    public unsafe NotificationLocation NotificationLocation
    {
      [CallerCount(14), CachedScanResults(RefRangeStart = 204767, RefRangeEnd = 204781, XrefRangeStart = 204767, XrefRangeEnd = 204781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetDisplayPreferenceOptionsInternal.NativeMethodInfoPtr_set_NotificationLocation_Public_set_Void_NotificationLocation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 937918, RefRangeEnd = 937935, XrefRangeStart = 937918, XrefRangeEnd = 937918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref SetDisplayPreferenceOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetDisplayPreferenceOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SetDisplayPreferenceOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937935, XrefRangeEnd = 937939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Nullable_Unboxed<SetDisplayPreferenceOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetDisplayPreferenceOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_SetDisplayPreferenceOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetDisplayPreferenceOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SetDisplayPreferenceOptionsInternal()
    {
      Il2CppClassPointerStore<SetDisplayPreferenceOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.UI", nameof (SetDisplayPreferenceOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetDisplayPreferenceOptionsInternal>.NativeClassPtr);
      SetDisplayPreferenceOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetDisplayPreferenceOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      SetDisplayPreferenceOptionsInternal.NativeFieldInfoPtr_m_NotificationLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetDisplayPreferenceOptionsInternal>.NativeClassPtr, nameof (m_NotificationLocation));
      SetDisplayPreferenceOptionsInternal.NativeMethodInfoPtr_set_NotificationLocation_Public_set_Void_NotificationLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetDisplayPreferenceOptionsInternal>.NativeClassPtr, 100665316);
      SetDisplayPreferenceOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SetDisplayPreferenceOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetDisplayPreferenceOptionsInternal>.NativeClassPtr, 100665317);
      SetDisplayPreferenceOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_SetDisplayPreferenceOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetDisplayPreferenceOptionsInternal>.NativeClassPtr, 100665318);
      SetDisplayPreferenceOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetDisplayPreferenceOptionsInternal>.NativeClassPtr, 100665319);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetDisplayPreferenceOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
