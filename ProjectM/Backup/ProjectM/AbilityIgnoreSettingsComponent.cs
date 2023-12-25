// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityIgnoreSettingsComponent
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
  public class AbilityIgnoreSettingsComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_IgnorePostCast;
    private static readonly IntPtr NativeFieldInfoPtr_IgnoreGlobalCooldown;
    private static readonly IntPtr NativeFieldInfoPtr_IgnoreAbilityImpair;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995879, XrefRangeEnd = 995882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(AbilityIgnoreSettingsComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityIgnoreSettingsComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityIgnoreSettingsComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityIgnoreSettingsComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityIgnoreSettingsComponent()
    {
      Il2CppClassPointerStore<AbilityIgnoreSettingsComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AbilityIgnoreSettingsComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityIgnoreSettingsComponent>.NativeClassPtr);
      AbilityIgnoreSettingsComponent.NativeFieldInfoPtr_IgnorePostCast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityIgnoreSettingsComponent>.NativeClassPtr, nameof (IgnorePostCast));
      AbilityIgnoreSettingsComponent.NativeFieldInfoPtr_IgnoreGlobalCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityIgnoreSettingsComponent>.NativeClassPtr, nameof (IgnoreGlobalCooldown));
      AbilityIgnoreSettingsComponent.NativeFieldInfoPtr_IgnoreAbilityImpair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityIgnoreSettingsComponent>.NativeClassPtr, nameof (IgnoreAbilityImpair));
      AbilityIgnoreSettingsComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityIgnoreSettingsComponent>.NativeClassPtr, 100676907);
      AbilityIgnoreSettingsComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityIgnoreSettingsComponent>.NativeClassPtr, 100676908);
    }

    public AbilityIgnoreSettingsComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool IgnorePostCast
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityIgnoreSettingsComponent.NativeFieldInfoPtr_IgnorePostCast));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityIgnoreSettingsComponent.NativeFieldInfoPtr_IgnorePostCast)) = value;
      }
    }

    public unsafe bool IgnoreGlobalCooldown
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityIgnoreSettingsComponent.NativeFieldInfoPtr_IgnoreGlobalCooldown));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityIgnoreSettingsComponent.NativeFieldInfoPtr_IgnoreGlobalCooldown)) = value;
      }
    }

    public unsafe bool IgnoreAbilityImpair
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityIgnoreSettingsComponent.NativeFieldInfoPtr_IgnoreAbilityImpair));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityIgnoreSettingsComponent.NativeFieldInfoPtr_IgnoreAbilityImpair)) = value;
      }
    }
  }
}
