// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitStatsComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class UnitStatsComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_UnitBaseStatsType;
    private static readonly IntPtr NativeFieldInfoPtr_UnitStatsAssetPhysicalSettings;
    private static readonly IntPtr NativeFieldInfoPtr_OverridePhysicalPower;
    private static readonly IntPtr NativeFieldInfoPtr_UnitStatsAssetSpellSettings;
    private static readonly IntPtr NativeFieldInfoPtr_OverrideSpellPower;
    private static readonly IntPtr NativeFieldInfoPtr_UnitStatsAssetResourceSettings;
    private static readonly IntPtr NativeFieldInfoPtr_OverrideResourcePower;
    private static readonly IntPtr NativeFieldInfoPtr_UnitStatsAssetSiegeSettings;
    private static readonly IntPtr NativeFieldInfoPtr_OverrideSiegePower;
    private static readonly IntPtr NativeFieldInfoPtr_ResourceYieldModifier;
    private static readonly IntPtr NativeFieldInfoPtr_ReducedResourceDurabilityLoss;
    private static readonly IntPtr NativeFieldInfoPtr_PhysicalResistance;
    private static readonly IntPtr NativeFieldInfoPtr_SpellResistance;
    private static readonly IntPtr NativeFieldInfoPtr_FireResistance;
    private static readonly IntPtr NativeFieldInfoPtr_HolyResistance;
    private static readonly IntPtr NativeFieldInfoPtr_SilverResistance;
    private static readonly IntPtr NativeFieldInfoPtr_GarlicResistance;
    private static readonly IntPtr NativeFieldInfoPtr_SunResistance;
    private static readonly IntPtr NativeFieldInfoPtr_PvPResilience;
    private static readonly IntPtr NativeFieldInfoPtr_PassiveHealthRegen;
    private static readonly IntPtr NativeFieldInfoPtr_PhysicalCriticalStrikeChance;
    private static readonly IntPtr NativeFieldInfoPtr_PhysicalCriticalStrikeDamage;
    private static readonly IntPtr NativeFieldInfoPtr_SpellCriticalStrikeChance;
    private static readonly IntPtr NativeFieldInfoPtr_SpellCriticalStrikeDamage;
    private static readonly IntPtr NativeFieldInfoPtr_AttackSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_PrimaryAttackSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_DamageVsUndeads;
    private static readonly IntPtr NativeFieldInfoPtr_DamageVsHumans;
    private static readonly IntPtr NativeFieldInfoPtr_DamageVsDemons;
    private static readonly IntPtr NativeFieldInfoPtr_DamageVsMechanical;
    private static readonly IntPtr NativeFieldInfoPtr_DamageVsBeasts;
    private static readonly IntPtr NativeFieldInfoPtr_DamageVsCastleObjects;
    private static readonly IntPtr NativeFieldInfoPtr_DamageVsPlayerVampires;
    private static readonly IntPtr NativeFieldInfoPtr_DamageVsWood;
    private static readonly IntPtr NativeFieldInfoPtr_DamageVsMineral;
    private static readonly IntPtr NativeFieldInfoPtr_DamageVsVegetation;
    private static readonly IntPtr NativeFieldInfoPtr_DamageVsLightArmor;
    private static readonly IntPtr NativeFieldInfoPtr_DamageVsHeavyArmor;
    private static readonly IntPtr NativeFieldInfoPtr_DamageVsMagic;
    private static readonly IntPtr NativeFieldInfoPtr_ResistVsUndeads;
    private static readonly IntPtr NativeFieldInfoPtr_ResistVsHumans;
    private static readonly IntPtr NativeFieldInfoPtr_ResistVsDemons;
    private static readonly IntPtr NativeFieldInfoPtr_ResistVsMechanical;
    private static readonly IntPtr NativeFieldInfoPtr_ResistVsBeasts;
    private static readonly IntPtr NativeFieldInfoPtr_ResistVsPlayerVampires;
    private static readonly IntPtr NativeFieldInfoPtr_HealthRecovery;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_FetchStatValueFromAsset_Private_Single_Single_Single_Unit_StatsSettings_Asset_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762904, XrefRangeEnd = 762963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitStatsComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 762986, RefRangeEnd = 762990, XrefRangeStart = 762963, XrefRangeEnd = 762986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float FetchStatValueFromAsset(
      float unitLevel,
      float baseValue,
      Unit_StatsSettings_Asset statsAsset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &unitLevel;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &baseValue;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) statsAsset);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitStatsComponent.NativeMethodInfoPtr_FetchStatValueFromAsset_Private_Single_Single_Single_Unit_StatsSettings_Asset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762990, XrefRangeEnd = 762991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnitStatsComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitStatsComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnitStatsComponent()
    {
      Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UnitStatsComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr);
      UnitStatsComponent.NativeFieldInfoPtr_UnitBaseStatsType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (UnitBaseStatsType));
      UnitStatsComponent.NativeFieldInfoPtr_UnitStatsAssetPhysicalSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (UnitStatsAssetPhysicalSettings));
      UnitStatsComponent.NativeFieldInfoPtr_OverridePhysicalPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (OverridePhysicalPower));
      UnitStatsComponent.NativeFieldInfoPtr_UnitStatsAssetSpellSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (UnitStatsAssetSpellSettings));
      UnitStatsComponent.NativeFieldInfoPtr_OverrideSpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (OverrideSpellPower));
      UnitStatsComponent.NativeFieldInfoPtr_UnitStatsAssetResourceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (UnitStatsAssetResourceSettings));
      UnitStatsComponent.NativeFieldInfoPtr_OverrideResourcePower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (OverrideResourcePower));
      UnitStatsComponent.NativeFieldInfoPtr_UnitStatsAssetSiegeSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (UnitStatsAssetSiegeSettings));
      UnitStatsComponent.NativeFieldInfoPtr_OverrideSiegePower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (OverrideSiegePower));
      UnitStatsComponent.NativeFieldInfoPtr_ResourceYieldModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (ResourceYieldModifier));
      UnitStatsComponent.NativeFieldInfoPtr_ReducedResourceDurabilityLoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (ReducedResourceDurabilityLoss));
      UnitStatsComponent.NativeFieldInfoPtr_PhysicalResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (PhysicalResistance));
      UnitStatsComponent.NativeFieldInfoPtr_SpellResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (SpellResistance));
      UnitStatsComponent.NativeFieldInfoPtr_FireResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (FireResistance));
      UnitStatsComponent.NativeFieldInfoPtr_HolyResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (HolyResistance));
      UnitStatsComponent.NativeFieldInfoPtr_SilverResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (SilverResistance));
      UnitStatsComponent.NativeFieldInfoPtr_GarlicResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (GarlicResistance));
      UnitStatsComponent.NativeFieldInfoPtr_SunResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (SunResistance));
      UnitStatsComponent.NativeFieldInfoPtr_PvPResilience = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (PvPResilience));
      UnitStatsComponent.NativeFieldInfoPtr_PassiveHealthRegen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (PassiveHealthRegen));
      UnitStatsComponent.NativeFieldInfoPtr_PhysicalCriticalStrikeChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (PhysicalCriticalStrikeChance));
      UnitStatsComponent.NativeFieldInfoPtr_PhysicalCriticalStrikeDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (PhysicalCriticalStrikeDamage));
      UnitStatsComponent.NativeFieldInfoPtr_SpellCriticalStrikeChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (SpellCriticalStrikeChance));
      UnitStatsComponent.NativeFieldInfoPtr_SpellCriticalStrikeDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (SpellCriticalStrikeDamage));
      UnitStatsComponent.NativeFieldInfoPtr_AttackSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (AttackSpeed));
      UnitStatsComponent.NativeFieldInfoPtr_PrimaryAttackSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (PrimaryAttackSpeed));
      UnitStatsComponent.NativeFieldInfoPtr_DamageVsUndeads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (DamageVsUndeads));
      UnitStatsComponent.NativeFieldInfoPtr_DamageVsHumans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (DamageVsHumans));
      UnitStatsComponent.NativeFieldInfoPtr_DamageVsDemons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (DamageVsDemons));
      UnitStatsComponent.NativeFieldInfoPtr_DamageVsMechanical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (DamageVsMechanical));
      UnitStatsComponent.NativeFieldInfoPtr_DamageVsBeasts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (DamageVsBeasts));
      UnitStatsComponent.NativeFieldInfoPtr_DamageVsCastleObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (DamageVsCastleObjects));
      UnitStatsComponent.NativeFieldInfoPtr_DamageVsPlayerVampires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (DamageVsPlayerVampires));
      UnitStatsComponent.NativeFieldInfoPtr_DamageVsWood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (DamageVsWood));
      UnitStatsComponent.NativeFieldInfoPtr_DamageVsMineral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (DamageVsMineral));
      UnitStatsComponent.NativeFieldInfoPtr_DamageVsVegetation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (DamageVsVegetation));
      UnitStatsComponent.NativeFieldInfoPtr_DamageVsLightArmor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (DamageVsLightArmor));
      UnitStatsComponent.NativeFieldInfoPtr_DamageVsHeavyArmor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (DamageVsHeavyArmor));
      UnitStatsComponent.NativeFieldInfoPtr_DamageVsMagic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (DamageVsMagic));
      UnitStatsComponent.NativeFieldInfoPtr_ResistVsUndeads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (ResistVsUndeads));
      UnitStatsComponent.NativeFieldInfoPtr_ResistVsHumans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (ResistVsHumans));
      UnitStatsComponent.NativeFieldInfoPtr_ResistVsDemons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (ResistVsDemons));
      UnitStatsComponent.NativeFieldInfoPtr_ResistVsMechanical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (ResistVsMechanical));
      UnitStatsComponent.NativeFieldInfoPtr_ResistVsBeasts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (ResistVsBeasts));
      UnitStatsComponent.NativeFieldInfoPtr_ResistVsPlayerVampires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (ResistVsPlayerVampires));
      UnitStatsComponent.NativeFieldInfoPtr_HealthRecovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, nameof (HealthRecovery));
      UnitStatsComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, 100667404);
      UnitStatsComponent.NativeMethodInfoPtr_FetchStatValueFromAsset_Private_Single_Single_Single_Unit_StatsSettings_Asset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, 100667405);
      UnitStatsComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitStatsComponent>.NativeClassPtr, 100667406);
    }

    public UnitStatsComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UnitBaseStatsType UnitBaseStatsType
    {
      get
      {
        return *(UnitBaseStatsType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_UnitBaseStatsType));
      }
      [param: In] set
      {
        *(UnitBaseStatsType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_UnitBaseStatsType)) = value;
      }
    }

    public unsafe Unit_StatsSettings_Asset UnitStatsAssetPhysicalSettings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_UnitStatsAssetPhysicalSettings));
        return pointer == IntPtr.Zero ? (Unit_StatsSettings_Asset) null : new Unit_StatsSettings_Asset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_UnitStatsAssetPhysicalSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float OverridePhysicalPower
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_OverridePhysicalPower));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_OverridePhysicalPower)) = value;
      }
    }

    public unsafe Unit_StatsSettings_Asset UnitStatsAssetSpellSettings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_UnitStatsAssetSpellSettings));
        return pointer == IntPtr.Zero ? (Unit_StatsSettings_Asset) null : new Unit_StatsSettings_Asset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_UnitStatsAssetSpellSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float OverrideSpellPower
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_OverrideSpellPower));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_OverrideSpellPower)) = value;
      }
    }

    public unsafe Unit_StatsSettings_Asset UnitStatsAssetResourceSettings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_UnitStatsAssetResourceSettings));
        return pointer == IntPtr.Zero ? (Unit_StatsSettings_Asset) null : new Unit_StatsSettings_Asset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_UnitStatsAssetResourceSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float OverrideResourcePower
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_OverrideResourcePower));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_OverrideResourcePower)) = value;
      }
    }

    public unsafe Unit_StatsSettings_Asset UnitStatsAssetSiegeSettings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_UnitStatsAssetSiegeSettings));
        return pointer == IntPtr.Zero ? (Unit_StatsSettings_Asset) null : new Unit_StatsSettings_Asset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_UnitStatsAssetSiegeSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float OverrideSiegePower
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_OverrideSiegePower));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_OverrideSiegePower)) = value;
      }
    }

    public unsafe float ResourceYieldModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_ResourceYieldModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_ResourceYieldModifier)) = value;
      }
    }

    public unsafe float ReducedResourceDurabilityLoss
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_ReducedResourceDurabilityLoss));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_ReducedResourceDurabilityLoss)) = value;
      }
    }

    public unsafe float PhysicalResistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_PhysicalResistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_PhysicalResistance)) = value;
      }
    }

    public unsafe float SpellResistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_SpellResistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_SpellResistance)) = value;
      }
    }

    public unsafe int FireResistance
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_FireResistance));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_FireResistance)) = value;
      }
    }

    public unsafe int HolyResistance
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_HolyResistance));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_HolyResistance)) = value;
      }
    }

    public unsafe int SilverResistance
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_SilverResistance));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_SilverResistance)) = value;
      }
    }

    public unsafe int GarlicResistance
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_GarlicResistance));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_GarlicResistance)) = value;
      }
    }

    public unsafe int SunResistance
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_SunResistance));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_SunResistance)) = value;
      }
    }

    public unsafe int PvPResilience
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_PvPResilience));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_PvPResilience)) = value;
      }
    }

    public unsafe float PassiveHealthRegen
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_PassiveHealthRegen));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_PassiveHealthRegen)) = value;
      }
    }

    public unsafe float PhysicalCriticalStrikeChance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_PhysicalCriticalStrikeChance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_PhysicalCriticalStrikeChance)) = value;
      }
    }

    public unsafe float PhysicalCriticalStrikeDamage
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_PhysicalCriticalStrikeDamage));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_PhysicalCriticalStrikeDamage)) = value;
      }
    }

    public unsafe float SpellCriticalStrikeChance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_SpellCriticalStrikeChance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_SpellCriticalStrikeChance)) = value;
      }
    }

    public unsafe float SpellCriticalStrikeDamage
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_SpellCriticalStrikeDamage));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_SpellCriticalStrikeDamage)) = value;
      }
    }

    public unsafe float AttackSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_AttackSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_AttackSpeed)) = value;
      }
    }

    public unsafe float PrimaryAttackSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_PrimaryAttackSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_PrimaryAttackSpeed)) = value;
      }
    }

    public unsafe float DamageVsUndeads
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsUndeads));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsUndeads)) = value;
      }
    }

    public unsafe float DamageVsHumans
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsHumans));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsHumans)) = value;
      }
    }

    public unsafe float DamageVsDemons
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsDemons));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsDemons)) = value;
      }
    }

    public unsafe float DamageVsMechanical
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsMechanical));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsMechanical)) = value;
      }
    }

    public unsafe float DamageVsBeasts
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsBeasts));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsBeasts)) = value;
      }
    }

    public unsafe float DamageVsCastleObjects
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsCastleObjects));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsCastleObjects)) = value;
      }
    }

    public unsafe float DamageVsPlayerVampires
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsPlayerVampires));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsPlayerVampires)) = value;
      }
    }

    public unsafe float DamageVsWood
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsWood));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsWood)) = value;
      }
    }

    public unsafe float DamageVsMineral
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsMineral));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsMineral)) = value;
      }
    }

    public unsafe float DamageVsVegetation
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsVegetation));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsVegetation)) = value;
      }
    }

    public unsafe float DamageVsLightArmor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsLightArmor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsLightArmor)) = value;
      }
    }

    public unsafe float DamageVsHeavyArmor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsHeavyArmor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsHeavyArmor)) = value;
      }
    }

    public unsafe float DamageVsMagic
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsMagic));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_DamageVsMagic)) = value;
      }
    }

    public unsafe float ResistVsUndeads
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_ResistVsUndeads));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_ResistVsUndeads)) = value;
      }
    }

    public unsafe float ResistVsHumans
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_ResistVsHumans));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_ResistVsHumans)) = value;
      }
    }

    public unsafe float ResistVsDemons
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_ResistVsDemons));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_ResistVsDemons)) = value;
      }
    }

    public unsafe float ResistVsMechanical
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_ResistVsMechanical));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_ResistVsMechanical)) = value;
      }
    }

    public unsafe float ResistVsBeasts
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_ResistVsBeasts));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_ResistVsBeasts)) = value;
      }
    }

    public unsafe float ResistVsPlayerVampires
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_ResistVsPlayerVampires));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_ResistVsPlayerVampires)) = value;
      }
    }

    public unsafe float HealthRecovery
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_HealthRecovery));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitStatsComponent.NativeFieldInfoPtr_HealthRecovery)) = value;
      }
    }
  }
}
