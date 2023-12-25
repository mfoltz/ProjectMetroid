// Decompiled with JetBrains decompiler
// Type: ProjectM.Compatibility.IPersistenceCompatibilityComparable`1
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

#nullable disable
namespace ProjectM.Compatibility
{
  public class IPersistenceCompatibilityComparable<T> : Il2CppObjectBase
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_CanLoadSaveFrom_Public_Abstract_Virtual_New_Void_T_PersistenceCompatibilityChecker_0;

    [CallerCount(0)]
    public virtual unsafe void CanLoadSaveFrom(
      T previousVersion,
      PersistenceCompatibilityChecker checker)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) previousVersion;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref previousVersion;
      *numPtr2 = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checker);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPersistenceCompatibilityComparable<T>.NativeMethodInfoPtr_CanLoadSaveFrom_Public_Abstract_Virtual_New_Void_T_PersistenceCompatibilityChecker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IPersistenceCompatibilityComparable()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<IPersistenceCompatibilityComparable<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Compatibility", "IPersistenceCompatibilityComparable`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IPersistenceCompatibilityComparable<T>.NativeMethodInfoPtr_CanLoadSaveFrom_Public_Abstract_Virtual_New_Void_T_PersistenceCompatibilityChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceCompatibilityComparable<T>>.NativeClassPtr, 100687972);
    }

    public IPersistenceCompatibilityComparable(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
