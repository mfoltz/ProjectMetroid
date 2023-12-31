// Decompiled with JetBrains decompiler
// Type: ProjectM.SharedComponentAccessManager`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;

#nullable disable
namespace ProjectM
{
  public class SharedComponentAccessManager<T> : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SharedComponents;
    private static readonly System.IntPtr NativeFieldInfoPtr__Indexes;
    private static readonly System.IntPtr NativeFieldInfoPtr__ComponentsByIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__JobHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr__EntityManager;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAccessor_Public_SharedComponentAccessor_1_T_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddJobDependency_Public_Void_JobHandle_0;

    [CallerCount(0)]
    public unsafe SharedComponentAccessManager(EntityManager entityManager)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedComponentAccessManager<T>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SharedComponentAccessManager<T>.NativeMethodInfoPtr__ctor_Public_Void_EntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SharedComponentAccessManager<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void Update(bool updateSharedComponentCollection = true)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &updateSharedComponentCollection;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SharedComponentAccessManager<T>.NativeMethodInfoPtr_Update_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe SharedComponentAccessor<T> GetAccessor(EntityManager entityManager)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SharedComponentAccessManager<T>.NativeMethodInfoPtr_GetAccessor_Public_SharedComponentAccessor_1_T_EntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SharedComponentAccessor<T>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void AddJobDependency(JobHandle jobHandle)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &jobHandle;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SharedComponentAccessManager<T>.NativeMethodInfoPtr_AddJobDependency_Public_Void_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SharedComponentAccessManager()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<SharedComponentAccessManager<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", "SharedComponentAccessManager`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedComponentAccessManager<T>>.NativeClassPtr);
      SharedComponentAccessManager<T>.NativeFieldInfoPtr__SharedComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedComponentAccessManager<T>>.NativeClassPtr, nameof (_SharedComponents));
      SharedComponentAccessManager<T>.NativeFieldInfoPtr__Indexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedComponentAccessManager<T>>.NativeClassPtr, nameof (_Indexes));
      SharedComponentAccessManager<T>.NativeFieldInfoPtr__ComponentsByIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedComponentAccessManager<T>>.NativeClassPtr, nameof (_ComponentsByIndex));
      SharedComponentAccessManager<T>.NativeFieldInfoPtr__JobHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedComponentAccessManager<T>>.NativeClassPtr, nameof (_JobHandle));
      SharedComponentAccessManager<T>.NativeFieldInfoPtr__EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedComponentAccessManager<T>>.NativeClassPtr, nameof (_EntityManager));
      SharedComponentAccessManager<T>.NativeMethodInfoPtr__ctor_Public_Void_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedComponentAccessManager<T>>.NativeClassPtr, 100667579);
      SharedComponentAccessManager<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedComponentAccessManager<T>>.NativeClassPtr, 100667580);
      SharedComponentAccessManager<T>.NativeMethodInfoPtr_Update_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedComponentAccessManager<T>>.NativeClassPtr, 100667581);
      SharedComponentAccessManager<T>.NativeMethodInfoPtr_GetAccessor_Public_SharedComponentAccessor_1_T_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedComponentAccessManager<T>>.NativeClassPtr, 100667582);
      SharedComponentAccessManager<T>.NativeMethodInfoPtr_AddJobDependency_Public_Void_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedComponentAccessManager<T>>.NativeClassPtr, 100667583);
    }

    public SharedComponentAccessManager(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<T> _SharedComponents
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SharedComponentAccessManager<T>.NativeFieldInfoPtr__SharedComponents));
        return pointer == System.IntPtr.Zero ? (List<T>) null : new List<T>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SharedComponentAccessManager<T>.NativeFieldInfoPtr__SharedComponents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<int> _Indexes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SharedComponentAccessManager<T>.NativeFieldInfoPtr__Indexes));
        return pointer == System.IntPtr.Zero ? (List<int>) null : new List<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SharedComponentAccessManager<T>.NativeFieldInfoPtr__Indexes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeHashMap<int, T> _ComponentsByIndex
    {
      get
      {
        return *(NativeHashMap<int, T>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SharedComponentAccessManager<T>.NativeFieldInfoPtr__ComponentsByIndex));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SharedComponentAccessManager<T>.NativeFieldInfoPtr__ComponentsByIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, T>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe JobHandle _JobHandle
    {
      get
      {
        return *(JobHandle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SharedComponentAccessManager<T>.NativeFieldInfoPtr__JobHandle));
      }
      [param: In] set
      {
        *(JobHandle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SharedComponentAccessManager<T>.NativeFieldInfoPtr__JobHandle)) = value;
      }
    }

    public unsafe EntityManager _EntityManager
    {
      get
      {
        return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SharedComponentAccessManager<T>.NativeFieldInfoPtr__EntityManager));
      }
      [param: In] set
      {
        *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SharedComponentAccessManager<T>.NativeFieldInfoPtr__EntityManager)) = value;
      }
    }
  }
}
