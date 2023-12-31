// Decompiled with JetBrains decompiler
// Type: ArchetypeChunkUtilities
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Collections;
using Unity.Entities;

#nullable disable
public static class ArchetypeChunkUtilities : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_DumpChunkFragmentation_Public_Static_Void_EntityManager_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AnalyzeChunkFragmentation_Public_Static_Void_EntityManager_Boolean_Boolean_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateWastedChunksInArchetype_Private_Static_Void_EntityManager_NativeList_1_ArchetypeChunk_NativeList_1_Int32_Boolean_Boolean_byref_Int32_byref_Int32_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 715810, RefRangeEnd = 715811, XrefRangeStart = 715809, XrefRangeEnd = 715810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DumpChunkFragmentation(EntityManager entityManager, bool extraDebugging)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &entityManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &extraDebugging;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ArchetypeChunkUtilities.NativeMethodInfoPtr_DumpChunkFragmentation_Public_Static_Void_EntityManager_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 715883, RefRangeEnd = 715885, XrefRangeStart = 715811, XrefRangeEnd = 715883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AnalyzeChunkFragmentation(
    EntityManager entityManager,
    bool logResult,
    bool extraDebugging,
    out int totalArchetypes,
    out int totalWastedChunks,
    out int totalChunks,
    out int chunksWithShared)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &entityManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &logResult;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &extraDebugging;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref totalArchetypes;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref totalWastedChunks;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref totalChunks;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref chunksWithShared;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ArchetypeChunkUtilities.NativeMethodInfoPtr_AnalyzeChunkFragmentation_Public_Static_Void_EntityManager_Boolean_Boolean_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 715989, RefRangeEnd = 715991, XrefRangeStart = 715885, XrefRangeEnd = 715989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CalculateWastedChunksInArchetype(
    EntityManager entityManager,
    NativeList<ArchetypeChunk> chunksInArchetype,
    NativeList<int> sameChunks,
    bool logResult,
    bool extraDebugging,
    out int wastedChunks,
    out int sharedChunks)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &entityManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunksInArchetype;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sameChunks;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &logResult;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &extraDebugging;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref wastedChunks;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref sharedChunks;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ArchetypeChunkUtilities.NativeMethodInfoPtr_CalculateWastedChunksInArchetype_Private_Static_Void_EntityManager_NativeList_1_ArchetypeChunk_NativeList_1_Int32_Boolean_Boolean_byref_Int32_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ArchetypeChunkUtilities()
  {
    Il2CppClassPointerStore<ArchetypeChunkUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (ArchetypeChunkUtilities));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeChunkUtilities>.NativeClassPtr);
    ArchetypeChunkUtilities.NativeMethodInfoPtr_DumpChunkFragmentation_Public_Static_Void_EntityManager_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeChunkUtilities>.NativeClassPtr, 100663422);
    ArchetypeChunkUtilities.NativeMethodInfoPtr_AnalyzeChunkFragmentation_Public_Static_Void_EntityManager_Boolean_Boolean_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeChunkUtilities>.NativeClassPtr, 100663423);
    ArchetypeChunkUtilities.NativeMethodInfoPtr_CalculateWastedChunksInArchetype_Private_Static_Void_EntityManager_NativeList_1_ArchetypeChunk_NativeList_1_Int32_Boolean_Boolean_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeChunkUtilities>.NativeClassPtr, 100663424);
  }

  public ArchetypeChunkUtilities(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
