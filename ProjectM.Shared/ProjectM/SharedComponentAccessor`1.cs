// Decompiled with JetBrains decompiler
// Type: ProjectM.SharedComponentAccessor`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public struct SharedComponentAccessor<T>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SharedComponents;
    private static readonly System.IntPtr NativeFieldInfoPtr_SharedComponentType;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSharedComponent_Public_Boolean_ArchetypeChunk_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSharedComponent_Public_T_ArchetypeChunk_0;
    public NativeHashMap<int, T> SharedComponents;
    public SharedComponentTypeHandle<T> SharedComponentType;

    [CallerCount(0)]
    public unsafe bool TryGetSharedComponent(ArchetypeChunk chunk, out T value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &chunk;
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
        local1 = ref value;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SharedComponentAccessor<T>.NativeMethodInfoPtr_TryGetSharedComponent_Public_Boolean_ArchetypeChunk_byref_T_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref value;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe T GetSharedComponent(ArchetypeChunk chunk)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &chunk;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(SharedComponentAccessor<T>.NativeMethodInfoPtr_GetSharedComponent_Public_T_ArchetypeChunk_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    static SharedComponentAccessor()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<SharedComponentAccessor<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", "SharedComponentAccessor`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedComponentAccessor<T>>.NativeClassPtr);
      SharedComponentAccessor<T>.NativeFieldInfoPtr_SharedComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedComponentAccessor<T>>.NativeClassPtr, nameof (SharedComponents));
      SharedComponentAccessor<T>.NativeFieldInfoPtr_SharedComponentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedComponentAccessor<T>>.NativeClassPtr, nameof (SharedComponentType));
      SharedComponentAccessor<T>.NativeMethodInfoPtr_TryGetSharedComponent_Public_Boolean_ArchetypeChunk_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedComponentAccessor<T>>.NativeClassPtr, 100667584);
      SharedComponentAccessor<T>.NativeMethodInfoPtr_GetSharedComponent_Public_T_ArchetypeChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedComponentAccessor<T>>.NativeClassPtr, 100667585);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SharedComponentAccessor<T>>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
