// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.FixedStringExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Shared
{
  public static class FixedStringExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_byref_FixedString32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_byref_FixedString64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_byref_FixedString128_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_byref_FixedString512_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_byref_FixedString4096_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsLengthValid_Private_Static_Boolean_Int32_Int32_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 799935, XrefRangeEnd = 799936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsValid([In] ref this FixedString32 value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FixedStringExtensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_byref_FixedString32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 799937, RefRangeEnd = 799943, XrefRangeStart = 799936, XrefRangeEnd = 799937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsValid([In] ref this FixedString64 value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FixedStringExtensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_byref_FixedString64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 799943, XrefRangeEnd = 799944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsValid([In] ref this FixedString128 value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FixedStringExtensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_byref_FixedString128_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 799945, RefRangeEnd = 799946, XrefRangeStart = 799944, XrefRangeEnd = 799945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsValid([In] ref this FixedString512 value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FixedStringExtensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_byref_FixedString512_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 799946, XrefRangeEnd = 799950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsValid([In] ref this FixedString4096 value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FixedStringExtensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_byref_FixedString4096_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool IsLengthValid(int length, int maxLength)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &length;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxLength;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FixedStringExtensions.NativeMethodInfoPtr_IsLengthValid_Private_Static_Boolean_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static FixedStringExtensions()
    {
      Il2CppClassPointerStore<FixedStringExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (FixedStringExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixedStringExtensions>.NativeClassPtr);
      FixedStringExtensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_byref_FixedString32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedStringExtensions>.NativeClassPtr, 100670567);
      FixedStringExtensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_byref_FixedString64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedStringExtensions>.NativeClassPtr, 100670568);
      FixedStringExtensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_byref_FixedString128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedStringExtensions>.NativeClassPtr, 100670569);
      FixedStringExtensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_byref_FixedString512_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedStringExtensions>.NativeClassPtr, 100670570);
      FixedStringExtensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_byref_FixedString4096_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedStringExtensions>.NativeClassPtr, 100670571);
      FixedStringExtensions.NativeMethodInfoPtr_IsLengthValid_Private_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedStringExtensions>.NativeClassPtr, 100670572);
    }

    public FixedStringExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
