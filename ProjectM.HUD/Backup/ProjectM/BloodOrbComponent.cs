// Decompiled with JetBrains decompiler
// Type: ProjectM.BloodOrbComponent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.UI;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM
{
  public class BloodOrbComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Tooltip;
    private static readonly IntPtr NativeFieldInfoPtr_BloodFillImage;
    private static readonly IntPtr NativeFieldInfoPtr_BloodFillAnimation;
    private static readonly IntPtr NativeFieldInfoPtr_BloodQualityMaterials;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_BloodHeader;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_BloodValue;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_BloodDesc;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_BloodWarning;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_VBlood;
    private static readonly IntPtr NativeFieldInfoPtr_BloodQualityParent;
    private static readonly IntPtr NativeFieldInfoPtr_BloodOrbChangeSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_BloodQuality;
    private static readonly IntPtr NativeFieldInfoPtr_IsHovered;
    private static readonly IntPtr NativeFieldInfoPtr__Rect;
    private static readonly IntPtr NativeMethodInfoPtr_get_Rect_Public_get_RectTransform_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetBloodQualityMaterial_Internal_Material_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe RectTransform Rect
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209183, XrefRangeEnd = 1209191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(BloodOrbComponent.NativeMethodInfoPtr_get_Rect_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
    }

    [CallerCount(0)]
    public unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodOrbComponent.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void OnPointerEnter()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodOrbComponent.NativeMethodInfoPtr_OnPointerEnter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void OnPointerExit()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodOrbComponent.NativeMethodInfoPtr_OnPointerExit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209191, XrefRangeEnd = 1209204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodOrbComponent.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209204, XrefRangeEnd = 1209209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Material GetBloodQualityMaterial(float bloodQuality)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &bloodQuality;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(BloodOrbComponent.NativeMethodInfoPtr_GetBloodQualityMaterial_Internal_Material_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (Material) null : new Material(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209209, XrefRangeEnd = 1209210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BloodOrbComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BloodOrbComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BloodOrbComponent()
    {
      Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM", nameof (BloodOrbComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr);
      BloodOrbComponent.NativeFieldInfoPtr_Tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr, nameof (Tooltip));
      BloodOrbComponent.NativeFieldInfoPtr_BloodFillImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr, nameof (BloodFillImage));
      BloodOrbComponent.NativeFieldInfoPtr_BloodFillAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr, nameof (BloodFillAnimation));
      BloodOrbComponent.NativeFieldInfoPtr_BloodQualityMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr, nameof (BloodQualityMaterials));
      BloodOrbComponent.NativeFieldInfoPtr_LKey_BloodHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr, nameof (LKey_BloodHeader));
      BloodOrbComponent.NativeFieldInfoPtr_LKey_BloodValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr, nameof (LKey_BloodValue));
      BloodOrbComponent.NativeFieldInfoPtr_LKey_BloodDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr, nameof (LKey_BloodDesc));
      BloodOrbComponent.NativeFieldInfoPtr_LKey_BloodWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr, nameof (LKey_BloodWarning));
      BloodOrbComponent.NativeFieldInfoPtr_LKey_VBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr, nameof (LKey_VBlood));
      BloodOrbComponent.NativeFieldInfoPtr_BloodQualityParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr, nameof (BloodQualityParent));
      BloodOrbComponent.NativeFieldInfoPtr_BloodOrbChangeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr, nameof (BloodOrbChangeSpeed));
      BloodOrbComponent.NativeFieldInfoPtr_BloodQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr, nameof (BloodQuality));
      BloodOrbComponent.NativeFieldInfoPtr_IsHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr, nameof (IsHovered));
      BloodOrbComponent.NativeFieldInfoPtr__Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr, nameof (_Rect));
      BloodOrbComponent.NativeMethodInfoPtr_get_Rect_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr, 100663596);
      BloodOrbComponent.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr, 100663597);
      BloodOrbComponent.NativeMethodInfoPtr_OnPointerEnter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr, 100663598);
      BloodOrbComponent.NativeMethodInfoPtr_OnPointerExit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr, 100663599);
      BloodOrbComponent.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr, 100663600);
      BloodOrbComponent.NativeMethodInfoPtr_GetBloodQualityMaterial_Internal_Material_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr, 100663601);
      BloodOrbComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodOrbComponent>.NativeClassPtr, 100663602);
    }

    public BloodOrbComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BloodPoolTooltip Tooltip
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_Tooltip));
        return pointer == IntPtr.Zero ? (BloodPoolTooltip) null : new BloodPoolTooltip(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_Tooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image BloodFillImage
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_BloodFillImage));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_BloodFillImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image BloodFillAnimation
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_BloodFillAnimation));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_BloodFillAnimation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<BloodQualityMaterial> BloodQualityMaterials
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_BloodQualityMaterials));
        return pointer == IntPtr.Zero ? (List<BloodQualityMaterial>) null : new List<BloodQualityMaterial>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_BloodQualityMaterials), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_BloodHeader
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_LKey_BloodHeader));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_LKey_BloodHeader)) = value;
      }
    }

    public unsafe LocalizationKey LKey_BloodValue
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_LKey_BloodValue));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_LKey_BloodValue)) = value;
      }
    }

    public unsafe LocalizationKey LKey_BloodDesc
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_LKey_BloodDesc));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_LKey_BloodDesc)) = value;
      }
    }

    public unsafe LocalizationKey LKey_BloodWarning
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_LKey_BloodWarning));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_LKey_BloodWarning)) = value;
      }
    }

    public unsafe LocalizationKey LKey_VBlood
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_LKey_VBlood));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_LKey_VBlood)) = value;
      }
    }

    public BloodQualityParent BloodQualityParent
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_BloodQualityParent);
        return new BloodQualityParent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloodQualityParent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_BloodQualityParent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BloodQualityParent>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe float BloodOrbChangeSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_BloodOrbChangeSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_BloodOrbChangeSpeed)) = value;
      }
    }

    public unsafe float BloodQuality
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_BloodQuality));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_BloodQuality)) = value;
      }
    }

    public unsafe bool IsHovered
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_IsHovered));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr_IsHovered)) = value;
      }
    }

    public unsafe RectTransform _Rect
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr__Rect));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloodOrbComponent.NativeFieldInfoPtr__Rect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
