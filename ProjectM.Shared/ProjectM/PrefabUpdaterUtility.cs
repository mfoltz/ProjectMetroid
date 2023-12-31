// Decompiled with JetBrains decompiler
// Type: ProjectM.PrefabUpdaterUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public static class PrefabUpdaterUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInstances_Public_Static_Void_GameObject_EntityManager_UpdateInstanceDelegate_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLinkedGroupInstances_Public_Static_Void_GameObject_EntityManager_UpdateInstanceDelegate_1_T_0;

    [CallerCount(0)]
    public static unsafe void UpdateInstances<T>(
      GameObject gameObject,
      EntityManager dstManager,
      PrefabUpdaterUtility.UpdateInstanceDelegate<T> update)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) update);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabUpdaterUtility.MethodInfoStoreGeneric_UpdateInstances_Public_Static_Void_GameObject_EntityManager_UpdateInstanceDelegate_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe void UpdateLinkedGroupInstances<T>(
      GameObject gameObject,
      EntityManager dstManager,
      PrefabUpdaterUtility.UpdateInstanceDelegate<T> update)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) update);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabUpdaterUtility.MethodInfoStoreGeneric_UpdateLinkedGroupInstances_Public_Static_Void_GameObject_EntityManager_UpdateInstanceDelegate_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PrefabUpdaterUtility()
    {
      Il2CppClassPointerStore<PrefabUpdaterUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PrefabUpdaterUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabUpdaterUtility>.NativeClassPtr);
      PrefabUpdaterUtility.NativeMethodInfoPtr_UpdateInstances_Public_Static_Void_GameObject_EntityManager_UpdateInstanceDelegate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabUpdaterUtility>.NativeClassPtr, 100667570);
      PrefabUpdaterUtility.NativeMethodInfoPtr_UpdateLinkedGroupInstances_Public_Static_Void_GameObject_EntityManager_UpdateInstanceDelegate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabUpdaterUtility>.NativeClassPtr, 100667571);
    }

    public PrefabUpdaterUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public sealed class UpdateInstanceDelegate<T> : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_T_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T_IAsyncResult_0;

      [CallerCount(0)]
      public unsafe UpdateInstanceDelegate(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabUpdaterUtility.UpdateInstanceDelegate<T>>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabUpdaterUtility.UpdateInstanceDelegate<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public virtual unsafe void Invoke(ref T d0)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
        System.IntPtr* numPtr2 = numPtr1;
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) d0);
        System.IntPtr* numPtr3 = &ptr;
        *numPtr2 = (System.IntPtr) numPtr3;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabUpdaterUtility.UpdateInstanceDelegate<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref T local = ref d0;
        System.IntPtr objectPointer = ptr;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local = (T) valueGeneric;
      }

      [CallerCount(0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        ref T d0,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
        System.IntPtr* numPtr2 = numPtr1;
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) d0);
        System.IntPtr* numPtr3 = &ptr;
        *numPtr2 = (System.IntPtr) numPtr3;
        *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabUpdaterUtility.UpdateInstanceDelegate<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_T_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref T local = ref d0;
        System.IntPtr objectPointer = ptr;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local = (T) valueGeneric;
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
      }

      [CallerCount(0)]
      public virtual unsafe void EndInvoke(ref T d0, Il2CppSystem.IAsyncResult result)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
        System.IntPtr* numPtr2 = numPtr1;
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) d0);
        System.IntPtr* numPtr3 = &ptr;
        *numPtr2 = (System.IntPtr) numPtr3;
        *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabUpdaterUtility.UpdateInstanceDelegate<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref T local = ref d0;
        System.IntPtr objectPointer = ptr;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local = (T) valueGeneric;
      }

      static UpdateInstanceDelegate()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<PrefabUpdaterUtility.UpdateInstanceDelegate<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabUpdaterUtility>.NativeClassPtr, "UpdateInstanceDelegate`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))).TypeHandle).value);
        PrefabUpdaterUtility.UpdateInstanceDelegate<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabUpdaterUtility.UpdateInstanceDelegate<T>>.NativeClassPtr, 100667572);
        PrefabUpdaterUtility.UpdateInstanceDelegate<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabUpdaterUtility.UpdateInstanceDelegate<T>>.NativeClassPtr, 100667573);
        PrefabUpdaterUtility.UpdateInstanceDelegate<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_T_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabUpdaterUtility.UpdateInstanceDelegate<T>>.NativeClassPtr, 100667574);
        PrefabUpdaterUtility.UpdateInstanceDelegate<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabUpdaterUtility.UpdateInstanceDelegate<T>>.NativeClassPtr, 100667575);
      }

      public UpdateInstanceDelegate(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    private sealed class MethodInfoStoreGeneric_UpdateInstances_Public_Static_Void_GameObject_EntityManager_UpdateInstanceDelegate_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PrefabUpdaterUtility.NativeMethodInfoPtr_UpdateInstances_Public_Static_Void_GameObject_EntityManager_UpdateInstanceDelegate_1_T_0, Il2CppClassPointerStore<PrefabUpdaterUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_UpdateLinkedGroupInstances_Public_Static_Void_GameObject_EntityManager_UpdateInstanceDelegate_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PrefabUpdaterUtility.NativeMethodInfoPtr_UpdateLinkedGroupInstances_Public_Static_Void_GameObject_EntityManager_UpdateInstanceDelegate_1_T_0, Il2CppClassPointerStore<PrefabUpdaterUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
