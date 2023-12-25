// Decompiled with JetBrains decompiler
// Type: ProjectM.RotateTowardsAimDirectionDuringCastComponent
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
  public class RotateTowardsAimDirectionDuringCastComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ExcludePostCastDuration;
    private static readonly IntPtr NativeFieldInfoPtr_UseManualDuration;
    private static readonly IntPtr NativeFieldInfoPtr_ManualDuration;
    private static readonly IntPtr NativeFieldInfoPtr_Curve;
    private static readonly IntPtr NativeFieldInfoPtr_AllowTargetRotationChangeDuringCast;
    private static readonly IntPtr NativeFieldInfoPtr_Clockwise;
    private static readonly IntPtr NativeFieldInfoPtr_MinDegrees;
    private static readonly IntPtr NativeFieldInfoPtr_MaxDegrees;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996347, XrefRangeEnd = 996350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(RotateTowardsAimDirectionDuringCastComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996350, XrefRangeEnd = 996351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RotateTowardsAimDirectionDuringCastComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RotateTowardsAimDirectionDuringCastComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RotateTowardsAimDirectionDuringCastComponent()
    {
      Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RotateTowardsAimDirectionDuringCastComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastComponent>.NativeClassPtr);
      RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_ExcludePostCastDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastComponent>.NativeClassPtr, nameof (ExcludePostCastDuration));
      RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_UseManualDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastComponent>.NativeClassPtr, nameof (UseManualDuration));
      RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_ManualDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastComponent>.NativeClassPtr, nameof (ManualDuration));
      RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastComponent>.NativeClassPtr, nameof (Curve));
      RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_AllowTargetRotationChangeDuringCast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastComponent>.NativeClassPtr, nameof (AllowTargetRotationChangeDuringCast));
      RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_Clockwise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastComponent>.NativeClassPtr, nameof (Clockwise));
      RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_MinDegrees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastComponent>.NativeClassPtr, nameof (MinDegrees));
      RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_MaxDegrees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastComponent>.NativeClassPtr, nameof (MaxDegrees));
      RotateTowardsAimDirectionDuringCastComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastComponent>.NativeClassPtr, 100676996);
      RotateTowardsAimDirectionDuringCastComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateTowardsAimDirectionDuringCastComponent>.NativeClassPtr, 100676997);
    }

    public RotateTowardsAimDirectionDuringCastComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool ExcludePostCastDuration
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_ExcludePostCastDuration));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_ExcludePostCastDuration)) = value;
      }
    }

    public unsafe bool UseManualDuration
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_UseManualDuration));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_UseManualDuration)) = value;
      }
    }

    public unsafe float ManualDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_ManualDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_ManualDuration)) = value;
      }
    }

    public unsafe CurveReference Curve
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_Curve));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_Curve)) = value;
      }
    }

    public unsafe bool AllowTargetRotationChangeDuringCast
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_AllowTargetRotationChangeDuringCast));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_AllowTargetRotationChangeDuringCast)) = value;
      }
    }

    public unsafe RotateDirectionType Clockwise
    {
      get
      {
        return *(RotateDirectionType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_Clockwise));
      }
      [param: In] set
      {
        *(RotateDirectionType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_Clockwise)) = value;
      }
    }

    public unsafe float MinDegrees
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_MinDegrees));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_MinDegrees)) = value;
      }
    }

    public unsafe float MaxDegrees
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_MaxDegrees));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateTowardsAimDirectionDuringCastComponent.NativeFieldInfoPtr_MaxDegrees)) = value;
      }
    }
  }
}
