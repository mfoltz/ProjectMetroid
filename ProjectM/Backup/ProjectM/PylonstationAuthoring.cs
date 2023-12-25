// Decompiled with JetBrains decompiler
// Type: ProjectM.PylonstationAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class PylonstationAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Recipes;
    private static readonly IntPtr NativeFieldInfoPtr_Upgrades;
    private static readonly IntPtr NativeFieldInfoPtr_CastleRaidRequirements;
    private static readonly IntPtr NativeFieldInfoPtr_CastleClaimRequirements;
    private static readonly IntPtr NativeFieldInfoPtr_CastleDestroyRequirements;
    private static readonly IntPtr NativeFieldInfoPtr_SlotsPerLevel;
    private static readonly IntPtr NativeFieldInfoPtr_ClaimGuid;
    private static readonly IntPtr NativeFieldInfoPtr_LevelUpGuid;
    private static readonly IntPtr NativeFieldInfoPtr_DestroyGuid;
    private static readonly IntPtr NativeFieldInfoPtr_ActiveSequence;
    private static readonly IntPtr NativeFieldInfoPtr_InactiveSequence;
    private static readonly IntPtr NativeMethodInfoPtr_get_UsedRecipes_Public_Virtual_Final_New_get_List_1_RecipeDataAsset_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_GetUpgrades_Public_get_List_1_UpgradeDataAsset_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_GetCastleClaim_Public_get_List_1_CastleClaimDataAsset_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_GetCastleDestroy_Public_get_List_1_CastleDestroyDataAsset_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe List<RecipeDataAsset> UsedRecipes
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063122, XrefRangeEnd = 1063131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationAuthoring.NativeMethodInfoPtr_get_UsedRecipes_Public_Virtual_Final_New_get_List_1_RecipeDataAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (List<RecipeDataAsset>) null : new List<RecipeDataAsset>(pointer);
      }
    }

    public unsafe List<UpgradeDataAsset> GetUpgrades
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063131, XrefRangeEnd = 1063140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationAuthoring.NativeMethodInfoPtr_get_GetUpgrades_Public_get_List_1_UpgradeDataAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (List<UpgradeDataAsset>) null : new List<UpgradeDataAsset>(pointer);
      }
    }

    public unsafe List<CastleClaimDataAsset> GetCastleClaim
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063140, XrefRangeEnd = 1063149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationAuthoring.NativeMethodInfoPtr_get_GetCastleClaim_Public_get_List_1_CastleClaimDataAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (List<CastleClaimDataAsset>) null : new List<CastleClaimDataAsset>(pointer);
      }
    }

    public unsafe List<CastleDestroyDataAsset> GetCastleDestroy
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063149, XrefRangeEnd = 1063158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(PylonstationAuthoring.NativeMethodInfoPtr_get_GetCastleDestroy_Public_get_List_1_CastleDestroyDataAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (List<CastleDestroyDataAsset>) null : new List<CastleDestroyDataAsset>(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063158, XrefRangeEnd = 1063225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(PylonstationAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063225, XrefRangeEnd = 1063244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PylonstationAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063244, XrefRangeEnd = 1063245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PylonstationAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PylonstationAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PylonstationAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PylonstationAuthoring()
    {
      Il2CppClassPointerStore<PylonstationAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PylonstationAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonstationAuthoring>.NativeClassPtr);
      PylonstationAuthoring.NativeFieldInfoPtr_Recipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationAuthoring>.NativeClassPtr, nameof (Recipes));
      PylonstationAuthoring.NativeFieldInfoPtr_Upgrades = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationAuthoring>.NativeClassPtr, nameof (Upgrades));
      PylonstationAuthoring.NativeFieldInfoPtr_CastleRaidRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationAuthoring>.NativeClassPtr, nameof (CastleRaidRequirements));
      PylonstationAuthoring.NativeFieldInfoPtr_CastleClaimRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationAuthoring>.NativeClassPtr, nameof (CastleClaimRequirements));
      PylonstationAuthoring.NativeFieldInfoPtr_CastleDestroyRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationAuthoring>.NativeClassPtr, nameof (CastleDestroyRequirements));
      PylonstationAuthoring.NativeFieldInfoPtr_SlotsPerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationAuthoring>.NativeClassPtr, nameof (SlotsPerLevel));
      PylonstationAuthoring.NativeFieldInfoPtr_ClaimGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationAuthoring>.NativeClassPtr, nameof (ClaimGuid));
      PylonstationAuthoring.NativeFieldInfoPtr_LevelUpGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationAuthoring>.NativeClassPtr, nameof (LevelUpGuid));
      PylonstationAuthoring.NativeFieldInfoPtr_DestroyGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationAuthoring>.NativeClassPtr, nameof (DestroyGuid));
      PylonstationAuthoring.NativeFieldInfoPtr_ActiveSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationAuthoring>.NativeClassPtr, nameof (ActiveSequence));
      PylonstationAuthoring.NativeFieldInfoPtr_InactiveSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonstationAuthoring>.NativeClassPtr, nameof (InactiveSequence));
      PylonstationAuthoring.NativeMethodInfoPtr_get_UsedRecipes_Public_Virtual_Final_New_get_List_1_RecipeDataAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationAuthoring>.NativeClassPtr, 100683464);
      PylonstationAuthoring.NativeMethodInfoPtr_get_GetUpgrades_Public_get_List_1_UpgradeDataAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationAuthoring>.NativeClassPtr, 100683465);
      PylonstationAuthoring.NativeMethodInfoPtr_get_GetCastleClaim_Public_get_List_1_CastleClaimDataAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationAuthoring>.NativeClassPtr, 100683466);
      PylonstationAuthoring.NativeMethodInfoPtr_get_GetCastleDestroy_Public_get_List_1_CastleDestroyDataAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationAuthoring>.NativeClassPtr, 100683467);
      PylonstationAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationAuthoring>.NativeClassPtr, 100683468);
      PylonstationAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationAuthoring>.NativeClassPtr, 100683469);
      PylonstationAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PylonstationAuthoring>.NativeClassPtr, 100683470);
    }

    public PylonstationAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<RecipeDataAsset> Recipes
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationAuthoring.NativeFieldInfoPtr_Recipes));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<RecipeDataAsset>) null : new Il2CppReferenceArray<RecipeDataAsset>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PylonstationAuthoring.NativeFieldInfoPtr_Recipes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<UpgradeDataAsset> Upgrades
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationAuthoring.NativeFieldInfoPtr_Upgrades));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<UpgradeDataAsset>) null : new Il2CppReferenceArray<UpgradeDataAsset>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PylonstationAuthoring.NativeFieldInfoPtr_Upgrades), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<CastleRaidDataAsset> CastleRaidRequirements
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationAuthoring.NativeFieldInfoPtr_CastleRaidRequirements));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<CastleRaidDataAsset>) null : new Il2CppReferenceArray<CastleRaidDataAsset>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PylonstationAuthoring.NativeFieldInfoPtr_CastleRaidRequirements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<CastleClaimDataAsset> CastleClaimRequirements
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationAuthoring.NativeFieldInfoPtr_CastleClaimRequirements));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<CastleClaimDataAsset>) null : new Il2CppReferenceArray<CastleClaimDataAsset>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PylonstationAuthoring.NativeFieldInfoPtr_CastleClaimRequirements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<CastleDestroyDataAsset> CastleDestroyRequirements
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationAuthoring.NativeFieldInfoPtr_CastleDestroyRequirements));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<CastleDestroyDataAsset>) null : new Il2CppReferenceArray<CastleDestroyDataAsset>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PylonstationAuthoring.NativeFieldInfoPtr_CastleDestroyRequirements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int SlotsPerLevel
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationAuthoring.NativeFieldInfoPtr_SlotsPerLevel));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationAuthoring.NativeFieldInfoPtr_SlotsPerLevel)) = value;
      }
    }

    public unsafe SequenceField ClaimGuid
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationAuthoring.NativeFieldInfoPtr_ClaimGuid));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PylonstationAuthoring.NativeFieldInfoPtr_ClaimGuid), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField LevelUpGuid
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationAuthoring.NativeFieldInfoPtr_LevelUpGuid));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PylonstationAuthoring.NativeFieldInfoPtr_LevelUpGuid), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField DestroyGuid
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationAuthoring.NativeFieldInfoPtr_DestroyGuid));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PylonstationAuthoring.NativeFieldInfoPtr_DestroyGuid), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField ActiveSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationAuthoring.NativeFieldInfoPtr_ActiveSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PylonstationAuthoring.NativeFieldInfoPtr_ActiveSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField InactiveSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PylonstationAuthoring.NativeFieldInfoPtr_InactiveSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PylonstationAuthoring.NativeFieldInfoPtr_InactiveSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
