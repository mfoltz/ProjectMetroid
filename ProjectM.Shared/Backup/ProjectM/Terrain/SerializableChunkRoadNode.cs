// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.SerializableChunkRoadNode
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM.Terrain
{
  [Serializable]
  public class SerializableChunkRoadNode : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_RoadType;
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeType;
    private static readonly System.IntPtr NativeFieldInfoPtr_BusStopName;
    private static readonly System.IntPtr NativeFieldInfoPtr_BusStopGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_EdgeNodeId;
    private static readonly System.IntPtr NativeFieldInfoPtr_NeighbourIndexes;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_WaitDuration;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 768471, RefRangeEnd = 768472, XrefRangeStart = 768463, XrefRangeEnd = 768471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SerializableChunkRoadNode()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableChunkRoadNode>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializableChunkRoadNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SerializableChunkRoadNode()
    {
      Il2CppClassPointerStore<SerializableChunkRoadNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (SerializableChunkRoadNode));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableChunkRoadNode>.NativeClassPtr);
      SerializableChunkRoadNode.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableChunkRoadNode>.NativeClassPtr, nameof (Position));
      SerializableChunkRoadNode.NativeFieldInfoPtr_RoadType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableChunkRoadNode>.NativeClassPtr, nameof (RoadType));
      SerializableChunkRoadNode.NativeFieldInfoPtr_NodeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableChunkRoadNode>.NativeClassPtr, nameof (NodeType));
      SerializableChunkRoadNode.NativeFieldInfoPtr_BusStopName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableChunkRoadNode>.NativeClassPtr, nameof (BusStopName));
      SerializableChunkRoadNode.NativeFieldInfoPtr_BusStopGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableChunkRoadNode>.NativeClassPtr, nameof (BusStopGuid));
      SerializableChunkRoadNode.NativeFieldInfoPtr_EdgeNodeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableChunkRoadNode>.NativeClassPtr, nameof (EdgeNodeId));
      SerializableChunkRoadNode.NativeFieldInfoPtr_NeighbourIndexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableChunkRoadNode>.NativeClassPtr, nameof (NeighbourIndexes));
      SerializableChunkRoadNode.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableChunkRoadNode>.NativeClassPtr, nameof (Rotation));
      SerializableChunkRoadNode.NativeFieldInfoPtr_WaitDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableChunkRoadNode>.NativeClassPtr, nameof (WaitDuration));
      SerializableChunkRoadNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableChunkRoadNode>.NativeClassPtr, 100667987);
    }

    public SerializableChunkRoadNode(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Vector3 Position
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializableChunkRoadNode.NativeFieldInfoPtr_Position));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializableChunkRoadNode.NativeFieldInfoPtr_Position)) = value;
      }
    }

    public unsafe RoadTypeAsset RoadType
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializableChunkRoadNode.NativeFieldInfoPtr_RoadType));
        return pointer == System.IntPtr.Zero ? (RoadTypeAsset) null : new RoadTypeAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializableChunkRoadNode.NativeFieldInfoPtr_RoadType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ChunkRoadNodeType NodeType
    {
      get
      {
        return *(ChunkRoadNodeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializableChunkRoadNode.NativeFieldInfoPtr_NodeType));
      }
      [param: In] set
      {
        *(ChunkRoadNodeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializableChunkRoadNode.NativeFieldInfoPtr_NodeType)) = value;
      }
    }

    public unsafe string BusStopName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializableChunkRoadNode.NativeFieldInfoPtr_BusStopName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializableChunkRoadNode.NativeFieldInfoPtr_BusStopName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe AssetGuid BusStopGuid
    {
      get
      {
        return *(AssetGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializableChunkRoadNode.NativeFieldInfoPtr_BusStopGuid));
      }
      [param: In] set
      {
        *(AssetGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializableChunkRoadNode.NativeFieldInfoPtr_BusStopGuid)) = value;
      }
    }

    public unsafe ChunkEdgeNodeId EdgeNodeId
    {
      get
      {
        return *(ChunkEdgeNodeId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializableChunkRoadNode.NativeFieldInfoPtr_EdgeNodeId));
      }
      [param: In] set
      {
        *(ChunkEdgeNodeId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializableChunkRoadNode.NativeFieldInfoPtr_EdgeNodeId)) = value;
      }
    }

    public unsafe List<int> NeighbourIndexes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializableChunkRoadNode.NativeFieldInfoPtr_NeighbourIndexes));
        return pointer == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializableChunkRoadNode.NativeFieldInfoPtr_NeighbourIndexes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe quaternion Rotation
    {
      get
      {
        return *(quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializableChunkRoadNode.NativeFieldInfoPtr_Rotation));
      }
      [param: In] set
      {
        *(quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializableChunkRoadNode.NativeFieldInfoPtr_Rotation)) = value;
      }
    }

    public unsafe BasicTimerSettings WaitDuration
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializableChunkRoadNode.NativeFieldInfoPtr_WaitDuration));
        return pointer == System.IntPtr.Zero ? (BasicTimerSettings) null : new BasicTimerSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializableChunkRoadNode.NativeFieldInfoPtr_WaitDuration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
