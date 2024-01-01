// Decompiled with JetBrains decompiler
// Type: VRising.GameData.Models.Data.InventoryItemData
// Assembly: VRising.GameData, Version=0.3.3.0, Culture=neutral, PublicKeyToken=null
// MVID: C7075106-6156-43C0-B1EB-76289CFB1DEF
// Assembly location: C:\Users\mitch\source\repos\BloodyEncounters\VRising.GameData.dll

using System.Diagnostics;

#nullable disable
namespace VRising.GameData.Models.Data
{
  public class InventoryItemData
  {
    [field: DebuggerBrowsable]
    public ItemModel Item { get; set; }

    [field: DebuggerBrowsable]
    public int Stacks { get; set; }

    [field: DebuggerBrowsable]
    public int Slot { get; set; }
  }
}
