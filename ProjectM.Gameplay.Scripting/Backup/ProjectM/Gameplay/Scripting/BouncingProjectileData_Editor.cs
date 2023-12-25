// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BouncingProjectileData_Editor
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [Serializable]
  public sealed class BouncingProjectileData_Editor : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetFilterCondition;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxBounces;
    private static readonly System.IntPtr NativeFieldInfoPtr_BounceRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnlyHitTargetsOnce;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageModifierPerBounce;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealModifierPerBounce;
    private static readonly System.IntPtr NativeFieldInfoPtr_BounceRadiusModifierPerBounce;
    private static readonly System.IntPtr NativeFieldInfoPtr_TieBreakerType;
    private static readonly System.IntPtr NativeFieldInfoPtr_TieBreakerValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_IncludeImmaterial;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProjectilePrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_DelayBuffPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_DelayTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_BounceIfDelayTargetDies;
    private static readonly System.IntPtr NativeFieldInfoPtr_BounceToOwnerType;
    private static readonly System.IntPtr NativeFieldInfoPtr_BounceToOwnerCondition;
    private static readonly System.IntPtr NativeFieldInfoPtr_OwnerProjectilePrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_ValueTuple_Unboxed_3_BouncingProjectileData_BlobAssetReference_1_ConditionBlob_BlobAssetReference_1_ConditionBlob_MonoBehaviour_PrefabGUID_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1176679, RefRangeEnd = 1176680, XrefRangeStart = 1176667, XrefRangeEnd = 1176679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ValueTuple_Unboxed<BouncingProjectileData, BlobAssetReference<ConditionBlob>, BlobAssetReference<ConditionBlob>> Convert(
      MonoBehaviour builder,
      PrefabGUID overrideProjectile = default (PrefabGUID))
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) builder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &overrideProjectile;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BouncingProjectileData_Editor.NativeMethodInfoPtr_Convert_Public_ValueTuple_Unboxed_3_BouncingProjectileData_BlobAssetReference_1_ConditionBlob_BlobAssetReference_1_ConditionBlob_MonoBehaviour_PrefabGUID_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ValueTuple_Unboxed<BouncingProjectileData, BlobAssetReference<ConditionBlob>, BlobAssetReference<ConditionBlob>>*) IL2CPP.il2cpp_object_unbox(num);
    }

    static BouncingProjectileData_Editor()
    {
      Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BouncingProjectileData_Editor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr);
      BouncingProjectileData_Editor.NativeFieldInfoPtr_TargetFilterCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, nameof (TargetFilterCondition));
      BouncingProjectileData_Editor.NativeFieldInfoPtr_MaxBounces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, nameof (MaxBounces));
      BouncingProjectileData_Editor.NativeFieldInfoPtr_BounceRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, nameof (BounceRadius));
      BouncingProjectileData_Editor.NativeFieldInfoPtr_OnlyHitTargetsOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, nameof (OnlyHitTargetsOnce));
      BouncingProjectileData_Editor.NativeFieldInfoPtr_DamageModifierPerBounce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, nameof (DamageModifierPerBounce));
      BouncingProjectileData_Editor.NativeFieldInfoPtr_HealModifierPerBounce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, nameof (HealModifierPerBounce));
      BouncingProjectileData_Editor.NativeFieldInfoPtr_BounceRadiusModifierPerBounce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, nameof (BounceRadiusModifierPerBounce));
      BouncingProjectileData_Editor.NativeFieldInfoPtr_TieBreakerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, nameof (TieBreakerType));
      BouncingProjectileData_Editor.NativeFieldInfoPtr_TieBreakerValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, nameof (TieBreakerValue));
      BouncingProjectileData_Editor.NativeFieldInfoPtr_IncludeImmaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, nameof (IncludeImmaterial));
      BouncingProjectileData_Editor.NativeFieldInfoPtr_ProjectilePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, nameof (ProjectilePrefab));
      BouncingProjectileData_Editor.NativeFieldInfoPtr_DelayBuffPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, nameof (DelayBuffPrefab));
      BouncingProjectileData_Editor.NativeFieldInfoPtr_DelayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, nameof (DelayTime));
      BouncingProjectileData_Editor.NativeFieldInfoPtr_BounceIfDelayTargetDies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, nameof (BounceIfDelayTargetDies));
      BouncingProjectileData_Editor.NativeFieldInfoPtr_BounceToOwnerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, nameof (BounceToOwnerType));
      BouncingProjectileData_Editor.NativeFieldInfoPtr_BounceToOwnerCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, nameof (BounceToOwnerCondition));
      BouncingProjectileData_Editor.NativeFieldInfoPtr_OwnerProjectilePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, nameof (OwnerProjectilePrefab));
      BouncingProjectileData_Editor.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, nameof (SpellMods));
      BouncingProjectileData_Editor.NativeMethodInfoPtr_Convert_Public_ValueTuple_Unboxed_3_BouncingProjectileData_BlobAssetReference_1_ConditionBlob_BlobAssetReference_1_ConditionBlob_MonoBehaviour_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, 100663574);
    }

    public BouncingProjectileData_Editor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public BouncingProjectileData_Editor()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, data));
    }

    public unsafe GameplayConditionGroupData_Editor_Parent TargetFilterCondition
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_TargetFilterCondition));
        return pointer == System.IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_TargetFilterCondition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int MaxBounces
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_MaxBounces));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_MaxBounces)) = value;
      }
    }

    public unsafe float BounceRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_BounceRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_BounceRadius)) = value;
      }
    }

    public unsafe bool OnlyHitTargetsOnce
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_OnlyHitTargetsOnce));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_OnlyHitTargetsOnce)) = value;
      }
    }

    public unsafe float DamageModifierPerBounce
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_DamageModifierPerBounce));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_DamageModifierPerBounce)) = value;
      }
    }

    public unsafe float HealModifierPerBounce
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_HealModifierPerBounce));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_HealModifierPerBounce)) = value;
      }
    }

    public unsafe float BounceRadiusModifierPerBounce
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_BounceRadiusModifierPerBounce));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_BounceRadiusModifierPerBounce)) = value;
      }
    }

    public unsafe TieBreakerType TieBreakerType
    {
      get
      {
        return *(TieBreakerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_TieBreakerType));
      }
      [param: In] set
      {
        *(TieBreakerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_TieBreakerType)) = value;
      }
    }

    public unsafe TieBreakerValue TieBreakerValue
    {
      get
      {
        return *(TieBreakerValue*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_TieBreakerValue));
      }
      [param: In] set
      {
        *(TieBreakerValue*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_TieBreakerValue)) = value;
      }
    }

    public unsafe bool IncludeImmaterial
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_IncludeImmaterial));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_IncludeImmaterial)) = value;
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> ProjectilePrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_ProjectilePrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_ProjectilePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> DelayBuffPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_DelayBuffPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_DelayBuffPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float DelayTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_DelayTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_DelayTime)) = value;
      }
    }

    public unsafe bool BounceIfDelayTargetDies
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_BounceIfDelayTargetDies));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_BounceIfDelayTargetDies)) = value;
      }
    }

    public unsafe BouncingProjectileData.ReturnToOwnerType BounceToOwnerType
    {
      get
      {
        return *(BouncingProjectileData.ReturnToOwnerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_BounceToOwnerType));
      }
      [param: In] set
      {
        *(BouncingProjectileData.ReturnToOwnerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_BounceToOwnerType)) = value;
      }
    }

    public unsafe GameplayConditionGroupData_Editor_Parent BounceToOwnerCondition
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_BounceToOwnerCondition));
        return pointer == System.IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_BounceToOwnerCondition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> OwnerProjectilePrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_OwnerProjectilePrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_OwnerProjectilePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public BouncingProjectileData_Editor.SpellModsAuthoring SpellMods
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_SpellMods);
        return new BouncingProjectileData_Editor.SpellModsAuthoring(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BouncingProjectileData_Editor.SpellModsAuthoring>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.NativeFieldInfoPtr_SpellMods), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BouncingProjectileData_Editor.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [Serializable]
    public sealed class SpellModsAuthoring : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxBounces;
      private static readonly System.IntPtr NativeFieldInfoPtr_DamageModifierPerBounce;
      private static readonly System.IntPtr NativeFieldInfoPtr_HealingModifierPerBounce;

      static SpellModsAuthoring()
      {
        Il2CppClassPointerStore<BouncingProjectileData_Editor.SpellModsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BouncingProjectileData_Editor>.NativeClassPtr, nameof (SpellModsAuthoring));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BouncingProjectileData_Editor.SpellModsAuthoring>.NativeClassPtr);
        BouncingProjectileData_Editor.SpellModsAuthoring.NativeFieldInfoPtr_MaxBounces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData_Editor.SpellModsAuthoring>.NativeClassPtr, nameof (MaxBounces));
        BouncingProjectileData_Editor.SpellModsAuthoring.NativeFieldInfoPtr_DamageModifierPerBounce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData_Editor.SpellModsAuthoring>.NativeClassPtr, nameof (DamageModifierPerBounce));
        BouncingProjectileData_Editor.SpellModsAuthoring.NativeFieldInfoPtr_HealingModifierPerBounce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BouncingProjectileData_Editor.SpellModsAuthoring>.NativeClassPtr, nameof (HealingModifierPerBounce));
      }

      public SpellModsAuthoring(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SpellModsAuthoring()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BouncingProjectileData_Editor.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BouncingProjectileData_Editor.SpellModsAuthoring>.NativeClassPtr, data));
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> MaxBounces
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.SpellModsAuthoring.NativeFieldInfoPtr_MaxBounces));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.SpellModsAuthoring.NativeFieldInfoPtr_MaxBounces), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> DamageModifierPerBounce
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.SpellModsAuthoring.NativeFieldInfoPtr_DamageModifierPerBounce));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.SpellModsAuthoring.NativeFieldInfoPtr_DamageModifierPerBounce), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> HealingModifierPerBounce
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.SpellModsAuthoring.NativeFieldInfoPtr_HealingModifierPerBounce));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BouncingProjectileData_Editor.SpellModsAuthoring.NativeFieldInfoPtr_HealingModifierPerBounce), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
