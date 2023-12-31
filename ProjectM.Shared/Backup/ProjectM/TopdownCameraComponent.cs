// Decompiled with JetBrains decompiler
// Type: ProjectM.TopdownCameraComponent
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
  public class TopdownCameraComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_LerpEnabled;
    private static readonly IntPtr NativeFieldInfoPtr_PositionLerpStrength;
    private static readonly IntPtr NativeFieldInfoPtr_ZoomLerpStrength;
    private static readonly IntPtr NativeFieldInfoPtr_StandardMinZoom;
    private static readonly IntPtr NativeFieldInfoPtr_StandardMaxZoom;
    private static readonly IntPtr NativeFieldInfoPtr_StandardMaxPitch;
    private static readonly IntPtr NativeFieldInfoPtr_StandardMinPitch;
    private static readonly IntPtr NativeFieldInfoPtr_StandardZoomDistance;
    private static readonly IntPtr NativeFieldInfoPtr_StartPitchPercent;
    private static readonly IntPtr NativeFieldInfoPtr_BuildZoomEnabled;
    private static readonly IntPtr NativeFieldInfoPtr_BuildModeMinZoom;
    private static readonly IntPtr NativeFieldInfoPtr_BuildModeMaxZoom;
    private static readonly IntPtr NativeFieldInfoPtr_BuildModeMaxPitch;
    private static readonly IntPtr NativeFieldInfoPtr_BuildModeMinPitch;
    private static readonly IntPtr NativeFieldInfoPtr_BuildModeZoomDistance;
    private static readonly IntPtr NativeFieldInfoPtr_EnableMousePanning;
    private static readonly IntPtr NativeFieldInfoPtr_LerpMousePan;
    private static readonly IntPtr NativeFieldInfoPtr_MousePanLerpStrength;
    private static readonly IntPtr NativeFieldInfoPtr_RotateBehaviour;
    private static readonly IntPtr NativeFieldInfoPtr_MouseAffectionCurve;
    private static readonly IntPtr NativeFieldInfoPtr_MaxMouseOffsetDistance;
    private static readonly IntPtr NativeFieldInfoPtr_HorizontalFloatiness;
    private static readonly IntPtr NativeFieldInfoPtr_LookAtHeight;
    private static readonly IntPtr NativeFieldInfoPtr_RotationSpeedYaw_MinSensitivity;
    private static readonly IntPtr NativeFieldInfoPtr_RotationSpeedYaw_MaxSensitivity;
    private static readonly IntPtr NativeFieldInfoPtr_RotationSpeedPitch_MinSensitivity;
    private static readonly IntPtr NativeFieldInfoPtr_RotationSpeedPitch_MaxSensitivity;
    private static readonly IntPtr NativeFieldInfoPtr_ControllerRotationSpeedYaw_MinSensitivity;
    private static readonly IntPtr NativeFieldInfoPtr_ControllerRotationSpeedYaw_MaxSensitivity;
    private static readonly IntPtr NativeFieldInfoPtr_ControllerRotationSpeedPitch_MinSensitivity;
    private static readonly IntPtr NativeFieldInfoPtr_ControllerRotationSpeedPitch_MaxSensitivity;
    private static readonly IntPtr NativeFieldInfoPtr_CameraSensitivityCurve;
    private static readonly IntPtr NativeFieldInfoPtr_ZoomSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_PitchStartZoomFraction;
    private static readonly IntPtr NativeFieldInfoPtr_ToggleCameraSetting;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateInstance_Private_Void_byref_TopdownCamera_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateInstanceState_Private_Void_byref_TopdownCameraState_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722759, XrefRangeEnd = 722768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(TopdownCameraComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void UpdateInstance(ref TopdownCamera component)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) ref component;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TopdownCameraComponent.NativeMethodInfoPtr_UpdateInstance_Private_Void_byref_TopdownCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void UpdateInstanceState(ref TopdownCameraState component)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) ref component;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TopdownCameraComponent.NativeMethodInfoPtr_UpdateInstanceState_Private_Void_byref_TopdownCameraState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722768, XrefRangeEnd = 722769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TopdownCameraComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TopdownCameraComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TopdownCameraComponent()
    {
      Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TopdownCameraComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr);
      TopdownCameraComponent.NativeFieldInfoPtr_LerpEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (LerpEnabled));
      TopdownCameraComponent.NativeFieldInfoPtr_PositionLerpStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (PositionLerpStrength));
      TopdownCameraComponent.NativeFieldInfoPtr_ZoomLerpStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (ZoomLerpStrength));
      TopdownCameraComponent.NativeFieldInfoPtr_StandardMinZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (StandardMinZoom));
      TopdownCameraComponent.NativeFieldInfoPtr_StandardMaxZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (StandardMaxZoom));
      TopdownCameraComponent.NativeFieldInfoPtr_StandardMaxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (StandardMaxPitch));
      TopdownCameraComponent.NativeFieldInfoPtr_StandardMinPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (StandardMinPitch));
      TopdownCameraComponent.NativeFieldInfoPtr_StandardZoomDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (StandardZoomDistance));
      TopdownCameraComponent.NativeFieldInfoPtr_StartPitchPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (StartPitchPercent));
      TopdownCameraComponent.NativeFieldInfoPtr_BuildZoomEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (BuildZoomEnabled));
      TopdownCameraComponent.NativeFieldInfoPtr_BuildModeMinZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (BuildModeMinZoom));
      TopdownCameraComponent.NativeFieldInfoPtr_BuildModeMaxZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (BuildModeMaxZoom));
      TopdownCameraComponent.NativeFieldInfoPtr_BuildModeMaxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (BuildModeMaxPitch));
      TopdownCameraComponent.NativeFieldInfoPtr_BuildModeMinPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (BuildModeMinPitch));
      TopdownCameraComponent.NativeFieldInfoPtr_BuildModeZoomDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (BuildModeZoomDistance));
      TopdownCameraComponent.NativeFieldInfoPtr_EnableMousePanning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (EnableMousePanning));
      TopdownCameraComponent.NativeFieldInfoPtr_LerpMousePan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (LerpMousePan));
      TopdownCameraComponent.NativeFieldInfoPtr_MousePanLerpStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (MousePanLerpStrength));
      TopdownCameraComponent.NativeFieldInfoPtr_RotateBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (RotateBehaviour));
      TopdownCameraComponent.NativeFieldInfoPtr_MouseAffectionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (MouseAffectionCurve));
      TopdownCameraComponent.NativeFieldInfoPtr_MaxMouseOffsetDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (MaxMouseOffsetDistance));
      TopdownCameraComponent.NativeFieldInfoPtr_HorizontalFloatiness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (HorizontalFloatiness));
      TopdownCameraComponent.NativeFieldInfoPtr_LookAtHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (LookAtHeight));
      TopdownCameraComponent.NativeFieldInfoPtr_RotationSpeedYaw_MinSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (RotationSpeedYaw_MinSensitivity));
      TopdownCameraComponent.NativeFieldInfoPtr_RotationSpeedYaw_MaxSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (RotationSpeedYaw_MaxSensitivity));
      TopdownCameraComponent.NativeFieldInfoPtr_RotationSpeedPitch_MinSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (RotationSpeedPitch_MinSensitivity));
      TopdownCameraComponent.NativeFieldInfoPtr_RotationSpeedPitch_MaxSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (RotationSpeedPitch_MaxSensitivity));
      TopdownCameraComponent.NativeFieldInfoPtr_ControllerRotationSpeedYaw_MinSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (ControllerRotationSpeedYaw_MinSensitivity));
      TopdownCameraComponent.NativeFieldInfoPtr_ControllerRotationSpeedYaw_MaxSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (ControllerRotationSpeedYaw_MaxSensitivity));
      TopdownCameraComponent.NativeFieldInfoPtr_ControllerRotationSpeedPitch_MinSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (ControllerRotationSpeedPitch_MinSensitivity));
      TopdownCameraComponent.NativeFieldInfoPtr_ControllerRotationSpeedPitch_MaxSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (ControllerRotationSpeedPitch_MaxSensitivity));
      TopdownCameraComponent.NativeFieldInfoPtr_CameraSensitivityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (CameraSensitivityCurve));
      TopdownCameraComponent.NativeFieldInfoPtr_ZoomSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (ZoomSpeed));
      TopdownCameraComponent.NativeFieldInfoPtr_PitchStartZoomFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (PitchStartZoomFraction));
      TopdownCameraComponent.NativeFieldInfoPtr_ToggleCameraSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, nameof (ToggleCameraSetting));
      TopdownCameraComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, 100663840);
      TopdownCameraComponent.NativeMethodInfoPtr_UpdateInstance_Private_Void_byref_TopdownCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, 100663841);
      TopdownCameraComponent.NativeMethodInfoPtr_UpdateInstanceState_Private_Void_byref_TopdownCameraState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, 100663842);
      TopdownCameraComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopdownCameraComponent>.NativeClassPtr, 100663843);
    }

    public TopdownCameraComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool LerpEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_LerpEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_LerpEnabled)) = value;
      }
    }

    public unsafe float PositionLerpStrength
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_PositionLerpStrength));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_PositionLerpStrength)) = value;
      }
    }

    public unsafe float ZoomLerpStrength
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_ZoomLerpStrength));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_ZoomLerpStrength)) = value;
      }
    }

    public unsafe float StandardMinZoom
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_StandardMinZoom));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_StandardMinZoom)) = value;
      }
    }

    public unsafe float StandardMaxZoom
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_StandardMaxZoom));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_StandardMaxZoom)) = value;
      }
    }

    public unsafe float StandardMaxPitch
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_StandardMaxPitch));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_StandardMaxPitch)) = value;
      }
    }

    public unsafe float StandardMinPitch
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_StandardMinPitch));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_StandardMinPitch)) = value;
      }
    }

    public unsafe float StandardZoomDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_StandardZoomDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_StandardZoomDistance)) = value;
      }
    }

    public unsafe float StartPitchPercent
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_StartPitchPercent));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_StartPitchPercent)) = value;
      }
    }

    public unsafe bool BuildZoomEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_BuildZoomEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_BuildZoomEnabled)) = value;
      }
    }

    public unsafe float BuildModeMinZoom
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_BuildModeMinZoom));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_BuildModeMinZoom)) = value;
      }
    }

    public unsafe float BuildModeMaxZoom
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_BuildModeMaxZoom));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_BuildModeMaxZoom)) = value;
      }
    }

    public unsafe float BuildModeMaxPitch
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_BuildModeMaxPitch));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_BuildModeMaxPitch)) = value;
      }
    }

    public unsafe float BuildModeMinPitch
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_BuildModeMinPitch));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_BuildModeMinPitch)) = value;
      }
    }

    public unsafe float BuildModeZoomDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_BuildModeZoomDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_BuildModeZoomDistance)) = value;
      }
    }

    public unsafe bool EnableMousePanning
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_EnableMousePanning));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_EnableMousePanning)) = value;
      }
    }

    public unsafe bool LerpMousePan
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_LerpMousePan));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_LerpMousePan)) = value;
      }
    }

    public unsafe float MousePanLerpStrength
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_MousePanLerpStrength));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_MousePanLerpStrength)) = value;
      }
    }

    public unsafe MousePanRotateBehaviour RotateBehaviour
    {
      get
      {
        return *(MousePanRotateBehaviour*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_RotateBehaviour));
      }
      [param: In] set
      {
        *(MousePanRotateBehaviour*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_RotateBehaviour)) = value;
      }
    }

    public unsafe CurveData MouseAffectionCurve
    {
      get
      {
        return *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_MouseAffectionCurve));
      }
      [param: In] set
      {
        *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_MouseAffectionCurve)) = value;
      }
    }

    public unsafe float MaxMouseOffsetDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_MaxMouseOffsetDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_MaxMouseOffsetDistance)) = value;
      }
    }

    public unsafe float HorizontalFloatiness
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_HorizontalFloatiness));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_HorizontalFloatiness)) = value;
      }
    }

    public unsafe float LookAtHeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_LookAtHeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_LookAtHeight)) = value;
      }
    }

    public unsafe float RotationSpeedYaw_MinSensitivity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_RotationSpeedYaw_MinSensitivity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_RotationSpeedYaw_MinSensitivity)) = value;
      }
    }

    public unsafe float RotationSpeedYaw_MaxSensitivity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_RotationSpeedYaw_MaxSensitivity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_RotationSpeedYaw_MaxSensitivity)) = value;
      }
    }

    public unsafe float RotationSpeedPitch_MinSensitivity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_RotationSpeedPitch_MinSensitivity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_RotationSpeedPitch_MinSensitivity)) = value;
      }
    }

    public unsafe float RotationSpeedPitch_MaxSensitivity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_RotationSpeedPitch_MaxSensitivity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_RotationSpeedPitch_MaxSensitivity)) = value;
      }
    }

    public unsafe float ControllerRotationSpeedYaw_MinSensitivity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_ControllerRotationSpeedYaw_MinSensitivity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_ControllerRotationSpeedYaw_MinSensitivity)) = value;
      }
    }

    public unsafe float ControllerRotationSpeedYaw_MaxSensitivity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_ControllerRotationSpeedYaw_MaxSensitivity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_ControllerRotationSpeedYaw_MaxSensitivity)) = value;
      }
    }

    public unsafe float ControllerRotationSpeedPitch_MinSensitivity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_ControllerRotationSpeedPitch_MinSensitivity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_ControllerRotationSpeedPitch_MinSensitivity)) = value;
      }
    }

    public unsafe float ControllerRotationSpeedPitch_MaxSensitivity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_ControllerRotationSpeedPitch_MaxSensitivity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_ControllerRotationSpeedPitch_MaxSensitivity)) = value;
      }
    }

    public unsafe CurveData CameraSensitivityCurve
    {
      get
      {
        return *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_CameraSensitivityCurve));
      }
      [param: In] set
      {
        *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_CameraSensitivityCurve)) = value;
      }
    }

    public unsafe float ZoomSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_ZoomSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_ZoomSpeed)) = value;
      }
    }

    public unsafe float PitchStartZoomFraction
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_PitchStartZoomFraction));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TopdownCameraComponent.NativeFieldInfoPtr_PitchStartZoomFraction)) = value;
      }
    }

    public static unsafe bool ToggleCameraSetting
    {
      get
      {
        bool toggleCameraSetting;
        IL2CPP.il2cpp_field_static_get_value(TopdownCameraComponent.NativeFieldInfoPtr_ToggleCameraSetting, (void*) &toggleCameraSetting);
        return toggleCameraSetting;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TopdownCameraComponent.NativeFieldInfoPtr_ToggleCameraSetting, (void*) &value);
      }
    }
  }
}
