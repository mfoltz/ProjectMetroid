// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitCompositionSpawner
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UnitCompositionSpawner
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitCompositionId;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTimeRequirement;
    private static readonly System.IntPtr NativeFieldInfoPtr_RespawnTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_RespawnTimeModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRespawnTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinRespawnTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_PositionSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_UptimeSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnDelayMinMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyWhenAllDead;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseRandomSpawn;
    private static readonly System.IntPtr NativeFieldInfoPtr_Initialized;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnerState;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnDelayFrom;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnDelayTo;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnDelayTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnProbability;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentSpawnProbability;
    private static readonly System.IntPtr NativeFieldInfoPtr_WasDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_Guard;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_PatrolEndedDespawnBuffPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnBuffKind;
    [FieldOffset(0)]
    public UnitCompositionId UnitCompositionId;
    [FieldOffset(4)]
    public DayTimeSpan CurrentTimeRequirement;
    [FieldOffset(16)]
    public Nullable_Unboxed<double> RespawnTime;
    [FieldOffset(32)]
    public float RespawnTimeModifier;
    [FieldOffset(36)]
    public float MaxRespawnTime;
    [FieldOffset(40)]
    public float MinRespawnTime;
    [FieldOffset(44)]
    public Entity PositionSource;
    [FieldOffset(52)]
    public PrefabGUID UptimeSettings;
    [FieldOffset(56)]
    public float2 PlayerRange;
    [FieldOffset(64)]
    public float2 SpawnDelayMinMax;
    [FieldOffset(72)]
    public bool DestroyWhenAllDead;
    [FieldOffset(73)]
    public bool UseRandomSpawn;
    [FieldOffset(74)]
    public bool Initialized;
    [FieldOffset(76)]
    public UnitCompositionSpawner.State SpawnerState;
    [FieldOffset(80)]
    public DateDuration SpawnDelayFrom;
    [FieldOffset(108)]
    public DateDuration SpawnDelayTo;
    [FieldOffset(136)]
    public double SpawnDelayTime;
    [FieldOffset(144)]
    public float SpawnProbability;
    [FieldOffset(148)]
    public float CurrentSpawnProbability;
    [FieldOffset(152)]
    public bool WasDisabled;
    [FieldOffset(153)]
    public bool Guard;
    [FieldOffset(160)]
    public double SpawnTime;
    [FieldOffset(168)]
    public PrefabGUID PatrolEndedDespawnBuffPrefabGuid;
    [FieldOffset(172)]
    public SpawnBuffKind SpawnBuffKind;

    static UnitCompositionSpawner()
    {
      Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UnitCompositionSpawner));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr);
      UnitCompositionSpawner.NativeFieldInfoPtr_UnitCompositionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (UnitCompositionId));
      UnitCompositionSpawner.NativeFieldInfoPtr_CurrentTimeRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (CurrentTimeRequirement));
      UnitCompositionSpawner.NativeFieldInfoPtr_RespawnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (RespawnTime));
      UnitCompositionSpawner.NativeFieldInfoPtr_RespawnTimeModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (RespawnTimeModifier));
      UnitCompositionSpawner.NativeFieldInfoPtr_MaxRespawnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (MaxRespawnTime));
      UnitCompositionSpawner.NativeFieldInfoPtr_MinRespawnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (MinRespawnTime));
      UnitCompositionSpawner.NativeFieldInfoPtr_PositionSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (PositionSource));
      UnitCompositionSpawner.NativeFieldInfoPtr_UptimeSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (UptimeSettings));
      UnitCompositionSpawner.NativeFieldInfoPtr_PlayerRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (PlayerRange));
      UnitCompositionSpawner.NativeFieldInfoPtr_SpawnDelayMinMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (SpawnDelayMinMax));
      UnitCompositionSpawner.NativeFieldInfoPtr_DestroyWhenAllDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (DestroyWhenAllDead));
      UnitCompositionSpawner.NativeFieldInfoPtr_UseRandomSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (UseRandomSpawn));
      UnitCompositionSpawner.NativeFieldInfoPtr_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (Initialized));
      UnitCompositionSpawner.NativeFieldInfoPtr_SpawnerState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (SpawnerState));
      UnitCompositionSpawner.NativeFieldInfoPtr_SpawnDelayFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (SpawnDelayFrom));
      UnitCompositionSpawner.NativeFieldInfoPtr_SpawnDelayTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (SpawnDelayTo));
      UnitCompositionSpawner.NativeFieldInfoPtr_SpawnDelayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (SpawnDelayTime));
      UnitCompositionSpawner.NativeFieldInfoPtr_SpawnProbability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (SpawnProbability));
      UnitCompositionSpawner.NativeFieldInfoPtr_CurrentSpawnProbability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (CurrentSpawnProbability));
      UnitCompositionSpawner.NativeFieldInfoPtr_WasDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (WasDisabled));
      UnitCompositionSpawner.NativeFieldInfoPtr_Guard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (Guard));
      UnitCompositionSpawner.NativeFieldInfoPtr_SpawnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (SpawnTime));
      UnitCompositionSpawner.NativeFieldInfoPtr_PatrolEndedDespawnBuffPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (PatrolEndedDespawnBuffPrefabGuid));
      UnitCompositionSpawner.NativeFieldInfoPtr_SpawnBuffKind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, nameof (SpawnBuffKind));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionSpawner>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public enum State
    {
      Inactive,
      WaitingForSpawn,
      Active,
      WaitingForDespawn,
    }
  }
}
