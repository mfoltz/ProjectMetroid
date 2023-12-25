// Decompiled with JetBrains decompiler
// Type: ProjectM.PerformanceLoggerSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Diagnostics;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  public class PerformanceLoggerSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__FrameTimeArray;
    private static readonly IntPtr NativeFieldInfoPtr__ClientFpsArray;
    private static readonly IntPtr NativeFieldInfoPtr__ServerFpsArray;
    private static readonly IntPtr NativeFieldInfoPtr__NetworkLatencyArray;
    private static readonly IntPtr NativeFieldInfoPtr__NetworkBytesSentPerSecondArray;
    private static readonly IntPtr NativeFieldInfoPtr__NetworkBytesReceivedPerSecondArray;
    private static readonly IntPtr NativeFieldInfoPtr__NetworkPacketsSentPerSecondArray;
    private static readonly IntPtr NativeFieldInfoPtr__NetworkPacketsReceivedPerSecondArray;
    private static readonly IntPtr NativeFieldInfoPtr__NetworkMessagesSentPerSecondArray;
    private static readonly IntPtr NativeFieldInfoPtr__NetworkMessagesReceivedPerSecondArray;
    private static readonly IntPtr NativeFieldInfoPtr__NetworkMessagesMaxBytesSentPerSecondArray;
    private static readonly IntPtr NativeFieldInfoPtr__NetworkMessagesMaxBytesReceivedPerSecondArray;
    private static readonly IntPtr NativeFieldInfoPtr__SoundCpuUsageArray;
    private static readonly IntPtr NativeFieldInfoPtr__SoundMemoryUsageArray;
    private static readonly IntPtr NativeFieldInfoPtr__ActiveHybridModelCountArray;
    private static readonly IntPtr NativeFieldInfoPtr__PositionArray;
    private static readonly IntPtr NativeFieldInfoPtr__WorldFrame;
    private static readonly IntPtr NativeFieldInfoPtr_MB;
    private static readonly IntPtr NativeFieldInfoPtr__LastLogTime;
    private static readonly IntPtr NativeFieldInfoPtr__NextSnapshotIndex;
    private static readonly IntPtr NativeFieldInfoPtr__FpsCounter;
    private static readonly IntPtr NativeFieldInfoPtr__NextFpsTime;
    private static readonly IntPtr NativeFieldInfoPtr__Fps;
    private static readonly IntPtr NativeFieldInfoPtr__SummaryBufferEntity;
    private static readonly IntPtr NativeFieldInfoPtr__ClientBootstrapSystem;
    private static readonly IntPtr NativeFieldInfoPtr__Stopwatch;
    private static readonly IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_8;
    private static readonly IntPtr NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_9;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetArchetypeCount_Private_Int32_World_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetCurrentControlledPosition_Private_float2_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetHourOfDay_Private_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410744, XrefRangeEnd = 1410799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PerformanceLoggerSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410799, XrefRangeEnd = 1410837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PerformanceLoggerSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410837, XrefRangeEnd = 1410970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PerformanceLoggerSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410970, XrefRangeEnd = 1410981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetArchetypeCount(World world)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PerformanceLoggerSystem.NativeMethodInfoPtr_GetArchetypeCount_Private_Int32_World_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410981, XrefRangeEnd = 1410989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float2 GetCurrentControlledPosition()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PerformanceLoggerSystem.NativeMethodInfoPtr_GetCurrentControlledPosition_Private_float2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410989, XrefRangeEnd = 1410999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetHourOfDay()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(PerformanceLoggerSystem.NativeMethodInfoPtr_GetHourOfDay_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PerformanceLoggerSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PerformanceLoggerSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410999, XrefRangeEnd = 1411013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PerformanceLoggerSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PerformanceLoggerSystem()
    {
      Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (PerformanceLoggerSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr);
      PerformanceLoggerSystem.NativeFieldInfoPtr__FrameTimeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_FrameTimeArray));
      PerformanceLoggerSystem.NativeFieldInfoPtr__ClientFpsArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_ClientFpsArray));
      PerformanceLoggerSystem.NativeFieldInfoPtr__ServerFpsArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_ServerFpsArray));
      PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkLatencyArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_NetworkLatencyArray));
      PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkBytesSentPerSecondArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_NetworkBytesSentPerSecondArray));
      PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkBytesReceivedPerSecondArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_NetworkBytesReceivedPerSecondArray));
      PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkPacketsSentPerSecondArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_NetworkPacketsSentPerSecondArray));
      PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkPacketsReceivedPerSecondArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_NetworkPacketsReceivedPerSecondArray));
      PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkMessagesSentPerSecondArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_NetworkMessagesSentPerSecondArray));
      PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkMessagesReceivedPerSecondArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_NetworkMessagesReceivedPerSecondArray));
      PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkMessagesMaxBytesSentPerSecondArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_NetworkMessagesMaxBytesSentPerSecondArray));
      PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkMessagesMaxBytesReceivedPerSecondArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_NetworkMessagesMaxBytesReceivedPerSecondArray));
      PerformanceLoggerSystem.NativeFieldInfoPtr__SoundCpuUsageArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_SoundCpuUsageArray));
      PerformanceLoggerSystem.NativeFieldInfoPtr__SoundMemoryUsageArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_SoundMemoryUsageArray));
      PerformanceLoggerSystem.NativeFieldInfoPtr__ActiveHybridModelCountArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_ActiveHybridModelCountArray));
      PerformanceLoggerSystem.NativeFieldInfoPtr__PositionArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_PositionArray));
      PerformanceLoggerSystem.NativeFieldInfoPtr__WorldFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_WorldFrame));
      PerformanceLoggerSystem.NativeFieldInfoPtr_MB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (MB));
      PerformanceLoggerSystem.NativeFieldInfoPtr__LastLogTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_LastLogTime));
      PerformanceLoggerSystem.NativeFieldInfoPtr__NextSnapshotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_NextSnapshotIndex));
      PerformanceLoggerSystem.NativeFieldInfoPtr__FpsCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_FpsCounter));
      PerformanceLoggerSystem.NativeFieldInfoPtr__NextFpsTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_NextFpsTime));
      PerformanceLoggerSystem.NativeFieldInfoPtr__Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_Fps));
      PerformanceLoggerSystem.NativeFieldInfoPtr__SummaryBufferEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_SummaryBufferEntity));
      PerformanceLoggerSystem.NativeFieldInfoPtr__ClientBootstrapSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_ClientBootstrapSystem));
      PerformanceLoggerSystem.NativeFieldInfoPtr__Stopwatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_Stopwatch));
      PerformanceLoggerSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_LocalControlled_8));
      PerformanceLoggerSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_DayNightCycle_9));
      PerformanceLoggerSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, 100668643);
      PerformanceLoggerSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, 100668644);
      PerformanceLoggerSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, 100668645);
      PerformanceLoggerSystem.NativeMethodInfoPtr_GetArchetypeCount_Private_Int32_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, 100668646);
      PerformanceLoggerSystem.NativeMethodInfoPtr_GetCurrentControlledPosition_Private_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, 100668647);
      PerformanceLoggerSystem.NativeMethodInfoPtr_GetHourOfDay_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, 100668648);
      PerformanceLoggerSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, 100668649);
      PerformanceLoggerSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceLoggerSystem>.NativeClassPtr, 100668650);
    }

    public PerformanceLoggerSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeArray<float> _FrameTimeArray
    {
      get
      {
        return *(NativeArray<float>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__FrameTimeArray));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__FrameTimeArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe NativeArray<int> _ClientFpsArray
    {
      get
      {
        return *(NativeArray<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__ClientFpsArray));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__ClientFpsArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe NativeArray<int> _ServerFpsArray
    {
      get
      {
        return *(NativeArray<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__ServerFpsArray));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__ServerFpsArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe NativeArray<int> _NetworkLatencyArray
    {
      get
      {
        return *(NativeArray<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkLatencyArray));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkLatencyArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe NativeArray<int> _NetworkBytesSentPerSecondArray
    {
      get
      {
        return *(NativeArray<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkBytesSentPerSecondArray));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkBytesSentPerSecondArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe NativeArray<int> _NetworkBytesReceivedPerSecondArray
    {
      get
      {
        return *(NativeArray<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkBytesReceivedPerSecondArray));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkBytesReceivedPerSecondArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe NativeArray<int> _NetworkPacketsSentPerSecondArray
    {
      get
      {
        return *(NativeArray<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkPacketsSentPerSecondArray));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkPacketsSentPerSecondArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe NativeArray<int> _NetworkPacketsReceivedPerSecondArray
    {
      get
      {
        return *(NativeArray<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkPacketsReceivedPerSecondArray));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkPacketsReceivedPerSecondArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe NativeArray<int> _NetworkMessagesSentPerSecondArray
    {
      get
      {
        return *(NativeArray<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkMessagesSentPerSecondArray));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkMessagesSentPerSecondArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe NativeArray<int> _NetworkMessagesReceivedPerSecondArray
    {
      get
      {
        return *(NativeArray<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkMessagesReceivedPerSecondArray));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkMessagesReceivedPerSecondArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe NativeArray<int> _NetworkMessagesMaxBytesSentPerSecondArray
    {
      get
      {
        return *(NativeArray<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkMessagesMaxBytesSentPerSecondArray));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkMessagesMaxBytesSentPerSecondArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe NativeArray<int> _NetworkMessagesMaxBytesReceivedPerSecondArray
    {
      get
      {
        return *(NativeArray<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkMessagesMaxBytesReceivedPerSecondArray));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__NetworkMessagesMaxBytesReceivedPerSecondArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe NativeArray<float> _SoundCpuUsageArray
    {
      get
      {
        return *(NativeArray<float>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__SoundCpuUsageArray));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__SoundCpuUsageArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe NativeArray<int> _SoundMemoryUsageArray
    {
      get
      {
        return *(NativeArray<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__SoundMemoryUsageArray));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__SoundMemoryUsageArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe NativeArray<int> _ActiveHybridModelCountArray
    {
      get
      {
        return *(NativeArray<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__ActiveHybridModelCountArray));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__ActiveHybridModelCountArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe NativeArray<float2> _PositionArray
    {
      get
      {
        return *(NativeArray<float2>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__PositionArray));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__PositionArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<WorldFrame> _WorldFrame
    {
      get
      {
        return *(SingletonAccessor<WorldFrame>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__WorldFrame));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__WorldFrame), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<WorldFrame>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public static unsafe int MB
    {
      get
      {
        int mb;
        IL2CPP.il2cpp_field_static_get_value(PerformanceLoggerSystem.NativeFieldInfoPtr_MB, (void*) &mb);
        return mb;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PerformanceLoggerSystem.NativeFieldInfoPtr_MB, (void*) &value);
      }
    }

    public unsafe double _LastLogTime
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__LastLogTime));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__LastLogTime)) = value;
      }
    }

    public unsafe int _NextSnapshotIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__NextSnapshotIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__NextSnapshotIndex)) = value;
      }
    }

    public unsafe int _FpsCounter
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__FpsCounter));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__FpsCounter)) = value;
      }
    }

    public unsafe float _NextFpsTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__NextFpsTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__NextFpsTime)) = value;
      }
    }

    public unsafe int _Fps
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__Fps));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__Fps)) = value;
      }
    }

    public unsafe Entity _SummaryBufferEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__SummaryBufferEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__SummaryBufferEntity)) = value;
      }
    }

    public unsafe ClientBootstrapSystem _ClientBootstrapSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__ClientBootstrapSystem));
        return pointer == IntPtr.Zero ? (ClientBootstrapSystem) null : new ClientBootstrapSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__ClientBootstrapSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Stopwatch _Stopwatch
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__Stopwatch));
        return pointer == IntPtr.Zero ? (Stopwatch) null : new Stopwatch(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__Stopwatch), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_LocalControlled_8
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_8));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_8)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_DayNightCycle_9
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_9));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PerformanceLoggerSystem.NativeFieldInfoPtr__SingletonEntityQuery_DayNightCycle_9)) = value;
      }
    }
  }
}
