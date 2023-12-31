// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.NetworkSync
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Shared;
using ProjectM.Terrain;
using Stunlock.Localization;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM.Network
{
  public static class NetworkSync : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PREFAB_GUID_BYTE_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_NETWORKED_ALIVE_VALUE;
    private static readonly System.IntPtr NativeFieldInfoPtr_NETWORK_ID_AND_PREFABGUID_SIZE_IN_BITS;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRelativeOptimizedPos;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxTransformIndexCountPerChunk;
    private static readonly System.IntPtr NativeFieldInfoPtr_UsefulSpellModSetCountBits;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteNetworkId_Public_Static_Void_byref_NetBufferOut_NetworkId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadNetworkId_Public_Static_NetworkId_byref_NetBufferIn_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteRangedFloat_Public_Static_Void_byref_NetBufferOut_Single_Single_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadRangedFloat_Public_Static_Single_byref_NetBufferIn_Single_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteDirection2D_Public_Static_Void_byref_NetBufferOut_byref_float2_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadDirection2D_Public_Static_float2_byref_NetBufferIn_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteQuaternion2D_Public_Static_Void_byref_NetBufferOut_byref_quaternion_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadQuaternion2D_Public_Static_quaternion_byref_NetBufferIn_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteTerrainChunk_Public_Static_Void_byref_NetBufferOut_TerrainChunk_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteTerrainChunkUnclamped_Public_Static_Void_byref_NetBufferOut_TerrainChunk_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadTerrainChunk_Public_Static_TerrainChunk_byref_NetBufferIn_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteChunkSceneId_Public_Static_Void_byref_NetBufferOut_ChunkSceneId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteChunkSceneIdUnclamped_Public_Static_Void_byref_NetBufferOut_ChunkSceneId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadChunkSceneId_Public_Static_ChunkSceneId_byref_NetBufferIn_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteRelativeTerrainChunk_Public_Static_Void_byref_NetBufferOut_TerrainChunk_TerrainChunk_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteRelativeChunkSceneId_Public_Static_Void_byref_NetBufferOut_ChunkSceneId_TerrainChunk_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadRelativeTerrainChunk_Public_Static_TerrainChunk_byref_NetBufferIn_TerrainChunk_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadRelativeChunkSceneId_Public_Static_ChunkSceneId_byref_NetBufferIn_TerrainChunk_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadRelativePos_Private_Static_TerrainChunk_byref_NetBufferIn_TerrainChunk_RelativeOptimizedPos_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteRelativeStaticTransformIndex_Public_Static_Void_byref_NetBufferOut_byref_StaticTransformIndex_TerrainChunk_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadRelativeStaticTransformIndex_Public_Static_StaticTransformIndex_byref_NetBufferIn_TerrainChunk_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteStaticTransformIndex_Public_Static_Void_byref_NetBufferOut_byref_StaticTransformIndex_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadStaticTransformIndex_Public_Static_StaticTransformIndex_byref_NetBufferIn_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteBitsUpTo64_Public_Static_Void_byref_NetBufferOut_byref_NativeBitArray_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteBits_Public_Static_Void_byref_NetBufferOut_byref_NativeBitArray_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadBitsUpTo64_Public_Static_Void_byref_NetBufferIn_byref_NativeBitArray_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadBits_Public_Static_Void_byref_NetBufferIn_byref_NativeBitArray_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteAssetGuid_Public_Static_Void_byref_NetBufferOut_AssetGuid_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadAssetGuid_Public_Static_AssetGuid_byref_NetBufferIn_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteLocalizationKey_Public_Static_Void_byref_NetBufferOut_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadLocalizationKey_Public_Static_LocalizationKey_byref_NetBufferIn_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteColor32_Public_Static_Void_byref_NetBufferOut_Color32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadColor32_Public_Static_Color32_byref_NetBufferIn_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteHalf_Public_Static_Void_byref_NetBufferOut_half_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadHalf_Public_Static_half_byref_NetBufferIn_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteMapZoneId_Public_Static_Void_byref_NetBufferOut_MapZoneId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadMapZoneId_Public_Static_MapZoneId_byref_NetBufferIn_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteSpellModSet_Public_Static_Void_byref_NetBufferOut_byref_SerializeEntityParams_byref_SpellModSet_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadSpellModSet_Public_Static_Void_byref_NetBufferIn_byref_DeserializeEntityParams_byref_SpellModSet_0;

    [CallerCount(950)]
    [CachedScanResults(RefRangeStart = 780625, RefRangeEnd = 781575, XrefRangeStart = 780623, XrefRangeEnd = 780625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteNetworkId(ref NetBufferOut netBuffer, NetworkId networkId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &networkId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_WriteNetworkId_Public_Static_Void_byref_NetBufferOut_NetworkId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(952)]
    [CachedScanResults(RefRangeStart = 781577, RefRangeEnd = 782529, XrefRangeStart = 781575, XrefRangeEnd = 781577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NetworkId ReadNetworkId(ref NetBufferIn netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_ReadNetworkId_Public_Static_NetworkId_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NetworkId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(558)]
    [CachedScanResults(RefRangeStart = 782533, RefRangeEnd = 783091, XrefRangeStart = 782529, XrefRangeEnd = 782533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteRangedFloat(
      ref NetBufferOut netBuffer,
      float value,
      float min,
      float max,
      int decimals)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &min;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &max;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &decimals;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_WriteRangedFloat_Public_Static_Void_byref_NetBufferOut_Single_Single_Single_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(558)]
    [CachedScanResults(RefRangeStart = 783091, RefRangeEnd = 783649, XrefRangeStart = 783091, XrefRangeEnd = 783091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float ReadRangedFloat(
      ref NetBufferIn netBuffer,
      float min,
      float max,
      int decimals)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &min;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &max;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &decimals;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_ReadRangedFloat_Public_Static_Single_byref_NetBufferIn_Single_Single_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(120)]
    [CachedScanResults(RefRangeStart = 783681, RefRangeEnd = 783801, XrefRangeStart = 783649, XrefRangeEnd = 783681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteDirection2D(
      ref NetBufferOut netBuffer,
      [In] ref float2 direction,
      int numOfBits = 12,
      bool canBeZero = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref direction;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &numOfBits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &canBeZero;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_WriteDirection2D_Public_Static_Void_byref_NetBufferOut_byref_float2_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(120)]
    [CachedScanResults(RefRangeStart = 783802, RefRangeEnd = 783922, XrefRangeStart = 783801, XrefRangeEnd = 783802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float2 ReadDirection2D(
      ref NetBufferIn netBuffer,
      int numOfBits = 12,
      bool canBeZero = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &numOfBits;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &canBeZero;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_ReadDirection2D_Public_Static_float2_byref_NetBufferIn_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(49)]
    [CachedScanResults(RefRangeStart = 783946, RefRangeEnd = 783995, XrefRangeStart = 783922, XrefRangeEnd = 783946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteQuaternion2D(
      ref NetBufferOut netBuffer,
      [In] ref quaternion rotation,
      int numOfBits = 12)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &numOfBits;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_WriteQuaternion2D_Public_Static_Void_byref_NetBufferOut_byref_quaternion_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(49)]
    [CachedScanResults(RefRangeStart = 784008, RefRangeEnd = 784057, XrefRangeStart = 783995, XrefRangeEnd = 784008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe quaternion ReadQuaternion2D(ref NetBufferIn netBuffer, int numOfBits = 12)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &numOfBits;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_ReadQuaternion2D_Public_Static_quaternion_byref_NetBufferIn_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(quaternion*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784057, XrefRangeEnd = 784058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteTerrainChunk(ref NetBufferOut netBuffer, TerrainChunk chunk)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunk;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_WriteTerrainChunk_Public_Static_Void_byref_NetBufferOut_TerrainChunk_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784058, XrefRangeEnd = 784060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteTerrainChunkUnclamped(
      ref NetBufferOut netBuffer,
      TerrainChunk chunk)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunk;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_WriteTerrainChunkUnclamped_Public_Static_Void_byref_NetBufferOut_TerrainChunk_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 784061, RefRangeEnd = 784064, XrefRangeStart = 784060, XrefRangeEnd = 784061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TerrainChunk ReadTerrainChunk(ref NetBufferIn netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_ReadTerrainChunk_Public_Static_TerrainChunk_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TerrainChunk*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784064, XrefRangeEnd = 784068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteChunkSceneId(
      ref NetBufferOut netBuffer,
      ChunkSceneId chunkSceneId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkSceneId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_WriteChunkSceneId_Public_Static_Void_byref_NetBufferOut_ChunkSceneId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784068, XrefRangeEnd = 784073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteChunkSceneIdUnclamped(
      ref NetBufferOut netBuffer,
      ChunkSceneId chunkSceneId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkSceneId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_WriteChunkSceneIdUnclamped_Public_Static_Void_byref_NetBufferOut_ChunkSceneId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784073, XrefRangeEnd = 784077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ChunkSceneId ReadChunkSceneId(ref NetBufferIn netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_ReadChunkSceneId_Public_Static_ChunkSceneId_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ChunkSceneId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784077, XrefRangeEnd = 784080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteRelativeTerrainChunk(
      ref NetBufferOut netBuffer,
      TerrainChunk chunk,
      TerrainChunk relativeToChunk)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &relativeToChunk;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_WriteRelativeTerrainChunk_Public_Static_Void_byref_NetBufferOut_TerrainChunk_TerrainChunk_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 784086, RefRangeEnd = 784087, XrefRangeStart = 784080, XrefRangeEnd = 784086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteRelativeChunkSceneId(
      ref NetBufferOut netBuffer,
      ChunkSceneId chunk,
      TerrainChunk relativeToChunk)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &relativeToChunk;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_WriteRelativeChunkSceneId_Public_Static_Void_byref_NetBufferOut_ChunkSceneId_TerrainChunk_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784087, XrefRangeEnd = 784092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TerrainChunk ReadRelativeTerrainChunk(
      ref NetBufferIn netBuffer,
      TerrainChunk relativeToChunk)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &relativeToChunk;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_ReadRelativeTerrainChunk_Public_Static_TerrainChunk_byref_NetBufferIn_TerrainChunk_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TerrainChunk*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784092, XrefRangeEnd = 784097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ChunkSceneId ReadRelativeChunkSceneId(
      ref NetBufferIn netBuffer,
      TerrainChunk relativeToChunk)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &relativeToChunk;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_ReadRelativeChunkSceneId_Public_Static_ChunkSceneId_byref_NetBufferIn_TerrainChunk_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ChunkSceneId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 784121, RefRangeEnd = 784124, XrefRangeStart = 784097, XrefRangeEnd = 784121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TerrainChunk ReadRelativePos(
      ref NetBufferIn netBuffer,
      TerrainChunk relativeToChunk,
      NetworkSync.RelativeOptimizedPos relativeOptimizedPos)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &relativeToChunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &relativeOptimizedPos;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_ReadRelativePos_Private_Static_TerrainChunk_byref_NetBufferIn_TerrainChunk_RelativeOptimizedPos_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TerrainChunk*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(93)]
    [CachedScanResults(RefRangeStart = 784139, RefRangeEnd = 784232, XrefRangeStart = 784124, XrefRangeEnd = 784139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteRelativeStaticTransformIndex(
      ref NetBufferOut netBuffer,
      [In] ref StaticTransformIndex staticTransformIndex,
      TerrainChunk relativeToChunk)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref staticTransformIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &relativeToChunk;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_WriteRelativeStaticTransformIndex_Public_Static_Void_byref_NetBufferOut_byref_StaticTransformIndex_TerrainChunk_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(93)]
    [CachedScanResults(RefRangeStart = 784241, RefRangeEnd = 784334, XrefRangeStart = 784232, XrefRangeEnd = 784241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe StaticTransformIndex ReadRelativeStaticTransformIndex(
      ref NetBufferIn netBuffer,
      TerrainChunk relativeToChunk)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &relativeToChunk;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_ReadRelativeStaticTransformIndex_Public_Static_StaticTransformIndex_byref_NetBufferIn_TerrainChunk_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(StaticTransformIndex*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784334, XrefRangeEnd = 784353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteStaticTransformIndex(
      ref NetBufferOut netBuffer,
      [In] ref StaticTransformIndex staticTransformIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref staticTransformIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_WriteStaticTransformIndex_Public_Static_Void_byref_NetBufferOut_byref_StaticTransformIndex_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784353, XrefRangeEnd = 784362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe StaticTransformIndex ReadStaticTransformIndex(ref NetBufferIn netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_ReadStaticTransformIndex_Public_Static_StaticTransformIndex_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(StaticTransformIndex*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784362, XrefRangeEnd = 784364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteBitsUpTo64(
      ref NetBufferOut netBuffer,
      [In] ref NativeBitArray bitArray,
      int srcStartIndex,
      int bitCount)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref bitArray;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &srcStartIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &bitCount;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_WriteBitsUpTo64_Public_Static_Void_byref_NetBufferOut_byref_NativeBitArray_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 784366, RefRangeEnd = 784367, XrefRangeStart = 784364, XrefRangeEnd = 784366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteBits(
      ref NetBufferOut netBuffer,
      [In] ref NativeBitArray bitArray,
      int srcStartIndex,
      int bitCount)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref bitArray;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &srcStartIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &bitCount;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_WriteBits_Public_Static_Void_byref_NetBufferOut_byref_NativeBitArray_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(315)]
    [CachedScanResults(RefRangeStart = 784369, RefRangeEnd = 784684, XrefRangeStart = 784367, XrefRangeEnd = 784369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ReadBitsUpTo64(
      ref NetBufferIn netBuffer,
      ref NativeBitArray bitArray,
      int destStartIndex,
      int bitCount)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref bitArray;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &destStartIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &bitCount;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_ReadBitsUpTo64_Public_Static_Void_byref_NetBufferIn_byref_NativeBitArray_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 784686, RefRangeEnd = 784687, XrefRangeStart = 784684, XrefRangeEnd = 784686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ReadBits(
      ref NetBufferIn netBuffer,
      ref NativeBitArray bitArray,
      int destStartIndex,
      int bitCount)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref bitArray;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &destStartIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &bitCount;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_ReadBits_Public_Static_Void_byref_NetBufferIn_byref_NativeBitArray_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784687, XrefRangeEnd = 784691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteAssetGuid(ref NetBufferOut netBuffer, AssetGuid assetGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &assetGuid;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_WriteAssetGuid_Public_Static_Void_byref_NetBufferOut_AssetGuid_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784691, XrefRangeEnd = 784695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe AssetGuid ReadAssetGuid(ref NetBufferIn netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_ReadAssetGuid_Public_Static_AssetGuid_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AssetGuid*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 784704, RefRangeEnd = 784707, XrefRangeStart = 784695, XrefRangeEnd = 784704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteLocalizationKey(
      ref NetBufferOut netBuffer,
      LocalizationKey localizationKey)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &localizationKey;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_WriteLocalizationKey_Public_Static_Void_byref_NetBufferOut_LocalizationKey_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 784709, RefRangeEnd = 784712, XrefRangeStart = 784707, XrefRangeEnd = 784709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe LocalizationKey ReadLocalizationKey(ref NetBufferIn netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_ReadLocalizationKey_Public_Static_LocalizationKey_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 784716, RefRangeEnd = 784718, XrefRangeStart = 784712, XrefRangeEnd = 784716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteColor32(ref NetBufferOut netBuffer, Color32 color)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_WriteColor32_Public_Static_Void_byref_NetBufferOut_Color32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 758461, RefRangeEnd = 758467, XrefRangeStart = 758461, XrefRangeEnd = 758467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Color32 ReadColor32(ref NetBufferIn netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_ReadColor32_Public_Static_Color32_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Color32*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(56)]
    [CachedScanResults(RefRangeStart = 784719, RefRangeEnd = 784775, XrefRangeStart = 784718, XrefRangeEnd = 784719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteHalf(ref NetBufferOut netBuffer, half half)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &half;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_WriteHalf_Public_Static_Void_byref_NetBufferOut_half_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(57)]
    [CachedScanResults(RefRangeStart = 784776, RefRangeEnd = 784833, XrefRangeStart = 784775, XrefRangeEnd = 784776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe half ReadHalf(ref NetBufferIn netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_ReadHalf_Public_Static_half_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(half*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 784838, RefRangeEnd = 784842, XrefRangeStart = 784833, XrefRangeEnd = 784838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteMapZoneId(ref NetBufferOut netBuffer, MapZoneId zoneId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &zoneId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_WriteMapZoneId_Public_Static_Void_byref_NetBufferOut_MapZoneId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 784847, RefRangeEnd = 784851, XrefRangeStart = 784842, XrefRangeEnd = 784847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe MapZoneId ReadMapZoneId(ref NetBufferIn netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_ReadMapZoneId_Public_Static_MapZoneId_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(MapZoneId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 784865, RefRangeEnd = 784880, XrefRangeStart = 784851, XrefRangeEnd = 784865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void WriteSpellModSet(
      ref NetBufferOut netBuffer,
      ref SerializeEntityParams data,
      [In] ref SpellModSet spellModSet)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref spellModSet;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_WriteSpellModSet_Public_Static_Void_byref_NetBufferOut_byref_SerializeEntityParams_byref_SpellModSet_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 784899, RefRangeEnd = 784914, XrefRangeStart = 784880, XrefRangeEnd = 784899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ReadSpellModSet(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data,
      ref SpellModSet spellModSet)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref spellModSet;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkSync.NativeMethodInfoPtr_ReadSpellModSet_Public_Static_Void_byref_NetBufferIn_byref_DeserializeEntityParams_byref_SpellModSet_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NetworkSync()
    {
      Il2CppClassPointerStore<NetworkSync>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (NetworkSync));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr);
      NetworkSync.NativeFieldInfoPtr_PREFAB_GUID_BYTE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, nameof (PREFAB_GUID_BYTE_SIZE));
      NetworkSync.NativeFieldInfoPtr_MAX_NETWORKED_ALIVE_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, nameof (MAX_NETWORKED_ALIVE_VALUE));
      NetworkSync.NativeFieldInfoPtr_NETWORK_ID_AND_PREFABGUID_SIZE_IN_BITS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, nameof (NETWORK_ID_AND_PREFABGUID_SIZE_IN_BITS));
      NetworkSync.NativeFieldInfoPtr_MaxRelativeOptimizedPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, nameof (MaxRelativeOptimizedPos));
      NetworkSync.NativeFieldInfoPtr_MaxTransformIndexCountPerChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, nameof (MaxTransformIndexCountPerChunk));
      NetworkSync.NativeFieldInfoPtr_UsefulSpellModSetCountBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, nameof (UsefulSpellModSetCountBits));
      NetworkSync.NativeMethodInfoPtr_WriteNetworkId_Public_Static_Void_byref_NetBufferOut_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669122);
      NetworkSync.NativeMethodInfoPtr_ReadNetworkId_Public_Static_NetworkId_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669123);
      NetworkSync.NativeMethodInfoPtr_WriteRangedFloat_Public_Static_Void_byref_NetBufferOut_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669124);
      NetworkSync.NativeMethodInfoPtr_ReadRangedFloat_Public_Static_Single_byref_NetBufferIn_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669125);
      NetworkSync.NativeMethodInfoPtr_WriteDirection2D_Public_Static_Void_byref_NetBufferOut_byref_float2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669126);
      NetworkSync.NativeMethodInfoPtr_ReadDirection2D_Public_Static_float2_byref_NetBufferIn_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669127);
      NetworkSync.NativeMethodInfoPtr_WriteQuaternion2D_Public_Static_Void_byref_NetBufferOut_byref_quaternion_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669128);
      NetworkSync.NativeMethodInfoPtr_ReadQuaternion2D_Public_Static_quaternion_byref_NetBufferIn_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669129);
      NetworkSync.NativeMethodInfoPtr_WriteTerrainChunk_Public_Static_Void_byref_NetBufferOut_TerrainChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669130);
      NetworkSync.NativeMethodInfoPtr_WriteTerrainChunkUnclamped_Public_Static_Void_byref_NetBufferOut_TerrainChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669131);
      NetworkSync.NativeMethodInfoPtr_ReadTerrainChunk_Public_Static_TerrainChunk_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669132);
      NetworkSync.NativeMethodInfoPtr_WriteChunkSceneId_Public_Static_Void_byref_NetBufferOut_ChunkSceneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669133);
      NetworkSync.NativeMethodInfoPtr_WriteChunkSceneIdUnclamped_Public_Static_Void_byref_NetBufferOut_ChunkSceneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669134);
      NetworkSync.NativeMethodInfoPtr_ReadChunkSceneId_Public_Static_ChunkSceneId_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669135);
      NetworkSync.NativeMethodInfoPtr_WriteRelativeTerrainChunk_Public_Static_Void_byref_NetBufferOut_TerrainChunk_TerrainChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669136);
      NetworkSync.NativeMethodInfoPtr_WriteRelativeChunkSceneId_Public_Static_Void_byref_NetBufferOut_ChunkSceneId_TerrainChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669137);
      NetworkSync.NativeMethodInfoPtr_ReadRelativeTerrainChunk_Public_Static_TerrainChunk_byref_NetBufferIn_TerrainChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669138);
      NetworkSync.NativeMethodInfoPtr_ReadRelativeChunkSceneId_Public_Static_ChunkSceneId_byref_NetBufferIn_TerrainChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669139);
      NetworkSync.NativeMethodInfoPtr_ReadRelativePos_Private_Static_TerrainChunk_byref_NetBufferIn_TerrainChunk_RelativeOptimizedPos_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669140);
      NetworkSync.NativeMethodInfoPtr_WriteRelativeStaticTransformIndex_Public_Static_Void_byref_NetBufferOut_byref_StaticTransformIndex_TerrainChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669141);
      NetworkSync.NativeMethodInfoPtr_ReadRelativeStaticTransformIndex_Public_Static_StaticTransformIndex_byref_NetBufferIn_TerrainChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669142);
      NetworkSync.NativeMethodInfoPtr_WriteStaticTransformIndex_Public_Static_Void_byref_NetBufferOut_byref_StaticTransformIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669143);
      NetworkSync.NativeMethodInfoPtr_ReadStaticTransformIndex_Public_Static_StaticTransformIndex_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669144);
      NetworkSync.NativeMethodInfoPtr_WriteBitsUpTo64_Public_Static_Void_byref_NetBufferOut_byref_NativeBitArray_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669145);
      NetworkSync.NativeMethodInfoPtr_WriteBits_Public_Static_Void_byref_NetBufferOut_byref_NativeBitArray_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669146);
      NetworkSync.NativeMethodInfoPtr_ReadBitsUpTo64_Public_Static_Void_byref_NetBufferIn_byref_NativeBitArray_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669147);
      NetworkSync.NativeMethodInfoPtr_ReadBits_Public_Static_Void_byref_NetBufferIn_byref_NativeBitArray_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669148);
      NetworkSync.NativeMethodInfoPtr_WriteAssetGuid_Public_Static_Void_byref_NetBufferOut_AssetGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669149);
      NetworkSync.NativeMethodInfoPtr_ReadAssetGuid_Public_Static_AssetGuid_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669150);
      NetworkSync.NativeMethodInfoPtr_WriteLocalizationKey_Public_Static_Void_byref_NetBufferOut_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669151);
      NetworkSync.NativeMethodInfoPtr_ReadLocalizationKey_Public_Static_LocalizationKey_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669152);
      NetworkSync.NativeMethodInfoPtr_WriteColor32_Public_Static_Void_byref_NetBufferOut_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669153);
      NetworkSync.NativeMethodInfoPtr_ReadColor32_Public_Static_Color32_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669154);
      NetworkSync.NativeMethodInfoPtr_WriteHalf_Public_Static_Void_byref_NetBufferOut_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669155);
      NetworkSync.NativeMethodInfoPtr_ReadHalf_Public_Static_half_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669156);
      NetworkSync.NativeMethodInfoPtr_WriteMapZoneId_Public_Static_Void_byref_NetBufferOut_MapZoneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669157);
      NetworkSync.NativeMethodInfoPtr_ReadMapZoneId_Public_Static_MapZoneId_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669158);
      NetworkSync.NativeMethodInfoPtr_WriteSpellModSet_Public_Static_Void_byref_NetBufferOut_byref_SerializeEntityParams_byref_SpellModSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669159);
      NetworkSync.NativeMethodInfoPtr_ReadSpellModSet_Public_Static_Void_byref_NetBufferIn_byref_DeserializeEntityParams_byref_SpellModSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSync>.NativeClassPtr, 100669160);
    }

    public NetworkSync(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int PREFAB_GUID_BYTE_SIZE
    {
      get
      {
        int prefabGuidByteSize;
        IL2CPP.il2cpp_field_static_get_value(NetworkSync.NativeFieldInfoPtr_PREFAB_GUID_BYTE_SIZE, (void*) &prefabGuidByteSize);
        return prefabGuidByteSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkSync.NativeFieldInfoPtr_PREFAB_GUID_BYTE_SIZE, (void*) &value);
      }
    }

    public static unsafe int MAX_NETWORKED_ALIVE_VALUE
    {
      get
      {
        int networkedAliveValue;
        IL2CPP.il2cpp_field_static_get_value(NetworkSync.NativeFieldInfoPtr_MAX_NETWORKED_ALIVE_VALUE, (void*) &networkedAliveValue);
        return networkedAliveValue;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkSync.NativeFieldInfoPtr_MAX_NETWORKED_ALIVE_VALUE, (void*) &value);
      }
    }

    public static unsafe int NETWORK_ID_AND_PREFABGUID_SIZE_IN_BITS
    {
      get
      {
        int prefabguidSizeInBits;
        IL2CPP.il2cpp_field_static_get_value(NetworkSync.NativeFieldInfoPtr_NETWORK_ID_AND_PREFABGUID_SIZE_IN_BITS, (void*) &prefabguidSizeInBits);
        return prefabguidSizeInBits;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkSync.NativeFieldInfoPtr_NETWORK_ID_AND_PREFABGUID_SIZE_IN_BITS, (void*) &value);
      }
    }

    public static unsafe int MaxRelativeOptimizedPos
    {
      get
      {
        int relativeOptimizedPos;
        IL2CPP.il2cpp_field_static_get_value(NetworkSync.NativeFieldInfoPtr_MaxRelativeOptimizedPos, (void*) &relativeOptimizedPos);
        return relativeOptimizedPos;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkSync.NativeFieldInfoPtr_MaxRelativeOptimizedPos, (void*) &value);
      }
    }

    public static unsafe int MaxTransformIndexCountPerChunk
    {
      get
      {
        int indexCountPerChunk;
        IL2CPP.il2cpp_field_static_get_value(NetworkSync.NativeFieldInfoPtr_MaxTransformIndexCountPerChunk, (void*) &indexCountPerChunk);
        return indexCountPerChunk;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkSync.NativeFieldInfoPtr_MaxTransformIndexCountPerChunk, (void*) &value);
      }
    }

    public static unsafe int UsefulSpellModSetCountBits
    {
      get
      {
        int spellModSetCountBits;
        IL2CPP.il2cpp_field_static_get_value(NetworkSync.NativeFieldInfoPtr_UsefulSpellModSetCountBits, (void*) &spellModSetCountBits);
        return spellModSetCountBits;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetworkSync.NativeFieldInfoPtr_UsefulSpellModSetCountBits, (void*) &value);
      }
    }

    public enum RelativeOptimizedPos : byte
    {
      Diff_N1_N1,
      Diff_00_N1,
      Diff_P1_N1,
      Diff_N1_00,
      Diff_00_00,
      Diff_P1_00,
      Diff_N1_P1,
      Diff_00_P1,
      Diff_P1_P1,
      FullPos,
    }
  }
}
