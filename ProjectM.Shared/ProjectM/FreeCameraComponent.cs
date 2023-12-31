// Decompiled with JetBrains decompiler
// Type: ProjectM.FreeCameraComponent
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
  public class FreeCameraComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_DefaultYaw;
    private static readonly IntPtr NativeFieldInfoPtr_DefaultPitch;
    private static readonly IntPtr NativeFieldInfoPtr_BaseMovementSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_LerpEnabled;
    private static readonly IntPtr NativeFieldInfoPtr_MouseRotationSensitivity;
    private static readonly IntPtr NativeFieldInfoPtr_SpeedChangeSensitivity;
    private static readonly IntPtr NativeFieldInfoPtr_SpeedCrawlMultiplier;
    private static readonly IntPtr NativeFieldInfoPtr_SpeedBoostMultiplier;
    private static readonly IntPtr NativeFieldInfoPtr_PositionLerpStrength;
    private static readonly IntPtr NativeFieldInfoPtr_RotationLerpStrength;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722631, XrefRangeEnd = 722650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(FreeCameraComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722650, XrefRangeEnd = 722651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FreeCameraComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreeCameraComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FreeCameraComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FreeCameraComponent()
    {
      Il2CppClassPointerStore<FreeCameraComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (FreeCameraComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreeCameraComponent>.NativeClassPtr);
      FreeCameraComponent.NativeFieldInfoPtr_DefaultYaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraComponent>.NativeClassPtr, nameof (DefaultYaw));
      FreeCameraComponent.NativeFieldInfoPtr_DefaultPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraComponent>.NativeClassPtr, nameof (DefaultPitch));
      FreeCameraComponent.NativeFieldInfoPtr_BaseMovementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraComponent>.NativeClassPtr, nameof (BaseMovementSpeed));
      FreeCameraComponent.NativeFieldInfoPtr_LerpEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraComponent>.NativeClassPtr, nameof (LerpEnabled));
      FreeCameraComponent.NativeFieldInfoPtr_MouseRotationSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraComponent>.NativeClassPtr, nameof (MouseRotationSensitivity));
      FreeCameraComponent.NativeFieldInfoPtr_SpeedChangeSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraComponent>.NativeClassPtr, nameof (SpeedChangeSensitivity));
      FreeCameraComponent.NativeFieldInfoPtr_SpeedCrawlMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraComponent>.NativeClassPtr, nameof (SpeedCrawlMultiplier));
      FreeCameraComponent.NativeFieldInfoPtr_SpeedBoostMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraComponent>.NativeClassPtr, nameof (SpeedBoostMultiplier));
      FreeCameraComponent.NativeFieldInfoPtr_PositionLerpStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraComponent>.NativeClassPtr, nameof (PositionLerpStrength));
      FreeCameraComponent.NativeFieldInfoPtr_RotationLerpStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraComponent>.NativeClassPtr, nameof (RotationLerpStrength));
      FreeCameraComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeCameraComponent>.NativeClassPtr, 100663813);
      FreeCameraComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeCameraComponent>.NativeClassPtr, 100663814);
    }

    public FreeCameraComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float DefaultYaw
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeCameraComponent.NativeFieldInfoPtr_DefaultYaw));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeCameraComponent.NativeFieldInfoPtr_DefaultYaw)) = value;
      }
    }

    public unsafe float DefaultPitch
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeCameraComponent.NativeFieldInfoPtr_DefaultPitch));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeCameraComponent.NativeFieldInfoPtr_DefaultPitch)) = value;
      }
    }

    public unsafe float BaseMovementSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeCameraComponent.NativeFieldInfoPtr_BaseMovementSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeCameraComponent.NativeFieldInfoPtr_BaseMovementSpeed)) = value;
      }
    }

    public unsafe bool LerpEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeCameraComponent.NativeFieldInfoPtr_LerpEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeCameraComponent.NativeFieldInfoPtr_LerpEnabled)) = value;
      }
    }

    public unsafe float MouseRotationSensitivity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeCameraComponent.NativeFieldInfoPtr_MouseRotationSensitivity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeCameraComponent.NativeFieldInfoPtr_MouseRotationSensitivity)) = value;
      }
    }

    public unsafe float SpeedChangeSensitivity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeCameraComponent.NativeFieldInfoPtr_SpeedChangeSensitivity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeCameraComponent.NativeFieldInfoPtr_SpeedChangeSensitivity)) = value;
      }
    }

    public unsafe float SpeedCrawlMultiplier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeCameraComponent.NativeFieldInfoPtr_SpeedCrawlMultiplier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeCameraComponent.NativeFieldInfoPtr_SpeedCrawlMultiplier)) = value;
      }
    }

    public unsafe float SpeedBoostMultiplier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeCameraComponent.NativeFieldInfoPtr_SpeedBoostMultiplier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeCameraComponent.NativeFieldInfoPtr_SpeedBoostMultiplier)) = value;
      }
    }

    public unsafe float PositionLerpStrength
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeCameraComponent.NativeFieldInfoPtr_PositionLerpStrength));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeCameraComponent.NativeFieldInfoPtr_PositionLerpStrength)) = value;
      }
    }

    public unsafe float RotationLerpStrength
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeCameraComponent.NativeFieldInfoPtr_RotationLerpStrength));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeCameraComponent.NativeFieldInfoPtr_RotationLerpStrength)) = value;
      }
    }
  }
}
