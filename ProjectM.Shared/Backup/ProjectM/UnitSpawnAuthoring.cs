// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitSpawnAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class UnitSpawnAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_UnitCompositionPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_SingleSpawnPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_SpawnType;
    private static readonly IntPtr NativeFieldInfoPtr_SpawnPattern;
    private static readonly IntPtr NativeFieldInfoPtr_DefaultAIState;
    private static readonly IntPtr NativeFieldInfoPtr_RespawnTimeModifier;
    private static readonly IntPtr NativeFieldInfoPtr_Formation;
    private static readonly IntPtr NativeFieldInfoPtr_PatrolPath;
    private static readonly IntPtr NativeFieldInfoPtr_PatrolType;
    private static readonly IntPtr NativeFieldInfoPtr_PatrolEndDespawnBuff;
    private static readonly IntPtr NativeFieldInfoPtr_PatrolSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_PatrolSpeedSetting;
    private static readonly IntPtr NativeFieldInfoPtr_ActivePlayerRangeSetting;
    private static readonly IntPtr NativeFieldInfoPtr_CompositionSpawnDelay;
    private static readonly IntPtr NativeFieldInfoPtr_Color;
    private static readonly IntPtr NativeFieldInfoPtr_TimeRequirement;
    private static readonly IntPtr NativeFieldInfoPtr_RandomSpawnDelay;
    private static readonly IntPtr NativeFieldInfoPtr_UnitUptimeSettings;
    private static readonly IntPtr NativeFieldInfoPtr_VBloodMapIcon;
    private static readonly IntPtr NativeFieldInfoPtr_SpawnProbabilitySetting;
    private static readonly IntPtr NativeFieldInfoPtr_SpawnProbability;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_ProjectM_Shared_IChunkSummaryDataSource_FillTree_Private_Virtual_Final_New_Void_ChunkSummaryBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763082, XrefRangeEnd = 763088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitSpawnAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ProjectM_Shared_IChunkSummaryDataSource_FillTree(
      ChunkSummaryBuilder summary)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) summary);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitSpawnAuthoring.NativeMethodInfoPtr_ProjectM_Shared_IChunkSummaryDataSource_FillTree_Private_Virtual_Final_New_Void_ChunkSummaryBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763088, XrefRangeEnd = 763103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnitSpawnAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitSpawnAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnitSpawnAuthoring()
    {
      Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UnitSpawnAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr);
      UnitSpawnAuthoring.NativeFieldInfoPtr_UnitCompositionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, nameof (UnitCompositionPrefab));
      UnitSpawnAuthoring.NativeFieldInfoPtr_SingleSpawnPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, nameof (SingleSpawnPrefab));
      UnitSpawnAuthoring.NativeFieldInfoPtr_SpawnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, nameof (SpawnType));
      UnitSpawnAuthoring.NativeFieldInfoPtr_SpawnPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, nameof (SpawnPattern));
      UnitSpawnAuthoring.NativeFieldInfoPtr_DefaultAIState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, nameof (DefaultAIState));
      UnitSpawnAuthoring.NativeFieldInfoPtr_RespawnTimeModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, nameof (RespawnTimeModifier));
      UnitSpawnAuthoring.NativeFieldInfoPtr_Formation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, nameof (Formation));
      UnitSpawnAuthoring.NativeFieldInfoPtr_PatrolPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, nameof (PatrolPath));
      UnitSpawnAuthoring.NativeFieldInfoPtr_PatrolType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, nameof (PatrolType));
      UnitSpawnAuthoring.NativeFieldInfoPtr_PatrolEndDespawnBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, nameof (PatrolEndDespawnBuff));
      UnitSpawnAuthoring.NativeFieldInfoPtr_PatrolSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, nameof (PatrolSpeed));
      UnitSpawnAuthoring.NativeFieldInfoPtr_PatrolSpeedSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, nameof (PatrolSpeedSetting));
      UnitSpawnAuthoring.NativeFieldInfoPtr_ActivePlayerRangeSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, nameof (ActivePlayerRangeSetting));
      UnitSpawnAuthoring.NativeFieldInfoPtr_CompositionSpawnDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, nameof (CompositionSpawnDelay));
      UnitSpawnAuthoring.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, nameof (Color));
      UnitSpawnAuthoring.NativeFieldInfoPtr_TimeRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, nameof (TimeRequirement));
      UnitSpawnAuthoring.NativeFieldInfoPtr_RandomSpawnDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, nameof (RandomSpawnDelay));
      UnitSpawnAuthoring.NativeFieldInfoPtr_UnitUptimeSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, nameof (UnitUptimeSettings));
      UnitSpawnAuthoring.NativeFieldInfoPtr_VBloodMapIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, nameof (VBloodMapIcon));
      UnitSpawnAuthoring.NativeFieldInfoPtr_SpawnProbabilitySetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, nameof (SpawnProbabilitySetting));
      UnitSpawnAuthoring.NativeFieldInfoPtr_SpawnProbability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, nameof (SpawnProbability));
      UnitSpawnAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, 100667415);
      UnitSpawnAuthoring.NativeMethodInfoPtr_ProjectM_Shared_IChunkSummaryDataSource_FillTree_Private_Virtual_Final_New_Void_ChunkSummaryBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, 100667416);
      UnitSpawnAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitSpawnAuthoring>.NativeClassPtr, 100667417);
    }

    public UnitSpawnAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WeakAssetReference<UnitCompositionAuthoring> UnitCompositionPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_UnitCompositionPrefab));
        return pointer == IntPtr.Zero ? (WeakAssetReference<UnitCompositionAuthoring>) null : new WeakAssetReference<UnitCompositionAuthoring>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_UnitCompositionPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> SingleSpawnPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_SingleSpawnPrefab));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_SingleSpawnPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnitSpawnAuthoring.UnitSpawnType SpawnType
    {
      get
      {
        return *(UnitSpawnAuthoring.UnitSpawnType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_SpawnType));
      }
      [param: In] set
      {
        *(UnitSpawnAuthoring.UnitSpawnType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_SpawnType)) = value;
      }
    }

    public unsafe UnitSpawnAuthoring.UnitSpawnPattern SpawnPattern
    {
      get
      {
        return *(UnitSpawnAuthoring.UnitSpawnPattern*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_SpawnPattern));
      }
      [param: In] set
      {
        *(UnitSpawnAuthoring.UnitSpawnPattern*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_SpawnPattern)) = value;
      }
    }

    public unsafe UnitSpawnAuthoring.UnitDefaultAIState DefaultAIState
    {
      get
      {
        return *(UnitSpawnAuthoring.UnitDefaultAIState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_DefaultAIState));
      }
      [param: In] set
      {
        *(UnitSpawnAuthoring.UnitDefaultAIState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_DefaultAIState)) = value;
      }
    }

    public unsafe float RespawnTimeModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_RespawnTimeModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_RespawnTimeModifier)) = value;
      }
    }

    public unsafe UnitFormationAuthoring Formation
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_Formation));
        return pointer == IntPtr.Zero ? (UnitFormationAuthoring) null : new UnitFormationAuthoring(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_Formation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PathAuthoring PatrolPath
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_PatrolPath));
        return pointer == IntPtr.Zero ? (PathAuthoring) null : new PathAuthoring(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_PatrolPath), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PatrolType PatrolType
    {
      get
      {
        return *(PatrolType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_PatrolType));
      }
      [param: In] set
      {
        *(PatrolType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_PatrolType)) = value;
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> PatrolEndDespawnBuff
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_PatrolEndDespawnBuff));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_PatrolEndDespawnBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float PatrolSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_PatrolSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_PatrolSpeed)) = value;
      }
    }

    public unsafe PatrolSpeedSettings PatrolSpeedSetting
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_PatrolSpeedSetting));
        return pointer == IntPtr.Zero ? (PatrolSpeedSettings) null : new PatrolSpeedSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_PatrolSpeedSetting), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PlayerProximitySettings ActivePlayerRangeSetting
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_ActivePlayerRangeSetting));
        return pointer == IntPtr.Zero ? (PlayerProximitySettings) null : new PlayerProximitySettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_ActivePlayerRangeSetting), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnitRespawnSettings CompositionSpawnDelay
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_CompositionSpawnDelay));
        return pointer == IntPtr.Zero ? (UnitRespawnSettings) null : new UnitRespawnSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_CompositionSpawnDelay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color Color
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_Color));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_Color)) = value;
      }
    }

    public unsafe DayTimeSpanSettings TimeRequirement
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_TimeRequirement));
        return pointer == IntPtr.Zero ? (DayTimeSpanSettings) null : new DayTimeSpanSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_TimeRequirement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DateDelaySetting RandomSpawnDelay
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_RandomSpawnDelay));
        return pointer == IntPtr.Zero ? (DateDelaySetting) null : new DateDelaySetting(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_RandomSpawnDelay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnitUptimeSettings UnitUptimeSettings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_UnitUptimeSettings));
        return pointer == IntPtr.Zero ? (UnitUptimeSettings) null : new UnitUptimeSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_UnitUptimeSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MapIconAuthoring VBloodMapIcon
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_VBloodMapIcon));
        return pointer == IntPtr.Zero ? (MapIconAuthoring) null : new MapIconAuthoring(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_VBloodMapIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpawnProbabilitySettings SpawnProbabilitySetting
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_SpawnProbabilitySetting));
        return pointer == IntPtr.Zero ? (SpawnProbabilitySettings) null : new SpawnProbabilitySettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_SpawnProbabilitySetting), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float SpawnProbability
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_SpawnProbability));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitSpawnAuthoring.NativeFieldInfoPtr_SpawnProbability)) = value;
      }
    }

    public enum UnitSpawnType
    {
      StaticFormation,
      StaticCustomFormation,
      Patrolling,
    }

    public enum UnitSpawnPattern
    {
      InOrder,
      Random,
    }

    public enum UnitDefaultAIState
    {
      Roaming,
      Guard,
    }
  }
}
