// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.AndroidInitializeOptionsSystemInitializeOptionsInternal
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
  public struct AndroidInitializeOptionsSystemInitializeOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Reserved;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OptionalInternalDirectory;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OptionalExternalDirectory;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Reserved_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OptionalInternalDirectory_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OptionalInternalDirectory_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OptionalExternalDirectory_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OptionalExternalDirectory_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AndroidInitializeOptionsSystemInitializeOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AndroidInitializeOptionsSystemInitializeOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_AndroidInitializeOptionsSystemInitializeOptions_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_Reserved;
    [FieldOffset(16)]
    public System.IntPtr m_OptionalInternalDirectory;
    [FieldOffset(24)]
    public System.IntPtr m_OptionalExternalDirectory;

    public unsafe System.IntPtr Reserved
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeMethodInfoPtr_get_Reserved_Public_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String OptionalInternalDirectory
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971527, XrefRangeEnd = 971531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeMethodInfoPtr_get_OptionalInternalDirectory_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971531, XrefRangeEnd = 971535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeMethodInfoPtr_set_OptionalInternalDirectory_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String OptionalExternalDirectory
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971535, XrefRangeEnd = 971539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeMethodInfoPtr_get_OptionalExternalDirectory_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971539, XrefRangeEnd = 971543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeMethodInfoPtr_set_OptionalExternalDirectory_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971543, XrefRangeEnd = 971551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref AndroidInitializeOptionsSystemInitializeOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AndroidInitializeOptionsSystemInitializeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971551, XrefRangeEnd = 971567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<AndroidInitializeOptionsSystemInitializeOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AndroidInitializeOptionsSystemInitializeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971567, XrefRangeEnd = 971573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971573, XrefRangeEnd = 971574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(
      out AndroidInitializeOptionsSystemInitializeOptions output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_AndroidInitializeOptionsSystemInitializeOptions_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref AndroidInitializeOptionsSystemInitializeOptions local = ref output;
      System.IntPtr pointer = zero;
      AndroidInitializeOptionsSystemInitializeOptions initializeOptions = pointer == System.IntPtr.Zero ? (AndroidInitializeOptionsSystemInitializeOptions) null : new AndroidInitializeOptionsSystemInitializeOptions(pointer);
      local = initializeOptions;
    }

    static AndroidInitializeOptionsSystemInitializeOptionsInternal()
    {
      Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Platform", nameof (AndroidInitializeOptionsSystemInitializeOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptionsInternal>.NativeClassPtr);
      AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeFieldInfoPtr_m_Reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptionsInternal>.NativeClassPtr, nameof (m_Reserved));
      AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeFieldInfoPtr_m_OptionalInternalDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptionsInternal>.NativeClassPtr, nameof (m_OptionalInternalDirectory));
      AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeFieldInfoPtr_m_OptionalExternalDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptionsInternal>.NativeClassPtr, nameof (m_OptionalExternalDirectory));
      AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeMethodInfoPtr_get_Reserved_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptionsInternal>.NativeClassPtr, 100674564);
      AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeMethodInfoPtr_set_Reserved_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptionsInternal>.NativeClassPtr, 100674565);
      AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeMethodInfoPtr_get_OptionalInternalDirectory_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptionsInternal>.NativeClassPtr, 100674566);
      AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeMethodInfoPtr_set_OptionalInternalDirectory_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptionsInternal>.NativeClassPtr, 100674567);
      AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeMethodInfoPtr_get_OptionalExternalDirectory_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptionsInternal>.NativeClassPtr, 100674568);
      AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeMethodInfoPtr_set_OptionalExternalDirectory_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptionsInternal>.NativeClassPtr, 100674569);
      AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AndroidInitializeOptionsSystemInitializeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptionsInternal>.NativeClassPtr, 100674570);
      AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AndroidInitializeOptionsSystemInitializeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptionsInternal>.NativeClassPtr, 100674571);
      AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptionsInternal>.NativeClassPtr, 100674572);
      AndroidInitializeOptionsSystemInitializeOptionsInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_AndroidInitializeOptionsSystemInitializeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptionsInternal>.NativeClassPtr, 100674573);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AndroidInitializeOptionsSystemInitializeOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
