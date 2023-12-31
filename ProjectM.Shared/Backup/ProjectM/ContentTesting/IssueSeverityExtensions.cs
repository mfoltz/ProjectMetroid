// Decompiled with JetBrains decompiler
// Type: ProjectM.ContentTesting.IssueSeverityExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

#nullable disable
namespace ProjectM.ContentTesting
{
  public static class IssueSeverityExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_IsIgnoredType_Public_Static_Boolean_IssueSeverity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AsIgnored_Public_Static_IssueSeverity_IssueSeverity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPrimaryColor_Public_Static_Color_IssueSeverity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBackgroundColor_Public_Static_Color_IssueSeverity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SortedCompareTo_Public_Static_Int32_IssueSeverity_IssueSeverity_0;

    [CallerCount(0)]
    public static unsafe bool IsIgnoredType(this IssueSeverity severity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &severity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IssueSeverityExtensions.NativeMethodInfoPtr_IsIgnoredType_Public_Static_Boolean_IssueSeverity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe IssueSeverity AsIgnored(this IssueSeverity severity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &severity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IssueSeverityExtensions.NativeMethodInfoPtr_AsIgnored_Public_Static_IssueSeverity_IssueSeverity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(IssueSeverity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765862, XrefRangeEnd = 765864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Color GetPrimaryColor(this IssueSeverity severity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &severity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IssueSeverityExtensions.NativeMethodInfoPtr_GetPrimaryColor_Public_Static_Color_IssueSeverity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765864, XrefRangeEnd = 765867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Color GetBackgroundColor(this IssueSeverity severity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &severity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IssueSeverityExtensions.NativeMethodInfoPtr_GetBackgroundColor_Public_Static_Color_IssueSeverity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe int SortedCompareTo(this IssueSeverity severity, IssueSeverity other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &severity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IssueSeverityExtensions.NativeMethodInfoPtr_SortedCompareTo_Public_Static_Int32_IssueSeverity_IssueSeverity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static IssueSeverityExtensions()
    {
      Il2CppClassPointerStore<IssueSeverityExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.ContentTesting", nameof (IssueSeverityExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IssueSeverityExtensions>.NativeClassPtr);
      IssueSeverityExtensions.NativeMethodInfoPtr_IsIgnoredType_Public_Static_Boolean_IssueSeverity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IssueSeverityExtensions>.NativeClassPtr, 100667685);
      IssueSeverityExtensions.NativeMethodInfoPtr_AsIgnored_Public_Static_IssueSeverity_IssueSeverity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IssueSeverityExtensions>.NativeClassPtr, 100667686);
      IssueSeverityExtensions.NativeMethodInfoPtr_GetPrimaryColor_Public_Static_Color_IssueSeverity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IssueSeverityExtensions>.NativeClassPtr, 100667687);
      IssueSeverityExtensions.NativeMethodInfoPtr_GetBackgroundColor_Public_Static_Color_IssueSeverity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IssueSeverityExtensions>.NativeClassPtr, 100667688);
      IssueSeverityExtensions.NativeMethodInfoPtr_SortedCompareTo_Public_Static_Int32_IssueSeverity_IssueSeverity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IssueSeverityExtensions>.NativeClassPtr, 100667689);
    }

    public IssueSeverityExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
