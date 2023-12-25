// Decompiled with JetBrains decompiler
// Type: ProjectM.PerformanceSummary_Positions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PerformanceSummary_Positions
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Position0;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position1;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Calculate_Public_Void_NativeArray_1_float2_0;
    [FieldOffset(0)]
    public float2 Position0;
    [FieldOffset(8)]
    public float2 Position1;
    [FieldOffset(16)]
    public float2 Position2;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1055154, RefRangeEnd = 1055155, XrefRangeStart = 1055154, XrefRangeEnd = 1055154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Calculate(NativeArray<float2> array)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &array;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PerformanceSummary_Positions.NativeMethodInfoPtr_Calculate_Public_Void_NativeArray_1_float2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PerformanceSummary_Positions()
    {
      Il2CppClassPointerStore<PerformanceSummary_Positions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PerformanceSummary_Positions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerformanceSummary_Positions>.NativeClassPtr);
      PerformanceSummary_Positions.NativeFieldInfoPtr_Position0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummary_Positions>.NativeClassPtr, nameof (Position0));
      PerformanceSummary_Positions.NativeFieldInfoPtr_Position1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummary_Positions>.NativeClassPtr, nameof (Position1));
      PerformanceSummary_Positions.NativeFieldInfoPtr_Position2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummary_Positions>.NativeClassPtr, nameof (Position2));
      PerformanceSummary_Positions.NativeMethodInfoPtr_Calculate_Public_Void_NativeArray_1_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceSummary_Positions>.NativeClassPtr, 100682987);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PerformanceSummary_Positions>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
