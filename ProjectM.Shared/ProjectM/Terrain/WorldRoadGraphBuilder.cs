// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.WorldRoadGraphBuilder
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WorldRoadGraphBuilder
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildWorldRoadGraph_Public_Static_WorldRoadGraph_NativeArray_1_ChunkRoadGraphInput_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateEdgeNodeKeys_Public_Static_Void_TerrainChunk_OrthogonalRotation_ChunkEdgeNodeId_byref_WorldRoadGraph_EdgeNodeKey_byref_WorldRoadGraph_EdgeNodeKey_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 768883, RefRangeEnd = 768885, XrefRangeStart = 768739, XrefRangeEnd = 768883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe WorldRoadGraph BuildWorldRoadGraph(
      NativeArray<WorldRoadGraphBuilder.ChunkRoadGraphInput> chunkGraphs,
      Allocator tempAllocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &chunkGraphs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tempAllocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphBuilder.NativeMethodInfoPtr_BuildWorldRoadGraph_Public_Static_WorldRoadGraph_NativeArray_1_ChunkRoadGraphInput_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(WorldRoadGraph*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 768890, RefRangeEnd = 768891, XrefRangeStart = 768885, XrefRangeEnd = 768890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CalculateEdgeNodeKeys(
      TerrainChunk chunkCoordinate,
      OrthogonalRotation chunkRotation,
      ChunkEdgeNodeId edgeNodeId,
      out WorldRoadGraph_EdgeNodeKey selfEdgeNodeKey,
      out WorldRoadGraph_EdgeNodeKey neighbourEdgeNodeKey)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &chunkCoordinate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkRotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &edgeNodeId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref selfEdgeNodeKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref neighbourEdgeNodeKey;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphBuilder.NativeMethodInfoPtr_CalculateEdgeNodeKeys_Public_Static_Void_TerrainChunk_OrthogonalRotation_ChunkEdgeNodeId_byref_WorldRoadGraph_EdgeNodeKey_byref_WorldRoadGraph_EdgeNodeKey_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WorldRoadGraphBuilder()
    {
      Il2CppClassPointerStore<WorldRoadGraphBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (WorldRoadGraphBuilder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldRoadGraphBuilder>.NativeClassPtr);
      WorldRoadGraphBuilder.NativeMethodInfoPtr_BuildWorldRoadGraph_Public_Static_WorldRoadGraph_NativeArray_1_ChunkRoadGraphInput_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphBuilder>.NativeClassPtr, 100668011);
      WorldRoadGraphBuilder.NativeMethodInfoPtr_CalculateEdgeNodeKeys_Public_Static_Void_TerrainChunk_OrthogonalRotation_ChunkEdgeNodeId_byref_WorldRoadGraph_EdgeNodeKey_byref_WorldRoadGraph_EdgeNodeKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphBuilder>.NativeClassPtr, 100668012);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorldRoadGraphBuilder>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ChunkRoadGraphInput
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Chunk;
      private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkGraph;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TerrainChunk_OrthogonalRotation_ChunkRoadGraph_0;
      [FieldOffset(0)]
      public TerrainChunk Chunk;
      [FieldOffset(8)]
      public OrthogonalRotation Rotation;
      [FieldOffset(16)]
      public ChunkRoadGraph ChunkGraph;

      [CallerCount(0)]
      public unsafe ChunkRoadGraphInput(
        TerrainChunk chunk,
        OrthogonalRotation rotation,
        ChunkRoadGraph chunkGraph)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkGraph;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphBuilder.ChunkRoadGraphInput.NativeMethodInfoPtr__ctor_Public_Void_TerrainChunk_OrthogonalRotation_ChunkRoadGraph_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ChunkRoadGraphInput()
      {
        Il2CppClassPointerStore<WorldRoadGraphBuilder.ChunkRoadGraphInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldRoadGraphBuilder>.NativeClassPtr, nameof (ChunkRoadGraphInput));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldRoadGraphBuilder.ChunkRoadGraphInput>.NativeClassPtr);
        WorldRoadGraphBuilder.ChunkRoadGraphInput.NativeFieldInfoPtr_Chunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBuilder.ChunkRoadGraphInput>.NativeClassPtr, nameof (Chunk));
        WorldRoadGraphBuilder.ChunkRoadGraphInput.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBuilder.ChunkRoadGraphInput>.NativeClassPtr, nameof (Rotation));
        WorldRoadGraphBuilder.ChunkRoadGraphInput.NativeFieldInfoPtr_ChunkGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBuilder.ChunkRoadGraphInput>.NativeClassPtr, nameof (ChunkGraph));
        WorldRoadGraphBuilder.ChunkRoadGraphInput.NativeMethodInfoPtr__ctor_Public_Void_TerrainChunk_OrthogonalRotation_ChunkRoadGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphBuilder.ChunkRoadGraphInput>.NativeClassPtr, 100668013);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorldRoadGraphBuilder.ChunkRoadGraphInput>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct BuilderData_Node
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_WorldPos;
      private static readonly System.IntPtr NativeFieldInfoPtr_NodeRoadType;
      private static readonly System.IntPtr NativeFieldInfoPtr_NeighbourStartIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_NeighbourCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_PatrolWaitDuration;
      private static readonly System.IntPtr NativeFieldInfoPtr_Chunk;
      [FieldOffset(0)]
      public float3 WorldPos;
      [FieldOffset(12)]
      public RoadType NodeRoadType;
      [FieldOffset(16)]
      public int NeighbourStartIndex;
      [FieldOffset(20)]
      public int NeighbourCount;
      [FieldOffset(24)]
      public quaternion Rotation;
      [FieldOffset(40)]
      public float PatrolWaitDuration;
      [FieldOffset(44)]
      public TerrainChunk Chunk;

      static BuilderData_Node()
      {
        Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData_Node>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldRoadGraphBuilder>.NativeClassPtr, nameof (BuilderData_Node));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData_Node>.NativeClassPtr);
        WorldRoadGraphBuilder.BuilderData_Node.NativeFieldInfoPtr_WorldPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData_Node>.NativeClassPtr, nameof (WorldPos));
        WorldRoadGraphBuilder.BuilderData_Node.NativeFieldInfoPtr_NodeRoadType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData_Node>.NativeClassPtr, nameof (NodeRoadType));
        WorldRoadGraphBuilder.BuilderData_Node.NativeFieldInfoPtr_NeighbourStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData_Node>.NativeClassPtr, nameof (NeighbourStartIndex));
        WorldRoadGraphBuilder.BuilderData_Node.NativeFieldInfoPtr_NeighbourCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData_Node>.NativeClassPtr, nameof (NeighbourCount));
        WorldRoadGraphBuilder.BuilderData_Node.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData_Node>.NativeClassPtr, nameof (Rotation));
        WorldRoadGraphBuilder.BuilderData_Node.NativeFieldInfoPtr_PatrolWaitDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData_Node>.NativeClassPtr, nameof (PatrolWaitDuration));
        WorldRoadGraphBuilder.BuilderData_Node.NativeFieldInfoPtr_Chunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData_Node>.NativeClassPtr, nameof (Chunk));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData_Node>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct BuilderData_BusStop
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Id;
      private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_NodeName;
      [FieldOffset(0)]
      public BusStopId Id;
      [FieldOffset(24)]
      public int NodeIndex;
      [FieldOffset(28)]
      public FixedString32 NodeName;

      static BuilderData_BusStop()
      {
        Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData_BusStop>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldRoadGraphBuilder>.NativeClassPtr, nameof (BuilderData_BusStop));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData_BusStop>.NativeClassPtr);
        WorldRoadGraphBuilder.BuilderData_BusStop.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData_BusStop>.NativeClassPtr, nameof (Id));
        WorldRoadGraphBuilder.BuilderData_BusStop.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData_BusStop>.NativeClassPtr, nameof (NodeIndex));
        WorldRoadGraphBuilder.BuilderData_BusStop.NativeFieldInfoPtr_NodeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData_BusStop>.NativeClassPtr, nameof (NodeName));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData_BusStop>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct BuilderData_EdgeNode
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
      private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
      [FieldOffset(0)]
      public AssetGuid Guid;
      [FieldOffset(16)]
      public int NodeIndex;

      static BuilderData_EdgeNode()
      {
        Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData_EdgeNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldRoadGraphBuilder>.NativeClassPtr, nameof (BuilderData_EdgeNode));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData_EdgeNode>.NativeClassPtr);
        WorldRoadGraphBuilder.BuilderData_EdgeNode.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData_EdgeNode>.NativeClassPtr, nameof (Guid));
        WorldRoadGraphBuilder.BuilderData_EdgeNode.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData_EdgeNode>.NativeClassPtr, nameof (NodeIndex));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData_EdgeNode>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct BuilderData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Nodes;
      private static readonly System.IntPtr NativeFieldInfoPtr_BusStops;
      private static readonly System.IntPtr NativeFieldInfoPtr_NeighbourBindings;
      private static readonly System.IntPtr NativeFieldInfoPtr_EdgeNodes;
      private static readonly System.IntPtr NativeMethodInfoPtr_Allocate_Public_Static_BuilderData_Allocator_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
      [FieldOffset(0)]
      public NativeList<WorldRoadGraphBuilder.BuilderData_Node> Nodes;
      [FieldOffset(16)]
      public NativeList<WorldRoadGraphBuilder.BuilderData_BusStop> BusStops;
      [FieldOffset(32)]
      public NativeList<int> NeighbourBindings;
      [FieldOffset(48)]
      public NativeHashMap<WorldRoadGraph_EdgeNodeKey, int> EdgeNodes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 768725, RefRangeEnd = 768726, XrefRangeStart = 768713, XrefRangeEnd = 768725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe WorldRoadGraphBuilder.BuilderData Allocate(Allocator tempAllocator)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &tempAllocator;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphBuilder.BuilderData.NativeMethodInfoPtr_Allocate_Public_Static_BuilderData_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(WorldRoadGraphBuilder.BuilderData*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 768738, RefRangeEnd = 768739, XrefRangeStart = 768726, XrefRangeEnd = 768738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Dispose()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(WorldRoadGraphBuilder.BuilderData.NativeMethodInfoPtr_Dispose_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static BuilderData()
      {
        Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldRoadGraphBuilder>.NativeClassPtr, nameof (BuilderData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData>.NativeClassPtr);
        WorldRoadGraphBuilder.BuilderData.NativeFieldInfoPtr_Nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData>.NativeClassPtr, nameof (Nodes));
        WorldRoadGraphBuilder.BuilderData.NativeFieldInfoPtr_BusStops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData>.NativeClassPtr, nameof (BusStops));
        WorldRoadGraphBuilder.BuilderData.NativeFieldInfoPtr_NeighbourBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData>.NativeClassPtr, nameof (NeighbourBindings));
        WorldRoadGraphBuilder.BuilderData.NativeFieldInfoPtr_EdgeNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData>.NativeClassPtr, nameof (EdgeNodes));
        WorldRoadGraphBuilder.BuilderData.NativeMethodInfoPtr_Allocate_Public_Static_BuilderData_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData>.NativeClassPtr, 100668014);
        WorldRoadGraphBuilder.BuilderData.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData>.NativeClassPtr, 100668015);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorldRoadGraphBuilder.BuilderData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
