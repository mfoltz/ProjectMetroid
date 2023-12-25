// Decompiled with JetBrains decompiler
// Type: ProjectM.PerformanceSummaryElement
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Text;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PerformanceSummaryElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClientFps;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerFps;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkLatency;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkBytesSentPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkBytesReceivedPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkPacketsSentPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkPacketsReceivedPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkMessagesSentPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkMessagesReceivedPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkMessagesMaxBytesSentPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkMessagesMaxBytesReceivedPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_Positions;
    private static readonly System.IntPtr NativeFieldInfoPtr_SoundCpuPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_SoundMemoryPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_HybridModelCountPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_HourOfDay;
    private static readonly System.IntPtr NativeFieldInfoPtr_Memory;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClientEnabledEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClientDisabledEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerEnabledEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDisabledEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArchetypeCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_ElapsedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Time;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCsvHeader_Public_Static_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToCsvRow_Public_String_NativeHashMap_2_TerrainChunk_Entity_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkName_Private_String_float2_NativeHashMap_2_TerrainChunk_Entity_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CsvAppend_Private_Static_Void_StringBuilder_String_0;
    [FieldOffset(0)]
    public PerformanceSummary_FloatAggregates FrameTime;
    [FieldOffset(16)]
    public PerformanceSummary_IntAggregates ClientFps;
    [FieldOffset(32)]
    public PerformanceSummary_IntAggregates ServerFps;
    [FieldOffset(48)]
    public PerformanceSummary_IntAggregates NetworkLatency;
    [FieldOffset(64)]
    public PerformanceSummary_IntAggregates NetworkBytesSentPerSecond;
    [FieldOffset(80)]
    public PerformanceSummary_IntAggregates NetworkBytesReceivedPerSecond;
    [FieldOffset(96)]
    public PerformanceSummary_IntAggregates NetworkPacketsSentPerSecond;
    [FieldOffset(112)]
    public PerformanceSummary_IntAggregates NetworkPacketsReceivedPerSecond;
    [FieldOffset(128)]
    public PerformanceSummary_IntAggregates NetworkMessagesSentPerSecond;
    [FieldOffset(144)]
    public PerformanceSummary_IntAggregates NetworkMessagesReceivedPerSecond;
    [FieldOffset(160)]
    public PerformanceSummary_IntAggregates NetworkMessagesMaxBytesSentPerSecond;
    [FieldOffset(176)]
    public PerformanceSummary_IntAggregates NetworkMessagesMaxBytesReceivedPerSecond;
    [FieldOffset(192)]
    public PerformanceSummary_Positions Positions;
    [FieldOffset(216)]
    public PerformanceSummary_FloatAggregates SoundCpuPerSecond;
    [FieldOffset(232)]
    public PerformanceSummary_IntAggregates SoundMemoryPerSecond;
    [FieldOffset(248)]
    public PerformanceSummary_IntAggregates HybridModelCountPerSecond;
    [FieldOffset(264)]
    public int HourOfDay;
    [FieldOffset(268)]
    public int Memory;
    [FieldOffset(272)]
    public int ClientEnabledEntities;
    [FieldOffset(276)]
    public int ClientDisabledEntities;
    [FieldOffset(280)]
    public int ServerEnabledEntities;
    [FieldOffset(284)]
    public int ServerDisabledEntities;
    [FieldOffset(288)]
    public int ArchetypeCount;
    [FieldOffset(292)]
    public float ElapsedTime;
    [FieldOffset(296)]
    public Il2CppSystem.DateTime Time;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1054767, RefRangeEnd = 1054768, XrefRangeStart = 1054625, XrefRangeEnd = 1054767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PerformanceSummaryElement.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1054944, RefRangeEnd = 1054945, XrefRangeStart = 1054768, XrefRangeEnd = 1054944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetCsvHeader()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PerformanceSummaryElement.NativeMethodInfoPtr_GetCsvHeader_Public_Static_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1055136, RefRangeEnd = 1055137, XrefRangeStart = 1054945, XrefRangeEnd = 1055136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string ToCsvRow(
      NativeHashMap<TerrainChunk, Entity> chunkMetadatas,
      EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &chunkMetadatas;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PerformanceSummaryElement.NativeMethodInfoPtr_ToCsvRow_Public_String_NativeHashMap_2_TerrainChunk_Entity_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1055146, RefRangeEnd = 1055149, XrefRangeStart = 1055137, XrefRangeEnd = 1055146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetChunkName(
      float2 pos,
      NativeHashMap<TerrainChunk, Entity> chunkMetadatas,
      EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkMetadatas;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PerformanceSummaryElement.NativeMethodInfoPtr_GetChunkName_Private_String_float2_NativeHashMap_2_TerrainChunk_Entity_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055149, XrefRangeEnd = 1055154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CsvAppend(StringBuilder builder, string s)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) builder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(s);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PerformanceSummaryElement.NativeMethodInfoPtr_CsvAppend_Private_Static_Void_StringBuilder_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PerformanceSummaryElement()
    {
      Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PerformanceSummaryElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr);
      PerformanceSummaryElement.NativeFieldInfoPtr_FrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (FrameTime));
      PerformanceSummaryElement.NativeFieldInfoPtr_ClientFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (ClientFps));
      PerformanceSummaryElement.NativeFieldInfoPtr_ServerFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (ServerFps));
      PerformanceSummaryElement.NativeFieldInfoPtr_NetworkLatency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (NetworkLatency));
      PerformanceSummaryElement.NativeFieldInfoPtr_NetworkBytesSentPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (NetworkBytesSentPerSecond));
      PerformanceSummaryElement.NativeFieldInfoPtr_NetworkBytesReceivedPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (NetworkBytesReceivedPerSecond));
      PerformanceSummaryElement.NativeFieldInfoPtr_NetworkPacketsSentPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (NetworkPacketsSentPerSecond));
      PerformanceSummaryElement.NativeFieldInfoPtr_NetworkPacketsReceivedPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (NetworkPacketsReceivedPerSecond));
      PerformanceSummaryElement.NativeFieldInfoPtr_NetworkMessagesSentPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (NetworkMessagesSentPerSecond));
      PerformanceSummaryElement.NativeFieldInfoPtr_NetworkMessagesReceivedPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (NetworkMessagesReceivedPerSecond));
      PerformanceSummaryElement.NativeFieldInfoPtr_NetworkMessagesMaxBytesSentPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (NetworkMessagesMaxBytesSentPerSecond));
      PerformanceSummaryElement.NativeFieldInfoPtr_NetworkMessagesMaxBytesReceivedPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (NetworkMessagesMaxBytesReceivedPerSecond));
      PerformanceSummaryElement.NativeFieldInfoPtr_Positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (Positions));
      PerformanceSummaryElement.NativeFieldInfoPtr_SoundCpuPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (SoundCpuPerSecond));
      PerformanceSummaryElement.NativeFieldInfoPtr_SoundMemoryPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (SoundMemoryPerSecond));
      PerformanceSummaryElement.NativeFieldInfoPtr_HybridModelCountPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (HybridModelCountPerSecond));
      PerformanceSummaryElement.NativeFieldInfoPtr_HourOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (HourOfDay));
      PerformanceSummaryElement.NativeFieldInfoPtr_Memory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (Memory));
      PerformanceSummaryElement.NativeFieldInfoPtr_ClientEnabledEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (ClientEnabledEntities));
      PerformanceSummaryElement.NativeFieldInfoPtr_ClientDisabledEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (ClientDisabledEntities));
      PerformanceSummaryElement.NativeFieldInfoPtr_ServerEnabledEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (ServerEnabledEntities));
      PerformanceSummaryElement.NativeFieldInfoPtr_ServerDisabledEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (ServerDisabledEntities));
      PerformanceSummaryElement.NativeFieldInfoPtr_ArchetypeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (ArchetypeCount));
      PerformanceSummaryElement.NativeFieldInfoPtr_ElapsedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (ElapsedTime));
      PerformanceSummaryElement.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, nameof (Time));
      PerformanceSummaryElement.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, 100682982);
      PerformanceSummaryElement.NativeMethodInfoPtr_GetCsvHeader_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, 100682983);
      PerformanceSummaryElement.NativeMethodInfoPtr_ToCsvRow_Public_String_NativeHashMap_2_TerrainChunk_Entity_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, 100682984);
      PerformanceSummaryElement.NativeMethodInfoPtr_GetChunkName_Private_String_float2_NativeHashMap_2_TerrainChunk_Entity_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, 100682985);
      PerformanceSummaryElement.NativeMethodInfoPtr_CsvAppend_Private_Static_Void_StringBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, 100682986);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PerformanceSummaryElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
