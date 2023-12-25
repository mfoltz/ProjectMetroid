﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.ApplyKnockbackOnGameplayEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ApplyKnockbackOnGameplayEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Range;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationAngleOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_KnockbackPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_DirectionType;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModelDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomKnockbackBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseMinMaxRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinDistanceToTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistanceToTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_CloseRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_FarRange;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0;
    [FieldOffset(0)]
    public float Duration;
    [FieldOffset(4)]
    public float Range;
    [FieldOffset(8)]
    public float RotationAngleOffset;
    [FieldOffset(12)]
    public KnockbackPower KnockbackPower;
    [FieldOffset(192)]
    public KnockbackDirectionType DirectionType;
    [FieldOffset(196)]
    public KnockbackTargetType TargetType;
    [FieldOffset(200)]
    public MovementCurveRotationMode ModelDirection;
    [FieldOffset(204)]
    public PrefabGUID CustomKnockbackBuff;
    [FieldOffset(208)]
    public bool UseMinMaxRange;
    [FieldOffset(212)]
    public float MinDistanceToTarget;
    [FieldOffset(216)]
    public float MaxDistanceToTarget;
    [FieldOffset(220)]
    public float CloseRange;
    [FieldOffset(224)]
    public float FarRange;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007846, XrefRangeEnd = 1007857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ApplyArithmetic(SpellModArithmetic spellMod, float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ApplyKnockbackOnGameplayEvent.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ApplyKnockbackOnGameplayEvent()
    {
      Il2CppClassPointerStore<ApplyKnockbackOnGameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ApplyKnockbackOnGameplayEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEvent>.NativeClassPtr);
      ApplyKnockbackOnGameplayEvent.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEvent>.NativeClassPtr, nameof (Duration));
      ApplyKnockbackOnGameplayEvent.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEvent>.NativeClassPtr, nameof (Range));
      ApplyKnockbackOnGameplayEvent.NativeFieldInfoPtr_RotationAngleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEvent>.NativeClassPtr, nameof (RotationAngleOffset));
      ApplyKnockbackOnGameplayEvent.NativeFieldInfoPtr_KnockbackPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEvent>.NativeClassPtr, nameof (KnockbackPower));
      ApplyKnockbackOnGameplayEvent.NativeFieldInfoPtr_DirectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEvent>.NativeClassPtr, nameof (DirectionType));
      ApplyKnockbackOnGameplayEvent.NativeFieldInfoPtr_TargetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEvent>.NativeClassPtr, nameof (TargetType));
      ApplyKnockbackOnGameplayEvent.NativeFieldInfoPtr_ModelDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEvent>.NativeClassPtr, nameof (ModelDirection));
      ApplyKnockbackOnGameplayEvent.NativeFieldInfoPtr_CustomKnockbackBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEvent>.NativeClassPtr, nameof (CustomKnockbackBuff));
      ApplyKnockbackOnGameplayEvent.NativeFieldInfoPtr_UseMinMaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEvent>.NativeClassPtr, nameof (UseMinMaxRange));
      ApplyKnockbackOnGameplayEvent.NativeFieldInfoPtr_MinDistanceToTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEvent>.NativeClassPtr, nameof (MinDistanceToTarget));
      ApplyKnockbackOnGameplayEvent.NativeFieldInfoPtr_MaxDistanceToTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEvent>.NativeClassPtr, nameof (MaxDistanceToTarget));
      ApplyKnockbackOnGameplayEvent.NativeFieldInfoPtr_CloseRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEvent>.NativeClassPtr, nameof (CloseRange));
      ApplyKnockbackOnGameplayEvent.NativeFieldInfoPtr_FarRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEvent>.NativeClassPtr, nameof (FarRange));
      ApplyKnockbackOnGameplayEvent.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEvent>.NativeClassPtr, 100678246);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ApplyKnockbackOnGameplayEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
