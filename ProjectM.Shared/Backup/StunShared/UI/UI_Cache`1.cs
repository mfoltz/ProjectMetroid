// Decompiled with JetBrains decompiler
// Type: StunShared.UI.UI_Cache`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace StunShared.UI
{
  public class UI_Cache<T> : Il2CppSystem.Object where T : UIEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Prefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_Parent;
    private static readonly System.IntPtr NativeFieldInfoPtr__Elements_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr_usedElementIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_usedElementsLastFrame;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Elements_Public_get_List_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Elements_Private_set_Void_List_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_RectTransform_Int32_List_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RectTransform_Il2CppArrayBase_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetParent_Public_Void_RectTransform_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartUpdate_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetElement_Public_Boolean_byref_T_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateElement_Private_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndUpdate_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

    public unsafe List<T> Elements
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UI_Cache<T>.NativeMethodInfoPtr_get_Elements_Public_get_List_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<T>) null : new List<T>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UI_Cache<T>.NativeMethodInfoPtr_set_Elements_Private_set_Void_List_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(32)]
    [CachedScanResults(RefRangeStart = 717830, RefRangeEnd = 717862, XrefRangeStart = 717823, XrefRangeEnd = 717830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UI_Cache(
      T prefab,
      RectTransform parent,
      int cachedEntries = -1,
      List<T> preInstantiatedEntries = null)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_Cache<T>>.NativeClassPtr))
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
      IL2CPP.il2cpp_runtime_invoke(UI_Cache<T>.NativeMethodInfoPtr__ctor_Public_Void_T_RectTransform_Int32_List_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717862, XrefRangeEnd = 717871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UI_Cache(RectTransform parent, [Optional] Il2CppArrayBase<T> prefabs)
    {
      if (prefabs == null)
        prefabs = (Il2CppArrayBase<T>) new Il2CppReferenceArray<T>(0L);
      // ISSUE: explicit constructor call
      this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_Cache<T>>.NativeClassPtr));
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabs);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UI_Cache<T>.NativeMethodInfoPtr__ctor_Public_Void_RectTransform_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetParent(RectTransform parent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UI_Cache<T>.NativeMethodInfoPtr_SetParent_Public_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 717871, RefRangeEnd = 717912, XrefRangeStart = 717871, XrefRangeEnd = 717871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void StartUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UI_Cache<T>.NativeMethodInfoPtr_StartUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 717913, RefRangeEnd = 717954, XrefRangeStart = 717912, XrefRangeEnd = 717913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetElement(out T element, int index = 0)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
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
        local1 = ref element;
      *numPtr2 = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UI_Cache<T>.NativeMethodInfoPtr_GetElement_Public_Boolean_byref_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      if (!typeof (T).IsValueType)
      {
        ref T local2 = ref element;
        System.IntPtr objectPointer = zero;
        // ISSUE: variable of the null type
        __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
        local2 = (T) valueGeneric;
      }
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe T InstantiateElement()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(UI_Cache<T>.NativeMethodInfoPtr_InstantiateElement_Private_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    [CallerCount(40)]
    [CachedScanResults(RefRangeStart = 717954, RefRangeEnd = 717994, XrefRangeStart = 717954, XrefRangeEnd = 717954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EndUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UI_Cache<T>.NativeMethodInfoPtr_EndUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717994, XrefRangeEnd = 718004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Destroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UI_Cache<T>.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UI_Cache()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<UI_Cache<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "StunShared.UI", "UI_Cache`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_Cache<T>>.NativeClassPtr);
      UI_Cache<T>.NativeFieldInfoPtr__Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Cache<T>>.NativeClassPtr, nameof (_Prefab));
      UI_Cache<T>.NativeFieldInfoPtr_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Cache<T>>.NativeClassPtr, nameof (Parent));
      UI_Cache<T>.NativeFieldInfoPtr__Elements_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Cache<T>>.NativeClassPtr, "<Elements>k__BackingField");
      UI_Cache<T>.NativeFieldInfoPtr__CachedEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Cache<T>>.NativeClassPtr, nameof (_CachedEntries));
      UI_Cache<T>.NativeFieldInfoPtr_usedElementIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Cache<T>>.NativeClassPtr, nameof (usedElementIndex));
      UI_Cache<T>.NativeFieldInfoPtr_usedElementsLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Cache<T>>.NativeClassPtr, nameof (usedElementsLastFrame));
      UI_Cache<T>.NativeMethodInfoPtr_get_Elements_Public_get_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Cache<T>>.NativeClassPtr, 100663561);
      UI_Cache<T>.NativeMethodInfoPtr_set_Elements_Private_set_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Cache<T>>.NativeClassPtr, 100663562);
      UI_Cache<T>.NativeMethodInfoPtr__ctor_Public_Void_T_RectTransform_Int32_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Cache<T>>.NativeClassPtr, 100663563);
      UI_Cache<T>.NativeMethodInfoPtr__ctor_Public_Void_RectTransform_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Cache<T>>.NativeClassPtr, 100663564);
      UI_Cache<T>.NativeMethodInfoPtr_SetParent_Public_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Cache<T>>.NativeClassPtr, 100663565);
      UI_Cache<T>.NativeMethodInfoPtr_StartUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Cache<T>>.NativeClassPtr, 100663566);
      UI_Cache<T>.NativeMethodInfoPtr_GetElement_Public_Boolean_byref_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Cache<T>>.NativeClassPtr, 100663567);
      UI_Cache<T>.NativeMethodInfoPtr_InstantiateElement_Private_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Cache<T>>.NativeClassPtr, 100663568);
      UI_Cache<T>.NativeMethodInfoPtr_EndUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Cache<T>>.NativeClassPtr, 100663569);
      UI_Cache<T>.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Cache<T>>.NativeClassPtr, 100663570);
    }

    public UI_Cache(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe T _Prefab
    {
      get
      {
        return IL2CPP.PointerToValueGeneric<T>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UI_Cache<T>.NativeFieldInfoPtr__Prefab), true, false);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr targetAddress = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UI_Cache<T>.NativeFieldInfoPtr__Prefab);
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

    public unsafe RectTransform Parent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UI_Cache<T>.NativeFieldInfoPtr_Parent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UI_Cache<T>.NativeFieldInfoPtr_Parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<T> _Elements_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UI_Cache<T>.NativeFieldInfoPtr__Elements_k__BackingField));
        return pointer == System.IntPtr.Zero ? (List<T>) null : new List<T>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UI_Cache<T>.NativeFieldInfoPtr__Elements_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _CachedEntries
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UI_Cache<T>.NativeFieldInfoPtr__CachedEntries));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UI_Cache<T>.NativeFieldInfoPtr__CachedEntries)) = value;
      }
    }

    public unsafe int usedElementIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UI_Cache<T>.NativeFieldInfoPtr_usedElementIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UI_Cache<T>.NativeFieldInfoPtr_usedElementIndex)) = value;
      }
    }

    public unsafe int usedElementsLastFrame
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UI_Cache<T>.NativeFieldInfoPtr_usedElementsLastFrame));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UI_Cache<T>.NativeFieldInfoPtr_usedElementsLastFrame)) = value;
      }
    }
  }
}
