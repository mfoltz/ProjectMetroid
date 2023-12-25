// Decompiled with JetBrains decompiler
// Type: ProjectM.JewelSpawnSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using ProjectM.Shared;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class JewelSpawnSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpellModSyncSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpellModTierSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurveCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__JewelSpellModSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__LegendaryItemSpellModSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__LegendaryItemStatModSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_JewelSpawnSystemData;
    private static readonly System.IntPtr NativeFieldInfoPtr__NamePrefixIndexCounters;
    private static readonly System.IntPtr NativeFieldInfoPtr__NamePostfixIndexCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr__HasRunConvertOnDemand;
    private static readonly System.IntPtr NativeFieldInfoPtr_MIN_JEWELITEMLEVEL;
    private static readonly System.IntPtr NativeFieldInfoPtr__JewelSpawnQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__LegendaryItemSpawnQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ShouldRunSystemQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob2_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob2_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___BuildJewelByUnitLevelMapping_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___BuildJewelByUnitLevelMapping_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___BuildJewelByUnitLevelMapping_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___BuildJewelByUnitLevelMapping_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_JewelItemPrefab_Public_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PersistentIdentifier_Public_Virtual_Final_New_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryCreateJewel_Public_Boolean_Entity_Int32_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetJewelTier_Public_Static_Boolean_BlobAssetReference_1_SpellModSetGlobalTierData_CurveCollection_Int32_byref_Random_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetWeaponTypeForItemLevel_Public_Static_Boolean_BlobAssetReference_1_SpellModSetGlobalTierData_Int32_byref_Random_byref_WeaponType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetRandomJewelAbility_Public_Static_Boolean_JewelSpawnSystemData_Int32_byref_Random_byref_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetRandomJewelAbilityFromSchool_Public_Boolean_PrefabGUID_Int32_byref_Random_byref_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetJewelPrefabGUID_Public_Static_Boolean_JewelSpawnSystemData_BlobAssetReference_1_SpellModSetGlobalTierData_CurveCollection_Int32_byref_Random_byref_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetLegendaryItemPrefabGUID_Public_Static_Boolean_JewelSpawnSystemData_BlobAssetReference_1_SpellModSetGlobalTierData_CurveCollection_Int32_byref_Random_byref_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetJewelPrefabGUIDFromAbility_Public_Static_Boolean_JewelSpawnSystemData_PrefabGUID_Int32_byref_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetLegendaryWeaponPrefabGUIDFromTierAndWeaponType_Public_Static_Boolean_JewelSpawnSystemData_Int32_WeaponType_byref_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetJewelPrefabGUIDFromSpellSchool_Public_Static_Boolean_JewelSpawnSystemData_PrefabGUID_Int32_byref_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryCreateJewelAndAddToInventory_Public_Boolean_Entity_PrefabGUID_Int32_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryInitializeJewelData_Public_Boolean_Entity_byref_Random_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryInitializeJewelData_Public_Boolean_Int32_Entity_byref_Random_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryInitializeJewelData_Public_Boolean_PrefabGUID_Int32_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryInitializeLegendaryItemData_Public_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateName_Private_Void_byref_GeneratedName_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PostfixHash_Private_Byte_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrefixHash_Private_Byte_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryConvertOnDemand_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindAndSetJewelItem_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildSpellSchoolSets_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildJewelByUnitLevelMapping_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForBuildSpellSchoolSets_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForBuildSpellSchoolSets_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForBuildSpellSchoolSets_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForBuildJewelByUnitLevelMapping_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForBuildJewelByUnitLevelMapping_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_3;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_4;

    public unsafe PrefabGUID JewelItemPrefab
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_get_JewelItemPrefab_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public virtual unsafe string PersistentIdentifier
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037430, XrefRangeEnd = 1037432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_get_PersistentIdentifier_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037432, XrefRangeEnd = 1037536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), JewelSpawnSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037536, XrefRangeEnd = 1037540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), JewelSpawnSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037540, XrefRangeEnd = 1037570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), JewelSpawnSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037570, XrefRangeEnd = 1037580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037580, XrefRangeEnd = 1037587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1037624, RefRangeEnd = 1037625, XrefRangeStart = 1037587, XrefRangeEnd = 1037624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryCreateJewel(
      Entity inventoryTarget,
      int unitLevel,
      out Entity jewelEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &inventoryTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &unitLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref jewelEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_TryCreateJewel_Public_Boolean_Entity_Int32_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1037654, RefRangeEnd = 1037657, XrefRangeStart = 1037625, XrefRangeEnd = 1037654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetJewelTier(
      BlobAssetReference<SpellModSetGlobalTierData> spellModTierSettings,
      CurveCollection curveCollection,
      int itemLevel,
      ref Unity.Mathematics.Random random,
      out int jewelTier)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &spellModTierSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &curveCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref jewelTier;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_TryGetJewelTier_Public_Static_Boolean_BlobAssetReference_1_SpellModSetGlobalTierData_CurveCollection_Int32_byref_Random_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037657, XrefRangeEnd = 1037678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetWeaponTypeForItemLevel(
      BlobAssetReference<SpellModSetGlobalTierData> spellModTierSettings,
      int itemLevel,
      ref Unity.Mathematics.Random random,
      out WeaponType weaponType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &spellModTierSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref weaponType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_TryGetWeaponTypeForItemLevel_Public_Static_Boolean_BlobAssetReference_1_SpellModSetGlobalTierData_Int32_byref_Random_byref_WeaponType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1037704, RefRangeEnd = 1037705, XrefRangeStart = 1037678, XrefRangeEnd = 1037704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetRandomJewelAbility(
      JewelSpawnSystemData jewelSpawnData,
      int itemLevel,
      ref Unity.Mathematics.Random random,
      out PrefabGUID ability)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &jewelSpawnData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref ability;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_TryGetRandomJewelAbility_Public_Static_Boolean_JewelSpawnSystemData_Int32_byref_Random_byref_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1037745, RefRangeEnd = 1037746, XrefRangeStart = 1037705, XrefRangeEnd = 1037745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetRandomJewelAbilityFromSchool(
      PrefabGUID spellSchool,
      int itemLevel,
      ref Unity.Mathematics.Random random,
      out PrefabGUID ability)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &spellSchool;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref ability;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_TryGetRandomJewelAbilityFromSchool_Public_Boolean_PrefabGUID_Int32_byref_Random_byref_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1037757, RefRangeEnd = 1037759, XrefRangeStart = 1037746, XrefRangeEnd = 1037757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetJewelPrefabGUID(
      JewelSpawnSystemData jewelSpawnData,
      BlobAssetReference<SpellModSetGlobalTierData> spellModTierSettings,
      CurveCollection curveCollection,
      int itemLevel,
      ref Unity.Mathematics.Random random,
      out PrefabGUID jewelPrefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &jewelSpawnData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &spellModTierSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &curveCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &itemLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref jewelPrefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_TryGetJewelPrefabGUID_Public_Static_Boolean_JewelSpawnSystemData_BlobAssetReference_1_SpellModSetGlobalTierData_CurveCollection_Int32_byref_Random_byref_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1037798, RefRangeEnd = 1037800, XrefRangeStart = 1037759, XrefRangeEnd = 1037798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetLegendaryItemPrefabGUID(
      JewelSpawnSystemData jewelSpawnData,
      BlobAssetReference<SpellModSetGlobalTierData> spellModTierSettings,
      CurveCollection curveCollection,
      int itemLevel,
      ref Unity.Mathematics.Random random,
      out PrefabGUID prefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &jewelSpawnData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &spellModTierSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &curveCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &itemLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_TryGetLegendaryItemPrefabGUID_Public_Static_Boolean_JewelSpawnSystemData_BlobAssetReference_1_SpellModSetGlobalTierData_CurveCollection_Int32_byref_Random_byref_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1037816, RefRangeEnd = 1037819, XrefRangeStart = 1037800, XrefRangeEnd = 1037816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetJewelPrefabGUIDFromAbility(
      JewelSpawnSystemData jewelSpawnData,
      PrefabGUID ability,
      int jewelTier,
      out PrefabGUID jewelPrefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &jewelSpawnData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ability;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &jewelTier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jewelPrefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_TryGetJewelPrefabGUIDFromAbility_Public_Static_Boolean_JewelSpawnSystemData_PrefabGUID_Int32_byref_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037819, XrefRangeEnd = 1037829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetLegendaryWeaponPrefabGUIDFromTierAndWeaponType(
      JewelSpawnSystemData jewelSpawnData,
      int tier,
      WeaponType weaponType,
      out PrefabGUID prefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &jewelSpawnData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &weaponType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_TryGetLegendaryWeaponPrefabGUIDFromTierAndWeaponType_Public_Static_Boolean_JewelSpawnSystemData_Int32_WeaponType_byref_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037829, XrefRangeEnd = 1037836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetJewelPrefabGUIDFromSpellSchool(
      JewelSpawnSystemData jewelSpawnData,
      PrefabGUID spellSchool,
      int jewelTier,
      out PrefabGUID jewelPrefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &jewelSpawnData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &spellSchool;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &jewelTier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jewelPrefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_TryGetJewelPrefabGUIDFromSpellSchool_Public_Static_Boolean_JewelSpawnSystemData_PrefabGUID_Int32_byref_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1037858, RefRangeEnd = 1037860, XrefRangeStart = 1037836, XrefRangeEnd = 1037858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryCreateJewelAndAddToInventory(
      Entity inventoryTarget,
      PrefabGUID abilityGuid,
      int jewelTier,
      out Entity jewelEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &inventoryTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &jewelTier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref jewelEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_TryCreateJewelAndAddToInventory_Public_Boolean_Entity_PrefabGUID_Int32_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037860, XrefRangeEnd = 1037870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryInitializeJewelData(Entity jewelEntity, ref Unity.Mathematics.Random random)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &jewelEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_TryInitializeJewelData_Public_Boolean_Entity_byref_Random_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1037889, RefRangeEnd = 1037891, XrefRangeStart = 1037870, XrefRangeEnd = 1037889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryInitializeJewelData(int itemLevel, Entity jewelEntity, ref Unity.Mathematics.Random random)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &itemLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &jewelEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref random;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_TryInitializeJewelData_Public_Boolean_Int32_Entity_byref_Random_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1037940, RefRangeEnd = 1037942, XrefRangeStart = 1037891, XrefRangeEnd = 1037940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryInitializeJewelData(
      PrefabGUID abilityGuid,
      int jewelTier,
      Entity jewelEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &abilityGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &jewelTier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &jewelEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_TryInitializeJewelData_Public_Boolean_PrefabGUID_Int32_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1038004, RefRangeEnd = 1038006, XrefRangeStart = 1037942, XrefRangeEnd = 1038004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryInitializeLegendaryItemData(Entity itemEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &itemEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_TryInitializeLegendaryItemData_Public_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1038027, RefRangeEnd = 1038029, XrefRangeStart = 1038006, XrefRangeEnd = 1038027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GenerateName(ref GeneratedName generatedName, int globalPostFixLength = 0)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref generatedName;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &globalPostFixLength;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_GenerateName_Private_Void_byref_GeneratedName_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe byte PostfixHash(int counter, int spellSchoolPostFixes, int globalPostFixes)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &counter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &spellSchoolPostFixes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &globalPostFixes;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_PostfixHash_Private_Byte_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(byte*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe byte PrefixHash(int counter, int prefixes)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &counter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefixes;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_PrefixHash_Private_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(byte*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(25)]
    [CachedScanResults(RefRangeStart = 29168, RefRangeEnd = 29193, XrefRangeStart = 29168, XrefRangeEnd = 29193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryConvertOnDemand()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_TryConvertOnDemand_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1038080, RefRangeEnd = 1038081, XrefRangeStart = 1038029, XrefRangeEnd = 1038080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool FindAndSetJewelItem()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_FindAndSetJewelItem_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1038146, RefRangeEnd = 1038147, XrefRangeStart = 1038081, XrefRangeEnd = 1038146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BuildSpellSchoolSets()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_BuildSpellSchoolSets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1038196, RefRangeEnd = 1038199, XrefRangeStart = 1038147, XrefRangeEnd = 1038196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BuildJewelByUnitLevelMapping()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_BuildJewelByUnitLevelMapping_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe JewelSpawnSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038199, XrefRangeEnd = 1038284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), JewelSpawnSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1038306, RefRangeEnd = 1038307, XrefRangeStart = 1038284, XrefRangeEnd = 1038306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForBuildSpellSchoolSets_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr___GetEntityQuery_ForBuildSpellSchoolSets_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1038335, RefRangeEnd = 1038336, XrefRangeStart = 1038307, XrefRangeEnd = 1038335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForBuildSpellSchoolSets_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr___GetEntityQuery_ForBuildSpellSchoolSets_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1038370, RefRangeEnd = 1038371, XrefRangeStart = 1038336, XrefRangeEnd = 1038370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForBuildSpellSchoolSets_LambdaJob2_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr___GetEntityQuery_ForBuildSpellSchoolSets_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1038393, RefRangeEnd = 1038394, XrefRangeStart = 1038371, XrefRangeEnd = 1038393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForBuildJewelByUnitLevelMapping_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr___GetEntityQuery_ForBuildJewelByUnitLevelMapping_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1038416, RefRangeEnd = 1038417, XrefRangeStart = 1038394, XrefRangeEnd = 1038416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForBuildJewelByUnitLevelMapping_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr___GetEntityQuery_ForBuildJewelByUnitLevelMapping_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1038421, RefRangeEnd = 1038422, XrefRangeStart = 1038417, XrefRangeEnd = 1038421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1038426, RefRangeEnd = 1038427, XrefRangeStart = 1038422, XrefRangeEnd = 1038426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1038431, RefRangeEnd = 1038432, XrefRangeStart = 1038427, XrefRangeEnd = 1038431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1038436, RefRangeEnd = 1038437, XrefRangeStart = 1038432, XrefRangeEnd = 1038436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1038441, RefRangeEnd = 1038442, XrefRangeStart = 1038437, XrefRangeEnd = 1038441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_4()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.NativeMethodInfoPtr_Method_Public_Static_Void_4, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static JewelSpawnSystem()
    {
      Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (JewelSpawnSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr);
      JewelSpawnSystem.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, nameof (_GameDataSystem));
      JewelSpawnSystem.NativeFieldInfoPtr__PrefabCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, nameof (_PrefabCollection));
      JewelSpawnSystem.NativeFieldInfoPtr__SpellModSyncSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, nameof (_SpellModSyncSystem));
      JewelSpawnSystem.NativeFieldInfoPtr__SpellModTierSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, nameof (_SpellModTierSettings));
      JewelSpawnSystem.NativeFieldInfoPtr__CurveCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, nameof (_CurveCollectionSystem));
      JewelSpawnSystem.NativeFieldInfoPtr__JewelSpellModSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, nameof (_JewelSpellModSettings));
      JewelSpawnSystem.NativeFieldInfoPtr__LegendaryItemSpellModSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, nameof (_LegendaryItemSpellModSettings));
      JewelSpawnSystem.NativeFieldInfoPtr__LegendaryItemStatModSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, nameof (_LegendaryItemStatModSettings));
      JewelSpawnSystem.NativeFieldInfoPtr_JewelSpawnSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, nameof (JewelSpawnSystemData));
      JewelSpawnSystem.NativeFieldInfoPtr__NamePrefixIndexCounters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, nameof (_NamePrefixIndexCounters));
      JewelSpawnSystem.NativeFieldInfoPtr__NamePostfixIndexCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, nameof (_NamePostfixIndexCounter));
      JewelSpawnSystem.NativeFieldInfoPtr__HasRunConvertOnDemand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, nameof (_HasRunConvertOnDemand));
      JewelSpawnSystem.NativeFieldInfoPtr_MIN_JEWELITEMLEVEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, nameof (MIN_JEWELITEMLEVEL));
      JewelSpawnSystem.NativeFieldInfoPtr__JewelSpawnQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, nameof (_JewelSpawnQuery));
      JewelSpawnSystem.NativeFieldInfoPtr__LegendaryItemSpawnQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, nameof (_LegendaryItemSpawnQuery));
      JewelSpawnSystem.NativeFieldInfoPtr__ShouldRunSystemQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, nameof (_ShouldRunSystemQuery));
      JewelSpawnSystem.NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, "<>BuildSpellSchoolSets_LambdaJob0_entityQuery");
      JewelSpawnSystem.NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, "<>BuildSpellSchoolSets_LambdaJob0_profilerMarker");
      JewelSpawnSystem.NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, "<>BuildSpellSchoolSets_LambdaJob1_entityQuery");
      JewelSpawnSystem.NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, "<>BuildSpellSchoolSets_LambdaJob1_profilerMarker");
      JewelSpawnSystem.NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob2_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, "<>BuildSpellSchoolSets_LambdaJob2_entityQuery");
      JewelSpawnSystem.NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob2_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, "<>BuildSpellSchoolSets_LambdaJob2_profilerMarker");
      JewelSpawnSystem.NativeFieldInfoPtr___BuildJewelByUnitLevelMapping_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, "<>BuildJewelByUnitLevelMapping_LambdaJob0_entityQuery");
      JewelSpawnSystem.NativeFieldInfoPtr___BuildJewelByUnitLevelMapping_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, "<>BuildJewelByUnitLevelMapping_LambdaJob0_profilerMarker");
      JewelSpawnSystem.NativeFieldInfoPtr___BuildJewelByUnitLevelMapping_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, "<>BuildJewelByUnitLevelMapping_LambdaJob1_entityQuery");
      JewelSpawnSystem.NativeFieldInfoPtr___BuildJewelByUnitLevelMapping_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, "<>BuildJewelByUnitLevelMapping_LambdaJob1_profilerMarker");
      JewelSpawnSystem.NativeMethodInfoPtr_get_JewelItemPrefab_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681135);
      JewelSpawnSystem.NativeMethodInfoPtr_get_PersistentIdentifier_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681136);
      JewelSpawnSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681137);
      JewelSpawnSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681138);
      JewelSpawnSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681139);
      JewelSpawnSystem.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681140);
      JewelSpawnSystem.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681141);
      JewelSpawnSystem.NativeMethodInfoPtr_TryCreateJewel_Public_Boolean_Entity_Int32_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681142);
      JewelSpawnSystem.NativeMethodInfoPtr_TryGetJewelTier_Public_Static_Boolean_BlobAssetReference_1_SpellModSetGlobalTierData_CurveCollection_Int32_byref_Random_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681143);
      JewelSpawnSystem.NativeMethodInfoPtr_TryGetWeaponTypeForItemLevel_Public_Static_Boolean_BlobAssetReference_1_SpellModSetGlobalTierData_Int32_byref_Random_byref_WeaponType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681144);
      JewelSpawnSystem.NativeMethodInfoPtr_TryGetRandomJewelAbility_Public_Static_Boolean_JewelSpawnSystemData_Int32_byref_Random_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681145);
      JewelSpawnSystem.NativeMethodInfoPtr_TryGetRandomJewelAbilityFromSchool_Public_Boolean_PrefabGUID_Int32_byref_Random_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681146);
      JewelSpawnSystem.NativeMethodInfoPtr_TryGetJewelPrefabGUID_Public_Static_Boolean_JewelSpawnSystemData_BlobAssetReference_1_SpellModSetGlobalTierData_CurveCollection_Int32_byref_Random_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681147);
      JewelSpawnSystem.NativeMethodInfoPtr_TryGetLegendaryItemPrefabGUID_Public_Static_Boolean_JewelSpawnSystemData_BlobAssetReference_1_SpellModSetGlobalTierData_CurveCollection_Int32_byref_Random_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681148);
      JewelSpawnSystem.NativeMethodInfoPtr_TryGetJewelPrefabGUIDFromAbility_Public_Static_Boolean_JewelSpawnSystemData_PrefabGUID_Int32_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681149);
      JewelSpawnSystem.NativeMethodInfoPtr_TryGetLegendaryWeaponPrefabGUIDFromTierAndWeaponType_Public_Static_Boolean_JewelSpawnSystemData_Int32_WeaponType_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681150);
      JewelSpawnSystem.NativeMethodInfoPtr_TryGetJewelPrefabGUIDFromSpellSchool_Public_Static_Boolean_JewelSpawnSystemData_PrefabGUID_Int32_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681151);
      JewelSpawnSystem.NativeMethodInfoPtr_TryCreateJewelAndAddToInventory_Public_Boolean_Entity_PrefabGUID_Int32_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681152);
      JewelSpawnSystem.NativeMethodInfoPtr_TryInitializeJewelData_Public_Boolean_Entity_byref_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681153);
      JewelSpawnSystem.NativeMethodInfoPtr_TryInitializeJewelData_Public_Boolean_Int32_Entity_byref_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681154);
      JewelSpawnSystem.NativeMethodInfoPtr_TryInitializeJewelData_Public_Boolean_PrefabGUID_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681155);
      JewelSpawnSystem.NativeMethodInfoPtr_TryInitializeLegendaryItemData_Public_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681156);
      JewelSpawnSystem.NativeMethodInfoPtr_GenerateName_Private_Void_byref_GeneratedName_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681157);
      JewelSpawnSystem.NativeMethodInfoPtr_PostfixHash_Private_Byte_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681158);
      JewelSpawnSystem.NativeMethodInfoPtr_PrefixHash_Private_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681159);
      JewelSpawnSystem.NativeMethodInfoPtr_TryConvertOnDemand_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681160);
      JewelSpawnSystem.NativeMethodInfoPtr_FindAndSetJewelItem_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681161);
      JewelSpawnSystem.NativeMethodInfoPtr_BuildSpellSchoolSets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681162);
      JewelSpawnSystem.NativeMethodInfoPtr_BuildJewelByUnitLevelMapping_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681163);
      JewelSpawnSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681164);
      JewelSpawnSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681166);
      JewelSpawnSystem.NativeMethodInfoPtr___GetEntityQuery_ForBuildSpellSchoolSets_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681167);
      JewelSpawnSystem.NativeMethodInfoPtr___GetEntityQuery_ForBuildSpellSchoolSets_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681168);
      JewelSpawnSystem.NativeMethodInfoPtr___GetEntityQuery_ForBuildSpellSchoolSets_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681169);
      JewelSpawnSystem.NativeMethodInfoPtr___GetEntityQuery_ForBuildJewelByUnitLevelMapping_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681170);
      JewelSpawnSystem.NativeMethodInfoPtr___GetEntityQuery_ForBuildJewelByUnitLevelMapping_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681171);
      JewelSpawnSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681172);
      JewelSpawnSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681173);
      JewelSpawnSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681174);
      JewelSpawnSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681175);
      JewelSpawnSystem.NativeMethodInfoPtr_Method_Public_Static_Void_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, 100681176);
    }

    public JewelSpawnSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr__PrefabCollection));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr__PrefabCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellModSyncSystem_Server _SpellModSyncSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr__SpellModSyncSystem));
        return pointer == System.IntPtr.Zero ? (SpellModSyncSystem_Server) null : new SpellModSyncSystem_Server(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr__SpellModSyncSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellModTierCollectionSystem _SpellModTierSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr__SpellModTierSettings));
        return pointer == System.IntPtr.Zero ? (SpellModTierCollectionSystem) null : new SpellModTierCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr__SpellModTierSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CurveCollectionSystem _CurveCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr__CurveCollectionSystem));
        return pointer == System.IntPtr.Zero ? (CurveCollectionSystem) null : new CurveCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr__CurveCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe PrefabGUID _JewelSpellModSettings
    {
      get
      {
        PrefabGUID spellModSettings;
        IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.NativeFieldInfoPtr__JewelSpellModSettings, (void*) &spellModSettings);
        return spellModSettings;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.NativeFieldInfoPtr__JewelSpellModSettings, (void*) &value);
      }
    }

    public static unsafe PrefabGUID _LegendaryItemSpellModSettings
    {
      get
      {
        PrefabGUID spellModSettings;
        IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.NativeFieldInfoPtr__LegendaryItemSpellModSettings, (void*) &spellModSettings);
        return spellModSettings;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.NativeFieldInfoPtr__LegendaryItemSpellModSettings, (void*) &value);
      }
    }

    public static unsafe PrefabGUID _LegendaryItemStatModSettings
    {
      get
      {
        PrefabGUID itemStatModSettings;
        IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.NativeFieldInfoPtr__LegendaryItemStatModSettings, (void*) &itemStatModSettings);
        return itemStatModSettings;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.NativeFieldInfoPtr__LegendaryItemStatModSettings, (void*) &value);
      }
    }

    public unsafe JewelSpawnSystemData JewelSpawnSystemData
    {
      get
      {
        return *(JewelSpawnSystemData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr_JewelSpawnSystemData));
      }
      [param: In] set
      {
        *(JewelSpawnSystemData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr_JewelSpawnSystemData)) = value;
      }
    }

    public unsafe NativeHashMap<PrefabGUID, int> _NamePrefixIndexCounters
    {
      get
      {
        return *(NativeHashMap<PrefabGUID, int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr__NamePrefixIndexCounters));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr__NamePrefixIndexCounters), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int _NamePostfixIndexCounter
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr__NamePostfixIndexCounter));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr__NamePostfixIndexCounter)) = value;
      }
    }

    public unsafe bool _HasRunConvertOnDemand
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr__HasRunConvertOnDemand));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr__HasRunConvertOnDemand)) = value;
      }
    }

    public static unsafe int MIN_JEWELITEMLEVEL
    {
      get
      {
        int minJewelitemlevel;
        IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.NativeFieldInfoPtr_MIN_JEWELITEMLEVEL, (void*) &minJewelitemlevel);
        return minJewelitemlevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.NativeFieldInfoPtr_MIN_JEWELITEMLEVEL, (void*) &value);
      }
    }

    public unsafe EntityQuery _JewelSpawnQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr__JewelSpawnQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr__JewelSpawnQuery)) = value;
      }
    }

    public unsafe EntityQuery _LegendaryItemSpawnQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr__LegendaryItemSpawnQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr__LegendaryItemSpawnQuery)) = value;
      }
    }

    public unsafe EntityQuery _ShouldRunSystemQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr__ShouldRunSystemQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr__ShouldRunSystemQuery)) = value;
      }
    }

    public unsafe EntityQuery __BuildSpellSchoolSets_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __BuildSpellSchoolSets_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __BuildSpellSchoolSets_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __BuildSpellSchoolSets_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __BuildSpellSchoolSets_LambdaJob2_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob2_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob2_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __BuildSpellSchoolSets_LambdaJob2_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob2_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr___BuildSpellSchoolSets_LambdaJob2_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __BuildJewelByUnitLevelMapping_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr___BuildJewelByUnitLevelMapping_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr___BuildJewelByUnitLevelMapping_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __BuildJewelByUnitLevelMapping_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr___BuildJewelByUnitLevelMapping_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr___BuildJewelByUnitLevelMapping_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __BuildJewelByUnitLevelMapping_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr___BuildJewelByUnitLevelMapping_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr___BuildJewelByUnitLevelMapping_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __BuildJewelByUnitLevelMapping_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr___BuildJewelByUnitLevelMapping_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JewelSpawnSystem.NativeFieldInfoPtr___BuildJewelByUnitLevelMapping_LambdaJob1_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ManuallyGenerated
    {
      static ManuallyGenerated()
      {
        Il2CppClassPointerStore<JewelSpawnSystem.ManuallyGenerated>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, nameof (ManuallyGenerated));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelSpawnSystem.ManuallyGenerated>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelSpawnSystem.ManuallyGenerated>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TierWithWeight
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Tier;
      private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
      [FieldOffset(0)]
      public int Tier;
      [FieldOffset(4)]
      public int Weight;

      static TierWithWeight()
      {
        Il2CppClassPointerStore<JewelSpawnSystem.TierWithWeight>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, nameof (TierWithWeight));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelSpawnSystem.TierWithWeight>.NativeClassPtr);
        JewelSpawnSystem.TierWithWeight.NativeFieldInfoPtr_Tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.TierWithWeight>.NativeClassPtr, nameof (Tier));
        JewelSpawnSystem.TierWithWeight.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.TierWithWeight>.NativeClassPtr, nameof (Weight));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelSpawnSystem.TierWithWeight>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.JewelSpawnSystem/<>c__DisplayClass47_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass47_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_abilityToSpellSchool;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__BuildSpellSchoolSets_b__0_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_SpellSchoolAbility_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, PrefabGUID> abilityToSpellSchool;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass47_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _BuildSpellSchoolSets_b__0(
        [In] ref PrefabGUID prefabGuid,
        [In] ref DynamicBuffer<SpellSchoolAbility> spellSchoolAbilities)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref prefabGuid;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref spellSchoolAbilities;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass47_0.NativeMethodInfoPtr__BuildSpellSchoolSets_b__0_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_SpellSchoolAbility_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass47_0()
      {
        Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass47_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, "<>c__DisplayClass47_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass47_0>.NativeClassPtr);
        JewelSpawnSystem.__c__DisplayClass47_0.NativeFieldInfoPtr_abilityToSpellSchool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass47_0>.NativeClassPtr, nameof (abilityToSpellSchool));
        JewelSpawnSystem.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass47_0>.NativeClassPtr, 100681177);
        JewelSpawnSystem.__c__DisplayClass47_0.NativeMethodInfoPtr__BuildSpellSchoolSets_b__0_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_SpellSchoolAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass47_0>.NativeClassPtr, 100681178);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass47_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.JewelSpawnSystem/<>c__DisplayClass47_1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass47_1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_spellSchoolTierToJewel;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__BuildSpellSchoolSets_b__1_Internal_Void_byref_PrefabGUID_byref_JewelInstance_0;
      [FieldOffset(0)]
      public NativeHashMap<SpellSchoolTier, PrefabGUID> spellSchoolTierToJewel;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass47_1()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass47_1.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _BuildSpellSchoolSets_b__1(
        [In] ref PrefabGUID prefabGuid,
        [In] ref JewelInstance jewelInstance)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref prefabGuid;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jewelInstance;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass47_1.NativeMethodInfoPtr__BuildSpellSchoolSets_b__1_Internal_Void_byref_PrefabGUID_byref_JewelInstance_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass47_1()
      {
        Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass47_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, "<>c__DisplayClass47_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass47_1>.NativeClassPtr);
        JewelSpawnSystem.__c__DisplayClass47_1.NativeFieldInfoPtr_spellSchoolTierToJewel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass47_1>.NativeClassPtr, nameof (spellSchoolTierToJewel));
        JewelSpawnSystem.__c__DisplayClass47_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass47_1>.NativeClassPtr, 100681179);
        JewelSpawnSystem.__c__DisplayClass47_1.NativeMethodInfoPtr__BuildSpellSchoolSets_b__1_Internal_Void_byref_PrefabGUID_byref_JewelInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass47_1>.NativeClassPtr, 100681180);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass47_1>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.JewelSpawnSystem/<>c__DisplayClass47_2")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass47_2
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_weaponTypeTierToLegendaryWeapon;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__BuildSpellSchoolSets_b__2_Internal_Void_byref_PrefabGUID_byref_EquippableData_byref_LegendaryItemInstance_0;
      [FieldOffset(0)]
      public NativeHashMap<WeaponTypeTier, PrefabGUID> weaponTypeTierToLegendaryWeapon;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass47_2()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass47_2.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _BuildSpellSchoolSets_b__2(
        [In] ref PrefabGUID prefabGuid,
        [In] ref EquippableData equippableData,
        [In] ref LegendaryItemInstance legendaryItemInstance)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref prefabGuid;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref equippableData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref legendaryItemInstance;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass47_2.NativeMethodInfoPtr__BuildSpellSchoolSets_b__2_Internal_Void_byref_PrefabGUID_byref_EquippableData_byref_LegendaryItemInstance_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass47_2()
      {
        Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass47_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, "<>c__DisplayClass47_2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass47_2>.NativeClassPtr);
        JewelSpawnSystem.__c__DisplayClass47_2.NativeFieldInfoPtr_weaponTypeTierToLegendaryWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass47_2>.NativeClassPtr, nameof (weaponTypeTierToLegendaryWeapon));
        JewelSpawnSystem.__c__DisplayClass47_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass47_2>.NativeClassPtr, 100681181);
        JewelSpawnSystem.__c__DisplayClass47_2.NativeMethodInfoPtr__BuildSpellSchoolSets_b__2_Internal_Void_byref_PrefabGUID_byref_EquippableData_byref_LegendaryItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass47_2>.NativeClassPtr, 100681182);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass47_2>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.JewelSpawnSystem/<>c__DisplayClass48_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass48_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_abilityGroupsPerUnitLevel;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__BuildJewelByUnitLevelMapping_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_TechUnlockAbilityBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__BuildJewelByUnitLevelMapping_b__1_Internal_Void_Entity_byref_UnitLevel_0;
      [FieldOffset(0)]
      public PrefabLookupMap prefabLookupMap;
      [FieldOffset(48)]
      public EntityManager entityManager;
      [FieldOffset(56)]
      public NativeList<UnitLevelAbilityGroupData> abilityGroupsPerUnitLevel;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass48_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _BuildJewelByUnitLevelMapping_b__0(
        Entity entity,
        [In] ref DynamicBuffer<TechUnlockAbilityBuffer> abilityBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass48_0.NativeMethodInfoPtr__BuildJewelByUnitLevelMapping_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_TechUnlockAbilityBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _BuildJewelByUnitLevelMapping_b__1(Entity entity, [In] ref UnitLevel unitLevel)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref unitLevel;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass48_0.NativeMethodInfoPtr__BuildJewelByUnitLevelMapping_b__1_Internal_Void_Entity_byref_UnitLevel_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass48_0()
      {
        Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass48_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, "<>c__DisplayClass48_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass48_0>.NativeClassPtr);
        JewelSpawnSystem.__c__DisplayClass48_0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass48_0>.NativeClassPtr, nameof (prefabLookupMap));
        JewelSpawnSystem.__c__DisplayClass48_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass48_0>.NativeClassPtr, nameof (entityManager));
        JewelSpawnSystem.__c__DisplayClass48_0.NativeFieldInfoPtr_abilityGroupsPerUnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass48_0>.NativeClassPtr, nameof (abilityGroupsPerUnitLevel));
        JewelSpawnSystem.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass48_0>.NativeClassPtr, 100681183);
        JewelSpawnSystem.__c__DisplayClass48_0.NativeMethodInfoPtr__BuildJewelByUnitLevelMapping_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_TechUnlockAbilityBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass48_0>.NativeClassPtr, 100681184);
        JewelSpawnSystem.__c__DisplayClass48_0.NativeMethodInfoPtr__BuildJewelByUnitLevelMapping_b__1_Internal_Void_Entity_byref_UnitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass48_0>.NativeClassPtr, 100681185);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass48_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.JewelSpawnSystem/ProjectM.<>c__DisplayClass_BuildSpellSchoolSets_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_BuildSpellSchoolSets_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_abilityToSpellSchool;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_SpellSchoolAbility_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_byref___c__DisplayClass47_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, PrefabGUID> abilityToSpellSchool;
      [FieldOffset(16)]
      public JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036872, XrefRangeEnd = 1036883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref PrefabGUID prefabGuid,
        [In] ref DynamicBuffer<SpellSchoolAbility> spellSchoolAbilities)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref prefabGuid;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref spellSchoolAbilities;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_SpellSchoolAbility_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref JewelSpawnSystem.__c__DisplayClass47_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref JewelSpawnSystem.__c__DisplayClass47_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036883, XrefRangeEnd = 1036885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1036893, RefRangeEnd = 1036894, XrefRangeStart = 1036885, XrefRangeEnd = 1036893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1036896, RefRangeEnd = 1036897, XrefRangeStart = 1036894, XrefRangeEnd = 1036896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        JewelSpawnSystem componentSystem,
        ref JewelSpawnSystem.__c__DisplayClass47_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_byref___c__DisplayClass47_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036897, XrefRangeEnd = 1036901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036901, XrefRangeEnd = 1036907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_BuildSpellSchoolSets_LambdaJob0()
      {
        Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, "<>c__DisplayClass_BuildSpellSchoolSets_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0>.NativeClassPtr);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeFieldInfoPtr_abilityToSpellSchool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0>.NativeClassPtr, nameof (abilityToSpellSchool));
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_SpellSchoolAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0>.NativeClassPtr, 100681186);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0>.NativeClassPtr, 100681187);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0>.NativeClassPtr, 100681188);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0>.NativeClassPtr, 100681189);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0>.NativeClassPtr, 100681190);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_byref___c__DisplayClass47_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0>.NativeClassPtr, 100681191);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0>.NativeClassPtr, 100681192);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0>.NativeClassPtr, 100681193);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabGuid;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_spellSchoolAbilities;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<PrefabGUID> forParameter_prefabGuid;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_DynamicBuffer<SpellSchoolAbility> forParameter_spellSchoolAbilities;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1036789, RefRangeEnd = 1036790, XrefRangeStart = 1036783, XrefRangeEnd = 1036789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(JewelSpawnSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1036796, RefRangeEnd = 1036797, XrefRangeStart = 1036790, XrefRangeEnd = 1036796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabGuid));
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_spellSchoolAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_spellSchoolAbilities));
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100681194);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100681195);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabGuid;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_spellSchoolAbilities;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<PrefabGUID>.Runtime runtime_prefabGuid;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<SpellSchoolAbility>.Runtime runtime_spellSchoolAbilities;

          static Runtimes()
          {
            Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabGuid));
            JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_spellSchoolAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_spellSchoolAbilities));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.JewelSpawnSystem/ProjectM.<>c__DisplayClass_BuildSpellSchoolSets_LambdaJob0/ProjectM.RunWithoutJobSystem_000040EB$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000040EB$PostfixBurstDelegate");
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681196);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681197);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681198);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681199);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.JewelSpawnSystem/ProjectM.<>c__DisplayClass_BuildSpellSchoolSets_LambdaJob0/ProjectM.RunWithoutJobSystem_000040EB$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036797, XrefRangeEnd = 1036811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036811, XrefRangeEnd = 1036829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036829, XrefRangeEnd = 1036844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1036871, RefRangeEnd = 1036872, XrefRangeStart = 1036844, XrefRangeEnd = 1036871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_000040EB$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681200);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681201);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681202);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681203);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681205);
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
            IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.JewelSpawnSystem/ProjectM.<>c__DisplayClass_BuildSpellSchoolSets_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_BuildSpellSchoolSets_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_spellSchoolTierToJewel;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_PrefabGUID_byref_JewelInstance_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_byref___c__DisplayClass47_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<SpellSchoolTier, PrefabGUID> spellSchoolTierToJewel;
      [FieldOffset(16)]
      public JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036996, XrefRangeEnd = 1037001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref PrefabGUID prefabGuid,
        [In] ref JewelInstance jewelInstance)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref prefabGuid;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jewelInstance;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_PrefabGUID_byref_JewelInstance_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref JewelSpawnSystem.__c__DisplayClass47_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref JewelSpawnSystem.__c__DisplayClass47_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037001, XrefRangeEnd = 1037003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1037011, RefRangeEnd = 1037012, XrefRangeStart = 1037003, XrefRangeEnd = 1037011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1037014, RefRangeEnd = 1037015, XrefRangeStart = 1037012, XrefRangeEnd = 1037014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        JewelSpawnSystem componentSystem,
        ref JewelSpawnSystem.__c__DisplayClass47_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_byref___c__DisplayClass47_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037015, XrefRangeEnd = 1037019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037019, XrefRangeEnd = 1037025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_BuildSpellSchoolSets_LambdaJob1()
      {
        Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, "<>c__DisplayClass_BuildSpellSchoolSets_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1>.NativeClassPtr);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeFieldInfoPtr_spellSchoolTierToJewel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1>.NativeClassPtr, nameof (spellSchoolTierToJewel));
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_PrefabGUID_byref_JewelInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1>.NativeClassPtr, 100681206);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1>.NativeClassPtr, 100681207);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1>.NativeClassPtr, 100681208);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1>.NativeClassPtr, 100681209);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1>.NativeClassPtr, 100681210);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_byref___c__DisplayClass47_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1>.NativeClassPtr, 100681211);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1>.NativeClassPtr, 100681212);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1>.NativeClassPtr, 100681213);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabGuid;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_jewelInstance;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<PrefabGUID> forParameter_prefabGuid;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<JewelInstance> forParameter_jewelInstance;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1036913, RefRangeEnd = 1036914, XrefRangeStart = 1036907, XrefRangeEnd = 1036913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(JewelSpawnSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1036920, RefRangeEnd = 1036921, XrefRangeStart = 1036914, XrefRangeEnd = 1036920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabGuid));
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_jewelInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_jewelInstance));
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100681214);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100681215);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabGuid;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_jewelInstance;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<PrefabGUID>.Runtime runtime_prefabGuid;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<JewelInstance>.Runtime runtime_jewelInstance;

          static Runtimes()
          {
            Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabGuid));
            JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_jewelInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_jewelInstance));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.JewelSpawnSystem/ProjectM.<>c__DisplayClass_BuildSpellSchoolSets_LambdaJob1/ProjectM.RunWithoutJobSystem_000040F4$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_000040F4$PostfixBurstDelegate");
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681216);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681217);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681218);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681219);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.JewelSpawnSystem/ProjectM.<>c__DisplayClass_BuildSpellSchoolSets_LambdaJob1/ProjectM.RunWithoutJobSystem_000040F4$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036921, XrefRangeEnd = 1036935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036935, XrefRangeEnd = 1036953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036953, XrefRangeEnd = 1036968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1036995, RefRangeEnd = 1036996, XrefRangeStart = 1036968, XrefRangeEnd = 1036995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_000040F4$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681220);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681221);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681222);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681223);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681225);
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
            IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.JewelSpawnSystem/ProjectM.<>c__DisplayClass_BuildSpellSchoolSets_LambdaJob2")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_BuildSpellSchoolSets_LambdaJob2
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_weaponTypeTierToLegendaryWeapon;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_PrefabGUID_byref_EquippableData_byref_LegendaryItemInstance_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_byref___c__DisplayClass47_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<WeaponTypeTier, PrefabGUID> weaponTypeTierToLegendaryWeapon;
      [FieldOffset(16)]
      public JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(112)]
      public unsafe JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037120, XrefRangeEnd = 1037123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref PrefabGUID prefabGuid,
        [In] ref EquippableData equippableData,
        [In] ref LegendaryItemInstance legendaryItemInstance)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref prefabGuid;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref equippableData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref legendaryItemInstance;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_PrefabGUID_byref_EquippableData_byref_LegendaryItemInstance_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref JewelSpawnSystem.__c__DisplayClass47_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref JewelSpawnSystem.__c__DisplayClass47_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037123, XrefRangeEnd = 1037125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1037136, RefRangeEnd = 1037137, XrefRangeStart = 1037125, XrefRangeEnd = 1037136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1037139, RefRangeEnd = 1037140, XrefRangeStart = 1037137, XrefRangeEnd = 1037139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        JewelSpawnSystem componentSystem,
        ref JewelSpawnSystem.__c__DisplayClass47_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_byref___c__DisplayClass47_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037140, XrefRangeEnd = 1037144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037144, XrefRangeEnd = 1037150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_BuildSpellSchoolSets_LambdaJob2()
      {
        Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, "<>c__DisplayClass_BuildSpellSchoolSets_LambdaJob2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2>.NativeClassPtr);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeFieldInfoPtr_weaponTypeTierToLegendaryWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2>.NativeClassPtr, nameof (weaponTypeTierToLegendaryWeapon));
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2>.NativeClassPtr, nameof (_runtimes));
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_PrefabGUID_byref_EquippableData_byref_LegendaryItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2>.NativeClassPtr, 100681226);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2>.NativeClassPtr, 100681227);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass47_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2>.NativeClassPtr, 100681228);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2>.NativeClassPtr, 100681229);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2>.NativeClassPtr, 100681230);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_byref___c__DisplayClass47_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2>.NativeClassPtr, 100681231);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2>.NativeClassPtr, 100681232);
        JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2>.NativeClassPtr, 100681233);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabGuid;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_equippableData;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_legendaryItemInstance;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<PrefabGUID> forParameter_prefabGuid;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<EquippableData> forParameter_equippableData;
        [FieldOffset(64)]
        public LambdaParameterValueProvider_IComponentData<LegendaryItemInstance> forParameter_legendaryItemInstance;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1037034, RefRangeEnd = 1037035, XrefRangeStart = 1037025, XrefRangeEnd = 1037034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(JewelSpawnSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1037044, RefRangeEnd = 1037045, XrefRangeStart = 1037035, XrefRangeEnd = 1037044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabGuid));
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_equippableData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_equippableData));
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_legendaryItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_legendaryItemInstance));
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100681234);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100681235);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabGuid;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_equippableData;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_legendaryItemInstance;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<PrefabGUID>.Runtime runtime_prefabGuid;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<EquippableData>.Runtime runtime_equippableData;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<LegendaryItemInstance>.Runtime runtime_legendaryItemInstance;

          static Runtimes()
          {
            Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabGuid));
            JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_equippableData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_equippableData));
            JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_legendaryItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_legendaryItemInstance));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.JewelSpawnSystem/ProjectM.<>c__DisplayClass_BuildSpellSchoolSets_LambdaJob2/ProjectM.RunWithoutJobSystem_000040FD$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_000040FD$PostfixBurstDelegate");
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681236);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681237);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681238);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681239);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.JewelSpawnSystem/ProjectM.<>c__DisplayClass_BuildSpellSchoolSets_LambdaJob2/ProjectM.RunWithoutJobSystem_000040FD$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037045, XrefRangeEnd = 1037059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037059, XrefRangeEnd = 1037077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037077, XrefRangeEnd = 1037092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1037119, RefRangeEnd = 1037120, XrefRangeStart = 1037092, XrefRangeEnd = 1037119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_000040FD$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681240);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681241);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681242);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681243);
          JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681245);
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
            IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.__c__DisplayClass_BuildSpellSchoolSets_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.JewelSpawnSystem/ProjectM.<>c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_abilityGroupsPerUnitLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_TechUnlockAbilityBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass48_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass48_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_byref___c__DisplayClass48_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public PrefabLookupMap prefabLookupMap;
      [FieldOffset(48)]
      public EntityManager entityManager;
      [FieldOffset(56)]
      public NativeList<UnitLevelAbilityGroupData> abilityGroupsPerUnitLevel;
      [FieldOffset(72)]
      public JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(120)]
      public unsafe JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037235, XrefRangeEnd = 1037252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref DynamicBuffer<TechUnlockAbilityBuffer> abilityBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref abilityBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_TechUnlockAbilityBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1037252, RefRangeEnd = 1037253, XrefRangeStart = 1037252, XrefRangeEnd = 1037252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref JewelSpawnSystem.__c__DisplayClass48_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass48_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1037253, RefRangeEnd = 1037254, XrefRangeStart = 1037253, XrefRangeEnd = 1037253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref JewelSpawnSystem.__c__DisplayClass48_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass48_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037254, XrefRangeEnd = 1037256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1037262, RefRangeEnd = 1037263, XrefRangeStart = 1037256, XrefRangeEnd = 1037262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1037265, RefRangeEnd = 1037266, XrefRangeStart = 1037263, XrefRangeEnd = 1037265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        JewelSpawnSystem componentSystem,
        ref JewelSpawnSystem.__c__DisplayClass48_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_byref___c__DisplayClass48_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037266, XrefRangeEnd = 1037270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037270, XrefRangeEnd = 1037276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0()
      {
        Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, "<>c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0>.NativeClassPtr);
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0>.NativeClassPtr, nameof (prefabLookupMap));
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0>.NativeClassPtr, nameof (entityManager));
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeFieldInfoPtr_abilityGroupsPerUnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0>.NativeClassPtr, nameof (abilityGroupsPerUnitLevel));
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_TechUnlockAbilityBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0>.NativeClassPtr, 100681246);
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass48_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0>.NativeClassPtr, 100681247);
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass48_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0>.NativeClassPtr, 100681248);
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0>.NativeClassPtr, 100681249);
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0>.NativeClassPtr, 100681250);
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_byref___c__DisplayClass48_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0>.NativeClassPtr, 100681251);
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0>.NativeClassPtr, 100681252);
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0>.NativeClassPtr, 100681253);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_abilityBuffer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<TechUnlockAbilityBuffer> forParameter_abilityBuffer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1037154, RefRangeEnd = 1037155, XrefRangeStart = 1037150, XrefRangeEnd = 1037154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(JewelSpawnSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1037159, RefRangeEnd = 1037160, XrefRangeStart = 1037155, XrefRangeEnd = 1037159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_abilityBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_abilityBuffer));
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100681254);
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100681255);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_abilityBuffer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<TechUnlockAbilityBuffer>.Runtime runtime_abilityBuffer;

          static Runtimes()
          {
            Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_abilityBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_abilityBuffer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.JewelSpawnSystem/ProjectM.<>c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0/ProjectM.RunWithoutJobSystem_00004106$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00004106$PostfixBurstDelegate");
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681256);
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681257);
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681258);
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681259);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.JewelSpawnSystem/ProjectM.<>c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0/ProjectM.RunWithoutJobSystem_00004106$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037160, XrefRangeEnd = 1037174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037174, XrefRangeEnd = 1037192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037192, XrefRangeEnd = 1037207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1037234, RefRangeEnd = 1037235, XrefRangeStart = 1037207, XrefRangeEnd = 1037234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00004106$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681260);
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681261);
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681262);
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681263);
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681265);
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
            IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.JewelSpawnSystem/ProjectM.<>c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_abilityGroupsPerUnitLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UnitLevel_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass48_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass48_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_byref___c__DisplayClass48_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public PrefabLookupMap prefabLookupMap;
      [FieldOffset(56)]
      public NativeList<UnitLevelAbilityGroupData> abilityGroupsPerUnitLevel;
      [FieldOffset(72)]
      public JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(112)]
      public unsafe JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037361, XrefRangeEnd = 1037406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref UnitLevel unitLevel)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref unitLevel;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UnitLevel_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1037406, RefRangeEnd = 1037407, XrefRangeStart = 1037406, XrefRangeEnd = 1037406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref JewelSpawnSystem.__c__DisplayClass48_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass48_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1037407, RefRangeEnd = 1037408, XrefRangeStart = 1037407, XrefRangeEnd = 1037407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref JewelSpawnSystem.__c__DisplayClass48_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass48_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037408, XrefRangeEnd = 1037410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1037416, RefRangeEnd = 1037417, XrefRangeStart = 1037410, XrefRangeEnd = 1037416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1037419, RefRangeEnd = 1037420, XrefRangeStart = 1037417, XrefRangeEnd = 1037419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        JewelSpawnSystem componentSystem,
        ref JewelSpawnSystem.__c__DisplayClass48_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_byref___c__DisplayClass48_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037420, XrefRangeEnd = 1037424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037424, XrefRangeEnd = 1037430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1()
      {
        Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem>.NativeClassPtr, "<>c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1>.NativeClassPtr);
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1>.NativeClassPtr, nameof (entityManager));
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1>.NativeClassPtr, nameof (prefabLookupMap));
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeFieldInfoPtr_abilityGroupsPerUnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1>.NativeClassPtr, nameof (abilityGroupsPerUnitLevel));
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UnitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1>.NativeClassPtr, 100681266);
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass48_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1>.NativeClassPtr, 100681267);
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass48_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1>.NativeClassPtr, 100681268);
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1>.NativeClassPtr, 100681269);
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1>.NativeClassPtr, 100681270);
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_byref___c__DisplayClass48_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1>.NativeClassPtr, 100681271);
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1>.NativeClassPtr, 100681272);
        JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1>.NativeClassPtr, 100681273);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_unitLevel;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<UnitLevel> forParameter_unitLevel;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1037280, RefRangeEnd = 1037281, XrefRangeStart = 1037276, XrefRangeEnd = 1037280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(JewelSpawnSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1037285, RefRangeEnd = 1037286, XrefRangeStart = 1037281, XrefRangeEnd = 1037285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_unitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_unitLevel));
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_JewelSpawnSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100681274);
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100681275);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_unitLevel;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<UnitLevel>.Runtime runtime_unitLevel;

          static Runtimes()
          {
            Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_unitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_unitLevel));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.JewelSpawnSystem/ProjectM.<>c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1/ProjectM.RunWithoutJobSystem_0000410F$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_0000410F$PostfixBurstDelegate");
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681276);
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681277);
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681278);
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100681279);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.JewelSpawnSystem/ProjectM.<>c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1/ProjectM.RunWithoutJobSystem_0000410F$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037286, XrefRangeEnd = 1037300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037300, XrefRangeEnd = 1037318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037318, XrefRangeEnd = 1037333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1037360, RefRangeEnd = 1037361, XrefRangeStart = 1037333, XrefRangeEnd = 1037360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_0000410F$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681280);
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681281);
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681282);
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681283);
          JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100681285);
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
            IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(JewelSpawnSystem.__c__DisplayClass_BuildJewelByUnitLevelMapping_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
