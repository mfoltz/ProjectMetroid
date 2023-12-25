// Decompiled with JetBrains decompiler
// Type: ProjectM.VampireSecondaryAnimationHandler
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using MagicaCloth;
using ProjectM.Hybrid;
using RootMotion.FinalIK;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class VampireSecondaryAnimationHandler : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_LeftArmIK;
    private static readonly IntPtr NativeFieldInfoPtr_RightArmIK;
    private static readonly IntPtr NativeFieldInfoPtr__SpineIK;
    private static readonly IntPtr NativeFieldInfoPtr__ChestIK;
    private static readonly IntPtr NativeFieldInfoPtr__HeadIK;
    private static readonly IntPtr NativeFieldInfoPtr__HeadIKGoalWeight;
    private static readonly IntPtr NativeFieldInfoPtr__SpineIKTarget;
    private static readonly IntPtr NativeFieldInfoPtr__LeanBendTarget;
    private static readonly IntPtr NativeFieldInfoPtr__ChestAimTarget;
    private static readonly IntPtr NativeFieldInfoPtr__HeadAimTarget;
    private static readonly IntPtr NativeFieldInfoPtr__PelvisBone;
    private static readonly IntPtr NativeFieldInfoPtr__ChestBone;
    private static readonly IntPtr NativeFieldInfoPtr__HeadBone;
    private static readonly IntPtr NativeFieldInfoPtr__ChestIKReference;
    private static readonly IntPtr NativeFieldInfoPtr__PelvisIKReference;
    private static readonly IntPtr NativeFieldInfoPtr__HeadIKReference;
    private static readonly IntPtr NativeFieldInfoPtr_AbilityCompensationWeight;
    private static readonly IntPtr NativeFieldInfoPtr__TakeOffTargetPosition;
    private static readonly IntPtr NativeFieldInfoPtr__TakeOffWeight;
    private static readonly IntPtr NativeFieldInfoPtr__LeanWeight;
    private static readonly IntPtr NativeFieldInfoPtr__LeanAccTime;
    private static readonly IntPtr NativeFieldInfoPtr__LeanAccSpeed;
    private static readonly IntPtr NativeFieldInfoPtr__LeanDecSpeed;
    private static readonly IntPtr NativeFieldInfoPtr__IsLocomotionSpine;
    private static readonly IntPtr NativeFieldInfoPtr_ProceduralMountSystemBlendInDuration;
    private static readonly IntPtr NativeFieldInfoPtr_ProceduralMountSystemBlendOutDuration;
    private static readonly IntPtr NativeFieldInfoPtr_HorseCrossbowAimHeight;
    private static readonly IntPtr NativeFieldInfoPtr_BendOffsetDuringIdle;
    private static readonly IntPtr NativeFieldInfoPtr_BendOffsetDuringTrot;
    private static readonly IntPtr NativeFieldInfoPtr_BendOffsetDuringGallop;
    private static readonly IntPtr NativeFieldInfoPtr_LeanStrength;
    private static readonly IntPtr NativeFieldInfoPtr_MountMovementPhase;
    private static readonly IntPtr NativeFieldInfoPtr_MountAnimator;
    private static readonly IntPtr NativeFieldInfoPtr__LeanValue;
    private static readonly IntPtr NativeFieldInfoPtr__BendValue;
    private static readonly IntPtr NativeFieldInfoPtr__HorseCollider;
    private static readonly IntPtr NativeFieldInfoPtr__Animator;
    private static readonly IntPtr NativeFieldInfoPtr__Transform;
    private static readonly IntPtr NativeFieldInfoPtr__Velocity;
    private static readonly IntPtr NativeFieldInfoPtr__StartRunTime;
    private static readonly IntPtr NativeFieldInfoPtr__StopRunTime;
    private static readonly IntPtr NativeFieldInfoPtr__StopDirection;
    private static readonly IntPtr NativeFieldInfoPtr__MountedSpineIKWeight;
    private static readonly IntPtr NativeFieldInfoPtr__SpineIKWeight;
    private static readonly IntPtr NativeFieldInfoPtr__SpineBendTransform;
    private static readonly IntPtr NativeFieldInfoPtr__SpineLeanTransform;
    private static readonly IntPtr NativeFieldInfoPtr__ChestIKWeight;
    private static readonly IntPtr NativeFieldInfoPtr__HeadIKWeight;
    private static readonly IntPtr NativeFieldInfoPtr__LeftArmIKWeight;
    private static readonly IntPtr NativeFieldInfoPtr__RightArmIKWeight;
    private static readonly IntPtr NativeFieldInfoPtr__MountColliders;
    private static readonly IntPtr NativeFieldInfoPtr__MountedCrossbowAdditiveChestWeight;
    private static readonly IntPtr NativeFieldInfoPtr__HybridModelAnimationComponent;
    private static readonly IntPtr NativeFieldInfoPtr_BoolIsInNullA;
    private static readonly IntPtr NativeFieldInfoPtr_FloatNoZeroInstantInputX;
    private static readonly IntPtr NativeFieldInfoPtr_FloatNoZeroInstantInputY;
    private static readonly IntPtr NativeFieldInfoPtr_FloatLocomotionCycleOffset;
    private static readonly IntPtr NativeFieldInfoPtr_BoolMounting;
    private static readonly IntPtr NativeFieldInfoPtr_BoolFiringCrossbow;
    private static readonly IntPtr NativeFieldInfoPtr_FloatVelocity;
    private static readonly IntPtr NativeFieldInfoPtr_FloatRunDuration;
    private static readonly IntPtr NativeFieldInfoPtr_FloatStopDuration;
    private static readonly IntPtr NativeFieldInfoPtr_FloatStopTurnAngle;
    private static readonly IntPtr NativeFieldInfoPtr_FloatSoftAngleToTarget;
    private static readonly IntPtr NativeFieldInfoPtr_FloatSoftAngleToMouse;
    private static readonly IntPtr NativeFieldInfoPtr_FloatAngleToMouseDirection;
    private static readonly IntPtr NativeFieldInfoPtr_FloatChestTurnAngle;
    private static readonly IntPtr NativeFieldInfoPtr_FloatLookAngle;
    private static readonly IntPtr NativeFieldInfoPtr_FloatHeadBendAngle;
    private static readonly IntPtr NativeFieldInfoPtr_FloatMeleeTwistX;
    private static readonly IntPtr NativeFieldInfoPtr_FloatMeleeTwistY;
    private static readonly IntPtr NativeFieldInfoPtr_FloatMeleeTwistWeight;
    private static readonly IntPtr NativeFieldInfoPtr_FloatTurnWeight;
    private static readonly IntPtr NativeFieldInfoPtr_FloatUpperBodyWeight;
    private static readonly IntPtr NativeFieldInfoPtr_BoolIsInCombat;
    private static readonly IntPtr NativeFieldInfoPtr_BoolIsInNullAbility;
    private static readonly IntPtr NativeFieldInfoPtr_FloatTrueAbsoluteAngleToTarget;
    private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetSpineRefAimPos_Private_Vector3_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetPelvisRefAimDir_Private_Vector3_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetChestRefAimPos_Private_Vector3_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetChestRefAimDir_Private_Vector3_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetHeadRefAimDir_Private_Vector3_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetHeadRefAimPos_Private_Vector3_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateMountedIKPositions_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateAbilityCompensationIKPositions_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateMeleeTwist_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateTakeOffIK_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ResetTakeOffIK_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_EvaluatedSlerp_Private_Vector3_Vector3_Vector3_Single_Vector3_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateMountColliders_Public_Void_Il2CppReferenceArray_1_CapsuleCollider_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976607, XrefRangeEnd = 976688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VampireSecondaryAnimationHandler.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976688, XrefRangeEnd = 976800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LateUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VampireSecondaryAnimationHandler.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 976802, RefRangeEnd = 976805, XrefRangeStart = 976800, XrefRangeEnd = 976802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Vector3 GetSpineRefAimPos()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(VampireSecondaryAnimationHandler.NativeMethodInfoPtr_GetSpineRefAimPos_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976805, XrefRangeEnd = 976807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Vector3 GetPelvisRefAimDir(bool flattened)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &flattened;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(VampireSecondaryAnimationHandler.NativeMethodInfoPtr_GetPelvisRefAimDir_Private_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976807, XrefRangeEnd = 976809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Vector3 GetChestRefAimPos()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(VampireSecondaryAnimationHandler.NativeMethodInfoPtr_GetChestRefAimPos_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976809, XrefRangeEnd = 976811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Vector3 GetChestRefAimDir(bool flattened)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &flattened;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(VampireSecondaryAnimationHandler.NativeMethodInfoPtr_GetChestRefAimDir_Private_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976811, XrefRangeEnd = 976813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Vector3 GetHeadRefAimDir(bool flattened)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &flattened;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(VampireSecondaryAnimationHandler.NativeMethodInfoPtr_GetHeadRefAimDir_Private_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976813, XrefRangeEnd = 976816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Vector3 GetHeadRefAimPos()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(VampireSecondaryAnimationHandler.NativeMethodInfoPtr_GetHeadRefAimPos_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 976864, RefRangeEnd = 976865, XrefRangeStart = 976816, XrefRangeEnd = 976864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateMountedIKPositions()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VampireSecondaryAnimationHandler.NativeMethodInfoPtr_UpdateMountedIKPositions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 976874, RefRangeEnd = 976875, XrefRangeStart = 976865, XrefRangeEnd = 976874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateAbilityCompensationIKPositions()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VampireSecondaryAnimationHandler.NativeMethodInfoPtr_UpdateAbilityCompensationIKPositions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 976888, RefRangeEnd = 976889, XrefRangeStart = 976875, XrefRangeEnd = 976888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateMeleeTwist()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VampireSecondaryAnimationHandler.NativeMethodInfoPtr_UpdateMeleeTwist_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 976976, RefRangeEnd = 976977, XrefRangeStart = 976889, XrefRangeEnd = 976976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateTakeOffIK()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VampireSecondaryAnimationHandler.NativeMethodInfoPtr_UpdateTakeOffIK_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 976984, RefRangeEnd = 976985, XrefRangeStart = 976977, XrefRangeEnd = 976984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ResetTakeOffIK()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VampireSecondaryAnimationHandler.NativeMethodInfoPtr_ResetTakeOffIK_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976985, XrefRangeEnd = 976986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Vector3 EvaluatedSlerp(
      Vector3 start,
      Vector3 end,
      float percentage,
      Vector3 center)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &start;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &end;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &percentage;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &center;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(VampireSecondaryAnimationHandler.NativeMethodInfoPtr_EvaluatedSlerp_Private_Vector3_Vector3_Vector3_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 977007, RefRangeEnd = 977008, XrefRangeStart = 976986, XrefRangeEnd = 977007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateMountColliders(
      Il2CppReferenceArray<CapsuleCollider> CapsuleColliders)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) CapsuleColliders);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VampireSecondaryAnimationHandler.NativeMethodInfoPtr_UpdateMountColliders_Public_Void_Il2CppReferenceArray_1_CapsuleCollider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977008, XrefRangeEnd = 977009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VampireSecondaryAnimationHandler()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VampireSecondaryAnimationHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VampireSecondaryAnimationHandler()
    {
      Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (VampireSecondaryAnimationHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr);
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_LeftArmIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (LeftArmIK));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_RightArmIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (RightArmIK));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__SpineIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_SpineIK));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__ChestIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_ChestIK));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HeadIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_HeadIK));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HeadIKGoalWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_HeadIKGoalWeight));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__SpineIKTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_SpineIKTarget));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__LeanBendTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_LeanBendTarget));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__ChestAimTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_ChestAimTarget));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HeadAimTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_HeadAimTarget));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__PelvisBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_PelvisBone));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__ChestBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_ChestBone));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HeadBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_HeadBone));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__ChestIKReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_ChestIKReference));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__PelvisIKReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_PelvisIKReference));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HeadIKReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_HeadIKReference));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_AbilityCompensationWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (AbilityCompensationWeight));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__TakeOffTargetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_TakeOffTargetPosition));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__TakeOffWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_TakeOffWeight));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__LeanWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_LeanWeight));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__LeanAccTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_LeanAccTime));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__LeanAccSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_LeanAccSpeed));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__LeanDecSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_LeanDecSpeed));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__IsLocomotionSpine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_IsLocomotionSpine));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_ProceduralMountSystemBlendInDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (ProceduralMountSystemBlendInDuration));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_ProceduralMountSystemBlendOutDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (ProceduralMountSystemBlendOutDuration));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_HorseCrossbowAimHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (HorseCrossbowAimHeight));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BendOffsetDuringIdle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (BendOffsetDuringIdle));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BendOffsetDuringTrot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (BendOffsetDuringTrot));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BendOffsetDuringGallop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (BendOffsetDuringGallop));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_LeanStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (LeanStrength));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_MountMovementPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (MountMovementPhase));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_MountAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (MountAnimator));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__LeanValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_LeanValue));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__BendValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_BendValue));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HorseCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_HorseCollider));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_Animator));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_Transform));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_Velocity));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__StartRunTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_StartRunTime));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__StopRunTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_StopRunTime));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__StopDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_StopDirection));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__MountedSpineIKWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_MountedSpineIKWeight));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__SpineIKWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_SpineIKWeight));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__SpineBendTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_SpineBendTransform));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__SpineLeanTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_SpineLeanTransform));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__ChestIKWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_ChestIKWeight));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HeadIKWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_HeadIKWeight));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__LeftArmIKWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_LeftArmIKWeight));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__RightArmIKWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_RightArmIKWeight));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__MountColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_MountColliders));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__MountedCrossbowAdditiveChestWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_MountedCrossbowAdditiveChestWeight));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HybridModelAnimationComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (_HybridModelAnimationComponent));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BoolIsInNullA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (BoolIsInNullA));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatNoZeroInstantInputX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatNoZeroInstantInputX));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatNoZeroInstantInputY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatNoZeroInstantInputY));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatLocomotionCycleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatLocomotionCycleOffset));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BoolMounting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (BoolMounting));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BoolFiringCrossbow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (BoolFiringCrossbow));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatVelocity));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatRunDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatRunDuration));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatStopDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatStopDuration));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatStopTurnAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatStopTurnAngle));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatSoftAngleToTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatSoftAngleToTarget));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatSoftAngleToMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatSoftAngleToMouse));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatAngleToMouseDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatAngleToMouseDirection));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatChestTurnAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatChestTurnAngle));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatLookAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatLookAngle));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatHeadBendAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatHeadBendAngle));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatMeleeTwistX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatMeleeTwistX));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatMeleeTwistY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatMeleeTwistY));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatMeleeTwistWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatMeleeTwistWeight));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatTurnWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatTurnWeight));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatUpperBodyWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatUpperBodyWeight));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BoolIsInCombat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (BoolIsInCombat));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BoolIsInNullAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (BoolIsInNullAbility));
      VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatTrueAbsoluteAngleToTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatTrueAbsoluteAngleToTarget));
      VampireSecondaryAnimationHandler.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, 100675483);
      VampireSecondaryAnimationHandler.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, 100675484);
      VampireSecondaryAnimationHandler.NativeMethodInfoPtr_GetSpineRefAimPos_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, 100675485);
      VampireSecondaryAnimationHandler.NativeMethodInfoPtr_GetPelvisRefAimDir_Private_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, 100675486);
      VampireSecondaryAnimationHandler.NativeMethodInfoPtr_GetChestRefAimPos_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, 100675487);
      VampireSecondaryAnimationHandler.NativeMethodInfoPtr_GetChestRefAimDir_Private_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, 100675488);
      VampireSecondaryAnimationHandler.NativeMethodInfoPtr_GetHeadRefAimDir_Private_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, 100675489);
      VampireSecondaryAnimationHandler.NativeMethodInfoPtr_GetHeadRefAimPos_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, 100675490);
      VampireSecondaryAnimationHandler.NativeMethodInfoPtr_UpdateMountedIKPositions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, 100675491);
      VampireSecondaryAnimationHandler.NativeMethodInfoPtr_UpdateAbilityCompensationIKPositions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, 100675492);
      VampireSecondaryAnimationHandler.NativeMethodInfoPtr_UpdateMeleeTwist_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, 100675493);
      VampireSecondaryAnimationHandler.NativeMethodInfoPtr_UpdateTakeOffIK_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, 100675494);
      VampireSecondaryAnimationHandler.NativeMethodInfoPtr_ResetTakeOffIK_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, 100675495);
      VampireSecondaryAnimationHandler.NativeMethodInfoPtr_EvaluatedSlerp_Private_Vector3_Vector3_Vector3_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, 100675496);
      VampireSecondaryAnimationHandler.NativeMethodInfoPtr_UpdateMountColliders_Public_Void_Il2CppReferenceArray_1_CapsuleCollider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, 100675497);
      VampireSecondaryAnimationHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampireSecondaryAnimationHandler>.NativeClassPtr, 100675498);
    }

    public VampireSecondaryAnimationHandler(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LimbIK LeftArmIK
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_LeftArmIK));
        return pointer == IntPtr.Zero ? (LimbIK) null : new LimbIK(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_LeftArmIK), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LimbIK RightArmIK
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_RightArmIK));
        return pointer == IntPtr.Zero ? (LimbIK) null : new LimbIK(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_RightArmIK), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CCDIK _SpineIK
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__SpineIK));
        return pointer == IntPtr.Zero ? (CCDIK) null : new CCDIK(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__SpineIK), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AimIK _ChestIK
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__ChestIK));
        return pointer == IntPtr.Zero ? (AimIK) null : new AimIK(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__ChestIK), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AimIK _HeadIK
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HeadIK));
        return pointer == IntPtr.Zero ? (AimIK) null : new AimIK(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HeadIK), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _HeadIKGoalWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HeadIKGoalWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HeadIKGoalWeight)) = value;
      }
    }

    public unsafe Transform _SpineIKTarget
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__SpineIKTarget));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__SpineIKTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform _LeanBendTarget
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__LeanBendTarget));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__LeanBendTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform _ChestAimTarget
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__ChestAimTarget));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__ChestAimTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform _HeadAimTarget
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HeadAimTarget));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HeadAimTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform _PelvisBone
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__PelvisBone));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__PelvisBone), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform _ChestBone
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__ChestBone));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__ChestBone), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform _HeadBone
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HeadBone));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HeadBone), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform _ChestIKReference
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__ChestIKReference));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__ChestIKReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform _PelvisIKReference
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__PelvisIKReference));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__PelvisIKReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform _HeadIKReference
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HeadIKReference));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HeadIKReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float AbilityCompensationWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_AbilityCompensationWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_AbilityCompensationWeight)) = value;
      }
    }

    public unsafe Vector3 _TakeOffTargetPosition
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__TakeOffTargetPosition));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__TakeOffTargetPosition)) = value;
      }
    }

    public unsafe float _TakeOffWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__TakeOffWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__TakeOffWeight)) = value;
      }
    }

    public unsafe float _LeanWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__LeanWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__LeanWeight)) = value;
      }
    }

    public unsafe float _LeanAccTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__LeanAccTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__LeanAccTime)) = value;
      }
    }

    public unsafe float _LeanAccSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__LeanAccSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__LeanAccSpeed)) = value;
      }
    }

    public unsafe float _LeanDecSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__LeanDecSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__LeanDecSpeed)) = value;
      }
    }

    public unsafe bool _IsLocomotionSpine
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__IsLocomotionSpine));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__IsLocomotionSpine)) = value;
      }
    }

    public unsafe float ProceduralMountSystemBlendInDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_ProceduralMountSystemBlendInDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_ProceduralMountSystemBlendInDuration)) = value;
      }
    }

    public unsafe float ProceduralMountSystemBlendOutDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_ProceduralMountSystemBlendOutDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_ProceduralMountSystemBlendOutDuration)) = value;
      }
    }

    public unsafe float HorseCrossbowAimHeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_HorseCrossbowAimHeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_HorseCrossbowAimHeight)) = value;
      }
    }

    public unsafe float BendOffsetDuringIdle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BendOffsetDuringIdle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BendOffsetDuringIdle)) = value;
      }
    }

    public unsafe float BendOffsetDuringTrot
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BendOffsetDuringTrot));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BendOffsetDuringTrot)) = value;
      }
    }

    public unsafe float BendOffsetDuringGallop
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BendOffsetDuringGallop));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BendOffsetDuringGallop)) = value;
      }
    }

    public unsafe float LeanStrength
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_LeanStrength));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_LeanStrength)) = value;
      }
    }

    public unsafe int MountMovementPhase
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_MountMovementPhase));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_MountMovementPhase)) = value;
      }
    }

    public unsafe Animator MountAnimator
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_MountAnimator));
        return pointer == IntPtr.Zero ? (Animator) null : new Animator(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_MountAnimator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _LeanValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__LeanValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__LeanValue)) = value;
      }
    }

    public unsafe float _BendValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__BendValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__BendValue)) = value;
      }
    }

    public unsafe MagicaCapsuleCollider _HorseCollider
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HorseCollider));
        return pointer == IntPtr.Zero ? (MagicaCapsuleCollider) null : new MagicaCapsuleCollider(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HorseCollider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Animator _Animator
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__Animator));
        return pointer == IntPtr.Zero ? (Animator) null : new Animator(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__Animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform _Transform
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__Transform));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__Transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _Velocity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__Velocity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__Velocity)) = value;
      }
    }

    public unsafe float _StartRunTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__StartRunTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__StartRunTime)) = value;
      }
    }

    public unsafe float _StopRunTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__StopRunTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__StopRunTime)) = value;
      }
    }

    public unsafe Vector3 _StopDirection
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__StopDirection));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__StopDirection)) = value;
      }
    }

    public unsafe float _MountedSpineIKWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__MountedSpineIKWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__MountedSpineIKWeight)) = value;
      }
    }

    public unsafe float _SpineIKWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__SpineIKWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__SpineIKWeight)) = value;
      }
    }

    public unsafe Transform _SpineBendTransform
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__SpineBendTransform));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__SpineBendTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform _SpineLeanTransform
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__SpineLeanTransform));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__SpineLeanTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _ChestIKWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__ChestIKWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__ChestIKWeight)) = value;
      }
    }

    public unsafe float _HeadIKWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HeadIKWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HeadIKWeight)) = value;
      }
    }

    public unsafe float _LeftArmIKWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__LeftArmIKWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__LeftArmIKWeight)) = value;
      }
    }

    public unsafe float _RightArmIKWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__RightArmIKWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__RightArmIKWeight)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<CapsuleCollider> _MountColliders
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__MountColliders));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<CapsuleCollider>) null : new Il2CppReferenceArray<CapsuleCollider>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__MountColliders), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _MountedCrossbowAdditiveChestWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__MountedCrossbowAdditiveChestWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__MountedCrossbowAdditiveChestWeight)) = value;
      }
    }

    public unsafe HybridModelAnimationComponent _HybridModelAnimationComponent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HybridModelAnimationComponent));
        return pointer == IntPtr.Zero ? (HybridModelAnimationComponent) null : new HybridModelAnimationComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VampireSecondaryAnimationHandler.NativeFieldInfoPtr__HybridModelAnimationComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe int BoolIsInNullA
    {
      get
      {
        int boolIsInNullA;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BoolIsInNullA, (void*) &boolIsInNullA);
        return boolIsInNullA;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BoolIsInNullA, (void*) &value);
      }
    }

    public static unsafe int FloatNoZeroInstantInputX
    {
      get
      {
        int zeroInstantInputX;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatNoZeroInstantInputX, (void*) &zeroInstantInputX);
        return zeroInstantInputX;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatNoZeroInstantInputX, (void*) &value);
      }
    }

    public static unsafe int FloatNoZeroInstantInputY
    {
      get
      {
        int zeroInstantInputY;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatNoZeroInstantInputY, (void*) &zeroInstantInputY);
        return zeroInstantInputY;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatNoZeroInstantInputY, (void*) &value);
      }
    }

    public static unsafe int FloatLocomotionCycleOffset
    {
      get
      {
        int locomotionCycleOffset;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatLocomotionCycleOffset, (void*) &locomotionCycleOffset);
        return locomotionCycleOffset;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatLocomotionCycleOffset, (void*) &value);
      }
    }

    public static unsafe int BoolMounting
    {
      get
      {
        int boolMounting;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BoolMounting, (void*) &boolMounting);
        return boolMounting;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BoolMounting, (void*) &value);
      }
    }

    public static unsafe int BoolFiringCrossbow
    {
      get
      {
        int boolFiringCrossbow;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BoolFiringCrossbow, (void*) &boolFiringCrossbow);
        return boolFiringCrossbow;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BoolFiringCrossbow, (void*) &value);
      }
    }

    public static unsafe int FloatVelocity
    {
      get
      {
        int floatVelocity;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatVelocity, (void*) &floatVelocity);
        return floatVelocity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatVelocity, (void*) &value);
      }
    }

    public static unsafe int FloatRunDuration
    {
      get
      {
        int floatRunDuration;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatRunDuration, (void*) &floatRunDuration);
        return floatRunDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatRunDuration, (void*) &value);
      }
    }

    public static unsafe int FloatStopDuration
    {
      get
      {
        int floatStopDuration;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatStopDuration, (void*) &floatStopDuration);
        return floatStopDuration;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatStopDuration, (void*) &value);
      }
    }

    public static unsafe int FloatStopTurnAngle
    {
      get
      {
        int floatStopTurnAngle;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatStopTurnAngle, (void*) &floatStopTurnAngle);
        return floatStopTurnAngle;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatStopTurnAngle, (void*) &value);
      }
    }

    public static unsafe int FloatSoftAngleToTarget
    {
      get
      {
        int softAngleToTarget;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatSoftAngleToTarget, (void*) &softAngleToTarget);
        return softAngleToTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatSoftAngleToTarget, (void*) &value);
      }
    }

    public static unsafe int FloatSoftAngleToMouse
    {
      get
      {
        int softAngleToMouse;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatSoftAngleToMouse, (void*) &softAngleToMouse);
        return softAngleToMouse;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatSoftAngleToMouse, (void*) &value);
      }
    }

    public static unsafe int FloatAngleToMouseDirection
    {
      get
      {
        int toMouseDirection;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatAngleToMouseDirection, (void*) &toMouseDirection);
        return toMouseDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatAngleToMouseDirection, (void*) &value);
      }
    }

    public static unsafe int FloatChestTurnAngle
    {
      get
      {
        int floatChestTurnAngle;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatChestTurnAngle, (void*) &floatChestTurnAngle);
        return floatChestTurnAngle;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatChestTurnAngle, (void*) &value);
      }
    }

    public static unsafe int FloatLookAngle
    {
      get
      {
        int floatLookAngle;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatLookAngle, (void*) &floatLookAngle);
        return floatLookAngle;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatLookAngle, (void*) &value);
      }
    }

    public static unsafe int FloatHeadBendAngle
    {
      get
      {
        int floatHeadBendAngle;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatHeadBendAngle, (void*) &floatHeadBendAngle);
        return floatHeadBendAngle;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatHeadBendAngle, (void*) &value);
      }
    }

    public static unsafe int FloatMeleeTwistX
    {
      get
      {
        int floatMeleeTwistX;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatMeleeTwistX, (void*) &floatMeleeTwistX);
        return floatMeleeTwistX;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatMeleeTwistX, (void*) &value);
      }
    }

    public static unsafe int FloatMeleeTwistY
    {
      get
      {
        int floatMeleeTwistY;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatMeleeTwistY, (void*) &floatMeleeTwistY);
        return floatMeleeTwistY;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatMeleeTwistY, (void*) &value);
      }
    }

    public static unsafe int FloatMeleeTwistWeight
    {
      get
      {
        int meleeTwistWeight;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatMeleeTwistWeight, (void*) &meleeTwistWeight);
        return meleeTwistWeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatMeleeTwistWeight, (void*) &value);
      }
    }

    public static unsafe int FloatTurnWeight
    {
      get
      {
        int floatTurnWeight;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatTurnWeight, (void*) &floatTurnWeight);
        return floatTurnWeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatTurnWeight, (void*) &value);
      }
    }

    public static unsafe int FloatUpperBodyWeight
    {
      get
      {
        int floatUpperBodyWeight;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatUpperBodyWeight, (void*) &floatUpperBodyWeight);
        return floatUpperBodyWeight;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatUpperBodyWeight, (void*) &value);
      }
    }

    public static unsafe int BoolIsInCombat
    {
      get
      {
        int boolIsInCombat;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BoolIsInCombat, (void*) &boolIsInCombat);
        return boolIsInCombat;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BoolIsInCombat, (void*) &value);
      }
    }

    public static unsafe int BoolIsInNullAbility
    {
      get
      {
        int boolIsInNullAbility;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BoolIsInNullAbility, (void*) &boolIsInNullAbility);
        return boolIsInNullAbility;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_BoolIsInNullAbility, (void*) &value);
      }
    }

    public static unsafe int FloatTrueAbsoluteAngleToTarget
    {
      get
      {
        int absoluteAngleToTarget;
        IL2CPP.il2cpp_field_static_get_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatTrueAbsoluteAngleToTarget, (void*) &absoluteAngleToTarget);
        return absoluteAngleToTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VampireSecondaryAnimationHandler.NativeFieldInfoPtr_FloatTrueAbsoluteAngleToTarget, (void*) &value);
      }
    }
  }
}
