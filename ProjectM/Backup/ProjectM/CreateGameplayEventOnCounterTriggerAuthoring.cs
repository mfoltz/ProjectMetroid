﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.CreateGameplayEventOnCounterTriggerAuthoring
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
  public class CreateGameplayEventOnCounterTriggerAuthoring : CreateGameplayEventAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_Conditional;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007532, XrefRangeEnd = 1007543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventOnCounterTriggerAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CreateGameplayEventOnCounterTriggerAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateGameplayEventOnCounterTriggerAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventOnCounterTriggerAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CreateGameplayEventOnCounterTriggerAuthoring()
    {
      Il2CppClassPointerStore<CreateGameplayEventOnCounterTriggerAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CreateGameplayEventOnCounterTriggerAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateGameplayEventOnCounterTriggerAuthoring>.NativeClassPtr);
      CreateGameplayEventOnCounterTriggerAuthoring.NativeFieldInfoPtr_Conditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnCounterTriggerAuthoring>.NativeClassPtr, nameof (Conditional));
      CreateGameplayEventOnCounterTriggerAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventOnCounterTriggerAuthoring>.NativeClassPtr, 100678197);
      CreateGameplayEventOnCounterTriggerAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventOnCounterTriggerAuthoring>.NativeClassPtr, 100678198);
    }

    public CreateGameplayEventOnCounterTriggerAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameplayConditionGroupData_Editor_Parent Conditional
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnCounterTriggerAuthoring.NativeFieldInfoPtr_Conditional));
        return pointer == IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnCounterTriggerAuthoring.NativeFieldInfoPtr_Conditional), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}