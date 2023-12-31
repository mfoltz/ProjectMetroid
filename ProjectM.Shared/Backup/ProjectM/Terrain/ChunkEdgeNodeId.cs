// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.ChunkEdgeNodeId
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Terrain
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct ChunkEdgeNodeId
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EdgeDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeInEdge;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ChunkEdgeNodeId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    [FieldOffset(0)]
    public ChunkEdge EdgeDirection;
    [FieldOffset(1)]
    public byte NodeInEdge;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 254395, RefRangeEnd = 254396, XrefRangeStart = 254395, XrefRangeEnd = 254396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(ChunkEdgeNodeId other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkEdgeNodeId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ChunkEdgeNodeId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768225, XrefRangeEnd = 768228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkEdgeNodeId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChunkEdgeNodeId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ChunkEdgeNodeId()
    {
      Il2CppClassPointerStore<ChunkEdgeNodeId>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (ChunkEdgeNodeId));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkEdgeNodeId>.NativeClassPtr);
      ChunkEdgeNodeId.NativeFieldInfoPtr_EdgeDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkEdgeNodeId>.NativeClassPtr, nameof (EdgeDirection));
      ChunkEdgeNodeId.NativeFieldInfoPtr_NodeInEdge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkEdgeNodeId>.NativeClassPtr, nameof (NodeInEdge));
      ChunkEdgeNodeId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ChunkEdgeNodeId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkEdgeNodeId>.NativeClassPtr, 100667963);
      ChunkEdgeNodeId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkEdgeNodeId>.NativeClassPtr, 100667964);
      ChunkEdgeNodeId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkEdgeNodeId>.NativeClassPtr, 100667965);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChunkEdgeNodeId>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
