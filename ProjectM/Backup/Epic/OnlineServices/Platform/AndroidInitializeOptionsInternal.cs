// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.AndroidInitializeOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AndroidInitializeOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AllocateMemoryFunction;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ReallocateMemoryFunction;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ReleaseMemoryFunction;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ProductName;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ProductVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Reserved;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SystemInitializeOptions;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OverrideThreadAffinity;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AllocateMemoryFunction_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ReallocateMemoryFunction_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ReleaseMemoryFunction_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductVersion_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SystemInitializeOptions_Public_set_Void_Nullable_1_AndroidInitializeOptionsSystemInitializeOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OverrideThreadAffinity_Public_set_Void_Nullable_Unboxed_1_InitializeThreadAffinity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AndroidInitializeOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AndroidInitializeOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_AllocateMemoryFunction;
    [FieldOffset(16)]
    public System.IntPtr m_ReallocateMemoryFunction;
    [FieldOffset(24)]
    public System.IntPtr m_ReleaseMemoryFunction;
    [FieldOffset(32)]
    public System.IntPtr m_ProductName;
    [FieldOffset(40)]
    public System.IntPtr m_ProductVersion;
    [FieldOffset(48)]
    public System.IntPtr m_Reserved;
    [FieldOffset(56)]
    public System.IntPtr m_SystemInitializeOptions;
    [FieldOffset(64)]
    public System.IntPtr m_OverrideThreadAffinity;

    public unsafe System.IntPtr AllocateMemoryFunction
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsInternal.NativeMethodInfoPtr_set_AllocateMemoryFunction_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe System.IntPtr ReallocateMemoryFunction
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsInternal.NativeMethodInfoPtr_set_ReallocateMemoryFunction_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe System.IntPtr ReleaseMemoryFunction
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsInternal.NativeMethodInfoPtr_set_ReleaseMemoryFunction_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String ProductName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971426, XrefRangeEnd = 971430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsInternal.NativeMethodInfoPtr_set_ProductName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String ProductVersion
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971430, XrefRangeEnd = 971434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsInternal.NativeMethodInfoPtr_set_ProductVersion_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe System.IntPtr Reserved
    {
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsInternal.NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppSystem.Nullable<AndroidInitializeOptionsSystemInitializeOptions> SystemInitializeOptions
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971434, XrefRangeEnd = 971440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsInternal.NativeMethodInfoPtr_set_SystemInitializeOptions_Public_set_Void_Nullable_1_AndroidInitializeOptionsSystemInitializeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<InitializeThreadAffinity> OverrideThreadAffinity
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971440, XrefRangeEnd = 971446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsInternal.NativeMethodInfoPtr_set_OverrideThreadAffinity_Public_set_Void_Nullable_Unboxed_1_InitializeThreadAffinity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 971466, RefRangeEnd = 971467, XrefRangeStart = 971446, XrefRangeEnd = 971466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref AndroidInitializeOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AndroidInitializeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971467, XrefRangeEnd = 971505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<AndroidInitializeOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AndroidInitializeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971505, XrefRangeEnd = 971516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AndroidInitializeOptionsInternal()
    {
      Il2CppClassPointerStore<AndroidInitializeOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Platform", nameof (AndroidInitializeOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidInitializeOptionsInternal>.NativeClassPtr);
      AndroidInitializeOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInitializeOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      AndroidInitializeOptionsInternal.NativeFieldInfoPtr_m_AllocateMemoryFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInitializeOptionsInternal>.NativeClassPtr, nameof (m_AllocateMemoryFunction));
      AndroidInitializeOptionsInternal.NativeFieldInfoPtr_m_ReallocateMemoryFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInitializeOptionsInternal>.NativeClassPtr, nameof (m_ReallocateMemoryFunction));
      AndroidInitializeOptionsInternal.NativeFieldInfoPtr_m_ReleaseMemoryFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInitializeOptionsInternal>.NativeClassPtr, nameof (m_ReleaseMemoryFunction));
      AndroidInitializeOptionsInternal.NativeFieldInfoPtr_m_ProductName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInitializeOptionsInternal>.NativeClassPtr, nameof (m_ProductName));
      AndroidInitializeOptionsInternal.NativeFieldInfoPtr_m_ProductVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInitializeOptionsInternal>.NativeClassPtr, nameof (m_ProductVersion));
      AndroidInitializeOptionsInternal.NativeFieldInfoPtr_m_Reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInitializeOptionsInternal>.NativeClassPtr, nameof (m_Reserved));
      AndroidInitializeOptionsInternal.NativeFieldInfoPtr_m_SystemInitializeOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInitializeOptionsInternal>.NativeClassPtr, nameof (m_SystemInitializeOptions));
      AndroidInitializeOptionsInternal.NativeFieldInfoPtr_m_OverrideThreadAffinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInitializeOptionsInternal>.NativeClassPtr, nameof (m_OverrideThreadAffinity));
      AndroidInitializeOptionsInternal.NativeMethodInfoPtr_set_AllocateMemoryFunction_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsInternal>.NativeClassPtr, 100674546);
      AndroidInitializeOptionsInternal.NativeMethodInfoPtr_set_ReallocateMemoryFunction_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsInternal>.NativeClassPtr, 100674547);
      AndroidInitializeOptionsInternal.NativeMethodInfoPtr_set_ReleaseMemoryFunction_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsInternal>.NativeClassPtr, 100674548);
      AndroidInitializeOptionsInternal.NativeMethodInfoPtr_set_ProductName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsInternal>.NativeClassPtr, 100674549);
      AndroidInitializeOptionsInternal.NativeMethodInfoPtr_set_ProductVersion_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsInternal>.NativeClassPtr, 100674550);
      AndroidInitializeOptionsInternal.NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsInternal>.NativeClassPtr, 100674551);
      AndroidInitializeOptionsInternal.NativeMethodInfoPtr_set_SystemInitializeOptions_Public_set_Void_Nullable_1_AndroidInitializeOptionsSystemInitializeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsInternal>.NativeClassPtr, 100674552);
      AndroidInitializeOptionsInternal.NativeMethodInfoPtr_set_OverrideThreadAffinity_Public_set_Void_Nullable_Unboxed_1_InitializeThreadAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsInternal>.NativeClassPtr, 100674553);
      AndroidInitializeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AndroidInitializeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsInternal>.NativeClassPtr, 100674554);
      AndroidInitializeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AndroidInitializeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsInternal>.NativeClassPtr, 100674555);
      AndroidInitializeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsInternal>.NativeClassPtr, 100674556);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AndroidInitializeOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
