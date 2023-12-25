// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.GraphNodeInSocket
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public class GraphNodeInSocket : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr__SocketType;
    private static readonly System.IntPtr NativeFieldInfoPtr__DefaultValue;
    private static readonly System.IntPtr NativeFieldInfoPtr__Connection;
    private static readonly System.IntPtr NativeFieldInfoPtr__Node;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Guid_Public_Virtual_Final_New_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetGuidOverride_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Connection_Public_get_GraphSocketConnection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SocketType_Public_Virtual_Final_New_get_BlackboardRegisterType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SocketType_Public_Virtual_Final_New_set_Void_BlackboardRegisterType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultValue_Public_get_SocketDefaultValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_SocketDefaultValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HasConnection_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Node_Public_Virtual_Final_New_get_SequenceGraphNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BlackboardRegisterType_SequenceGraphNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Connect_Public_Void_GraphSocketConnection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Disconnect_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Float1Value_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Float1Value_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Float2Value_Public_get_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Float2Value_Public_set_Void_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Float3Value_Public_get_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Float3Value_Public_set_Void_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Float4Value_Public_get_float4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Float4Value_Public_set_Void_float4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Int1Value_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Int1Value_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Int2Value_Public_get_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Int2Value_Public_set_Void_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Int3Value_Public_get_int3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Int3Value_Public_set_Void_int3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Int4Value_Public_get_int4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Int4Value_Public_set_Void_int4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EntityValue_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EntityValue_Public_set_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_BoneValue_Public_get_HybridBoneEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_BoneValue_Public_set_Void_HybridBoneEnum_0;

    public virtual unsafe string Guid
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_get_Guid_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 16451, RefRangeEnd = 16455, XrefRangeStart = 16451, XrefRangeEnd = 16455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetGuidOverride(string guid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(guid);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_SetGuidOverride_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe GraphSocketConnection Connection
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_get_Connection_Public_get_GraphSocketConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new GraphSocketConnection(pointer);
      }
    }

    public virtual unsafe BlackboardRegisterType SocketType
    {
      [CallerCount(264), CachedScanResults(RefRangeStart = 39170, RefRangeEnd = 39434, XrefRangeStart = 39170, XrefRangeEnd = 39434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_get_SocketType_Public_Virtual_Final_New_get_BlackboardRegisterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BlackboardRegisterType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(6), CachedScanResults(RefRangeStart = 1098068, RefRangeEnd = 1098074, XrefRangeStart = 1098063, XrefRangeEnd = 1098068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_set_SocketType_Public_Virtual_Final_New_set_Void_BlackboardRegisterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe SocketDefaultValue DefaultValue
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_get_DefaultValue_Public_get_SocketDefaultValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(SocketDefaultValue*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_SocketDefaultValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool HasConnection
    {
      [CallerCount(11), CachedScanResults(RefRangeStart = 1098075, RefRangeEnd = 1098086, XrefRangeStart = 1098074, XrefRangeEnd = 1098075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_get_HasConnection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public virtual unsafe SequenceGraphNode Node
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 22405, RefRangeEnd = 22406, XrefRangeStart = 22405, XrefRangeEnd = 22406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_get_Node_Public_Virtual_Final_New_get_SequenceGraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (SequenceGraphNode) null : new SequenceGraphNode(pointer);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1098097, RefRangeEnd = 1098098, XrefRangeStart = 1098086, XrefRangeEnd = 1098097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GraphNodeInSocket(BlackboardRegisterType socketType, SequenceGraphNode node)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &socketType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr__ctor_Public_Void_BlackboardRegisterType_SequenceGraphNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098098, XrefRangeEnd = 1098099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Connect(GraphSocketConnection connection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) connection));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_Connect_Public_Void_GraphSocketConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1098102, RefRangeEnd = 1098105, XrefRangeStart = 1098099, XrefRangeEnd = 1098102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Disconnect()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_Disconnect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe float Float1Value
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098105, XrefRangeEnd = 1098106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_get_Float1Value_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098106, XrefRangeEnd = 1098107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_set_Float1Value_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float2 Float2Value
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098107, XrefRangeEnd = 1098108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_get_Float2Value_Public_get_float2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float2*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098108, XrefRangeEnd = 1098109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_set_Float2Value_Public_set_Void_float2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float3 Float3Value
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098109, XrefRangeEnd = 1098110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_get_Float3Value_Public_get_float3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float3*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098110, XrefRangeEnd = 1098111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_set_Float3Value_Public_set_Void_float3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float4 Float4Value
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098111, XrefRangeEnd = 1098112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_get_Float4Value_Public_get_float4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float4*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098112, XrefRangeEnd = 1098113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_set_Float4Value_Public_set_Void_float4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int Int1Value
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098113, XrefRangeEnd = 1098114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_get_Int1Value_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098114, XrefRangeEnd = 1098115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_set_Int1Value_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int2 Int2Value
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098115, XrefRangeEnd = 1098116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_get_Int2Value_Public_get_int2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int2*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1098116, XrefRangeEnd = 1098117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_set_Int2Value_Public_set_Void_int2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int3 Int3Value
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_get_Int3Value_Public_get_int3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int3*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_set_Int3Value_Public_set_Void_int3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int4 Int4Value
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_get_Int4Value_Public_get_int4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int4*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_set_Int4Value_Public_set_Void_int4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Entity EntityValue
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_get_EntityValue_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_set_EntityValue_Public_set_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe HybridBoneEnum BoneValue
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_get_BoneValue_Public_get_HybridBoneEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(HybridBoneEnum*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GraphNodeInSocket.NativeMethodInfoPtr_set_BoneValue_Public_set_Void_HybridBoneEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static GraphNodeInSocket()
    {
      Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (GraphNodeInSocket));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr);
      GraphNodeInSocket.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, nameof (_Guid));
      GraphNodeInSocket.NativeFieldInfoPtr__SocketType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, nameof (_SocketType));
      GraphNodeInSocket.NativeFieldInfoPtr__DefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, nameof (_DefaultValue));
      GraphNodeInSocket.NativeFieldInfoPtr__Connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, nameof (_Connection));
      GraphNodeInSocket.NativeFieldInfoPtr__Node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, nameof (_Node));
      GraphNodeInSocket.NativeMethodInfoPtr_get_Guid_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687162);
      GraphNodeInSocket.NativeMethodInfoPtr_SetGuidOverride_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687163);
      GraphNodeInSocket.NativeMethodInfoPtr_get_Connection_Public_get_GraphSocketConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687164);
      GraphNodeInSocket.NativeMethodInfoPtr_get_SocketType_Public_Virtual_Final_New_get_BlackboardRegisterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687165);
      GraphNodeInSocket.NativeMethodInfoPtr_set_SocketType_Public_Virtual_Final_New_set_Void_BlackboardRegisterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687166);
      GraphNodeInSocket.NativeMethodInfoPtr_get_DefaultValue_Public_get_SocketDefaultValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687167);
      GraphNodeInSocket.NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_SocketDefaultValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687168);
      GraphNodeInSocket.NativeMethodInfoPtr_get_HasConnection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687169);
      GraphNodeInSocket.NativeMethodInfoPtr_get_Node_Public_Virtual_Final_New_get_SequenceGraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687170);
      GraphNodeInSocket.NativeMethodInfoPtr__ctor_Public_Void_BlackboardRegisterType_SequenceGraphNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687171);
      GraphNodeInSocket.NativeMethodInfoPtr_Connect_Public_Void_GraphSocketConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687172);
      GraphNodeInSocket.NativeMethodInfoPtr_Disconnect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687173);
      GraphNodeInSocket.NativeMethodInfoPtr_get_Float1Value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687174);
      GraphNodeInSocket.NativeMethodInfoPtr_set_Float1Value_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687175);
      GraphNodeInSocket.NativeMethodInfoPtr_get_Float2Value_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687176);
      GraphNodeInSocket.NativeMethodInfoPtr_set_Float2Value_Public_set_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687177);
      GraphNodeInSocket.NativeMethodInfoPtr_get_Float3Value_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687178);
      GraphNodeInSocket.NativeMethodInfoPtr_set_Float3Value_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687179);
      GraphNodeInSocket.NativeMethodInfoPtr_get_Float4Value_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687180);
      GraphNodeInSocket.NativeMethodInfoPtr_set_Float4Value_Public_set_Void_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687181);
      GraphNodeInSocket.NativeMethodInfoPtr_get_Int1Value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687182);
      GraphNodeInSocket.NativeMethodInfoPtr_set_Int1Value_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687183);
      GraphNodeInSocket.NativeMethodInfoPtr_get_Int2Value_Public_get_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687184);
      GraphNodeInSocket.NativeMethodInfoPtr_set_Int2Value_Public_set_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687185);
      GraphNodeInSocket.NativeMethodInfoPtr_get_Int3Value_Public_get_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687186);
      GraphNodeInSocket.NativeMethodInfoPtr_set_Int3Value_Public_set_Void_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687187);
      GraphNodeInSocket.NativeMethodInfoPtr_get_Int4Value_Public_get_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687188);
      GraphNodeInSocket.NativeMethodInfoPtr_set_Int4Value_Public_set_Void_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687189);
      GraphNodeInSocket.NativeMethodInfoPtr_get_EntityValue_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687190);
      GraphNodeInSocket.NativeMethodInfoPtr_set_EntityValue_Public_set_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687191);
      GraphNodeInSocket.NativeMethodInfoPtr_get_BoneValue_Public_get_HybridBoneEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687192);
      GraphNodeInSocket.NativeMethodInfoPtr_set_BoneValue_Public_set_Void_HybridBoneEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeInSocket>.NativeClassPtr, 100687193);
    }

    public GraphNodeInSocket(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphNodeInSocket.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphNodeInSocket.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe BlackboardRegisterType _SocketType
    {
      get
      {
        return *(BlackboardRegisterType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphNodeInSocket.NativeFieldInfoPtr__SocketType));
      }
      [param: In] set
      {
        *(BlackboardRegisterType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphNodeInSocket.NativeFieldInfoPtr__SocketType)) = value;
      }
    }

    public unsafe SocketDefaultValue _DefaultValue
    {
      get
      {
        return *(SocketDefaultValue*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphNodeInSocket.NativeFieldInfoPtr__DefaultValue));
      }
      [param: In] set
      {
        *(SocketDefaultValue*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphNodeInSocket.NativeFieldInfoPtr__DefaultValue)) = value;
      }
    }

    public GraphSocketConnection _Connection
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphNodeInSocket.NativeFieldInfoPtr__Connection);
        return new GraphSocketConnection(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GraphSocketConnection>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphNodeInSocket.NativeFieldInfoPtr__Connection), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GraphSocketConnection>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SequenceGraphNode _Node
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphNodeInSocket.NativeFieldInfoPtr__Node));
        return pointer == System.IntPtr.Zero ? (SequenceGraphNode) null : new SequenceGraphNode(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphNodeInSocket.NativeFieldInfoPtr__Node), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
