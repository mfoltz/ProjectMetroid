// Decompiled with JetBrains decompiler
// Type: ProjectM.ChangeAbilityOnGameplayEventAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ChangeAbilityOnGameplayEventAuthoring : OnGameplayEventAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_Conditional;
    private static readonly IntPtr NativeFieldInfoPtr_Target;
    private static readonly IntPtr NativeFieldInfoPtr_AbilitySlotIndex;
    private static readonly IntPtr NativeFieldInfoPtr_AbilityGroup;
    private static readonly IntPtr NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    public override unsafe GameplayEventTypeEnum GetGameplayEventType()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChangeAbilityOnGameplayEventAuthoring.NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameplayEventTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007915, XrefRangeEnd = 1007919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ChangeAbilityOnGameplayEventAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChangeAbilityOnGameplayEventAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeAbilityOnGameplayEventAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChangeAbilityOnGameplayEventAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChangeAbilityOnGameplayEventAuthoring()
    {
      Il2CppClassPointerStore<ChangeAbilityOnGameplayEventAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ChangeAbilityOnGameplayEventAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeAbilityOnGameplayEventAuthoring>.NativeClassPtr);
      ChangeAbilityOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeAbilityOnGameplayEventAuthoring>.NativeClassPtr, nameof (Conditional));
      ChangeAbilityOnGameplayEventAuthoring.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeAbilityOnGameplayEventAuthoring>.NativeClassPtr, nameof (Target));
      ChangeAbilityOnGameplayEventAuthoring.NativeFieldInfoPtr_AbilitySlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeAbilityOnGameplayEventAuthoring>.NativeClassPtr, nameof (AbilitySlotIndex));
      ChangeAbilityOnGameplayEventAuthoring.NativeFieldInfoPtr_AbilityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeAbilityOnGameplayEventAuthoring>.NativeClassPtr, nameof (AbilityGroup));
      ChangeAbilityOnGameplayEventAuthoring.NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_GameplayEventTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeAbilityOnGameplayEventAuthoring>.NativeClassPtr, 100678253);
      ChangeAbilityOnGameplayEventAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeAbilityOnGameplayEventAuthoring>.NativeClassPtr, 100678254);
      ChangeAbilityOnGameplayEventAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeAbilityOnGameplayEventAuthoring>.NativeClassPtr, 100678255);
    }

    public ChangeAbilityOnGameplayEventAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameplayConditionGroupData_Editor_Parent Conditional
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeAbilityOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional));
        return pointer == IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChangeAbilityOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ChangeAbilityTarget Target
    {
      get
      {
        return *(ChangeAbilityTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeAbilityOnGameplayEventAuthoring.NativeFieldInfoPtr_Target));
      }
      [param: In] set
      {
        *(ChangeAbilityTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeAbilityOnGameplayEventAuthoring.NativeFieldInfoPtr_Target)) = value;
      }
    }

    public unsafe int AbilitySlotIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeAbilityOnGameplayEventAuthoring.NativeFieldInfoPtr_AbilitySlotIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeAbilityOnGameplayEventAuthoring.NativeFieldInfoPtr_AbilitySlotIndex)) = value;
      }
    }

    public unsafe PrefabGuidComponent AbilityGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeAbilityOnGameplayEventAuthoring.NativeFieldInfoPtr_AbilityGroup));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChangeAbilityOnGameplayEventAuthoring.NativeFieldInfoPtr_AbilityGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
