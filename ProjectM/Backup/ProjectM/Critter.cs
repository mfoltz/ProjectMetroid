// Decompiled with JetBrains decompiler
// Type: ProjectM.Critter
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class Critter : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_TransformToMove;
    private static readonly IntPtr NativeFieldInfoPtr_AnimationVelocity;
    private static readonly IntPtr NativeFieldInfoPtr_BaseLayerAnimSpeedMultiplier;
    private static readonly IntPtr NativeFieldInfoPtr_AnimSpeedMultiplier;
    private static readonly IntPtr NativeFieldInfoPtr_RotationSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_RotationSpeedDuringEscape;
    private static readonly IntPtr NativeFieldInfoPtr_MovementSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_GoalPositionRadiusAllowance;
    private static readonly IntPtr NativeFieldInfoPtr_EscapePoint;
    private static readonly IntPtr NativeFieldInfoPtr_RestDurationMinMax;
    private static readonly IntPtr NativeFieldInfoPtr_ScaleDownDuringEscape;
    private static readonly IntPtr NativeFieldInfoPtr_UseSpecialFleeAnimation;
    private static readonly IntPtr NativeFieldInfoPtr_TakeOffDuration;
    private static readonly IntPtr NativeFieldInfoPtr_EscapeDelay;
    private static readonly IntPtr NativeFieldInfoPtr_Stationary;
    private static readonly IntPtr NativeFieldInfoPtr_UseAdditiveTurnAnimations;
    private static readonly IntPtr NativeFieldInfoPtr_TurnLayerIndex;
    private static readonly IntPtr NativeFieldInfoPtr_MaxAngleThreshold;
    private static readonly IntPtr NativeFieldInfoPtr_LayerLerpStepSize;
    private static readonly IntPtr NativeFieldInfoPtr_AdditivePoseStrength;
    private static readonly IntPtr NativeFieldInfoPtr_Escape;
    private static readonly IntPtr NativeFieldInfoPtr_DistanceToEscapeTargetSnapshot;
    private static readonly IntPtr NativeFieldInfoPtr_GoalPoint;
    private static readonly IntPtr NativeFieldInfoPtr_RestDuration;
    private static readonly IntPtr NativeFieldInfoPtr_Animator;
    private static readonly IntPtr NativeFieldInfoPtr_OutOfBoundsTimer;
    private static readonly IntPtr NativeFieldInfoPtr_EscapeDelayTimer;
    private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateCritter_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988004, XrefRangeEnd = 988010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Critter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988010, XrefRangeEnd = 988012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateCritter()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Critter.NativeMethodInfoPtr_UpdateCritter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988012, XrefRangeEnd = 988024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDrawGizmosSelected()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Critter.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988024, XrefRangeEnd = 988025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Critter()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Critter>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Critter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Critter()
    {
      Il2CppClassPointerStore<Critter>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (Critter));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Critter>.NativeClassPtr);
      Critter.NativeFieldInfoPtr_TransformToMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (TransformToMove));
      Critter.NativeFieldInfoPtr_AnimationVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (AnimationVelocity));
      Critter.NativeFieldInfoPtr_BaseLayerAnimSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (BaseLayerAnimSpeedMultiplier));
      Critter.NativeFieldInfoPtr_AnimSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (AnimSpeedMultiplier));
      Critter.NativeFieldInfoPtr_RotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (RotationSpeed));
      Critter.NativeFieldInfoPtr_RotationSpeedDuringEscape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (RotationSpeedDuringEscape));
      Critter.NativeFieldInfoPtr_MovementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (MovementSpeed));
      Critter.NativeFieldInfoPtr_GoalPositionRadiusAllowance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (GoalPositionRadiusAllowance));
      Critter.NativeFieldInfoPtr_EscapePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (EscapePoint));
      Critter.NativeFieldInfoPtr_RestDurationMinMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (RestDurationMinMax));
      Critter.NativeFieldInfoPtr_ScaleDownDuringEscape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (ScaleDownDuringEscape));
      Critter.NativeFieldInfoPtr_UseSpecialFleeAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (UseSpecialFleeAnimation));
      Critter.NativeFieldInfoPtr_TakeOffDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (TakeOffDuration));
      Critter.NativeFieldInfoPtr_EscapeDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (EscapeDelay));
      Critter.NativeFieldInfoPtr_Stationary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (Stationary));
      Critter.NativeFieldInfoPtr_UseAdditiveTurnAnimations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (UseAdditiveTurnAnimations));
      Critter.NativeFieldInfoPtr_TurnLayerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (TurnLayerIndex));
      Critter.NativeFieldInfoPtr_MaxAngleThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (MaxAngleThreshold));
      Critter.NativeFieldInfoPtr_LayerLerpStepSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (LayerLerpStepSize));
      Critter.NativeFieldInfoPtr_AdditivePoseStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (AdditivePoseStrength));
      Critter.NativeFieldInfoPtr_Escape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (Escape));
      Critter.NativeFieldInfoPtr_DistanceToEscapeTargetSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (DistanceToEscapeTargetSnapshot));
      Critter.NativeFieldInfoPtr_GoalPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (GoalPoint));
      Critter.NativeFieldInfoPtr_RestDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (RestDuration));
      Critter.NativeFieldInfoPtr_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (Animator));
      Critter.NativeFieldInfoPtr_OutOfBoundsTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (OutOfBoundsTimer));
      Critter.NativeFieldInfoPtr_EscapeDelayTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Critter>.NativeClassPtr, nameof (EscapeDelayTimer));
      Critter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Critter>.NativeClassPtr, 100676189);
      Critter.NativeMethodInfoPtr_UpdateCritter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Critter>.NativeClassPtr, 100676190);
      Critter.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Critter>.NativeClassPtr, 100676191);
      Critter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Critter>.NativeClassPtr, 100676192);
    }

    public Critter(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Transform TransformToMove
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_TransformToMove));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_TransformToMove), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float AnimationVelocity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_AnimationVelocity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_AnimationVelocity)) = value;
      }
    }

    public unsafe float BaseLayerAnimSpeedMultiplier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_BaseLayerAnimSpeedMultiplier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_BaseLayerAnimSpeedMultiplier)) = value;
      }
    }

    public unsafe float AnimSpeedMultiplier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_AnimSpeedMultiplier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_AnimSpeedMultiplier)) = value;
      }
    }

    public unsafe float RotationSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_RotationSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_RotationSpeed)) = value;
      }
    }

    public unsafe float RotationSpeedDuringEscape
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_RotationSpeedDuringEscape));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_RotationSpeedDuringEscape)) = value;
      }
    }

    public unsafe float MovementSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_MovementSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_MovementSpeed)) = value;
      }
    }

    public unsafe float GoalPositionRadiusAllowance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_GoalPositionRadiusAllowance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_GoalPositionRadiusAllowance)) = value;
      }
    }

    public unsafe Transform EscapePoint
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_EscapePoint));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_EscapePoint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector2 RestDurationMinMax
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_RestDurationMinMax));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_RestDurationMinMax)) = value;
      }
    }

    public unsafe bool ScaleDownDuringEscape
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_ScaleDownDuringEscape));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_ScaleDownDuringEscape)) = value;
      }
    }

    public unsafe bool UseSpecialFleeAnimation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_UseSpecialFleeAnimation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_UseSpecialFleeAnimation)) = value;
      }
    }

    public unsafe float TakeOffDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_TakeOffDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_TakeOffDuration)) = value;
      }
    }

    public unsafe float EscapeDelay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_EscapeDelay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_EscapeDelay)) = value;
      }
    }

    public unsafe bool Stationary
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_Stationary));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_Stationary)) = value;
      }
    }

    public unsafe bool UseAdditiveTurnAnimations
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_UseAdditiveTurnAnimations));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_UseAdditiveTurnAnimations)) = value;
      }
    }

    public unsafe int TurnLayerIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_TurnLayerIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_TurnLayerIndex)) = value;
      }
    }

    public unsafe float MaxAngleThreshold
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_MaxAngleThreshold));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_MaxAngleThreshold)) = value;
      }
    }

    public unsafe float LayerLerpStepSize
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_LayerLerpStepSize));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_LayerLerpStepSize)) = value;
      }
    }

    public unsafe float AdditivePoseStrength
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_AdditivePoseStrength));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_AdditivePoseStrength)) = value;
      }
    }

    public unsafe bool Escape
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_Escape));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_Escape)) = value;
      }
    }

    public unsafe float DistanceToEscapeTargetSnapshot
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_DistanceToEscapeTargetSnapshot));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_DistanceToEscapeTargetSnapshot)) = value;
      }
    }

    public unsafe Vector3 GoalPoint
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_GoalPoint));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_GoalPoint)) = value;
      }
    }

    public unsafe float RestDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_RestDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_RestDuration)) = value;
      }
    }

    public unsafe Animator Animator
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_Animator));
        return pointer == IntPtr.Zero ? (Animator) null : new Animator(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_Animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float OutOfBoundsTimer
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_OutOfBoundsTimer));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_OutOfBoundsTimer)) = value;
      }
    }

    public unsafe float EscapeDelayTimer
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_EscapeDelayTimer));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Critter.NativeFieldInfoPtr_EscapeDelayTimer)) = value;
      }
    }
  }
}
