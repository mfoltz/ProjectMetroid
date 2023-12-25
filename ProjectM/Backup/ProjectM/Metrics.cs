// Decompiled with JetBrains decompiler
// Type: ProjectM.Metrics
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Terrain;
using StunMetrics;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class Metrics : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeMetrics_Public_Static_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 979740, RefRangeEnd = 979741, XrefRangeStart = 979730, XrefRangeEnd = 979740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void InitializeMetrics()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Metrics.NativeMethodInfoPtr_InitializeMetrics_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Metrics()
    {
      Il2CppClassPointerStore<Metrics>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (Metrics));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Metrics>.NativeClassPtr);
      Metrics.NativeMethodInfoPtr_InitializeMetrics_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Metrics>.NativeClassPtr, 100675651);
    }

    public Metrics(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static class Durations : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_RawFPS;
      private static readonly System.IntPtr NativeFieldInfoPtr_RawFrameTimeMs;
      private static readonly System.IntPtr NativeFieldInfoPtr_FPSHistogram;
      private static readonly System.IntPtr NativeFieldInfoPtr_FrameTimeMsTimer;
      private static readonly System.IntPtr NativeFieldInfoPtr_IngameDay;
      private static readonly System.IntPtr NativeFieldInfoPtr_FrameCounter;
      private static readonly System.IntPtr NativeFieldInfoPtr_UptimeSeconds;
      private static readonly System.IntPtr NativeFieldInfoPtr_WorldElapsedTime;
      private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 979417, RefRangeEnd = 979418, XrefRangeStart = 979381, XrefRangeEnd = 979417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Initialize()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Metrics.Durations.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Durations()
      {
        Il2CppClassPointerStore<Metrics.Durations>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Metrics>.NativeClassPtr, nameof (Durations));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Metrics.Durations>.NativeClassPtr);
        Metrics.Durations.NativeFieldInfoPtr_RawFPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Durations>.NativeClassPtr, nameof (RawFPS));
        Metrics.Durations.NativeFieldInfoPtr_RawFrameTimeMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Durations>.NativeClassPtr, nameof (RawFrameTimeMs));
        Metrics.Durations.NativeFieldInfoPtr_FPSHistogram = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Durations>.NativeClassPtr, nameof (FPSHistogram));
        Metrics.Durations.NativeFieldInfoPtr_FrameTimeMsTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Durations>.NativeClassPtr, nameof (FrameTimeMsTimer));
        Metrics.Durations.NativeFieldInfoPtr_IngameDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Durations>.NativeClassPtr, nameof (IngameDay));
        Metrics.Durations.NativeFieldInfoPtr_FrameCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Durations>.NativeClassPtr, nameof (FrameCounter));
        Metrics.Durations.NativeFieldInfoPtr_UptimeSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Durations>.NativeClassPtr, nameof (UptimeSeconds));
        Metrics.Durations.NativeFieldInfoPtr_WorldElapsedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Durations>.NativeClassPtr, nameof (WorldElapsedTime));
        Metrics.Durations.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Metrics.Durations>.NativeClassPtr, 100675652);
      }

      public Durations(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe GaugeAPI RawFPS
      {
        get
        {
          GaugeAPI rawFps;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Durations.NativeFieldInfoPtr_RawFPS, (void*) &rawFps);
          return rawFps;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Durations.NativeFieldInfoPtr_RawFPS, (void*) &value);
        }
      }

      public static unsafe GaugeAPI RawFrameTimeMs
      {
        get
        {
          GaugeAPI rawFrameTimeMs;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Durations.NativeFieldInfoPtr_RawFrameTimeMs, (void*) &rawFrameTimeMs);
          return rawFrameTimeMs;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Durations.NativeFieldInfoPtr_RawFrameTimeMs, (void*) &value);
        }
      }

      public static unsafe HistogramAPI FPSHistogram
      {
        get
        {
          HistogramAPI fpsHistogram;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Durations.NativeFieldInfoPtr_FPSHistogram, (void*) &fpsHistogram);
          return fpsHistogram;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Durations.NativeFieldInfoPtr_FPSHistogram, (void*) &value);
        }
      }

      public static unsafe TimerAPI FrameTimeMsTimer
      {
        get
        {
          TimerAPI frameTimeMsTimer;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Durations.NativeFieldInfoPtr_FrameTimeMsTimer, (void*) &frameTimeMsTimer);
          return frameTimeMsTimer;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Durations.NativeFieldInfoPtr_FrameTimeMsTimer, (void*) &value);
        }
      }

      public static unsafe GaugeAPI IngameDay
      {
        get
        {
          GaugeAPI ingameDay;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Durations.NativeFieldInfoPtr_IngameDay, (void*) &ingameDay);
          return ingameDay;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Durations.NativeFieldInfoPtr_IngameDay, (void*) &value);
        }
      }

      public static unsafe GaugeAPI FrameCounter
      {
        get
        {
          GaugeAPI frameCounter;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Durations.NativeFieldInfoPtr_FrameCounter, (void*) &frameCounter);
          return frameCounter;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Durations.NativeFieldInfoPtr_FrameCounter, (void*) &value);
        }
      }

      public static unsafe GaugeAPI UptimeSeconds
      {
        get
        {
          GaugeAPI uptimeSeconds;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Durations.NativeFieldInfoPtr_UptimeSeconds, (void*) &uptimeSeconds);
          return uptimeSeconds;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Durations.NativeFieldInfoPtr_UptimeSeconds, (void*) &value);
        }
      }

      public static unsafe GaugeAPI WorldElapsedTime
      {
        get
        {
          GaugeAPI worldElapsedTime;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Durations.NativeFieldInfoPtr_WorldElapsedTime, (void*) &worldElapsedTime);
          return worldElapsedTime;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Durations.NativeFieldInfoPtr_WorldElapsedTime, (void*) &value);
        }
      }
    }

    public static class AIs : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EnabledCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_HighPriority;
      private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 979464, RefRangeEnd = 979465, XrefRangeStart = 979451, XrefRangeEnd = 979464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Initialize()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Metrics.AIs.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static AIs()
      {
        Il2CppClassPointerStore<Metrics.AIs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Metrics>.NativeClassPtr, nameof (AIs));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Metrics.AIs>.NativeClassPtr);
        Metrics.AIs.NativeFieldInfoPtr_EnabledCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.AIs>.NativeClassPtr, nameof (EnabledCount));
        Metrics.AIs.NativeFieldInfoPtr_HighPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.AIs>.NativeClassPtr, nameof (HighPriority));
        Metrics.AIs.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Metrics.AIs>.NativeClassPtr, 100675653);
      }

      public AIs(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe GaugeAPI EnabledCount
      {
        get
        {
          GaugeAPI enabledCount;
          IL2CPP.il2cpp_field_static_get_value(Metrics.AIs.NativeFieldInfoPtr_EnabledCount, (void*) &enabledCount);
          return enabledCount;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.AIs.NativeFieldInfoPtr_EnabledCount, (void*) &value);
        }
      }

      public static unsafe GaugeAPI HighPriority
      {
        get
        {
          GaugeAPI highPriority;
          IL2CPP.il2cpp_field_static_get_value(Metrics.AIs.NativeFieldInfoPtr_HighPriority, (void*) &highPriority);
          return highPriority;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.AIs.NativeFieldInfoPtr_HighPriority, (void*) &value);
        }
      }

      public static class Paths : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Calculated_Success;
        private static readonly System.IntPtr NativeFieldInfoPtr_Calculated_FailedNoPath;
        private static readonly System.IntPtr NativeFieldInfoPtr_Calculated_FailedTooManyExpansions;
        private static readonly System.IntPtr NativeFieldInfoPtr_TimedOut;
        private static readonly System.IntPtr NativeFieldInfoPtr_Active_Success;
        private static readonly System.IntPtr NativeFieldInfoPtr_Active_Failed;
        private static readonly System.IntPtr NativeFieldInfoPtr_Active_AwaitingPath;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 979450, RefRangeEnd = 979451, XrefRangeStart = 979418, XrefRangeEnd = 979450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Metrics.AIs.Paths.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static Paths()
        {
          Il2CppClassPointerStore<Metrics.AIs.Paths>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Metrics.AIs>.NativeClassPtr, nameof (Paths));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Metrics.AIs.Paths>.NativeClassPtr);
          Metrics.AIs.Paths.NativeFieldInfoPtr_Calculated_Success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.AIs.Paths>.NativeClassPtr, nameof (Calculated_Success));
          Metrics.AIs.Paths.NativeFieldInfoPtr_Calculated_FailedNoPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.AIs.Paths>.NativeClassPtr, nameof (Calculated_FailedNoPath));
          Metrics.AIs.Paths.NativeFieldInfoPtr_Calculated_FailedTooManyExpansions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.AIs.Paths>.NativeClassPtr, nameof (Calculated_FailedTooManyExpansions));
          Metrics.AIs.Paths.NativeFieldInfoPtr_TimedOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.AIs.Paths>.NativeClassPtr, nameof (TimedOut));
          Metrics.AIs.Paths.NativeFieldInfoPtr_Active_Success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.AIs.Paths>.NativeClassPtr, nameof (Active_Success));
          Metrics.AIs.Paths.NativeFieldInfoPtr_Active_Failed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.AIs.Paths>.NativeClassPtr, nameof (Active_Failed));
          Metrics.AIs.Paths.NativeFieldInfoPtr_Active_AwaitingPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.AIs.Paths>.NativeClassPtr, nameof (Active_AwaitingPath));
          Metrics.AIs.Paths.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Metrics.AIs.Paths>.NativeClassPtr, 100675654);
        }

        public Paths(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public static unsafe CounterAPI Calculated_Success
        {
          get
          {
            CounterAPI calculatedSuccess;
            IL2CPP.il2cpp_field_static_get_value(Metrics.AIs.Paths.NativeFieldInfoPtr_Calculated_Success, (void*) &calculatedSuccess);
            return calculatedSuccess;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Metrics.AIs.Paths.NativeFieldInfoPtr_Calculated_Success, (void*) &value);
          }
        }

        public static unsafe CounterAPI Calculated_FailedNoPath
        {
          get
          {
            CounterAPI calculatedFailedNoPath;
            IL2CPP.il2cpp_field_static_get_value(Metrics.AIs.Paths.NativeFieldInfoPtr_Calculated_FailedNoPath, (void*) &calculatedFailedNoPath);
            return calculatedFailedNoPath;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Metrics.AIs.Paths.NativeFieldInfoPtr_Calculated_FailedNoPath, (void*) &value);
          }
        }

        public static unsafe CounterAPI Calculated_FailedTooManyExpansions
        {
          get
          {
            CounterAPI tooManyExpansions;
            IL2CPP.il2cpp_field_static_get_value(Metrics.AIs.Paths.NativeFieldInfoPtr_Calculated_FailedTooManyExpansions, (void*) &tooManyExpansions);
            return tooManyExpansions;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Metrics.AIs.Paths.NativeFieldInfoPtr_Calculated_FailedTooManyExpansions, (void*) &value);
          }
        }

        public static unsafe CounterAPI TimedOut
        {
          get
          {
            CounterAPI timedOut;
            IL2CPP.il2cpp_field_static_get_value(Metrics.AIs.Paths.NativeFieldInfoPtr_TimedOut, (void*) &timedOut);
            return timedOut;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Metrics.AIs.Paths.NativeFieldInfoPtr_TimedOut, (void*) &value);
          }
        }

        public static unsafe GaugeAPI Active_Success
        {
          get
          {
            GaugeAPI activeSuccess;
            IL2CPP.il2cpp_field_static_get_value(Metrics.AIs.Paths.NativeFieldInfoPtr_Active_Success, (void*) &activeSuccess);
            return activeSuccess;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Metrics.AIs.Paths.NativeFieldInfoPtr_Active_Success, (void*) &value);
          }
        }

        public static unsafe GaugeAPI Active_Failed
        {
          get
          {
            GaugeAPI activeFailed;
            IL2CPP.il2cpp_field_static_get_value(Metrics.AIs.Paths.NativeFieldInfoPtr_Active_Failed, (void*) &activeFailed);
            return activeFailed;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Metrics.AIs.Paths.NativeFieldInfoPtr_Active_Failed, (void*) &value);
          }
        }

        public static unsafe GaugeAPI Active_AwaitingPath
        {
          get
          {
            GaugeAPI activeAwaitingPath;
            IL2CPP.il2cpp_field_static_get_value(Metrics.AIs.Paths.NativeFieldInfoPtr_Active_AwaitingPath, (void*) &activeAwaitingPath);
            return activeAwaitingPath;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Metrics.AIs.Paths.NativeFieldInfoPtr_Active_AwaitingPath, (void*) &value);
          }
        }
      }
    }

    public static class ECS : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntitiesEnabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntitiesDisabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntitiesNetworked;
      private static readonly System.IntPtr NativeFieldInfoPtr_Archetypes;
      private static readonly System.IntPtr NativeFieldInfoPtr_ActiveArchetypes;
      private static readonly System.IntPtr NativeFieldInfoPtr_ArchetypeChunks;
      private static readonly System.IntPtr NativeFieldInfoPtr_ArchetypeChunksWasted;
      private static readonly System.IntPtr NativeFieldInfoPtr_ArchetypeChunksWithShared;
      private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 979501, RefRangeEnd = 979502, XrefRangeStart = 979465, XrefRangeEnd = 979501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Initialize()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Metrics.ECS.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ECS()
      {
        Il2CppClassPointerStore<Metrics.ECS>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Metrics>.NativeClassPtr, nameof (ECS));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Metrics.ECS>.NativeClassPtr);
        Metrics.ECS.NativeFieldInfoPtr_EntitiesEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.ECS>.NativeClassPtr, nameof (EntitiesEnabled));
        Metrics.ECS.NativeFieldInfoPtr_EntitiesDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.ECS>.NativeClassPtr, nameof (EntitiesDisabled));
        Metrics.ECS.NativeFieldInfoPtr_EntitiesNetworked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.ECS>.NativeClassPtr, nameof (EntitiesNetworked));
        Metrics.ECS.NativeFieldInfoPtr_Archetypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.ECS>.NativeClassPtr, nameof (Archetypes));
        Metrics.ECS.NativeFieldInfoPtr_ActiveArchetypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.ECS>.NativeClassPtr, nameof (ActiveArchetypes));
        Metrics.ECS.NativeFieldInfoPtr_ArchetypeChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.ECS>.NativeClassPtr, nameof (ArchetypeChunks));
        Metrics.ECS.NativeFieldInfoPtr_ArchetypeChunksWasted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.ECS>.NativeClassPtr, nameof (ArchetypeChunksWasted));
        Metrics.ECS.NativeFieldInfoPtr_ArchetypeChunksWithShared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.ECS>.NativeClassPtr, nameof (ArchetypeChunksWithShared));
        Metrics.ECS.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Metrics.ECS>.NativeClassPtr, 100675655);
      }

      public ECS(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe GaugeAPI EntitiesEnabled
      {
        get
        {
          GaugeAPI entitiesEnabled;
          IL2CPP.il2cpp_field_static_get_value(Metrics.ECS.NativeFieldInfoPtr_EntitiesEnabled, (void*) &entitiesEnabled);
          return entitiesEnabled;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.ECS.NativeFieldInfoPtr_EntitiesEnabled, (void*) &value);
        }
      }

      public static unsafe GaugeAPI EntitiesDisabled
      {
        get
        {
          GaugeAPI entitiesDisabled;
          IL2CPP.il2cpp_field_static_get_value(Metrics.ECS.NativeFieldInfoPtr_EntitiesDisabled, (void*) &entitiesDisabled);
          return entitiesDisabled;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.ECS.NativeFieldInfoPtr_EntitiesDisabled, (void*) &value);
        }
      }

      public static unsafe GaugeAPI EntitiesNetworked
      {
        get
        {
          GaugeAPI entitiesNetworked;
          IL2CPP.il2cpp_field_static_get_value(Metrics.ECS.NativeFieldInfoPtr_EntitiesNetworked, (void*) &entitiesNetworked);
          return entitiesNetworked;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.ECS.NativeFieldInfoPtr_EntitiesNetworked, (void*) &value);
        }
      }

      public static unsafe GaugeAPI Archetypes
      {
        get
        {
          GaugeAPI archetypes;
          IL2CPP.il2cpp_field_static_get_value(Metrics.ECS.NativeFieldInfoPtr_Archetypes, (void*) &archetypes);
          return archetypes;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.ECS.NativeFieldInfoPtr_Archetypes, (void*) &value);
        }
      }

      public static unsafe GaugeAPI ActiveArchetypes
      {
        get
        {
          GaugeAPI activeArchetypes;
          IL2CPP.il2cpp_field_static_get_value(Metrics.ECS.NativeFieldInfoPtr_ActiveArchetypes, (void*) &activeArchetypes);
          return activeArchetypes;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.ECS.NativeFieldInfoPtr_ActiveArchetypes, (void*) &value);
        }
      }

      public static unsafe GaugeAPI ArchetypeChunks
      {
        get
        {
          GaugeAPI archetypeChunks;
          IL2CPP.il2cpp_field_static_get_value(Metrics.ECS.NativeFieldInfoPtr_ArchetypeChunks, (void*) &archetypeChunks);
          return archetypeChunks;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.ECS.NativeFieldInfoPtr_ArchetypeChunks, (void*) &value);
        }
      }

      public static unsafe GaugeAPI ArchetypeChunksWasted
      {
        get
        {
          GaugeAPI archetypeChunksWasted;
          IL2CPP.il2cpp_field_static_get_value(Metrics.ECS.NativeFieldInfoPtr_ArchetypeChunksWasted, (void*) &archetypeChunksWasted);
          return archetypeChunksWasted;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.ECS.NativeFieldInfoPtr_ArchetypeChunksWasted, (void*) &value);
        }
      }

      public static unsafe GaugeAPI ArchetypeChunksWithShared
      {
        get
        {
          GaugeAPI chunksWithShared;
          IL2CPP.il2cpp_field_static_get_value(Metrics.ECS.NativeFieldInfoPtr_ArchetypeChunksWithShared, (void*) &chunksWithShared);
          return chunksWithShared;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.ECS.NativeFieldInfoPtr_ArchetypeChunksWithShared, (void*) &value);
        }
      }
    }

    public static class SystemStats : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TempAllocatorSize;
      private static readonly System.IntPtr NativeFieldInfoPtr_MonoHeapSize;
      private static readonly System.IntPtr NativeFieldInfoPtr_MonoUsedSize;
      private static readonly System.IntPtr NativeFieldInfoPtr_TotalAllocatedMemory;
      private static readonly System.IntPtr NativeFieldInfoPtr_TotalReservedMemory;
      private static readonly System.IntPtr NativeFieldInfoPtr_TotalUnusedReservedMemory;
      private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 979530, RefRangeEnd = 979531, XrefRangeStart = 979502, XrefRangeEnd = 979530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Initialize()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Metrics.SystemStats.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SystemStats()
      {
        Il2CppClassPointerStore<Metrics.SystemStats>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Metrics>.NativeClassPtr, nameof (SystemStats));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Metrics.SystemStats>.NativeClassPtr);
        Metrics.SystemStats.NativeFieldInfoPtr_TempAllocatorSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.SystemStats>.NativeClassPtr, nameof (TempAllocatorSize));
        Metrics.SystemStats.NativeFieldInfoPtr_MonoHeapSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.SystemStats>.NativeClassPtr, nameof (MonoHeapSize));
        Metrics.SystemStats.NativeFieldInfoPtr_MonoUsedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.SystemStats>.NativeClassPtr, nameof (MonoUsedSize));
        Metrics.SystemStats.NativeFieldInfoPtr_TotalAllocatedMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.SystemStats>.NativeClassPtr, nameof (TotalAllocatedMemory));
        Metrics.SystemStats.NativeFieldInfoPtr_TotalReservedMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.SystemStats>.NativeClassPtr, nameof (TotalReservedMemory));
        Metrics.SystemStats.NativeFieldInfoPtr_TotalUnusedReservedMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.SystemStats>.NativeClassPtr, nameof (TotalUnusedReservedMemory));
        Metrics.SystemStats.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Metrics.SystemStats>.NativeClassPtr, 100675656);
      }

      public SystemStats(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe GaugeAPI TempAllocatorSize
      {
        get
        {
          GaugeAPI tempAllocatorSize;
          IL2CPP.il2cpp_field_static_get_value(Metrics.SystemStats.NativeFieldInfoPtr_TempAllocatorSize, (void*) &tempAllocatorSize);
          return tempAllocatorSize;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.SystemStats.NativeFieldInfoPtr_TempAllocatorSize, (void*) &value);
        }
      }

      public static unsafe GaugeAPI MonoHeapSize
      {
        get
        {
          GaugeAPI monoHeapSize;
          IL2CPP.il2cpp_field_static_get_value(Metrics.SystemStats.NativeFieldInfoPtr_MonoHeapSize, (void*) &monoHeapSize);
          return monoHeapSize;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.SystemStats.NativeFieldInfoPtr_MonoHeapSize, (void*) &value);
        }
      }

      public static unsafe GaugeAPI MonoUsedSize
      {
        get
        {
          GaugeAPI monoUsedSize;
          IL2CPP.il2cpp_field_static_get_value(Metrics.SystemStats.NativeFieldInfoPtr_MonoUsedSize, (void*) &monoUsedSize);
          return monoUsedSize;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.SystemStats.NativeFieldInfoPtr_MonoUsedSize, (void*) &value);
        }
      }

      public static unsafe GaugeAPI TotalAllocatedMemory
      {
        get
        {
          GaugeAPI totalAllocatedMemory;
          IL2CPP.il2cpp_field_static_get_value(Metrics.SystemStats.NativeFieldInfoPtr_TotalAllocatedMemory, (void*) &totalAllocatedMemory);
          return totalAllocatedMemory;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.SystemStats.NativeFieldInfoPtr_TotalAllocatedMemory, (void*) &value);
        }
      }

      public static unsafe GaugeAPI TotalReservedMemory
      {
        get
        {
          GaugeAPI totalReservedMemory;
          IL2CPP.il2cpp_field_static_get_value(Metrics.SystemStats.NativeFieldInfoPtr_TotalReservedMemory, (void*) &totalReservedMemory);
          return totalReservedMemory;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.SystemStats.NativeFieldInfoPtr_TotalReservedMemory, (void*) &value);
        }
      }

      public static unsafe GaugeAPI TotalUnusedReservedMemory
      {
        get
        {
          GaugeAPI unusedReservedMemory;
          IL2CPP.il2cpp_field_static_get_value(Metrics.SystemStats.NativeFieldInfoPtr_TotalUnusedReservedMemory, (void*) &unusedReservedMemory);
          return unusedReservedMemory;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.SystemStats.NativeFieldInfoPtr_TotalUnusedReservedMemory, (void*) &value);
        }
      }
    }

    public static class Users : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Connected;
      private static readonly System.IntPtr NativeFieldInfoPtr_ConnectedMax;
      private static readonly System.IntPtr NativeFieldInfoPtr_Taken;
      private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 979547, RefRangeEnd = 979548, XrefRangeStart = 979531, XrefRangeEnd = 979547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Initialize()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Metrics.Users.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Users()
      {
        Il2CppClassPointerStore<Metrics.Users>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Metrics>.NativeClassPtr, nameof (Users));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Metrics.Users>.NativeClassPtr);
        Metrics.Users.NativeFieldInfoPtr_Connected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Users>.NativeClassPtr, nameof (Connected));
        Metrics.Users.NativeFieldInfoPtr_ConnectedMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Users>.NativeClassPtr, nameof (ConnectedMax));
        Metrics.Users.NativeFieldInfoPtr_Taken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Users>.NativeClassPtr, nameof (Taken));
        Metrics.Users.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Metrics.Users>.NativeClassPtr, 100675657);
      }

      public Users(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe GaugeAPI Connected
      {
        get
        {
          GaugeAPI connected;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Users.NativeFieldInfoPtr_Connected, (void*) &connected);
          return connected;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Users.NativeFieldInfoPtr_Connected, (void*) &value);
        }
      }

      public static unsafe GaugeAPI ConnectedMax
      {
        get
        {
          GaugeAPI connectedMax;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Users.NativeFieldInfoPtr_ConnectedMax, (void*) &connectedMax);
          return connectedMax;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Users.NativeFieldInfoPtr_ConnectedMax, (void*) &value);
        }
      }

      public static unsafe GaugeAPI Taken
      {
        get
        {
          GaugeAPI taken;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Users.NativeFieldInfoPtr_Taken, (void*) &taken);
          return taken;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Users.NativeFieldInfoPtr_Taken, (void*) &value);
        }
      }
    }

    public static class ServerActivity : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ActiveUsersScore;
      private static readonly System.IntPtr NativeFieldInfoPtr_UsersInStartCave;
      private static readonly System.IntPtr NativeFieldInfoPtr_FreeTerritoriesPerRegion;
      private static readonly System.IntPtr NativeFieldInfoPtr_UsedTerritoriesPerRegion;
      private static readonly System.IntPtr NativeFieldInfoPtr_UsersPerRegion;
      private static readonly System.IntPtr NativeFieldInfoPtr_ActiveUsersPerRegion;
      private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 979641, RefRangeEnd = 979642, XrefRangeStart = 979548, XrefRangeEnd = 979641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Initialize()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Metrics.ServerActivity.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ServerActivity()
      {
        Il2CppClassPointerStore<Metrics.ServerActivity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Metrics>.NativeClassPtr, nameof (ServerActivity));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Metrics.ServerActivity>.NativeClassPtr);
        Metrics.ServerActivity.NativeFieldInfoPtr_ActiveUsersScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.ServerActivity>.NativeClassPtr, nameof (ActiveUsersScore));
        Metrics.ServerActivity.NativeFieldInfoPtr_UsersInStartCave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.ServerActivity>.NativeClassPtr, nameof (UsersInStartCave));
        Metrics.ServerActivity.NativeFieldInfoPtr_FreeTerritoriesPerRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.ServerActivity>.NativeClassPtr, nameof (FreeTerritoriesPerRegion));
        Metrics.ServerActivity.NativeFieldInfoPtr_UsedTerritoriesPerRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.ServerActivity>.NativeClassPtr, nameof (UsedTerritoriesPerRegion));
        Metrics.ServerActivity.NativeFieldInfoPtr_UsersPerRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.ServerActivity>.NativeClassPtr, nameof (UsersPerRegion));
        Metrics.ServerActivity.NativeFieldInfoPtr_ActiveUsersPerRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.ServerActivity>.NativeClassPtr, nameof (ActiveUsersPerRegion));
        Metrics.ServerActivity.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Metrics.ServerActivity>.NativeClassPtr, 100675658);
      }

      public ServerActivity(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe GaugeAPI ActiveUsersScore
      {
        get
        {
          GaugeAPI activeUsersScore;
          IL2CPP.il2cpp_field_static_get_value(Metrics.ServerActivity.NativeFieldInfoPtr_ActiveUsersScore, (void*) &activeUsersScore);
          return activeUsersScore;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.ServerActivity.NativeFieldInfoPtr_ActiveUsersScore, (void*) &value);
        }
      }

      public static unsafe GaugeAPI UsersInStartCave
      {
        get
        {
          GaugeAPI usersInStartCave;
          IL2CPP.il2cpp_field_static_get_value(Metrics.ServerActivity.NativeFieldInfoPtr_UsersInStartCave, (void*) &usersInStartCave);
          return usersInStartCave;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.ServerActivity.NativeFieldInfoPtr_UsersInStartCave, (void*) &value);
        }
      }

      public static unsafe Dictionary<WorldRegionType, GaugeAPI> FreeTerritoriesPerRegion
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Metrics.ServerActivity.NativeFieldInfoPtr_FreeTerritoriesPerRegion, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Dictionary<WorldRegionType, GaugeAPI>) null : new Dictionary<WorldRegionType, GaugeAPI>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.ServerActivity.NativeFieldInfoPtr_FreeTerritoriesPerRegion, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Dictionary<WorldRegionType, GaugeAPI> UsedTerritoriesPerRegion
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Metrics.ServerActivity.NativeFieldInfoPtr_UsedTerritoriesPerRegion, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Dictionary<WorldRegionType, GaugeAPI>) null : new Dictionary<WorldRegionType, GaugeAPI>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.ServerActivity.NativeFieldInfoPtr_UsedTerritoriesPerRegion, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Dictionary<WorldRegionType, GaugeAPI> UsersPerRegion
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Metrics.ServerActivity.NativeFieldInfoPtr_UsersPerRegion, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Dictionary<WorldRegionType, GaugeAPI>) null : new Dictionary<WorldRegionType, GaugeAPI>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.ServerActivity.NativeFieldInfoPtr_UsersPerRegion, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Dictionary<WorldRegionType, GaugeAPI> ActiveUsersPerRegion
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Metrics.ServerActivity.NativeFieldInfoPtr_ActiveUsersPerRegion, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Dictionary<WorldRegionType, GaugeAPI>) null : new Dictionary<WorldRegionType, GaugeAPI>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.ServerActivity.NativeFieldInfoPtr_ActiveUsersPerRegion, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public static class ServerSettings : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_GameMode;
      private static readonly System.IntPtr NativeFieldInfoPtr_ClanSize;
      private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 979654, RefRangeEnd = 979655, XrefRangeStart = 979642, XrefRangeEnd = 979654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Initialize()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Metrics.ServerSettings.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ServerSettings()
      {
        Il2CppClassPointerStore<Metrics.ServerSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Metrics>.NativeClassPtr, nameof (ServerSettings));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Metrics.ServerSettings>.NativeClassPtr);
        Metrics.ServerSettings.NativeFieldInfoPtr_GameMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.ServerSettings>.NativeClassPtr, nameof (GameMode));
        Metrics.ServerSettings.NativeFieldInfoPtr_ClanSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.ServerSettings>.NativeClassPtr, nameof (ClanSize));
        Metrics.ServerSettings.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Metrics.ServerSettings>.NativeClassPtr, 100675659);
      }

      public ServerSettings(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe GaugeAPI GameMode
      {
        get
        {
          GaugeAPI gameMode;
          IL2CPP.il2cpp_field_static_get_value(Metrics.ServerSettings.NativeFieldInfoPtr_GameMode, (void*) &gameMode);
          return gameMode;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.ServerSettings.NativeFieldInfoPtr_GameMode, (void*) &value);
        }
      }

      public static unsafe GaugeAPI ClanSize
      {
        get
        {
          GaugeAPI clanSize;
          IL2CPP.il2cpp_field_static_get_value(Metrics.ServerSettings.NativeFieldInfoPtr_ClanSize, (void*) &clanSize);
          return clanSize;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.ServerSettings.NativeFieldInfoPtr_ClanSize, (void*) &value);
        }
      }
    }

    public static class Network : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkStatsTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_BytesSentPerSecond;
      private static readonly System.IntPtr NativeFieldInfoPtr_BytesReceivedPerSecond;
      private static readonly System.IntPtr NativeFieldInfoPtr_MessagesMaxBytesSentPerSecond;
      private static readonly System.IntPtr NativeFieldInfoPtr_MessagesMaxBytesReceivedPerSecond;
      private static readonly System.IntPtr NativeFieldInfoPtr_MessagesSentPerSecond;
      private static readonly System.IntPtr NativeFieldInfoPtr_MessagesReceivedPerSecond;
      private static readonly System.IntPtr NativeFieldInfoPtr_PacketsSentPerSecond;
      private static readonly System.IntPtr NativeFieldInfoPtr_PacketsReceivedPerSecond;
      private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 979695, RefRangeEnd = 979696, XrefRangeStart = 979655, XrefRangeEnd = 979695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Initialize()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Metrics.Network.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Network()
      {
        Il2CppClassPointerStore<Metrics.Network>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Metrics>.NativeClassPtr, nameof (Network));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Metrics.Network>.NativeClassPtr);
        Metrics.Network.NativeFieldInfoPtr_NetworkStatsTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Network>.NativeClassPtr, nameof (NetworkStatsTime));
        Metrics.Network.NativeFieldInfoPtr_BytesSentPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Network>.NativeClassPtr, nameof (BytesSentPerSecond));
        Metrics.Network.NativeFieldInfoPtr_BytesReceivedPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Network>.NativeClassPtr, nameof (BytesReceivedPerSecond));
        Metrics.Network.NativeFieldInfoPtr_MessagesMaxBytesSentPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Network>.NativeClassPtr, nameof (MessagesMaxBytesSentPerSecond));
        Metrics.Network.NativeFieldInfoPtr_MessagesMaxBytesReceivedPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Network>.NativeClassPtr, nameof (MessagesMaxBytesReceivedPerSecond));
        Metrics.Network.NativeFieldInfoPtr_MessagesSentPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Network>.NativeClassPtr, nameof (MessagesSentPerSecond));
        Metrics.Network.NativeFieldInfoPtr_MessagesReceivedPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Network>.NativeClassPtr, nameof (MessagesReceivedPerSecond));
        Metrics.Network.NativeFieldInfoPtr_PacketsSentPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Network>.NativeClassPtr, nameof (PacketsSentPerSecond));
        Metrics.Network.NativeFieldInfoPtr_PacketsReceivedPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Network>.NativeClassPtr, nameof (PacketsReceivedPerSecond));
        Metrics.Network.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Metrics.Network>.NativeClassPtr, 100675660);
      }

      public Network(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe GaugeAPI NetworkStatsTime
      {
        get
        {
          GaugeAPI networkStatsTime;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Network.NativeFieldInfoPtr_NetworkStatsTime, (void*) &networkStatsTime);
          return networkStatsTime;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Network.NativeFieldInfoPtr_NetworkStatsTime, (void*) &value);
        }
      }

      public static unsafe GaugeAPI BytesSentPerSecond
      {
        get
        {
          GaugeAPI bytesSentPerSecond;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Network.NativeFieldInfoPtr_BytesSentPerSecond, (void*) &bytesSentPerSecond);
          return bytesSentPerSecond;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Network.NativeFieldInfoPtr_BytesSentPerSecond, (void*) &value);
        }
      }

      public static unsafe GaugeAPI BytesReceivedPerSecond
      {
        get
        {
          GaugeAPI receivedPerSecond;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Network.NativeFieldInfoPtr_BytesReceivedPerSecond, (void*) &receivedPerSecond);
          return receivedPerSecond;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Network.NativeFieldInfoPtr_BytesReceivedPerSecond, (void*) &value);
        }
      }

      public static unsafe GaugeAPI MessagesMaxBytesSentPerSecond
      {
        get
        {
          GaugeAPI bytesSentPerSecond;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Network.NativeFieldInfoPtr_MessagesMaxBytesSentPerSecond, (void*) &bytesSentPerSecond);
          return bytesSentPerSecond;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Network.NativeFieldInfoPtr_MessagesMaxBytesSentPerSecond, (void*) &value);
        }
      }

      public static unsafe GaugeAPI MessagesMaxBytesReceivedPerSecond
      {
        get
        {
          GaugeAPI receivedPerSecond;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Network.NativeFieldInfoPtr_MessagesMaxBytesReceivedPerSecond, (void*) &receivedPerSecond);
          return receivedPerSecond;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Network.NativeFieldInfoPtr_MessagesMaxBytesReceivedPerSecond, (void*) &value);
        }
      }

      public static unsafe GaugeAPI MessagesSentPerSecond
      {
        get
        {
          GaugeAPI messagesSentPerSecond;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Network.NativeFieldInfoPtr_MessagesSentPerSecond, (void*) &messagesSentPerSecond);
          return messagesSentPerSecond;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Network.NativeFieldInfoPtr_MessagesSentPerSecond, (void*) &value);
        }
      }

      public static unsafe GaugeAPI MessagesReceivedPerSecond
      {
        get
        {
          GaugeAPI receivedPerSecond;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Network.NativeFieldInfoPtr_MessagesReceivedPerSecond, (void*) &receivedPerSecond);
          return receivedPerSecond;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Network.NativeFieldInfoPtr_MessagesReceivedPerSecond, (void*) &value);
        }
      }

      public static unsafe GaugeAPI PacketsSentPerSecond
      {
        get
        {
          GaugeAPI packetsSentPerSecond;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Network.NativeFieldInfoPtr_PacketsSentPerSecond, (void*) &packetsSentPerSecond);
          return packetsSentPerSecond;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Network.NativeFieldInfoPtr_PacketsSentPerSecond, (void*) &value);
        }
      }

      public static unsafe GaugeAPI PacketsReceivedPerSecond
      {
        get
        {
          GaugeAPI receivedPerSecond;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Network.NativeFieldInfoPtr_PacketsReceivedPerSecond, (void*) &receivedPerSecond);
          return receivedPerSecond;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Network.NativeFieldInfoPtr_PacketsReceivedPerSecond, (void*) &value);
        }
      }
    }

    public static class Logs : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Debugs;
      private static readonly System.IntPtr NativeFieldInfoPtr_Warnings;
      private static readonly System.IntPtr NativeFieldInfoPtr_Errors;
      private static readonly System.IntPtr NativeFieldInfoPtr_Exceptions;
      private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 979716, RefRangeEnd = 979717, XrefRangeStart = 979696, XrefRangeEnd = 979716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Initialize()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Metrics.Logs.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Logs()
      {
        Il2CppClassPointerStore<Metrics.Logs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Metrics>.NativeClassPtr, nameof (Logs));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Metrics.Logs>.NativeClassPtr);
        Metrics.Logs.NativeFieldInfoPtr_Debugs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Logs>.NativeClassPtr, nameof (Debugs));
        Metrics.Logs.NativeFieldInfoPtr_Warnings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Logs>.NativeClassPtr, nameof (Warnings));
        Metrics.Logs.NativeFieldInfoPtr_Errors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Logs>.NativeClassPtr, nameof (Errors));
        Metrics.Logs.NativeFieldInfoPtr_Exceptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Logs>.NativeClassPtr, nameof (Exceptions));
        Metrics.Logs.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Metrics.Logs>.NativeClassPtr, 100675661);
      }

      public Logs(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe GaugeAPI Debugs
      {
        get
        {
          GaugeAPI debugs;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Logs.NativeFieldInfoPtr_Debugs, (void*) &debugs);
          return debugs;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Logs.NativeFieldInfoPtr_Debugs, (void*) &value);
        }
      }

      public static unsafe GaugeAPI Warnings
      {
        get
        {
          GaugeAPI warnings;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Logs.NativeFieldInfoPtr_Warnings, (void*) &warnings);
          return warnings;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Logs.NativeFieldInfoPtr_Warnings, (void*) &value);
        }
      }

      public static unsafe GaugeAPI Errors
      {
        get
        {
          GaugeAPI errors;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Logs.NativeFieldInfoPtr_Errors, (void*) &errors);
          return errors;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Logs.NativeFieldInfoPtr_Errors, (void*) &value);
        }
      }

      public static unsafe GaugeAPI Exceptions
      {
        get
        {
          GaugeAPI exceptions;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Logs.NativeFieldInfoPtr_Exceptions, (void*) &exceptions);
          return exceptions;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Logs.NativeFieldInfoPtr_Exceptions, (void*) &value);
        }
      }
    }

    public static class Cleanups : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DuplicateEquipmentBuffsRemoved;
      private static readonly System.IntPtr NativeFieldInfoPtr_BrokenItemsRemoved;
      private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 979729, RefRangeEnd = 979730, XrefRangeStart = 979717, XrefRangeEnd = 979729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Initialize()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Metrics.Cleanups.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Cleanups()
      {
        Il2CppClassPointerStore<Metrics.Cleanups>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Metrics>.NativeClassPtr, nameof (Cleanups));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Metrics.Cleanups>.NativeClassPtr);
        Metrics.Cleanups.NativeFieldInfoPtr_DuplicateEquipmentBuffsRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Cleanups>.NativeClassPtr, nameof (DuplicateEquipmentBuffsRemoved));
        Metrics.Cleanups.NativeFieldInfoPtr_BrokenItemsRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Metrics.Cleanups>.NativeClassPtr, nameof (BrokenItemsRemoved));
        Metrics.Cleanups.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Metrics.Cleanups>.NativeClassPtr, 100675662);
      }

      public Cleanups(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe GaugeAPI DuplicateEquipmentBuffsRemoved
      {
        get
        {
          GaugeAPI equipmentBuffsRemoved;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Cleanups.NativeFieldInfoPtr_DuplicateEquipmentBuffsRemoved, (void*) &equipmentBuffsRemoved);
          return equipmentBuffsRemoved;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Cleanups.NativeFieldInfoPtr_DuplicateEquipmentBuffsRemoved, (void*) &value);
        }
      }

      public static unsafe GaugeAPI BrokenItemsRemoved
      {
        get
        {
          GaugeAPI brokenItemsRemoved;
          IL2CPP.il2cpp_field_static_get_value(Metrics.Cleanups.NativeFieldInfoPtr_BrokenItemsRemoved, (void*) &brokenItemsRemoved);
          return brokenItemsRemoved;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Metrics.Cleanups.NativeFieldInfoPtr_BrokenItemsRemoved, (void*) &value);
        }
      }
    }
  }
}
