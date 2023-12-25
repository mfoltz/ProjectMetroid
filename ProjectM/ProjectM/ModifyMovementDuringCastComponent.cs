// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifyMovementDuringCastComponent
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
  public class ModifyMovementDuringCastComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_MovementSpeedMultiplier;
    private static readonly IntPtr NativeFieldInfoPtr_InDuration;
    private static readonly IntPtr NativeFieldInfoPtr_Duration;
    private static readonly IntPtr NativeFieldInfoPtr_OutDuration;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996188, XrefRangeEnd = 996191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ModifyMovementDuringCastComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ModifyMovementDuringCastComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifyMovementDuringCastComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifyMovementDuringCastComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ModifyMovementDuringCastComponent()
    {
      Il2CppClassPointerStore<ModifyMovementDuringCastComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ModifyMovementDuringCastComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyMovementDuringCastComponent>.NativeClassPtr);
      ModifyMovementDuringCastComponent.NativeFieldInfoPtr_MovementSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyMovementDuringCastComponent>.NativeClassPtr, nameof (MovementSpeedMultiplier));
      ModifyMovementDuringCastComponent.NativeFieldInfoPtr_InDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyMovementDuringCastComponent>.NativeClassPtr, nameof (InDuration));
      ModifyMovementDuringCastComponent.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyMovementDuringCastComponent>.NativeClassPtr, nameof (Duration));
      ModifyMovementDuringCastComponent.NativeFieldInfoPtr_OutDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyMovementDuringCastComponent>.NativeClassPtr, nameof (OutDuration));
      ModifyMovementDuringCastComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyMovementDuringCastComponent>.NativeClassPtr, 100676963);
      ModifyMovementDuringCastComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyMovementDuringCastComponent>.NativeClassPtr, 100676964);
    }

    public ModifyMovementDuringCastComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float MovementSpeedMultiplier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementDuringCastComponent.NativeFieldInfoPtr_MovementSpeedMultiplier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementDuringCastComponent.NativeFieldInfoPtr_MovementSpeedMultiplier)) = value;
      }
    }

    public unsafe float InDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementDuringCastComponent.NativeFieldInfoPtr_InDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementDuringCastComponent.NativeFieldInfoPtr_InDuration)) = value;
      }
    }

    public unsafe float Duration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementDuringCastComponent.NativeFieldInfoPtr_Duration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementDuringCastComponent.NativeFieldInfoPtr_Duration)) = value;
      }
    }

    public unsafe float OutDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementDuringCastComponent.NativeFieldInfoPtr_OutDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementDuringCastComponent.NativeFieldInfoPtr_OutDuration)) = value;
      }
    }
  }
}
