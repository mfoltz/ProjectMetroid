// Decompiled with JetBrains decompiler
// Type: ProjectM.QuadrupedSecondaryAnimationHandler
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
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class QuadrupedSecondaryAnimationHandler : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_IsMount;
    private static readonly IntPtr NativeFieldInfoPtr_SoftAdditiveTurnSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_SoftIdleTurnSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_DirectionBufferSize;
    private static readonly IntPtr NativeFieldInfoPtr_TurnLeanFactor;
    private static readonly IntPtr NativeFieldInfoPtr_LeanClampedAt;
    private static readonly IntPtr NativeFieldInfoPtr_LeftFrontLegIK;
    private static readonly IntPtr NativeFieldInfoPtr_RightFrontLegIK;
    private static readonly IntPtr NativeFieldInfoPtr_LeftBackLegIK;
    private static readonly IntPtr NativeFieldInfoPtr_RightBackLegIK;
    private static readonly IntPtr NativeFieldInfoPtr_LockFeetInIdle;
    private static readonly IntPtr NativeFieldInfoPtr_FeetLockBlendDuration;
    private static readonly IntPtr NativeFieldInfoPtr_LockTranslation;
    private static readonly IntPtr NativeFieldInfoPtr_LockRotation;
    private static readonly IntPtr NativeFieldInfoPtr_HeadAimSpeed;
    private static readonly IntPtr NativeFieldInfoPtr__Animator;
    private static readonly IntPtr NativeFieldInfoPtr__Transform;
    private static readonly IntPtr NativeFieldInfoPtr__LegIKs;
    private static readonly IntPtr NativeFieldInfoPtr__DirectionBuffer;
    private static readonly IntPtr NativeFieldInfoPtr__LockFeet;
    private static readonly IntPtr NativeFieldInfoPtr__LockInstant;
    private static readonly IntPtr NativeFieldInfoPtr__UnlockInstant;
    private static readonly IntPtr NativeFieldInfoPtr__FeetLockCallOneShot;
    private static readonly IntPtr NativeFieldInfoPtr__AimTargetWorldPos;
    private static readonly IntPtr NativeFieldInfoPtr__AimAngle;
    private static readonly IntPtr NativeFieldInfoPtr__TurnFactor;
    private static readonly IntPtr NativeFieldInfoPtr__SoftAngleToTarget;
    private static readonly IntPtr NativeFieldInfoPtr__SoftAngleToMouse;
    private static readonly IntPtr NativeFieldInfoPtr__InternalMounterData;
    private static readonly IntPtr NativeFieldInfoPtr_FloatTurnFactor;
    private static readonly IntPtr NativeFieldInfoPtr_FloatHeadAimAngle;
    private static readonly IntPtr NativeFieldInfoPtr_FloatAngleToMouseDirection;
    private static readonly IntPtr NativeFieldInfoPtr_FloatAngleToTargetDirection;
    private static readonly IntPtr NativeFieldInfoPtr_FloatSoftAngleToTarget;
    private static readonly IntPtr NativeFieldInfoPtr_FloatSoftAngleToMouse;
    private static readonly IntPtr NativeFieldInfoPtr_FloatVelocityDirection;
    private static readonly IntPtr NativeFieldInfoPtr_FloatVelocity;
    private static readonly IntPtr NativeFieldInfoPtr_BoolFreeFeet;
    private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetPosNeg_Private_Static_Single_Vector3_Vector3_0;
    private static readonly IntPtr NativeMethodInfoPtr_TransitionIKTranslationWeight_Private_Void_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_TransitionIKRotationWeight_Private_Void_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetIkTranslationWeight_Private_Void_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetIkRotationWeight_Private_Void_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetAimTarget_Public_Void_Vector3_0;
    private static readonly IntPtr NativeMethodInfoPtr_LockFeet_Public_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_UnlockFeet_Public_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_FeedMounterData_Public_Void_Vector3_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976451, XrefRangeEnd = 976495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976495, XrefRangeEnd = 976565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976565, XrefRangeEnd = 976571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LateUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976571, XrefRangeEnd = 976573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float GetPosNeg(Vector3 right, Vector3 aim)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &right;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &aim;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_GetPosNeg_Private_Static_Single_Vector3_Vector3_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 976576, RefRangeEnd = 976577, XrefRangeStart = 976573, XrefRangeEnd = 976576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TransitionIKTranslationWeight(float goalWeight)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &goalWeight;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_TransitionIKTranslationWeight_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 976580, RefRangeEnd = 976581, XrefRangeStart = 976577, XrefRangeEnd = 976580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TransitionIKRotationWeight(float goalWeight)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &goalWeight;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_TransitionIKRotationWeight_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976581, XrefRangeEnd = 976582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetIkTranslationWeight(float weight)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &weight;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_SetIkTranslationWeight_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976582, XrefRangeEnd = 976583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetIkRotationWeight(float weight)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &weight;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_SetIkRotationWeight_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void SetAimTarget(Vector3 worldPos)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &worldPos;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_SetAimTarget_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 976591, RefRangeEnd = 976592, XrefRangeStart = 976583, XrefRangeEnd = 976591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LockFeet(bool instant)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &instant;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_LockFeet_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 976592, RefRangeEnd = 976593, XrefRangeStart = 976592, XrefRangeEnd = 976592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UnlockFeet(bool instant)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &instant;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_UnlockFeet_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 976593, RefRangeEnd = 976594, XrefRangeStart = 976593, XrefRangeEnd = 976593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FeedMounterData(Vector3 velocity, float angleToMouse)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &velocity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &angleToMouse;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_FeedMounterData_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976594, XrefRangeEnd = 976595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe QuadrupedSecondaryAnimationHandler()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static QuadrupedSecondaryAnimationHandler()
    {
      Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (QuadrupedSecondaryAnimationHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr);
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_IsMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (IsMount));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_SoftAdditiveTurnSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (SoftAdditiveTurnSpeed));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_SoftIdleTurnSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (SoftIdleTurnSpeed));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_DirectionBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (DirectionBufferSize));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_TurnLeanFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (TurnLeanFactor));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_LeanClampedAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (LeanClampedAt));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_LeftFrontLegIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (LeftFrontLegIK));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_RightFrontLegIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (RightFrontLegIK));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_LeftBackLegIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (LeftBackLegIK));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_RightBackLegIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (RightBackLegIK));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_LockFeetInIdle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (LockFeetInIdle));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FeetLockBlendDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (FeetLockBlendDuration));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_LockTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (LockTranslation));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_LockRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (LockRotation));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_HeadAimSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (HeadAimSpeed));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (_Animator));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (_Transform));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__LegIKs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (_LegIKs));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__DirectionBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (_DirectionBuffer));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__LockFeet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (_LockFeet));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__LockInstant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (_LockInstant));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__UnlockInstant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (_UnlockInstant));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__FeetLockCallOneShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (_FeetLockCallOneShot));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__AimTargetWorldPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (_AimTargetWorldPos));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__AimAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (_AimAngle));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__TurnFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (_TurnFactor));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__SoftAngleToTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (_SoftAngleToTarget));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__SoftAngleToMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (_SoftAngleToMouse));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__InternalMounterData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (_InternalMounterData));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatTurnFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatTurnFactor));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatHeadAimAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatHeadAimAngle));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatAngleToMouseDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatAngleToMouseDirection));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatAngleToTargetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatAngleToTargetDirection));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatSoftAngleToTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatSoftAngleToTarget));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatSoftAngleToMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatSoftAngleToMouse));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatVelocityDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatVelocityDirection));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (FloatVelocity));
      QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_BoolFreeFeet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, nameof (BoolFreeFeet));
      QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, 100675465);
      QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, 100675466);
      QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, 100675467);
      QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_GetPosNeg_Private_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, 100675468);
      QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_TransitionIKTranslationWeight_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, 100675469);
      QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_TransitionIKRotationWeight_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, 100675470);
      QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_SetIkTranslationWeight_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, 100675471);
      QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_SetIkRotationWeight_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, 100675472);
      QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_SetAimTarget_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, 100675473);
      QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_LockFeet_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, 100675474);
      QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_UnlockFeet_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, 100675475);
      QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr_FeedMounterData_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, 100675476);
      QuadrupedSecondaryAnimationHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadrupedSecondaryAnimationHandler>.NativeClassPtr, 100675477);
    }

    public QuadrupedSecondaryAnimationHandler(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool IsMount
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_IsMount));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_IsMount)) = value;
      }
    }

    public unsafe float SoftAdditiveTurnSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_SoftAdditiveTurnSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_SoftAdditiveTurnSpeed)) = value;
      }
    }

    public unsafe float SoftIdleTurnSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_SoftIdleTurnSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_SoftIdleTurnSpeed)) = value;
      }
    }

    public unsafe int DirectionBufferSize
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_DirectionBufferSize));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_DirectionBufferSize)) = value;
      }
    }

    public unsafe float TurnLeanFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_TurnLeanFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_TurnLeanFactor)) = value;
      }
    }

    public unsafe float LeanClampedAt
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_LeanClampedAt));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_LeanClampedAt)) = value;
      }
    }

    public unsafe LegIK LeftFrontLegIK
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_LeftFrontLegIK));
        return pointer == IntPtr.Zero ? (LegIK) null : new LegIK(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_LeftFrontLegIK), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LegIK RightFrontLegIK
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_RightFrontLegIK));
        return pointer == IntPtr.Zero ? (LegIK) null : new LegIK(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_RightFrontLegIK), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LegIK LeftBackLegIK
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_LeftBackLegIK));
        return pointer == IntPtr.Zero ? (LegIK) null : new LegIK(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_LeftBackLegIK), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LegIK RightBackLegIK
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_RightBackLegIK));
        return pointer == IntPtr.Zero ? (LegIK) null : new LegIK(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_RightBackLegIK), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool LockFeetInIdle
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_LockFeetInIdle));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_LockFeetInIdle)) = value;
      }
    }

    public unsafe float FeetLockBlendDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FeetLockBlendDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FeetLockBlendDuration)) = value;
      }
    }

    public unsafe bool LockTranslation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_LockTranslation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_LockTranslation)) = value;
      }
    }

    public unsafe bool LockRotation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_LockRotation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_LockRotation)) = value;
      }
    }

    public unsafe float HeadAimSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_HeadAimSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_HeadAimSpeed)) = value;
      }
    }

    public unsafe Animator _Animator
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__Animator));
        return pointer == IntPtr.Zero ? (Animator) null : new Animator(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__Animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform _Transform
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__Transform));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__Transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<LegIK> _LegIKs
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__LegIKs));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<LegIK>) null : new Il2CppReferenceArray<LegIK>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__LegIKs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<Vector3> _DirectionBuffer
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__DirectionBuffer));
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : new Il2CppStructArray<Vector3>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__DirectionBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _LockFeet
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__LockFeet));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__LockFeet)) = value;
      }
    }

    public unsafe bool _LockInstant
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__LockInstant));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__LockInstant)) = value;
      }
    }

    public unsafe bool _UnlockInstant
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__UnlockInstant));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__UnlockInstant)) = value;
      }
    }

    public unsafe bool _FeetLockCallOneShot
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__FeetLockCallOneShot));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__FeetLockCallOneShot)) = value;
      }
    }

    public unsafe Vector3 _AimTargetWorldPos
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__AimTargetWorldPos));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__AimTargetWorldPos)) = value;
      }
    }

    public unsafe float _AimAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__AimAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__AimAngle)) = value;
      }
    }

    public unsafe float _TurnFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__TurnFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__TurnFactor)) = value;
      }
    }

    public unsafe float _SoftAngleToTarget
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__SoftAngleToTarget));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__SoftAngleToTarget)) = value;
      }
    }

    public unsafe float _SoftAngleToMouse
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__SoftAngleToMouse));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__SoftAngleToMouse)) = value;
      }
    }

    public unsafe InternalMounterData _InternalMounterData
    {
      get
      {
        return *(InternalMounterData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__InternalMounterData));
      }
      [param: In] set
      {
        *(InternalMounterData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr__InternalMounterData)) = value;
      }
    }

    public static unsafe int FloatTurnFactor
    {
      get
      {
        int floatTurnFactor;
        IL2CPP.il2cpp_field_static_get_value(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatTurnFactor, (void*) &floatTurnFactor);
        return floatTurnFactor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatTurnFactor, (void*) &value);
      }
    }

    public static unsafe int FloatHeadAimAngle
    {
      get
      {
        int floatHeadAimAngle;
        IL2CPP.il2cpp_field_static_get_value(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatHeadAimAngle, (void*) &floatHeadAimAngle);
        return floatHeadAimAngle;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatHeadAimAngle, (void*) &value);
      }
    }

    public static unsafe int FloatAngleToMouseDirection
    {
      get
      {
        int toMouseDirection;
        IL2CPP.il2cpp_field_static_get_value(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatAngleToMouseDirection, (void*) &toMouseDirection);
        return toMouseDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatAngleToMouseDirection, (void*) &value);
      }
    }

    public static unsafe int FloatAngleToTargetDirection
    {
      get
      {
        int toTargetDirection;
        IL2CPP.il2cpp_field_static_get_value(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatAngleToTargetDirection, (void*) &toTargetDirection);
        return toTargetDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatAngleToTargetDirection, (void*) &value);
      }
    }

    public static unsafe int FloatSoftAngleToTarget
    {
      get
      {
        int softAngleToTarget;
        IL2CPP.il2cpp_field_static_get_value(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatSoftAngleToTarget, (void*) &softAngleToTarget);
        return softAngleToTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatSoftAngleToTarget, (void*) &value);
      }
    }

    public static unsafe int FloatSoftAngleToMouse
    {
      get
      {
        int softAngleToMouse;
        IL2CPP.il2cpp_field_static_get_value(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatSoftAngleToMouse, (void*) &softAngleToMouse);
        return softAngleToMouse;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatSoftAngleToMouse, (void*) &value);
      }
    }

    public static unsafe int FloatVelocityDirection
    {
      get
      {
        int velocityDirection;
        IL2CPP.il2cpp_field_static_get_value(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatVelocityDirection, (void*) &velocityDirection);
        return velocityDirection;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatVelocityDirection, (void*) &value);
      }
    }

    public static unsafe int FloatVelocity
    {
      get
      {
        int floatVelocity;
        IL2CPP.il2cpp_field_static_get_value(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatVelocity, (void*) &floatVelocity);
        return floatVelocity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_FloatVelocity, (void*) &value);
      }
    }

    public static unsafe int BoolFreeFeet
    {
      get
      {
        int boolFreeFeet;
        IL2CPP.il2cpp_field_static_get_value(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_BoolFreeFeet, (void*) &boolFreeFeet);
        return boolFreeFeet;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(QuadrupedSecondaryAnimationHandler.NativeFieldInfoPtr_BoolFreeFeet, (void*) &value);
      }
    }
  }
}
