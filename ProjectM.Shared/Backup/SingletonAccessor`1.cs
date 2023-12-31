// Decompiled with JetBrains decompiler
// Type: SingletonAccessor`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Unity.Entities;

#nullable disable
public struct SingletonAccessor<T>
{
  private static readonly System.IntPtr NativeFieldInfoPtr__SingletonQuery;
  private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_SingletonAccessor_1_T_EntityManager_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasSingleton_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSingleton_Public_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSingleton_Public_Void_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSingleton_Public_Boolean_byref_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSingletonEntity_Public_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSingletonEntity_Public_Boolean_byref_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  public EntityQuery _SingletonQuery;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 716188, RefRangeEnd = 716189, XrefRangeStart = 716178, XrefRangeEnd = 716188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe SingletonAccessor<T> Create(EntityManager entityManager)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &entityManager;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SingletonAccessor<T>.NativeMethodInfoPtr_Create_Public_Static_SingletonAccessor_1_T_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(SingletonAccessor<T>*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(154)]
  [CachedScanResults(RefRangeStart = 716190, RefRangeEnd = 716344, XrefRangeStart = 716189, XrefRangeEnd = 716190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HasSingleton()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SingletonAccessor<T>.NativeMethodInfoPtr_HasSingleton_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716344, XrefRangeEnd = 716350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe T GetSingleton()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(SingletonAccessor<T>.NativeMethodInfoPtr_GetSingleton_Public_T_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716350, XrefRangeEnd = 716354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSingleton(T value)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
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
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SingletonAccessor<T>.NativeMethodInfoPtr_SetSingleton_Public_Void_T_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716354, XrefRangeEnd = 716356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGetSingleton(out T result)
  {
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
      local1 = ref result;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SingletonAccessor<T>.NativeMethodInfoPtr_TryGetSingleton_Public_Boolean_byref_T_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    if (!typeof (T).IsValueType)
    {
      ref T local2 = ref result;
      System.IntPtr objectPointer = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
      local2 = (T) valueGeneric;
    }
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(36)]
  [CachedScanResults(RefRangeStart = 716359, RefRangeEnd = 716395, XrefRangeStart = 716356, XrefRangeEnd = 716359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Entity GetSingletonEntity()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SingletonAccessor<T>.NativeMethodInfoPtr_GetSingletonEntity_Public_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 716397, RefRangeEnd = 716399, XrefRangeStart = 716395, XrefRangeEnd = 716397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGetSingletonEntity(out Entity result)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) ref result;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SingletonAccessor<T>.NativeMethodInfoPtr_TryGetSingletonEntity_Public_Boolean_byref_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(206)]
  [CachedScanResults(RefRangeStart = 716400, RefRangeEnd = 716606, XrefRangeStart = 716399, XrefRangeEnd = 716400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SingletonAccessor<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SingletonAccessor()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<SingletonAccessor<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", "SingletonAccessor`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingletonAccessor<T>>.NativeClassPtr);
    SingletonAccessor<T>.NativeFieldInfoPtr__SingletonQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingletonAccessor<T>>.NativeClassPtr, nameof (_SingletonQuery));
    SingletonAccessor<T>.NativeMethodInfoPtr_Create_Public_Static_SingletonAccessor_1_T_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonAccessor<T>>.NativeClassPtr, 100663441);
    SingletonAccessor<T>.NativeMethodInfoPtr_HasSingleton_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonAccessor<T>>.NativeClassPtr, 100663442);
    SingletonAccessor<T>.NativeMethodInfoPtr_GetSingleton_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonAccessor<T>>.NativeClassPtr, 100663443);
    SingletonAccessor<T>.NativeMethodInfoPtr_SetSingleton_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonAccessor<T>>.NativeClassPtr, 100663444);
    SingletonAccessor<T>.NativeMethodInfoPtr_TryGetSingleton_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonAccessor<T>>.NativeClassPtr, 100663445);
    SingletonAccessor<T>.NativeMethodInfoPtr_GetSingletonEntity_Public_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonAccessor<T>>.NativeClassPtr, 100663446);
    SingletonAccessor<T>.NativeMethodInfoPtr_TryGetSingletonEntity_Public_Boolean_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonAccessor<T>>.NativeClassPtr, 100663447);
    SingletonAccessor<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingletonAccessor<T>>.NativeClassPtr, 100663448);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SingletonAccessor<T>>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
