// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.OptionsPanel_Interface
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
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace ProjectM.UI
{
  public class OptionsPanel_Interface : StunGUIBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ContentNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_CheckboxPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_CategoryHeaderPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_DropdownPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_SliderPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Interface;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Language;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_HUD;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_StreamerMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_LockedMinimapRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ResetMapOnOpen;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_FadeOutBuildMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ChatSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ShowChatTimeStamps;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ShowGlobalChat;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ShowClanNames;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_AlwaysShowVampireHuds;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_SteamRichPresenceEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ConsoleEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ConfineCursorToWindow;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_AllowFriendsToJoinThroughSteam;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_SkipIntroCinematic;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ToggleEquipMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Privacy;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_AnalyticsOptedIn;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_ShowPlayerPathOnMinimap;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_CameraSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_InvertedCamera;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_CameraSensitivity;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__Settings;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddHeader_Private_Void_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddToggle_Private_Void_LocalizationKey_Func_1_Boolean_UnityAction_1_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSlider_Private_Void_LocalizationKey_LocalizationKey_Single_Single_Single_UnityAction_1_Single_Func_2_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisplayValueTransformPercent_Private_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisplayValueTransform_Private_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddLocalizationDropdown_Private_Options_Control_Dropdown_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToggleAnalytics_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_0_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_1_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_2_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_3_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_4_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_5_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_6_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_7_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_8_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_9_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_10_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_11_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_12_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_13_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_14_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_15_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_16_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_17_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_18_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_19_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_20_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_21_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_22_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_23_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_24_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_25_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_26_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_27_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_28_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_29_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_30_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_31_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_32_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__32_33_Private_Void_Boolean_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162894, XrefRangeEnd = 1163162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163162, XrefRangeEnd = 1163166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddHeader(LocalizationKey textKey)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &textKey;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr_AddHeader_Private_Void_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163166, XrefRangeEnd = 1163167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr_AddToggle_Private_Void_LocalizationKey_Func_1_Boolean_UnityAction_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163167, XrefRangeEnd = 1163171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddSlider(
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
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr_AddSlider_Private_Void_LocalizationKey_LocalizationKey_Single_Single_Single_UnityAction_1_Single_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163171, XrefRangeEnd = 1163175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float DisplayValueTransformPercent(float value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr_DisplayValueTransformPercent_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe float DisplayValueTransform(float value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr_DisplayValueTransform_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1163464, RefRangeEnd = 1163465, XrefRangeStart = 1163175, XrefRangeEnd = 1163464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Options_Control_Dropdown AddLocalizationDropdown(LocalizationKey textKey)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &textKey;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr_AddLocalizationDropdown_Private_Options_Control_Dropdown_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Options_Control_Dropdown) null : new Options_Control_Dropdown(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163465, XrefRangeEnd = 1163466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ToggleAnalytics(bool value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr_ToggleAnalytics_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163466, XrefRangeEnd = 1163471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OptionsPanel_Interface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__32_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__32_1(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_1_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__32_2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_2_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__32_3(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_3_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__32_4()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_4_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__32_5(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_5_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__32_6()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_6_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163471, XrefRangeEnd = 1163473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__32_7(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_7_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__32_8()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_8_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__32_9(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_9_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__32_10()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_10_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__32_11(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_11_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__32_12()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_12_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__32_13(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_13_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__32_14()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_14_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__32_15(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_15_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__32_16()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_16_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__32_17(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_17_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__32_18(float x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &x;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_18_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__32_19()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_19_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__32_20(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_20_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__32_21()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_21_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__32_22(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_22_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__32_23()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_23_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__32_24(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_24_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__32_25()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_25_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__32_26(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_26_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__32_27()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_27_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__32_28(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_28_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__32_29()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_29_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__32_30(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_30_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__32_31(float v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_31_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__32_32()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_32_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__32_33(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_33_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static OptionsPanel_Interface()
    {
      Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (OptionsPanel_Interface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr);
      OptionsPanel_Interface.NativeFieldInfoPtr_ContentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (ContentNode));
      OptionsPanel_Interface.NativeFieldInfoPtr_CheckboxPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (CheckboxPrefab));
      OptionsPanel_Interface.NativeFieldInfoPtr_CategoryHeaderPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (CategoryHeaderPrefab));
      OptionsPanel_Interface.NativeFieldInfoPtr_DropdownPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (DropdownPrefab));
      OptionsPanel_Interface.NativeFieldInfoPtr_SliderPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (SliderPrefab));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_Interface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_Interface));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_Language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_Language));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_HUD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_HUD));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_StreamerMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_StreamerMode));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_LockedMinimapRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_LockedMinimapRotation));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_ResetMapOnOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_ResetMapOnOpen));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_FadeOutBuildMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_FadeOutBuildMenu));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_ChatSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_ChatSize));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_ShowChatTimeStamps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_ShowChatTimeStamps));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_Value));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_ShowGlobalChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_ShowGlobalChat));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_ShowClanNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_ShowClanNames));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_AlwaysShowVampireHuds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_AlwaysShowVampireHuds));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_SteamRichPresenceEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_SteamRichPresenceEnabled));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_ConsoleEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_ConsoleEnabled));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_ConfineCursorToWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_ConfineCursorToWindow));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_AllowFriendsToJoinThroughSteam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_AllowFriendsToJoinThroughSteam));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_SkipIntroCinematic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_SkipIntroCinematic));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_ToggleEquipMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_ToggleEquipMode));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_Privacy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_Privacy));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_AnalyticsOptedIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_AnalyticsOptedIn));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_ShowPlayerPathOnMinimap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_ShowPlayerPathOnMinimap));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_CameraSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_CameraSettings));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_InvertedCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_InvertedCamera));
      OptionsPanel_Interface.NativeFieldInfoPtr_LK_CameraSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LK_CameraSensitivity));
      OptionsPanel_Interface.NativeFieldInfoPtr__ClientSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (_ClientSettings));
      OptionsPanel_Interface.NativeFieldInfoPtr__Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (_Settings));
      OptionsPanel_Interface.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692478);
      OptionsPanel_Interface.NativeMethodInfoPtr_AddHeader_Private_Void_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692479);
      OptionsPanel_Interface.NativeMethodInfoPtr_AddToggle_Private_Void_LocalizationKey_Func_1_Boolean_UnityAction_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692480);
      OptionsPanel_Interface.NativeMethodInfoPtr_AddSlider_Private_Void_LocalizationKey_LocalizationKey_Single_Single_Single_UnityAction_1_Single_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692481);
      OptionsPanel_Interface.NativeMethodInfoPtr_DisplayValueTransformPercent_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692482);
      OptionsPanel_Interface.NativeMethodInfoPtr_DisplayValueTransform_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692483);
      OptionsPanel_Interface.NativeMethodInfoPtr_AddLocalizationDropdown_Private_Options_Control_Dropdown_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692484);
      OptionsPanel_Interface.NativeMethodInfoPtr_ToggleAnalytics_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692485);
      OptionsPanel_Interface.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692486);
      OptionsPanel_Interface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692487);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692488);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_1_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692489);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_2_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692490);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_3_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692491);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_4_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692492);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_5_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692493);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_6_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692494);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_7_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692495);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_8_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692496);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_9_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692497);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_10_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692498);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_11_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692499);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_12_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692500);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_13_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692501);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_14_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692502);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_15_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692503);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_16_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692504);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_17_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692505);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_18_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692506);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_19_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692507);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_20_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692508);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_21_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692509);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_22_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692510);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_23_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692511);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_24_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692512);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_25_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692513);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_26_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692514);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_27_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692515);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_28_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692516);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_29_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692517);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_30_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692518);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_31_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692519);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_32_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692520);
      OptionsPanel_Interface.NativeMethodInfoPtr__Start_b__32_33_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, 100692521);
    }

    public OptionsPanel_Interface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe RectTransform ContentNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_ContentNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_ContentNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Options_Control_Checkbox CheckboxPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_CheckboxPrefab));
        return pointer == System.IntPtr.Zero ? (Options_Control_Checkbox) null : new Options_Control_Checkbox(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_CheckboxPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe OptionsCategoryHeader CategoryHeaderPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_CategoryHeaderPrefab));
        return pointer == System.IntPtr.Zero ? (OptionsCategoryHeader) null : new OptionsCategoryHeader(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_CategoryHeaderPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Options_Control_Dropdown DropdownPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_DropdownPrefab));
        return pointer == System.IntPtr.Zero ? (Options_Control_Dropdown) null : new Options_Control_Dropdown(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_DropdownPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Options_Control_Slider SliderPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_SliderPrefab));
        return pointer == System.IntPtr.Zero ? (Options_Control_Slider) null : new Options_Control_Slider(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_SliderPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LK_Interface
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_Interface));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_Interface)) = value;
      }
    }

    public unsafe LocalizationKey LK_Language
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_Language));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_Language)) = value;
      }
    }

    public unsafe LocalizationKey LK_HUD
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_HUD));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_HUD)) = value;
      }
    }

    public unsafe LocalizationKey LK_StreamerMode
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_StreamerMode));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_StreamerMode)) = value;
      }
    }

    public unsafe LocalizationKey LK_LockedMinimapRotation
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_LockedMinimapRotation));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_LockedMinimapRotation)) = value;
      }
    }

    public unsafe LocalizationKey LK_ResetMapOnOpen
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_ResetMapOnOpen));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_ResetMapOnOpen)) = value;
      }
    }

    public unsafe LocalizationKey LK_FadeOutBuildMenu
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_FadeOutBuildMenu));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_FadeOutBuildMenu)) = value;
      }
    }

    public unsafe LocalizationKey LK_ChatSize
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_ChatSize));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_ChatSize)) = value;
      }
    }

    public unsafe LocalizationKey LK_ShowChatTimeStamps
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_ShowChatTimeStamps));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_ShowChatTimeStamps)) = value;
      }
    }

    public unsafe LocalizationKey LK_Value
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_Value));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_Value)) = value;
      }
    }

    public unsafe LocalizationKey LK_ShowGlobalChat
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_ShowGlobalChat));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_ShowGlobalChat)) = value;
      }
    }

    public unsafe LocalizationKey LK_ShowClanNames
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_ShowClanNames));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_ShowClanNames)) = value;
      }
    }

    public unsafe LocalizationKey LK_AlwaysShowVampireHuds
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_AlwaysShowVampireHuds));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_AlwaysShowVampireHuds)) = value;
      }
    }

    public unsafe LocalizationKey LK_SteamRichPresenceEnabled
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_SteamRichPresenceEnabled));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_SteamRichPresenceEnabled)) = value;
      }
    }

    public unsafe LocalizationKey LK_ConsoleEnabled
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_ConsoleEnabled));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_ConsoleEnabled)) = value;
      }
    }

    public unsafe LocalizationKey LK_ConfineCursorToWindow
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_ConfineCursorToWindow));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_ConfineCursorToWindow)) = value;
      }
    }

    public unsafe LocalizationKey LK_AllowFriendsToJoinThroughSteam
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_AllowFriendsToJoinThroughSteam));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_AllowFriendsToJoinThroughSteam)) = value;
      }
    }

    public unsafe LocalizationKey LK_SkipIntroCinematic
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_SkipIntroCinematic));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_SkipIntroCinematic)) = value;
      }
    }

    public unsafe LocalizationKey LK_ToggleEquipMode
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_ToggleEquipMode));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_ToggleEquipMode)) = value;
      }
    }

    public unsafe LocalizationKey LK_Privacy
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_Privacy));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_Privacy)) = value;
      }
    }

    public unsafe LocalizationKey LK_AnalyticsOptedIn
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_AnalyticsOptedIn));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_AnalyticsOptedIn)) = value;
      }
    }

    public unsafe LocalizationKey LK_ShowPlayerPathOnMinimap
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_ShowPlayerPathOnMinimap));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_ShowPlayerPathOnMinimap)) = value;
      }
    }

    public unsafe LocalizationKey LK_CameraSettings
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_CameraSettings));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_CameraSettings)) = value;
      }
    }

    public unsafe LocalizationKey LK_InvertedCamera
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_InvertedCamera));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_InvertedCamera)) = value;
      }
    }

    public unsafe LocalizationKey LK_CameraSensitivity
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_CameraSensitivity));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr_LK_CameraSensitivity)) = value;
      }
    }

    public unsafe ClientSettings _ClientSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr__ClientSettings));
        return pointer == System.IntPtr.Zero ? (ClientSettings) null : new ClientSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr__ClientSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InterfaceSettings _Settings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr__Settings));
        return pointer == System.IntPtr.Zero ? (InterfaceSettings) null : new InterfaceSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.NativeFieldInfoPtr__Settings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class LocalizationData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FileName;
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;

      static LocalizationData()
      {
        Il2CppClassPointerStore<OptionsPanel_Interface.LocalizationData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, nameof (LocalizationData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Interface.LocalizationData>.NativeClassPtr);
        OptionsPanel_Interface.LocalizationData.NativeFieldInfoPtr_FileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface.LocalizationData>.NativeClassPtr, nameof (FileName));
        OptionsPanel_Interface.LocalizationData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface.LocalizationData>.NativeClassPtr, nameof (Name));
      }

      public LocalizationData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public LocalizationData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<OptionsPanel_Interface.LocalizationData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OptionsPanel_Interface.LocalizationData>.NativeClassPtr, data));
      }

      public unsafe string FileName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.LocalizationData.NativeFieldInfoPtr_FileName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.LocalizationData.NativeFieldInfoPtr_FileName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.LocalizationData.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.LocalizationData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.OptionsPanel_Interface/<>c__DisplayClass39_0")]
    public sealed class __c__DisplayClass39_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_localizations;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddLocalizationDropdown_b__2_Internal_Void_Int32_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass39_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsPanel_Interface.__c__DisplayClass39_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162888, XrefRangeEnd = 1162893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AddLocalizationDropdown_b__2(int newIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &newIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.__c__DisplayClass39_0.NativeMethodInfoPtr__AddLocalizationDropdown_b__2_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass39_0()
      {
        Il2CppClassPointerStore<OptionsPanel_Interface.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, "<>c__DisplayClass39_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Interface.__c__DisplayClass39_0>.NativeClassPtr);
        OptionsPanel_Interface.__c__DisplayClass39_0.NativeFieldInfoPtr_localizations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface.__c__DisplayClass39_0>.NativeClassPtr, nameof (localizations));
        OptionsPanel_Interface.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface.__c__DisplayClass39_0>.NativeClassPtr, "<>4__this");
        OptionsPanel_Interface.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface.__c__DisplayClass39_0>.NativeClassPtr, 100692522);
        OptionsPanel_Interface.__c__DisplayClass39_0.NativeMethodInfoPtr__AddLocalizationDropdown_b__2_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface.__c__DisplayClass39_0>.NativeClassPtr, 100692523);
      }

      public __c__DisplayClass39_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe List<OptionsPanel_Interface.LocalizationData> localizations
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.__c__DisplayClass39_0.NativeFieldInfoPtr_localizations));
          return pointer == System.IntPtr.Zero ? (List<OptionsPanel_Interface.LocalizationData>) null : new List<OptionsPanel_Interface.LocalizationData>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.__c__DisplayClass39_0.NativeFieldInfoPtr_localizations), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe OptionsPanel_Interface __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (OptionsPanel_Interface) null : new OptionsPanel_Interface(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Interface.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.OptionsPanel_Interface/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__39_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__39_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddLocalizationDropdown_b__39_0_Internal_Int32_LocalizationData_LocalizationData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddLocalizationDropdown_b__39_1_Internal_String_LocalizationData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsPanel_Interface.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162893, XrefRangeEnd = 1162894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _AddLocalizationDropdown_b__39_0(
        OptionsPanel_Interface.LocalizationData x,
        OptionsPanel_Interface.LocalizationData y)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) y));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.__c.NativeMethodInfoPtr__AddLocalizationDropdown_b__39_0_Internal_Int32_LocalizationData_LocalizationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe string _AddLocalizationDropdown_b__39_1(
        OptionsPanel_Interface.LocalizationData x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Interface.__c.NativeMethodInfoPtr__AddLocalizationDropdown_b__39_1_Internal_String_LocalizationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c()
      {
        Il2CppClassPointerStore<OptionsPanel_Interface.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsPanel_Interface>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Interface.__c>.NativeClassPtr);
        OptionsPanel_Interface.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface.__c>.NativeClassPtr, "<>9");
        OptionsPanel_Interface.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface.__c>.NativeClassPtr, "<>9__39_0");
        OptionsPanel_Interface.__c.NativeFieldInfoPtr___9__39_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Interface.__c>.NativeClassPtr, "<>9__39_1");
        OptionsPanel_Interface.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface.__c>.NativeClassPtr, 100692525);
        OptionsPanel_Interface.__c.NativeMethodInfoPtr__AddLocalizationDropdown_b__39_0_Internal_Int32_LocalizationData_LocalizationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface.__c>.NativeClassPtr, 100692526);
        OptionsPanel_Interface.__c.NativeMethodInfoPtr__AddLocalizationDropdown_b__39_1_Internal_String_LocalizationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Interface.__c>.NativeClassPtr, 100692527);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe OptionsPanel_Interface.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(OptionsPanel_Interface.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (OptionsPanel_Interface.__c) null : new OptionsPanel_Interface.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(OptionsPanel_Interface.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<OptionsPanel_Interface.LocalizationData> __9__39_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(OptionsPanel_Interface.__c.NativeFieldInfoPtr___9__39_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<OptionsPanel_Interface.LocalizationData>) null : new Il2CppSystem.Comparison<OptionsPanel_Interface.LocalizationData>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(OptionsPanel_Interface.__c.NativeFieldInfoPtr___9__39_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<OptionsPanel_Interface.LocalizationData, string> __9__39_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(OptionsPanel_Interface.__c.NativeFieldInfoPtr___9__39_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<OptionsPanel_Interface.LocalizationData, string>) null : new Il2CppSystem.Func<OptionsPanel_Interface.LocalizationData, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(OptionsPanel_Interface.__c.NativeFieldInfoPtr___9__39_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
