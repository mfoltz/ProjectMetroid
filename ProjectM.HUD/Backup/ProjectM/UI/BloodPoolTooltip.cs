// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BloodPoolTooltip
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class BloodPoolTooltip : UIEntry
  {
    private static readonly IntPtr NativeFieldInfoPtr_BloodBuffsThresholds;
    private static readonly IntPtr NativeFieldInfoPtr_Label_BloodPool;
    private static readonly IntPtr NativeFieldInfoPtr_Label_BloodQuality;
    private static readonly IntPtr NativeFieldInfoPtr_Label_BloodType;
    private static readonly IntPtr NativeFieldInfoPtr_Image_BloodType;
    private static readonly IntPtr NativeFieldInfoPtr_Image_BloodQualitySlider;
    private static readonly IntPtr NativeFieldInfoPtr_TierList;
    private static readonly IntPtr NativeFieldInfoPtr_BloodTypeBonusList;
    private static readonly IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly IntPtr NativeFieldInfoPtr__EntityManager;
    private static readonly IntPtr NativeFieldInfoPtr__CanvasRect;
    private static readonly IntPtr NativeFieldInfoPtr_BloodQualityAnimationSpeed;
    private static readonly IntPtr NativeFieldInfoPtr__BloodQuality;
    private static readonly IntPtr NativeMethodInfoPtr_InitializeTooltip_Internal_Void_EntityManager_GameDataSystem_PrefabCollectionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetAnchor_Internal_Void_AnchorPreset_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetPivot_Internal_Void_PivotPresets_0;
    private static readonly IntPtr NativeMethodInfoPtr_FindMainParent_Private_RectTransform_GameObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetTooltip_Public_Boolean_Vector3_BloodBuffInfo_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetTierText_Private_String_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetTooltipPosition_Private_Void_Vector3_0;
    private static readonly IntPtr NativeMethodInfoPtr_DisableTooltip_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223305, XrefRangeEnd = 1223325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitializeTooltip(
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
      IL2CPP.il2cpp_runtime_invoke(BloodPoolTooltip.NativeMethodInfoPtr_InitializeTooltip_Internal_Void_EntityManager_GameDataSystem_PrefabCollectionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodPoolTooltip.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAnchor(AnchorPreset anchorPreset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &anchorPreset;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodPoolTooltip.NativeMethodInfoPtr_SetAnchor_Internal_Void_AnchorPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 1223182, RefRangeEnd = 1223190, XrefRangeStart = 1223182, XrefRangeEnd = 1223190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetPivot(PivotPresets pivotPresets)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &pivotPresets;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodPoolTooltip.NativeMethodInfoPtr_SetPivot_Internal_Void_PivotPresets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223325, XrefRangeEnd = 1223337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RectTransform FindMainParent(GameObject gameObject)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(BloodPoolTooltip.NativeMethodInfoPtr_FindMainParent_Private_RectTransform_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1223432, RefRangeEnd = 1223433, XrefRangeStart = 1223337, XrefRangeEnd = 1223432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SetTooltip(Vector3 position, BloodBuffInfo bloodBuffInfo)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &position;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) bloodBuffInfo));
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(BloodPoolTooltip.NativeMethodInfoPtr_SetTooltip_Public_Boolean_Vector3_BloodBuffInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1223440, RefRangeEnd = 1223441, XrefRangeStart = 1223433, XrefRangeEnd = 1223440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetTierText(int tier)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &tier;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(BloodPoolTooltip.NativeMethodInfoPtr_GetTierText_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223441, XrefRangeEnd = 1223453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetTooltipPosition(Vector3 position)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &position;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodPoolTooltip.NativeMethodInfoPtr_SetTooltipPosition_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(29)]
    [CachedScanResults(RefRangeStart = 1222138, RefRangeEnd = 1222167, XrefRangeStart = 1222138, XrefRangeEnd = 1222167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableTooltip()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodPoolTooltip.NativeMethodInfoPtr_DisableTooltip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223453, XrefRangeEnd = 1223461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BloodPoolTooltip()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodPoolTooltip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BloodPoolTooltip()
    {
      Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BloodPoolTooltip));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr);
      BloodPoolTooltip.NativeFieldInfoPtr_BloodBuffsThresholds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, nameof (BloodBuffsThresholds));
      BloodPoolTooltip.NativeFieldInfoPtr_Label_BloodPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, nameof (Label_BloodPool));
      BloodPoolTooltip.NativeFieldInfoPtr_Label_BloodQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, nameof (Label_BloodQuality));
      BloodPoolTooltip.NativeFieldInfoPtr_Label_BloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, nameof (Label_BloodType));
      BloodPoolTooltip.NativeFieldInfoPtr_Image_BloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, nameof (Image_BloodType));
      BloodPoolTooltip.NativeFieldInfoPtr_Image_BloodQualitySlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, nameof (Image_BloodQualitySlider));
      BloodPoolTooltip.NativeFieldInfoPtr_TierList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, nameof (TierList));
      BloodPoolTooltip.NativeFieldInfoPtr_BloodTypeBonusList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, nameof (BloodTypeBonusList));
      BloodPoolTooltip.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, nameof (_GameDataSystem));
      BloodPoolTooltip.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      BloodPoolTooltip.NativeFieldInfoPtr__EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, nameof (_EntityManager));
      BloodPoolTooltip.NativeFieldInfoPtr__CanvasRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, nameof (_CanvasRect));
      BloodPoolTooltip.NativeFieldInfoPtr_BloodQualityAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, nameof (BloodQualityAnimationSpeed));
      BloodPoolTooltip.NativeFieldInfoPtr__BloodQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, nameof (_BloodQuality));
      BloodPoolTooltip.NativeMethodInfoPtr_InitializeTooltip_Internal_Void_EntityManager_GameDataSystem_PrefabCollectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, 100664792);
      BloodPoolTooltip.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, 100664793);
      BloodPoolTooltip.NativeMethodInfoPtr_SetAnchor_Internal_Void_AnchorPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, 100664794);
      BloodPoolTooltip.NativeMethodInfoPtr_SetPivot_Internal_Void_PivotPresets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, 100664795);
      BloodPoolTooltip.NativeMethodInfoPtr_FindMainParent_Private_RectTransform_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, 100664796);
      BloodPoolTooltip.NativeMethodInfoPtr_SetTooltip_Public_Boolean_Vector3_BloodBuffInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, 100664797);
      BloodPoolTooltip.NativeMethodInfoPtr_GetTierText_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, 100664798);
      BloodPoolTooltip.NativeMethodInfoPtr_SetTooltipPosition_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, 100664799);
      BloodPoolTooltip.NativeMethodInfoPtr_DisableTooltip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, 100664800);
      BloodPoolTooltip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodPoolTooltip>.NativeClassPtr, 100664801);
    }

    public BloodPoolTooltip(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppStructArray<float> BloodBuffsThresholds
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr_BloodBuffsThresholds));
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<float>) null : new Il2CppStructArray<float>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr_BloodBuffsThresholds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Label_BloodPool
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr_Label_BloodPool));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr_Label_BloodPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Label_BloodQuality
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr_Label_BloodQuality));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr_Label_BloodQuality), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Label_BloodType
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr_Label_BloodType));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr_Label_BloodType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Image_BloodType
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr_Image_BloodType));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr_Image_BloodType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Image_BloodQualitySlider
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr_Image_BloodQualitySlider));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr_Image_BloodQualitySlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<LocalizedText> TierList
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr_TierList));
        return pointer == IntPtr.Zero ? (List<LocalizedText>) null : new List<LocalizedText>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr_TierList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<BloodTypeBonus> BloodTypeBonusList
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr_BloodTypeBonusList));
        return pointer == IntPtr.Zero ? (List<BloodTypeBonus>) null : new List<BloodTypeBonus>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr_BloodTypeBonusList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr__GameDataSystem));
        return pointer == IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityManager _EntityManager
    {
      get
      {
        return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr__EntityManager));
      }
      [param: In] set
      {
        *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr__EntityManager)) = value;
      }
    }

    public unsafe RectTransform _CanvasRect
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr__CanvasRect));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr__CanvasRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float BloodQualityAnimationSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr_BloodQualityAnimationSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr_BloodQualityAnimationSpeed)) = value;
      }
    }

    public unsafe float _BloodQuality
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr__BloodQuality));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodPoolTooltip.NativeFieldInfoPtr__BloodQuality)) = value;
      }
    }
  }
}
