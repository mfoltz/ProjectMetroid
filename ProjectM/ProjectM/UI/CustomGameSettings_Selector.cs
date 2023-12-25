// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CustomGameSettings_Selector
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using StunShared.UI;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class CustomGameSettings_Selector : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Modified;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeaderText;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectorPrevButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectorNextButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectorText;
    private static readonly System.IntPtr NativeFieldInfoPtr_IndexIndicatorNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_IndexIndicatorPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_InfoButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResetButton;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnValueChange;
    private static readonly System.IntPtr NativeFieldInfoPtr__LoopAround;
    private static readonly System.IntPtr NativeFieldInfoPtr__UseIndexIndicator;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__Keys;
    private static readonly System.IntPtr NativeFieldInfoPtr__IndexIndicatorCache;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitIndicatorCache_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_Nullable_Unboxed_1_LocalizationKey_Int32_Int32_List_1_String_Boolean_Boolean_Action_2_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetModified_Public_Void_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LeftButton_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RightButton_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryChangeIndex_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckButtons_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSelectedIndexIndicator_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161240, XrefRangeEnd = 1161241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Selector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1161248, RefRangeEnd = 1161250, XrefRangeStart = 1161241, XrefRangeEnd = 1161248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitIndicatorCache()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Selector.NativeMethodInfoPtr_InitIndicatorCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1161298, RefRangeEnd = 1161299, XrefRangeStart = 1161250, XrefRangeEnd = 1161298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize(
      LocalizationKey textKey,
      Nullable_Unboxed<LocalizationKey> tooltipKey,
      int defValue,
      int initValue,
      List<string> keys,
      bool loopAround,
      bool useIndexIndicator,
      Il2CppSystem.Action<int, int> onValueChange)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tooltipKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &defValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &initValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keys);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &loopAround;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &useIndexIndicator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onValueChange);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Selector.NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_Nullable_Unboxed_1_LocalizationKey_Int32_Int32_List_1_String_Boolean_Boolean_Action_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1161303, RefRangeEnd = 1161304, XrefRangeStart = 1161299, XrefRangeEnd = 1161303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetModified(bool modified, bool initDiff)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &modified;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &initDiff;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Selector.NativeMethodInfoPtr_SetModified_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161304, XrefRangeEnd = 1161305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LeftButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Selector.NativeMethodInfoPtr_LeftButton_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161305, XrefRangeEnd = 1161306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RightButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Selector.NativeMethodInfoPtr_RightButton_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1161312, RefRangeEnd = 1161314, XrefRangeStart = 1161306, XrefRangeEnd = 1161312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TryChangeIndex(int indexAdd)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &indexAdd;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Selector.NativeMethodInfoPtr_TryChangeIndex_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1161339, RefRangeEnd = 1161342, XrefRangeStart = 1161314, XrefRangeEnd = 1161339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetValue(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Selector.NativeMethodInfoPtr_SetValue_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161342, XrefRangeEnd = 1161347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckButtons()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Selector.NativeMethodInfoPtr_CheckButtons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161347, XrefRangeEnd = 1161360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateSelectedIndexIndicator()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Selector.NativeMethodInfoPtr_UpdateSelectedIndexIndicator_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CustomGameSettings_Selector()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Selector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CustomGameSettings_Selector()
    {
      Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (CustomGameSettings_Selector));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr);
      CustomGameSettings_Selector.NativeFieldInfoPtr_Modified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, nameof (Modified));
      CustomGameSettings_Selector.NativeFieldInfoPtr_HeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, nameof (HeaderText));
      CustomGameSettings_Selector.NativeFieldInfoPtr_SelectorPrevButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, nameof (SelectorPrevButton));
      CustomGameSettings_Selector.NativeFieldInfoPtr_SelectorNextButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, nameof (SelectorNextButton));
      CustomGameSettings_Selector.NativeFieldInfoPtr_SelectorText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, nameof (SelectorText));
      CustomGameSettings_Selector.NativeFieldInfoPtr_IndexIndicatorNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, nameof (IndexIndicatorNode));
      CustomGameSettings_Selector.NativeFieldInfoPtr_IndexIndicatorPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, nameof (IndexIndicatorPrefab));
      CustomGameSettings_Selector.NativeFieldInfoPtr_InfoButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, nameof (InfoButton));
      CustomGameSettings_Selector.NativeFieldInfoPtr_ResetButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, nameof (ResetButton));
      CustomGameSettings_Selector.NativeFieldInfoPtr__OnValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, nameof (_OnValueChange));
      CustomGameSettings_Selector.NativeFieldInfoPtr__LoopAround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, nameof (_LoopAround));
      CustomGameSettings_Selector.NativeFieldInfoPtr__UseIndexIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, nameof (_UseIndexIndicator));
      CustomGameSettings_Selector.NativeFieldInfoPtr__CurrentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, nameof (_CurrentIndex));
      CustomGameSettings_Selector.NativeFieldInfoPtr__Keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, nameof (_Keys));
      CustomGameSettings_Selector.NativeFieldInfoPtr__IndexIndicatorCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, nameof (_IndexIndicatorCache));
      CustomGameSettings_Selector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, 100692350);
      CustomGameSettings_Selector.NativeMethodInfoPtr_InitIndicatorCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, 100692351);
      CustomGameSettings_Selector.NativeMethodInfoPtr_Initialize_Public_Void_LocalizationKey_Nullable_Unboxed_1_LocalizationKey_Int32_Int32_List_1_String_Boolean_Boolean_Action_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, 100692352);
      CustomGameSettings_Selector.NativeMethodInfoPtr_SetModified_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, 100692353);
      CustomGameSettings_Selector.NativeMethodInfoPtr_LeftButton_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, 100692354);
      CustomGameSettings_Selector.NativeMethodInfoPtr_RightButton_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, 100692355);
      CustomGameSettings_Selector.NativeMethodInfoPtr_TryChangeIndex_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, 100692356);
      CustomGameSettings_Selector.NativeMethodInfoPtr_SetValue_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, 100692357);
      CustomGameSettings_Selector.NativeMethodInfoPtr_CheckButtons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, 100692358);
      CustomGameSettings_Selector.NativeMethodInfoPtr_UpdateSelectedIndexIndicator_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, 100692359);
      CustomGameSettings_Selector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, 100692360);
    }

    public CustomGameSettings_Selector(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image Modified
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr_Modified));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr_Modified), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText HeaderText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr_HeaderText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr_HeaderText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SelectorPrevButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr_SelectorPrevButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr_SelectorPrevButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton SelectorNextButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr_SelectorNextButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr_SelectorNextButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText SelectorText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr_SelectorText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr_SelectorText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform IndexIndicatorNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr_IndexIndicatorNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr_IndexIndicatorNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SelectorIndexIndicator IndexIndicatorPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr_IndexIndicatorPrefab));
        return pointer == System.IntPtr.Zero ? (SelectorIndexIndicator) null : new SelectorIndexIndicator(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr_IndexIndicatorPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton InfoButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr_InfoButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr_InfoButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton ResetButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr_ResetButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr_ResetButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<int, int> _OnValueChange
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr__OnValueChange));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<int, int>) null : new Il2CppSystem.Action<int, int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr__OnValueChange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _LoopAround
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr__LoopAround));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr__LoopAround)) = value;
      }
    }

    public unsafe bool _UseIndexIndicator
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr__UseIndexIndicator));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr__UseIndexIndicator)) = value;
      }
    }

    public unsafe int _CurrentIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr__CurrentIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr__CurrentIndex)) = value;
      }
    }

    public unsafe List<string> _Keys
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr__Keys));
        return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr__Keys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<SelectorIndexIndicator> _IndexIndicatorCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr__IndexIndicatorCache));
        return pointer == System.IntPtr.Zero ? (UI_Cache<SelectorIndexIndicator>) null : new UI_Cache<SelectorIndexIndicator>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.NativeFieldInfoPtr__IndexIndicatorCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.UI.CustomGameSettings_Selector/<>c__DisplayClass17_0")]
    public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_defValue;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass17_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomGameSettings_Selector.__c__DisplayClass17_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Selector.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161238, XrefRangeEnd = 1161240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Initialize_b__0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CustomGameSettings_Selector.__c__DisplayClass17_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass17_0()
      {
        Il2CppClassPointerStore<CustomGameSettings_Selector.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomGameSettings_Selector>.NativeClassPtr, "<>c__DisplayClass17_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomGameSettings_Selector.__c__DisplayClass17_0>.NativeClassPtr);
        CustomGameSettings_Selector.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Selector.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
        CustomGameSettings_Selector.__c__DisplayClass17_0.NativeFieldInfoPtr_defValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomGameSettings_Selector.__c__DisplayClass17_0>.NativeClassPtr, nameof (defValue));
        CustomGameSettings_Selector.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Selector.__c__DisplayClass17_0>.NativeClassPtr, 100692361);
        CustomGameSettings_Selector.__c__DisplayClass17_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomGameSettings_Selector.__c__DisplayClass17_0>.NativeClassPtr, 100692362);
      }

      public __c__DisplayClass17_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe CustomGameSettings_Selector __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (CustomGameSettings_Selector) null : new CustomGameSettings_Selector(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int defValue
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.__c__DisplayClass17_0.NativeFieldInfoPtr_defValue));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomGameSettings_Selector.__c__DisplayClass17_0.NativeFieldInfoPtr_defValue)) = value;
        }
      }
    }
  }
}
