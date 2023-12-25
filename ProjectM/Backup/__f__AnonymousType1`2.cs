// Decompiled with JetBrains decompiler
// Type: __f__AnonymousType1`2
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
[ObfuscatedName("<>f__AnonymousType1`2")]
public sealed class __f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar> : 
  Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr__skin_i__Field;
  private static readonly System.IntPtr NativeFieldInfoPtr__prefabGuidComponent_i__Field;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_skin_Public_get_\u003Cskin\u003Ej__TPar_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_prefabGuidComponent_Public_get_\u003CprefabGuidComponent\u003Ej__TPar_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_\u003Cskin\u003Ej__TPar_\u003CprefabGuidComponent\u003Ej__TPar_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

  public unsafe \u003Cskin\u003Ej__TPar skin
  {
    [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>.NativeMethodInfoPtr_get_skin_Public_get_\u003Cskin\u003Ej__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<\u003Cskin\u003Ej__TPar>(objectPointer, false, true);
    }
  }

  public unsafe \u003CprefabGuidComponent\u003Ej__TPar prefabGuidComponent
  {
    [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>.NativeMethodInfoPtr_get_prefabGuidComponent_Public_get_\u003CprefabGuidComponent\u003Ej__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<\u003CprefabGuidComponent\u003Ej__TPar>(objectPointer, false, true);
    }
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 908041, RefRangeEnd = 908048, XrefRangeStart = 908041, XrefRangeEnd = 908048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe __f__AnonymousType1(
    \u003Cskin\u003Ej__TPar skin,
    \u003CprefabGuidComponent\u003Ej__TPar prefabGuidComponent)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>>.NativeClassPtr))
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    \u003Cskin\u003Ej__TPar& local1;
    if (!typeof (\u003Cskin\u003Ej__TPar).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<\u003Cskin\u003Ej__TPar> local2 = (object) skin;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (\u003Cskin\u003Ej__TPar&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (\u003Cskin\u003Ej__TPar&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref skin;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    \u003CprefabGuidComponent\u003Ej__TPar& local3;
    if (!typeof (\u003CprefabGuidComponent\u003Ej__TPar).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<\u003CprefabGuidComponent\u003Ej__TPar> local4 = (object) prefabGuidComponent;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local3 = local4 is string ? (\u003CprefabGuidComponent\u003Ej__TPar&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (\u003CprefabGuidComponent\u003Ej__TPar&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
    }
    else
      local3 = ref prefabGuidComponent;
    *(System.IntPtr*) num = (System.IntPtr) ref local3;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>.NativeMethodInfoPtr__ctor_Public_Void_\u003Cskin\u003Ej__TPar_\u003CprefabGuidComponent\u003Ej__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911978, XrefRangeEnd = 911981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Equals(Il2CppSystem.Object value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  public override unsafe int GetHashCode()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911981, XrefRangeEnd = 912001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  static __f__AnonymousType1()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<__f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.dll", "", "<>f__AnonymousType1`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<\u003Cskin\u003Ej__TPar>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<\u003CprefabGuidComponent\u003Ej__TPar>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>>.NativeClassPtr);
    __f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>.NativeFieldInfoPtr__skin_i__Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>>.NativeClassPtr, "<skin>i__Field");
    __f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>.NativeFieldInfoPtr__prefabGuidComponent_i__Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>>.NativeClassPtr, "<prefabGuidComponent>i__Field");
    __f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>.NativeMethodInfoPtr_get_skin_Public_get_\u003Cskin\u003Ej__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>>.NativeClassPtr, 100663303);
    __f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>.NativeMethodInfoPtr_get_prefabGuidComponent_Public_get_\u003CprefabGuidComponent\u003Ej__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>>.NativeClassPtr, 100663304);
    __f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>.NativeMethodInfoPtr__ctor_Public_Void_\u003Cskin\u003Ej__TPar_\u003CprefabGuidComponent\u003Ej__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>>.NativeClassPtr, 100663305);
    __f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>>.NativeClassPtr, 100663306);
    __f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>>.NativeClassPtr, 100663307);
    __f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>>.NativeClassPtr, 100663308);
  }

  public __f__AnonymousType1(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe \u003Cskin\u003Ej__TPar _skin_i__Field
  {
    get
    {
      return IL2CPP.PointerToValueGeneric<\u003Cskin\u003Ej__TPar>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(__f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>.NativeFieldInfoPtr__skin_i__Field), true, false);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr targetAddress = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(__f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>.NativeFieldInfoPtr__skin_i__Field);
      System.Type type = typeof (\u003Cskin\u003Ej__TPar);
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
        \u003Cskin\u003Ej__TPar skinJTpar = value;
        *(\u003Cskin\u003Ej__TPar*) targetAddress = skinJTpar;
      }
    }
  }

  public unsafe \u003CprefabGuidComponent\u003Ej__TPar _prefabGuidComponent_i__Field
  {
    get
    {
      return IL2CPP.PointerToValueGeneric<\u003CprefabGuidComponent\u003Ej__TPar>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(__f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>.NativeFieldInfoPtr__prefabGuidComponent_i__Field), true, false);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr targetAddress = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(__f__AnonymousType1<\u003Cskin\u003Ej__TPar, \u003CprefabGuidComponent\u003Ej__TPar>.NativeFieldInfoPtr__prefabGuidComponent_i__Field);
      System.Type type = typeof (\u003CprefabGuidComponent\u003Ej__TPar);
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
        \u003CprefabGuidComponent\u003Ej__TPar guidComponentJTpar = value;
        *(\u003CprefabGuidComponent\u003Ej__TPar*) targetAddress = guidComponentJTpar;
      }
    }
  }
}
