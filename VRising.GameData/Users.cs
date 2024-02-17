// Decompiled with JetBrains decompiler
// Type: VRising.GameData.Users
// Assembly: VRising.GameData, Version=0.3.3.0, Culture=neutral, PublicKeyToken=null
// MVID: C7075106-6156-43C0-B1EB-76289CFB1DEF
// Assembly location: C:\Users\mitch\source\repos\BloodyEncounters\VRising.GameData.dll

using ProjectM.Network;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Unity.Collections;
using Unity.Entities;
using VRising.GameData.Models;

#nullable disable
namespace VRising.GameData
{
  public class Users
  {
    private static Users _instance;

    [field: DebuggerBrowsable]
    internal static ulong CurrentUserSteamId { get; set; }

    private Users()
    {
    }

    internal static Users Instance => Users._instance ?? (Users._instance = new Users());

    public UserModel GetCurrentUser() => this.GetUserByPlatformId(Users.CurrentUserSteamId);

    public UserModel GetUserByPlatformId(ulong platformId)
    {
      return this.All.FirstOrDefault<UserModel>((Func<UserModel, bool>) (u => (long) u.PlatformId == (long) platformId));
    }

    public UserModel GetUserByCharacterName(string characterName)
    {
      return this.All.FirstOrDefault<UserModel>((Func<UserModel, bool>) (u => u.CharacterName == characterName));
    }

    public UserModel FromEntity(Entity userEntity)
    {
      if (!VRising.GameData.GameData.World.EntityManager.HasComponent<User>(userEntity))
        throw new Exception("Given entity does not have User component.");
      return new UserModel(userEntity);
    }

    public IEnumerable<UserModel> Online
    {
      get => this.All.Where<UserModel>((Func<UserModel, bool>) (u => u.IsConnected));
    }

    public IEnumerable<UserModel> All
    {
      get
      {
        NativeArray<Entity> userEntities = VRising.GameData.GameData.World.EntityManager.CreateEntityQuery(ComponentType.ReadOnly<User>()).ToEntityArray(Allocator.Temp);
        foreach (Entity entity in userEntities)
        {
          Entity userEntity = entity;
          yield return this.FromEntity(userEntity);
          userEntity = new Entity();
        }
        userEntities = new NativeArray<Entity>();
      }
    }
  }
}
