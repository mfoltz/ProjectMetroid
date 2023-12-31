// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.RecursiveTerrainChunkSharedAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace ProjectM.Terrain
{
  public class RecursiveTerrainChunkSharedAuthoring : 
    RecursiveSharedAuthoringComponent<TerrainChunkShared>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767491, XrefRangeEnd = 767494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RecursiveTerrainChunkSharedAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecursiveTerrainChunkSharedAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RecursiveTerrainChunkSharedAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RecursiveTerrainChunkSharedAuthoring()
    {
      Il2CppClassPointerStore<RecursiveTerrainChunkSharedAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (RecursiveTerrainChunkSharedAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecursiveTerrainChunkSharedAuthoring>.NativeClassPtr);
      RecursiveTerrainChunkSharedAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecursiveTerrainChunkSharedAuthoring>.NativeClassPtr, 100667912);
    }

    public RecursiveTerrainChunkSharedAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
