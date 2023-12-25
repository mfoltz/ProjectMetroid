// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.ResponseEventType
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

#nullable disable
namespace ProjectM.Network
{
  public enum ResponseEventType : byte
  {
    Inventory_Transfer_Success,
    Inventory_Transfer_Fail,
    Inventory_DragDrop_Success,
    Inventory_DragDrop_Fail,
    Inventory_Split_Success,
    Inventory_Split_Fail,
    Inventory_Uneqip_Success,
    Inventory_Uneqip_Fail,
    Inventory_Sort_Success,
    Inventory_Sort_Fail,
    Inventory_EquipBag_Success,
    Inventory_EquipBag_Fail,
    Inventory_UnequipBag_Success,
    Inventory_UnequipBag_Fail,
    Inventory_SwapBagSlot_Success,
    Inventory_SwapBagSlot_Fail,
    Trader_Purchase_Success,
    Trader_Purchase_Fail,
    Craft_Jewel_Start_Success,
    Craft_Jewel_Start_Fail,
    Craft_Jewel_Stop_Success,
    Craft_Jewel_Stop_Fail,
    Craft_Jewel_Complete_Success,
    Craft_Jewel_Complete_Fail,
    Workstation_Craft_Start,
    Workstation_Craft_Queue,
    Workstation_Craft_Abort,
    Workstation_Craft_CantCraft,
    Workstation_LightningRod_Start,
    Workstation_LightningRod_Step,
    Workstation_LightningRod_Finished,
    Workstation_LightningRod_Complete,
    Workstation_Forge_Insert,
    Workstation_Forge_Remove,
    Workstation_Forge_Start,
    Workstation_Forge_Stop,
    Workstation_Forge_Finish,
    Workstation_Forge_Complete,
    Servant_Insert_Success,
    Build_Not_Enough_Resources,
    Build_Cannot_Place,
    Build_CastleHeart_Placed,
    Craft_Not_Enough_Resources,
    Notification_MapZone_Discovered,
    Notification_Task_Completed,
    Warning_Castle_Decay_Start,
    Warning_Castle_Under_Attack,
    Warning_Castle_Breached,
    Warning_Attacking_Protected_Structure_TimeBased,
    Warning_Attacking_Protected_Structure,
    Warning_Cant_Harm_Structure,
    Warning_Siege_Golem_Built,
  }
}
