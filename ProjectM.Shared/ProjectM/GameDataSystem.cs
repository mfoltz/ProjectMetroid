// Decompiled with JetBrains decompiler
// Type: ProjectM.GameDataSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Roofs;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class GameDataSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__RegisterManagedDataQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldTypeAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerGameBalanceAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__OriginalRecipeDurations;
    private static readonly System.IntPtr NativeFieldInfoPtr__ManagedDataLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr__ItemHashLookupMap_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ItemGroupHashLookupMap_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__DropTableDataHashLookupMap_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__BlueprintHashLookupMap_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__RecipeHashLookupMap_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__UpgradeHashLookupMap_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__CastleRaidHashLookupMap_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__CastleClaimHashLookupMap_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__CastleDestroyHashLookupMap_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__StationBonusLookupMap_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__RepairstationDataHashLookupMap_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__RoofCategoryLookupMap_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomLocalizationKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterManagedDataLookup_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterManagedDataLookup_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterItems_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterItems_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterItems_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterItems_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterItemGroups_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterItemGroups_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterDropTableDatas_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterDropTableDatas_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterRecipes_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterRecipes_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterRecipes_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterRecipes_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterRecipes_LambdaJob2_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterRecipes_LambdaJob2_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterCastleData_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterCastleData_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterCastleData_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterCastleData_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterCastleData_LambdaJob2_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterCastleData_LambdaJob2_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterCastleData_LambdaJob3_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterCastleData_LambdaJob3_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterBlueprints_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterBlueprints_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterStationBonuses_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterStationBonuses_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterRepairstationData_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterRepairstationData_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterRoofCategories_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RegisterRoofCategories_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ManagedDataRegistry_Public_get_ManagedDataRegistry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ItemHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_ItemData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_ItemData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ItemGroupHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_ItemDataDropGroup_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemGroupHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_ItemDataDropGroup_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DropTableDataHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_DropTableData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DropTableDataHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_DropTableData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_BlueprintHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_BlueprintData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_BlueprintHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_BlueprintData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RecipeHashLookupMap_Public_set_Void_NativeHashMap_2_PrefabGUID_RecipeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RecipeHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_RecipeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UpgradeHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_UpgradeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UpgradeHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_UpgradeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CastleRaidHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_CastleRaidData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CastleRaidHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_CastleRaidData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CastleClaimHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_CastleClaimData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CastleClaimHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_CastleClaimData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CastleDestroyHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_CastleDestroyData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CastleDestroyHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_CastleDestroyData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_StationBonusLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_StationBonusData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_StationBonusLookupMap_Public_get_NativeHashMap_2_PrefabGUID_StationBonusData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RepairstationDataHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_RepairstationData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RepairstationDataHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_RepairstationData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RoofCategoryLookupMap_Private_set_Void_NativeHashMap_2_Int32_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RoofCategoryLookupMap_Public_get_NativeHashMap_2_Int32_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterManagedDataLookup_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterItems_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterItemGroups_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterDropTableDatas_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterRecipes_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterCastleData_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterBlueprints_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterStationBonuses_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterRepairstationData_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RegisterRoofCategories_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRegisterManagedDataLookup_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRegisterItems_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRegisterItems_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRegisterItemGroups_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRegisterDropTableDatas_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRegisterRecipes_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRegisterRecipes_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRegisterRecipes_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRegisterCastleData_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRegisterCastleData_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRegisterCastleData_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRegisterCastleData_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRegisterBlueprints_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRegisterStationBonuses_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRegisterRepairstationData_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRegisterRoofCategories_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_3;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_4;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_5;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_6;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_7;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_8;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_9;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_10;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_11;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_12;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_13;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_14;

    public unsafe ManagedDataRegistry ManagedDataRegistry
    {
      [CallerCount(207), CachedScanResults(RefRangeStart = 753358, RefRangeEnd = 753565, XrefRangeStart = 753357, XrefRangeEnd = 753358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_get_ManagedDataRegistry_Public_get_ManagedDataRegistry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new ManagedDataRegistry(pointer);
      }
    }

    public unsafe NativeHashMap<PrefabGUID, ItemData> ItemHashLookupMap
    {
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_set_ItemHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_get_ItemHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeHashMap<PrefabGUID, ItemData>*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe NativeHashMap<PrefabGUID, ItemDataDropGroup> ItemGroupHashLookupMap
    {
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_set_ItemGroupHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_ItemDataDropGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_get_ItemGroupHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_ItemDataDropGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeHashMap<PrefabGUID, ItemDataDropGroup>*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe NativeHashMap<PrefabGUID, DropTableData> DropTableDataHashLookupMap
    {
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_set_DropTableDataHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_DropTableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_get_DropTableDataHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_DropTableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeHashMap<PrefabGUID, DropTableData>*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe NativeHashMap<PrefabGUID, BlueprintData> BlueprintHashLookupMap
    {
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_set_BlueprintHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_BlueprintData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_get_BlueprintHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_BlueprintData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeHashMap<PrefabGUID, BlueprintData>*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe NativeHashMap<PrefabGUID, RecipeData> RecipeHashLookupMap
    {
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_set_RecipeHashLookupMap_Public_set_Void_NativeHashMap_2_PrefabGUID_RecipeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_get_RecipeHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_RecipeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeHashMap<PrefabGUID, RecipeData>*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe NativeHashMap<PrefabGUID, UpgradeData> UpgradeHashLookupMap
    {
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_set_UpgradeHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_UpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_get_UpgradeHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_UpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeHashMap<PrefabGUID, UpgradeData>*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe NativeHashMap<PrefabGUID, CastleRaidData> CastleRaidHashLookupMap
    {
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_set_CastleRaidHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_CastleRaidData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_get_CastleRaidHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_CastleRaidData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeHashMap<PrefabGUID, CastleRaidData>*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe NativeHashMap<PrefabGUID, CastleClaimData> CastleClaimHashLookupMap
    {
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_set_CastleClaimHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_CastleClaimData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_get_CastleClaimHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_CastleClaimData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeHashMap<PrefabGUID, CastleClaimData>*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe NativeHashMap<PrefabGUID, CastleDestroyData> CastleDestroyHashLookupMap
    {
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_set_CastleDestroyHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_CastleDestroyData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_get_CastleDestroyHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_CastleDestroyData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeHashMap<PrefabGUID, CastleDestroyData>*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe NativeHashMap<PrefabGUID, StationBonusData> StationBonusLookupMap
    {
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_set_StationBonusLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_StationBonusData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_get_StationBonusLookupMap_Public_get_NativeHashMap_2_PrefabGUID_StationBonusData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeHashMap<PrefabGUID, StationBonusData>*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe NativeHashMap<PrefabGUID, RepairstationData> RepairstationDataHashLookupMap
    {
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_set_RepairstationDataHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_RepairstationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_get_RepairstationDataHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_RepairstationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeHashMap<PrefabGUID, RepairstationData>*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe NativeHashMap<int, Entity> RoofCategoryLookupMap
    {
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_set_RoofCategoryLookupMap_Private_set_Void_NativeHashMap_2_Int32_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_get_RoofCategoryLookupMap_Public_get_NativeHashMap_2_Int32_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeHashMap<int, Entity>*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753565, XrefRangeEnd = 753653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameDataSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753653, XrefRangeEnd = 753698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameDataSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753698, XrefRangeEnd = 753708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameDataSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 753730, RefRangeEnd = 753731, XrefRangeStart = 753708, XrefRangeEnd = 753730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterManagedDataLookup()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_RegisterManagedDataLookup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 753766, RefRangeEnd = 753767, XrefRangeStart = 753731, XrefRangeEnd = 753766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterItems()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_RegisterItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 753781, RefRangeEnd = 753782, XrefRangeStart = 753767, XrefRangeEnd = 753781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterItemGroups()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_RegisterItemGroups_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 753796, RefRangeEnd = 753797, XrefRangeStart = 753782, XrefRangeEnd = 753796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterDropTableDatas()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_RegisterDropTableDatas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 753879, RefRangeEnd = 753880, XrefRangeStart = 753797, XrefRangeEnd = 753879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterRecipes()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_RegisterRecipes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 753936, RefRangeEnd = 753937, XrefRangeStart = 753880, XrefRangeEnd = 753936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterCastleData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_RegisterCastleData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 753957, RefRangeEnd = 753958, XrefRangeStart = 753937, XrefRangeEnd = 753957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterBlueprints()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_RegisterBlueprints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 753972, RefRangeEnd = 753973, XrefRangeStart = 753958, XrefRangeEnd = 753972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterStationBonuses()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_RegisterStationBonuses_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 753987, RefRangeEnd = 753988, XrefRangeStart = 753973, XrefRangeEnd = 753987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterRepairstationData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_RegisterRepairstationData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 754003, RefRangeEnd = 754004, XrefRangeStart = 753988, XrefRangeEnd = 754003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RegisterRoofCategories()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_RegisterRoofCategories_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754004, XrefRangeEnd = 754012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameDataSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754012, XrefRangeEnd = 754545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameDataSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754545, XrefRangeEnd = 754561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRegisterManagedDataLookup_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterManagedDataLookup_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754561, XrefRangeEnd = 754577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRegisterItems_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterItems_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754577, XrefRangeEnd = 754596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRegisterItems_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterItems_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754596, XrefRangeEnd = 754615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRegisterItemGroups_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterItemGroups_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754615, XrefRangeEnd = 754634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRegisterDropTableDatas_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterDropTableDatas_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754634, XrefRangeEnd = 754653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRegisterRecipes_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterRecipes_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754653, XrefRangeEnd = 754672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRegisterRecipes_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterRecipes_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754672, XrefRangeEnd = 754691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRegisterRecipes_LambdaJob2_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterRecipes_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754691, XrefRangeEnd = 754710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRegisterCastleData_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterCastleData_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754710, XrefRangeEnd = 754729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRegisterCastleData_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterCastleData_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754729, XrefRangeEnd = 754748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRegisterCastleData_LambdaJob2_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterCastleData_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754748, XrefRangeEnd = 754767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRegisterCastleData_LambdaJob3_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterCastleData_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754767, XrefRangeEnd = 754786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRegisterBlueprints_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterBlueprints_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754786, XrefRangeEnd = 754805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRegisterStationBonuses_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterStationBonuses_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754805, XrefRangeEnd = 754824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRegisterRepairstationData_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterRepairstationData_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754824, XrefRangeEnd = 754840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRegisterRoofCategories_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterRoofCategories_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 754844, RefRangeEnd = 754845, XrefRangeStart = 754840, XrefRangeEnd = 754844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 754849, RefRangeEnd = 754850, XrefRangeStart = 754845, XrefRangeEnd = 754849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 754854, RefRangeEnd = 754855, XrefRangeStart = 754850, XrefRangeEnd = 754854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 754859, RefRangeEnd = 754860, XrefRangeStart = 754855, XrefRangeEnd = 754859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 754864, RefRangeEnd = 754865, XrefRangeStart = 754860, XrefRangeEnd = 754864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_4()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_4, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 754869, RefRangeEnd = 754870, XrefRangeStart = 754865, XrefRangeEnd = 754869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_5()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_5, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 754874, RefRangeEnd = 754875, XrefRangeStart = 754870, XrefRangeEnd = 754874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_6()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_6, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 754879, RefRangeEnd = 754880, XrefRangeStart = 754875, XrefRangeEnd = 754879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_7()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_7, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 754884, RefRangeEnd = 754885, XrefRangeStart = 754880, XrefRangeEnd = 754884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_8()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_8, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 754889, RefRangeEnd = 754890, XrefRangeStart = 754885, XrefRangeEnd = 754889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_9()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_9, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 754894, RefRangeEnd = 754895, XrefRangeStart = 754890, XrefRangeEnd = 754894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_10()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_10, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 754899, RefRangeEnd = 754900, XrefRangeStart = 754895, XrefRangeEnd = 754899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_11()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_11, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 754904, RefRangeEnd = 754905, XrefRangeStart = 754900, XrefRangeEnd = 754904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_12()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_12, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 754909, RefRangeEnd = 754910, XrefRangeStart = 754905, XrefRangeEnd = 754909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_13()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_13, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 754914, RefRangeEnd = 754915, XrefRangeStart = 754910, XrefRangeEnd = 754914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_14()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_14, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameDataSystem()
    {
      Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GameDataSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr);
      GameDataSystem.NativeFieldInfoPtr__RegisterManagedDataQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, nameof (_RegisterManagedDataQuery));
      GameDataSystem.NativeFieldInfoPtr__WorldTypeAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, nameof (_WorldTypeAccessor));
      GameDataSystem.NativeFieldInfoPtr__ServerGameBalanceAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, nameof (_ServerGameBalanceAccessor));
      GameDataSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      GameDataSystem.NativeFieldInfoPtr__OriginalRecipeDurations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, nameof (_OriginalRecipeDurations));
      GameDataSystem.NativeFieldInfoPtr__ManagedDataLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, nameof (_ManagedDataLookupMap));
      GameDataSystem.NativeFieldInfoPtr__ItemHashLookupMap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<ItemHashLookupMap>k__BackingField");
      GameDataSystem.NativeFieldInfoPtr__ItemGroupHashLookupMap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<ItemGroupHashLookupMap>k__BackingField");
      GameDataSystem.NativeFieldInfoPtr__DropTableDataHashLookupMap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<DropTableDataHashLookupMap>k__BackingField");
      GameDataSystem.NativeFieldInfoPtr__BlueprintHashLookupMap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<BlueprintHashLookupMap>k__BackingField");
      GameDataSystem.NativeFieldInfoPtr__RecipeHashLookupMap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<RecipeHashLookupMap>k__BackingField");
      GameDataSystem.NativeFieldInfoPtr__UpgradeHashLookupMap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<UpgradeHashLookupMap>k__BackingField");
      GameDataSystem.NativeFieldInfoPtr__CastleRaidHashLookupMap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<CastleRaidHashLookupMap>k__BackingField");
      GameDataSystem.NativeFieldInfoPtr__CastleClaimHashLookupMap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<CastleClaimHashLookupMap>k__BackingField");
      GameDataSystem.NativeFieldInfoPtr__CastleDestroyHashLookupMap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<CastleDestroyHashLookupMap>k__BackingField");
      GameDataSystem.NativeFieldInfoPtr__StationBonusLookupMap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<StationBonusLookupMap>k__BackingField");
      GameDataSystem.NativeFieldInfoPtr__RepairstationDataHashLookupMap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<RepairstationDataHashLookupMap>k__BackingField");
      GameDataSystem.NativeFieldInfoPtr__RoofCategoryLookupMap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<RoofCategoryLookupMap>k__BackingField");
      GameDataSystem.NativeFieldInfoPtr_RandomLocalizationKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, nameof (RandomLocalizationKeys));
      GameDataSystem.NativeFieldInfoPtr___RegisterManagedDataLookup_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterManagedDataLookup_LambdaJob0_entityQuery");
      GameDataSystem.NativeFieldInfoPtr___RegisterManagedDataLookup_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterManagedDataLookup_LambdaJob0_profilerMarker");
      GameDataSystem.NativeFieldInfoPtr___RegisterItems_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterItems_LambdaJob0_entityQuery");
      GameDataSystem.NativeFieldInfoPtr___RegisterItems_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterItems_LambdaJob0_profilerMarker");
      GameDataSystem.NativeFieldInfoPtr___RegisterItems_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterItems_LambdaJob1_entityQuery");
      GameDataSystem.NativeFieldInfoPtr___RegisterItems_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterItems_LambdaJob1_profilerMarker");
      GameDataSystem.NativeFieldInfoPtr___RegisterItemGroups_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterItemGroups_LambdaJob0_entityQuery");
      GameDataSystem.NativeFieldInfoPtr___RegisterItemGroups_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterItemGroups_LambdaJob0_profilerMarker");
      GameDataSystem.NativeFieldInfoPtr___RegisterDropTableDatas_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterDropTableDatas_LambdaJob0_entityQuery");
      GameDataSystem.NativeFieldInfoPtr___RegisterDropTableDatas_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterDropTableDatas_LambdaJob0_profilerMarker");
      GameDataSystem.NativeFieldInfoPtr___RegisterRecipes_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterRecipes_LambdaJob0_entityQuery");
      GameDataSystem.NativeFieldInfoPtr___RegisterRecipes_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterRecipes_LambdaJob0_profilerMarker");
      GameDataSystem.NativeFieldInfoPtr___RegisterRecipes_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterRecipes_LambdaJob1_entityQuery");
      GameDataSystem.NativeFieldInfoPtr___RegisterRecipes_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterRecipes_LambdaJob1_profilerMarker");
      GameDataSystem.NativeFieldInfoPtr___RegisterRecipes_LambdaJob2_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterRecipes_LambdaJob2_entityQuery");
      GameDataSystem.NativeFieldInfoPtr___RegisterRecipes_LambdaJob2_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterRecipes_LambdaJob2_profilerMarker");
      GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterCastleData_LambdaJob0_entityQuery");
      GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterCastleData_LambdaJob0_profilerMarker");
      GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterCastleData_LambdaJob1_entityQuery");
      GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterCastleData_LambdaJob1_profilerMarker");
      GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob2_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterCastleData_LambdaJob2_entityQuery");
      GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob2_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterCastleData_LambdaJob2_profilerMarker");
      GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob3_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterCastleData_LambdaJob3_entityQuery");
      GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob3_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterCastleData_LambdaJob3_profilerMarker");
      GameDataSystem.NativeFieldInfoPtr___RegisterBlueprints_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterBlueprints_LambdaJob0_entityQuery");
      GameDataSystem.NativeFieldInfoPtr___RegisterBlueprints_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterBlueprints_LambdaJob0_profilerMarker");
      GameDataSystem.NativeFieldInfoPtr___RegisterStationBonuses_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterStationBonuses_LambdaJob0_entityQuery");
      GameDataSystem.NativeFieldInfoPtr___RegisterStationBonuses_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterStationBonuses_LambdaJob0_profilerMarker");
      GameDataSystem.NativeFieldInfoPtr___RegisterRepairstationData_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterRepairstationData_LambdaJob0_entityQuery");
      GameDataSystem.NativeFieldInfoPtr___RegisterRepairstationData_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterRepairstationData_LambdaJob0_profilerMarker");
      GameDataSystem.NativeFieldInfoPtr___RegisterRoofCategories_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterRoofCategories_LambdaJob0_entityQuery");
      GameDataSystem.NativeFieldInfoPtr___RegisterRoofCategories_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>RegisterRoofCategories_LambdaJob0_profilerMarker");
      GameDataSystem.NativeMethodInfoPtr_get_ManagedDataRegistry_Public_get_ManagedDataRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666165);
      GameDataSystem.NativeMethodInfoPtr_set_ItemHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666166);
      GameDataSystem.NativeMethodInfoPtr_get_ItemHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666167);
      GameDataSystem.NativeMethodInfoPtr_set_ItemGroupHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_ItemDataDropGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666168);
      GameDataSystem.NativeMethodInfoPtr_get_ItemGroupHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_ItemDataDropGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666169);
      GameDataSystem.NativeMethodInfoPtr_set_DropTableDataHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_DropTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666170);
      GameDataSystem.NativeMethodInfoPtr_get_DropTableDataHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_DropTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666171);
      GameDataSystem.NativeMethodInfoPtr_set_BlueprintHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_BlueprintData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666172);
      GameDataSystem.NativeMethodInfoPtr_get_BlueprintHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_BlueprintData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666173);
      GameDataSystem.NativeMethodInfoPtr_set_RecipeHashLookupMap_Public_set_Void_NativeHashMap_2_PrefabGUID_RecipeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666174);
      GameDataSystem.NativeMethodInfoPtr_get_RecipeHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_RecipeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666175);
      GameDataSystem.NativeMethodInfoPtr_set_UpgradeHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_UpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666176);
      GameDataSystem.NativeMethodInfoPtr_get_UpgradeHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_UpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666177);
      GameDataSystem.NativeMethodInfoPtr_set_CastleRaidHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_CastleRaidData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666178);
      GameDataSystem.NativeMethodInfoPtr_get_CastleRaidHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_CastleRaidData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666179);
      GameDataSystem.NativeMethodInfoPtr_set_CastleClaimHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_CastleClaimData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666180);
      GameDataSystem.NativeMethodInfoPtr_get_CastleClaimHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_CastleClaimData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666181);
      GameDataSystem.NativeMethodInfoPtr_set_CastleDestroyHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_CastleDestroyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666182);
      GameDataSystem.NativeMethodInfoPtr_get_CastleDestroyHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_CastleDestroyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666183);
      GameDataSystem.NativeMethodInfoPtr_set_StationBonusLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_StationBonusData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666184);
      GameDataSystem.NativeMethodInfoPtr_get_StationBonusLookupMap_Public_get_NativeHashMap_2_PrefabGUID_StationBonusData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666185);
      GameDataSystem.NativeMethodInfoPtr_set_RepairstationDataHashLookupMap_Private_set_Void_NativeHashMap_2_PrefabGUID_RepairstationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666186);
      GameDataSystem.NativeMethodInfoPtr_get_RepairstationDataHashLookupMap_Public_get_NativeHashMap_2_PrefabGUID_RepairstationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666187);
      GameDataSystem.NativeMethodInfoPtr_set_RoofCategoryLookupMap_Private_set_Void_NativeHashMap_2_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666188);
      GameDataSystem.NativeMethodInfoPtr_get_RoofCategoryLookupMap_Public_get_NativeHashMap_2_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666189);
      GameDataSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666190);
      GameDataSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666191);
      GameDataSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666192);
      GameDataSystem.NativeMethodInfoPtr_RegisterManagedDataLookup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666193);
      GameDataSystem.NativeMethodInfoPtr_RegisterItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666194);
      GameDataSystem.NativeMethodInfoPtr_RegisterItemGroups_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666195);
      GameDataSystem.NativeMethodInfoPtr_RegisterDropTableDatas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666196);
      GameDataSystem.NativeMethodInfoPtr_RegisterRecipes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666197);
      GameDataSystem.NativeMethodInfoPtr_RegisterCastleData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666198);
      GameDataSystem.NativeMethodInfoPtr_RegisterBlueprints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666199);
      GameDataSystem.NativeMethodInfoPtr_RegisterStationBonuses_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666200);
      GameDataSystem.NativeMethodInfoPtr_RegisterRepairstationData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666201);
      GameDataSystem.NativeMethodInfoPtr_RegisterRoofCategories_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666202);
      GameDataSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666203);
      GameDataSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666204);
      GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterManagedDataLookup_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666205);
      GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterItems_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666206);
      GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterItems_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666207);
      GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterItemGroups_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666208);
      GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterDropTableDatas_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666209);
      GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterRecipes_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666210);
      GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterRecipes_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666211);
      GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterRecipes_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666212);
      GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterCastleData_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666213);
      GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterCastleData_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666214);
      GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterCastleData_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666215);
      GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterCastleData_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666216);
      GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterBlueprints_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666217);
      GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterStationBonuses_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666218);
      GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterRepairstationData_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666219);
      GameDataSystem.NativeMethodInfoPtr___GetEntityQuery_ForRegisterRoofCategories_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666220);
      GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666221);
      GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666222);
      GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666223);
      GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666224);
      GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666225);
      GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_5 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666226);
      GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_6 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666227);
      GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_7 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666228);
      GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_8 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666229);
      GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_9 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666230);
      GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_10 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666231);
      GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_11 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666232);
      GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_12 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666233);
      GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_13 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666234);
      GameDataSystem.NativeMethodInfoPtr_Method_Public_Static_Void_14 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, 100666235);
    }

    public GameDataSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _RegisterManagedDataQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__RegisterManagedDataQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__RegisterManagedDataQuery)) = value;
      }
    }

    public unsafe SingletonAccessor<WorldTypeSingleton> _WorldTypeAccessor
    {
      get
      {
        return *(SingletonAccessor<WorldTypeSingleton>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__WorldTypeAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__WorldTypeAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<WorldTypeSingleton>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerGameBalanceSettings> _ServerGameBalanceAccessor
    {
      get
      {
        return *(SingletonAccessor<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__ServerGameBalanceAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__ServerGameBalanceAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeHashMap<PrefabGUID, float> _OriginalRecipeDurations
    {
      get
      {
        return *(NativeHashMap<PrefabGUID, float>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__OriginalRecipeDurations));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__OriginalRecipeDurations), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Dictionary<PrefabLookupKey, Il2CppSystem.Object> _ManagedDataLookupMap
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__ManagedDataLookupMap));
        return pointer == System.IntPtr.Zero ? (Dictionary<PrefabLookupKey, Il2CppSystem.Object>) null : new Dictionary<PrefabLookupKey, Il2CppSystem.Object>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__ManagedDataLookupMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeHashMap<PrefabGUID, ItemData> _ItemHashLookupMap_k__BackingField
    {
      get
      {
        return *(NativeHashMap<PrefabGUID, ItemData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__ItemHashLookupMap_k__BackingField));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__ItemHashLookupMap_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, ItemData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<PrefabGUID, ItemDataDropGroup> _ItemGroupHashLookupMap_k__BackingField
    {
      get
      {
        return *(NativeHashMap<PrefabGUID, ItemDataDropGroup>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__ItemGroupHashLookupMap_k__BackingField));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__ItemGroupHashLookupMap_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, ItemDataDropGroup>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<PrefabGUID, DropTableData> _DropTableDataHashLookupMap_k__BackingField
    {
      get
      {
        return *(NativeHashMap<PrefabGUID, DropTableData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__DropTableDataHashLookupMap_k__BackingField));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__DropTableDataHashLookupMap_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, DropTableData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<PrefabGUID, BlueprintData> _BlueprintHashLookupMap_k__BackingField
    {
      get
      {
        return *(NativeHashMap<PrefabGUID, BlueprintData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__BlueprintHashLookupMap_k__BackingField));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__BlueprintHashLookupMap_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, BlueprintData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<PrefabGUID, RecipeData> _RecipeHashLookupMap_k__BackingField
    {
      get
      {
        return *(NativeHashMap<PrefabGUID, RecipeData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__RecipeHashLookupMap_k__BackingField));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__RecipeHashLookupMap_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, RecipeData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<PrefabGUID, UpgradeData> _UpgradeHashLookupMap_k__BackingField
    {
      get
      {
        return *(NativeHashMap<PrefabGUID, UpgradeData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__UpgradeHashLookupMap_k__BackingField));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__UpgradeHashLookupMap_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, UpgradeData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<PrefabGUID, CastleRaidData> _CastleRaidHashLookupMap_k__BackingField
    {
      get
      {
        return *(NativeHashMap<PrefabGUID, CastleRaidData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__CastleRaidHashLookupMap_k__BackingField));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__CastleRaidHashLookupMap_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, CastleRaidData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<PrefabGUID, CastleClaimData> _CastleClaimHashLookupMap_k__BackingField
    {
      get
      {
        return *(NativeHashMap<PrefabGUID, CastleClaimData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__CastleClaimHashLookupMap_k__BackingField));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__CastleClaimHashLookupMap_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, CastleClaimData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<PrefabGUID, CastleDestroyData> _CastleDestroyHashLookupMap_k__BackingField
    {
      get
      {
        return *(NativeHashMap<PrefabGUID, CastleDestroyData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__CastleDestroyHashLookupMap_k__BackingField));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__CastleDestroyHashLookupMap_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, CastleDestroyData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<PrefabGUID, StationBonusData> _StationBonusLookupMap_k__BackingField
    {
      get
      {
        return *(NativeHashMap<PrefabGUID, StationBonusData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__StationBonusLookupMap_k__BackingField));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__StationBonusLookupMap_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, StationBonusData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<PrefabGUID, RepairstationData> _RepairstationDataHashLookupMap_k__BackingField
    {
      get
      {
        return *(NativeHashMap<PrefabGUID, RepairstationData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__RepairstationDataHashLookupMap_k__BackingField));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__RepairstationDataHashLookupMap_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, RepairstationData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<int, Entity> _RoofCategoryLookupMap_k__BackingField
    {
      get
      {
        return *(NativeHashMap<int, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__RoofCategoryLookupMap_k__BackingField));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr__RoofCategoryLookupMap_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe RandomLocalizationKeys RandomLocalizationKeys
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr_RandomLocalizationKeys));
        return pointer == System.IntPtr.Zero ? (RandomLocalizationKeys) null : new RandomLocalizationKeys(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr_RandomLocalizationKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __RegisterManagedDataLookup_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterManagedDataLookup_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterManagedDataLookup_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RegisterManagedDataLookup_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterManagedDataLookup_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterManagedDataLookup_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RegisterItems_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterItems_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterItems_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RegisterItems_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterItems_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterItems_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RegisterItems_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterItems_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterItems_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RegisterItems_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterItems_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterItems_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RegisterItemGroups_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterItemGroups_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterItemGroups_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RegisterItemGroups_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterItemGroups_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterItemGroups_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RegisterDropTableDatas_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterDropTableDatas_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterDropTableDatas_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RegisterDropTableDatas_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterDropTableDatas_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterDropTableDatas_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RegisterRecipes_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterRecipes_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterRecipes_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RegisterRecipes_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterRecipes_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterRecipes_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RegisterRecipes_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterRecipes_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterRecipes_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RegisterRecipes_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterRecipes_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterRecipes_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RegisterRecipes_LambdaJob2_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterRecipes_LambdaJob2_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterRecipes_LambdaJob2_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RegisterRecipes_LambdaJob2_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterRecipes_LambdaJob2_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterRecipes_LambdaJob2_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RegisterCastleData_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RegisterCastleData_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RegisterCastleData_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RegisterCastleData_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RegisterCastleData_LambdaJob2_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob2_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob2_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RegisterCastleData_LambdaJob2_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob2_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob2_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RegisterCastleData_LambdaJob3_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob3_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob3_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RegisterCastleData_LambdaJob3_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob3_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterCastleData_LambdaJob3_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RegisterBlueprints_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterBlueprints_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterBlueprints_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RegisterBlueprints_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterBlueprints_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterBlueprints_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RegisterStationBonuses_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterStationBonuses_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterStationBonuses_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RegisterStationBonuses_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterStationBonuses_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterStationBonuses_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RegisterRepairstationData_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterRepairstationData_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterRepairstationData_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RegisterRepairstationData_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterRepairstationData_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterRepairstationData_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RegisterRoofCategories_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterRoofCategories_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterRoofCategories_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RegisterRoofCategories_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterRoofCategories_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.NativeFieldInfoPtr___RegisterRoofCategories_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/<>c__DisplayClass60_0")]
    public sealed class __c__DisplayClass60_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_worldType;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_lookupMap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RegisterManagedDataLookup_b__0_Internal_Void_Entity_byref_RegisterManagedDataEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass60_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass60_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RegisterManagedDataLookup_b__0(
        Entity entity,
        [In] ref RegisterManagedDataEvent registerManagedDataEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref registerManagedDataEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass60_0.NativeMethodInfoPtr__RegisterManagedDataLookup_b__0_Internal_Void_Entity_byref_RegisterManagedDataEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass60_0()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass60_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass60_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass60_0>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass60_0.NativeFieldInfoPtr_worldType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass60_0>.NativeClassPtr, nameof (worldType));
        GameDataSystem.__c__DisplayClass60_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass60_0>.NativeClassPtr, "<>4__this");
        GameDataSystem.__c__DisplayClass60_0.NativeFieldInfoPtr_lookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass60_0>.NativeClassPtr, nameof (lookupMap));
        GameDataSystem.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass60_0>.NativeClassPtr, 100666236);
        GameDataSystem.__c__DisplayClass60_0.NativeMethodInfoPtr__RegisterManagedDataLookup_b__0_Internal_Void_Entity_byref_RegisterManagedDataEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass60_0>.NativeClassPtr, 100666237);
      }

      public __c__DisplayClass60_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass60_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass60_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass60_0>.NativeClassPtr, data));
      }

      public unsafe WorldType worldType
      {
        get
        {
          return *(WorldType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass60_0.NativeFieldInfoPtr_worldType));
        }
        [param: In] set
        {
          *(WorldType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass60_0.NativeFieldInfoPtr_worldType)) = value;
        }
      }

      public unsafe GameDataSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass60_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass60_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Dictionary<PrefabLookupKey, Il2CppSystem.Object> lookupMap
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass60_0.NativeFieldInfoPtr_lookupMap));
          return pointer == System.IntPtr.Zero ? (Dictionary<PrefabLookupKey, Il2CppSystem.Object>) null : new Dictionary<PrefabLookupKey, Il2CppSystem.Object>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass60_0.NativeFieldInfoPtr_lookupMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/<>c__DisplayClass61_0")]
    public sealed class __c__DisplayClass61_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_maxStacksModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_bloodBoundEquipment;
      private static readonly System.IntPtr NativeFieldInfoPtr_teleportBoundItems;
      private static readonly System.IntPtr NativeFieldInfoPtr_itemHashLookupMap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RegisterItems_b__0_Internal_Void_byref_RegisterPrefab_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RegisterItems_b__1_Internal_Void_byref_ItemData_byref_RegisterPrefabEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass61_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass61_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RegisterItems_b__0([In] ref RegisterPrefab registerPrefab)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref registerPrefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass61_0.NativeMethodInfoPtr__RegisterItems_b__0_Internal_Void_byref_RegisterPrefab_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RegisterItems_b__1(
        ref ItemData itemData,
        [In] ref RegisterPrefabEvent registerEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref itemData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref registerEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass61_0.NativeMethodInfoPtr__RegisterItems_b__1_Internal_Void_byref_ItemData_byref_RegisterPrefabEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass61_0()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass61_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass61_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass61_0>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass61_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass61_0>.NativeClassPtr, "<>4__this");
        GameDataSystem.__c__DisplayClass61_0.NativeFieldInfoPtr_maxStacksModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass61_0>.NativeClassPtr, nameof (maxStacksModifier));
        GameDataSystem.__c__DisplayClass61_0.NativeFieldInfoPtr_bloodBoundEquipment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass61_0>.NativeClassPtr, nameof (bloodBoundEquipment));
        GameDataSystem.__c__DisplayClass61_0.NativeFieldInfoPtr_teleportBoundItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass61_0>.NativeClassPtr, nameof (teleportBoundItems));
        GameDataSystem.__c__DisplayClass61_0.NativeFieldInfoPtr_itemHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass61_0>.NativeClassPtr, nameof (itemHashLookupMap));
        GameDataSystem.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass61_0>.NativeClassPtr, 100666238);
        GameDataSystem.__c__DisplayClass61_0.NativeMethodInfoPtr__RegisterItems_b__0_Internal_Void_byref_RegisterPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass61_0>.NativeClassPtr, 100666239);
        GameDataSystem.__c__DisplayClass61_0.NativeMethodInfoPtr__RegisterItems_b__1_Internal_Void_byref_ItemData_byref_RegisterPrefabEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass61_0>.NativeClassPtr, 100666240);
      }

      public __c__DisplayClass61_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass61_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass61_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass61_0>.NativeClassPtr, data));
      }

      public unsafe GameDataSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass61_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass61_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float maxStacksModifier
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass61_0.NativeFieldInfoPtr_maxStacksModifier));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass61_0.NativeFieldInfoPtr_maxStacksModifier)) = value;
        }
      }

      public unsafe bool bloodBoundEquipment
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass61_0.NativeFieldInfoPtr_bloodBoundEquipment));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass61_0.NativeFieldInfoPtr_bloodBoundEquipment)) = value;
        }
      }

      public unsafe bool teleportBoundItems
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass61_0.NativeFieldInfoPtr_teleportBoundItems));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass61_0.NativeFieldInfoPtr_teleportBoundItems)) = value;
        }
      }

      public unsafe NativeHashMap<PrefabGUID, ItemData> itemHashLookupMap
      {
        get
        {
          return *(NativeHashMap<PrefabGUID, ItemData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass61_0.NativeFieldInfoPtr_itemHashLookupMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass61_0.NativeFieldInfoPtr_itemHashLookupMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, ItemData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/<>c__DisplayClass62_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass62_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_itemGroupHashLookupMap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RegisterItemGroups_b__0_Internal_Void_byref_RegisterPrefabEvent_byref_ItemDataDropGroup_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, ItemDataDropGroup> itemGroupHashLookupMap;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass62_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RegisterItemGroups_b__0(
        [In] ref RegisterPrefabEvent registerEvent,
        [In] ref ItemDataDropGroup itemDataGroup)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref itemDataGroup;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass62_0.NativeMethodInfoPtr__RegisterItemGroups_b__0_Internal_Void_byref_RegisterPrefabEvent_byref_ItemDataDropGroup_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass62_0()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass62_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass62_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass62_0>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass62_0.NativeFieldInfoPtr_itemGroupHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass62_0>.NativeClassPtr, nameof (itemGroupHashLookupMap));
        GameDataSystem.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass62_0>.NativeClassPtr, 100666241);
        GameDataSystem.__c__DisplayClass62_0.NativeMethodInfoPtr__RegisterItemGroups_b__0_Internal_Void_byref_RegisterPrefabEvent_byref_ItemDataDropGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass62_0>.NativeClassPtr, 100666242);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass62_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/<>c__DisplayClass63_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass63_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_dropTableDataHashLookupMap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RegisterDropTableDatas_b__0_Internal_Void_byref_RegisterPrefabEvent_byref_DropTableData_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, DropTableData> dropTableDataHashLookupMap;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass63_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RegisterDropTableDatas_b__0(
        [In] ref RegisterPrefabEvent registerEvent,
        [In] ref DropTableData dropTableData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref dropTableData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass63_0.NativeMethodInfoPtr__RegisterDropTableDatas_b__0_Internal_Void_byref_RegisterPrefabEvent_byref_DropTableData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass63_0()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass63_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass63_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass63_0>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass63_0.NativeFieldInfoPtr_dropTableDataHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass63_0>.NativeClassPtr, nameof (dropTableDataHashLookupMap));
        GameDataSystem.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass63_0>.NativeClassPtr, 100666243);
        GameDataSystem.__c__DisplayClass63_0.NativeMethodInfoPtr__RegisterDropTableDatas_b__0_Internal_Void_byref_RegisterPrefabEvent_byref_DropTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass63_0>.NativeClassPtr, 100666244);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass63_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/<>c__DisplayClass64_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass64_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_originalRecipeDurations;
      private static readonly System.IntPtr NativeFieldInfoPtr_recipeHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_refinementstationRecipes;
      private static readonly System.IntPtr NativeFieldInfoPtr_workstationRecipes;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RegisterRecipes_b__0_Internal_Void_byref_RecipeData_byref_RegisterPrefabEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RegisterRecipes_b__1_Internal_Void_byref_DynamicBuffer_1_RefinementstationRecipesBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RegisterRecipes_b__2_Internal_Void_byref_DynamicBuffer_1_WorkstationRecipesBuffer_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, float> originalRecipeDurations;
      [FieldOffset(16)]
      public NativeHashMap<PrefabGUID, RecipeData> recipeHashLookupMap;
      [FieldOffset(32)]
      public NativeHashSet<PrefabGUID> refinementstationRecipes;
      [FieldOffset(48)]
      public NativeHashSet<PrefabGUID> workstationRecipes;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass64_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RegisterRecipes_b__0(
        ref RecipeData recipeData,
        [In] ref RegisterPrefabEvent registerEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref recipeData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref registerEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass64_0.NativeMethodInfoPtr__RegisterRecipes_b__0_Internal_Void_byref_RecipeData_byref_RegisterPrefabEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RegisterRecipes_b__1(
        [In] ref DynamicBuffer<RefinementstationRecipesBuffer> rRecipes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref rRecipes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass64_0.NativeMethodInfoPtr__RegisterRecipes_b__1_Internal_Void_byref_DynamicBuffer_1_RefinementstationRecipesBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RegisterRecipes_b__2(
        [In] ref DynamicBuffer<WorkstationRecipesBuffer> wRecipes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref wRecipes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass64_0.NativeMethodInfoPtr__RegisterRecipes_b__2_Internal_Void_byref_DynamicBuffer_1_WorkstationRecipesBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass64_0()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass64_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass64_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass64_0>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass64_0.NativeFieldInfoPtr_originalRecipeDurations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass64_0>.NativeClassPtr, nameof (originalRecipeDurations));
        GameDataSystem.__c__DisplayClass64_0.NativeFieldInfoPtr_recipeHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass64_0>.NativeClassPtr, nameof (recipeHashLookupMap));
        GameDataSystem.__c__DisplayClass64_0.NativeFieldInfoPtr_refinementstationRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass64_0>.NativeClassPtr, nameof (refinementstationRecipes));
        GameDataSystem.__c__DisplayClass64_0.NativeFieldInfoPtr_workstationRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass64_0>.NativeClassPtr, nameof (workstationRecipes));
        GameDataSystem.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass64_0>.NativeClassPtr, 100666245);
        GameDataSystem.__c__DisplayClass64_0.NativeMethodInfoPtr__RegisterRecipes_b__0_Internal_Void_byref_RecipeData_byref_RegisterPrefabEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass64_0>.NativeClassPtr, 100666246);
        GameDataSystem.__c__DisplayClass64_0.NativeMethodInfoPtr__RegisterRecipes_b__1_Internal_Void_byref_DynamicBuffer_1_RefinementstationRecipesBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass64_0>.NativeClassPtr, 100666247);
        GameDataSystem.__c__DisplayClass64_0.NativeMethodInfoPtr__RegisterRecipes_b__2_Internal_Void_byref_DynamicBuffer_1_WorkstationRecipesBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass64_0>.NativeClassPtr, 100666248);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass64_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/<>c__DisplayClass65_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass65_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_upgradeHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_castleRaidHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_castleClaimHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_castleDestroyHashLookupMap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RegisterCastleData_b__0_Internal_Void_byref_RegisterPrefabEvent_byref_UpgradeData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RegisterCastleData_b__1_Internal_Void_byref_RegisterPrefabEvent_byref_CastleRaidData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RegisterCastleData_b__2_Internal_Void_byref_RegisterPrefabEvent_byref_CastleClaimData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RegisterCastleData_b__3_Internal_Void_byref_RegisterPrefabEvent_byref_CastleDestroyData_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, UpgradeData> upgradeHashLookupMap;
      [FieldOffset(16)]
      public NativeHashMap<PrefabGUID, CastleRaidData> castleRaidHashLookupMap;
      [FieldOffset(32)]
      public NativeHashMap<PrefabGUID, CastleClaimData> castleClaimHashLookupMap;
      [FieldOffset(48)]
      public NativeHashMap<PrefabGUID, CastleDestroyData> castleDestroyHashLookupMap;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass65_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RegisterCastleData_b__0(
        [In] ref RegisterPrefabEvent registerEvent,
        [In] ref UpgradeData upgradeData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref upgradeData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass65_0.NativeMethodInfoPtr__RegisterCastleData_b__0_Internal_Void_byref_RegisterPrefabEvent_byref_UpgradeData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RegisterCastleData_b__1(
        [In] ref RegisterPrefabEvent registerEvent,
        [In] ref CastleRaidData upgradeData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref upgradeData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass65_0.NativeMethodInfoPtr__RegisterCastleData_b__1_Internal_Void_byref_RegisterPrefabEvent_byref_CastleRaidData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RegisterCastleData_b__2(
        [In] ref RegisterPrefabEvent registerEvent,
        [In] ref CastleClaimData upgradeData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref upgradeData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass65_0.NativeMethodInfoPtr__RegisterCastleData_b__2_Internal_Void_byref_RegisterPrefabEvent_byref_CastleClaimData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RegisterCastleData_b__3(
        [In] ref RegisterPrefabEvent registerEvent,
        [In] ref CastleDestroyData upgradeData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref upgradeData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass65_0.NativeMethodInfoPtr__RegisterCastleData_b__3_Internal_Void_byref_RegisterPrefabEvent_byref_CastleDestroyData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass65_0()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass65_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass65_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass65_0>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass65_0.NativeFieldInfoPtr_upgradeHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass65_0>.NativeClassPtr, nameof (upgradeHashLookupMap));
        GameDataSystem.__c__DisplayClass65_0.NativeFieldInfoPtr_castleRaidHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass65_0>.NativeClassPtr, nameof (castleRaidHashLookupMap));
        GameDataSystem.__c__DisplayClass65_0.NativeFieldInfoPtr_castleClaimHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass65_0>.NativeClassPtr, nameof (castleClaimHashLookupMap));
        GameDataSystem.__c__DisplayClass65_0.NativeFieldInfoPtr_castleDestroyHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass65_0>.NativeClassPtr, nameof (castleDestroyHashLookupMap));
        GameDataSystem.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass65_0>.NativeClassPtr, 100666249);
        GameDataSystem.__c__DisplayClass65_0.NativeMethodInfoPtr__RegisterCastleData_b__0_Internal_Void_byref_RegisterPrefabEvent_byref_UpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass65_0>.NativeClassPtr, 100666250);
        GameDataSystem.__c__DisplayClass65_0.NativeMethodInfoPtr__RegisterCastleData_b__1_Internal_Void_byref_RegisterPrefabEvent_byref_CastleRaidData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass65_0>.NativeClassPtr, 100666251);
        GameDataSystem.__c__DisplayClass65_0.NativeMethodInfoPtr__RegisterCastleData_b__2_Internal_Void_byref_RegisterPrefabEvent_byref_CastleClaimData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass65_0>.NativeClassPtr, 100666252);
        GameDataSystem.__c__DisplayClass65_0.NativeMethodInfoPtr__RegisterCastleData_b__3_Internal_Void_byref_RegisterPrefabEvent_byref_CastleDestroyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass65_0>.NativeClassPtr, 100666253);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass65_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/<>c__DisplayClass66_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass66_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_dismantleResourceModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_blueprintHashLookupMap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RegisterBlueprints_b__0_Internal_Void_byref_BlueprintData_byref_RegisterPrefabEvent_0;
      [FieldOffset(0)]
      public float dismantleResourceModifier;
      [FieldOffset(8)]
      public NativeHashMap<PrefabGUID, BlueprintData> blueprintHashLookupMap;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass66_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RegisterBlueprints_b__0(
        ref BlueprintData blueprintData,
        [In] ref RegisterPrefabEvent registerEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref blueprintData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref registerEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass66_0.NativeMethodInfoPtr__RegisterBlueprints_b__0_Internal_Void_byref_BlueprintData_byref_RegisterPrefabEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass66_0()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass66_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass66_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass66_0>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass66_0.NativeFieldInfoPtr_dismantleResourceModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass66_0>.NativeClassPtr, nameof (dismantleResourceModifier));
        GameDataSystem.__c__DisplayClass66_0.NativeFieldInfoPtr_blueprintHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass66_0>.NativeClassPtr, nameof (blueprintHashLookupMap));
        GameDataSystem.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass66_0>.NativeClassPtr, 100666254);
        GameDataSystem.__c__DisplayClass66_0.NativeMethodInfoPtr__RegisterBlueprints_b__0_Internal_Void_byref_BlueprintData_byref_RegisterPrefabEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass66_0>.NativeClassPtr, 100666255);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass66_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/<>c__DisplayClass67_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass67_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_stationBonusHashLookupMap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RegisterStationBonuses_b__0_Internal_Void_byref_RegisterPrefabEvent_byref_StationBonusData_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, StationBonusData> stationBonusHashLookupMap;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass67_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RegisterStationBonuses_b__0(
        [In] ref RegisterPrefabEvent registerEvent,
        [In] ref StationBonusData stationBonusData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref stationBonusData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass67_0.NativeMethodInfoPtr__RegisterStationBonuses_b__0_Internal_Void_byref_RegisterPrefabEvent_byref_StationBonusData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass67_0()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass67_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass67_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass67_0>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass67_0.NativeFieldInfoPtr_stationBonusHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass67_0>.NativeClassPtr, nameof (stationBonusHashLookupMap));
        GameDataSystem.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass67_0>.NativeClassPtr, 100666256);
        GameDataSystem.__c__DisplayClass67_0.NativeMethodInfoPtr__RegisterStationBonuses_b__0_Internal_Void_byref_RegisterPrefabEvent_byref_StationBonusData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass67_0>.NativeClassPtr, 100666257);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass67_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/<>c__DisplayClass68_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass68_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_repairstationDataHashLookupMap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RegisterRepairstationData_b__0_Internal_Void_byref_RegisterPrefabEvent_byref_RepairstationData_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, RepairstationData> repairstationDataHashLookupMap;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass68_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RegisterRepairstationData_b__0(
        [In] ref RegisterPrefabEvent registerEvent,
        [In] ref RepairstationData repairstationData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref repairstationData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass68_0.NativeMethodInfoPtr__RegisterRepairstationData_b__0_Internal_Void_byref_RegisterPrefabEvent_byref_RepairstationData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass68_0()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass68_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass68_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass68_0>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass68_0.NativeFieldInfoPtr_repairstationDataHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass68_0>.NativeClassPtr, nameof (repairstationDataHashLookupMap));
        GameDataSystem.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass68_0>.NativeClassPtr, 100666258);
        GameDataSystem.__c__DisplayClass68_0.NativeMethodInfoPtr__RegisterRepairstationData_b__0_Internal_Void_byref_RegisterPrefabEvent_byref_RepairstationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass68_0>.NativeClassPtr, 100666259);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass68_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/<>c__DisplayClass69_0")]
    public sealed class __c__DisplayClass69_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_lookupMap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RegisterRoofCategories_b__0_Internal_Void_byref_RegisterPrefab_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass69_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass69_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass69_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RegisterRoofCategories_b__0([In] ref RegisterPrefab registerPrefab)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref registerPrefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass69_0.NativeMethodInfoPtr__RegisterRoofCategories_b__0_Internal_Void_byref_RegisterPrefab_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass69_0()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass69_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass69_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass69_0>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass69_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass69_0>.NativeClassPtr, "<>4__this");
        GameDataSystem.__c__DisplayClass69_0.NativeFieldInfoPtr_lookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass69_0>.NativeClassPtr, nameof (lookupMap));
        GameDataSystem.__c__DisplayClass69_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass69_0>.NativeClassPtr, 100666260);
        GameDataSystem.__c__DisplayClass69_0.NativeMethodInfoPtr__RegisterRoofCategories_b__0_Internal_Void_byref_RegisterPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass69_0>.NativeClassPtr, 100666261);
      }

      public __c__DisplayClass69_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass69_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass69_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass69_0>.NativeClassPtr, data));
      }

      public unsafe GameDataSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass69_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass69_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeHashMap<int, Entity> lookupMap
      {
        get
        {
          return *(NativeHashMap<int, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass69_0.NativeFieldInfoPtr_lookupMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass69_0.NativeFieldInfoPtr_lookupMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterManagedDataLookup_LambdaJob0")]
    public sealed class __c__DisplayClass_RegisterManagedDataLookup_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_worldType;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_lookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RegisterManagedDataEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass60_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass60_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass60_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 751515, RefRangeEnd = 751516, XrefRangeStart = 751477, XrefRangeEnd = 751515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref RegisterManagedDataEvent registerManagedDataEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref registerManagedDataEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RegisterManagedDataEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 751518, RefRangeEnd = 751519, XrefRangeStart = 751516, XrefRangeEnd = 751518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GameDataSystem.__c__DisplayClass60_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass60_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 751521, RefRangeEnd = 751522, XrefRangeStart = 751519, XrefRangeEnd = 751521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GameDataSystem.__c__DisplayClass60_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass60_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751522, XrefRangeEnd = 751524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 751530, RefRangeEnd = 751531, XrefRangeStart = 751524, XrefRangeEnd = 751530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 751533, RefRangeEnd = 751534, XrefRangeStart = 751531, XrefRangeEnd = 751533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GameDataSystem componentSystem,
        ref GameDataSystem.__c__DisplayClass60_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass60_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751534, XrefRangeEnd = 751540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RegisterManagedDataLookup_LambdaJob0()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass_RegisterManagedDataLookup_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeFieldInfoPtr_worldType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0>.NativeClassPtr, nameof (worldType));
        GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0>.NativeClassPtr, "<>4__this");
        GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeFieldInfoPtr_lookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0>.NativeClassPtr, nameof (lookupMap));
        GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_RegisterManagedDataEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0>.NativeClassPtr, 100666262);
        GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass60_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0>.NativeClassPtr, 100666263);
        GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass60_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0>.NativeClassPtr, 100666264);
        GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0>.NativeClassPtr, 100666265);
        GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0>.NativeClassPtr, 100666266);
        GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass60_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0>.NativeClassPtr, 100666267);
        GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0>.NativeClassPtr, 100666268);
      }

      public __c__DisplayClass_RegisterManagedDataLookup_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_RegisterManagedDataLookup_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe WorldType worldType
      {
        get
        {
          return *(WorldType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeFieldInfoPtr_worldType));
        }
        [param: In] set
        {
          *(WorldType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeFieldInfoPtr_worldType)) = value;
        }
      }

      public unsafe GameDataSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Dictionary<PrefabLookupKey, Il2CppSystem.Object> lookupMap
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeFieldInfoPtr_lookupMap));
          return pointer == System.IntPtr.Zero ? (Dictionary<PrefabLookupKey, Il2CppSystem.Object>) null : new Dictionary<PrefabLookupKey, Il2CppSystem.Object>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeFieldInfoPtr_lookupMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_registerManagedDataEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<RegisterManagedDataEvent> forParameter_registerManagedDataEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 751471, RefRangeEnd = 751472, XrefRangeStart = 751467, XrefRangeEnd = 751471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GameDataSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 751476, RefRangeEnd = 751477, XrefRangeStart = 751472, XrefRangeEnd = 751476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_registerManagedDataEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_registerManagedDataEvent));
          GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666269);
          GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666270);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_registerManagedDataEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<RegisterManagedDataEvent>.Runtime runtime_registerManagedDataEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_registerManagedDataEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_registerManagedDataEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterManagedDataLookup_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterItems_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RegisterItems_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_maxStacksModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_bloodBoundEquipment;
      private static readonly System.IntPtr NativeFieldInfoPtr_teleportBoundItems;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ItemData_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefab_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass61_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass61_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass61_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public float maxStacksModifier;
      [FieldOffset(4)]
      public bool bloodBoundEquipment;
      [FieldOffset(5)]
      public bool teleportBoundItems;
      [FieldOffset(8)]
      public ComponentDataFromEntity<ItemData> _ComponentDataFromEntity_ItemData_0;
      [FieldOffset(40)]
      public GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(72)]
      public unsafe GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751623, XrefRangeEnd = 751634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref RegisterPrefab registerPrefab)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref registerPrefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefab_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 751634, RefRangeEnd = 751635, XrefRangeStart = 751634, XrefRangeEnd = 751634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GameDataSystem.__c__DisplayClass61_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass61_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 751635, RefRangeEnd = 751636, XrefRangeStart = 751635, XrefRangeEnd = 751635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GameDataSystem.__c__DisplayClass61_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass61_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751636, XrefRangeEnd = 751638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 751643, RefRangeEnd = 751644, XrefRangeStart = 751638, XrefRangeEnd = 751643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 751649, RefRangeEnd = 751650, XrefRangeStart = 751644, XrefRangeEnd = 751649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GameDataSystem componentSystem,
        ref GameDataSystem.__c__DisplayClass61_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass61_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751650, XrefRangeEnd = 751654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751654, XrefRangeEnd = 751660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RegisterItems_LambdaJob0()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass_RegisterItems_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeFieldInfoPtr_maxStacksModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0>.NativeClassPtr, nameof (maxStacksModifier));
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeFieldInfoPtr_bloodBoundEquipment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0>.NativeClassPtr, nameof (bloodBoundEquipment));
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeFieldInfoPtr_teleportBoundItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0>.NativeClassPtr, nameof (teleportBoundItems));
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_ItemData_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_ItemData_0));
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0>.NativeClassPtr, 100666271);
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass61_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0>.NativeClassPtr, 100666272);
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass61_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0>.NativeClassPtr, 100666273);
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0>.NativeClassPtr, 100666274);
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0>.NativeClassPtr, 100666275);
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass61_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0>.NativeClassPtr, 100666276);
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0>.NativeClassPtr, 100666277);
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0>.NativeClassPtr, 100666278);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_registerPrefab;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<RegisterPrefab> forParameter_registerPrefab;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 751543, RefRangeEnd = 751544, XrefRangeStart = 751540, XrefRangeEnd = 751543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GameDataSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 751547, RefRangeEnd = 751548, XrefRangeStart = 751544, XrefRangeEnd = 751547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_registerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_registerPrefab));
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666279);
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666280);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_registerPrefab;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<RegisterPrefab>.Runtime runtime_registerPrefab;

          static Runtimes()
          {
            Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_registerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_registerPrefab));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterItems_LambdaJob0/ProjectM.RunWithoutJobSystem_00000B1E$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000B1E$PostfixBurstDelegate");
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666281);
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666282);
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666283);
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666284);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterItems_LambdaJob0/ProjectM.RunWithoutJobSystem_00000B1E$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751548, XrefRangeEnd = 751562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751562, XrefRangeEnd = 751580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751580, XrefRangeEnd = 751595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 751622, RefRangeEnd = 751623, XrefRangeStart = 751595, XrefRangeEnd = 751622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000B1E$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666285);
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666286);
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666287);
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666288);
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666290);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterItems_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RegisterItems_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_maxStacksModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_bloodBoundEquipment;
      private static readonly System.IntPtr NativeFieldInfoPtr_teleportBoundItems;
      private static readonly System.IntPtr NativeFieldInfoPtr_itemHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ItemData_byref_RegisterPrefabEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass61_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass61_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass61_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public float maxStacksModifier;
      [FieldOffset(4)]
      public bool bloodBoundEquipment;
      [FieldOffset(5)]
      public bool teleportBoundItems;
      [FieldOffset(8)]
      public NativeHashMap<PrefabGUID, ItemData> itemHashLookupMap;
      [FieldOffset(24)]
      public GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751749, XrefRangeEnd = 751756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref ItemData itemData,
        [In] ref RegisterPrefabEvent registerEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref itemData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref registerEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ItemData_byref_RegisterPrefabEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 751756, RefRangeEnd = 751757, XrefRangeStart = 751756, XrefRangeEnd = 751756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GameDataSystem.__c__DisplayClass61_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass61_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 751757, RefRangeEnd = 751758, XrefRangeStart = 751757, XrefRangeEnd = 751757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GameDataSystem.__c__DisplayClass61_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass61_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751758, XrefRangeEnd = 751760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 751768, RefRangeEnd = 751769, XrefRangeStart = 751760, XrefRangeEnd = 751768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 751771, RefRangeEnd = 751772, XrefRangeStart = 751769, XrefRangeEnd = 751771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GameDataSystem componentSystem,
        ref GameDataSystem.__c__DisplayClass61_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass61_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751772, XrefRangeEnd = 751776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751776, XrefRangeEnd = 751782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RegisterItems_LambdaJob1()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass_RegisterItems_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeFieldInfoPtr_maxStacksModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1>.NativeClassPtr, nameof (maxStacksModifier));
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeFieldInfoPtr_bloodBoundEquipment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1>.NativeClassPtr, nameof (bloodBoundEquipment));
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeFieldInfoPtr_teleportBoundItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1>.NativeClassPtr, nameof (teleportBoundItems));
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeFieldInfoPtr_itemHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1>.NativeClassPtr, nameof (itemHashLookupMap));
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ItemData_byref_RegisterPrefabEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1>.NativeClassPtr, 100666291);
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass61_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1>.NativeClassPtr, 100666292);
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass61_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1>.NativeClassPtr, 100666293);
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1>.NativeClassPtr, 100666294);
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1>.NativeClassPtr, 100666295);
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass61_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1>.NativeClassPtr, 100666296);
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1>.NativeClassPtr, 100666297);
        GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1>.NativeClassPtr, 100666298);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_itemData;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_registerEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<ItemData> forParameter_itemData;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent> forParameter_registerEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 751666, RefRangeEnd = 751667, XrefRangeStart = 751660, XrefRangeEnd = 751666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GameDataSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 751673, RefRangeEnd = 751674, XrefRangeStart = 751667, XrefRangeEnd = 751673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_itemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_itemData));
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_registerEvent));
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100666299);
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100666300);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_itemData;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_registerEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<ItemData>.Runtime runtime_itemData;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent>.Runtime runtime_registerEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_itemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_itemData));
            GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_registerEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterItems_LambdaJob1/ProjectM.RunWithoutJobSystem_00000B27$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000B27$PostfixBurstDelegate");
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666301);
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666302);
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666303);
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666304);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterItems_LambdaJob1/ProjectM.RunWithoutJobSystem_00000B27$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751674, XrefRangeEnd = 751688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751688, XrefRangeEnd = 751706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751706, XrefRangeEnd = 751721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 751748, RefRangeEnd = 751749, XrefRangeStart = 751721, XrefRangeEnd = 751748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000B27$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666305);
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666306);
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666307);
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666308);
          GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666310);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterItems_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterItemGroups_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RegisterItemGroups_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_itemGroupHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_ItemDataDropGroup_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass62_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass62_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass62_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, ItemDataDropGroup> itemGroupHashLookupMap;
      [FieldOffset(16)]
      public GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751871, XrefRangeEnd = 751874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref RegisterPrefabEvent registerEvent,
        [In] ref ItemDataDropGroup itemDataGroup)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref itemDataGroup;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_ItemDataDropGroup_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GameDataSystem.__c__DisplayClass62_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass62_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GameDataSystem.__c__DisplayClass62_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass62_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751874, XrefRangeEnd = 751876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 751884, RefRangeEnd = 751885, XrefRangeStart = 751876, XrefRangeEnd = 751884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 751887, RefRangeEnd = 751888, XrefRangeStart = 751885, XrefRangeEnd = 751887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GameDataSystem componentSystem,
        ref GameDataSystem.__c__DisplayClass62_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass62_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751888, XrefRangeEnd = 751892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751892, XrefRangeEnd = 751898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RegisterItemGroups_LambdaJob0()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass_RegisterItemGroups_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeFieldInfoPtr_itemGroupHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0>.NativeClassPtr, nameof (itemGroupHashLookupMap));
        GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_ItemDataDropGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0>.NativeClassPtr, 100666311);
        GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass62_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0>.NativeClassPtr, 100666312);
        GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass62_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0>.NativeClassPtr, 100666313);
        GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0>.NativeClassPtr, 100666314);
        GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0>.NativeClassPtr, 100666315);
        GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass62_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0>.NativeClassPtr, 100666316);
        GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0>.NativeClassPtr, 100666317);
        GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0>.NativeClassPtr, 100666318);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_registerEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_itemDataGroup;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent> forParameter_registerEvent;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<ItemDataDropGroup> forParameter_itemDataGroup;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 751788, RefRangeEnd = 751789, XrefRangeStart = 751782, XrefRangeEnd = 751788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GameDataSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 751795, RefRangeEnd = 751796, XrefRangeStart = 751789, XrefRangeEnd = 751795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_registerEvent));
          GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_itemDataGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_itemDataGroup));
          GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666319);
          GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666320);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_registerEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_itemDataGroup;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent>.Runtime runtime_registerEvent;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<ItemDataDropGroup>.Runtime runtime_itemDataGroup;

          static Runtimes()
          {
            Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_registerEvent));
            GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_itemDataGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_itemDataGroup));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterItemGroups_LambdaJob0/ProjectM.RunWithoutJobSystem_00000B30$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000B30$PostfixBurstDelegate");
          GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666321);
          GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666322);
          GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666323);
          GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666324);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterItemGroups_LambdaJob0/ProjectM.RunWithoutJobSystem_00000B30$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751796, XrefRangeEnd = 751810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751810, XrefRangeEnd = 751828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751828, XrefRangeEnd = 751843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 751870, RefRangeEnd = 751871, XrefRangeStart = 751843, XrefRangeEnd = 751870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000B30$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666325);
          GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666326);
          GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666327);
          GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666328);
          GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666330);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterItemGroups_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterDropTableDatas_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RegisterDropTableDatas_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_dropTableDataHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_DropTableData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass63_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass63_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass63_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, DropTableData> dropTableDataHashLookupMap;
      [FieldOffset(16)]
      public GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751987, XrefRangeEnd = 751990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref RegisterPrefabEvent registerEvent,
        [In] ref DropTableData dropTableData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref dropTableData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_DropTableData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GameDataSystem.__c__DisplayClass63_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass63_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GameDataSystem.__c__DisplayClass63_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass63_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751990, XrefRangeEnd = 751992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 752000, RefRangeEnd = 752001, XrefRangeStart = 751992, XrefRangeEnd = 752000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 752003, RefRangeEnd = 752004, XrefRangeStart = 752001, XrefRangeEnd = 752003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GameDataSystem componentSystem,
        ref GameDataSystem.__c__DisplayClass63_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass63_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752004, XrefRangeEnd = 752008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752008, XrefRangeEnd = 752014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RegisterDropTableDatas_LambdaJob0()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass_RegisterDropTableDatas_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeFieldInfoPtr_dropTableDataHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0>.NativeClassPtr, nameof (dropTableDataHashLookupMap));
        GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_DropTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0>.NativeClassPtr, 100666331);
        GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass63_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0>.NativeClassPtr, 100666332);
        GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass63_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0>.NativeClassPtr, 100666333);
        GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0>.NativeClassPtr, 100666334);
        GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0>.NativeClassPtr, 100666335);
        GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass63_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0>.NativeClassPtr, 100666336);
        GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0>.NativeClassPtr, 100666337);
        GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0>.NativeClassPtr, 100666338);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_registerEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_dropTableData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent> forParameter_registerEvent;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<DropTableData> forParameter_dropTableData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 751904, RefRangeEnd = 751905, XrefRangeStart = 751898, XrefRangeEnd = 751904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GameDataSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 751911, RefRangeEnd = 751912, XrefRangeStart = 751905, XrefRangeEnd = 751911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_registerEvent));
          GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_dropTableData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_dropTableData));
          GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666339);
          GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666340);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_registerEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_dropTableData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent>.Runtime runtime_registerEvent;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<DropTableData>.Runtime runtime_dropTableData;

          static Runtimes()
          {
            Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_registerEvent));
            GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_dropTableData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_dropTableData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterDropTableDatas_LambdaJob0/ProjectM.RunWithoutJobSystem_00000B39$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000B39$PostfixBurstDelegate");
          GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666341);
          GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666342);
          GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666343);
          GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666344);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterDropTableDatas_LambdaJob0/ProjectM.RunWithoutJobSystem_00000B39$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751912, XrefRangeEnd = 751926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751926, XrefRangeEnd = 751944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751944, XrefRangeEnd = 751959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 751986, RefRangeEnd = 751987, XrefRangeStart = 751959, XrefRangeEnd = 751986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000B39$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666345);
          GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666346);
          GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666347);
          GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666348);
          GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666350);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterDropTableDatas_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterRecipes_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RegisterRecipes_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_originalRecipeDurations;
      private static readonly System.IntPtr NativeFieldInfoPtr_recipeHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RecipeData_byref_RegisterPrefabEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass64_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, float> originalRecipeDurations;
      [FieldOffset(16)]
      public NativeHashMap<PrefabGUID, RecipeData> recipeHashLookupMap;
      [FieldOffset(32)]
      public GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(96)]
      public unsafe GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752103, XrefRangeEnd = 752109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref RecipeData recipeData,
        [In] ref RegisterPrefabEvent registerEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref recipeData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref registerEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RecipeData_byref_RegisterPrefabEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(15)]
      [CachedScanResults(RefRangeStart = 752109, RefRangeEnd = 752124, XrefRangeStart = 752109, XrefRangeEnd = 752109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GameDataSystem.__c__DisplayClass64_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(17)]
      [CachedScanResults(RefRangeStart = 752124, RefRangeEnd = 752141, XrefRangeStart = 752124, XrefRangeEnd = 752124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GameDataSystem.__c__DisplayClass64_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752141, XrefRangeEnd = 752143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 752151, RefRangeEnd = 752152, XrefRangeStart = 752143, XrefRangeEnd = 752151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 752154, RefRangeEnd = 752155, XrefRangeStart = 752152, XrefRangeEnd = 752154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GameDataSystem componentSystem,
        ref GameDataSystem.__c__DisplayClass64_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass64_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752155, XrefRangeEnd = 752159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752159, XrefRangeEnd = 752165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RegisterRecipes_LambdaJob0()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass_RegisterRecipes_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeFieldInfoPtr_originalRecipeDurations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0>.NativeClassPtr, nameof (originalRecipeDurations));
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeFieldInfoPtr_recipeHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0>.NativeClassPtr, nameof (recipeHashLookupMap));
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RecipeData_byref_RegisterPrefabEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0>.NativeClassPtr, 100666351);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0>.NativeClassPtr, 100666352);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0>.NativeClassPtr, 100666353);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0>.NativeClassPtr, 100666354);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0>.NativeClassPtr, 100666355);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass64_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0>.NativeClassPtr, 100666356);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0>.NativeClassPtr, 100666357);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0>.NativeClassPtr, 100666358);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_recipeData;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_registerEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<RecipeData> forParameter_recipeData;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent> forParameter_registerEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752020, RefRangeEnd = 752021, XrefRangeStart = 752014, XrefRangeEnd = 752020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GameDataSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752027, RefRangeEnd = 752028, XrefRangeStart = 752021, XrefRangeEnd = 752027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_recipeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_recipeData));
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_registerEvent));
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666359);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666360);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_recipeData;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_registerEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<RecipeData>.Runtime runtime_recipeData;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent>.Runtime runtime_registerEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_recipeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_recipeData));
            GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_registerEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterRecipes_LambdaJob0/ProjectM.RunWithoutJobSystem_00000B42$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000B42$PostfixBurstDelegate");
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666361);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666362);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666363);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666364);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterRecipes_LambdaJob0/ProjectM.RunWithoutJobSystem_00000B42$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752028, XrefRangeEnd = 752042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752042, XrefRangeEnd = 752060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752060, XrefRangeEnd = 752075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752102, RefRangeEnd = 752103, XrefRangeStart = 752075, XrefRangeEnd = 752102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000B42$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666365);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666366);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666367);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666368);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666370);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterRecipes_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RegisterRecipes_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_refinementstationRecipes;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_RefinementstationRecipesBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass64_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashSet<PrefabGUID> refinementstationRecipes;
      [FieldOffset(16)]
      public GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(56)]
      public unsafe GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752248, XrefRangeEnd = 752259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref DynamicBuffer<RefinementstationRecipesBuffer> rRecipes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref rRecipes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_RefinementstationRecipesBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 752259, RefRangeEnd = 752263, XrefRangeStart = 752259, XrefRangeEnd = 752259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GameDataSystem.__c__DisplayClass64_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 752263, RefRangeEnd = 752267, XrefRangeStart = 752263, XrefRangeEnd = 752263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GameDataSystem.__c__DisplayClass64_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752267, XrefRangeEnd = 752269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 752274, RefRangeEnd = 752275, XrefRangeStart = 752269, XrefRangeEnd = 752274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 752277, RefRangeEnd = 752278, XrefRangeStart = 752275, XrefRangeEnd = 752277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GameDataSystem componentSystem,
        ref GameDataSystem.__c__DisplayClass64_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass64_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752278, XrefRangeEnd = 752282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752282, XrefRangeEnd = 752288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RegisterRecipes_LambdaJob1()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass_RegisterRecipes_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeFieldInfoPtr_refinementstationRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1>.NativeClassPtr, nameof (refinementstationRecipes));
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_RefinementstationRecipesBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1>.NativeClassPtr, 100666371);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1>.NativeClassPtr, 100666372);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1>.NativeClassPtr, 100666373);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1>.NativeClassPtr, 100666374);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1>.NativeClassPtr, 100666375);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass64_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1>.NativeClassPtr, 100666376);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1>.NativeClassPtr, 100666377);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1>.NativeClassPtr, 100666378);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_rRecipes;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<RefinementstationRecipesBuffer> forParameter_rRecipes;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752168, RefRangeEnd = 752169, XrefRangeStart = 752165, XrefRangeEnd = 752168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GameDataSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752172, RefRangeEnd = 752173, XrefRangeStart = 752169, XrefRangeEnd = 752172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_rRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_rRecipes));
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100666379);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100666380);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_rRecipes;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<RefinementstationRecipesBuffer>.Runtime runtime_rRecipes;

          static Runtimes()
          {
            Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_rRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_rRecipes));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterRecipes_LambdaJob1/ProjectM.RunWithoutJobSystem_00000B4B$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000B4B$PostfixBurstDelegate");
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666381);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666382);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666383);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666384);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterRecipes_LambdaJob1/ProjectM.RunWithoutJobSystem_00000B4B$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752173, XrefRangeEnd = 752187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752187, XrefRangeEnd = 752205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752205, XrefRangeEnd = 752220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752247, RefRangeEnd = 752248, XrefRangeStart = 752220, XrefRangeEnd = 752247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000B4B$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666385);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666386);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666387);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666388);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666390);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterRecipes_LambdaJob2")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RegisterRecipes_LambdaJob2
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_workstationRecipes;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_WorkstationRecipesBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass64_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashSet<PrefabGUID> workstationRecipes;
      [FieldOffset(16)]
      public GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(56)]
      public unsafe GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752371, XrefRangeEnd = 752382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref DynamicBuffer<WorkstationRecipesBuffer> wRecipes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref wRecipes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_WorkstationRecipesBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 752382, RefRangeEnd = 752385, XrefRangeStart = 752382, XrefRangeEnd = 752382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GameDataSystem.__c__DisplayClass64_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 752385, RefRangeEnd = 752388, XrefRangeStart = 752385, XrefRangeEnd = 752385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GameDataSystem.__c__DisplayClass64_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752388, XrefRangeEnd = 752390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 752395, RefRangeEnd = 752396, XrefRangeStart = 752390, XrefRangeEnd = 752395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 752398, RefRangeEnd = 752399, XrefRangeStart = 752396, XrefRangeEnd = 752398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GameDataSystem componentSystem,
        ref GameDataSystem.__c__DisplayClass64_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass64_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752399, XrefRangeEnd = 752403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752403, XrefRangeEnd = 752409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RegisterRecipes_LambdaJob2()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass_RegisterRecipes_LambdaJob2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeFieldInfoPtr_workstationRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2>.NativeClassPtr, nameof (workstationRecipes));
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2>.NativeClassPtr, nameof (_runtimes));
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_WorkstationRecipesBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2>.NativeClassPtr, 100666391);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2>.NativeClassPtr, 100666392);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass64_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2>.NativeClassPtr, 100666393);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2>.NativeClassPtr, 100666394);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2>.NativeClassPtr, 100666395);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass64_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2>.NativeClassPtr, 100666396);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2>.NativeClassPtr, 100666397);
        GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2>.NativeClassPtr, 100666398);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_wRecipes;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<WorkstationRecipesBuffer> forParameter_wRecipes;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752291, RefRangeEnd = 752292, XrefRangeStart = 752288, XrefRangeEnd = 752291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GameDataSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752295, RefRangeEnd = 752296, XrefRangeStart = 752292, XrefRangeEnd = 752295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_wRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_wRecipes));
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100666399);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100666400);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_wRecipes;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<WorkstationRecipesBuffer>.Runtime runtime_wRecipes;

          static Runtimes()
          {
            Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_wRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_wRecipes));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterRecipes_LambdaJob2/ProjectM.RunWithoutJobSystem_00000B54$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_00000B54$PostfixBurstDelegate");
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666401);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666402);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666403);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666404);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterRecipes_LambdaJob2/ProjectM.RunWithoutJobSystem_00000B54$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752296, XrefRangeEnd = 752310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752310, XrefRangeEnd = 752328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752328, XrefRangeEnd = 752343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752370, RefRangeEnd = 752371, XrefRangeStart = 752343, XrefRangeEnd = 752370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_00000B54$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666405);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666406);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666407);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666408);
          GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666410);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterRecipes_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterCastleData_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RegisterCastleData_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_upgradeHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_UpgradeData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass65_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, UpgradeData> upgradeHashLookupMap;
      [FieldOffset(16)]
      public GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752498, XrefRangeEnd = 752501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref RegisterPrefabEvent registerEvent,
        [In] ref UpgradeData upgradeData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref upgradeData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_UpgradeData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GameDataSystem.__c__DisplayClass65_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GameDataSystem.__c__DisplayClass65_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752501, XrefRangeEnd = 752503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 752511, RefRangeEnd = 752512, XrefRangeStart = 752503, XrefRangeEnd = 752511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 752514, RefRangeEnd = 752515, XrefRangeStart = 752512, XrefRangeEnd = 752514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GameDataSystem componentSystem,
        ref GameDataSystem.__c__DisplayClass65_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass65_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752515, XrefRangeEnd = 752519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752519, XrefRangeEnd = 752525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RegisterCastleData_LambdaJob0()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass_RegisterCastleData_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeFieldInfoPtr_upgradeHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0>.NativeClassPtr, nameof (upgradeHashLookupMap));
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_UpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0>.NativeClassPtr, 100666411);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0>.NativeClassPtr, 100666412);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0>.NativeClassPtr, 100666413);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0>.NativeClassPtr, 100666414);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0>.NativeClassPtr, 100666415);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass65_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0>.NativeClassPtr, 100666416);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0>.NativeClassPtr, 100666417);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0>.NativeClassPtr, 100666418);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_registerEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_upgradeData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent> forParameter_registerEvent;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<UpgradeData> forParameter_upgradeData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752415, RefRangeEnd = 752416, XrefRangeStart = 752409, XrefRangeEnd = 752415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GameDataSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752422, RefRangeEnd = 752423, XrefRangeStart = 752416, XrefRangeEnd = 752422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_registerEvent));
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_upgradeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_upgradeData));
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666419);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666420);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_registerEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_upgradeData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent>.Runtime runtime_registerEvent;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<UpgradeData>.Runtime runtime_upgradeData;

          static Runtimes()
          {
            Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_registerEvent));
            GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_upgradeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_upgradeData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterCastleData_LambdaJob0/ProjectM.RunWithoutJobSystem_00000B5D$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000B5D$PostfixBurstDelegate");
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666421);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666422);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666423);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666424);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterCastleData_LambdaJob0/ProjectM.RunWithoutJobSystem_00000B5D$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752423, XrefRangeEnd = 752437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752437, XrefRangeEnd = 752455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752455, XrefRangeEnd = 752470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752497, RefRangeEnd = 752498, XrefRangeStart = 752470, XrefRangeEnd = 752497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000B5D$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666425);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666426);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666427);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666428);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666430);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterCastleData_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RegisterCastleData_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_castleRaidHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_CastleRaidData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass65_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, CastleRaidData> castleRaidHashLookupMap;
      [FieldOffset(16)]
      public GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752614, XrefRangeEnd = 752617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref RegisterPrefabEvent registerEvent,
        [In] ref CastleRaidData upgradeData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref upgradeData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_CastleRaidData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 752617, RefRangeEnd = 752621, XrefRangeStart = 752617, XrefRangeEnd = 752617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GameDataSystem.__c__DisplayClass65_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 752621, RefRangeEnd = 752625, XrefRangeStart = 752621, XrefRangeEnd = 752621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GameDataSystem.__c__DisplayClass65_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752625, XrefRangeEnd = 752627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 752635, RefRangeEnd = 752636, XrefRangeStart = 752627, XrefRangeEnd = 752635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 752638, RefRangeEnd = 752639, XrefRangeStart = 752636, XrefRangeEnd = 752638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GameDataSystem componentSystem,
        ref GameDataSystem.__c__DisplayClass65_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass65_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752639, XrefRangeEnd = 752643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752643, XrefRangeEnd = 752649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RegisterCastleData_LambdaJob1()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass_RegisterCastleData_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeFieldInfoPtr_castleRaidHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1>.NativeClassPtr, nameof (castleRaidHashLookupMap));
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_CastleRaidData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1>.NativeClassPtr, 100666431);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1>.NativeClassPtr, 100666432);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1>.NativeClassPtr, 100666433);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1>.NativeClassPtr, 100666434);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1>.NativeClassPtr, 100666435);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass65_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1>.NativeClassPtr, 100666436);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1>.NativeClassPtr, 100666437);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1>.NativeClassPtr, 100666438);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_registerEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_upgradeData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent> forParameter_registerEvent;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<CastleRaidData> forParameter_upgradeData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752531, RefRangeEnd = 752532, XrefRangeStart = 752525, XrefRangeEnd = 752531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GameDataSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752538, RefRangeEnd = 752539, XrefRangeStart = 752532, XrefRangeEnd = 752538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_registerEvent));
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_upgradeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_upgradeData));
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100666439);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100666440);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_registerEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_upgradeData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent>.Runtime runtime_registerEvent;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<CastleRaidData>.Runtime runtime_upgradeData;

          static Runtimes()
          {
            Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_registerEvent));
            GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_upgradeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_upgradeData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterCastleData_LambdaJob1/ProjectM.RunWithoutJobSystem_00000B66$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000B66$PostfixBurstDelegate");
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666441);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666442);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666443);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666444);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterCastleData_LambdaJob1/ProjectM.RunWithoutJobSystem_00000B66$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752539, XrefRangeEnd = 752553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752553, XrefRangeEnd = 752571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752571, XrefRangeEnd = 752586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752613, RefRangeEnd = 752614, XrefRangeStart = 752586, XrefRangeEnd = 752613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000B66$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666445);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666446);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666447);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666448);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666450);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterCastleData_LambdaJob2")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RegisterCastleData_LambdaJob2
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_castleClaimHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_CastleClaimData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass65_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, CastleClaimData> castleClaimHashLookupMap;
      [FieldOffset(16)]
      public GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752738, XrefRangeEnd = 752741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref RegisterPrefabEvent registerEvent,
        [In] ref CastleClaimData upgradeData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref upgradeData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_CastleClaimData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 752259, RefRangeEnd = 752263, XrefRangeStart = 752259, XrefRangeEnd = 752263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GameDataSystem.__c__DisplayClass65_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 752263, RefRangeEnd = 752267, XrefRangeStart = 752263, XrefRangeEnd = 752267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GameDataSystem.__c__DisplayClass65_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752741, XrefRangeEnd = 752743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 752751, RefRangeEnd = 752752, XrefRangeStart = 752743, XrefRangeEnd = 752751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 752754, RefRangeEnd = 752755, XrefRangeStart = 752752, XrefRangeEnd = 752754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GameDataSystem componentSystem,
        ref GameDataSystem.__c__DisplayClass65_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass65_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752755, XrefRangeEnd = 752759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752759, XrefRangeEnd = 752765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RegisterCastleData_LambdaJob2()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass_RegisterCastleData_LambdaJob2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeFieldInfoPtr_castleClaimHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2>.NativeClassPtr, nameof (castleClaimHashLookupMap));
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2>.NativeClassPtr, nameof (_runtimes));
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_CastleClaimData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2>.NativeClassPtr, 100666451);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2>.NativeClassPtr, 100666452);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2>.NativeClassPtr, 100666453);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2>.NativeClassPtr, 100666454);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2>.NativeClassPtr, 100666455);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass65_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2>.NativeClassPtr, 100666456);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2>.NativeClassPtr, 100666457);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2>.NativeClassPtr, 100666458);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_registerEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_upgradeData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent> forParameter_registerEvent;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<CastleClaimData> forParameter_upgradeData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752655, RefRangeEnd = 752656, XrefRangeStart = 752649, XrefRangeEnd = 752655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GameDataSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752662, RefRangeEnd = 752663, XrefRangeStart = 752656, XrefRangeEnd = 752662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_registerEvent));
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_upgradeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_upgradeData));
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100666459);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100666460);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_registerEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_upgradeData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent>.Runtime runtime_registerEvent;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<CastleClaimData>.Runtime runtime_upgradeData;

          static Runtimes()
          {
            Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_registerEvent));
            GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_upgradeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_upgradeData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterCastleData_LambdaJob2/ProjectM.RunWithoutJobSystem_00000B6F$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_00000B6F$PostfixBurstDelegate");
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666461);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666462);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666463);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666464);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterCastleData_LambdaJob2/ProjectM.RunWithoutJobSystem_00000B6F$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752663, XrefRangeEnd = 752677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752677, XrefRangeEnd = 752695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752695, XrefRangeEnd = 752710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752737, RefRangeEnd = 752738, XrefRangeStart = 752710, XrefRangeEnd = 752737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_00000B6F$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666465);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666466);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666467);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666468);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666470);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterCastleData_LambdaJob3")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RegisterCastleData_LambdaJob3
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_castleDestroyHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_CastleDestroyData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass65_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, CastleDestroyData> castleDestroyHashLookupMap;
      [FieldOffset(16)]
      public GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752854, XrefRangeEnd = 752857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref RegisterPrefabEvent registerEvent,
        [In] ref CastleDestroyData upgradeData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref upgradeData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_CastleDestroyData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 752382, RefRangeEnd = 752385, XrefRangeStart = 752382, XrefRangeEnd = 752385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GameDataSystem.__c__DisplayClass65_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 752385, RefRangeEnd = 752388, XrefRangeStart = 752385, XrefRangeEnd = 752388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GameDataSystem.__c__DisplayClass65_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752857, XrefRangeEnd = 752859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 752867, RefRangeEnd = 752868, XrefRangeStart = 752859, XrefRangeEnd = 752867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 752870, RefRangeEnd = 752871, XrefRangeStart = 752868, XrefRangeEnd = 752870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GameDataSystem componentSystem,
        ref GameDataSystem.__c__DisplayClass65_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass65_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752871, XrefRangeEnd = 752875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752875, XrefRangeEnd = 752881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RegisterCastleData_LambdaJob3()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass_RegisterCastleData_LambdaJob3");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeFieldInfoPtr_castleDestroyHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3>.NativeClassPtr, nameof (castleDestroyHashLookupMap));
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3>.NativeClassPtr, nameof (_runtimes));
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_CastleDestroyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3>.NativeClassPtr, 100666471);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3>.NativeClassPtr, 100666472);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass65_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3>.NativeClassPtr, 100666473);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3>.NativeClassPtr, 100666474);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3>.NativeClassPtr, 100666475);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass65_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3>.NativeClassPtr, 100666476);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3>.NativeClassPtr, 100666477);
        GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3>.NativeClassPtr, 100666478);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_registerEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_upgradeData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent> forParameter_registerEvent;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<CastleDestroyData> forParameter_upgradeData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752771, RefRangeEnd = 752772, XrefRangeStart = 752765, XrefRangeEnd = 752771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GameDataSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752778, RefRangeEnd = 752779, XrefRangeStart = 752772, XrefRangeEnd = 752778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_registerEvent));
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_upgradeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_upgradeData));
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, 100666479);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, 100666480);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_registerEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_upgradeData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent>.Runtime runtime_registerEvent;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<CastleDestroyData>.Runtime runtime_upgradeData;

          static Runtimes()
          {
            Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_registerEvent));
            GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_upgradeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_upgradeData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterCastleData_LambdaJob3/ProjectM.RunWithoutJobSystem_00000B78$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3>.NativeClassPtr, "RunWithoutJobSystem_00000B78$PostfixBurstDelegate");
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666481);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666482);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666483);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666484);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterCastleData_LambdaJob3/ProjectM.RunWithoutJobSystem_00000B78$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752779, XrefRangeEnd = 752793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752793, XrefRangeEnd = 752811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752811, XrefRangeEnd = 752826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752853, RefRangeEnd = 752854, XrefRangeStart = 752826, XrefRangeEnd = 752853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3>.NativeClassPtr, "RunWithoutJobSystem_00000B78$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666485);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666486);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666487);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666488);
          GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666490);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterCastleData_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterBlueprints_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RegisterBlueprints_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_dismantleResourceModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_blueprintHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BlueprintData_byref_RegisterPrefabEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass66_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass66_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass66_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public float dismantleResourceModifier;
      [FieldOffset(8)]
      public NativeHashMap<PrefabGUID, BlueprintData> blueprintHashLookupMap;
      [FieldOffset(24)]
      public GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752970, XrefRangeEnd = 752973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref BlueprintData blueprintData,
        [In] ref RegisterPrefabEvent registerEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref blueprintData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref registerEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BlueprintData_byref_RegisterPrefabEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 752973, RefRangeEnd = 752979, XrefRangeStart = 752973, XrefRangeEnd = 752973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GameDataSystem.__c__DisplayClass66_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass66_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 752979, RefRangeEnd = 752985, XrefRangeStart = 752979, XrefRangeEnd = 752979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GameDataSystem.__c__DisplayClass66_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass66_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752985, XrefRangeEnd = 752987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 752995, RefRangeEnd = 752996, XrefRangeStart = 752987, XrefRangeEnd = 752995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 752998, RefRangeEnd = 752999, XrefRangeStart = 752996, XrefRangeEnd = 752998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GameDataSystem componentSystem,
        ref GameDataSystem.__c__DisplayClass66_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass66_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752999, XrefRangeEnd = 753003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753003, XrefRangeEnd = 753009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RegisterBlueprints_LambdaJob0()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass_RegisterBlueprints_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeFieldInfoPtr_dismantleResourceModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0>.NativeClassPtr, nameof (dismantleResourceModifier));
        GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeFieldInfoPtr_blueprintHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0>.NativeClassPtr, nameof (blueprintHashLookupMap));
        GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_BlueprintData_byref_RegisterPrefabEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0>.NativeClassPtr, 100666491);
        GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass66_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0>.NativeClassPtr, 100666492);
        GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass66_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0>.NativeClassPtr, 100666493);
        GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0>.NativeClassPtr, 100666494);
        GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0>.NativeClassPtr, 100666495);
        GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass66_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0>.NativeClassPtr, 100666496);
        GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0>.NativeClassPtr, 100666497);
        GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0>.NativeClassPtr, 100666498);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_blueprintData;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_registerEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<BlueprintData> forParameter_blueprintData;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent> forParameter_registerEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752887, RefRangeEnd = 752888, XrefRangeStart = 752881, XrefRangeEnd = 752887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GameDataSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752894, RefRangeEnd = 752895, XrefRangeStart = 752888, XrefRangeEnd = 752894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_blueprintData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_blueprintData));
          GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_registerEvent));
          GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666499);
          GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666500);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_blueprintData;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_registerEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<BlueprintData>.Runtime runtime_blueprintData;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent>.Runtime runtime_registerEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_blueprintData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_blueprintData));
            GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_registerEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterBlueprints_LambdaJob0/ProjectM.RunWithoutJobSystem_00000B81$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000B81$PostfixBurstDelegate");
          GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666501);
          GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666502);
          GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666503);
          GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666504);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterBlueprints_LambdaJob0/ProjectM.RunWithoutJobSystem_00000B81$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752895, XrefRangeEnd = 752909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752909, XrefRangeEnd = 752927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752927, XrefRangeEnd = 752942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 752969, RefRangeEnd = 752970, XrefRangeStart = 752942, XrefRangeEnd = 752969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000B81$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666505);
          GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666506);
          GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666507);
          GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666508);
          GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666510);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterBlueprints_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterStationBonuses_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RegisterStationBonuses_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_stationBonusHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_StationBonusData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass67_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass67_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass67_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, StationBonusData> stationBonusHashLookupMap;
      [FieldOffset(16)]
      public GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753098, XrefRangeEnd = 753101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref RegisterPrefabEvent registerEvent,
        [In] ref StationBonusData stationBonusData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref stationBonusData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_StationBonusData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GameDataSystem.__c__DisplayClass67_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass67_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GameDataSystem.__c__DisplayClass67_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass67_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753101, XrefRangeEnd = 753103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 753111, RefRangeEnd = 753112, XrefRangeStart = 753103, XrefRangeEnd = 753111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 753114, RefRangeEnd = 753115, XrefRangeStart = 753112, XrefRangeEnd = 753114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GameDataSystem componentSystem,
        ref GameDataSystem.__c__DisplayClass67_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass67_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753115, XrefRangeEnd = 753119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753119, XrefRangeEnd = 753125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RegisterStationBonuses_LambdaJob0()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass_RegisterStationBonuses_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeFieldInfoPtr_stationBonusHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0>.NativeClassPtr, nameof (stationBonusHashLookupMap));
        GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_StationBonusData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0>.NativeClassPtr, 100666511);
        GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass67_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0>.NativeClassPtr, 100666512);
        GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass67_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0>.NativeClassPtr, 100666513);
        GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0>.NativeClassPtr, 100666514);
        GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0>.NativeClassPtr, 100666515);
        GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass67_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0>.NativeClassPtr, 100666516);
        GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0>.NativeClassPtr, 100666517);
        GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0>.NativeClassPtr, 100666518);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_registerEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_stationBonusData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent> forParameter_registerEvent;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<StationBonusData> forParameter_stationBonusData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 753015, RefRangeEnd = 753016, XrefRangeStart = 753009, XrefRangeEnd = 753015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GameDataSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 753022, RefRangeEnd = 753023, XrefRangeStart = 753016, XrefRangeEnd = 753022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_registerEvent));
          GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_stationBonusData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_stationBonusData));
          GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666519);
          GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666520);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_registerEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_stationBonusData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent>.Runtime runtime_registerEvent;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<StationBonusData>.Runtime runtime_stationBonusData;

          static Runtimes()
          {
            Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_registerEvent));
            GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_stationBonusData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_stationBonusData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterStationBonuses_LambdaJob0/ProjectM.RunWithoutJobSystem_00000B8A$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000B8A$PostfixBurstDelegate");
          GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666521);
          GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666522);
          GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666523);
          GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666524);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterStationBonuses_LambdaJob0/ProjectM.RunWithoutJobSystem_00000B8A$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753023, XrefRangeEnd = 753037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753037, XrefRangeEnd = 753055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753055, XrefRangeEnd = 753070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 753097, RefRangeEnd = 753098, XrefRangeStart = 753070, XrefRangeEnd = 753097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000B8A$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666525);
          GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666526);
          GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666527);
          GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666528);
          GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666530);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterStationBonuses_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterRepairstationData_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RegisterRepairstationData_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_repairstationDataHashLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_RepairstationData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass68_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass68_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass68_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, RepairstationData> repairstationDataHashLookupMap;
      [FieldOffset(16)]
      public GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753214, XrefRangeEnd = 753217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref RegisterPrefabEvent registerEvent,
        [In] ref RepairstationData repairstationData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref registerEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref repairstationData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_RepairstationData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GameDataSystem.__c__DisplayClass68_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass68_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GameDataSystem.__c__DisplayClass68_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass68_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753217, XrefRangeEnd = 753219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 753227, RefRangeEnd = 753228, XrefRangeStart = 753219, XrefRangeEnd = 753227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 753230, RefRangeEnd = 753231, XrefRangeStart = 753228, XrefRangeEnd = 753230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GameDataSystem componentSystem,
        ref GameDataSystem.__c__DisplayClass68_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass68_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753231, XrefRangeEnd = 753235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753235, XrefRangeEnd = 753241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RegisterRepairstationData_LambdaJob0()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass_RegisterRepairstationData_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeFieldInfoPtr_repairstationDataHashLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0>.NativeClassPtr, nameof (repairstationDataHashLookupMap));
        GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefabEvent_byref_RepairstationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0>.NativeClassPtr, 100666531);
        GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass68_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0>.NativeClassPtr, 100666532);
        GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass68_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0>.NativeClassPtr, 100666533);
        GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0>.NativeClassPtr, 100666534);
        GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0>.NativeClassPtr, 100666535);
        GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass68_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0>.NativeClassPtr, 100666536);
        GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0>.NativeClassPtr, 100666537);
        GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0>.NativeClassPtr, 100666538);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_registerEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_repairstationData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent> forParameter_registerEvent;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<RepairstationData> forParameter_repairstationData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 753131, RefRangeEnd = 753132, XrefRangeStart = 753125, XrefRangeEnd = 753131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GameDataSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 753138, RefRangeEnd = 753139, XrefRangeStart = 753132, XrefRangeEnd = 753138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_registerEvent));
          GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_repairstationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_repairstationData));
          GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666539);
          GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666540);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_registerEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_repairstationData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<RegisterPrefabEvent>.Runtime runtime_registerEvent;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<RepairstationData>.Runtime runtime_repairstationData;

          static Runtimes()
          {
            Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_registerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_registerEvent));
            GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_repairstationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_repairstationData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterRepairstationData_LambdaJob0/ProjectM.RunWithoutJobSystem_00000B93$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000B93$PostfixBurstDelegate");
          GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666541);
          GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666542);
          GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666543);
          GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666544);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterRepairstationData_LambdaJob0/ProjectM.RunWithoutJobSystem_00000B93$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753139, XrefRangeEnd = 753153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753153, XrefRangeEnd = 753171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753171, XrefRangeEnd = 753186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 753213, RefRangeEnd = 753214, XrefRangeStart = 753186, XrefRangeEnd = 753213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000B93$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666545);
          GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666546);
          GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666547);
          GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666548);
          GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666550);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterRepairstationData_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterRoofCategories_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RegisterRoofCategories_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_lookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_RoofCategory_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefab_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass69_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass69_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass69_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<int, Entity> lookupMap;
      [FieldOffset(16)]
      public ComponentDataFromEntity<RoofCategory> _ComponentDataFromEntity_RoofCategory_0;
      [FieldOffset(48)]
      public GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753324, XrefRangeEnd = 753333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref RegisterPrefab registerPrefab)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref registerPrefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefab_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(34)]
      [CachedScanResults(RefRangeStart = 723251, RefRangeEnd = 723285, XrefRangeStart = 723251, XrefRangeEnd = 723285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref GameDataSystem.__c__DisplayClass69_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass69_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(34)]
      [CachedScanResults(RefRangeStart = 723285, RefRangeEnd = 723319, XrefRangeStart = 723285, XrefRangeEnd = 723319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref GameDataSystem.__c__DisplayClass69_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass69_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753333, XrefRangeEnd = 753335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 753340, RefRangeEnd = 753341, XrefRangeStart = 753335, XrefRangeEnd = 753340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 753346, RefRangeEnd = 753347, XrefRangeStart = 753341, XrefRangeEnd = 753346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        GameDataSystem componentSystem,
        ref GameDataSystem.__c__DisplayClass69_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass69_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753347, XrefRangeEnd = 753351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753351, XrefRangeEnd = 753357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RegisterRoofCategories_LambdaJob0()
      {
        Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem>.NativeClassPtr, "<>c__DisplayClass_RegisterRoofCategories_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0>.NativeClassPtr);
        GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeFieldInfoPtr_lookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0>.NativeClassPtr, nameof (lookupMap));
        GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_RoofCategory_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_RoofCategory_0));
        GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0>.NativeClassPtr, 100666551);
        GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass69_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0>.NativeClassPtr, 100666552);
        GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass69_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0>.NativeClassPtr, 100666553);
        GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0>.NativeClassPtr, 100666554);
        GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0>.NativeClassPtr, 100666555);
        GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_byref___c__DisplayClass69_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0>.NativeClassPtr, 100666556);
        GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0>.NativeClassPtr, 100666557);
        GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0>.NativeClassPtr, 100666558);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_registerPrefab;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<RegisterPrefab> forParameter_registerPrefab;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 753244, RefRangeEnd = 753245, XrefRangeStart = 753241, XrefRangeEnd = 753244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(GameDataSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 753248, RefRangeEnd = 753249, XrefRangeStart = 753245, XrefRangeEnd = 753248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_registerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_registerPrefab));
          GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666559);
          GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100666560);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_registerPrefab;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<RegisterPrefab>.Runtime runtime_registerPrefab;

          static Runtimes()
          {
            Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_registerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_registerPrefab));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterRoofCategories_LambdaJob0/ProjectM.RunWithoutJobSystem_00000B9C$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000B9C$PostfixBurstDelegate");
          GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666561);
          GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666562);
          GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666563);
          GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100666564);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.GameDataSystem/ProjectM.<>c__DisplayClass_RegisterRoofCategories_LambdaJob0/ProjectM.RunWithoutJobSystem_00000B9C$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753249, XrefRangeEnd = 753263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753263, XrefRangeEnd = 753281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753281, XrefRangeEnd = 753296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 753323, RefRangeEnd = 753324, XrefRangeStart = 753296, XrefRangeEnd = 753323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000B9C$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666565);
          GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666566);
          GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666567);
          GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666568);
          GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100666570);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(GameDataSystem.__c__DisplayClass_RegisterRoofCategories_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
