// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.AuthScopeFlags
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using System;

#nullable disable
namespace Epic.OnlineServices.Auth
{
  [Flags]
  public enum AuthScopeFlags
  {
    NoFlags = 0,
    BasicProfile = 1,
    FriendsList = 2,
    Presence = 4,
    FriendsManagement = 8,
    Email = 16, // 0x00000010
    Country = 32, // 0x00000020
  }
}
