// Decompiled with JetBrains decompiler
// Type: ProjectM.GameConnect
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GameConnect
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ConnectAddress;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerSaveName;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReplayFilePath;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConnectPassword;
    private static readonly System.IntPtr NativeFieldInfoPtr_HostAddress;
    private static readonly System.IntPtr NativeFieldInfoPtr_HostMaxUsers;
    private static readonly System.IntPtr NativeFieldInfoPtr_HostPort;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayReplay;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreateClient;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShouldHost;
    private static readonly System.IntPtr NativeFieldInfoPtr_HostDedicated;
    private static readonly System.IntPtr NativeFieldInfoPtr_SavePerUser;
    [FieldOffset(0)]
    public ConnectAddress ConnectAddress;
    [FieldOffset(48)]
    public FixedString512 ServerSaveName;
    [FieldOffset(560)]
    public FixedString512 ReplayFilePath;
    [FieldOffset(1072)]
    public FixedString128 ConnectPassword;
    [FieldOffset(1200)]
    public FixedString32 HostAddress;
    [FieldOffset(1232)]
    public int HostMaxUsers;
    [FieldOffset(1236)]
    public ushort HostPort;
    [FieldOffset(1238)]
    public bool PlayReplay;
    [FieldOffset(1239)]
    public bool CreateClient;
    [FieldOffset(1240)]
    public bool ShouldHost;
    [FieldOffset(1241)]
    public bool HostDedicated;
    [FieldOffset(1242)]
    public bool SavePerUser;

    static GameConnect()
    {
      Il2CppClassPointerStore<GameConnect>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (GameConnect));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameConnect>.NativeClassPtr);
      GameConnect.NativeFieldInfoPtr_ConnectAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnect>.NativeClassPtr, nameof (ConnectAddress));
      GameConnect.NativeFieldInfoPtr_ServerSaveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnect>.NativeClassPtr, nameof (ServerSaveName));
      GameConnect.NativeFieldInfoPtr_ReplayFilePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnect>.NativeClassPtr, nameof (ReplayFilePath));
      GameConnect.NativeFieldInfoPtr_ConnectPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnect>.NativeClassPtr, nameof (ConnectPassword));
      GameConnect.NativeFieldInfoPtr_HostAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnect>.NativeClassPtr, nameof (HostAddress));
      GameConnect.NativeFieldInfoPtr_HostMaxUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnect>.NativeClassPtr, nameof (HostMaxUsers));
      GameConnect.NativeFieldInfoPtr_HostPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnect>.NativeClassPtr, nameof (HostPort));
      GameConnect.NativeFieldInfoPtr_PlayReplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnect>.NativeClassPtr, nameof (PlayReplay));
      GameConnect.NativeFieldInfoPtr_CreateClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnect>.NativeClassPtr, nameof (CreateClient));
      GameConnect.NativeFieldInfoPtr_ShouldHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnect>.NativeClassPtr, nameof (ShouldHost));
      GameConnect.NativeFieldInfoPtr_HostDedicated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnect>.NativeClassPtr, nameof (HostDedicated));
      GameConnect.NativeFieldInfoPtr_SavePerUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnect>.NativeClassPtr, nameof (SavePerUser));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameConnect>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
