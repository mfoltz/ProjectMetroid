// Decompiled with JetBrains decompiler
// Type: ProjectM.CritterAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class CritterAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_EscapeSequence;
    private static readonly IntPtr NativeFieldInfoPtr_Lifetime;
    private static readonly IntPtr NativeFieldInfoPtr_EscapeSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_RotationSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_OnAggroDuration;
    private static readonly IntPtr NativeFieldInfoPtr_TurnToEscapeDuration;
    private static readonly IntPtr NativeFieldInfoPtr_FadeOutTime;
    private static readonly IntPtr NativeFieldInfoPtr_IdleAnimationSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_OnAggroAnimationSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_EscapeAnimationSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_EscapesByFlying;
    private static readonly IntPtr NativeFieldInfoPtr_IsTame;
    private static readonly IntPtr NativeFieldInfoPtr_CanBeSteppedOn;
    private static readonly IntPtr NativeFieldInfoPtr_SteppedOnSequence;
    private static readonly IntPtr NativeFieldInfoPtr_StepCollisionSphereRadius;
    private static readonly IntPtr NativeFieldInfoPtr_SteppedOnSequenceDuration;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988025, XrefRangeEnd = 988032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988032, XrefRangeEnd = 988054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CritterAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CritterAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CritterAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CritterAuthoring()
    {
      Il2CppClassPointerStore<CritterAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CritterAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterAuthoring>.NativeClassPtr);
      CritterAuthoring.NativeFieldInfoPtr_EscapeSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterAuthoring>.NativeClassPtr, nameof (EscapeSequence));
      CritterAuthoring.NativeFieldInfoPtr_Lifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterAuthoring>.NativeClassPtr, nameof (Lifetime));
      CritterAuthoring.NativeFieldInfoPtr_EscapeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterAuthoring>.NativeClassPtr, nameof (EscapeSpeed));
      CritterAuthoring.NativeFieldInfoPtr_RotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterAuthoring>.NativeClassPtr, nameof (RotationSpeed));
      CritterAuthoring.NativeFieldInfoPtr_OnAggroDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterAuthoring>.NativeClassPtr, nameof (OnAggroDuration));
      CritterAuthoring.NativeFieldInfoPtr_TurnToEscapeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterAuthoring>.NativeClassPtr, nameof (TurnToEscapeDuration));
      CritterAuthoring.NativeFieldInfoPtr_FadeOutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterAuthoring>.NativeClassPtr, nameof (FadeOutTime));
      CritterAuthoring.NativeFieldInfoPtr_IdleAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterAuthoring>.NativeClassPtr, nameof (IdleAnimationSpeed));
      CritterAuthoring.NativeFieldInfoPtr_OnAggroAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterAuthoring>.NativeClassPtr, nameof (OnAggroAnimationSpeed));
      CritterAuthoring.NativeFieldInfoPtr_EscapeAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterAuthoring>.NativeClassPtr, nameof (EscapeAnimationSpeed));
      CritterAuthoring.NativeFieldInfoPtr_EscapesByFlying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterAuthoring>.NativeClassPtr, nameof (EscapesByFlying));
      CritterAuthoring.NativeFieldInfoPtr_IsTame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterAuthoring>.NativeClassPtr, nameof (IsTame));
      CritterAuthoring.NativeFieldInfoPtr_CanBeSteppedOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterAuthoring>.NativeClassPtr, nameof (CanBeSteppedOn));
      CritterAuthoring.NativeFieldInfoPtr_SteppedOnSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterAuthoring>.NativeClassPtr, nameof (SteppedOnSequence));
      CritterAuthoring.NativeFieldInfoPtr_StepCollisionSphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterAuthoring>.NativeClassPtr, nameof (StepCollisionSphereRadius));
      CritterAuthoring.NativeFieldInfoPtr_SteppedOnSequenceDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterAuthoring>.NativeClassPtr, nameof (SteppedOnSequenceDuration));
      CritterAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterAuthoring>.NativeClassPtr, 100676196);
      CritterAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CritterAuthoring>.NativeClassPtr, 100676197);
    }

    public CritterAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SequenceField EscapeSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_EscapeSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_EscapeSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float Lifetime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_Lifetime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_Lifetime)) = value;
      }
    }

    public unsafe float EscapeSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_EscapeSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_EscapeSpeed)) = value;
      }
    }

    public unsafe float RotationSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_RotationSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_RotationSpeed)) = value;
      }
    }

    public unsafe float OnAggroDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_OnAggroDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_OnAggroDuration)) = value;
      }
    }

    public unsafe float TurnToEscapeDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_TurnToEscapeDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_TurnToEscapeDuration)) = value;
      }
    }

    public unsafe float FadeOutTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_FadeOutTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_FadeOutTime)) = value;
      }
    }

    public unsafe float IdleAnimationSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_IdleAnimationSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_IdleAnimationSpeed)) = value;
      }
    }

    public unsafe float OnAggroAnimationSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_OnAggroAnimationSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_OnAggroAnimationSpeed)) = value;
      }
    }

    public unsafe float EscapeAnimationSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_EscapeAnimationSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_EscapeAnimationSpeed)) = value;
      }
    }

    public unsafe bool EscapesByFlying
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_EscapesByFlying));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_EscapesByFlying)) = value;
      }
    }

    public unsafe bool IsTame
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_IsTame));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_IsTame)) = value;
      }
    }

    public unsafe bool CanBeSteppedOn
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_CanBeSteppedOn));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_CanBeSteppedOn)) = value;
      }
    }

    public unsafe SequenceField SteppedOnSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_SteppedOnSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_SteppedOnSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float StepCollisionSphereRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_StepCollisionSphereRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_StepCollisionSphereRadius)) = value;
      }
    }

    public unsafe float SteppedOnSequenceDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_SteppedOnSequenceDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CritterAuthoring.NativeFieldInfoPtr_SteppedOnSequenceDuration)) = value;
      }
    }
  }
}
