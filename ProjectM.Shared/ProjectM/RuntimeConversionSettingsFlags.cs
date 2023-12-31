// Decompiled with JetBrains decompiler
// Type: ProjectM.RuntimeConversionSettingsFlags
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using System;

#nullable disable
namespace ProjectM
{
  [Flags]
  public enum RuntimeConversionSettingsFlags
  {
    None = 0,
    ConvertOnDemandV1_Startup = 1,
    ConvertOnDemandV2_Startup = 2,
    ConvertOnDemand_Runtime = 4,
    SkipPostProcessingAndKeepInProcessingWorld = 8,
    ShareWithAllServerClientConversionWorlds = 16, // 0x00000010
    SilentConversion = 32, // 0x00000020
    AcceptConversionWithoutSettingsAsset = 64, // 0x00000040
    AllConvertOnDemandFlags = ConvertOnDemand_Runtime | ConvertOnDemandV2_Startup | ConvertOnDemandV1_Startup, // 0x00000007
  }
}
