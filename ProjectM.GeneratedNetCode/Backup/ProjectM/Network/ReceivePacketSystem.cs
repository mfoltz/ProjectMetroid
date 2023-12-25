// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.ReceivePacketSystem
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;

#nullable disable
namespace ProjectM.Network
{
  public class ReceivePacketSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CopySnapshotsToEntitiesSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpellModSyncSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CreateEntitiesQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReceivePacketQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__WeakRefTracker;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkIndexToNetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr__EntitiesToSpawn;
    private static readonly System.IntPtr NativeFieldInfoPtr__EntitiesToDestroy;
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr__Dependency;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ClientNetworkState_5;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetWeakRefTracker_Internal_WeakRefTracker_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNetworkIndexToNetworkId_Internal_NativeHashMap_2_Int32_NetworkId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadEntityHeader_Private_Static_EntityHeader_byref_NetBufferIn_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResetDependency_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddDependency_Public_Void_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateEntities_Private_Void_Int32_NativeHashMap_2_NetworkId_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyEntities_Private_Void_NativeHashMap_2_NetworkId_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupJob_Private_Void_byref_JobParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateToggleDisabledEvent_Private_Static_Void_Entity_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertPrefabsOnDemand_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SpawnNewEntities_Private_Void_NativeHashMap_2_NetworkId_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    public unsafe WeakRefTracker GetWeakRefTracker()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReceivePacketSystem.NativeMethodInfoPtr_GetWeakRefTracker_Internal_WeakRefTracker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(WeakRefTracker*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe NativeHashMap<int, NetworkId> GetNetworkIndexToNetworkId()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReceivePacketSystem.NativeMethodInfoPtr_GetNetworkIndexToNetworkId_Internal_NativeHashMap_2_Int32_NetworkId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeHashMap<int, NetworkId>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1520846, RefRangeEnd = 1520848, XrefRangeStart = 1520834, XrefRangeEnd = 1520846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ReceivePacketSystem.EntityHeader ReadEntityHeader(ref NetBufferIn netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReceivePacketSystem.NativeMethodInfoPtr_ReadEntityHeader_Private_Static_EntityHeader_byref_NetBufferIn_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ReceivePacketSystem.EntityHeader*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1520849, RefRangeEnd = 1520850, XrefRangeStart = 1520848, XrefRangeEnd = 1520849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ResetDependency()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReceivePacketSystem.NativeMethodInfoPtr_ResetDependency_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1520851, RefRangeEnd = 1520852, XrefRangeStart = 1520850, XrefRangeEnd = 1520851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddDependency(JobHandle dependency)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &dependency;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReceivePacketSystem.NativeMethodInfoPtr_AddDependency_Public_Void_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1520852, XrefRangeEnd = 1520909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReceivePacketSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1520909, XrefRangeEnd = 1520923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReceivePacketSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1520923, XrefRangeEnd = 1520964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReceivePacketSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1521005, RefRangeEnd = 1521006, XrefRangeStart = 1520964, XrefRangeEnd = 1521005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateEntities(
      int currentFrame,
      NativeHashMap<NetworkId, Entity> networkEntityMap)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &currentFrame;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &networkEntityMap;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReceivePacketSystem.NativeMethodInfoPtr_CreateEntities_Private_Void_Int32_NativeHashMap_2_NetworkId_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1521058, RefRangeEnd = 1521059, XrefRangeStart = 1521006, XrefRangeEnd = 1521058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DestroyEntities(
      NativeHashMap<NetworkId, Entity> networkedIdToEntityMap)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &networkedIdToEntityMap;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReceivePacketSystem.NativeMethodInfoPtr_DestroyEntities_Private_Void_NativeHashMap_2_NetworkId_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1521182, RefRangeEnd = 1521183, XrefRangeStart = 1521059, XrefRangeEnd = 1521182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupJob(
      ref ReceivePacketSystem.ReceivePacketJob.JobParams receivePacketJob)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref receivePacketJob;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReceivePacketSystem.NativeMethodInfoPtr_SetupJob_Private_Void_byref_JobParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1521187, RefRangeEnd = 1521189, XrefRangeStart = 1521183, XrefRangeEnd = 1521187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateToggleDisabledEvent(
      Entity entity,
      EntityCommandBuffer commandBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReceivePacketSystem.NativeMethodInfoPtr_CreateToggleDisabledEvent_Private_Static_Void_Entity_EntityCommandBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ConvertPrefabsOnDemand()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReceivePacketSystem.NativeMethodInfoPtr_ConvertPrefabsOnDemand_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1521241, RefRangeEnd = 1521242, XrefRangeStart = 1521189, XrefRangeEnd = 1521241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SpawnNewEntities(NativeHashMap<NetworkId, Entity> networkEntityMap)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &networkEntityMap;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReceivePacketSystem.NativeMethodInfoPtr_SpawnNewEntities_Private_Void_NativeHashMap_2_NetworkId_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ReceivePacketSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReceivePacketSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1521242, XrefRangeEnd = 1521250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReceivePacketSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ReceivePacketSystem()
    {
      Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (ReceivePacketSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr);
      ReceivePacketSystem.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, nameof (_NetworkIdSystem));
      ReceivePacketSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      ReceivePacketSystem.NativeFieldInfoPtr__CopySnapshotsToEntitiesSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, nameof (_CopySnapshotsToEntitiesSystem));
      ReceivePacketSystem.NativeFieldInfoPtr__SpellModSyncSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, nameof (_SpellModSyncSystem));
      ReceivePacketSystem.NativeFieldInfoPtr__CreateEntitiesQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, nameof (_CreateEntitiesQuery));
      ReceivePacketSystem.NativeFieldInfoPtr__ReceivePacketQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, nameof (_ReceivePacketQuery));
      ReceivePacketSystem.NativeFieldInfoPtr__WeakRefTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, nameof (_WeakRefTracker));
      ReceivePacketSystem.NativeFieldInfoPtr__NetworkIndexToNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, nameof (_NetworkIndexToNetworkId));
      ReceivePacketSystem.NativeFieldInfoPtr__EntitiesToSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, nameof (_EntitiesToSpawn));
      ReceivePacketSystem.NativeFieldInfoPtr__EntitiesToDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, nameof (_EntitiesToDestroy));
      ReceivePacketSystem.NativeFieldInfoPtr__WorldFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, nameof (_WorldFrame));
      ReceivePacketSystem.NativeFieldInfoPtr__Dependency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, nameof (_Dependency));
      ReceivePacketSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientNetworkState_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ClientNetworkState_5));
      ReceivePacketSystem.NativeMethodInfoPtr_GetWeakRefTracker_Internal_WeakRefTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, 100664098);
      ReceivePacketSystem.NativeMethodInfoPtr_GetNetworkIndexToNetworkId_Internal_NativeHashMap_2_Int32_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, 100664099);
      ReceivePacketSystem.NativeMethodInfoPtr_ReadEntityHeader_Private_Static_EntityHeader_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, 100664100);
      ReceivePacketSystem.NativeMethodInfoPtr_ResetDependency_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, 100664101);
      ReceivePacketSystem.NativeMethodInfoPtr_AddDependency_Public_Void_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, 100664102);
      ReceivePacketSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, 100664103);
      ReceivePacketSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, 100664104);
      ReceivePacketSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, 100664105);
      ReceivePacketSystem.NativeMethodInfoPtr_CreateEntities_Private_Void_Int32_NativeHashMap_2_NetworkId_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, 100664106);
      ReceivePacketSystem.NativeMethodInfoPtr_DestroyEntities_Private_Void_NativeHashMap_2_NetworkId_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, 100664107);
      ReceivePacketSystem.NativeMethodInfoPtr_SetupJob_Private_Void_byref_JobParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, 100664108);
      ReceivePacketSystem.NativeMethodInfoPtr_CreateToggleDisabledEvent_Private_Static_Void_Entity_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, 100664109);
      ReceivePacketSystem.NativeMethodInfoPtr_ConvertPrefabsOnDemand_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, 100664110);
      ReceivePacketSystem.NativeMethodInfoPtr_SpawnNewEntities_Private_Void_NativeHashMap_2_NetworkId_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, 100664111);
      ReceivePacketSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, 100664112);
      ReceivePacketSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, 100664113);
    }

    public ReceivePacketSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == System.IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CopySnapshotsToEntitiesSystem _CopySnapshotsToEntitiesSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__CopySnapshotsToEntitiesSystem));
        return pointer == System.IntPtr.Zero ? (CopySnapshotsToEntitiesSystem) null : new CopySnapshotsToEntitiesSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__CopySnapshotsToEntitiesSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellModSyncSystem_Client _SpellModSyncSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__SpellModSyncSystem));
        return pointer == System.IntPtr.Zero ? (SpellModSyncSystem_Client) null : new SpellModSyncSystem_Client(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__SpellModSyncSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _CreateEntitiesQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__CreateEntitiesQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__CreateEntitiesQuery)) = value;
      }
    }

    public unsafe EntityQuery _ReceivePacketQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__ReceivePacketQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__ReceivePacketQuery)) = value;
      }
    }

    public unsafe WeakRefTracker _WeakRefTracker
    {
      get
      {
        return *(WeakRefTracker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__WeakRefTracker));
      }
      [param: In] set
      {
        *(WeakRefTracker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__WeakRefTracker)) = value;
      }
    }

    public unsafe NativeHashMap<int, NetworkId> _NetworkIndexToNetworkId
    {
      get
      {
        return *(NativeHashMap<int, NetworkId>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__NetworkIndexToNetworkId));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__NetworkIndexToNetworkId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, NetworkId>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<ReceivePacketSystem.EntityToSpawn> _EntitiesToSpawn
    {
      get
      {
        return *(NativeList<ReceivePacketSystem.EntityToSpawn>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__EntitiesToSpawn));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__EntitiesToSpawn), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ReceivePacketSystem.EntityToSpawn>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<ReceivePacketSystem.EntityToDestroy> _EntitiesToDestroy
    {
      get
      {
        return *(NativeList<ReceivePacketSystem.EntityToDestroy>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__EntitiesToDestroy));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__EntitiesToDestroy), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ReceivePacketSystem.EntityToDestroy>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<WorldFrame> _WorldFrame
    {
      get
      {
        return *(SingletonAccessor<WorldFrame>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__WorldFrame));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__WorldFrame), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<WorldFrame>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe JobHandleManager _Dependency
    {
      get
      {
        return *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__Dependency));
      }
      [param: In] set
      {
        *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__Dependency)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ClientNetworkState_5
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientNetworkState_5));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReceivePacketSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientNetworkState_5)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ReceivePacketJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TimeNow;
      private static readonly System.IntPtr NativeFieldInfoPtr_CurrentFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr_Params;
      private static readonly System.IntPtr NativeFieldInfoPtr_ReceivedPacketBufferType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ReceivedPacketType;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedIndexToNetworkIdMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetNetworkSnapshot;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetNetworkSnapshotState;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetNetworkedTimeout;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetNetworked;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetPrefabGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;
      private static readonly System.IntPtr NativeFieldInfoPtr_WeakRefTracker;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetNetSnapshot;
      private static readonly System.IntPtr NativeFieldInfoPtr_CopySnapshotsFromTheseEntities;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReceivePacket_Private_Void_byref_ReceivedPacket_DynamicBuffer_1_ReceivedPacketBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeEntity_Private_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
      [FieldOffset(0)]
      public double TimeNow;
      [FieldOffset(8)]
      public int CurrentFrame;
      [FieldOffset(16)]
      public ReceivePacketSystem.ReceivePacketJob.JobParams Params;
      [FieldOffset(1656)]
      public BufferTypeHandle<ReceivedPacketBuffer> ReceivedPacketBufferType;
      [FieldOffset(1696)]
      public ComponentTypeHandle<ReceivedPacket> ReceivedPacketType;
      [FieldOffset(1728)]
      public NativeHashMap<NetworkId, Entity> NetworkedIdToEntityMap;
      [FieldOffset(1744)]
      public NativeHashMap<int, NetworkId> NetworkedIndexToNetworkIdMap;
      [FieldOffset(1760)]
      public ComponentDataFromEntity<NetworkSnapshot> GetNetworkSnapshot;
      [FieldOffset(1792)]
      public ComponentDataFromEntity<ClientNetworkSnapshotState> GetNetworkSnapshotState;
      [FieldOffset(1824)]
      public ComponentDataFromEntity<NetworkedTimeout> GetNetworkedTimeout;
      [FieldOffset(1856)]
      public ComponentDataFromEntity<Networked> GetNetworked;
      [FieldOffset(1888)]
      public ComponentDataFromEntity<PrefabGUID> GetPrefabGUID;
      [FieldOffset(1920)]
      public SyncRegistry_Client<SpellModSet> SpellMods;
      [FieldOffset(1952)]
      public WeakRefTracker WeakRefTracker;
      [FieldOffset(2008)]
      public BufferFromEntity<NetSnapshot> GetNetSnapshot;
      [FieldOffset(2048)]
      public NativeHashSet<Entity> CopySnapshotsFromTheseEntities;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1514737, XrefRangeEnd = 1514749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ReceivePacketSystem.ReceivePacketJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1514921, RefRangeEnd = 1514922, XrefRangeStart = 1514749, XrefRangeEnd = 1514921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ReceivePacket(
        [In] ref ReceivedPacket packetMetaData,
        DynamicBuffer<ReceivedPacketBuffer> receivedPacketBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref packetMetaData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &receivedPacketBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReceivePacketSystem.ReceivePacketJob.NativeMethodInfoPtr_ReceivePacket_Private_Void_byref_ReceivedPacket_DynamicBuffer_1_ReceivedPacketBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1520679, RefRangeEnd = 1520680, XrefRangeStart = 1514922, XrefRangeEnd = 1520679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void DeserializeEntity(
        ref NetBufferIn netBuffer,
        ref DeserializeEntityParams data)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReceivePacketSystem.ReceivePacketJob.NativeMethodInfoPtr_DeserializeEntity_Private_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ReceivePacketJob()
      {
        Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, nameof (ReceivePacketJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob>.NativeClassPtr);
        ReceivePacketSystem.ReceivePacketJob.NativeFieldInfoPtr_TimeNow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob>.NativeClassPtr, nameof (TimeNow));
        ReceivePacketSystem.ReceivePacketJob.NativeFieldInfoPtr_CurrentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob>.NativeClassPtr, nameof (CurrentFrame));
        ReceivePacketSystem.ReceivePacketJob.NativeFieldInfoPtr_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob>.NativeClassPtr, nameof (Params));
        ReceivePacketSystem.ReceivePacketJob.NativeFieldInfoPtr_ReceivedPacketBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob>.NativeClassPtr, nameof (ReceivedPacketBufferType));
        ReceivePacketSystem.ReceivePacketJob.NativeFieldInfoPtr_ReceivedPacketType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob>.NativeClassPtr, nameof (ReceivedPacketType));
        ReceivePacketSystem.ReceivePacketJob.NativeFieldInfoPtr_NetworkedIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob>.NativeClassPtr, nameof (NetworkedIdToEntityMap));
        ReceivePacketSystem.ReceivePacketJob.NativeFieldInfoPtr_NetworkedIndexToNetworkIdMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob>.NativeClassPtr, nameof (NetworkedIndexToNetworkIdMap));
        ReceivePacketSystem.ReceivePacketJob.NativeFieldInfoPtr_GetNetworkSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob>.NativeClassPtr, nameof (GetNetworkSnapshot));
        ReceivePacketSystem.ReceivePacketJob.NativeFieldInfoPtr_GetNetworkSnapshotState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob>.NativeClassPtr, nameof (GetNetworkSnapshotState));
        ReceivePacketSystem.ReceivePacketJob.NativeFieldInfoPtr_GetNetworkedTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob>.NativeClassPtr, nameof (GetNetworkedTimeout));
        ReceivePacketSystem.ReceivePacketJob.NativeFieldInfoPtr_GetNetworked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob>.NativeClassPtr, nameof (GetNetworked));
        ReceivePacketSystem.ReceivePacketJob.NativeFieldInfoPtr_GetPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob>.NativeClassPtr, nameof (GetPrefabGUID));
        ReceivePacketSystem.ReceivePacketJob.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob>.NativeClassPtr, nameof (SpellMods));
        ReceivePacketSystem.ReceivePacketJob.NativeFieldInfoPtr_WeakRefTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob>.NativeClassPtr, nameof (WeakRefTracker));
        ReceivePacketSystem.ReceivePacketJob.NativeFieldInfoPtr_GetNetSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob>.NativeClassPtr, nameof (GetNetSnapshot));
        ReceivePacketSystem.ReceivePacketJob.NativeFieldInfoPtr_CopySnapshotsFromTheseEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob>.NativeClassPtr, nameof (CopySnapshotsFromTheseEntities));
        ReceivePacketSystem.ReceivePacketJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob>.NativeClassPtr, 100664114);
        ReceivePacketSystem.ReceivePacketJob.NativeMethodInfoPtr_ReceivePacket_Private_Void_byref_ReceivedPacket_DynamicBuffer_1_ReceivedPacketBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob>.NativeClassPtr, 100664115);
        ReceivePacketSystem.ReceivePacketJob.NativeMethodInfoPtr_DeserializeEntity_Private_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob>.NativeClassPtr, 100664116);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct JobParams
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_AbilityChargeCooldowns;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_AbilityStateBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_AchievementInProgressElement;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_ActionBarSlotElement;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_ActiveServantMission;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_AllyPermission;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_BloodHuntBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_CastleBuildingAttachedChildrenBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_CastleBuildingAttachToParentsBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_CastleBuildingFusedChildrenBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_CastleMemberNames;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_CastleTeleporterElement;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_CastleTerritoryDecay;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_CastleTerritoryOccupant;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_ClanMemberStatus;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_FollowerBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_InventoryBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_InventoryInstanceElement;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_PerksBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_ProgressionBookBlueprintElement;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_ProgressionBookRecipeElement;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_ProgressionBookShapeshiftElement;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_ProgressionBookTechElement;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_PylonstationCastleClaimBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_PylonstationCastleDestroyBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_PylonstationCastleRaidBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_PylonstationUpgradesBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_QueuedWorkstationCraftAction;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_RefinementstationRecipesBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_ResearchBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_RespawnPointOwnerBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Restricted_InventoryBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Script_LightningProjectile_Nodes;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_ShardBossHuntBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_SpawnedUnitsBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_TradeCost;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_TradeOutput;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_TraderEntry;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_UnlockedVBlood;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_UnlockedWaypointElement;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_UserMapZoneElement;
        [FieldOffset(0)]
        public BufferFromEntity<Snapshot_AbilityChargeCooldowns> GetSnapshot_AbilityChargeCooldowns;
        [FieldOffset(40)]
        public BufferFromEntity<Snapshot_AbilityStateBuffer> GetSnapshot_AbilityStateBuffer;
        [FieldOffset(80)]
        public BufferFromEntity<Snapshot_AchievementInProgressElement> GetSnapshot_AchievementInProgressElement;
        [FieldOffset(120)]
        public BufferFromEntity<Snapshot_ActionBarSlotElement> GetSnapshot_ActionBarSlotElement;
        [FieldOffset(160)]
        public BufferFromEntity<Snapshot_ActiveServantMission> GetSnapshot_ActiveServantMission;
        [FieldOffset(200)]
        public BufferFromEntity<Snapshot_AllyPermission> GetSnapshot_AllyPermission;
        [FieldOffset(240)]
        public BufferFromEntity<Snapshot_BloodHuntBuffer> GetSnapshot_BloodHuntBuffer;
        [FieldOffset(280)]
        public BufferFromEntity<Snapshot_CastleBuildingAttachedChildrenBuffer> GetSnapshot_CastleBuildingAttachedChildrenBuffer;
        [FieldOffset(320)]
        public BufferFromEntity<Snapshot_CastleBuildingAttachToParentsBuffer> GetSnapshot_CastleBuildingAttachToParentsBuffer;
        [FieldOffset(360)]
        public BufferFromEntity<Snapshot_CastleBuildingFusedChildrenBuffer> GetSnapshot_CastleBuildingFusedChildrenBuffer;
        [FieldOffset(400)]
        public BufferFromEntity<Snapshot_CastleMemberNames> GetSnapshot_CastleMemberNames;
        [FieldOffset(440)]
        public BufferFromEntity<Snapshot_CastleTeleporterElement> GetSnapshot_CastleTeleporterElement;
        [FieldOffset(480)]
        public BufferFromEntity<Snapshot_CastleTerritoryDecay> GetSnapshot_CastleTerritoryDecay;
        [FieldOffset(520)]
        public BufferFromEntity<Snapshot_CastleTerritoryOccupant> GetSnapshot_CastleTerritoryOccupant;
        [FieldOffset(560)]
        public BufferFromEntity<Snapshot_ClanMemberStatus> GetSnapshot_ClanMemberStatus;
        [FieldOffset(600)]
        public BufferFromEntity<Snapshot_FollowerBuffer> GetSnapshot_FollowerBuffer;
        [FieldOffset(640)]
        public BufferFromEntity<Snapshot_InventoryBuffer> GetSnapshot_InventoryBuffer;
        [FieldOffset(680)]
        public BufferFromEntity<Snapshot_InventoryInstanceElement> GetSnapshot_InventoryInstanceElement;
        [FieldOffset(720)]
        public BufferFromEntity<Snapshot_PerksBuffer> GetSnapshot_PerksBuffer;
        [FieldOffset(760)]
        public BufferFromEntity<Snapshot_ProgressionBookBlueprintElement> GetSnapshot_ProgressionBookBlueprintElement;
        [FieldOffset(800)]
        public BufferFromEntity<Snapshot_ProgressionBookRecipeElement> GetSnapshot_ProgressionBookRecipeElement;
        [FieldOffset(840)]
        public BufferFromEntity<Snapshot_ProgressionBookShapeshiftElement> GetSnapshot_ProgressionBookShapeshiftElement;
        [FieldOffset(880)]
        public BufferFromEntity<Snapshot_ProgressionBookTechElement> GetSnapshot_ProgressionBookTechElement;
        [FieldOffset(920)]
        public BufferFromEntity<Snapshot_PylonstationCastleClaimBuffer> GetSnapshot_PylonstationCastleClaimBuffer;
        [FieldOffset(960)]
        public BufferFromEntity<Snapshot_PylonstationCastleDestroyBuffer> GetSnapshot_PylonstationCastleDestroyBuffer;
        [FieldOffset(1000)]
        public BufferFromEntity<Snapshot_PylonstationCastleRaidBuffer> GetSnapshot_PylonstationCastleRaidBuffer;
        [FieldOffset(1040)]
        public BufferFromEntity<Snapshot_PylonstationUpgradesBuffer> GetSnapshot_PylonstationUpgradesBuffer;
        [FieldOffset(1080)]
        public BufferFromEntity<Snapshot_QueuedWorkstationCraftAction> GetSnapshot_QueuedWorkstationCraftAction;
        [FieldOffset(1120)]
        public BufferFromEntity<Snapshot_RefinementstationRecipesBuffer> GetSnapshot_RefinementstationRecipesBuffer;
        [FieldOffset(1160)]
        public BufferFromEntity<Snapshot_ResearchBuffer> GetSnapshot_ResearchBuffer;
        [FieldOffset(1200)]
        public BufferFromEntity<Snapshot_RespawnPointOwnerBuffer> GetSnapshot_RespawnPointOwnerBuffer;
        [FieldOffset(1240)]
        public BufferFromEntity<Snapshot_Restricted_InventoryBuffer> GetSnapshot_Restricted_InventoryBuffer;
        [FieldOffset(1280)]
        public BufferFromEntity<Snapshot_Script_LightningProjectile_Nodes> GetSnapshot_Script_LightningProjectile_Nodes;
        [FieldOffset(1320)]
        public BufferFromEntity<Snapshot_ShardBossHuntBuffer> GetSnapshot_ShardBossHuntBuffer;
        [FieldOffset(1360)]
        public BufferFromEntity<Snapshot_SpawnedUnitsBuffer> GetSnapshot_SpawnedUnitsBuffer;
        [FieldOffset(1400)]
        public BufferFromEntity<Snapshot_TradeCost> GetSnapshot_TradeCost;
        [FieldOffset(1440)]
        public BufferFromEntity<Snapshot_TradeOutput> GetSnapshot_TradeOutput;
        [FieldOffset(1480)]
        public BufferFromEntity<Snapshot_TraderEntry> GetSnapshot_TraderEntry;
        [FieldOffset(1520)]
        public BufferFromEntity<Snapshot_UnlockedVBlood> GetSnapshot_UnlockedVBlood;
        [FieldOffset(1560)]
        public BufferFromEntity<Snapshot_UnlockedWaypointElement> GetSnapshot_UnlockedWaypointElement;
        [FieldOffset(1600)]
        public BufferFromEntity<Snapshot_UserMapZoneElement> GetSnapshot_UserMapZoneElement;

        static JobParams()
        {
          Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob>.NativeClassPtr, nameof (JobParams));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr);
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_AbilityChargeCooldowns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_AbilityChargeCooldowns));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_AbilityStateBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_AbilityStateBuffer));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_AchievementInProgressElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_AchievementInProgressElement));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_ActionBarSlotElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_ActionBarSlotElement));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_ActiveServantMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_ActiveServantMission));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_AllyPermission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_AllyPermission));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_BloodHuntBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_BloodHuntBuffer));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_CastleBuildingAttachedChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_CastleBuildingAttachedChildrenBuffer));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_CastleBuildingAttachToParentsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_CastleBuildingAttachToParentsBuffer));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_CastleBuildingFusedChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_CastleBuildingFusedChildrenBuffer));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_CastleMemberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_CastleMemberNames));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_CastleTeleporterElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_CastleTeleporterElement));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_CastleTerritoryDecay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_CastleTerritoryDecay));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_CastleTerritoryOccupant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_CastleTerritoryOccupant));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_ClanMemberStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_ClanMemberStatus));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_FollowerBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_FollowerBuffer));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_InventoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_InventoryBuffer));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_InventoryInstanceElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_InventoryInstanceElement));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_PerksBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_PerksBuffer));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_ProgressionBookBlueprintElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_ProgressionBookBlueprintElement));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_ProgressionBookRecipeElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_ProgressionBookRecipeElement));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_ProgressionBookShapeshiftElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_ProgressionBookShapeshiftElement));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_ProgressionBookTechElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_ProgressionBookTechElement));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_PylonstationCastleClaimBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_PylonstationCastleClaimBuffer));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_PylonstationCastleDestroyBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_PylonstationCastleDestroyBuffer));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_PylonstationCastleRaidBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_PylonstationCastleRaidBuffer));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_PylonstationUpgradesBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_PylonstationUpgradesBuffer));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_QueuedWorkstationCraftAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_QueuedWorkstationCraftAction));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_RefinementstationRecipesBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_RefinementstationRecipesBuffer));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_ResearchBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_ResearchBuffer));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_RespawnPointOwnerBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_RespawnPointOwnerBuffer));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Restricted_InventoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Restricted_InventoryBuffer));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Script_LightningProjectile_Nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Script_LightningProjectile_Nodes));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_ShardBossHuntBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_ShardBossHuntBuffer));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_SpawnedUnitsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_SpawnedUnitsBuffer));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_TradeCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_TradeCost));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_TradeOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_TradeOutput));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_TraderEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_TraderEntry));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_UnlockedVBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_UnlockedVBlood));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_UnlockedWaypointElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_UnlockedWaypointElement));
          ReceivePacketSystem.ReceivePacketJob.JobParams.NativeFieldInfoPtr_GetSnapshot_UserMapZoneElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_UserMapZoneElement));
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReceivePacketSystem.ReceivePacketJob.JobParams>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct EntityToSpawn
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkId;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsHardReffed;
      [FieldOffset(0)]
      public PrefabGUID PrefabGUID;
      [FieldOffset(4)]
      public NetworkId NetworkId;
      [FieldOffset(12)]
      public bool IsHardReffed;

      static EntityToSpawn()
      {
        Il2CppClassPointerStore<ReceivePacketSystem.EntityToSpawn>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, nameof (EntityToSpawn));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivePacketSystem.EntityToSpawn>.NativeClassPtr);
        ReceivePacketSystem.EntityToSpawn.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.EntityToSpawn>.NativeClassPtr, nameof (PrefabGUID));
        ReceivePacketSystem.EntityToSpawn.NativeFieldInfoPtr_NetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.EntityToSpawn>.NativeClassPtr, nameof (NetworkId));
        ReceivePacketSystem.EntityToSpawn.NativeFieldInfoPtr_IsHardReffed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.EntityToSpawn>.NativeClassPtr, nameof (IsHardReffed));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReceivePacketSystem.EntityToSpawn>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct EntityToDestroy
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkId;
      [FieldOffset(0)]
      public PrefabGUID PrefabGUID;
      [FieldOffset(4)]
      public NetworkId NetworkId;

      static EntityToDestroy()
      {
        Il2CppClassPointerStore<ReceivePacketSystem.EntityToDestroy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, nameof (EntityToDestroy));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivePacketSystem.EntityToDestroy>.NativeClassPtr);
        ReceivePacketSystem.EntityToDestroy.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.EntityToDestroy>.NativeClassPtr, nameof (PrefabGUID));
        ReceivePacketSystem.EntityToDestroy.NativeFieldInfoPtr_NetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.EntityToDestroy>.NativeClassPtr, nameof (NetworkId));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReceivePacketSystem.EntityToDestroy>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct EntityHeader
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkIdIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkIdGeneration;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_ComponentBitCount;
      private static readonly System.IntPtr NativeFieldInfoPtr_FullNetworkedIdAndPrefabGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasSerializedComponents;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsDestroyedSnapshot;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsHardReffed;
      [FieldOffset(0)]
      public int NetworkIdIndex;
      [FieldOffset(4)]
      public byte NetworkIdGeneration;
      [FieldOffset(8)]
      public PrefabGUID PrefabGuid;
      [FieldOffset(12)]
      public int ComponentBitCount;
      [FieldOffset(16)]
      public bool FullNetworkedIdAndPrefabGuid;
      [FieldOffset(17)]
      public bool HasSerializedComponents;
      [FieldOffset(18)]
      public bool IsDestroyedSnapshot;
      [FieldOffset(19)]
      public bool IsHardReffed;

      static EntityHeader()
      {
        Il2CppClassPointerStore<ReceivePacketSystem.EntityHeader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, nameof (EntityHeader));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivePacketSystem.EntityHeader>.NativeClassPtr);
        ReceivePacketSystem.EntityHeader.NativeFieldInfoPtr_NetworkIdIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.EntityHeader>.NativeClassPtr, nameof (NetworkIdIndex));
        ReceivePacketSystem.EntityHeader.NativeFieldInfoPtr_NetworkIdGeneration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.EntityHeader>.NativeClassPtr, nameof (NetworkIdGeneration));
        ReceivePacketSystem.EntityHeader.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.EntityHeader>.NativeClassPtr, nameof (PrefabGuid));
        ReceivePacketSystem.EntityHeader.NativeFieldInfoPtr_ComponentBitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.EntityHeader>.NativeClassPtr, nameof (ComponentBitCount));
        ReceivePacketSystem.EntityHeader.NativeFieldInfoPtr_FullNetworkedIdAndPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.EntityHeader>.NativeClassPtr, nameof (FullNetworkedIdAndPrefabGuid));
        ReceivePacketSystem.EntityHeader.NativeFieldInfoPtr_HasSerializedComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.EntityHeader>.NativeClassPtr, nameof (HasSerializedComponents));
        ReceivePacketSystem.EntityHeader.NativeFieldInfoPtr_IsDestroyedSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.EntityHeader>.NativeClassPtr, nameof (IsDestroyedSnapshot));
        ReceivePacketSystem.EntityHeader.NativeFieldInfoPtr_IsHardReffed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.EntityHeader>.NativeClassPtr, nameof (IsHardReffed));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReceivePacketSystem.EntityHeader>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CreateEntitiesJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ReceivedPacketBufferType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ReceivedPacketType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetClientNetworkState;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetReceivedServerFrames;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetNetworkedTimeout;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetDisabledDueToTimeout;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetLinkedEntityGroup;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetAttachedBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_ClientNetworkStateEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedIndexToNetworkIdMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntitiesToSpawn;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntitiesToDestroy;
      private static readonly System.IntPtr NativeFieldInfoPtr_CurrentFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr_UnscaledTime;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CreateEntities_Private_Void_byref_ReceivedPacket_DynamicBuffer_1_ReceivedPacketBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EnableRecursive_Private_Void_Entity_0;
      [FieldOffset(0)]
      public BufferTypeHandle<ReceivedPacketBuffer> ReceivedPacketBufferType;
      [FieldOffset(40)]
      public ComponentTypeHandle<ReceivedPacket> ReceivedPacketType;
      [FieldOffset(72)]
      public ComponentDataFromEntity<ClientNetworkState> GetClientNetworkState;
      [FieldOffset(104)]
      public BufferFromEntity<ReceivedServerFrame> GetReceivedServerFrames;
      [FieldOffset(144)]
      public ComponentDataFromEntity<NetworkedTimeout> GetNetworkedTimeout;
      [FieldOffset(176)]
      public ComponentDataFromEntity<DisabledDueToTimeout> GetDisabledDueToTimeout;
      [FieldOffset(208)]
      public BufferFromEntity<LinkedEntityGroup> GetLinkedEntityGroup;
      [FieldOffset(248)]
      public BufferFromEntity<AttachedBuffer> GetAttachedBuffer;
      [FieldOffset(288)]
      public Entity ClientNetworkStateEntity;
      [FieldOffset(296)]
      public NativeHashMap<NetworkId, Entity> NetworkedIdToEntityMap;
      [FieldOffset(312)]
      public NativeHashMap<int, NetworkId> NetworkedIndexToNetworkIdMap;
      [FieldOffset(328)]
      public EntityCommandBuffer CommandBuffer;
      [FieldOffset(344)]
      public NativeList<ReceivePacketSystem.EntityToSpawn> EntitiesToSpawn;
      [FieldOffset(360)]
      public NativeList<ReceivePacketSystem.EntityToDestroy> EntitiesToDestroy;
      [FieldOffset(376)]
      public int CurrentFrame;
      [FieldOffset(380)]
      public float UnscaledTime;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1520680, XrefRangeEnd = 1520692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ReceivePacketSystem.CreateEntitiesJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1520780, RefRangeEnd = 1520781, XrefRangeStart = 1520692, XrefRangeEnd = 1520780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CreateEntities(
        ref ReceivedPacket packetMetaData,
        DynamicBuffer<ReceivedPacketBuffer> receivedPacketBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref packetMetaData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &receivedPacketBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReceivePacketSystem.CreateEntitiesJob.NativeMethodInfoPtr_CreateEntities_Private_Void_byref_ReceivedPacket_DynamicBuffer_1_ReceivedPacketBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1520832, RefRangeEnd = 1520834, XrefRangeStart = 1520781, XrefRangeEnd = 1520832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void EnableRecursive(Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReceivePacketSystem.CreateEntitiesJob.NativeMethodInfoPtr_EnableRecursive_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static CreateEntitiesJob()
      {
        Il2CppClassPointerStore<ReceivePacketSystem.CreateEntitiesJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReceivePacketSystem>.NativeClassPtr, nameof (CreateEntitiesJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivePacketSystem.CreateEntitiesJob>.NativeClassPtr);
        ReceivePacketSystem.CreateEntitiesJob.NativeFieldInfoPtr_ReceivedPacketBufferType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.CreateEntitiesJob>.NativeClassPtr, nameof (ReceivedPacketBufferType));
        ReceivePacketSystem.CreateEntitiesJob.NativeFieldInfoPtr_ReceivedPacketType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.CreateEntitiesJob>.NativeClassPtr, nameof (ReceivedPacketType));
        ReceivePacketSystem.CreateEntitiesJob.NativeFieldInfoPtr_GetClientNetworkState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.CreateEntitiesJob>.NativeClassPtr, nameof (GetClientNetworkState));
        ReceivePacketSystem.CreateEntitiesJob.NativeFieldInfoPtr_GetReceivedServerFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.CreateEntitiesJob>.NativeClassPtr, nameof (GetReceivedServerFrames));
        ReceivePacketSystem.CreateEntitiesJob.NativeFieldInfoPtr_GetNetworkedTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.CreateEntitiesJob>.NativeClassPtr, nameof (GetNetworkedTimeout));
        ReceivePacketSystem.CreateEntitiesJob.NativeFieldInfoPtr_GetDisabledDueToTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.CreateEntitiesJob>.NativeClassPtr, nameof (GetDisabledDueToTimeout));
        ReceivePacketSystem.CreateEntitiesJob.NativeFieldInfoPtr_GetLinkedEntityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.CreateEntitiesJob>.NativeClassPtr, nameof (GetLinkedEntityGroup));
        ReceivePacketSystem.CreateEntitiesJob.NativeFieldInfoPtr_GetAttachedBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.CreateEntitiesJob>.NativeClassPtr, nameof (GetAttachedBuffer));
        ReceivePacketSystem.CreateEntitiesJob.NativeFieldInfoPtr_ClientNetworkStateEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.CreateEntitiesJob>.NativeClassPtr, nameof (ClientNetworkStateEntity));
        ReceivePacketSystem.CreateEntitiesJob.NativeFieldInfoPtr_NetworkedIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.CreateEntitiesJob>.NativeClassPtr, nameof (NetworkedIdToEntityMap));
        ReceivePacketSystem.CreateEntitiesJob.NativeFieldInfoPtr_NetworkedIndexToNetworkIdMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.CreateEntitiesJob>.NativeClassPtr, nameof (NetworkedIndexToNetworkIdMap));
        ReceivePacketSystem.CreateEntitiesJob.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.CreateEntitiesJob>.NativeClassPtr, nameof (CommandBuffer));
        ReceivePacketSystem.CreateEntitiesJob.NativeFieldInfoPtr_EntitiesToSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.CreateEntitiesJob>.NativeClassPtr, nameof (EntitiesToSpawn));
        ReceivePacketSystem.CreateEntitiesJob.NativeFieldInfoPtr_EntitiesToDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.CreateEntitiesJob>.NativeClassPtr, nameof (EntitiesToDestroy));
        ReceivePacketSystem.CreateEntitiesJob.NativeFieldInfoPtr_CurrentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.CreateEntitiesJob>.NativeClassPtr, nameof (CurrentFrame));
        ReceivePacketSystem.CreateEntitiesJob.NativeFieldInfoPtr_UnscaledTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketSystem.CreateEntitiesJob>.NativeClassPtr, nameof (UnscaledTime));
        ReceivePacketSystem.CreateEntitiesJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketSystem.CreateEntitiesJob>.NativeClassPtr, 100664117);
        ReceivePacketSystem.CreateEntitiesJob.NativeMethodInfoPtr_CreateEntities_Private_Void_byref_ReceivedPacket_DynamicBuffer_1_ReceivedPacketBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketSystem.CreateEntitiesJob>.NativeClassPtr, 100664118);
        ReceivePacketSystem.CreateEntitiesJob.NativeMethodInfoPtr_EnableRecursive_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketSystem.CreateEntitiesJob>.NativeClassPtr, 100664119);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReceivePacketSystem.CreateEntitiesJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
