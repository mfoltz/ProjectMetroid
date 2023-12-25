// Decompiled with JetBrains decompiler
// Type: PrefabVariantExampleCollectionScript
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Malee;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class PrefabVariantExampleCollectionScript : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_Entries;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PrefabVariantExampleCollectionScript()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabVariantExampleCollectionScript>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PrefabVariantExampleCollectionScript.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static PrefabVariantExampleCollectionScript()
  {
    Il2CppClassPointerStore<PrefabVariantExampleCollectionScript>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (PrefabVariantExampleCollectionScript));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabVariantExampleCollectionScript>.NativeClassPtr);
    PrefabVariantExampleCollectionScript.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabVariantExampleCollectionScript>.NativeClassPtr, nameof (Entries));
    PrefabVariantExampleCollectionScript.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabVariantExampleCollectionScript>.NativeClassPtr, 100663755);
  }

  public PrefabVariantExampleCollectionScript(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe PrefabVariantExampleCollectionScript.CollectionGroup Entries
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabVariantExampleCollectionScript.NativeFieldInfoPtr_Entries));
      return pointer == IntPtr.Zero ? (PrefabVariantExampleCollectionScript.CollectionGroup) null : new PrefabVariantExampleCollectionScript.CollectionGroup(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabVariantExampleCollectionScript.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class CollectionGroup : ReorderableArray<GameObject>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922343, XrefRangeEnd = 922346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CollectionGroup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabVariantExampleCollectionScript.CollectionGroup>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabVariantExampleCollectionScript.CollectionGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CollectionGroup()
    {
      Il2CppClassPointerStore<PrefabVariantExampleCollectionScript.CollectionGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabVariantExampleCollectionScript>.NativeClassPtr, nameof (CollectionGroup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabVariantExampleCollectionScript.CollectionGroup>.NativeClassPtr);
      PrefabVariantExampleCollectionScript.CollectionGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabVariantExampleCollectionScript.CollectionGroup>.NativeClassPtr, 100663756);
    }

    public CollectionGroup(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
