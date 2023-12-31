// Decompiled with JetBrains decompiler
// Type: ProjectM.SyncedServerDebugSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding.Placement;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SyncedServerDebugSettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SunDamageDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_DurabilityDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodDrainDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_CooldownsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuildCostsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_TutorialPopupsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllProgressionUnlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockAllVBloodsOnLaunch;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayersInvulnerabilityEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayNightCycleDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_NPCsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_GlobalCastleTerritoryEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuildingPlacementRestrictionsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FreeBuildingPlacementEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuildingReplacementDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleHeartConnectionRequirementDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllWaypointsUnlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_AggroDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_DropsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseHeightRaycasting;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileCollisionDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCollisionDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_DynamicCloudsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitEffectsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_RoofGenerationEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_LinnCastleRoofsEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_FeedWoundedRequirementDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseSunblockerChecksForFly;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleLimitsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseDeathSequencesInsteadOfRagdolls;
    private static readonly System.IntPtr NativeFieldInfoPtr_DisableDebugEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr_AdminOnlyDebugEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr_EveryoneIsAdmin;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleHeartBloodEssenceDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_AiCastsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_LightningStrikesDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_VbloodGhostsDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlacementLogLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr__Initialized;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Boolean_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetServerDebugSettings_Private_Boolean_byref_ServerDebugSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetServerDebugSettings_Private_Boolean_World_byref_ServerDebugSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyFromSettings_Public_Void_ServerDebugSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetSetting_Public_Void_World_DebugSettingType_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetPlacementLogLevel_Public_Void_World_PlacementLogLevel_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SaveToSettingsFile_Private_Void_World_DebugSettingType_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_SyncedServerDebugSettings_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_SyncedServerDebugSettings_ComponentSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_SyncedServerDebugSettings_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSmart_Public_Static_SyncedServerDebugSettings_SingletonAccessor_1_SyncedServerDebugSettings_0;
    [FieldOffset(0)]
    public bool SunDamageDisabled;
    [FieldOffset(1)]
    public bool DurabilityDisabled;
    [FieldOffset(2)]
    public bool BloodDrainDisabled;
    [FieldOffset(3)]
    public bool CooldownsDisabled;
    [FieldOffset(4)]
    public bool BuildCostsDisabled;
    [FieldOffset(5)]
    public bool TutorialPopupsDisabled;
    [FieldOffset(6)]
    public bool AllProgressionUnlocked;
    [FieldOffset(7)]
    public bool UnlockAllVBloodsOnLaunch;
    [FieldOffset(8)]
    public bool PlayersInvulnerabilityEnabled;
    [FieldOffset(9)]
    public bool DayNightCycleDisabled;
    [FieldOffset(10)]
    public bool NPCsDisabled;
    [FieldOffset(11)]
    public bool GlobalCastleTerritoryEnabled;
    [FieldOffset(12)]
    public bool BuildingPlacementRestrictionsDisabled;
    [FieldOffset(13)]
    public bool FreeBuildingPlacementEnabled;
    [FieldOffset(14)]
    public bool BuildingReplacementDisabled;
    [FieldOffset(15)]
    public bool CastleHeartConnectionRequirementDisabled;
    [FieldOffset(16)]
    public bool AllWaypointsUnlocked;
    [FieldOffset(17)]
    public bool AggroDisabled;
    [FieldOffset(18)]
    public bool DropsDisabled;
    [FieldOffset(19)]
    public bool UseHeightRaycasting;
    [FieldOffset(20)]
    public bool TileCollisionDisabled;
    [FieldOffset(21)]
    public bool DynamicCollisionDisabled;
    [FieldOffset(22)]
    public bool DynamicCloudsDisabled;
    [FieldOffset(23)]
    public bool HitEffectsDisabled;
    [FieldOffset(24)]
    public bool RoofGenerationEnabled;
    [FieldOffset(25)]
    public bool LinnCastleRoofsEnabled;
    [FieldOffset(26)]
    public bool FeedWoundedRequirementDisabled;
    [FieldOffset(27)]
    public bool UseSunblockerChecksForFly;
    [FieldOffset(28)]
    public bool CastleLimitsDisabled;
    [FieldOffset(29)]
    public bool UseDeathSequencesInsteadOfRagdolls;
    [FieldOffset(30)]
    public bool DisableDebugEvents;
    [FieldOffset(31)]
    public bool AdminOnlyDebugEvents;
    [FieldOffset(32)]
    public bool EveryoneIsAdmin;
    [FieldOffset(33)]
    public bool CastleHeartBloodEssenceDisabled;
    [FieldOffset(34)]
    public bool AiCastsDisabled;
    [FieldOffset(35)]
    public bool LightningStrikesDisabled;
    [FieldOffset(36)]
    public bool VbloodGhostsDisabled;
    [FieldOffset(37)]
    public PlacementLogLevel PlacementLogLevel;
    [FieldOffset(38)]
    public bool _Initialized;

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 734223, RefRangeEnd = 734228, XrefRangeStart = 734222, XrefRangeEnd = 734223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize(
      bool disableDebugEvents = false,
      bool adminOnlyDebugEvents = false,
      bool everyoneIsAdmin = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &disableDebugEvents;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &adminOnlyDebugEvents;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &everyoneIsAdmin;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncedServerDebugSettings.NativeMethodInfoPtr_Initialize_Public_Void_Boolean_Boolean_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 734237, RefRangeEnd = 734238, XrefRangeStart = 734228, XrefRangeEnd = 734237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetServerDebugSettings(out ServerDebugSettings settings)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncedServerDebugSettings.NativeMethodInfoPtr_TryGetServerDebugSettings_Private_Boolean_byref_ServerDebugSettings_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ServerDebugSettings local = ref settings;
      System.IntPtr pointer = zero;
      ServerDebugSettings serverDebugSettings = pointer == System.IntPtr.Zero ? (ServerDebugSettings) null : new ServerDebugSettings(pointer);
      local = serverDebugSettings;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734238, XrefRangeEnd = 734244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetServerDebugSettings(
      World serverWorld,
      out ServerDebugSettings settings)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serverWorld);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SyncedServerDebugSettings.NativeMethodInfoPtr_TryGetServerDebugSettings_Private_Boolean_World_byref_ServerDebugSettings_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ServerDebugSettings local = ref settings;
      System.IntPtr pointer = zero;
      ServerDebugSettings serverDebugSettings = pointer == System.IntPtr.Zero ? (ServerDebugSettings) null : new ServerDebugSettings(pointer);
      local = serverDebugSettings;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 734244, RefRangeEnd = 734245, XrefRangeStart = 734244, XrefRangeEnd = 734244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplyFromSettings(ServerDebugSettings settings)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) settings);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncedServerDebugSettings.NativeMethodInfoPtr_ApplyFromSettings_Public_Void_ServerDebugSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 734246, RefRangeEnd = 734247, XrefRangeStart = 734245, XrefRangeEnd = 734246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetSetting(World serverWorld, DebugSettingType type, bool value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serverWorld);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncedServerDebugSettings.NativeMethodInfoPtr_SetSetting_Public_Void_World_DebugSettingType_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734247, XrefRangeEnd = 734258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetPlacementLogLevel(World serverWorld, PlacementLogLevel placementLogLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serverWorld);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &placementLogLevel;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncedServerDebugSettings.NativeMethodInfoPtr_SetPlacementLogLevel_Public_Void_World_PlacementLogLevel_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 734302, RefRangeEnd = 734303, XrefRangeStart = 734258, XrefRangeEnd = 734302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SaveToSettingsFile(World serverWorld, DebugSettingType type, bool value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serverWorld);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SyncedServerDebugSettings.NativeMethodInfoPtr_SaveToSettingsFile_Private_Void_World_DebugSettingType_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(65)]
    [CachedScanResults(RefRangeStart = 734311, RefRangeEnd = 734376, XrefRangeStart = 734303, XrefRangeEnd = 734311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SyncedServerDebugSettings Get(ComponentSystemBase systemBase)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncedServerDebugSettings.NativeMethodInfoPtr_Get_Public_Static_SyncedServerDebugSettings_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SyncedServerDebugSettings*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(39)]
    [CachedScanResults(RefRangeStart = 734384, RefRangeEnd = 734423, XrefRangeStart = 734376, XrefRangeEnd = 734384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SyncedServerDebugSettings Get(ComponentSystem componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncedServerDebugSettings.NativeMethodInfoPtr_Get_Public_Static_SyncedServerDebugSettings_ComponentSystem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SyncedServerDebugSettings*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 734440, RefRangeEnd = 734448, XrefRangeStart = 734423, XrefRangeEnd = 734440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SyncedServerDebugSettings Get(EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncedServerDebugSettings.NativeMethodInfoPtr_Get_Public_Static_SyncedServerDebugSettings_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SyncedServerDebugSettings*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(40)]
    [CachedScanResults(RefRangeStart = 734456, RefRangeEnd = 734496, XrefRangeStart = 734448, XrefRangeEnd = 734456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SyncedServerDebugSettings GetSmart(
      SingletonAccessor<SyncedServerDebugSettings> serverDebugSettings)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &serverDebugSettings;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncedServerDebugSettings.NativeMethodInfoPtr_GetSmart_Public_Static_SyncedServerDebugSettings_SingletonAccessor_1_SyncedServerDebugSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SyncedServerDebugSettings*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SyncedServerDebugSettings()
    {
      Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SyncedServerDebugSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr);
      SyncedServerDebugSettings.NativeFieldInfoPtr_SunDamageDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (SunDamageDisabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_DurabilityDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (DurabilityDisabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_BloodDrainDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (BloodDrainDisabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_CooldownsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (CooldownsDisabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_BuildCostsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (BuildCostsDisabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_TutorialPopupsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (TutorialPopupsDisabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_AllProgressionUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (AllProgressionUnlocked));
      SyncedServerDebugSettings.NativeFieldInfoPtr_UnlockAllVBloodsOnLaunch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (UnlockAllVBloodsOnLaunch));
      SyncedServerDebugSettings.NativeFieldInfoPtr_PlayersInvulnerabilityEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (PlayersInvulnerabilityEnabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_DayNightCycleDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (DayNightCycleDisabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_NPCsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (NPCsDisabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_GlobalCastleTerritoryEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (GlobalCastleTerritoryEnabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_BuildingPlacementRestrictionsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (BuildingPlacementRestrictionsDisabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_FreeBuildingPlacementEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (FreeBuildingPlacementEnabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_BuildingReplacementDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (BuildingReplacementDisabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_CastleHeartConnectionRequirementDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (CastleHeartConnectionRequirementDisabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_AllWaypointsUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (AllWaypointsUnlocked));
      SyncedServerDebugSettings.NativeFieldInfoPtr_AggroDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (AggroDisabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_DropsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (DropsDisabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_UseHeightRaycasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (UseHeightRaycasting));
      SyncedServerDebugSettings.NativeFieldInfoPtr_TileCollisionDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (TileCollisionDisabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_DynamicCollisionDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (DynamicCollisionDisabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_DynamicCloudsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (DynamicCloudsDisabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_HitEffectsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (HitEffectsDisabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_RoofGenerationEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (RoofGenerationEnabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_LinnCastleRoofsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (LinnCastleRoofsEnabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_FeedWoundedRequirementDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (FeedWoundedRequirementDisabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_UseSunblockerChecksForFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (UseSunblockerChecksForFly));
      SyncedServerDebugSettings.NativeFieldInfoPtr_CastleLimitsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (CastleLimitsDisabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_UseDeathSequencesInsteadOfRagdolls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (UseDeathSequencesInsteadOfRagdolls));
      SyncedServerDebugSettings.NativeFieldInfoPtr_DisableDebugEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (DisableDebugEvents));
      SyncedServerDebugSettings.NativeFieldInfoPtr_AdminOnlyDebugEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (AdminOnlyDebugEvents));
      SyncedServerDebugSettings.NativeFieldInfoPtr_EveryoneIsAdmin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (EveryoneIsAdmin));
      SyncedServerDebugSettings.NativeFieldInfoPtr_CastleHeartBloodEssenceDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (CastleHeartBloodEssenceDisabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_AiCastsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (AiCastsDisabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_LightningStrikesDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (LightningStrikesDisabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_VbloodGhostsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (VbloodGhostsDisabled));
      SyncedServerDebugSettings.NativeFieldInfoPtr_PlacementLogLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (PlacementLogLevel));
      SyncedServerDebugSettings.NativeFieldInfoPtr__Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, nameof (_Initialized));
      SyncedServerDebugSettings.NativeMethodInfoPtr_Initialize_Public_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, 100664857);
      SyncedServerDebugSettings.NativeMethodInfoPtr_TryGetServerDebugSettings_Private_Boolean_byref_ServerDebugSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, 100664858);
      SyncedServerDebugSettings.NativeMethodInfoPtr_TryGetServerDebugSettings_Private_Boolean_World_byref_ServerDebugSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, 100664859);
      SyncedServerDebugSettings.NativeMethodInfoPtr_ApplyFromSettings_Public_Void_ServerDebugSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, 100664860);
      SyncedServerDebugSettings.NativeMethodInfoPtr_SetSetting_Public_Void_World_DebugSettingType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, 100664861);
      SyncedServerDebugSettings.NativeMethodInfoPtr_SetPlacementLogLevel_Public_Void_World_PlacementLogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, 100664862);
      SyncedServerDebugSettings.NativeMethodInfoPtr_SaveToSettingsFile_Private_Void_World_DebugSettingType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, 100664863);
      SyncedServerDebugSettings.NativeMethodInfoPtr_Get_Public_Static_SyncedServerDebugSettings_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, 100664864);
      SyncedServerDebugSettings.NativeMethodInfoPtr_Get_Public_Static_SyncedServerDebugSettings_ComponentSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, 100664865);
      SyncedServerDebugSettings.NativeMethodInfoPtr_Get_Public_Static_SyncedServerDebugSettings_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, 100664866);
      SyncedServerDebugSettings.NativeMethodInfoPtr_GetSmart_Public_Static_SyncedServerDebugSettings_SingletonAccessor_1_SyncedServerDebugSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, 100664867);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SyncedServerDebugSettings>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
