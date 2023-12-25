// Decompiled with JetBrains decompiler
// Type: ProjectM.CreateGameplayEventOnAbilityTriggerAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class CreateGameplayEventOnAbilityTriggerAuthoring : CreateGameplayEventAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_Type;
    private static readonly IntPtr NativeFieldInfoPtr_AbilityTypes;
    private static readonly IntPtr NativeFieldInfoPtr_AbilityPrefabTargets;
    private static readonly IntPtr NativeFieldInfoPtr_Conditional;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007498, XrefRangeEnd = 1007531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventOnAbilityTriggerAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007531, XrefRangeEnd = 1007532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CreateGameplayEventOnAbilityTriggerAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateGameplayEventOnAbilityTriggerAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventOnAbilityTriggerAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CreateGameplayEventOnAbilityTriggerAuthoring()
    {
      Il2CppClassPointerStore<CreateGameplayEventOnAbilityTriggerAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CreateGameplayEventOnAbilityTriggerAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateGameplayEventOnAbilityTriggerAuthoring>.NativeClassPtr);
      CreateGameplayEventOnAbilityTriggerAuthoring.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnAbilityTriggerAuthoring>.NativeClassPtr, nameof (Type));
      CreateGameplayEventOnAbilityTriggerAuthoring.NativeFieldInfoPtr_AbilityTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnAbilityTriggerAuthoring>.NativeClassPtr, nameof (AbilityTypes));
      CreateGameplayEventOnAbilityTriggerAuthoring.NativeFieldInfoPtr_AbilityPrefabTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnAbilityTriggerAuthoring>.NativeClassPtr, nameof (AbilityPrefabTargets));
      CreateGameplayEventOnAbilityTriggerAuthoring.NativeFieldInfoPtr_Conditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnAbilityTriggerAuthoring>.NativeClassPtr, nameof (Conditional));
      CreateGameplayEventOnAbilityTriggerAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventOnAbilityTriggerAuthoring>.NativeClassPtr, 100678195);
      CreateGameplayEventOnAbilityTriggerAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventOnAbilityTriggerAuthoring>.NativeClassPtr, 100678196);
    }

    public CreateGameplayEventOnAbilityTriggerAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe AbilityTriggerEventType Type
    {
      get
      {
        return *(AbilityTriggerEventType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnAbilityTriggerAuthoring.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(AbilityTriggerEventType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnAbilityTriggerAuthoring.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe AbilityTypeFlag AbilityTypes
    {
      get
      {
        return *(AbilityTypeFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnAbilityTriggerAuthoring.NativeFieldInfoPtr_AbilityTypes));
      }
      [param: In] set
      {
        *(AbilityTypeFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnAbilityTriggerAuthoring.NativeFieldInfoPtr_AbilityTypes)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<WeakAssetReference<AbilityComponent>> AbilityPrefabTargets
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnAbilityTriggerAuthoring.NativeFieldInfoPtr_AbilityPrefabTargets));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<WeakAssetReference<AbilityComponent>>) null : new Il2CppReferenceArray<WeakAssetReference<AbilityComponent>>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnAbilityTriggerAuthoring.NativeFieldInfoPtr_AbilityPrefabTargets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameplayConditionGroupData_Editor_Parent Conditional
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnAbilityTriggerAuthoring.NativeFieldInfoPtr_Conditional));
        return pointer == IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnAbilityTriggerAuthoring.NativeFieldInfoPtr_Conditional), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
