// Decompiled with JetBrains decompiler
// Type: ProjectM.DealDamageOnGameplayEventAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class DealDamageOnGameplayEventAuthoring : OnGameplayEventAuthoring
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Conditional;
    private static readonly System.IntPtr NativeFieldInfoPtr_MainType;
    private static readonly System.IntPtr NativeFieldInfoPtr_MainFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResourceFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResourceModify;
    private static readonly System.IntPtr NativeFieldInfoPtr_SiegeFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaggerFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageModifierSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsDoT;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowSCT;
    private static readonly System.IntPtr NativeFieldInfoPtr_CauseDurabilityLoss;
    private static readonly System.IntPtr NativeFieldInfoPtr_Ignore_CC;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrimaryAttack;
    private static readonly System.IntPtr NativeFieldInfoPtr_RawDamageValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_RawDamagePercent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModifyDamagePerHit;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageModifierPerHit;
    private static readonly System.IntPtr NativeFieldInfoPtr_MultiplyMainFactorWithBuffStacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SpellModSettings_Public_Virtual_Final_New_get_IEnumerable_1_SpellModSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe IEnumerable<ProjectM.SpellModSettings> SpellModSettings
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007943, XrefRangeEnd = 1007952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DealDamageOnGameplayEventAuthoring.NativeMethodInfoPtr_get_SpellModSettings_Public_Virtual_Final_New_get_IEnumerable_1_SpellModSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerable<ProjectM.SpellModSettings>) null : new IEnumerable<ProjectM.SpellModSettings>(pointer);
      }
    }

    [CallerCount(0)]
    public override unsafe GameplayEventTypeEnum GetGameplayEventType()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DealDamageOnGameplayEventAuthoring.NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameplayEventTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007952, XrefRangeEnd = 1007967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DealDamageOnGameplayEventAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007967, XrefRangeEnd = 1007968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DealDamageOnGameplayEventAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DealDamageOnGameplayEventAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DealDamageOnGameplayEventAuthoring()
    {
      Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DealDamageOnGameplayEventAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr);
      DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, nameof (Conditional));
      DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_MainType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, nameof (MainType));
      DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_MainFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, nameof (MainFactor));
      DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_ResourceFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, nameof (ResourceFactor));
      DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_ResourceModify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, nameof (ResourceModify));
      DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_SiegeFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, nameof (SiegeFactor));
      DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_StaggerFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, nameof (StaggerFactor));
      DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_DamageModifierSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, nameof (DamageModifierSettings));
      DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_IsDoT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, nameof (IsDoT));
      DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_ShowSCT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, nameof (ShowSCT));
      DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_CauseDurabilityLoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, nameof (CauseDurabilityLoss));
      DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_Ignore_CC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, nameof (Ignore_CC));
      DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_PrimaryAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, nameof (PrimaryAttack));
      DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_RawDamageValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, nameof (RawDamageValue));
      DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_RawDamagePercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, nameof (RawDamagePercent));
      DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_ModifyDamagePerHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, nameof (ModifyDamagePerHit));
      DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_DamageModifierPerHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, nameof (DamageModifierPerHit));
      DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_MultiplyMainFactorWithBuffStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, nameof (MultiplyMainFactorWithBuffStacks));
      DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, nameof (SpellMods));
      DealDamageOnGameplayEventAuthoring.NativeMethodInfoPtr_get_SpellModSettings_Public_Virtual_Final_New_get_IEnumerable_1_SpellModSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, 100678270);
      DealDamageOnGameplayEventAuthoring.NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, 100678271);
      DealDamageOnGameplayEventAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, 100678272);
      DealDamageOnGameplayEventAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, 100678273);
    }

    public DealDamageOnGameplayEventAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameplayConditionGroupData_Editor_Parent Conditional
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional));
        return pointer == System.IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MainDamageType MainType
    {
      get
      {
        return *(MainDamageType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_MainType));
      }
      [param: In] set
      {
        *(MainDamageType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_MainType)) = value;
      }
    }

    public unsafe float MainFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_MainFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_MainFactor)) = value;
      }
    }

    public unsafe float ResourceFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_ResourceFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_ResourceFactor)) = value;
      }
    }

    public unsafe float ResourceModify
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_ResourceModify));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_ResourceModify)) = value;
      }
    }

    public unsafe float SiegeFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_SiegeFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_SiegeFactor)) = value;
      }
    }

    public unsafe float StaggerFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_StaggerFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_StaggerFactor)) = value;
      }
    }

    public unsafe DamageModifierSettings DamageModifierSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_DamageModifierSettings));
        return pointer == System.IntPtr.Zero ? (DamageModifierSettings) null : new DamageModifierSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_DamageModifierSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool IsDoT
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_IsDoT));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_IsDoT)) = value;
      }
    }

    public unsafe bool ShowSCT
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_ShowSCT));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_ShowSCT)) = value;
      }
    }

    public unsafe bool CauseDurabilityLoss
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_CauseDurabilityLoss));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_CauseDurabilityLoss)) = value;
      }
    }

    public unsafe bool Ignore_CC
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_Ignore_CC));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_Ignore_CC)) = value;
      }
    }

    public unsafe bool PrimaryAttack
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_PrimaryAttack));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_PrimaryAttack)) = value;
      }
    }

    public unsafe float RawDamageValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_RawDamageValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_RawDamageValue)) = value;
      }
    }

    public unsafe float RawDamagePercent
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_RawDamagePercent));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_RawDamagePercent)) = value;
      }
    }

    public unsafe bool ModifyDamagePerHit
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_ModifyDamagePerHit));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_ModifyDamagePerHit)) = value;
      }
    }

    public unsafe float DamageModifierPerHit
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_DamageModifierPerHit));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_DamageModifierPerHit)) = value;
      }
    }

    public unsafe bool MultiplyMainFactorWithBuffStacks
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_MultiplyMainFactorWithBuffStacks));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_MultiplyMainFactorWithBuffStacks)) = value;
      }
    }

    public DealDamageOnGameplayEventAuthoring.SpellModsAuthoring SpellMods
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_SpellMods);
        return new DealDamageOnGameplayEventAuthoring.SpellModsAuthoring(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.NativeFieldInfoPtr_SpellMods), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [Serializable]
    public sealed class SpellModsAuthoring : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_MainFactor;
      private static readonly System.IntPtr NativeFieldInfoPtr_DamageModifierPerHit;

      static SpellModsAuthoring()
      {
        Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring>.NativeClassPtr, nameof (SpellModsAuthoring));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr);
        DealDamageOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_MainFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr, nameof (MainFactor));
        DealDamageOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_DamageModifierPerHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr, nameof (DamageModifierPerHit));
      }

      public SpellModsAuthoring(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SpellModsAuthoring()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DealDamageOnGameplayEventAuthoring.SpellModsAuthoring>.NativeClassPtr, data));
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> MainFactor
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_MainFactor));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_MainFactor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> DamageModifierPerHit
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_DamageModifierPerHit));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DealDamageOnGameplayEventAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_DamageModifierPerHit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
