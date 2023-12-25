// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HybridIKSpiderLegs
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using RootMotion.FinalIK;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Hybrid
{
  public class HybridIKSpiderLegs : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RootTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeadTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr__IKLegs;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultAreaRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_StepSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_StepSpeedCurveAsset;
    private static readonly System.IntPtr NativeFieldInfoPtr_StepHeightCurveAsset;
    private static readonly System.IntPtr NativeFieldInfoPtr_StepHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasInitialized;
    private static readonly System.IntPtr NativeFieldInfoPtr__Animator;
    private static readonly System.IntPtr NativeFieldInfoPtr__HybridModelFootstepComponent_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_FloatHeadAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr__HeadAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_SuspensionCurveAsset;
    private static readonly System.IntPtr NativeFieldInfoPtr_SuspensionSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_BodyAimIK;
    private static readonly System.IntPtr NativeFieldInfoPtr_BodyTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_BodyProxy;
    private static readonly System.IntPtr NativeFieldInfoPtr_BodyAimIKTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_BodyTiltWeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_BodyTiltVelocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_BodyTiltStrength;
    private static readonly System.IntPtr NativeFieldInfoPtr_BodyTiltDampening;
    private static readonly System.IntPtr NativeFieldInfoPtr_BodyBobHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_BodyBobStrength;
    private static readonly System.IntPtr NativeFieldInfoPtr_BodyBobDampening;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HybridModelFootstepComponent_Public_get_HybridModelFootstepComponent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_HybridModelFootstepComponent_Private_set_Void_HybridModelFootstepComponent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAnimatorParameter_Public_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe HybridModelFootstepComponent HybridModelFootstepComponent
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridIKSpiderLegs.NativeMethodInfoPtr_get_HybridModelFootstepComponent_Public_get_HybridModelFootstepComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (HybridModelFootstepComponent) null : new HybridModelFootstepComponent(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridIKSpiderLegs.NativeMethodInfoPtr_set_HybridModelFootstepComponent_Private_set_Void_HybridModelFootstepComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155326, XrefRangeEnd = 1155351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void AddComponent(
      World world,
      PrefabLookupMap prefabLookupMap,
      Entity hybridEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabLookupMap;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hybridEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridIKSpiderLegs.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1155368, RefRangeEnd = 1155369, XrefRangeStart = 1155351, XrefRangeEnd = 1155368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Init()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridIKSpiderLegs.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1155378, RefRangeEnd = 1155379, XrefRangeStart = 1155369, XrefRangeEnd = 1155378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateAnimatorParameter(float headAngle)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &headAngle;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridIKSpiderLegs.NativeMethodInfoPtr_UpdateAnimatorParameter_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155379, XrefRangeEnd = 1155380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HybridIKSpiderLegs()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridIKSpiderLegs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HybridIKSpiderLegs()
    {
      Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (HybridIKSpiderLegs));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr);
      HybridIKSpiderLegs.NativeFieldInfoPtr_RootTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (RootTransform));
      HybridIKSpiderLegs.NativeFieldInfoPtr_HeadTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (HeadTransform));
      HybridIKSpiderLegs.NativeFieldInfoPtr__IKLegs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (_IKLegs));
      HybridIKSpiderLegs.NativeFieldInfoPtr_DefaultAreaRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (DefaultAreaRadius));
      HybridIKSpiderLegs.NativeFieldInfoPtr_StepSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (StepSpeed));
      HybridIKSpiderLegs.NativeFieldInfoPtr_StepSpeedCurveAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (StepSpeedCurveAsset));
      HybridIKSpiderLegs.NativeFieldInfoPtr_StepHeightCurveAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (StepHeightCurveAsset));
      HybridIKSpiderLegs.NativeFieldInfoPtr_StepHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (StepHeight));
      HybridIKSpiderLegs.NativeFieldInfoPtr_HasInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (HasInitialized));
      HybridIKSpiderLegs.NativeFieldInfoPtr__Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (_Animator));
      HybridIKSpiderLegs.NativeFieldInfoPtr__HybridModelFootstepComponent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, "<HybridModelFootstepComponent>k__BackingField");
      HybridIKSpiderLegs.NativeFieldInfoPtr_FloatHeadAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (FloatHeadAngle));
      HybridIKSpiderLegs.NativeFieldInfoPtr__HeadAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (_HeadAngle));
      HybridIKSpiderLegs.NativeFieldInfoPtr_SuspensionCurveAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (SuspensionCurveAsset));
      HybridIKSpiderLegs.NativeFieldInfoPtr_SuspensionSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (SuspensionSpeed));
      HybridIKSpiderLegs.NativeFieldInfoPtr_BodyAimIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (BodyAimIK));
      HybridIKSpiderLegs.NativeFieldInfoPtr_BodyTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (BodyTransform));
      HybridIKSpiderLegs.NativeFieldInfoPtr_BodyProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (BodyProxy));
      HybridIKSpiderLegs.NativeFieldInfoPtr_BodyAimIKTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (BodyAimIKTarget));
      HybridIKSpiderLegs.NativeFieldInfoPtr_BodyTiltWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (BodyTiltWeight));
      HybridIKSpiderLegs.NativeFieldInfoPtr_BodyTiltVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (BodyTiltVelocity));
      HybridIKSpiderLegs.NativeFieldInfoPtr_BodyTiltStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (BodyTiltStrength));
      HybridIKSpiderLegs.NativeFieldInfoPtr_BodyTiltDampening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (BodyTiltDampening));
      HybridIKSpiderLegs.NativeFieldInfoPtr_BodyBobHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (BodyBobHeight));
      HybridIKSpiderLegs.NativeFieldInfoPtr_BodyBobStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (BodyBobStrength));
      HybridIKSpiderLegs.NativeFieldInfoPtr_BodyBobDampening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (BodyBobDampening));
      HybridIKSpiderLegs.NativeMethodInfoPtr_get_HybridModelFootstepComponent_Public_get_HybridModelFootstepComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, 100691911);
      HybridIKSpiderLegs.NativeMethodInfoPtr_set_HybridModelFootstepComponent_Private_set_Void_HybridModelFootstepComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, 100691912);
      HybridIKSpiderLegs.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, 100691913);
      HybridIKSpiderLegs.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, 100691914);
      HybridIKSpiderLegs.NativeMethodInfoPtr_UpdateAnimatorParameter_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, 100691915);
      HybridIKSpiderLegs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, 100691916);
    }

    public HybridIKSpiderLegs(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Transform RootTransform
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_RootTransform));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_RootTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform HeadTransform
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_HeadTransform));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_HeadTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<HybridIKSpiderLegs.IKLeg> _IKLegs
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr__IKLegs));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<HybridIKSpiderLegs.IKLeg>) null : new Il2CppReferenceArray<HybridIKSpiderLegs.IKLeg>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr__IKLegs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float DefaultAreaRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_DefaultAreaRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_DefaultAreaRadius)) = value;
      }
    }

    public unsafe float StepSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_StepSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_StepSpeed)) = value;
      }
    }

    public unsafe CurveReference StepSpeedCurveAsset
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_StepSpeedCurveAsset));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_StepSpeedCurveAsset)) = value;
      }
    }

    public unsafe CurveReference StepHeightCurveAsset
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_StepHeightCurveAsset));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_StepHeightCurveAsset)) = value;
      }
    }

    public unsafe float StepHeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_StepHeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_StepHeight)) = value;
      }
    }

    public unsafe bool HasInitialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_HasInitialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_HasInitialized)) = value;
      }
    }

    public unsafe Animator _Animator
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr__Animator));
        return pointer == System.IntPtr.Zero ? (Animator) null : new Animator(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr__Animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HybridModelFootstepComponent _HybridModelFootstepComponent_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr__HybridModelFootstepComponent_k__BackingField));
        return pointer == System.IntPtr.Zero ? (HybridModelFootstepComponent) null : new HybridModelFootstepComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr__HybridModelFootstepComponent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe int FloatHeadAngle
    {
      get
      {
        int floatHeadAngle;
        IL2CPP.il2cpp_field_static_get_value(HybridIKSpiderLegs.NativeFieldInfoPtr_FloatHeadAngle, (void*) &floatHeadAngle);
        return floatHeadAngle;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(HybridIKSpiderLegs.NativeFieldInfoPtr_FloatHeadAngle, (void*) &value);
      }
    }

    public unsafe float _HeadAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr__HeadAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr__HeadAngle)) = value;
      }
    }

    public unsafe CurveReference SuspensionCurveAsset
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_SuspensionCurveAsset));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_SuspensionCurveAsset)) = value;
      }
    }

    public unsafe float SuspensionSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_SuspensionSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_SuspensionSpeed)) = value;
      }
    }

    public unsafe AimIK BodyAimIK
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_BodyAimIK));
        return pointer == System.IntPtr.Zero ? (AimIK) null : new AimIK(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_BodyAimIK), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform BodyTransform
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_BodyTransform));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_BodyTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform BodyProxy
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_BodyProxy));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_BodyProxy), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform BodyAimIKTarget
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_BodyAimIKTarget));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_BodyAimIKTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float BodyTiltWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_BodyTiltWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_BodyTiltWeight)) = value;
      }
    }

    public unsafe Vector3 BodyTiltVelocity
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_BodyTiltVelocity));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_BodyTiltVelocity)) = value;
      }
    }

    public unsafe float BodyTiltStrength
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_BodyTiltStrength));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_BodyTiltStrength)) = value;
      }
    }

    public unsafe float BodyTiltDampening
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_BodyTiltDampening));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_BodyTiltDampening)) = value;
      }
    }

    public unsafe float BodyBobHeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_BodyBobHeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_BodyBobHeight)) = value;
      }
    }

    public unsafe float BodyBobStrength
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_BodyBobStrength));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_BodyBobStrength)) = value;
      }
    }

    public unsafe float BodyBobDampening
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_BodyBobDampening));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.NativeFieldInfoPtr_BodyBobDampening)) = value;
      }
    }

    [Serializable]
    public sealed class IKLeg : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_IsEnabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_DefaultPosTarget;
      private static readonly System.IntPtr NativeFieldInfoPtr_IK;
      private static readonly System.IntPtr NativeFieldInfoPtr_Target;
      private static readonly System.IntPtr NativeFieldInfoPtr_SuspensionTransform;
      private static readonly System.IntPtr NativeFieldInfoPtr_PistonPairs;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultPos_Public_get_Vector3_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePistons_Public_Void_0;

      public unsafe Vector3 DefaultPos
      {
        [CallerCount(2), CachedScanResults(RefRangeStart = 1155317, RefRangeEnd = 1155319, XrefRangeStart = 1155316, XrefRangeEnd = 1155317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridIKSpiderLegs.IKLeg.NativeMethodInfoPtr_get_DefaultPos_Public_get_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1155322, RefRangeEnd = 1155323, XrefRangeStart = 1155319, XrefRangeEnd = 1155322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Init()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridIKSpiderLegs.IKLeg.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 246533, RefRangeEnd = 246534, XrefRangeStart = 246533, XrefRangeEnd = 246534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetEnabled(bool value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridIKSpiderLegs.IKLeg.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1155325, RefRangeEnd = 1155326, XrefRangeStart = 1155323, XrefRangeEnd = 1155325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void UpdatePistons()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridIKSpiderLegs.IKLeg.NativeMethodInfoPtr_UpdatePistons_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static IKLeg()
      {
        Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridIKSpiderLegs>.NativeClassPtr, nameof (IKLeg));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg>.NativeClassPtr);
        HybridIKSpiderLegs.IKLeg.NativeFieldInfoPtr_IsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg>.NativeClassPtr, nameof (IsEnabled));
        HybridIKSpiderLegs.IKLeg.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg>.NativeClassPtr, nameof (Name));
        HybridIKSpiderLegs.IKLeg.NativeFieldInfoPtr_DefaultPosTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg>.NativeClassPtr, nameof (DefaultPosTarget));
        HybridIKSpiderLegs.IKLeg.NativeFieldInfoPtr_IK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg>.NativeClassPtr, nameof (IK));
        HybridIKSpiderLegs.IKLeg.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg>.NativeClassPtr, nameof (Target));
        HybridIKSpiderLegs.IKLeg.NativeFieldInfoPtr_SuspensionTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg>.NativeClassPtr, nameof (SuspensionTransform));
        HybridIKSpiderLegs.IKLeg.NativeFieldInfoPtr_PistonPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg>.NativeClassPtr, nameof (PistonPairs));
        HybridIKSpiderLegs.IKLeg.NativeMethodInfoPtr_get_DefaultPos_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg>.NativeClassPtr, 100691918);
        HybridIKSpiderLegs.IKLeg.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg>.NativeClassPtr, 100691919);
        HybridIKSpiderLegs.IKLeg.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg>.NativeClassPtr, 100691920);
        HybridIKSpiderLegs.IKLeg.NativeMethodInfoPtr_UpdatePistons_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg>.NativeClassPtr, 100691921);
      }

      public IKLeg(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public IKLeg()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg>.NativeClassPtr, data));
      }

      public unsafe bool IsEnabled
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.IKLeg.NativeFieldInfoPtr_IsEnabled));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.IKLeg.NativeFieldInfoPtr_IsEnabled)) = value;
        }
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.IKLeg.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.IKLeg.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe Transform DefaultPosTarget
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.IKLeg.NativeFieldInfoPtr_DefaultPosTarget));
          return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.IKLeg.NativeFieldInfoPtr_DefaultPosTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe CCDIK IK
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.IKLeg.NativeFieldInfoPtr_IK));
          return pointer == System.IntPtr.Zero ? (CCDIK) null : new CCDIK(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.IKLeg.NativeFieldInfoPtr_IK), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Transform Target
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.IKLeg.NativeFieldInfoPtr_Target));
          return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.IKLeg.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Transform SuspensionTransform
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.IKLeg.NativeFieldInfoPtr_SuspensionTransform));
          return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.IKLeg.NativeFieldInfoPtr_SuspensionTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<HybridIKSpiderLegs.IKLeg.PistonPair> PistonPairs
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.IKLeg.NativeFieldInfoPtr_PistonPairs));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<HybridIKSpiderLegs.IKLeg.PistonPair>) null : new Il2CppReferenceArray<HybridIKSpiderLegs.IKLeg.PistonPair>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.IKLeg.NativeFieldInfoPtr_PistonPairs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [Serializable]
      public sealed class PistonPair : Il2CppSystem.ValueType
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Piston1;
        private static readonly System.IntPtr NativeFieldInfoPtr_Piston2;
        private static readonly System.IntPtr NativeFieldInfoPtr_IsNegative;
        private static readonly System.IntPtr NativeMethodInfoPtr_get_Angle_Private_get_Single_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

        public unsafe float Angle
        {
          [CallerCount(0)] get
          {
            IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            System.IntPtr* numPtr = (System.IntPtr*) null;
            System.IntPtr exc;
            System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridIKSpiderLegs.IKLeg.PistonPair.NativeMethodInfoPtr_get_Angle_Private_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
            Il2CppException.RaiseExceptionIfNecessary(exc);
            return *(float*) IL2CPP.il2cpp_object_unbox(num);
          }
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1155315, RefRangeEnd = 1155316, XrefRangeStart = 1155309, XrefRangeEnd = 1155315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void Update()
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HybridIKSpiderLegs.IKLeg.PistonPair.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static PistonPair()
        {
          Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg.PistonPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg>.NativeClassPtr, nameof (PistonPair));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg.PistonPair>.NativeClassPtr);
          HybridIKSpiderLegs.IKLeg.PistonPair.NativeFieldInfoPtr_Piston1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg.PistonPair>.NativeClassPtr, nameof (Piston1));
          HybridIKSpiderLegs.IKLeg.PistonPair.NativeFieldInfoPtr_Piston2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg.PistonPair>.NativeClassPtr, nameof (Piston2));
          HybridIKSpiderLegs.IKLeg.PistonPair.NativeFieldInfoPtr_IsNegative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg.PistonPair>.NativeClassPtr, nameof (IsNegative));
          HybridIKSpiderLegs.IKLeg.PistonPair.NativeMethodInfoPtr_get_Angle_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg.PistonPair>.NativeClassPtr, 100691922);
          HybridIKSpiderLegs.IKLeg.PistonPair.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg.PistonPair>.NativeClassPtr, 100691923);
        }

        public PistonPair(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public PistonPair()
        {
          // ISSUE: cast to a reference type
          // ISSUE: untyped stack allocation
          System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg.PistonPair>.NativeClassPtr, (uint&) System.IntPtr.Zero));
          // ISSUE: explicit constructor call
          base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HybridIKSpiderLegs.IKLeg.PistonPair>.NativeClassPtr, data));
        }

        public unsafe Transform Piston1
        {
          get
          {
            System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.IKLeg.PistonPair.NativeFieldInfoPtr_Piston1));
            return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
          }
          [param: In] set
          {
            System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.IKLeg.PistonPair.NativeFieldInfoPtr_Piston1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        public unsafe Transform Piston2
        {
          get
          {
            System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.IKLeg.PistonPair.NativeFieldInfoPtr_Piston2));
            return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
          }
          [param: In] set
          {
            System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.IKLeg.PistonPair.NativeFieldInfoPtr_Piston2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        public unsafe bool IsNegative
        {
          get
          {
            return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.IKLeg.PistonPair.NativeFieldInfoPtr_IsNegative));
          }
          [param: In] set
          {
            *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridIKSpiderLegs.IKLeg.PistonPair.NativeFieldInfoPtr_IsNegative)) = value;
          }
        }
      }
    }
  }
}
