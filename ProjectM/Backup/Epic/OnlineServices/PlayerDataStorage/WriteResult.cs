// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.PlayerDataStorage.WriteResult
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

#nullable disable
namespace Epic.OnlineServices.PlayerDataStorage
{
  public enum WriteResult
  {
    ContinueWriting = 1,
    CompleteRequest = 2,
    FailRequest = 3,
    CancelRequest = 4,
  }
}
