// Decompiled with JetBrains decompiler
// Type: VRising.GameData.Items
// Assembly: VRising.GameData, Version=0.3.3.0, Culture=neutral, PublicKeyToken=null
// MVID: C7075106-6156-43C0-B1EB-76289CFB1DEF
// Assembly location: C:\Users\mitch\source\repos\BloodyEncounters\VRising.GameData.dll

using BepInEx.Core.Logging.Interpolation;
using BepInEx.Logging;
using ProjectM;
using Stunlock.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using VRising.GameData.Models;

#nullable disable
namespace VRising.GameData
{
  public class Items
  {
    private static Items _instance;
    private List<ItemModel> _itemPrefabs;
    private List<ItemModel> _weapons;

    private Items()
    {
    }

    internal static Items Instance => Items._instance ?? (Items._instance = new Items());

    public ItemModel GetPrefabById(PrefabGUID prefabGuid)
    {
      try
      {
        ManagedItemData orDefault = VRising.GameData.GameData.World.GetExistingSystem<GameDataSystem>().ManagedDataRegistry.GetOrDefault<ManagedItemData>(prefabGuid);
        ManualLogSource logger = VRising.GameData.GameData.Logger;
        bool flag;
        BepInExMessageLogInterpolatedStringHandler interpolatedStringHandler = new BepInExMessageLogInterpolatedStringHandler(6, 1, ref flag);
        if (flag)
        {
          ((BepInExLogInterpolatedStringHandler) interpolatedStringHandler).AppendLiteral("Name: ");
          ((BepInExLogInterpolatedStringHandler) interpolatedStringHandler).AppendFormatted<LocalizationKey>(orDefault.Name);
        }
        logger.LogMessage(interpolatedStringHandler);
        return this.FromEntity(VRising.GameData.GameData.Systems.PrefabCollectionSystem.PrefabLookupMap[prefabGuid]);
      }
      catch (Exception ex)
      {
        VRising.GameData.GameData.Logger.LogError((object) ex);
      }
      return (ItemModel) null;
    }

    public ItemModel FromEntity(Entity entity)
    {
      try
      {
        return new ItemModel(entity);
      }
      catch (Exception ex)
      {
        VRising.GameData.GameData.Logger.LogError((object) ex);
      }
      return (ItemModel) null;
    }

    public List<ItemModel> Prefabs
    {
      get => this._itemPrefabs ?? (this._itemPrefabs = this.GetItemPrefabs());
    }

    private List<ItemModel> GetItemPrefabs()
    {
      List<ItemModel> itemPrefabs = new List<ItemModel>();
      ManualLogSource logger = VRising.GameData.GameData.Logger;
      bool flag;
      BepInExErrorLogInterpolatedStringHandler interpolatedStringHandler1 = new BepInExErrorLogInterpolatedStringHandler(14, 1, ref flag);
      NativeHashMap<PrefabGUID, Entity> prefabGuidToEntityMap;
      if (flag)
      {
        ((BepInExLogInterpolatedStringHandler) interpolatedStringHandler1).AppendLiteral("TOTAL PREFABS ");
        BepInExErrorLogInterpolatedStringHandler interpolatedStringHandler2 = interpolatedStringHandler1;
        prefabGuidToEntityMap = VRising.GameData.GameData.Systems.PrefabCollectionSystem._PrefabGuidToEntityMap;
        int num = prefabGuidToEntityMap.Count();
        ((BepInExLogInterpolatedStringHandler) interpolatedStringHandler2).AppendFormatted<int>(num);
      }
      logger.LogError(interpolatedStringHandler1);
      prefabGuidToEntityMap = VRising.GameData.GameData.Systems.PrefabCollectionSystem._PrefabGuidToEntityMap;
      foreach (KeyValue<PrefabGUID, Entity> keyValue in prefabGuidToEntityMap)
      {
        ItemModel itemModel = this.FromEntity(keyValue.Value);
        if (itemModel != null)
          itemPrefabs.Add(itemModel);
      }
      return itemPrefabs;
    }

    public List<ItemModel> Weapons
    {
      get
      {
        return this._weapons ?? (this._weapons = this.Prefabs.Where<ItemModel>((Func<ItemModel, bool>) (itemModel => itemModel.EquipmentType == EquipmentType.Weapon)).ToList<ItemModel>());
      }
    }
  }
}
