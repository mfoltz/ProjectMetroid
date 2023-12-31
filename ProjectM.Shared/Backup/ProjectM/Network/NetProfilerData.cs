// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.NetProfilerData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct NetProfilerData
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearAsync_Public_JobHandle_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BranchParallelWriter_Public_ParallelWriter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Internal_Void_Int32_byref_NetBufferOut_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartFrame_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndFrame_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartUser_Public_Void_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartUser_Public_Void_Int32_Int32_byref_NetBufferOut_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndUser_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndUser_Public_Void_byref_NetBufferOut_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartEntity_Public_Void_NetworkId_NetworkSnapshotType_Int32_Single_Single_Single_Single_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartEntity_Public_Void_NetworkId_NetworkSnapshotType_Int32_Single_Single_Single_Single_Boolean_byref_NetBufferOut_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndEntity_Public_Void_Int32_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndEntity_Public_Void_byref_NetBufferOut_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartComponent_Public_Void_ComponentTypeId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartComponent_Public_Void_ComponentTypeId_byref_NetBufferOut_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndComponent_Public_Void_Int32_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndComponent_Public_Void_byref_NetBufferOut_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartObject_Public_Void_NetObjectType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartObject_Public_Void_NetObjectType_byref_NetBufferOut_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndObject_Public_Void_Int32_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndObject_Public_Void_byref_NetBufferOut_Boolean_Boolean_0;

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NetProfilerData(Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &allocator;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetProfilerData.NativeMethodInfoPtr__ctor_Public_Void_Allocator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetProfilerData.NativeMethodInfoPtr_Dispose_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe JobHandle ClearAsync(JobHandle dependency)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &dependency;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetProfilerData.NativeMethodInfoPtr_ClearAsync_Public_JobHandle_JobHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(JobHandle*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1858)]
    [CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NetProfilerData.ParallelWriter BranchParallelWriter()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetProfilerData.NativeMethodInfoPtr_BranchParallelWriter_Public_ParallelWriter_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NetProfilerData.ParallelWriter*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779716, XrefRangeEnd = 779721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Serialize(int frameIndex, ref NetBufferOut netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &frameIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetProfilerData.NativeMethodInfoPtr_Serialize_Internal_Void_Int32_byref_NetBufferOut_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779721, XrefRangeEnd = 779726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StartFrame()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetProfilerData.NativeMethodInfoPtr_StartFrame_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779726, XrefRangeEnd = 779731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EndFrame()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetProfilerData.NativeMethodInfoPtr_EndFrame_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779731, XrefRangeEnd = 779736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StartUser(int userIndex, int userGeneration)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &userIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userGeneration;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetProfilerData.NativeMethodInfoPtr_StartUser_Public_Void_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779736, XrefRangeEnd = 779741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StartUser(
      int userIndex,
      int userGeneration,
      [In] ref NetBufferOut netBufferAtStart)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &userIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userGeneration;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBufferAtStart;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetProfilerData.NativeMethodInfoPtr_StartUser_Public_Void_Int32_Int32_byref_NetBufferOut_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779741, XrefRangeEnd = 779746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EndUser(int bitSize)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &bitSize;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetProfilerData.NativeMethodInfoPtr_EndUser_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779746, XrefRangeEnd = 779751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EndUser([In] ref NetBufferOut netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetProfilerData.NativeMethodInfoPtr_EndUser_Public_Void_byref_NetBufferOut_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779751, XrefRangeEnd = 779756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StartEntity(
      NetworkId networkId,
      NetworkSnapshotType snapshotType,
      int prefabHash,
      float priority,
      float panicPriority,
      float syncRate,
      float maxSyncRate,
      bool isPanic)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &networkId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabHash;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &priority;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &panicPriority;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &syncRate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSyncRate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &isPanic;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetProfilerData.NativeMethodInfoPtr_StartEntity_Public_Void_NetworkId_NetworkSnapshotType_Int32_Single_Single_Single_Single_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779756, XrefRangeEnd = 779761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StartEntity(
      NetworkId networkId,
      NetworkSnapshotType snapshotType,
      int prefabHash,
      float priority,
      float panicPriority,
      float syncRate,
      float maxSyncRate,
      bool isPanic,
      [In] ref NetBufferOut netBufferAtStart)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) &networkId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabHash;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &priority;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &panicPriority;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &syncRate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSyncRate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &isPanic;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBufferAtStart;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetProfilerData.NativeMethodInfoPtr_StartEntity_Public_Void_NetworkId_NetworkSnapshotType_Int32_Single_Single_Single_Single_Boolean_byref_NetBufferOut_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779761, XrefRangeEnd = 779766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EndEntity(int bitSize, bool usesSynchronizeBit, bool wasSerialized)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &bitSize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &usesSynchronizeBit;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &wasSerialized;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetProfilerData.NativeMethodInfoPtr_EndEntity_Public_Void_Int32_Boolean_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779766, XrefRangeEnd = 779771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EndEntity(
      [In] ref NetBufferOut netBufferAtEnd,
      bool usesSynchronizeBit,
      bool wasSerialized)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref netBufferAtEnd;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &usesSynchronizeBit;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &wasSerialized;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetProfilerData.NativeMethodInfoPtr_EndEntity_Public_Void_byref_NetBufferOut_Boolean_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779771, XrefRangeEnd = 779776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StartComponent(NetProfilerData.ComponentTypeId componentType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &componentType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetProfilerData.NativeMethodInfoPtr_StartComponent_Public_Void_ComponentTypeId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779776, XrefRangeEnd = 779781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StartComponent(
      NetProfilerData.ComponentTypeId componentType,
      [In] ref NetBufferOut netBufferAtStart)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &componentType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBufferAtStart;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetProfilerData.NativeMethodInfoPtr_StartComponent_Public_Void_ComponentTypeId_byref_NetBufferOut_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779781, XrefRangeEnd = 779786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EndComponent(int bitSize, bool usesSynchronizeBit, bool wasSerialized)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &bitSize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &usesSynchronizeBit;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &wasSerialized;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetProfilerData.NativeMethodInfoPtr_EndComponent_Public_Void_Int32_Boolean_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779786, XrefRangeEnd = 779791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EndComponent(
      [In] ref NetBufferOut netBufferAtEnd,
      bool usesSynchronizeBit,
      bool wasSerialized)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref netBufferAtEnd;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &usesSynchronizeBit;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &wasSerialized;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetProfilerData.NativeMethodInfoPtr_EndComponent_Public_Void_byref_NetBufferOut_Boolean_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779791, XrefRangeEnd = 779796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StartObject(NetProfilerData.NetObjectType objectType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &objectType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetProfilerData.NativeMethodInfoPtr_StartObject_Public_Void_NetObjectType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779796, XrefRangeEnd = 779801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StartObject(
      NetProfilerData.NetObjectType objectType,
      [In] ref NetBufferOut netBufferAtStart)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &objectType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBufferAtStart;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetProfilerData.NativeMethodInfoPtr_StartObject_Public_Void_NetObjectType_byref_NetBufferOut_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779801, XrefRangeEnd = 779806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EndObject(int bitSize, bool usesSynchronizeBit, bool wasSerialized)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &bitSize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &usesSynchronizeBit;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &wasSerialized;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetProfilerData.NativeMethodInfoPtr_EndObject_Public_Void_Int32_Boolean_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779806, XrefRangeEnd = 779811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EndObject(
      [In] ref NetBufferOut netBufferAtEnd,
      bool usesSynchronizeBit,
      bool wasSerialized)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref netBufferAtEnd;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &usesSynchronizeBit;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &wasSerialized;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetProfilerData.NativeMethodInfoPtr_EndObject_Public_Void_byref_NetBufferOut_Boolean_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NetProfilerData()
    {
      Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (NetProfilerData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr);
      NetProfilerData.NativeMethodInfoPtr__ctor_Public_Void_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, 100669049);
      NetProfilerData.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, 100669050);
      NetProfilerData.NativeMethodInfoPtr_ClearAsync_Public_JobHandle_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, 100669051);
      NetProfilerData.NativeMethodInfoPtr_BranchParallelWriter_Public_ParallelWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, 100669052);
      NetProfilerData.NativeMethodInfoPtr_Serialize_Internal_Void_Int32_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, 100669053);
      NetProfilerData.NativeMethodInfoPtr_StartFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, 100669054);
      NetProfilerData.NativeMethodInfoPtr_EndFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, 100669055);
      NetProfilerData.NativeMethodInfoPtr_StartUser_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, 100669056);
      NetProfilerData.NativeMethodInfoPtr_StartUser_Public_Void_Int32_Int32_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, 100669057);
      NetProfilerData.NativeMethodInfoPtr_EndUser_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, 100669058);
      NetProfilerData.NativeMethodInfoPtr_EndUser_Public_Void_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, 100669059);
      NetProfilerData.NativeMethodInfoPtr_StartEntity_Public_Void_NetworkId_NetworkSnapshotType_Int32_Single_Single_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, 100669060);
      NetProfilerData.NativeMethodInfoPtr_StartEntity_Public_Void_NetworkId_NetworkSnapshotType_Int32_Single_Single_Single_Single_Boolean_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, 100669061);
      NetProfilerData.NativeMethodInfoPtr_EndEntity_Public_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, 100669062);
      NetProfilerData.NativeMethodInfoPtr_EndEntity_Public_Void_byref_NetBufferOut_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, 100669063);
      NetProfilerData.NativeMethodInfoPtr_StartComponent_Public_Void_ComponentTypeId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, 100669064);
      NetProfilerData.NativeMethodInfoPtr_StartComponent_Public_Void_ComponentTypeId_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, 100669065);
      NetProfilerData.NativeMethodInfoPtr_EndComponent_Public_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, 100669066);
      NetProfilerData.NativeMethodInfoPtr_EndComponent_Public_Void_byref_NetBufferOut_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, 100669067);
      NetProfilerData.NativeMethodInfoPtr_StartObject_Public_Void_NetObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, 100669068);
      NetProfilerData.NativeMethodInfoPtr_StartObject_Public_Void_NetObjectType_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, 100669069);
      NetProfilerData.NativeMethodInfoPtr_EndObject_Public_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, 100669070);
      NetProfilerData.NativeMethodInfoPtr_EndObject_Public_Void_byref_NetBufferOut_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, 100669071);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ParallelWriter
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_StartJobWriter_Public_ParallelJobWriter_Allocator_0;

      [CallerCount(1858)]
      [CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe NetProfilerData.ParallelJobWriter StartJobWriter(Allocator allocator)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &allocator;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetProfilerData.ParallelWriter.NativeMethodInfoPtr_StartJobWriter_Public_ParallelJobWriter_Allocator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NetProfilerData.ParallelJobWriter*) IL2CPP.il2cpp_object_unbox(num);
      }

      static ParallelWriter()
      {
        Il2CppClassPointerStore<NetProfilerData.ParallelWriter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, nameof (ParallelWriter));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetProfilerData.ParallelWriter>.NativeClassPtr);
        NetProfilerData.ParallelWriter.NativeMethodInfoPtr_StartJobWriter_Public_ParallelJobWriter_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData.ParallelWriter>.NativeClassPtr, 100669072);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetProfilerData.ParallelWriter>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ParallelJobWriter
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_StartUser_Public_Void_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_StartUser_Public_Void_Int32_Int32_byref_NetBufferOut_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndUser_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndUser_Public_Void_byref_NetBufferOut_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_StartEntity_Public_Void_NetworkId_NetworkSnapshotType_Int32_Single_Single_Single_Single_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_StartEntity_Public_Void_NetworkId_NetworkSnapshotType_Int32_Single_Single_Single_Single_Boolean_byref_NetBufferOut_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndEntity_Public_Void_Int32_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndEntity_Public_Void_byref_NetBufferOut_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_StartComponent_Public_Void_ComponentTypeId_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_StartComponent_Public_Void_ComponentTypeId_byref_NetBufferOut_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndComponent_Public_Void_Int32_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndComponent_Public_Void_byref_NetBufferOut_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_StartObject_Public_Void_NetObjectType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_StartObject_Public_Void_NetObjectType_byref_NetBufferOut_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndObject_Public_Void_Int32_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndObject_Public_Void_byref_NetBufferOut_Boolean_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndJobWriter_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779631, XrefRangeEnd = 779636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void StartUser(int userIndex, int userGeneration)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &userIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userGeneration;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_StartUser_Public_Void_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779636, XrefRangeEnd = 779641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void StartUser(
        int userIndex,
        int userGeneration,
        [In] ref NetBufferOut netBufferAtStart)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &userIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userGeneration;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBufferAtStart;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_StartUser_Public_Void_Int32_Int32_byref_NetBufferOut_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779641, XrefRangeEnd = 779646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void EndUser(int bitSize)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &bitSize;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_EndUser_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779646, XrefRangeEnd = 779651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void EndUser([In] ref NetBufferOut netBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_EndUser_Public_Void_byref_NetBufferOut_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779651, XrefRangeEnd = 779656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void StartEntity(
        NetworkId networkId,
        NetworkSnapshotType snapshotType,
        int prefabHash,
        float priority,
        float panicPriority,
        float syncRate,
        float maxSyncRate,
        bool isPanic)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[8];
        numPtr[0] = (System.IntPtr) &networkId;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabHash;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &priority;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &panicPriority;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &syncRate;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSyncRate;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &isPanic;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_StartEntity_Public_Void_NetworkId_NetworkSnapshotType_Int32_Single_Single_Single_Single_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779656, XrefRangeEnd = 779661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void StartEntity(
        NetworkId networkId,
        NetworkSnapshotType snapshotType,
        int prefabHash,
        float priority,
        float panicPriority,
        float syncRate,
        float maxSyncRate,
        bool isPanic,
        [In] ref NetBufferOut netBufferAtStart)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[9];
        numPtr[0] = (System.IntPtr) &networkId;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabHash;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &priority;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &panicPriority;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &syncRate;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSyncRate;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &isPanic;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBufferAtStart;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_StartEntity_Public_Void_NetworkId_NetworkSnapshotType_Int32_Single_Single_Single_Single_Boolean_byref_NetBufferOut_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779661, XrefRangeEnd = 779666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void EndEntity(int bitSize, bool usesSynchronizeBit, bool wasSerialized)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &bitSize;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &usesSynchronizeBit;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &wasSerialized;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_EndEntity_Public_Void_Int32_Boolean_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779666, XrefRangeEnd = 779671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void EndEntity(
        [In] ref NetBufferOut netBufferAtEnd,
        bool usesSynchronizeBit,
        bool wasSerialized)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref netBufferAtEnd;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &usesSynchronizeBit;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &wasSerialized;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_EndEntity_Public_Void_byref_NetBufferOut_Boolean_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779671, XrefRangeEnd = 779676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void StartComponent(NetProfilerData.ComponentTypeId componentType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &componentType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_StartComponent_Public_Void_ComponentTypeId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779676, XrefRangeEnd = 779681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void StartComponent(
        NetProfilerData.ComponentTypeId componentType,
        [In] ref NetBufferOut netBufferAtStart)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &componentType;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBufferAtStart;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_StartComponent_Public_Void_ComponentTypeId_byref_NetBufferOut_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779681, XrefRangeEnd = 779686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void EndComponent(int bitSize, bool usesSynchronizeBit, bool wasSerialized)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &bitSize;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &usesSynchronizeBit;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &wasSerialized;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_EndComponent_Public_Void_Int32_Boolean_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779686, XrefRangeEnd = 779691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void EndComponent(
        [In] ref NetBufferOut netBufferAtEnd,
        bool usesSynchronizeBit,
        bool wasSerialized)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref netBufferAtEnd;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &usesSynchronizeBit;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &wasSerialized;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_EndComponent_Public_Void_byref_NetBufferOut_Boolean_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779691, XrefRangeEnd = 779696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void StartObject(NetProfilerData.NetObjectType objectType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &objectType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_StartObject_Public_Void_NetObjectType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779696, XrefRangeEnd = 779701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void StartObject(
        NetProfilerData.NetObjectType objectType,
        [In] ref NetBufferOut netBufferAtStart)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &objectType;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBufferAtStart;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_StartObject_Public_Void_NetObjectType_byref_NetBufferOut_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779701, XrefRangeEnd = 779706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void EndObject(int bitSize, bool usesSynchronizeBit, bool wasSerialized)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &bitSize;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &usesSynchronizeBit;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &wasSerialized;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_EndObject_Public_Void_Int32_Boolean_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779706, XrefRangeEnd = 779711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void EndObject(
        [In] ref NetBufferOut netBufferAtEnd,
        bool usesSynchronizeBit,
        bool wasSerialized)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref netBufferAtEnd;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &usesSynchronizeBit;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &wasSerialized;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_EndObject_Public_Void_byref_NetBufferOut_Boolean_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 779711, XrefRangeEnd = 779716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void EndJobWriter()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_EndJobWriter_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ParallelJobWriter()
      {
        Il2CppClassPointerStore<NetProfilerData.ParallelJobWriter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, nameof (ParallelJobWriter));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetProfilerData.ParallelJobWriter>.NativeClassPtr);
        NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_StartUser_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData.ParallelJobWriter>.NativeClassPtr, 100669073);
        NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_StartUser_Public_Void_Int32_Int32_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData.ParallelJobWriter>.NativeClassPtr, 100669074);
        NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_EndUser_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData.ParallelJobWriter>.NativeClassPtr, 100669075);
        NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_EndUser_Public_Void_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData.ParallelJobWriter>.NativeClassPtr, 100669076);
        NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_StartEntity_Public_Void_NetworkId_NetworkSnapshotType_Int32_Single_Single_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData.ParallelJobWriter>.NativeClassPtr, 100669077);
        NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_StartEntity_Public_Void_NetworkId_NetworkSnapshotType_Int32_Single_Single_Single_Single_Boolean_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData.ParallelJobWriter>.NativeClassPtr, 100669078);
        NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_EndEntity_Public_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData.ParallelJobWriter>.NativeClassPtr, 100669079);
        NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_EndEntity_Public_Void_byref_NetBufferOut_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData.ParallelJobWriter>.NativeClassPtr, 100669080);
        NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_StartComponent_Public_Void_ComponentTypeId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData.ParallelJobWriter>.NativeClassPtr, 100669081);
        NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_StartComponent_Public_Void_ComponentTypeId_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData.ParallelJobWriter>.NativeClassPtr, 100669082);
        NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_EndComponent_Public_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData.ParallelJobWriter>.NativeClassPtr, 100669083);
        NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_EndComponent_Public_Void_byref_NetBufferOut_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData.ParallelJobWriter>.NativeClassPtr, 100669084);
        NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_StartObject_Public_Void_NetObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData.ParallelJobWriter>.NativeClassPtr, 100669085);
        NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_StartObject_Public_Void_NetObjectType_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData.ParallelJobWriter>.NativeClassPtr, 100669086);
        NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_EndObject_Public_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData.ParallelJobWriter>.NativeClassPtr, 100669087);
        NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_EndObject_Public_Void_byref_NetBufferOut_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData.ParallelJobWriter>.NativeClassPtr, 100669088);
        NetProfilerData.ParallelJobWriter.NativeMethodInfoPtr_EndJobWriter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData.ParallelJobWriter>.NativeClassPtr, 100669089);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetProfilerData.ParallelJobWriter>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public enum NetObjectType
    {
      Unspecified,
      HeaderData,
      GameStateMessage,
      DestroyedEntityIds,
      HardReffedEnititesWithoutSnapshot,
      DestroyedEntities,
      LivingEntities,
      ComponentSyncBits,
      ComponentFieldSyncBits,
      NetworkId,
      BitsSerialized,
      EntityHeader,
      PrefabGuid,
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ComponentTypeId
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ComponentTypeIndex;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComponentType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ComponentTypeId_Int32_0;
      [FieldOffset(0)]
      public int ComponentTypeIndex;

      [CallerCount(20)]
      [CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ComponentTypeId(ComponentType componentType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &componentType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetProfilerData.ComponentTypeId.NativeMethodInfoPtr__ctor_Public_Void_ComponentType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(20)]
      [CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ComponentTypeId(int componentTypeIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &componentTypeIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetProfilerData.ComponentTypeId.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(504)]
      [CachedScanResults(RefRangeStart = 279526, RefRangeEnd = 280030, XrefRangeStart = 279526, XrefRangeEnd = 280030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe implicit operator NetProfilerData.ComponentTypeId(int id)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &id;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetProfilerData.ComponentTypeId.NativeMethodInfoPtr_op_Implicit_Public_Static_ComponentTypeId_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NetProfilerData.ComponentTypeId*) IL2CPP.il2cpp_object_unbox(num);
      }

      static ComponentTypeId()
      {
        Il2CppClassPointerStore<NetProfilerData.ComponentTypeId>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetProfilerData>.NativeClassPtr, nameof (ComponentTypeId));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetProfilerData.ComponentTypeId>.NativeClassPtr);
        NetProfilerData.ComponentTypeId.NativeFieldInfoPtr_ComponentTypeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetProfilerData.ComponentTypeId>.NativeClassPtr, nameof (ComponentTypeIndex));
        NetProfilerData.ComponentTypeId.NativeMethodInfoPtr__ctor_Public_Void_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData.ComponentTypeId>.NativeClassPtr, 100669090);
        NetProfilerData.ComponentTypeId.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData.ComponentTypeId>.NativeClassPtr, 100669091);
        NetProfilerData.ComponentTypeId.NativeMethodInfoPtr_op_Implicit_Public_Static_ComponentTypeId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetProfilerData.ComponentTypeId>.NativeClassPtr, 100669092);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetProfilerData.ComponentTypeId>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
