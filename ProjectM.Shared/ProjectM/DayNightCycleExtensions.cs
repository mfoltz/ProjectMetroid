// Decompiled with JetBrains decompiler
// Type: ProjectM.DayNightCycleExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class DayNightCycleExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DaysPerMonth;
    private static readonly System.IntPtr NativeFieldInfoPtr_MonthsPerYear;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddTime_Public_Static_Void_byref_DayNightCycle_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTime_Public_Static_Void_byref_DayNightCycle_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTime_Public_Static_Void_byref_DayNightCycle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetGameDateTimeNow_Public_Static_GameDateTime_byref_DayNightCycle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TotalDays_Public_Static_Int32_byref_DayNightCycle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeScale_Public_Static_TimeScale_byref_DayNightCycle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeScale_Public_Static_TimeScale_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDateInTime_Public_Static_Single_byref_DayNightCycle_byref_DateDuration_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDateInTime_Public_Static_Single_byref_DayNightCycle_Int32_Int32_Int32_Int32_Int32_Int32_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724526, XrefRangeEnd = 724534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddTime(ref this DayNightCycle cycle, double time)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref cycle;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DayNightCycleExtensions.NativeMethodInfoPtr_AddTime_Public_Static_Void_byref_DayNightCycle_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 724542, RefRangeEnd = 724545, XrefRangeStart = 724534, XrefRangeEnd = 724542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetTime(ref this DayNightCycle cycle, double time)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref cycle;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DayNightCycleExtensions.NativeMethodInfoPtr_SetTime_Public_Static_Void_byref_DayNightCycle_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 724549, RefRangeEnd = 724550, XrefRangeStart = 724545, XrefRangeEnd = 724549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void UpdateTime(ref this DayNightCycle cycle)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref cycle;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DayNightCycleExtensions.NativeMethodInfoPtr_UpdateTime_Public_Static_Void_byref_DayNightCycle_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 724567, RefRangeEnd = 724572, XrefRangeStart = 724550, XrefRangeEnd = 724567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe GameDateTime GetGameDateTimeNow([In] ref this DayNightCycle dayNightCycle)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref dayNightCycle;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayNightCycleExtensions.NativeMethodInfoPtr_GetGameDateTimeNow_Public_Static_GameDateTime_byref_DayNightCycle_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameDateTime*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 724576, RefRangeEnd = 724580, XrefRangeStart = 724572, XrefRangeEnd = 724576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int TotalDays([In] ref this DayNightCycle dayNightCycle)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref dayNightCycle;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayNightCycleExtensions.NativeMethodInfoPtr_TotalDays_Public_Static_Int32_byref_DayNightCycle_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 724588, RefRangeEnd = 724595, XrefRangeStart = 724580, XrefRangeEnd = 724588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe DayNightCycleExtensions.TimeScale GetTimeScale(
      [In] ref this DayNightCycle dayNightCycle)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref dayNightCycle;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayNightCycleExtensions.NativeMethodInfoPtr_GetTimeScale_Public_Static_TimeScale_byref_DayNightCycle_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DayNightCycleExtensions.TimeScale*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 724599, RefRangeEnd = 724602, XrefRangeStart = 724595, XrefRangeEnd = 724599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe DayNightCycleExtensions.TimeScale GetTimeScale(float totalDayDuration)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &totalDayDuration;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayNightCycleExtensions.NativeMethodInfoPtr_GetTimeScale_Public_Static_TimeScale_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DayNightCycleExtensions.TimeScale*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 724606, RefRangeEnd = 724608, XrefRangeStart = 724602, XrefRangeEnd = 724606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetDateInTime(
      [In] ref this DayNightCycle dayNightCycle,
      [In] ref DateDuration duration)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref dayNightCycle;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref duration;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayNightCycleExtensions.NativeMethodInfoPtr_GetDateInTime_Public_Static_Single_byref_DayNightCycle_byref_DateDuration_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724608, XrefRangeEnd = 724612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetDateInTime(
      [In] ref this DayNightCycle dayNightCycle,
      int years,
      int months,
      int weeks,
      int days,
      int hours,
      int minutes)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) ref dayNightCycle;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &years;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &months;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &weeks;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &days;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &hours;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &minutes;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayNightCycleExtensions.NativeMethodInfoPtr_GetDateInTime_Public_Static_Single_byref_DayNightCycle_Int32_Int32_Int32_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DayNightCycleExtensions()
    {
      Il2CppClassPointerStore<DayNightCycleExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DayNightCycleExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DayNightCycleExtensions>.NativeClassPtr);
      DayNightCycleExtensions.NativeFieldInfoPtr_DaysPerMonth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleExtensions>.NativeClassPtr, nameof (DaysPerMonth));
      DayNightCycleExtensions.NativeFieldInfoPtr_MonthsPerYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleExtensions>.NativeClassPtr, nameof (MonthsPerYear));
      DayNightCycleExtensions.NativeMethodInfoPtr_AddTime_Public_Static_Void_byref_DayNightCycle_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleExtensions>.NativeClassPtr, 100664074);
      DayNightCycleExtensions.NativeMethodInfoPtr_SetTime_Public_Static_Void_byref_DayNightCycle_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleExtensions>.NativeClassPtr, 100664075);
      DayNightCycleExtensions.NativeMethodInfoPtr_UpdateTime_Public_Static_Void_byref_DayNightCycle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleExtensions>.NativeClassPtr, 100664076);
      DayNightCycleExtensions.NativeMethodInfoPtr_GetGameDateTimeNow_Public_Static_GameDateTime_byref_DayNightCycle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleExtensions>.NativeClassPtr, 100664077);
      DayNightCycleExtensions.NativeMethodInfoPtr_TotalDays_Public_Static_Int32_byref_DayNightCycle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleExtensions>.NativeClassPtr, 100664078);
      DayNightCycleExtensions.NativeMethodInfoPtr_GetTimeScale_Public_Static_TimeScale_byref_DayNightCycle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleExtensions>.NativeClassPtr, 100664079);
      DayNightCycleExtensions.NativeMethodInfoPtr_GetTimeScale_Public_Static_TimeScale_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleExtensions>.NativeClassPtr, 100664080);
      DayNightCycleExtensions.NativeMethodInfoPtr_GetDateInTime_Public_Static_Single_byref_DayNightCycle_byref_DateDuration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleExtensions>.NativeClassPtr, 100664081);
      DayNightCycleExtensions.NativeMethodInfoPtr_GetDateInTime_Public_Static_Single_byref_DayNightCycle_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycleExtensions>.NativeClassPtr, 100664082);
    }

    public DayNightCycleExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int DaysPerMonth
    {
      get
      {
        int daysPerMonth;
        IL2CPP.il2cpp_field_static_get_value(DayNightCycleExtensions.NativeFieldInfoPtr_DaysPerMonth, (void*) &daysPerMonth);
        return daysPerMonth;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DayNightCycleExtensions.NativeFieldInfoPtr_DaysPerMonth, (void*) &value);
      }
    }

    public static unsafe int MonthsPerYear
    {
      get
      {
        int monthsPerYear;
        IL2CPP.il2cpp_field_static_get_value(DayNightCycleExtensions.NativeFieldInfoPtr_MonthsPerYear, (void*) &monthsPerYear);
        return monthsPerYear;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DayNightCycleExtensions.NativeFieldInfoPtr_MonthsPerYear, (void*) &value);
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TimeScale
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TimePerMinute;
      private static readonly System.IntPtr NativeFieldInfoPtr_TimePerHour;
      private static readonly System.IntPtr NativeFieldInfoPtr_TimePerDay;
      private static readonly System.IntPtr NativeFieldInfoPtr_TimePerWeek;
      private static readonly System.IntPtr NativeFieldInfoPtr_TimePerMonth;
      private static readonly System.IntPtr NativeFieldInfoPtr_TimePerYear;
      [FieldOffset(0)]
      public float TimePerMinute;
      [FieldOffset(4)]
      public float TimePerHour;
      [FieldOffset(8)]
      public float TimePerDay;
      [FieldOffset(12)]
      public float TimePerWeek;
      [FieldOffset(16)]
      public float TimePerMonth;
      [FieldOffset(20)]
      public float TimePerYear;

      static TimeScale()
      {
        Il2CppClassPointerStore<DayNightCycleExtensions.TimeScale>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DayNightCycleExtensions>.NativeClassPtr, nameof (TimeScale));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DayNightCycleExtensions.TimeScale>.NativeClassPtr);
        DayNightCycleExtensions.TimeScale.NativeFieldInfoPtr_TimePerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleExtensions.TimeScale>.NativeClassPtr, nameof (TimePerMinute));
        DayNightCycleExtensions.TimeScale.NativeFieldInfoPtr_TimePerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleExtensions.TimeScale>.NativeClassPtr, nameof (TimePerHour));
        DayNightCycleExtensions.TimeScale.NativeFieldInfoPtr_TimePerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleExtensions.TimeScale>.NativeClassPtr, nameof (TimePerDay));
        DayNightCycleExtensions.TimeScale.NativeFieldInfoPtr_TimePerWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleExtensions.TimeScale>.NativeClassPtr, nameof (TimePerWeek));
        DayNightCycleExtensions.TimeScale.NativeFieldInfoPtr_TimePerMonth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleExtensions.TimeScale>.NativeClassPtr, nameof (TimePerMonth));
        DayNightCycleExtensions.TimeScale.NativeFieldInfoPtr_TimePerYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycleExtensions.TimeScale>.NativeClassPtr, nameof (TimePerYear));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DayNightCycleExtensions.TimeScale>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
