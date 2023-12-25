// Decompiled with JetBrains decompiler
// Type: ProjectM.EOS.EOSUtils
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace ProjectM.EOS
{
  public static class EOSUtils : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOrdinalSortingValueUnsigned_Public_Static_UInt64_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOrdinalSortingValue_Public_Static_Int64_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertValueRangeToSigned_Public_Static_Int64_UInt64_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124125, XrefRangeEnd = 1124126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ulong GetOrdinalSortingValueUnsigned(string value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSUtils.NativeMethodInfoPtr_GetOrdinalSortingValueUnsigned_Public_Static_UInt64_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124126, XrefRangeEnd = 1124127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe long GetOrdinalSortingValue(string value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSUtils.NativeMethodInfoPtr_GetOrdinalSortingValue_Public_Static_Int64_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(long*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe long ConvertValueRangeToSigned(ulong value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EOSUtils.NativeMethodInfoPtr_ConvertValueRangeToSigned_Public_Static_Int64_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(long*) IL2CPP.il2cpp_object_unbox(num);
    }

    static EOSUtils()
    {
      Il2CppClassPointerStore<EOSUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.EOS", nameof (EOSUtils));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EOSUtils>.NativeClassPtr);
      EOSUtils.NativeMethodInfoPtr_GetOrdinalSortingValueUnsigned_Public_Static_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSUtils>.NativeClassPtr, 100689190);
      EOSUtils.NativeMethodInfoPtr_GetOrdinalSortingValue_Public_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSUtils>.NativeClassPtr, 100689191);
      EOSUtils.NativeMethodInfoPtr_ConvertValueRangeToSigned_Public_Static_Int64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EOSUtils>.NativeClassPtr, 100689192);
    }

    public EOSUtils(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
