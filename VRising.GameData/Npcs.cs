// Decompiled with JetBrains decompiler
// Type: VRising.GameData.Npcs
// Assembly: VRising.GameData, Version=0.3.3.0, Culture=neutral, PublicKeyToken=null
// MVID: C7075106-6156-43C0-B1EB-76289CFB1DEF
// Assembly location: C:\Users\mitch\source\repos\BloodyEncounters\VRising.GameData.dll

using Unity.Entities;
using VRising.GameData.Models;

#nullable disable
namespace VRising.GameData
{
  public class Npcs
  {
    private static Npcs _instance;

    private Npcs()
    {
    }

    internal static Npcs Instance => Npcs._instance ?? (Npcs._instance = new Npcs());

    public NpcModel FromEntity(Entity npcEntity) => new NpcModel(npcEntity);
  }
}
