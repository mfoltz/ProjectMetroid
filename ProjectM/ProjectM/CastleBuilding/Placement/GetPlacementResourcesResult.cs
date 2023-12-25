// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Placement.GetPlacementResourcesResult
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding.Placement
{
  public static class GetPlacementResourcesResult : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetResult_Public_Static_PlacementResourcesResult_EntityManager_GameDataSystem_PlacementResult_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetResourceRequirements_Public_Static_Void_EntityManager_PrefabGUID_GameDataSystem_NativeHashMap_2_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddResourceRequirements_Private_Static_Void_EntityManager_Entity_NativeHashMap_2_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDismantleResources_Private_Static_Void_EntityManager_GameDataSystem_PrefabGUID_NativeHashMap_2_PrefabGUID_Int32_Double_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddDismantleResult_Private_Static_Void_EntityManager_BlueprintData_NativeHashMap_2_PrefabGUID_Int32_Double_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasEnoughResources_Public_Static_Boolean_PlacementResourcesResult_EntityManager_SingletonAccessor_1_SyncedServerDebugSettings_Entity_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1131549, RefRangeEnd = 1131553, XrefRangeStart = 1131504, XrefRangeEnd = 1131549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PlacementResourcesResult GetResult(
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      PlacementResult placementResult,
      double serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &placementResult;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResourcesResult.NativeMethodInfoPtr_GetResult_Public_Static_PlacementResourcesResult_EntityManager_GameDataSystem_PlacementResult_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PlacementResourcesResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1131571, RefRangeEnd = 1131573, XrefRangeStart = 1131553, XrefRangeEnd = 1131571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetResourceRequirements(
      EntityManager entityManager,
      PrefabGUID prefabGuid,
      GameDataSystem gameDataSystem,
      NativeHashMap<PrefabGUID, int> result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResourcesResult.NativeMethodInfoPtr_GetResourceRequirements_Public_Static_Void_EntityManager_PrefabGUID_GameDataSystem_NativeHashMap_2_PrefabGUID_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131573, XrefRangeEnd = 1131588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddResourceRequirements(
      EntityManager entityManager,
      Entity entity,
      NativeHashMap<PrefabGUID, int> result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResourcesResult.NativeMethodInfoPtr_AddResourceRequirements_Private_Static_Void_EntityManager_Entity_NativeHashMap_2_PrefabGUID_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1131611, RefRangeEnd = 1131612, XrefRangeStart = 1131588, XrefRangeEnd = 1131611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GetDismantleResources(
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      PrefabGUID prefabGuid,
      NativeHashMap<PrefabGUID, int> result,
      double serverTime,
      Entity entityToDestroy)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &entityToDestroy;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResourcesResult.NativeMethodInfoPtr_GetDismantleResources_Private_Static_Void_EntityManager_GameDataSystem_PrefabGUID_NativeHashMap_2_PrefabGUID_Int32_Double_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131612, XrefRangeEnd = 1131632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddDismantleResult(
      EntityManager entityManager,
      BlueprintData blueprintData,
      NativeHashMap<PrefabGUID, int> result,
      double serverTime,
      Entity entityToDestroy)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &blueprintData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &entityToDestroy;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetPlacementResourcesResult.NativeMethodInfoPtr_AddDismantleResult_Private_Static_Void_EntityManager_BlueprintData_NativeHashMap_2_PrefabGUID_Int32_Double_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1131647, RefRangeEnd = 1131649, XrefRangeStart = 1131632, XrefRangeEnd = 1131647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasEnoughResources(
      PlacementResourcesResult resourcesResult,
      EntityManager entityManager,
      SingletonAccessor<SyncedServerDebugSettings> serverDebugSettings,
      Entity character)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &resourcesResult;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &serverDebugSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GetPlacementResourcesResult.NativeMethodInfoPtr_HasEnoughResources_Public_Static_Boolean_PlacementResourcesResult_EntityManager_SingletonAccessor_1_SyncedServerDebugSettings_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static GetPlacementResourcesResult()
    {
      Il2CppClassPointerStore<GetPlacementResourcesResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding.Placement", nameof (GetPlacementResourcesResult));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlacementResourcesResult>.NativeClassPtr);
      GetPlacementResourcesResult.NativeMethodInfoPtr_GetResult_Public_Static_PlacementResourcesResult_EntityManager_GameDataSystem_PlacementResult_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResourcesResult>.NativeClassPtr, 100689827);
      GetPlacementResourcesResult.NativeMethodInfoPtr_GetResourceRequirements_Public_Static_Void_EntityManager_PrefabGUID_GameDataSystem_NativeHashMap_2_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResourcesResult>.NativeClassPtr, 100689828);
      GetPlacementResourcesResult.NativeMethodInfoPtr_AddResourceRequirements_Private_Static_Void_EntityManager_Entity_NativeHashMap_2_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResourcesResult>.NativeClassPtr, 100689829);
      GetPlacementResourcesResult.NativeMethodInfoPtr_GetDismantleResources_Private_Static_Void_EntityManager_GameDataSystem_PrefabGUID_NativeHashMap_2_PrefabGUID_Int32_Double_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResourcesResult>.NativeClassPtr, 100689830);
      GetPlacementResourcesResult.NativeMethodInfoPtr_AddDismantleResult_Private_Static_Void_EntityManager_BlueprintData_NativeHashMap_2_PrefabGUID_Int32_Double_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResourcesResult>.NativeClassPtr, 100689831);
      GetPlacementResourcesResult.NativeMethodInfoPtr_HasEnoughResources_Public_Static_Boolean_PlacementResourcesResult_EntityManager_SingletonAccessor_1_SyncedServerDebugSettings_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlacementResourcesResult>.NativeClassPtr, 100689832);
    }

    public GetPlacementResourcesResult(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
