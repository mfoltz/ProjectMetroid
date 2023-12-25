// Decompiled with JetBrains decompiler
// Type: HybridCritterComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
public class HybridCritterComponent : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_Animator;
  private static readonly IntPtr NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void AddComponent(
    World world,
    PrefabLookupMap prefabLookupMap,
    Entity hybridEntity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &prefabLookupMap;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &hybridEntity;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HybridCritterComponent.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HybridCritterComponent()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridCritterComponent>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HybridCritterComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static HybridCritterComponent()
  {
    Il2CppClassPointerStore<HybridCritterComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (HybridCritterComponent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridCritterComponent>.NativeClassPtr);
    HybridCritterComponent.NativeFieldInfoPtr_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridCritterComponent>.NativeClassPtr, nameof (Animator));
    HybridCritterComponent.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridCritterComponent>.NativeClassPtr, 100663480);
    HybridCritterComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridCritterComponent>.NativeClassPtr, 100663481);
  }

  public HybridCritterComponent(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Animator Animator
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridCritterComponent.NativeFieldInfoPtr_Animator));
      return pointer == IntPtr.Zero ? (Animator) null : new Animator(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridCritterComponent.NativeFieldInfoPtr_Animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
