// Decompiled with JetBrains decompiler
// Type: ProjectM.ManagedDataRegistry
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public sealed class ManagedDataRegistry : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__DataLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabLookupMap;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_PrefabLookupKey_Object_PrefabLookupMap_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGet_Public_Boolean_PrefabGUID_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOrDefault_Public_T_PrefabGUID_T_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 751260, RefRangeEnd = 751261, XrefRangeStart = 751259, XrefRangeEnd = 751260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ManagedDataRegistry(
      Dictionary<PrefabLookupKey, Il2CppSystem.Object> dataLookupMap,
      PrefabLookupMap prefabLookupMap)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedDataRegistry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dataLookupMap);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ManagedDataRegistry.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_PrefabLookupKey_Object_PrefabLookupMap_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(189)]
    [CachedScanResults(RefRangeStart = 751265, RefRangeEnd = 751454, XrefRangeStart = 751261, XrefRangeEnd = 751265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGet<T>(PrefabGUID prefabGUID, out T component) where T : class
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &prefabGUID;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(T*) &zero);
      }
      else
        local1 = ref component;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ManagedDataRegistry.MethodInfoStoreGeneric_TryGet_Public_Boolean_PrefabGUID_byref_T_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref component;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 751458, RefRangeEnd = 751467, XrefRangeStart = 751454, XrefRangeEnd = 751458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe T GetOrDefault<T>(PrefabGUID prefabGUID, T defaultValue = null) where T : class
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &prefabGUID;
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) defaultValue;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref defaultValue;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(ManagedDataRegistry.MethodInfoStoreGeneric_GetOrDefault_Public_T_PrefabGUID_T_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    static ManagedDataRegistry()
    {
      Il2CppClassPointerStore<ManagedDataRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ManagedDataRegistry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedDataRegistry>.NativeClassPtr);
      ManagedDataRegistry.NativeFieldInfoPtr__DataLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedDataRegistry>.NativeClassPtr, nameof (_DataLookupMap));
      ManagedDataRegistry.NativeFieldInfoPtr__PrefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedDataRegistry>.NativeClassPtr, nameof (_PrefabLookupMap));
      ManagedDataRegistry.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_PrefabLookupKey_Object_PrefabLookupMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedDataRegistry>.NativeClassPtr, 100666162);
      ManagedDataRegistry.NativeMethodInfoPtr_TryGet_Public_Boolean_PrefabGUID_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedDataRegistry>.NativeClassPtr, 100666163);
      ManagedDataRegistry.NativeMethodInfoPtr_GetOrDefault_Public_T_PrefabGUID_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedDataRegistry>.NativeClassPtr, 100666164);
    }

    public ManagedDataRegistry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ManagedDataRegistry()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ManagedDataRegistry>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ManagedDataRegistry>.NativeClassPtr, data));
    }

    public unsafe Dictionary<PrefabLookupKey, Il2CppSystem.Object> _DataLookupMap
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedDataRegistry.NativeFieldInfoPtr__DataLookupMap));
        return pointer == System.IntPtr.Zero ? (Dictionary<PrefabLookupKey, Il2CppSystem.Object>) null : new Dictionary<PrefabLookupKey, Il2CppSystem.Object>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ManagedDataRegistry.NativeFieldInfoPtr__DataLookupMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabLookupMap _PrefabLookupMap
    {
      get
      {
        return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedDataRegistry.NativeFieldInfoPtr__PrefabLookupMap));
      }
      [param: In] set
      {
        *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedDataRegistry.NativeFieldInfoPtr__PrefabLookupMap)) = value;
      }
    }

    private sealed class MethodInfoStoreGeneric_TryGet_Public_Boolean_PrefabGUID_byref_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ManagedDataRegistry.NativeMethodInfoPtr_TryGet_Public_Boolean_PrefabGUID_byref_T_0, Il2CppClassPointerStore<ManagedDataRegistry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetOrDefault_Public_T_PrefabGUID_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ManagedDataRegistry.NativeMethodInfoPtr_GetOrDefault_Public_T_PrefabGUID_T_0, Il2CppClassPointerStore<ManagedDataRegistry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
