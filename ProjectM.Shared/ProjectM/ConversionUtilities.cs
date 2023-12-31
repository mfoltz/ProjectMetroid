// Decompiled with JetBrains decompiler
// Type: ProjectM.ConversionUtilities
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public static class ConversionUtilities : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyEntityAndChildren_Public_Static_Void_GameObjectConversionSystem_GameObjectLookupConversionSystem_Transform_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAllComponents_Private_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroySelfAndChildren_Private_Static_Void_GameObjectConversionSystem_GameObjectLookupConversionSystem_Transform_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSynced_Public_Static_SyncedCollection_Component_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasTransform_Public_Static_Boolean_Component_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StripEntityFromWorldsExcept_Public_Static_Void_EntityManager_Entity_Il2CppStructArray_1_WorldType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StripComponentFromWorldsExcept_Public_Static_Void_EntityManager_Entity_Il2CppStructArray_1_WorldType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StripBufferFromWorldsExcept_Public_Static_Void_EntityManager_Entity_Il2CppStructArray_1_WorldType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrivateStripComponentFromWorldsExcept_Private_Static_Void_EntityManager_Entity_Il2CppStructArray_1_WorldType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConversionWorldEntity_Public_Static_Entity_GameObjectConversionSystem_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveECSTransform_Public_Static_Void_GameObjectConversionSystem_GameObject_0;

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 763983, RefRangeEnd = 763992, XrefRangeStart = 763957, XrefRangeEnd = 763983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DestroyEntityAndChildren(
      GameObjectConversionSystem conversionSystem,
      GameObjectLookupConversionSystem gameObjectLookup,
      Transform transform)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObjectLookup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConversionUtilities.NativeMethodInfoPtr_DestroyEntityAndChildren_Public_Static_Void_GameObjectConversionSystem_GameObjectLookupConversionSystem_Transform_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 764011, RefRangeEnd = 764015, XrefRangeStart = 763992, XrefRangeEnd = 764011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemoveAllComponents(EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConversionUtilities.NativeMethodInfoPtr_RemoveAllComponents_Private_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 764060, RefRangeEnd = 764062, XrefRangeStart = 764015, XrefRangeEnd = 764060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DestroySelfAndChildren(
      GameObjectConversionSystem conversionSystem,
      GameObjectLookupConversionSystem gameObjectLookup,
      Transform transform)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObjectLookup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConversionUtilities.NativeMethodInfoPtr_DestroySelfAndChildren_Private_Static_Void_GameObjectConversionSystem_GameObjectLookupConversionSystem_Transform_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 764075, RefRangeEnd = 764078, XrefRangeStart = 764062, XrefRangeEnd = 764075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SyncedCollection GetSynced(Component component)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) component);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConversionUtilities.NativeMethodInfoPtr_GetSynced_Public_Static_SyncedCollection_Component_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SyncedCollection) null : new SyncedCollection(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 764084, RefRangeEnd = 764086, XrefRangeStart = 764078, XrefRangeEnd = 764084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasTransform(Component component)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) component);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConversionUtilities.NativeMethodInfoPtr_HasTransform_Public_Static_Boolean_Component_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 764099, RefRangeEnd = 764104, XrefRangeStart = 764086, XrefRangeEnd = 764099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void StripEntityFromWorldsExcept(
      EntityManager dstManager,
      Entity entity,
      [Optional] Il2CppStructArray<WorldType> worlds)
    {
      if (worlds == null)
        worlds = new Il2CppStructArray<WorldType>(0L);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) worlds);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConversionUtilities.NativeMethodInfoPtr_StripEntityFromWorldsExcept_Public_Static_Void_EntityManager_Entity_Il2CppStructArray_1_WorldType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 262568, RefRangeEnd = 262580, XrefRangeStart = 262568, XrefRangeEnd = 262580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void StripComponentFromWorldsExcept(
      EntityManager dstManager,
      Entity entity,
      [Optional] Il2CppStructArray<WorldType> worlds)
    {
      if (worlds == null)
        worlds = new Il2CppStructArray<WorldType>(0L);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) worlds);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConversionUtilities.MethodInfoStoreGeneric_StripComponentFromWorldsExcept_Public_Static_Void_EntityManager_Entity_Il2CppStructArray_1_WorldType_0<M0>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe void StripBufferFromWorldsExcept(
      EntityManager dstManager,
      Entity entity,
      [Optional] Il2CppStructArray<WorldType> worlds)
    {
      if (worlds == null)
        worlds = new Il2CppStructArray<WorldType>(0L);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) worlds);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConversionUtilities.MethodInfoStoreGeneric_StripBufferFromWorldsExcept_Public_Static_Void_EntityManager_Entity_Il2CppStructArray_1_WorldType_0<M0>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764104, XrefRangeEnd = 764126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void PrivateStripComponentFromWorldsExcept(
      EntityManager dstManager,
      Entity entity,
      [Optional] Il2CppStructArray<WorldType> worlds)
    {
      if (worlds == null)
        worlds = new Il2CppStructArray<WorldType>(0L);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) worlds);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConversionUtilities.MethodInfoStoreGeneric_PrivateStripComponentFromWorldsExcept_Private_Static_Void_EntityManager_Entity_Il2CppStructArray_1_WorldType_0<M0>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 764133, RefRangeEnd = 764134, XrefRangeStart = 764126, XrefRangeEnd = 764133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity GetConversionWorldEntity(
      GameObjectConversionSystem conversionSystem,
      GameObject gameObject)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConversionUtilities.NativeMethodInfoPtr_GetConversionWorldEntity_Public_Static_Entity_GameObjectConversionSystem_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 764140, RefRangeEnd = 764142, XrefRangeStart = 764134, XrefRangeEnd = 764140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemoveECSTransform(
      GameObjectConversionSystem conversionSystem,
      GameObject gameObject)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConversionUtilities.NativeMethodInfoPtr_RemoveECSTransform_Public_Static_Void_GameObjectConversionSystem_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public static void StripEntityFromWorldsExcept(
      EntityManager dstManager,
      Entity entity,
      params WorldType[] worlds)
    {
      ConversionUtilities.StripEntityFromWorldsExcept(dstManager, entity, new Il2CppStructArray<WorldType>(worlds));
    }

    public static void StripComponentFromWorldsExcept<T, T>(
      EntityManager dstManager,
      Entity entity,
      params WorldType[] worlds)
    {
      ConversionUtilities.StripComponentFromWorldsExcept(dstManager, entity, new Il2CppStructArray<WorldType>(worlds));
    }

    public static void StripBufferFromWorldsExcept<T, T>(
      EntityManager dstManager,
      Entity entity,
      params WorldType[] worlds)
    {
      ConversionUtilities.StripBufferFromWorldsExcept(dstManager, entity, new Il2CppStructArray<WorldType>(worlds));
    }

    public static void PrivateStripComponentFromWorldsExcept<T, T>(
      EntityManager dstManager,
      Entity entity,
      params WorldType[] worlds)
    {
      ConversionUtilities.PrivateStripComponentFromWorldsExcept(dstManager, entity, new Il2CppStructArray<WorldType>(worlds));
    }

    static ConversionUtilities()
    {
      Il2CppClassPointerStore<ConversionUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ConversionUtilities));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConversionUtilities>.NativeClassPtr);
      ConversionUtilities.NativeMethodInfoPtr_DestroyEntityAndChildren_Public_Static_Void_GameObjectConversionSystem_GameObjectLookupConversionSystem_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversionUtilities>.NativeClassPtr, 100667500);
      ConversionUtilities.NativeMethodInfoPtr_RemoveAllComponents_Private_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversionUtilities>.NativeClassPtr, 100667501);
      ConversionUtilities.NativeMethodInfoPtr_DestroySelfAndChildren_Private_Static_Void_GameObjectConversionSystem_GameObjectLookupConversionSystem_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversionUtilities>.NativeClassPtr, 100667502);
      ConversionUtilities.NativeMethodInfoPtr_GetSynced_Public_Static_SyncedCollection_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversionUtilities>.NativeClassPtr, 100667503);
      ConversionUtilities.NativeMethodInfoPtr_HasTransform_Public_Static_Boolean_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversionUtilities>.NativeClassPtr, 100667504);
      ConversionUtilities.NativeMethodInfoPtr_StripEntityFromWorldsExcept_Public_Static_Void_EntityManager_Entity_Il2CppStructArray_1_WorldType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversionUtilities>.NativeClassPtr, 100667505);
      ConversionUtilities.NativeMethodInfoPtr_StripComponentFromWorldsExcept_Public_Static_Void_EntityManager_Entity_Il2CppStructArray_1_WorldType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversionUtilities>.NativeClassPtr, 100667506);
      ConversionUtilities.NativeMethodInfoPtr_StripBufferFromWorldsExcept_Public_Static_Void_EntityManager_Entity_Il2CppStructArray_1_WorldType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversionUtilities>.NativeClassPtr, 100667507);
      ConversionUtilities.NativeMethodInfoPtr_PrivateStripComponentFromWorldsExcept_Private_Static_Void_EntityManager_Entity_Il2CppStructArray_1_WorldType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversionUtilities>.NativeClassPtr, 100667508);
      ConversionUtilities.NativeMethodInfoPtr_GetConversionWorldEntity_Public_Static_Entity_GameObjectConversionSystem_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversionUtilities>.NativeClassPtr, 100667509);
      ConversionUtilities.NativeMethodInfoPtr_RemoveECSTransform_Public_Static_Void_GameObjectConversionSystem_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversionUtilities>.NativeClassPtr, 100667510);
    }

    public ConversionUtilities(System.IntPtr pointer)
      : base(pointer)
    {
    }

    private sealed class MethodInfoStoreGeneric_StripComponentFromWorldsExcept_Public_Static_Void_EntityManager_Entity_Il2CppStructArray_1_WorldType_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ConversionUtilities.NativeMethodInfoPtr_StripComponentFromWorldsExcept_Public_Static_Void_EntityManager_Entity_Il2CppStructArray_1_WorldType_0, Il2CppClassPointerStore<ConversionUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_StripBufferFromWorldsExcept_Public_Static_Void_EntityManager_Entity_Il2CppStructArray_1_WorldType_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ConversionUtilities.NativeMethodInfoPtr_StripBufferFromWorldsExcept_Public_Static_Void_EntityManager_Entity_Il2CppStructArray_1_WorldType_0, Il2CppClassPointerStore<ConversionUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_PrivateStripComponentFromWorldsExcept_Private_Static_Void_EntityManager_Entity_Il2CppStructArray_1_WorldType_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ConversionUtilities.NativeMethodInfoPtr_PrivateStripComponentFromWorldsExcept_Private_Static_Void_EntityManager_Entity_Il2CppStructArray_1_WorldType_0, Il2CppClassPointerStore<ConversionUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
