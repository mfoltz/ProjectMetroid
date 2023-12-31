// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.RoadPathfinding
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Terrain
{
  public static class RoadPathfinding : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindPath_Public_Static_SolverResult_byref_WorldRoadGraph_BusStopId_BusStopId_NativeArray_1_RoadTypePathfindingWeightsElement_NativeList_1_float3_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindPath_Public_Static_SolverResult_byref_WorldRoadGraph_Int32_Int32_NativeArray_1_RoadTypePathfindingWeightsElement_NativeList_1_float3_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CleanupChunkEdgeNodes_Private_Static_Void_NativeList_1_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateHeuristic_Private_Static_Single_float3_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EuclidianH_Private_Static_Single_float3_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Visit_Private_Static_Void_Neighbour_byref_NativeMinHeap_1_Node_NativeHashMap_2_Int32_NodeData_NativeHashSet_1_Int32_Node_Node_byref_SolveJobData_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 768516, RefRangeEnd = 768517, XrefRangeStart = 768486, XrefRangeEnd = 768516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe RoadPathfinding.SolverResult TryFindPath(
      ref WorldRoadGraph worldRoadGraph,
      BusStopId from,
      BusStopId to,
      NativeArray<RoadTypePathfindingWeightsElement> roadTypePreferrence,
      NativeList<float3> resultPath,
      bool logErrors)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) ref worldRoadGraph;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &roadTypePreferrence;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &resultPath;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &logErrors;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoadPathfinding.NativeMethodInfoPtr_TryFindPath_Public_Static_SolverResult_byref_WorldRoadGraph_BusStopId_BusStopId_NativeArray_1_RoadTypePathfindingWeightsElement_NativeList_1_float3_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(RoadPathfinding.SolverResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 768597, RefRangeEnd = 768599, XrefRangeStart = 768517, XrefRangeEnd = 768597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe RoadPathfinding.SolverResult TryFindPath(
      ref WorldRoadGraph worldRoadGraph,
      int fromNodeIndex,
      int toNodeIndex,
      NativeArray<RoadTypePathfindingWeightsElement> roadTypeWeights,
      NativeList<float3> resultPath,
      bool logErrors)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) ref worldRoadGraph;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromNodeIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &toNodeIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &roadTypeWeights;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &resultPath;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &logErrors;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoadPathfinding.NativeMethodInfoPtr_TryFindPath_Public_Static_SolverResult_byref_WorldRoadGraph_Int32_Int32_NativeArray_1_RoadTypePathfindingWeightsElement_NativeList_1_float3_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(RoadPathfinding.SolverResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 768627, RefRangeEnd = 768628, XrefRangeStart = 768599, XrefRangeEnd = 768627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CleanupChunkEdgeNodes(NativeList<float3> resultPath)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &resultPath;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoadPathfinding.NativeMethodInfoPtr_CleanupChunkEdgeNodes_Private_Static_Void_NativeList_1_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 257678, RefRangeEnd = 257679, XrefRangeStart = 257678, XrefRangeEnd = 257679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float CalculateHeuristic(float3 start, float3 end)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &start;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoadPathfinding.NativeMethodInfoPtr_CalculateHeuristic_Private_Static_Single_float3_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 257678, RefRangeEnd = 257679, XrefRangeStart = 257678, XrefRangeEnd = 257679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float EuclidianH(float3 start, float3 end)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &start;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoadPathfinding.NativeMethodInfoPtr_EuclidianH_Private_Static_Single_float3_float3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 768643, RefRangeEnd = 768644, XrefRangeStart = 768628, XrefRangeEnd = 768643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Visit(
      WorldRoadGraphBlob.Neighbour next,
      ref NativeMinHeap<RoadPathfinding.Node> open,
      NativeHashMap<int, RoadPathfinding.NodeData> openData,
      NativeHashSet<int> closed,
      RoadPathfinding.Node current,
      RoadPathfinding.Node end,
      ref RoadPathfinding.SolveJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &next;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref open;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &openData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &closed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &current;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RoadPathfinding.NativeMethodInfoPtr_Visit_Private_Static_Void_Neighbour_byref_NativeMinHeap_1_Node_NativeHashMap_2_Int32_NodeData_NativeHashSet_1_Int32_Node_Node_byref_SolveJobData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RoadPathfinding()
    {
      Il2CppClassPointerStore<RoadPathfinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (RoadPathfinding));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadPathfinding>.NativeClassPtr);
      RoadPathfinding.NativeMethodInfoPtr_TryFindPath_Public_Static_SolverResult_byref_WorldRoadGraph_BusStopId_BusStopId_NativeArray_1_RoadTypePathfindingWeightsElement_NativeList_1_float3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadPathfinding>.NativeClassPtr, 100667988);
      RoadPathfinding.NativeMethodInfoPtr_TryFindPath_Public_Static_SolverResult_byref_WorldRoadGraph_Int32_Int32_NativeArray_1_RoadTypePathfindingWeightsElement_NativeList_1_float3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadPathfinding>.NativeClassPtr, 100667989);
      RoadPathfinding.NativeMethodInfoPtr_CleanupChunkEdgeNodes_Private_Static_Void_NativeList_1_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadPathfinding>.NativeClassPtr, 100667990);
      RoadPathfinding.NativeMethodInfoPtr_CalculateHeuristic_Private_Static_Single_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadPathfinding>.NativeClassPtr, 100667991);
      RoadPathfinding.NativeMethodInfoPtr_EuclidianH_Private_Static_Single_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadPathfinding>.NativeClassPtr, 100667992);
      RoadPathfinding.NativeMethodInfoPtr_Visit_Private_Static_Void_Neighbour_byref_NativeMinHeap_1_Node_NativeHashMap_2_Int32_NodeData_NativeHashSet_1_Int32_Node_Node_byref_SolveJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadPathfinding>.NativeClassPtr, 100667993);
    }

    public RoadPathfinding(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public enum SolverResult
    {
      Success,
      Failed_NoPath,
      Failed_TooManyExpansions,
      Failed_Error,
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Node
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_NodeIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_H;
      private static readonly System.IntPtr NativeFieldInfoPtr_G;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxG;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxH;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_F_Public_get_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Node_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
      [FieldOffset(0)]
      public int NodeIndex;
      [FieldOffset(4)]
      public float H;
      [FieldOffset(8)]
      public float G;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 768472, RefRangeEnd = 768474, XrefRangeStart = 768472, XrefRangeEnd = 768472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Node(int nodeIndex, float h = 1000000f, float g = 1000000f)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &nodeIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &h;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &g;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RoadPathfinding.Node.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public unsafe float F
      {
        [CallerCount(2), CachedScanResults(RefRangeStart = 768474, RefRangeEnd = 768476, XrefRangeStart = 768474, XrefRangeEnd = 768474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoadPathfinding.Node.NativeMethodInfoPtr_get_F_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(float*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768476, XrefRangeEnd = 768477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(RoadPathfinding.Node other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoadPathfinding.Node.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Node_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768477, XrefRangeEnd = 768480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoadPathfinding.Node.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 727621, RefRangeEnd = 727622, XrefRangeStart = 727621, XrefRangeEnd = 727622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RoadPathfinding.Node.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768480, XrefRangeEnd = 768486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe string ToString()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(RoadPathfinding.Node.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static Node()
      {
        Il2CppClassPointerStore<RoadPathfinding.Node>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoadPathfinding>.NativeClassPtr, nameof (Node));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadPathfinding.Node>.NativeClassPtr);
        RoadPathfinding.Node.NativeFieldInfoPtr_NodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadPathfinding.Node>.NativeClassPtr, nameof (NodeIndex));
        RoadPathfinding.Node.NativeFieldInfoPtr_H = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadPathfinding.Node>.NativeClassPtr, nameof (H));
        RoadPathfinding.Node.NativeFieldInfoPtr_G = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadPathfinding.Node>.NativeClassPtr, nameof (G));
        RoadPathfinding.Node.NativeFieldInfoPtr_MaxG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadPathfinding.Node>.NativeClassPtr, nameof (MaxG));
        RoadPathfinding.Node.NativeFieldInfoPtr_MaxH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadPathfinding.Node>.NativeClassPtr, nameof (MaxH));
        RoadPathfinding.Node.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadPathfinding.Node>.NativeClassPtr, 100667994);
        RoadPathfinding.Node.NativeMethodInfoPtr_get_F_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadPathfinding.Node>.NativeClassPtr, 100667995);
        RoadPathfinding.Node.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadPathfinding.Node>.NativeClassPtr, 100667996);
        RoadPathfinding.Node.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadPathfinding.Node>.NativeClassPtr, 100667997);
        RoadPathfinding.Node.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadPathfinding.Node>.NativeClassPtr, 100667998);
        RoadPathfinding.Node.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadPathfinding.Node>.NativeClassPtr, 100667999);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoadPathfinding.Node>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe float MaxG
      {
        get
        {
          float maxG;
          IL2CPP.il2cpp_field_static_get_value(RoadPathfinding.Node.NativeFieldInfoPtr_MaxG, (void*) &maxG);
          return maxG;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RoadPathfinding.Node.NativeFieldInfoPtr_MaxG, (void*) &value);
        }
      }

      public static unsafe float MaxH
      {
        get
        {
          float maxH;
          IL2CPP.il2cpp_field_static_get_value(RoadPathfinding.Node.NativeFieldInfoPtr_MaxH, (void*) &maxH);
          return maxH;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RoadPathfinding.Node.NativeFieldInfoPtr_MaxH, (void*) &value);
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct NodeData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PreviousNodeIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_G;
      [FieldOffset(0)]
      public int PreviousNodeIndex;
      [FieldOffset(4)]
      public float G;

      static NodeData()
      {
        Il2CppClassPointerStore<RoadPathfinding.NodeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoadPathfinding>.NativeClassPtr, nameof (NodeData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadPathfinding.NodeData>.NativeClassPtr);
        RoadPathfinding.NodeData.NativeFieldInfoPtr_PreviousNodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadPathfinding.NodeData>.NativeClassPtr, nameof (PreviousNodeIndex));
        RoadPathfinding.NodeData.NativeFieldInfoPtr_G = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadPathfinding.NodeData>.NativeClassPtr, nameof (G));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoadPathfinding.NodeData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SolveJobData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_WorldRoadGraph;
      private static readonly System.IntPtr NativeFieldInfoPtr_RoadTypePreferrence;
      private static readonly System.IntPtr NativeFieldInfoPtr_EndPos;
      [FieldOffset(0)]
      public WorldRoadGraph WorldRoadGraph;
      [FieldOffset(64)]
      public NativeArray<RoadTypePathfindingWeightsElement> RoadTypePreferrence;
      [FieldOffset(80)]
      public float3 EndPos;

      static SolveJobData()
      {
        Il2CppClassPointerStore<RoadPathfinding.SolveJobData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoadPathfinding>.NativeClassPtr, nameof (SolveJobData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadPathfinding.SolveJobData>.NativeClassPtr);
        RoadPathfinding.SolveJobData.NativeFieldInfoPtr_WorldRoadGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadPathfinding.SolveJobData>.NativeClassPtr, nameof (WorldRoadGraph));
        RoadPathfinding.SolveJobData.NativeFieldInfoPtr_RoadTypePreferrence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadPathfinding.SolveJobData>.NativeClassPtr, nameof (RoadTypePreferrence));
        RoadPathfinding.SolveJobData.NativeFieldInfoPtr_EndPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadPathfinding.SolveJobData>.NativeClassPtr, nameof (EndPos));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RoadPathfinding.SolveJobData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
