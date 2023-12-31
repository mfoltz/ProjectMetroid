// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.ChunkRoadGraph_Editor
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Terrain
{
  public class ChunkRoadGraph_Editor : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Nodes;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBusStop_Public_Boolean_AssetGuid_byref_ChunkRoadNode_Editor_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_NewNode_Public_ChunkRoadNode_Editor_Vector3_ChunkRoadNodeType_RoadTypeAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNode_Public_Void_ChunkRoadNode_Editor_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAllNeighbours_Public_Void_ChunkRoadNode_Editor_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768308, XrefRangeEnd = 768314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetBusStop(AssetGuid busStopGuid, out ChunkRoadNode_Editor busStop)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &busStopGuid;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ChunkRoadGraph_Editor.NativeMethodInfoPtr_TryGetBusStop_Public_Boolean_AssetGuid_byref_ChunkRoadNode_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ChunkRoadNode_Editor local = ref busStop;
      System.IntPtr pointer = zero;
      ChunkRoadNode_Editor chunkRoadNodeEditor = pointer == System.IntPtr.Zero ? (ChunkRoadNode_Editor) null : new ChunkRoadNode_Editor(pointer);
      local = chunkRoadNodeEditor;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768314, XrefRangeEnd = 768351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkRoadNode_Editor NewNode(
      Vector3 position,
      ChunkRoadNodeType nodeType,
      RoadTypeAsset roadType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) roadType);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkRoadGraph_Editor.NativeMethodInfoPtr_NewNode_Public_ChunkRoadNode_Editor_Vector3_ChunkRoadNodeType_RoadTypeAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ChunkRoadNode_Editor) null : new ChunkRoadNode_Editor(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 768364, RefRangeEnd = 768366, XrefRangeStart = 768351, XrefRangeEnd = 768364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNode(ChunkRoadNode_Editor instance, bool allowEdgeNodeRemoval)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) instance);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allowEdgeNodeRemoval;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkRoadGraph_Editor.NativeMethodInfoPtr_RemoveNode_Public_Void_ChunkRoadNode_Editor_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768366, XrefRangeEnd = 768375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveAllNeighbours(ChunkRoadNode_Editor instance)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) instance);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkRoadGraph_Editor.NativeMethodInfoPtr_RemoveAllNeighbours_Public_Void_ChunkRoadNode_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 768383, RefRangeEnd = 768384, XrefRangeStart = 768375, XrefRangeEnd = 768383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkRoadGraph_Editor()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkRoadGraph_Editor>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkRoadGraph_Editor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChunkRoadGraph_Editor()
    {
      Il2CppClassPointerStore<ChunkRoadGraph_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (ChunkRoadGraph_Editor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkRoadGraph_Editor>.NativeClassPtr);
      ChunkRoadGraph_Editor.NativeFieldInfoPtr_Nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkRoadGraph_Editor>.NativeClassPtr, nameof (Nodes));
      ChunkRoadGraph_Editor.NativeMethodInfoPtr_TryGetBusStop_Public_Boolean_AssetGuid_byref_ChunkRoadNode_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkRoadGraph_Editor>.NativeClassPtr, 100667972);
      ChunkRoadGraph_Editor.NativeMethodInfoPtr_NewNode_Public_ChunkRoadNode_Editor_Vector3_ChunkRoadNodeType_RoadTypeAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkRoadGraph_Editor>.NativeClassPtr, 100667973);
      ChunkRoadGraph_Editor.NativeMethodInfoPtr_RemoveNode_Public_Void_ChunkRoadNode_Editor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkRoadGraph_Editor>.NativeClassPtr, 100667974);
      ChunkRoadGraph_Editor.NativeMethodInfoPtr_RemoveAllNeighbours_Public_Void_ChunkRoadNode_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkRoadGraph_Editor>.NativeClassPtr, 100667975);
      ChunkRoadGraph_Editor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkRoadGraph_Editor>.NativeClassPtr, 100667976);
    }

    public ChunkRoadGraph_Editor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<ChunkRoadNode_Editor> Nodes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkRoadGraph_Editor.NativeFieldInfoPtr_Nodes));
        return pointer == System.IntPtr.Zero ? (List<ChunkRoadNode_Editor>) null : new List<ChunkRoadNode_Editor>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkRoadGraph_Editor.NativeFieldInfoPtr_Nodes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
