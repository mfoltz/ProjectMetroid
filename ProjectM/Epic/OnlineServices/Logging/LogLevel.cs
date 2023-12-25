// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Logging.LogLevel
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

#nullable disable
namespace Epic.OnlineServices.Logging
{
  public enum LogLevel
  {
    Off = 0,
    Fatal = 100, // 0x00000064
    Error = 200, // 0x000000C8
    Warning = 300, // 0x0000012C
    Info = 400, // 0x00000190
    Verbose = 500, // 0x000001F4
    VeryVerbose = 600, // 0x00000258
  }
}
