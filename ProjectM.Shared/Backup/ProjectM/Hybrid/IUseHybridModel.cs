// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.IUseHybridModel
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using UnityEngine;

#nullable disable
namespace ProjectM.Hybrid
{
  public class IUseHybridModel : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_GetReferencedHybridModels_Public_Abstract_Virtual_New_Void_HashSet_1_GameObject_0;

    [CallerCount(0)]
    public virtual unsafe void GetReferencedHybridModels(HashSet<GameObject> hybridModels)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hybridModels);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IUseHybridModel.NativeMethodInfoPtr_GetReferencedHybridModels_Public_Abstract_Virtual_New_Void_HashSet_1_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IUseHybridModel()
    {
      Il2CppClassPointerStore<IUseHybridModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Hybrid", nameof (IUseHybridModel));
      IUseHybridModel.NativeMethodInfoPtr_GetReferencedHybridModels_Public_Abstract_Virtual_New_Void_HashSet_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUseHybridModel>.NativeClassPtr, 100670304);
    }

    public IUseHybridModel(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
