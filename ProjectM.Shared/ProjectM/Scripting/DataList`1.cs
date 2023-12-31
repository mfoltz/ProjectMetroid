// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.DataList`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Scripting
{
  public struct DataList<T>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr__EntityManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__List;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Capacity_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCreated_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddRange_Public_Void_DataList_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAtSwapBack_Public_Void_Int32_0;
    public Entity _Entity;
    public EntityManager _EntityManager;
    public NativeList<T> _List;

    [CallerCount(0)]
    public unsafe DataList(Entity entity, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DataList<T>.NativeMethodInfoPtr__ctor_Public_Void_Entity_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DataList<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe IEnumerator<T> GetEnumerator()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DataList<T>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator<T>) null : new IEnumerator<T>(pointer);
    }

    [CallerCount(0)]
    public virtual unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DataList<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    public unsafe T this[int index]
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &index;
        System.IntPtr exc;
        System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(DataList<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &index;
        System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
        T& local1;
        if (!typeof (T).IsValueType)
        {
          __Boxed<T> local2 = (object) value;
          local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
        }
        else
          local1 = ref value;
        *(System.IntPtr*) num = (System.IntPtr) ref local1;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DataList<T>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int Length
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DataList<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int Capacity
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DataList<T>.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DataList<T>.NativeMethodInfoPtr_set_Capacity_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool IsCreated
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DataList<T>.NativeMethodInfoPtr_get_IsCreated_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    public unsafe void Add(T element)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) element;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref element;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DataList<T>.NativeMethodInfoPtr_Add_Public_Void_T_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void AddRange(DataList<T> dataList)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &dataList;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DataList<T>.NativeMethodInfoPtr_AddRange_Public_Void_DataList_1_T_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void Clear()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DataList<T>.NativeMethodInfoPtr_Clear_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void RemoveAtSwapBack(int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DataList<T>.NativeMethodInfoPtr_RemoveAtSwapBack_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DataList()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<DataList<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", "DataList`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataList<T>>.NativeClassPtr);
      DataList<T>.NativeFieldInfoPtr__Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataList<T>>.NativeClassPtr, nameof (_Entity));
      DataList<T>.NativeFieldInfoPtr__EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataList<T>>.NativeClassPtr, nameof (_EntityManager));
      DataList<T>.NativeFieldInfoPtr__List = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataList<T>>.NativeClassPtr, nameof (_List));
      DataList<T>.NativeMethodInfoPtr__ctor_Public_Void_Entity_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataList<T>>.NativeClassPtr, 100668640);
      DataList<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataList<T>>.NativeClassPtr, 100668641);
      DataList<T>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataList<T>>.NativeClassPtr, 100668642);
      DataList<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataList<T>>.NativeClassPtr, 100668643);
      DataList<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataList<T>>.NativeClassPtr, 100668644);
      DataList<T>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataList<T>>.NativeClassPtr, 100668645);
      DataList<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataList<T>>.NativeClassPtr, 100668646);
      DataList<T>.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataList<T>>.NativeClassPtr, 100668647);
      DataList<T>.NativeMethodInfoPtr_set_Capacity_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataList<T>>.NativeClassPtr, 100668648);
      DataList<T>.NativeMethodInfoPtr_get_IsCreated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataList<T>>.NativeClassPtr, 100668649);
      DataList<T>.NativeMethodInfoPtr_Add_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataList<T>>.NativeClassPtr, 100668650);
      DataList<T>.NativeMethodInfoPtr_AddRange_Public_Void_DataList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataList<T>>.NativeClassPtr, 100668651);
      DataList<T>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataList<T>>.NativeClassPtr, 100668652);
      DataList<T>.NativeMethodInfoPtr_RemoveAtSwapBack_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataList<T>>.NativeClassPtr, 100668653);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DataList<T>>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
