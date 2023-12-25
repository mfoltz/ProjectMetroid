// Decompiled with JetBrains decompiler
// Type: ProjectM.Repairstation
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Repairstation
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnOnRepairPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlaySequenceOnRepair;
    private static readonly System.IntPtr NativeFieldInfoPtr_TransferTeamToRepairerTeam;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClaimCastleAreaOnRepair;
    [FieldOffset(0)]
    public PrefabGUID SpawnOnRepairPrefab;
    [FieldOffset(4)]
    public SequenceGUID PlaySequenceOnRepair;
    [FieldOffset(8)]
    public bool TransferTeamToRepairerTeam;
    [FieldOffset(9)]
    public bool ClaimCastleAreaOnRepair;

    static Repairstation()
    {
      Il2CppClassPointerStore<Repairstation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (Repairstation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Repairstation>.NativeClassPtr);
      Repairstation.NativeFieldInfoPtr_SpawnOnRepairPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Repairstation>.NativeClassPtr, nameof (SpawnOnRepairPrefab));
      Repairstation.NativeFieldInfoPtr_PlaySequenceOnRepair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Repairstation>.NativeClassPtr, nameof (PlaySequenceOnRepair));
      Repairstation.NativeFieldInfoPtr_TransferTeamToRepairerTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Repairstation>.NativeClassPtr, nameof (TransferTeamToRepairerTeam));
      Repairstation.NativeFieldInfoPtr_ClaimCastleAreaOnRepair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Repairstation>.NativeClassPtr, nameof (ClaimCastleAreaOnRepair));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Repairstation>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
