// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CustomGameSettings_FromToTime
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
  public class CustomGameSettings_FromToTime : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Modified;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeaderText;
    private static readonly System.IntPtr NativeFieldInfoPtr_FromHourValueField;
    private static readonly System.IntPtr NativeFieldInfoPtr_FromMinuteValueField;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToHourValueField;
    private static readonly System.IntPtr NativeFieldInfoPtr_ToMinuteValueField;
    private static readonly System.IntPtr NativeFieldInfoPtr_InfoButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResetButton;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnValueChange;
    private static readonly System.IntPtr NativeFieldInfoPtr__InitValue;
    private static readonly System.IntPtr NativeFieldInfoPtr__DefaultValue;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentValue;
    private static readonly System.IntPtr NativeFieldInfoPtr__Decimals;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_Nullable_Unboxed_1_LocalizationKey_StartEndTimeData_StartEndTimeData_Action_1_StartEndTimeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_LocalizedString_Nullable_Unboxed_1_LocalizationKey_StartEndTimeData_StartEndTimeData_Action_1_StartEndTimeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultValues_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetValue_Private_Int32_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnValueChanged_Private_Void_Int32_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TimeDiff_Private_Boolean_StartEndTimeData_StartEndTimeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFields_Private_Void_Int32_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetModified_Public_Void_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__14_0_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__14_1_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__14_2_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__14_3_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__14_4_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__14_5_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__14_6_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__14_7_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__14_8_Private_Void_String_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1161064, RefRangeEnd = 1161065, XrefRangeStart = 1161062, XrefRangeEnd = 1161064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize(
      LocalizationKey textKey,
      Nullable_Unboxed<LocalizationKey> tooltipKey,
      StartEndTimeData defValue,
      StartEndTimeData initValue,
      Il2CppSystem.Action<StartEndTimeData> onValueChange)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tooltipKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) defValue);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) initValue);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_FromToTime.NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_Nullable_Unboxed_1_LocalizationKey_StartEndTimeData_StartEndTimeData_Action_1_StartEndTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1161171, RefRangeEnd = 1161172, XrefRangeStart = 1161065, XrefRangeEnd = 1161171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize(
      LocalizedString text,
      Nullable_Unboxed<LocalizationKey> tooltipKey,
      StartEndTimeData defValue,
      StartEndTimeData initValue,
      Il2CppSystem.Action<StartEndTimeData> onValueChange)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) text));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tooltipKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) defValue);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) initValue);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_FromToTime.NativeMethodInfoPtr_Initialize_Public_Void_LocalizedString_Nullable_Unboxed_1_LocalizationKey_StartEndTimeData_StartEndTimeData_Action_1_StartEndTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161172, XrefRangeEnd = 1161174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetDefaultValues(bool apply)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &apply;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_FromToTime.NativeMethodInfoPtr_SetDefaultValues_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161174, XrefRangeEnd = 1161175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int TryGetValue(string text)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_FromToTime.NativeMethodInfoPtr_TryGetValue_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1161184, RefRangeEnd = 1161190, XrefRangeStart = 1161175, XrefRangeEnd = 1161184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnValueChanged(int fromHour, int fromMinute, int toHour, int toMinute)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &fromHour;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromMinute;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &toHour;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &toMinute;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_FromToTime.NativeMethodInfoPtr_OnValueChanged_Private_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool TimeDiff(StartEndTimeData x, StartEndTimeData y)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_FromToTime.NativeMethodInfoPtr_TimeDiff_Private_Boolean_StartEndTimeData_StartEndTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 1161203, RefRangeEnd = 1161210, XrefRangeStart = 1161190, XrefRangeEnd = 1161203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateFields(int fromHour, int fromMinute, int toHour, int toMinute)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &fromHour;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromMinute;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &toHour;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &toMinute;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_FromToTime.NativeMethodInfoPtr_UpdateFields_Private_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161210, XrefRangeEnd = 1161214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetModified(bool modified, bool initDiff)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &modified;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &initDiff;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_FromToTime.NativeMethodInfoPtr_SetModified_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_FromToTime.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CustomGameSettings_FromToTime()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_FromToTime.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161214, XrefRangeEnd = 1161216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__14_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_FromToTime.NativeMethodInfoPtr__Initialize_b__14_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161216, XrefRangeEnd = 1161218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__14_1(string v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(v);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_FromToTime.NativeMethodInfoPtr__Initialize_b__14_1_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161218, XrefRangeEnd = 1161219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__14_2(string v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(v);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_FromToTime.NativeMethodInfoPtr__Initialize_b__14_2_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161219, XrefRangeEnd = 1161221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__14_3(string v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(v);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_FromToTime.NativeMethodInfoPtr__Initialize_b__14_3_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__14_4(string v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(v);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_FromToTime.NativeMethodInfoPtr__Initialize_b__14_4_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161221, XrefRangeEnd = 1161223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__14_5(string v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(v);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_FromToTime.NativeMethodInfoPtr__Initialize_b__14_5_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__14_6(string v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(v);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_FromToTime.NativeMethodInfoPtr__Initialize_b__14_6_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161223, XrefRangeEnd = 1161225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__14_7(string v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(v);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_FromToTime.NativeMethodInfoPtr__Initialize_b__14_7_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__14_8(string v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(v);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_FromToTime.NativeMethodInfoPtr__Initialize_b__14_8_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CustomGameSettings_FromToTime()
    {
      Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (CustomGameSettings_FromToTime));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr);
      CustomGameSettings_FromToTime.NativeFieldInfoPtr_Modified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, nameof (Modified));
      CustomGameSettings_FromToTime.NativeFieldInfoPtr_HeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, nameof (HeaderText));
      CustomGameSettings_FromToTime.NativeFieldInfoPtr_FromHourValueField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, nameof (FromHourValueField));
      CustomGameSettings_FromToTime.NativeFieldInfoPtr_FromMinuteValueField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, nameof (FromMinuteValueField));
      CustomGameSettings_FromToTime.NativeFieldInfoPtr_ToHourValueField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, nameof (ToHourValueField));
      CustomGameSettings_FromToTime.NativeFieldInfoPtr_ToMinuteValueField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, nameof (ToMinuteValueField));
      CustomGameSettings_FromToTime.NativeFieldInfoPtr_InfoButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, nameof (InfoButton));
      CustomGameSettings_FromToTime.NativeFieldInfoPtr_ResetButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, nameof (ResetButton));
      CustomGameSettings_FromToTime.NativeFieldInfoPtr__OnValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, nameof (_OnValueChange));
      CustomGameSettings_FromToTime.NativeFieldInfoPtr__InitValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, nameof (_InitValue));
      CustomGameSettings_FromToTime.NativeFieldInfoPtr__DefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, nameof (_DefaultValue));
      CustomGameSettings_FromToTime.NativeFieldInfoPtr__CurrentValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, nameof (_CurrentValue));
      CustomGameSettings_FromToTime.NativeFieldInfoPtr__Decimals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, nameof (_Decimals));
      CustomGameSettings_FromToTime.NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_Nullable_Unboxed_1_LocalizationKey_StartEndTimeData_StartEndTimeData_Action_1_StartEndTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, 100692329);
      CustomGameSettings_FromToTime.NativeMethodInfoPtr_Initialize_Public_Void_LocalizedString_Nullable_Unboxed_1_LocalizationKey_StartEndTimeData_StartEndTimeData_Action_1_StartEndTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, 100692330);
      CustomGameSettings_FromToTime.NativeMethodInfoPtr_SetDefaultValues_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, 100692331);
      CustomGameSettings_FromToTime.NativeMethodInfoPtr_TryGetValue_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, 100692332);
      CustomGameSettings_FromToTime.NativeMethodInfoPtr_OnValueChanged_Private_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, 100692333);
      CustomGameSettings_FromToTime.NativeMethodInfoPtr_TimeDiff_Private_Boolean_StartEndTimeData_StartEndTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, 100692334);
      CustomGameSettings_FromToTime.NativeMethodInfoPtr_UpdateFields_Private_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, 100692335);
      CustomGameSettings_FromToTime.NativeMethodInfoPtr_SetModified_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, 100692336);
      CustomGameSettings_FromToTime.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, 100692337);
      CustomGameSettings_FromToTime.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, 100692338);
      CustomGameSettings_FromToTime.NativeMethodInfoPtr__Initialize_b__14_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, 100692339);
      CustomGameSettings_FromToTime.NativeMethodInfoPtr__Initialize_b__14_1_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, 100692340);
      CustomGameSettings_FromToTime.NativeMethodInfoPtr__Initialize_b__14_2_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, 100692341);
      CustomGameSettings_FromToTime.NativeMethodInfoPtr__Initialize_b__14_3_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, 100692342);
      CustomGameSettings_FromToTime.NativeMethodInfoPtr__Initialize_b__14_4_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, 100692343);
      CustomGameSettings_FromToTime.NativeMethodInfoPtr__Initialize_b__14_5_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, 100692344);
      CustomGameSettings_FromToTime.NativeMethodInfoPtr__Initialize_b__14_6_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, 100692345);
      CustomGameSettings_FromToTime.NativeMethodInfoPtr__Initialize_b__14_7_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, 100692346);
      CustomGameSettings_FromToTime.NativeMethodInfoPtr__Initialize_b__14_8_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_FromToTime>.NativeClassPtr, 100692347);
    }

    public CustomGameSettings_FromToTime(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image Modified
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr_Modified));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr_Modified), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText HeaderText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr_HeaderText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr_HeaderText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField FromHourValueField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr_FromHourValueField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr_FromHourValueField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField FromMinuteValueField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr_FromMinuteValueField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr_FromMinuteValueField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField ToHourValueField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr_ToHourValueField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr_ToHourValueField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_InputField ToMinuteValueField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr_ToMinuteValueField));
        return pointer == System.IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr_ToMinuteValueField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton InfoButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr_InfoButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr_InfoButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton ResetButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr_ResetButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr_ResetButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<StartEndTimeData> _OnValueChange
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr__OnValueChange));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<StartEndTimeData>) null : new Il2CppSystem.Action<StartEndTimeData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr__OnValueChange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StartEndTimeData _InitValue
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr__InitValue));
        return pointer == System.IntPtr.Zero ? (StartEndTimeData) null : new StartEndTimeData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr__InitValue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StartEndTimeData _DefaultValue
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr__DefaultValue));
        return pointer == System.IntPtr.Zero ? (StartEndTimeData) null : new StartEndTimeData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr__DefaultValue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StartEndTimeData _CurrentValue
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr__CurrentValue));
        return pointer == System.IntPtr.Zero ? (StartEndTimeData) null : new StartEndTimeData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr__CurrentValue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _Decimals
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr__Decimals));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_FromToTime.NativeFieldInfoPtr__Decimals)) = value;
      }
    }
  }
}
