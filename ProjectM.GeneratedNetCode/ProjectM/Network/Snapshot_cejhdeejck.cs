// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_cejhdeejck
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.CastleBuilding.Placement;
using Stunlock.Network;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_cejhdeejck
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_AdminOnlyDebugEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_AggroDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_AiCastsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_AllProgressionUnlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_AllWaypointsUnlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_BloodDrainDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_BuildCostsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_BuildingPlacementRestrictionsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_BuildingReplacementDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_CastleHeartBloodEssenceDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_CastleHeartConnectionRequirementDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_CastleLimitsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_CooldownsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_DayNightCycleDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_DisableDebugEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_DropsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_DurabilityDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_DynamicCloudsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_DynamicCollisionDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_EveryoneIsAdmin;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_FeedWoundedRequirementDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_FreeBuildingPlacementEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_GlobalCastleTerritoryEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_HitEffectsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_LightningStrikesDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_LinnCastleRoofsEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_NPCsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_PlacementLogLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_PlayersInvulnerabilityEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_RoofGenerationEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_SunDamageDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_TileCollisionDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_TutorialPopupsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_UnlockAllVBloodsOnLaunch;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_UseDeathSequencesInsteadOfRagdolls;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_UseHeightRaycasting;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_UseSunblockerChecksForFly;
    private static readonly System.IntPtr NativeFieldInfoPtr_SyncedServerDebugSettings_VbloodGhostsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_IndexCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChanged_ComponentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SyncedServerDebugSettings_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedFields_SyncedServerDebugSettings_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_AdminOnlyDebugEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_AggroDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_AiCastsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_AllProgressionUnlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_AllWaypointsUnlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_BloodDrainDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_BuildCostsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_BuildingPlacementRestrictionsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_BuildingReplacementDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_CastleHeartBloodEssenceDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_CastleHeartConnectionRequirementDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_CastleLimitsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_CooldownsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DayNightCycleDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DisableDebugEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DropsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DurabilityDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DynamicCloudsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DynamicCollisionDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_EveryoneIsAdmin;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_FeedWoundedRequirementDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_FreeBuildingPlacementEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_GlobalCastleTerritoryEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_HitEffectsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_LightningStrikesDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_LinnCastleRoofsEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_NPCsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_PlacementLogLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_PlayersInvulnerabilityEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_RoofGenerationEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_SunDamageDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_TileCollisionDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_TutorialPopupsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_UnlockAllVBloodsOnLaunch;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_UseDeathSequencesInsteadOfRagdolls;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_UseHeightRaycasting;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_UseSunblockerChecksForFly;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_VbloodGhostsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataStartOffset_SyncedServerDebugSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_ComponentDataSize_SyncedServerDebugSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_CompBit_SyncedServerDebugSettings;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public NetworkSnapshotType SnapshotType;
    [FieldOffset(8)]
    public bool SyncedServerDebugSettings_AdminOnlyDebugEvents;
    [FieldOffset(9)]
    public bool SyncedServerDebugSettings_AggroDisabled;
    [FieldOffset(10)]
    public bool SyncedServerDebugSettings_AiCastsDisabled;
    [FieldOffset(11)]
    public bool SyncedServerDebugSettings_AllProgressionUnlocked;
    [FieldOffset(12)]
    public bool SyncedServerDebugSettings_AllWaypointsUnlocked;
    [FieldOffset(13)]
    public bool SyncedServerDebugSettings_BloodDrainDisabled;
    [FieldOffset(14)]
    public bool SyncedServerDebugSettings_BuildCostsDisabled;
    [FieldOffset(15)]
    public bool SyncedServerDebugSettings_BuildingPlacementRestrictionsDisabled;
    [FieldOffset(16)]
    public bool SyncedServerDebugSettings_BuildingReplacementDisabled;
    [FieldOffset(17)]
    public bool SyncedServerDebugSettings_CastleHeartBloodEssenceDisabled;
    [FieldOffset(18)]
    public bool SyncedServerDebugSettings_CastleHeartConnectionRequirementDisabled;
    [FieldOffset(19)]
    public bool SyncedServerDebugSettings_CastleLimitsDisabled;
    [FieldOffset(20)]
    public bool SyncedServerDebugSettings_CooldownsDisabled;
    [FieldOffset(21)]
    public bool SyncedServerDebugSettings_DayNightCycleDisabled;
    [FieldOffset(22)]
    public bool SyncedServerDebugSettings_DisableDebugEvents;
    [FieldOffset(23)]
    public bool SyncedServerDebugSettings_DropsDisabled;
    [FieldOffset(24)]
    public bool SyncedServerDebugSettings_DurabilityDisabled;
    [FieldOffset(25)]
    public bool SyncedServerDebugSettings_DynamicCloudsDisabled;
    [FieldOffset(26)]
    public bool SyncedServerDebugSettings_DynamicCollisionDisabled;
    [FieldOffset(27)]
    public bool SyncedServerDebugSettings_EveryoneIsAdmin;
    [FieldOffset(28)]
    public bool SyncedServerDebugSettings_FeedWoundedRequirementDisabled;
    [FieldOffset(29)]
    public bool SyncedServerDebugSettings_FreeBuildingPlacementEnabled;
    [FieldOffset(30)]
    public bool SyncedServerDebugSettings_GlobalCastleTerritoryEnabled;
    [FieldOffset(31)]
    public bool SyncedServerDebugSettings_HitEffectsDisabled;
    [FieldOffset(32)]
    public bool SyncedServerDebugSettings_LightningStrikesDisabled;
    [FieldOffset(33)]
    public bool SyncedServerDebugSettings_LinnCastleRoofsEnabled;
    [FieldOffset(34)]
    public bool SyncedServerDebugSettings_NPCsDisabled;
    [FieldOffset(35)]
    public PlacementLogLevel SyncedServerDebugSettings_PlacementLogLevel;
    [FieldOffset(36)]
    public bool SyncedServerDebugSettings_PlayersInvulnerabilityEnabled;
    [FieldOffset(37)]
    public bool SyncedServerDebugSettings_RoofGenerationEnabled;
    [FieldOffset(38)]
    public bool SyncedServerDebugSettings_SunDamageDisabled;
    [FieldOffset(39)]
    public bool SyncedServerDebugSettings_TileCollisionDisabled;
    [FieldOffset(40)]
    public bool SyncedServerDebugSettings_TutorialPopupsDisabled;
    [FieldOffset(41)]
    public bool SyncedServerDebugSettings_UnlockAllVBloodsOnLaunch;
    [FieldOffset(42)]
    public bool SyncedServerDebugSettings_UseDeathSequencesInsteadOfRagdolls;
    [FieldOffset(43)]
    public bool SyncedServerDebugSettings_UseHeightRaycasting;
    [FieldOffset(44)]
    public bool SyncedServerDebugSettings_UseSunblockerChecksForFly;
    [FieldOffset(45)]
    public bool SyncedServerDebugSettings_VbloodGhostsDisabled;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1565668, XrefRangeEnd = 1565709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeSnapshot(
      ref NetBufferOut netBuffer,
      SnapshotFrameChangedBuffer* frameChanged,
      ref SerializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) frameChanged;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cejhdeejck.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1565754, RefRangeEnd = 1565755, XrefRangeStart = 1565709, XrefRangeEnd = 1565754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeserializeSnapshot(
      ref NetBufferIn netBuffer,
      ref DeserializeEntityParams data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Snapshot_cejhdeejck.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Snapshot_cejhdeejck()
    {
      Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_cejhdeejck));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr);
      Snapshot_cejhdeejck.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (PrefabGuid));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SnapshotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SnapshotType));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_AdminOnlyDebugEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_AdminOnlyDebugEvents));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_AggroDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_AggroDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_AiCastsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_AiCastsDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_AllProgressionUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_AllProgressionUnlocked));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_AllWaypointsUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_AllWaypointsUnlocked));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_BloodDrainDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_BloodDrainDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_BuildCostsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_BuildCostsDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_BuildingPlacementRestrictionsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_BuildingPlacementRestrictionsDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_BuildingReplacementDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_BuildingReplacementDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_CastleHeartBloodEssenceDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_CastleHeartBloodEssenceDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_CastleHeartConnectionRequirementDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_CastleHeartConnectionRequirementDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_CastleLimitsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_CastleLimitsDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_CooldownsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_CooldownsDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_DayNightCycleDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_DayNightCycleDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_DisableDebugEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_DisableDebugEvents));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_DropsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_DropsDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_DurabilityDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_DurabilityDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_DynamicCloudsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_DynamicCloudsDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_DynamicCollisionDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_DynamicCollisionDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_EveryoneIsAdmin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_EveryoneIsAdmin));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_FeedWoundedRequirementDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_FeedWoundedRequirementDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_FreeBuildingPlacementEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_FreeBuildingPlacementEnabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_GlobalCastleTerritoryEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_GlobalCastleTerritoryEnabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_HitEffectsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_HitEffectsDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_LightningStrikesDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_LightningStrikesDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_LinnCastleRoofsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_LinnCastleRoofsEnabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_NPCsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_NPCsDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_PlacementLogLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_PlacementLogLevel));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_PlayersInvulnerabilityEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_PlayersInvulnerabilityEnabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_RoofGenerationEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_RoofGenerationEnabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_SunDamageDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_SunDamageDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_TileCollisionDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_TileCollisionDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_TutorialPopupsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_TutorialPopupsDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_UnlockAllVBloodsOnLaunch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_UnlockAllVBloodsOnLaunch));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_UseDeathSequencesInsteadOfRagdolls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_UseDeathSequencesInsteadOfRagdolls));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_UseHeightRaycasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_UseHeightRaycasting));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_UseSunblockerChecksForFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_UseSunblockerChecksForFly));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_SyncedServerDebugSettings_VbloodGhostsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (SyncedServerDebugSettings_VbloodGhostsDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (CodeGen_EstimatedSnapshotSize));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChanged_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChanged_IndexCount));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChanged_ComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChanged_ComponentCount));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedFields_SyncedServerDebugSettings_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedFields_SyncedServerDebugSettings_Start));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedFields_SyncedServerDebugSettings_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedFields_SyncedServerDebugSettings_Count));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_AdminOnlyDebugEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_AdminOnlyDebugEvents));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_AggroDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_AggroDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_AiCastsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_AiCastsDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_AllProgressionUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_AllProgressionUnlocked));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_AllWaypointsUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_AllWaypointsUnlocked));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_BloodDrainDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_BloodDrainDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_BuildCostsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_BuildCostsDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_BuildingPlacementRestrictionsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_BuildingPlacementRestrictionsDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_BuildingReplacementDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_BuildingReplacementDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_CastleHeartBloodEssenceDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_CastleHeartBloodEssenceDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_CastleHeartConnectionRequirementDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_CastleHeartConnectionRequirementDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_CastleLimitsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_CastleLimitsDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_CooldownsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_CooldownsDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DayNightCycleDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_DayNightCycleDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DisableDebugEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_DisableDebugEvents));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DropsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_DropsDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DurabilityDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_DurabilityDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DynamicCloudsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_DynamicCloudsDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DynamicCollisionDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_DynamicCollisionDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_EveryoneIsAdmin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_EveryoneIsAdmin));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_FeedWoundedRequirementDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_FeedWoundedRequirementDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_FreeBuildingPlacementEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_FreeBuildingPlacementEnabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_GlobalCastleTerritoryEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_GlobalCastleTerritoryEnabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_HitEffectsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_HitEffectsDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_LightningStrikesDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_LightningStrikesDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_LinnCastleRoofsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_LinnCastleRoofsEnabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_NPCsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_NPCsDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_PlacementLogLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_PlacementLogLevel));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_PlayersInvulnerabilityEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_PlayersInvulnerabilityEnabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_RoofGenerationEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_RoofGenerationEnabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_SunDamageDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_SunDamageDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_TileCollisionDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_TileCollisionDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_TutorialPopupsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_TutorialPopupsDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_UnlockAllVBloodsOnLaunch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_UnlockAllVBloodsOnLaunch));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_UseDeathSequencesInsteadOfRagdolls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_UseDeathSequencesInsteadOfRagdolls));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_UseHeightRaycasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_UseHeightRaycasting));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_UseSunblockerChecksForFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_UseSunblockerChecksForFly));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_VbloodGhostsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (FrameChangedIndex_SyncedServerDebugSettings_VbloodGhostsDisabled));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_ComponentDataStartOffset_SyncedServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (ComponentDataStartOffset_SyncedServerDebugSettings));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_ComponentDataSize_SyncedServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (ComponentDataSize_SyncedServerDebugSettings));
      Snapshot_cejhdeejck.NativeFieldInfoPtr_CompBit_SyncedServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, nameof (CompBit_SyncedServerDebugSettings));
      Snapshot_cejhdeejck.NativeMethodInfoPtr_SerializeSnapshot_Public_Void_byref_NetBufferOut_ptr_SnapshotFrameChangedBuffer_byref_SerializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, 100664500);
      Snapshot_cejhdeejck.NativeMethodInfoPtr_DeserializeSnapshot_Public_Void_byref_NetBufferIn_byref_DeserializeEntityParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, 100664501);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_cejhdeejck>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int CodeGen_EstimatedSnapshotSize
    {
      get
      {
        int estimatedSnapshotSize;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &estimatedSnapshotSize);
        return estimatedSnapshotSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_CodeGen_EstimatedSnapshotSize, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_IndexCount
    {
      get
      {
        int changedIndexCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &changedIndexCount);
        return changedIndexCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChanged_IndexCount, (void*) &value);
      }
    }

    public static unsafe int FrameChanged_ComponentCount
    {
      get
      {
        int changedComponentCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &changedComponentCount);
        return changedComponentCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChanged_ComponentCount, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SyncedServerDebugSettings_Start
    {
      get
      {
        int debugSettingsStart;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedFields_SyncedServerDebugSettings_Start, (void*) &debugSettingsStart);
        return debugSettingsStart;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedFields_SyncedServerDebugSettings_Start, (void*) &value);
      }
    }

    public static unsafe int FrameChangedFields_SyncedServerDebugSettings_Count
    {
      get
      {
        int debugSettingsCount;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedFields_SyncedServerDebugSettings_Count, (void*) &debugSettingsCount);
        return debugSettingsCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedFields_SyncedServerDebugSettings_Count, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings
    {
      get
      {
        int serverDebugSettings;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings, (void*) &serverDebugSettings);
        return serverDebugSettings;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_AdminOnlyDebugEvents
    {
      get
      {
        int adminOnlyDebugEvents;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_AdminOnlyDebugEvents, (void*) &adminOnlyDebugEvents);
        return adminOnlyDebugEvents;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_AdminOnlyDebugEvents, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_AggroDisabled
    {
      get
      {
        int settingsAggroDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_AggroDisabled, (void*) &settingsAggroDisabled);
        return settingsAggroDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_AggroDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_AiCastsDisabled
    {
      get
      {
        int settingsAiCastsDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_AiCastsDisabled, (void*) &settingsAiCastsDisabled);
        return settingsAiCastsDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_AiCastsDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_AllProgressionUnlocked
    {
      get
      {
        int progressionUnlocked;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_AllProgressionUnlocked, (void*) &progressionUnlocked);
        return progressionUnlocked;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_AllProgressionUnlocked, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_AllWaypointsUnlocked
    {
      get
      {
        int waypointsUnlocked;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_AllWaypointsUnlocked, (void*) &waypointsUnlocked);
        return waypointsUnlocked;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_AllWaypointsUnlocked, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_BloodDrainDisabled
    {
      get
      {
        int bloodDrainDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_BloodDrainDisabled, (void*) &bloodDrainDisabled);
        return bloodDrainDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_BloodDrainDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_BuildCostsDisabled
    {
      get
      {
        int buildCostsDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_BuildCostsDisabled, (void*) &buildCostsDisabled);
        return buildCostsDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_BuildCostsDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_BuildingPlacementRestrictionsDisabled
    {
      get
      {
        int restrictionsDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_BuildingPlacementRestrictionsDisabled, (void*) &restrictionsDisabled);
        return restrictionsDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_BuildingPlacementRestrictionsDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_BuildingReplacementDisabled
    {
      get
      {
        int replacementDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_BuildingReplacementDisabled, (void*) &replacementDisabled);
        return replacementDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_BuildingReplacementDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_CastleHeartBloodEssenceDisabled
    {
      get
      {
        int bloodEssenceDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_CastleHeartBloodEssenceDisabled, (void*) &bloodEssenceDisabled);
        return bloodEssenceDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_CastleHeartBloodEssenceDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_CastleHeartConnectionRequirementDisabled
    {
      get
      {
        int requirementDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_CastleHeartConnectionRequirementDisabled, (void*) &requirementDisabled);
        return requirementDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_CastleHeartConnectionRequirementDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_CastleLimitsDisabled
    {
      get
      {
        int castleLimitsDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_CastleLimitsDisabled, (void*) &castleLimitsDisabled);
        return castleLimitsDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_CastleLimitsDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_CooldownsDisabled
    {
      get
      {
        int cooldownsDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_CooldownsDisabled, (void*) &cooldownsDisabled);
        return cooldownsDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_CooldownsDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_DayNightCycleDisabled
    {
      get
      {
        int nightCycleDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DayNightCycleDisabled, (void*) &nightCycleDisabled);
        return nightCycleDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DayNightCycleDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_DisableDebugEvents
    {
      get
      {
        int disableDebugEvents;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DisableDebugEvents, (void*) &disableDebugEvents);
        return disableDebugEvents;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DisableDebugEvents, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_DropsDisabled
    {
      get
      {
        int settingsDropsDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DropsDisabled, (void*) &settingsDropsDisabled);
        return settingsDropsDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DropsDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_DurabilityDisabled
    {
      get
      {
        int durabilityDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DurabilityDisabled, (void*) &durabilityDisabled);
        return durabilityDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DurabilityDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_DynamicCloudsDisabled
    {
      get
      {
        int dynamicCloudsDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DynamicCloudsDisabled, (void*) &dynamicCloudsDisabled);
        return dynamicCloudsDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DynamicCloudsDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_DynamicCollisionDisabled
    {
      get
      {
        int collisionDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DynamicCollisionDisabled, (void*) &collisionDisabled);
        return collisionDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_DynamicCollisionDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_EveryoneIsAdmin
    {
      get
      {
        int settingsEveryoneIsAdmin;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_EveryoneIsAdmin, (void*) &settingsEveryoneIsAdmin);
        return settingsEveryoneIsAdmin;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_EveryoneIsAdmin, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_FeedWoundedRequirementDisabled
    {
      get
      {
        int requirementDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_FeedWoundedRequirementDisabled, (void*) &requirementDisabled);
        return requirementDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_FeedWoundedRequirementDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_FreeBuildingPlacementEnabled
    {
      get
      {
        int placementEnabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_FreeBuildingPlacementEnabled, (void*) &placementEnabled);
        return placementEnabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_FreeBuildingPlacementEnabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_GlobalCastleTerritoryEnabled
    {
      get
      {
        int territoryEnabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_GlobalCastleTerritoryEnabled, (void*) &territoryEnabled);
        return territoryEnabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_GlobalCastleTerritoryEnabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_HitEffectsDisabled
    {
      get
      {
        int hitEffectsDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_HitEffectsDisabled, (void*) &hitEffectsDisabled);
        return hitEffectsDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_HitEffectsDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_LightningStrikesDisabled
    {
      get
      {
        int lightningStrikesDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_LightningStrikesDisabled, (void*) &lightningStrikesDisabled);
        return lightningStrikesDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_LightningStrikesDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_LinnCastleRoofsEnabled
    {
      get
      {
        int castleRoofsEnabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_LinnCastleRoofsEnabled, (void*) &castleRoofsEnabled);
        return castleRoofsEnabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_LinnCastleRoofsEnabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_NPCsDisabled
    {
      get
      {
        int settingsNpCsDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_NPCsDisabled, (void*) &settingsNpCsDisabled);
        return settingsNpCsDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_NPCsDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_PlacementLogLevel
    {
      get
      {
        int placementLogLevel;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_PlacementLogLevel, (void*) &placementLogLevel);
        return placementLogLevel;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_PlacementLogLevel, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_PlayersInvulnerabilityEnabled
    {
      get
      {
        int invulnerabilityEnabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_PlayersInvulnerabilityEnabled, (void*) &invulnerabilityEnabled);
        return invulnerabilityEnabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_PlayersInvulnerabilityEnabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_RoofGenerationEnabled
    {
      get
      {
        int generationEnabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_RoofGenerationEnabled, (void*) &generationEnabled);
        return generationEnabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_RoofGenerationEnabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_SunDamageDisabled
    {
      get
      {
        int sunDamageDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_SunDamageDisabled, (void*) &sunDamageDisabled);
        return sunDamageDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_SunDamageDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_TileCollisionDisabled
    {
      get
      {
        int collisionDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_TileCollisionDisabled, (void*) &collisionDisabled);
        return collisionDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_TileCollisionDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_TutorialPopupsDisabled
    {
      get
      {
        int tutorialPopupsDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_TutorialPopupsDisabled, (void*) &tutorialPopupsDisabled);
        return tutorialPopupsDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_TutorialPopupsDisabled, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_UnlockAllVBloodsOnLaunch
    {
      get
      {
        int allVbloodsOnLaunch;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_UnlockAllVBloodsOnLaunch, (void*) &allVbloodsOnLaunch);
        return allVbloodsOnLaunch;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_UnlockAllVBloodsOnLaunch, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_UseDeathSequencesInsteadOfRagdolls
    {
      get
      {
        int insteadOfRagdolls;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_UseDeathSequencesInsteadOfRagdolls, (void*) &insteadOfRagdolls);
        return insteadOfRagdolls;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_UseDeathSequencesInsteadOfRagdolls, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_UseHeightRaycasting
    {
      get
      {
        int heightRaycasting;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_UseHeightRaycasting, (void*) &heightRaycasting);
        return heightRaycasting;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_UseHeightRaycasting, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_UseSunblockerChecksForFly
    {
      get
      {
        int sunblockerChecksForFly;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_UseSunblockerChecksForFly, (void*) &sunblockerChecksForFly);
        return sunblockerChecksForFly;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_UseSunblockerChecksForFly, (void*) &value);
      }
    }

    public static unsafe int FrameChangedIndex_SyncedServerDebugSettings_VbloodGhostsDisabled
    {
      get
      {
        int vbloodGhostsDisabled;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_VbloodGhostsDisabled, (void*) &vbloodGhostsDisabled);
        return vbloodGhostsDisabled;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_FrameChangedIndex_SyncedServerDebugSettings_VbloodGhostsDisabled, (void*) &value);
      }
    }

    public static unsafe int ComponentDataStartOffset_SyncedServerDebugSettings
    {
      get
      {
        int serverDebugSettings;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_ComponentDataStartOffset_SyncedServerDebugSettings, (void*) &serverDebugSettings);
        return serverDebugSettings;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_ComponentDataStartOffset_SyncedServerDebugSettings, (void*) &value);
      }
    }

    public static unsafe int ComponentDataSize_SyncedServerDebugSettings
    {
      get
      {
        int serverDebugSettings;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_ComponentDataSize_SyncedServerDebugSettings, (void*) &serverDebugSettings);
        return serverDebugSettings;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_ComponentDataSize_SyncedServerDebugSettings, (void*) &value);
      }
    }

    public static unsafe ulong CompBit_SyncedServerDebugSettings
    {
      get
      {
        ulong serverDebugSettings;
        IL2CPP.il2cpp_field_static_get_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_CompBit_SyncedServerDebugSettings, (void*) &serverDebugSettings);
        return serverDebugSettings;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Snapshot_cejhdeejck.NativeFieldInfoPtr_CompBit_SyncedServerDebugSettings, (void*) &value);
      }
    }
  }
}
