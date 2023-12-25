// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifyBloodDrainBuffComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Scripting;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ModifyBloodDrainBuffComponent : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_AffectBloodValue;
    private static readonly IntPtr NativeFieldInfoPtr_BloodValue;
    private static readonly IntPtr NativeFieldInfoPtr_ModificationType;
    private static readonly IntPtr NativeFieldInfoPtr_ModificationPriority;
    private static readonly IntPtr NativeFieldInfoPtr_AffectIdleBloodValue;
    private static readonly IntPtr NativeFieldInfoPtr_BloodIdleValue;
    private static readonly IntPtr NativeFieldInfoPtr_ModificationIdleType;
    private static readonly IntPtr NativeFieldInfoPtr_ModificationIdlePriority;
    private static readonly IntPtr NativeFieldInfoPtr_IgnoreIdleDrainWhileActive;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024597, XrefRangeEnd = 1024602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Convert(
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ModifyBloodDrainBuffComponent.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024602, XrefRangeEnd = 1024606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ModifyBloodDrainBuffComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024606, XrefRangeEnd = 1024607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ModifyBloodDrainBuffComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifyBloodDrainBuffComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifyBloodDrainBuffComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ModifyBloodDrainBuffComponent()
    {
      Il2CppClassPointerStore<ModifyBloodDrainBuffComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ModifyBloodDrainBuffComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyBloodDrainBuffComponent>.NativeClassPtr);
      ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_AffectBloodValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBloodDrainBuffComponent>.NativeClassPtr, nameof (AffectBloodValue));
      ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_BloodValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBloodDrainBuffComponent>.NativeClassPtr, nameof (BloodValue));
      ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_ModificationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBloodDrainBuffComponent>.NativeClassPtr, nameof (ModificationType));
      ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_ModificationPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBloodDrainBuffComponent>.NativeClassPtr, nameof (ModificationPriority));
      ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_AffectIdleBloodValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBloodDrainBuffComponent>.NativeClassPtr, nameof (AffectIdleBloodValue));
      ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_BloodIdleValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBloodDrainBuffComponent>.NativeClassPtr, nameof (BloodIdleValue));
      ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_ModificationIdleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBloodDrainBuffComponent>.NativeClassPtr, nameof (ModificationIdleType));
      ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_ModificationIdlePriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBloodDrainBuffComponent>.NativeClassPtr, nameof (ModificationIdlePriority));
      ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_IgnoreIdleDrainWhileActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyBloodDrainBuffComponent>.NativeClassPtr, nameof (IgnoreIdleDrainWhileActive));
      ModifyBloodDrainBuffComponent.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyBloodDrainBuffComponent>.NativeClassPtr, 100680036);
      ModifyBloodDrainBuffComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyBloodDrainBuffComponent>.NativeClassPtr, 100680037);
      ModifyBloodDrainBuffComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyBloodDrainBuffComponent>.NativeClassPtr, 100680038);
    }

    public ModifyBloodDrainBuffComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool AffectBloodValue
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_AffectBloodValue));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_AffectBloodValue)) = value;
      }
    }

    public unsafe float BloodValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_BloodValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_BloodValue)) = value;
      }
    }

    public unsafe ModificationType_Editor ModificationType
    {
      get
      {
        return *(ModificationType_Editor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_ModificationType));
      }
      [param: In] set
      {
        *(ModificationType_Editor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_ModificationType)) = value;
      }
    }

    public unsafe int ModificationPriority
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_ModificationPriority));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_ModificationPriority)) = value;
      }
    }

    public unsafe bool AffectIdleBloodValue
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_AffectIdleBloodValue));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_AffectIdleBloodValue)) = value;
      }
    }

    public unsafe float BloodIdleValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_BloodIdleValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_BloodIdleValue)) = value;
      }
    }

    public unsafe ModificationType_Editor ModificationIdleType
    {
      get
      {
        return *(ModificationType_Editor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_ModificationIdleType));
      }
      [param: In] set
      {
        *(ModificationType_Editor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_ModificationIdleType)) = value;
      }
    }

    public unsafe int ModificationIdlePriority
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_ModificationIdlePriority));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_ModificationIdlePriority)) = value;
      }
    }

    public unsafe bool IgnoreIdleDrainWhileActive
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_IgnoreIdleDrainWhileActive));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyBloodDrainBuffComponent.NativeFieldInfoPtr_IgnoreIdleDrainWhileActive)) = value;
      }
    }
  }
}
