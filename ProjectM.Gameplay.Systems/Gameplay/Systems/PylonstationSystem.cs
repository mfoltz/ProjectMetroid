// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Systems.PylonstationSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Gameplay.Systems
{
  public class PylonstationSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__EventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClaimPylonQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__DestroyPylonQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__CastleHeartRaidQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__UpgradePylonQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__DecayCastleQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___ClaimPylonJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ClaimPylonJob_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpgradePylonJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpgradePylonJob_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___DecayCastlesByCommand_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___DecayCastlesByCommand_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessClaimCastleEvents_Private_Void_byref_NativeHashMap_2_NetworkId_Entity_byref_ServerGameBalanceSettings_byref_ServerTime_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClaimCastle_Private_Void_Entity_Pylonstation_CastleHeart_FromCharacter_ControlledBy_byref_ServerTime_byref_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessDestroyCastleEvents_Private_Void_byref_NativeHashMap_2_NetworkId_Entity_byref_ServerGameBalanceSettings_byref_ServerTime_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyCastle_Private_Void_Entity_byref_Pylonstation_byref_FromCharacter_byref_ServerTime_byref_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessRaidCastleEvents_Private_Void_byref_NativeHashMap_2_NetworkId_Entity_byref_ServerGameBalanceSettings_byref_ServerTime_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RaidCastle_Private_Static_Void_Entity_Pylonstation_CastleHeart_byref_ServerGameBalanceSettings_byref_ServerTime_byref_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessUpgradeCastleEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpgradeCastleHeart_Private_Void_Entity_Pylonstation_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessDecayCastleCommands_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAdmin_Private_Boolean_byref_User_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidateHostileCastleAction_Private_Boolean_byref_FromCharacter_byref_Entity_byref_User_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForClaimPylonJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpgradePylonJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDecayCastlesByCommand_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1454885, XrefRangeEnd = 1454959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PylonstationSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1454959, XrefRangeEnd = 1454979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PylonstationSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1455036, RefRangeEnd = 1455037, XrefRangeStart = 1454979, XrefRangeEnd = 1455036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessClaimCastleEvents(
      [In] ref NativeHashMap<NetworkId, Entity> networkIdToEntityMap,
      [In] ref ServerGameBalanceSettings balanceSettings,
      [In] ref ServerTime serverTime,
      bool castleLimitsDisabled,
      bool buildCostsDisabled)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref networkIdToEntityMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref balanceSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &castleLimitsDisabled;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &buildCostsDisabled;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.NativeMethodInfoPtr_ProcessClaimCastleEvents_Private_Void_byref_NativeHashMap_2_NetworkId_Entity_byref_ServerGameBalanceSettings_byref_ServerTime_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1455037, XrefRangeEnd = 1455088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClaimCastle(
      Entity castleHeartEntity,
      Pylonstation pylonstation,
      CastleHeart castleHeart,
      FromCharacter fromCharacter,
      ControlledBy characterUserOwner,
      [In] ref ServerTime serverTime,
      ref EntityCommandBuffer commandBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &castleHeartEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pylonstation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &castleHeart;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &fromCharacter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &characterUserOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref commandBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.NativeMethodInfoPtr_ClaimCastle_Private_Void_Entity_Pylonstation_CastleHeart_FromCharacter_ControlledBy_byref_ServerTime_byref_EntityCommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1455131, RefRangeEnd = 1455132, XrefRangeStart = 1455088, XrefRangeEnd = 1455131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessDestroyCastleEvents(
      [In] ref NativeHashMap<NetworkId, Entity> networkIdToEntityMap,
      [In] ref ServerGameBalanceSettings balanceSettings,
      [In] ref ServerTime serverTime,
      bool buildCostsDisabled)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref networkIdToEntityMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref balanceSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &buildCostsDisabled;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.NativeMethodInfoPtr_ProcessDestroyCastleEvents_Private_Void_byref_NativeHashMap_2_NetworkId_Entity_byref_ServerGameBalanceSettings_byref_ServerTime_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1455172, RefRangeEnd = 1455173, XrefRangeStart = 1455132, XrefRangeEnd = 1455172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DestroyCastle(
      Entity castleHeartEntity,
      [In] ref Pylonstation pylonstation,
      [In] ref FromCharacter fromCharacter,
      [In] ref ServerTime serverTime,
      ref EntityCommandBuffer commandBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &castleHeartEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref pylonstation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref commandBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.NativeMethodInfoPtr_DestroyCastle_Private_Void_Entity_byref_Pylonstation_byref_FromCharacter_byref_ServerTime_byref_EntityCommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1455211, RefRangeEnd = 1455212, XrefRangeStart = 1455173, XrefRangeEnd = 1455211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessRaidCastleEvents(
      [In] ref NativeHashMap<NetworkId, Entity> networkIdToEntityMap,
      [In] ref ServerGameBalanceSettings balanceSettings,
      [In] ref ServerTime serverTime,
      bool buildCostsDisabled)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref networkIdToEntityMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref balanceSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &buildCostsDisabled;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.NativeMethodInfoPtr_ProcessRaidCastleEvents_Private_Void_byref_NativeHashMap_2_NetworkId_Entity_byref_ServerGameBalanceSettings_byref_ServerTime_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1455218, RefRangeEnd = 1455219, XrefRangeStart = 1455212, XrefRangeEnd = 1455218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RaidCastle(
      Entity castleHeartEntity,
      Pylonstation pylonstation,
      CastleHeart castleHeart,
      [In] ref ServerGameBalanceSettings balanceSettings,
      [In] ref ServerTime serverTime,
      ref EntityCommandBuffer commandBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &castleHeartEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pylonstation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &castleHeart;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref balanceSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref commandBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.NativeMethodInfoPtr_RaidCastle_Private_Static_Void_Entity_Pylonstation_CastleHeart_byref_ServerGameBalanceSettings_byref_ServerTime_byref_EntityCommandBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1455231, RefRangeEnd = 1455232, XrefRangeStart = 1455219, XrefRangeEnd = 1455231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessUpgradeCastleEvents(
      NativeHashMap<NetworkId, Entity> networkIdToEntityMap,
      bool buildCostsDisabled)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &networkIdToEntityMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &buildCostsDisabled;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.NativeMethodInfoPtr_ProcessUpgradeCastleEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1455295, RefRangeEnd = 1455296, XrefRangeStart = 1455232, XrefRangeEnd = 1455295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpgradeCastleHeart(Entity castleHeartEntity, Pylonstation pylonstation)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &castleHeartEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pylonstation;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.NativeMethodInfoPtr_UpgradeCastleHeart_Private_Void_Entity_Pylonstation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1455314, RefRangeEnd = 1455315, XrefRangeStart = 1455296, XrefRangeEnd = 1455314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessDecayCastleCommands()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.NativeMethodInfoPtr_ProcessDecayCastleCommands_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1455318, RefRangeEnd = 1455320, XrefRangeStart = 1455315, XrefRangeEnd = 1455318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsAdmin([In] ref User user)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref user;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.NativeMethodInfoPtr_IsAdmin_Private_Boolean_byref_User_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1455346, RefRangeEnd = 1455347, XrefRangeStart = 1455320, XrefRangeEnd = 1455346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ValidateHostileCastleAction(
      [In] ref FromCharacter fromCharacter,
      [In] ref Entity castleHeartEntity,
      [In] ref User user)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref fromCharacter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeartEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.NativeMethodInfoPtr_ValidateHostileCastleAction_Private_Boolean_byref_FromCharacter_byref_Entity_byref_User_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PylonstationSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1455347, XrefRangeEnd = 1455427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PylonstationSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1455427, XrefRangeEnd = 1455446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForClaimPylonJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.NativeMethodInfoPtr___GetEntityQuery_ForClaimPylonJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1455446, XrefRangeEnd = 1455465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpgradePylonJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpgradePylonJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1455465, XrefRangeEnd = 1455484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForDecayCastlesByCommand_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.NativeMethodInfoPtr___GetEntityQuery_ForDecayCastlesByCommand_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1455488, RefRangeEnd = 1455489, XrefRangeStart = 1455484, XrefRangeEnd = 1455488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PylonstationSystem()
    {
      Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay.Systems", nameof (PylonstationSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr);
      PylonstationSystem.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, nameof (_GameDataSystem));
      PylonstationSystem.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, nameof (_NetworkIdSystem));
      PylonstationSystem.NativeFieldInfoPtr__EventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, nameof (_EventQuery));
      PylonstationSystem.NativeFieldInfoPtr__ClaimPylonQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, nameof (_ClaimPylonQuery));
      PylonstationSystem.NativeFieldInfoPtr__DestroyPylonQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, nameof (_DestroyPylonQuery));
      PylonstationSystem.NativeFieldInfoPtr__CastleHeartRaidQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, nameof (_CastleHeartRaidQuery));
      PylonstationSystem.NativeFieldInfoPtr__UpgradePylonQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, nameof (_UpgradePylonQuery));
      PylonstationSystem.NativeFieldInfoPtr__DecayCastleQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, nameof (_DecayCastleQuery));
      PylonstationSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      PylonstationSystem.NativeFieldInfoPtr___ClaimPylonJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, "<>ClaimPylonJob_entityQuery");
      PylonstationSystem.NativeFieldInfoPtr___ClaimPylonJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, "<>ClaimPylonJob_profilerMarker");
      PylonstationSystem.NativeFieldInfoPtr___UpgradePylonJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, "<>UpgradePylonJob_entityQuery");
      PylonstationSystem.NativeFieldInfoPtr___UpgradePylonJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, "<>UpgradePylonJob_profilerMarker");
      PylonstationSystem.NativeFieldInfoPtr___DecayCastlesByCommand_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, "<>DecayCastlesByCommand_entityQuery");
      PylonstationSystem.NativeFieldInfoPtr___DecayCastlesByCommand_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, "<>DecayCastlesByCommand_profilerMarker");
      PylonstationSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, 100673063);
      PylonstationSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, 100673064);
      PylonstationSystem.NativeMethodInfoPtr_ProcessClaimCastleEvents_Private_Void_byref_NativeHashMap_2_NetworkId_Entity_byref_ServerGameBalanceSettings_byref_ServerTime_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, 100673065);
      PylonstationSystem.NativeMethodInfoPtr_ClaimCastle_Private_Void_Entity_Pylonstation_CastleHeart_FromCharacter_ControlledBy_byref_ServerTime_byref_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, 100673066);
      PylonstationSystem.NativeMethodInfoPtr_ProcessDestroyCastleEvents_Private_Void_byref_NativeHashMap_2_NetworkId_Entity_byref_ServerGameBalanceSettings_byref_ServerTime_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, 100673067);
      PylonstationSystem.NativeMethodInfoPtr_DestroyCastle_Private_Void_Entity_byref_Pylonstation_byref_FromCharacter_byref_ServerTime_byref_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, 100673068);
      PylonstationSystem.NativeMethodInfoPtr_ProcessRaidCastleEvents_Private_Void_byref_NativeHashMap_2_NetworkId_Entity_byref_ServerGameBalanceSettings_byref_ServerTime_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, 100673069);
      PylonstationSystem.NativeMethodInfoPtr_RaidCastle_Private_Static_Void_Entity_Pylonstation_CastleHeart_byref_ServerGameBalanceSettings_byref_ServerTime_byref_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, 100673070);
      PylonstationSystem.NativeMethodInfoPtr_ProcessUpgradeCastleEvents_Private_Void_NativeHashMap_2_NetworkId_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, 100673071);
      PylonstationSystem.NativeMethodInfoPtr_UpgradeCastleHeart_Private_Void_Entity_Pylonstation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, 100673072);
      PylonstationSystem.NativeMethodInfoPtr_ProcessDecayCastleCommands_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, 100673073);
      PylonstationSystem.NativeMethodInfoPtr_IsAdmin_Private_Boolean_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, 100673074);
      PylonstationSystem.NativeMethodInfoPtr_ValidateHostileCastleAction_Private_Boolean_byref_FromCharacter_byref_Entity_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, 100673075);
      PylonstationSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, 100673076);
      PylonstationSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, 100673077);
      PylonstationSystem.NativeMethodInfoPtr___GetEntityQuery_ForClaimPylonJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, 100673078);
      PylonstationSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpgradePylonJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, 100673079);
      PylonstationSystem.NativeMethodInfoPtr___GetEntityQuery_ForDecayCastlesByCommand_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, 100673080);
      PylonstationSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, 100673081);
    }

    public PylonstationSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == System.IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _EventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr__EventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr__EventQuery)) = value;
      }
    }

    public unsafe EntityQuery _ClaimPylonQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr__ClaimPylonQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr__ClaimPylonQuery)) = value;
      }
    }

    public unsafe EntityQuery _DestroyPylonQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr__DestroyPylonQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr__DestroyPylonQuery)) = value;
      }
    }

    public unsafe EntityQuery _CastleHeartRaidQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr__CastleHeartRaidQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr__CastleHeartRaidQuery)) = value;
      }
    }

    public unsafe EntityQuery _UpgradePylonQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr__UpgradePylonQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr__UpgradePylonQuery)) = value;
      }
    }

    public unsafe EntityQuery _DecayCastleQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr__DecayCastleQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr__DecayCastleQuery)) = value;
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __ClaimPylonJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr___ClaimPylonJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr___ClaimPylonJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ClaimPylonJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr___ClaimPylonJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr___ClaimPylonJob_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpgradePylonJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr___UpgradePylonJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr___UpgradePylonJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpgradePylonJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr___UpgradePylonJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr___UpgradePylonJob_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __DecayCastlesByCommand_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr___DecayCastlesByCommand_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr___DecayCastlesByCommand_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __DecayCastlesByCommand_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr___DecayCastlesByCommand_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.NativeFieldInfoPtr___DecayCastlesByCommand_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationSystem/<>c__DisplayClass12_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass12_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_castleHeartEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_characterUserOwner;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ClaimCastle_b__0_Internal_Void_Entity_byref_UserOwner_byref_CastleHeartConnection_0;
      [FieldOffset(0)]
      public Entity castleHeartEntity;
      [FieldOffset(8)]
      public ControlledBy characterUserOwner;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass12_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ClaimCastle_b__0(
        Entity entity,
        ref UserOwner tileModelUserOwner,
        [In] ref CastleHeartConnection heartConnection)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileModelUserOwner;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref heartConnection;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__ClaimCastle_b__0_Internal_Void_Entity_byref_UserOwner_byref_CastleHeartConnection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass12_0()
      {
        Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, "<>c__DisplayClass12_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass12_0>.NativeClassPtr);
        PylonstationSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_castleHeartEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (castleHeartEntity));
        PylonstationSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_characterUserOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (characterUserOwner));
        PylonstationSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass12_0>.NativeClassPtr, 100673082);
        PylonstationSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__ClaimCastle_b__0_Internal_Void_Entity_byref_UserOwner_byref_CastleHeartConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass12_0>.NativeClassPtr, 100673083);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass12_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationSystem/<>c__DisplayClass17_0")]
    public sealed class __c__DisplayClass17_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_buildCostsDisabled;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ProcessUpgradeCastleEvents_b__0_Internal_Void_Entity_byref_UpgradePylonEvent_byref_FromCharacter_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass17_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass17_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ProcessUpgradeCastleEvents_b__0(
        Entity entity,
        [In] ref UpgradePylonEvent upgradeEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref upgradeEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass17_0.NativeMethodInfoPtr__ProcessUpgradeCastleEvents_b__0_Internal_Void_Entity_byref_UpgradePylonEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass17_0()
      {
        Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, "<>c__DisplayClass17_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass17_0>.NativeClassPtr);
        PylonstationSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (networkIdToEntityMap));
        PylonstationSystem.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
        PylonstationSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_buildCostsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass17_0>.NativeClassPtr, nameof (buildCostsDisabled));
        PylonstationSystem.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass17_0>.NativeClassPtr, 100673084);
        PylonstationSystem.__c__DisplayClass17_0.NativeMethodInfoPtr__ProcessUpgradeCastleEvents_b__0_Internal_Void_Entity_byref_UpgradePylonEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass17_0>.NativeClassPtr, 100673085);
      }

      public __c__DisplayClass17_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass17_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass17_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass17_0>.NativeClassPtr, data));
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe PylonstationSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PylonstationSystem) null : new PylonstationSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool buildCostsDisabled
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_buildCostsDisabled));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass17_0.NativeFieldInfoPtr_buildCostsDisabled)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationSystem/<>c__DisplayClass19_0")]
    public sealed class __c__DisplayClass19_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_bloodGUID;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass19_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass19_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass19_0()
      {
        Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, "<>c__DisplayClass19_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass19_0>.NativeClassPtr);
        PylonstationSystem.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass19_0>.NativeClassPtr, "<>4__this");
        PylonstationSystem.__c__DisplayClass19_0.NativeFieldInfoPtr_bloodGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass19_0>.NativeClassPtr, nameof (bloodGUID));
        PylonstationSystem.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass19_0>.NativeClassPtr, 100673086);
      }

      public __c__DisplayClass19_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass19_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass19_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass19_0>.NativeClassPtr, data));
      }

      public unsafe PylonstationSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PylonstationSystem) null : new PylonstationSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabGUID bloodGUID
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass19_0.NativeFieldInfoPtr_bloodGUID));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass19_0.NativeFieldInfoPtr_bloodGUID)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationSystem/<>c__DisplayClass19_1")]
    public sealed class __c__DisplayClass19_1 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_decayEvent;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ProcessDecayCastleCommands_b__0_Internal_Void_Entity_byref_Pylonstation_byref_UserOwner_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass19_1()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass19_1>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass19_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _ProcessDecayCastleCommands_b__0(
        Entity entity,
        ref Pylonstation station,
        [In] ref UserOwner userOwner)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref station;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref userOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass19_1.NativeMethodInfoPtr__ProcessDecayCastleCommands_b__0_Internal_Void_Entity_byref_Pylonstation_byref_UserOwner_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass19_1()
      {
        Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass19_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, "<>c__DisplayClass19_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass19_1>.NativeClassPtr);
        PylonstationSystem.__c__DisplayClass19_1.NativeFieldInfoPtr_decayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass19_1>.NativeClassPtr, nameof (decayEvent));
        PylonstationSystem.__c__DisplayClass19_1.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass19_1>.NativeClassPtr, "CS$<>8__locals1");
        PylonstationSystem.__c__DisplayClass19_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass19_1>.NativeClassPtr, 100673087);
        PylonstationSystem.__c__DisplayClass19_1.NativeMethodInfoPtr__ProcessDecayCastleCommands_b__0_Internal_Void_Entity_byref_Pylonstation_byref_UserOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass19_1>.NativeClassPtr, 100673088);
      }

      public __c__DisplayClass19_1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass19_1()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass19_1>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass19_1>.NativeClassPtr, data));
      }

      public unsafe DecayEvent decayEvent
      {
        get
        {
          return *(DecayEvent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass19_1.NativeFieldInfoPtr_decayEvent));
        }
        [param: In] set
        {
          *(DecayEvent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass19_1.NativeFieldInfoPtr_decayEvent)) = value;
        }
      }

      public PylonstationSystem.__c__DisplayClass19_0 field_Public___c__DisplayClass19_0_0
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass19_1.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0);
          return new PylonstationSystem.__c__DisplayClass19_0(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass19_0>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass19_1.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass19_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ClaimPylonJob")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ClaimPylonJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_castleHeartEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_characterUserOwner;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UserOwner_byref_CastleHeartConnection_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationSystem_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public Entity castleHeartEntity;
      [FieldOffset(8)]
      public ControlledBy characterUserOwner;
      [FieldOffset(16)]
      public PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1454735, XrefRangeEnd = 1454740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref UserOwner tileModelUserOwner,
        [In] ref CastleHeartConnection heartConnection)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileModelUserOwner;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref heartConnection;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UserOwner_byref_CastleHeartConnection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 1074195, RefRangeEnd = 1074202, XrefRangeStart = 1074195, XrefRangeEnd = 1074202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PylonstationSystem.__c__DisplayClass12_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 1074202, RefRangeEnd = 1074209, XrefRangeStart = 1074202, XrefRangeEnd = 1074209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PylonstationSystem.__c__DisplayClass12_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1454740, XrefRangeEnd = 1454742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1454751, RefRangeEnd = 1454752, XrefRangeStart = 1454742, XrefRangeEnd = 1454751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1454754, RefRangeEnd = 1454755, XrefRangeStart = 1454752, XrefRangeEnd = 1454754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PylonstationSystem componentSystem,
        ref PylonstationSystem.__c__DisplayClass12_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationSystem_byref___c__DisplayClass12_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1454755, XrefRangeEnd = 1454759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1454759, XrefRangeEnd = 1454765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ClaimPylonJob()
      {
        Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, "<>c__DisplayClass_ClaimPylonJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob>.NativeClassPtr);
        PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeFieldInfoPtr_castleHeartEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob>.NativeClassPtr, nameof (castleHeartEntity));
        PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeFieldInfoPtr_characterUserOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob>.NativeClassPtr, nameof (characterUserOwner));
        PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob>.NativeClassPtr, nameof (_runtimes));
        PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UserOwner_byref_CastleHeartConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob>.NativeClassPtr, 100673089);
        PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob>.NativeClassPtr, 100673090);
        PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob>.NativeClassPtr, 100673091);
        PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob>.NativeClassPtr, 100673092);
        PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob>.NativeClassPtr, 100673093);
        PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationSystem_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob>.NativeClassPtr, 100673094);
        PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob>.NativeClassPtr, 100673095);
        PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob>.NativeClassPtr, 100673096);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_tileModelUserOwner;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_heartConnection;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<UserOwner> forParameter_tileModelUserOwner;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<CastleHeartConnection> forParameter_heartConnection;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1454651, RefRangeEnd = 1454652, XrefRangeStart = 1454644, XrefRangeEnd = 1454651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PylonstationSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1454659, RefRangeEnd = 1454660, XrefRangeStart = 1454652, XrefRangeEnd = 1454659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_tileModelUserOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_tileModelUserOwner));
          PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_heartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_heartConnection));
          PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders>.NativeClassPtr, 100673097);
          PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders>.NativeClassPtr, 100673098);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_tileModelUserOwner;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_heartConnection;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<UserOwner>.Runtime runtime_tileModelUserOwner;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<CastleHeartConnection>.Runtime runtime_heartConnection;

          static Runtimes()
          {
            Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_tileModelUserOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_tileModelUserOwner));
            PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_heartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_heartConnection));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ClaimPylonJob/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001773$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob>.NativeClassPtr, "RunWithoutJobSystem_00001773$PostfixBurstDelegate");
          PylonstationSystem.__c__DisplayClass_ClaimPylonJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673099);
          PylonstationSystem.__c__DisplayClass_ClaimPylonJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673100);
          PylonstationSystem.__c__DisplayClass_ClaimPylonJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673101);
          PylonstationSystem.__c__DisplayClass_ClaimPylonJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100673102);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_ClaimPylonJob/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001773$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1454660, XrefRangeEnd = 1454674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1454674, XrefRangeEnd = 1454692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1454692, XrefRangeEnd = 1454707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1454734, RefRangeEnd = 1454735, XrefRangeStart = 1454707, XrefRangeEnd = 1454734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob>.NativeClassPtr, "RunWithoutJobSystem_00001773$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673103);
          PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673104);
          PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673105);
          PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673106);
          PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100673108);
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
            IL2CPP.il2cpp_field_static_get_value(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(PylonstationSystem.__c__DisplayClass_ClaimPylonJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_UpgradePylonJob")]
    public sealed class __c__DisplayClass_UpgradePylonJob : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_buildCostsDisabled;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UpgradePylonEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationSystem_byref___c__DisplayClass17_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1454803, RefRangeEnd = 1454804, XrefRangeStart = 1454781, XrefRangeEnd = 1454803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref UpgradePylonEvent upgradeEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref upgradeEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UpgradePylonEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1454804, XrefRangeEnd = 1454805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PylonstationSystem.__c__DisplayClass17_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1454806, RefRangeEnd = 1454807, XrefRangeStart = 1454805, XrefRangeEnd = 1454806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PylonstationSystem.__c__DisplayClass17_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1454807, XrefRangeEnd = 1454821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1454827, RefRangeEnd = 1454828, XrefRangeStart = 1454821, XrefRangeEnd = 1454827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1454829, RefRangeEnd = 1454830, XrefRangeStart = 1454828, XrefRangeEnd = 1454829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PylonstationSystem componentSystem,
        ref PylonstationSystem.__c__DisplayClass17_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationSystem_byref___c__DisplayClass17_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpgradePylonJob()
      {
        Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, "<>c__DisplayClass_UpgradePylonJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob>.NativeClassPtr);
        PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob>.NativeClassPtr, nameof (networkIdToEntityMap));
        PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob>.NativeClassPtr, "<>4__this");
        PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeFieldInfoPtr_buildCostsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob>.NativeClassPtr, nameof (buildCostsDisabled));
        PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob>.NativeClassPtr, nameof (_runtimes));
        PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob>.NativeClassPtr, nameof (_performLambdaDelegate));
        PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UpgradePylonEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob>.NativeClassPtr, 100673109);
        PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob>.NativeClassPtr, 100673110);
        PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob>.NativeClassPtr, 100673111);
        PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob>.NativeClassPtr, 100673113);
        PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob>.NativeClassPtr, 100673114);
        PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationSystem_byref___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob>.NativeClassPtr, 100673115);
      }

      public __c__DisplayClass_UpgradePylonJob(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_UpgradePylonJob()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob>.NativeClassPtr, data));
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe PylonstationSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PylonstationSystem) null : new PylonstationSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool buildCostsDisabled
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeFieldInfoPtr_buildCostsDisabled));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeFieldInfoPtr_buildCostsDisabled)) = value;
        }
      }

      public unsafe PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PylonstationSystem.__c__DisplayClass_UpgradePylonJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_upgradeEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<UpgradePylonEvent> forParameter_upgradeEvent;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1454765, XrefRangeEnd = 1454772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PylonstationSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1454780, RefRangeEnd = 1454781, XrefRangeStart = 1454772, XrefRangeEnd = 1454780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_upgradeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_upgradeEvent));
          PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders>.NativeClassPtr, 100673116);
          PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders>.NativeClassPtr, 100673117);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_upgradeEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<UpgradePylonEvent>.StructuralChangeRuntime runtime_upgradeEvent;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.StructuralChangeRuntime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_upgradeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_upgradeEvent));
            PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_UpgradePylonJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.PylonstationSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_DecayCastlesByCommand")]
    public sealed class __c__DisplayClass_DecayCastlesByCommand : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_decayEvent;
      private static readonly System.IntPtr NativeFieldInfoPtr_bloodGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Pylonstation_byref_UserOwner_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass19_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass19_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationSystem_byref___c__DisplayClass19_1_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1454855, RefRangeEnd = 1454856, XrefRangeStart = 1454846, XrefRangeEnd = 1454855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref Pylonstation station,
        [In] ref UserOwner userOwner)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref station;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref userOwner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Pylonstation_byref_UserOwner_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1454856, XrefRangeEnd = 1454857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PylonstationSystem.__c__DisplayClass19_1 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass19_1_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1454858, RefRangeEnd = 1454859, XrefRangeStart = 1454857, XrefRangeEnd = 1454858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PylonstationSystem.__c__DisplayClass19_1 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass19_1_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1454859, XrefRangeEnd = 1454876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1454882, RefRangeEnd = 1454883, XrefRangeStart = 1454876, XrefRangeEnd = 1454882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1454884, RefRangeEnd = 1454885, XrefRangeStart = 1454883, XrefRangeEnd = 1454884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PylonstationSystem componentSystem,
        ref PylonstationSystem.__c__DisplayClass19_1 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationSystem_byref___c__DisplayClass19_1_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DecayCastlesByCommand()
      {
        Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationSystem>.NativeClassPtr, "<>c__DisplayClass_DecayCastlesByCommand");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand>.NativeClassPtr);
        PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand>.NativeClassPtr, "<>4__this");
        PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeFieldInfoPtr_decayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand>.NativeClassPtr, nameof (decayEvent));
        PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeFieldInfoPtr_bloodGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand>.NativeClassPtr, nameof (bloodGUID));
        PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand>.NativeClassPtr, nameof (_runtimes));
        PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand>.NativeClassPtr, nameof (_performLambdaDelegate));
        PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Pylonstation_byref_UserOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand>.NativeClassPtr, 100673118);
        PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass19_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand>.NativeClassPtr, 100673119);
        PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass19_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand>.NativeClassPtr, 100673120);
        PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand>.NativeClassPtr, 100673122);
        PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand>.NativeClassPtr, 100673123);
        PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationSystem_byref___c__DisplayClass19_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand>.NativeClassPtr, 100673124);
      }

      public __c__DisplayClass_DecayCastlesByCommand(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_DecayCastlesByCommand()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand>.NativeClassPtr, data));
      }

      public unsafe PylonstationSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PylonstationSystem) null : new PylonstationSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe DecayEvent decayEvent
      {
        get
        {
          return *(DecayEvent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeFieldInfoPtr_decayEvent));
        }
        [param: In] set
        {
          *(DecayEvent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeFieldInfoPtr_decayEvent)) = value;
        }
      }

      public unsafe PrefabGUID bloodGUID
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeFieldInfoPtr_bloodGUID));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeFieldInfoPtr_bloodGUID)) = value;
        }
      }

      public unsafe PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_station;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_userOwner;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Pylonstation> forParameter_station;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<UserOwner> forParameter_userOwner;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1454830, XrefRangeEnd = 1454837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PylonstationSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1454845, RefRangeEnd = 1454846, XrefRangeStart = 1454837, XrefRangeEnd = 1454845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_station));
          PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_userOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_userOwner));
          PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PylonstationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders>.NativeClassPtr, 100673125);
          PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders>.NativeClassPtr, 100673126);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_station;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_userOwner;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<Pylonstation>.StructuralChangeRuntime runtime_station;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<UserOwner>.StructuralChangeRuntime runtime_userOwner;

          static Runtimes()
          {
            Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_station));
            PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_userOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_userOwner));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonstationSystem.__c__DisplayClass_DecayCastlesByCommand.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
