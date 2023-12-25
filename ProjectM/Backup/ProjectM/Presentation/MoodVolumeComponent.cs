// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.MoodVolumeComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Wind;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Presentation
{
  public class MoodVolumeComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Mood;
    private static readonly IntPtr NativeFieldInfoPtr_WindZoneAsset;
    private static readonly IntPtr NativeFieldInfoPtr_SphereRadius;
    private static readonly IntPtr NativeFieldInfoPtr_BoxSize;
    private static readonly IntPtr NativeFieldInfoPtr_FadeDistance;
    private static readonly IntPtr NativeFieldInfoPtr_MoodColliderType;
    private static readonly IntPtr NativeFieldInfoPtr_SpecifyWindOverride;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112630, XrefRangeEnd = 1112677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(MoodVolumeComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112677, XrefRangeEnd = 1112705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDrawGizmos()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MoodVolumeComponent.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112705, XrefRangeEnd = 1112707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MoodVolumeComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoodVolumeComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MoodVolumeComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MoodVolumeComponent()
    {
      Il2CppClassPointerStore<MoodVolumeComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (MoodVolumeComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoodVolumeComponent>.NativeClassPtr);
      MoodVolumeComponent.NativeFieldInfoPtr_Mood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodVolumeComponent>.NativeClassPtr, nameof (Mood));
      MoodVolumeComponent.NativeFieldInfoPtr_WindZoneAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodVolumeComponent>.NativeClassPtr, nameof (WindZoneAsset));
      MoodVolumeComponent.NativeFieldInfoPtr_SphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodVolumeComponent>.NativeClassPtr, nameof (SphereRadius));
      MoodVolumeComponent.NativeFieldInfoPtr_BoxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodVolumeComponent>.NativeClassPtr, nameof (BoxSize));
      MoodVolumeComponent.NativeFieldInfoPtr_FadeDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodVolumeComponent>.NativeClassPtr, nameof (FadeDistance));
      MoodVolumeComponent.NativeFieldInfoPtr_MoodColliderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodVolumeComponent>.NativeClassPtr, nameof (MoodColliderType));
      MoodVolumeComponent.NativeFieldInfoPtr_SpecifyWindOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodVolumeComponent>.NativeClassPtr, nameof (SpecifyWindOverride));
      MoodVolumeComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoodVolumeComponent>.NativeClassPtr, 100688084);
      MoodVolumeComponent.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoodVolumeComponent>.NativeClassPtr, 100688085);
      MoodVolumeComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoodVolumeComponent>.NativeClassPtr, 100688086);
    }

    public MoodVolumeComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe MoodSetting Mood
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodVolumeComponent.NativeFieldInfoPtr_Mood));
        return pointer == IntPtr.Zero ? (MoodSetting) null : new MoodSetting(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoodVolumeComponent.NativeFieldInfoPtr_Mood), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WindZoneAsset WindZoneAsset
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodVolumeComponent.NativeFieldInfoPtr_WindZoneAsset));
        return pointer == IntPtr.Zero ? (WindZoneAsset) null : new WindZoneAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoodVolumeComponent.NativeFieldInfoPtr_WindZoneAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float SphereRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodVolumeComponent.NativeFieldInfoPtr_SphereRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodVolumeComponent.NativeFieldInfoPtr_SphereRadius)) = value;
      }
    }

    public unsafe Vector3 BoxSize
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodVolumeComponent.NativeFieldInfoPtr_BoxSize));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodVolumeComponent.NativeFieldInfoPtr_BoxSize)) = value;
      }
    }

    public unsafe float FadeDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodVolumeComponent.NativeFieldInfoPtr_FadeDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodVolumeComponent.NativeFieldInfoPtr_FadeDistance)) = value;
      }
    }

    public unsafe MoodColliderEnum MoodColliderType
    {
      get
      {
        return *(MoodColliderEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodVolumeComponent.NativeFieldInfoPtr_MoodColliderType));
      }
      [param: In] set
      {
        *(MoodColliderEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodVolumeComponent.NativeFieldInfoPtr_MoodColliderType)) = value;
      }
    }

    public unsafe bool SpecifyWindOverride
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodVolumeComponent.NativeFieldInfoPtr_SpecifyWindOverride));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodVolumeComponent.NativeFieldInfoPtr_SpecifyWindOverride)) = value;
      }
    }
  }
}
