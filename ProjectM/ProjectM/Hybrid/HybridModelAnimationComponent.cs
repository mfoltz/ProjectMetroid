// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HybridModelAnimationComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using MagicaCloth;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Hybrid
{
  public class HybridModelAnimationComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_LogNewAnimations;
    private static readonly IntPtr NativeFieldInfoPtr_TurnOffAnimatorWhenOccluded;
    private static readonly IntPtr NativeFieldInfoPtr_Animator;
    private static readonly IntPtr NativeFieldInfoPtr_AnimationCollection;
    private static readonly IntPtr NativeFieldInfoPtr_AnimationListeners;
    private static readonly IntPtr NativeFieldInfoPtr_ToggleableCloths;
    private static readonly IntPtr NativeFieldInfoPtr_EndStance;
    private static readonly IntPtr NativeFieldInfoPtr_MountedSpineIK;
    private static readonly IntPtr NativeFieldInfoPtr_MountedLeftArmIK;
    private static readonly IntPtr NativeFieldInfoPtr_MountedRightArmIK;
    private static readonly IntPtr NativeFieldInfoPtr_LockDominantFootOnExit;
    private static readonly IntPtr NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetLayerIndexFromEnum_Public_Static_Int32_Animator_AnimationLayerEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetLayerEnumFromIndex_Public_Static_AnimationLayerEnum_Animator_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_HasContentErrors_Private_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157234, XrefRangeEnd = 1157280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(HybridModelAnimationComponent.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1157295, RefRangeEnd = 1157296, XrefRangeStart = 1157280, XrefRangeEnd = 1157295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetLayerIndexFromEnum(Animator animator, AnimationLayerEnum layerEnum)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) animator);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &layerEnum;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridModelAnimationComponent.NativeMethodInfoPtr_GetLayerIndexFromEnum_Public_Static_Int32_Animator_AnimationLayerEnum_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157296, XrefRangeEnd = 1157312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe AnimationLayerEnum GetLayerEnumFromIndex(Animator animator, int layerIndex)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) animator);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &layerIndex;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridModelAnimationComponent.NativeMethodInfoPtr_GetLayerEnumFromIndex_Public_Static_AnimationLayerEnum_Animator_Int32_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AnimationLayerEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1157322, RefRangeEnd = 1157323, XrefRangeStart = 1157312, XrefRangeEnd = 1157322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasContentErrors()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridModelAnimationComponent.NativeMethodInfoPtr_HasContentErrors_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157323, XrefRangeEnd = 1157327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelAnimationComponent.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157327, XrefRangeEnd = 1157342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HybridModelAnimationComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridModelAnimationComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelAnimationComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HybridModelAnimationComponent()
    {
      Il2CppClassPointerStore<HybridModelAnimationComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (HybridModelAnimationComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelAnimationComponent>.NativeClassPtr);
      HybridModelAnimationComponent.NativeFieldInfoPtr_LogNewAnimations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimationComponent>.NativeClassPtr, nameof (LogNewAnimations));
      HybridModelAnimationComponent.NativeFieldInfoPtr_TurnOffAnimatorWhenOccluded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimationComponent>.NativeClassPtr, nameof (TurnOffAnimatorWhenOccluded));
      HybridModelAnimationComponent.NativeFieldInfoPtr_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimationComponent>.NativeClassPtr, nameof (Animator));
      HybridModelAnimationComponent.NativeFieldInfoPtr_AnimationCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimationComponent>.NativeClassPtr, nameof (AnimationCollection));
      HybridModelAnimationComponent.NativeFieldInfoPtr_AnimationListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimationComponent>.NativeClassPtr, nameof (AnimationListeners));
      HybridModelAnimationComponent.NativeFieldInfoPtr_ToggleableCloths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimationComponent>.NativeClassPtr, nameof (ToggleableCloths));
      HybridModelAnimationComponent.NativeFieldInfoPtr_EndStance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimationComponent>.NativeClassPtr, nameof (EndStance));
      HybridModelAnimationComponent.NativeFieldInfoPtr_MountedSpineIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimationComponent>.NativeClassPtr, nameof (MountedSpineIK));
      HybridModelAnimationComponent.NativeFieldInfoPtr_MountedLeftArmIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimationComponent>.NativeClassPtr, nameof (MountedLeftArmIK));
      HybridModelAnimationComponent.NativeFieldInfoPtr_MountedRightArmIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimationComponent>.NativeClassPtr, nameof (MountedRightArmIK));
      HybridModelAnimationComponent.NativeFieldInfoPtr_LockDominantFootOnExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelAnimationComponent>.NativeClassPtr, nameof (LockDominantFootOnExit));
      HybridModelAnimationComponent.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelAnimationComponent>.NativeClassPtr, 100692122);
      HybridModelAnimationComponent.NativeMethodInfoPtr_GetLayerIndexFromEnum_Public_Static_Int32_Animator_AnimationLayerEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelAnimationComponent>.NativeClassPtr, 100692123);
      HybridModelAnimationComponent.NativeMethodInfoPtr_GetLayerEnumFromIndex_Public_Static_AnimationLayerEnum_Animator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelAnimationComponent>.NativeClassPtr, 100692124);
      HybridModelAnimationComponent.NativeMethodInfoPtr_HasContentErrors_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelAnimationComponent>.NativeClassPtr, 100692125);
      HybridModelAnimationComponent.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelAnimationComponent>.NativeClassPtr, 100692126);
      HybridModelAnimationComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelAnimationComponent>.NativeClassPtr, 100692127);
    }

    public HybridModelAnimationComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe bool LogNewAnimations
    {
      get
      {
        bool logNewAnimations;
        IL2CPP.il2cpp_field_static_get_value(HybridModelAnimationComponent.NativeFieldInfoPtr_LogNewAnimations, (void*) &logNewAnimations);
        return logNewAnimations;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HybridModelAnimationComponent.NativeFieldInfoPtr_LogNewAnimations, (void*) &value);
      }
    }

    public unsafe bool TurnOffAnimatorWhenOccluded
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationComponent.NativeFieldInfoPtr_TurnOffAnimatorWhenOccluded));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationComponent.NativeFieldInfoPtr_TurnOffAnimatorWhenOccluded)) = value;
      }
    }

    public unsafe Animator Animator
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationComponent.NativeFieldInfoPtr_Animator));
        return pointer == IntPtr.Zero ? (Animator) null : new Animator(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationComponent.NativeFieldInfoPtr_Animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationCollection AnimationCollection
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationComponent.NativeFieldInfoPtr_AnimationCollection));
        return pointer == IntPtr.Zero ? (AnimationCollection) null : new AnimationCollection(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationComponent.NativeFieldInfoPtr_AnimationCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<HybridModelAnimationListenerComponent> AnimationListeners
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationComponent.NativeFieldInfoPtr_AnimationListeners));
        return pointer == IntPtr.Zero ? (List<HybridModelAnimationListenerComponent>) null : new List<HybridModelAnimationListenerComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationComponent.NativeFieldInfoPtr_AnimationListeners), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<BaseCloth> ToggleableCloths
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationComponent.NativeFieldInfoPtr_ToggleableCloths));
        return pointer == IntPtr.Zero ? (List<BaseCloth>) null : new List<BaseCloth>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationComponent.NativeFieldInfoPtr_ToggleableCloths), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int EndStance
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationComponent.NativeFieldInfoPtr_EndStance));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationComponent.NativeFieldInfoPtr_EndStance)) = value;
      }
    }

    public unsafe bool MountedSpineIK
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationComponent.NativeFieldInfoPtr_MountedSpineIK));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationComponent.NativeFieldInfoPtr_MountedSpineIK)) = value;
      }
    }

    public unsafe bool MountedLeftArmIK
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationComponent.NativeFieldInfoPtr_MountedLeftArmIK));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationComponent.NativeFieldInfoPtr_MountedLeftArmIK)) = value;
      }
    }

    public unsafe bool MountedRightArmIK
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationComponent.NativeFieldInfoPtr_MountedRightArmIK));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationComponent.NativeFieldInfoPtr_MountedRightArmIK)) = value;
      }
    }

    public unsafe bool LockDominantFootOnExit
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationComponent.NativeFieldInfoPtr_LockDominantFootOnExit));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelAnimationComponent.NativeFieldInfoPtr_LockDominantFootOnExit)) = value;
      }
    }
  }
}
