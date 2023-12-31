// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.IHybridComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using Unity.Entities;

#nullable disable
namespace ProjectM.Hybrid
{
  public class IHybridComponent : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_AddComponent_Public_Abstract_Virtual_New_Void_World_PrefabLookupMap_Entity_0;

    [CallerCount(0)]
    public virtual unsafe void AddComponent(
      World world,
      PrefabLookupMap prefabLookupMap,
      Entity hybridEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &prefabLookupMap;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &hybridEntity;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IHybridComponent.NativeMethodInfoPtr_AddComponent_Public_Abstract_Virtual_New_Void_World_PrefabLookupMap_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IHybridComponent()
    {
      Il2CppClassPointerStore<IHybridComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Hybrid", nameof (IHybridComponent));
      IHybridComponent.NativeMethodInfoPtr_AddComponent_Public_Abstract_Virtual_New_Void_World_PrefabLookupMap_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHybridComponent>.NativeClassPtr, 100670328);
    }

    public IHybridComponent(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
