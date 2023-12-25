// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.GridSelectionGroup`2
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class GridSelectionGroup<T, E> : Focusable where T : GridSelectionEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__EntryGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr__CanSelectEntries_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnEntryLeftClicked;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnEntryMiddleClicked;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnEntryRightClicked;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnEntryBeginDrag;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnEntryDragAction;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnEntryEndDrag;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnEntrySelected;
    private static readonly System.IntPtr NativeFieldInfoPtr__SelectedEntryIndex_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__HoveredEntryIndex_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputState;
    private static readonly System.IntPtr NativeFieldInfoPtr__Parent;
    private static readonly System.IntPtr NativeFieldInfoPtr__Entries;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnEntryUpdate;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnEntryInitialized;
    private static readonly System.IntPtr NativeFieldInfoPtr__FocusedThisFrame;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CanSelectEntries_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CanSelectEntries_Private_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SelectedEntryIndex_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SelectedEntryIndex_Private_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HoveredEntryIndex_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_HoveredEntryIndex_Private_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AnyEntrySelected_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Entries_Public_get_List_1_E_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSelectedEntry_Public_Boolean_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetHoveredEntry_Public_Boolean_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetEntry_Public_Boolean_Int32_byref_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySelectEntry_Public_Void_Int32_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEntryInitialized_Public_Void_T_E_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_LayoutGroup_Action_2_T_E_Boolean_Action_1_T_List_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResetState_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnFocused_Protected_Virtual_Void_Direction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Public_Void_List_1_E_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeselectEntry_Public_Void_0;

    public unsafe bool CanSelectEntries
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.NativeMethodInfoPtr_get_CanSelectEntries_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.NativeMethodInfoPtr_set_CanSelectEntries_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int SelectedEntryIndex
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.NativeMethodInfoPtr_get_SelectedEntryIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.NativeMethodInfoPtr_set_SelectedEntryIndex_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int HoveredEntryIndex
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.NativeMethodInfoPtr_get_HoveredEntryIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.NativeMethodInfoPtr_set_HoveredEntryIndex_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool AnyEntrySelected
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 1228522, RefRangeEnd = 1228526, XrefRangeStart = 1228522, XrefRangeEnd = 1228526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.NativeMethodInfoPtr_get_AnyEntrySelected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe List<E> Entries
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.NativeMethodInfoPtr_get_Entries_Public_get_List_1_E_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<E>) null : new List<E>(pointer);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1278120, RefRangeEnd = 1278121, XrefRangeStart = 1278071, XrefRangeEnd = 1278120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetSelectedEntry(out T entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(T*) &zero);
      }
      else
        local1 = ref entry;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.NativeMethodInfoPtr_TryGetSelectedEntry_Public_Boolean_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref entry;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1278188, RefRangeEnd = 1278190, XrefRangeStart = 1278121, XrefRangeEnd = 1278188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetHoveredEntry(out T entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(T*) &zero);
      }
      else
        local1 = ref entry;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.NativeMethodInfoPtr_TryGetHoveredEntry_Public_Boolean_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref entry;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1278214, RefRangeEnd = 1278218, XrefRangeStart = 1278190, XrefRangeEnd = 1278214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetEntry(int index, out T entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(T*) &zero);
      }
      else
        local1 = ref entry;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.NativeMethodInfoPtr_TryGetEntry_Public_Boolean_Int32_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref entry;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1278225, RefRangeEnd = 1278231, XrefRangeStart = 1278218, XrefRangeEnd = 1278225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TrySelectEntry(int index, bool sendCallback = true)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sendCallback;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.NativeMethodInfoPtr_TrySelectEntry_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278231, XrefRangeEnd = 1278280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnEntryInitialized(T entry, E data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) entry;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref entry;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      E& local3;
      if (!typeof (E).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<E> local4 = (object) data;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local3 = local4 is string ? (E&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (E&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
      }
      else
        local3 = ref data;
      *(System.IntPtr*) num = (System.IntPtr) ref local3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.NativeMethodInfoPtr_OnEntryInitialized_Public_Void_T_E_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1278308, RefRangeEnd = 1278309, XrefRangeStart = 1278280, XrefRangeEnd = 1278308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GridSelectionGroup(
      T prefab,
      LayoutGroup parent,
      Il2CppSystem.Action<T, E> onEntryUpdate,
      bool canSelectEntries = true,
      Il2CppSystem.Action<T> onEntryInitialized = null,
      List<T> preInstantiatedEntries = null)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr))
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[6];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) prefab;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref prefab;
      *numPtr2 = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onEntryUpdate);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &canSelectEntries;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onEntryInitialized);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) preInstantiatedEntries);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.NativeMethodInfoPtr__ctor_Public_Void_T_LayoutGroup_Action_2_T_E_Boolean_Action_1_T_List_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(52)]
    [CachedScanResults(RefRangeStart = 1278408, RefRangeEnd = 1278460, XrefRangeStart = 1278309, XrefRangeEnd = 1278408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ResetState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.NativeMethodInfoPtr_ResetState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278460, XrefRangeEnd = 1278461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnFocused(Focusable.Direction direction)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &direction;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GridSelectionGroup<T, E>.NativeMethodInfoPtr_OnFocused_Protected_Virtual_Void_Direction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(91)]
    [CachedScanResults(RefRangeStart = 1278463, RefRangeEnd = 1278554, XrefRangeStart = 1278461, XrefRangeEnd = 1278463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Refresh(List<E> entries, bool selectOnMouseDown = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entries);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &selectOnMouseDown;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.NativeMethodInfoPtr_Refresh_Public_Void_List_1_E_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(28)]
    [CachedScanResults(RefRangeStart = 1278609, RefRangeEnd = 1278637, XrefRangeStart = 1278554, XrefRangeEnd = 1278609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.NativeMethodInfoPtr_HandleInput_Public_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 1278693, RefRangeEnd = 1278700, XrefRangeStart = 1278637, XrefRangeEnd = 1278693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeselectEntry()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.NativeMethodInfoPtr_DeselectEntry_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GridSelectionGroup()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", "GridSelectionGroup`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<E>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr);
      GridSelectionGroup<T, E>.NativeFieldInfoPtr__EntryGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, nameof (_EntryGroup));
      GridSelectionGroup<T, E>.NativeFieldInfoPtr__CanSelectEntries_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, "<CanSelectEntries>k__BackingField");
      GridSelectionGroup<T, E>.NativeFieldInfoPtr_OnEntryLeftClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, nameof (OnEntryLeftClicked));
      GridSelectionGroup<T, E>.NativeFieldInfoPtr_OnEntryMiddleClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, nameof (OnEntryMiddleClicked));
      GridSelectionGroup<T, E>.NativeFieldInfoPtr_OnEntryRightClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, nameof (OnEntryRightClicked));
      GridSelectionGroup<T, E>.NativeFieldInfoPtr_OnEntryBeginDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, nameof (OnEntryBeginDrag));
      GridSelectionGroup<T, E>.NativeFieldInfoPtr_OnEntryDragAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, nameof (OnEntryDragAction));
      GridSelectionGroup<T, E>.NativeFieldInfoPtr_OnEntryEndDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, nameof (OnEntryEndDrag));
      GridSelectionGroup<T, E>.NativeFieldInfoPtr_OnEntrySelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, nameof (OnEntrySelected));
      GridSelectionGroup<T, E>.NativeFieldInfoPtr__SelectedEntryIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, "<SelectedEntryIndex>k__BackingField");
      GridSelectionGroup<T, E>.NativeFieldInfoPtr__HoveredEntryIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, "<HoveredEntryIndex>k__BackingField");
      GridSelectionGroup<T, E>.NativeFieldInfoPtr__InputState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, nameof (_InputState));
      GridSelectionGroup<T, E>.NativeFieldInfoPtr__Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, nameof (_Parent));
      GridSelectionGroup<T, E>.NativeFieldInfoPtr__Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, nameof (_Entries));
      GridSelectionGroup<T, E>.NativeFieldInfoPtr__OnEntryUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, nameof (_OnEntryUpdate));
      GridSelectionGroup<T, E>.NativeFieldInfoPtr__OnEntryInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, nameof (_OnEntryInitialized));
      GridSelectionGroup<T, E>.NativeFieldInfoPtr__FocusedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, nameof (_FocusedThisFrame));
      GridSelectionGroup<T, E>.NativeMethodInfoPtr_get_CanSelectEntries_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, 100668770);
      GridSelectionGroup<T, E>.NativeMethodInfoPtr_set_CanSelectEntries_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, 100668771);
      GridSelectionGroup<T, E>.NativeMethodInfoPtr_get_SelectedEntryIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, 100668772);
      GridSelectionGroup<T, E>.NativeMethodInfoPtr_set_SelectedEntryIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, 100668773);
      GridSelectionGroup<T, E>.NativeMethodInfoPtr_get_HoveredEntryIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, 100668774);
      GridSelectionGroup<T, E>.NativeMethodInfoPtr_set_HoveredEntryIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, 100668775);
      GridSelectionGroup<T, E>.NativeMethodInfoPtr_get_AnyEntrySelected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, 100668776);
      GridSelectionGroup<T, E>.NativeMethodInfoPtr_get_Entries_Public_get_List_1_E_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, 100668777);
      GridSelectionGroup<T, E>.NativeMethodInfoPtr_TryGetSelectedEntry_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, 100668778);
      GridSelectionGroup<T, E>.NativeMethodInfoPtr_TryGetHoveredEntry_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, 100668779);
      GridSelectionGroup<T, E>.NativeMethodInfoPtr_TryGetEntry_Public_Boolean_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, 100668780);
      GridSelectionGroup<T, E>.NativeMethodInfoPtr_TrySelectEntry_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, 100668781);
      GridSelectionGroup<T, E>.NativeMethodInfoPtr_OnEntryInitialized_Public_Void_T_E_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, 100668782);
      GridSelectionGroup<T, E>.NativeMethodInfoPtr__ctor_Public_Void_T_LayoutGroup_Action_2_T_E_Boolean_Action_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, 100668783);
      GridSelectionGroup<T, E>.NativeMethodInfoPtr_ResetState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, 100668784);
      GridSelectionGroup<T, E>.NativeMethodInfoPtr_OnFocused_Protected_Virtual_Void_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, 100668785);
      GridSelectionGroup<T, E>.NativeMethodInfoPtr_Refresh_Public_Void_List_1_E_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, 100668786);
      GridSelectionGroup<T, E>.NativeMethodInfoPtr_HandleInput_Public_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, 100668787);
      GridSelectionGroup<T, E>.NativeMethodInfoPtr_DeselectEntry_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, 100668788);
    }

    public GridSelectionGroup(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntryGroup<T, E> _EntryGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr__EntryGroup));
        return pointer == System.IntPtr.Zero ? (EntryGroup<T, E>) null : new EntryGroup<T, E>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr__EntryGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _CanSelectEntries_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr__CanSelectEntries_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr__CanSelectEntries_k__BackingField)) = value;
      }
    }

    public unsafe Il2CppSystem.Action<int> OnEntryLeftClicked
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr_OnEntryLeftClicked));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<int>) null : new Il2CppSystem.Action<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr_OnEntryLeftClicked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<int> OnEntryMiddleClicked
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr_OnEntryMiddleClicked));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<int>) null : new Il2CppSystem.Action<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr_OnEntryMiddleClicked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<int> OnEntryRightClicked
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr_OnEntryRightClicked));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<int>) null : new Il2CppSystem.Action<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr_OnEntryRightClicked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<int, PointerEventData> OnEntryBeginDrag
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr_OnEntryBeginDrag));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<int, PointerEventData>) null : new Il2CppSystem.Action<int, PointerEventData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr_OnEntryBeginDrag), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<int, PointerEventData> OnEntryDragAction
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr_OnEntryDragAction));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<int, PointerEventData>) null : new Il2CppSystem.Action<int, PointerEventData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr_OnEntryDragAction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<int> OnEntryEndDrag
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr_OnEntryEndDrag));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<int>) null : new Il2CppSystem.Action<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr_OnEntryEndDrag), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<int, int> OnEntrySelected
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr_OnEntrySelected));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<int, int>) null : new Il2CppSystem.Action<int, int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr_OnEntrySelected), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _SelectedEntryIndex_k__BackingField
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr__SelectedEntryIndex_k__BackingField));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr__SelectedEntryIndex_k__BackingField)) = value;
      }
    }

    public unsafe int _HoveredEntryIndex_k__BackingField
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr__HoveredEntryIndex_k__BackingField));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr__HoveredEntryIndex_k__BackingField)) = value;
      }
    }

    public unsafe InputState _InputState
    {
      get
      {
        return *(InputState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr__InputState));
      }
      [param: In] set
      {
        *(InputState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr__InputState)) = value;
      }
    }

    public unsafe LayoutGroup _Parent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr__Parent));
        return pointer == System.IntPtr.Zero ? (LayoutGroup) null : new LayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr__Parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<E> _Entries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr__Entries));
        return pointer == System.IntPtr.Zero ? (List<E>) null : new List<E>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr__Entries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<T, E> _OnEntryUpdate
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr__OnEntryUpdate));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<T, E>) null : new Il2CppSystem.Action<T, E>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr__OnEntryUpdate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<T> _OnEntryInitialized
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr__OnEntryInitialized));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<T>) null : new Il2CppSystem.Action<T>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr__OnEntryInitialized), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _FocusedThisFrame
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr__FocusedThisFrame));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.NativeFieldInfoPtr__FocusedThisFrame)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UI.GridSelectionGroup`2/<>c__DisplayClass33_0")]
    public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_entry;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnEntryInitialized_b__0_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnEntryInitialized_b__1_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnEntryInitialized_b__2_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnEntryInitialized_b__3_Internal_Void_PointerEventData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnEntryInitialized_b__4_Internal_Void_PointerEventData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnEntryInitialized_b__6_Internal_Void_0;

      [CallerCount(653)]
      [CachedScanResults(RefRangeStart = 134013, RefRangeEnd = 134666, XrefRangeStart = 134013, XrefRangeEnd = 134666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass33_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridSelectionGroup<T, E>.__c__DisplayClass33_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278053, XrefRangeEnd = 1278056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnEntryInitialized_b__0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.__c__DisplayClass33_0.NativeMethodInfoPtr__OnEntryInitialized_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278056, XrefRangeEnd = 1278059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnEntryInitialized_b__1()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.__c__DisplayClass33_0.NativeMethodInfoPtr__OnEntryInitialized_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278059, XrefRangeEnd = 1278062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnEntryInitialized_b__2()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.__c__DisplayClass33_0.NativeMethodInfoPtr__OnEntryInitialized_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278062, XrefRangeEnd = 1278065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnEntryInitialized_b__3(PointerEventData eventData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.__c__DisplayClass33_0.NativeMethodInfoPtr__OnEntryInitialized_b__3_Internal_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278065, XrefRangeEnd = 1278068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnEntryInitialized_b__4(PointerEventData eventData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.__c__DisplayClass33_0.NativeMethodInfoPtr__OnEntryInitialized_b__4_Internal_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278068, XrefRangeEnd = 1278071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnEntryInitialized_b__6()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.__c__DisplayClass33_0.NativeMethodInfoPtr__OnEntryInitialized_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass33_0()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<GridSelectionGroup<T, E>.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, "<>c__DisplayClass33_0"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<E>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridSelectionGroup<T, E>.__c__DisplayClass33_0>.NativeClassPtr);
        GridSelectionGroup<T, E>.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSelectionGroup<T, E>.__c__DisplayClass33_0>.NativeClassPtr, "<>4__this");
        GridSelectionGroup<T, E>.__c__DisplayClass33_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSelectionGroup<T, E>.__c__DisplayClass33_0>.NativeClassPtr, nameof (entry));
        GridSelectionGroup<T, E>.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>.__c__DisplayClass33_0>.NativeClassPtr, 100668789);
        GridSelectionGroup<T, E>.__c__DisplayClass33_0.NativeMethodInfoPtr__OnEntryInitialized_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>.__c__DisplayClass33_0>.NativeClassPtr, 100668790);
        GridSelectionGroup<T, E>.__c__DisplayClass33_0.NativeMethodInfoPtr__OnEntryInitialized_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>.__c__DisplayClass33_0>.NativeClassPtr, 100668791);
        GridSelectionGroup<T, E>.__c__DisplayClass33_0.NativeMethodInfoPtr__OnEntryInitialized_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>.__c__DisplayClass33_0>.NativeClassPtr, 100668792);
        GridSelectionGroup<T, E>.__c__DisplayClass33_0.NativeMethodInfoPtr__OnEntryInitialized_b__3_Internal_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>.__c__DisplayClass33_0>.NativeClassPtr, 100668793);
        GridSelectionGroup<T, E>.__c__DisplayClass33_0.NativeMethodInfoPtr__OnEntryInitialized_b__4_Internal_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>.__c__DisplayClass33_0>.NativeClassPtr, 100668794);
        GridSelectionGroup<T, E>.__c__DisplayClass33_0.NativeMethodInfoPtr__OnEntryInitialized_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>.__c__DisplayClass33_0>.NativeClassPtr, 100668795);
      }

      public __c__DisplayClass33_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe GridSelectionGroup<T, E> __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (GridSelectionGroup<T, E>) null : new GridSelectionGroup<T, E>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe T entry
      {
        get
        {
          return IL2CPP.PointerToValueGeneric<T>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.__c__DisplayClass33_0.NativeFieldInfoPtr_entry), true, false);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr targetAddress = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GridSelectionGroup<T, E>.__c__DisplayClass33_0.NativeFieldInfoPtr_entry);
          System.Type type = typeof (T);
          if (!type.IsValueType)
          {
            if (!string.Equals(type.FullName, "System.String"))
            {
              System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((object) value as Il2CppObjectBase);
              if (ptr != System.IntPtr.Zero && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)))
              {
                System.IntPtr num1 = ptr;
                System.IntPtr num2 = IL2CPP.il2cpp_object_unbox(ptr);
                int num3 = IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(num1), (uint&) System.IntPtr.Zero);
                __memcpy(targetAddress, num2, num3);
              }
              else
                IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, targetAddress, ptr);
            }
            else
            {
              System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp((object) value as string);
              IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, targetAddress, il2Cpp);
            }
          }
          else
          {
            T obj = value;
            *(T*) targetAddress = obj;
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.GridSelectionGroup`2/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__33_5;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnEntryInitialized_b__33_5_Internal_Void_0;

      [CallerCount(653)]
      [CachedScanResults(RefRangeStart = 134013, RefRangeEnd = 134666, XrefRangeStart = 134013, XrefRangeEnd = 134666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridSelectionGroup<T, E>.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnEntryInitialized_b__33_5()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GridSelectionGroup<T, E>.__c.NativeMethodInfoPtr__OnEntryInitialized_b__33_5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<GridSelectionGroup<T, E>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GridSelectionGroup<T, E>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<E>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridSelectionGroup<T, E>.__c>.NativeClassPtr);
        GridSelectionGroup<T, E>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSelectionGroup<T, E>.__c>.NativeClassPtr, "<>9");
        GridSelectionGroup<T, E>.__c.NativeFieldInfoPtr___9__33_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridSelectionGroup<T, E>.__c>.NativeClassPtr, "<>9__33_5");
        GridSelectionGroup<T, E>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>.__c>.NativeClassPtr, 100668797);
        GridSelectionGroup<T, E>.__c.NativeMethodInfoPtr__OnEntryInitialized_b__33_5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridSelectionGroup<T, E>.__c>.NativeClassPtr, 100668798);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe GridSelectionGroup<T, E>.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GridSelectionGroup<T, E>.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (GridSelectionGroup<T, E>.__c) null : new GridSelectionGroup<T, E>.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GridSelectionGroup<T, E>.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action __9__33_5
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GridSelectionGroup<T, E>.__c.NativeFieldInfoPtr___9__33_5, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GridSelectionGroup<T, E>.__c.NativeFieldInfoPtr___9__33_5, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
