// Decompiled with JetBrains decompiler
// Type: ProjectM.StaticTransformIndexLookup
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct StaticTransformIndexLookup
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TerrainChunks;
    private static readonly System.IntPtr NativeFieldInfoPtr_TransformLookupFromChunk;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_StaticTransformIndexLookup_ComponentSystemBase_TerrainChunkLookup_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindTransform_Public_Boolean_StaticTransformIndex_byref_StaticTransformElement_0;
    [FieldOffset(0)]
    public TerrainChunkLookup TerrainChunks;
    [FieldOffset(16)]
    public BufferFromEntity<StaticTransformElement> TransformLookupFromChunk;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 762374, RefRangeEnd = 762375, XrefRangeStart = 762371, XrefRangeEnd = 762374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe StaticTransformIndexLookup Create(
      ComponentSystemBase system,
      TerrainChunkLookup terrainChunks)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &terrainChunks;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StaticTransformIndexLookup.NativeMethodInfoPtr_Create_Public_Static_StaticTransformIndexLookup_ComponentSystemBase_TerrainChunkLookup_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(StaticTransformIndexLookup*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 762389, RefRangeEnd = 762390, XrefRangeStart = 762375, XrefRangeEnd = 762389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryFindTransform(
      StaticTransformIndex transformIndex,
      out StaticTransformElement staticTransform)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &transformIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref staticTransform;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StaticTransformIndexLookup.NativeMethodInfoPtr_TryFindTransform_Public_Boolean_StaticTransformIndex_byref_StaticTransformElement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static StaticTransformIndexLookup()
    {
      Il2CppClassPointerStore<StaticTransformIndexLookup>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (StaticTransformIndexLookup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticTransformIndexLookup>.NativeClassPtr);
      StaticTransformIndexLookup.NativeFieldInfoPtr_TerrainChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTransformIndexLookup>.NativeClassPtr, nameof (TerrainChunks));
      StaticTransformIndexLookup.NativeFieldInfoPtr_TransformLookupFromChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTransformIndexLookup>.NativeClassPtr, nameof (TransformLookupFromChunk));
      StaticTransformIndexLookup.NativeMethodInfoPtr_Create_Public_Static_StaticTransformIndexLookup_ComponentSystemBase_TerrainChunkLookup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticTransformIndexLookup>.NativeClassPtr, 100667374);
      StaticTransformIndexLookup.NativeMethodInfoPtr_TryFindTransform_Public_Boolean_StaticTransformIndex_byref_StaticTransformElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticTransformIndexLookup>.NativeClassPtr, 100667375);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StaticTransformIndexLookup>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
