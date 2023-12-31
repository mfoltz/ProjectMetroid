// Decompiled with JetBrains decompiler
// Type: ProjectM.DestroyDebugReason
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

#nullable disable
namespace ProjectM
{
  public enum DestroyDebugReason : byte
  {
    None,
    Duration,
    Consume,
    OnHit,
    Transform,
    NoPlayerInRangeTimeout,
    Absorb,
    Movement,
    MinionMasterDeathAction,
    DestroyRoof,
    DestroyAfterDuration,
    ValidateInteractors,
    ResetCharacter,
    TryRemoveBuff,
    TrySpawnBuff,
    DestroyTileModels,
    TransitionJob,
    ActiveWorkstationSequenceSystem,
    Holy_RadialZone,
    DestroyIndoorMusicSequence,
    ServantTerminate,
    DestroyedParentOnAttach,
    Network,
    ImprisonedBuffSystem,
    DestroyPatrolAtEndOfRoute_NoDestroyBuffFound,
    DestroyPatrolAtEndOfRoute_DestroyBuffApplicationFailed,
    Forge,
    VbloodGhostBuffSequence,
    UntrackVbloodOnDeath,
    QuickStart,
    ForgeSystem_Sequences,
    DestroyAimPreview_NoValidOwner,
    ByScript,
    AttachToNullParent,
    AttachToSceneEntity,
  }
}
