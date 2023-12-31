// Decompiled with JetBrains decompiler
// Type: ProjectM.Minion
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Minion
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PowerOverride;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusHealthPerOwnerSpellPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusPhysicalPowerPerOwnerSpellPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_BonusSpellPowerPerOwnerSpellPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnBuffsBlob;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnEventTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_MasterDeathActionBuffGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_MasterDeathAction;
    private static readonly System.IntPtr NativeFieldInfoPtr_IncludeInMinionCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerMasterDeathActionOnDowned;
    [FieldOffset(0)]
    public float PowerOverride;
    [FieldOffset(4)]
    public float BonusHealthPerOwnerSpellPower;
    [FieldOffset(8)]
    public float BonusPhysicalPowerPerOwnerSpellPower;
    [FieldOffset(12)]
    public float BonusSpellPowerPerOwnerSpellPower;
    [FieldOffset(16)]
    public BlobAssetReference<SpawnMinionOnGameplayEventBlob> SpawnBuffsBlob;
    [FieldOffset(24)]
    public Entity SpawnEventTarget;
    [FieldOffset(32)]
    public PrefabGUID MasterDeathActionBuffGuid;
    [FieldOffset(36)]
    public SequenceGUID SpawnSequenceGuid;
    [FieldOffset(40)]
    public MinionMasterDeathAction MasterDeathAction;
    [FieldOffset(44)]
    public bool IncludeInMinionCount;
    [FieldOffset(45)]
    public bool TriggerMasterDeathActionOnDowned;

    static Minion()
    {
      Il2CppClassPointerStore<Minion>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Minion));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Minion>.NativeClassPtr);
      Minion.NativeFieldInfoPtr_PowerOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Minion>.NativeClassPtr, nameof (PowerOverride));
      Minion.NativeFieldInfoPtr_BonusHealthPerOwnerSpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Minion>.NativeClassPtr, nameof (BonusHealthPerOwnerSpellPower));
      Minion.NativeFieldInfoPtr_BonusPhysicalPowerPerOwnerSpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Minion>.NativeClassPtr, nameof (BonusPhysicalPowerPerOwnerSpellPower));
      Minion.NativeFieldInfoPtr_BonusSpellPowerPerOwnerSpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Minion>.NativeClassPtr, nameof (BonusSpellPowerPerOwnerSpellPower));
      Minion.NativeFieldInfoPtr_SpawnBuffsBlob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Minion>.NativeClassPtr, nameof (SpawnBuffsBlob));
      Minion.NativeFieldInfoPtr_SpawnEventTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Minion>.NativeClassPtr, nameof (SpawnEventTarget));
      Minion.NativeFieldInfoPtr_MasterDeathActionBuffGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Minion>.NativeClassPtr, nameof (MasterDeathActionBuffGuid));
      Minion.NativeFieldInfoPtr_SpawnSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Minion>.NativeClassPtr, nameof (SpawnSequenceGuid));
      Minion.NativeFieldInfoPtr_MasterDeathAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Minion>.NativeClassPtr, nameof (MasterDeathAction));
      Minion.NativeFieldInfoPtr_IncludeInMinionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Minion>.NativeClassPtr, nameof (IncludeInMinionCount));
      Minion.NativeFieldInfoPtr_TriggerMasterDeathActionOnDowned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Minion>.NativeClassPtr, nameof (TriggerMasterDeathActionOnDowned));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Minion>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
