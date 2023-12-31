// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitUptimeSetting
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UnitUptimeSetting
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveTimeSpace;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveHoursDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActivePercentage;
    private static readonly System.IntPtr NativeFieldInfoPtr_RespawnVariancePercentage;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllowedSpawnTimes;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnTimeBlob;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetNextValidTime_Public_Boolean_DayNightCycle_Single_Boolean_byref_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StepForwardOneTimeSpan_Private_Int32_Int32_byref_BlobArray_1_MinMaxValue_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StepBackOneTimeSpan_Private_Int32_Int32_byref_BlobArray_1_MinMaxValue_byref_Boolean_0;
    [FieldOffset(0)]
    public TimeSpace ActiveTimeSpace;
    [FieldOffset(4)]
    public float ActiveHoursDuration;
    [FieldOffset(8)]
    public float ActivePercentage;
    [FieldOffset(12)]
    public float RespawnVariancePercentage;
    [FieldOffset(16)]
    public DayTimeSpan AllowedSpawnTimes;
    [FieldOffset(32)]
    public DayTimeSpanBlob SpawnTimeBlob;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 749448, RefRangeEnd = 749450, XrefRangeStart = 749430, XrefRangeEnd = 749448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetNextValidTime(
      DayNightCycle dayNightCycle,
      float s,
      bool findNextValidTime,
      out double time)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &dayNightCycle;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &s;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &findNextValidTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref time;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitUptimeSetting.NativeMethodInfoPtr_TryGetNextValidTime_Public_Boolean_DayNightCycle_Single_Boolean_byref_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749450, XrefRangeEnd = 749451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int StepForwardOneTimeSpan(
      int currentIndex,
      ref BlobArray<DayTimeSpan.MinMaxValue> timeSpans,
      out bool yearChanged)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &currentIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref timeSpans;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref yearChanged;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitUptimeSetting.NativeMethodInfoPtr_StepForwardOneTimeSpan_Private_Int32_Int32_byref_BlobArray_1_MinMaxValue_byref_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749451, XrefRangeEnd = 749452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int StepBackOneTimeSpan(
      int currentIndex,
      ref BlobArray<DayTimeSpan.MinMaxValue> timeSpans,
      out bool yearChanged)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &currentIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref timeSpans;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref yearChanged;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitUptimeSetting.NativeMethodInfoPtr_StepBackOneTimeSpan_Private_Int32_Int32_byref_BlobArray_1_MinMaxValue_byref_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static UnitUptimeSetting()
    {
      Il2CppClassPointerStore<UnitUptimeSetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UnitUptimeSetting));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitUptimeSetting>.NativeClassPtr);
      UnitUptimeSetting.NativeFieldInfoPtr_ActiveTimeSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitUptimeSetting>.NativeClassPtr, nameof (ActiveTimeSpace));
      UnitUptimeSetting.NativeFieldInfoPtr_ActiveHoursDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitUptimeSetting>.NativeClassPtr, nameof (ActiveHoursDuration));
      UnitUptimeSetting.NativeFieldInfoPtr_ActivePercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitUptimeSetting>.NativeClassPtr, nameof (ActivePercentage));
      UnitUptimeSetting.NativeFieldInfoPtr_RespawnVariancePercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitUptimeSetting>.NativeClassPtr, nameof (RespawnVariancePercentage));
      UnitUptimeSetting.NativeFieldInfoPtr_AllowedSpawnTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitUptimeSetting>.NativeClassPtr, nameof (AllowedSpawnTimes));
      UnitUptimeSetting.NativeFieldInfoPtr_SpawnTimeBlob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitUptimeSetting>.NativeClassPtr, nameof (SpawnTimeBlob));
      UnitUptimeSetting.NativeMethodInfoPtr_TryGetNextValidTime_Public_Boolean_DayNightCycle_Single_Boolean_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitUptimeSetting>.NativeClassPtr, 100666012);
      UnitUptimeSetting.NativeMethodInfoPtr_StepForwardOneTimeSpan_Private_Int32_Int32_byref_BlobArray_1_MinMaxValue_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitUptimeSetting>.NativeClassPtr, 100666013);
      UnitUptimeSetting.NativeMethodInfoPtr_StepBackOneTimeSpan_Private_Int32_Int32_byref_BlobArray_1_MinMaxValue_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitUptimeSetting>.NativeClassPtr, 100666014);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitUptimeSetting>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
