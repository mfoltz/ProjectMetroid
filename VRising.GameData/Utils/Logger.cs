// Decompiled with JetBrains decompiler
// Type: VRising.GameData.Utils.Logger
// Assembly: VRising.GameData, Version=0.3.3.0, Culture=neutral, PublicKeyToken=null
// MVID: C7075106-6156-43C0-B1EB-76289CFB1DEF
// Assembly location: C:\Users\mitch\source\repos\BloodyEncounters\VRising.GameData.dll

using BepInEx.Logging;
using System;

#nullable disable
namespace VRising.GameData.Utils
{
  internal class Logger
  {
    private readonly ManualLogSource _logger;

    internal Logger(ManualLogSource logger) => this._logger = logger;

    internal void Log(LogLevel logLevel, string message)
    {
    }

    internal void LogInfo(string message) => this.Log((LogLevel) 16, message);

    internal void LogWarning(string message) => this.Log((LogLevel) 4, message);

    internal void LogDebug(string message) => this.Log((LogLevel) 32, message);

    internal void LogFatal(string message) => this.Log((LogLevel) 1, message);

    internal void LogError(string message) => this.Log((LogLevel) 2, message);

    internal void LogError(Exception exception) => this.Log((LogLevel) 2, exception.ToString());

    internal void LogMessage(string message) => this.Log((LogLevel) 8, message);
  }
}
