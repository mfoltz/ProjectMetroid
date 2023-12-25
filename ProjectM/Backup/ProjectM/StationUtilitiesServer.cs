// Decompiled with JetBrains decompiler
// Type: ProjectM.StationUtilitiesServer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class StationUtilitiesServer : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_HasBloodSource_Public_Static_Boolean_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBloodSource_Public_Static_Boolean_EntityManager_Entity_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasRecipe_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_NativeHashMap_2_PrefabGUID_RecipeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasUnlockedRecipe_Public_Static_Boolean_EntityManager_ProgressionDependencySystem_PrefabCollectionSystem_GameDataSystem_Entity_RecipeData_PrefabGUID_Boolean_0;

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1039847, RefRangeEnd = 1039853, XrefRangeStart = 1039837, XrefRangeEnd = 1039847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasBloodSource(EntityManager entityManager, Entity targetWorkStation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetWorkStation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StationUtilitiesServer.NativeMethodInfoPtr_HasBloodSource_Public_Static_Boolean_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1039853, XrefRangeEnd = 1039860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetBloodSource(
      EntityManager entityManager,
      Entity targetWorkStation,
      out bool hasBloodSource)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetWorkStation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref hasBloodSource;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StationUtilitiesServer.NativeMethodInfoPtr_TryGetBloodSource_Public_Static_Boolean_EntityManager_Entity_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1039873, RefRangeEnd = 1039875, XrefRangeStart = 1039860, XrefRangeEnd = 1039873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasRecipe(
      EntityManager entityManager,
      Entity target,
      PrefabGUID recipeGuid,
      NativeHashMap<PrefabGUID, RecipeData> recipeHashLookupMap)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &recipeGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &recipeHashLookupMap;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StationUtilitiesServer.NativeMethodInfoPtr_HasRecipe_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_NativeHashMap_2_PrefabGUID_RecipeData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1039886, RefRangeEnd = 1039888, XrefRangeStart = 1039875, XrefRangeEnd = 1039886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasUnlockedRecipe(
      EntityManager entityManager,
      ProgressionDependencySystem progressionDependencySystem,
      PrefabCollectionSystem prefabCollectionSystem,
      GameDataSystem gameDataSystem,
      Entity userEntity,
      RecipeData recipeData,
      PrefabGUID recipeGuid,
      bool skipProgressionCheck)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) progressionDependencySystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &recipeData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &recipeGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &skipProgressionCheck;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StationUtilitiesServer.NativeMethodInfoPtr_HasUnlockedRecipe_Public_Static_Boolean_EntityManager_ProgressionDependencySystem_PrefabCollectionSystem_GameDataSystem_Entity_RecipeData_PrefabGUID_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static StationUtilitiesServer()
    {
      Il2CppClassPointerStore<StationUtilitiesServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (StationUtilitiesServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationUtilitiesServer>.NativeClassPtr);
      StationUtilitiesServer.NativeMethodInfoPtr_HasBloodSource_Public_Static_Boolean_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationUtilitiesServer>.NativeClassPtr, 100681436);
      StationUtilitiesServer.NativeMethodInfoPtr_TryGetBloodSource_Public_Static_Boolean_EntityManager_Entity_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationUtilitiesServer>.NativeClassPtr, 100681437);
      StationUtilitiesServer.NativeMethodInfoPtr_HasRecipe_Public_Static_Boolean_EntityManager_Entity_PrefabGUID_NativeHashMap_2_PrefabGUID_RecipeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationUtilitiesServer>.NativeClassPtr, 100681438);
      StationUtilitiesServer.NativeMethodInfoPtr_HasUnlockedRecipe_Public_Static_Boolean_EntityManager_ProgressionDependencySystem_PrefabCollectionSystem_GameDataSystem_Entity_RecipeData_PrefabGUID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationUtilitiesServer>.NativeClassPtr, 100681439);
    }

    public StationUtilitiesServer(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
