// Decompiled with JetBrains decompiler
// Type: VRising.GameData.Models.Internals.BaseManagedDataModel
// Assembly: VRising.GameData, Version=0.3.3.0, Culture=neutral, PublicKeyToken=null
// MVID: C7075106-6156-43C0-B1EB-76289CFB1DEF
// Assembly location: C:\Users\mitch\source\repos\BloodyEncounters\VRising.GameData.dll

using ProjectM;
using ProjectM.Portrait;
using ProjectM.UI;
using Unity.Entities;

#nullable disable
namespace VRising.GameData.Models.Internals
{
  public class BaseManagedDataModel
  {
    private readonly World _world;
    private readonly BaseEntityModel _entityModel;

    internal BaseManagedDataModel(World world, BaseEntityModel entityModel)
    {
      this._world = world;
      this._entityModel = entityModel;
    }

    public ManagedBlueprintData ManagedBlueprintData
    {
      get => this._world.GetManagedComponentDataInternal<ManagedBlueprintData>(this._entityModel);
    }

    public ManagedAbilityGroupData ManagedAbilityGroupData
    {
      get
      {
        return this._world.GetManagedComponentDataInternal<ManagedAbilityGroupData>(this._entityModel);
      }
    }

    public ManagedDescriptionData ManagedDescriptionData
    {
      get => this._world.GetManagedComponentDataInternal<ManagedDescriptionData>(this._entityModel);
    }

    public VBloodPortraitData VBloodPortraitData
    {
      get => this._world.GetManagedComponentDataInternal<VBloodPortraitData>(this._entityModel);
    }

    public ManagedCharacterHUD ManagedCharacterHUD
    {
      get => this._world.GetManagedComponentDataInternal<ManagedCharacterHUD>(this._entityModel);
    }

    public ServantPortraitData ServantPortraitData
    {
      get => this._world.GetManagedComponentDataInternal<ServantPortraitData>(this._entityModel);
    }

    public VoiceData VoiceData
    {
      get => this._world.GetManagedComponentDataInternal<VoiceData>(this._entityModel);
    }

    public ManagedRepairStationData ManagedRepairStationData
    {
      get
      {
        return this._world.GetManagedComponentDataInternal<ManagedRepairStationData>(this._entityModel);
      }
    }

    public ManagedItemData ManagedItemData
    {
      get => this._world.GetManagedComponentDataInternal<ManagedItemData>(this._entityModel);
    }

    public ManagedDataDropGroup ManagedDataDropGroup
    {
      get => this._world.GetManagedComponentDataInternal<ManagedDataDropGroup>(this._entityModel);
    }

    public ManagedUnitBloodTypeData ManagedUnitBloodTypeData
    {
      get
      {
        return this._world.GetManagedComponentDataInternal<ManagedUnitBloodTypeData>(this._entityModel);
      }
    }

    public ManagedSCTTypeData ManagedSCTTypeData
    {
      get => this._world.GetManagedComponentDataInternal<ManagedSCTTypeData>(this._entityModel);
    }

    public ManagedJournalTooltip ManagedJournalTooltip
    {
      get => this._world.GetManagedComponentDataInternal<ManagedJournalTooltip>(this._entityModel);
    }

    public FeatureCollectionComponent FeatureCollectionComponent
    {
      get
      {
        return this._world.GetManagedComponentDataInternal<FeatureCollectionComponent>(this._entityModel);
      }
    }

    public ManagedMissionData ManagedMissionData
    {
      get => this._world.GetManagedComponentDataInternal<ManagedMissionData>(this._entityModel);
    }

    public ManagedBuildMenuGroupData ManagedBuildMenuGroupData
    {
      get
      {
        return this._world.GetManagedComponentDataInternal<ManagedBuildMenuGroupData>(this._entityModel);
      }
    }

    public ScreenEdgeIconDataComponent ScreenEdgeIconDataComponent
    {
      get
      {
        return this._world.GetManagedComponentDataInternal<ScreenEdgeIconDataComponent>(this._entityModel);
      }
    }

    public ManagedPerkData ManagedPerkData
    {
      get => this._world.GetManagedComponentDataInternal<ManagedPerkData>(this._entityModel);
    }

    public ManagedStationBonusData ManagedStationBonusData
    {
      get
      {
        return this._world.GetManagedComponentDataInternal<ManagedStationBonusData>(this._entityModel);
      }
    }

    public ManagedMissionInjureDataAsset ManagedMissionInjureDataAsset
    {
      get
      {
        return this._world.GetManagedComponentDataInternal<ManagedMissionInjureDataAsset>(this._entityModel);
      }
    }

    public ManagedAchievementData ManagedAchievementData
    {
      get => this._world.GetManagedComponentDataInternal<ManagedAchievementData>(this._entityModel);
    }

    public ManagedMapIconData ManagedMapIconData
    {
      get => this._world.GetManagedComponentDataInternal<ManagedMapIconData>(this._entityModel);
    }

    public ManagedTechData ManagedTechData
    {
      get => this._world.GetManagedComponentDataInternal<ManagedTechData>(this._entityModel);
    }

    public ManagedItemSet ManagedItemSet
    {
      get => this._world.GetManagedComponentDataInternal<ManagedItemSet>(this._entityModel);
    }

    public ManagedBuildMenuCompositionData ManagedBuildMenuCompositionData
    {
      get
      {
        return this._world.GetManagedComponentDataInternal<ManagedBuildMenuCompositionData>(this._entityModel);
      }
    }
  }
}
