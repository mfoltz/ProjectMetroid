// Decompiled with JetBrains decompiler
// Type: ChunkPerformanceTester
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Engine.Console;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
public static class ChunkPerformanceTester : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_TestRunner;
  private static readonly System.IntPtr NativeFieldInfoPtr_TeleportCommand;
  private static readonly System.IntPtr NativeFieldInfoPtr_TeleportFullCommand;
  private static readonly System.IntPtr NativeFieldInfoPtr_TeleportArgumentString;
  private static readonly System.IntPtr NativeFieldInfoPtr_ChunkSizeX;
  private static readonly System.IntPtr NativeFieldInfoPtr_FPS_MIN;
  private static readonly System.IntPtr NativeFieldInfoPtr_FPS_MAX;
  private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_CHUNK_LOAD_INTERVAL;
  private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_SAMPLE_INTERVAL;
  private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_AVOID_SYNC_SPIKE_INTERVAL;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApproximateTestTime_Public_Static_Single_Single_Int32_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTeleportCommand_Public_Static_Void_DefaultConsoleCommand_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunTest_Public_Static_Void_List_1_Vector2Int_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TeleportPlayer_Public_Static_Void_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawHeatMapAndExport_Public_Static_Void_TestSettings_List_1_ChunkData_ComputeShader_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConvertChunkDataToBufferData_Public_Static_Void_byref_Int32_byref_List_1_ChunkData_byref_ComputeBuffer_byref_ComputeBuffer_byref_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ChunkDataToLog_Private_Static_String_TestSettings_List_1_ChunkData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExportResultLog_Public_Static_Void_String_byref_TestSettings_byref_List_1_ChunkData_Single_Single_0;

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 915920, RefRangeEnd = 915923, XrefRangeStart = 915916, XrefRangeEnd = 915920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float ApproximateTestTime(
    float distBetweenSamples,
    int numChunks,
    float chunkLoadTimeInterval = 1.3f,
    float sampleTimeInterval = 0.1f,
    float avoidSyncSpikeInterval = 1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &distBetweenSamples;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &numChunks;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkLoadTimeInterval;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sampleTimeInterval;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &avoidSyncSpikeInterval;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTester.NativeMethodInfoPtr_ApproximateTestTime_Public_Static_Single_Single_Int32_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915923, XrefRangeEnd = 915928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetTeleportCommand(DefaultConsoleCommand teleportCommand)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) teleportCommand);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTester.NativeMethodInfoPtr_SetTeleportCommand_Public_Static_Void_DefaultConsoleCommand_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 915948, RefRangeEnd = 915951, XrefRangeStart = 915928, XrefRangeEnd = 915948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RunTest(
    List<Vector2Int> chunkCoordinates,
    float distBetweenSamples = 32f,
    float chunkLoadTimeInterval = 1.3f,
    float sampleTimeInterval = 0.1f,
    float avoidSyncSpikeInterval = 1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) chunkCoordinates);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &distBetweenSamples;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkLoadTimeInterval;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sampleTimeInterval;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &avoidSyncSpikeInterval;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTester.NativeMethodInfoPtr_RunTest_Public_Static_Void_List_1_Vector2Int_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 915964, RefRangeEnd = 915965, XrefRangeStart = 915951, XrefRangeEnd = 915964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void TeleportPlayer(float tilePosX, float tilePosY)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &tilePosX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tilePosY;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTester.NativeMethodInfoPtr_TeleportPlayer_Public_Static_Void_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 916057, RefRangeEnd = 916059, XrefRangeStart = 915965, XrefRangeEnd = 916057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawHeatMapAndExport(
    ChunkPerformanceTestBehaviour.TestSettings testSettings,
    List<ChunkPerformanceTestBehaviour.ChunkData> chunkData,
    ComputeShader cs,
    int jumpsPerChunk,
    int numTotalSamples)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) testSettings);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) chunkData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cs);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &jumpsPerChunk;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &numTotalSamples;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTester.NativeMethodInfoPtr_DrawHeatMapAndExport_Public_Static_Void_TestSettings_List_1_ChunkData_ComputeShader_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 916086, RefRangeEnd = 916087, XrefRangeStart = 916059, XrefRangeEnd = 916086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ConvertChunkDataToBufferData(
    [In] ref int NumSamples,
    [In] ref List<ChunkPerformanceTestBehaviour.ChunkData> chunkData,
    ref ComputeBuffer chunkBuffer,
    ref ComputeBuffer sampleBuffer,
    out Vector2 MinMaxFPS)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
    numPtr1[0] = (System.IntPtr) ref NumSamples;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr ptr1 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) chunkData);
    System.IntPtr* numPtr2 = &ptr1;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr ptr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) chunkBuffer);
    System.IntPtr* numPtr3 = &ptr2;
    *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
    System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    System.IntPtr ptr3 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sampleBuffer);
    System.IntPtr* numPtr4 = &ptr3;
    *(System.IntPtr*) num3 = (System.IntPtr) numPtr4;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref MinMaxFPS;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTester.NativeMethodInfoPtr_ConvertChunkDataToBufferData_Public_Static_Void_byref_Int32_byref_List_1_ChunkData_byref_ComputeBuffer_byref_ComputeBuffer_byref_Vector2_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref List<ChunkPerformanceTestBehaviour.ChunkData> local1 = ref chunkData;
    System.IntPtr pointer1 = ptr1;
    List<> list = pointer1 == System.IntPtr.Zero ? (List<>) null : new List<>(pointer1);
    local1 = (List<ChunkPerformanceTestBehaviour.ChunkData>) list;
    ref ComputeBuffer local2 = ref chunkBuffer;
    System.IntPtr pointer2 = ptr2;
    ComputeBuffer computeBuffer1 = pointer2 == System.IntPtr.Zero ? (ComputeBuffer) null : new ComputeBuffer(pointer2);
    local2 = computeBuffer1;
    ref ComputeBuffer local3 = ref sampleBuffer;
    System.IntPtr pointer3 = ptr3;
    ComputeBuffer computeBuffer2 = pointer3 == System.IntPtr.Zero ? (ComputeBuffer) null : new ComputeBuffer(pointer3);
    local3 = computeBuffer2;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916087, XrefRangeEnd = 916245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ChunkDataToLog(
    ChunkPerformanceTestBehaviour.TestSettings testSettings,
    List<ChunkPerformanceTestBehaviour.ChunkData> chunkData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) testSettings);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) chunkData);
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTester.NativeMethodInfoPtr_ChunkDataToLog_Private_Static_String_TestSettings_List_1_ChunkData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 916308, RefRangeEnd = 916309, XrefRangeStart = 916245, XrefRangeEnd = 916308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ExportResultLog(
    string exportPath,
    [In] ref ChunkPerformanceTestBehaviour.TestSettings testSettings,
    [In] ref List<ChunkPerformanceTestBehaviour.ChunkData> chunkData,
    float minFPS,
    float maxFPS)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(exportPath);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr ptr1 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) testSettings);
    System.IntPtr* numPtr2 = &ptr1;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr ptr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) chunkData);
    System.IntPtr* numPtr3 = &ptr2;
    *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &minFPS;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &maxFPS;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTester.NativeMethodInfoPtr_ExportResultLog_Public_Static_Void_String_byref_TestSettings_byref_List_1_ChunkData_Single_Single_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref ChunkPerformanceTestBehaviour.TestSettings local1 = ref testSettings;
    System.IntPtr pointer1 = ptr1;
    ChunkPerformanceTestBehaviour.TestSettings testSettings1 = pointer1 == System.IntPtr.Zero ? (ChunkPerformanceTestBehaviour.TestSettings) null : new ChunkPerformanceTestBehaviour.TestSettings(pointer1);
    local1 = testSettings1;
    ref List<ChunkPerformanceTestBehaviour.ChunkData> local2 = ref chunkData;
    System.IntPtr pointer2 = ptr2;
    List<> list = pointer2 == System.IntPtr.Zero ? (List<>) null : new List<>(pointer2);
    local2 = (List<ChunkPerformanceTestBehaviour.ChunkData>) list;
  }

  static ChunkPerformanceTester()
  {
    Il2CppClassPointerStore<ChunkPerformanceTester>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (ChunkPerformanceTester));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkPerformanceTester>.NativeClassPtr);
    ChunkPerformanceTester.NativeFieldInfoPtr_TestRunner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTester>.NativeClassPtr, nameof (TestRunner));
    ChunkPerformanceTester.NativeFieldInfoPtr_TeleportCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTester>.NativeClassPtr, nameof (TeleportCommand));
    ChunkPerformanceTester.NativeFieldInfoPtr_TeleportFullCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTester>.NativeClassPtr, nameof (TeleportFullCommand));
    ChunkPerformanceTester.NativeFieldInfoPtr_TeleportArgumentString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTester>.NativeClassPtr, nameof (TeleportArgumentString));
    ChunkPerformanceTester.NativeFieldInfoPtr_ChunkSizeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTester>.NativeClassPtr, nameof (ChunkSizeX));
    ChunkPerformanceTester.NativeFieldInfoPtr_FPS_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTester>.NativeClassPtr, nameof (FPS_MIN));
    ChunkPerformanceTester.NativeFieldInfoPtr_FPS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTester>.NativeClassPtr, nameof (FPS_MAX));
    ChunkPerformanceTester.NativeFieldInfoPtr_DEFAULT_CHUNK_LOAD_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTester>.NativeClassPtr, nameof (DEFAULT_CHUNK_LOAD_INTERVAL));
    ChunkPerformanceTester.NativeFieldInfoPtr_DEFAULT_SAMPLE_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTester>.NativeClassPtr, nameof (DEFAULT_SAMPLE_INTERVAL));
    ChunkPerformanceTester.NativeFieldInfoPtr_DEFAULT_AVOID_SYNC_SPIKE_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTester>.NativeClassPtr, nameof (DEFAULT_AVOID_SYNC_SPIKE_INTERVAL));
    ChunkPerformanceTester.NativeMethodInfoPtr_ApproximateTestTime_Public_Static_Single_Single_Int32_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTester>.NativeClassPtr, 100663627);
    ChunkPerformanceTester.NativeMethodInfoPtr_SetTeleportCommand_Public_Static_Void_DefaultConsoleCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTester>.NativeClassPtr, 100663628);
    ChunkPerformanceTester.NativeMethodInfoPtr_RunTest_Public_Static_Void_List_1_Vector2Int_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTester>.NativeClassPtr, 100663629);
    ChunkPerformanceTester.NativeMethodInfoPtr_TeleportPlayer_Public_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTester>.NativeClassPtr, 100663630);
    ChunkPerformanceTester.NativeMethodInfoPtr_DrawHeatMapAndExport_Public_Static_Void_TestSettings_List_1_ChunkData_ComputeShader_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTester>.NativeClassPtr, 100663631);
    ChunkPerformanceTester.NativeMethodInfoPtr_ConvertChunkDataToBufferData_Public_Static_Void_byref_Int32_byref_List_1_ChunkData_byref_ComputeBuffer_byref_ComputeBuffer_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTester>.NativeClassPtr, 100663632);
    ChunkPerformanceTester.NativeMethodInfoPtr_ChunkDataToLog_Private_Static_String_TestSettings_List_1_ChunkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTester>.NativeClassPtr, 100663633);
    ChunkPerformanceTester.NativeMethodInfoPtr_ExportResultLog_Public_Static_Void_String_byref_TestSettings_byref_List_1_ChunkData_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTester>.NativeClassPtr, 100663634);
  }

  public ChunkPerformanceTester(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe ChunkPerformanceTestBehaviour TestRunner
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ChunkPerformanceTester.NativeFieldInfoPtr_TestRunner, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ChunkPerformanceTestBehaviour) null : new ChunkPerformanceTestBehaviour(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ChunkPerformanceTester.NativeFieldInfoPtr_TestRunner, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe DefaultConsoleCommand TeleportCommand
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ChunkPerformanceTester.NativeFieldInfoPtr_TeleportCommand, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (DefaultConsoleCommand) null : new DefaultConsoleCommand(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ChunkPerformanceTester.NativeFieldInfoPtr_TeleportCommand, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe string TeleportFullCommand
  {
    get
    {
      System.IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(ChunkPerformanceTester.NativeFieldInfoPtr_TeleportFullCommand, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ChunkPerformanceTester.NativeFieldInfoPtr_TeleportFullCommand, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string TeleportArgumentString
  {
    get
    {
      System.IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(ChunkPerformanceTester.NativeFieldInfoPtr_TeleportArgumentString, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ChunkPerformanceTester.NativeFieldInfoPtr_TeleportArgumentString, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe int ChunkSizeX
  {
    get
    {
      int chunkSizeX;
      IL2CPP.il2cpp_field_static_get_value(ChunkPerformanceTester.NativeFieldInfoPtr_ChunkSizeX, (void*) &chunkSizeX);
      return chunkSizeX;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ChunkPerformanceTester.NativeFieldInfoPtr_ChunkSizeX, (void*) &value);
    }
  }

  public static unsafe float FPS_MIN
  {
    get
    {
      float fpsMin;
      IL2CPP.il2cpp_field_static_get_value(ChunkPerformanceTester.NativeFieldInfoPtr_FPS_MIN, (void*) &fpsMin);
      return fpsMin;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ChunkPerformanceTester.NativeFieldInfoPtr_FPS_MIN, (void*) &value);
    }
  }

  public static unsafe float FPS_MAX
  {
    get
    {
      float fpsMax;
      IL2CPP.il2cpp_field_static_get_value(ChunkPerformanceTester.NativeFieldInfoPtr_FPS_MAX, (void*) &fpsMax);
      return fpsMax;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ChunkPerformanceTester.NativeFieldInfoPtr_FPS_MAX, (void*) &value);
    }
  }

  public static unsafe float DEFAULT_CHUNK_LOAD_INTERVAL
  {
    get
    {
      float chunkLoadInterval;
      IL2CPP.il2cpp_field_static_get_value(ChunkPerformanceTester.NativeFieldInfoPtr_DEFAULT_CHUNK_LOAD_INTERVAL, (void*) &chunkLoadInterval);
      return chunkLoadInterval;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ChunkPerformanceTester.NativeFieldInfoPtr_DEFAULT_CHUNK_LOAD_INTERVAL, (void*) &value);
    }
  }

  public static unsafe float DEFAULT_SAMPLE_INTERVAL
  {
    get
    {
      float defaultSampleInterval;
      IL2CPP.il2cpp_field_static_get_value(ChunkPerformanceTester.NativeFieldInfoPtr_DEFAULT_SAMPLE_INTERVAL, (void*) &defaultSampleInterval);
      return defaultSampleInterval;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ChunkPerformanceTester.NativeFieldInfoPtr_DEFAULT_SAMPLE_INTERVAL, (void*) &value);
    }
  }

  public static unsafe float DEFAULT_AVOID_SYNC_SPIKE_INTERVAL
  {
    get
    {
      float syncSpikeInterval;
      IL2CPP.il2cpp_field_static_get_value(ChunkPerformanceTester.NativeFieldInfoPtr_DEFAULT_AVOID_SYNC_SPIKE_INTERVAL, (void*) &syncSpikeInterval);
      return syncSpikeInterval;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ChunkPerformanceTester.NativeFieldInfoPtr_DEFAULT_AVOID_SYNC_SPIKE_INTERVAL, (void*) &value);
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Chunk
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_id;
    private static readonly System.IntPtr NativeFieldInfoPtr_sampleBufferStartIndex;
    [FieldOffset(0)]
    public float2 id;
    [FieldOffset(8)]
    public int sampleBufferStartIndex;

    static Chunk()
    {
      Il2CppClassPointerStore<ChunkPerformanceTester.Chunk>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkPerformanceTester>.NativeClassPtr, nameof (Chunk));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkPerformanceTester.Chunk>.NativeClassPtr);
      ChunkPerformanceTester.Chunk.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTester.Chunk>.NativeClassPtr, nameof (id));
      ChunkPerformanceTester.Chunk.NativeFieldInfoPtr_sampleBufferStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTester.Chunk>.NativeClassPtr, nameof (sampleBufferStartIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkPerformanceTester.Chunk>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Sample
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_fps;
    [FieldOffset(0)]
    public float fps;

    static Sample()
    {
      Il2CppClassPointerStore<ChunkPerformanceTester.Sample>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkPerformanceTester>.NativeClassPtr, nameof (Sample));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkPerformanceTester.Sample>.NativeClassPtr);
      ChunkPerformanceTester.Sample.NativeFieldInfoPtr_fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTester.Sample>.NativeClassPtr, nameof (fps));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkPerformanceTester.Sample>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
