// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.IntegratedPlatform.IntegratedPlatformManagementFlags
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using System;

#nullable disable
namespace Epic.OnlineServices.IntegratedPlatform
{
  [Flags]
  public enum IntegratedPlatformManagementFlags
  {
    Disabled = 1,
    LibraryManagedByApplication = 2,
    LibraryManagedBySDK = 4,
    DisablePresenceMirroring = 8,
    DisableSDKManagedSessions = 16, // 0x00000010
    PreferEOSIdentity = 32, // 0x00000020
    PreferIntegratedIdentity = 64, // 0x00000040
  }
}
