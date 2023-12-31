// Decompiled with JetBrains decompiler
// Type: LocalizedText
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
public class LocalizedText : StunGUIBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_LocalizationKey;
  private static readonly IntPtr NativeFieldInfoPtr__LocalizedString;
  private static readonly IntPtr NativeFieldInfoPtr__Text_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr_SetRectSizeToTextSize;
  private static readonly IntPtr NativeFieldInfoPtr__TextHasBeenModified;
  private static readonly IntPtr NativeFieldInfoPtr__IsForceSet;
  private static readonly IntPtr NativeFieldInfoPtr_LocalizationVersion;
  private static readonly IntPtr NativeFieldInfoPtr__HasTextBeenSet;
  private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_get_TextMeshProUGUI_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_Text_Public_set_Void_TextMeshProUGUI_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_VerifyTextExists_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetFontSize_Public_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetText_Public_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetFontMaterial_Public_Void_Material_0;
  private static readonly IntPtr NativeMethodInfoPtr_ForceSet_Public_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_LocalizedString_0;
  private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_LocalizationKey_Il2CppReferenceArray_1_LocalizedKeyValue_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetKeyValue_Public_Void_LocalizedKeyValue_0;
  private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_LocalizationKey_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateText_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe TextMeshProUGUI Text
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(LocalizedText.NativeMethodInfoPtr_get_Text_Public_get_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocalizedText.NativeMethodInfoPtr_set_Text_Public_set_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714306, XrefRangeEnd = 714308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LocalizedText.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 714316, RefRangeEnd = 714327, XrefRangeStart = 714308, XrefRangeEnd = 714316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void VerifyTextExists()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LocalizedText.NativeMethodInfoPtr_VerifyTextExists_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(111)]
  [CachedScanResults(RefRangeStart = 714333, RefRangeEnd = 714444, XrefRangeStart = 714327, XrefRangeEnd = 714333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetColor(Color color)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1];
    numPtr[0] = (IntPtr) &color;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LocalizedText.NativeMethodInfoPtr_SetColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 714450, RefRangeEnd = 714451, XrefRangeStart = 714444, XrefRangeEnd = 714450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetFontSize(int fontSize)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1];
    numPtr[0] = (IntPtr) &fontSize;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LocalizedText.NativeMethodInfoPtr_SetFontSize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 714456, RefRangeEnd = 714459, XrefRangeStart = 714451, XrefRangeEnd = 714456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Color GetColor()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(LocalizedText.NativeMethodInfoPtr_GetColor_Public_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714459, XrefRangeEnd = 714464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string GetText()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LocalizedText.NativeMethodInfoPtr_GetText_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 714470, RefRangeEnd = 714471, XrefRangeStart = 714464, XrefRangeEnd = 714470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetFontMaterial(Material material)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LocalizedText.NativeMethodInfoPtr_SetFontMaterial_Public_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(122)]
  [CachedScanResults(RefRangeStart = 714478, RefRangeEnd = 714600, XrefRangeStart = 714471, XrefRangeEnd = 714478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ForceSet(string text)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LocalizedText.NativeMethodInfoPtr_ForceSet_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(55)]
  [CachedScanResults(RefRangeStart = 714608, RefRangeEnd = 714663, XrefRangeStart = 714600, XrefRangeEnd = 714608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(LocalizedString localizedString)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) localizedString));
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LocalizedText.NativeMethodInfoPtr_Set_Public_Void_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(44)]
  [CachedScanResults(RefRangeStart = 714671, RefRangeEnd = 714715, XrefRangeStart = 714663, XrefRangeEnd = 714671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(
    LocalizationKey localizationKey,
    [Optional] Il2CppReferenceArray<LocalizedKeyValue> keyValues)
  {
    if (keyValues == null)
      keyValues = (Il2CppReferenceArray<LocalizedKeyValue>) new Il2CppStructArray<LocalizedKeyValue>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &localizationKey;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keyValues);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LocalizedText.NativeMethodInfoPtr_Set_Public_Void_LocalizationKey_Il2CppReferenceArray_1_LocalizedKeyValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(88)]
  [CachedScanResults(RefRangeStart = 714723, RefRangeEnd = 714811, XrefRangeStart = 714715, XrefRangeEnd = 714723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetKeyValue(LocalizedKeyValue keyValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) keyValue));
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LocalizedText.NativeMethodInfoPtr_SetKeyValue_Public_Void_LocalizedKeyValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(315)]
  [CachedScanResults(RefRangeStart = 714819, RefRangeEnd = 715134, XrefRangeStart = 714811, XrefRangeEnd = 714819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(LocalizationKey localizationKey)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1];
    numPtr[0] = (IntPtr) &localizationKey;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LocalizedText.NativeMethodInfoPtr_Set_Public_Void_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 715136, RefRangeEnd = 715137, XrefRangeStart = 715134, XrefRangeEnd = 715136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateText()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LocalizedText.NativeMethodInfoPtr_UpdateText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715137, XrefRangeEnd = 715157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LocalizedText.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715157, XrefRangeEnd = 715158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LocalizedText.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715158, XrefRangeEnd = 715159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LocalizedText()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LocalizedText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public void Set(LocalizationKey localizationKey, params LocalizedKeyValue[] keyValues)
  {
    this.Set(localizationKey, new Il2CppReferenceArray<LocalizedKeyValue>(keyValues));
  }

  static LocalizedText()
  {
    Il2CppClassPointerStore<LocalizedText>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (LocalizedText));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr);
    LocalizedText.NativeFieldInfoPtr_LocalizationKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, nameof (LocalizationKey));
    LocalizedText.NativeFieldInfoPtr__LocalizedString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, nameof (_LocalizedString));
    LocalizedText.NativeFieldInfoPtr__Text_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, "<Text>k__BackingField");
    LocalizedText.NativeFieldInfoPtr_SetRectSizeToTextSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, nameof (SetRectSizeToTextSize));
    LocalizedText.NativeFieldInfoPtr__TextHasBeenModified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, nameof (_TextHasBeenModified));
    LocalizedText.NativeFieldInfoPtr__IsForceSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, nameof (_IsForceSet));
    LocalizedText.NativeFieldInfoPtr_LocalizationVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, nameof (LocalizationVersion));
    LocalizedText.NativeFieldInfoPtr__HasTextBeenSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, nameof (_HasTextBeenSet));
    LocalizedText.NativeMethodInfoPtr_get_Text_Public_get_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, 100663342);
    LocalizedText.NativeMethodInfoPtr_set_Text_Public_set_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, 100663343);
    LocalizedText.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, 100663344);
    LocalizedText.NativeMethodInfoPtr_VerifyTextExists_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, 100663345);
    LocalizedText.NativeMethodInfoPtr_SetColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, 100663346);
    LocalizedText.NativeMethodInfoPtr_SetFontSize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, 100663347);
    LocalizedText.NativeMethodInfoPtr_GetColor_Public_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, 100663348);
    LocalizedText.NativeMethodInfoPtr_GetText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, 100663349);
    LocalizedText.NativeMethodInfoPtr_SetFontMaterial_Public_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, 100663350);
    LocalizedText.NativeMethodInfoPtr_ForceSet_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, 100663351);
    LocalizedText.NativeMethodInfoPtr_Set_Public_Void_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, 100663352);
    LocalizedText.NativeMethodInfoPtr_Set_Public_Void_LocalizationKey_Il2CppReferenceArray_1_LocalizedKeyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, 100663353);
    LocalizedText.NativeMethodInfoPtr_SetKeyValue_Public_Void_LocalizedKeyValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, 100663354);
    LocalizedText.NativeMethodInfoPtr_Set_Public_Void_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, 100663355);
    LocalizedText.NativeMethodInfoPtr_UpdateText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, 100663356);
    LocalizedText.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, 100663357);
    LocalizedText.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, 100663358);
    LocalizedText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedText>.NativeClassPtr, 100663359);
  }

  public LocalizedText(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LocalizationKey LocalizationKey
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedText.NativeFieldInfoPtr_LocalizationKey));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedText.NativeFieldInfoPtr_LocalizationKey)) = value;
    }
  }

  public LocalizedString _LocalizedString
  {
    get
    {
      IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedText.NativeFieldInfoPtr__LocalizedString);
      return new LocalizedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedText.NativeFieldInfoPtr__LocalizedString), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }

  public unsafe TextMeshProUGUI _Text_k__BackingField
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedText.NativeFieldInfoPtr__Text_k__BackingField));
      return pointer == IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalizedText.NativeFieldInfoPtr__Text_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool SetRectSizeToTextSize
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedText.NativeFieldInfoPtr_SetRectSizeToTextSize));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedText.NativeFieldInfoPtr_SetRectSizeToTextSize)) = value;
    }
  }

  public unsafe bool _TextHasBeenModified
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedText.NativeFieldInfoPtr__TextHasBeenModified));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedText.NativeFieldInfoPtr__TextHasBeenModified)) = value;
    }
  }

  public unsafe bool _IsForceSet
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedText.NativeFieldInfoPtr__IsForceSet));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedText.NativeFieldInfoPtr__IsForceSet)) = value;
    }
  }

  public unsafe int LocalizationVersion
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedText.NativeFieldInfoPtr_LocalizationVersion));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedText.NativeFieldInfoPtr_LocalizationVersion)) = value;
    }
  }

  public unsafe bool _HasTextBeenSet
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedText.NativeFieldInfoPtr__HasTextBeenSet));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedText.NativeFieldInfoPtr__HasTextBeenSet)) = value;
    }
  }
}
