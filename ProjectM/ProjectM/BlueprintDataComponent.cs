// Decompiled with JetBrains decompiler
// Type: ProjectM.BlueprintDataComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using ProjectM.ContentTesting;
using ProjectM.Sequencer;
using ProjectM.Shared;
using ProjectM.UI;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class BlueprintDataComponent : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_IsStartBlueprint;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsInventoryItemBuilding;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExitBuildModeWhenBuilt;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiresLineOfSight;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiresSuccessfullPathfinding;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Description;
    private static readonly System.IntPtr NativeFieldInfoPtr_DescriptionBuilder;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlueprintIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_LimitedType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Requirements;
    private static readonly System.IntPtr NativeFieldInfoPtr_Variations;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiresUserContentFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditSequenceField;
    private static readonly System.IntPtr NativeFieldInfoPtr_InvalidEditSequenceField;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlaceSequenceField;
    private static readonly System.IntPtr NativeFieldInfoPtr_InvalidPlaceSequenceField;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuildingSequenceField;
    private static readonly System.IntPtr NativeFieldInfoPtr_DismantledSequenceField;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyedSequenceField;
    private static readonly System.IntPtr NativeFieldInfoPtr_RepairedSequenceField;
    private static readonly System.IntPtr NativeFieldInfoPtr_DismantleTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_DismantleFraction;
    private static readonly System.IntPtr NativeFieldInfoPtr_FullDismantleTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_SkipDismantleTimeIfReplaced;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsPartOfCastle;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnlyPlaceableOnGround;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRange;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSequenceGUID_Private_SequenceGUID_SequenceField_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_ContentTesting_IGameObjectContentTest_get_TestGroups_Private_Virtual_Final_New_get_TestGroupFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_ContentTesting_IGameObjectContentTest_Test_Private_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988644, XrefRangeEnd = 988798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(BlueprintDataComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 988804, RefRangeEnd = 988812, XrefRangeStart = 988798, XrefRangeEnd = 988804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceGUID GetSequenceGUID(
      SequenceField sequenceField,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sequenceField);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BlueprintDataComponent.NativeMethodInfoPtr_GetSequenceGUID_Private_SequenceGUID_SequenceField_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SequenceGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988812, XrefRangeEnd = 988824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BlueprintDataComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe TestGroupFlags ProjectM\u002EContentTesting\u002EIGameObjectContentTest\u002ETestGroups
    {
      [CallerCount(21), CachedScanResults(RefRangeStart = 31081, RefRangeEnd = 31102, XrefRangeStart = 31081, XrefRangeEnd = 31102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BlueprintDataComponent.NativeMethodInfoPtr_ProjectM_ContentTesting_IGameObjectContentTest_get_TestGroups_Private_Virtual_Final_New_get_TestGroupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TestGroupFlags*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988824, XrefRangeEnd = 988825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ProjectM_ContentTesting_IGameObjectContentTest_Test(
      TestContext<GameObject> context,
      List<ContentIssue> outIssues)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlueprintDataComponent.NativeMethodInfoPtr_ProjectM_ContentTesting_IGameObjectContentTest_Test_Private_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988825, XrefRangeEnd = 988826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BlueprintDataComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlueprintDataComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BlueprintDataComponent()
    {
      Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (BlueprintDataComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr);
      BlueprintDataComponent.NativeFieldInfoPtr_IsStartBlueprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (IsStartBlueprint));
      BlueprintDataComponent.NativeFieldInfoPtr_IsInventoryItemBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (IsInventoryItemBuilding));
      BlueprintDataComponent.NativeFieldInfoPtr_ExitBuildModeWhenBuilt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (ExitBuildModeWhenBuilt));
      BlueprintDataComponent.NativeFieldInfoPtr_RequiresLineOfSight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (RequiresLineOfSight));
      BlueprintDataComponent.NativeFieldInfoPtr_RequiresSuccessfullPathfinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (RequiresSuccessfullPathfinding));
      BlueprintDataComponent.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (Name));
      BlueprintDataComponent.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (Description));
      BlueprintDataComponent.NativeFieldInfoPtr_DescriptionBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (DescriptionBuilder));
      BlueprintDataComponent.NativeFieldInfoPtr_BlueprintIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (BlueprintIcon));
      BlueprintDataComponent.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (Type));
      BlueprintDataComponent.NativeFieldInfoPtr_LimitedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (LimitedType));
      BlueprintDataComponent.NativeFieldInfoPtr_Requirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (Requirements));
      BlueprintDataComponent.NativeFieldInfoPtr_Variations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (Variations));
      BlueprintDataComponent.NativeFieldInfoPtr_RequiresUserContentFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (RequiresUserContentFlags));
      BlueprintDataComponent.NativeFieldInfoPtr_EditSequenceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (EditSequenceField));
      BlueprintDataComponent.NativeFieldInfoPtr_InvalidEditSequenceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (InvalidEditSequenceField));
      BlueprintDataComponent.NativeFieldInfoPtr_PlaceSequenceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (PlaceSequenceField));
      BlueprintDataComponent.NativeFieldInfoPtr_InvalidPlaceSequenceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (InvalidPlaceSequenceField));
      BlueprintDataComponent.NativeFieldInfoPtr_BuildingSequenceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (BuildingSequenceField));
      BlueprintDataComponent.NativeFieldInfoPtr_DismantledSequenceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (DismantledSequenceField));
      BlueprintDataComponent.NativeFieldInfoPtr_DestroyedSequenceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (DestroyedSequenceField));
      BlueprintDataComponent.NativeFieldInfoPtr_RepairedSequenceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (RepairedSequenceField));
      BlueprintDataComponent.NativeFieldInfoPtr_DismantleTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (DismantleTime));
      BlueprintDataComponent.NativeFieldInfoPtr_DismantleFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (DismantleFraction));
      BlueprintDataComponent.NativeFieldInfoPtr_FullDismantleTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (FullDismantleTime));
      BlueprintDataComponent.NativeFieldInfoPtr_SkipDismantleTimeIfReplaced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (SkipDismantleTimeIfReplaced));
      BlueprintDataComponent.NativeFieldInfoPtr_IsPartOfCastle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (IsPartOfCastle));
      BlueprintDataComponent.NativeFieldInfoPtr_OnlyPlaceableOnGround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (OnlyPlaceableOnGround));
      BlueprintDataComponent.NativeFieldInfoPtr_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (MaxRange));
      BlueprintDataComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, 100676272);
      BlueprintDataComponent.NativeMethodInfoPtr_GetSequenceGUID_Private_SequenceGUID_SequenceField_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, 100676273);
      BlueprintDataComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, 100676274);
      BlueprintDataComponent.NativeMethodInfoPtr_ProjectM_ContentTesting_IGameObjectContentTest_get_TestGroups_Private_Virtual_Final_New_get_TestGroupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, 100676275);
      BlueprintDataComponent.NativeMethodInfoPtr_ProjectM_ContentTesting_IGameObjectContentTest_Test_Private_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, 100676276);
      BlueprintDataComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, 100676277);
    }

    public BlueprintDataComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool IsStartBlueprint
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_IsStartBlueprint));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_IsStartBlueprint)) = value;
      }
    }

    public unsafe bool IsInventoryItemBuilding
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_IsInventoryItemBuilding));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_IsInventoryItemBuilding)) = value;
      }
    }

    public unsafe bool ExitBuildModeWhenBuilt
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_ExitBuildModeWhenBuilt));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_ExitBuildModeWhenBuilt)) = value;
      }
    }

    public unsafe bool RequiresLineOfSight
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_RequiresLineOfSight));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_RequiresLineOfSight)) = value;
      }
    }

    public unsafe bool RequiresSuccessfullPathfinding
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_RequiresSuccessfullPathfinding));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_RequiresSuccessfullPathfinding)) = value;
      }
    }

    public unsafe LocalizationKey Name
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_Name));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_Name)) = value;
      }
    }

    public unsafe LocalizationKey Description
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_Description));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_Description)) = value;
      }
    }

    public unsafe LocalizedStringBuilder DescriptionBuilder
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_DescriptionBuilder));
        return pointer == System.IntPtr.Zero ? (LocalizedStringBuilder) null : new LocalizedStringBuilder(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_DescriptionBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<Sprite> BlueprintIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_BlueprintIcon));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<Sprite>) null : new WeakAssetReference<Sprite>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_BlueprintIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BlueprintType Type
    {
      get
      {
        return *(BlueprintType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(BlueprintType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe CastleLimitedType LimitedType
    {
      get
      {
        return *(CastleLimitedType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_LimitedType));
      }
      [param: In] set
      {
        *(CastleLimitedType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_LimitedType)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<BlueprintDataComponent.BlueprintRequirement> Requirements
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_Requirements));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<BlueprintDataComponent.BlueprintRequirement>) null : new Il2CppReferenceArray<BlueprintDataComponent.BlueprintRequirement>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_Requirements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<WeakAssetReference<BlueprintDataComponent>> Variations
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_Variations));
        return pointer == System.IntPtr.Zero ? (List<WeakAssetReference<BlueprintDataComponent>>) null : new List<WeakAssetReference<BlueprintDataComponent>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_Variations), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UserContentFlags RequiresUserContentFlags
    {
      get
      {
        return *(UserContentFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_RequiresUserContentFlags));
      }
      [param: In] set
      {
        *(UserContentFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_RequiresUserContentFlags)) = value;
      }
    }

    public unsafe SequenceField EditSequenceField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_EditSequenceField));
        return pointer == System.IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_EditSequenceField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField InvalidEditSequenceField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_InvalidEditSequenceField));
        return pointer == System.IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_InvalidEditSequenceField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField PlaceSequenceField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_PlaceSequenceField));
        return pointer == System.IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_PlaceSequenceField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField InvalidPlaceSequenceField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_InvalidPlaceSequenceField));
        return pointer == System.IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_InvalidPlaceSequenceField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField BuildingSequenceField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_BuildingSequenceField));
        return pointer == System.IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_BuildingSequenceField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField DismantledSequenceField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_DismantledSequenceField));
        return pointer == System.IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_DismantledSequenceField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField DestroyedSequenceField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_DestroyedSequenceField));
        return pointer == System.IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_DestroyedSequenceField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField RepairedSequenceField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_RepairedSequenceField));
        return pointer == System.IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_RepairedSequenceField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float DismantleTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_DismantleTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_DismantleTime)) = value;
      }
    }

    public unsafe float DismantleFraction
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_DismantleFraction));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_DismantleFraction)) = value;
      }
    }

    public unsafe float FullDismantleTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_FullDismantleTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_FullDismantleTime)) = value;
      }
    }

    public unsafe bool SkipDismantleTimeIfReplaced
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_SkipDismantleTimeIfReplaced));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_SkipDismantleTimeIfReplaced)) = value;
      }
    }

    public unsafe bool IsPartOfCastle
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_IsPartOfCastle));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_IsPartOfCastle)) = value;
      }
    }

    public unsafe bool OnlyPlaceableOnGround
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_OnlyPlaceableOnGround));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_OnlyPlaceableOnGround)) = value;
      }
    }

    public unsafe float MaxRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_MaxRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.NativeFieldInfoPtr_MaxRange)) = value;
      }
    }

    [Serializable]
    public sealed class BlueprintRequirement : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__CachedPrefabGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_Item;
      private static readonly System.IntPtr NativeFieldInfoPtr_Amount;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemPrefabGuid_Public_get_PrefabGUID_0;

      public unsafe PrefabGUID ItemPrefabGuid
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988639, XrefRangeEnd = 988644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BlueprintDataComponent.BlueprintRequirement.NativeMethodInfoPtr_get_ItemPrefabGuid_Public_get_PrefabGUID_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      static BlueprintRequirement()
      {
        Il2CppClassPointerStore<BlueprintDataComponent.BlueprintRequirement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, nameof (BlueprintRequirement));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlueprintDataComponent.BlueprintRequirement>.NativeClassPtr);
        BlueprintDataComponent.BlueprintRequirement.NativeFieldInfoPtr__CachedPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent.BlueprintRequirement>.NativeClassPtr, nameof (_CachedPrefabGuid));
        BlueprintDataComponent.BlueprintRequirement.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent.BlueprintRequirement>.NativeClassPtr, nameof (Item));
        BlueprintDataComponent.BlueprintRequirement.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent.BlueprintRequirement>.NativeClassPtr, nameof (Amount));
        BlueprintDataComponent.BlueprintRequirement.NativeMethodInfoPtr_get_ItemPrefabGuid_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDataComponent.BlueprintRequirement>.NativeClassPtr, 100676278);
      }

      public BlueprintRequirement(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public BlueprintRequirement()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlueprintDataComponent.BlueprintRequirement>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlueprintDataComponent.BlueprintRequirement>.NativeClassPtr, data));
      }

      public unsafe PrefabGUID _CachedPrefabGuid
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.BlueprintRequirement.NativeFieldInfoPtr__CachedPrefabGuid));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.BlueprintRequirement.NativeFieldInfoPtr__CachedPrefabGuid)) = value;
        }
      }

      public unsafe ItemDataComponent Item
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.BlueprintRequirement.NativeFieldInfoPtr_Item));
          return pointer == System.IntPtr.Zero ? (ItemDataComponent) null : new ItemDataComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.BlueprintRequirement.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int Amount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.BlueprintRequirement.NativeFieldInfoPtr_Amount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlueprintDataComponent.BlueprintRequirement.NativeFieldInfoPtr_Amount)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.BlueprintDataComponent/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__30_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__30_0_Internal_Boolean_WeakAssetReference_1_BlueprintDataComponent_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlueprintDataComponent.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BlueprintDataComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe bool _Convert_b__30_0(WeakAssetReference<BlueprintDataComponent> skin)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) skin);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BlueprintDataComponent.__c.NativeMethodInfoPtr__Convert_b__30_0_Internal_Boolean_WeakAssetReference_1_BlueprintDataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<BlueprintDataComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlueprintDataComponent>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlueprintDataComponent.__c>.NativeClassPtr);
        BlueprintDataComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent.__c>.NativeClassPtr, "<>9");
        BlueprintDataComponent.__c.NativeFieldInfoPtr___9__30_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlueprintDataComponent.__c>.NativeClassPtr, "<>9__30_0");
        BlueprintDataComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDataComponent.__c>.NativeClassPtr, 100676280);
        BlueprintDataComponent.__c.NativeMethodInfoPtr__Convert_b__30_0_Internal_Boolean_WeakAssetReference_1_BlueprintDataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlueprintDataComponent.__c>.NativeClassPtr, 100676281);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe BlueprintDataComponent.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BlueprintDataComponent.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (BlueprintDataComponent.__c) null : new BlueprintDataComponent.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BlueprintDataComponent.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<WeakAssetReference<BlueprintDataComponent>, bool> __9__30_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(BlueprintDataComponent.__c.NativeFieldInfoPtr___9__30_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<WeakAssetReference<BlueprintDataComponent>, bool>) null : new Il2CppSystem.Func<WeakAssetReference<BlueprintDataComponent>, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(BlueprintDataComponent.__c.NativeFieldInfoPtr___9__30_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
