// Decompiled with JetBrains decompiler
// Type: ProjectM.AggroUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Scripting;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  public static class AggroUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Static_Int32_DynamicBuffer_1_AggroBuffer_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddAssumeNew_Public_Static_Int32_DynamicBuffer_1_AggroBuffer_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetIndexOf_Public_Static_Boolean_DynamicBuffer_1_AggroBuffer_Entity_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Static_Boolean_DynamicBuffer_1_AggroBuffer_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ContainsExcludeNonAggroable_Public_Static_Boolean_DynamicBuffer_1_AggroBuffer_Entity_ComponentDataFromEntity_1_Aggroable_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ContainsExcludeNonAggroable_Public_Static_Boolean_DynamicBuffer_1_AggroBuffer_Entity_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Accumulate_Public_Static_Single_DynamicBuffer_1_AlertBuffer_Entity_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Static_Void_DynamicBuffer_1_AlertBuffer_Entity_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Static_Void_DynamicBuffer_1_AlertBuffer_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddAssumeNew_Public_Static_Void_DynamicBuffer_1_AlertBuffer_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Static_Boolean_DynamicBuffer_1_AlertBuffer_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetIfLower_Public_Static_Void_DynamicBuffer_1_AlertBuffer_Entity_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetIfNew_Public_Static_Boolean_DynamicBuffer_1_AlertBuffer_Entity_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Decay_Public_Static_Void_DynamicBuffer_1_AlertBuffer_byref_NativeList_1_Entity_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearAggro_Public_Static_Void_byref_AggroConsumer_DynamicBuffer_1_AggroBuffer_DynamicBuffer_1_AlertBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyAggro_Public_Static_Void_DynamicBuffer_1_AggroBuffer_DynamicBuffer_1_AggroBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyAggro_Public_Static_Void_EntityManager_DynamicBuffer_1_AggroBuffer_DynamicBuffer_1_AggroBuffer_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TooFarFromPreCombatPosition_Public_Static_Boolean_byref_AggroConsumer_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindExternalElementIndex_Public_Static_Boolean_DynamicBuffer_1_ExternalAggroBufferElement_Entity_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CleanupExternalAggroBuffer_Public_Static_Void_DynamicBuffer_1_ExternalAggroBufferElement_byref_ServerGameManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerCount_Public_Static_Byte_EntityManager_Entity_0;

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 763232, RefRangeEnd = 763240, XrefRangeStart = 763217, XrefRangeEnd = 763232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int Add(DynamicBuffer<AggroBuffer> buffer, Entity producer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &producer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroUtility.NativeMethodInfoPtr_Add_Public_Static_Int32_DynamicBuffer_1_AggroBuffer_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 763246, RefRangeEnd = 763248, XrefRangeStart = 763240, XrefRangeEnd = 763246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int AddAssumeNew(DynamicBuffer<AggroBuffer> buffer, Entity producer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &producer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroUtility.NativeMethodInfoPtr_AddAssumeNew_Public_Static_Int32_DynamicBuffer_1_AggroBuffer_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 763257, RefRangeEnd = 763258, XrefRangeStart = 763248, XrefRangeEnd = 763257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetIndexOf(
      DynamicBuffer<AggroBuffer> buffer,
      Entity producer,
      out int result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &producer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroUtility.NativeMethodInfoPtr_TryGetIndexOf_Public_Static_Boolean_DynamicBuffer_1_AggroBuffer_Entity_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 763267, RefRangeEnd = 763271, XrefRangeStart = 763258, XrefRangeEnd = 763267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Contains(DynamicBuffer<AggroBuffer> buffer, Entity producer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &producer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroUtility.NativeMethodInfoPtr_Contains_Public_Static_Boolean_DynamicBuffer_1_AggroBuffer_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763271, XrefRangeEnd = 763283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ContainsExcludeNonAggroable(
      DynamicBuffer<AggroBuffer> buffer,
      Entity producer,
      ComponentDataFromEntity<Aggroable> getAggroable)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &producer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getAggroable;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroUtility.NativeMethodInfoPtr_ContainsExcludeNonAggroable_Public_Static_Boolean_DynamicBuffer_1_AggroBuffer_Entity_ComponentDataFromEntity_1_Aggroable_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 763294, RefRangeEnd = 763295, XrefRangeStart = 763283, XrefRangeEnd = 763294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ContainsExcludeNonAggroable(
      DynamicBuffer<AggroBuffer> buffer,
      Entity producer,
      EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &producer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroUtility.NativeMethodInfoPtr_ContainsExcludeNonAggroable_Public_Static_Boolean_DynamicBuffer_1_AggroBuffer_Entity_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763295, XrefRangeEnd = 763308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float Accumulate(
      DynamicBuffer<AlertBuffer> buffer,
      Entity producer,
      float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &producer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroUtility.NativeMethodInfoPtr_Accumulate_Public_Static_Single_DynamicBuffer_1_AlertBuffer_Entity_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763308, XrefRangeEnd = 763321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Set(DynamicBuffer<AlertBuffer> buffer, Entity producer, float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &producer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AggroUtility.NativeMethodInfoPtr_Set_Public_Static_Void_DynamicBuffer_1_AlertBuffer_Entity_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763321, XrefRangeEnd = 763333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Add(DynamicBuffer<AlertBuffer> buffer, Entity producer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &producer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AggroUtility.NativeMethodInfoPtr_Add_Public_Static_Void_DynamicBuffer_1_AlertBuffer_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 763336, RefRangeEnd = 763337, XrefRangeStart = 763333, XrefRangeEnd = 763336, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddAssumeNew(DynamicBuffer<AlertBuffer> buffer, Entity producer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &producer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AggroUtility.NativeMethodInfoPtr_AddAssumeNew_Public_Static_Void_DynamicBuffer_1_AlertBuffer_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 763346, RefRangeEnd = 763347, XrefRangeStart = 763337, XrefRangeEnd = 763346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Contains(DynamicBuffer<AlertBuffer> buffer, Entity producer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &producer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroUtility.NativeMethodInfoPtr_Contains_Public_Static_Boolean_DynamicBuffer_1_AlertBuffer_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763347, XrefRangeEnd = 763360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetIfLower(
      DynamicBuffer<AlertBuffer> buffer,
      Entity producer,
      float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &producer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AggroUtility.NativeMethodInfoPtr_SetIfLower_Public_Static_Void_DynamicBuffer_1_AlertBuffer_Entity_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763360, XrefRangeEnd = 763373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool SetIfNew(
      DynamicBuffer<AlertBuffer> buffer,
      Entity producer,
      float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &producer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroUtility.NativeMethodInfoPtr_SetIfNew_Public_Static_Boolean_DynamicBuffer_1_AlertBuffer_Entity_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763373, XrefRangeEnd = 763393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Decay(
      DynamicBuffer<AlertBuffer> buffer,
      [In] ref NativeList<Entity> entities,
      float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AggroUtility.NativeMethodInfoPtr_Decay_Public_Static_Void_DynamicBuffer_1_AlertBuffer_byref_NativeList_1_Entity_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 763406, RefRangeEnd = 763409, XrefRangeStart = 763393, XrefRangeEnd = 763406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ClearAggro(
      ref AggroConsumer aggroConsumer,
      DynamicBuffer<AggroBuffer> aggroBuffer,
      DynamicBuffer<AlertBuffer> alertBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref aggroConsumer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aggroBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &alertBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AggroUtility.NativeMethodInfoPtr_ClearAggro_Public_Static_Void_byref_AggroConsumer_DynamicBuffer_1_AggroBuffer_DynamicBuffer_1_AlertBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 763418, RefRangeEnd = 763421, XrefRangeStart = 763409, XrefRangeEnd = 763418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CopyAggro(
      DynamicBuffer<AggroBuffer> fromAggroBuffer,
      DynamicBuffer<AggroBuffer> toAggroBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fromAggroBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &toAggroBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AggroUtility.NativeMethodInfoPtr_CopyAggro_Public_Static_Void_DynamicBuffer_1_AggroBuffer_DynamicBuffer_1_AggroBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 763431, RefRangeEnd = 763432, XrefRangeStart = 763421, XrefRangeEnd = 763431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CopyAggro(
      EntityManager entityManager,
      DynamicBuffer<AggroBuffer> fromAggroBuffer,
      DynamicBuffer<AggroBuffer> toAggroBuffer,
      Entity toEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromAggroBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &toAggroBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &toEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AggroUtility.NativeMethodInfoPtr_CopyAggro_Public_Static_Void_EntityManager_DynamicBuffer_1_AggroBuffer_DynamicBuffer_1_AggroBuffer_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 763432, RefRangeEnd = 763436, XrefRangeStart = 763432, XrefRangeEnd = 763432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TooFarFromPreCombatPosition(
      [In] ref AggroConsumer aggroConsumer,
      float3 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref aggroConsumer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroUtility.NativeMethodInfoPtr_TooFarFromPreCombatPosition_Public_Static_Boolean_byref_AggroConsumer_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 763445, RefRangeEnd = 763447, XrefRangeStart = 763436, XrefRangeEnd = 763445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryFindExternalElementIndex(
      DynamicBuffer<ExternalAggroBufferElement> buffer,
      Entity source,
      out int result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroUtility.NativeMethodInfoPtr_TryFindExternalElementIndex_Public_Static_Boolean_DynamicBuffer_1_ExternalAggroBufferElement_Entity_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 763459, RefRangeEnd = 763461, XrefRangeStart = 763447, XrefRangeEnd = 763459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CleanupExternalAggroBuffer(
      DynamicBuffer<ExternalAggroBufferElement> externalAggroBuffer,
      ref ServerGameManager game)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &externalAggroBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref game;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AggroUtility.NativeMethodInfoPtr_CleanupExternalAggroBuffer_Public_Static_Void_DynamicBuffer_1_ExternalAggroBufferElement_byref_ServerGameManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 763472, RefRangeEnd = 763474, XrefRangeStart = 763461, XrefRangeEnd = 763472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe byte GetPlayerCount(EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AggroUtility.NativeMethodInfoPtr_GetPlayerCount_Public_Static_Byte_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(byte*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AggroUtility()
    {
      Il2CppClassPointerStore<AggroUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AggroUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroUtility>.NativeClassPtr);
      AggroUtility.NativeMethodInfoPtr_Add_Public_Static_Int32_DynamicBuffer_1_AggroBuffer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroUtility>.NativeClassPtr, 100667426);
      AggroUtility.NativeMethodInfoPtr_AddAssumeNew_Public_Static_Int32_DynamicBuffer_1_AggroBuffer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroUtility>.NativeClassPtr, 100667427);
      AggroUtility.NativeMethodInfoPtr_TryGetIndexOf_Public_Static_Boolean_DynamicBuffer_1_AggroBuffer_Entity_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroUtility>.NativeClassPtr, 100667428);
      AggroUtility.NativeMethodInfoPtr_Contains_Public_Static_Boolean_DynamicBuffer_1_AggroBuffer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroUtility>.NativeClassPtr, 100667429);
      AggroUtility.NativeMethodInfoPtr_ContainsExcludeNonAggroable_Public_Static_Boolean_DynamicBuffer_1_AggroBuffer_Entity_ComponentDataFromEntity_1_Aggroable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroUtility>.NativeClassPtr, 100667430);
      AggroUtility.NativeMethodInfoPtr_ContainsExcludeNonAggroable_Public_Static_Boolean_DynamicBuffer_1_AggroBuffer_Entity_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroUtility>.NativeClassPtr, 100667431);
      AggroUtility.NativeMethodInfoPtr_Accumulate_Public_Static_Single_DynamicBuffer_1_AlertBuffer_Entity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroUtility>.NativeClassPtr, 100667432);
      AggroUtility.NativeMethodInfoPtr_Set_Public_Static_Void_DynamicBuffer_1_AlertBuffer_Entity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroUtility>.NativeClassPtr, 100667433);
      AggroUtility.NativeMethodInfoPtr_Add_Public_Static_Void_DynamicBuffer_1_AlertBuffer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroUtility>.NativeClassPtr, 100667434);
      AggroUtility.NativeMethodInfoPtr_AddAssumeNew_Public_Static_Void_DynamicBuffer_1_AlertBuffer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroUtility>.NativeClassPtr, 100667435);
      AggroUtility.NativeMethodInfoPtr_Contains_Public_Static_Boolean_DynamicBuffer_1_AlertBuffer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroUtility>.NativeClassPtr, 100667436);
      AggroUtility.NativeMethodInfoPtr_SetIfLower_Public_Static_Void_DynamicBuffer_1_AlertBuffer_Entity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroUtility>.NativeClassPtr, 100667437);
      AggroUtility.NativeMethodInfoPtr_SetIfNew_Public_Static_Boolean_DynamicBuffer_1_AlertBuffer_Entity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroUtility>.NativeClassPtr, 100667438);
      AggroUtility.NativeMethodInfoPtr_Decay_Public_Static_Void_DynamicBuffer_1_AlertBuffer_byref_NativeList_1_Entity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroUtility>.NativeClassPtr, 100667439);
      AggroUtility.NativeMethodInfoPtr_ClearAggro_Public_Static_Void_byref_AggroConsumer_DynamicBuffer_1_AggroBuffer_DynamicBuffer_1_AlertBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroUtility>.NativeClassPtr, 100667440);
      AggroUtility.NativeMethodInfoPtr_CopyAggro_Public_Static_Void_DynamicBuffer_1_AggroBuffer_DynamicBuffer_1_AggroBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroUtility>.NativeClassPtr, 100667441);
      AggroUtility.NativeMethodInfoPtr_CopyAggro_Public_Static_Void_EntityManager_DynamicBuffer_1_AggroBuffer_DynamicBuffer_1_AggroBuffer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroUtility>.NativeClassPtr, 100667442);
      AggroUtility.NativeMethodInfoPtr_TooFarFromPreCombatPosition_Public_Static_Boolean_byref_AggroConsumer_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroUtility>.NativeClassPtr, 100667443);
      AggroUtility.NativeMethodInfoPtr_TryFindExternalElementIndex_Public_Static_Boolean_DynamicBuffer_1_ExternalAggroBufferElement_Entity_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroUtility>.NativeClassPtr, 100667444);
      AggroUtility.NativeMethodInfoPtr_CleanupExternalAggroBuffer_Public_Static_Void_DynamicBuffer_1_ExternalAggroBufferElement_byref_ServerGameManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroUtility>.NativeClassPtr, 100667445);
      AggroUtility.NativeMethodInfoPtr_GetPlayerCount_Public_Static_Byte_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroUtility>.NativeClassPtr, 100667446);
    }

    public AggroUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
