// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BuildMenu_StructureSelectionGroup
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
  public class BuildMenu_StructureSelectionGroup : 
    SelectionGroupBase<BuildMenu_TopStructureEntry, BuildMenu_TopStructureEntry_Data>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedGroup_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedStructure_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__HoveredEntry_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectFirstSubEntryNextRefresh;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForceRebuildLayoutNextRefresh;
    private static readonly System.IntPtr NativeFieldInfoPtr__LayoutGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr__PreviousDataCount;
    private static readonly System.IntPtr NativeFieldInfoPtr__OffsetEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr__RectTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnEntryClicked;
    private static readonly System.IntPtr NativeFieldInfoPtr_LEFT_PIVOT_ITEM_THRESHOLD;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SelectedGroup_Public_get_BuildMenu_TopStructureEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SelectedGroup_Private_set_Void_BuildMenu_TopStructureEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SelectedStructure_Public_get_BuildMenu_StructureEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SelectedStructure_Private_set_Void_BuildMenu_StructureEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HoveredEntry_Public_get_BuildMenu_StructureEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_HoveredEntry_Private_set_Void_BuildMenu_StructureEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AnyEntrySelected_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AnyEntryHovered_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSelectedStructure_Public_Boolean_byref_BuildMenu_StructureEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetHoveredEntry_Public_Boolean_byref_BuildMenu_StructureEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResetState_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePivot_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetOffset_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleStructureClicked_Private_Void_BuildMenu_StructureEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleGroupClicked_Private_Void_BuildMenu_TopStructureEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshInternal_Protected_Virtual_Void_List_1_BuildMenu_TopStructureEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeselectEntry_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEntryCreated_Protected_Virtual_Void_BuildMenu_TopStructureEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe BuildMenu_TopStructureEntry SelectedGroup
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 22440, RefRangeEnd = 22452, XrefRangeStart = 22440, XrefRangeEnd = 22452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_get_SelectedGroup_Public_get_BuildMenu_TopStructureEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (BuildMenu_TopStructureEntry) null : new BuildMenu_TopStructureEntry(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_set_SelectedGroup_Private_set_Void_BuildMenu_TopStructureEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe BuildMenu_StructureEntry SelectedStructure
    {
      [CallerCount(343), CachedScanResults(RefRangeStart = 22462, RefRangeEnd = 22805, XrefRangeStart = 22462, XrefRangeEnd = 22805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_get_SelectedStructure_Public_get_BuildMenu_StructureEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_set_SelectedStructure_Private_set_Void_BuildMenu_StructureEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe BuildMenu_StructureEntry HoveredEntry
    {
      [CallerCount(7), CachedScanResults(RefRangeStart = 22398, RefRangeEnd = 22405, XrefRangeStart = 22398, XrefRangeEnd = 22405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_get_HoveredEntry_Public_get_BuildMenu_StructureEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (BuildMenu_StructureEntry) null : new BuildMenu_StructureEntry(pointer);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 23675, RefRangeEnd = 23677, XrefRangeStart = 23675, XrefRangeEnd = 23677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_set_HoveredEntry_Private_set_Void_BuildMenu_StructureEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool AnyEntrySelected
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 1227739, RefRangeEnd = 1227741, XrefRangeStart = 1227736, XrefRangeEnd = 1227739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_get_AnyEntrySelected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool AnyEntryHovered
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1227744, RefRangeEnd = 1227745, XrefRangeStart = 1227741, XrefRangeEnd = 1227744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_get_AnyEntryHovered_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227745, XrefRangeEnd = 1227753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1227756, RefRangeEnd = 1227758, XrefRangeStart = 1227753, XrefRangeEnd = 1227756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetSelectedStructure(out BuildMenu_StructureEntry result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_TryGetSelectedStructure_Public_Boolean_byref_BuildMenu_StructureEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref BuildMenu_StructureEntry local = ref result;
      System.IntPtr pointer = zero;
      BuildMenu_StructureEntry menuStructureEntry = pointer == System.IntPtr.Zero ? (BuildMenu_StructureEntry) null : new BuildMenu_StructureEntry(pointer);
      local = menuStructureEntry;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1227761, RefRangeEnd = 1227762, XrefRangeStart = 1227758, XrefRangeEnd = 1227761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetHoveredEntry(out BuildMenu_StructureEntry result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_TryGetHoveredEntry_Public_Boolean_byref_BuildMenu_StructureEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref BuildMenu_StructureEntry local = ref result;
      System.IntPtr pointer = zero;
      BuildMenu_StructureEntry menuStructureEntry = pointer == System.IntPtr.Zero ? (BuildMenu_StructureEntry) null : new BuildMenu_StructureEntry(pointer);
      local = menuStructureEntry;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1227767, RefRangeEnd = 1227772, XrefRangeStart = 1227762, XrefRangeEnd = 1227767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ResetState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_ResetState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227772, XrefRangeEnd = 1227773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdatePivot(int dataCount)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &dataCount;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_UpdatePivot_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227773, XrefRangeEnd = 1227775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetOffset(int value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_SetOffset_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1227783, RefRangeEnd = 1227784, XrefRangeStart = 1227775, XrefRangeEnd = 1227783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleStructureClicked(BuildMenu_StructureEntry entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_HandleStructureClicked_Private_Void_BuildMenu_StructureEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1227799, RefRangeEnd = 1227800, XrefRangeStart = 1227784, XrefRangeEnd = 1227799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleGroupClicked(BuildMenu_TopStructureEntry entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_HandleGroupClicked_Private_Void_BuildMenu_TopStructureEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227800, XrefRangeEnd = 1227838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void RefreshInternal(List<BuildMenu_TopStructureEntry_Data> data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_RefreshInternal_Protected_Virtual_Void_List_1_BuildMenu_TopStructureEntry_Data_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1227839, RefRangeEnd = 1227840, XrefRangeStart = 1227838, XrefRangeEnd = 1227839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeselectEntry()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_DeselectEntry_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227840, XrefRangeEnd = 1227863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEntryCreated(BuildMenu_TopStructureEntry entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_OnEntryCreated_Protected_Virtual_Void_BuildMenu_TopStructureEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227863, XrefRangeEnd = 1227866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BuildMenu_StructureSelectionGroup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BuildMenu_StructureSelectionGroup()
    {
      Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BuildMenu_StructureSelectionGroup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr);
      BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr__SelectedGroup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, "<SelectedGroup>k__BackingField");
      BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr__SelectedStructure_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, "<SelectedStructure>k__BackingField");
      BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr__HoveredEntry_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, "<HoveredEntry>k__BackingField");
      BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr_SelectFirstSubEntryNextRefresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, nameof (SelectFirstSubEntryNextRefresh));
      BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr_ForceRebuildLayoutNextRefresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, nameof (ForceRebuildLayoutNextRefresh));
      BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr__LayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, nameof (_LayoutGroup));
      BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr__PreviousDataCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, nameof (_PreviousDataCount));
      BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr__OffsetEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, nameof (_OffsetEnabled));
      BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr__RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, nameof (_RectTransform));
      BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr_OnEntryClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, nameof (OnEntryClicked));
      BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr_LEFT_PIVOT_ITEM_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, nameof (LEFT_PIVOT_ITEM_THRESHOLD));
      BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_get_SelectedGroup_Public_get_BuildMenu_TopStructureEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, 100665086);
      BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_set_SelectedGroup_Private_set_Void_BuildMenu_TopStructureEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, 100665087);
      BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_get_SelectedStructure_Public_get_BuildMenu_StructureEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, 100665088);
      BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_set_SelectedStructure_Private_set_Void_BuildMenu_StructureEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, 100665089);
      BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_get_HoveredEntry_Public_get_BuildMenu_StructureEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, 100665090);
      BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_set_HoveredEntry_Private_set_Void_BuildMenu_StructureEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, 100665091);
      BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_get_AnyEntrySelected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, 100665092);
      BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_get_AnyEntryHovered_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, 100665093);
      BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, 100665094);
      BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_TryGetSelectedStructure_Public_Boolean_byref_BuildMenu_StructureEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, 100665095);
      BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_TryGetHoveredEntry_Public_Boolean_byref_BuildMenu_StructureEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, 100665096);
      BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_ResetState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, 100665097);
      BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_UpdatePivot_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, 100665098);
      BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_SetOffset_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, 100665099);
      BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_HandleStructureClicked_Private_Void_BuildMenu_StructureEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, 100665100);
      BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_HandleGroupClicked_Private_Void_BuildMenu_TopStructureEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, 100665101);
      BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_RefreshInternal_Protected_Virtual_Void_List_1_BuildMenu_TopStructureEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, 100665102);
      BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_DeselectEntry_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, 100665103);
      BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr_OnEntryCreated_Protected_Virtual_Void_BuildMenu_TopStructureEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, 100665104);
      BuildMenu_StructureSelectionGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, 100665105);
    }

    public BuildMenu_StructureSelectionGroup(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BuildMenu_TopStructureEntry _SelectedGroup_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr__SelectedGroup_k__BackingField));
        return pointer == System.IntPtr.Zero ? (BuildMenu_TopStructureEntry) null : new BuildMenu_TopStructureEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr__SelectedGroup_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BuildMenu_StructureEntry _SelectedStructure_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr__SelectedStructure_k__BackingField));
        return pointer == System.IntPtr.Zero ? (BuildMenu_StructureEntry) null : new BuildMenu_StructureEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr__SelectedStructure_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BuildMenu_StructureEntry _HoveredEntry_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr__HoveredEntry_k__BackingField));
        return pointer == System.IntPtr.Zero ? (BuildMenu_StructureEntry) null : new BuildMenu_StructureEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr__HoveredEntry_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BuildMenu_TopStructureEntry SelectFirstSubEntryNextRefresh
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr_SelectFirstSubEntryNextRefresh));
        return pointer == System.IntPtr.Zero ? (BuildMenu_TopStructureEntry) null : new BuildMenu_TopStructureEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr_SelectFirstSubEntryNextRefresh), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool ForceRebuildLayoutNextRefresh
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr_ForceRebuildLayoutNextRefresh));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr_ForceRebuildLayoutNextRefresh)) = value;
      }
    }

    public unsafe HorizontalLayoutGroup _LayoutGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr__LayoutGroup));
        return pointer == System.IntPtr.Zero ? (HorizontalLayoutGroup) null : new HorizontalLayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr__LayoutGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _PreviousDataCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr__PreviousDataCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr__PreviousDataCount)) = value;
      }
    }

    public unsafe bool _OffsetEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr__OffsetEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr__OffsetEnabled)) = value;
      }
    }

    public unsafe RectTransform _RectTransform
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr__RectTransform));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr__RectTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action OnEntryClicked
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr_OnEntryClicked));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr_OnEntryClicked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe int LEFT_PIVOT_ITEM_THRESHOLD
    {
      get
      {
        int pivotItemThreshold;
        IL2CPP.il2cpp_field_static_get_value(BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr_LEFT_PIVOT_ITEM_THRESHOLD, (void*) &pivotItemThreshold);
        return pivotItemThreshold;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BuildMenu_StructureSelectionGroup.NativeFieldInfoPtr_LEFT_PIVOT_ITEM_THRESHOLD, (void*) &value);
      }
    }

    [ObfuscatedName("ProjectM.UI.BuildMenu_StructureSelectionGroup/<>c__DisplayClass34_0")]
    public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_entry;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnEntryCreated_b__0_Internal_Void_BuildMenu_StructureEntry_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnEntryCreated_b__1_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass34_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup.__c__DisplayClass34_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureSelectionGroup.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227732, XrefRangeEnd = 1227734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnEntryCreated_b__0(BuildMenu_StructureEntry entry)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureSelectionGroup.__c__DisplayClass34_0.NativeMethodInfoPtr__OnEntryCreated_b__0_Internal_Void_BuildMenu_StructureEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227734, XrefRangeEnd = 1227736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnEntryCreated_b__1()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BuildMenu_StructureSelectionGroup.__c__DisplayClass34_0.NativeMethodInfoPtr__OnEntryCreated_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass34_0()
      {
        Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup>.NativeClassPtr, "<>c__DisplayClass34_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup.__c__DisplayClass34_0>.NativeClassPtr);
        BuildMenu_StructureSelectionGroup.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup.__c__DisplayClass34_0>.NativeClassPtr, "<>4__this");
        BuildMenu_StructureSelectionGroup.__c__DisplayClass34_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup.__c__DisplayClass34_0>.NativeClassPtr, nameof (entry));
        BuildMenu_StructureSelectionGroup.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup.__c__DisplayClass34_0>.NativeClassPtr, 100665106);
        BuildMenu_StructureSelectionGroup.__c__DisplayClass34_0.NativeMethodInfoPtr__OnEntryCreated_b__0_Internal_Void_BuildMenu_StructureEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup.__c__DisplayClass34_0>.NativeClassPtr, 100665107);
        BuildMenu_StructureSelectionGroup.__c__DisplayClass34_0.NativeMethodInfoPtr__OnEntryCreated_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildMenu_StructureSelectionGroup.__c__DisplayClass34_0>.NativeClassPtr, 100665108);
      }

      public __c__DisplayClass34_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe BuildMenu_StructureSelectionGroup __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (BuildMenu_StructureSelectionGroup) null : new BuildMenu_StructureSelectionGroup(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe BuildMenu_TopStructureEntry entry
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.__c__DisplayClass34_0.NativeFieldInfoPtr_entry));
          return pointer == System.IntPtr.Zero ? (BuildMenu_TopStructureEntry) null : new BuildMenu_TopStructureEntry(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildMenu_StructureSelectionGroup.__c__DisplayClass34_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
