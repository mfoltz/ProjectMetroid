// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnMinionOnGameplayEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpawnMinionOnGameplayEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Location;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabPickMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_EventTargetAggroBoost;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistanceFromPreCombatPositionOverride;
    private static readonly System.IntPtr NativeFieldInfoPtr_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_IncludeInMinionCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanBeConsumed;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideBloodQualityCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceBadBloodQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerMasterDeathActionOnDowned;
    private static readonly System.IntPtr NativeFieldInfoPtr_InheritOwnerFaction;
    private static readonly System.IntPtr NativeFieldInfoPtr_InheritOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_MasterDeathAction;
    private static readonly System.IntPtr NativeFieldInfoPtr_MasterDeathBuffPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlobData;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatsOverrides;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0;
    [FieldOffset(0)]
    public SpawnMiniononGameplayEventLocation Location;
    [FieldOffset(4)]
    public SpawnMinionOnGameplayEventRotation Rotation;
    [FieldOffset(8)]
    public SpawnMinionOnGameplayEventPrefabPickMode PrefabPickMode;
    [FieldOffset(12)]
    public float MinDistance;
    [FieldOffset(16)]
    public float MaxDistance;
    [FieldOffset(20)]
    public float EventTargetAggroBoost;
    [FieldOffset(24)]
    public float MaxDistanceFromPreCombatPositionOverride;
    [FieldOffset(28)]
    public int Count;
    [FieldOffset(32)]
    public bool IncludeInMinionCount;
    [FieldOffset(33)]
    public bool CanBeConsumed;
    [FieldOffset(36)]
    public CurveReference OverrideBloodQualityCurve;
    [FieldOffset(44)]
    public bool ForceBadBloodQuality;
    [FieldOffset(45)]
    public bool TriggerMasterDeathActionOnDowned;
    [FieldOffset(46)]
    public bool InheritOwnerFaction;
    [FieldOffset(47)]
    public bool InheritOwner;
    [FieldOffset(48)]
    public MinionMasterDeathAction MasterDeathAction;
    [FieldOffset(52)]
    public PrefabGUID MasterDeathBuffPrefabGuid;
    [FieldOffset(56)]
    public BlobAssetReference<SpawnMinionOnGameplayEventBlob> BlobData;
    [FieldOffset(64)]
    public SequenceGUID SpawnSequenceGuid;
    [FieldOffset(68)]
    public SpawnMinionOnGameplayEventStatsOverrides StatsOverrides;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008368, XrefRangeEnd = 1008376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ApplyArithmetic(SpellModArithmetic spellMod, float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnMinionOnGameplayEvent.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpawnMinionOnGameplayEvent()
    {
      Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SpawnMinionOnGameplayEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr);
      SpawnMinionOnGameplayEvent.NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr, nameof (Location));
      SpawnMinionOnGameplayEvent.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr, nameof (Rotation));
      SpawnMinionOnGameplayEvent.NativeFieldInfoPtr_PrefabPickMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr, nameof (PrefabPickMode));
      SpawnMinionOnGameplayEvent.NativeFieldInfoPtr_MinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr, nameof (MinDistance));
      SpawnMinionOnGameplayEvent.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr, nameof (MaxDistance));
      SpawnMinionOnGameplayEvent.NativeFieldInfoPtr_EventTargetAggroBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr, nameof (EventTargetAggroBoost));
      SpawnMinionOnGameplayEvent.NativeFieldInfoPtr_MaxDistanceFromPreCombatPositionOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr, nameof (MaxDistanceFromPreCombatPositionOverride));
      SpawnMinionOnGameplayEvent.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr, nameof (Count));
      SpawnMinionOnGameplayEvent.NativeFieldInfoPtr_IncludeInMinionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr, nameof (IncludeInMinionCount));
      SpawnMinionOnGameplayEvent.NativeFieldInfoPtr_CanBeConsumed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr, nameof (CanBeConsumed));
      SpawnMinionOnGameplayEvent.NativeFieldInfoPtr_OverrideBloodQualityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr, nameof (OverrideBloodQualityCurve));
      SpawnMinionOnGameplayEvent.NativeFieldInfoPtr_ForceBadBloodQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr, nameof (ForceBadBloodQuality));
      SpawnMinionOnGameplayEvent.NativeFieldInfoPtr_TriggerMasterDeathActionOnDowned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr, nameof (TriggerMasterDeathActionOnDowned));
      SpawnMinionOnGameplayEvent.NativeFieldInfoPtr_InheritOwnerFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr, nameof (InheritOwnerFaction));
      SpawnMinionOnGameplayEvent.NativeFieldInfoPtr_InheritOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr, nameof (InheritOwner));
      SpawnMinionOnGameplayEvent.NativeFieldInfoPtr_MasterDeathAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr, nameof (MasterDeathAction));
      SpawnMinionOnGameplayEvent.NativeFieldInfoPtr_MasterDeathBuffPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr, nameof (MasterDeathBuffPrefabGuid));
      SpawnMinionOnGameplayEvent.NativeFieldInfoPtr_BlobData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr, nameof (BlobData));
      SpawnMinionOnGameplayEvent.NativeFieldInfoPtr_SpawnSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr, nameof (SpawnSequenceGuid));
      SpawnMinionOnGameplayEvent.NativeFieldInfoPtr_StatsOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr, nameof (StatsOverrides));
      SpawnMinionOnGameplayEvent.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr, 100678342);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnMinionOnGameplayEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
