// Decompiled with JetBrains decompiler
// Type: ProjectM.IModification`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

#nullable disable
namespace ProjectM
{
  public class IModification<T> : Il2CppObjectBase
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ModData_Public_Abstract_Virtual_New_get_ModificationData_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ModData_Public_Abstract_Virtual_New_set_Void_ModificationData_1_T_0;

    public virtual unsafe ModificationData<T> ModData
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IModification<T>.NativeMethodInfoPtr_get_ModData_Public_Abstract_Virtual_New_get_ModificationData_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ModificationData<T>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IModification<T>.NativeMethodInfoPtr_set_ModData_Public_Abstract_Virtual_New_set_Void_ModificationData_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static IModification()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<IModification<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", "IModification`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IModification<T>.NativeMethodInfoPtr_get_ModData_Public_Abstract_Virtual_New_get_ModificationData_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModification<T>>.NativeClassPtr, 100665727);
      IModification<T>.NativeMethodInfoPtr_set_ModData_Public_Abstract_Virtual_New_set_Void_ModificationData_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModification<T>>.NativeClassPtr, 100665728);
    }

    public IModification(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
