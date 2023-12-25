// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.ITileModelSpatialLookupMap
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using Unity.Entities;
using Unity.Jobs;

#nullable disable
namespace ProjectM.Tiles
{
  public class ITileModelSpatialLookupMap : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_GetLookupParamsAsync_Public_Abstract_Virtual_New_SpatialLookupParams_ComponentSystemBase_byref_JobHandle_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetLookupParamsAndComplete_Public_Abstract_Virtual_New_SpatialLookupParams_ComponentSystemBase_0;

    [CallerCount(0)]
    public virtual unsafe SpatialLookupParams GetLookupParamsAsync(
      ComponentSystemBase system,
      out JobHandle lookupDeps)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref lookupDeps;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ITileModelSpatialLookupMap.NativeMethodInfoPtr_GetLookupParamsAsync_Public_Abstract_Virtual_New_SpatialLookupParams_ComponentSystemBase_byref_JobHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SpatialLookupParams*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public virtual unsafe SpatialLookupParams GetLookupParamsAndComplete(ComponentSystemBase system)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ITileModelSpatialLookupMap.NativeMethodInfoPtr_GetLookupParamsAndComplete_Public_Abstract_Virtual_New_SpatialLookupParams_ComponentSystemBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SpatialLookupParams*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ITileModelSpatialLookupMap()
    {
      Il2CppClassPointerStore<ITileModelSpatialLookupMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (ITileModelSpatialLookupMap));
      ITileModelSpatialLookupMap.NativeMethodInfoPtr_GetLookupParamsAsync_Public_Abstract_Virtual_New_SpatialLookupParams_ComponentSystemBase_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITileModelSpatialLookupMap>.NativeClassPtr, 100685612);
      ITileModelSpatialLookupMap.NativeMethodInfoPtr_GetLookupParamsAndComplete_Public_Abstract_Virtual_New_SpatialLookupParams_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITileModelSpatialLookupMap>.NativeClassPtr, 100685613);
    }

    public ITileModelSpatialLookupMap(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
