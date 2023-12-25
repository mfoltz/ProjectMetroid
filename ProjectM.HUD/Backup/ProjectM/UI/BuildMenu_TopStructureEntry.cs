// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BuildMenu_TopStructureEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class BuildMenu_TopStructureEntry : GridSelectionEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GroupEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_Primary;
    private static readonly System.IntPtr NativeFieldInfoPtr_AmountText;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleLimitText;
    private static readonly System.IntPtr NativeFieldInfoPtr_GroupIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_Delimiter_Large;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubStructureLayout;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubStructureLayoutParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_DisabledAlpha;
    private static readonly System.IntPtr NativeFieldInfoPtr__Hovered_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockedChildren;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnStructureClicked;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnGroupClicked;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr__DelimiterRectTransform_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__LayoutGroup_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_BackgroundLayoutGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_LayoutPaddingRight;
    private static readonly System.IntPtr NativeFieldInfoPtr_LayoutPaddingLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartLayoutPaddingRight;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartLayoutPaddingLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr__CanvasGroup;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Hovered_Public_get_BuildMenu_StructureEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Hovered_Private_set_Void_BuildMenu_StructureEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DelimiterRectTransform_Public_get_RectTransform_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_DelimiterRectTransform_Private_set_Void_RectTransform_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LayoutGroup_Public_get_HorizontalLayoutGroup_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LayoutGroup_Private_set_Void_HorizontalLayoutGroup_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHovered_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Internal_Void_BuildMenu_TopStructureEntry_Data_PrefabGUID_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ContainsBlueprint_Public_Boolean_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__31_0_Private_Void_0;

    public unsafe BuildMenu_StructureEntry Hovered
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenu_TopStructureEntry.NativeMethodInfoPtr_get_Hovered_Public_get_BuildMenu_StructureEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (BuildMenu_StructureEntry) null : new BuildMenu_StructureEntry(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenu_TopStructureEntry.NativeMethodInfoPtr_set_Hovered_Private_set_Void_BuildMenu_StructureEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe RectTransform DelimiterRectTransform
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenu_TopStructureEntry.NativeMethodInfoPtr_get_DelimiterRectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenu_TopStructureEntry.NativeMethodInfoPtr_set_DelimiterRectTransform_Private_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe HorizontalLayoutGroup LayoutGroup
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenu_TopStructureEntry.NativeMethodInfoPtr_get_LayoutGroup_Public_get_HorizontalLayoutGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (HorizontalLayoutGroup) null : new HorizontalLayoutGroup(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenu_TopStructureEntry.NativeMethodInfoPtr_set_LayoutGroup_Private_set_Void_HorizontalLayoutGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227881, XrefRangeEnd = 1227903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu_TopStructureEntry.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1227923, RefRangeEnd = 1227924, XrefRangeStart = 1227903, XrefRangeEnd = 1227923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateHovered()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu_TopStructureEntry.NativeMethodInfoPtr_UpdateHovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1228000, RefRangeEnd = 1228001, XrefRangeStart = 1227924, XrefRangeEnd = 1228000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshData(
      BuildMenu_TopStructureEntry_Data data,
      PrefabGUID selectedGroup,
      PrefabGUID selectedStructure)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &selectedGroup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &selectedStructure;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu_TopStructureEntry.NativeMethodInfoPtr_RefreshData_Internal_Void_BuildMenu_TopStructureEntry_Data_PrefabGUID_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1228018, RefRangeEnd = 1228019, XrefRangeStart = 1228001, XrefRangeEnd = 1228018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ContainsBlueprint(PrefabGUID prefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenu_TopStructureEntry.NativeMethodInfoPtr_ContainsBlueprint_Public_Boolean_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228019, XrefRangeEnd = 1228027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BuildMenu_TopStructureEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu_TopStructureEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228027, XrefRangeEnd = 1228032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Awake_b__31_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu_TopStructureEntry.NativeMethodInfoPtr__Awake_b__31_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BuildMenu_TopStructureEntry()
    {
      Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BuildMenu_TopStructureEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr);
      BuildMenu_TopStructureEntry.NativeFieldInfoPtr_GroupEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, nameof (GroupEntryPrefab));
      BuildMenu_TopStructureEntry.NativeFieldInfoPtr_Primary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, nameof (Primary));
      BuildMenu_TopStructureEntry.NativeFieldInfoPtr_AmountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, nameof (AmountText));
      BuildMenu_TopStructureEntry.NativeFieldInfoPtr_CastleLimitText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, nameof (CastleLimitText));
      BuildMenu_TopStructureEntry.NativeFieldInfoPtr_GroupIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, nameof (GroupIcon));
      BuildMenu_TopStructureEntry.NativeFieldInfoPtr_Delimiter_Large = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, nameof (Delimiter_Large));
      BuildMenu_TopStructureEntry.NativeFieldInfoPtr_SubStructureLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, nameof (SubStructureLayout));
      BuildMenu_TopStructureEntry.NativeFieldInfoPtr_SubStructureLayoutParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, nameof (SubStructureLayoutParent));
      BuildMenu_TopStructureEntry.NativeFieldInfoPtr_DisabledAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, nameof (DisabledAlpha));
      BuildMenu_TopStructureEntry.NativeFieldInfoPtr__Hovered_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, "<Hovered>k__BackingField");
      BuildMenu_TopStructureEntry.NativeFieldInfoPtr_UnlockedChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, nameof (UnlockedChildren));
      BuildMenu_TopStructureEntry.NativeFieldInfoPtr_OnStructureClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, nameof (OnStructureClicked));
      BuildMenu_TopStructureEntry.NativeFieldInfoPtr_OnGroupClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, nameof (OnGroupClicked));
      BuildMenu_TopStructureEntry.NativeFieldInfoPtr_SubEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, nameof (SubEntries));
      BuildMenu_TopStructureEntry.NativeFieldInfoPtr__DelimiterRectTransform_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, "<DelimiterRectTransform>k__BackingField");
      BuildMenu_TopStructureEntry.NativeFieldInfoPtr__LayoutGroup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, "<LayoutGroup>k__BackingField");
      BuildMenu_TopStructureEntry.NativeFieldInfoPtr_BackgroundLayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, nameof (BackgroundLayoutGroup));
      BuildMenu_TopStructureEntry.NativeFieldInfoPtr_LayoutPaddingRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, nameof (LayoutPaddingRight));
      BuildMenu_TopStructureEntry.NativeFieldInfoPtr_LayoutPaddingLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, nameof (LayoutPaddingLeft));
      BuildMenu_TopStructureEntry.NativeFieldInfoPtr_StartLayoutPaddingRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, nameof (StartLayoutPaddingRight));
      BuildMenu_TopStructureEntry.NativeFieldInfoPtr_StartLayoutPaddingLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, nameof (StartLayoutPaddingLeft));
      BuildMenu_TopStructureEntry.NativeFieldInfoPtr__CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, nameof (_CanvasGroup));
      BuildMenu_TopStructureEntry.NativeMethodInfoPtr_get_Hovered_Public_get_BuildMenu_StructureEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, 100665112);
      BuildMenu_TopStructureEntry.NativeMethodInfoPtr_set_Hovered_Private_set_Void_BuildMenu_StructureEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, 100665113);
      BuildMenu_TopStructureEntry.NativeMethodInfoPtr_get_DelimiterRectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, 100665114);
      BuildMenu_TopStructureEntry.NativeMethodInfoPtr_set_DelimiterRectTransform_Private_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, 100665115);
      BuildMenu_TopStructureEntry.NativeMethodInfoPtr_get_LayoutGroup_Public_get_HorizontalLayoutGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, 100665116);
      BuildMenu_TopStructureEntry.NativeMethodInfoPtr_set_LayoutGroup_Private_set_Void_HorizontalLayoutGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, 100665117);
      BuildMenu_TopStructureEntry.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, 100665118);
      BuildMenu_TopStructureEntry.NativeMethodInfoPtr_UpdateHovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, 100665119);
      BuildMenu_TopStructureEntry.NativeMethodInfoPtr_RefreshData_Internal_Void_BuildMenu_TopStructureEntry_Data_PrefabGUID_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, 100665120);
      BuildMenu_TopStructureEntry.NativeMethodInfoPtr_ContainsBlueprint_Public_Boolean_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, 100665121);
      BuildMenu_TopStructureEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, 100665122);
      BuildMenu_TopStructureEntry.NativeMethodInfoPtr__Awake_b__31_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, 100665123);
    }

    public BuildMenu_TopStructureEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BuildMenu_StructureEntry GroupEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_GroupEntryPrefab));
        return pointer == System.IntPtr.Zero ? (BuildMenu_StructureEntry) null : new BuildMenu_StructureEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_GroupEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BuildMenu_StructureEntry Primary
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_Primary));
        return pointer == System.IntPtr.Zero ? (BuildMenu_StructureEntry) null : new BuildMenu_StructureEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_Primary), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText AmountText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_AmountText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_AmountText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText CastleLimitText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_CastleLimitText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_CastleLimitText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject GroupIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_GroupIcon));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_GroupIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject Delimiter_Large
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_Delimiter_Large));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_Delimiter_Large), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject SubStructureLayout
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_SubStructureLayout));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_SubStructureLayout), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject SubStructureLayoutParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_SubStructureLayoutParent));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_SubStructureLayoutParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float DisabledAlpha
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_DisabledAlpha));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_DisabledAlpha)) = value;
      }
    }

    public unsafe BuildMenu_StructureEntry _Hovered_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr__Hovered_k__BackingField));
        return pointer == System.IntPtr.Zero ? (BuildMenu_StructureEntry) null : new BuildMenu_StructureEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr__Hovered_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int UnlockedChildren
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_UnlockedChildren));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_UnlockedChildren)) = value;
      }
    }

    public unsafe Il2CppSystem.Action<BuildMenu_StructureEntry> OnStructureClicked
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_OnStructureClicked));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<BuildMenu_StructureEntry>) null : new Il2CppSystem.Action<BuildMenu_StructureEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_OnStructureClicked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action OnGroupClicked
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_OnGroupClicked));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_OnGroupClicked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<BuildMenu_StructureEntry> SubEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_SubEntries));
        return pointer == System.IntPtr.Zero ? (List<BuildMenu_StructureEntry>) null : new List<BuildMenu_StructureEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_SubEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform _DelimiterRectTransform_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr__DelimiterRectTransform_k__BackingField));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr__DelimiterRectTransform_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HorizontalLayoutGroup _LayoutGroup_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr__LayoutGroup_k__BackingField));
        return pointer == System.IntPtr.Zero ? (HorizontalLayoutGroup) null : new HorizontalLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr__LayoutGroup_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HorizontalLayoutGroup BackgroundLayoutGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_BackgroundLayoutGroup));
        return pointer == System.IntPtr.Zero ? (HorizontalLayoutGroup) null : new HorizontalLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_BackgroundLayoutGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int LayoutPaddingRight
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_LayoutPaddingRight));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_LayoutPaddingRight)) = value;
      }
    }

    public unsafe int LayoutPaddingLeft
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_LayoutPaddingLeft));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_LayoutPaddingLeft)) = value;
      }
    }

    public unsafe int StartLayoutPaddingRight
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_StartLayoutPaddingRight));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_StartLayoutPaddingRight)) = value;
      }
    }

    public unsafe int StartLayoutPaddingLeft
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_StartLayoutPaddingLeft));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr_StartLayoutPaddingLeft)) = value;
      }
    }

    public unsafe CanvasGroup _CanvasGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr__CanvasGroup));
        return pointer == System.IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.NativeFieldInfoPtr__CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.UI.BuildMenu_TopStructureEntry/<>c__DisplayClass33_0")]
    public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_subEntry;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__RefreshData_b__0_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass33_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenu_TopStructureEntry.__c__DisplayClass33_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenu_TopStructureEntry.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227877, XrefRangeEnd = 1227881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _RefreshData_b__0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenu_TopStructureEntry.__c__DisplayClass33_0.NativeMethodInfoPtr__RefreshData_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass33_0()
      {
        Il2CppClassPointerStore<BuildMenu_TopStructureEntry.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenu_TopStructureEntry>.NativeClassPtr, "<>c__DisplayClass33_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenu_TopStructureEntry.__c__DisplayClass33_0>.NativeClassPtr);
        BuildMenu_TopStructureEntry.__c__DisplayClass33_0.NativeFieldInfoPtr_subEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry.__c__DisplayClass33_0>.NativeClassPtr, nameof (subEntry));
        BuildMenu_TopStructureEntry.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_TopStructureEntry.__c__DisplayClass33_0>.NativeClassPtr, "<>4__this");
        BuildMenu_TopStructureEntry.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_TopStructureEntry.__c__DisplayClass33_0>.NativeClassPtr, 100665124);
        BuildMenu_TopStructureEntry.__c__DisplayClass33_0.NativeMethodInfoPtr__RefreshData_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_TopStructureEntry.__c__DisplayClass33_0>.NativeClassPtr, 100665125);
      }

      public __c__DisplayClass33_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe BuildMenu_StructureEntry subEntry
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.__c__DisplayClass33_0.NativeFieldInfoPtr_subEntry));
          return pointer == System.IntPtr.Zero ? (BuildMenu_StructureEntry) null : new BuildMenu_StructureEntry(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.__c__DisplayClass33_0.NativeFieldInfoPtr_subEntry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe BuildMenu_TopStructureEntry __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (BuildMenu_TopStructureEntry) null : new BuildMenu_TopStructureEntry(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_TopStructureEntry.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
