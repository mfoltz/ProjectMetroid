// Decompiled with JetBrains decompiler
// Type: SCTText
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.UI;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
public class SCTText : UIEntry
{
  private static readonly IntPtr NativeFieldInfoPtr_Text;
  private static readonly IntPtr NativeFieldInfoPtr_RectText;
  private static readonly IntPtr NativeFieldInfoPtr_RectMain;
  private static readonly IntPtr NativeFieldInfoPtr__ValueLocalizedString;
  private static readonly IntPtr NativeFieldInfoPtr__ValueKeyValue;
  private static readonly IntPtr NativeFieldInfoPtr__SourceTypeKeyValue;
  private static readonly IntPtr NativeFieldInfoPtr_BloodTypeChange;
  private static readonly IntPtr NativeFieldInfoPtr__Initialized;
  private static readonly IntPtr NativeMethodInfoPtr_InitializeUI_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_RefreshData_Public_Void_SCT_Type_EntryData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1206473, RefRangeEnd = 1206474, XrefRangeStart = 1206456, XrefRangeEnd = 1206473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void InitializeUI()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SCTText.NativeMethodInfoPtr_InitializeUI_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1206516, RefRangeEnd = 1206517, XrefRangeStart = 1206474, XrefRangeEnd = 1206516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RefreshData(SCT_Type type, ScrollingCombatTextParentMapper.EntryData data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &data;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SCTText.NativeMethodInfoPtr_RefreshData_Public_Void_SCT_Type_EntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(41)]
  [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SCTText()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SCTText>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SCTText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SCTText()
  {
    Il2CppClassPointerStore<SCTText>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (SCTText));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SCTText>.NativeClassPtr);
    SCTText.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTText>.NativeClassPtr, nameof (Text));
    SCTText.NativeFieldInfoPtr_RectText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTText>.NativeClassPtr, nameof (RectText));
    SCTText.NativeFieldInfoPtr_RectMain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTText>.NativeClassPtr, nameof (RectMain));
    SCTText.NativeFieldInfoPtr__ValueLocalizedString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTText>.NativeClassPtr, nameof (_ValueLocalizedString));
    SCTText.NativeFieldInfoPtr__ValueKeyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTText>.NativeClassPtr, nameof (_ValueKeyValue));
    SCTText.NativeFieldInfoPtr__SourceTypeKeyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTText>.NativeClassPtr, nameof (_SourceTypeKeyValue));
    SCTText.NativeFieldInfoPtr_BloodTypeChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTText>.NativeClassPtr, nameof (BloodTypeChange));
    SCTText.NativeFieldInfoPtr__Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SCTText>.NativeClassPtr, nameof (_Initialized));
    SCTText.NativeMethodInfoPtr_InitializeUI_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SCTText>.NativeClassPtr, 100663408);
    SCTText.NativeMethodInfoPtr_RefreshData_Public_Void_SCT_Type_EntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SCTText>.NativeClassPtr, 100663409);
    SCTText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SCTText>.NativeClassPtr, 100663410);
  }

  public SCTText(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe TextMeshProUGUI Text
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTText.NativeFieldInfoPtr_Text));
      return pointer == IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTText.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform RectText
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTText.NativeFieldInfoPtr_RectText));
      return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTText.NativeFieldInfoPtr_RectText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform RectMain
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTText.NativeFieldInfoPtr_RectMain));
      return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTText.NativeFieldInfoPtr_RectMain), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public LocalizedString _ValueLocalizedString
  {
    get
    {
      IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTText.NativeFieldInfoPtr__ValueLocalizedString);
      return new LocalizedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTText.NativeFieldInfoPtr__ValueLocalizedString), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }

  public LocalizedKeyValue _ValueKeyValue
  {
    get
    {
      IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTText.NativeFieldInfoPtr__ValueKeyValue);
      return new LocalizedKeyValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedKeyValue>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTText.NativeFieldInfoPtr__ValueKeyValue), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedKeyValue>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }

  public LocalizedKeyValue _SourceTypeKeyValue
  {
    get
    {
      IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTText.NativeFieldInfoPtr__SourceTypeKeyValue);
      return new LocalizedKeyValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedKeyValue>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTText.NativeFieldInfoPtr__SourceTypeKeyValue), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedKeyValue>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }

  public unsafe SCT_Type BloodTypeChange
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTText.NativeFieldInfoPtr_BloodTypeChange));
      return pointer == IntPtr.Zero ? (SCT_Type) null : new SCT_Type(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SCTText.NativeFieldInfoPtr_BloodTypeChange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _Initialized
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTText.NativeFieldInfoPtr__Initialized));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SCTText.NativeFieldInfoPtr__Initialized)) = value;
    }
  }
}
