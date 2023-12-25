// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.CastleTerritoryAuthoringUtilities
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM.Terrain
{
  public static class CastleTerritoryAuthoringUtilities : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TransformTerritory_Public_Static_Void_byref_TerritoryData_TerrainChunk_OrthogonalRotation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateSizeBytes_Public_Static_Int32_TerrainTileMapData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeTerrain_Public_Static_NetBufferOut_TerrainTileMapData_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeArray_Public_Static_Il2CppStructArray_1_TerritoryData_byref_NetBufferIn_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeTerritory_Public_Static_Void_byref_NetBufferOut_TerritoryData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeTerritory_Public_Static_TerritoryData_byref_NetBufferIn_Allocator_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124478, XrefRangeEnd = 1124485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TransformTerritory(
      ref CastleTerritoryAuthoringUtilities.TerritoryData territoryData,
      TerrainChunk terrainChunk,
      OrthogonalRotation rotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref territoryData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &terrainChunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleTerritoryAuthoringUtilities.NativeMethodInfoPtr_TransformTerritory_Public_Static_Void_byref_TerritoryData_TerrainChunk_OrthogonalRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124485, XrefRangeEnd = 1124490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int CalculateSizeBytes(TerrainTileMapData tileMapData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tileMapData);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleTerritoryAuthoringUtilities.NativeMethodInfoPtr_CalculateSizeBytes_Public_Static_Int32_TerrainTileMapData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1124506, RefRangeEnd = 1124508, XrefRangeStart = 1124490, XrefRangeEnd = 1124506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NetBufferOut SerializeTerrain(
      TerrainTileMapData tileMapData,
      Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tileMapData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleTerritoryAuthoringUtilities.NativeMethodInfoPtr_SerializeTerrain_Public_Static_NetBufferOut_TerrainTileMapData_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NetBufferOut*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124508, XrefRangeEnd = 1124513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppStructArray<CastleTerritoryAuthoringUtilities.TerritoryData> DeserializeArray(
      ref NetBufferIn netBuffer,
      Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleTerritoryAuthoringUtilities.NativeMethodInfoPtr_DeserializeArray_Public_Static_Il2CppStructArray_1_TerritoryData_byref_NetBufferIn_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<CastleTerritoryAuthoringUtilities.TerritoryData>) null : new Il2CppStructArray<CastleTerritoryAuthoringUtilities.TerritoryData>(nativeObject);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1124567, RefRangeEnd = 1124568, XrefRangeStart = 1124513, XrefRangeEnd = 1124567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SerializeTerritory(
      ref NetBufferOut netBuffer,
      CastleTerritoryAuthoringUtilities.TerritoryData territoryData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &territoryData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleTerritoryAuthoringUtilities.NativeMethodInfoPtr_SerializeTerritory_Public_Static_Void_byref_NetBufferOut_TerritoryData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1124593, RefRangeEnd = 1124594, XrefRangeStart = 1124568, XrefRangeEnd = 1124593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CastleTerritoryAuthoringUtilities.TerritoryData DeserializeTerritory(
      ref NetBufferIn netBuffer,
      Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleTerritoryAuthoringUtilities.NativeMethodInfoPtr_DeserializeTerritory_Public_Static_TerritoryData_byref_NetBufferIn_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleTerritoryAuthoringUtilities.TerritoryData*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CastleTerritoryAuthoringUtilities()
    {
      Il2CppClassPointerStore<CastleTerritoryAuthoringUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Terrain", nameof (CastleTerritoryAuthoringUtilities));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleTerritoryAuthoringUtilities>.NativeClassPtr);
      CastleTerritoryAuthoringUtilities.NativeMethodInfoPtr_TransformTerritory_Public_Static_Void_byref_TerritoryData_TerrainChunk_OrthogonalRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryAuthoringUtilities>.NativeClassPtr, 100689216);
      CastleTerritoryAuthoringUtilities.NativeMethodInfoPtr_CalculateSizeBytes_Public_Static_Int32_TerrainTileMapData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryAuthoringUtilities>.NativeClassPtr, 100689217);
      CastleTerritoryAuthoringUtilities.NativeMethodInfoPtr_SerializeTerrain_Public_Static_NetBufferOut_TerrainTileMapData_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryAuthoringUtilities>.NativeClassPtr, 100689218);
      CastleTerritoryAuthoringUtilities.NativeMethodInfoPtr_DeserializeArray_Public_Static_Il2CppStructArray_1_TerritoryData_byref_NetBufferIn_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryAuthoringUtilities>.NativeClassPtr, 100689219);
      CastleTerritoryAuthoringUtilities.NativeMethodInfoPtr_SerializeTerritory_Public_Static_Void_byref_NetBufferOut_TerritoryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryAuthoringUtilities>.NativeClassPtr, 100689220);
      CastleTerritoryAuthoringUtilities.NativeMethodInfoPtr_DeserializeTerritory_Public_Static_TerritoryData_byref_NetBufferIn_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryAuthoringUtilities>.NativeClassPtr, 100689221);
    }

    public CastleTerritoryAuthoringUtilities(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TerritoryData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Color;
      private static readonly System.IntPtr NativeFieldInfoPtr_Blocks;
      private static readonly System.IntPtr NativeMethodInfoPtr_FromTerritoryAuthoring_Public_Static_TerritoryData_byref_CastleTerritoryDataAuthoring_Allocator_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
      [FieldOffset(0)]
      public Color Color;
      [FieldOffset(16)]
      public NativeArray<int2> Blocks;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1124470, RefRangeEnd = 1124471, XrefRangeStart = 1124462, XrefRangeEnd = 1124470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe CastleTerritoryAuthoringUtilities.TerritoryData FromTerritoryAuthoring(
        [In] ref CastleTerritoryDataAuthoring authoringData,
        Allocator allocator)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) authoringData);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleTerritoryAuthoringUtilities.TerritoryData.NativeMethodInfoPtr_FromTerritoryAuthoring_Public_Static_TerritoryData_byref_CastleTerritoryDataAuthoring_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(CastleTerritoryAuthoringUtilities.TerritoryData*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1124477, RefRangeEnd = 1124478, XrefRangeStart = 1124471, XrefRangeEnd = 1124477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Dispose()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleTerritoryAuthoringUtilities.TerritoryData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TerritoryData()
      {
        Il2CppClassPointerStore<CastleTerritoryAuthoringUtilities.TerritoryData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleTerritoryAuthoringUtilities>.NativeClassPtr, nameof (TerritoryData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleTerritoryAuthoringUtilities.TerritoryData>.NativeClassPtr);
        CastleTerritoryAuthoringUtilities.TerritoryData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryAuthoringUtilities.TerritoryData>.NativeClassPtr, nameof (Color));
        CastleTerritoryAuthoringUtilities.TerritoryData.NativeFieldInfoPtr_Blocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritoryAuthoringUtilities.TerritoryData>.NativeClassPtr, nameof (Blocks));
        CastleTerritoryAuthoringUtilities.TerritoryData.NativeMethodInfoPtr_FromTerritoryAuthoring_Public_Static_TerritoryData_byref_CastleTerritoryDataAuthoring_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryAuthoringUtilities.TerritoryData>.NativeClassPtr, 100689222);
        CastleTerritoryAuthoringUtilities.TerritoryData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritoryAuthoringUtilities.TerritoryData>.NativeClassPtr, 100689223);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleTerritoryAuthoringUtilities.TerritoryData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
