// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.OptionsPanel_Graphics
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace ProjectM.UI
{
  public class OptionsPanel_Graphics : StunGUIBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ContentNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_CheckboxPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_SliderPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_DropdownPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_CategoryHeaderPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Advanced;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_General;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_GraphicsPreset;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Brightness;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Display;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Resolution;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_WindowMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Quality;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_AmbientOcclusionQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_BloomQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ShadowQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_VolumetricFogQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_VerticalSync;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ShouldLimitFPS;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_LimitFPSSliderLabel;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_MotionBlur;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_DepthOfField;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_HighQualityVegetation;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_HighQualityAtmosphere;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_TextureStreaming;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_TextureMipStreaming;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_DynamicResolution;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ScreenShake;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_AntiAliasingMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_FSRQualityMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ClothQualityMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ClothUpdateRate;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_MenuCapFPSMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ValuePercent;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_BloodEffectsEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__Settings;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalizedQualities;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalizedWindowModes;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalizedGraphicsPresets;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalizedCapFPSMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalizedClothSpeeds;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalizedFSRQualityModes;
    private static readonly System.IntPtr NativeFieldInfoPtr_RedrawableEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr__FSR;
    private static readonly System.IntPtr NativeFieldInfoPtr_NeedsRefresh;
    private static readonly System.IntPtr NativeFieldInfoPtr_NeedsHybridModelRefresh;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InvertBrightness_Private_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemapBrightnessTo01_Private_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Mul100_Private_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetVerticalSync_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddHeader_Private_Void_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddToggle_Private_Void_LocalizationKey_Func_1_Boolean_UnityAction_1_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSlider_Private_Options_Control_Slider_LocalizationKey_LocalizationKey_Single_Single_Func_1_Single_UnityAction_1_Single_Func_2_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSlider_Private_Options_Control_Slider_LocalizationKey_LocalizationKey_Single_Single_Single_UnityAction_1_Single_Func_2_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddQualityDropdown_Private_Void_LocalizationKey_UnityAction_1_QualitySetting_Func_1_QualitySetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddAntiAliasingDropdown_Private_Void_LocalizationKey_Func_1_AntiAliasingMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddFSRQualityDropdown_Private_Options_Control_Dropdown_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeFSR_Private_Void_Options_Control_Dropdown_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddGraphicsPresetDropdown_Private_Void_LocalizationKey_UnityAction_1_PresetMode_Func_1_PresetMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ChangeGraphicsPreset_Private_Void_PresetMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckForGraphicsPresetChanges_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddMenuFPSCapDropdown_Private_Void_LocalizationKey_UnityAction_1_LimitFPSMode_Func_1_LimitFPSMode_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddClothUpdateDropdown_Private_Void_LocalizationKey_UnityAction_1_ClothUpdateSpeed_Func_1_ClothUpdateSpeed_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FullScreenModeDropdown_Private_Void_LocalizationKey_UnityAction_1_FullScreenMode_Func_1_FullScreenMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddResolutionsDropdown_Private_Void_LocalizationKey_UnityAction_1_int2_Func_1_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RedrawEntries_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnAntiAliasingModeChange_Private_Void_AntiAliasingMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_0_Private_PresetMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_1_Private_Void_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_2_Private_int2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_3_Private_Void_FullScreenMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_5_Private_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_6_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_7_Private_Void_QualitySetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_8_Private_QualitySetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_9_Private_Void_QualitySetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_10_Private_QualitySetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_11_Private_Void_QualitySetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_12_Private_QualitySetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_13_Private_Void_QualitySetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_14_Private_QualitySetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_15_Private_Void_QualitySetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_16_Private_QualitySetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_17_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_18_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_19_Private_AntiAliasingMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_20_Private_Void_LimitFPSMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_21_Private_LimitFPSMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_22_Private_Void_LimitFPSMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_23_Private_LimitFPSMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_40_Private_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_41_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_24_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_25_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_26_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_27_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_28_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_29_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_30_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_31_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_32_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_33_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_34_Private_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_35_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_36_Private_Void_QualitySetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_37_Private_QualitySetting_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_38_Private_Void_ClothUpdateSpeed_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_39_Private_ClothUpdateSpeed_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1162058, RefRangeEnd = 1162059, XrefRangeStart = 1161671, XrefRangeEnd = 1162058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe float InvertBrightness(float brightness)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &brightness;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_InvertBrightness_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162059, XrefRangeEnd = 1162063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float RemapBrightnessTo01(float brightness)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &brightness;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_RemapBrightnessTo01_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe float Mul100(float volume)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &volume;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_Mul100_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162063, XrefRangeEnd = 1162069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162069, XrefRangeEnd = 1162070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetVerticalSync(bool newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_SetVerticalSync_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1162078, RefRangeEnd = 1162082, XrefRangeStart = 1162070, XrefRangeEnd = 1162078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddHeader(LocalizationKey textKey)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &textKey;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_AddHeader_Private_Void_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162082, XrefRangeEnd = 1162087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddToggle(
      LocalizationKey textKey,
      Il2CppSystem.Func<bool> initValueFunc,
      UnityAction<bool> onValueChange)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) initValueFunc);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_AddToggle_Private_Void_LocalizationKey_Func_1_Boolean_UnityAction_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1162097, RefRangeEnd = 1162100, XrefRangeStart = 1162087, XrefRangeEnd = 1162097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Options_Control_Slider AddSlider(
      LocalizationKey textKey,
      LocalizationKey valueKey,
      float minValue,
      float maxValue,
      Il2CppSystem.Func<float> initValueFunc,
      UnityAction<float> onValueChange,
      Il2CppSystem.Func<float, float> displayValueTransformer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &valueKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &minValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &maxValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) initValueFunc);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayValueTransformer);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_AddSlider_Private_Options_Control_Slider_LocalizationKey_LocalizationKey_Single_Single_Func_1_Single_UnityAction_1_Single_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Options_Control_Slider) null : new Options_Control_Slider(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162100, XrefRangeEnd = 1162107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Options_Control_Slider AddSlider(
      LocalizationKey textKey,
      LocalizationKey valueKey,
      float minValue,
      float maxValue,
      float initValue,
      UnityAction<float> onValueChange,
      Il2CppSystem.Func<float, float> displayValueTransformer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &valueKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &minValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &maxValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &initValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayValueTransformer);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_AddSlider_Private_Options_Control_Slider_LocalizationKey_LocalizationKey_Single_Single_Single_UnityAction_1_Single_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Options_Control_Slider) null : new Options_Control_Slider(pointer);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1162180, RefRangeEnd = 1162186, XrefRangeStart = 1162107, XrefRangeEnd = 1162180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddQualityDropdown(
      LocalizationKey textKey,
      UnityAction<QualitySetting> onValueChange,
      Il2CppSystem.Func<QualitySetting> getQualitySetting)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getQualitySetting);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_AddQualityDropdown_Private_Void_LocalizationKey_UnityAction_1_QualitySetting_Func_1_QualitySetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1162243, RefRangeEnd = 1162244, XrefRangeStart = 1162186, XrefRangeEnd = 1162243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddAntiAliasingDropdown(
      LocalizationKey textKey,
      Il2CppSystem.Func<AntiAliasingMode> getQualitySetting)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getQualitySetting);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_AddAntiAliasingDropdown_Private_Void_LocalizationKey_Func_1_AntiAliasingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1162322, RefRangeEnd = 1162323, XrefRangeStart = 1162244, XrefRangeEnd = 1162322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Options_Control_Dropdown AddFSRQualityDropdown(LocalizationKey textKey)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &textKey;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_AddFSRQualityDropdown_Private_Options_Control_Dropdown_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Options_Control_Dropdown) null : new Options_Control_Dropdown(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1162327, RefRangeEnd = 1162328, XrefRangeStart = 1162323, XrefRangeEnd = 1162327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitializeFSR(Options_Control_Dropdown entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_InitializeFSR_Private_Void_Options_Control_Dropdown_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1162403, RefRangeEnd = 1162404, XrefRangeStart = 1162328, XrefRangeEnd = 1162403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddGraphicsPresetDropdown(
      LocalizationKey textKey,
      UnityAction<PresetMode> onValueChange,
      Il2CppSystem.Func<PresetMode> getPresetSetting)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getPresetSetting);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_AddGraphicsPresetDropdown_Private_Void_LocalizationKey_UnityAction_1_PresetMode_Func_1_PresetMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162404, XrefRangeEnd = 1162416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ChangeGraphicsPreset(PresetMode newMode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newMode;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_ChangeGraphicsPreset_Private_Void_PresetMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 1162437, RefRangeEnd = 1162452, XrefRangeStart = 1162416, XrefRangeEnd = 1162437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckForGraphicsPresetChanges()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_CheckForGraphicsPresetChanges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1162530, RefRangeEnd = 1162532, XrefRangeStart = 1162452, XrefRangeEnd = 1162530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddMenuFPSCapDropdown(
      LocalizationKey textKey,
      UnityAction<LimitFPSMode> onValueChange,
      Il2CppSystem.Func<LimitFPSMode> getQualitySetting,
      bool forInGameSetting)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getQualitySetting);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &forInGameSetting;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_AddMenuFPSCapDropdown_Private_Void_LocalizationKey_UnityAction_1_LimitFPSMode_Func_1_LimitFPSMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1162607, RefRangeEnd = 1162608, XrefRangeStart = 1162532, XrefRangeEnd = 1162607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddClothUpdateDropdown(
      LocalizationKey textKey,
      UnityAction<ClothUpdateSpeed> onValueChange,
      Il2CppSystem.Func<ClothUpdateSpeed> getQualitySetting)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getQualitySetting);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_AddClothUpdateDropdown_Private_Void_LocalizationKey_UnityAction_1_ClothUpdateSpeed_Func_1_ClothUpdateSpeed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1162681, RefRangeEnd = 1162682, XrefRangeStart = 1162608, XrefRangeEnd = 1162681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FullScreenModeDropdown(
      LocalizationKey textKey,
      UnityAction<FullScreenMode> onValueChange,
      Il2CppSystem.Func<FullScreenMode> getQualitySetting)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getQualitySetting);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_FullScreenModeDropdown_Private_Void_LocalizationKey_UnityAction_1_FullScreenMode_Func_1_FullScreenMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1162768, RefRangeEnd = 1162769, XrefRangeStart = 1162682, XrefRangeEnd = 1162768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddResolutionsDropdown(
      LocalizationKey textKey,
      UnityAction<int2> onValueChange,
      Il2CppSystem.Func<int2> getQualitySetting)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getQualitySetting);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_AddResolutionsDropdown_Private_Void_LocalizationKey_UnityAction_1_int2_Func_1_int2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1162792, RefRangeEnd = 1162793, XrefRangeStart = 1162769, XrefRangeEnd = 1162792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RedrawEntries()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_RedrawEntries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1162810, RefRangeEnd = 1162813, XrefRangeStart = 1162793, XrefRangeEnd = 1162810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnAntiAliasingModeChange(AntiAliasingMode mode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &mode;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr_OnAntiAliasingModeChange_Private_Void_AntiAliasingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162813, XrefRangeEnd = 1162863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OptionsPanel_Graphics()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe PresetMode _Start_b__54_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_0_Private_PresetMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PresetMode*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162863, XrefRangeEnd = 1162866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__54_1(int2 newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_1_Private_Void_int2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe int2 _Start_b__54_2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_2_Private_int2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162866, XrefRangeEnd = 1162869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__54_3(FullScreenMode newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_3_Private_Void_FullScreenMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe float _Start_b__54_5()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_5_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162869, XrefRangeEnd = 1162871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__54_6(float newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_6_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162871, XrefRangeEnd = 1162873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__54_7(QualitySetting newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_7_Private_Void_QualitySetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe QualitySetting _Start_b__54_8()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_8_Private_QualitySetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(QualitySetting*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162873, XrefRangeEnd = 1162875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__54_9(QualitySetting newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_9_Private_Void_QualitySetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe QualitySetting _Start_b__54_10()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_10_Private_QualitySetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(QualitySetting*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162875, XrefRangeEnd = 1162877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__54_11(QualitySetting newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_11_Private_Void_QualitySetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe QualitySetting _Start_b__54_12()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_12_Private_QualitySetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(QualitySetting*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162877, XrefRangeEnd = 1162879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__54_13(QualitySetting newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_13_Private_Void_QualitySetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe QualitySetting _Start_b__54_14()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_14_Private_QualitySetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(QualitySetting*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162879, XrefRangeEnd = 1162881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__54_15(QualitySetting newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_15_Private_Void_QualitySetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe QualitySetting _Start_b__54_16()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_16_Private_QualitySetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(QualitySetting*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__54_17()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_17_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__54_18(bool newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_18_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe AntiAliasingMode _Start_b__54_19()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_19_Private_AntiAliasingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AntiAliasingMode*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__54_20(LimitFPSMode newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_20_Private_Void_LimitFPSMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe LimitFPSMode _Start_b__54_21()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_21_Private_LimitFPSMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(LimitFPSMode*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__54_22(LimitFPSMode newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_22_Private_Void_LimitFPSMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe LimitFPSMode _Start_b__54_23()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_23_Private_LimitFPSMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(LimitFPSMode*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe float _Start_b__54_40()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_40_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__54_41(float newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_41_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__54_24()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_24_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__54_25(bool newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_25_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__54_26()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_26_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__54_27(bool newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_27_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__54_28()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_28_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162881, XrefRangeEnd = 1162883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__54_29(bool newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_29_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__54_30()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_30_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162883, XrefRangeEnd = 1162885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__54_31(bool newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_31_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__54_32()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_32_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__54_33(bool newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_33_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe float _Start_b__54_34()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_34_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__54_35(float newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_35_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162885, XrefRangeEnd = 1162886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__54_36(QualitySetting newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_36_Private_Void_QualitySetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe QualitySetting _Start_b__54_37()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_37_Private_QualitySetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(QualitySetting*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162886, XrefRangeEnd = 1162888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__54_38(ClothUpdateSpeed newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_38_Private_Void_ClothUpdateSpeed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe ClothUpdateSpeed _Start_b__54_39()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_39_Private_ClothUpdateSpeed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ClothUpdateSpeed*) IL2CPP.il2cpp_object_unbox(num);
    }

    static OptionsPanel_Graphics()
    {
      Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (OptionsPanel_Graphics));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr);
      OptionsPanel_Graphics.NativeFieldInfoPtr_ContentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (ContentNode));
      OptionsPanel_Graphics.NativeFieldInfoPtr_CheckboxPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (CheckboxPrefab));
      OptionsPanel_Graphics.NativeFieldInfoPtr_SliderPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (SliderPrefab));
      OptionsPanel_Graphics.NativeFieldInfoPtr_DropdownPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (DropdownPrefab));
      OptionsPanel_Graphics.NativeFieldInfoPtr_CategoryHeaderPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (CategoryHeaderPrefab));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_Advanced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_Advanced));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_General = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_General));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_GraphicsPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_GraphicsPreset));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_Brightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_Brightness));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_Display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_Display));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_Resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_Resolution));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_WindowMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_WindowMode));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_Quality));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_AmbientOcclusionQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_AmbientOcclusionQuality));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_BloomQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_BloomQuality));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_ShadowQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_ShadowQuality));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_VolumetricFogQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_VolumetricFogQuality));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_VerticalSync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_VerticalSync));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_ShouldLimitFPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_ShouldLimitFPS));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_LimitFPSSliderLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_LimitFPSSliderLabel));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_MotionBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_MotionBlur));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_DepthOfField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_DepthOfField));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_HighQualityVegetation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_HighQualityVegetation));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_HighQualityAtmosphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_HighQualityAtmosphere));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_TextureStreaming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_TextureStreaming));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_TextureMipStreaming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_TextureMipStreaming));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_DynamicResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_DynamicResolution));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_ScreenShake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_ScreenShake));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_AntiAliasingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_AntiAliasingMode));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_FSRQualityMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_FSRQualityMode));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_ClothQualityMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_ClothQualityMode));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_ClothUpdateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_ClothUpdateRate));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_MenuCapFPSMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_MenuCapFPSMode));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_Value));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_ValuePercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_ValuePercent));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LK_BloodEffectsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LK_BloodEffectsEnabled));
      OptionsPanel_Graphics.NativeFieldInfoPtr__ClientSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (_ClientSettings));
      OptionsPanel_Graphics.NativeFieldInfoPtr__Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (_Settings));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LocalizedQualities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LocalizedQualities));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LocalizedWindowModes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LocalizedWindowModes));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LocalizedGraphicsPresets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LocalizedGraphicsPresets));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LocalizedCapFPSMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LocalizedCapFPSMode));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LocalizedClothSpeeds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LocalizedClothSpeeds));
      OptionsPanel_Graphics.NativeFieldInfoPtr_LocalizedFSRQualityModes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LocalizedFSRQualityModes));
      OptionsPanel_Graphics.NativeFieldInfoPtr_RedrawableEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (RedrawableEntries));
      OptionsPanel_Graphics.NativeFieldInfoPtr__FSR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (_FSR));
      OptionsPanel_Graphics.NativeFieldInfoPtr_NeedsRefresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (NeedsRefresh));
      OptionsPanel_Graphics.NativeFieldInfoPtr_NeedsHybridModelRefresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (NeedsHybridModelRefresh));
      OptionsPanel_Graphics.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692390);
      OptionsPanel_Graphics.NativeMethodInfoPtr_InvertBrightness_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692391);
      OptionsPanel_Graphics.NativeMethodInfoPtr_RemapBrightnessTo01_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692392);
      OptionsPanel_Graphics.NativeMethodInfoPtr_Mul100_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692393);
      OptionsPanel_Graphics.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692394);
      OptionsPanel_Graphics.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692395);
      OptionsPanel_Graphics.NativeMethodInfoPtr_SetVerticalSync_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692396);
      OptionsPanel_Graphics.NativeMethodInfoPtr_AddHeader_Private_Void_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692397);
      OptionsPanel_Graphics.NativeMethodInfoPtr_AddToggle_Private_Void_LocalizationKey_Func_1_Boolean_UnityAction_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692398);
      OptionsPanel_Graphics.NativeMethodInfoPtr_AddSlider_Private_Options_Control_Slider_LocalizationKey_LocalizationKey_Single_Single_Func_1_Single_UnityAction_1_Single_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692399);
      OptionsPanel_Graphics.NativeMethodInfoPtr_AddSlider_Private_Options_Control_Slider_LocalizationKey_LocalizationKey_Single_Single_Single_UnityAction_1_Single_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692400);
      OptionsPanel_Graphics.NativeMethodInfoPtr_AddQualityDropdown_Private_Void_LocalizationKey_UnityAction_1_QualitySetting_Func_1_QualitySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692401);
      OptionsPanel_Graphics.NativeMethodInfoPtr_AddAntiAliasingDropdown_Private_Void_LocalizationKey_Func_1_AntiAliasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692402);
      OptionsPanel_Graphics.NativeMethodInfoPtr_AddFSRQualityDropdown_Private_Options_Control_Dropdown_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692403);
      OptionsPanel_Graphics.NativeMethodInfoPtr_InitializeFSR_Private_Void_Options_Control_Dropdown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692404);
      OptionsPanel_Graphics.NativeMethodInfoPtr_AddGraphicsPresetDropdown_Private_Void_LocalizationKey_UnityAction_1_PresetMode_Func_1_PresetMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692405);
      OptionsPanel_Graphics.NativeMethodInfoPtr_ChangeGraphicsPreset_Private_Void_PresetMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692406);
      OptionsPanel_Graphics.NativeMethodInfoPtr_CheckForGraphicsPresetChanges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692407);
      OptionsPanel_Graphics.NativeMethodInfoPtr_AddMenuFPSCapDropdown_Private_Void_LocalizationKey_UnityAction_1_LimitFPSMode_Func_1_LimitFPSMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692408);
      OptionsPanel_Graphics.NativeMethodInfoPtr_AddClothUpdateDropdown_Private_Void_LocalizationKey_UnityAction_1_ClothUpdateSpeed_Func_1_ClothUpdateSpeed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692409);
      OptionsPanel_Graphics.NativeMethodInfoPtr_FullScreenModeDropdown_Private_Void_LocalizationKey_UnityAction_1_FullScreenMode_Func_1_FullScreenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692410);
      OptionsPanel_Graphics.NativeMethodInfoPtr_AddResolutionsDropdown_Private_Void_LocalizationKey_UnityAction_1_int2_Func_1_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692411);
      OptionsPanel_Graphics.NativeMethodInfoPtr_RedrawEntries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692412);
      OptionsPanel_Graphics.NativeMethodInfoPtr_OnAntiAliasingModeChange_Private_Void_AntiAliasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692413);
      OptionsPanel_Graphics.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692414);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_0_Private_PresetMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692415);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_1_Private_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692416);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_2_Private_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692417);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_3_Private_Void_FullScreenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692418);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_5_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692419);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_6_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692420);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_7_Private_Void_QualitySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692421);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_8_Private_QualitySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692422);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_9_Private_Void_QualitySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692423);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_10_Private_QualitySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692424);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_11_Private_Void_QualitySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692425);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_12_Private_QualitySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692426);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_13_Private_Void_QualitySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692427);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_14_Private_QualitySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692428);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_15_Private_Void_QualitySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692429);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_16_Private_QualitySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692430);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_17_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692431);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_18_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692432);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_19_Private_AntiAliasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692433);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_20_Private_Void_LimitFPSMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692434);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_21_Private_LimitFPSMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692435);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_22_Private_Void_LimitFPSMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692436);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_23_Private_LimitFPSMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692437);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_40_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692438);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_41_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692439);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_24_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692440);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_25_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692441);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_26_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692442);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_27_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692443);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_28_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692444);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_29_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692445);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_30_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692446);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_31_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692447);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_32_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692448);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_33_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692449);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_34_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692450);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_35_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692451);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_36_Private_Void_QualitySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692452);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_37_Private_QualitySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692453);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_38_Private_Void_ClothUpdateSpeed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692454);
      OptionsPanel_Graphics.NativeMethodInfoPtr__Start_b__54_39_Private_ClothUpdateSpeed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, 100692455);
    }

    public OptionsPanel_Graphics(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe RectTransform ContentNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_ContentNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_ContentNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Options_Control_Checkbox CheckboxPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_CheckboxPrefab));
        return pointer == System.IntPtr.Zero ? (Options_Control_Checkbox) null : new Options_Control_Checkbox(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_CheckboxPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Options_Control_Slider SliderPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_SliderPrefab));
        return pointer == System.IntPtr.Zero ? (Options_Control_Slider) null : new Options_Control_Slider(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_SliderPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Options_Control_Dropdown DropdownPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_DropdownPrefab));
        return pointer == System.IntPtr.Zero ? (Options_Control_Dropdown) null : new Options_Control_Dropdown(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_DropdownPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe OptionsCategoryHeader CategoryHeaderPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_CategoryHeaderPrefab));
        return pointer == System.IntPtr.Zero ? (OptionsCategoryHeader) null : new OptionsCategoryHeader(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_CategoryHeaderPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LK_Advanced
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_Advanced));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_Advanced)) = value;
      }
    }

    public unsafe LocalizationKey LK_General
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_General));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_General)) = value;
      }
    }

    public unsafe LocalizationKey LK_GraphicsPreset
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_GraphicsPreset));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_GraphicsPreset)) = value;
      }
    }

    public unsafe LocalizationKey LK_Brightness
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_Brightness));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_Brightness)) = value;
      }
    }

    public unsafe LocalizationKey LK_Display
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_Display));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_Display)) = value;
      }
    }

    public unsafe LocalizationKey LK_Resolution
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_Resolution));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_Resolution)) = value;
      }
    }

    public unsafe LocalizationKey LK_WindowMode
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_WindowMode));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_WindowMode)) = value;
      }
    }

    public unsafe LocalizationKey LK_Quality
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_Quality));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_Quality)) = value;
      }
    }

    public unsafe LocalizationKey LK_AmbientOcclusionQuality
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_AmbientOcclusionQuality));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_AmbientOcclusionQuality)) = value;
      }
    }

    public unsafe LocalizationKey LK_BloomQuality
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_BloomQuality));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_BloomQuality)) = value;
      }
    }

    public unsafe LocalizationKey LK_ShadowQuality
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_ShadowQuality));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_ShadowQuality)) = value;
      }
    }

    public unsafe LocalizationKey LK_VolumetricFogQuality
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_VolumetricFogQuality));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_VolumetricFogQuality)) = value;
      }
    }

    public unsafe LocalizationKey LK_VerticalSync
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_VerticalSync));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_VerticalSync)) = value;
      }
    }

    public unsafe LocalizationKey LK_ShouldLimitFPS
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_ShouldLimitFPS));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_ShouldLimitFPS)) = value;
      }
    }

    public unsafe LocalizationKey LK_LimitFPSSliderLabel
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_LimitFPSSliderLabel));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_LimitFPSSliderLabel)) = value;
      }
    }

    public unsafe LocalizationKey LK_MotionBlur
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_MotionBlur));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_MotionBlur)) = value;
      }
    }

    public unsafe LocalizationKey LK_DepthOfField
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_DepthOfField));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_DepthOfField)) = value;
      }
    }

    public unsafe LocalizationKey LK_HighQualityVegetation
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_HighQualityVegetation));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_HighQualityVegetation)) = value;
      }
    }

    public unsafe LocalizationKey LK_HighQualityAtmosphere
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_HighQualityAtmosphere));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_HighQualityAtmosphere)) = value;
      }
    }

    public unsafe LocalizationKey LK_TextureStreaming
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_TextureStreaming));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_TextureStreaming)) = value;
      }
    }

    public unsafe LocalizationKey LK_TextureMipStreaming
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_TextureMipStreaming));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_TextureMipStreaming)) = value;
      }
    }

    public unsafe LocalizationKey LK_DynamicResolution
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_DynamicResolution));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_DynamicResolution)) = value;
      }
    }

    public unsafe LocalizationKey LK_ScreenShake
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_ScreenShake));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_ScreenShake)) = value;
      }
    }

    public unsafe LocalizationKey LK_AntiAliasingMode
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_AntiAliasingMode));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_AntiAliasingMode)) = value;
      }
    }

    public unsafe LocalizationKey LK_FSRQualityMode
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_FSRQualityMode));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_FSRQualityMode)) = value;
      }
    }

    public unsafe LocalizationKey LK_ClothQualityMode
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_ClothQualityMode));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_ClothQualityMode)) = value;
      }
    }

    public unsafe LocalizationKey LK_ClothUpdateRate
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_ClothUpdateRate));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_ClothUpdateRate)) = value;
      }
    }

    public unsafe LocalizationKey LK_MenuCapFPSMode
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_MenuCapFPSMode));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_MenuCapFPSMode)) = value;
      }
    }

    public unsafe LocalizationKey LK_Value
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_Value));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_Value)) = value;
      }
    }

    public unsafe LocalizationKey LK_ValuePercent
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_ValuePercent));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_ValuePercent)) = value;
      }
    }

    public unsafe LocalizationKey LK_BloodEffectsEnabled
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_BloodEffectsEnabled));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LK_BloodEffectsEnabled)) = value;
      }
    }

    public unsafe ClientSettings _ClientSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr__ClientSettings));
        return pointer == System.IntPtr.Zero ? (ClientSettings) null : new ClientSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr__ClientSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GraphicsSettings _Settings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr__Settings));
        return pointer == System.IntPtr.Zero ? (GraphicsSettings) null : new GraphicsSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr__Settings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<OptionsPanel_Graphics.LocalizedQualitySetting> LocalizedQualities
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LocalizedQualities));
        return pointer == System.IntPtr.Zero ? (List<OptionsPanel_Graphics.LocalizedQualitySetting>) null : new List<OptionsPanel_Graphics.LocalizedQualitySetting>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LocalizedQualities), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<OptionsPanel_Graphics.LocalizedWindowMode> LocalizedWindowModes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LocalizedWindowModes));
        return pointer == System.IntPtr.Zero ? (List<OptionsPanel_Graphics.LocalizedWindowMode>) null : new List<OptionsPanel_Graphics.LocalizedWindowMode>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LocalizedWindowModes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<OptionsPanel_Graphics.LocalizedGraphicsPreset> LocalizedGraphicsPresets
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LocalizedGraphicsPresets));
        return pointer == System.IntPtr.Zero ? (List<OptionsPanel_Graphics.LocalizedGraphicsPreset>) null : new List<OptionsPanel_Graphics.LocalizedGraphicsPreset>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LocalizedGraphicsPresets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<OptionsPanel_Graphics.LocalizedMenuFPSCapMode> LocalizedCapFPSMode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LocalizedCapFPSMode));
        return pointer == System.IntPtr.Zero ? (List<OptionsPanel_Graphics.LocalizedMenuFPSCapMode>) null : new List<OptionsPanel_Graphics.LocalizedMenuFPSCapMode>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LocalizedCapFPSMode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<OptionsPanel_Graphics.LocalizedClothSpeed> LocalizedClothSpeeds
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LocalizedClothSpeeds));
        return pointer == System.IntPtr.Zero ? (List<OptionsPanel_Graphics.LocalizedClothSpeed>) null : new List<OptionsPanel_Graphics.LocalizedClothSpeed>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LocalizedClothSpeeds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<OptionsPanel_Graphics.LocalizedFSRQualityMode> LocalizedFSRQualityModes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LocalizedFSRQualityModes));
        return pointer == System.IntPtr.Zero ? (List<OptionsPanel_Graphics.LocalizedFSRQualityMode>) null : new List<OptionsPanel_Graphics.LocalizedFSRQualityMode>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_LocalizedFSRQualityModes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<MonoBehaviour> RedrawableEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_RedrawableEntries));
        return pointer == System.IntPtr.Zero ? (List<MonoBehaviour>) null : new List<MonoBehaviour>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_RedrawableEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Options_Control_Dropdown _FSR
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr__FSR));
        return pointer == System.IntPtr.Zero ? (Options_Control_Dropdown) null : new Options_Control_Dropdown(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr__FSR), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool NeedsRefresh
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_NeedsRefresh));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_NeedsRefresh)) = value;
      }
    }

    public unsafe bool NeedsHybridModelRefresh
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_NeedsHybridModelRefresh));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.NativeFieldInfoPtr_NeedsHybridModelRefresh)) = value;
      }
    }

    [Serializable]
    [StructLayout(LayoutKind.Explicit)]
    public struct LocalizedQualitySetting
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Quality;
      private static readonly System.IntPtr NativeFieldInfoPtr_Text;
      [FieldOffset(0)]
      public QualitySetting Quality;
      [FieldOffset(4)]
      public LocalizationKey Text;

      static LocalizedQualitySetting()
      {
        Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedQualitySetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LocalizedQualitySetting));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedQualitySetting>.NativeClassPtr);
        OptionsPanel_Graphics.LocalizedQualitySetting.NativeFieldInfoPtr_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedQualitySetting>.NativeClassPtr, nameof (Quality));
        OptionsPanel_Graphics.LocalizedQualitySetting.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedQualitySetting>.NativeClassPtr, nameof (Text));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedQualitySetting>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [Serializable]
    [StructLayout(LayoutKind.Explicit)]
    public struct LocalizedWindowMode
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Mode;
      private static readonly System.IntPtr NativeFieldInfoPtr_Text;
      [FieldOffset(0)]
      public FullScreenMode Mode;
      [FieldOffset(4)]
      public LocalizationKey Text;

      static LocalizedWindowMode()
      {
        Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedWindowMode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LocalizedWindowMode));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedWindowMode>.NativeClassPtr);
        OptionsPanel_Graphics.LocalizedWindowMode.NativeFieldInfoPtr_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedWindowMode>.NativeClassPtr, nameof (Mode));
        OptionsPanel_Graphics.LocalizedWindowMode.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedWindowMode>.NativeClassPtr, nameof (Text));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedWindowMode>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [Serializable]
    [StructLayout(LayoutKind.Explicit)]
    public struct LocalizedGraphicsPreset
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Mode;
      private static readonly System.IntPtr NativeFieldInfoPtr_Text;
      [FieldOffset(0)]
      public PresetMode Mode;
      [FieldOffset(4)]
      public LocalizationKey Text;

      static LocalizedGraphicsPreset()
      {
        Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedGraphicsPreset>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LocalizedGraphicsPreset));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedGraphicsPreset>.NativeClassPtr);
        OptionsPanel_Graphics.LocalizedGraphicsPreset.NativeFieldInfoPtr_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedGraphicsPreset>.NativeClassPtr, nameof (Mode));
        OptionsPanel_Graphics.LocalizedGraphicsPreset.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedGraphicsPreset>.NativeClassPtr, nameof (Text));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedGraphicsPreset>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [Serializable]
    [StructLayout(LayoutKind.Explicit)]
    public struct LocalizedMenuFPSCapMode
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CapFPSMode;
      private static readonly System.IntPtr NativeFieldInfoPtr_Text;
      [FieldOffset(0)]
      public LimitFPSMode CapFPSMode;
      [FieldOffset(4)]
      public LocalizationKey Text;

      static LocalizedMenuFPSCapMode()
      {
        Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedMenuFPSCapMode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LocalizedMenuFPSCapMode));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedMenuFPSCapMode>.NativeClassPtr);
        OptionsPanel_Graphics.LocalizedMenuFPSCapMode.NativeFieldInfoPtr_CapFPSMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedMenuFPSCapMode>.NativeClassPtr, nameof (CapFPSMode));
        OptionsPanel_Graphics.LocalizedMenuFPSCapMode.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedMenuFPSCapMode>.NativeClassPtr, nameof (Text));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedMenuFPSCapMode>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [Serializable]
    [StructLayout(LayoutKind.Explicit)]
    public struct LocalizedClothSpeed
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_UpdateSpeed;
      private static readonly System.IntPtr NativeFieldInfoPtr_Text;
      [FieldOffset(0)]
      public ClothUpdateSpeed UpdateSpeed;
      [FieldOffset(4)]
      public LocalizationKey Text;

      static LocalizedClothSpeed()
      {
        Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedClothSpeed>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LocalizedClothSpeed));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedClothSpeed>.NativeClassPtr);
        OptionsPanel_Graphics.LocalizedClothSpeed.NativeFieldInfoPtr_UpdateSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedClothSpeed>.NativeClassPtr, nameof (UpdateSpeed));
        OptionsPanel_Graphics.LocalizedClothSpeed.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedClothSpeed>.NativeClassPtr, nameof (Text));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedClothSpeed>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [Serializable]
    [StructLayout(LayoutKind.Explicit)]
    public struct LocalizedFSRQualityMode
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_QualityMode;
      private static readonly System.IntPtr NativeFieldInfoPtr_Text;
      [FieldOffset(0)]
      public FSRQualityMode QualityMode;
      [FieldOffset(4)]
      public LocalizationKey Text;

      static LocalizedFSRQualityMode()
      {
        Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedFSRQualityMode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, nameof (LocalizedFSRQualityMode));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedFSRQualityMode>.NativeClassPtr);
        OptionsPanel_Graphics.LocalizedFSRQualityMode.NativeFieldInfoPtr_QualityMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedFSRQualityMode>.NativeClassPtr, nameof (QualityMode));
        OptionsPanel_Graphics.LocalizedFSRQualityMode.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedFSRQualityMode>.NativeClassPtr, nameof (Text));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OptionsPanel_Graphics.LocalizedFSRQualityMode>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.UI.OptionsPanel_Graphics/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__54_4;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__54_42;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_4_Internal_FullScreenMode_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__54_42_Internal_Single_Single_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsPanel_Graphics.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161622, XrefRangeEnd = 1161623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe FullScreenMode _Start_b__54_4()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.__c.NativeMethodInfoPtr__Start_b__54_4_Internal_FullScreenMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(FullScreenMode*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe float _Start_b__54_42(float newValue)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &newValue;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.__c.NativeMethodInfoPtr__Start_b__54_42_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<OptionsPanel_Graphics.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Graphics.__c>.NativeClassPtr);
        OptionsPanel_Graphics.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.__c>.NativeClassPtr, "<>9");
        OptionsPanel_Graphics.__c.NativeFieldInfoPtr___9__54_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.__c>.NativeClassPtr, "<>9__54_4");
        OptionsPanel_Graphics.__c.NativeFieldInfoPtr___9__54_42 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.__c>.NativeClassPtr, "<>9__54_42");
        OptionsPanel_Graphics.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics.__c>.NativeClassPtr, 100692457);
        OptionsPanel_Graphics.__c.NativeMethodInfoPtr__Start_b__54_4_Internal_FullScreenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics.__c>.NativeClassPtr, 100692458);
        OptionsPanel_Graphics.__c.NativeMethodInfoPtr__Start_b__54_42_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics.__c>.NativeClassPtr, 100692459);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe OptionsPanel_Graphics.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(OptionsPanel_Graphics.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (OptionsPanel_Graphics.__c) null : new OptionsPanel_Graphics.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(OptionsPanel_Graphics.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<FullScreenMode> __9__54_4
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(OptionsPanel_Graphics.__c.NativeFieldInfoPtr___9__54_4, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<FullScreenMode>) null : new Il2CppSystem.Func<FullScreenMode>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(OptionsPanel_Graphics.__c.NativeFieldInfoPtr___9__54_4, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<float, float> __9__54_42
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(OptionsPanel_Graphics.__c.NativeFieldInfoPtr___9__54_42, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<float, float>) null : new Il2CppSystem.Func<float, float>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(OptionsPanel_Graphics.__c.NativeFieldInfoPtr___9__54_42, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.OptionsPanel_Graphics/<>c__DisplayClass65_0")]
    public sealed class __c__DisplayClass65_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_values;
      private static readonly System.IntPtr NativeFieldInfoPtr_onValueChange;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddQualityDropdown_b__0_Internal_Void_Int32_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass65_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass65_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161623, XrefRangeEnd = 1161629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AddQualityDropdown_b__0(int newIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &newIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.__c__DisplayClass65_0.NativeMethodInfoPtr__AddQualityDropdown_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass65_0()
      {
        Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass65_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, "<>c__DisplayClass65_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass65_0>.NativeClassPtr);
        OptionsPanel_Graphics.__c__DisplayClass65_0.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass65_0>.NativeClassPtr, nameof (values));
        OptionsPanel_Graphics.__c__DisplayClass65_0.NativeFieldInfoPtr_onValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass65_0>.NativeClassPtr, nameof (onValueChange));
        OptionsPanel_Graphics.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass65_0>.NativeClassPtr, 100692460);
        OptionsPanel_Graphics.__c__DisplayClass65_0.NativeMethodInfoPtr__AddQualityDropdown_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass65_0>.NativeClassPtr, 100692461);
      }

      public __c__DisplayClass65_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe List<QualitySetting> values
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass65_0.NativeFieldInfoPtr_values));
          return pointer == System.IntPtr.Zero ? (List<QualitySetting>) null : new List<QualitySetting>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass65_0.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe UnityAction<QualitySetting> onValueChange
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass65_0.NativeFieldInfoPtr_onValueChange));
          return pointer == System.IntPtr.Zero ? (UnityAction<QualitySetting>) null : new UnityAction<QualitySetting>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass65_0.NativeFieldInfoPtr_onValueChange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.OptionsPanel_Graphics/<>c__DisplayClass66_0")]
    public sealed class __c__DisplayClass66_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_values;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddAntiAliasingDropdown_b__0_Internal_Void_Int32_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass66_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass66_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161629, XrefRangeEnd = 1161635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AddAntiAliasingDropdown_b__0(int newIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &newIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.__c__DisplayClass66_0.NativeMethodInfoPtr__AddAntiAliasingDropdown_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass66_0()
      {
        Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass66_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, "<>c__DisplayClass66_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass66_0>.NativeClassPtr);
        OptionsPanel_Graphics.__c__DisplayClass66_0.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass66_0>.NativeClassPtr, nameof (values));
        OptionsPanel_Graphics.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass66_0>.NativeClassPtr, "<>4__this");
        OptionsPanel_Graphics.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass66_0>.NativeClassPtr, 100692462);
        OptionsPanel_Graphics.__c__DisplayClass66_0.NativeMethodInfoPtr__AddAntiAliasingDropdown_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass66_0>.NativeClassPtr, 100692463);
      }

      public __c__DisplayClass66_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe List<AntiAliasingMode> values
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass66_0.NativeFieldInfoPtr_values));
          return pointer == System.IntPtr.Zero ? (List<AntiAliasingMode>) null : new List<AntiAliasingMode>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass66_0.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe OptionsPanel_Graphics __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (OptionsPanel_Graphics) null : new OptionsPanel_Graphics(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.OptionsPanel_Graphics/<>c__DisplayClass67_0")]
    public sealed class __c__DisplayClass67_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_values;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddFSRQualityDropdown_b__0_Internal_Void_Int32_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass67_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass67_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161635, XrefRangeEnd = 1161640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AddFSRQualityDropdown_b__0(int newIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &newIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.__c__DisplayClass67_0.NativeMethodInfoPtr__AddFSRQualityDropdown_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass67_0()
      {
        Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass67_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, "<>c__DisplayClass67_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass67_0>.NativeClassPtr);
        OptionsPanel_Graphics.__c__DisplayClass67_0.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass67_0>.NativeClassPtr, nameof (values));
        OptionsPanel_Graphics.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass67_0>.NativeClassPtr, "<>4__this");
        OptionsPanel_Graphics.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass67_0>.NativeClassPtr, 100692464);
        OptionsPanel_Graphics.__c__DisplayClass67_0.NativeMethodInfoPtr__AddFSRQualityDropdown_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass67_0>.NativeClassPtr, 100692465);
      }

      public __c__DisplayClass67_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe List<FSRQualityMode> values
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass67_0.NativeFieldInfoPtr_values));
          return pointer == System.IntPtr.Zero ? (List<FSRQualityMode>) null : new List<FSRQualityMode>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass67_0.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe OptionsPanel_Graphics __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (OptionsPanel_Graphics) null : new OptionsPanel_Graphics(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.OptionsPanel_Graphics/<>c__DisplayClass69_0")]
    public sealed class __c__DisplayClass69_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_values;
      private static readonly System.IntPtr NativeFieldInfoPtr_onValueChange;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddGraphicsPresetDropdown_b__0_Internal_Void_Int32_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass69_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass69_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.__c__DisplayClass69_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161640, XrefRangeEnd = 1161646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AddGraphicsPresetDropdown_b__0(int newIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &newIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.__c__DisplayClass69_0.NativeMethodInfoPtr__AddGraphicsPresetDropdown_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass69_0()
      {
        Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass69_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, "<>c__DisplayClass69_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass69_0>.NativeClassPtr);
        OptionsPanel_Graphics.__c__DisplayClass69_0.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass69_0>.NativeClassPtr, nameof (values));
        OptionsPanel_Graphics.__c__DisplayClass69_0.NativeFieldInfoPtr_onValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass69_0>.NativeClassPtr, nameof (onValueChange));
        OptionsPanel_Graphics.__c__DisplayClass69_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass69_0>.NativeClassPtr, 100692466);
        OptionsPanel_Graphics.__c__DisplayClass69_0.NativeMethodInfoPtr__AddGraphicsPresetDropdown_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass69_0>.NativeClassPtr, 100692467);
      }

      public __c__DisplayClass69_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe List<PresetMode> values
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass69_0.NativeFieldInfoPtr_values));
          return pointer == System.IntPtr.Zero ? (List<PresetMode>) null : new List<PresetMode>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass69_0.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe UnityAction<PresetMode> onValueChange
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass69_0.NativeFieldInfoPtr_onValueChange));
          return pointer == System.IntPtr.Zero ? (UnityAction<PresetMode>) null : new UnityAction<PresetMode>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass69_0.NativeFieldInfoPtr_onValueChange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.OptionsPanel_Graphics/<>c__DisplayClass72_0")]
    public sealed class __c__DisplayClass72_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_values;
      private static readonly System.IntPtr NativeFieldInfoPtr_onValueChange;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddMenuFPSCapDropdown_b__0_Internal_Void_Int32_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass72_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass72_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.__c__DisplayClass72_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161646, XrefRangeEnd = 1161652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AddMenuFPSCapDropdown_b__0(int newIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &newIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.__c__DisplayClass72_0.NativeMethodInfoPtr__AddMenuFPSCapDropdown_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass72_0()
      {
        Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass72_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, "<>c__DisplayClass72_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass72_0>.NativeClassPtr);
        OptionsPanel_Graphics.__c__DisplayClass72_0.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass72_0>.NativeClassPtr, nameof (values));
        OptionsPanel_Graphics.__c__DisplayClass72_0.NativeFieldInfoPtr_onValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass72_0>.NativeClassPtr, nameof (onValueChange));
        OptionsPanel_Graphics.__c__DisplayClass72_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass72_0>.NativeClassPtr, 100692468);
        OptionsPanel_Graphics.__c__DisplayClass72_0.NativeMethodInfoPtr__AddMenuFPSCapDropdown_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass72_0>.NativeClassPtr, 100692469);
      }

      public __c__DisplayClass72_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe List<LimitFPSMode> values
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass72_0.NativeFieldInfoPtr_values));
          return pointer == System.IntPtr.Zero ? (List<LimitFPSMode>) null : new List<LimitFPSMode>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass72_0.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe UnityAction<LimitFPSMode> onValueChange
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass72_0.NativeFieldInfoPtr_onValueChange));
          return pointer == System.IntPtr.Zero ? (UnityAction<LimitFPSMode>) null : new UnityAction<LimitFPSMode>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass72_0.NativeFieldInfoPtr_onValueChange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.OptionsPanel_Graphics/<>c__DisplayClass73_0")]
    public sealed class __c__DisplayClass73_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_values;
      private static readonly System.IntPtr NativeFieldInfoPtr_onValueChange;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddClothUpdateDropdown_b__0_Internal_Void_Int32_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass73_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass73_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.__c__DisplayClass73_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161652, XrefRangeEnd = 1161658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AddClothUpdateDropdown_b__0(int newIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &newIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.__c__DisplayClass73_0.NativeMethodInfoPtr__AddClothUpdateDropdown_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass73_0()
      {
        Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass73_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, "<>c__DisplayClass73_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass73_0>.NativeClassPtr);
        OptionsPanel_Graphics.__c__DisplayClass73_0.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass73_0>.NativeClassPtr, nameof (values));
        OptionsPanel_Graphics.__c__DisplayClass73_0.NativeFieldInfoPtr_onValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass73_0>.NativeClassPtr, nameof (onValueChange));
        OptionsPanel_Graphics.__c__DisplayClass73_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass73_0>.NativeClassPtr, 100692470);
        OptionsPanel_Graphics.__c__DisplayClass73_0.NativeMethodInfoPtr__AddClothUpdateDropdown_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass73_0>.NativeClassPtr, 100692471);
      }

      public __c__DisplayClass73_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe List<ClothUpdateSpeed> values
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass73_0.NativeFieldInfoPtr_values));
          return pointer == System.IntPtr.Zero ? (List<ClothUpdateSpeed>) null : new List<ClothUpdateSpeed>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass73_0.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe UnityAction<ClothUpdateSpeed> onValueChange
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass73_0.NativeFieldInfoPtr_onValueChange));
          return pointer == System.IntPtr.Zero ? (UnityAction<ClothUpdateSpeed>) null : new UnityAction<ClothUpdateSpeed>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass73_0.NativeFieldInfoPtr_onValueChange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.OptionsPanel_Graphics/<>c__DisplayClass74_0")]
    public sealed class __c__DisplayClass74_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_values;
      private static readonly System.IntPtr NativeFieldInfoPtr_onValueChange;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__FullScreenModeDropdown_b__0_Internal_Void_Int32_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass74_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass74_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.__c__DisplayClass74_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161658, XrefRangeEnd = 1161664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _FullScreenModeDropdown_b__0(int newIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &newIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.__c__DisplayClass74_0.NativeMethodInfoPtr__FullScreenModeDropdown_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass74_0()
      {
        Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass74_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, "<>c__DisplayClass74_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass74_0>.NativeClassPtr);
        OptionsPanel_Graphics.__c__DisplayClass74_0.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass74_0>.NativeClassPtr, nameof (values));
        OptionsPanel_Graphics.__c__DisplayClass74_0.NativeFieldInfoPtr_onValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass74_0>.NativeClassPtr, nameof (onValueChange));
        OptionsPanel_Graphics.__c__DisplayClass74_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass74_0>.NativeClassPtr, 100692472);
        OptionsPanel_Graphics.__c__DisplayClass74_0.NativeMethodInfoPtr__FullScreenModeDropdown_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass74_0>.NativeClassPtr, 100692473);
      }

      public __c__DisplayClass74_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe List<FullScreenMode> values
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass74_0.NativeFieldInfoPtr_values));
          return pointer == System.IntPtr.Zero ? (List<FullScreenMode>) null : new List<FullScreenMode>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass74_0.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe UnityAction<FullScreenMode> onValueChange
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass74_0.NativeFieldInfoPtr_onValueChange));
          return pointer == System.IntPtr.Zero ? (UnityAction<FullScreenMode>) null : new UnityAction<FullScreenMode>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass74_0.NativeFieldInfoPtr_onValueChange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.OptionsPanel_Graphics/<>c__DisplayClass75_0")]
    public sealed class __c__DisplayClass75_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_values;
      private static readonly System.IntPtr NativeFieldInfoPtr_onValueChange;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddResolutionsDropdown_b__0_Internal_Void_Int32_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass75_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass75_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161664, XrefRangeEnd = 1161670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AddResolutionsDropdown_b__0(int newIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &newIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.__c__DisplayClass75_0.NativeMethodInfoPtr__AddResolutionsDropdown_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass75_0()
      {
        Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass75_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, "<>c__DisplayClass75_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass75_0>.NativeClassPtr);
        OptionsPanel_Graphics.__c__DisplayClass75_0.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass75_0>.NativeClassPtr, nameof (values));
        OptionsPanel_Graphics.__c__DisplayClass75_0.NativeFieldInfoPtr_onValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass75_0>.NativeClassPtr, nameof (onValueChange));
        OptionsPanel_Graphics.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass75_0>.NativeClassPtr, 100692474);
        OptionsPanel_Graphics.__c__DisplayClass75_0.NativeMethodInfoPtr__AddResolutionsDropdown_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass75_0>.NativeClassPtr, 100692475);
      }

      public __c__DisplayClass75_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe List<int2> values
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass75_0.NativeFieldInfoPtr_values));
          return pointer == System.IntPtr.Zero ? (List<int2>) null : new List<int2>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass75_0.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe UnityAction<int2> onValueChange
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass75_0.NativeFieldInfoPtr_onValueChange));
          return pointer == System.IntPtr.Zero ? (UnityAction<int2>) null : new UnityAction<int2>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass75_0.NativeFieldInfoPtr_onValueChange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.OptionsPanel_Graphics/<>c__DisplayClass75_1")]
    public sealed class __c__DisplayClass75_1 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_resolution;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddResolutionsDropdown_b__1_Internal_Boolean_int2_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass75_1()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass75_1>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.__c__DisplayClass75_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161670, XrefRangeEnd = 1161671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _AddResolutionsDropdown_b__1(int2 res)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &res;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Graphics.__c__DisplayClass75_1.NativeMethodInfoPtr__AddResolutionsDropdown_b__1_Internal_Boolean_int2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass75_1()
      {
        Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass75_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsPanel_Graphics>.NativeClassPtr, "<>c__DisplayClass75_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass75_1>.NativeClassPtr);
        OptionsPanel_Graphics.__c__DisplayClass75_1.NativeFieldInfoPtr_resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass75_1>.NativeClassPtr, nameof (resolution));
        OptionsPanel_Graphics.__c__DisplayClass75_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass75_1>.NativeClassPtr, 100692476);
        OptionsPanel_Graphics.__c__DisplayClass75_1.NativeMethodInfoPtr__AddResolutionsDropdown_b__1_Internal_Boolean_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Graphics.__c__DisplayClass75_1>.NativeClassPtr, 100692477);
      }

      public __c__DisplayClass75_1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Resolution resolution
      {
        get
        {
          return *(Resolution*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass75_1.NativeFieldInfoPtr_resolution));
        }
        [param: In] set
        {
          *(Resolution*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Graphics.__c__DisplayClass75_1.NativeFieldInfoPtr_resolution)) = value;
        }
      }
    }
  }
}
