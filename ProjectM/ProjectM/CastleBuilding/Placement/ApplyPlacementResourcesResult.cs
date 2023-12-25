// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Placement.ApplyPlacementResourcesResult
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding.Placement
{
  public static class ApplyPlacementResourcesResult : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Static_Void_PlacementResourcesResult_EntityManager_GameDataSystem_Entity_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveItemsDueToResourceRequirements_Private_Static_Void_PlacementResourcesResult_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddItemsFromDismantleResources_Private_Static_Void_PlacementResourcesResult_EntityManager_GameDataSystem_Entity_0;

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1130358, RefRangeEnd = 1130364, XrefRangeStart = 1130355, XrefRangeEnd = 1130358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Execute(
      PlacementResourcesResult resourcesResult,
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      Entity character,
      bool buildCostsDisabled)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &resourcesResult;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &buildCostsDisabled;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ApplyPlacementResourcesResult.NativeMethodInfoPtr_Execute_Public_Static_Void_PlacementResourcesResult_EntityManager_GameDataSystem_Entity_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1130412, RefRangeEnd = 1130413, XrefRangeStart = 1130364, XrefRangeEnd = 1130412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemoveItemsDueToResourceRequirements(
      PlacementResourcesResult result,
      EntityManager entityManager,
      Entity character)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ApplyPlacementResourcesResult.NativeMethodInfoPtr_RemoveItemsDueToResourceRequirements_Private_Static_Void_PlacementResourcesResult_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1130428, RefRangeEnd = 1130429, XrefRangeStart = 1130413, XrefRangeEnd = 1130428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddItemsFromDismantleResources(
      PlacementResourcesResult result,
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      Entity character)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ApplyPlacementResourcesResult.NativeMethodInfoPtr_AddItemsFromDismantleResources_Private_Static_Void_PlacementResourcesResult_EntityManager_GameDataSystem_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ApplyPlacementResourcesResult()
    {
      Il2CppClassPointerStore<ApplyPlacementResourcesResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding.Placement", nameof (ApplyPlacementResourcesResult));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplyPlacementResourcesResult>.NativeClassPtr);
      ApplyPlacementResourcesResult.NativeMethodInfoPtr_Execute_Public_Static_Void_PlacementResourcesResult_EntityManager_GameDataSystem_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyPlacementResourcesResult>.NativeClassPtr, 100689809);
      ApplyPlacementResourcesResult.NativeMethodInfoPtr_RemoveItemsDueToResourceRequirements_Private_Static_Void_PlacementResourcesResult_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyPlacementResourcesResult>.NativeClassPtr, 100689810);
      ApplyPlacementResourcesResult.NativeMethodInfoPtr_AddItemsFromDismantleResources_Private_Static_Void_PlacementResourcesResult_EntityManager_GameDataSystem_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyPlacementResourcesResult>.NativeClassPtr, 100689811);
    }

    public ApplyPlacementResourcesResult(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
