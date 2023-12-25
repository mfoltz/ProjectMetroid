// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.OptionsHelper
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace ProjectM.UI
{
  public static class OptionsHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_AddHeader_Public_Static_OptionsCategoryHeader_RectTransform_OptionsCategoryHeader_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddToggle_Public_Static_Options_Control_Checkbox_RectTransform_Options_Control_Checkbox_LocalizationKey_Func_1_Boolean_UnityAction_1_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddToggle_Public_Static_Options_Control_Checkbox_RectTransform_Options_Control_Checkbox_LocalizationKey_Boolean_UnityAction_1_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSlider_Public_Static_Void_RectTransform_Options_Control_Slider_LocalizationKey_LocalizationKey_Single_Single_Func_1_Single_UnityAction_1_Single_Func_2_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSlider_Public_Static_Void_RectTransform_Options_Control_Slider_LocalizationKey_LocalizationKey_Single_Single_Single_UnityAction_1_Single_Func_2_Single_Single_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161536, XrefRangeEnd = 1161540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe OptionsCategoryHeader AddHeader(
      RectTransform node,
      OptionsCategoryHeader headerPrefab,
      LocalizationKey localizationKey)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) headerPrefab);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &localizationKey;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsHelper.NativeMethodInfoPtr_AddHeader_Public_Static_OptionsCategoryHeader_RectTransform_OptionsCategoryHeader_LocalizationKey_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (OptionsCategoryHeader) null : new OptionsCategoryHeader(pointer);
    }

    [CallerCount(32)]
    [CachedScanResults(RefRangeStart = 1161561, RefRangeEnd = 1161593, XrefRangeStart = 1161540, XrefRangeEnd = 1161561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Options_Control_Checkbox AddToggle(
      RectTransform node,
      Options_Control_Checkbox checkboxPrefab,
      LocalizationKey textKey,
      Il2CppSystem.Func<bool> initValueFunc,
      UnityAction<bool> onValueChange)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkboxPrefab);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) initValueFunc);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsHelper.NativeMethodInfoPtr_AddToggle_Public_Static_Options_Control_Checkbox_RectTransform_Options_Control_Checkbox_LocalizationKey_Func_1_Boolean_UnityAction_1_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Options_Control_Checkbox) null : new Options_Control_Checkbox(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161593, XrefRangeEnd = 1161611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Options_Control_Checkbox AddToggle(
      RectTransform node,
      Options_Control_Checkbox checkboxPrefab,
      LocalizationKey textKey,
      bool initValue,
      UnityAction<bool> onValueChange)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkboxPrefab);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &initValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OptionsHelper.NativeMethodInfoPtr_AddToggle_Public_Static_Options_Control_Checkbox_RectTransform_Options_Control_Checkbox_LocalizationKey_Boolean_UnityAction_1_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Options_Control_Checkbox) null : new Options_Control_Checkbox(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161611, XrefRangeEnd = 1161618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddSlider(
      RectTransform node,
      Options_Control_Slider sliderPrefab,
      LocalizationKey textKey,
      LocalizationKey valueKey,
      float minValue,
      float maxValue,
      Il2CppSystem.Func<float> initValueFunc,
      UnityAction<float> onValueChange,
      Il2CppSystem.Func<float, float> displayValueTransformer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sliderPrefab);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &valueKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &minValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &maxValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) initValueFunc);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayValueTransformer);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsHelper.NativeMethodInfoPtr_AddSlider_Public_Static_Void_RectTransform_Options_Control_Slider_LocalizationKey_LocalizationKey_Single_Single_Func_1_Single_UnityAction_1_Single_Func_2_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161618, XrefRangeEnd = 1161622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddSlider(
      RectTransform node,
      Options_Control_Slider sliderPrefab,
      LocalizationKey textKey,
      LocalizationKey valueKey,
      float minValue,
      float maxValue,
      float initValue,
      UnityAction<float> onValueChange,
      Il2CppSystem.Func<float, float> displayValueTransformer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sliderPrefab);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &valueKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &minValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &maxValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &initValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) displayValueTransformer);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OptionsHelper.NativeMethodInfoPtr_AddSlider_Public_Static_Void_RectTransform_Options_Control_Slider_LocalizationKey_LocalizationKey_Single_Single_Single_UnityAction_1_Single_Func_2_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static OptionsHelper()
    {
      Il2CppClassPointerStore<OptionsHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (OptionsHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsHelper>.NativeClassPtr);
      OptionsHelper.NativeMethodInfoPtr_AddHeader_Public_Static_OptionsCategoryHeader_RectTransform_OptionsCategoryHeader_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsHelper>.NativeClassPtr, 100692385);
      OptionsHelper.NativeMethodInfoPtr_AddToggle_Public_Static_Options_Control_Checkbox_RectTransform_Options_Control_Checkbox_LocalizationKey_Func_1_Boolean_UnityAction_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsHelper>.NativeClassPtr, 100692386);
      OptionsHelper.NativeMethodInfoPtr_AddToggle_Public_Static_Options_Control_Checkbox_RectTransform_Options_Control_Checkbox_LocalizationKey_Boolean_UnityAction_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsHelper>.NativeClassPtr, 100692387);
      OptionsHelper.NativeMethodInfoPtr_AddSlider_Public_Static_Void_RectTransform_Options_Control_Slider_LocalizationKey_LocalizationKey_Single_Single_Func_1_Single_UnityAction_1_Single_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsHelper>.NativeClassPtr, 100692388);
      OptionsHelper.NativeMethodInfoPtr_AddSlider_Public_Static_Void_RectTransform_Options_Control_Slider_LocalizationKey_LocalizationKey_Single_Single_Single_UnityAction_1_Single_Func_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsHelper>.NativeClassPtr, 100692389);
    }

    public OptionsHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
