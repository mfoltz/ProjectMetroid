// Decompiled with JetBrains decompiler
// Type: EntityManagerExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using Unity.Entities;

#nullable disable
public static class EntityManagerExtensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentObject_Public_Static_T_EntityManager_Entity_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715991, XrefRangeEnd = 715992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T GetComponentObject<T>(this EntityManager entityManager, Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &entityManager;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(EntityManagerExtensions.MethodInfoStoreGeneric_GetComponentObject_Public_Static_T_EntityManager_Entity_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  static EntityManagerExtensions()
  {
    Il2CppClassPointerStore<EntityManagerExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (EntityManagerExtensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityManagerExtensions>.NativeClassPtr);
    EntityManagerExtensions.NativeMethodInfoPtr_GetComponentObject_Public_Static_T_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityManagerExtensions>.NativeClassPtr, 100663425);
  }

  public EntityManagerExtensions(System.IntPtr pointer)
    : base(pointer)
  {
  }

  private sealed class MethodInfoStoreGeneric_GetComponentObject_Public_Static_T_EntityManager_Entity_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(EntityManagerExtensions.NativeMethodInfoPtr_GetComponentObject_Public_Static_T_EntityManager_Entity_0, Il2CppClassPointerStore<EntityManagerExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
