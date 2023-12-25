// Decompiled with JetBrains decompiler
// Type: ProjectM.Auth.PlatformInitState
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

#nullable disable
namespace ProjectM.Auth
{
  public enum PlatformInitState
  {
    None,
    Success,
    Initializing,
    NotRunning,
    InitFailed,
    DllNotFound,
    NotRunningCheckFailed,
    UnknownError,
    GameNotOwned,
    AppMissmatch,
  }
}
