﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.MoveStopAbilityComponent
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
  public class MoveStopAbilityComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Radius;
    private static readonly IntPtr NativeFieldInfoPtr_UnitAngle;
    private static readonly IntPtr NativeFieldInfoPtr_ResourceAngle;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996216, XrefRangeEnd = 996219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(MoveStopAbilityComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996219, XrefRangeEnd = 996220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MoveStopAbilityComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveStopAbilityComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MoveStopAbilityComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MoveStopAbilityComponent()
    {
      Il2CppClassPointerStore<MoveStopAbilityComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (MoveStopAbilityComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveStopAbilityComponent>.NativeClassPtr);
      MoveStopAbilityComponent.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveStopAbilityComponent>.NativeClassPtr, nameof (Radius));
      MoveStopAbilityComponent.NativeFieldInfoPtr_UnitAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveStopAbilityComponent>.NativeClassPtr, nameof (UnitAngle));
      MoveStopAbilityComponent.NativeFieldInfoPtr_ResourceAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveStopAbilityComponent>.NativeClassPtr, nameof (ResourceAngle));
      MoveStopAbilityComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveStopAbilityComponent>.NativeClassPtr, 100676972);
      MoveStopAbilityComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveStopAbilityComponent>.NativeClassPtr, 100676973);
    }

    public MoveStopAbilityComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Radius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveStopAbilityComponent.NativeFieldInfoPtr_Radius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveStopAbilityComponent.NativeFieldInfoPtr_Radius)) = value;
      }
    }

    public unsafe float UnitAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveStopAbilityComponent.NativeFieldInfoPtr_UnitAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveStopAbilityComponent.NativeFieldInfoPtr_UnitAngle)) = value;
      }
    }

    public unsafe float ResourceAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveStopAbilityComponent.NativeFieldInfoPtr_ResourceAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveStopAbilityComponent.NativeFieldInfoPtr_ResourceAngle)) = value;
      }
    }
  }
}
