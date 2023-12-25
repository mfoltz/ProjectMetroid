// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Logging.LogCategory
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

#nullable disable
namespace Epic.OnlineServices.Logging
{
  public enum LogCategory
  {
    Core = 0,
    Auth = 1,
    Friends = 2,
    Presence = 3,
    UserInfo = 4,
    HttpSerialization = 5,
    Ecom = 6,
    P2P = 7,
    Sessions = 8,
    RateLimiter = 9,
    PlayerDataStorage = 10, // 0x0000000A
    Analytics = 11, // 0x0000000B
    Messaging = 12, // 0x0000000C
    Connect = 13, // 0x0000000D
    Overlay = 14, // 0x0000000E
    Achievements = 15, // 0x0000000F
    Stats = 16, // 0x00000010
    Ui = 17, // 0x00000011
    Lobby = 18, // 0x00000012
    Leaderboards = 19, // 0x00000013
    Keychain = 20, // 0x00000014
    IntegratedPlatform = 21, // 0x00000015
    TitleStorage = 22, // 0x00000016
    Mods = 23, // 0x00000017
    AntiCheat = 24, // 0x00000018
    Reports = 25, // 0x00000019
    Sanctions = 26, // 0x0000001A
    ProgressionSnapshots = 27, // 0x0000001B
    Kws = 28, // 0x0000001C
    Rtc = 29, // 0x0000001D
    RTCAdmin = 30, // 0x0000001E
    CustomInvites = 31, // 0x0000001F
    AllCategories = 2147483647, // 0x7FFFFFFF
  }
}
