// Decompiled with JetBrains decompiler
// Type: ProjectM.RotateAroundAxisAuthoring
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
  public class RotateAroundAxisAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_CurveDuration;
    private static readonly IntPtr NativeFieldInfoPtr_Axis;
    private static readonly IntPtr NativeFieldInfoPtr_RotationCurve;
    private static readonly IntPtr NativeFieldInfoPtr_EnableTestMode;
    private static readonly IntPtr NativeFieldInfoPtr__WasTesting;
    private static readonly IntPtr NativeFieldInfoPtr__OriginalRotation;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RotateAroundAxisAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RotateAroundAxisAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RotateAroundAxisAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RotateAroundAxisAuthoring()
    {
      Il2CppClassPointerStore<RotateAroundAxisAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RotateAroundAxisAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotateAroundAxisAuthoring>.NativeClassPtr);
      RotateAroundAxisAuthoring.NativeFieldInfoPtr_CurveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateAroundAxisAuthoring>.NativeClassPtr, nameof (CurveDuration));
      RotateAroundAxisAuthoring.NativeFieldInfoPtr_Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateAroundAxisAuthoring>.NativeClassPtr, nameof (Axis));
      RotateAroundAxisAuthoring.NativeFieldInfoPtr_RotationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateAroundAxisAuthoring>.NativeClassPtr, nameof (RotationCurve));
      RotateAroundAxisAuthoring.NativeFieldInfoPtr_EnableTestMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateAroundAxisAuthoring>.NativeClassPtr, nameof (EnableTestMode));
      RotateAroundAxisAuthoring.NativeFieldInfoPtr__WasTesting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateAroundAxisAuthoring>.NativeClassPtr, nameof (_WasTesting));
      RotateAroundAxisAuthoring.NativeFieldInfoPtr__OriginalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateAroundAxisAuthoring>.NativeClassPtr, nameof (_OriginalRotation));
      RotateAroundAxisAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAroundAxisAuthoring>.NativeClassPtr, 100683829);
    }

    public RotateAroundAxisAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float CurveDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateAroundAxisAuthoring.NativeFieldInfoPtr_CurveDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateAroundAxisAuthoring.NativeFieldInfoPtr_CurveDuration)) = value;
      }
    }

    public unsafe Axis Axis
    {
      get
      {
        return *(Axis*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateAroundAxisAuthoring.NativeFieldInfoPtr_Axis));
      }
      [param: In] set
      {
        *(Axis*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateAroundAxisAuthoring.NativeFieldInfoPtr_Axis)) = value;
      }
    }

    public unsafe CurveData RotationCurve
    {
      get
      {
        return *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateAroundAxisAuthoring.NativeFieldInfoPtr_RotationCurve));
      }
      [param: In] set
      {
        *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateAroundAxisAuthoring.NativeFieldInfoPtr_RotationCurve)) = value;
      }
    }

    public unsafe bool EnableTestMode
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateAroundAxisAuthoring.NativeFieldInfoPtr_EnableTestMode));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateAroundAxisAuthoring.NativeFieldInfoPtr_EnableTestMode)) = value;
      }
    }

    public unsafe bool _WasTesting
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateAroundAxisAuthoring.NativeFieldInfoPtr__WasTesting));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateAroundAxisAuthoring.NativeFieldInfoPtr__WasTesting)) = value;
      }
    }

    public unsafe Quaternion _OriginalRotation
    {
      get
      {
        return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateAroundAxisAuthoring.NativeFieldInfoPtr__OriginalRotation));
      }
      [param: In] set
      {
        *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateAroundAxisAuthoring.NativeFieldInfoPtr__OriginalRotation)) = value;
      }
    }
  }
}
