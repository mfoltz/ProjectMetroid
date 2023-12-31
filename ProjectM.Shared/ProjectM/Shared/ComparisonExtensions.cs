// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.ComparisonExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  public static class ComparisonExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_byref_Comparison_Unboxed_1_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_byref_Comparison_Unboxed_1_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_byref_Comparison_Unboxed_1_Int64_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSign_Public_Static_String_ConditionTypes_0;

    [CallerCount(19)]
    [CachedScanResults(RefRangeStart = 802172, RefRangeEnd = 802191, XrefRangeStart = 802172, XrefRangeEnd = 802172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Compare([In] ref this Comparison_Unboxed<float> comparison, float valueLHS)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref comparison;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &valueLHS;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ComparisonExtensions.NativeMethodInfoPtr_Compare_Public_Static_Boolean_byref_Comparison_Unboxed_1_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 802191, RefRangeEnd = 802200, XrefRangeStart = 802191, XrefRangeEnd = 802191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Compare([In] ref this Comparison_Unboxed<int> comparison, int valueLHS)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref comparison;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &valueLHS;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ComparisonExtensions.NativeMethodInfoPtr_Compare_Public_Static_Boolean_byref_Comparison_Unboxed_1_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool Compare([In] ref this Comparison_Unboxed<long> comparison, long valueLHS)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref comparison;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &valueLHS;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ComparisonExtensions.NativeMethodInfoPtr_Compare_Public_Static_Boolean_byref_Comparison_Unboxed_1_Int64_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 802207, RefRangeEnd = 802208, XrefRangeStart = 802200, XrefRangeEnd = 802207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetSign(this ConditionTypes ConditionTypes)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &ConditionTypes;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ComparisonExtensions.NativeMethodInfoPtr_GetSign_Public_Static_String_ConditionTypes_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static ComparisonExtensions()
    {
      Il2CppClassPointerStore<ComparisonExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (ComparisonExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComparisonExtensions>.NativeClassPtr);
      ComparisonExtensions.NativeMethodInfoPtr_Compare_Public_Static_Boolean_byref_Comparison_Unboxed_1_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComparisonExtensions>.NativeClassPtr, 100670734);
      ComparisonExtensions.NativeMethodInfoPtr_Compare_Public_Static_Boolean_byref_Comparison_Unboxed_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComparisonExtensions>.NativeClassPtr, 100670735);
      ComparisonExtensions.NativeMethodInfoPtr_Compare_Public_Static_Boolean_byref_Comparison_Unboxed_1_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComparisonExtensions>.NativeClassPtr, 100670736);
      ComparisonExtensions.NativeMethodInfoPtr_GetSign_Public_Static_String_ConditionTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComparisonExtensions>.NativeClassPtr, 100670737);
    }

    public ComparisonExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
