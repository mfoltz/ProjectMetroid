// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.DelegateAndComponentType`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Scripting
{
  public sealed class DelegateAndComponentType<T> : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Invoke;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentType;

    static DelegateAndComponentType()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<DelegateAndComponentType<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", "DelegateAndComponentType`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateAndComponentType<T>>.NativeClassPtr);
      DelegateAndComponentType<T>.NativeFieldInfoPtr_Invoke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateAndComponentType<T>>.NativeClassPtr, nameof (Invoke));
      DelegateAndComponentType<T>.NativeFieldInfoPtr_ComponentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateAndComponentType<T>>.NativeClassPtr, nameof (ComponentType));
    }

    public DelegateAndComponentType(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public DelegateAndComponentType()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DelegateAndComponentType<T>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DelegateAndComponentType<T>>.NativeClassPtr, data));
    }

    public unsafe T Invoke
    {
      get
      {
        return IL2CPP.PointerToValueGeneric<T>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DelegateAndComponentType<T>.NativeFieldInfoPtr_Invoke), true, false);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr targetAddress = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DelegateAndComponentType<T>.NativeFieldInfoPtr_Invoke);
        System.Type type = typeof (T);
        if (!type.IsValueType)
        {
          if (!string.Equals(type.FullName, "System.String"))
          {
            System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((object) value as Il2CppObjectBase);
            if (ptr != System.IntPtr.Zero && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)))
            {
              System.IntPtr num1 = ptr;
              System.IntPtr num2 = IL2CPP.il2cpp_object_unbox(ptr);
              int num3 = IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(num1), (uint&) System.IntPtr.Zero);
              __memcpy(targetAddress, num2, num3);
            }
            else
              IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, targetAddress, ptr);
          }
          else
          {
            System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp((object) value as string);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, targetAddress, il2Cpp);
          }
        }
        else
        {
          T obj = value;
          *(T*) targetAddress = obj;
        }
      }
    }

    public unsafe string ComponentType
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DelegateAndComponentType<T>.NativeFieldInfoPtr_ComponentType)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DelegateAndComponentType<T>.NativeFieldInfoPtr_ComponentType), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
