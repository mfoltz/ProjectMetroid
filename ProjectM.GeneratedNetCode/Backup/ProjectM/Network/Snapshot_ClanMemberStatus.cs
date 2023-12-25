// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_ClanMemberStatus
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_ClanMemberStatus
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanRole;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthPercent;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsConnected;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserIndex;
    [FieldOffset(0)]
    public ClanRoleEnum ClanRole;
    [FieldOffset(4)]
    public int HealthPercent;
    [FieldOffset(8)]
    public bool IsConnected;
    [FieldOffset(10)]
    public FixedString64 Name;
    [FieldOffset(76)]
    public int UserIndex;

    static Snapshot_ClanMemberStatus()
    {
      Il2CppClassPointerStore<Snapshot_ClanMemberStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_ClanMemberStatus));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_ClanMemberStatus>.NativeClassPtr);
      Snapshot_ClanMemberStatus.NativeFieldInfoPtr_ClanRole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ClanMemberStatus>.NativeClassPtr, nameof (ClanRole));
      Snapshot_ClanMemberStatus.NativeFieldInfoPtr_HealthPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ClanMemberStatus>.NativeClassPtr, nameof (HealthPercent));
      Snapshot_ClanMemberStatus.NativeFieldInfoPtr_IsConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ClanMemberStatus>.NativeClassPtr, nameof (IsConnected));
      Snapshot_ClanMemberStatus.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ClanMemberStatus>.NativeClassPtr, nameof (Name));
      Snapshot_ClanMemberStatus.NativeFieldInfoPtr_UserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ClanMemberStatus>.NativeClassPtr, nameof (UserIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_ClanMemberStatus>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
