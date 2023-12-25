// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.BehaviourTreeJobData
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.CastleBuilding;
using ProjectM.Pathfinding;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BehaviourTreeJobData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr_PostUpdateBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetAiDamageTakenEvent;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetAiPrioritization_State;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetFollower;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetMapCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetIsSpellControlled;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetSpawnedBy;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetMovePatrolState;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetServantConnectedCoffin;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleHeartConnection;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetPylonstation;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetIsTransformed;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetMiscAiGameplayData;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetTeam;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetGainAlertByVicinity;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetAlertModifiers;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetDead;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetStealthable;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetGlobalCooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetAbilityGroupComboState;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetBuffableFlagState;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetPathfinder;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetGenericCombatMovementData;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetLocalToWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetServantInteractPointLocalTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetSpawnTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetAiPointOfInterestTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetAiPointOfInterest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetAbilityGroupSlot;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetAiMoveSpeeds;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleFloor;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetCastleStairs;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetImprisoned;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetCastOptionStateBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetMinionBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetAbilityStateBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetAiMove_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetAiMove_Server;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetAbilityBar_Shared;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetAbilityCooldownState;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetAggroConsumer;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetEvaluateCastOptionsRequest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetPathRequest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetLastPathRequest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetEntityInput;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetLastTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetMovement;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetServantAssignedWorkstation;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetWorkstationAssignedServant;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetAggroBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetAlertBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetPathBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetUnsmoothedPathBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetPathRequestFilledSegmentBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetPathRequestSolveDebugBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetAbilityGroupSlotBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetFloatModificationBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetBehaviourTreeState;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleWorkstationEntitites;
    private static readonly System.IntPtr NativeFieldInfoPtr_AiDamageTakenEventEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr_Collision;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeltaTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ElapsedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_AiDebugEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_CooldownsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleHeartConnectionRequirementDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeOfDay;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabLookupMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlacementSpatialLookupParams;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_Randoms;
    private static readonly System.IntPtr NativeFieldInfoPtr_ThreadId;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProfilingParams;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRandom_Public_Random_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetRandom_Public_Void_Random_0;
    [FieldOffset(0)]
    public EntityCommandBuffer.ParallelWriter SpawnBarrier;
    [FieldOffset(16)]
    public EntityCommandBuffer.ParallelWriter PostUpdateBarrier;
    [FieldOffset(32)]
    public ComponentDataFromEntity<AiDamageTakenEvent> GetAiDamageTakenEvent;
    [FieldOffset(64)]
    public ComponentDataFromEntity<AiPrioritization_State> GetAiPrioritization_State;
    [FieldOffset(96)]
    public ComponentDataFromEntity<Rotation> GetRotation;
    [FieldOffset(128)]
    public ComponentDataFromEntity<Follower> GetFollower;
    [FieldOffset(160)]
    public ComponentDataFromEntity<Health> GetHealth;
    [FieldOffset(192)]
    public ComponentDataFromEntity<MapCollision> GetMapCollision;
    [FieldOffset(224)]
    public ComponentDataFromEntity<IsSpellControlled> GetIsSpellControlled;
    [FieldOffset(256)]
    public ComponentDataFromEntity<SpawnedBy> GetSpawnedBy;
    [FieldOffset(288)]
    public ComponentDataFromEntity<MovePatrolState> GetMovePatrolState;
    [FieldOffset(320)]
    public ComponentDataFromEntity<ServantConnectedCoffin> GetServantConnectedCoffin;
    [FieldOffset(352)]
    public ComponentDataFromEntity<CastleHeartConnection> GetCastleHeartConnection;
    [FieldOffset(384)]
    public ComponentDataFromEntity<Pylonstation> GetPylonstation;
    [FieldOffset(416)]
    public ComponentDataFromEntity<IsTransformed> GetIsTransformed;
    [FieldOffset(448)]
    public ComponentDataFromEntity<MiscAiGameplayData> GetMiscAiGameplayData;
    [FieldOffset(480)]
    public ComponentDataFromEntity<Team> GetTeam;
    [FieldOffset(512)]
    public ComponentDataFromEntity<GainAlertByVicinity> GetGainAlertByVicinity;
    [FieldOffset(544)]
    public ComponentDataFromEntity<AlertModifiers> GetAlertModifiers;
    [FieldOffset(576)]
    public ComponentDataFromEntity<Dead> GetDead;
    [FieldOffset(608)]
    public ComponentDataFromEntity<Stealthable> GetStealthable;
    [FieldOffset(640)]
    public ComponentDataFromEntity<PrefabGUID> GetPrefabGUID;
    [FieldOffset(672)]
    public ComponentDataFromEntity<GlobalCooldown> GetGlobalCooldown;
    [FieldOffset(704)]
    public ComponentDataFromEntity<AbilityGroupComboState> GetAbilityGroupComboState;
    [FieldOffset(736)]
    public ComponentDataFromEntity<BuffableFlagState> GetBuffableFlagState;
    [FieldOffset(768)]
    public ComponentDataFromEntity<Velocity> GetVelocity;
    [FieldOffset(800)]
    public ComponentDataFromEntity<Pathfinder> GetPathfinder;
    [FieldOffset(832)]
    public ComponentDataFromEntity<GenericCombatMovementData> GetGenericCombatMovementData;
    [FieldOffset(864)]
    public ComponentDataFromEntity<LocalToWorld> GetLocalToWorld;
    [FieldOffset(896)]
    public ComponentDataFromEntity<ServantInteractPointLocalTransform> GetServantInteractPointLocalTransform;
    [FieldOffset(928)]
    public ComponentDataFromEntity<SpawnTransform> GetSpawnTransform;
    [FieldOffset(960)]
    public ComponentDataFromEntity<AiPointOfInterestTarget> GetAiPointOfInterestTarget;
    [FieldOffset(992)]
    public ComponentDataFromEntity<AiPointOfInterest> GetAiPointOfInterest;
    [FieldOffset(1024)]
    public ComponentDataFromEntity<AbilityGroupSlot> GetAbilityGroupSlot;
    [FieldOffset(1056)]
    public ComponentDataFromEntity<AiMoveSpeeds> GetAiMoveSpeeds;
    [FieldOffset(1088)]
    public ComponentDataFromEntity<CastleFloor> GetCastleFloor;
    [FieldOffset(1120)]
    public ComponentDataFromEntity<CastleStairs> GetCastleStairs;
    [FieldOffset(1152)]
    public ComponentDataFromEntity<Imprisoned> GetImprisoned;
    [FieldOffset(1184)]
    public BufferFromEntity<CastOptionStateBuffer> GetCastOptionStateBuffer;
    [FieldOffset(1224)]
    public BufferFromEntity<MinionBuffer> GetMinionBuffer;
    [FieldOffset(1264)]
    public BufferFromEntity<AbilityStateBuffer> GetAbilityStateBuffer;
    [FieldOffset(1304)]
    public ComponentDataFromEntity<AiMove_Shared> GetAiMove_Shared;
    [FieldOffset(1336)]
    public ComponentDataFromEntity<AiMove_Server> GetAiMove_Server;
    [FieldOffset(1368)]
    public ComponentDataFromEntity<AbilityBar_Shared> GetAbilityBar_Shared;
    [FieldOffset(1400)]
    public ComponentDataFromEntity<AbilityCooldownState> GetAbilityCooldownState;
    [FieldOffset(1432)]
    public ComponentDataFromEntity<AggroConsumer> GetAggroConsumer;
    [FieldOffset(1464)]
    public ComponentDataFromEntity<EvaluateCastOptionsRequest> GetEvaluateCastOptionsRequest;
    [FieldOffset(1496)]
    public ComponentDataFromEntity<PathRequest> GetPathRequest;
    [FieldOffset(1528)]
    public ComponentDataFromEntity<LastPathRequest> GetLastPathRequest;
    [FieldOffset(1560)]
    public ComponentDataFromEntity<EntityInput> GetEntityInput;
    [FieldOffset(1592)]
    public ComponentDataFromEntity<Translation> GetTranslation;
    [FieldOffset(1624)]
    public ComponentDataFromEntity<LastTranslation> GetLastTranslation;
    [FieldOffset(1656)]
    public ComponentDataFromEntity<Movement> GetMovement;
    [FieldOffset(1688)]
    public ComponentDataFromEntity<ServantAssignedWorkstation> GetServantAssignedWorkstation;
    [FieldOffset(1720)]
    public ComponentDataFromEntity<WorkstationAssignedServant> GetWorkstationAssignedServant;
    [FieldOffset(1752)]
    public BufferFromEntity<AggroBuffer> GetAggroBuffer;
    [FieldOffset(1792)]
    public BufferFromEntity<AlertBuffer> GetAlertBuffer;
    [FieldOffset(1832)]
    public BufferFromEntity<PathBuffer> GetPathBuffer;
    [FieldOffset(1872)]
    public BufferFromEntity<UnsmoothedPathBuffer> GetUnsmoothedPathBuffer;
    [FieldOffset(1912)]
    public BufferFromEntity<PathRequestFilledSegmentBuffer> GetPathRequestFilledSegmentBuffer;
    [FieldOffset(1952)]
    public BufferFromEntity<PathRequestSolveDebugBuffer> GetPathRequestSolveDebugBuffer;
    [FieldOffset(1992)]
    public BufferFromEntity<AbilityGroupSlotBuffer> GetAbilityGroupSlotBuffer;
    [FieldOffset(2032)]
    public BufferFromEntity<FloatModificationBuffer> GetFloatModificationBuffer;
    [FieldOffset(2072)]
    public ComponentDataFromEntity<BehaviourTreeState> GetBehaviourTreeState;
    [FieldOffset(2104)]
    public NativeArray<Entity> CastleWorkstationEntitites;
    [FieldOffset(2120)]
    public NativeArray<Entity> AiDamageTakenEventEntities;
    [FieldOffset(2136)]
    public CollisionDetection Collision;
    [FieldOffset(2152)]
    public float DeltaTime;
    [FieldOffset(2160)]
    public double ElapsedTime;
    [FieldOffset(2168)]
    public int ServerFrame;
    [FieldOffset(2172)]
    public bool AiDebugEnabled;
    [FieldOffset(2173)]
    public bool CooldownsDisabled;
    [FieldOffset(2174)]
    public bool CastleHeartConnectionRequirementDisabled;
    [FieldOffset(2176)]
    public TimeOfDay TimeOfDay;
    [FieldOffset(2184)]
    public PrefabLookupMap PrefabLookupMap;
    [FieldOffset(2232)]
    public SpatialLookupParams PlacementSpatialLookupParams;
    [FieldOffset(2312)]
    public TileWorld TileWorld;
    [FieldOffset(2336)]
    public NativeArray<Unity.Mathematics.Random> Randoms;
    [FieldOffset(2352)]
    public int ThreadId;
    [FieldOffset(2356)]
    public BehaviourTreePartials.BehaviourTreeProfilingParams ProfilingParams;

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 1340137, RefRangeEnd = 1340151, XrefRangeStart = 1340137, XrefRangeEnd = 1340137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Unity.Mathematics.Random GetRandom()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BehaviourTreeJobData.NativeMethodInfoPtr_GetRandom_Public_Random_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Unity.Mathematics.Random*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 1340151, RefRangeEnd = 1340165, XrefRangeStart = 1340151, XrefRangeEnd = 1340151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetRandom(Unity.Mathematics.Random random)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &random;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BehaviourTreeJobData.NativeMethodInfoPtr_SetRandom_Public_Void_Random_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BehaviourTreeJobData()
    {
      Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (BehaviourTreeJobData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr);
      BehaviourTreeJobData.NativeFieldInfoPtr_SpawnBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (SpawnBarrier));
      BehaviourTreeJobData.NativeFieldInfoPtr_PostUpdateBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (PostUpdateBarrier));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetAiDamageTakenEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetAiDamageTakenEvent));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetAiPrioritization_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetAiPrioritization_State));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetRotation));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetFollower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetFollower));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetHealth));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetMapCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetMapCollision));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetIsSpellControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetIsSpellControlled));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetSpawnedBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetSpawnedBy));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetMovePatrolState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetMovePatrolState));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetServantConnectedCoffin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetServantConnectedCoffin));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetCastleHeartConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetCastleHeartConnection));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetPylonstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetPylonstation));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetIsTransformed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetIsTransformed));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetMiscAiGameplayData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetMiscAiGameplayData));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetTeam));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetGainAlertByVicinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetGainAlertByVicinity));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetAlertModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetAlertModifiers));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetDead));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetStealthable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetStealthable));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetPrefabGUID));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetGlobalCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetGlobalCooldown));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetAbilityGroupComboState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetAbilityGroupComboState));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetBuffableFlagState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetBuffableFlagState));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetVelocity));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetPathfinder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetPathfinder));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetGenericCombatMovementData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetGenericCombatMovementData));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetLocalToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetLocalToWorld));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetServantInteractPointLocalTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetServantInteractPointLocalTransform));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetSpawnTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetSpawnTransform));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetAiPointOfInterestTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetAiPointOfInterestTarget));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetAiPointOfInterest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetAiPointOfInterest));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetAbilityGroupSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetAbilityGroupSlot));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetAiMoveSpeeds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetAiMoveSpeeds));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetCastleFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetCastleFloor));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetCastleStairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetCastleStairs));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetImprisoned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetImprisoned));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetCastOptionStateBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetCastOptionStateBuffer));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetMinionBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetMinionBuffer));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetAbilityStateBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetAbilityStateBuffer));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetAiMove_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetAiMove_Shared));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetAiMove_Server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetAiMove_Server));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetAbilityBar_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetAbilityBar_Shared));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetAbilityCooldownState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetAbilityCooldownState));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetAggroConsumer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetAggroConsumer));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetEvaluateCastOptionsRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetEvaluateCastOptionsRequest));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetPathRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetPathRequest));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetLastPathRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetLastPathRequest));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetEntityInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetEntityInput));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetTranslation));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetLastTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetLastTranslation));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetMovement));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetServantAssignedWorkstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetServantAssignedWorkstation));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetWorkstationAssignedServant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetWorkstationAssignedServant));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetAggroBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetAggroBuffer));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetAlertBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetAlertBuffer));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetPathBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetPathBuffer));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetUnsmoothedPathBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetUnsmoothedPathBuffer));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetPathRequestFilledSegmentBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetPathRequestFilledSegmentBuffer));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetPathRequestSolveDebugBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetPathRequestSolveDebugBuffer));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetAbilityGroupSlotBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetAbilityGroupSlotBuffer));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetFloatModificationBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetFloatModificationBuffer));
      BehaviourTreeJobData.NativeFieldInfoPtr_GetBehaviourTreeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (GetBehaviourTreeState));
      BehaviourTreeJobData.NativeFieldInfoPtr_CastleWorkstationEntitites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (CastleWorkstationEntitites));
      BehaviourTreeJobData.NativeFieldInfoPtr_AiDamageTakenEventEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (AiDamageTakenEventEntities));
      BehaviourTreeJobData.NativeFieldInfoPtr_Collision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (Collision));
      BehaviourTreeJobData.NativeFieldInfoPtr_DeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (DeltaTime));
      BehaviourTreeJobData.NativeFieldInfoPtr_ElapsedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (ElapsedTime));
      BehaviourTreeJobData.NativeFieldInfoPtr_ServerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (ServerFrame));
      BehaviourTreeJobData.NativeFieldInfoPtr_AiDebugEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (AiDebugEnabled));
      BehaviourTreeJobData.NativeFieldInfoPtr_CooldownsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (CooldownsDisabled));
      BehaviourTreeJobData.NativeFieldInfoPtr_CastleHeartConnectionRequirementDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (CastleHeartConnectionRequirementDisabled));
      BehaviourTreeJobData.NativeFieldInfoPtr_TimeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (TimeOfDay));
      BehaviourTreeJobData.NativeFieldInfoPtr_PrefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (PrefabLookupMap));
      BehaviourTreeJobData.NativeFieldInfoPtr_PlacementSpatialLookupParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (PlacementSpatialLookupParams));
      BehaviourTreeJobData.NativeFieldInfoPtr_TileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (TileWorld));
      BehaviourTreeJobData.NativeFieldInfoPtr_Randoms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (Randoms));
      BehaviourTreeJobData.NativeFieldInfoPtr_ThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (ThreadId));
      BehaviourTreeJobData.NativeFieldInfoPtr_ProfilingParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, nameof (ProfilingParams));
      BehaviourTreeJobData.NativeMethodInfoPtr_GetRandom_Public_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, 100665040);
      BehaviourTreeJobData.NativeMethodInfoPtr_SetRandom_Public_Void_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, 100665041);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BehaviourTreeJobData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
