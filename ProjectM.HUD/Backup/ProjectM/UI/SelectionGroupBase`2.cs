// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SelectionGroupBase`2
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class SelectionGroupBase<TEntry, TData> : MonoBehaviour where TEntry : GridSelectionEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entries;
    private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Internal_Void_List_1_TData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshInternal_Protected_Abstract_Virtual_New_Void_List_1_TData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEntryCreated_Protected_Abstract_Virtual_New_Void_TEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1228704, RefRangeEnd = 1228705, XrefRangeStart = 1228686, XrefRangeEnd = 1228704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Refresh(List<TData> data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SelectionGroupBase<TEntry, TData>.NativeMethodInfoPtr_Refresh_Internal_Void_List_1_TData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void RefreshInternal(List<TData> data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SelectionGroupBase<TEntry, TData>.NativeMethodInfoPtr_RefreshInternal_Protected_Abstract_Virtual_New_Void_List_1_TData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void OnEntryCreated(TEntry entry)
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SelectionGroupBase<TEntry, TData>.NativeMethodInfoPtr_OnEntryCreated_Protected_Abstract_Virtual_New_Void_TEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1228709, RefRangeEnd = 1228711, XrefRangeStart = 1228705, XrefRangeEnd = 1228709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SelectionGroupBase()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionGroupBase<TEntry, TData>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SelectionGroupBase<TEntry, TData>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SelectionGroupBase()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<SelectionGroupBase<TEntry, TData>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", "SelectionGroupBase`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TData>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionGroupBase<TEntry, TData>>.NativeClassPtr);
      SelectionGroupBase<TEntry, TData>.NativeFieldInfoPtr_EntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionGroupBase<TEntry, TData>>.NativeClassPtr, nameof (EntryPrefab));
      SelectionGroupBase<TEntry, TData>.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionGroupBase<TEntry, TData>>.NativeClassPtr, nameof (Entries));
      SelectionGroupBase<TEntry, TData>.NativeMethodInfoPtr_Refresh_Internal_Void_List_1_TData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionGroupBase<TEntry, TData>>.NativeClassPtr, 100665193);
      SelectionGroupBase<TEntry, TData>.NativeMethodInfoPtr_RefreshInternal_Protected_Abstract_Virtual_New_Void_List_1_TData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionGroupBase<TEntry, TData>>.NativeClassPtr, 100665194);
      SelectionGroupBase<TEntry, TData>.NativeMethodInfoPtr_OnEntryCreated_Protected_Abstract_Virtual_New_Void_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionGroupBase<TEntry, TData>>.NativeClassPtr, 100665195);
      SelectionGroupBase<TEntry, TData>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionGroupBase<TEntry, TData>>.NativeClassPtr, 100665196);
    }

    public SelectionGroupBase(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TEntry EntryPrefab
    {
      get
      {
        return IL2CPP.PointerToValueGeneric<TEntry>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectionGroupBase<TEntry, TData>.NativeFieldInfoPtr_EntryPrefab), true, false);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr targetAddress = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectionGroupBase<TEntry, TData>.NativeFieldInfoPtr_EntryPrefab);
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

    public unsafe List<TEntry> Entries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectionGroupBase<TEntry, TData>.NativeFieldInfoPtr_Entries));
        return pointer == System.IntPtr.Zero ? (List<TEntry>) null : new List<TEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectionGroupBase<TEntry, TData>.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
