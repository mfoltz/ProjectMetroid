﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityDPSComponent
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
  public class AbilityDPSComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_DPSWeight;
    private static readonly IntPtr NativeFieldInfoPtr_DamageModifierSettings;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995794, XrefRangeEnd = 995803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(AbilityDPSComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 724616, RefRangeEnd = 724620, XrefRangeStart = 724616, XrefRangeEnd = 724620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityDPSComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityDPSComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityDPSComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityDPSComponent()
    {
      Il2CppClassPointerStore<AbilityDPSComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AbilityDPSComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityDPSComponent>.NativeClassPtr);
      AbilityDPSComponent.NativeFieldInfoPtr_DPSWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDPSComponent>.NativeClassPtr, nameof (DPSWeight));
      AbilityDPSComponent.NativeFieldInfoPtr_DamageModifierSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDPSComponent>.NativeClassPtr, nameof (DamageModifierSettings));
      AbilityDPSComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDPSComponent>.NativeClassPtr, 100676898);
      AbilityDPSComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDPSComponent>.NativeClassPtr, 100676899);
    }

    public AbilityDPSComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float DPSWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityDPSComponent.NativeFieldInfoPtr_DPSWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityDPSComponent.NativeFieldInfoPtr_DPSWeight)) = value;
      }
    }

    public unsafe DamageModifierSettings DamageModifierSettings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityDPSComponent.NativeFieldInfoPtr_DamageModifierSettings));
        return pointer == IntPtr.Zero ? (DamageModifierSettings) null : new DamageModifierSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityDPSComponent.NativeFieldInfoPtr_DamageModifierSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}