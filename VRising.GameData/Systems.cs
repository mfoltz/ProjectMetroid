// Decompiled with JetBrains decompiler
// Type: VRising.GameData.Systems
// Assembly: VRising.GameData, Version=0.3.3.0, Culture=neutral, PublicKeyToken=null
// MVID: C7075106-6156-43C0-B1EB-76289CFB1DEF
// Assembly location: C:\Users\mitch\source\repos\BloodyEncounters\VRising.GameData.dll

using ProjectM;

#nullable disable
namespace VRising.GameData
{
  public class Systems
  {
    private static Systems _instance;

    private Systems()
    {
    }

    internal static Systems Instance => Systems._instance ?? (Systems._instance = new Systems());

    public PrefabCollectionSystem PrefabCollectionSystem
    {
      get => VRising.GameData.GameData.World.GetExistingSystem<PrefabCollectionSystem>();
    }

    public GameDataSystem GameDataSystem => VRising.GameData.GameData.World.GetExistingSystem<GameDataSystem>();

    public ManagedDataRegistry ManagedDataRegistry => this.GameDataSystem.ManagedDataRegistry;
  }
}
