// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Unholy_BoneSpear_Projectile_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Scripting;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Unholy_BoneSpear_Projectile_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellDamage;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConsumeRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExplosionRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitType;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExplosionSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChargedBuffType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConsumeHitFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExplosionHitFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsCharged;
    [FieldOffset(0)]
    public float SpellDamage;
    [FieldOffset(4)]
    public float ConsumeRadius;
    [FieldOffset(8)]
    public float ExplosionRadius;
    [FieldOffset(12)]
    public float BuffDuration;
    [FieldOffset(16)]
    public PrefabGUID UnitType;
    [FieldOffset(20)]
    public PrefabGUID BuffType;
    [FieldOffset(24)]
    public SequenceGUID ExplosionSequence;
    [FieldOffset(28)]
    public PrefabGUID ChargedBuffType;
    [FieldOffset(32)]
    public HitFilter ConsumeHitFilter;
    [FieldOffset(33)]
    public HitFilter ExplosionHitFilter;
    [FieldOffset(34)]
    public bool IsCharged;

    static Script_Unholy_BoneSpear_Projectile_DataServer()
    {
      Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Unholy_BoneSpear_Projectile_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile_DataServer>.NativeClassPtr);
      Script_Unholy_BoneSpear_Projectile_DataServer.NativeFieldInfoPtr_SpellDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile_DataServer>.NativeClassPtr, nameof (SpellDamage));
      Script_Unholy_BoneSpear_Projectile_DataServer.NativeFieldInfoPtr_ConsumeRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile_DataServer>.NativeClassPtr, nameof (ConsumeRadius));
      Script_Unholy_BoneSpear_Projectile_DataServer.NativeFieldInfoPtr_ExplosionRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile_DataServer>.NativeClassPtr, nameof (ExplosionRadius));
      Script_Unholy_BoneSpear_Projectile_DataServer.NativeFieldInfoPtr_BuffDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile_DataServer>.NativeClassPtr, nameof (BuffDuration));
      Script_Unholy_BoneSpear_Projectile_DataServer.NativeFieldInfoPtr_UnitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile_DataServer>.NativeClassPtr, nameof (UnitType));
      Script_Unholy_BoneSpear_Projectile_DataServer.NativeFieldInfoPtr_BuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile_DataServer>.NativeClassPtr, nameof (BuffType));
      Script_Unholy_BoneSpear_Projectile_DataServer.NativeFieldInfoPtr_ExplosionSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile_DataServer>.NativeClassPtr, nameof (ExplosionSequence));
      Script_Unholy_BoneSpear_Projectile_DataServer.NativeFieldInfoPtr_ChargedBuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile_DataServer>.NativeClassPtr, nameof (ChargedBuffType));
      Script_Unholy_BoneSpear_Projectile_DataServer.NativeFieldInfoPtr_ConsumeHitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile_DataServer>.NativeClassPtr, nameof (ConsumeHitFilter));
      Script_Unholy_BoneSpear_Projectile_DataServer.NativeFieldInfoPtr_ExplosionHitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile_DataServer>.NativeClassPtr, nameof (ExplosionHitFilter));
      Script_Unholy_BoneSpear_Projectile_DataServer.NativeFieldInfoPtr_IsCharged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile_DataServer>.NativeClassPtr, nameof (IsCharged));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
