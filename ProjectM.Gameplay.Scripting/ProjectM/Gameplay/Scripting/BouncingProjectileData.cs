// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BouncingProjectileData
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BouncingProjectileData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BounceRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_BounceRadiusModifierPerBounce;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageModifierPerBounce;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealModifierPerBounce;
    private static readonly System.IntPtr NativeFieldInfoPtr_DelayTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProjectilePrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_DelayBuffPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentBounce;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxBounces;
    private static readonly System.IntPtr NativeFieldInfoPtr_TieBreakerType;
    private static readonly System.IntPtr NativeFieldInfoPtr_TieBreakerValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnlyHitTargetsOnce;
    private static readonly System.IntPtr NativeFieldInfoPtr_BounceIfDelayTargetDies;
    private static readonly System.IntPtr NativeFieldInfoPtr_BounceToOwnerType;
    private static readonly System.IntPtr NativeFieldInfoPtr_IncludeImmaterial;
    private static readonly System.IntPtr NativeFieldInfoPtr_OwnerProjectilePrefab;
    [FieldOffset(0)]
    public float BounceRadius;
    [FieldOffset(4)]
    public float BounceRadiusModifierPerBounce;
    [FieldOffset(8)]
    public float DamageModifierPerBounce;
    [FieldOffset(12)]
    public float HealModifierPerBounce;
    [FieldOffset(16)]
    public float DelayTime;
    [FieldOffset(20)]
    public PrefabGUID ProjectilePrefab;
    [FieldOffset(24)]
    public PrefabGUID DelayBuffPrefab;
    [FieldOffset(28)]
    public int CurrentBounce;
    [FieldOffset(32)]
    public int MaxBounces;
    [FieldOffset(36)]
    public TieBreakerType TieBreakerType;
    [FieldOffset(37)]
    public TieBreakerValue TieBreakerValue;
    [FieldOffset(38)]
    public bool OnlyHitTargetsOnce;
    [FieldOffset(39)]
    public bool BounceIfDelayTargetDies;
    [FieldOffset(40)]
    public BouncingProjectileData.ReturnToOwnerType BounceToOwnerType;
    [FieldOffset(44)]
    public bool IncludeImmaterial;
    [FieldOffset(48)]
    public PrefabGUID OwnerProjectilePrefab;

    static BouncingProjectileData()
    {
      Il2CppClassPointerStore<BouncingProjectileData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BouncingProjectileData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BouncingProjectileData>.NativeClassPtr);
      BouncingProjectileData.NativeFieldInfoPtr_BounceRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData>.NativeClassPtr, nameof (BounceRadius));
      BouncingProjectileData.NativeFieldInfoPtr_BounceRadiusModifierPerBounce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData>.NativeClassPtr, nameof (BounceRadiusModifierPerBounce));
      BouncingProjectileData.NativeFieldInfoPtr_DamageModifierPerBounce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData>.NativeClassPtr, nameof (DamageModifierPerBounce));
      BouncingProjectileData.NativeFieldInfoPtr_HealModifierPerBounce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData>.NativeClassPtr, nameof (HealModifierPerBounce));
      BouncingProjectileData.NativeFieldInfoPtr_DelayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData>.NativeClassPtr, nameof (DelayTime));
      BouncingProjectileData.NativeFieldInfoPtr_ProjectilePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData>.NativeClassPtr, nameof (ProjectilePrefab));
      BouncingProjectileData.NativeFieldInfoPtr_DelayBuffPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData>.NativeClassPtr, nameof (DelayBuffPrefab));
      BouncingProjectileData.NativeFieldInfoPtr_CurrentBounce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData>.NativeClassPtr, nameof (CurrentBounce));
      BouncingProjectileData.NativeFieldInfoPtr_MaxBounces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData>.NativeClassPtr, nameof (MaxBounces));
      BouncingProjectileData.NativeFieldInfoPtr_TieBreakerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData>.NativeClassPtr, nameof (TieBreakerType));
      BouncingProjectileData.NativeFieldInfoPtr_TieBreakerValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData>.NativeClassPtr, nameof (TieBreakerValue));
      BouncingProjectileData.NativeFieldInfoPtr_OnlyHitTargetsOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData>.NativeClassPtr, nameof (OnlyHitTargetsOnce));
      BouncingProjectileData.NativeFieldInfoPtr_BounceIfDelayTargetDies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData>.NativeClassPtr, nameof (BounceIfDelayTargetDies));
      BouncingProjectileData.NativeFieldInfoPtr_BounceToOwnerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData>.NativeClassPtr, nameof (BounceToOwnerType));
      BouncingProjectileData.NativeFieldInfoPtr_IncludeImmaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData>.NativeClassPtr, nameof (IncludeImmaterial));
      BouncingProjectileData.NativeFieldInfoPtr_OwnerProjectilePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData>.NativeClassPtr, nameof (OwnerProjectilePrefab));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BouncingProjectileData>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public enum ReturnToOwnerType
    {
      None,
      IfNoTargetCanBeFound,
      AtEnd,
    }
  }
}
