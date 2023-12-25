// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.IntegratedPlatform.SteamOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.IntegratedPlatform
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SteamOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OverrideLibraryPath;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SteamMajorVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SteamMinorVersion;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OverrideLibraryPath_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OverrideLibraryPath_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SteamMajorVersion_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SteamMajorVersion_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SteamMinorVersion_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SteamMinorVersion_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SteamOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_SteamOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_SteamOptions_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_OverrideLibraryPath;
    [FieldOffset(16)]
    public uint m_SteamMajorVersion;
    [FieldOffset(20)]
    public uint m_SteamMinorVersion;

    public unsafe Epic.OnlineServices.Utf8String OverrideLibraryPath
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960344, XrefRangeEnd = 960348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamOptionsInternal.NativeMethodInfoPtr_get_OverrideLibraryPath_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960348, XrefRangeEnd = 960352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SteamOptionsInternal.NativeMethodInfoPtr_set_OverrideLibraryPath_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint SteamMajorVersion
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 23501, RefRangeEnd = 23506, XrefRangeStart = 23501, XrefRangeEnd = 23506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamOptionsInternal.NativeMethodInfoPtr_get_SteamMajorVersion_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SteamOptionsInternal.NativeMethodInfoPtr_set_SteamMajorVersion_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint SteamMinorVersion
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 23498, RefRangeEnd = 23499, XrefRangeStart = 23498, XrefRangeEnd = 23499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SteamOptionsInternal.NativeMethodInfoPtr_get_SteamMinorVersion_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 23499, RefRangeEnd = 23501, XrefRangeStart = 23499, XrefRangeEnd = 23501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SteamOptionsInternal.NativeMethodInfoPtr_set_SteamMinorVersion_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960352, XrefRangeEnd = 960356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref SteamOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SteamOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960356, XrefRangeEnd = 960368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<SteamOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_SteamOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960368, XrefRangeEnd = 960372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960372, XrefRangeEnd = 960373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out SteamOptions output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SteamOptionsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_SteamOptions_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref SteamOptions local = ref output;
      System.IntPtr pointer = zero;
      SteamOptions steamOptions = pointer == System.IntPtr.Zero ? (SteamOptions) null : new SteamOptions(pointer);
      local = steamOptions;
    }

    static SteamOptionsInternal()
    {
      Il2CppClassPointerStore<SteamOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.IntegratedPlatform", nameof (SteamOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamOptionsInternal>.NativeClassPtr);
      SteamOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      SteamOptionsInternal.NativeFieldInfoPtr_m_OverrideLibraryPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamOptionsInternal>.NativeClassPtr, nameof (m_OverrideLibraryPath));
      SteamOptionsInternal.NativeFieldInfoPtr_m_SteamMajorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamOptionsInternal>.NativeClassPtr, nameof (m_SteamMajorVersion));
      SteamOptionsInternal.NativeFieldInfoPtr_m_SteamMinorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamOptionsInternal>.NativeClassPtr, nameof (m_SteamMinorVersion));
      SteamOptionsInternal.NativeMethodInfoPtr_get_OverrideLibraryPath_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamOptionsInternal>.NativeClassPtr, 100671430);
      SteamOptionsInternal.NativeMethodInfoPtr_set_OverrideLibraryPath_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamOptionsInternal>.NativeClassPtr, 100671431);
      SteamOptionsInternal.NativeMethodInfoPtr_get_SteamMajorVersion_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamOptionsInternal>.NativeClassPtr, 100671432);
      SteamOptionsInternal.NativeMethodInfoPtr_set_SteamMajorVersion_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamOptionsInternal>.NativeClassPtr, 100671433);
      SteamOptionsInternal.NativeMethodInfoPtr_get_SteamMinorVersion_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamOptionsInternal>.NativeClassPtr, 100671434);
      SteamOptionsInternal.NativeMethodInfoPtr_set_SteamMinorVersion_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamOptionsInternal>.NativeClassPtr, 100671435);
      SteamOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SteamOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamOptionsInternal>.NativeClassPtr, 100671436);
      SteamOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_SteamOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamOptionsInternal>.NativeClassPtr, 100671437);
      SteamOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamOptionsInternal>.NativeClassPtr, 100671438);
      SteamOptionsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_SteamOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamOptionsInternal>.NativeClassPtr, 100671439);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
