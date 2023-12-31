// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.ChunkRoadNode_Editor
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM.Terrain
{
  public class ChunkRoadNode_Editor : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_WaitDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_RoadType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Neighbours;
    private static readonly System.IntPtr NativeFieldInfoPtr__NodeType;
    private static readonly System.IntPtr NativeFieldInfoPtr_BusStopName;
    private static readonly System.IntPtr NativeFieldInfoPtr__BusStopGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr__EdgeNodeId;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NodeType_Public_get_ChunkRoadNodeType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_BusStopGuid_Public_get_AssetGuid_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EdgeNodeId_Public_get_ChunkEdgeNodeId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_quaternion_BasicTimerSettings_ChunkRoadNodeType_RoadTypeAsset_String_AssetGuid_ChunkEdgeNodeId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ChangeNodeType_Public_Void_ChunkRoadNodeType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnbindNodeTypeFields_Public_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNeighbour_Public_Void_ChunkRoadNode_Editor_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNeighbour_Public_Void_ChunkRoadNode_Editor_0;

    public unsafe ChunkRoadNodeType NodeType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkRoadNode_Editor.NativeMethodInfoPtr_get_NodeType_Public_get_ChunkRoadNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ChunkRoadNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe AssetGuid BusStopGuid
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkRoadNode_Editor.NativeMethodInfoPtr_get_BusStopGuid_Public_get_AssetGuid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(AssetGuid*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe ChunkEdgeNodeId EdgeNodeId
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkRoadNode_Editor.NativeMethodInfoPtr_get_EdgeNodeId_Public_get_ChunkEdgeNodeId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ChunkEdgeNodeId*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768384, XrefRangeEnd = 768396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkRoadNode_Editor()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkRoadNode_Editor>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkRoadNode_Editor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 768411, RefRangeEnd = 768413, XrefRangeStart = 768396, XrefRangeEnd = 768411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkRoadNode_Editor(
      Vector3 position,
      quaternion rotation,
      BasicTimerSettings waitDuration,
      ChunkRoadNodeType nodeType,
      RoadTypeAsset roadType,
      string busStopName,
      AssetGuid busStopGuid,
      ChunkEdgeNodeId edgeNodeId)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkRoadNode_Editor>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) waitDuration);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) roadType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(busStopName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &busStopGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &edgeNodeId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkRoadNode_Editor.NativeMethodInfoPtr__ctor_Public_Void_Vector3_quaternion_BasicTimerSettings_ChunkRoadNodeType_RoadTypeAsset_String_AssetGuid_ChunkEdgeNodeId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768413, XrefRangeEnd = 768431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ChangeNodeType(ChunkRoadNodeType nodeType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &nodeType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkRoadNode_Editor.NativeMethodInfoPtr_ChangeNodeType_Public_Void_ChunkRoadNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 768437, RefRangeEnd = 768438, XrefRangeStart = 768431, XrefRangeEnd = 768437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UnbindNodeTypeFields(bool allowEdgeNodeRemoval)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &allowEdgeNodeRemoval;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkRoadNode_Editor.NativeMethodInfoPtr_UnbindNodeTypeFields_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768438, XrefRangeEnd = 768448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddNeighbour(ChunkRoadNode_Editor other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkRoadNode_Editor.NativeMethodInfoPtr_AddNeighbour_Public_Void_ChunkRoadNode_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768448, XrefRangeEnd = 768453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNeighbour(ChunkRoadNode_Editor neighbour)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) neighbour);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkRoadNode_Editor.NativeMethodInfoPtr_RemoveNeighbour_Public_Void_ChunkRoadNode_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChunkRoadNode_Editor()
    {
      Il2CppClassPointerStore<ChunkRoadNode_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (ChunkRoadNode_Editor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkRoadNode_Editor>.NativeClassPtr);
      ChunkRoadNode_Editor.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadNode_Editor>.NativeClassPtr, nameof (Position));
      ChunkRoadNode_Editor.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadNode_Editor>.NativeClassPtr, nameof (Rotation));
      ChunkRoadNode_Editor.NativeFieldInfoPtr_WaitDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadNode_Editor>.NativeClassPtr, nameof (WaitDuration));
      ChunkRoadNode_Editor.NativeFieldInfoPtr_RoadType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadNode_Editor>.NativeClassPtr, nameof (RoadType));
      ChunkRoadNode_Editor.NativeFieldInfoPtr_Neighbours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadNode_Editor>.NativeClassPtr, nameof (Neighbours));
      ChunkRoadNode_Editor.NativeFieldInfoPtr__NodeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadNode_Editor>.NativeClassPtr, nameof (_NodeType));
      ChunkRoadNode_Editor.NativeFieldInfoPtr_BusStopName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadNode_Editor>.NativeClassPtr, nameof (BusStopName));
      ChunkRoadNode_Editor.NativeFieldInfoPtr__BusStopGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadNode_Editor>.NativeClassPtr, nameof (_BusStopGuid));
      ChunkRoadNode_Editor.NativeFieldInfoPtr__EdgeNodeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadNode_Editor>.NativeClassPtr, nameof (_EdgeNodeId));
      ChunkRoadNode_Editor.NativeMethodInfoPtr_get_NodeType_Public_get_ChunkRoadNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkRoadNode_Editor>.NativeClassPtr, 100667977);
      ChunkRoadNode_Editor.NativeMethodInfoPtr_get_BusStopGuid_Public_get_AssetGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkRoadNode_Editor>.NativeClassPtr, 100667978);
      ChunkRoadNode_Editor.NativeMethodInfoPtr_get_EdgeNodeId_Public_get_ChunkEdgeNodeId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkRoadNode_Editor>.NativeClassPtr, 100667979);
      ChunkRoadNode_Editor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkRoadNode_Editor>.NativeClassPtr, 100667980);
      ChunkRoadNode_Editor.NativeMethodInfoPtr__ctor_Public_Void_Vector3_quaternion_BasicTimerSettings_ChunkRoadNodeType_RoadTypeAsset_String_AssetGuid_ChunkEdgeNodeId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkRoadNode_Editor>.NativeClassPtr, 100667981);
      ChunkRoadNode_Editor.NativeMethodInfoPtr_ChangeNodeType_Public_Void_ChunkRoadNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkRoadNode_Editor>.NativeClassPtr, 100667982);
      ChunkRoadNode_Editor.NativeMethodInfoPtr_UnbindNodeTypeFields_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkRoadNode_Editor>.NativeClassPtr, 100667983);
      ChunkRoadNode_Editor.NativeMethodInfoPtr_AddNeighbour_Public_Void_ChunkRoadNode_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkRoadNode_Editor>.NativeClassPtr, 100667984);
      ChunkRoadNode_Editor.NativeMethodInfoPtr_RemoveNeighbour_Public_Void_ChunkRoadNode_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkRoadNode_Editor>.NativeClassPtr, 100667985);
    }

    public ChunkRoadNode_Editor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Vector3 Position
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkRoadNode_Editor.NativeFieldInfoPtr_Position));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkRoadNode_Editor.NativeFieldInfoPtr_Position)) = value;
      }
    }

    public unsafe quaternion Rotation
    {
      get
      {
        return *(quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkRoadNode_Editor.NativeFieldInfoPtr_Rotation));
      }
      [param: In] set
      {
        *(quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkRoadNode_Editor.NativeFieldInfoPtr_Rotation)) = value;
      }
    }

    public unsafe BasicTimerSettings WaitDuration
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkRoadNode_Editor.NativeFieldInfoPtr_WaitDuration));
        return pointer == System.IntPtr.Zero ? (BasicTimerSettings) null : new BasicTimerSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkRoadNode_Editor.NativeFieldInfoPtr_WaitDuration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RoadTypeAsset RoadType
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkRoadNode_Editor.NativeFieldInfoPtr_RoadType));
        return pointer == System.IntPtr.Zero ? (RoadTypeAsset) null : new RoadTypeAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkRoadNode_Editor.NativeFieldInfoPtr_RoadType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ChunkRoadNode_Editor> Neighbours
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkRoadNode_Editor.NativeFieldInfoPtr_Neighbours));
        return pointer == System.IntPtr.Zero ? (List<ChunkRoadNode_Editor>) null : new List<ChunkRoadNode_Editor>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkRoadNode_Editor.NativeFieldInfoPtr_Neighbours), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ChunkRoadNodeType _NodeType
    {
      get
      {
        return *(ChunkRoadNodeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkRoadNode_Editor.NativeFieldInfoPtr__NodeType));
      }
      [param: In] set
      {
        *(ChunkRoadNodeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkRoadNode_Editor.NativeFieldInfoPtr__NodeType)) = value;
      }
    }

    public unsafe string BusStopName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkRoadNode_Editor.NativeFieldInfoPtr_BusStopName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkRoadNode_Editor.NativeFieldInfoPtr_BusStopName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe AssetGuid _BusStopGuid
    {
      get
      {
        return *(AssetGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkRoadNode_Editor.NativeFieldInfoPtr__BusStopGuid));
      }
      [param: In] set
      {
        *(AssetGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkRoadNode_Editor.NativeFieldInfoPtr__BusStopGuid)) = value;
      }
    }

    public unsafe ChunkEdgeNodeId _EdgeNodeId
    {
      get
      {
        return *(ChunkEdgeNodeId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkRoadNode_Editor.NativeFieldInfoPtr__EdgeNodeId));
      }
      [param: In] set
      {
        *(ChunkEdgeNodeId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkRoadNode_Editor.NativeFieldInfoPtr__EdgeNodeId)) = value;
      }
    }
  }
}
