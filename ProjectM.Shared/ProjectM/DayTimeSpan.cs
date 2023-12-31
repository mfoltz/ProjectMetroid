// Decompiled with JetBrains decompiler
// Type: ProjectM.DayTimeSpan
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DayTimeSpan
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Days;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartMonth;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndMonth;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartHour;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartMinute;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndHour;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndMinute;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasValue;
    private static readonly System.IntPtr NativeMethodInfoPtr_Default_Public_Static_DayTimeSpan_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDayNightSpanBlob_Public_Static_DayTimeSpanBlob_DayTimeSpan_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MergeTimes_Private_Static_Void_NativeList_1_MinMaxValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SplitByWeekDays_Private_Static_NativeList_1_MinMaxValue_NativeList_1_MinMaxValue_TimeSpanWeekDayFlag_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SplitByTime_Private_Static_NativeList_1_MinMaxValue_NativeList_1_MinMaxValue_Int32_Int32_Int32_Int32_0;
    [FieldOffset(0)]
    public TimeSpanWeekDayFlag Days;
    [FieldOffset(4)]
    public byte StartMonth;
    [FieldOffset(5)]
    public byte EndMonth;
    [FieldOffset(6)]
    public byte StartHour;
    [FieldOffset(7)]
    public byte StartMinute;
    [FieldOffset(8)]
    public byte EndHour;
    [FieldOffset(9)]
    public byte EndMinute;
    [FieldOffset(10)]
    public bool HasValue;

    [CallerCount(0)]
    public static unsafe DayTimeSpan Default()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayTimeSpan.NativeMethodInfoPtr_Default_Public_Static_DayTimeSpan_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DayTimeSpan*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 748798, RefRangeEnd = 748800, XrefRangeStart = 748755, XrefRangeEnd = 748798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe DayTimeSpanBlob GetDayNightSpanBlob(DayTimeSpan dts)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &dts;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayTimeSpan.NativeMethodInfoPtr_GetDayNightSpanBlob_Public_Static_DayTimeSpanBlob_DayTimeSpan_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DayTimeSpanBlob*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 748818, RefRangeEnd = 748821, XrefRangeStart = 748800, XrefRangeEnd = 748818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void MergeTimes(
      NativeList<DayTimeSpan.MinMaxValue> mergedTimeSpans)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &mergedTimeSpans;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DayTimeSpan.NativeMethodInfoPtr_MergeTimes_Private_Static_Void_NativeList_1_MinMaxValue_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 748857, RefRangeEnd = 748858, XrefRangeStart = 748821, XrefRangeEnd = 748857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeList<DayTimeSpan.MinMaxValue> SplitByWeekDays(
      NativeList<DayTimeSpan.MinMaxValue> timeSpans,
      TimeSpanWeekDayFlag weekDayFlag,
      int minutesPerDay,
      int minutesPerWeek)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &timeSpans;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &weekDayFlag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &minutesPerDay;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &minutesPerWeek;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayTimeSpan.NativeMethodInfoPtr_SplitByWeekDays_Private_Static_NativeList_1_MinMaxValue_NativeList_1_MinMaxValue_TimeSpanWeekDayFlag_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<DayTimeSpan.MinMaxValue>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 748885, RefRangeEnd = 748887, XrefRangeStart = 748858, XrefRangeEnd = 748885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeList<DayTimeSpan.MinMaxValue> SplitByTime(
      NativeList<DayTimeSpan.MinMaxValue> timeSpans,
      int minuteValue,
      int start,
      int end,
      int max)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &timeSpans;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &minuteValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &start;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &max;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayTimeSpan.NativeMethodInfoPtr_SplitByTime_Private_Static_NativeList_1_MinMaxValue_NativeList_1_MinMaxValue_Int32_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<DayTimeSpan.MinMaxValue>*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DayTimeSpan()
    {
      Il2CppClassPointerStore<DayTimeSpan>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DayTimeSpan));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DayTimeSpan>.NativeClassPtr);
      DayTimeSpan.NativeFieldInfoPtr_Days = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayTimeSpan>.NativeClassPtr, nameof (Days));
      DayTimeSpan.NativeFieldInfoPtr_StartMonth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayTimeSpan>.NativeClassPtr, nameof (StartMonth));
      DayTimeSpan.NativeFieldInfoPtr_EndMonth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayTimeSpan>.NativeClassPtr, nameof (EndMonth));
      DayTimeSpan.NativeFieldInfoPtr_StartHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayTimeSpan>.NativeClassPtr, nameof (StartHour));
      DayTimeSpan.NativeFieldInfoPtr_StartMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayTimeSpan>.NativeClassPtr, nameof (StartMinute));
      DayTimeSpan.NativeFieldInfoPtr_EndHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayTimeSpan>.NativeClassPtr, nameof (EndHour));
      DayTimeSpan.NativeFieldInfoPtr_EndMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayTimeSpan>.NativeClassPtr, nameof (EndMinute));
      DayTimeSpan.NativeFieldInfoPtr_HasValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayTimeSpan>.NativeClassPtr, nameof (HasValue));
      DayTimeSpan.NativeMethodInfoPtr_Default_Public_Static_DayTimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayTimeSpan>.NativeClassPtr, 100665928);
      DayTimeSpan.NativeMethodInfoPtr_GetDayNightSpanBlob_Public_Static_DayTimeSpanBlob_DayTimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayTimeSpan>.NativeClassPtr, 100665929);
      DayTimeSpan.NativeMethodInfoPtr_MergeTimes_Private_Static_Void_NativeList_1_MinMaxValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayTimeSpan>.NativeClassPtr, 100665930);
      DayTimeSpan.NativeMethodInfoPtr_SplitByWeekDays_Private_Static_NativeList_1_MinMaxValue_NativeList_1_MinMaxValue_TimeSpanWeekDayFlag_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayTimeSpan>.NativeClassPtr, 100665931);
      DayTimeSpan.NativeMethodInfoPtr_SplitByTime_Private_Static_NativeList_1_MinMaxValue_NativeList_1_MinMaxValue_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayTimeSpan>.NativeClassPtr, 100665932);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DayTimeSpan>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MinMaxValue
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_MinMinutes;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxMinutes;
      [FieldOffset(0)]
      public int MinMinutes;
      [FieldOffset(4)]
      public int MaxMinutes;

      static MinMaxValue()
      {
        Il2CppClassPointerStore<DayTimeSpan.MinMaxValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DayTimeSpan>.NativeClassPtr, nameof (MinMaxValue));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DayTimeSpan.MinMaxValue>.NativeClassPtr);
        DayTimeSpan.MinMaxValue.NativeFieldInfoPtr_MinMinutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayTimeSpan.MinMaxValue>.NativeClassPtr, nameof (MinMinutes));
        DayTimeSpan.MinMaxValue.NativeFieldInfoPtr_MaxMinutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayTimeSpan.MinMaxValue>.NativeClassPtr, nameof (MaxMinutes));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DayTimeSpan.MinMaxValue>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
