// Decompiled with JetBrains decompiler
// Type: ProjectM.BindableSetting`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class BindableSetting<T> : BindableSetting
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomValue;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TryGetValue_b__1_0_Private_Boolean_FieldInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TryGetValue_b__1_1_Private_Boolean_FieldInfo_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763663, XrefRangeEnd = 763699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetValue(out T value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(T*) &zero);
      }
      else
        local1 = ref value;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BindableSetting<T>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref value;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(57)]
    [CachedScanResults(RefRangeStart = 262491, RefRangeEnd = 262548, XrefRangeStart = 262491, XrefRangeEnd = 262548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BindableSetting()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindableSetting<T>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BindableSetting<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763699, XrefRangeEnd = 763726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _TryGetValue_b__1_0(FieldInfo x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BindableSetting<T>.NativeMethodInfoPtr__TryGetValue_b__1_0_Private_Boolean_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763726, XrefRangeEnd = 763731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _TryGetValue_b__1_1(FieldInfo x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BindableSetting<T>.NativeMethodInfoPtr__TryGetValue_b__1_1_Private_Boolean_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static BindableSetting()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<BindableSetting<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", "BindableSetting`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindableSetting<T>>.NativeClassPtr);
      BindableSetting<T>.NativeFieldInfoPtr_CustomValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindableSetting<T>>.NativeClassPtr, nameof (CustomValue));
      BindableSetting<T>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindableSetting<T>>.NativeClassPtr, 100667473);
      BindableSetting<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindableSetting<T>>.NativeClassPtr, 100667474);
      BindableSetting<T>.NativeMethodInfoPtr__TryGetValue_b__1_0_Private_Boolean_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindableSetting<T>>.NativeClassPtr, 100667475);
      BindableSetting<T>.NativeMethodInfoPtr__TryGetValue_b__1_1_Private_Boolean_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindableSetting<T>>.NativeClassPtr, 100667476);
    }

    public BindableSetting(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe T CustomValue
    {
      get
      {
        return IL2CPP.PointerToValueGeneric<T>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BindableSetting<T>.NativeFieldInfoPtr_CustomValue), true, false);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr targetAddress = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BindableSetting<T>.NativeFieldInfoPtr_CustomValue);
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
  }
}
