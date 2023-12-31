// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.Comparison`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  public sealed class Comparison<TValue> : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_ValueRHS;

    static Comparison()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<Comparison<TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", "Comparison`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Comparison<TValue>>.NativeClassPtr);
      Comparison<TValue>.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Comparison<TValue>>.NativeClassPtr, nameof (Type));
      Comparison<TValue>.NativeFieldInfoPtr_ValueRHS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Comparison<TValue>>.NativeClassPtr, nameof (ValueRHS));
    }

    public Comparison(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Comparison()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Comparison<TValue>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Comparison<TValue>>.NativeClassPtr, data));
    }

    public unsafe ConditionTypes Type
    {
      get
      {
        return *(ConditionTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Comparison<TValue>.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(ConditionTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Comparison<TValue>.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe TValue ValueRHS
    {
      get
      {
        return IL2CPP.PointerToValueGeneric<TValue>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Comparison<TValue>.NativeFieldInfoPtr_ValueRHS), true, false);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr targetAddress = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Comparison<TValue>.NativeFieldInfoPtr_ValueRHS);
        System.Type type = typeof (TValue);
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
          TValue obj = value;
          *(TValue*) targetAddress = obj;
        }
      }
    }
  }
}
