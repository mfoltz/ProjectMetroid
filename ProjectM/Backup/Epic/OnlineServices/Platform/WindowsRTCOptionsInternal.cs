// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.WindowsRTCOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WindowsRTCOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PlatformSpecificOptions;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlatformSpecificOptions_Public_get_Nullable_1_WindowsRTCOptionsPlatformSpecificOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlatformSpecificOptions_Public_set_Void_Nullable_1_WindowsRTCOptionsPlatformSpecificOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_WindowsRTCOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_WindowsRTCOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_WindowsRTCOptions_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_PlatformSpecificOptions;

    public unsafe Il2CppSystem.Nullable<WindowsRTCOptionsPlatformSpecificOptions> PlatformSpecificOptions
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972479, XrefRangeEnd = 972485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsInternal.NativeMethodInfoPtr_get_PlatformSpecificOptions_Public_get_Nullable_1_WindowsRTCOptionsPlatformSpecificOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new Il2CppSystem.Nullable<WindowsRTCOptionsPlatformSpecificOptions>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972485, XrefRangeEnd = 972491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsInternal.NativeMethodInfoPtr_set_PlatformSpecificOptions_Public_set_Void_Nullable_1_WindowsRTCOptionsPlatformSpecificOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972491, XrefRangeEnd = 972497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref WindowsRTCOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_WindowsRTCOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972497, XrefRangeEnd = 972507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<WindowsRTCOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_WindowsRTCOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972507, XrefRangeEnd = 972511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972511, XrefRangeEnd = 972512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out WindowsRTCOptions output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_WindowsRTCOptions_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref WindowsRTCOptions local = ref output;
      System.IntPtr pointer = zero;
      WindowsRTCOptions windowsRtcOptions = pointer == System.IntPtr.Zero ? (WindowsRTCOptions) null : new WindowsRTCOptions(pointer);
      local = windowsRtcOptions;
    }

    static WindowsRTCOptionsInternal()
    {
      Il2CppClassPointerStore<WindowsRTCOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Platform", nameof (WindowsRTCOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsRTCOptionsInternal>.NativeClassPtr);
      WindowsRTCOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsRTCOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      WindowsRTCOptionsInternal.NativeFieldInfoPtr_m_PlatformSpecificOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsRTCOptionsInternal>.NativeClassPtr, nameof (m_PlatformSpecificOptions));
      WindowsRTCOptionsInternal.NativeMethodInfoPtr_get_PlatformSpecificOptions_Public_get_Nullable_1_WindowsRTCOptionsPlatformSpecificOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsInternal>.NativeClassPtr, 100674817);
      WindowsRTCOptionsInternal.NativeMethodInfoPtr_set_PlatformSpecificOptions_Public_set_Void_Nullable_1_WindowsRTCOptionsPlatformSpecificOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsInternal>.NativeClassPtr, 100674818);
      WindowsRTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_WindowsRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsInternal>.NativeClassPtr, 100674819);
      WindowsRTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_WindowsRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsInternal>.NativeClassPtr, 100674820);
      WindowsRTCOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsInternal>.NativeClassPtr, 100674821);
      WindowsRTCOptionsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_WindowsRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsInternal>.NativeClassPtr, 100674822);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WindowsRTCOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
