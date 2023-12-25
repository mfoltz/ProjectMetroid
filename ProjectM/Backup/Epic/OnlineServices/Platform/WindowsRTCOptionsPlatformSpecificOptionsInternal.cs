// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.WindowsRTCOptionsPlatformSpecificOptionsInternal
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
  public struct WindowsRTCOptionsPlatformSpecificOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_XAudio29DllPath;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_XAudio29DllPath_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_XAudio29DllPath_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_WindowsRTCOptionsPlatformSpecificOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_WindowsRTCOptionsPlatformSpecificOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_WindowsRTCOptionsPlatformSpecificOptions_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_XAudio29DllPath;

    public unsafe Epic.OnlineServices.Utf8String XAudio29DllPath
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972518, XrefRangeEnd = 972522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeMethodInfoPtr_get_XAudio29DllPath_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972522, XrefRangeEnd = 972526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeMethodInfoPtr_set_XAudio29DllPath_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972526, XrefRangeEnd = 972530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref WindowsRTCOptionsPlatformSpecificOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_WindowsRTCOptionsPlatformSpecificOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972530, XrefRangeEnd = 972538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<WindowsRTCOptionsPlatformSpecificOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_WindowsRTCOptionsPlatformSpecificOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972538, XrefRangeEnd = 972542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972542, XrefRangeEnd = 972543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(
      out WindowsRTCOptionsPlatformSpecificOptions output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_WindowsRTCOptionsPlatformSpecificOptions_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref WindowsRTCOptionsPlatformSpecificOptions local = ref output;
      System.IntPtr pointer = zero;
      WindowsRTCOptionsPlatformSpecificOptions platformSpecificOptions = pointer == System.IntPtr.Zero ? (WindowsRTCOptionsPlatformSpecificOptions) null : new WindowsRTCOptionsPlatformSpecificOptions(pointer);
      local = platformSpecificOptions;
    }

    static WindowsRTCOptionsPlatformSpecificOptionsInternal()
    {
      Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Platform", nameof (WindowsRTCOptionsPlatformSpecificOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptionsInternal>.NativeClassPtr);
      WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeFieldInfoPtr_m_XAudio29DllPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptionsInternal>.NativeClassPtr, nameof (m_XAudio29DllPath));
      WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeMethodInfoPtr_get_XAudio29DllPath_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptionsInternal>.NativeClassPtr, 100674826);
      WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeMethodInfoPtr_set_XAudio29DllPath_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptionsInternal>.NativeClassPtr, 100674827);
      WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_WindowsRTCOptionsPlatformSpecificOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptionsInternal>.NativeClassPtr, 100674828);
      WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_WindowsRTCOptionsPlatformSpecificOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptionsInternal>.NativeClassPtr, 100674829);
      WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptionsInternal>.NativeClassPtr, 100674830);
      WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_WindowsRTCOptionsPlatformSpecificOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptionsInternal>.NativeClassPtr, 100674831);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
