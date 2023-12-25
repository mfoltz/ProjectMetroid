// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.GenericSelectionGroup`2
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.EventSystems;

#nullable disable
namespace ProjectM.UI
{
  public class GenericSelectionGroup<TEntry, TData> : SelectionGroupBase<TEntry, TData> where TEntry : GenericSelectionEntry<TData>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OnEntryLeftClicked;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnBeginDragAction;
    private static readonly System.IntPtr NativeFieldInfoPtr__HoveredEntryIndex_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AnyEntryHovered_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HoveredEntryIndex_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_HoveredEntryIndex_Private_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEntryCreated_Protected_Virtual_Void_TEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshInternal_Protected_Virtual_Void_List_1_TData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetHoveredEntry_Public_Boolean_byref_TEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetEntry_Public_Boolean_Int32_byref_TEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe bool AnyEntryHovered
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 1228522, RefRangeEnd = 1228526, XrefRangeStart = 1228522, XrefRangeEnd = 1228522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GenericSelectionGroup<TEntry, TData>.NativeMethodInfoPtr_get_AnyEntryHovered_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int HoveredEntryIndex
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GenericSelectionGroup<TEntry, TData>.NativeMethodInfoPtr_get_HoveredEntryIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GenericSelectionGroup<TEntry, TData>.NativeMethodInfoPtr_set_HoveredEntryIndex_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228526, XrefRangeEnd = 1228542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnEntryCreated(TEntry entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      TEntry& local1;
      if (!typeof (TEntry).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TEntry> local2 = (object) entry;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TEntry&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TEntry&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref entry;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GenericSelectionGroup<TEntry, TData>.NativeMethodInfoPtr_OnEntryCreated_Protected_Virtual_Void_TEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228542, XrefRangeEnd = 1228544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void RefreshInternal(List<TData> data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GenericSelectionGroup<TEntry, TData>.NativeMethodInfoPtr_RefreshInternal_Protected_Virtual_Void_List_1_TData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228544, XrefRangeEnd = 1228545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetHoveredEntry(out TEntry result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      TEntry& local1;
      if (!typeof (TEntry).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(TEntry*) &zero);
      }
      else
        local1 = ref result;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GenericSelectionGroup<TEntry, TData>.NativeMethodInfoPtr_TryGetHoveredEntry_Public_Boolean_byref_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (TEntry).IsValueType)
      {
        ref TEntry local2 = ref result;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TEntry>(objectPointer, false, false);
        local2 = (TEntry) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1228547, RefRangeEnd = 1228549, XrefRangeStart = 1228545, XrefRangeEnd = 1228547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetEntry(int index, out TEntry result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero;
      // ISSUE: variable of a reference type
      TEntry& local1;
      if (!typeof (TEntry).IsValueType)
      {
        zero = System.IntPtr.Zero;
        local1 = ref (*(TEntry*) &zero);
      }
      else
        local1 = ref result;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GenericSelectionGroup<TEntry, TData>.NativeMethodInfoPtr_TryGetEntry_Public_Boolean_Int32_byref_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (TEntry).IsValueType)
      {
        ref TEntry local2 = ref result;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TEntry>(objectPointer, false, false);
        local2 = (TEntry) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 1228550, RefRangeEnd = 1228559, XrefRangeStart = 1228549, XrefRangeEnd = 1228550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GenericSelectionGroup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSelectionGroup<TEntry, TData>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GenericSelectionGroup<TEntry, TData>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GenericSelectionGroup()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<GenericSelectionGroup<TEntry, TData>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", "GenericSelectionGroup`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TData>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSelectionGroup<TEntry, TData>>.NativeClassPtr);
      GenericSelectionGroup<TEntry, TData>.NativeFieldInfoPtr_OnEntryLeftClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionGroup<TEntry, TData>>.NativeClassPtr, nameof (OnEntryLeftClicked));
      GenericSelectionGroup<TEntry, TData>.NativeFieldInfoPtr_OnBeginDragAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionGroup<TEntry, TData>>.NativeClassPtr, nameof (OnBeginDragAction));
      GenericSelectionGroup<TEntry, TData>.NativeFieldInfoPtr__HoveredEntryIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionGroup<TEntry, TData>>.NativeClassPtr, "<HoveredEntryIndex>k__BackingField");
      GenericSelectionGroup<TEntry, TData>.NativeMethodInfoPtr_get_AnyEntryHovered_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionGroup<TEntry, TData>>.NativeClassPtr, 100665165);
      GenericSelectionGroup<TEntry, TData>.NativeMethodInfoPtr_get_HoveredEntryIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionGroup<TEntry, TData>>.NativeClassPtr, 100665166);
      GenericSelectionGroup<TEntry, TData>.NativeMethodInfoPtr_set_HoveredEntryIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionGroup<TEntry, TData>>.NativeClassPtr, 100665167);
      GenericSelectionGroup<TEntry, TData>.NativeMethodInfoPtr_OnEntryCreated_Protected_Virtual_Void_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionGroup<TEntry, TData>>.NativeClassPtr, 100665168);
      GenericSelectionGroup<TEntry, TData>.NativeMethodInfoPtr_RefreshInternal_Protected_Virtual_Void_List_1_TData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionGroup<TEntry, TData>>.NativeClassPtr, 100665169);
      GenericSelectionGroup<TEntry, TData>.NativeMethodInfoPtr_TryGetHoveredEntry_Public_Boolean_byref_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionGroup<TEntry, TData>>.NativeClassPtr, 100665170);
      GenericSelectionGroup<TEntry, TData>.NativeMethodInfoPtr_TryGetEntry_Public_Boolean_Int32_byref_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionGroup<TEntry, TData>>.NativeClassPtr, 100665171);
      GenericSelectionGroup<TEntry, TData>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionGroup<TEntry, TData>>.NativeClassPtr, 100665172);
    }

    public GenericSelectionGroup(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppSystem.Action<int> OnEntryLeftClicked
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericSelectionGroup<TEntry, TData>.NativeFieldInfoPtr_OnEntryLeftClicked));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<int>) null : new Il2CppSystem.Action<int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenericSelectionGroup<TEntry, TData>.NativeFieldInfoPtr_OnEntryLeftClicked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<int, PointerEventData> OnBeginDragAction
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericSelectionGroup<TEntry, TData>.NativeFieldInfoPtr_OnBeginDragAction));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<int, PointerEventData>) null : new Il2CppSystem.Action<int, PointerEventData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenericSelectionGroup<TEntry, TData>.NativeFieldInfoPtr_OnBeginDragAction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _HoveredEntryIndex_k__BackingField
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericSelectionGroup<TEntry, TData>.NativeFieldInfoPtr__HoveredEntryIndex_k__BackingField));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericSelectionGroup<TEntry, TData>.NativeFieldInfoPtr__HoveredEntryIndex_k__BackingField)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UI.GenericSelectionGroup`2/<>c__DisplayClass8_0")]
    public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_entry;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnEntryCreated_b__0_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnEntryCreated_b__1_Internal_Void_PointerEventData_0;

      [CallerCount(653)]
      [CachedScanResults(RefRangeStart = 134013, RefRangeEnd = 134666, XrefRangeStart = 134013, XrefRangeEnd = 134666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSelectionGroup<TEntry, TData>.__c__DisplayClass8_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GenericSelectionGroup<TEntry, TData>.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228516, XrefRangeEnd = 1228519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnEntryCreated_b__0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GenericSelectionGroup<TEntry, TData>.__c__DisplayClass8_0.NativeMethodInfoPtr__OnEntryCreated_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228519, XrefRangeEnd = 1228522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnEntryCreated_b__1(PointerEventData eventData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GenericSelectionGroup<TEntry, TData>.__c__DisplayClass8_0.NativeMethodInfoPtr__OnEntryCreated_b__1_Internal_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_0()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<GenericSelectionGroup<TEntry, TData>.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSelectionGroup<TEntry, TData>>.NativeClassPtr, "<>c__DisplayClass8_0"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr)),
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TData>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSelectionGroup<TEntry, TData>.__c__DisplayClass8_0>.NativeClassPtr);
        GenericSelectionGroup<TEntry, TData>.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionGroup<TEntry, TData>.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
        GenericSelectionGroup<TEntry, TData>.__c__DisplayClass8_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionGroup<TEntry, TData>.__c__DisplayClass8_0>.NativeClassPtr, nameof (entry));
        GenericSelectionGroup<TEntry, TData>.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionGroup<TEntry, TData>.__c__DisplayClass8_0>.NativeClassPtr, 100665173);
        GenericSelectionGroup<TEntry, TData>.__c__DisplayClass8_0.NativeMethodInfoPtr__OnEntryCreated_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionGroup<TEntry, TData>.__c__DisplayClass8_0>.NativeClassPtr, 100665174);
        GenericSelectionGroup<TEntry, TData>.__c__DisplayClass8_0.NativeMethodInfoPtr__OnEntryCreated_b__1_Internal_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionGroup<TEntry, TData>.__c__DisplayClass8_0>.NativeClassPtr, 100665175);
      }

      public __c__DisplayClass8_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe GenericSelectionGroup<TEntry, TData> __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericSelectionGroup<TEntry, TData>.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (GenericSelectionGroup<TEntry, TData>) null : new GenericSelectionGroup<TEntry, TData>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenericSelectionGroup<TEntry, TData>.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe TEntry entry
      {
        get
        {
          return IL2CPP.PointerToValueGeneric<TEntry>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericSelectionGroup<TEntry, TData>.__c__DisplayClass8_0.NativeFieldInfoPtr_entry), true, false);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr targetAddress = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenericSelectionGroup<TEntry, TData>.__c__DisplayClass8_0.NativeFieldInfoPtr_entry);
          System.Type type = typeof (TEntry);
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
            TEntry entry = value;
            *(TEntry*) targetAddress = entry;
          }
        }
      }
    }
  }
}
