// Decompiled with JetBrains decompiler
// Type: ProjectM.IRegisterStaticTransformTypes
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace ProjectM
{
  public class IRegisterStaticTransformTypes : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_RegisterRequiredTypes_Public_Abstract_Virtual_New_Void_StaticTransformIndexConversion_0;

    [CallerCount(0)]
    public virtual unsafe void RegisterRequiredTypes(
      StaticTransformIndexConversion transformIndexingConversion)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transformIndexingConversion);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRegisterStaticTransformTypes.NativeMethodInfoPtr_RegisterRequiredTypes_Public_Abstract_Virtual_New_Void_StaticTransformIndexConversion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IRegisterStaticTransformTypes()
    {
      Il2CppClassPointerStore<IRegisterStaticTransformTypes>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (IRegisterStaticTransformTypes));
      IRegisterStaticTransformTypes.NativeMethodInfoPtr_RegisterRequiredTypes_Public_Abstract_Virtual_New_Void_StaticTransformIndexConversion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRegisterStaticTransformTypes>.NativeClassPtr, 100667376);
    }

    public IRegisterStaticTransformTypes(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
