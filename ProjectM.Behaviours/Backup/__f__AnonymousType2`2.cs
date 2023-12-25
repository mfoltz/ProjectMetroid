// Decompiled with JetBrains decompiler
// Type: __f__AnonymousType2`2
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
[ObfuscatedName("<>f__AnonymousType2`2")]
public sealed class __f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar> : 
  Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr____h__TransparentIdentifier1_i__Field;
  private static readonly System.IntPtr NativeFieldInfoPtr__maxRange_i__Field;
  private static readonly System.IntPtr NativeMethodInfoPtr_get___h__TransparentIdentifier1_Public_get_\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_maxRange_Public_get_\u003CmaxRange\u003Ej__TPar_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar_\u003CmaxRange\u003Ej__TPar_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

  public unsafe \u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar \u003C\u003Eh__TransparentIdentifier1
  {
    [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>.NativeMethodInfoPtr_get___h__TransparentIdentifier1_Public_get_\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar>(objectPointer, false, true);
    }
  }

  public unsafe \u003CmaxRange\u003Ej__TPar maxRange
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>.NativeMethodInfoPtr_get_maxRange_Public_get_\u003CmaxRange\u003Ej__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<\u003CmaxRange\u003Ej__TPar>(objectPointer, false, true);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1320499, RefRangeEnd = 1320500, XrefRangeStart = 1320497, XrefRangeEnd = 1320499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe __f__AnonymousType2(
    \u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar _param1,
    \u003CmaxRange\u003Ej__TPar maxRange)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>>.NativeClassPtr))
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    \u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar& local1;
    if (!typeof (\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar> local2 = (object) _param1;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref _param1;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    \u003CmaxRange\u003Ej__TPar& local3;
    if (!typeof (\u003CmaxRange\u003Ej__TPar).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<\u003CmaxRange\u003Ej__TPar> local4 = (object) maxRange;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local3 = local4 is string ? (\u003CmaxRange\u003Ej__TPar&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (\u003CmaxRange\u003Ej__TPar&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
    }
    else
      local3 = ref maxRange;
    *(System.IntPtr*) num = (System.IntPtr) ref local3;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>.NativeMethodInfoPtr__ctor_Public_Void_\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar_\u003CmaxRange\u003Ej__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Equals(Il2CppSystem.Object value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public override unsafe int GetHashCode()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1320500, XrefRangeEnd = 1320520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  static __f__AnonymousType2()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<__f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "", "<>f__AnonymousType2`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<\u003CmaxRange\u003Ej__TPar>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>>.NativeClassPtr);
    __f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>.NativeFieldInfoPtr____h__TransparentIdentifier1_i__Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>>.NativeClassPtr, "<<>h__TransparentIdentifier1>i__Field");
    __f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>.NativeFieldInfoPtr__maxRange_i__Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>>.NativeClassPtr, "<maxRange>i__Field");
    __f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>.NativeMethodInfoPtr_get___h__TransparentIdentifier1_Public_get_\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>>.NativeClassPtr, 100663309);
    __f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>.NativeMethodInfoPtr_get_maxRange_Public_get_\u003CmaxRange\u003Ej__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>>.NativeClassPtr, 100663310);
    __f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>.NativeMethodInfoPtr__ctor_Public_Void_\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar_\u003CmaxRange\u003Ej__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>>.NativeClassPtr, 100663311);
    __f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>>.NativeClassPtr, 100663312);
    __f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>>.NativeClassPtr, 100663313);
    __f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>>.NativeClassPtr, 100663314);
  }

  public __f__AnonymousType2(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe \u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar ___h__TransparentIdentifier1_i__Field
  {
    get
    {
      return IL2CPP.PointerToValueGeneric<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(__f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>.NativeFieldInfoPtr____h__TransparentIdentifier1_i__Field), true, false);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr targetAddress = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(__f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>.NativeFieldInfoPtr____h__TransparentIdentifier1_i__Field);
      System.Type type = typeof (\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar);
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
        \u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar identifier1JTpar = value;
        *(\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar*) targetAddress = identifier1JTpar;
      }
    }
  }

  public unsafe \u003CmaxRange\u003Ej__TPar _maxRange_i__Field
  {
    get
    {
      return IL2CPP.PointerToValueGeneric<\u003CmaxRange\u003Ej__TPar>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(__f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>.NativeFieldInfoPtr__maxRange_i__Field), true, false);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr targetAddress = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(__f__AnonymousType2<\u003C\u003C\u003Eh__TransparentIdentifier1\u003Ej__TPar, \u003CmaxRange\u003Ej__TPar>.NativeFieldInfoPtr__maxRange_i__Field);
      System.Type type = typeof (\u003CmaxRange\u003Ej__TPar);
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
        \u003CmaxRange\u003Ej__TPar maxRangeJTpar = value;
        *(\u003CmaxRange\u003Ej__TPar*) targetAddress = maxRangeJTpar;
      }
    }
  }
}
