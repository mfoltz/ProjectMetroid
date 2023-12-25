// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.RotateTowardsCamera
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
namespace ProjectM.Presentation
{
  public class RotateTowardsCamera : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_EulerOffset;
    private static readonly IntPtr NativeFieldInfoPtr_RotationMode;
    private static readonly IntPtr NativeFieldInfoPtr__Camera;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112852, XrefRangeEnd = 1112879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RotateTowardsCamera.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RotateTowardsCamera()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RotateTowardsCamera>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RotateTowardsCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RotateTowardsCamera()
    {
      Il2CppClassPointerStore<RotateTowardsCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (RotateTowardsCamera));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotateTowardsCamera>.NativeClassPtr);
      RotateTowardsCamera.NativeFieldInfoPtr_EulerOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsCamera>.NativeClassPtr, nameof (EulerOffset));
      RotateTowardsCamera.NativeFieldInfoPtr_RotationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsCamera>.NativeClassPtr, nameof (RotationMode));
      RotateTowardsCamera.NativeFieldInfoPtr__Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateTowardsCamera>.NativeClassPtr, nameof (_Camera));
      RotateTowardsCamera.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateTowardsCamera>.NativeClassPtr, 100688097);
      RotateTowardsCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateTowardsCamera>.NativeClassPtr, 100688098);
    }

    public RotateTowardsCamera(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Vector3 EulerOffset
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateTowardsCamera.NativeFieldInfoPtr_EulerOffset));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateTowardsCamera.NativeFieldInfoPtr_EulerOffset)) = value;
      }
    }

    public unsafe RotateTowardsCamera.RotationModeEnum RotationMode
    {
      get
      {
        return *(RotateTowardsCamera.RotationModeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateTowardsCamera.NativeFieldInfoPtr_RotationMode));
      }
      [param: In] set
      {
        *(RotateTowardsCamera.RotationModeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateTowardsCamera.NativeFieldInfoPtr_RotationMode)) = value;
      }
    }

    public unsafe Camera _Camera
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RotateTowardsCamera.NativeFieldInfoPtr__Camera));
        return pointer == IntPtr.Zero ? (Camera) null : new Camera(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RotateTowardsCamera.NativeFieldInfoPtr__Camera), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public enum RotationModeEnum
    {
      FaceCameraPosition,
      FaceCameraPositionLockY,
      FaceCameraDirection,
      FaceCameraDirectionLockY,
    }
  }
}
