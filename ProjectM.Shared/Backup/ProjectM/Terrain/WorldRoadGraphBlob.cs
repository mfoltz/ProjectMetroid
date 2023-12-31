// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.WorldRoadGraphBlob
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WorldRoadGraphBlob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Nodes;
    [FieldOffset(0)]
    public BlobArray<WorldRoadGraphBlob.Node> Nodes;

    static WorldRoadGraphBlob()
    {
      Il2CppClassPointerStore<WorldRoadGraphBlob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (WorldRoadGraphBlob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldRoadGraphBlob>.NativeClassPtr);
      WorldRoadGraphBlob.NativeFieldInfoPtr_Nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBlob>.NativeClassPtr, nameof (Nodes));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorldRoadGraphBlob>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Node
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_WorldPos;
      private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_PatrolWaitDuration;
      private static readonly System.IntPtr NativeFieldInfoPtr_Neighbours;
      [FieldOffset(0)]
      public float3 WorldPos;
      [FieldOffset(12)]
      public quaternion Rotation;
      [FieldOffset(28)]
      public float PatrolWaitDuration;
      [FieldOffset(32)]
      public BlobArray<WorldRoadGraphBlob.Neighbour> Neighbours;

      static Node()
      {
        Il2CppClassPointerStore<WorldRoadGraphBlob.Node>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldRoadGraphBlob>.NativeClassPtr, nameof (Node));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldRoadGraphBlob.Node>.NativeClassPtr);
        WorldRoadGraphBlob.Node.NativeFieldInfoPtr_WorldPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBlob.Node>.NativeClassPtr, nameof (WorldPos));
        WorldRoadGraphBlob.Node.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBlob.Node>.NativeClassPtr, nameof (Rotation));
        WorldRoadGraphBlob.Node.NativeFieldInfoPtr_PatrolWaitDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBlob.Node>.NativeClassPtr, nameof (PatrolWaitDuration));
        WorldRoadGraphBlob.Node.NativeFieldInfoPtr_Neighbours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBlob.Node>.NativeClassPtr, nameof (Neighbours));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorldRoadGraphBlob.Node>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Neighbour
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_Distance;
      private static readonly System.IntPtr NativeFieldInfoPtr_WorldPos;
      private static readonly System.IntPtr NativeFieldInfoPtr_RoadType;
      [FieldOffset(0)]
      public int NodeIndex;
      [FieldOffset(4)]
      public float Distance;
      [FieldOffset(8)]
      public float3 WorldPos;
      [FieldOffset(20)]
      public RoadType RoadType;

      static Neighbour()
      {
        Il2CppClassPointerStore<WorldRoadGraphBlob.Neighbour>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldRoadGraphBlob>.NativeClassPtr, nameof (Neighbour));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldRoadGraphBlob.Neighbour>.NativeClassPtr);
        WorldRoadGraphBlob.Neighbour.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBlob.Neighbour>.NativeClassPtr, nameof (NodeIndex));
        WorldRoadGraphBlob.Neighbour.NativeFieldInfoPtr_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBlob.Neighbour>.NativeClassPtr, nameof (Distance));
        WorldRoadGraphBlob.Neighbour.NativeFieldInfoPtr_WorldPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBlob.Neighbour>.NativeClassPtr, nameof (WorldPos));
        WorldRoadGraphBlob.Neighbour.NativeFieldInfoPtr_RoadType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraphBlob.Neighbour>.NativeClassPtr, nameof (RoadType));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorldRoadGraphBlob.Neighbour>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
