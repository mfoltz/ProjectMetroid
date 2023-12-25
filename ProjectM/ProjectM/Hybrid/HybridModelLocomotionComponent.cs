// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HybridModelLocomotionComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Hybrid
{
  public class HybridModelLocomotionComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Animator;
    private static readonly IntPtr NativeFieldInfoPtr_UnitLocomotionSupport;
    private static readonly IntPtr NativeFieldInfoPtr_StrafeSupport;
    private static readonly IntPtr NativeFieldInfoPtr_InCombatSupport;
    private static readonly IntPtr NativeFieldInfoPtr_RunSpeedMultiplier;
    private static readonly IntPtr NativeFieldInfoPtr_QuadrupedSecondaryAnimationHandler;
    private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr_HasContentErrors_Private_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157443, XrefRangeEnd = 1157451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelLocomotionComponent.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157451, XrefRangeEnd = 1157468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(HybridModelLocomotionComponent.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157468, XrefRangeEnd = 1157474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasContentErrors()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridModelLocomotionComponent.NativeMethodInfoPtr_HasContentErrors_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157474, XrefRangeEnd = 1157478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelLocomotionComponent.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157478, XrefRangeEnd = 1157479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HybridModelLocomotionComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridModelLocomotionComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridModelLocomotionComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HybridModelLocomotionComponent()
    {
      Il2CppClassPointerStore<HybridModelLocomotionComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (HybridModelLocomotionComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridModelLocomotionComponent>.NativeClassPtr);
      HybridModelLocomotionComponent.NativeFieldInfoPtr_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelLocomotionComponent>.NativeClassPtr, nameof (Animator));
      HybridModelLocomotionComponent.NativeFieldInfoPtr_UnitLocomotionSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelLocomotionComponent>.NativeClassPtr, nameof (UnitLocomotionSupport));
      HybridModelLocomotionComponent.NativeFieldInfoPtr_StrafeSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelLocomotionComponent>.NativeClassPtr, nameof (StrafeSupport));
      HybridModelLocomotionComponent.NativeFieldInfoPtr_InCombatSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelLocomotionComponent>.NativeClassPtr, nameof (InCombatSupport));
      HybridModelLocomotionComponent.NativeFieldInfoPtr_RunSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelLocomotionComponent>.NativeClassPtr, nameof (RunSpeedMultiplier));
      HybridModelLocomotionComponent.NativeFieldInfoPtr_QuadrupedSecondaryAnimationHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridModelLocomotionComponent>.NativeClassPtr, nameof (QuadrupedSecondaryAnimationHandler));
      HybridModelLocomotionComponent.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelLocomotionComponent>.NativeClassPtr, 100692138);
      HybridModelLocomotionComponent.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelLocomotionComponent>.NativeClassPtr, 100692139);
      HybridModelLocomotionComponent.NativeMethodInfoPtr_HasContentErrors_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelLocomotionComponent>.NativeClassPtr, 100692140);
      HybridModelLocomotionComponent.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelLocomotionComponent>.NativeClassPtr, 100692141);
      HybridModelLocomotionComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridModelLocomotionComponent>.NativeClassPtr, 100692142);
    }

    public HybridModelLocomotionComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Animator Animator
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelLocomotionComponent.NativeFieldInfoPtr_Animator));
        return pointer == IntPtr.Zero ? (Animator) null : new Animator(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelLocomotionComponent.NativeFieldInfoPtr_Animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool UnitLocomotionSupport
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelLocomotionComponent.NativeFieldInfoPtr_UnitLocomotionSupport));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelLocomotionComponent.NativeFieldInfoPtr_UnitLocomotionSupport)) = value;
      }
    }

    public unsafe bool StrafeSupport
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelLocomotionComponent.NativeFieldInfoPtr_StrafeSupport));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelLocomotionComponent.NativeFieldInfoPtr_StrafeSupport)) = value;
      }
    }

    public unsafe bool InCombatSupport
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelLocomotionComponent.NativeFieldInfoPtr_InCombatSupport));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelLocomotionComponent.NativeFieldInfoPtr_InCombatSupport)) = value;
      }
    }

    public unsafe float RunSpeedMultiplier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelLocomotionComponent.NativeFieldInfoPtr_RunSpeedMultiplier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelLocomotionComponent.NativeFieldInfoPtr_RunSpeedMultiplier)) = value;
      }
    }

    public unsafe QuadrupedSecondaryAnimationHandler QuadrupedSecondaryAnimationHandler
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridModelLocomotionComponent.NativeFieldInfoPtr_QuadrupedSecondaryAnimationHandler));
        return pointer == IntPtr.Zero ? (QuadrupedSecondaryAnimationHandler) null : new QuadrupedSecondaryAnimationHandler(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridModelLocomotionComponent.NativeFieldInfoPtr_QuadrupedSecondaryAnimationHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
