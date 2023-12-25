// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequenceGraphData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Stunlock.Sequencer;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public class SequenceGraphData : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__GraphNodes;
    private static readonly System.IntPtr NativeFieldInfoPtr__PlaybackType;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_GraphNodes_Public_get_List_1_SequenceGraphNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlaybackType_Public_get_GraphPlaybackType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NodeCount_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNode_Public_SequenceGraphNode_GraphFunction_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateFromNodeType_Private_SequenceGraphNode_GraphFunction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetNodeByGuid_Public_Boolean_String_byref_SequenceGraphNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSocketFromConnectionData_Public_Boolean_GraphSocketConnection_byref_IGraphNodeSocket_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_NodeHasAnyConnections_Public_Boolean_SequenceGraphNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_NodeHasAnyConnectionToAnyOfTheseSockets_Private_Boolean_SequenceGraphNode_List_1_GraphNodeOutSocket_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetSocketType_Public_Boolean_SequenceGraphNode_IGraphNodeSocket_BlackboardRegisterType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisconnectTheseOutSockets_Public_Void_List_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanConnect_Public_Boolean_IGraphNodeSocket_IGraphNodeSocket_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MakeConnection_Public_Void_IGraphNodeSocket_IGraphNodeSocket_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInSocket_Public_Boolean_String_byref_GraphNodeInSocket_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInValueOutSockets_Public_List_1_GraphNodeOutSocket_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOutValueInSockets_Public_List_1_GraphNodeInSocket_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNodes_Public_List_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetOutSocket_Public_Boolean_String_byref_GraphNodeOutSocket_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSocketParent_Public_Boolean_String_byref_SequenceGraphNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeleteNode_Public_Void_SequenceGraphNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DuplicateNode_Public_Void_SequenceGraphNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveConnections_Public_Void_SequenceGraphNode_DisconnectType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_Sequencer_ISequenceEditorObject_get_name_Private_Virtual_Final_New_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetSocketType_b__15_0_Private_Void_List_1_String_0;

    public unsafe List<SequenceGraphNode> GraphNodes
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr_get_GraphNodes_Public_get_List_1_SequenceGraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<SequenceGraphNode>) null : new List<SequenceGraphNode>(pointer);
      }
    }

    public unsafe GraphPlaybackType PlaybackType
    {
      [CallerCount(36), CachedScanResults(RefRangeStart = 29682, RefRangeEnd = 29718, XrefRangeStart = 29682, XrefRangeEnd = 29718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr_get_PlaybackType_Public_get_GraphPlaybackType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(GraphPlaybackType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int NodeCount
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094755, XrefRangeEnd = 1094756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr_get_NodeCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094756, XrefRangeEnd = 1094757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Create()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr_Create_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1094761, RefRangeEnd = 1094763, XrefRangeStart = 1094757, XrefRangeEnd = 1094761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceGraphNode AddNode(GraphFunction nodeType, Vector2 position)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &nodeType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr_AddNode_Public_SequenceGraphNode_GraphFunction_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SequenceGraphNode) null : new SequenceGraphNode(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1094826, RefRangeEnd = 1094827, XrefRangeStart = 1094763, XrefRangeEnd = 1094826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceGraphNode CreateFromNodeType(GraphFunction nodeType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &nodeType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr_CreateFromNodeType_Private_SequenceGraphNode_GraphFunction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SequenceGraphNode) null : new SequenceGraphNode(pointer);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1094848, RefRangeEnd = 1094851, XrefRangeStart = 1094827, XrefRangeEnd = 1094848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetNodeByGuid(string guid, out SequenceGraphNode node)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(guid);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr_TryGetNodeByGuid_Public_Boolean_String_byref_SequenceGraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref SequenceGraphNode local = ref node;
      System.IntPtr pointer = zero;
      SequenceGraphNode sequenceGraphNode = pointer == System.IntPtr.Zero ? (SequenceGraphNode) null : new SequenceGraphNode(pointer);
      local = sequenceGraphNode;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094851, XrefRangeEnd = 1094875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetSocketFromConnectionData(
      GraphSocketConnection connection,
      out IGraphNodeSocket socket)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) connection));
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr_TryGetSocketFromConnectionData_Public_Boolean_GraphSocketConnection_byref_IGraphNodeSocket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref IGraphNodeSocket local = ref socket;
      System.IntPtr pointer = zero;
      IGraphNodeSocket igraphNodeSocket = pointer == System.IntPtr.Zero ? (IGraphNodeSocket) null : new IGraphNodeSocket(pointer);
      local = igraphNodeSocket;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094875, XrefRangeEnd = 1094909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool NodeHasAnyConnections(SequenceGraphNode node)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr_NodeHasAnyConnections_Public_Boolean_SequenceGraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1094941, RefRangeEnd = 1094942, XrefRangeStart = 1094909, XrefRangeEnd = 1094941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool NodeHasAnyConnectionToAnyOfTheseSockets(
      SequenceGraphNode node,
      List<GraphNodeOutSocket> outSockets)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outSockets);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr_NodeHasAnyConnectionToAnyOfTheseSockets_Private_Boolean_SequenceGraphNode_List_1_GraphNodeOutSocket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094942, XrefRangeEnd = 1094955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SetSocketType(
      SequenceGraphNode node,
      IGraphNodeSocket socket,
      BlackboardRegisterType newSocketType,
      int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) socket);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &newSocketType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr_SetSocketType_Public_Boolean_SequenceGraphNode_IGraphNodeSocket_BlackboardRegisterType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1094994, RefRangeEnd = 1094995, XrefRangeStart = 1094955, XrefRangeEnd = 1094994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisconnectTheseOutSockets(List<string> sockets)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sockets);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr_DisconnectTheseOutSockets_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094995, XrefRangeEnd = 1095000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CanConnect(IGraphNodeSocket toSocket, IGraphNodeSocket fromSocket)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) toSocket);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fromSocket);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr_CanConnect_Public_Boolean_IGraphNodeSocket_IGraphNodeSocket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095000, XrefRangeEnd = 1095010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void MakeConnection(IGraphNodeSocket toSocket, IGraphNodeSocket fromSocket)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) toSocket);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fromSocket);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr_MakeConnection_Public_Void_IGraphNodeSocket_IGraphNodeSocket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 1095039, RefRangeEnd = 1095055, XrefRangeStart = 1095010, XrefRangeEnd = 1095039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetInSocket(string socketGuid, out GraphNodeInSocket socket)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(socketGuid);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr_TryGetInSocket_Public_Boolean_String_byref_GraphNodeInSocket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref GraphNodeInSocket local = ref socket;
      System.IntPtr pointer = zero;
      GraphNodeInSocket graphNodeInSocket = pointer == System.IntPtr.Zero ? (GraphNodeInSocket) null : new GraphNodeInSocket(pointer);
      local = graphNodeInSocket;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1095088, RefRangeEnd = 1095089, XrefRangeStart = 1095055, XrefRangeEnd = 1095088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<GraphNodeOutSocket> GetInValueOutSockets()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr_GetInValueOutSockets_Public_List_1_GraphNodeOutSocket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<GraphNodeOutSocket>) null : new List<GraphNodeOutSocket>(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1095122, RefRangeEnd = 1095124, XrefRangeStart = 1095089, XrefRangeEnd = 1095122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<GraphNodeInSocket> GetOutValueInSockets()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr_GetOutValueInSockets_Public_List_1_GraphNodeInSocket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<GraphNodeInSocket>) null : new List<GraphNodeInSocket>(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1095146, RefRangeEnd = 1095148, XrefRangeStart = 1095124, XrefRangeEnd = 1095146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<T> GetNodes<T>() where T : SequenceGraphNode
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.MethodInfoStoreGeneric_GetNodes_Public_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<T>) null : new List<T>(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1095177, RefRangeEnd = 1095178, XrefRangeStart = 1095148, XrefRangeEnd = 1095177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetOutSocket(string socketGuid, out GraphNodeOutSocket socket)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(socketGuid);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr_TryGetOutSocket_Public_Boolean_String_byref_GraphNodeOutSocket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref GraphNodeOutSocket local = ref socket;
      System.IntPtr pointer = zero;
      GraphNodeOutSocket graphNodeOutSocket = pointer == System.IntPtr.Zero ? (GraphNodeOutSocket) null : new GraphNodeOutSocket(pointer);
      local = graphNodeOutSocket;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1095229, RefRangeEnd = 1095230, XrefRangeStart = 1095178, XrefRangeEnd = 1095229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetSocketParent(string socketGuid, out SequenceGraphNode node)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(socketGuid);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr_TryGetSocketParent_Public_Boolean_String_byref_SequenceGraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref SequenceGraphNode local = ref node;
      System.IntPtr pointer = zero;
      SequenceGraphNode sequenceGraphNode = pointer == System.IntPtr.Zero ? (SequenceGraphNode) null : new SequenceGraphNode(pointer);
      local = sequenceGraphNode;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095230, XrefRangeEnd = 1095235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeleteNode(SequenceGraphNode node)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr_DeleteNode_Public_Void_SequenceGraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095235, XrefRangeEnd = 1095237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DuplicateNode(SequenceGraphNode node)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr_DuplicateNode_Public_Void_SequenceGraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1095286, RefRangeEnd = 1095287, XrefRangeStart = 1095237, XrefRangeEnd = 1095286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveConnections(SequenceGraphNode node, DisconnectType disconnectType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &disconnectType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr_RemoveConnections_Public_Void_SequenceGraphNode_DisconnectType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095287, XrefRangeEnd = 1095295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceGraphData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public virtual unsafe string ProjectM_Sequencer_ISequenceEditorObject_get_name()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr_ProjectM_Sequencer_ISequenceEditorObject_get_name_Private_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095295, XrefRangeEnd = 1095296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _SetSocketType_b__15_0(List<string> changedSockets)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) changedSockets);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.NativeMethodInfoPtr__SetSocketType_b__15_0_Private_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SequenceGraphData()
    {
      Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequenceGraphData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr);
      SequenceGraphData.NativeFieldInfoPtr__GraphNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, nameof (_GraphNodes));
      SequenceGraphData.NativeFieldInfoPtr__PlaybackType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, nameof (_PlaybackType));
      SequenceGraphData.NativeMethodInfoPtr_get_GraphNodes_Public_get_List_1_SequenceGraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686790);
      SequenceGraphData.NativeMethodInfoPtr_get_PlaybackType_Public_get_GraphPlaybackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686791);
      SequenceGraphData.NativeMethodInfoPtr_get_NodeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686792);
      SequenceGraphData.NativeMethodInfoPtr_Create_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686793);
      SequenceGraphData.NativeMethodInfoPtr_AddNode_Public_SequenceGraphNode_GraphFunction_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686794);
      SequenceGraphData.NativeMethodInfoPtr_CreateFromNodeType_Private_SequenceGraphNode_GraphFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686795);
      SequenceGraphData.NativeMethodInfoPtr_TryGetNodeByGuid_Public_Boolean_String_byref_SequenceGraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686796);
      SequenceGraphData.NativeMethodInfoPtr_TryGetSocketFromConnectionData_Public_Boolean_GraphSocketConnection_byref_IGraphNodeSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686797);
      SequenceGraphData.NativeMethodInfoPtr_NodeHasAnyConnections_Public_Boolean_SequenceGraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686798);
      SequenceGraphData.NativeMethodInfoPtr_NodeHasAnyConnectionToAnyOfTheseSockets_Private_Boolean_SequenceGraphNode_List_1_GraphNodeOutSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686799);
      SequenceGraphData.NativeMethodInfoPtr_SetSocketType_Public_Boolean_SequenceGraphNode_IGraphNodeSocket_BlackboardRegisterType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686800);
      SequenceGraphData.NativeMethodInfoPtr_DisconnectTheseOutSockets_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686801);
      SequenceGraphData.NativeMethodInfoPtr_CanConnect_Public_Boolean_IGraphNodeSocket_IGraphNodeSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686802);
      SequenceGraphData.NativeMethodInfoPtr_MakeConnection_Public_Void_IGraphNodeSocket_IGraphNodeSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686803);
      SequenceGraphData.NativeMethodInfoPtr_TryGetInSocket_Public_Boolean_String_byref_GraphNodeInSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686804);
      SequenceGraphData.NativeMethodInfoPtr_GetInValueOutSockets_Public_List_1_GraphNodeOutSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686805);
      SequenceGraphData.NativeMethodInfoPtr_GetOutValueInSockets_Public_List_1_GraphNodeInSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686806);
      SequenceGraphData.NativeMethodInfoPtr_GetNodes_Public_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686807);
      SequenceGraphData.NativeMethodInfoPtr_TryGetOutSocket_Public_Boolean_String_byref_GraphNodeOutSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686808);
      SequenceGraphData.NativeMethodInfoPtr_TryGetSocketParent_Public_Boolean_String_byref_SequenceGraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686809);
      SequenceGraphData.NativeMethodInfoPtr_DeleteNode_Public_Void_SequenceGraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686810);
      SequenceGraphData.NativeMethodInfoPtr_DuplicateNode_Public_Void_SequenceGraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686811);
      SequenceGraphData.NativeMethodInfoPtr_RemoveConnections_Public_Void_SequenceGraphNode_DisconnectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686812);
      SequenceGraphData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686813);
      SequenceGraphData.NativeMethodInfoPtr_ProjectM_Sequencer_ISequenceEditorObject_get_name_Private_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686814);
      SequenceGraphData.NativeMethodInfoPtr__SetSocketType_b__15_0_Private_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, 100686815);
    }

    public SequenceGraphData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<SequenceGraphNode> _GraphNodes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceGraphData.NativeFieldInfoPtr__GraphNodes));
        return pointer == System.IntPtr.Zero ? (List<SequenceGraphNode>) null : new List<SequenceGraphNode>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceGraphData.NativeFieldInfoPtr__GraphNodes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GraphPlaybackType _PlaybackType
    {
      get
      {
        return *(GraphPlaybackType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceGraphData.NativeFieldInfoPtr__PlaybackType));
      }
      [param: In] set
      {
        *(GraphPlaybackType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceGraphData.NativeFieldInfoPtr__PlaybackType)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Sequencer.SequenceGraphData/<>c__DisplayClass14_0")]
    public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_inSocket;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__NodeHasAnyConnectionToAnyOfTheseSockets_b__0_Internal_Boolean_GraphNodeOutSocket_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass14_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceGraphData.__c__DisplayClass14_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094753, XrefRangeEnd = 1094755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _NodeHasAnyConnectionToAnyOfTheseSockets_b__0(GraphNodeOutSocket a)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceGraphData.__c__DisplayClass14_0.NativeMethodInfoPtr__NodeHasAnyConnectionToAnyOfTheseSockets_b__0_Internal_Boolean_GraphNodeOutSocket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass14_0()
      {
        Il2CppClassPointerStore<SequenceGraphData.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr, "<>c__DisplayClass14_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceGraphData.__c__DisplayClass14_0>.NativeClassPtr);
        SequenceGraphData.__c__DisplayClass14_0.NativeFieldInfoPtr_inSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceGraphData.__c__DisplayClass14_0>.NativeClassPtr, nameof (inSocket));
        SequenceGraphData.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData.__c__DisplayClass14_0>.NativeClassPtr, 100686816);
        SequenceGraphData.__c__DisplayClass14_0.NativeMethodInfoPtr__NodeHasAnyConnectionToAnyOfTheseSockets_b__0_Internal_Boolean_GraphNodeOutSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceGraphData.__c__DisplayClass14_0>.NativeClassPtr, 100686817);
      }

      public __c__DisplayClass14_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe GraphNodeInSocket inSocket
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceGraphData.__c__DisplayClass14_0.NativeFieldInfoPtr_inSocket));
          return pointer == System.IntPtr.Zero ? (GraphNodeInSocket) null : new GraphNodeInSocket(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SequenceGraphData.__c__DisplayClass14_0.NativeFieldInfoPtr_inSocket), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_GetNodes_Public_List_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceGraphData.NativeMethodInfoPtr_GetNodes_Public_List_1_T_0, Il2CppClassPointerStore<SequenceGraphData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
