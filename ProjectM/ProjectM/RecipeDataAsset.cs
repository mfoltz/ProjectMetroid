// Decompiled with JetBrains decompiler
// Type: ProjectM.RecipeDataAsset
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class RecipeDataAsset : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OutputItems;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutputUnits;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemCost;
    private static readonly System.IntPtr NativeFieldInfoPtr_SharedItemCost;
    private static readonly System.IntPtr NativeFieldInfoPtr_CraftDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_CraftDurationTimer;
    private static readonly System.IntPtr NativeFieldInfoPtr_HudSortingOrder;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlwaysUnlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideInStation;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreServerSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_RepairItemCost;
    private static readonly System.IntPtr NativeFieldInfoPtr_SharedRepairCost;
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiresUserContentFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_Skins;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreRepairCostRequirement;
    private static readonly System.IntPtr NativeFieldInfoPtr__Guid;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddToRuntimeBuffer_Public_Void_DynamicBuffer_1_WorkstationRecipesBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddToRuntimeBuffer_Public_Void_DynamicBuffer_1_RefinementstationRecipesBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe int GuidHash
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 992649, RefRangeEnd = 992653, XrefRangeStart = 992648, XrefRangeEnd = 992649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RecipeDataAsset.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 992649, RefRangeEnd = 992653, XrefRangeStart = 992649, XrefRangeEnd = 992653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabGUID GetPrefabGUID()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RecipeDataAsset.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992653, XrefRangeEnd = 992815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RecipeDataAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 992854, RefRangeEnd = 992859, XrefRangeStart = 992815, XrefRangeEnd = 992854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddToRuntimeBuffer(DynamicBuffer<WorkstationRecipesBuffer> buffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &buffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RecipeDataAsset.NativeMethodInfoPtr_AddToRuntimeBuffer_Public_Void_DynamicBuffer_1_WorkstationRecipesBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 992898, RefRangeEnd = 992901, XrefRangeStart = 992859, XrefRangeEnd = 992898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddToRuntimeBuffer(
      DynamicBuffer<RefinementstationRecipesBuffer> buffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &buffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RecipeDataAsset.NativeMethodInfoPtr_AddToRuntimeBuffer_Public_Void_DynamicBuffer_1_RefinementstationRecipesBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnBeforeSerialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RecipeDataAsset.NativeMethodInfoPtr_OnBeforeSerialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnAfterDeserialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RecipeDataAsset.NativeMethodInfoPtr_OnAfterDeserialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992901, XrefRangeEnd = 992902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RecipeDataAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RecipeDataAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RecipeDataAsset()
    {
      Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RecipeDataAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr);
      RecipeDataAsset.NativeFieldInfoPtr_OutputItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, nameof (OutputItems));
      RecipeDataAsset.NativeFieldInfoPtr_OutputUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, nameof (OutputUnits));
      RecipeDataAsset.NativeFieldInfoPtr_ItemCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, nameof (ItemCost));
      RecipeDataAsset.NativeFieldInfoPtr_SharedItemCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, nameof (SharedItemCost));
      RecipeDataAsset.NativeFieldInfoPtr_CraftDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, nameof (CraftDuration));
      RecipeDataAsset.NativeFieldInfoPtr_CraftDurationTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, nameof (CraftDurationTimer));
      RecipeDataAsset.NativeFieldInfoPtr_HudSortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, nameof (HudSortingOrder));
      RecipeDataAsset.NativeFieldInfoPtr_AlwaysUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, nameof (AlwaysUnlocked));
      RecipeDataAsset.NativeFieldInfoPtr_HideInStation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, nameof (HideInStation));
      RecipeDataAsset.NativeFieldInfoPtr_IgnoreServerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, nameof (IgnoreServerSettings));
      RecipeDataAsset.NativeFieldInfoPtr_RepairItemCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, nameof (RepairItemCost));
      RecipeDataAsset.NativeFieldInfoPtr_SharedRepairCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, nameof (SharedRepairCost));
      RecipeDataAsset.NativeFieldInfoPtr_RequiresUserContentFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, nameof (RequiresUserContentFlags));
      RecipeDataAsset.NativeFieldInfoPtr_Skins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, nameof (Skins));
      RecipeDataAsset.NativeFieldInfoPtr_IgnoreRepairCostRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, nameof (IgnoreRepairCostRequirement));
      RecipeDataAsset.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, nameof (_Guid));
      RecipeDataAsset.NativeMethodInfoPtr_get_GuidHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, 100676647);
      RecipeDataAsset.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, 100676648);
      RecipeDataAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, 100676649);
      RecipeDataAsset.NativeMethodInfoPtr_AddToRuntimeBuffer_Public_Void_DynamicBuffer_1_WorkstationRecipesBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, 100676650);
      RecipeDataAsset.NativeMethodInfoPtr_AddToRuntimeBuffer_Public_Void_DynamicBuffer_1_RefinementstationRecipesBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, 100676651);
      RecipeDataAsset.NativeMethodInfoPtr_OnBeforeSerialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, 100676652);
      RecipeDataAsset.NativeMethodInfoPtr_OnAfterDeserialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, 100676653);
      RecipeDataAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, 100676654);
    }

    public RecipeDataAsset(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<RecipeDataAsset.RecipeOutputItemEntry> OutputItems
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_OutputItems));
        return pointer == System.IntPtr.Zero ? (List<RecipeDataAsset.RecipeOutputItemEntry>) null : new List<RecipeDataAsset.RecipeOutputItemEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_OutputItems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<RecipeDataAsset.RecipeOutputUnitEntry> OutputUnits
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_OutputUnits));
        return pointer == System.IntPtr.Zero ? (List<RecipeDataAsset.RecipeOutputUnitEntry>) null : new List<RecipeDataAsset.RecipeOutputUnitEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_OutputUnits), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<RecipeDataAsset.RecipeRequirement> ItemCost
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_ItemCost));
        return pointer == System.IntPtr.Zero ? (List<RecipeDataAsset.RecipeRequirement>) null : new List<RecipeDataAsset.RecipeRequirement>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_ItemCost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SharedItemRequirementAsset> SharedItemCost
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_SharedItemCost));
        return pointer == System.IntPtr.Zero ? (List<SharedItemRequirementAsset>) null : new List<SharedItemRequirementAsset>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_SharedItemCost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float CraftDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_CraftDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_CraftDuration)) = value;
      }
    }

    public unsafe BasicTimerSettings CraftDurationTimer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_CraftDurationTimer));
        return pointer == System.IntPtr.Zero ? (BasicTimerSettings) null : new BasicTimerSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_CraftDurationTimer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int HudSortingOrder
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_HudSortingOrder));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_HudSortingOrder)) = value;
      }
    }

    public unsafe bool AlwaysUnlocked
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_AlwaysUnlocked));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_AlwaysUnlocked)) = value;
      }
    }

    public unsafe bool HideInStation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_HideInStation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_HideInStation)) = value;
      }
    }

    public unsafe bool IgnoreServerSettings
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_IgnoreServerSettings));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_IgnoreServerSettings)) = value;
      }
    }

    public unsafe List<RecipeDataAsset.RecipeRequirement> RepairItemCost
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_RepairItemCost));
        return pointer == System.IntPtr.Zero ? (List<RecipeDataAsset.RecipeRequirement>) null : new List<RecipeDataAsset.RecipeRequirement>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_RepairItemCost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SharedItemRequirementAsset> SharedRepairCost
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_SharedRepairCost));
        return pointer == System.IntPtr.Zero ? (List<SharedItemRequirementAsset>) null : new List<SharedItemRequirementAsset>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_SharedRepairCost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UserContentFlags RequiresUserContentFlags
    {
      get
      {
        return *(UserContentFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_RequiresUserContentFlags));
      }
      [param: In] set
      {
        *(UserContentFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_RequiresUserContentFlags)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<RecipeDataAsset> Skins
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_Skins));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<RecipeDataAsset>) null : new Il2CppReferenceArray<RecipeDataAsset>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_Skins), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool IgnoreRepairCostRequirement
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_IgnoreRepairCostRequirement));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr_IgnoreRepairCostRequirement)) = value;
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    [Serializable]
    public sealed class RecipeRequirement : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ItemPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_Amount;

      static RecipeRequirement()
      {
        Il2CppClassPointerStore<RecipeDataAsset.RecipeRequirement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, nameof (RecipeRequirement));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeDataAsset.RecipeRequirement>.NativeClassPtr);
        RecipeDataAsset.RecipeRequirement.NativeFieldInfoPtr_ItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset.RecipeRequirement>.NativeClassPtr, nameof (ItemPrefab));
        RecipeDataAsset.RecipeRequirement.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset.RecipeRequirement>.NativeClassPtr, nameof (Amount));
      }

      public RecipeRequirement(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public RecipeRequirement()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RecipeDataAsset.RecipeRequirement>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RecipeDataAsset.RecipeRequirement>.NativeClassPtr, data));
      }

      public unsafe WeakAssetReference<ItemDataComponent> ItemPrefab
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.RecipeRequirement.NativeFieldInfoPtr_ItemPrefab));
          return pointer == System.IntPtr.Zero ? (WeakAssetReference<ItemDataComponent>) null : new WeakAssetReference<ItemDataComponent>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.RecipeRequirement.NativeFieldInfoPtr_ItemPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int Amount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.RecipeRequirement.NativeFieldInfoPtr_Amount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.RecipeRequirement.NativeFieldInfoPtr_Amount)) = value;
        }
      }
    }

    [Serializable]
    public sealed class RecipeOutputItemEntry : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ItemPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_Amount;

      static RecipeOutputItemEntry()
      {
        Il2CppClassPointerStore<RecipeDataAsset.RecipeOutputItemEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, nameof (RecipeOutputItemEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeDataAsset.RecipeOutputItemEntry>.NativeClassPtr);
        RecipeDataAsset.RecipeOutputItemEntry.NativeFieldInfoPtr_ItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset.RecipeOutputItemEntry>.NativeClassPtr, nameof (ItemPrefab));
        RecipeDataAsset.RecipeOutputItemEntry.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset.RecipeOutputItemEntry>.NativeClassPtr, nameof (Amount));
      }

      public RecipeOutputItemEntry(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public RecipeOutputItemEntry()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RecipeDataAsset.RecipeOutputItemEntry>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RecipeDataAsset.RecipeOutputItemEntry>.NativeClassPtr, data));
      }

      public unsafe WeakAssetReference<ItemDataComponent> ItemPrefab
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.RecipeOutputItemEntry.NativeFieldInfoPtr_ItemPrefab));
          return pointer == System.IntPtr.Zero ? (WeakAssetReference<ItemDataComponent>) null : new WeakAssetReference<ItemDataComponent>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.RecipeOutputItemEntry.NativeFieldInfoPtr_ItemPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int Amount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.RecipeOutputItemEntry.NativeFieldInfoPtr_Amount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.RecipeOutputItemEntry.NativeFieldInfoPtr_Amount)) = value;
        }
      }
    }

    [Serializable]
    public sealed class RecipeOutputUnitEntry : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_UnitPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_Amount;

      static RecipeOutputUnitEntry()
      {
        Il2CppClassPointerStore<RecipeDataAsset.RecipeOutputUnitEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, nameof (RecipeOutputUnitEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeDataAsset.RecipeOutputUnitEntry>.NativeClassPtr);
        RecipeDataAsset.RecipeOutputUnitEntry.NativeFieldInfoPtr_UnitPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset.RecipeOutputUnitEntry>.NativeClassPtr, nameof (UnitPrefab));
        RecipeDataAsset.RecipeOutputUnitEntry.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset.RecipeOutputUnitEntry>.NativeClassPtr, nameof (Amount));
      }

      public RecipeOutputUnitEntry(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public RecipeOutputUnitEntry()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RecipeDataAsset.RecipeOutputUnitEntry>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RecipeDataAsset.RecipeOutputUnitEntry>.NativeClassPtr, data));
      }

      public unsafe WeakAssetReference<PrefabGuidComponent> UnitPrefab
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.RecipeOutputUnitEntry.NativeFieldInfoPtr_UnitPrefab));
          return pointer == System.IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.RecipeOutputUnitEntry.NativeFieldInfoPtr_UnitPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int Amount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.RecipeOutputUnitEntry.NativeFieldInfoPtr_Amount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataAsset.RecipeOutputUnitEntry.NativeFieldInfoPtr_Amount)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.RecipeDataAsset/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__22_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__23_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__24_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__22_0_Internal_Boolean_RecipeDataAsset_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddToRuntimeBuffer_b__23_0_Internal_Boolean_RecipeDataAsset_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddToRuntimeBuffer_b__24_0_Internal_Boolean_RecipeDataAsset_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecipeDataAsset.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RecipeDataAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992636, XrefRangeEnd = 992640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _Convert_b__22_0(RecipeDataAsset skin)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) skin);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RecipeDataAsset.__c.NativeMethodInfoPtr__Convert_b__22_0_Internal_Boolean_RecipeDataAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992640, XrefRangeEnd = 992644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _AddToRuntimeBuffer_b__23_0(RecipeDataAsset skin)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) skin);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RecipeDataAsset.__c.NativeMethodInfoPtr__AddToRuntimeBuffer_b__23_0_Internal_Boolean_RecipeDataAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992644, XrefRangeEnd = 992648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _AddToRuntimeBuffer_b__24_0(RecipeDataAsset skin)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) skin);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RecipeDataAsset.__c.NativeMethodInfoPtr__AddToRuntimeBuffer_b__24_0_Internal_Boolean_RecipeDataAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<RecipeDataAsset.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RecipeDataAsset>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeDataAsset.__c>.NativeClassPtr);
        RecipeDataAsset.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset.__c>.NativeClassPtr, "<>9");
        RecipeDataAsset.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset.__c>.NativeClassPtr, "<>9__22_0");
        RecipeDataAsset.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset.__c>.NativeClassPtr, "<>9__23_0");
        RecipeDataAsset.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataAsset.__c>.NativeClassPtr, "<>9__24_0");
        RecipeDataAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDataAsset.__c>.NativeClassPtr, 100676656);
        RecipeDataAsset.__c.NativeMethodInfoPtr__Convert_b__22_0_Internal_Boolean_RecipeDataAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDataAsset.__c>.NativeClassPtr, 100676657);
        RecipeDataAsset.__c.NativeMethodInfoPtr__AddToRuntimeBuffer_b__23_0_Internal_Boolean_RecipeDataAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDataAsset.__c>.NativeClassPtr, 100676658);
        RecipeDataAsset.__c.NativeMethodInfoPtr__AddToRuntimeBuffer_b__24_0_Internal_Boolean_RecipeDataAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDataAsset.__c>.NativeClassPtr, 100676659);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe RecipeDataAsset.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RecipeDataAsset.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (RecipeDataAsset.__c) null : new RecipeDataAsset.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RecipeDataAsset.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<RecipeDataAsset, bool> __9__22_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RecipeDataAsset.__c.NativeFieldInfoPtr___9__22_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<RecipeDataAsset, bool>) null : new Il2CppSystem.Func<RecipeDataAsset, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RecipeDataAsset.__c.NativeFieldInfoPtr___9__22_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<RecipeDataAsset, bool> __9__23_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RecipeDataAsset.__c.NativeFieldInfoPtr___9__23_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<RecipeDataAsset, bool>) null : new Il2CppSystem.Func<RecipeDataAsset, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RecipeDataAsset.__c.NativeFieldInfoPtr___9__23_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<RecipeDataAsset, bool> __9__24_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RecipeDataAsset.__c.NativeFieldInfoPtr___9__24_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<RecipeDataAsset, bool>) null : new Il2CppSystem.Func<RecipeDataAsset, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RecipeDataAsset.__c.NativeFieldInfoPtr___9__24_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
