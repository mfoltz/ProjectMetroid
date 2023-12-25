// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.DebugMenuItem
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class DebugMenuItem : UIEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MainTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputFieldSection;
    private static readonly System.IntPtr NativeFieldInfoPtr_ButtonSection;
    private static readonly System.IntPtr NativeFieldInfoPtr_SliderSection;
    private static readonly System.IntPtr NativeFieldInfoPtr_CheckBoxSection;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeaderSection;
    private static readonly System.IntPtr NativeFieldInfoPtr_SharedItemTitleText;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputField;
    private static readonly System.IntPtr NativeFieldInfoPtr_Button;
    private static readonly System.IntPtr NativeFieldInfoPtr_ButtonText;
    private static readonly System.IntPtr NativeFieldInfoPtr_Slider;
    private static readonly System.IntPtr NativeFieldInfoPtr_CheckBox;
    private static readonly System.IntPtr NativeFieldInfoPtr_CheckBoxText;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeaderText;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitInputField_Public_Void_String_UnityAction_1_String_Func_1_String_ContentType_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitButton_Public_Void_String_UnityAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitButton_Public_Void_String_String_UnityAction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitSlider_Public_Void_String_Single_Single_Single_UnityAction_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitCheckBox_Public_Void_String_String_UnityAction_1_Boolean_Func_1_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitCheckBox_Public_Void_String_UnityAction_1_Boolean_Func_1_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitSpacing_Public_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitHeader_Public_Void_String_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableAllSections_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ActivateSection_Private_Void_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetHeight_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultHeight_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableSharedItemTitle_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetItemTitleText_Private_Void_String_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuItem.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259807, XrefRangeEnd = 1259812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuItem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1259837, RefRangeEnd = 1259838, XrefRangeStart = 1259812, XrefRangeEnd = 1259837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitInputField(
      string headerText,
      UnityAction<string> onInputSubmitted,
      Il2CppSystem.Func<string> initialValueFunc = null,
      TMP_InputField.ContentType contentType = TMP_InputField.ContentType.Standard,
      string placeholderText = "")
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(headerText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onInputSubmitted);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) initialValueFunc);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &contentType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(placeholderText);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuItem.NativeMethodInfoPtr_InitInputField_Public_Void_String_UnityAction_1_String_Func_1_String_ContentType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259838, XrefRangeEnd = 1259849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitButton(string buttonText, UnityAction onButtonClick)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(buttonText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onButtonClick);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuItem.NativeMethodInfoPtr_InitButton_Public_Void_String_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259849, XrefRangeEnd = 1259861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitButton(string headerText, string buttonText, UnityAction onButtonClick)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(headerText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(buttonText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onButtonClick);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuItem.NativeMethodInfoPtr_InitButton_Public_Void_String_String_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1259877, RefRangeEnd = 1259878, XrefRangeStart = 1259861, XrefRangeEnd = 1259877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitSlider(
      string headerText,
      float minValue,
      float maxValue,
      float initialValue,
      UnityAction<float> onValueChanged)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(headerText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &minValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &initialValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChanged);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuItem.NativeMethodInfoPtr_InitSlider_Public_Void_String_Single_Single_Single_UnityAction_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1259895, RefRangeEnd = 1259896, XrefRangeStart = 1259878, XrefRangeEnd = 1259895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitCheckBox(
      string headerText,
      string checkBoxText,
      UnityAction<bool> onValueChanged,
      Il2CppSystem.Func<bool> getInitialValue = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(headerText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(checkBoxText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChanged);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getInitialValue);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuItem.NativeMethodInfoPtr_InitCheckBox_Public_Void_String_String_UnityAction_1_Boolean_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1259914, RefRangeEnd = 1259915, XrefRangeStart = 1259896, XrefRangeEnd = 1259914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitCheckBox(
      string checkBoxText,
      UnityAction<bool> onValueChanged,
      Il2CppSystem.Func<bool> getInitialValue = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(checkBoxText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChanged);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) getInitialValue);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuItem.NativeMethodInfoPtr_InitCheckBox_Public_Void_String_UnityAction_1_Boolean_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259915, XrefRangeEnd = 1259920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitSpacing(float height)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &height;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuItem.NativeMethodInfoPtr_InitSpacing_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259920, XrefRangeEnd = 1259927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitHeader(string text, float fontSize, float marginBottom = 0.0f)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fontSize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &marginBottom;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuItem.NativeMethodInfoPtr_InitHeader_Public_Void_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 1259933, RefRangeEnd = 1259942, XrefRangeStart = 1259927, XrefRangeEnd = 1259933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableAllSections()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuItem.NativeMethodInfoPtr_DisableAllSections_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259942, XrefRangeEnd = 1259945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ActivateSection(GameObject section)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) section);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuItem.NativeMethodInfoPtr_ActivateSection_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1259948, RefRangeEnd = 1259950, XrefRangeStart = 1259945, XrefRangeEnd = 1259948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetHeight(float height)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &height;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuItem.NativeMethodInfoPtr_SetHeight_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259950, XrefRangeEnd = 1259953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetDefaultHeight()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuItem.NativeMethodInfoPtr_SetDefaultHeight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259953, XrefRangeEnd = 1259956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableSharedItemTitle()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuItem.NativeMethodInfoPtr_DisableSharedItemTitle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259956, XrefRangeEnd = 1259960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetItemTitleText(string text, float fontSize = 18f)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fontSize;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuItem.NativeMethodInfoPtr_SetItemTitleText_Private_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DebugMenuItem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugMenuItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DebugMenuItem()
    {
      Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (DebugMenuItem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr);
      DebugMenuItem.NativeFieldInfoPtr_MainTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, nameof (MainTransform));
      DebugMenuItem.NativeFieldInfoPtr_InputFieldSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, nameof (InputFieldSection));
      DebugMenuItem.NativeFieldInfoPtr_ButtonSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, nameof (ButtonSection));
      DebugMenuItem.NativeFieldInfoPtr_SliderSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, nameof (SliderSection));
      DebugMenuItem.NativeFieldInfoPtr_CheckBoxSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, nameof (CheckBoxSection));
      DebugMenuItem.NativeFieldInfoPtr_HeaderSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, nameof (HeaderSection));
      DebugMenuItem.NativeFieldInfoPtr_SharedItemTitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, nameof (SharedItemTitleText));
      DebugMenuItem.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, nameof (InputField));
      DebugMenuItem.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, nameof (Button));
      DebugMenuItem.NativeFieldInfoPtr_ButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, nameof (ButtonText));
      DebugMenuItem.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, nameof (Slider));
      DebugMenuItem.NativeFieldInfoPtr_CheckBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, nameof (CheckBox));
      DebugMenuItem.NativeFieldInfoPtr_CheckBoxText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, nameof (CheckBoxText));
      DebugMenuItem.NativeFieldInfoPtr_HeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, nameof (HeaderText));
      DebugMenuItem.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, 100667171);
      DebugMenuItem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, 100667172);
      DebugMenuItem.NativeMethodInfoPtr_InitInputField_Public_Void_String_UnityAction_1_String_Func_1_String_ContentType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, 100667173);
      DebugMenuItem.NativeMethodInfoPtr_InitButton_Public_Void_String_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, 100667174);
      DebugMenuItem.NativeMethodInfoPtr_InitButton_Public_Void_String_String_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, 100667175);
      DebugMenuItem.NativeMethodInfoPtr_InitSlider_Public_Void_String_Single_Single_Single_UnityAction_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, 100667176);
      DebugMenuItem.NativeMethodInfoPtr_InitCheckBox_Public_Void_String_String_UnityAction_1_Boolean_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, 100667177);
      DebugMenuItem.NativeMethodInfoPtr_InitCheckBox_Public_Void_String_UnityAction_1_Boolean_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, 100667178);
      DebugMenuItem.NativeMethodInfoPtr_InitSpacing_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, 100667179);
      DebugMenuItem.NativeMethodInfoPtr_InitHeader_Public_Void_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, 100667180);
      DebugMenuItem.NativeMethodInfoPtr_DisableAllSections_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, 100667181);
      DebugMenuItem.NativeMethodInfoPtr_ActivateSection_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, 100667182);
      DebugMenuItem.NativeMethodInfoPtr_SetHeight_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, 100667183);
      DebugMenuItem.NativeMethodInfoPtr_SetDefaultHeight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, 100667184);
      DebugMenuItem.NativeMethodInfoPtr_DisableSharedItemTitle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, 100667185);
      DebugMenuItem.NativeMethodInfoPtr_SetItemTitleText_Private_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, 100667186);
      DebugMenuItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenuItem>.NativeClassPtr, 100667187);
    }

    public DebugMenuItem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe RectTransform MainTransform
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_MainTransform));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_MainTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject InputFieldSection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_InputFieldSection));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_InputFieldSection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject ButtonSection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_ButtonSection));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_ButtonSection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject SliderSection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_SliderSection));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_SliderSection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject CheckBoxSection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_CheckBoxSection));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_CheckBoxSection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject HeaderSection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_HeaderSection));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_HeaderSection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text SharedItemTitleText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_SharedItemTitleText));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_SharedItemTitleText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField InputField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_InputField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Button Button
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_Button));
        return pointer == System.IntPtr.Zero ? (Button) null : new Button(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text ButtonText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_ButtonText));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_ButtonText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Slider Slider
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_Slider));
        return pointer == System.IntPtr.Zero ? (Slider) null : new Slider(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Toggle CheckBox
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_CheckBox));
        return pointer == System.IntPtr.Zero ? (Toggle) null : new Toggle(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_CheckBox), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text CheckBoxText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_CheckBoxText));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_CheckBoxText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text HeaderText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_HeaderText));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugMenuItem.NativeFieldInfoPtr_HeaderText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
