// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CustomGameSettings_Slider
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class CustomGameSettings_Slider : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Modified;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeaderText;
    private static readonly System.IntPtr NativeFieldInfoPtr_Slider;
    private static readonly System.IntPtr NativeFieldInfoPtr_ValueField;
    private static readonly System.IntPtr NativeFieldInfoPtr_ValueError;
    private static readonly System.IntPtr NativeFieldInfoPtr_InfoButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResetButton;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnValueChange;
    private static readonly System.IntPtr NativeFieldInfoPtr__Decimals;
    private static readonly System.IntPtr NativeFieldInfoPtr__MinValue;
    private static readonly System.IntPtr NativeFieldInfoPtr__MaxValue;
    private static readonly System.IntPtr NativeFieldInfoPtr__Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_soundMapping;
    private static readonly System.IntPtr NativeFieldInfoPtr_clickSoundType;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlayClickSound_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_Nullable_Unboxed_1_LocalizationKey_Single_Single_Single_Single_Int32_Boolean_Action_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_LocalizedString_Nullable_Unboxed_1_LocalizationKey_Single_Single_Single_Single_Int32_Boolean_Action_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetModified_Public_Void_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TextField_OnValueChange_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Slider_OnValueChange_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1161378, RefRangeEnd = 1161379, XrefRangeStart = 1161361, XrefRangeEnd = 1161378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PlayClickSound()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Slider.NativeMethodInfoPtr_PlayClickSound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1161381, RefRangeEnd = 1161385, XrefRangeStart = 1161379, XrefRangeEnd = 1161381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize(
      LocalizationKey textKey,
      Nullable_Unboxed<LocalizationKey> tooltipKey,
      float minValue,
      float maxValue,
      float defValue,
      float initValue,
      int decimals,
      bool wholeNumbers,
      Il2CppSystem.Action<float> onValueChange)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tooltipKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &minValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &maxValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &defValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &initValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &decimals;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &wholeNumbers;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Slider.NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_Nullable_Unboxed_1_LocalizationKey_Single_Single_Single_Single_Int32_Boolean_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1161448, RefRangeEnd = 1161450, XrefRangeStart = 1161385, XrefRangeEnd = 1161448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize(
      LocalizedString text,
      Nullable_Unboxed<LocalizationKey> tooltipKey,
      float minValue,
      float maxValue,
      float defValue,
      float initValue,
      int decimals,
      bool wholeNumbers,
      Il2CppSystem.Action<float> onValueChange)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) text));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tooltipKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &minValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &maxValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &defValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &initValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &decimals;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &wholeNumbers;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Slider.NativeMethodInfoPtr_Initialize_Public_Void_LocalizedString_Nullable_Unboxed_1_LocalizationKey_Single_Single_Single_Single_Int32_Boolean_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1161454, RefRangeEnd = 1161459, XrefRangeStart = 1161450, XrefRangeEnd = 1161454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetModified(bool modified, bool initDiff)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &modified;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &initDiff;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Slider.NativeMethodInfoPtr_SetModified_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161459, XrefRangeEnd = 1161473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TextField_OnValueChange(string stringValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(stringValue);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Slider.NativeMethodInfoPtr_TextField_OnValueChange_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1161487, RefRangeEnd = 1161489, XrefRangeStart = 1161473, XrefRangeEnd = 1161487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetValue(float newValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newValue;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Slider.NativeMethodInfoPtr_SetValue_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1161487, RefRangeEnd = 1161489, XrefRangeStart = 1161487, XrefRangeEnd = 1161489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Slider_OnValueChange(float newVal)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newVal;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Slider.NativeMethodInfoPtr_Slider_OnValueChange_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Slider.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 587828, RefRangeEnd = 587829, XrefRangeStart = 587828, XrefRangeEnd = 587829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetValue()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Slider.NativeMethodInfoPtr_GetValue_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CustomGameSettings_Slider()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Slider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CustomGameSettings_Slider()
    {
      Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (CustomGameSettings_Slider));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr);
      CustomGameSettings_Slider.NativeFieldInfoPtr_Modified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, nameof (Modified));
      CustomGameSettings_Slider.NativeFieldInfoPtr_HeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, nameof (HeaderText));
      CustomGameSettings_Slider.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, nameof (Slider));
      CustomGameSettings_Slider.NativeFieldInfoPtr_ValueField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, nameof (ValueField));
      CustomGameSettings_Slider.NativeFieldInfoPtr_ValueError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, nameof (ValueError));
      CustomGameSettings_Slider.NativeFieldInfoPtr_InfoButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, nameof (InfoButton));
      CustomGameSettings_Slider.NativeFieldInfoPtr_ResetButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, nameof (ResetButton));
      CustomGameSettings_Slider.NativeFieldInfoPtr__OnValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, nameof (_OnValueChange));
      CustomGameSettings_Slider.NativeFieldInfoPtr__Decimals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, nameof (_Decimals));
      CustomGameSettings_Slider.NativeFieldInfoPtr__MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, nameof (_MinValue));
      CustomGameSettings_Slider.NativeFieldInfoPtr__MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, nameof (_MaxValue));
      CustomGameSettings_Slider.NativeFieldInfoPtr__Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, nameof (_Value));
      CustomGameSettings_Slider.NativeFieldInfoPtr_soundMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, nameof (soundMapping));
      CustomGameSettings_Slider.NativeFieldInfoPtr_clickSoundType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, nameof (clickSoundType));
      CustomGameSettings_Slider.NativeMethodInfoPtr_PlayClickSound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, 100692363);
      CustomGameSettings_Slider.NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_Nullable_Unboxed_1_LocalizationKey_Single_Single_Single_Single_Int32_Boolean_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, 100692364);
      CustomGameSettings_Slider.NativeMethodInfoPtr_Initialize_Public_Void_LocalizedString_Nullable_Unboxed_1_LocalizationKey_Single_Single_Single_Single_Int32_Boolean_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, 100692365);
      CustomGameSettings_Slider.NativeMethodInfoPtr_SetModified_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, 100692366);
      CustomGameSettings_Slider.NativeMethodInfoPtr_TextField_OnValueChange_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, 100692367);
      CustomGameSettings_Slider.NativeMethodInfoPtr_SetValue_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, 100692368);
      CustomGameSettings_Slider.NativeMethodInfoPtr_Slider_OnValueChange_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, 100692369);
      CustomGameSettings_Slider.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, 100692370);
      CustomGameSettings_Slider.NativeMethodInfoPtr_GetValue_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, 100692371);
      CustomGameSettings_Slider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, 100692372);
    }

    public CustomGameSettings_Slider(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image Modified
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr_Modified));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr_Modified), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText HeaderText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr_HeaderText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr_HeaderText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Slider Slider
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr_Slider));
        return pointer == System.IntPtr.Zero ? (Slider) null : new Slider(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField ValueField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr_ValueField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr_ValueField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ValueError
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr_ValueError));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr_ValueError), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton InfoButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr_InfoButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr_InfoButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton ResetButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr_ResetButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr_ResetButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<float> _OnValueChange
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr__OnValueChange));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<float>) null : new Il2CppSystem.Action<float>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr__OnValueChange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _Decimals
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr__Decimals));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr__Decimals)) = value;
      }
    }

    public unsafe float _MinValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr__MinValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr__MinValue)) = value;
      }
    }

    public unsafe float _MaxValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr__MaxValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr__MaxValue)) = value;
      }
    }

    public unsafe float _Value
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr__Value));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr__Value)) = value;
      }
    }

    public unsafe UISoundMapping soundMapping
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr_soundMapping));
        return pointer == System.IntPtr.Zero ? (UISoundMapping) null : new UISoundMapping(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr_soundMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UISoundType clickSoundType
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr_clickSoundType));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.NativeFieldInfoPtr_clickSoundType)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UI.CustomGameSettings_Slider/<>c__DisplayClass16_0")]
    public sealed class __c__DisplayClass16_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_defValue;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass16_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomGameSettings_Slider.__c__DisplayClass16_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Slider.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161360, XrefRangeEnd = 1161361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Initialize_b__0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Slider.__c__DisplayClass16_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass16_0()
      {
        Il2CppClassPointerStore<CustomGameSettings_Slider.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomGameSettings_Slider>.NativeClassPtr, "<>c__DisplayClass16_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomGameSettings_Slider.__c__DisplayClass16_0>.NativeClassPtr);
        CustomGameSettings_Slider.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Slider.__c__DisplayClass16_0>.NativeClassPtr, "<>4__this");
        CustomGameSettings_Slider.__c__DisplayClass16_0.NativeFieldInfoPtr_defValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Slider.__c__DisplayClass16_0>.NativeClassPtr, nameof (defValue));
        CustomGameSettings_Slider.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Slider.__c__DisplayClass16_0>.NativeClassPtr, 100692373);
        CustomGameSettings_Slider.__c__DisplayClass16_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Slider.__c__DisplayClass16_0>.NativeClassPtr, 100692374);
      }

      public __c__DisplayClass16_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe CustomGameSettings_Slider __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (CustomGameSettings_Slider) null : new CustomGameSettings_Slider(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float defValue
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.__c__DisplayClass16_0.NativeFieldInfoPtr_defValue));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Slider.__c__DisplayClass16_0.NativeFieldInfoPtr_defValue)) = value;
        }
      }
    }
  }
}
