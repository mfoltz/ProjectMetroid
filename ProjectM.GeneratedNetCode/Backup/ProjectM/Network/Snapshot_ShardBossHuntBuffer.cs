// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_ShardBossHuntBuffer
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_ShardBossHuntBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodHuntTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsUnlockedByStation;
    [FieldOffset(0)]
    public PrefabGUID BloodHuntTarget;
    [FieldOffset(4)]
    public bool IsUnlockedByStation;

    static Snapshot_ShardBossHuntBuffer()
    {
      Il2CppClassPointerStore<Snapshot_ShardBossHuntBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_ShardBossHuntBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_ShardBossHuntBuffer>.NativeClassPtr);
      Snapshot_ShardBossHuntBuffer.NativeFieldInfoPtr_BloodHuntTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ShardBossHuntBuffer>.NativeClassPtr, nameof (BloodHuntTarget));
      Snapshot_ShardBossHuntBuffer.NativeFieldInfoPtr_IsUnlockedByStation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_ShardBossHuntBuffer>.NativeClassPtr, nameof (IsUnlockedByStation));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_ShardBossHuntBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
