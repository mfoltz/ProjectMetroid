// Decompiled with JetBrains decompiler
// Type: ProjectM.DayNightCycle
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DayNightCycle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Time;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayNightCycleStartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayDurationInSeconds;
    private static readonly System.IntPtr NativeFieldInfoPtr_Cloudiness;
    private static readonly System.IntPtr NativeFieldInfoPtr_MorningMoodTransitionDurationBeforeSunrise;
    private static readonly System.IntPtr NativeFieldInfoPtr_MorningMoodTransitionDurationAfterSunrise;
    private static readonly System.IntPtr NativeFieldInfoPtr_EveningMoodTransitionDurationBeforeSunset;
    private static readonly System.IntPtr NativeFieldInfoPtr_EveningMoodTransitionDurationAfterSunset;
    private static readonly System.IntPtr NativeFieldInfoPtr_MorningShadowTransitionDurationBeforeSunrise;
    private static readonly System.IntPtr NativeFieldInfoPtr_MorningShadowTransitionDurationAfterSunrise;
    private static readonly System.IntPtr NativeFieldInfoPtr_EveningShadowTransitionDurationBeforeSunset;
    private static readonly System.IntPtr NativeFieldInfoPtr_EveningShadowTransitionDurationAfterSunset;
    private static readonly System.IntPtr NativeFieldInfoPtr_DurationBeforeSunDamageAfterSunrise;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayTimeStartInSeconds;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayTimeDurationInSeconds;
    private static readonly System.IntPtr NativeFieldInfoPtr_NightTimeDurationInSeconds;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayTimeSpan;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodMoonBuffBonus;
    private static readonly System.IntPtr NativeFieldInfoPtr_NextBloodMoonDay;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodMoonFrequency_Min;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodMoonFrequency_Max;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastlePvPEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerPvPEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr__TimeSpanTicksSinceStart_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_AmbientBiome;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameDateTimeNow;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSinceMidnight_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSinceDayStart_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MorningMoodTransitionStart_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MorningMoodTransitionEnd_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MorningMoodTransitionDuration_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MorningShadowTransitionStart_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MorningShadowTransitionEnd_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MorningShadowTransitionDuration_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EveningMoodTransitionStart_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EveningMoodTransitionEnd_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EveningMoodTransitionDuration_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EveningShadowTransitionStart_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EveningShadowTransitionEnd_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EveningShadowTransitionDuration_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeOfDay_Public_get_TimeOfDay_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateNextBloodMoonDay_Public_Void_Random_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsBloodMoonDay_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSpanTicksSinceStart_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeSpanTicksSinceStart_Private_set_Void_Single_0;
    [FieldOffset(0)]
    public double Time;
    [FieldOffset(8)]
    public double ServerTime;
    [FieldOffset(16)]
    public float DayNightCycleStartTime;
    [FieldOffset(20)]
    public float DayDurationInSeconds;
    [FieldOffset(24)]
    public float Cloudiness;
    [FieldOffset(28)]
    public float MorningMoodTransitionDurationBeforeSunrise;
    [FieldOffset(32)]
    public float MorningMoodTransitionDurationAfterSunrise;
    [FieldOffset(36)]
    public float EveningMoodTransitionDurationBeforeSunset;
    [FieldOffset(40)]
    public float EveningMoodTransitionDurationAfterSunset;
    [FieldOffset(44)]
    public float MorningShadowTransitionDurationBeforeSunrise;
    [FieldOffset(48)]
    public float MorningShadowTransitionDurationAfterSunrise;
    [FieldOffset(52)]
    public float EveningShadowTransitionDurationBeforeSunset;
    [FieldOffset(56)]
    public float EveningShadowTransitionDurationAfterSunset;
    [FieldOffset(60)]
    public float DurationBeforeSunDamageAfterSunrise;
    [FieldOffset(64)]
    public float DayTimeStartInSeconds;
    [FieldOffset(68)]
    public float DayTimeDurationInSeconds;
    [FieldOffset(72)]
    public float NightTimeDurationInSeconds;
    [FieldOffset(76)]
    public DayTimeSpan DayTimeSpan;
    [FieldOffset(88)]
    public float BloodMoonBuffBonus;
    [FieldOffset(92)]
    public int NextBloodMoonDay;
    [FieldOffset(96)]
    public int BloodMoonFrequency_Min;
    [FieldOffset(100)]
    public int BloodMoonFrequency_Max;
    [FieldOffset(104)]
    public bool CastlePvPEnabled;
    [FieldOffset(105)]
    public bool PlayerPvPEnabled;
    [FieldOffset(108)]
    public float _TimeSpanTicksSinceStart_k__BackingField;
    [FieldOffset(112)]
    public int AmbientBiome;
    [FieldOffset(116)]
    public GameDateTime GameDateTimeNow;

    public unsafe float TimeSinceMidnight
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 723901, RefRangeEnd = 723905, XrefRangeStart = 723900, XrefRangeEnd = 723901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayNightCycle.NativeMethodInfoPtr_get_TimeSinceMidnight_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float TimeSinceDayStart
    {
      [CallerCount(6), CachedScanResults(RefRangeStart = 723906, RefRangeEnd = 723912, XrefRangeStart = 723905, XrefRangeEnd = 723906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayNightCycle.NativeMethodInfoPtr_get_TimeSinceDayStart_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float MorningMoodTransitionStart
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 723912, RefRangeEnd = 723916, XrefRangeStart = 723912, XrefRangeEnd = 723912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayNightCycle.NativeMethodInfoPtr_get_MorningMoodTransitionStart_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float MorningMoodTransitionEnd
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 723916, RefRangeEnd = 723918, XrefRangeStart = 723916, XrefRangeEnd = 723916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayNightCycle.NativeMethodInfoPtr_get_MorningMoodTransitionEnd_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float MorningMoodTransitionDuration
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 723918, RefRangeEnd = 723920, XrefRangeStart = 723918, XrefRangeEnd = 723918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayNightCycle.NativeMethodInfoPtr_get_MorningMoodTransitionDuration_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float MorningShadowTransitionStart
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 723920, RefRangeEnd = 723922, XrefRangeStart = 723920, XrefRangeEnd = 723920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayNightCycle.NativeMethodInfoPtr_get_MorningShadowTransitionStart_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float MorningShadowTransitionEnd
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 723922, RefRangeEnd = 723923, XrefRangeStart = 723922, XrefRangeEnd = 723922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayNightCycle.NativeMethodInfoPtr_get_MorningShadowTransitionEnd_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float MorningShadowTransitionDuration
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 723923, RefRangeEnd = 723924, XrefRangeStart = 723923, XrefRangeEnd = 723923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayNightCycle.NativeMethodInfoPtr_get_MorningShadowTransitionDuration_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float EveningMoodTransitionStart
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 723924, RefRangeEnd = 723928, XrefRangeStart = 723924, XrefRangeEnd = 723924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayNightCycle.NativeMethodInfoPtr_get_EveningMoodTransitionStart_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float EveningMoodTransitionEnd
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 723928, RefRangeEnd = 723930, XrefRangeStart = 723928, XrefRangeEnd = 723928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayNightCycle.NativeMethodInfoPtr_get_EveningMoodTransitionEnd_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float EveningMoodTransitionDuration
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 723930, RefRangeEnd = 723932, XrefRangeStart = 723930, XrefRangeEnd = 723930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayNightCycle.NativeMethodInfoPtr_get_EveningMoodTransitionDuration_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float EveningShadowTransitionStart
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 723932, RefRangeEnd = 723934, XrefRangeStart = 723932, XrefRangeEnd = 723932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayNightCycle.NativeMethodInfoPtr_get_EveningShadowTransitionStart_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float EveningShadowTransitionEnd
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 723934, RefRangeEnd = 723935, XrefRangeStart = 723934, XrefRangeEnd = 723934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayNightCycle.NativeMethodInfoPtr_get_EveningShadowTransitionEnd_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe float EveningShadowTransitionDuration
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 723935, RefRangeEnd = 723936, XrefRangeStart = 723935, XrefRangeEnd = 723935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayNightCycle.NativeMethodInfoPtr_get_EveningShadowTransitionDuration_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe TimeOfDay TimeOfDay
    {
      [CallerCount(15), CachedScanResults(RefRangeStart = 723937, RefRangeEnd = 723952, XrefRangeStart = 723936, XrefRangeEnd = 723937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayNightCycle.NativeMethodInfoPtr_get_TimeOfDay_Public_get_TimeOfDay_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TimeOfDay*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 723959, RefRangeEnd = 723960, XrefRangeStart = 723952, XrefRangeEnd = 723959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CalculateNextBloodMoonDay(Unity.Mathematics.Random random)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &random;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DayNightCycle.NativeMethodInfoPtr_CalculateNextBloodMoonDay_Public_Void_Random_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 723968, RefRangeEnd = 723973, XrefRangeStart = 723960, XrefRangeEnd = 723968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsBloodMoonDay()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayNightCycle.NativeMethodInfoPtr_IsBloodMoonDay_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    public unsafe float TimeSpanTicksSinceStart
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DayNightCycle.NativeMethodInfoPtr_get_TimeSpanTicksSinceStart_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DayNightCycle.NativeMethodInfoPtr_set_TimeSpanTicksSinceStart_Private_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static DayNightCycle()
    {
      Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DayNightCycle));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr);
      DayNightCycle.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (Time));
      DayNightCycle.NativeFieldInfoPtr_ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (ServerTime));
      DayNightCycle.NativeFieldInfoPtr_DayNightCycleStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (DayNightCycleStartTime));
      DayNightCycle.NativeFieldInfoPtr_DayDurationInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (DayDurationInSeconds));
      DayNightCycle.NativeFieldInfoPtr_Cloudiness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (Cloudiness));
      DayNightCycle.NativeFieldInfoPtr_MorningMoodTransitionDurationBeforeSunrise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (MorningMoodTransitionDurationBeforeSunrise));
      DayNightCycle.NativeFieldInfoPtr_MorningMoodTransitionDurationAfterSunrise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (MorningMoodTransitionDurationAfterSunrise));
      DayNightCycle.NativeFieldInfoPtr_EveningMoodTransitionDurationBeforeSunset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (EveningMoodTransitionDurationBeforeSunset));
      DayNightCycle.NativeFieldInfoPtr_EveningMoodTransitionDurationAfterSunset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (EveningMoodTransitionDurationAfterSunset));
      DayNightCycle.NativeFieldInfoPtr_MorningShadowTransitionDurationBeforeSunrise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (MorningShadowTransitionDurationBeforeSunrise));
      DayNightCycle.NativeFieldInfoPtr_MorningShadowTransitionDurationAfterSunrise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (MorningShadowTransitionDurationAfterSunrise));
      DayNightCycle.NativeFieldInfoPtr_EveningShadowTransitionDurationBeforeSunset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (EveningShadowTransitionDurationBeforeSunset));
      DayNightCycle.NativeFieldInfoPtr_EveningShadowTransitionDurationAfterSunset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (EveningShadowTransitionDurationAfterSunset));
      DayNightCycle.NativeFieldInfoPtr_DurationBeforeSunDamageAfterSunrise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (DurationBeforeSunDamageAfterSunrise));
      DayNightCycle.NativeFieldInfoPtr_DayTimeStartInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (DayTimeStartInSeconds));
      DayNightCycle.NativeFieldInfoPtr_DayTimeDurationInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (DayTimeDurationInSeconds));
      DayNightCycle.NativeFieldInfoPtr_NightTimeDurationInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (NightTimeDurationInSeconds));
      DayNightCycle.NativeFieldInfoPtr_DayTimeSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (DayTimeSpan));
      DayNightCycle.NativeFieldInfoPtr_BloodMoonBuffBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (BloodMoonBuffBonus));
      DayNightCycle.NativeFieldInfoPtr_NextBloodMoonDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (NextBloodMoonDay));
      DayNightCycle.NativeFieldInfoPtr_BloodMoonFrequency_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (BloodMoonFrequency_Min));
      DayNightCycle.NativeFieldInfoPtr_BloodMoonFrequency_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (BloodMoonFrequency_Max));
      DayNightCycle.NativeFieldInfoPtr_CastlePvPEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (CastlePvPEnabled));
      DayNightCycle.NativeFieldInfoPtr_PlayerPvPEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (PlayerPvPEnabled));
      DayNightCycle.NativeFieldInfoPtr__TimeSpanTicksSinceStart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, "<TimeSpanTicksSinceStart>k__BackingField");
      DayNightCycle.NativeFieldInfoPtr_AmbientBiome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (AmbientBiome));
      DayNightCycle.NativeFieldInfoPtr_GameDateTimeNow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, nameof (GameDateTimeNow));
      DayNightCycle.NativeMethodInfoPtr_get_TimeSinceMidnight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, 100664013);
      DayNightCycle.NativeMethodInfoPtr_get_TimeSinceDayStart_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, 100664014);
      DayNightCycle.NativeMethodInfoPtr_get_MorningMoodTransitionStart_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, 100664015);
      DayNightCycle.NativeMethodInfoPtr_get_MorningMoodTransitionEnd_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, 100664016);
      DayNightCycle.NativeMethodInfoPtr_get_MorningMoodTransitionDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, 100664017);
      DayNightCycle.NativeMethodInfoPtr_get_MorningShadowTransitionStart_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, 100664018);
      DayNightCycle.NativeMethodInfoPtr_get_MorningShadowTransitionEnd_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, 100664019);
      DayNightCycle.NativeMethodInfoPtr_get_MorningShadowTransitionDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, 100664020);
      DayNightCycle.NativeMethodInfoPtr_get_EveningMoodTransitionStart_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, 100664021);
      DayNightCycle.NativeMethodInfoPtr_get_EveningMoodTransitionEnd_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, 100664022);
      DayNightCycle.NativeMethodInfoPtr_get_EveningMoodTransitionDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, 100664023);
      DayNightCycle.NativeMethodInfoPtr_get_EveningShadowTransitionStart_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, 100664024);
      DayNightCycle.NativeMethodInfoPtr_get_EveningShadowTransitionEnd_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, 100664025);
      DayNightCycle.NativeMethodInfoPtr_get_EveningShadowTransitionDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, 100664026);
      DayNightCycle.NativeMethodInfoPtr_get_TimeOfDay_Public_get_TimeOfDay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, 100664027);
      DayNightCycle.NativeMethodInfoPtr_CalculateNextBloodMoonDay_Public_Void_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, 100664028);
      DayNightCycle.NativeMethodInfoPtr_IsBloodMoonDay_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, 100664029);
      DayNightCycle.NativeMethodInfoPtr_get_TimeSpanTicksSinceStart_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, 100664030);
      DayNightCycle.NativeMethodInfoPtr_set_TimeSpanTicksSinceStart_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, 100664031);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DayNightCycle>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
