// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.ChunkRoadGraphAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Collections;

#nullable disable
namespace ProjectM.Terrain
{
  public static class ChunkRoadGraphAuthoring : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRoadTypeSettings_Public_Static_NativeHashMap_2_Byte_RoadTypeSettings_SerializedChunkRoadGraph_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertBlobAsset_Public_Static_ChunkRoadGraph_SerializedChunkRoadGraph_Allocator_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768234, XrefRangeEnd = 768247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeHashMap<byte, RoadTypeSettings> GetRoadTypeSettings(
      SerializedChunkRoadGraph serializedGraph,
      Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serializedGraph);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkRoadGraphAuthoring.NativeMethodInfoPtr_GetRoadTypeSettings_Public_Static_NativeHashMap_2_Byte_RoadTypeSettings_SerializedChunkRoadGraph_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeHashMap<byte, RoadTypeSettings>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 768306, RefRangeEnd = 768308, XrefRangeStart = 768247, XrefRangeEnd = 768306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ChunkRoadGraph ConvertBlobAsset(
      SerializedChunkRoadGraph serializedGraph,
      Allocator tempAllocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serializedGraph);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tempAllocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkRoadGraphAuthoring.NativeMethodInfoPtr_ConvertBlobAsset_Public_Static_ChunkRoadGraph_SerializedChunkRoadGraph_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ChunkRoadGraph*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ChunkRoadGraphAuthoring()
    {
      Il2CppClassPointerStore<ChunkRoadGraphAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (ChunkRoadGraphAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkRoadGraphAuthoring>.NativeClassPtr);
      ChunkRoadGraphAuthoring.NativeMethodInfoPtr_GetRoadTypeSettings_Public_Static_NativeHashMap_2_Byte_RoadTypeSettings_SerializedChunkRoadGraph_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkRoadGraphAuthoring>.NativeClassPtr, 100667970);
      ChunkRoadGraphAuthoring.NativeMethodInfoPtr_ConvertBlobAsset_Public_Static_ChunkRoadGraph_SerializedChunkRoadGraph_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkRoadGraphAuthoring>.NativeClassPtr, 100667971);
    }

    public ChunkRoadGraphAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
