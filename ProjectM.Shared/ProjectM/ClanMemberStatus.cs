// Decompiled with JetBrains decompiler
// Type: ProjectM.ClanMemberStatus
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ClanMemberStatus
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UserIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthPercent;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsConnected;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanRole;
    [FieldOffset(0)]
    public int UserIndex;
    [FieldOffset(4)]
    public FixedString64 Name;
    [FieldOffset(68)]
    public int HealthPercent;
    [FieldOffset(72)]
    public bool IsConnected;
    [FieldOffset(76)]
    public ClanRoleEnum ClanRole;

    static ClanMemberStatus()
    {
      Il2CppClassPointerStore<ClanMemberStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ClanMemberStatus));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanMemberStatus>.NativeClassPtr);
      ClanMemberStatus.NativeFieldInfoPtr_UserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMemberStatus>.NativeClassPtr, nameof (UserIndex));
      ClanMemberStatus.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMemberStatus>.NativeClassPtr, nameof (Name));
      ClanMemberStatus.NativeFieldInfoPtr_HealthPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMemberStatus>.NativeClassPtr, nameof (HealthPercent));
      ClanMemberStatus.NativeFieldInfoPtr_IsConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMemberStatus>.NativeClassPtr, nameof (IsConnected));
      ClanMemberStatus.NativeFieldInfoPtr_ClanRole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMemberStatus>.NativeClassPtr, nameof (ClanRole));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanMemberStatus>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
