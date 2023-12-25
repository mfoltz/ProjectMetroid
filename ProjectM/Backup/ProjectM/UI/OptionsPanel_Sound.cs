// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.OptionsPanel_Sound
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Audio;
using Stunlock.Fmod;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace ProjectM.UI
{
  public class OptionsPanel_Sound : StunGUIBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ContentNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_CheckboxPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_SliderPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_DropdownPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_CategoryHeaderPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_AudioSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_DisableAllSounds;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_DisableMusic;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_MonoSound;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_SoundInBackground;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Volume;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Master;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Effects;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Music;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Ambience;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_PlayerVoiceLines;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_VoiceLines;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_UIEffects;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Misc;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Soundcard;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_VoiceSoundcard;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_VoiceMicSoundcard;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_VOIPEffects;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_PushToTalk;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Autojoin;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_Connected;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_VoiceChat;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_VolumeValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_DefaultSoundCard;
    private static readonly System.IntPtr NativeFieldInfoPtr__StudioManagerSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__StudioManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__StudioSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CoreSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__Settings;
    private static readonly System.IntPtr NativeFieldInfoPtr__Drivers;
    private static readonly System.IntPtr NativeFieldInfoPtr__DriversTmp;
    private static readonly System.IntPtr NativeFieldInfoPtr__VoipInputDrivers;
    private static readonly System.IntPtr NativeFieldInfoPtr__VoipOutputDrivers;
    private static readonly System.IntPtr NativeFieldInfoPtr__DriverDropdownOptions;
    private static readonly System.IntPtr NativeFieldInfoPtr__VoipInputDriverDropdownOptions;
    private static readonly System.IntPtr NativeFieldInfoPtr__VoipOutputDriverDropdownOptions;
    private static readonly System.IntPtr NativeFieldInfoPtr__DriverDropdown;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetMono_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDriverList_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasDriversChanged_Private_Boolean_List_1_Tuple_2_Guid_String_List_1_Tuple_2_Guid_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSoundDriverDropDown_Private_Options_Control_Dropdown_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDropdownOptions_Private_List_1_String_List_1_Tuple_2_Guid_String_List_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetVoipDropdownOptions_Private_List_1_String_List_1_Tuple_2_String_String_List_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddDropDown_Private_Options_Control_Dropdown_LocalizationKey_List_1_String_Int32_UnityAction_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetIndex_Private_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAvailableDrivers_Public_Boolean_List_1_Tuple_2_Guid_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentDriver_Public_Boolean_byref_Int32_byref_Guid_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddHeader_Private_Void_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddToggle_Private_Void_LocalizationKey_Func_1_Boolean_UnityAction_1_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddBusVolumeSlider_Private_Void_LocalizationKey_LocalizationKey_Guid_UnityAction_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddVcaVolumeSlider_Private_Void_LocalizationKey_LocalizationKey_Guid_UnityAction_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSlider_Private_Void_LocalizationKey_LocalizationKey_Single_Single_Func_1_Single_UnityAction_1_Single_Func_2_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSlider_Private_Void_LocalizationKey_LocalizationKey_Single_Single_Single_UnityAction_1_Single_Func_2_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_VolumeDisplayValueTransform_Private_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBusVolume_Private_Single_Guid_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBusVolume_Private_Void_Guid_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBusMute_Private_Boolean_Guid_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBusMute_Private_Void_Guid_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetVcaVolume_Private_Single_Guid_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetVcaVolume_Private_Void_Guid_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetVoiceVolume_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LogAllBanksAndBuses_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__43_0_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__43_1_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__43_2_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__43_3_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__43_4_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__43_5_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__43_6_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__43_7_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__43_8_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__43_9_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__43_10_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__43_11_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__43_12_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__43_13_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__43_14_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__43_15_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__43_16_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__43_19_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__43_20_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__43_21_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__43_22_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__AddSoundDriverDropDown_b__49_0_Private_Void_Int32_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163491, XrefRangeEnd = 1163756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetMono(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_SetMono_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1163806, RefRangeEnd = 1163808, XrefRangeStart = 1163756, XrefRangeEnd = 1163806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateDriverList()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_UpdateDriverList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1163841, RefRangeEnd = 1163842, XrefRangeStart = 1163808, XrefRangeEnd = 1163841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasDriversChanged(
      List<Il2CppSystem.Tuple<Il2CppSystem.Guid, string>> newDrivers,
      List<Il2CppSystem.Tuple<Il2CppSystem.Guid, string>> prevDrivers)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newDrivers);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prevDrivers);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_HasDriversChanged_Private_Boolean_List_1_Tuple_2_Guid_String_List_1_Tuple_2_Guid_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163842, XrefRangeEnd = 1163847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163847, XrefRangeEnd = 1163849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163849, XrefRangeEnd = 1163863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Options_Control_Dropdown AddSoundDriverDropDown(LocalizationKey textKey)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &textKey;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_AddSoundDriverDropDown_Private_Options_Control_Dropdown_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Options_Control_Dropdown) null : new Options_Control_Dropdown(pointer);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1163891, RefRangeEnd = 1163894, XrefRangeStart = 1163863, XrefRangeEnd = 1163891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<string> GetDropdownOptions(
      List<Il2CppSystem.Tuple<Il2CppSystem.Guid, string>> tuples,
      List<string> options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tuples);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_GetDropdownOptions_Private_List_1_String_List_1_Tuple_2_Guid_String_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1163922, RefRangeEnd = 1163924, XrefRangeStart = 1163894, XrefRangeEnd = 1163922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<string> GetVoipDropdownOptions(
      List<Il2CppSystem.Tuple<string, string>> tuples,
      List<string> options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tuples);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_GetVoipDropdownOptions_Private_List_1_String_List_1_Tuple_2_String_String_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1163928, RefRangeEnd = 1163930, XrefRangeStart = 1163924, XrefRangeEnd = 1163928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Options_Control_Dropdown AddDropDown(
      LocalizationKey textKey,
      List<string> options,
      int selectedIndex,
      UnityAction<int> onValueChanged)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &selectedIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChanged);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_AddDropDown_Private_Options_Control_Dropdown_LocalizationKey_List_1_String_Int32_UnityAction_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Options_Control_Dropdown) null : new Options_Control_Dropdown(pointer);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1163953, RefRangeEnd = 1163956, XrefRangeStart = 1163930, XrefRangeEnd = 1163953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetIndex()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_GetIndex_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163956, XrefRangeEnd = 1163972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetAvailableDrivers(List<Il2CppSystem.Tuple<Il2CppSystem.Guid, string>> drivers)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) drivers);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_TryGetAvailableDrivers_Public_Boolean_List_1_Tuple_2_Guid_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163972, XrefRangeEnd = 1163980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetCurrentDriver(out int index, out Il2CppSystem.Guid guid, out string name)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = (System.IntPtr) ref index;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref guid;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_GetCurrentDriver_Public_Boolean_byref_Int32_byref_Guid_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      name = IL2CPP.Il2CppStringToManaged(zero);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163980, XrefRangeEnd = 1163984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddHeader(LocalizationKey textKey)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &textKey;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_AddHeader_Private_Void_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_AddToggle_Private_Void_LocalizationKey_Func_1_Boolean_UnityAction_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1164021, RefRangeEnd = 1164022, XrefRangeStart = 1163984, XrefRangeEnd = 1164021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddBusVolumeSlider(
      LocalizationKey textKey,
      LocalizationKey valueKey,
      Il2CppSystem.Guid busGuid,
      UnityAction<float> applySetting)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &valueKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &busGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) applySetting);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_AddBusVolumeSlider_Private_Void_LocalizationKey_LocalizationKey_Guid_UnityAction_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1164059, RefRangeEnd = 1164065, XrefRangeStart = 1164022, XrefRangeEnd = 1164059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddVcaVolumeSlider(
      LocalizationKey textKey,
      LocalizationKey valueKey,
      Il2CppSystem.Guid vcaGuid,
      UnityAction<float> applySetting)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &valueKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &vcaGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) applySetting);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_AddVcaVolumeSlider_Private_Void_LocalizationKey_LocalizationKey_Guid_UnityAction_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164065, XrefRangeEnd = 1164072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddSlider(
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
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_AddSlider_Private_Void_LocalizationKey_LocalizationKey_Single_Single_Func_1_Single_UnityAction_1_Single_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164072, XrefRangeEnd = 1164076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_AddSlider_Private_Void_LocalizationKey_LocalizationKey_Single_Single_Single_UnityAction_1_Single_Func_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe float VolumeDisplayValueTransform(float volume)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &volume;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_VolumeDisplayValueTransform_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1164078, RefRangeEnd = 1164079, XrefRangeStart = 1164076, XrefRangeEnd = 1164078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetBusVolume(Il2CppSystem.Guid busGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &busGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_GetBusVolume_Private_Single_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1164081, RefRangeEnd = 1164082, XrefRangeStart = 1164079, XrefRangeEnd = 1164081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetBusVolume(Il2CppSystem.Guid busGuid, float newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &busGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_SetBusVolume_Private_Void_Guid_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164082, XrefRangeEnd = 1164084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetBusMute(Il2CppSystem.Guid busGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &busGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_GetBusMute_Private_Boolean_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1164097, RefRangeEnd = 1164099, XrefRangeStart = 1164084, XrefRangeEnd = 1164097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetBusMute(Il2CppSystem.Guid busGuid, bool mute)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &busGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mute;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_SetBusMute_Private_Void_Guid_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1164101, RefRangeEnd = 1164102, XrefRangeStart = 1164099, XrefRangeEnd = 1164101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetVcaVolume(Il2CppSystem.Guid vcaGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &vcaGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_GetVcaVolume_Private_Single_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1164104, RefRangeEnd = 1164105, XrefRangeStart = 1164102, XrefRangeEnd = 1164104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetVcaVolume(Il2CppSystem.Guid vcaGuid, float newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &vcaGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_SetVcaVolume_Private_Void_Guid_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void SetVoiceVolume(float newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_SetVoiceVolume_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164105, XrefRangeEnd = 1164131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LogAllBanksAndBuses()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr_LogAllBanksAndBuses_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164131, XrefRangeEnd = 1164173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OptionsPanel_Sound()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164173, XrefRangeEnd = 1164179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Start_b__43_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164179, XrefRangeEnd = 1164184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__43_1(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_1_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164184, XrefRangeEnd = 1164190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Start_b__43_2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_2_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164190, XrefRangeEnd = 1164195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__43_3(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_3_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__43_4()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_4_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__43_5(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_5_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__43_6()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_6_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__43_7(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_7_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__43_8(float v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_8_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__43_9(float v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_9_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__43_10(float v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_10_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__43_11(float v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_11_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__43_12(float v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_12_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__43_13(float v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_13_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__43_14(float v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_14_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__43_15()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_15_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__43_16(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_16_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Start_b__43_19()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_19_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe void _Start_b__43_20(bool v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &v;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_20_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164195, XrefRangeEnd = 1164204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__43_21(int newIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_21_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164204, XrefRangeEnd = 1164213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__43_22(int newIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_22_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164213, XrefRangeEnd = 1164226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _AddSoundDriverDropDown_b__49_0(int newIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.NativeMethodInfoPtr__AddSoundDriverDropDown_b__49_0_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static OptionsPanel_Sound()
    {
      Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (OptionsPanel_Sound));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr);
      OptionsPanel_Sound.NativeFieldInfoPtr_ContentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (ContentNode));
      OptionsPanel_Sound.NativeFieldInfoPtr_CheckboxPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (CheckboxPrefab));
      OptionsPanel_Sound.NativeFieldInfoPtr_SliderPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (SliderPrefab));
      OptionsPanel_Sound.NativeFieldInfoPtr_DropdownPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (DropdownPrefab));
      OptionsPanel_Sound.NativeFieldInfoPtr_CategoryHeaderPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (CategoryHeaderPrefab));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_AudioSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_AudioSettings));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_DisableAllSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_DisableAllSounds));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_DisableMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_DisableMusic));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_MonoSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_MonoSound));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_SoundInBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_SoundInBackground));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_Volume));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_Master));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_Effects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_Effects));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_Music = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_Music));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_Ambience = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_Ambience));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_PlayerVoiceLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_PlayerVoiceLines));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_VoiceLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_VoiceLines));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_UIEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_UIEffects));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_Misc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_Misc));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_Soundcard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_Soundcard));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_VoiceSoundcard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_VoiceSoundcard));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_VoiceMicSoundcard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_VoiceMicSoundcard));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_VOIPEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_VOIPEffects));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_PushToTalk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_PushToTalk));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_Autojoin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_Autojoin));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_Connected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_Connected));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_VoiceChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_VoiceChat));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_VolumeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_VolumeValue));
      OptionsPanel_Sound.NativeFieldInfoPtr_LK_DefaultSoundCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (LK_DefaultSoundCard));
      OptionsPanel_Sound.NativeFieldInfoPtr__StudioManagerSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (_StudioManagerSystem));
      OptionsPanel_Sound.NativeFieldInfoPtr__StudioManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (_StudioManager));
      OptionsPanel_Sound.NativeFieldInfoPtr__StudioSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (_StudioSystem));
      OptionsPanel_Sound.NativeFieldInfoPtr__CoreSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (_CoreSystem));
      OptionsPanel_Sound.NativeFieldInfoPtr__ClientSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (_ClientSettings));
      OptionsPanel_Sound.NativeFieldInfoPtr__Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (_Settings));
      OptionsPanel_Sound.NativeFieldInfoPtr__Drivers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (_Drivers));
      OptionsPanel_Sound.NativeFieldInfoPtr__DriversTmp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (_DriversTmp));
      OptionsPanel_Sound.NativeFieldInfoPtr__VoipInputDrivers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (_VoipInputDrivers));
      OptionsPanel_Sound.NativeFieldInfoPtr__VoipOutputDrivers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (_VoipOutputDrivers));
      OptionsPanel_Sound.NativeFieldInfoPtr__DriverDropdownOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (_DriverDropdownOptions));
      OptionsPanel_Sound.NativeFieldInfoPtr__VoipInputDriverDropdownOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (_VoipInputDriverDropdownOptions));
      OptionsPanel_Sound.NativeFieldInfoPtr__VoipOutputDriverDropdownOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (_VoipOutputDriverDropdownOptions));
      OptionsPanel_Sound.NativeFieldInfoPtr__DriverDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, nameof (_DriverDropdown));
      OptionsPanel_Sound.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692528);
      OptionsPanel_Sound.NativeMethodInfoPtr_SetMono_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692529);
      OptionsPanel_Sound.NativeMethodInfoPtr_UpdateDriverList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692530);
      OptionsPanel_Sound.NativeMethodInfoPtr_HasDriversChanged_Private_Boolean_List_1_Tuple_2_Guid_String_List_1_Tuple_2_Guid_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692531);
      OptionsPanel_Sound.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692532);
      OptionsPanel_Sound.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692533);
      OptionsPanel_Sound.NativeMethodInfoPtr_AddSoundDriverDropDown_Private_Options_Control_Dropdown_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692534);
      OptionsPanel_Sound.NativeMethodInfoPtr_GetDropdownOptions_Private_List_1_String_List_1_Tuple_2_Guid_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692535);
      OptionsPanel_Sound.NativeMethodInfoPtr_GetVoipDropdownOptions_Private_List_1_String_List_1_Tuple_2_String_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692536);
      OptionsPanel_Sound.NativeMethodInfoPtr_AddDropDown_Private_Options_Control_Dropdown_LocalizationKey_List_1_String_Int32_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692537);
      OptionsPanel_Sound.NativeMethodInfoPtr_GetIndex_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692538);
      OptionsPanel_Sound.NativeMethodInfoPtr_TryGetAvailableDrivers_Public_Boolean_List_1_Tuple_2_Guid_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692539);
      OptionsPanel_Sound.NativeMethodInfoPtr_GetCurrentDriver_Public_Boolean_byref_Int32_byref_Guid_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692540);
      OptionsPanel_Sound.NativeMethodInfoPtr_AddHeader_Private_Void_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692541);
      OptionsPanel_Sound.NativeMethodInfoPtr_AddToggle_Private_Void_LocalizationKey_Func_1_Boolean_UnityAction_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692542);
      OptionsPanel_Sound.NativeMethodInfoPtr_AddBusVolumeSlider_Private_Void_LocalizationKey_LocalizationKey_Guid_UnityAction_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692543);
      OptionsPanel_Sound.NativeMethodInfoPtr_AddVcaVolumeSlider_Private_Void_LocalizationKey_LocalizationKey_Guid_UnityAction_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692544);
      OptionsPanel_Sound.NativeMethodInfoPtr_AddSlider_Private_Void_LocalizationKey_LocalizationKey_Single_Single_Func_1_Single_UnityAction_1_Single_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692545);
      OptionsPanel_Sound.NativeMethodInfoPtr_AddSlider_Private_Void_LocalizationKey_LocalizationKey_Single_Single_Single_UnityAction_1_Single_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692546);
      OptionsPanel_Sound.NativeMethodInfoPtr_VolumeDisplayValueTransform_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692547);
      OptionsPanel_Sound.NativeMethodInfoPtr_GetBusVolume_Private_Single_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692548);
      OptionsPanel_Sound.NativeMethodInfoPtr_SetBusVolume_Private_Void_Guid_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692549);
      OptionsPanel_Sound.NativeMethodInfoPtr_GetBusMute_Private_Boolean_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692550);
      OptionsPanel_Sound.NativeMethodInfoPtr_SetBusMute_Private_Void_Guid_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692551);
      OptionsPanel_Sound.NativeMethodInfoPtr_GetVcaVolume_Private_Single_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692552);
      OptionsPanel_Sound.NativeMethodInfoPtr_SetVcaVolume_Private_Void_Guid_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692553);
      OptionsPanel_Sound.NativeMethodInfoPtr_SetVoiceVolume_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692554);
      OptionsPanel_Sound.NativeMethodInfoPtr_LogAllBanksAndBuses_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692555);
      OptionsPanel_Sound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692556);
      OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692557);
      OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_1_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692558);
      OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_2_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692559);
      OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_3_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692560);
      OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_4_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692561);
      OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_5_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692562);
      OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_6_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692563);
      OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_7_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692564);
      OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_8_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692565);
      OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_9_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692566);
      OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_10_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692567);
      OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_11_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692568);
      OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_12_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692569);
      OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_13_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692570);
      OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_14_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692571);
      OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_15_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692572);
      OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_16_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692573);
      OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_19_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692574);
      OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_20_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692575);
      OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_21_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692576);
      OptionsPanel_Sound.NativeMethodInfoPtr__Start_b__43_22_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692577);
      OptionsPanel_Sound.NativeMethodInfoPtr__AddSoundDriverDropDown_b__49_0_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, 100692578);
    }

    public OptionsPanel_Sound(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe RectTransform ContentNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_ContentNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_ContentNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Options_Control_Checkbox CheckboxPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_CheckboxPrefab));
        return pointer == System.IntPtr.Zero ? (Options_Control_Checkbox) null : new Options_Control_Checkbox(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_CheckboxPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Options_Control_Slider SliderPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_SliderPrefab));
        return pointer == System.IntPtr.Zero ? (Options_Control_Slider) null : new Options_Control_Slider(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_SliderPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Options_Control_Dropdown DropdownPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_DropdownPrefab));
        return pointer == System.IntPtr.Zero ? (Options_Control_Dropdown) null : new Options_Control_Dropdown(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_DropdownPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe OptionsCategoryHeader CategoryHeaderPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_CategoryHeaderPrefab));
        return pointer == System.IntPtr.Zero ? (OptionsCategoryHeader) null : new OptionsCategoryHeader(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_CategoryHeaderPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LK_AudioSettings
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_AudioSettings));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_AudioSettings)) = value;
      }
    }

    public unsafe LocalizationKey LK_DisableAllSounds
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_DisableAllSounds));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_DisableAllSounds)) = value;
      }
    }

    public unsafe LocalizationKey LK_DisableMusic
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_DisableMusic));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_DisableMusic)) = value;
      }
    }

    public unsafe LocalizationKey LK_MonoSound
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_MonoSound));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_MonoSound)) = value;
      }
    }

    public unsafe LocalizationKey LK_SoundInBackground
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_SoundInBackground));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_SoundInBackground)) = value;
      }
    }

    public unsafe LocalizationKey LK_Volume
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_Volume));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_Volume)) = value;
      }
    }

    public unsafe LocalizationKey LK_Master
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_Master));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_Master)) = value;
      }
    }

    public unsafe LocalizationKey LK_Effects
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_Effects));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_Effects)) = value;
      }
    }

    public unsafe LocalizationKey LK_Music
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_Music));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_Music)) = value;
      }
    }

    public unsafe LocalizationKey LK_Ambience
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_Ambience));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_Ambience)) = value;
      }
    }

    public unsafe LocalizationKey LK_PlayerVoiceLines
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_PlayerVoiceLines));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_PlayerVoiceLines)) = value;
      }
    }

    public unsafe LocalizationKey LK_VoiceLines
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_VoiceLines));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_VoiceLines)) = value;
      }
    }

    public unsafe LocalizationKey LK_UIEffects
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_UIEffects));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_UIEffects)) = value;
      }
    }

    public unsafe LocalizationKey LK_Misc
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_Misc));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_Misc)) = value;
      }
    }

    public unsafe LocalizationKey LK_Soundcard
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_Soundcard));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_Soundcard)) = value;
      }
    }

    public unsafe LocalizationKey LK_VoiceSoundcard
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_VoiceSoundcard));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_VoiceSoundcard)) = value;
      }
    }

    public unsafe LocalizationKey LK_VoiceMicSoundcard
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_VoiceMicSoundcard));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_VoiceMicSoundcard)) = value;
      }
    }

    public unsafe LocalizationKey LK_VOIPEffects
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_VOIPEffects));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_VOIPEffects)) = value;
      }
    }

    public unsafe LocalizationKey LK_PushToTalk
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_PushToTalk));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_PushToTalk)) = value;
      }
    }

    public unsafe LocalizationKey LK_Autojoin
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_Autojoin));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_Autojoin)) = value;
      }
    }

    public unsafe LocalizationKey LK_Connected
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_Connected));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_Connected)) = value;
      }
    }

    public unsafe LocalizationKey LK_VoiceChat
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_VoiceChat));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_VoiceChat)) = value;
      }
    }

    public unsafe LocalizationKey LK_VolumeValue
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_VolumeValue));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_VolumeValue)) = value;
      }
    }

    public unsafe LocalizationKey LK_DefaultSoundCard
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_DefaultSoundCard));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr_LK_DefaultSoundCard)) = value;
      }
    }

    public unsafe StudioManagerSystem _StudioManagerSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__StudioManagerSystem));
        return pointer == System.IntPtr.Zero ? (StudioManagerSystem) null : new StudioManagerSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__StudioManagerSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StudioManager _StudioManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__StudioManager));
        return pointer == System.IntPtr.Zero ? (StudioManager) null : new StudioManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__StudioManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FMOD.Studio.System _StudioSystem
    {
      get
      {
        return *(FMOD.Studio.System*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__StudioSystem));
      }
      [param: In] set
      {
        *(FMOD.Studio.System*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__StudioSystem)) = value;
      }
    }

    public unsafe FMOD.System _CoreSystem
    {
      get
      {
        return *(FMOD.System*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__CoreSystem));
      }
      [param: In] set
      {
        *(FMOD.System*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__CoreSystem)) = value;
      }
    }

    public unsafe ClientSettings _ClientSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__ClientSettings));
        return pointer == System.IntPtr.Zero ? (ClientSettings) null : new ClientSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__ClientSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SoundSettings _Settings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__Settings));
        return pointer == System.IntPtr.Zero ? (SoundSettings) null : new SoundSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__Settings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<Il2CppSystem.Tuple<Il2CppSystem.Guid, string>> _Drivers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__Drivers));
        return pointer == System.IntPtr.Zero ? (List<Il2CppSystem.Tuple<Il2CppSystem.Guid, string>>) null : new List<Il2CppSystem.Tuple<Il2CppSystem.Guid, string>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__Drivers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<Il2CppSystem.Tuple<Il2CppSystem.Guid, string>> _DriversTmp
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__DriversTmp));
        return pointer == System.IntPtr.Zero ? (List<Il2CppSystem.Tuple<Il2CppSystem.Guid, string>>) null : new List<Il2CppSystem.Tuple<Il2CppSystem.Guid, string>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__DriversTmp), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<Il2CppSystem.Tuple<string, string>> _VoipInputDrivers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__VoipInputDrivers));
        return pointer == System.IntPtr.Zero ? (List<Il2CppSystem.Tuple<string, string>>) null : new List<Il2CppSystem.Tuple<string, string>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__VoipInputDrivers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<Il2CppSystem.Tuple<string, string>> _VoipOutputDrivers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__VoipOutputDrivers));
        return pointer == System.IntPtr.Zero ? (List<Il2CppSystem.Tuple<string, string>>) null : new List<Il2CppSystem.Tuple<string, string>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__VoipOutputDrivers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<string> _DriverDropdownOptions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__DriverDropdownOptions));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__DriverDropdownOptions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<string> _VoipInputDriverDropdownOptions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__VoipInputDriverDropdownOptions));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__VoipInputDriverDropdownOptions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<string> _VoipOutputDriverDropdownOptions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__VoipOutputDriverDropdownOptions));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__VoipOutputDriverDropdownOptions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Options_Control_Dropdown _DriverDropdown
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__DriverDropdown));
        return pointer == System.IntPtr.Zero ? (Options_Control_Dropdown) null : new Options_Control_Dropdown(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.NativeFieldInfoPtr__DriverDropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.UI.OptionsPanel_Sound/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__43_17;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__43_18;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__43_17_Internal_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__43_18_Internal_Void_Boolean_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsPanel_Sound.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163473, XrefRangeEnd = 1163477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _Start_b__43_17()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.__c.NativeMethodInfoPtr__Start_b__43_17_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163477, XrefRangeEnd = 1163481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Start_b__43_18(bool v)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &v;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.__c.NativeMethodInfoPtr__Start_b__43_18_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<OptionsPanel_Sound.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Sound.__c>.NativeClassPtr);
        OptionsPanel_Sound.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound.__c>.NativeClassPtr, "<>9");
        OptionsPanel_Sound.__c.NativeFieldInfoPtr___9__43_17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound.__c>.NativeClassPtr, "<>9__43_17");
        OptionsPanel_Sound.__c.NativeFieldInfoPtr___9__43_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound.__c>.NativeClassPtr, "<>9__43_18");
        OptionsPanel_Sound.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound.__c>.NativeClassPtr, 100692580);
        OptionsPanel_Sound.__c.NativeMethodInfoPtr__Start_b__43_17_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound.__c>.NativeClassPtr, 100692581);
        OptionsPanel_Sound.__c.NativeMethodInfoPtr__Start_b__43_18_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound.__c>.NativeClassPtr, 100692582);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe OptionsPanel_Sound.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(OptionsPanel_Sound.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (OptionsPanel_Sound.__c) null : new OptionsPanel_Sound.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(OptionsPanel_Sound.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<bool> __9__43_17
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(OptionsPanel_Sound.__c.NativeFieldInfoPtr___9__43_17, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<bool>) null : new Il2CppSystem.Func<bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(OptionsPanel_Sound.__c.NativeFieldInfoPtr___9__43_17, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe UnityAction<bool> __9__43_18
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(OptionsPanel_Sound.__c.NativeFieldInfoPtr___9__43_18, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (UnityAction<bool>) null : new UnityAction<bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(OptionsPanel_Sound.__c.NativeFieldInfoPtr___9__43_18, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.OptionsPanel_Sound/<>c__DisplayClass58_0")]
    public sealed class __c__DisplayClass58_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_busGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_applySetting;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddBusVolumeSlider_b__0_Internal_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddBusVolumeSlider_b__1_Internal_Void_Single_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass58_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsPanel_Sound.__c__DisplayClass58_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163481, XrefRangeEnd = 1163482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe float _AddBusVolumeSlider_b__0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.__c__DisplayClass58_0.NativeMethodInfoPtr__AddBusVolumeSlider_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163482, XrefRangeEnd = 1163486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AddBusVolumeSlider_b__1(float vol)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &vol;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.__c__DisplayClass58_0.NativeMethodInfoPtr__AddBusVolumeSlider_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass58_0()
      {
        Il2CppClassPointerStore<OptionsPanel_Sound.__c__DisplayClass58_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, "<>c__DisplayClass58_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Sound.__c__DisplayClass58_0>.NativeClassPtr);
        OptionsPanel_Sound.__c__DisplayClass58_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound.__c__DisplayClass58_0>.NativeClassPtr, "<>4__this");
        OptionsPanel_Sound.__c__DisplayClass58_0.NativeFieldInfoPtr_busGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound.__c__DisplayClass58_0>.NativeClassPtr, nameof (busGuid));
        OptionsPanel_Sound.__c__DisplayClass58_0.NativeFieldInfoPtr_applySetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound.__c__DisplayClass58_0>.NativeClassPtr, nameof (applySetting));
        OptionsPanel_Sound.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound.__c__DisplayClass58_0>.NativeClassPtr, 100692583);
        OptionsPanel_Sound.__c__DisplayClass58_0.NativeMethodInfoPtr__AddBusVolumeSlider_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound.__c__DisplayClass58_0>.NativeClassPtr, 100692584);
        OptionsPanel_Sound.__c__DisplayClass58_0.NativeMethodInfoPtr__AddBusVolumeSlider_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound.__c__DisplayClass58_0>.NativeClassPtr, 100692585);
      }

      public __c__DisplayClass58_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe OptionsPanel_Sound __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.__c__DisplayClass58_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (OptionsPanel_Sound) null : new OptionsPanel_Sound(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.__c__DisplayClass58_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Guid busGuid
      {
        get
        {
          return *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.__c__DisplayClass58_0.NativeFieldInfoPtr_busGuid));
        }
        [param: In] set
        {
          *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.__c__DisplayClass58_0.NativeFieldInfoPtr_busGuid)) = value;
        }
      }

      public unsafe UnityAction<float> applySetting
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.__c__DisplayClass58_0.NativeFieldInfoPtr_applySetting));
          return pointer == System.IntPtr.Zero ? (UnityAction<float>) null : new UnityAction<float>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.__c__DisplayClass58_0.NativeFieldInfoPtr_applySetting), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.OptionsPanel_Sound/<>c__DisplayClass59_0")]
    public sealed class __c__DisplayClass59_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_vcaGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_applySetting;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddVcaVolumeSlider_b__0_Internal_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddVcaVolumeSlider_b__1_Internal_Void_Single_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass59_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsPanel_Sound.__c__DisplayClass59_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163486, XrefRangeEnd = 1163487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe float _AddVcaVolumeSlider_b__0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.__c__DisplayClass59_0.NativeMethodInfoPtr__AddVcaVolumeSlider_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163487, XrefRangeEnd = 1163491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AddVcaVolumeSlider_b__1(float vol)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &vol;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OptionsPanel_Sound.__c__DisplayClass59_0.NativeMethodInfoPtr__AddVcaVolumeSlider_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass59_0()
      {
        Il2CppClassPointerStore<OptionsPanel_Sound.__c__DisplayClass59_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsPanel_Sound>.NativeClassPtr, "<>c__DisplayClass59_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsPanel_Sound.__c__DisplayClass59_0>.NativeClassPtr);
        OptionsPanel_Sound.__c__DisplayClass59_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound.__c__DisplayClass59_0>.NativeClassPtr, "<>4__this");
        OptionsPanel_Sound.__c__DisplayClass59_0.NativeFieldInfoPtr_vcaGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound.__c__DisplayClass59_0>.NativeClassPtr, nameof (vcaGuid));
        OptionsPanel_Sound.__c__DisplayClass59_0.NativeFieldInfoPtr_applySetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsPanel_Sound.__c__DisplayClass59_0>.NativeClassPtr, nameof (applySetting));
        OptionsPanel_Sound.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound.__c__DisplayClass59_0>.NativeClassPtr, 100692586);
        OptionsPanel_Sound.__c__DisplayClass59_0.NativeMethodInfoPtr__AddVcaVolumeSlider_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound.__c__DisplayClass59_0>.NativeClassPtr, 100692587);
        OptionsPanel_Sound.__c__DisplayClass59_0.NativeMethodInfoPtr__AddVcaVolumeSlider_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsPanel_Sound.__c__DisplayClass59_0>.NativeClassPtr, 100692588);
      }

      public __c__DisplayClass59_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe OptionsPanel_Sound __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.__c__DisplayClass59_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (OptionsPanel_Sound) null : new OptionsPanel_Sound(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.__c__DisplayClass59_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Guid vcaGuid
      {
        get
        {
          return *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.__c__DisplayClass59_0.NativeFieldInfoPtr_vcaGuid));
        }
        [param: In] set
        {
          *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.__c__DisplayClass59_0.NativeFieldInfoPtr_vcaGuid)) = value;
        }
      }

      public unsafe UnityAction<float> applySetting
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.__c__DisplayClass59_0.NativeFieldInfoPtr_applySetting));
          return pointer == System.IntPtr.Zero ? (UnityAction<float>) null : new UnityAction<float>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OptionsPanel_Sound.__c__DisplayClass59_0.NativeFieldInfoPtr_applySetting), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
