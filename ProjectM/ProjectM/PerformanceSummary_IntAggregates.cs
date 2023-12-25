// Decompiled with JetBrains decompiler
// Type: ProjectM.PerformanceSummary_IntAggregates
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PerformanceSummary_IntAggregates
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Min;
    private static readonly System.IntPtr NativeFieldInfoPtr_Max;
    private static readonly System.IntPtr NativeFieldInfoPtr_Average;
    private static readonly System.IntPtr NativeFieldInfoPtr_Median;
    private static readonly System.IntPtr NativeMethodInfoPtr_Calculate_Public_Void_NativeArray_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCsvHeader_Public_Static_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCsvRow_Public_String_0;
    [FieldOffset(0)]
    public int Min;
    [FieldOffset(4)]
    public int Max;
    [FieldOffset(8)]
    public int Average;
    [FieldOffset(12)]
    public int Median;

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 1055158, RefRangeEnd = 1055171, XrefRangeStart = 1055155, XrefRangeEnd = 1055158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Calculate(NativeArray<int> array)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &array;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PerformanceSummary_IntAggregates.NativeMethodInfoPtr_Calculate_Public_Void_NativeArray_1_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055171, XrefRangeEnd = 1055195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PerformanceSummary_IntAggregates.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 1055260, RefRangeEnd = 1055273, XrefRangeStart = 1055195, XrefRangeEnd = 1055260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetCsvHeader(string name)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PerformanceSummary_IntAggregates.NativeMethodInfoPtr_GetCsvHeader_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 1055297, RefRangeEnd = 1055310, XrefRangeStart = 1055273, XrefRangeEnd = 1055297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetCsvRow()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PerformanceSummary_IntAggregates.NativeMethodInfoPtr_GetCsvRow_Public_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static PerformanceSummary_IntAggregates()
    {
      Il2CppClassPointerStore<PerformanceSummary_IntAggregates>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PerformanceSummary_IntAggregates));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerformanceSummary_IntAggregates>.NativeClassPtr);
      PerformanceSummary_IntAggregates.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummary_IntAggregates>.NativeClassPtr, nameof (Min));
      PerformanceSummary_IntAggregates.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummary_IntAggregates>.NativeClassPtr, nameof (Max));
      PerformanceSummary_IntAggregates.NativeFieldInfoPtr_Average = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummary_IntAggregates>.NativeClassPtr, nameof (Average));
      PerformanceSummary_IntAggregates.NativeFieldInfoPtr_Median = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummary_IntAggregates>.NativeClassPtr, nameof (Median));
      PerformanceSummary_IntAggregates.NativeMethodInfoPtr_Calculate_Public_Void_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceSummary_IntAggregates>.NativeClassPtr, 100682988);
      PerformanceSummary_IntAggregates.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceSummary_IntAggregates>.NativeClassPtr, 100682989);
      PerformanceSummary_IntAggregates.NativeMethodInfoPtr_GetCsvHeader_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceSummary_IntAggregates>.NativeClassPtr, 100682990);
      PerformanceSummary_IntAggregates.NativeMethodInfoPtr_GetCsvRow_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceSummary_IntAggregates>.NativeClassPtr, 100682991);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PerformanceSummary_IntAggregates>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
