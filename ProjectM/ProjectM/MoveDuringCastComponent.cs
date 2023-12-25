// Decompiled with JetBrains decompiler
// Type: ProjectM.MoveDuringCastComponent
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
namespace ProjectM
{
  public class MoveDuringCastComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_MoveType;
    private static readonly IntPtr NativeFieldInfoPtr_ExcludePostCastDuration;
    private static readonly IntPtr NativeFieldInfoPtr_UseManualDuration;
    private static readonly IntPtr NativeFieldInfoPtr_ManualDuration;
    private static readonly IntPtr NativeFieldInfoPtr_ForceMovementLength;
    private static readonly IntPtr NativeFieldInfoPtr_CurveX;
    private static readonly IntPtr NativeFieldInfoPtr_CurveY;
    private static readonly IntPtr NativeFieldInfoPtr_CurveZ;
    private static readonly IntPtr NativeFieldInfoPtr_ModelOffsetCurveX;
    private static readonly IntPtr NativeFieldInfoPtr_ModelOffsetCurveY;
    private static readonly IntPtr NativeFieldInfoPtr_ModelOffsetCurveZ;
    private static readonly IntPtr NativeFieldInfoPtr_ForceMoveType;
    private static readonly IntPtr NativeFieldInfoPtr_OnlyForceMoveIfAnyMoveInput;
    private static readonly IntPtr NativeFieldInfoPtr_IgnoreMovementImpair;
    private static readonly IntPtr NativeFieldInfoPtr_IgnoreMovementSpeedChanges;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996213, XrefRangeEnd = 996216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(MoveDuringCastComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MoveDuringCastComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveDuringCastComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MoveDuringCastComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MoveDuringCastComponent()
    {
      Il2CppClassPointerStore<MoveDuringCastComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (MoveDuringCastComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveDuringCastComponent>.NativeClassPtr);
      MoveDuringCastComponent.NativeFieldInfoPtr_MoveType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastComponent>.NativeClassPtr, nameof (MoveType));
      MoveDuringCastComponent.NativeFieldInfoPtr_ExcludePostCastDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastComponent>.NativeClassPtr, nameof (ExcludePostCastDuration));
      MoveDuringCastComponent.NativeFieldInfoPtr_UseManualDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastComponent>.NativeClassPtr, nameof (UseManualDuration));
      MoveDuringCastComponent.NativeFieldInfoPtr_ManualDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastComponent>.NativeClassPtr, nameof (ManualDuration));
      MoveDuringCastComponent.NativeFieldInfoPtr_ForceMovementLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastComponent>.NativeClassPtr, nameof (ForceMovementLength));
      MoveDuringCastComponent.NativeFieldInfoPtr_CurveX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastComponent>.NativeClassPtr, nameof (CurveX));
      MoveDuringCastComponent.NativeFieldInfoPtr_CurveY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastComponent>.NativeClassPtr, nameof (CurveY));
      MoveDuringCastComponent.NativeFieldInfoPtr_CurveZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastComponent>.NativeClassPtr, nameof (CurveZ));
      MoveDuringCastComponent.NativeFieldInfoPtr_ModelOffsetCurveX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastComponent>.NativeClassPtr, nameof (ModelOffsetCurveX));
      MoveDuringCastComponent.NativeFieldInfoPtr_ModelOffsetCurveY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastComponent>.NativeClassPtr, nameof (ModelOffsetCurveY));
      MoveDuringCastComponent.NativeFieldInfoPtr_ModelOffsetCurveZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastComponent>.NativeClassPtr, nameof (ModelOffsetCurveZ));
      MoveDuringCastComponent.NativeFieldInfoPtr_ForceMoveType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastComponent>.NativeClassPtr, nameof (ForceMoveType));
      MoveDuringCastComponent.NativeFieldInfoPtr_OnlyForceMoveIfAnyMoveInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastComponent>.NativeClassPtr, nameof (OnlyForceMoveIfAnyMoveInput));
      MoveDuringCastComponent.NativeFieldInfoPtr_IgnoreMovementImpair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastComponent>.NativeClassPtr, nameof (IgnoreMovementImpair));
      MoveDuringCastComponent.NativeFieldInfoPtr_IgnoreMovementSpeedChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveDuringCastComponent>.NativeClassPtr, nameof (IgnoreMovementSpeedChanges));
      MoveDuringCastComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveDuringCastComponent>.NativeClassPtr, 100676970);
      MoveDuringCastComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveDuringCastComponent>.NativeClassPtr, 100676971);
    }

    public MoveDuringCastComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe AbilityMoveType MoveType
    {
      get
      {
        return *(AbilityMoveType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_MoveType));
      }
      [param: In] set
      {
        *(AbilityMoveType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_MoveType)) = value;
      }
    }

    public unsafe bool ExcludePostCastDuration
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_ExcludePostCastDuration));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_ExcludePostCastDuration)) = value;
      }
    }

    public unsafe bool UseManualDuration
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_UseManualDuration));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_UseManualDuration)) = value;
      }
    }

    public unsafe float ManualDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_ManualDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_ManualDuration)) = value;
      }
    }

    public unsafe float ForceMovementLength
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_ForceMovementLength));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_ForceMovementLength)) = value;
      }
    }

    public unsafe CurveReference CurveX
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_CurveX));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_CurveX)) = value;
      }
    }

    public unsafe CurveReference CurveY
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_CurveY));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_CurveY)) = value;
      }
    }

    public unsafe CurveReference CurveZ
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_CurveZ));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_CurveZ)) = value;
      }
    }

    public unsafe CurveReference ModelOffsetCurveX
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_ModelOffsetCurveX));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_ModelOffsetCurveX)) = value;
      }
    }

    public unsafe CurveReference ModelOffsetCurveY
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_ModelOffsetCurveY));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_ModelOffsetCurveY)) = value;
      }
    }

    public unsafe CurveReference ModelOffsetCurveZ
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_ModelOffsetCurveZ));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_ModelOffsetCurveZ)) = value;
      }
    }

    public unsafe ForceMoveDuringCastType ForceMoveType
    {
      get
      {
        return *(ForceMoveDuringCastType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_ForceMoveType));
      }
      [param: In] set
      {
        *(ForceMoveDuringCastType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_ForceMoveType)) = value;
      }
    }

    public unsafe bool OnlyForceMoveIfAnyMoveInput
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_OnlyForceMoveIfAnyMoveInput));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_OnlyForceMoveIfAnyMoveInput)) = value;
      }
    }

    public unsafe bool IgnoreMovementImpair
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_IgnoreMovementImpair));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_IgnoreMovementImpair)) = value;
      }
    }

    public unsafe bool IgnoreMovementSpeedChanges
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_IgnoreMovementSpeedChanges));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveDuringCastComponent.NativeFieldInfoPtr_IgnoreMovementSpeedChanges)) = value;
      }
    }
  }
}
