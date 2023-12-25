// Decompiled with JetBrains decompiler
// Type: ProjectM.JewelSpawnSystemData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct JewelSpawnSystemData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_JewelTemplateId;
    private static readonly System.IntPtr NativeFieldInfoPtr_LegendaryItemTemplateId;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityToSpellSchool;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellSchoolTierToJewel;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponTypeTierToLegendaryWeapon;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroupsPerUnitLevel;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public PrefabGUID JewelTemplateId;
    [FieldOffset(4)]
    public PrefabGUID LegendaryItemTemplateId;
    [FieldOffset(8)]
    public NativeHashMap<PrefabGUID, PrefabGUID> AbilityToSpellSchool;
    [FieldOffset(24)]
    public NativeHashMap<SpellSchoolTier, PrefabGUID> SpellSchoolTierToJewel;
    [FieldOffset(40)]
    public NativeHashMap<WeaponTypeTier, PrefabGUID> WeaponTypeTierToLegendaryWeapon;
    [FieldOffset(56)]
    public NativeList<UnitLevelAbilityGroupData> AbilityGroupsPerUnitLevel;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1036782, RefRangeEnd = 1036783, XrefRangeStart = 1036758, XrefRangeEnd = 1036782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JewelSpawnSystemData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static JewelSpawnSystemData()
    {
      Il2CppClassPointerStore<JewelSpawnSystemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (JewelSpawnSystemData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelSpawnSystemData>.NativeClassPtr);
      JewelSpawnSystemData.NativeFieldInfoPtr_JewelTemplateId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystemData>.NativeClassPtr, nameof (JewelTemplateId));
      JewelSpawnSystemData.NativeFieldInfoPtr_LegendaryItemTemplateId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystemData>.NativeClassPtr, nameof (LegendaryItemTemplateId));
      JewelSpawnSystemData.NativeFieldInfoPtr_AbilityToSpellSchool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystemData>.NativeClassPtr, nameof (AbilityToSpellSchool));
      JewelSpawnSystemData.NativeFieldInfoPtr_SpellSchoolTierToJewel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystemData>.NativeClassPtr, nameof (SpellSchoolTierToJewel));
      JewelSpawnSystemData.NativeFieldInfoPtr_WeaponTypeTierToLegendaryWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystemData>.NativeClassPtr, nameof (WeaponTypeTierToLegendaryWeapon));
      JewelSpawnSystemData.NativeFieldInfoPtr_AbilityGroupsPerUnitLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelSpawnSystemData>.NativeClassPtr, nameof (AbilityGroupsPerUnitLevel));
      JewelSpawnSystemData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelSpawnSystemData>.NativeClassPtr, 100681134);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelSpawnSystemData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
