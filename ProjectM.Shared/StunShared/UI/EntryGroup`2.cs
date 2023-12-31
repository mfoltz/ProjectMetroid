// Decompiled with JetBrains decompiler
// Type: StunShared.UI.EntryGroup`2
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

#nullable disable
namespace StunShared.UI
{
  public class EntryGroup<T, E> : EntryGroupBase<T, E> where T : UIEntry
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_RectTransform_Int32_List_1_T_0;

    [CallerCount(23)]
    [CachedScanResults(RefRangeStart = 717689, RefRangeEnd = 717712, XrefRangeStart = 717688, XrefRangeEnd = 717689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EntryGroup(
      T prefab,
      RectTransform parent,
      int cachedEntries = -1,
      List<T> preInstantiatedEntries = null)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntryGroup<T, E>>.NativeClassPtr))
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
      IL2CPP.il2cpp_runtime_invoke(EntryGroup<T, E>.NativeMethodInfoPtr__ctor_Public_Void_T_RectTransform_Int32_List_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EntryGroup()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<EntryGroup<T, E>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "StunShared.UI", "EntryGroup`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<E>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntryGroup<T, E>>.NativeClassPtr);
      EntryGroup<T, E>.NativeMethodInfoPtr__ctor_Public_Void_T_RectTransform_Int32_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntryGroup<T, E>>.NativeClassPtr, 100663554);
    }

    public EntryGroup(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
