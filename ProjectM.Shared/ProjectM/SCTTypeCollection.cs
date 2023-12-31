// Decompiled with JetBrains decompiler
// Type: ProjectM.SCTTypeCollection
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Stunlock.Localization;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SCTTypeCollection
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageDone_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageTaken_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResourceGain_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_NeedBetterTool_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_NeedExplosives_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiresRecipe_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_MissingMaterials_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_CritDamage_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_Healing_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_Absorb_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_InventoryFull_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_HaveEquippedItems_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_Generic_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgniteExtinguished_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodEssence_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalChat_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastFailResult_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAXHeal_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_CannotTeleport_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_PvPProtectedOUT_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_PvPProtectedIN_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_PvECastleDamage_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_PvPCastleDamageOutsideTime_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_WoodenWall_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_StoneWall_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_NeedExplosivesOrBear_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_Invulernable_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_Missing_LiquidSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_InfoMessage_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_InfoWarning_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_InfoError_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_AttackMonsterGate_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinorHealing_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageDoneHighLevelTarget_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_NotEnoughBloodManaKey;
    [FieldOffset(0)]
    public PrefabGUID DamageDone_Type;
    [FieldOffset(4)]
    public PrefabGUID DamageTaken_Type;
    [FieldOffset(8)]
    public PrefabGUID ResourceGain_Type;
    [FieldOffset(12)]
    public PrefabGUID NeedBetterTool_Type;
    [FieldOffset(16)]
    public PrefabGUID NeedExplosives_Type;
    [FieldOffset(20)]
    public PrefabGUID RequiresRecipe_Type;
    [FieldOffset(24)]
    public PrefabGUID MissingMaterials_Type;
    [FieldOffset(28)]
    public PrefabGUID CritDamage_Type;
    [FieldOffset(32)]
    public PrefabGUID Healing_Type;
    [FieldOffset(36)]
    public PrefabGUID Absorb_Type;
    [FieldOffset(40)]
    public PrefabGUID InventoryFull_Type;
    [FieldOffset(44)]
    public PrefabGUID HaveEquippedItems_Type;
    [FieldOffset(48)]
    public PrefabGUID Generic_Type;
    [FieldOffset(52)]
    public PrefabGUID IgniteExtinguished_Type;
    [FieldOffset(56)]
    public PrefabGUID BloodEssence_Type;
    [FieldOffset(60)]
    public PrefabGUID LocalChat_Type;
    [FieldOffset(64)]
    public PrefabGUID CastFailResult_Type;
    [FieldOffset(68)]
    public PrefabGUID MAXHeal_Type;
    [FieldOffset(72)]
    public PrefabGUID CannotTeleport_Type;
    [FieldOffset(76)]
    public PrefabGUID PvPProtectedOUT_Type;
    [FieldOffset(80)]
    public PrefabGUID PvPProtectedIN_Type;
    [FieldOffset(84)]
    public PrefabGUID PvECastleDamage_Type;
    [FieldOffset(88)]
    public PrefabGUID PvPCastleDamageOutsideTime_Type;
    [FieldOffset(92)]
    public PrefabGUID WoodenWall_Type;
    [FieldOffset(96)]
    public PrefabGUID StoneWall_Type;
    [FieldOffset(100)]
    public PrefabGUID NeedExplosivesOrBear_Type;
    [FieldOffset(104)]
    public PrefabGUID Invulernable_Type;
    [FieldOffset(108)]
    public PrefabGUID Missing_LiquidSource;
    [FieldOffset(112)]
    public PrefabGUID InfoMessage_Type;
    [FieldOffset(116)]
    public PrefabGUID InfoWarning_Type;
    [FieldOffset(120)]
    public PrefabGUID InfoError_Type;
    [FieldOffset(124)]
    public PrefabGUID AttackMonsterGate_Type;
    [FieldOffset(128)]
    public PrefabGUID MinorHealing_Type;
    [FieldOffset(132)]
    public PrefabGUID DamageDoneHighLevelTarget_Type;
    [FieldOffset(136)]
    public LocalizationKey NotEnoughBloodManaKey;

    static SCTTypeCollection()
    {
      Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SCTTypeCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr);
      SCTTypeCollection.NativeFieldInfoPtr_DamageDone_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (DamageDone_Type));
      SCTTypeCollection.NativeFieldInfoPtr_DamageTaken_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (DamageTaken_Type));
      SCTTypeCollection.NativeFieldInfoPtr_ResourceGain_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (ResourceGain_Type));
      SCTTypeCollection.NativeFieldInfoPtr_NeedBetterTool_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (NeedBetterTool_Type));
      SCTTypeCollection.NativeFieldInfoPtr_NeedExplosives_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (NeedExplosives_Type));
      SCTTypeCollection.NativeFieldInfoPtr_RequiresRecipe_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (RequiresRecipe_Type));
      SCTTypeCollection.NativeFieldInfoPtr_MissingMaterials_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (MissingMaterials_Type));
      SCTTypeCollection.NativeFieldInfoPtr_CritDamage_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (CritDamage_Type));
      SCTTypeCollection.NativeFieldInfoPtr_Healing_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (Healing_Type));
      SCTTypeCollection.NativeFieldInfoPtr_Absorb_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (Absorb_Type));
      SCTTypeCollection.NativeFieldInfoPtr_InventoryFull_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (InventoryFull_Type));
      SCTTypeCollection.NativeFieldInfoPtr_HaveEquippedItems_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (HaveEquippedItems_Type));
      SCTTypeCollection.NativeFieldInfoPtr_Generic_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (Generic_Type));
      SCTTypeCollection.NativeFieldInfoPtr_IgniteExtinguished_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (IgniteExtinguished_Type));
      SCTTypeCollection.NativeFieldInfoPtr_BloodEssence_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (BloodEssence_Type));
      SCTTypeCollection.NativeFieldInfoPtr_LocalChat_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (LocalChat_Type));
      SCTTypeCollection.NativeFieldInfoPtr_CastFailResult_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (CastFailResult_Type));
      SCTTypeCollection.NativeFieldInfoPtr_MAXHeal_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (MAXHeal_Type));
      SCTTypeCollection.NativeFieldInfoPtr_CannotTeleport_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (CannotTeleport_Type));
      SCTTypeCollection.NativeFieldInfoPtr_PvPProtectedOUT_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (PvPProtectedOUT_Type));
      SCTTypeCollection.NativeFieldInfoPtr_PvPProtectedIN_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (PvPProtectedIN_Type));
      SCTTypeCollection.NativeFieldInfoPtr_PvECastleDamage_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (PvECastleDamage_Type));
      SCTTypeCollection.NativeFieldInfoPtr_PvPCastleDamageOutsideTime_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (PvPCastleDamageOutsideTime_Type));
      SCTTypeCollection.NativeFieldInfoPtr_WoodenWall_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (WoodenWall_Type));
      SCTTypeCollection.NativeFieldInfoPtr_StoneWall_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (StoneWall_Type));
      SCTTypeCollection.NativeFieldInfoPtr_NeedExplosivesOrBear_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (NeedExplosivesOrBear_Type));
      SCTTypeCollection.NativeFieldInfoPtr_Invulernable_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (Invulernable_Type));
      SCTTypeCollection.NativeFieldInfoPtr_Missing_LiquidSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (Missing_LiquidSource));
      SCTTypeCollection.NativeFieldInfoPtr_InfoMessage_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (InfoMessage_Type));
      SCTTypeCollection.NativeFieldInfoPtr_InfoWarning_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (InfoWarning_Type));
      SCTTypeCollection.NativeFieldInfoPtr_InfoError_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (InfoError_Type));
      SCTTypeCollection.NativeFieldInfoPtr_AttackMonsterGate_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (AttackMonsterGate_Type));
      SCTTypeCollection.NativeFieldInfoPtr_MinorHealing_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (MinorHealing_Type));
      SCTTypeCollection.NativeFieldInfoPtr_DamageDoneHighLevelTarget_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (DamageDoneHighLevelTarget_Type));
      SCTTypeCollection.NativeFieldInfoPtr_NotEnoughBloodManaKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, nameof (NotEnoughBloodManaKey));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SCTTypeCollection>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
