// Decompiled with JetBrains decompiler
// Type: ProjectM.OrbitCameraComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

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
  public class OrbitCameraComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_DefaultYaw;
    private static readonly IntPtr NativeFieldInfoPtr_DefaultPitch;
    private static readonly IntPtr NativeFieldInfoPtr_LerpEnabled;
    private static readonly IntPtr NativeFieldInfoPtr_PositionLerpStrength;
    private static readonly IntPtr NativeFieldInfoPtr_ZoomLerpStrength;
    private static readonly IntPtr NativeFieldInfoPtr_OrbitRotationLerpStrength;
    private static readonly IntPtr NativeFieldInfoPtr_AnchorRotationLerpStrength;
    private static readonly IntPtr NativeFieldInfoPtr_MouseRotationSensitivity;
    private static readonly IntPtr NativeFieldInfoPtr_OverTheShoulderSensitivity;
    private static readonly IntPtr NativeFieldInfoPtr_AutoRotationSensitivity;
    private static readonly IntPtr NativeFieldInfoPtr_AnchorHeightSensitivity;
    private static readonly IntPtr NativeFieldInfoPtr_MinZoom;
    private static readonly IntPtr NativeFieldInfoPtr_MaxZoom;
    private static readonly IntPtr NativeFieldInfoPtr_MinPitch;
    private static readonly IntPtr NativeFieldInfoPtr_MaxPitch;
    private static readonly IntPtr NativeFieldInfoPtr_ZoomSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_DefaultZoomDistance;
    private static readonly IntPtr NativeFieldInfoPtr_AnchorHeightOffset;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722718, XrefRangeEnd = 722744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(OrbitCameraComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722744, XrefRangeEnd = 722745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OrbitCameraComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrbitCameraComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OrbitCameraComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static OrbitCameraComponent()
    {
      Il2CppClassPointerStore<OrbitCameraComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (OrbitCameraComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrbitCameraComponent>.NativeClassPtr);
      OrbitCameraComponent.NativeFieldInfoPtr_DefaultYaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraComponent>.NativeClassPtr, nameof (DefaultYaw));
      OrbitCameraComponent.NativeFieldInfoPtr_DefaultPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraComponent>.NativeClassPtr, nameof (DefaultPitch));
      OrbitCameraComponent.NativeFieldInfoPtr_LerpEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraComponent>.NativeClassPtr, nameof (LerpEnabled));
      OrbitCameraComponent.NativeFieldInfoPtr_PositionLerpStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraComponent>.NativeClassPtr, nameof (PositionLerpStrength));
      OrbitCameraComponent.NativeFieldInfoPtr_ZoomLerpStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraComponent>.NativeClassPtr, nameof (ZoomLerpStrength));
      OrbitCameraComponent.NativeFieldInfoPtr_OrbitRotationLerpStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraComponent>.NativeClassPtr, nameof (OrbitRotationLerpStrength));
      OrbitCameraComponent.NativeFieldInfoPtr_AnchorRotationLerpStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraComponent>.NativeClassPtr, nameof (AnchorRotationLerpStrength));
      OrbitCameraComponent.NativeFieldInfoPtr_MouseRotationSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraComponent>.NativeClassPtr, nameof (MouseRotationSensitivity));
      OrbitCameraComponent.NativeFieldInfoPtr_OverTheShoulderSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraComponent>.NativeClassPtr, nameof (OverTheShoulderSensitivity));
      OrbitCameraComponent.NativeFieldInfoPtr_AutoRotationSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraComponent>.NativeClassPtr, nameof (AutoRotationSensitivity));
      OrbitCameraComponent.NativeFieldInfoPtr_AnchorHeightSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraComponent>.NativeClassPtr, nameof (AnchorHeightSensitivity));
      OrbitCameraComponent.NativeFieldInfoPtr_MinZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraComponent>.NativeClassPtr, nameof (MinZoom));
      OrbitCameraComponent.NativeFieldInfoPtr_MaxZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraComponent>.NativeClassPtr, nameof (MaxZoom));
      OrbitCameraComponent.NativeFieldInfoPtr_MinPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraComponent>.NativeClassPtr, nameof (MinPitch));
      OrbitCameraComponent.NativeFieldInfoPtr_MaxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraComponent>.NativeClassPtr, nameof (MaxPitch));
      OrbitCameraComponent.NativeFieldInfoPtr_ZoomSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraComponent>.NativeClassPtr, nameof (ZoomSpeed));
      OrbitCameraComponent.NativeFieldInfoPtr_DefaultZoomDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraComponent>.NativeClassPtr, nameof (DefaultZoomDistance));
      OrbitCameraComponent.NativeFieldInfoPtr_AnchorHeightOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCameraComponent>.NativeClassPtr, nameof (AnchorHeightOffset));
      OrbitCameraComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCameraComponent>.NativeClassPtr, 100663837);
      OrbitCameraComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCameraComponent>.NativeClassPtr, 100663838);
    }

    public OrbitCameraComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float DefaultYaw
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_DefaultYaw));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_DefaultYaw)) = value;
      }
    }

    public unsafe float DefaultPitch
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_DefaultPitch));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_DefaultPitch)) = value;
      }
    }

    public unsafe bool LerpEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_LerpEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_LerpEnabled)) = value;
      }
    }

    public unsafe float PositionLerpStrength
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_PositionLerpStrength));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_PositionLerpStrength)) = value;
      }
    }

    public unsafe float ZoomLerpStrength
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_ZoomLerpStrength));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_ZoomLerpStrength)) = value;
      }
    }

    public unsafe float OrbitRotationLerpStrength
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_OrbitRotationLerpStrength));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_OrbitRotationLerpStrength)) = value;
      }
    }

    public unsafe float AnchorRotationLerpStrength
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_AnchorRotationLerpStrength));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_AnchorRotationLerpStrength)) = value;
      }
    }

    public unsafe float MouseRotationSensitivity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_MouseRotationSensitivity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_MouseRotationSensitivity)) = value;
      }
    }

    public unsafe float OverTheShoulderSensitivity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_OverTheShoulderSensitivity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_OverTheShoulderSensitivity)) = value;
      }
    }

    public unsafe float AutoRotationSensitivity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_AutoRotationSensitivity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_AutoRotationSensitivity)) = value;
      }
    }

    public unsafe float AnchorHeightSensitivity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_AnchorHeightSensitivity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_AnchorHeightSensitivity)) = value;
      }
    }

    public unsafe float MinZoom
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_MinZoom));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_MinZoom)) = value;
      }
    }

    public unsafe float MaxZoom
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_MaxZoom));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_MaxZoom)) = value;
      }
    }

    public unsafe float MinPitch
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_MinPitch));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_MinPitch)) = value;
      }
    }

    public unsafe float MaxPitch
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_MaxPitch));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_MaxPitch)) = value;
      }
    }

    public unsafe float ZoomSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_ZoomSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_ZoomSpeed)) = value;
      }
    }

    public unsafe float DefaultZoomDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_DefaultZoomDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_DefaultZoomDistance)) = value;
      }
    }

    public unsafe float AnchorHeightOffset
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_AnchorHeightOffset));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrbitCameraComponent.NativeFieldInfoPtr_AnchorHeightOffset)) = value;
      }
    }
  }
}
