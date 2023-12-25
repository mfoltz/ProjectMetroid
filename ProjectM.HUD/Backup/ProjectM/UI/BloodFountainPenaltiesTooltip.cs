// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BloodFountainPenaltiesTooltip
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class BloodFountainPenaltiesTooltip : UIEntry
  {
    private static readonly IntPtr NativeFieldInfoPtr_TooltipPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_Name;
    private static readonly IntPtr NativeFieldInfoPtr_FloorPenaltyList;
    private static readonly IntPtr NativeFieldInfoPtr_FountainPenaltyList;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_Floors;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_Fountains;
    private static readonly IntPtr NativeFieldInfoPtr_TextColor_Dark;
    private static readonly IntPtr NativeFieldInfoPtr_TextColor_Normal;
    private static readonly IntPtr NativeFieldInfoPtr_TextColor_Highlighted;
    private static readonly IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly IntPtr NativeFieldInfoPtr__EntityManager;
    private static readonly IntPtr NativeFieldInfoPtr__CanvasRect;
    private static readonly IntPtr NativeMethodInfoPtr_InitializeTooltip_Internal_Void_EntityManager_GameDataSystem_PrefabCollectionSystem_AdditionalTooltipSetting_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetPrivateData_Private_Void_EntityManager_GameDataSystem_PrefabCollectionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetAnchor_Internal_Void_AnchorPreset_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetPivot_Internal_Void_PivotPresets_0;
    private static readonly IntPtr NativeMethodInfoPtr_FindMainParent_Private_RectTransform_GameObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetTooltip_Internal_Boolean_Vector3_List_1_Data_Int32_List_1_Data_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetData_Private_Void_Vector3_List_1_Data_Int32_List_1_Data_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetTooltipPosition_Private_Void_Vector3_0;
    private static readonly IntPtr NativeMethodInfoPtr_DisableTooltip_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223162, XrefRangeEnd = 1223178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitializeTooltip(
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      PrefabCollectionSystem prefabCollectionSystem,
      AdditionalTooltipSetting additionalTooltipSetting)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &entityManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &additionalTooltipSetting;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodFountainPenaltiesTooltip.NativeMethodInfoPtr_InitializeTooltip_Internal_Void_EntityManager_GameDataSystem_PrefabCollectionSystem_AdditionalTooltipSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetPrivateData(
      EntityManager entityManager,
      GameDataSystem gameDataSystem,
      PrefabCollectionSystem prefabCollectionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entityManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabCollectionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodFountainPenaltiesTooltip.NativeMethodInfoPtr_SetPrivateData_Private_Void_EntityManager_GameDataSystem_PrefabCollectionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223178, XrefRangeEnd = 1223180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAnchor(AnchorPreset anchorPreset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &anchorPreset;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodFountainPenaltiesTooltip.NativeMethodInfoPtr_SetAnchor_Internal_Void_AnchorPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 1223182, RefRangeEnd = 1223190, XrefRangeStart = 1223180, XrefRangeEnd = 1223182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetPivot(PivotPresets pivotPresets)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &pivotPresets;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodFountainPenaltiesTooltip.NativeMethodInfoPtr_SetPivot_Internal_Void_PivotPresets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223190, XrefRangeEnd = 1223202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RectTransform FindMainParent(GameObject gameObject)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(BloodFountainPenaltiesTooltip.NativeMethodInfoPtr_FindMainParent_Private_RectTransform_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223202, XrefRangeEnd = 1223203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SetTooltip(
      Vector3 position,
      List<TooltipPenaltyEntry.Data> floorPenalties,
      int floorIndex,
      List<TooltipPenaltyEntry.Data> fountainPenalties,
      int fountainIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &position;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) floorPenalties);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &floorIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fountainPenalties);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &fountainIndex;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(BloodFountainPenaltiesTooltip.NativeMethodInfoPtr_SetTooltip_Internal_Boolean_Vector3_List_1_Data_Int32_List_1_Data_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1223276, RefRangeEnd = 1223277, XrefRangeStart = 1223203, XrefRangeEnd = 1223276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(
      Vector3 position,
      List<TooltipPenaltyEntry.Data> floorPenalties,
      int floorIndex,
      List<TooltipPenaltyEntry.Data> fountainPenalties,
      int fountainIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &position;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) floorPenalties);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &floorIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fountainPenalties);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &fountainIndex;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodFountainPenaltiesTooltip.NativeMethodInfoPtr_SetData_Private_Void_Vector3_List_1_Data_Int32_List_1_Data_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223277, XrefRangeEnd = 1223305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetTooltipPosition(Vector3 position)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &position;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodFountainPenaltiesTooltip.NativeMethodInfoPtr_SetTooltipPosition_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(29)]
    [CachedScanResults(RefRangeStart = 1222138, RefRangeEnd = 1222167, XrefRangeStart = 1222138, XrefRangeEnd = 1222167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableTooltip()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodFountainPenaltiesTooltip.NativeMethodInfoPtr_DisableTooltip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BloodFountainPenaltiesTooltip()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodFountainPenaltiesTooltip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BloodFountainPenaltiesTooltip()
    {
      Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BloodFountainPenaltiesTooltip));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr);
      BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_TooltipPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr, nameof (TooltipPrefab));
      BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr, nameof (Name));
      BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_FloorPenaltyList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr, nameof (FloorPenaltyList));
      BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_FountainPenaltyList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr, nameof (FountainPenaltyList));
      BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_LKey_Floors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr, nameof (LKey_Floors));
      BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_LKey_Fountains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr, nameof (LKey_Fountains));
      BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_TextColor_Dark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr, nameof (TextColor_Dark));
      BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_TextColor_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr, nameof (TextColor_Normal));
      BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_TextColor_Highlighted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr, nameof (TextColor_Highlighted));
      BloodFountainPenaltiesTooltip.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr, nameof (_GameDataSystem));
      BloodFountainPenaltiesTooltip.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      BloodFountainPenaltiesTooltip.NativeFieldInfoPtr__EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr, nameof (_EntityManager));
      BloodFountainPenaltiesTooltip.NativeFieldInfoPtr__CanvasRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr, nameof (_CanvasRect));
      BloodFountainPenaltiesTooltip.NativeMethodInfoPtr_InitializeTooltip_Internal_Void_EntityManager_GameDataSystem_PrefabCollectionSystem_AdditionalTooltipSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr, 100664782);
      BloodFountainPenaltiesTooltip.NativeMethodInfoPtr_SetPrivateData_Private_Void_EntityManager_GameDataSystem_PrefabCollectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr, 100664783);
      BloodFountainPenaltiesTooltip.NativeMethodInfoPtr_SetAnchor_Internal_Void_AnchorPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr, 100664784);
      BloodFountainPenaltiesTooltip.NativeMethodInfoPtr_SetPivot_Internal_Void_PivotPresets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr, 100664785);
      BloodFountainPenaltiesTooltip.NativeMethodInfoPtr_FindMainParent_Private_RectTransform_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr, 100664786);
      BloodFountainPenaltiesTooltip.NativeMethodInfoPtr_SetTooltip_Internal_Boolean_Vector3_List_1_Data_Int32_List_1_Data_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr, 100664787);
      BloodFountainPenaltiesTooltip.NativeMethodInfoPtr_SetData_Private_Void_Vector3_List_1_Data_Int32_List_1_Data_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr, 100664788);
      BloodFountainPenaltiesTooltip.NativeMethodInfoPtr_SetTooltipPosition_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr, 100664789);
      BloodFountainPenaltiesTooltip.NativeMethodInfoPtr_DisableTooltip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr, 100664790);
      BloodFountainPenaltiesTooltip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodFountainPenaltiesTooltip>.NativeClassPtr, 100664791);
    }

    public BloodFountainPenaltiesTooltip(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BloodFountainPenaltiesTooltip TooltipPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_TooltipPrefab));
        return pointer == IntPtr.Zero ? (BloodFountainPenaltiesTooltip) null : new BloodFountainPenaltiesTooltip(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_TooltipPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Name
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_Name));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_Name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<TooltipPenaltyEntry> FloorPenaltyList
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_FloorPenaltyList));
        return pointer == IntPtr.Zero ? (List<TooltipPenaltyEntry>) null : new List<TooltipPenaltyEntry>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_FloorPenaltyList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<TooltipPenaltyEntry> FountainPenaltyList
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_FountainPenaltyList));
        return pointer == IntPtr.Zero ? (List<TooltipPenaltyEntry>) null : new List<TooltipPenaltyEntry>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_FountainPenaltyList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_Floors
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_LKey_Floors));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_LKey_Floors)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Fountains
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_LKey_Fountains));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_LKey_Fountains)) = value;
      }
    }

    public unsafe Color TextColor_Dark
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_TextColor_Dark));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_TextColor_Dark)) = value;
      }
    }

    public unsafe Color TextColor_Normal
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_TextColor_Normal));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_TextColor_Normal)) = value;
      }
    }

    public unsafe Color TextColor_Highlighted
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_TextColor_Highlighted));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr_TextColor_Highlighted)) = value;
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr__GameDataSystem));
        return pointer == IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityManager _EntityManager
    {
      get
      {
        return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr__EntityManager));
      }
      [param: In] set
      {
        *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr__EntityManager)) = value;
      }
    }

    public unsafe RectTransform _CanvasRect
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr__CanvasRect));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodFountainPenaltiesTooltip.NativeFieldInfoPtr__CanvasRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
