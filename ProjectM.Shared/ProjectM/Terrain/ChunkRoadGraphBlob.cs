// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.ChunkRoadGraphBlob
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ChunkRoadGraphBlob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Nodes;
    private static readonly System.IntPtr NativeFieldInfoPtr_EdgeNodes;
    private static readonly System.IntPtr NativeFieldInfoPtr_BusStops;
    [FieldOffset(0)]
    public BlobArray<ChunkRoadGraphBlob.Node> Nodes;
    [FieldOffset(8)]
    public BlobArray<ChunkRoadGraphBlob.EdgeNode> EdgeNodes;
    [FieldOffset(16)]
    public BlobArray<ChunkRoadGraphBlob.BusStopNode> BusStops;

    static ChunkRoadGraphBlob()
    {
      Il2CppClassPointerStore<ChunkRoadGraphBlob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (ChunkRoadGraphBlob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkRoadGraphBlob>.NativeClassPtr);
      ChunkRoadGraphBlob.NativeFieldInfoPtr_Nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadGraphBlob>.NativeClassPtr, nameof (Nodes));
      ChunkRoadGraphBlob.NativeFieldInfoPtr_EdgeNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadGraphBlob>.NativeClassPtr, nameof (EdgeNodes));
      ChunkRoadGraphBlob.NativeFieldInfoPtr_BusStops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadGraphBlob>.NativeClassPtr, nameof (BusStops));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkRoadGraphBlob>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Node
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Position;
      private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_NodeType;
      private static readonly System.IntPtr NativeFieldInfoPtr_NodeRoadType;
      private static readonly System.IntPtr NativeFieldInfoPtr_Neighbours;
      private static readonly System.IntPtr NativeFieldInfoPtr_WaitDuration;
      [FieldOffset(0)]
      public float3 Position;
      [FieldOffset(12)]
      public quaternion Rotation;
      [FieldOffset(28)]
      public ChunkRoadNodeType NodeType;
      [FieldOffset(29)]
      public RoadType NodeRoadType;
      [FieldOffset(32)]
      public BlobArray<ushort> Neighbours;
      [FieldOffset(40)]
      public float WaitDuration;

      static Node()
      {
        Il2CppClassPointerStore<ChunkRoadGraphBlob.Node>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkRoadGraphBlob>.NativeClassPtr, nameof (Node));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkRoadGraphBlob.Node>.NativeClassPtr);
        ChunkRoadGraphBlob.Node.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadGraphBlob.Node>.NativeClassPtr, nameof (Position));
        ChunkRoadGraphBlob.Node.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadGraphBlob.Node>.NativeClassPtr, nameof (Rotation));
        ChunkRoadGraphBlob.Node.NativeFieldInfoPtr_NodeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadGraphBlob.Node>.NativeClassPtr, nameof (NodeType));
        ChunkRoadGraphBlob.Node.NativeFieldInfoPtr_NodeRoadType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadGraphBlob.Node>.NativeClassPtr, nameof (NodeRoadType));
        ChunkRoadGraphBlob.Node.NativeFieldInfoPtr_Neighbours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadGraphBlob.Node>.NativeClassPtr, nameof (Neighbours));
        ChunkRoadGraphBlob.Node.NativeFieldInfoPtr_WaitDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadGraphBlob.Node>.NativeClassPtr, nameof (WaitDuration));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkRoadGraphBlob.Node>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct EdgeNode
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_NodeId;
      private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
      [FieldOffset(0)]
      public ChunkEdgeNodeId NodeId;
      [FieldOffset(2)]
      public ushort NodeIndex;

      static EdgeNode()
      {
        Il2CppClassPointerStore<ChunkRoadGraphBlob.EdgeNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkRoadGraphBlob>.NativeClassPtr, nameof (EdgeNode));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkRoadGraphBlob.EdgeNode>.NativeClassPtr);
        ChunkRoadGraphBlob.EdgeNode.NativeFieldInfoPtr_NodeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadGraphBlob.EdgeNode>.NativeClassPtr, nameof (NodeId));
        ChunkRoadGraphBlob.EdgeNode.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadGraphBlob.EdgeNode>.NativeClassPtr, nameof (NodeIndex));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkRoadGraphBlob.EdgeNode>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct BusStopNode
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
      private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      [FieldOffset(0)]
      public AssetGuid Guid;
      [FieldOffset(16)]
      public ushort NodeIndex;
      [FieldOffset(18)]
      public FixedString32 Name;

      static BusStopNode()
      {
        Il2CppClassPointerStore<ChunkRoadGraphBlob.BusStopNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChunkRoadGraphBlob>.NativeClassPtr, nameof (BusStopNode));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkRoadGraphBlob.BusStopNode>.NativeClassPtr);
        ChunkRoadGraphBlob.BusStopNode.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadGraphBlob.BusStopNode>.NativeClassPtr, nameof (Guid));
        ChunkRoadGraphBlob.BusStopNode.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadGraphBlob.BusStopNode>.NativeClassPtr, nameof (NodeIndex));
        ChunkRoadGraphBlob.BusStopNode.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadGraphBlob.BusStopNode>.NativeClassPtr, nameof (Name));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkRoadGraphBlob.BusStopNode>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
