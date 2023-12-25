// Decompiled with JetBrains decompiler
// Type: ChunkPerformanceTestBehaviour
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using ProjectM.Hybrid;
using ProjectM.Sequencer;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Profiling;
using UnityEngine;

#nullable disable
public class ChunkPerformanceTestBehaviour : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_ClientWorld;
  private static readonly System.IntPtr NativeFieldInfoPtr_HybridModelSystem;
  private static readonly System.IntPtr NativeFieldInfoPtr_ParticleLifetimeSystem;
  private static readonly System.IntPtr NativeFieldInfoPtr_DrawCallsRecorder;
  private static readonly System.IntPtr NativeFieldInfoPtr_TrianglesRecorder;
  private static readonly System.IntPtr NativeFieldInfoPtr_SystemMemoryRecorder;
  private static readonly System.IntPtr NativeFieldInfoPtr_ShadowCastersRecorder;
  private static readonly System.IntPtr NativeFieldInfoPtr_ValidTestEnvironment;
  private static readonly System.IntPtr NativeFieldInfoPtr_ComputeShader;
  private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTestData;
  private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTestPhase;
  private static readonly System.IntPtr NativeFieldInfoPtr_ChunkSampleData;
  private static readonly System.IntPtr NativeFieldInfoPtr_CurrentChunk;
  private static readonly System.IntPtr NativeFieldInfoPtr_CurrentSample;
  private static readonly System.IntPtr NativeFieldInfoPtr_StartTilePosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTilePosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_IterationsXY;
  private static readonly System.IntPtr NativeFieldInfoPtr_TimeSinceLastSample;
  private static readonly System.IntPtr NativeFieldInfoPtr_ChunkSizeX;
  private static readonly System.IntPtr NativeFieldInfoPtr_NumTestChunks;
  private static readonly System.IntPtr NativeFieldInfoPtr_ChunksTested;
  private static readonly System.IntPtr NativeFieldInfoPtr_SamplesTaken;
  private static readonly System.IntPtr NativeFieldInfoPtr_BYTE_TO_MEGABYTE;
  private static readonly System.IntPtr NativeFieldInfoPtr_TestEnd;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTestDataAndStart_Public_Void_TestSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitTestData_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CleanupTestData_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PerformMiscDataSample_Private_SampleSnapshotData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateNextTeleportPosition_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExportTestResults_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915767, XrefRangeEnd = 915789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTestBehaviour.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915789, XrefRangeEnd = 915791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetTestDataAndStart(ChunkPerformanceTestBehaviour.TestSettings data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTestBehaviour.NativeMethodInfoPtr_SetTestDataAndStart_Public_Void_TestSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 915819, RefRangeEnd = 915820, XrefRangeStart = 915791, XrefRangeEnd = 915819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InitTestData()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTestBehaviour.NativeMethodInfoPtr_InitTestData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915820, XrefRangeEnd = 915824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CleanupTestData()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTestBehaviour.NativeMethodInfoPtr_CleanupTestData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTestBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915824, XrefRangeEnd = 915838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ChunkPerformanceTestBehaviour.SampleSnapshotData PerformMiscDataSample()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTestBehaviour.NativeMethodInfoPtr_PerformMiscDataSample_Private_SampleSnapshotData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(ChunkPerformanceTestBehaviour.SampleSnapshotData*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915838, XrefRangeEnd = 915900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTestBehaviour.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void CalculateNextTeleportPosition()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTestBehaviour.NativeMethodInfoPtr_CalculateNextTeleportPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915900, XrefRangeEnd = 915908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ExportTestResults()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTestBehaviour.NativeMethodInfoPtr_ExportTestResults_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915908, XrefRangeEnd = 915916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ChunkPerformanceTestBehaviour()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTestBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ChunkPerformanceTestBehaviour()
  {
    Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (ChunkPerformanceTestBehaviour));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr);
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ClientWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (ClientWorld));
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_HybridModelSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (HybridModelSystem));
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ParticleLifetimeSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (ParticleLifetimeSystem));
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_DrawCallsRecorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (DrawCallsRecorder));
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_TrianglesRecorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (TrianglesRecorder));
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_SystemMemoryRecorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (SystemMemoryRecorder));
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ShadowCastersRecorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (ShadowCastersRecorder));
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ValidTestEnvironment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (ValidTestEnvironment));
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ComputeShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (ComputeShader));
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_CurrentTestData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (CurrentTestData));
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_CurrentTestPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (CurrentTestPhase));
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ChunkSampleData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (ChunkSampleData));
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_CurrentChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (CurrentChunk));
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_CurrentSample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (CurrentSample));
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_StartTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (StartTilePosition));
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_CurrentTilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (CurrentTilePosition));
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_IterationsXY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (IterationsXY));
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_TimeSinceLastSample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (TimeSinceLastSample));
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ChunkSizeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (ChunkSizeX));
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_NumTestChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (NumTestChunks));
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ChunksTested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (ChunksTested));
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_SamplesTaken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (SamplesTaken));
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_BYTE_TO_MEGABYTE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (BYTE_TO_MEGABYTE));
    ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_TestEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (TestEnd));
    ChunkPerformanceTestBehaviour.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, 100663600);
    ChunkPerformanceTestBehaviour.NativeMethodInfoPtr_SetTestDataAndStart_Public_Void_TestSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, 100663601);
    ChunkPerformanceTestBehaviour.NativeMethodInfoPtr_InitTestData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, 100663602);
    ChunkPerformanceTestBehaviour.NativeMethodInfoPtr_CleanupTestData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, 100663603);
    ChunkPerformanceTestBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, 100663604);
    ChunkPerformanceTestBehaviour.NativeMethodInfoPtr_PerformMiscDataSample_Private_SampleSnapshotData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, 100663605);
    ChunkPerformanceTestBehaviour.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, 100663606);
    ChunkPerformanceTestBehaviour.NativeMethodInfoPtr_CalculateNextTeleportPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, 100663607);
    ChunkPerformanceTestBehaviour.NativeMethodInfoPtr_ExportTestResults_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, 100663608);
    ChunkPerformanceTestBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, 100663609);
  }

  public ChunkPerformanceTestBehaviour(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe World ClientWorld
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ClientWorld));
      return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ClientWorld), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe HybridModelSystem HybridModelSystem
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_HybridModelSystem));
      return pointer == System.IntPtr.Zero ? (HybridModelSystem) null : new HybridModelSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_HybridModelSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleLifetimeSystem ParticleLifetimeSystem
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ParticleLifetimeSystem));
      return pointer == System.IntPtr.Zero ? (ParticleLifetimeSystem) null : new ParticleLifetimeSystem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ParticleLifetimeSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ProfilerRecorder DrawCallsRecorder
  {
    get
    {
      return *(ProfilerRecorder*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_DrawCallsRecorder));
    }
    [param: In] set
    {
      *(ProfilerRecorder*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_DrawCallsRecorder)) = value;
    }
  }

  public unsafe ProfilerRecorder TrianglesRecorder
  {
    get
    {
      return *(ProfilerRecorder*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_TrianglesRecorder));
    }
    [param: In] set
    {
      *(ProfilerRecorder*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_TrianglesRecorder)) = value;
    }
  }

  public unsafe ProfilerRecorder SystemMemoryRecorder
  {
    get
    {
      return *(ProfilerRecorder*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_SystemMemoryRecorder));
    }
    [param: In] set
    {
      *(ProfilerRecorder*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_SystemMemoryRecorder)) = value;
    }
  }

  public unsafe ProfilerRecorder ShadowCastersRecorder
  {
    get
    {
      return *(ProfilerRecorder*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ShadowCastersRecorder));
    }
    [param: In] set
    {
      *(ProfilerRecorder*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ShadowCastersRecorder)) = value;
    }
  }

  public unsafe bool ValidTestEnvironment
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ValidTestEnvironment));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ValidTestEnvironment)) = value;
    }
  }

  public unsafe ComputeShader ComputeShader
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ComputeShader));
      return pointer == System.IntPtr.Zero ? (ComputeShader) null : new ComputeShader(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ComputeShader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ChunkPerformanceTestBehaviour.TestSettings CurrentTestData
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_CurrentTestData));
      return pointer == System.IntPtr.Zero ? (ChunkPerformanceTestBehaviour.TestSettings) null : new ChunkPerformanceTestBehaviour.TestSettings(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_CurrentTestData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ChunkPerformanceTestBehaviour.TestPhase CurrentTestPhase
  {
    get
    {
      return *(ChunkPerformanceTestBehaviour.TestPhase*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_CurrentTestPhase));
    }
    [param: In] set
    {
      *(ChunkPerformanceTestBehaviour.TestPhase*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_CurrentTestPhase)) = value;
    }
  }

  public unsafe List<ChunkPerformanceTestBehaviour.ChunkData> ChunkSampleData
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ChunkSampleData));
      return pointer == System.IntPtr.Zero ? (List<ChunkPerformanceTestBehaviour.ChunkData>) null : new List<ChunkPerformanceTestBehaviour.ChunkData>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ChunkSampleData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ChunkPerformanceTestBehaviour.ChunkData CurrentChunk
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_CurrentChunk));
      return pointer == System.IntPtr.Zero ? (ChunkPerformanceTestBehaviour.ChunkData) null : new ChunkPerformanceTestBehaviour.ChunkData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_CurrentChunk), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ChunkPerformanceTestBehaviour.SampleData CurrentSample
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_CurrentSample));
      return pointer == System.IntPtr.Zero ? (ChunkPerformanceTestBehaviour.SampleData) null : new ChunkPerformanceTestBehaviour.SampleData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_CurrentSample), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 StartTilePosition
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_StartTilePosition));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_StartTilePosition)) = value;
    }
  }

  public unsafe Vector2 CurrentTilePosition
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_CurrentTilePosition));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_CurrentTilePosition)) = value;
    }
  }

  public unsafe Vector2Int IterationsXY
  {
    get
    {
      return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_IterationsXY));
    }
    [param: In] set
    {
      *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_IterationsXY)) = value;
    }
  }

  public unsafe float TimeSinceLastSample
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_TimeSinceLastSample));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_TimeSinceLastSample)) = value;
    }
  }

  public static unsafe int ChunkSizeX
  {
    get
    {
      int chunkSizeX;
      IL2CPP.il2cpp_field_static_get_value(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ChunkSizeX, (void*) &chunkSizeX);
      return chunkSizeX;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ChunkSizeX, (void*) &value);
    }
  }

  public unsafe int NumTestChunks
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_NumTestChunks));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_NumTestChunks)) = value;
    }
  }

  public unsafe int ChunksTested
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ChunksTested));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_ChunksTested)) = value;
    }
  }

  public unsafe int SamplesTaken
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_SamplesTaken));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_SamplesTaken)) = value;
    }
  }

  public static unsafe int BYTE_TO_MEGABYTE
  {
    get
    {
      int byteToMegabyte;
      IL2CPP.il2cpp_field_static_get_value(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_BYTE_TO_MEGABYTE, (void*) &byteToMegabyte);
      return byteToMegabyte;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_BYTE_TO_MEGABYTE, (void*) &value);
    }
  }

  public unsafe bool TestEnd
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_TestEnd));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.NativeFieldInfoPtr_TestEnd)) = value;
    }
  }

  public class TestSettings : HeatMapBinaryUtility.HeatMapFileHeader
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ChunksToTest;
    private static readonly System.IntPtr NativeFieldInfoPtr_JumpDist;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChunkLoadTimeInterval;
    private static readonly System.IntPtr NativeFieldInfoPtr_SampleTimeInterval;
    private static readonly System.IntPtr NativeFieldInfoPtr_AvoidSyncSpikeTimeInterval;
    private static readonly System.IntPtr NativeFieldInfoPtr_XJumpsPerChunk;
    private static readonly System.IntPtr NativeFieldInfoPtr_YJumpsPerChunk;
    private static readonly System.IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_BinaryWriter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Boolean_BinaryReader_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915630, XrefRangeEnd = 915631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Write(BinaryWriter bw)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bw);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChunkPerformanceTestBehaviour.TestSettings.NativeMethodInfoPtr_Write_Public_Virtual_Void_BinaryWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915631, XrefRangeEnd = 915635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool Read(BinaryReader br)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) br);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChunkPerformanceTestBehaviour.TestSettings.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_BinaryReader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TestSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.TestSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTestBehaviour.TestSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TestSettings()
    {
      Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.TestSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (TestSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.TestSettings>.NativeClassPtr);
      ChunkPerformanceTestBehaviour.TestSettings.NativeFieldInfoPtr_ChunksToTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.TestSettings>.NativeClassPtr, nameof (ChunksToTest));
      ChunkPerformanceTestBehaviour.TestSettings.NativeFieldInfoPtr_JumpDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.TestSettings>.NativeClassPtr, nameof (JumpDist));
      ChunkPerformanceTestBehaviour.TestSettings.NativeFieldInfoPtr_ChunkLoadTimeInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.TestSettings>.NativeClassPtr, nameof (ChunkLoadTimeInterval));
      ChunkPerformanceTestBehaviour.TestSettings.NativeFieldInfoPtr_SampleTimeInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.TestSettings>.NativeClassPtr, nameof (SampleTimeInterval));
      ChunkPerformanceTestBehaviour.TestSettings.NativeFieldInfoPtr_AvoidSyncSpikeTimeInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.TestSettings>.NativeClassPtr, nameof (AvoidSyncSpikeTimeInterval));
      ChunkPerformanceTestBehaviour.TestSettings.NativeFieldInfoPtr_XJumpsPerChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.TestSettings>.NativeClassPtr, nameof (XJumpsPerChunk));
      ChunkPerformanceTestBehaviour.TestSettings.NativeFieldInfoPtr_YJumpsPerChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.TestSettings>.NativeClassPtr, nameof (YJumpsPerChunk));
      ChunkPerformanceTestBehaviour.TestSettings.NativeMethodInfoPtr_Write_Public_Virtual_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.TestSettings>.NativeClassPtr, 100663610);
      ChunkPerformanceTestBehaviour.TestSettings.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.TestSettings>.NativeClassPtr, 100663611);
      ChunkPerformanceTestBehaviour.TestSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.TestSettings>.NativeClassPtr, 100663612);
    }

    public TestSettings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<Vector2Int> ChunksToTest
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.TestSettings.NativeFieldInfoPtr_ChunksToTest));
        return pointer == System.IntPtr.Zero ? (List<Vector2Int>) null : new List<Vector2Int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.TestSettings.NativeFieldInfoPtr_ChunksToTest), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float JumpDist
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.TestSettings.NativeFieldInfoPtr_JumpDist));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.TestSettings.NativeFieldInfoPtr_JumpDist)) = value;
      }
    }

    public unsafe float ChunkLoadTimeInterval
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.TestSettings.NativeFieldInfoPtr_ChunkLoadTimeInterval));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.TestSettings.NativeFieldInfoPtr_ChunkLoadTimeInterval)) = value;
      }
    }

    public unsafe float SampleTimeInterval
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.TestSettings.NativeFieldInfoPtr_SampleTimeInterval));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.TestSettings.NativeFieldInfoPtr_SampleTimeInterval)) = value;
      }
    }

    public unsafe float AvoidSyncSpikeTimeInterval
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.TestSettings.NativeFieldInfoPtr_AvoidSyncSpikeTimeInterval));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.TestSettings.NativeFieldInfoPtr_AvoidSyncSpikeTimeInterval)) = value;
      }
    }

    public unsafe int XJumpsPerChunk
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.TestSettings.NativeFieldInfoPtr_XJumpsPerChunk));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.TestSettings.NativeFieldInfoPtr_XJumpsPerChunk)) = value;
      }
    }

    public unsafe int YJumpsPerChunk
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.TestSettings.NativeFieldInfoPtr_YJumpsPerChunk));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.TestSettings.NativeFieldInfoPtr_YJumpsPerChunk)) = value;
      }
    }
  }

  public class ChunkData : HeatMapBinaryUtility.HeatMapFileHeader
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_Samples;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2Int_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSample_Public_Void_SampleData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_BinaryWriter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Boolean_BinaryReader_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 915643, RefRangeEnd = 915644, XrefRangeStart = 915635, XrefRangeEnd = 915643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.ChunkData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTestBehaviour.ChunkData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 915652, RefRangeEnd = 915653, XrefRangeStart = 915644, XrefRangeEnd = 915652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkData(Vector2Int id)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.ChunkData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &id;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTestBehaviour.ChunkData.NativeMethodInfoPtr__ctor_Public_Void_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 915657, RefRangeEnd = 915658, XrefRangeStart = 915653, XrefRangeEnd = 915657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddSample(ChunkPerformanceTestBehaviour.SampleData sample)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sample);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTestBehaviour.ChunkData.NativeMethodInfoPtr_AddSample_Public_Void_SampleData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915658, XrefRangeEnd = 915673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Write(BinaryWriter bw)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bw);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChunkPerformanceTestBehaviour.ChunkData.NativeMethodInfoPtr_Write_Public_Virtual_Void_BinaryWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915673, XrefRangeEnd = 915687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool Read(BinaryReader br)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) br);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChunkPerformanceTestBehaviour.ChunkData.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_BinaryReader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ChunkData()
    {
      Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.ChunkData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (ChunkData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.ChunkData>.NativeClassPtr);
      ChunkPerformanceTestBehaviour.ChunkData.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.ChunkData>.NativeClassPtr, nameof (ID));
      ChunkPerformanceTestBehaviour.ChunkData.NativeFieldInfoPtr_Samples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.ChunkData>.NativeClassPtr, nameof (Samples));
      ChunkPerformanceTestBehaviour.ChunkData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.ChunkData>.NativeClassPtr, 100663613);
      ChunkPerformanceTestBehaviour.ChunkData.NativeMethodInfoPtr__ctor_Public_Void_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.ChunkData>.NativeClassPtr, 100663614);
      ChunkPerformanceTestBehaviour.ChunkData.NativeMethodInfoPtr_AddSample_Public_Void_SampleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.ChunkData>.NativeClassPtr, 100663615);
      ChunkPerformanceTestBehaviour.ChunkData.NativeMethodInfoPtr_Write_Public_Virtual_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.ChunkData>.NativeClassPtr, 100663616);
      ChunkPerformanceTestBehaviour.ChunkData.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.ChunkData>.NativeClassPtr, 100663617);
    }

    public ChunkData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Vector2Int ID
    {
      get
      {
        return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.ChunkData.NativeFieldInfoPtr_ID));
      }
      [param: In] set
      {
        *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.ChunkData.NativeFieldInfoPtr_ID)) = value;
      }
    }

    public unsafe List<ChunkPerformanceTestBehaviour.SampleData> Samples
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.ChunkData.NativeFieldInfoPtr_Samples));
        return pointer == System.IntPtr.Zero ? (List<ChunkPerformanceTestBehaviour.SampleData>) null : new List<ChunkPerformanceTestBehaviour.SampleData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.ChunkData.NativeFieldInfoPtr_Samples), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct SampleSnapshotData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NumActiveHybridModels;
    private static readonly System.IntPtr NativeFieldInfoPtr_NumActiveVFXs;
    private static readonly System.IntPtr NativeFieldInfoPtr_NumDrawCalls;
    private static readonly System.IntPtr NativeFieldInfoPtr_NumTriangles;
    private static readonly System.IntPtr NativeFieldInfoPtr_UsedSystemMemoryMB;
    private static readonly System.IntPtr NativeFieldInfoPtr_NumShadowCasters;
    private static readonly System.IntPtr NativeFieldInfoPtr_NumLights;
    private static readonly System.IntPtr NativeMethodInfoPtr_InvalidData_Public_Static_SampleSnapshotData_0;
    [FieldOffset(0)]
    public int NumActiveHybridModels;
    [FieldOffset(4)]
    public int NumActiveVFXs;
    [FieldOffset(8)]
    public int NumDrawCalls;
    [FieldOffset(12)]
    public int NumTriangles;
    [FieldOffset(16)]
    public int UsedSystemMemoryMB;
    [FieldOffset(20)]
    public int NumShadowCasters;
    [FieldOffset(24)]
    public int NumLights;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 915687, RefRangeEnd = 915689, XrefRangeStart = 915687, XrefRangeEnd = 915687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ChunkPerformanceTestBehaviour.SampleSnapshotData InvalidData()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTestBehaviour.SampleSnapshotData.NativeMethodInfoPtr_InvalidData_Public_Static_SampleSnapshotData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ChunkPerformanceTestBehaviour.SampleSnapshotData*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SampleSnapshotData()
    {
      Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleSnapshotData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (SampleSnapshotData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleSnapshotData>.NativeClassPtr);
      ChunkPerformanceTestBehaviour.SampleSnapshotData.NativeFieldInfoPtr_NumActiveHybridModels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleSnapshotData>.NativeClassPtr, nameof (NumActiveHybridModels));
      ChunkPerformanceTestBehaviour.SampleSnapshotData.NativeFieldInfoPtr_NumActiveVFXs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleSnapshotData>.NativeClassPtr, nameof (NumActiveVFXs));
      ChunkPerformanceTestBehaviour.SampleSnapshotData.NativeFieldInfoPtr_NumDrawCalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleSnapshotData>.NativeClassPtr, nameof (NumDrawCalls));
      ChunkPerformanceTestBehaviour.SampleSnapshotData.NativeFieldInfoPtr_NumTriangles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleSnapshotData>.NativeClassPtr, nameof (NumTriangles));
      ChunkPerformanceTestBehaviour.SampleSnapshotData.NativeFieldInfoPtr_UsedSystemMemoryMB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleSnapshotData>.NativeClassPtr, nameof (UsedSystemMemoryMB));
      ChunkPerformanceTestBehaviour.SampleSnapshotData.NativeFieldInfoPtr_NumShadowCasters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleSnapshotData>.NativeClassPtr, nameof (NumShadowCasters));
      ChunkPerformanceTestBehaviour.SampleSnapshotData.NativeFieldInfoPtr_NumLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleSnapshotData>.NativeClassPtr, nameof (NumLights));
      ChunkPerformanceTestBehaviour.SampleSnapshotData.NativeMethodInfoPtr_InvalidData_Public_Static_SampleSnapshotData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleSnapshotData>.NativeClassPtr, 100663618);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleSnapshotData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  public class SampleData : HeatMapBinaryUtility.HeatMapFileHeader
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_SamplePosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_FPS;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Frames;
    private static readonly System.IntPtr NativeFieldInfoPtr_MiscData;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2Int_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSampleData_Public_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FinishSample_Public_Void_SampleSnapshotData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalcFPS_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLog_Public_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_BinaryWriter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Boolean_BinaryReader_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SampleData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTestBehaviour.SampleData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 915690, RefRangeEnd = 915691, XrefRangeStart = 915689, XrefRangeEnd = 915690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SampleData(Vector2Int id, Vector2 position)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTestBehaviour.SampleData.NativeMethodInfoPtr__ctor_Public_Void_Vector2Int_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 915691, RefRangeEnd = 915692, XrefRangeStart = 915691, XrefRangeEnd = 915691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddSampleData(float deltaTime)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &deltaTime;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTestBehaviour.SampleData.NativeMethodInfoPtr_AddSampleData_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 915692, RefRangeEnd = 915693, XrefRangeStart = 915692, XrefRangeEnd = 915692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FinishSample(
      ChunkPerformanceTestBehaviour.SampleSnapshotData miscData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &miscData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTestBehaviour.SampleData.NativeMethodInfoPtr_FinishSample_Public_Void_SampleSnapshotData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void CalcFPS()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTestBehaviour.SampleData.NativeMethodInfoPtr_CalcFPS_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 915762, RefRangeEnd = 915763, XrefRangeStart = 915693, XrefRangeEnd = 915762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetLog()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ChunkPerformanceTestBehaviour.SampleData.NativeMethodInfoPtr_GetLog_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915763, XrefRangeEnd = 915764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Write(BinaryWriter bw)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bw);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChunkPerformanceTestBehaviour.SampleData.NativeMethodInfoPtr_Write_Public_Virtual_Void_BinaryWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915764, XrefRangeEnd = 915767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool Read(BinaryReader br)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) br);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChunkPerformanceTestBehaviour.SampleData.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_BinaryReader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SampleData()
    {
      Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour>.NativeClassPtr, nameof (SampleData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleData>.NativeClassPtr);
      ChunkPerformanceTestBehaviour.SampleData.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleData>.NativeClassPtr, nameof (ID));
      ChunkPerformanceTestBehaviour.SampleData.NativeFieldInfoPtr_SamplePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleData>.NativeClassPtr, nameof (SamplePosition));
      ChunkPerformanceTestBehaviour.SampleData.NativeFieldInfoPtr_FPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleData>.NativeClassPtr, nameof (FPS));
      ChunkPerformanceTestBehaviour.SampleData.NativeFieldInfoPtr_FrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleData>.NativeClassPtr, nameof (FrameTime));
      ChunkPerformanceTestBehaviour.SampleData.NativeFieldInfoPtr_Frames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleData>.NativeClassPtr, nameof (Frames));
      ChunkPerformanceTestBehaviour.SampleData.NativeFieldInfoPtr_MiscData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleData>.NativeClassPtr, nameof (MiscData));
      ChunkPerformanceTestBehaviour.SampleData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleData>.NativeClassPtr, 100663619);
      ChunkPerformanceTestBehaviour.SampleData.NativeMethodInfoPtr__ctor_Public_Void_Vector2Int_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleData>.NativeClassPtr, 100663620);
      ChunkPerformanceTestBehaviour.SampleData.NativeMethodInfoPtr_AddSampleData_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleData>.NativeClassPtr, 100663621);
      ChunkPerformanceTestBehaviour.SampleData.NativeMethodInfoPtr_FinishSample_Public_Void_SampleSnapshotData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleData>.NativeClassPtr, 100663622);
      ChunkPerformanceTestBehaviour.SampleData.NativeMethodInfoPtr_CalcFPS_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleData>.NativeClassPtr, 100663623);
      ChunkPerformanceTestBehaviour.SampleData.NativeMethodInfoPtr_GetLog_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleData>.NativeClassPtr, 100663624);
      ChunkPerformanceTestBehaviour.SampleData.NativeMethodInfoPtr_Write_Public_Virtual_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleData>.NativeClassPtr, 100663625);
      ChunkPerformanceTestBehaviour.SampleData.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkPerformanceTestBehaviour.SampleData>.NativeClassPtr, 100663626);
    }

    public SampleData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Vector2Int ID
    {
      get
      {
        return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.SampleData.NativeFieldInfoPtr_ID));
      }
      [param: In] set
      {
        *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.SampleData.NativeFieldInfoPtr_ID)) = value;
      }
    }

    public unsafe Vector2 SamplePosition
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.SampleData.NativeFieldInfoPtr_SamplePosition));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.SampleData.NativeFieldInfoPtr_SamplePosition)) = value;
      }
    }

    public unsafe float FPS
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.SampleData.NativeFieldInfoPtr_FPS));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.SampleData.NativeFieldInfoPtr_FPS)) = value;
      }
    }

    public unsafe float FrameTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.SampleData.NativeFieldInfoPtr_FrameTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.SampleData.NativeFieldInfoPtr_FrameTime)) = value;
      }
    }

    public unsafe int Frames
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.SampleData.NativeFieldInfoPtr_Frames));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.SampleData.NativeFieldInfoPtr_Frames)) = value;
      }
    }

    public unsafe ChunkPerformanceTestBehaviour.SampleSnapshotData MiscData
    {
      get
      {
        return *(ChunkPerformanceTestBehaviour.SampleSnapshotData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.SampleData.NativeFieldInfoPtr_MiscData));
      }
      [param: In] set
      {
        *(ChunkPerformanceTestBehaviour.SampleSnapshotData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkPerformanceTestBehaviour.SampleData.NativeFieldInfoPtr_MiscData)) = value;
      }
    }
  }

  public enum TestPhase
  {
    InitTest,
    InitChunk,
    LetChunkLoad,
    StartSample,
    AvoidSpikes,
    WaitForSample,
    ProcessSample,
    EndChunk,
    EndTest,
  }
}
