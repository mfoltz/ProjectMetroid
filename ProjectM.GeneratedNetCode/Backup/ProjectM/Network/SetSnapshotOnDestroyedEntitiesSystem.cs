// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.SetSnapshotOnDestroyedEntitiesSystem
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  public class SetSnapshotOnDestroyedEntitiesSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__DestroyQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupJob_Private_Void_byref_JobParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1614691, XrefRangeEnd = 1614710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetSnapshotOnDestroyedEntitiesSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1614710, XrefRangeEnd = 1614741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetSnapshotOnDestroyedEntitiesSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1614864, RefRangeEnd = 1614865, XrefRangeStart = 1614741, XrefRangeEnd = 1614864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupJob(
      ref SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams jobParams)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref jobParams;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetSnapshotOnDestroyedEntitiesSystem.NativeMethodInfoPtr_SetupJob_Private_Void_byref_JobParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SetSnapshotOnDestroyedEntitiesSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetSnapshotOnDestroyedEntitiesSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetSnapshotOnDestroyedEntitiesSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SetSnapshotOnDestroyedEntitiesSystem()
    {
      Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (SetSnapshotOnDestroyedEntitiesSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem>.NativeClassPtr);
      SetSnapshotOnDestroyedEntitiesSystem.NativeFieldInfoPtr__DestroyQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem>.NativeClassPtr, nameof (_DestroyQuery));
      SetSnapshotOnDestroyedEntitiesSystem.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem>.NativeClassPtr, nameof (_NetworkIdSystem));
      SetSnapshotOnDestroyedEntitiesSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem>.NativeClassPtr, 100665104);
      SetSnapshotOnDestroyedEntitiesSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem>.NativeClassPtr, 100665105);
      SetSnapshotOnDestroyedEntitiesSystem.NativeMethodInfoPtr_SetupJob_Private_Void_byref_JobParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem>.NativeClassPtr, 100665106);
      SetSnapshotOnDestroyedEntitiesSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem>.NativeClassPtr, 100665107);
      SetSnapshotOnDestroyedEntitiesSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem>.NativeClassPtr, 100665108);
    }

    public SetSnapshotOnDestroyedEntitiesSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _DestroyQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetSnapshotOnDestroyedEntitiesSystem.NativeFieldInfoPtr__DestroyQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetSnapshotOnDestroyedEntitiesSystem.NativeFieldInfoPtr__DestroyQuery)) = value;
      }
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetSnapshotOnDestroyedEntitiesSystem.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == System.IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetSnapshotOnDestroyedEntitiesSystem.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CopyDataToDestroyedEntitiesJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Params;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityTypeHandle;
      private static readonly System.IntPtr NativeFieldInfoPtr_DestroyedEntityTypeHandle;
      private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotTypeHandle;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkIdLookup;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetNetSnapshot;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetNetSnapshotFrameChanged;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetNetworkedSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetFrameChanged;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopyBuffer_Private_Void_Entity_Entity_BufferFromEntity_1_T_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CopySnapshotData_Private_Void_Entity_Entity_NetworkSnapshot_0;
      [FieldOffset(0)]
      public SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams Params;
      [FieldOffset(1640)]
      public EntityTypeHandle EntityTypeHandle;
      [FieldOffset(1648)]
      public ComponentTypeHandle<DestroyedEntity> DestroyedEntityTypeHandle;
      [FieldOffset(1680)]
      public ComponentTypeHandle<NetworkSnapshot> SnapshotTypeHandle;
      [FieldOffset(1712)]
      public NativeHashMap<NetworkId, Entity> NetworkIdLookup;
      [FieldOffset(1728)]
      public BufferFromEntity<NetSnapshot> GetNetSnapshot;
      [FieldOffset(1768)]
      public BufferFromEntity<SnapshotFrameChangedBuffer> GetNetSnapshotFrameChanged;
      [FieldOffset(1808)]
      public ComponentDataFromEntity<NetworkedSettings> GetNetworkedSettings;
      [FieldOffset(1840)]
      public ComponentDataFromEntity<FrameChanged> GetFrameChanged;

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 1614544, RefRangeEnd = 1614551, XrefRangeStart = 1614541, XrefRangeEnd = 1614544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopyBuffer<T>(
        Entity sourceEntity,
        Entity targetEntity,
        BufferFromEntity<T> getBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &sourceEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.MethodInfoStoreGeneric_CopyBuffer_Private_Void_Entity_Entity_BufferFromEntity_1_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1614551, XrefRangeEnd = 1614632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1614690, RefRangeEnd = 1614691, XrefRangeStart = 1614632, XrefRangeEnd = 1614690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void CopySnapshotData(
        Entity sourceEntity,
        Entity targetEntity,
        NetworkSnapshot snapshotType)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &sourceEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &snapshotType;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.NativeMethodInfoPtr_CopySnapshotData_Private_Void_Entity_Entity_NetworkSnapshot_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static CopyDataToDestroyedEntitiesJob()
      {
        Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem>.NativeClassPtr, nameof (CopyDataToDestroyedEntitiesJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob>.NativeClassPtr);
        SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.NativeFieldInfoPtr_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob>.NativeClassPtr, nameof (Params));
        SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.NativeFieldInfoPtr_EntityTypeHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob>.NativeClassPtr, nameof (EntityTypeHandle));
        SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.NativeFieldInfoPtr_DestroyedEntityTypeHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob>.NativeClassPtr, nameof (DestroyedEntityTypeHandle));
        SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.NativeFieldInfoPtr_SnapshotTypeHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob>.NativeClassPtr, nameof (SnapshotTypeHandle));
        SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.NativeFieldInfoPtr_NetworkIdLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob>.NativeClassPtr, nameof (NetworkIdLookup));
        SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.NativeFieldInfoPtr_GetNetSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob>.NativeClassPtr, nameof (GetNetSnapshot));
        SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.NativeFieldInfoPtr_GetNetSnapshotFrameChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob>.NativeClassPtr, nameof (GetNetSnapshotFrameChanged));
        SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.NativeFieldInfoPtr_GetNetworkedSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob>.NativeClassPtr, nameof (GetNetworkedSettings));
        SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.NativeFieldInfoPtr_GetFrameChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob>.NativeClassPtr, nameof (GetFrameChanged));
        SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.NativeMethodInfoPtr_CopyBuffer_Private_Void_Entity_Entity_BufferFromEntity_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob>.NativeClassPtr, 100665109);
        SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob>.NativeClassPtr, 100665110);
        SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.NativeMethodInfoPtr_CopySnapshotData_Private_Void_Entity_Entity_NetworkSnapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob>.NativeClassPtr, 100665111);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob>.NativeClassPtr, (System.IntPtr) ref this));
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
          Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob>.NativeClassPtr, nameof (JobParams));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr);
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_AbilityChargeCooldowns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_AbilityChargeCooldowns));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_AbilityStateBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_AbilityStateBuffer));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_AchievementInProgressElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_AchievementInProgressElement));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_ActionBarSlotElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_ActionBarSlotElement));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_ActiveServantMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_ActiveServantMission));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_AllyPermission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_AllyPermission));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_BloodHuntBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_BloodHuntBuffer));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_CastleBuildingAttachedChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_CastleBuildingAttachedChildrenBuffer));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_CastleBuildingAttachToParentsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_CastleBuildingAttachToParentsBuffer));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_CastleBuildingFusedChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_CastleBuildingFusedChildrenBuffer));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_CastleMemberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_CastleMemberNames));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_CastleTeleporterElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_CastleTeleporterElement));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_CastleTerritoryDecay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_CastleTerritoryDecay));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_CastleTerritoryOccupant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_CastleTerritoryOccupant));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_ClanMemberStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_ClanMemberStatus));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_FollowerBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_FollowerBuffer));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_InventoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_InventoryBuffer));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_InventoryInstanceElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_InventoryInstanceElement));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_PerksBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_PerksBuffer));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_ProgressionBookBlueprintElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_ProgressionBookBlueprintElement));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_ProgressionBookRecipeElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_ProgressionBookRecipeElement));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_ProgressionBookShapeshiftElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_ProgressionBookShapeshiftElement));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_ProgressionBookTechElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_ProgressionBookTechElement));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_PylonstationCastleClaimBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_PylonstationCastleClaimBuffer));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_PylonstationCastleDestroyBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_PylonstationCastleDestroyBuffer));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_PylonstationCastleRaidBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_PylonstationCastleRaidBuffer));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_PylonstationUpgradesBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_PylonstationUpgradesBuffer));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_QueuedWorkstationCraftAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_QueuedWorkstationCraftAction));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_RefinementstationRecipesBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_RefinementstationRecipesBuffer));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_ResearchBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_ResearchBuffer));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_RespawnPointOwnerBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_RespawnPointOwnerBuffer));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Restricted_InventoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Restricted_InventoryBuffer));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Script_LightningProjectile_Nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Script_LightningProjectile_Nodes));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_ShardBossHuntBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_ShardBossHuntBuffer));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_SpawnedUnitsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_SpawnedUnitsBuffer));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_TradeCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_TradeCost));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_TradeOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_TradeOutput));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_TraderEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_TraderEntry));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_UnlockedVBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_UnlockedVBlood));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_UnlockedWaypointElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_UnlockedWaypointElement));
          SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams.NativeFieldInfoPtr_GetSnapshot_UserMapZoneElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_UserMapZoneElement));
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.JobParams>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }

      private sealed class MethodInfoStoreGeneric_CopyBuffer_Private_Void_Entity_Entity_BufferFromEntity_1_T_0<T>
      {
        internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob.NativeMethodInfoPtr_CopyBuffer_Private_Void_Entity_Entity_BufferFromEntity_1_T_0, Il2CppClassPointerStore<SetSnapshotOnDestroyedEntitiesSystem.CopyDataToDestroyedEntitiesJob>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))));
      }
    }
  }
}
