// Decompiled with JetBrains decompiler
// Type: StunShared.UI.EntryGroupBase`2
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace StunShared.UI
{
  public class EntryGroupBase<T, E> : Il2CppSystem.Object where T : UIEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OnEntryInitialized;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnEntryUpdate;
    private static readonly System.IntPtr NativeFieldInfoPtr__EntryCache;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedLayoutGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedVerticalContentSizeFitter;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedHorizontalContentSizeFitter;
    private static readonly System.IntPtr NativeFieldInfoPtr__PreviousLength;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EntryCache_Public_get_UI_Cache_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Parent_Public_get_RectTransform_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntry_Public_T_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_StartIndex_Protected_Virtual_New_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EndIndex_Protected_Virtual_New_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_RectTransform_Int32_List_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshEntries_Public_Void_NativeArray_1_E_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshEntries_Public_Void_List_1_E_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

    public unsafe UI_Cache<T> EntryCache
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntryGroupBase<T, E>.NativeMethodInfoPtr_get_EntryCache_Public_get_UI_Cache_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (UI_Cache<T>) null : new UI_Cache<T>(pointer);
      }
    }

    public unsafe RectTransform Parent
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntryGroupBase<T, E>.NativeMethodInfoPtr_get_Parent_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
    }

    [CallerCount(0)]
    public unsafe T GetEntry(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(EntryGroupBase<T, E>.NativeMethodInfoPtr_GetEntry_Public_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    public virtual unsafe int StartIndex
    {
      [CallerCount(1474), CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EntryGroupBase<T, E>.NativeMethodInfoPtr_get_StartIndex_Protected_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public virtual unsafe int EndIndex
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 55746, RefRangeEnd = 55747, XrefRangeStart = 55746, XrefRangeEnd = 55747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EntryGroupBase<T, E>.NativeMethodInfoPtr_get_EndIndex_Protected_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717481, XrefRangeEnd = 717631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EntryGroupBase(
      T prefab,
      RectTransform parent,
      int cachedEntries = -1,
      List<T> preInstantiatedEntries = null)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntryGroupBase<T, E>>.NativeClassPtr))
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
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
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &cachedEntries;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) preInstantiatedEntries);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntryGroupBase<T, E>.NativeMethodInfoPtr__ctor_Public_Void_T_RectTransform_Int32_List_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717631, XrefRangeEnd = 717658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshEntries(NativeArray<E> entryData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entryData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntryGroupBase<T, E>.NativeMethodInfoPtr_RefreshEntries_Public_Void_NativeArray_1_E_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 717685, RefRangeEnd = 717686, XrefRangeStart = 717658, XrefRangeEnd = 717685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshEntries(List<E> entryData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entryData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntryGroupBase<T, E>.NativeMethodInfoPtr_RefreshEntries_Public_Void_List_1_E_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 717687, RefRangeEnd = 717688, XrefRangeStart = 717686, XrefRangeEnd = 717687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Destroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntryGroupBase<T, E>.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EntryGroupBase()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<EntryGroupBase<T, E>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "StunShared.UI", "EntryGroupBase`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<E>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntryGroupBase<T, E>>.NativeClassPtr);
      EntryGroupBase<T, E>.NativeFieldInfoPtr_OnEntryInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntryGroupBase<T, E>>.NativeClassPtr, nameof (OnEntryInitialized));
      EntryGroupBase<T, E>.NativeFieldInfoPtr_OnEntryUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntryGroupBase<T, E>>.NativeClassPtr, nameof (OnEntryUpdate));
      EntryGroupBase<T, E>.NativeFieldInfoPtr__EntryCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntryGroupBase<T, E>>.NativeClassPtr, nameof (_EntryCache));
      EntryGroupBase<T, E>.NativeFieldInfoPtr__CachedLayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntryGroupBase<T, E>>.NativeClassPtr, nameof (_CachedLayoutGroup));
      EntryGroupBase<T, E>.NativeFieldInfoPtr__CachedVerticalContentSizeFitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntryGroupBase<T, E>>.NativeClassPtr, nameof (_CachedVerticalContentSizeFitter));
      EntryGroupBase<T, E>.NativeFieldInfoPtr__CachedHorizontalContentSizeFitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntryGroupBase<T, E>>.NativeClassPtr, nameof (_CachedHorizontalContentSizeFitter));
      EntryGroupBase<T, E>.NativeFieldInfoPtr__PreviousLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntryGroupBase<T, E>>.NativeClassPtr, nameof (_PreviousLength));
      EntryGroupBase<T, E>.NativeMethodInfoPtr_get_EntryCache_Public_get_UI_Cache_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntryGroupBase<T, E>>.NativeClassPtr, 100663545);
      EntryGroupBase<T, E>.NativeMethodInfoPtr_get_Parent_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntryGroupBase<T, E>>.NativeClassPtr, 100663546);
      EntryGroupBase<T, E>.NativeMethodInfoPtr_GetEntry_Public_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntryGroupBase<T, E>>.NativeClassPtr, 100663547);
      EntryGroupBase<T, E>.NativeMethodInfoPtr_get_StartIndex_Protected_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntryGroupBase<T, E>>.NativeClassPtr, 100663548);
      EntryGroupBase<T, E>.NativeMethodInfoPtr_get_EndIndex_Protected_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntryGroupBase<T, E>>.NativeClassPtr, 100663549);
      EntryGroupBase<T, E>.NativeMethodInfoPtr__ctor_Public_Void_T_RectTransform_Int32_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntryGroupBase<T, E>>.NativeClassPtr, 100663550);
      EntryGroupBase<T, E>.NativeMethodInfoPtr_RefreshEntries_Public_Void_NativeArray_1_E_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntryGroupBase<T, E>>.NativeClassPtr, 100663551);
      EntryGroupBase<T, E>.NativeMethodInfoPtr_RefreshEntries_Public_Void_List_1_E_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntryGroupBase<T, E>>.NativeClassPtr, 100663552);
      EntryGroupBase<T, E>.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntryGroupBase<T, E>>.NativeClassPtr, 100663553);
    }

    public EntryGroupBase(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppSystem.Action<T, E> OnEntryInitialized
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntryGroupBase<T, E>.NativeFieldInfoPtr_OnEntryInitialized));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<T, E>) null : new Il2CppSystem.Action<T, E>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EntryGroupBase<T, E>.NativeFieldInfoPtr_OnEntryInitialized), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<T, E> OnEntryUpdate
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntryGroupBase<T, E>.NativeFieldInfoPtr_OnEntryUpdate));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<T, E>) null : new Il2CppSystem.Action<T, E>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EntryGroupBase<T, E>.NativeFieldInfoPtr_OnEntryUpdate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<T> _EntryCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntryGroupBase<T, E>.NativeFieldInfoPtr__EntryCache));
        return pointer == System.IntPtr.Zero ? (UI_Cache<T>) null : new UI_Cache<T>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EntryGroupBase<T, E>.NativeFieldInfoPtr__EntryCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LayoutGroup _CachedLayoutGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntryGroupBase<T, E>.NativeFieldInfoPtr__CachedLayoutGroup));
        return pointer == System.IntPtr.Zero ? (LayoutGroup) null : new LayoutGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EntryGroupBase<T, E>.NativeFieldInfoPtr__CachedLayoutGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ContentSizeFitter _CachedVerticalContentSizeFitter
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntryGroupBase<T, E>.NativeFieldInfoPtr__CachedVerticalContentSizeFitter));
        return pointer == System.IntPtr.Zero ? (ContentSizeFitter) null : new ContentSizeFitter(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EntryGroupBase<T, E>.NativeFieldInfoPtr__CachedVerticalContentSizeFitter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ContentSizeFitter _CachedHorizontalContentSizeFitter
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntryGroupBase<T, E>.NativeFieldInfoPtr__CachedHorizontalContentSizeFitter));
        return pointer == System.IntPtr.Zero ? (ContentSizeFitter) null : new ContentSizeFitter(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EntryGroupBase<T, E>.NativeFieldInfoPtr__CachedHorizontalContentSizeFitter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _PreviousLength
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntryGroupBase<T, E>.NativeFieldInfoPtr__PreviousLength));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntryGroupBase<T, E>.NativeFieldInfoPtr__PreviousLength)) = value;
      }
    }
  }
}
