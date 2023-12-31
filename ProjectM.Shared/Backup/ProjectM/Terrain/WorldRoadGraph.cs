// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.WorldRoadGraph
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WorldRoadGraph
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_IsCreated;
    private static readonly System.IntPtr NativeFieldInfoPtr_Blob;
    private static readonly System.IntPtr NativeFieldInfoPtr_BusStops;
    private static readonly System.IntPtr NativeFieldInfoPtr_BusStopNameToNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChunkToNodes;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBusStopPosition_Public_Static_Boolean_WorldRoadGraph_BusStopId_byref_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBusStop_Public_Static_Boolean_WorldRoadGraph_BusStopId_byref_BusStopData_0;
    [FieldOffset(0)]
    public bool IsCreated;
    [FieldOffset(8)]
    public BlobAssetReference<WorldRoadGraphBlob> Blob;
    [FieldOffset(16)]
    public NativeHashMap<BusStopId, int> BusStops;
    [FieldOffset(32)]
    public NativeHashMap<FixedString32, int> BusStopNameToNode;
    [FieldOffset(48)]
    public NativeMultiHashMap<TerrainChunk, int> ChunkToNodes;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768674, XrefRangeEnd = 768686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldRoadGraph.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 768696, RefRangeEnd = 768697, XrefRangeStart = 768686, XrefRangeEnd = 768696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetBusStopPosition(
      WorldRoadGraph worldRoadGraph,
      BusStopId busStopId,
      out float3 worldPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &worldRoadGraph;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &busStopId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref worldPosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldRoadGraph.NativeMethodInfoPtr_TryGetBusStopPosition_Public_Static_Boolean_WorldRoadGraph_BusStopId_byref_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 768707, RefRangeEnd = 768708, XrefRangeStart = 768697, XrefRangeEnd = 768707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetBusStop(
      WorldRoadGraph worldRoadGraph,
      BusStopId busStopId,
      out WorldRoadGraph.BusStopData busStopData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &worldRoadGraph;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &busStopId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref busStopData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldRoadGraph.NativeMethodInfoPtr_TryGetBusStop_Public_Static_Boolean_WorldRoadGraph_BusStopId_byref_BusStopData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static WorldRoadGraph()
    {
      Il2CppClassPointerStore<WorldRoadGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (WorldRoadGraph));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldRoadGraph>.NativeClassPtr);
      WorldRoadGraph.NativeFieldInfoPtr_IsCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraph>.NativeClassPtr, nameof (IsCreated));
      WorldRoadGraph.NativeFieldInfoPtr_Blob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraph>.NativeClassPtr, nameof (Blob));
      WorldRoadGraph.NativeFieldInfoPtr_BusStops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraph>.NativeClassPtr, nameof (BusStops));
      WorldRoadGraph.NativeFieldInfoPtr_BusStopNameToNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraph>.NativeClassPtr, nameof (BusStopNameToNode));
      WorldRoadGraph.NativeFieldInfoPtr_ChunkToNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraph>.NativeClassPtr, nameof (ChunkToNodes));
      WorldRoadGraph.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraph>.NativeClassPtr, 100668005);
      WorldRoadGraph.NativeMethodInfoPtr_TryGetBusStopPosition_Public_Static_Boolean_WorldRoadGraph_BusStopId_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraph>.NativeClassPtr, 100668006);
      WorldRoadGraph.NativeMethodInfoPtr_TryGetBusStop_Public_Static_Boolean_WorldRoadGraph_BusStopId_byref_BusStopData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraph>.NativeClassPtr, 100668007);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorldRoadGraph>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct BusStopData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Position;
      private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_WaitDuration;
      [FieldOffset(0)]
      public float3 Position;
      [FieldOffset(12)]
      public quaternion Rotation;
      [FieldOffset(28)]
      public float WaitDuration;

      static BusStopData()
      {
        Il2CppClassPointerStore<WorldRoadGraph.BusStopData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldRoadGraph>.NativeClassPtr, nameof (BusStopData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldRoadGraph.BusStopData>.NativeClassPtr);
        WorldRoadGraph.BusStopData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraph.BusStopData>.NativeClassPtr, nameof (Position));
        WorldRoadGraph.BusStopData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraph.BusStopData>.NativeClassPtr, nameof (Rotation));
        WorldRoadGraph.BusStopData.NativeFieldInfoPtr_WaitDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraph.BusStopData>.NativeClassPtr, nameof (WaitDuration));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorldRoadGraph.BusStopData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
