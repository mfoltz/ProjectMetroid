// Decompiled with JetBrains decompiler
// Type: ProjectM.PerformanceSummary_FloatAggregates
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
  public struct PerformanceSummary_FloatAggregates
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Min;
    private static readonly System.IntPtr NativeFieldInfoPtr_Max;
    private static readonly System.IntPtr NativeFieldInfoPtr_Average;
    private static readonly System.IntPtr NativeFieldInfoPtr_Median;
    private static readonly System.IntPtr NativeMethodInfoPtr_Calculate_Public_Void_NativeArray_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCsvHeader_Public_Static_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCsvRow_Public_String_0;
    [FieldOffset(0)]
    public float Min;
    [FieldOffset(4)]
    public float Max;
    [FieldOffset(8)]
    public float Average;
    [FieldOffset(12)]
    public float Median;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1055315, RefRangeEnd = 1055317, XrefRangeStart = 1055310, XrefRangeEnd = 1055315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Calculate(NativeArray<float> array)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &array;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PerformanceSummary_FloatAggregates.NativeMethodInfoPtr_Calculate_Public_Void_NativeArray_1_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055317, XrefRangeEnd = 1055341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PerformanceSummary_FloatAggregates.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1055406, RefRangeEnd = 1055408, XrefRangeStart = 1055341, XrefRangeEnd = 1055406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetCsvHeader(string name)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PerformanceSummary_FloatAggregates.NativeMethodInfoPtr_GetCsvHeader_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1055432, RefRangeEnd = 1055434, XrefRangeStart = 1055408, XrefRangeEnd = 1055432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetCsvRow()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PerformanceSummary_FloatAggregates.NativeMethodInfoPtr_GetCsvRow_Public_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static PerformanceSummary_FloatAggregates()
    {
      Il2CppClassPointerStore<PerformanceSummary_FloatAggregates>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PerformanceSummary_FloatAggregates));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerformanceSummary_FloatAggregates>.NativeClassPtr);
      PerformanceSummary_FloatAggregates.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummary_FloatAggregates>.NativeClassPtr, nameof (Min));
      PerformanceSummary_FloatAggregates.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummary_FloatAggregates>.NativeClassPtr, nameof (Max));
      PerformanceSummary_FloatAggregates.NativeFieldInfoPtr_Average = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummary_FloatAggregates>.NativeClassPtr, nameof (Average));
      PerformanceSummary_FloatAggregates.NativeFieldInfoPtr_Median = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummary_FloatAggregates>.NativeClassPtr, nameof (Median));
      PerformanceSummary_FloatAggregates.NativeMethodInfoPtr_Calculate_Public_Void_NativeArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceSummary_FloatAggregates>.NativeClassPtr, 100682992);
      PerformanceSummary_FloatAggregates.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceSummary_FloatAggregates>.NativeClassPtr, 100682993);
      PerformanceSummary_FloatAggregates.NativeMethodInfoPtr_GetCsvHeader_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceSummary_FloatAggregates>.NativeClassPtr, 100682994);
      PerformanceSummary_FloatAggregates.NativeMethodInfoPtr_GetCsvRow_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceSummary_FloatAggregates>.NativeClassPtr, 100682995);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PerformanceSummary_FloatAggregates>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
