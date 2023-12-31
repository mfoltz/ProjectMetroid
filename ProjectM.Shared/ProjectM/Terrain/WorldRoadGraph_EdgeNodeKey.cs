// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.WorldRoadGraph_EdgeNodeKey
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WorldRoadGraph_EdgeNodeKey
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Chunk;
    private static readonly System.IntPtr NativeFieldInfoPtr_Edge;
    private static readonly System.IntPtr NativeFieldInfoPtr_EdgeNodeIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_WorldRoadGraph_EdgeNodeKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    [FieldOffset(0)]
    public TerrainChunk Chunk;
    [FieldOffset(8)]
    public ChunkEdge Edge;
    [FieldOffset(9)]
    public byte EdgeNodeIndex;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768708, XrefRangeEnd = 768709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(WorldRoadGraph_EdgeNodeKey other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldRoadGraph_EdgeNodeKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_WorldRoadGraph_EdgeNodeKey_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768709, XrefRangeEnd = 768712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldRoadGraph_EdgeNodeKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768712, XrefRangeEnd = 768713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldRoadGraph_EdgeNodeKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static WorldRoadGraph_EdgeNodeKey()
    {
      Il2CppClassPointerStore<WorldRoadGraph_EdgeNodeKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (WorldRoadGraph_EdgeNodeKey));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldRoadGraph_EdgeNodeKey>.NativeClassPtr);
      WorldRoadGraph_EdgeNodeKey.NativeFieldInfoPtr_Chunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraph_EdgeNodeKey>.NativeClassPtr, nameof (Chunk));
      WorldRoadGraph_EdgeNodeKey.NativeFieldInfoPtr_Edge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraph_EdgeNodeKey>.NativeClassPtr, nameof (Edge));
      WorldRoadGraph_EdgeNodeKey.NativeFieldInfoPtr_EdgeNodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldRoadGraph_EdgeNodeKey>.NativeClassPtr, nameof (EdgeNodeIndex));
      WorldRoadGraph_EdgeNodeKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_WorldRoadGraph_EdgeNodeKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraph_EdgeNodeKey>.NativeClassPtr, 100668008);
      WorldRoadGraph_EdgeNodeKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraph_EdgeNodeKey>.NativeClassPtr, 100668009);
      WorldRoadGraph_EdgeNodeKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldRoadGraph_EdgeNodeKey>.NativeClassPtr, 100668010);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorldRoadGraph_EdgeNodeKey>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
