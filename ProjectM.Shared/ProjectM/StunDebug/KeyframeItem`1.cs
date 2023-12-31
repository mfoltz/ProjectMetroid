// Decompiled with JetBrains decompiler
// Type: ProjectM.StunDebug.KeyframeItem`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.StunDebug
{
  [Serializable]
  public sealed class KeyframeItem<T> : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Time;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_Single_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770794, RefRangeEnd = 770795, XrefRangeStart = 770794, XrefRangeEnd = 770795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe KeyframeItem(T value, float time)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyframeItem<T>>.NativeClassPtr))
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) value;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *numPtr2 = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KeyframeItem<T>.NativeMethodInfoPtr__ctor_Public_Void_T_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static KeyframeItem()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<KeyframeItem<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.StunDebug", "KeyframeItem`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyframeItem<T>>.NativeClassPtr);
      KeyframeItem<T>.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyframeItem<T>>.NativeClassPtr, nameof (Value));
      KeyframeItem<T>.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyframeItem<T>>.NativeClassPtr, nameof (Time));
      KeyframeItem<T>.NativeMethodInfoPtr__ctor_Public_Void_T_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeItem<T>>.NativeClassPtr, 100668270);
    }

    public KeyframeItem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public KeyframeItem()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyframeItem<T>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyframeItem<T>>.NativeClassPtr, data));
    }

    public unsafe T Value
    {
      get
      {
        return IL2CPP.PointerToValueGeneric<T>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyframeItem<T>.NativeFieldInfoPtr_Value), true, false);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr targetAddress = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KeyframeItem<T>.NativeFieldInfoPtr_Value);
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

    public unsafe float Time
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyframeItem<T>.NativeFieldInfoPtr_Time));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyframeItem<T>.NativeFieldInfoPtr_Time)) = value;
      }
    }
  }
}
