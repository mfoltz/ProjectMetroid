// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.SerializedChunkRoadGraph
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Terrain
{
  [Serializable]
  public class SerializedChunkRoadGraph : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Nodes;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 768461, RefRangeEnd = 768463, XrefRangeStart = 768453, XrefRangeEnd = 768461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SerializedChunkRoadGraph()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedChunkRoadGraph>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializedChunkRoadGraph.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SerializedChunkRoadGraph()
    {
      Il2CppClassPointerStore<SerializedChunkRoadGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (SerializedChunkRoadGraph));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedChunkRoadGraph>.NativeClassPtr);
      SerializedChunkRoadGraph.NativeFieldInfoPtr_Nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedChunkRoadGraph>.NativeClassPtr, nameof (Nodes));
      SerializedChunkRoadGraph.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedChunkRoadGraph>.NativeClassPtr, 100667986);
    }

    public SerializedChunkRoadGraph(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<SerializableChunkRoadNode> Nodes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializedChunkRoadGraph.NativeFieldInfoPtr_Nodes));
        return pointer == System.IntPtr.Zero ? (List<SerializableChunkRoadNode>) null : new List<SerializableChunkRoadNode>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializedChunkRoadGraph.NativeFieldInfoPtr_Nodes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
