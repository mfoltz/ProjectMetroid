// Decompiled with JetBrains decompiler
// Type: ProjectM.ServerWebAPISystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Text;
using ProjectM.Network;
using StunMetrics;
using StunMetrics.Reporting;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ServerWebAPISystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__GameVersion;
    private static readonly IntPtr NativeFieldInfoPtr__MetricListenerId;
    private static readonly IntPtr NativeFieldInfoPtr__HttpReceiveService;
    private static readonly IntPtr NativeFieldInfoPtr__ConsoleCommands;
    private static readonly IntPtr NativeFieldInfoPtr__ServerBootstrapSystem;
    private static readonly IntPtr NativeFieldInfoPtr__TimeWhenInitialized;
    private static readonly IntPtr NativeFieldInfoPtr__WaitingForInitialization;
    private static readonly IntPtr NativeFieldInfoPtr__MetricSnapshot;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ConsoleCommand_Private_Void_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetupWebAPI_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnMetricSnapshot_Private_Static_Void_DataId_MetricSnapshot_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateInitializationState_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_HandleConsoleCommands_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_TryBuildPrometheusResponse_Private_Boolean_StringBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_AppendGauge_Private_Static_Void_StringBuilder_String_String_GaugeSnapshot_0;
    private static readonly IntPtr NativeMethodInfoPtr_AppendGauge_Private_Static_Void_StringBuilder_String_String_Double_0;
    private static readonly IntPtr NativeMethodInfoPtr_AppendCounter_Private_Static_Void_StringBuilder_String_String_CounterSnapshot_0;
    private static readonly IntPtr NativeMethodInfoPtr_AppendCounter_Private_Static_Void_StringBuilder_String_String_Int64_0;
    private static readonly IntPtr NativeMethodInfoPtr_AppendHistogram_Private_Static_Void_StringBuilder_String_String_HistogramSnapshot_0;
    private static readonly IntPtr NativeMethodInfoPtr_AppendMeter_Private_Static_Void_StringBuilder_String_String_Data_0;
    private static readonly IntPtr NativeMethodInfoPtr_AppendHeader_Private_Static_Void_StringBuilder_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_AppendValue_Private_Static_Void_StringBuilder_String_Double_0;
    private static readonly IntPtr NativeMethodInfoPtr_AppendValue_Private_Static_Void_StringBuilder_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_AppendValue_Private_Static_Void_StringBuilder_String_Int64_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986087, XrefRangeEnd = 986148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerWebAPISystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986148, XrefRangeEnd = 986160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerWebAPISystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986160, XrefRangeEnd = 986164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ConsoleCommand(string input)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(input);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerWebAPISystem.NativeMethodInfoPtr_ConsoleCommand_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 986227, RefRangeEnd = 986228, XrefRangeStart = 986164, XrefRangeEnd = 986227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupWebAPI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerWebAPISystem.NativeMethodInfoPtr_SetupWebAPI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986228, XrefRangeEnd = 986232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnMetricSnapshot(DataId listenerId, MetricSnapshot snapshot)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &listenerId;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) snapshot);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerWebAPISystem.NativeMethodInfoPtr_OnMetricSnapshot_Private_Static_Void_DataId_MetricSnapshot_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986232, XrefRangeEnd = 986249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerWebAPISystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986249, XrefRangeEnd = 986253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateInitializationState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerWebAPISystem.NativeMethodInfoPtr_UpdateInitializationState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986253, XrefRangeEnd = 986266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleConsoleCommands()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerWebAPISystem.NativeMethodInfoPtr_HandleConsoleCommands_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986266, XrefRangeEnd = 986446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryBuildPrometheusResponse(StringBuilder sb)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerWebAPISystem.NativeMethodInfoPtr_TryBuildPrometheusResponse_Private_Boolean_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986446, XrefRangeEnd = 986447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AppendGauge(
      StringBuilder sb,
      string gaugeName,
      string suffix,
      GaugeSnapshot gaugeData)
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(gaugeName);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(suffix);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &gaugeData;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerWebAPISystem.NativeMethodInfoPtr_AppendGauge_Private_Static_Void_StringBuilder_String_String_GaugeSnapshot_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 986461, RefRangeEnd = 986469, XrefRangeStart = 986447, XrefRangeEnd = 986461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AppendGauge(
      StringBuilder sb,
      string gaugeName,
      string suffix,
      double value)
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(gaugeName);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(suffix);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &value;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerWebAPISystem.NativeMethodInfoPtr_AppendGauge_Private_Static_Void_StringBuilder_String_String_Double_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 986483, RefRangeEnd = 986484, XrefRangeStart = 986469, XrefRangeEnd = 986483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AppendCounter(
      StringBuilder sb,
      string counterName,
      string suffix,
      CounterSnapshot counterData)
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(counterName);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(suffix);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &counterData;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerWebAPISystem.NativeMethodInfoPtr_AppendCounter_Private_Static_Void_StringBuilder_String_String_CounterSnapshot_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986484, XrefRangeEnd = 986498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AppendCounter(
      StringBuilder sb,
      string counterName,
      string suffix,
      long value)
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(counterName);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(suffix);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &value;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerWebAPISystem.NativeMethodInfoPtr_AppendCounter_Private_Static_Void_StringBuilder_String_String_Int64_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 986649, RefRangeEnd = 986651, XrefRangeStart = 986498, XrefRangeEnd = 986649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AppendHistogram(
      StringBuilder sb,
      string histogramName,
      string suffix,
      HistogramSnapshot histogramData)
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(histogramName);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(suffix);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &histogramData;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerWebAPISystem.NativeMethodInfoPtr_AppendHistogram_Private_Static_Void_StringBuilder_String_String_HistogramSnapshot_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 986712, RefRangeEnd = 986714, XrefRangeStart = 986651, XrefRangeEnd = 986712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AppendMeter(
      StringBuilder sb,
      string meterName,
      string suffix,
      MeterSnapshot.Data meterData)
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(meterName);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(suffix);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &meterData;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerWebAPISystem.NativeMethodInfoPtr_AppendMeter_Private_Static_Void_StringBuilder_String_String_Data_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 986726, RefRangeEnd = 986731, XrefRangeStart = 986714, XrefRangeEnd = 986726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AppendHeader(StringBuilder sb, string type, string key)
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(type);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(key);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerWebAPISystem.NativeMethodInfoPtr_AppendHeader_Private_Static_Void_StringBuilder_String_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986731, XrefRangeEnd = 986740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AppendValue(StringBuilder sb, string key, double value)
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(key);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &value;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerWebAPISystem.NativeMethodInfoPtr_AppendValue_Private_Static_Void_StringBuilder_String_Double_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986740, XrefRangeEnd = 986749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AppendValue(StringBuilder sb, string key, string value)
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(key);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(value);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerWebAPISystem.NativeMethodInfoPtr_AppendValue_Private_Static_Void_StringBuilder_String_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986749, XrefRangeEnd = 986758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AppendValue(StringBuilder sb, string key, long value)
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(key);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &value;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerWebAPISystem.NativeMethodInfoPtr_AppendValue_Private_Static_Void_StringBuilder_String_Int64_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerWebAPISystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerWebAPISystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerWebAPISystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServerWebAPISystem()
    {
      Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ServerWebAPISystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr);
      ServerWebAPISystem.NativeFieldInfoPtr__GameVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, nameof (_GameVersion));
      ServerWebAPISystem.NativeFieldInfoPtr__MetricListenerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, nameof (_MetricListenerId));
      ServerWebAPISystem.NativeFieldInfoPtr__HttpReceiveService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, nameof (_HttpReceiveService));
      ServerWebAPISystem.NativeFieldInfoPtr__ConsoleCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, nameof (_ConsoleCommands));
      ServerWebAPISystem.NativeFieldInfoPtr__ServerBootstrapSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, nameof (_ServerBootstrapSystem));
      ServerWebAPISystem.NativeFieldInfoPtr__TimeWhenInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, nameof (_TimeWhenInitialized));
      ServerWebAPISystem.NativeFieldInfoPtr__WaitingForInitialization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, nameof (_WaitingForInitialization));
      ServerWebAPISystem.NativeFieldInfoPtr__MetricSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, nameof (_MetricSnapshot));
      ServerWebAPISystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, 100676087);
      ServerWebAPISystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, 100676088);
      ServerWebAPISystem.NativeMethodInfoPtr_ConsoleCommand_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, 100676089);
      ServerWebAPISystem.NativeMethodInfoPtr_SetupWebAPI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, 100676090);
      ServerWebAPISystem.NativeMethodInfoPtr_OnMetricSnapshot_Private_Static_Void_DataId_MetricSnapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, 100676091);
      ServerWebAPISystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, 100676092);
      ServerWebAPISystem.NativeMethodInfoPtr_UpdateInitializationState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, 100676093);
      ServerWebAPISystem.NativeMethodInfoPtr_HandleConsoleCommands_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, 100676094);
      ServerWebAPISystem.NativeMethodInfoPtr_TryBuildPrometheusResponse_Private_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, 100676095);
      ServerWebAPISystem.NativeMethodInfoPtr_AppendGauge_Private_Static_Void_StringBuilder_String_String_GaugeSnapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, 100676096);
      ServerWebAPISystem.NativeMethodInfoPtr_AppendGauge_Private_Static_Void_StringBuilder_String_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, 100676097);
      ServerWebAPISystem.NativeMethodInfoPtr_AppendCounter_Private_Static_Void_StringBuilder_String_String_CounterSnapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, 100676098);
      ServerWebAPISystem.NativeMethodInfoPtr_AppendCounter_Private_Static_Void_StringBuilder_String_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, 100676099);
      ServerWebAPISystem.NativeMethodInfoPtr_AppendHistogram_Private_Static_Void_StringBuilder_String_String_HistogramSnapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, 100676100);
      ServerWebAPISystem.NativeMethodInfoPtr_AppendMeter_Private_Static_Void_StringBuilder_String_String_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, 100676101);
      ServerWebAPISystem.NativeMethodInfoPtr_AppendHeader_Private_Static_Void_StringBuilder_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, 100676102);
      ServerWebAPISystem.NativeMethodInfoPtr_AppendValue_Private_Static_Void_StringBuilder_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, 100676103);
      ServerWebAPISystem.NativeMethodInfoPtr_AppendValue_Private_Static_Void_StringBuilder_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, 100676104);
      ServerWebAPISystem.NativeMethodInfoPtr_AppendValue_Private_Static_Void_StringBuilder_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, 100676105);
      ServerWebAPISystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, 100676106);
      ServerWebAPISystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWebAPISystem>.NativeClassPtr, 100676107);
    }

    public ServerWebAPISystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameVersion _GameVersion
    {
      get
      {
        return *(GameVersion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerWebAPISystem.NativeFieldInfoPtr__GameVersion));
      }
      [param: In] set
      {
        *(GameVersion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerWebAPISystem.NativeFieldInfoPtr__GameVersion)) = value;
      }
    }

    public unsafe DataId _MetricListenerId
    {
      get
      {
        return *(DataId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerWebAPISystem.NativeFieldInfoPtr__MetricListenerId));
      }
      [param: In] set
      {
        *(DataId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerWebAPISystem.NativeFieldInfoPtr__MetricListenerId)) = value;
      }
    }

    public unsafe HttpServiceReceiveThread _HttpReceiveService
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerWebAPISystem.NativeFieldInfoPtr__HttpReceiveService));
        return pointer == IntPtr.Zero ? (HttpServiceReceiveThread) null : new HttpServiceReceiveThread(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerWebAPISystem.NativeFieldInfoPtr__HttpReceiveService), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ConcurrentQueue<string> _ConsoleCommands
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerWebAPISystem.NativeFieldInfoPtr__ConsoleCommands));
        return pointer == IntPtr.Zero ? (ConcurrentQueue<string>) null : new ConcurrentQueue<string>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerWebAPISystem.NativeFieldInfoPtr__ConsoleCommands), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerBootstrapSystem _ServerBootstrapSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerWebAPISystem.NativeFieldInfoPtr__ServerBootstrapSystem));
        return pointer == IntPtr.Zero ? (ServerBootstrapSystem) null : new ServerBootstrapSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerWebAPISystem.NativeFieldInfoPtr__ServerBootstrapSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _TimeWhenInitialized
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerWebAPISystem.NativeFieldInfoPtr__TimeWhenInitialized));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerWebAPISystem.NativeFieldInfoPtr__TimeWhenInitialized)) = value;
      }
    }

    public unsafe bool _WaitingForInitialization
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerWebAPISystem.NativeFieldInfoPtr__WaitingForInitialization));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerWebAPISystem.NativeFieldInfoPtr__WaitingForInitialization)) = value;
      }
    }

    public static unsafe MetricSnapshot _MetricSnapshot
    {
      get
      {
        IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ServerWebAPISystem.NativeFieldInfoPtr__MetricSnapshot, (void*) &num);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (MetricSnapshot) null : new MetricSnapshot(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerWebAPISystem.NativeFieldInfoPtr__MetricSnapshot, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
