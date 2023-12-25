// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleHeartHelpers
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public static class CastleHeartHelpers : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConnectedTileModels_Public_Static_NativeList_1_Entity_Entity_EntityManager_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetClaimReason_Public_Static_ClaimCastleReason_byref_Pylonstation_byref_Team_byref_ServerGameBalanceSettings_byref_ServerTime_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDestroyReason_Public_Static_DestroyCastleReason_byref_Pylonstation_byref_Team_byref_ServerGameBalanceSettings_byref_ServerTime_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRaidReason_Public_Static_RaidCastleReason_byref_Pylonstation_byref_CastleHeart_byref_ServerGameBalanceSettings_byref_ServerTime_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanClaim_Public_Static_Boolean_byref_Pylonstation_byref_Team_byref_ServerGameBalanceSettings_byref_ServerTime_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanDestroy_Public_Static_Boolean_byref_Pylonstation_byref_Team_byref_ServerGameBalanceSettings_byref_ServerTime_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanRaid_Public_Static_Boolean_byref_Pylonstation_byref_CastleHeart_byref_ServerGameBalanceSettings_byref_ServerTime_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsFreeRaid_Public_Static_Boolean_byref_Pylonstation_byref_ServerGameBalanceSettings_byref_ServerTime_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsFreeClaim_Public_Static_Boolean_byref_Pylonstation_byref_ServerGameBalanceSettings_byref_ServerTime_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsFreeDestroy_Public_Static_Boolean_byref_Pylonstation_byref_ServerGameBalanceSettings_byref_ServerTime_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLevelData_Public_Static_Boolean_byref_Pylonstation_byref_DynamicBuffer_1_TCastleBuffer_byref_NativeHashMap_2_PrefabGUID_TCastleData_byref_TCastleData_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CharacterMeetsRaidCosts_Public_Static_Boolean_byref_EntityManager_byref_NativeHashMap_2_PrefabGUID_CastleRaidData_byref_Entity_byref_Entity_byref_DynamicBuffer_1_CastleRaidRequirementBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CharacterMeetsDestroyCosts_Public_Static_Boolean_byref_EntityManager_byref_NativeHashMap_2_PrefabGUID_CastleDestroyData_byref_Entity_byref_Entity_byref_DynamicBuffer_1_CastleDestroyRequirementBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CharacterMeetsClaimCosts_Public_Static_Boolean_byref_EntityManager_byref_NativeHashMap_2_PrefabGUID_CastleClaimData_byref_Entity_byref_Entity_byref_DynamicBuffer_1_CastleClaimRequirementBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CharacterMeetsUpgradeCosts_Public_Static_Boolean_byref_EntityManager_byref_NativeHashMap_2_PrefabGUID_UpgradeData_byref_Entity_byref_Entity_byref_DynamicBuffer_1_UpgradeRequirementBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FulfillsAllRequirements_Public_Static_Boolean_byref_EntityManager_Entity_byref_DynamicBuffer_1_TRequirement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConsumeRequirements_Public_Static_Void_EntityManager_Entity_DynamicBuffer_1_TRequirement_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1128793, RefRangeEnd = 1128794, XrefRangeStart = 1128749, XrefRangeEnd = 1128793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe NativeList<Entity> GetConnectedTileModels(
      Entity castleHeart,
      EntityManager entityManager,
      Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &castleHeart;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleHeartHelpers.NativeMethodInfoPtr_GetConnectedTileModels_Public_Static_NativeList_1_Entity_Entity_EntityManager_Allocator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<Entity>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1128794, RefRangeEnd = 1128795, XrefRangeStart = 1128794, XrefRangeEnd = 1128794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ClaimCastleReason GetClaimReason(
      [In] ref Pylonstation pylonstation,
      [In] ref Team team,
      [In] ref ServerGameBalanceSettings balanceSettings,
      [In] ref ServerTime serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref pylonstation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref team;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref balanceSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleHeartHelpers.NativeMethodInfoPtr_GetClaimReason_Public_Static_ClaimCastleReason_byref_Pylonstation_byref_Team_byref_ServerGameBalanceSettings_byref_ServerTime_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ClaimCastleReason*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1128797, RefRangeEnd = 1128798, XrefRangeStart = 1128795, XrefRangeEnd = 1128797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe DestroyCastleReason GetDestroyReason(
      [In] ref Pylonstation pylonstation,
      [In] ref Team team,
      [In] ref ServerGameBalanceSettings balanceSettings,
      [In] ref ServerTime serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref pylonstation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref team;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref balanceSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleHeartHelpers.NativeMethodInfoPtr_GetDestroyReason_Public_Static_DestroyCastleReason_byref_Pylonstation_byref_Team_byref_ServerGameBalanceSettings_byref_ServerTime_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DestroyCastleReason*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1128799, RefRangeEnd = 1128800, XrefRangeStart = 1128798, XrefRangeEnd = 1128799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe RaidCastleReason GetRaidReason(
      [In] ref Pylonstation pylonstation,
      [In] ref CastleHeart castleHeart,
      [In] ref ServerGameBalanceSettings balanceSettings,
      [In] ref ServerTime serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref pylonstation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeart;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref balanceSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleHeartHelpers.NativeMethodInfoPtr_GetRaidReason_Public_Static_RaidCastleReason_byref_Pylonstation_byref_CastleHeart_byref_ServerGameBalanceSettings_byref_ServerTime_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(RaidCastleReason*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128800, XrefRangeEnd = 1128801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CanClaim(
      [In] ref Pylonstation pylonstation,
      [In] ref Team team,
      [In] ref ServerGameBalanceSettings balanceSettings,
      [In] ref ServerTime serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref pylonstation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref team;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref balanceSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleHeartHelpers.NativeMethodInfoPtr_CanClaim_Public_Static_Boolean_byref_Pylonstation_byref_Team_byref_ServerGameBalanceSettings_byref_ServerTime_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1128803, RefRangeEnd = 1128804, XrefRangeStart = 1128801, XrefRangeEnd = 1128803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CanDestroy(
      [In] ref Pylonstation pylonstation,
      [In] ref Team team,
      [In] ref ServerGameBalanceSettings balanceSettings,
      [In] ref ServerTime serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref pylonstation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref team;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref balanceSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleHeartHelpers.NativeMethodInfoPtr_CanDestroy_Public_Static_Boolean_byref_Pylonstation_byref_Team_byref_ServerGameBalanceSettings_byref_ServerTime_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1128805, RefRangeEnd = 1128806, XrefRangeStart = 1128804, XrefRangeEnd = 1128805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CanRaid(
      [In] ref Pylonstation pylonstation,
      [In] ref CastleHeart castleHeart,
      [In] ref ServerGameBalanceSettings balanceSettings,
      [In] ref ServerTime serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref pylonstation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeart;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref balanceSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleHeartHelpers.NativeMethodInfoPtr_CanRaid_Public_Static_Boolean_byref_Pylonstation_byref_CastleHeart_byref_ServerGameBalanceSettings_byref_ServerTime_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1128807, RefRangeEnd = 1128810, XrefRangeStart = 1128806, XrefRangeEnd = 1128807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsFreeRaid(
      [In] ref Pylonstation pylonstation,
      [In] ref ServerGameBalanceSettings balanceSettings,
      [In] ref ServerTime serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref pylonstation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref balanceSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleHeartHelpers.NativeMethodInfoPtr_IsFreeRaid_Public_Static_Boolean_byref_Pylonstation_byref_ServerGameBalanceSettings_byref_ServerTime_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1128810, RefRangeEnd = 1128812, XrefRangeStart = 1128810, XrefRangeEnd = 1128810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsFreeClaim(
      [In] ref Pylonstation pylonstation,
      [In] ref ServerGameBalanceSettings balanceSettings,
      [In] ref ServerTime serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref pylonstation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref balanceSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleHeartHelpers.NativeMethodInfoPtr_IsFreeClaim_Public_Static_Boolean_byref_Pylonstation_byref_ServerGameBalanceSettings_byref_ServerTime_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1128813, RefRangeEnd = 1128816, XrefRangeStart = 1128812, XrefRangeEnd = 1128813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsFreeDestroy(
      [In] ref Pylonstation pylonstation,
      [In] ref ServerGameBalanceSettings balanceSettings,
      [In] ref ServerTime serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref pylonstation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref balanceSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleHeartHelpers.NativeMethodInfoPtr_IsFreeDestroy_Public_Static_Boolean_byref_Pylonstation_byref_ServerGameBalanceSettings_byref_ServerTime_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1128829, RefRangeEnd = 1128831, XrefRangeStart = 1128816, XrefRangeEnd = 1128829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool GetLevelData<TCastleBuffer, TCastleData>(
      [In] ref Pylonstation pylonstation,
      [In] ref DynamicBuffer<TCastleBuffer> buffer,
      [In] ref NativeHashMap<PrefabGUID, TCastleData> lookup,
      out TCastleData castleData,
      int levelOffset = 0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref pylonstation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref lookup;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      TCastleData& local1;
      if (!typeof (TCastleData).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(TCastleData*) &zero);
      }
      else
        local1 = ref castleData;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &levelOffset;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CastleHeartHelpers.MethodInfoStoreGeneric_GetLevelData_Public_Static_Boolean_byref_Pylonstation_byref_DynamicBuffer_1_TCastleBuffer_byref_NativeHashMap_2_PrefabGUID_TCastleData_byref_TCastleData_Int32_0<TCastleBuffer, TCastleData>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (TCastleData).IsValueType)
      {
        ref TCastleData local2 = ref castleData;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TCastleData>(objectPointer, false, false);
        local2 = (TCastleData) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1128847, RefRangeEnd = 1128849, XrefRangeStart = 1128831, XrefRangeEnd = 1128847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CharacterMeetsRaidCosts(
      [In] ref EntityManager entityManager,
      [In] ref NativeHashMap<PrefabGUID, CastleRaidData> castleRaidLookup,
      [In] ref Entity castleHeartEntity,
      [In] ref Entity character,
      out DynamicBuffer<CastleRaidRequirementBuffer> requirements)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleRaidLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeartEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref requirements;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleHeartHelpers.NativeMethodInfoPtr_CharacterMeetsRaidCosts_Public_Static_Boolean_byref_EntityManager_byref_NativeHashMap_2_PrefabGUID_CastleRaidData_byref_Entity_byref_Entity_byref_DynamicBuffer_1_CastleRaidRequirementBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1128865, RefRangeEnd = 1128867, XrefRangeStart = 1128849, XrefRangeEnd = 1128865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CharacterMeetsDestroyCosts(
      [In] ref EntityManager entityManager,
      [In] ref NativeHashMap<PrefabGUID, CastleDestroyData> castleDestroyLookup,
      [In] ref Entity castleHeartEntity,
      [In] ref Entity character,
      out DynamicBuffer<CastleDestroyRequirementBuffer> requirements)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleDestroyLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeartEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref requirements;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleHeartHelpers.NativeMethodInfoPtr_CharacterMeetsDestroyCosts_Public_Static_Boolean_byref_EntityManager_byref_NativeHashMap_2_PrefabGUID_CastleDestroyData_byref_Entity_byref_Entity_byref_DynamicBuffer_1_CastleDestroyRequirementBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1128883, RefRangeEnd = 1128884, XrefRangeStart = 1128867, XrefRangeEnd = 1128883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CharacterMeetsClaimCosts(
      [In] ref EntityManager entityManager,
      [In] ref NativeHashMap<PrefabGUID, CastleClaimData> castleClaimLookup,
      [In] ref Entity castleHeartEntity,
      [In] ref Entity character,
      out DynamicBuffer<CastleClaimRequirementBuffer> requirements)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleClaimLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeartEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref requirements;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleHeartHelpers.NativeMethodInfoPtr_CharacterMeetsClaimCosts_Public_Static_Boolean_byref_EntityManager_byref_NativeHashMap_2_PrefabGUID_CastleClaimData_byref_Entity_byref_Entity_byref_DynamicBuffer_1_CastleClaimRequirementBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1128900, RefRangeEnd = 1128902, XrefRangeStart = 1128884, XrefRangeEnd = 1128900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CharacterMeetsUpgradeCosts(
      [In] ref EntityManager entityManager,
      [In] ref NativeHashMap<PrefabGUID, UpgradeData> upgradeLookup,
      [In] ref Entity castleHeartEntity,
      [In] ref Entity character,
      out DynamicBuffer<UpgradeRequirementBuffer> requirements)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref upgradeLookup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeartEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref requirements;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleHeartHelpers.NativeMethodInfoPtr_CharacterMeetsUpgradeCosts_Public_Static_Boolean_byref_EntityManager_byref_NativeHashMap_2_PrefabGUID_UpgradeData_byref_Entity_byref_Entity_byref_DynamicBuffer_1_UpgradeRequirementBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1128914, RefRangeEnd = 1128916, XrefRangeStart = 1128902, XrefRangeEnd = 1128914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool FulfillsAllRequirements<TRequirement>(
      [In] ref EntityManager entityManager,
      Entity character,
      [In] ref DynamicBuffer<TRequirement> requirements)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref requirements;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleHeartHelpers.MethodInfoStoreGeneric_FulfillsAllRequirements_Public_Static_Boolean_byref_EntityManager_Entity_byref_DynamicBuffer_1_TRequirement_0<TRequirement>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128916, XrefRangeEnd = 1128929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ConsumeRequirements<TRequirement>(
      EntityManager entityManager,
      Entity character,
      DynamicBuffer<TRequirement> requirements)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &character;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &requirements;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleHeartHelpers.MethodInfoStoreGeneric_ConsumeRequirements_Public_Static_Void_EntityManager_Entity_DynamicBuffer_1_TRequirement_0<TRequirement>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleHeartHelpers()
    {
      Il2CppClassPointerStore<CastleHeartHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (CastleHeartHelpers));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleHeartHelpers>.NativeClassPtr);
      CastleHeartHelpers.NativeMethodInfoPtr_GetConnectedTileModels_Public_Static_NativeList_1_Entity_Entity_EntityManager_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartHelpers>.NativeClassPtr, 100689686);
      CastleHeartHelpers.NativeMethodInfoPtr_GetClaimReason_Public_Static_ClaimCastleReason_byref_Pylonstation_byref_Team_byref_ServerGameBalanceSettings_byref_ServerTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartHelpers>.NativeClassPtr, 100689687);
      CastleHeartHelpers.NativeMethodInfoPtr_GetDestroyReason_Public_Static_DestroyCastleReason_byref_Pylonstation_byref_Team_byref_ServerGameBalanceSettings_byref_ServerTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartHelpers>.NativeClassPtr, 100689688);
      CastleHeartHelpers.NativeMethodInfoPtr_GetRaidReason_Public_Static_RaidCastleReason_byref_Pylonstation_byref_CastleHeart_byref_ServerGameBalanceSettings_byref_ServerTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartHelpers>.NativeClassPtr, 100689689);
      CastleHeartHelpers.NativeMethodInfoPtr_CanClaim_Public_Static_Boolean_byref_Pylonstation_byref_Team_byref_ServerGameBalanceSettings_byref_ServerTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartHelpers>.NativeClassPtr, 100689690);
      CastleHeartHelpers.NativeMethodInfoPtr_CanDestroy_Public_Static_Boolean_byref_Pylonstation_byref_Team_byref_ServerGameBalanceSettings_byref_ServerTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartHelpers>.NativeClassPtr, 100689691);
      CastleHeartHelpers.NativeMethodInfoPtr_CanRaid_Public_Static_Boolean_byref_Pylonstation_byref_CastleHeart_byref_ServerGameBalanceSettings_byref_ServerTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartHelpers>.NativeClassPtr, 100689692);
      CastleHeartHelpers.NativeMethodInfoPtr_IsFreeRaid_Public_Static_Boolean_byref_Pylonstation_byref_ServerGameBalanceSettings_byref_ServerTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartHelpers>.NativeClassPtr, 100689693);
      CastleHeartHelpers.NativeMethodInfoPtr_IsFreeClaim_Public_Static_Boolean_byref_Pylonstation_byref_ServerGameBalanceSettings_byref_ServerTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartHelpers>.NativeClassPtr, 100689694);
      CastleHeartHelpers.NativeMethodInfoPtr_IsFreeDestroy_Public_Static_Boolean_byref_Pylonstation_byref_ServerGameBalanceSettings_byref_ServerTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartHelpers>.NativeClassPtr, 100689695);
      CastleHeartHelpers.NativeMethodInfoPtr_GetLevelData_Public_Static_Boolean_byref_Pylonstation_byref_DynamicBuffer_1_TCastleBuffer_byref_NativeHashMap_2_PrefabGUID_TCastleData_byref_TCastleData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartHelpers>.NativeClassPtr, 100689696);
      CastleHeartHelpers.NativeMethodInfoPtr_CharacterMeetsRaidCosts_Public_Static_Boolean_byref_EntityManager_byref_NativeHashMap_2_PrefabGUID_CastleRaidData_byref_Entity_byref_Entity_byref_DynamicBuffer_1_CastleRaidRequirementBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartHelpers>.NativeClassPtr, 100689697);
      CastleHeartHelpers.NativeMethodInfoPtr_CharacterMeetsDestroyCosts_Public_Static_Boolean_byref_EntityManager_byref_NativeHashMap_2_PrefabGUID_CastleDestroyData_byref_Entity_byref_Entity_byref_DynamicBuffer_1_CastleDestroyRequirementBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartHelpers>.NativeClassPtr, 100689698);
      CastleHeartHelpers.NativeMethodInfoPtr_CharacterMeetsClaimCosts_Public_Static_Boolean_byref_EntityManager_byref_NativeHashMap_2_PrefabGUID_CastleClaimData_byref_Entity_byref_Entity_byref_DynamicBuffer_1_CastleClaimRequirementBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartHelpers>.NativeClassPtr, 100689699);
      CastleHeartHelpers.NativeMethodInfoPtr_CharacterMeetsUpgradeCosts_Public_Static_Boolean_byref_EntityManager_byref_NativeHashMap_2_PrefabGUID_UpgradeData_byref_Entity_byref_Entity_byref_DynamicBuffer_1_UpgradeRequirementBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartHelpers>.NativeClassPtr, 100689700);
      CastleHeartHelpers.NativeMethodInfoPtr_FulfillsAllRequirements_Public_Static_Boolean_byref_EntityManager_Entity_byref_DynamicBuffer_1_TRequirement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartHelpers>.NativeClassPtr, 100689701);
      CastleHeartHelpers.NativeMethodInfoPtr_ConsumeRequirements_Public_Static_Void_EntityManager_Entity_DynamicBuffer_1_TRequirement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleHeartHelpers>.NativeClassPtr, 100689702);
    }

    public CastleHeartHelpers(System.IntPtr pointer)
      : base(pointer)
    {
    }

    private sealed class MethodInfoStoreGeneric_GetLevelData_Public_Static_Boolean_byref_Pylonstation_byref_DynamicBuffer_1_TCastleBuffer_byref_NativeHashMap_2_PrefabGUID_TCastleData_byref_TCastleData_Int32_0<TCastleBuffer, TCastleData>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CastleHeartHelpers.NativeMethodInfoPtr_GetLevelData_Public_Static_Boolean_byref_Pylonstation_byref_DynamicBuffer_1_TCastleBuffer_byref_NativeHashMap_2_PrefabGUID_TCastleData_byref_TCastleData_Int32_0, Il2CppClassPointerStore<CastleHeartHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCastleBuffer>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCastleData>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_FulfillsAllRequirements_Public_Static_Boolean_byref_EntityManager_Entity_byref_DynamicBuffer_1_TRequirement_0<TRequirement>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CastleHeartHelpers.NativeMethodInfoPtr_FulfillsAllRequirements_Public_Static_Boolean_byref_EntityManager_Entity_byref_DynamicBuffer_1_TRequirement_0, Il2CppClassPointerStore<CastleHeartHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRequirement>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ConsumeRequirements_Public_Static_Void_EntityManager_Entity_DynamicBuffer_1_TRequirement_0<TRequirement>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CastleHeartHelpers.NativeMethodInfoPtr_ConsumeRequirements_Public_Static_Void_EntityManager_Entity_DynamicBuffer_1_TRequirement_0, Il2CppClassPointerStore<CastleHeartHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRequirement>.NativeClassPtr))
      }))));
    }
  }
}
