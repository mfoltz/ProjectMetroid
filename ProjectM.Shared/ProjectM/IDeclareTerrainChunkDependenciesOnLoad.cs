// Decompiled with JetBrains decompiler
// Type: ProjectM.IDeclareTerrainChunkDependenciesOnLoad
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Terrain;
using System;

#nullable disable
namespace ProjectM
{
  public class IDeclareTerrainChunkDependenciesOnLoad : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_AddSceneMetadataDependencies_Public_Abstract_Virtual_New_Void_byref_ConvertOnDemandContext_TerrainChunkMetadataLoadedEvent_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddSceneDependencies_Public_Abstract_Virtual_New_Void_byref_ConvertOnDemandContext_TerrainChunkLoadedEvent_0;

    [CallerCount(0)]
    public virtual unsafe void AddSceneMetadataDependencies(
      ref ConvertOnDemandContext convertOnDemandContext,
      TerrainChunkMetadataLoadedEvent loadedEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) ref convertOnDemandContext;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &loadedEvent;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDeclareTerrainChunkDependenciesOnLoad.NativeMethodInfoPtr_AddSceneMetadataDependencies_Public_Abstract_Virtual_New_Void_byref_ConvertOnDemandContext_TerrainChunkMetadataLoadedEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void AddSceneDependencies(
      ref ConvertOnDemandContext convertOnDemandContext,
      TerrainChunkLoadedEvent loadedEvent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) ref convertOnDemandContext;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &loadedEvent;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDeclareTerrainChunkDependenciesOnLoad.NativeMethodInfoPtr_AddSceneDependencies_Public_Abstract_Virtual_New_Void_byref_ConvertOnDemandContext_TerrainChunkLoadedEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IDeclareTerrainChunkDependenciesOnLoad()
    {
      Il2CppClassPointerStore<IDeclareTerrainChunkDependenciesOnLoad>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (IDeclareTerrainChunkDependenciesOnLoad));
      IDeclareTerrainChunkDependenciesOnLoad.NativeMethodInfoPtr_AddSceneMetadataDependencies_Public_Abstract_Virtual_New_Void_byref_ConvertOnDemandContext_TerrainChunkMetadataLoadedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDeclareTerrainChunkDependenciesOnLoad>.NativeClassPtr, 100663781);
      IDeclareTerrainChunkDependenciesOnLoad.NativeMethodInfoPtr_AddSceneDependencies_Public_Abstract_Virtual_New_Void_byref_ConvertOnDemandContext_TerrainChunkLoadedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDeclareTerrainChunkDependenciesOnLoad>.NativeClassPtr, 100663782);
    }

    public IDeclareTerrainChunkDependenciesOnLoad(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
