// Decompiled with JetBrains decompiler
// Type: ProjectM.NestedEntitiesHelpers
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class NestedEntitiesHelpers : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetNestedEntitiesWith_Public_Static_Void_EntityManager_Entity_NativeList_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetNestedComponentDatas_Public_Static_Void_EntityManager_Entity_NativeList_1_T0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetNestedComponentDatas_Public_Static_Void_EntityManager_Entity_NativeList_1_T0_NativeList_1_T1_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 764493, RefRangeEnd = 764494, XrefRangeStart = 764474, XrefRangeEnd = 764493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryGetNestedEntitiesWith<T0>(
      EntityManager entityManager,
      Entity parentEntity,
      NativeList<Entity> result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &parentEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NestedEntitiesHelpers.MethodInfoStoreGeneric_TryGetNestedEntitiesWith_Public_Static_Void_EntityManager_Entity_NativeList_1_Entity_0<T0>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe void TryGetNestedComponentDatas<T0>(
      EntityManager entityManager,
      Entity parentEntity,
      NativeList<T0> result0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &parentEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &result0;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NestedEntitiesHelpers.MethodInfoStoreGeneric_TryGetNestedComponentDatas_Public_Static_Void_EntityManager_Entity_NativeList_1_T0_0<T0>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe void TryGetNestedComponentDatas<T0, T1>(
      EntityManager entityManager,
      Entity parentEntity,
      NativeList<T0> result0,
      NativeList<T1> result1)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &parentEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &result0;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &result1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NestedEntitiesHelpers.MethodInfoStoreGeneric_TryGetNestedComponentDatas_Public_Static_Void_EntityManager_Entity_NativeList_1_T0_NativeList_1_T1_0<T0, T1>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NestedEntitiesHelpers()
    {
      Il2CppClassPointerStore<NestedEntitiesHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (NestedEntitiesHelpers));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NestedEntitiesHelpers>.NativeClassPtr);
      NestedEntitiesHelpers.NativeMethodInfoPtr_TryGetNestedEntitiesWith_Public_Static_Void_EntityManager_Entity_NativeList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedEntitiesHelpers>.NativeClassPtr, 100667527);
      NestedEntitiesHelpers.NativeMethodInfoPtr_TryGetNestedComponentDatas_Public_Static_Void_EntityManager_Entity_NativeList_1_T0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedEntitiesHelpers>.NativeClassPtr, 100667528);
      NestedEntitiesHelpers.NativeMethodInfoPtr_TryGetNestedComponentDatas_Public_Static_Void_EntityManager_Entity_NativeList_1_T0_NativeList_1_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NestedEntitiesHelpers>.NativeClassPtr, 100667529);
    }

    public NestedEntitiesHelpers(System.IntPtr pointer)
      : base(pointer)
    {
    }

    private sealed class MethodInfoStoreGeneric_TryGetNestedEntitiesWith_Public_Static_Void_EntityManager_Entity_NativeList_1_Entity_0<T0>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NestedEntitiesHelpers.NativeMethodInfoPtr_TryGetNestedEntitiesWith_Public_Static_Void_EntityManager_Entity_NativeList_1_Entity_0, Il2CppClassPointerStore<NestedEntitiesHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetNestedComponentDatas_Public_Static_Void_EntityManager_Entity_NativeList_1_T0_0<T0>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NestedEntitiesHelpers.NativeMethodInfoPtr_TryGetNestedComponentDatas_Public_Static_Void_EntityManager_Entity_NativeList_1_T0_0, Il2CppClassPointerStore<NestedEntitiesHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_TryGetNestedComponentDatas_Public_Static_Void_EntityManager_Entity_NativeList_1_T0_NativeList_1_T1_0<T0, T1>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(NestedEntitiesHelpers.NativeMethodInfoPtr_TryGetNestedComponentDatas_Public_Static_Void_EntityManager_Entity_NativeList_1_T0_NativeList_1_T1_0, Il2CppClassPointerStore<NestedEntitiesHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
      }))));
    }
  }
}
