// Decompiled with JetBrains decompiler
// Type: ProjectM.UpdateDynamicWorldVFXSpawnQueueJob
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UpdateDynamicWorldVFXSpawnQueueJob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldVFXManagerIndexType;
    private static readonly System.IntPtr NativeFieldInfoPtr_TranslationType;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChunkRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnEventQueue;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReferencedManagers;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalPlayerPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxSpawnRangeSq;
    private static readonly System.IntPtr NativeFieldInfoPtr_ElapsedTime;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DistSq_Private_Single_float3_float3_0;
    [FieldOffset(0)]
    public ComponentTypeHandle<WorldVFXSpawnManagerIndex> WorldVFXManagerIndexType;
    [FieldOffset(32)]
    public ComponentTypeHandle<Translation> TranslationType;
    [FieldOffset(64)]
    public EntityTypeHandle EntityType;
    [FieldOffset(68)]
    public ChunkRange ChunkRange;
    [FieldOffset(80)]
    public NativeList<DynamicWorldVFXSpawnEvent> SpawnEventQueue;
    [FieldOffset(96)]
    public NativeList<int> ReferencedManagers;
    [FieldOffset(112)]
    public float3 LocalPlayerPosition;
    [FieldOffset(124)]
    public float MaxSpawnRangeSq;
    [FieldOffset(128)]
    public float ElapsedTime;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1084816, RefRangeEnd = 1084817, XrefRangeStart = 1084789, XrefRangeEnd = 1084816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &chunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateDynamicWorldVFXSpawnQueueJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1084817, RefRangeEnd = 1084818, XrefRangeStart = 1084817, XrefRangeEnd = 1084817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float DistSq(float3 point1, float3 point2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &point1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &point2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateDynamicWorldVFXSpawnQueueJob.NativeMethodInfoPtr_DistSq_Private_Single_float3_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static UpdateDynamicWorldVFXSpawnQueueJob()
    {
      Il2CppClassPointerStore<UpdateDynamicWorldVFXSpawnQueueJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (UpdateDynamicWorldVFXSpawnQueueJob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateDynamicWorldVFXSpawnQueueJob>.NativeClassPtr);
      UpdateDynamicWorldVFXSpawnQueueJob.NativeFieldInfoPtr_WorldVFXManagerIndexType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDynamicWorldVFXSpawnQueueJob>.NativeClassPtr, nameof (WorldVFXManagerIndexType));
      UpdateDynamicWorldVFXSpawnQueueJob.NativeFieldInfoPtr_TranslationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDynamicWorldVFXSpawnQueueJob>.NativeClassPtr, nameof (TranslationType));
      UpdateDynamicWorldVFXSpawnQueueJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDynamicWorldVFXSpawnQueueJob>.NativeClassPtr, nameof (EntityType));
      UpdateDynamicWorldVFXSpawnQueueJob.NativeFieldInfoPtr_ChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDynamicWorldVFXSpawnQueueJob>.NativeClassPtr, nameof (ChunkRange));
      UpdateDynamicWorldVFXSpawnQueueJob.NativeFieldInfoPtr_SpawnEventQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDynamicWorldVFXSpawnQueueJob>.NativeClassPtr, nameof (SpawnEventQueue));
      UpdateDynamicWorldVFXSpawnQueueJob.NativeFieldInfoPtr_ReferencedManagers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDynamicWorldVFXSpawnQueueJob>.NativeClassPtr, nameof (ReferencedManagers));
      UpdateDynamicWorldVFXSpawnQueueJob.NativeFieldInfoPtr_LocalPlayerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDynamicWorldVFXSpawnQueueJob>.NativeClassPtr, nameof (LocalPlayerPosition));
      UpdateDynamicWorldVFXSpawnQueueJob.NativeFieldInfoPtr_MaxSpawnRangeSq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDynamicWorldVFXSpawnQueueJob>.NativeClassPtr, nameof (MaxSpawnRangeSq));
      UpdateDynamicWorldVFXSpawnQueueJob.NativeFieldInfoPtr_ElapsedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDynamicWorldVFXSpawnQueueJob>.NativeClassPtr, nameof (ElapsedTime));
      UpdateDynamicWorldVFXSpawnQueueJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDynamicWorldVFXSpawnQueueJob>.NativeClassPtr, 100685445);
      UpdateDynamicWorldVFXSpawnQueueJob.NativeMethodInfoPtr_DistSq_Private_Single_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDynamicWorldVFXSpawnQueueJob>.NativeClassPtr, 100685446);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateDynamicWorldVFXSpawnQueueJob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
