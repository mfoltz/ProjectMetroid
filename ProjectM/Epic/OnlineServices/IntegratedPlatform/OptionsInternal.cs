// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.IntegratedPlatform.OptionsInternal
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
  public struct OptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_InitOptions;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Flags_Public_get_IntegratedPlatformManagementFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Flags_Public_set_Void_IntegratedPlatformManagementFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_InitOptions_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_InitOptions_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Options_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_Options_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_Options_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_Type;
    [FieldOffset(16)]
    public IntegratedPlatformManagementFlags m_Flags;
    [FieldOffset(24)]
    public System.IntPtr m_InitOptions;

    public unsafe Epic.OnlineServices.Utf8String Type
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960308, XrefRangeEnd = 960312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_get_Type_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960312, XrefRangeEnd = 960316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_Type_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe IntegratedPlatformManagementFlags Flags
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 23501, RefRangeEnd = 23506, XrefRangeStart = 23501, XrefRangeEnd = 23506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_get_Flags_Public_get_IntegratedPlatformManagementFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(IntegratedPlatformManagementFlags*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_Flags_Public_set_Void_IntegratedPlatformManagementFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe System.IntPtr InitOptions
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_get_InitOptions_Public_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_set_InitOptions_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960316, XrefRangeEnd = 960320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Options other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Options_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960320, XrefRangeEnd = 960332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<Options> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_Options_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960332, XrefRangeEnd = 960337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960337, XrefRangeEnd = 960338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out Options output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_Options_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Options local = ref output;
      System.IntPtr pointer = zero;
      Options options = pointer == System.IntPtr.Zero ? (Options) null : new Options(pointer);
      local = options;
    }

    static OptionsInternal()
    {
      Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.IntegratedPlatform", nameof (OptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr);
      OptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      OptionsInternal.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_Type));
      OptionsInternal.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_Flags));
      OptionsInternal.NativeFieldInfoPtr_m_InitOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, nameof (m_InitOptions));
      OptionsInternal.NativeMethodInfoPtr_get_Type_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100671413);
      OptionsInternal.NativeMethodInfoPtr_set_Type_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100671414);
      OptionsInternal.NativeMethodInfoPtr_get_Flags_Public_get_IntegratedPlatformManagementFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100671415);
      OptionsInternal.NativeMethodInfoPtr_set_Flags_Public_set_Void_IntegratedPlatformManagementFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100671416);
      OptionsInternal.NativeMethodInfoPtr_get_InitOptions_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100671417);
      OptionsInternal.NativeMethodInfoPtr_set_InitOptions_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100671418);
      OptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Options_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100671419);
      OptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_Options_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100671420);
      OptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100671421);
      OptionsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_Options_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, 100671422);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
