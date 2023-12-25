// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SCTTypeCollectionAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class SCTTypeCollectionAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_DamageDone_Type;
    private static readonly IntPtr NativeFieldInfoPtr_DamageTaken_Type;
    private static readonly IntPtr NativeFieldInfoPtr_ResourceGain_Type;
    private static readonly IntPtr NativeFieldInfoPtr_NeedBetterTool_Type;
    private static readonly IntPtr NativeFieldInfoPtr_NeedExplosives_Type;
    private static readonly IntPtr NativeFieldInfoPtr_MissingMaterials_Type;
    private static readonly IntPtr NativeFieldInfoPtr_RequiresRecipe_Type;
    private static readonly IntPtr NativeFieldInfoPtr_CritDamage_Type;
    private static readonly IntPtr NativeFieldInfoPtr_Healing_Type;
    private static readonly IntPtr NativeFieldInfoPtr_Absorb_Type;
    private static readonly IntPtr NativeFieldInfoPtr_InventoryFull_Type;
    private static readonly IntPtr NativeFieldInfoPtr_HaveEquippedItems_Type;
    private static readonly IntPtr NativeFieldInfoPtr_Generic_Type;
    private static readonly IntPtr NativeFieldInfoPtr_IgniteExtinguished_Type;
    private static readonly IntPtr NativeFieldInfoPtr_BloodEssence_Type;
    private static readonly IntPtr NativeFieldInfoPtr_LocalChat_Type;
    private static readonly IntPtr NativeFieldInfoPtr_CastFailResult_Type;
    private static readonly IntPtr NativeFieldInfoPtr_MAXHeal_Type;
    private static readonly IntPtr NativeFieldInfoPtr_CannotTeleport_Type;
    private static readonly IntPtr NativeFieldInfoPtr_PvPProtectedIN_Type;
    private static readonly IntPtr NativeFieldInfoPtr_PvPProtectedOUT_Type;
    private static readonly IntPtr NativeFieldInfoPtr_PvECastleDamage_Type;
    private static readonly IntPtr NativeFieldInfoPtr_PvPCastleDamageOutsideTime_Type;
    private static readonly IntPtr NativeFieldInfoPtr_WoodenWall_Type;
    private static readonly IntPtr NativeFieldInfoPtr_StoneWall_Type;
    private static readonly IntPtr NativeFieldInfoPtr_NeedExplosivesOrBear_Type;
    private static readonly IntPtr NativeFieldInfoPtr_Invulernable_Type;
    private static readonly IntPtr NativeFieldInfoPtr_Missing_LiquidSource;
    private static readonly IntPtr NativeFieldInfoPtr_InfoMessage_Type;
    private static readonly IntPtr NativeFieldInfoPtr_InfoWarning_Type;
    private static readonly IntPtr NativeFieldInfoPtr_InfoError_Type;
    private static readonly IntPtr NativeFieldInfoPtr_AttackMonsterGate_Type;
    private static readonly IntPtr NativeFieldInfoPtr_MinorHealing_Type;
    private static readonly IntPtr NativeFieldInfoPtr_DamageDoneHighLevelTarget_Type;
    private static readonly IntPtr NativeFieldInfoPtr_NotEnoughBloodManaKey;
    private static readonly IntPtr NativeFieldInfoPtr__Guid;
    private static readonly IntPtr NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe int GuidHash
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160763, XrefRangeEnd = 1160764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(SCTTypeCollectionAsset.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160764, XrefRangeEnd = 1160784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SCTTypeCollectionAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabGUID GetPrefabGUID()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(SCTTypeCollectionAsset.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SCTTypeCollectionAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SCTTypeCollectionAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SCTTypeCollectionAsset()
    {
      Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (SCTTypeCollectionAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr);
      SCTTypeCollectionAsset.NativeFieldInfoPtr_DamageDone_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (DamageDone_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_DamageTaken_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (DamageTaken_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_ResourceGain_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (ResourceGain_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_NeedBetterTool_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (NeedBetterTool_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_NeedExplosives_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (NeedExplosives_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_MissingMaterials_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (MissingMaterials_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_RequiresRecipe_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (RequiresRecipe_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_CritDamage_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (CritDamage_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_Healing_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (Healing_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_Absorb_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (Absorb_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_InventoryFull_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (InventoryFull_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_HaveEquippedItems_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (HaveEquippedItems_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_Generic_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (Generic_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_IgniteExtinguished_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (IgniteExtinguished_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_BloodEssence_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (BloodEssence_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_LocalChat_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (LocalChat_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_CastFailResult_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (CastFailResult_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_MAXHeal_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (MAXHeal_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_CannotTeleport_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (CannotTeleport_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_PvPProtectedIN_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (PvPProtectedIN_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_PvPProtectedOUT_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (PvPProtectedOUT_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_PvECastleDamage_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (PvECastleDamage_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_PvPCastleDamageOutsideTime_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (PvPCastleDamageOutsideTime_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_WoodenWall_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (WoodenWall_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_StoneWall_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (StoneWall_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_NeedExplosivesOrBear_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (NeedExplosivesOrBear_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_Invulernable_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (Invulernable_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_Missing_LiquidSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (Missing_LiquidSource));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_InfoMessage_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (InfoMessage_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_InfoWarning_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (InfoWarning_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_InfoError_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (InfoError_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_AttackMonsterGate_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (AttackMonsterGate_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_MinorHealing_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (MinorHealing_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_DamageDoneHighLevelTarget_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (DamageDoneHighLevelTarget_Type));
      SCTTypeCollectionAsset.NativeFieldInfoPtr_NotEnoughBloodManaKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (NotEnoughBloodManaKey));
      SCTTypeCollectionAsset.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, nameof (_Guid));
      SCTTypeCollectionAsset.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, 100692289);
      SCTTypeCollectionAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, 100692290);
      SCTTypeCollectionAsset.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, 100692291);
      SCTTypeCollectionAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SCTTypeCollectionAsset>.NativeClassPtr, 100692292);
    }

    public SCTTypeCollectionAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SCT_Type DamageDone_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_DamageDone_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_DamageDone_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type DamageTaken_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_DamageTaken_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_DamageTaken_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type ResourceGain_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_ResourceGain_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_ResourceGain_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type NeedBetterTool_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_NeedBetterTool_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_NeedBetterTool_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type NeedExplosives_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_NeedExplosives_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_NeedExplosives_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type MissingMaterials_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_MissingMaterials_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_MissingMaterials_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type RequiresRecipe_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_RequiresRecipe_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_RequiresRecipe_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type CritDamage_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_CritDamage_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_CritDamage_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type Healing_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_Healing_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_Healing_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type Absorb_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_Absorb_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_Absorb_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type InventoryFull_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_InventoryFull_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_InventoryFull_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type HaveEquippedItems_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_HaveEquippedItems_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_HaveEquippedItems_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type Generic_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_Generic_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_Generic_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type IgniteExtinguished_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_IgniteExtinguished_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_IgniteExtinguished_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type BloodEssence_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_BloodEssence_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_BloodEssence_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type LocalChat_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_LocalChat_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_LocalChat_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type CastFailResult_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_CastFailResult_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_CastFailResult_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type MAXHeal_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_MAXHeal_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_MAXHeal_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type CannotTeleport_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_CannotTeleport_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_CannotTeleport_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type PvPProtectedIN_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_PvPProtectedIN_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_PvPProtectedIN_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type PvPProtectedOUT_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_PvPProtectedOUT_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_PvPProtectedOUT_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type PvECastleDamage_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_PvECastleDamage_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_PvECastleDamage_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type PvPCastleDamageOutsideTime_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_PvPCastleDamageOutsideTime_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_PvPCastleDamageOutsideTime_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type WoodenWall_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_WoodenWall_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_WoodenWall_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type StoneWall_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_StoneWall_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_StoneWall_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type NeedExplosivesOrBear_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_NeedExplosivesOrBear_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_NeedExplosivesOrBear_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type Invulernable_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_Invulernable_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_Invulernable_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type Missing_LiquidSource
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_Missing_LiquidSource));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_Missing_LiquidSource), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type InfoMessage_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_InfoMessage_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_InfoMessage_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type InfoWarning_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_InfoWarning_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_InfoWarning_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type InfoError_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_InfoError_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_InfoError_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type AttackMonsterGate_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_AttackMonsterGate_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_AttackMonsterGate_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type MinorHealing_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_MinorHealing_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_MinorHealing_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SCT_Type DamageDoneHighLevelTarget_Type
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_DamageDoneHighLevelTarget_Type));
        return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_DamageDoneHighLevelTarget_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey NotEnoughBloodManaKey
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_NotEnoughBloodManaKey));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr_NotEnoughBloodManaKey)) = value;
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTTypeCollectionAsset.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
