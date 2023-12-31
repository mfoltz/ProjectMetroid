// Decompiled with JetBrains decompiler
// Type: ProjectM.ServerDebugSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding.Placement;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class ServerDebugSettings : SettingsBase
  {
    private static readonly IntPtr NativeFieldInfoPtr_DefaultPath;
    private static readonly IntPtr NativeFieldInfoPtr_LocalPath;
    private static readonly IntPtr NativeFieldInfoPtr_SunDamageDisabled;
    private static readonly IntPtr NativeFieldInfoPtr_DurabilityDisabled;
    private static readonly IntPtr NativeFieldInfoPtr_BloodDrainDisabled;
    private static readonly IntPtr NativeFieldInfoPtr_CooldownsDisabled;
    private static readonly IntPtr NativeFieldInfoPtr_BuildCostsDisabled;
    private static readonly IntPtr NativeFieldInfoPtr_TutorialPopupsDisabled;
    private static readonly IntPtr NativeFieldInfoPtr_AllProgressionUnlocked;
    private static readonly IntPtr NativeFieldInfoPtr_UnlockAllVBloodsOnLaunch;
    private static readonly IntPtr NativeFieldInfoPtr_PlayersInvulernabilityEnabled;
    private static readonly IntPtr NativeFieldInfoPtr_DayNightCycleDisabled;
    private static readonly IntPtr NativeFieldInfoPtr_NPCsDisabled;
    private static readonly IntPtr NativeFieldInfoPtr_GlobalCastleTerritoryEnabled;
    private static readonly IntPtr NativeFieldInfoPtr_BuildingPlacementRestrictionsDisabled;
    private static readonly IntPtr NativeFieldInfoPtr_FreeBuildingPlacementEnabled;
    private static readonly IntPtr NativeFieldInfoPtr_BuildingReplacementDisabled;
    private static readonly IntPtr NativeFieldInfoPtr_CastleHeartConnectionRequirementDisabled;
    private static readonly IntPtr NativeFieldInfoPtr_AllWaypointsUnlocked;
    private static readonly IntPtr NativeFieldInfoPtr_AggroDisabled;
    private static readonly IntPtr NativeFieldInfoPtr_DropsDisabled;
    private static readonly IntPtr NativeFieldInfoPtr_UseHeightRaycasting;
    private static readonly IntPtr NativeFieldInfoPtr_TileCollisionDisabled;
    private static readonly IntPtr NativeFieldInfoPtr_DynamicCollisionDisabled;
    private static readonly IntPtr NativeFieldInfoPtr_DynamicCloudsDisabled;
    private static readonly IntPtr NativeFieldInfoPtr_HitEffectsDisabled;
    private static readonly IntPtr NativeFieldInfoPtr_RoofGenerationEnabled;
    private static readonly IntPtr NativeFieldInfoPtr_LinnCastleRoofsEnabled;
    private static readonly IntPtr NativeFieldInfoPtr_UseDeathSequencesInsteadOfRagdolls;
    private static readonly IntPtr NativeFieldInfoPtr_FeedWoundedRequirementDisabled;
    private static readonly IntPtr NativeFieldInfoPtr_SkipNetworkVersionCheck;
    private static readonly IntPtr NativeFieldInfoPtr_UseSunblockerChecksForFly;
    private static readonly IntPtr NativeFieldInfoPtr_CastleHeartBloodEssenceDisabled;
    private static readonly IntPtr NativeFieldInfoPtr_CastleLimitsDisabled;
    private static readonly IntPtr NativeFieldInfoPtr_AiCastsDisabled;
    private static readonly IntPtr NativeFieldInfoPtr_LightningStrikesDisabled;
    private static readonly IntPtr NativeFieldInfoPtr_VbloodGhostsDisabled;
    private static readonly IntPtr NativeFieldInfoPtr_PlacementLogLevel;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 749244, RefRangeEnd = 749246, XrefRangeStart = 749239, XrefRangeEnd = 749244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerDebugSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerDebugSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServerDebugSettings()
    {
      Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ServerDebugSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr);
      ServerDebugSettings.NativeFieldInfoPtr_DefaultPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (DefaultPath));
      ServerDebugSettings.NativeFieldInfoPtr_LocalPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (LocalPath));
      ServerDebugSettings.NativeFieldInfoPtr_SunDamageDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (SunDamageDisabled));
      ServerDebugSettings.NativeFieldInfoPtr_DurabilityDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (DurabilityDisabled));
      ServerDebugSettings.NativeFieldInfoPtr_BloodDrainDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (BloodDrainDisabled));
      ServerDebugSettings.NativeFieldInfoPtr_CooldownsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (CooldownsDisabled));
      ServerDebugSettings.NativeFieldInfoPtr_BuildCostsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (BuildCostsDisabled));
      ServerDebugSettings.NativeFieldInfoPtr_TutorialPopupsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (TutorialPopupsDisabled));
      ServerDebugSettings.NativeFieldInfoPtr_AllProgressionUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (AllProgressionUnlocked));
      ServerDebugSettings.NativeFieldInfoPtr_UnlockAllVBloodsOnLaunch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (UnlockAllVBloodsOnLaunch));
      ServerDebugSettings.NativeFieldInfoPtr_PlayersInvulernabilityEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (PlayersInvulernabilityEnabled));
      ServerDebugSettings.NativeFieldInfoPtr_DayNightCycleDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (DayNightCycleDisabled));
      ServerDebugSettings.NativeFieldInfoPtr_NPCsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (NPCsDisabled));
      ServerDebugSettings.NativeFieldInfoPtr_GlobalCastleTerritoryEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (GlobalCastleTerritoryEnabled));
      ServerDebugSettings.NativeFieldInfoPtr_BuildingPlacementRestrictionsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (BuildingPlacementRestrictionsDisabled));
      ServerDebugSettings.NativeFieldInfoPtr_FreeBuildingPlacementEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (FreeBuildingPlacementEnabled));
      ServerDebugSettings.NativeFieldInfoPtr_BuildingReplacementDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (BuildingReplacementDisabled));
      ServerDebugSettings.NativeFieldInfoPtr_CastleHeartConnectionRequirementDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (CastleHeartConnectionRequirementDisabled));
      ServerDebugSettings.NativeFieldInfoPtr_AllWaypointsUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (AllWaypointsUnlocked));
      ServerDebugSettings.NativeFieldInfoPtr_AggroDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (AggroDisabled));
      ServerDebugSettings.NativeFieldInfoPtr_DropsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (DropsDisabled));
      ServerDebugSettings.NativeFieldInfoPtr_UseHeightRaycasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (UseHeightRaycasting));
      ServerDebugSettings.NativeFieldInfoPtr_TileCollisionDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (TileCollisionDisabled));
      ServerDebugSettings.NativeFieldInfoPtr_DynamicCollisionDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (DynamicCollisionDisabled));
      ServerDebugSettings.NativeFieldInfoPtr_DynamicCloudsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (DynamicCloudsDisabled));
      ServerDebugSettings.NativeFieldInfoPtr_HitEffectsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (HitEffectsDisabled));
      ServerDebugSettings.NativeFieldInfoPtr_RoofGenerationEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (RoofGenerationEnabled));
      ServerDebugSettings.NativeFieldInfoPtr_LinnCastleRoofsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (LinnCastleRoofsEnabled));
      ServerDebugSettings.NativeFieldInfoPtr_UseDeathSequencesInsteadOfRagdolls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (UseDeathSequencesInsteadOfRagdolls));
      ServerDebugSettings.NativeFieldInfoPtr_FeedWoundedRequirementDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (FeedWoundedRequirementDisabled));
      ServerDebugSettings.NativeFieldInfoPtr_SkipNetworkVersionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (SkipNetworkVersionCheck));
      ServerDebugSettings.NativeFieldInfoPtr_UseSunblockerChecksForFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (UseSunblockerChecksForFly));
      ServerDebugSettings.NativeFieldInfoPtr_CastleHeartBloodEssenceDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (CastleHeartBloodEssenceDisabled));
      ServerDebugSettings.NativeFieldInfoPtr_CastleLimitsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (CastleLimitsDisabled));
      ServerDebugSettings.NativeFieldInfoPtr_AiCastsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (AiCastsDisabled));
      ServerDebugSettings.NativeFieldInfoPtr_LightningStrikesDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (LightningStrikesDisabled));
      ServerDebugSettings.NativeFieldInfoPtr_VbloodGhostsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (VbloodGhostsDisabled));
      ServerDebugSettings.NativeFieldInfoPtr_PlacementLogLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, nameof (PlacementLogLevel));
      ServerDebugSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerDebugSettings>.NativeClassPtr, 100665991);
    }

    public ServerDebugSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string DefaultPath
    {
      get
      {
        IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ServerDebugSettings.NativeFieldInfoPtr_DefaultPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerDebugSettings.NativeFieldInfoPtr_DefaultPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string LocalPath
    {
      get
      {
        IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ServerDebugSettings.NativeFieldInfoPtr_LocalPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerDebugSettings.NativeFieldInfoPtr_LocalPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool SunDamageDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_SunDamageDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_SunDamageDisabled)) = value;
      }
    }

    public unsafe bool DurabilityDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_DurabilityDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_DurabilityDisabled)) = value;
      }
    }

    public unsafe bool BloodDrainDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_BloodDrainDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_BloodDrainDisabled)) = value;
      }
    }

    public unsafe bool CooldownsDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_CooldownsDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_CooldownsDisabled)) = value;
      }
    }

    public unsafe bool BuildCostsDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_BuildCostsDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_BuildCostsDisabled)) = value;
      }
    }

    public unsafe bool TutorialPopupsDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_TutorialPopupsDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_TutorialPopupsDisabled)) = value;
      }
    }

    public unsafe bool AllProgressionUnlocked
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_AllProgressionUnlocked));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_AllProgressionUnlocked)) = value;
      }
    }

    public unsafe bool UnlockAllVBloodsOnLaunch
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_UnlockAllVBloodsOnLaunch));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_UnlockAllVBloodsOnLaunch)) = value;
      }
    }

    public unsafe bool PlayersInvulernabilityEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_PlayersInvulernabilityEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_PlayersInvulernabilityEnabled)) = value;
      }
    }

    public unsafe bool DayNightCycleDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_DayNightCycleDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_DayNightCycleDisabled)) = value;
      }
    }

    public unsafe bool NPCsDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_NPCsDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_NPCsDisabled)) = value;
      }
    }

    public unsafe bool GlobalCastleTerritoryEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_GlobalCastleTerritoryEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_GlobalCastleTerritoryEnabled)) = value;
      }
    }

    public unsafe bool BuildingPlacementRestrictionsDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_BuildingPlacementRestrictionsDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_BuildingPlacementRestrictionsDisabled)) = value;
      }
    }

    public unsafe bool FreeBuildingPlacementEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_FreeBuildingPlacementEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_FreeBuildingPlacementEnabled)) = value;
      }
    }

    public unsafe bool BuildingReplacementDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_BuildingReplacementDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_BuildingReplacementDisabled)) = value;
      }
    }

    public unsafe bool CastleHeartConnectionRequirementDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_CastleHeartConnectionRequirementDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_CastleHeartConnectionRequirementDisabled)) = value;
      }
    }

    public unsafe bool AllWaypointsUnlocked
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_AllWaypointsUnlocked));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_AllWaypointsUnlocked)) = value;
      }
    }

    public unsafe bool AggroDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_AggroDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_AggroDisabled)) = value;
      }
    }

    public unsafe bool DropsDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_DropsDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_DropsDisabled)) = value;
      }
    }

    public unsafe bool UseHeightRaycasting
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_UseHeightRaycasting));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_UseHeightRaycasting)) = value;
      }
    }

    public unsafe bool TileCollisionDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_TileCollisionDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_TileCollisionDisabled)) = value;
      }
    }

    public unsafe bool DynamicCollisionDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_DynamicCollisionDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_DynamicCollisionDisabled)) = value;
      }
    }

    public unsafe bool DynamicCloudsDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_DynamicCloudsDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_DynamicCloudsDisabled)) = value;
      }
    }

    public unsafe bool HitEffectsDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_HitEffectsDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_HitEffectsDisabled)) = value;
      }
    }

    public unsafe bool RoofGenerationEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_RoofGenerationEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_RoofGenerationEnabled)) = value;
      }
    }

    public unsafe bool LinnCastleRoofsEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_LinnCastleRoofsEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_LinnCastleRoofsEnabled)) = value;
      }
    }

    public unsafe bool UseDeathSequencesInsteadOfRagdolls
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_UseDeathSequencesInsteadOfRagdolls));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_UseDeathSequencesInsteadOfRagdolls)) = value;
      }
    }

    public unsafe bool FeedWoundedRequirementDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_FeedWoundedRequirementDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_FeedWoundedRequirementDisabled)) = value;
      }
    }

    public unsafe bool SkipNetworkVersionCheck
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_SkipNetworkVersionCheck));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_SkipNetworkVersionCheck)) = value;
      }
    }

    public unsafe bool UseSunblockerChecksForFly
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_UseSunblockerChecksForFly));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_UseSunblockerChecksForFly)) = value;
      }
    }

    public unsafe bool CastleHeartBloodEssenceDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_CastleHeartBloodEssenceDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_CastleHeartBloodEssenceDisabled)) = value;
      }
    }

    public unsafe bool CastleLimitsDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_CastleLimitsDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_CastleLimitsDisabled)) = value;
      }
    }

    public unsafe bool AiCastsDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_AiCastsDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_AiCastsDisabled)) = value;
      }
    }

    public unsafe bool LightningStrikesDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_LightningStrikesDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_LightningStrikesDisabled)) = value;
      }
    }

    public unsafe bool VbloodGhostsDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_VbloodGhostsDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_VbloodGhostsDisabled)) = value;
      }
    }

    public unsafe PlacementLogLevel PlacementLogLevel
    {
      get
      {
        return *(PlacementLogLevel*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_PlacementLogLevel));
      }
      [param: In] set
      {
        *(PlacementLogLevel*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerDebugSettings.NativeFieldInfoPtr_PlacementLogLevel)) = value;
      }
    }
  }
}
