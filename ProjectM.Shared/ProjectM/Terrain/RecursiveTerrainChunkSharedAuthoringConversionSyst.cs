// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.RecursiveTerrainChunkSharedAuthoringConversionSystem
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
  public class RecursiveTerrainChunkSharedAuthoringConversionSystem : 
    AttachRecursiveSharedComponentConversionSystem<RecursiveTerrainChunkSharedAuthoring, TerrainChunkShared>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767494, XrefRangeEnd = 767497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RecursiveTerrainChunkSharedAuthoringConversionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecursiveTerrainChunkSharedAuthoringConversionSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RecursiveTerrainChunkSharedAuthoringConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767497, XrefRangeEnd = 767500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RecursiveTerrainChunkSharedAuthoringConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RecursiveTerrainChunkSharedAuthoringConversionSystem()
    {
      Il2CppClassPointerStore<RecursiveTerrainChunkSharedAuthoringConversionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (RecursiveTerrainChunkSharedAuthoringConversionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecursiveTerrainChunkSharedAuthoringConversionSystem>.NativeClassPtr);
      RecursiveTerrainChunkSharedAuthoringConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecursiveTerrainChunkSharedAuthoringConversionSystem>.NativeClassPtr, 100667913);
      RecursiveTerrainChunkSharedAuthoringConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecursiveTerrainChunkSharedAuthoringConversionSystem>.NativeClassPtr, 100667914);
    }

    public RecursiveTerrainChunkSharedAuthoringConversionSystem(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
